Imports System.Data.SQLite
Imports System.Globalization

Public Class Pelicula
    Private Sub Pelicula_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar los datos de las películas en el ListView
        ModuloPelicula.CargarDatosListViewPelicula(ListView_Pelicula)
    End Sub

    Private Sub Button_NuevaPelicula_Click(sender As Object, e As EventArgs) Handles Button_NuevaPelicula.Click
        ' Ocultar este formulario y mostrar el formulario para agregar una nueva película
        Me.Hide()
        Dim formPelicula As New FormPelicula()
        formPelicula.InicializarNuevoPelicula()
        formPelicula.Show()
    End Sub

    Private Sub Button_VolverInicio_Click(sender As Object, e As EventArgs) Handles Button_VolverInicio.Click
        ' Ocultar este formulario y mostrar el formulario de inicio (Alquiler)
        Me.Hide()
        Dim alquilerForm As New Alquiler()
        alquilerForm.Show()
    End Sub
End Class
