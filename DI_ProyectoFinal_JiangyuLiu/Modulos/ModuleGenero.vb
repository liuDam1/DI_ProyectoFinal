Imports System.Data.SQLite

Module ModuleGenero
    ' **********************************************
    ' ** CONSULTAS SQL DE LA BASE DE DATOS **
    ' **********************************************

    ' Cadena de conexión a la base de datos
    Private Const CONNECTION_STRING As String = "Data Source=D:\Users\jiang\Desktop\BaseDatos\SQLite.db; Version=3;"

    ' Consulta para cargar datos en un ListView
    Private Const QUERY_CARGAR_DATOS As String = "SELECT NumeroGenero, Nombre FROM Genero"

    ' Consulta para agregar un nuevo género
    Private Const QUERY_AGREGAR_GENERO As String = "INSERT INTO Genero (Nombre) VALUES (@Nombre)"

    ' Consulta para modificar un género
    Private Const QUERY_MODIFICAR_GENERO As String = "UPDATE Genero SET Nombre = @Nombre WHERE NumeroGenero = @NumeroGenero"

    ' Consulta para eliminar un género
    Private Const QUERY_ELIMINAR_GENERO As String = "DELETE FROM Genero WHERE NumeroGenero = @NumeroGenero"

    ' Consulta para obtener un género por su número
    Private Const QUERY_OBTENER_GENERO As String = "SELECT NumeroGenero, Nombre FROM Genero WHERE NumeroGenero = @NumeroGenero"

    ' Consulta para obtener el siguiente número de género
    Private Const QUERY_OBTENER_SIGUIENTE_NUMERO_GENERO As String = "SELECT MAX(NumeroGenero) FROM Genero"

    ' **********************************************
    ' ** MÉTODOS DE ACCESO A LA BASE DE DATOS **
    ' **********************************************

    ' Método para cargar datos en un ListView
    Public Sub CargarDatosListViewGenero(ByVal listView As ListView)
        Using con As New SQLiteConnection(CONNECTION_STRING)
            Try
                con.Open()
                Using cmd As New SQLiteCommand(QUERY_CARGAR_DATOS, con)
                    Using reader As SQLiteDataReader = cmd.ExecuteReader()
                        listView.Items.Clear()

                        While reader.Read()
                            Dim item As New ListViewItem(reader("NumeroGenero").ToString())
                            item.SubItems.Add(reader("Nombre").ToString())

                            listView.Items.Add(item)
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MsgBox("Error al cargar datos: " & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End Using
    End Sub

    ' Método para agregar un nuevo género
    Public Function AgregarGenero(ByVal nombre As String) As Boolean
        Using con As New SQLiteConnection(CONNECTION_STRING)
            Try
                con.Open()
                Using insertCmd As New SQLiteCommand(QUERY_AGREGAR_GENERO, con)
                    insertCmd.Parameters.AddWithValue("@Nombre", nombre)
                    insertCmd.ExecuteNonQuery()
                    MsgBox("Género agregado correctamente.", MsgBoxStyle.Information, "Éxito")
                    Return True
                End Using
            Catch ex As Exception
                MsgBox("Error al agregar género: " & ex.Message, MsgBoxStyle.Critical, "Error")
                Return False
            End Try
        End Using
    End Function

    ' Método para obtener el siguiente número de género
    Public Function ObtenerSiguienteNumeroGenero() As Integer
        Using con As New SQLiteConnection(CONNECTION_STRING)
            Try
                con.Open()
                Using cmdMax As New SQLiteCommand(QUERY_OBTENER_SIGUIENTE_NUMERO_GENERO, con)
                    Dim maxValue As Object = cmdMax.ExecuteScalar()
                    If maxValue Is DBNull.Value Then
                        Return 1
                    Else
                        Return CInt(maxValue) + 1
                    End If
                End Using
            Catch ex As Exception
                MsgBox("Error al obtener el siguiente número de género: " & ex.Message, MsgBoxStyle.Critical, "Error")
                Return 1
            End Try
        End Using
    End Function

    ' Método para modificar un género
    Public Function ModificarGenero(ByVal numeroGenero As Integer, ByVal nombre As String) As Boolean
        Using con As New SQLiteConnection(CONNECTION_STRING)
            Try
                con.Open()
                Using updateCmd As New SQLiteCommand(QUERY_MODIFICAR_GENERO, con)
                    updateCmd.Parameters.AddWithValue("@NumeroGenero", numeroGenero)
                    updateCmd.Parameters.AddWithValue("@Nombre", nombre)
                    updateCmd.ExecuteNonQuery()
                    MsgBox("Género modificado correctamente.", MsgBoxStyle.Information, "Éxito")
                    Return True
                End Using
            Catch ex As Exception
                MsgBox("Error al modificar género: " & ex.Message, MsgBoxStyle.Critical, "Error")
                Return False
            End Try
        End Using
    End Function

    ' Método para eliminar un género
    Public Function EliminarGenero(ByVal numeroGenero As Integer) As Boolean
        Using con As New SQLiteConnection(CONNECTION_STRING)
            Try
                con.Open()
                Using deleteCmd As New SQLiteCommand(QUERY_ELIMINAR_GENERO, con)
                    deleteCmd.Parameters.AddWithValue("@NumeroGenero", numeroGenero)
                    deleteCmd.ExecuteNonQuery()
                    MsgBox("Género eliminado correctamente.", MsgBoxStyle.Information, "Éxito")
                    Return True
                End Using
            Catch ex As Exception
                MsgBox("Error al eliminar género: " & ex.Message, MsgBoxStyle.Critical, "Error")
                Return False
            End Try
        End Using
    End Function

    ' Método para obtener un género por su número
    Public Function ObtenerGenero(ByVal numeroGenero As Integer) As DataRow
        Dim dt As New DataTable()
        Using con As New SQLiteConnection(CONNECTION_STRING)
            Try
                con.Open()
                Using cmd As New SQLiteCommand(QUERY_OBTENER_GENERO, con)
                    cmd.Parameters.AddWithValue("@NumeroGenero", numeroGenero)
                    Using adapter As New SQLiteDataAdapter(cmd)
                        adapter.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            Return dt.Rows(0)
                        Else
                            Return Nothing
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MsgBox("Error al obtener género: " & ex.Message, MsgBoxStyle.Critical, "Error")
                Return Nothing
            End Try
        End Using
    End Function
End Module