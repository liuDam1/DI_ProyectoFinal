Imports System.Data.SQLite

Public Class FormPelicula
    Private modoOperacion As String = ""

    Private Sub FormPelicula_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar los géneros en el ComboBox
        ModuloPelicula.CargarComboBoxGeneros(ComboBox_GeneroPelic)

        ' Inicializar para agregar una nueva película
        InicializarNuevoPelicula()
    End Sub

    ' Método para inicializar una nueva película
    Public Sub InicializarNuevoPelicula()
        modoOperacion = "Agregar"
        ConfigurarCamposParaNuevoPelicula()
    End Sub

    ' Método para manejar el clic en el botón Guardar
    Private Sub Button_Guardar_Click(sender As Object, e As EventArgs) Handles Button_Guardar.Click
        Select Case modoOperacion
            Case "Agregar"
                GuardarNuevaPelicula()
            Case "Modificar"
                ModificarPeliculaExistente()
            Case "Eliminar"
                EliminarPeliculaExistente()
        End Select
    End Sub

    ' Método para manejar el clic en el menú "Nuevo"
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        modoOperacion = "Agregar"
        ConfigurarCamposParaNuevoPelicula()
    End Sub

    ' Método para manejar el clic en el menú "Modificar"
    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        modoOperacion = "Modificar"
        ConfigurarCamposParaModificar()
    End Sub

    ' Método para manejar el clic en el menú "Eliminar"
    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        modoOperacion = "Eliminar"
        ConfigurarCamposParaEliminar()
    End Sub

    Private Sub VaolverPeliculaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VaolverPeliculaToolStripMenuItem.Click
        Pelicula.Show()
        Me.Hide()
    End Sub

    ' Método para manejar la tecla Enter en el campo de número de película
    Private Sub TextBox_NumPelicula_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_NumPelicula.KeyDown
        If e.KeyCode = Keys.Enter AndAlso (modoOperacion = "Modificar" Or modoOperacion = "Eliminar") Then
            CargarDatosPelicula()
        End If
    End Sub

    ' Métodos auxiliares
    Private Sub ConfigurarCamposParaNuevoPelicula()
        Label1_Titulo.Text = "Nueva Película"
        TextBox_NumPelicula.Text = ModuloPelicula.ObtenerSiguienteNumeroPelicula().ToString()
        TextBox_NumPelicula.Enabled = False
        TextBox_TituloPelic.Enabled = True
        TextBox_DirectorPelic.Enabled = True
        TextBox_AnoPelic.Enabled = True
        ComboBox_GeneroPelic.Enabled = True
        TextBox_DuracionPelic.Enabled = True
        TextBox_CalificacionPelic.Enabled = True
        Button_Guardar.Text = "Guardar"
        LimpiarCampos()
    End Sub

    Private Sub ConfigurarCamposParaModificar()
        Label1_Titulo.Text = "Modificar Película"
        TextBox_NumPelicula.Text = ""
        TextBox_NumPelicula.Enabled = True
        TextBox_TituloPelic.Enabled = False
        TextBox_DirectorPelic.Enabled = False
        TextBox_AnoPelic.Enabled = False
        ComboBox_GeneroPelic.Enabled = False
        TextBox_DuracionPelic.Enabled = False
        TextBox_CalificacionPelic.Enabled = False
        Button_Guardar.Text = "Guardar"
        LimpiarCampos()
    End Sub

    Private Sub ConfigurarCamposParaEliminar()
        Label1_Titulo.Text = "Eliminar Película"
        TextBox_NumPelicula.Text = ""
        TextBox_NumPelicula.Enabled = True
        TextBox_TituloPelic.Enabled = False
        TextBox_DirectorPelic.Enabled = False
        TextBox_AnoPelic.Enabled = False
        ComboBox_GeneroPelic.Enabled = False
        TextBox_DuracionPelic.Enabled = False
        TextBox_CalificacionPelic.Enabled = False
        Button_Guardar.Text = "Eliminar"
        LimpiarCampos()
    End Sub

    Private Sub LimpiarCampos()
        TextBox_TituloPelic.Text = ""
        TextBox_DirectorPelic.Text = ""
        TextBox_AnoPelic.Text = ""
        ComboBox_GeneroPelic.SelectedIndex = -1
        TextBox_DuracionPelic.Text = ""
        TextBox_CalificacionPelic.Text = ""
    End Sub

    Private Sub CargarDatosPelicula()
        Dim numeroPelicula As Integer
        If Integer.TryParse(TextBox_NumPelicula.Text, numeroPelicula) Then
            Dim pelicula As ModuloPelicula.PeliculaItem = ModuloPelicula.ObtenerPelicula(numeroPelicula)
            If pelicula IsNot Nothing Then
                TextBox_TituloPelic.Text = pelicula.Titulo
                TextBox_DirectorPelic.Text = pelicula.Director
                TextBox_AnoPelic.Text = pelicula.Ano.ToString()
                For Each item As ModuloPelicula.GeneroItem In ComboBox_GeneroPelic.Items
                    If item.NumeroGenero = pelicula.NumeroGenero Then
                        ComboBox_GeneroPelic.SelectedItem = item
                        Exit For
                    End If
                Next
                TextBox_DuracionPelic.Text = pelicula.Duracion
                TextBox_CalificacionPelic.Text = pelicula.Calificacion

                If modoOperacion = "Modificar" Then
                    TextBox_TituloPelic.Enabled = True
                    TextBox_DirectorPelic.Enabled = True
                    TextBox_AnoPelic.Enabled = True
                    ComboBox_GeneroPelic.Enabled = True
                    TextBox_DuracionPelic.Enabled = True
                    TextBox_CalificacionPelic.Enabled = True
                End If
            Else
                MsgBox("No se encontró ninguna película con el número proporcionado.", MsgBoxStyle.Information, "Información")
                LimpiarCampos()
            End If
        End If
    End Sub

    Private Sub GuardarNuevaPelicula()
        Dim titulo As String = TextBox_TituloPelic.Text
        Dim director As String = TextBox_DirectorPelic.Text
        Dim ano As Integer
        If Integer.TryParse(TextBox_AnoPelic.Text, ano) Then
            ' Obtener el género seleccionado
            Dim generoItem As ModuloPelicula.GeneroItem = CType(ComboBox_GeneroPelic.SelectedItem, ModuloPelicula.GeneroItem)
            Dim duracion As String = TextBox_DuracionPelic.Text
            Dim calificacion As String = TextBox_CalificacionPelic.Text

            If generoItem IsNot Nothing Then
                ' Guardar la película en la base de datos
                If ModuloPelicula.AgregarPelicula(titulo, director, ano, generoItem, duracion, calificacion) Then
                    ' Ocultar el formulario actual y mostrar el formulario de lista de películas
                    Me.Hide()
                    Dim peliculaForm As New Pelicula()
                    peliculaForm.Show()
                End If
            Else
                MsgBox("Por favor, seleccione un género.", MsgBoxStyle.Critical, "Error")
            End If
        Else
            MsgBox("Por favor, ingrese un año válido.", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub ModificarPeliculaExistente()
        Dim numeroPelicula As Integer
        If Integer.TryParse(TextBox_NumPelicula.Text, numeroPelicula) Then
            Dim titulo As String = TextBox_TituloPelic.Text
            Dim director As String = TextBox_DirectorPelic.Text
            Dim ano As Integer
            If Integer.TryParse(TextBox_AnoPelic.Text, ano) Then
                ' Obtener el género seleccionado
                Dim generoItem As ModuloPelicula.GeneroItem = CType(ComboBox_GeneroPelic.SelectedItem, ModuloPelicula.GeneroItem)
                Dim duracion As String = TextBox_DuracionPelic.Text
                Dim calificacion As String = TextBox_CalificacionPelic.Text

                If generoItem IsNot Nothing Then
                    ' Modificar la película en la base de datos
                    If ModuloPelicula.ModificarPelicula(numeroPelicula, titulo, director, ano, generoItem, duracion, calificacion) Then
                        ' Ocultar el formulario actual y mostrar el formulario de lista de películas
                        Me.Hide()
                        Dim peliculaForm As New Pelicula()
                        peliculaForm.Show()
                    End If
                Else
                    MsgBox("Por favor, seleccione un género.", MsgBoxStyle.Critical, "Error")
                End If
            Else
                MsgBox("Por favor, ingrese un año válido.", MsgBoxStyle.Critical, "Error")
            End If
        Else
            MsgBox("El número de película debe ser un valor numérico.", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub EliminarPeliculaExistente()
        Dim numeroPelicula As Integer
        If Integer.TryParse(TextBox_NumPelicula.Text, numeroPelicula) Then
            If ModuloPelicula.EliminarPelicula(numeroPelicula) Then
                ' Ocultar el formulario actual y mostrar el formulario de lista de películas
                Me.Hide()
                Dim peliculaForm As New Pelicula()
                peliculaForm.Show()
            End If
        Else
            MsgBox("El número de película debe ser un valor numérico.", MsgBoxStyle.Critical, "Error")
        End If
    End Sub
End Class
