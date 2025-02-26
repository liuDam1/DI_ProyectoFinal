Public Class FormGenero
    Private modoOperacion As String = ""

    ' Método para inicializar un nuevo género
    Public Sub InicializarNuevoGenero()
        modoOperacion = "Agregar"
        ConfigurarCamposParaNuevoGenero()
    End Sub

    ' Método para manejar el clic en el botón Guardar
    Private Sub Button_Guardar_Click(sender As Object, e As EventArgs) Handles Button_Guardar.Click
        Select Case modoOperacion
            Case "Agregar"
                GuardarNuevoGenero()
            Case "Modificar"
                ModificarGeneroExistente()
            Case "Eliminar"
                EliminarGeneroExistente()
        End Select
    End Sub

    ' Método para manejar el clic en el menú "Nuevo Género"
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        modoOperacion = "Agregar"
        ConfigurarCamposParaNuevoGenero()
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

    ' Método para manejar el clic en el menú "Volver Inicio"
    Private Sub VolverInicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverInicioToolStripMenuItem.Click
        Me.Hide()
        Alquiler.Show()
    End Sub

    ' Método para manejar la tecla Enter en el campo de número de género
    Private Sub TextBox_GeneroNum_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_GeneroNum.KeyDown
        If e.KeyCode = Keys.Enter AndAlso (modoOperacion = "Modificar" Or modoOperacion = "Eliminar") Then
            CargarDatosGenero()
        End If
    End Sub

    ' Métodos auxiliares
    Private Sub ConfigurarCamposParaNuevoGenero()
        Label1_Titulo.Text = "Nuevo Género"
        LimpiarCampos()
        TextBox_GeneroNum.Text = ModuleGenero.ObtenerSiguienteNumeroGenero
        TextBox_GeneroNum.Enabled = False
        TextBox_Genero.Enabled = True
        Button_Guardar.Text = "Guardar"
    End Sub


    Private Sub ConfigurarCamposParaModificar()
        Label1_Titulo.Text = "Modificar Género"
        TextBox_GeneroNum.Text = ""
        TextBox_GeneroNum.Enabled = True
        TextBox_Genero.Enabled = False
        Button_Guardar.Text = "Guardar"
        LimpiarCampos()
    End Sub

    Private Sub ConfigurarCamposParaEliminar()
        Label1_Titulo.Text = "Eliminar Género"
        TextBox_GeneroNum.Text = ""
        TextBox_GeneroNum.Enabled = True
        TextBox_Genero.Enabled = False
        Button_Guardar.Text = "Eliminar"
        LimpiarCampos()
    End Sub

    Private Sub LimpiarCampos()
        TextBox_GeneroNum.Text = ""
        TextBox_Genero.Text = ""
    End Sub

    Private Sub CargarDatosGenero()
        Dim numeroGenero As Integer
        If Integer.TryParse(TextBox_GeneroNum.Text, numeroGenero) Then
            Dim fila As DataRow = ModuleGenero.ObtenerGenero(numeroGenero)
            If fila IsNot Nothing Then
                TextBox_Genero.Text = fila("Nombre").ToString()

                If modoOperacion = "Modificar" Then
                    TextBox_Genero.Enabled = True
                End If
            Else
                MsgBox("No se encontró ningún registro con el número de género proporcionado.", MsgBoxStyle.Information, "Información")
                LimpiarCampos()
            End If
        End If
    End Sub

    Private Sub GuardarNuevoGenero()
        Dim nombre As String = TextBox_Genero.Text

        If ModuleGenero.AgregarGenero(nombre) Then
            CargarDatosListViewGenero()
            LimpiarCampos()
        End If
    End Sub

    Private Sub ModificarGeneroExistente()
        Dim numeroGenero As Integer
        If Integer.TryParse(TextBox_GeneroNum.Text, numeroGenero) Then
            Dim nombre As String = TextBox_Genero.Text

            If ModuleGenero.ModificarGenero(numeroGenero, nombre) Then
                CargarDatosListViewGenero()
                LimpiarCampos()
            End If
        Else
            MsgBox("El número de género debe ser un valor numérico.", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub EliminarGeneroExistente()
        Dim numeroGenero As Integer
        If Integer.TryParse(TextBox_GeneroNum.Text, numeroGenero) Then
            If ModuleGenero.EliminarGenero(numeroGenero) Then
                CargarDatosListViewGenero()
                LimpiarCampos()
            End If
        Else
            MsgBox("El número de género debe ser un valor numérico.", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub FormGenero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatosListViewGenero()
    End Sub

    Private Sub CargarDatosListViewGenero()
        ModuleGenero.CargarDatosListViewGenero(ListView_Genero)
    End Sub
End Class
