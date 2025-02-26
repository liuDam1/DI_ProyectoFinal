Module BaseDatos
    Public con As SQLite.SQLiteConnection

    Public Sub ConectarBD()
        Dim connectionString As String = "Data Source=D:\Users\jiang\Desktop\BaseDatos\SQLite.db; Version=3;"
        Try
            If con Is Nothing Then
                con = New SQLite.SQLiteConnection(connectionString)
            End If

            If con.State = ConnectionState.Closed Then
                con.Open()
            Else
                MsgBox("La conexión ya está abierta.", MsgBoxStyle.Information, "Conexión activa")
            End If
        Catch ex As Exception
            MsgBox("No se pudo conectar a la base de datos. Error: " & ex.Message, MsgBoxStyle.Critical, "Error de conexión")
        End Try
    End Sub

    Public Sub CerrarConexionBD()
        Try
            If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then
                con.Close()
                MsgBox("Conexión cerrada correctamente.", MsgBoxStyle.Information, "Conexión cerrada")
            Else
                MsgBox("No hay ninguna conexión abierta.", MsgBoxStyle.Exclamation, "Cerrar conexión")
            End If
        Catch ex As Exception
            '::: Si ocurre un error al cerrar la conexión
            MsgBox("Error al cerrar la conexión: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Sub CerrarTodo(e As FormClosingEventArgs)
        Dim respuesta As DialogResult = MessageBox.Show("¿Estás seguro de que deseas cerrar la aplicación?", "Confirmar", MessageBoxButtons.YesNo)
        If respuesta = DialogResult.No Then
            e.Cancel = True
        Else
            CerrarConexionBD()
        End If
    End Sub
End Module