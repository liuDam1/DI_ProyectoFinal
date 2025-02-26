Imports System.Data.SQLite

Module ModuloSocio
    ' **********************************************
    ' ** CONSULTAS SQL DE LA BASE DE DATOS **
    ' **********************************************

    ' Cadena de conexión a la base de datos
    Private Const CONNECTION_STRING As String = "Data Source=D:\Users\jiang\Desktop\BaseDatos\SQLite.db; Version=3;"

    ' Consulta para cargar datos en un ListView
    Private Const QUERY_CARGAR_DATOS As String = "SELECT NumeroSocio, Nombre, Apellido, DNI, Direccion, Telefono FROM Socio"

    ' Consulta para agregar un nuevo socio
    Private Const QUERY_AGREGAR_SOCIO As String = "INSERT INTO Socio (NumeroSocio, Nombre, Apellido, DNI, Direccion, Telefono) VALUES (@NumeroSocio, @Nombre, @Apellido, @DNI, @Direccion, @Telefono)"

    ' Consulta para obtener el siguiente número de socio
    Private Const QUERY_OBTENER_SIGUIENTE_NUMERO_SOCIO As String = "SELECT MAX(NumeroSocio) FROM Socio"

    ' Consulta para modificar un socio
    Private Const QUERY_MODIFICAR_SOCIO As String = "UPDATE Socio SET Nombre = @Nombre, Apellido = @Apellido, DNI = @DNI, Direccion = @Direccion, Telefono = @Telefono WHERE NumeroSocio = @NumeroSocio"

    ' Consulta para eliminar un socio
    Private Const QUERY_ELIMINAR_SOCIO As String = "DELETE FROM Socio WHERE NumeroSocio = @NumeroSocio"

    ' Consulta para obtener un socio por su número
    Private Const QUERY_OBTENER_SOCIO As String = "SELECT NumeroSocio, Nombre, Apellido, DNI, Direccion, Telefono FROM Socio WHERE NumeroSocio = @NumeroSocio"

    ' **********************************************
    ' ** MÉTODOS DE ACCESO A LA BASE DE DATOS **
    ' **********************************************

    ' Método para cargar datos en un ListView
    Public Sub CargarDatosListViewSocio(ByVal listView As ListView)
        Dim con As New SQLiteConnection(CONNECTION_STRING)
        Try
            con.Open()
            Dim cmd As New SQLiteCommand(QUERY_CARGAR_DATOS, con)
            Dim reader As SQLiteDataReader = cmd.ExecuteReader()

            listView.Items.Clear()

            While reader.Read()
                Dim item As New ListViewItem(reader("NumeroSocio").ToString())
                item.SubItems.Add(reader("Nombre").ToString())
                item.SubItems.Add(reader("Apellido").ToString())
                item.SubItems.Add(reader("DNI").ToString())
                item.SubItems.Add(reader("Direccion").ToString())
                item.SubItems.Add(reader("Telefono").ToString())

                listView.Items.Add(item)
            End While

            reader.Close()
        Catch ex As Exception
            MsgBox("Error al cargar datos: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            con.Close()
        End Try
    End Sub

    ' Método para agregar un nuevo socio
    Public Function AgregarSocio(ByVal numeroSocio As Integer, ByVal nombre As String, ByVal apellido As String, ByVal dni As String, ByVal direccion As String, ByVal telefono As String) As Boolean
        Dim con As New SQLiteConnection(CONNECTION_STRING)
        Try
            con.Open()
            Dim insertCmd As New SQLiteCommand(QUERY_AGREGAR_SOCIO, con)
            insertCmd.Parameters.AddWithValue("@NumeroSocio", numeroSocio)
            insertCmd.Parameters.AddWithValue("@Nombre", nombre)
            insertCmd.Parameters.AddWithValue("@Apellido", apellido)
            insertCmd.Parameters.AddWithValue("@DNI", dni)
            insertCmd.Parameters.AddWithValue("@Direccion", direccion)
            insertCmd.Parameters.AddWithValue("@Telefono", telefono)
            insertCmd.ExecuteNonQuery()
            MsgBox("Socio agregado correctamente.", MsgBoxStyle.Information, "Éxito")
            Return True
        Catch ex As Exception
            MsgBox("Error al agregar socio: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        Finally
            con.Close()
        End Try
    End Function

    ' Método para conseguir el numero de socio
    Public Function ObtenerSiguienteNumeroSocio() As Integer
        Dim con As New SQLiteConnection(CONNECTION_STRING)
        Try
            con.Open()
            Dim cmdMax As New SQLiteCommand(QUERY_OBTENER_SIGUIENTE_NUMERO_SOCIO, con)
            Dim maxValue As Object = cmdMax.ExecuteScalar()
            If maxValue Is DBNull.Value Then
                Return 1
            Else
                Return CInt(maxValue) + 1
            End If
        Catch ex As Exception
            MsgBox("Error al obtener el siguiente número de socio: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Return 1
        Finally
            con.Close()
        End Try
    End Function

    ' Método para modificar un socio
    Public Function ModificarSocio(ByVal numeroSocio As Integer, ByVal nombre As String, ByVal apellido As String, ByVal dni As String, ByVal direccion As String, ByVal telefono As String) As Boolean
        Dim con As New SQLiteConnection(CONNECTION_STRING)
        Try
            con.Open()
            Dim updateCmd As New SQLiteCommand(QUERY_MODIFICAR_SOCIO, con)
            updateCmd.Parameters.AddWithValue("@NumeroSocio", numeroSocio)
            updateCmd.Parameters.AddWithValue("@Nombre", nombre)
            updateCmd.Parameters.AddWithValue("@Apellido", apellido)
            updateCmd.Parameters.AddWithValue("@DNI", dni)
            updateCmd.Parameters.AddWithValue("@Direccion", direccion)
            updateCmd.Parameters.AddWithValue("@Telefono", telefono)
            updateCmd.ExecuteNonQuery()
            MsgBox("Socio modificado correctamente.", MsgBoxStyle.Information, "Éxito")
            Return True
        Catch ex As Exception
            MsgBox("Error al modificar socio: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        Finally
            con.Close()
        End Try
    End Function

    ' Método para eliminar un socio
    Public Function EliminarSocio(ByVal numeroSocio As Integer) As Boolean
        Dim con As New SQLiteConnection(CONNECTION_STRING)
        Try
            con.Open()
            Dim deleteCmd As New SQLiteCommand(QUERY_ELIMINAR_SOCIO, con)
            deleteCmd.Parameters.AddWithValue("@NumeroSocio", numeroSocio)
            deleteCmd.ExecuteNonQuery()
            MsgBox("Socio eliminado correctamente.", MsgBoxStyle.Information, "Éxito")
            Return True
        Catch ex As Exception
            MsgBox("Error al eliminar socio: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        Finally
            con.Close()
        End Try
    End Function

    ' Método para obtener un socio por su número
    Public Function ObtenerSocio(ByVal numeroSocio As Integer) As DataRow
        Dim con As New SQLiteConnection(CONNECTION_STRING)
        Dim dt As New DataTable()
        Try
            con.Open()
            Dim cmd As New SQLiteCommand(QUERY_OBTENER_SOCIO, con)
            cmd.Parameters.AddWithValue("@NumeroSocio", numeroSocio)
            Dim adapter As New SQLiteDataAdapter(cmd)
            adapter.Fill(dt)
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error al obtener socio: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Return Nothing
        Finally
            con.Close()
        End Try
    End Function
End Module
