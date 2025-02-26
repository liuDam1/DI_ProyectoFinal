Public Class Socio
    Private Sub Socio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModuloSocio.CargarDatosListViewSocio(ListView_Socio)
    End Sub

    Private Sub Socio_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ModuloSocio.CargarDatosListViewSocio(ListView_Socio)
    End Sub

    Private Sub Button_NuevaSocio_Click(sender As Object, e As EventArgs) Handles Button_NuevaSocio.Click
        FormSocio.InicializarNuevoSocio()
        FormSocio.Show()
        Me.Hide()
    End Sub

    Private Sub Button_VolverInicio_Click(sender As Object, e As EventArgs) Handles Button_VolverInicio.Click
        Alquiler.Show()
        Me.Hide()
    End Sub
End Class
