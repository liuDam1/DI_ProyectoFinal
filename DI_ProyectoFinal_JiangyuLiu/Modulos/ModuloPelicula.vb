Imports System.Data.SQLite

Module ModuloPelicula
    ' **********************************************
    ' ** CONSULTAS SQL DE LA BASE DE DATOS **
    ' **********************************************

    ' Cadena de conexión a la base de datos
    Private Const CONNECTION_STRING As String = "Data Source=D:\Users\jiang\Desktop\BaseDatos\SQLite.db; Version=3;"

    ' Consulta para obtener el siguiente número de película
    Private Const QUERY_OBTENER_ULTIMO_NUMERO As String = "SELECT MAX(NumeroPelicula) AS UltimoNumero FROM Pelicula"

    ' Consulta para agregar una nueva película
    Private Const QUERY_AGREGAR_PELICULA As String = "INSERT INTO Pelicula (Titulo, Director, Ano, NumeroGenero, Duracion, Calificacion) " &
                                                     "VALUES (@Titulo, @Director, @Ano, @NumeroGenero, @Duracion, @Calificacion)"

    ' Consulta para cargar los datos de las películas en el ListView
    Private Const QUERY_CARGAR_PELICULAS As String = "SELECT NumeroPelicula, Titulo, Director, Ano, NumeroGenero, Duracion, Calificacion FROM Pelicula"

    ' Consulta para cargar los géneros en el ComboBox
    Private Const QUERY_CARGAR_GENEROS As String = "SELECT NumeroGenero, Nombre FROM Genero"

    ' Consulta para obtener una película por número
    Private Const QUERY_OBTENER_PELICULA As String = "SELECT Titulo, Director, Ano, NumeroGenero, Duracion, Calificacion FROM Pelicula WHERE NumeroPelicula = @NumeroPelicula"

    ' Consulta para eliminar una película
    Private Const QUERY_ELIMINAR_PELICULA As String = "DELETE FROM Pelicula WHERE NumeroPelicula = @NumeroPelicula"

    ' Consulta para modificar una película
    Private Const QUERY_MODIFICAR_PELICULA As String = "UPDATE Pelicula SET Titulo = @Titulo, Director = @Director, Ano = @Ano, NumeroGenero = @NumeroGenero, Duracion = @Duracion, Calificacion = @Calificacion WHERE NumeroPelicula = @NumeroPelicula"

    ' **********************************************
    ' ** MÉTODOS DE ACCESO A LA BASE DE DATOS **
    ' **********************************************

    ' Método para obtener el siguiente número de película automáticamente
    Public Function ObtenerSiguienteNumeroPelicula() As Integer
        Using con As New SQLiteConnection(CONNECTION_STRING)
            Try
                con.Open()
                Using cmd As New SQLiteCommand(QUERY_OBTENER_ULTIMO_NUMERO, con)
                    Dim resultado As Object = cmd.ExecuteScalar()
                    ' Si no hay películas en la base de datos, empezar desde 1
                    If resultado Is DBNull.Value Then
                        Return 1
                    Else
                        Return CInt(resultado) + 1
                    End If
                End Using
            Catch ex As Exception
                MsgBox("Error al obtener el siguiente número de película: " & ex.Message, MsgBoxStyle.Critical, "Error")
                Return -1
            End Try
        End Using
    End Function

    ' Método para agregar una nueva película
    Public Function AgregarPelicula(ByVal titulo As String, ByVal director As String, ByVal ano As Integer,
                                   ByVal generoItem As GeneroItem, ByVal duracion As String, ByVal calificacion As String) As Boolean
        Using con As New SQLiteConnection(CONNECTION_STRING)
            Try
                con.Open()
                Using cmd As New SQLiteCommand(QUERY_AGREGAR_PELICULA, con)
                    cmd.Parameters.AddWithValue("@Titulo", titulo)
                    cmd.Parameters.AddWithValue("@Director", director)
                    cmd.Parameters.AddWithValue("@Ano", ano)
                    cmd.Parameters.AddWithValue("@NumeroGenero", generoItem.NumeroGenero)
                    cmd.Parameters.AddWithValue("@Duracion", duracion)
                    cmd.Parameters.AddWithValue("@Calificacion", calificacion)
                    cmd.ExecuteNonQuery()
                    MsgBox("Película agregada correctamente.", MsgBoxStyle.Information, "Éxito")
                    Return True
                End Using
            Catch ex As Exception
                MsgBox("Error al agregar la película: " & ex.Message, MsgBoxStyle.Critical, "Error")
                Return False
            End Try
        End Using
    End Function

    ' Método para obtener una película por número
    Public Function ObtenerPelicula(ByVal numeroPelicula As Integer) As PeliculaItem
        Using con As New SQLiteConnection(CONNECTION_STRING)
            Try
                con.Open()
                Using cmd As New SQLiteCommand(QUERY_OBTENER_PELICULA, con)
                    cmd.Parameters.AddWithValue("@NumeroPelicula", numeroPelicula)
                    Using reader As SQLiteDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim pelicula As New PeliculaItem()
                            pelicula.Titulo = reader("Titulo").ToString()
                            pelicula.Director = reader("Director").ToString()
                            pelicula.Ano = CInt(reader("Ano"))
                            pelicula.NumeroGenero = CInt(reader("NumeroGenero"))
                            pelicula.Duracion = reader("Duracion").ToString()
                            pelicula.Calificacion = reader("Calificacion").ToString()
                            Return pelicula
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MsgBox("Error al obtener la película: " & ex.Message, MsgBoxStyle.Critical, "Error")
                Return Nothing
            End Try
        End Using
    End Function

    ' Método para eliminar una película
    Public Function EliminarPelicula(ByVal numeroPelicula As Integer) As Boolean
        Using con As New SQLiteConnection(CONNECTION_STRING)
            Try
                con.Open()
                Using cmd As New SQLiteCommand(QUERY_ELIMINAR_PELICULA, con)
                    cmd.Parameters.AddWithValue("@NumeroPelicula", numeroPelicula)
                    cmd.ExecuteNonQuery()
                    MsgBox("Película eliminada correctamente.", MsgBoxStyle.Information, "Éxito")
                    Return True
                End Using
            Catch ex As Exception
                MsgBox("Error al eliminar la película: " & ex.Message, MsgBoxStyle.Critical, "Error")
                Return False
            End Try
        End Using
    End Function

    ' Método para modificar una película
    Public Function ModificarPelicula(ByVal numeroPelicula As Integer, ByVal titulo As String, ByVal director As String,
                                      ByVal ano As Integer, ByVal generoItem As GeneroItem, ByVal duracion As String,
                                      ByVal calificacion As String) As Boolean
        Using con As New SQLiteConnection(CONNECTION_STRING)
            Try
                con.Open()
                Using transaction As SQLiteTransaction = con.BeginTransaction()
                    Using cmd As New SQLiteCommand(QUERY_MODIFICAR_PELICULA, con, transaction)
                        cmd.Parameters.AddWithValue("@NumeroPelicula", numeroPelicula)
                        cmd.Parameters.AddWithValue("@Titulo", titulo)
                        cmd.Parameters.AddWithValue("@Director", director)
                        cmd.Parameters.AddWithValue("@Ano", ano)
                        cmd.Parameters.AddWithValue("@NumeroGenero", generoItem.NumeroGenero)
                        cmd.Parameters.AddWithValue("@Duracion", duracion)
                        cmd.Parameters.AddWithValue("@Calificacion", calificacion)
                        cmd.ExecuteNonQuery()
                        transaction.Commit()
                        MsgBox("Película modificada correctamente.", MsgBoxStyle.Information, "Éxito")
                        Return True
                    End Using
                End Using
            Catch ex As Exception
                MsgBox("Error al modificar la película: " & ex.Message, MsgBoxStyle.Critical, "Error")
                If con.State = ConnectionState.Open Then
                    con.BeginTransaction().Rollback()
                End If
                Return False
            End Try
        End Using
    End Function

    ' Método para cargar los datos de las películas en el ListView
    Public Sub CargarDatosListViewPelicula(ByVal listView As ListView)
        Using con As New SQLiteConnection(CONNECTION_STRING)
            Try
                con.Open()
                Using cmd As New SQLiteCommand(QUERY_CARGAR_PELICULAS, con)
                    Using reader As SQLiteDataReader = cmd.ExecuteReader()
                        ' Limpiar el ListView antes de cargar los datos
                        listView.Items.Clear()
                        ' Agregar los datos al ListView
                        While reader.Read()
                            Dim item As New ListViewItem(reader("NumeroPelicula").ToString())
                            item.SubItems.Add(reader("Titulo").ToString())
                            item.SubItems.Add(reader("Director").ToString())
                            item.SubItems.Add(reader("Ano").ToString())
                            item.SubItems.Add(reader("NumeroGenero").ToString())
                            item.SubItems.Add(reader("Duracion").ToString())
                            item.SubItems.Add(reader("Calificacion").ToString())
                            listView.Items.Add(item)
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MsgBox("Error al cargar datos: " & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End Using
    End Sub

    ' Método para cargar los géneros en el ComboBox
    Public Sub CargarComboBoxGeneros(ByVal comboBox As ComboBox)
        Using con As New SQLiteConnection(CONNECTION_STRING)
            Try
                con.Open()
                Using cmd As New SQLiteCommand(QUERY_CARGAR_GENEROS, con)
                    Using reader As SQLiteDataReader = cmd.ExecuteReader()
                        comboBox.Items.Clear()
                        While reader.Read()
                            Dim generoNombre As String = reader("Nombre").ToString()
                            Dim generoNumero As Integer = reader("NumeroGenero")
                            comboBox.Items.Add(New GeneroItem(generoNumero, generoNombre))
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MsgBox("Error al cargar los géneros: " & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End Using
    End Sub

    ' Clase para representar un género
    Public Class GeneroItem
        Public Property NumeroGenero As Integer
        Public Property NombreGenero As String

        Public Sub New(ByVal numero As Integer, ByVal nombre As String)
            NumeroGenero = numero
            NombreGenero = nombre
        End Sub

        Public Overrides Function ToString() As String
            Return NombreGenero
        End Function
    End Class

    ' Clase para representar una película
    Public Class PeliculaItem
        Public Property Titulo As String
        Public Property Director As String
        Public Property Ano As Integer
        Public Property NumeroGenero As Integer
        Public Property Duracion As String
        Public Property Calificacion As String
    End Class
End Module