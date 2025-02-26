Public Class Alquiler
    Private Sub Alquiler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModuleAlquiler.CargarDatosListView(ListView_Alquiler)
    End Sub

    Private Sub Alquiler_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        ModuleAlquiler.CargarDatosListView(ListView_Alquiler)
    End Sub

    ' Botón "Nuevo Alquiler"
    Private Sub Button_NuevaAlquiler_Click(sender As Object, e As EventArgs) Handles Button_NuevaAlquiler.Click
        Dim formAlquiler As New FormAlquiler()
        formAlquiler.InicializarNuevoAlquiler()
        Me.Hide()
        formAlquiler.Show()
    End Sub

    ' Botón "Devolver Película"
    Private Sub Button_DevolverPelicula_Click(sender As Object, e As EventArgs) Handles Button_DevolverPelicula.Click
        Dim formAlquiler As New FormAlquiler()
        formAlquiler.InicializarParaDevolucion()
        Me.Hide()
        formAlquiler.Show()
    End Sub

    ' Menú "Nuevo Alquiler"
    Private Sub AlquilerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlquilerToolStripMenuItem.Click
        Dim formAlquiler As New FormAlquiler()
        formAlquiler.InicializarNuevoAlquiler()
        Me.Hide()
        formAlquiler.Show()
    End Sub

    ' Menú "Socio"
    Private Sub SocioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SocioToolStripMenuItem.Click
        Socio.Show()
        Me.Hide()
    End Sub

    ' Menú "Género"
    Private Sub GeneroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeneroToolStripMenuItem.Click
        FormGenero.Show()
        Me.Hide()
    End Sub

    ' Menú "Película"
    Private Sub PelículaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PelículaToolStripMenuItem.Click
        Pelicula.Show()
        Me.Hide()
    End Sub
End Class
