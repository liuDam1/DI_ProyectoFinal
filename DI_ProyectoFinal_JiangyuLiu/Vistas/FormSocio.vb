Imports System.Globalization

Public Class FormSocio
    Private modoOperacion As String = ""

    ' Método para inicializar un nuevo socio
    Public Sub InicializarNuevoSocio()
        modoOperacion = "Agregar"
        ConfigurarCamposParaNuevoSocio()
    End Sub

    ' Método para manejar el clic en el botón Guardar
    Private Sub Button_Guardar_Click(sender As Object, e As EventArgs) Handles Button_Guardar.Click
        Select Case modoOperacion
            Case "Agregar"
                GuardarNuevoSocio()
            Case "Modificar"
                ModificarSocioExistente()
            Case "Eliminar"
                EliminarSocioExistente()
        End Select
    End Sub

    ' Método para manejar el clic en el menú "Nuevo Socio"
    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem.Click
        modoOperacion = "Agregar"
        ConfigurarCamposParaNuevoSocio()
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
        Socio.Show()
    End Sub

    ' Método para manejar la tecla Enter en el campo de número de socio
    Private Sub TextBox_NumSocio_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_NumSocio.KeyDown
        If e.KeyCode = Keys.Enter AndAlso (modoOperacion = "Modificar" Or modoOperacion = "Eliminar") Then
            CargarDatosSocio()
        End If
    End Sub

    ' Métodos auxiliares
    Private Sub ConfigurarCamposParaNuevoSocio()
        Label1_Titulo.Text = "Nuevo Socio"
        TextBox_NumSocio.Text = ObtenerSiguienteNumeroSocio().ToString()
        TextBox_NumSocio.Enabled = False
        TextBox_NombreSocio.Enabled = True
        TextBoxApellidoSocio.Enabled = True
        TextBox_DniSocio.Enabled = True
        TextBox_TelefonoSocio.Enabled = True
        TextBox_DireccionSocio.Enabled = True
        Button_Guardar.Text = "Guardar"
        LimpiarCampos()
    End Sub

    Private Sub ConfigurarCamposParaModificar()
        Label1_Titulo.Text = "Modificar Socio"
        TextBox_NumSocio.Text = ""
        TextBox_NumSocio.Enabled = True
        TextBox_NombreSocio.Enabled = False
        TextBoxApellidoSocio.Enabled = False
        TextBox_DniSocio.Enabled = False
        TextBox_TelefonoSocio.Enabled = False
        TextBox_DireccionSocio.Enabled = False
        Button_Guardar.Text = "Guardar"
        LimpiarCampos()
    End Sub

    Private Sub ConfigurarCamposParaEliminar()
        Label1_Titulo.Text = "Eliminar Socio"
        TextBox_NumSocio.Text = ""
        TextBox_NumSocio.Enabled = True
        TextBox_NombreSocio.Enabled = False
        TextBoxApellidoSocio.Enabled = False
        TextBox_DniSocio.Enabled = False
        TextBox_TelefonoSocio.Enabled = False
        TextBox_DireccionSocio.Enabled = False
        Button_Guardar.Text = "Eliminar"
        LimpiarCampos()
    End Sub

    Private Sub LimpiarCampos()
        TextBox_NombreSocio.Text = ""
        TextBoxApellidoSocio.Text = ""
        TextBox_DniSocio.Text = ""
        TextBox_TelefonoSocio.Text = ""
        TextBox_DireccionSocio.Text = ""
    End Sub

    Private Sub CargarDatosSocio()
        Dim numeroSocio As Integer
        If Integer.TryParse(TextBox_NumSocio.Text, numeroSocio) Then
            Dim fila As DataRow = ModuloSocio.ObtenerSocio(numeroSocio)
            If fila IsNot Nothing Then
                TextBox_NombreSocio.Text = fila("Nombre").ToString()
                TextBoxApellidoSocio.Text = fila("Apellido").ToString()
                TextBox_DniSocio.Text = fila("DNI").ToString()
                TextBox_TelefonoSocio.Text = fila("Telefono").ToString()
                TextBox_DireccionSocio.Text = fila("Direccion").ToString()

                If modoOperacion = "Modificar" Then
                    TextBox_NombreSocio.Enabled = True
                    TextBoxApellidoSocio.Enabled = True
                    TextBox_DniSocio.Enabled = True
                    TextBox_TelefonoSocio.Enabled = True
                    TextBox_DireccionSocio.Enabled = True
                End If
            Else
                MsgBox("No se encontró ningún registro con el número de socio proporcionado.", MsgBoxStyle.Information, "Información")
                LimpiarCampos()
            End If
        End If
    End Sub

    Private Sub GuardarNuevoSocio()
        Dim numeroSocio As Integer = ObtenerSiguienteNumeroSocio()
        Dim nombre As String = TextBox_NombreSocio.Text
        Dim apellido As String = TextBoxApellidoSocio.Text
        Dim dni As String = TextBox_DniSocio.Text
        Dim direccion As String = TextBox_DireccionSocio.Text
        Dim telefono As String = TextBox_TelefonoSocio.Text

        If ModuloSocio.AgregarSocio(numeroSocio, nombre, apellido, dni, direccion, telefono) Then
            Me.Hide()
            Socio.Show()
        End If
    End Sub


    Private Sub ModificarSocioExistente()
        Dim numeroSocio As Integer
        If Integer.TryParse(TextBox_NumSocio.Text, numeroSocio) Then
            Dim nombre As String = TextBox_NombreSocio.Text
            Dim apellido As String = TextBoxApellidoSocio.Text
            Dim dni As String = TextBox_DniSocio.Text
            Dim direccion As String = TextBox_DireccionSocio.Text
            Dim telefono As String = TextBox_TelefonoSocio.Text

            If ModuloSocio.ModificarSocio(numeroSocio, nombre, apellido, dni, direccion, telefono) Then
                Me.Hide()
                Socio.Show()
            End If
        Else
            MsgBox("El número de socio debe ser un valor numérico.", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub EliminarSocioExistente()
        Dim numeroSocio As Integer
        If Integer.TryParse(TextBox_NumSocio.Text, numeroSocio) Then
            If ModuloSocio.EliminarSocio(numeroSocio) Then
                Me.Hide()
                Socio.Show()
            End If
        Else
            MsgBox("El número de socio debe ser un valor numérico.", MsgBoxStyle.Critical, "Error")
        End If
    End Sub
End Class
