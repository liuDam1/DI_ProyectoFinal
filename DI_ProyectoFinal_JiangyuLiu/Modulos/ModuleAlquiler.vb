Imports System.Data.SQLite

Module ModuleAlquiler
    ' **********************************************
    ' ** CONSULTAS SQL DE LA BASE DE DATOS **
    ' **********************************************

    ' Consulta para cargar datos en un ListView
    Private Const QUERY_CARGAR_DATOS As String = "SELECT NumeroPrestamo, NumeroSocio, NumeroPelicula, FechaPrestamo, FechaDevolucion FROM Prestamo"

    ' Consulta para obtener un alquiler por su número de préstamo
    Private Const QUERY_OBTENER_ALQUILER As String = "SELECT NumeroPrestamo, NumeroSocio, NumeroPelicula, FechaPrestamo, FechaDevolucion FROM Prestamo WHERE NumeroPrestamo = @NumeroPrestamo"

    ' Consulta para obtener el siguiente número de préstamo
    Private Const QUERY_OBTENER_SIGUIENTE_NUMERO As String = "SELECT MAX(NumeroPrestamo) FROM Prestamo"

    ' Consulta para verificar si un socio existe
    Private Const QUERY_EXISTE_SOCIO As String = "SELECT COUNT(*) FROM Socio WHERE NumeroSocio = @NumeroSocio"

    ' Consulta para verificar si una película existe
    Private Const QUERY_EXISTE_PELICULA As String = "SELECT COUNT(*) FROM Pelicula WHERE NumeroPelicula = @NumeroPelicula"

    ' Consulta para agregar un nuevo alquiler
    Private Const QUERY_INSERT_ALQUILER As String = "INSERT INTO Prestamo (NumeroSocio, NumeroPelicula, FechaPrestamo, FechaDevolucion) VALUES (@NumeroSocio, @NumeroPelicula, @FechaPrestamo, @FechaDevolucion)"

    ' Consulta para eliminar un alquiler
    Private Const QUERY_DELETE_ALQUILER As String = "DELETE FROM Prestamo WHERE NumeroPrestamo = @NumeroPrestamo"

    ' Consulta para modificar un alquiler
    Private Const QUERY_UPDATE_ALQUILER As String = "UPDATE Prestamo SET NumeroSocio = @NumeroSocio, NumeroPelicula = @NumeroPelicula, FechaPrestamo = @FechaPrestamo, FechaDevolucion = @FechaDevolucion WHERE NumeroPrestamo = @NumeroPrestamo"

    ' Consulta para actualizar la fecha de devolución
    Private Const QUERY_UPDATE_FECHA_DEVOLUCION As String = "UPDATE Prestamo SET FechaDevolucion = @FechaDevolucion WHERE NumeroPrestamo = @NumeroPrestamo"

    ' **********************************************
    ' ** MÉTODOS DE ACCESO A LA BASE DE DATOS **
    ' **********************************************

    ' Método para cargar datos en un ListView
    Public Sub CargarDatosListView(ByVal listView As ListView)
        Dim con As New SQLiteConnection("Data Source=D:\Users\jiang\Desktop\BaseDatos\SQLite.db; Version=3;")
        Try
            con.Open()
            Dim cmd As New SQLiteCommand(QUERY_CARGAR_DATOS, con)
            Dim reader As SQLiteDataReader = cmd.ExecuteReader()

            listView.Items.Clear()

            While reader.Read()
                Dim item As New ListViewItem(reader("NumeroPrestamo").ToString())
                item.SubItems.Add(reader("NumeroSocio").ToString())
                item.SubItems.Add(reader("NumeroPelicula").ToString())
                item.SubItems.Add(reader("FechaPrestamo").ToString())

                ' FechaDevolucion puede ser NULL
                If Not reader.IsDBNull(reader.GetOrdinal("FechaDevolucion")) Then
                    item.SubItems.Add(reader("FechaDevolucion").ToString())
                Else
                    item.SubItems.Add("") ' Si es NULL, dejar vacío
                End If

                listView.Items.Add(item)
            End While

            reader.Close()
        Catch ex As Exception
            MsgBox("Error al cargar datos: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            con.Close()
        End Try
    End Sub

    ' Método para agregar un nuevo alquiler
    Public Function AgregarAlquiler(ByVal numeroSocio As Integer, ByVal numeroPelicula As Integer, ByVal fechaPrestamo As String, ByVal fechaDevolucion As String) As Boolean
        Dim con As New SQLiteConnection("Data Source=D:\Users\jiang\Desktop\BaseDatos\SQLite.db; Version=3;")
        Try
            con.Open()

            ' Verificar si el socio y la película existen
            If Not ExisteSocio(numeroSocio, con) Then
                MsgBox("El número de socio no existe.", MsgBoxStyle.Critical, "Error")
                Return False
            End If
            If Not ExistePelicula(numeroPelicula, con) Then
                MsgBox("El número de película no existe.", MsgBoxStyle.Critical, "Error")
                Return False
            End If

            ' Insertar el nuevo alquiler
            Dim insertCmd As New SQLiteCommand(QUERY_INSERT_ALQUILER, con)
            insertCmd.Parameters.AddWithValue("@NumeroSocio", numeroSocio)
            insertCmd.Parameters.AddWithValue("@NumeroPelicula", numeroPelicula)
            insertCmd.Parameters.AddWithValue("@FechaPrestamo", fechaPrestamo)

            ' Manejar la fecha de devolución como NULL si no se proporciona
            If String.IsNullOrEmpty(fechaDevolucion) Then
                insertCmd.Parameters.AddWithValue("@FechaDevolucion", DBNull.Value) ' FechaDevolucion será NULL
            Else
                insertCmd.Parameters.AddWithValue("@FechaDevolucion", fechaDevolucion)
            End If

            insertCmd.ExecuteNonQuery()

            MsgBox("Alquiler agregado correctamente.", MsgBoxStyle.Information, "Éxito")
            Return True
        Catch ex As Exception
            MsgBox("Error al agregar el alquiler: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        Finally
            con.Close()
        End Try
    End Function

    ' Método para eliminar un alquiler
    Public Function EliminarAlquiler(ByVal numeroPrestamo As Integer) As Boolean
        Dim con As New SQLiteConnection("Data Source=D:\Users\jiang\Desktop\BaseDatos\SQLite.db; Version=3;")
        Try
            con.Open()

            ' Verificar si el préstamo existe
            Dim cmdVerificar As New SQLiteCommand("SELECT COUNT(*) FROM Prestamo WHERE NumeroPrestamo = @NumeroPrestamo", con)
            cmdVerificar.Parameters.AddWithValue("@NumeroPrestamo", numeroPrestamo)
            Dim count As Integer = CInt(cmdVerificar.ExecuteScalar())

            If count = 0 Then
                MsgBox("El número de préstamo no existe.", MsgBoxStyle.Critical, "Error")
                Return False
            End If

            ' Eliminar el alquiler
            Dim deleteCmd As New SQLiteCommand(QUERY_DELETE_ALQUILER, con)
            deleteCmd.Parameters.AddWithValue("@NumeroPrestamo", numeroPrestamo)
            deleteCmd.ExecuteNonQuery()

            MsgBox("Alquiler eliminado correctamente.", MsgBoxStyle.Information, "Éxito")
            Return True
        Catch ex As Exception
            MsgBox("Error al eliminar el alquiler: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        Finally
            con.Close()
        End Try
    End Function

    ' Método para modificar un alquiler
    Public Function ModificarAlquiler(ByVal numeroPrestamo As Integer, ByVal numeroSocio As Integer, ByVal numeroPelicula As Integer, ByVal fechaPrestamo As String, ByVal fechaDevolucion As String) As Boolean
        Dim con As New SQLiteConnection("Data Source=D:\Users\jiang\Desktop\BaseDatos\SQLite.db; Version=3;")
        Try
            con.Open()

            ' Verificar si el préstamo existe
            Dim cmdVerificar As New SQLiteCommand("SELECT COUNT(*) FROM Prestamo WHERE NumeroPrestamo = @NumeroPrestamo", con)
            cmdVerificar.Parameters.AddWithValue("@NumeroPrestamo", numeroPrestamo)
            Dim count As Integer = CInt(cmdVerificar.ExecuteScalar())

            If count = 0 Then
                MsgBox("El número de préstamo no existe.", MsgBoxStyle.Critical, "Error")
                Return False
            End If

            ' Verificar si el socio y la película existen
            If Not ExisteSocio(numeroSocio, con) Then
                MsgBox("El número de socio no existe.", MsgBoxStyle.Critical, "Error")
                Return False
            End If
            If Not ExistePelicula(numeroPelicula, con) Then
                MsgBox("El número de película no existe.", MsgBoxStyle.Critical, "Error")
                Return False
            End If

            ' Modificar el alquiler
            Dim updateCmd As New SQLiteCommand(QUERY_UPDATE_ALQUILER, con)
            updateCmd.Parameters.AddWithValue("@NumeroPrestamo", numeroPrestamo)
            updateCmd.Parameters.AddWithValue("@NumeroSocio", numeroSocio)
            updateCmd.Parameters.AddWithValue("@NumeroPelicula", numeroPelicula)
            updateCmd.Parameters.AddWithValue("@FechaPrestamo", fechaPrestamo)

            ' Manejar la fecha de devolución como NULL si no se proporciona
            If String.IsNullOrEmpty(fechaDevolucion) Then
                updateCmd.Parameters.AddWithValue("@FechaDevolucion", DBNull.Value) ' FechaDevolucion será NULL
            Else
                updateCmd.Parameters.AddWithValue("@FechaDevolucion", fechaDevolucion)
            End If

            updateCmd.ExecuteNonQuery()

            MsgBox("Alquiler modificado correctamente.", MsgBoxStyle.Information, "Éxito")
            Return True
        Catch ex As Exception
            MsgBox("Error al modificar el alquiler: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        Finally
            con.Close()
        End Try
    End Function

    ' Método para obtener un alquiler por su número de préstamo
    Public Function ObtenerAlquiler(ByVal numeroPrestamo As Integer) As DataRow
        Dim con As New SQLiteConnection("Data Source=D:\Users\jiang\Desktop\BaseDatos\SQLite.db; Version=3;")
        Dim dt As New DataTable()
        Try
            con.Open()
            Dim cmd As New SQLiteCommand(QUERY_OBTENER_ALQUILER, con)
            cmd.Parameters.AddWithValue("@NumeroPrestamo", numeroPrestamo)
            Dim adapter As New SQLiteDataAdapter(cmd)
            adapter.Fill(dt)

            If dt.Rows.Count > 0 Then
                Return dt.Rows(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error al obtener el alquiler: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Return Nothing
        Finally
            con.Close()
        End Try
    End Function

    ' Método para actualizar la fecha de devolución
    Public Function ActualizarFechaDevolucion(ByVal numeroPrestamo As Integer, ByVal fechaDevolucion As String) As Boolean
        Dim con As New SQLiteConnection("Data Source=D:\Users\jiang\Desktop\BaseDatos\SQLite.db; Version=3;")
        Try
            con.Open()

            ' Verificar si el préstamo existe
            Dim cmdVerificar As New SQLiteCommand("SELECT COUNT(*) FROM Prestamo WHERE NumeroPrestamo = @NumeroPrestamo", con)
            cmdVerificar.Parameters.AddWithValue("@NumeroPrestamo", numeroPrestamo)
            Dim count As Integer = CInt(cmdVerificar.ExecuteScalar())

            If count = 0 Then
                MsgBox("El número de préstamo no existe.", MsgBoxStyle.Critical, "Error")
                Return False
            End If

            ' Actualizar la fecha de devolución
            Dim updateCmd As New SQLiteCommand(QUERY_UPDATE_FECHA_DEVOLUCION, con)
            updateCmd.Parameters.AddWithValue("@NumeroPrestamo", numeroPrestamo)
            updateCmd.Parameters.AddWithValue("@FechaDevolucion", fechaDevolucion)
            updateCmd.ExecuteNonQuery()

            MsgBox("Fecha de devolución actualizada correctamente.", MsgBoxStyle.Information, "Éxito")
            Return True
        Catch ex As Exception
            MsgBox("Error al actualizar la fecha de devolución: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        Finally
            con.Close()
        End Try
    End Function

    ' Método para obtener el siguiente número de préstamo
    Public Function ObtenerSiguienteNumeroPrestamo() As Integer
        Dim con As New SQLiteConnection("Data Source=D:\Users\jiang\Desktop\BaseDatos\SQLite.db; Version=3;")
        Try
            con.Open()
            Dim cmdMax As New SQLiteCommand(QUERY_OBTENER_SIGUIENTE_NUMERO, con)
            Dim maxValue As Object = cmdMax.ExecuteScalar()

            If maxValue Is DBNull.Value Then
                Return 1
            Else
                Return CInt(maxValue) + 1
            End If
        Catch ex As Exception
            MsgBox("Error al obtener el siguiente número de préstamo: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        Finally
            con.Close()
        End Try
    End Function

    ' Método para verificar si un socio existe
    Private Function ExisteSocio(ByVal numeroSocio As Integer, ByVal con As SQLiteConnection) As Boolean
        Dim cmd As New SQLiteCommand(QUERY_EXISTE_SOCIO, con)
        cmd.Parameters.AddWithValue("@NumeroSocio", numeroSocio)
        Dim count As Integer = CInt(cmd.ExecuteScalar())
        Return count > 0
    End Function

    ' Método para verificar si una película existe
    Private Function ExistePelicula(ByVal numeroPelicula As Integer, ByVal con As SQLiteConnection) As Boolean
        Dim cmd As New SQLiteCommand(QUERY_EXISTE_PELICULA, con)
        cmd.Parameters.AddWithValue("@NumeroPelicula", numeroPelicula)
        Dim count As Integer = CInt(cmd.ExecuteScalar())
        Return count > 0
    End Function
End Module
