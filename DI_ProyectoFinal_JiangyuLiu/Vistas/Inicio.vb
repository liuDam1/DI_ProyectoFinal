Public Class Inicio
    Private Sub TiempoEspera_Tick(sender As Object, e As EventArgs) Handles TiempoEspera.Tick
        TiempoEspera.Stop()
        Me.Hide()
        Alquiler.Show()
    End Sub

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BaseDatos.ConectarBD()
    End Sub
End Class
