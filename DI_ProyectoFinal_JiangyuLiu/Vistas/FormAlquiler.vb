Imports System.Globalization

Public Class FormAlquiler
    Private modoOperacion As String = ""

    'Método para inicializar un nuevo alquiler
    Public Sub InicializarNuevoAlquiler()
        modoOperacion = "Agregar"
        ConfigurarCamposParaNuevoAlquiler()
    End Sub

    'Método para manejar el clic en el botón Guardar
    Private Sub Button_Guardar_Click(sender As Object, e As EventArgs) Handles Button_Guardar.Click
        Select Case modoOperacion
            Case "Agregar"
                GuardarNuevoAlquiler()
            Case "Eliminar"
                EliminarAlquilerExistente()
            Case "Modificar"
                ModificarAlquilerExistente()
            Case "Devolver"
                DevolverPelicula()
        End Select
    End Sub

    'Método para manejar el clic en el menú "Nuevo Alquiler"
    Private Sub NuevoAlquilerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoAlquilerToolStripMenuItem.Click
        modoOperacion = "Agregar"
        ConfigurarCamposParaNuevoAlquiler()
    End Sub

    'Método para manejar el clic en el menú "Borrar Alquiler"
    Private Sub BorrarAlquilerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrarAlquilerToolStripMenuItem.Click
        modoOperacion = "Eliminar"
        ConfigurarCamposParaEliminar()
    End Sub

    'Método para manejar el clic en el menú "Modificar"
    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        modoOperacion = "Modificar"
        ConfigurarCamposParaModificar()
    End Sub

    'Método para manejar el clic en el menú "Lista"
    Private Sub ListaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaToolStripMenuItem.Click
        Me.Hide()
        Alquiler.Show()
    End Sub

    'Método para inicializar la ventana para devolución
    Public Sub InicializarParaDevolucion()
        modoOperacion = "Devolver"
        ConfigurarCamposParaDevolucion()
    End Sub

    'Método para manejar la tecla Enter en el campo de número de préstamo
    Private Sub TextBox_NumPrestamo_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_NumPrestamo.KeyDown
        If e.KeyCode = Keys.Enter AndAlso (modoOperacion = "Eliminar" Or modoOperacion = "Modificar" Or modoOperacion = "Devolver") Then
            CargarDatosAlquiler()
        End If
    End Sub

    'Métodos auxiliares
    Private Sub ConfigurarCamposParaNuevoAlquiler()
        Dim nuevoNumeroPrestamo As Integer = ModuleAlquiler.ObtenerSiguienteNumeroPrestamo()
        TextBox_NumPrestamo.Text = nuevoNumeroPrestamo.ToString()
        TextBox_NumPrestamo.Enabled = False
        TextBox_NumSocio.Enabled = True
        TextBox_NumPelicula.Enabled = True
        TextBox_FechPrestamo.Text = Date.Today.ToString("yyyy-MM-dd")
        TextBox_FechDevolucion.Text = ""
        Button_Guardar.Text = "Guardar"
    End Sub

    Private Sub ConfigurarCamposParaEliminar()
        Label1_Titulo.Text = "Eliminar Película"
        TextBox_NumPrestamo.Text = ""
        TextBox_NumPrestamo.Enabled = True
        TextBox_NumSocio.Enabled = False
        TextBox_NumPelicula.Enabled = False
        TextBox_FechPrestamo.Enabled = False
        TextBox_FechDevolucion.Enabled = False
        Button_Guardar.Text = "Aceptar"
        LimpiarCampos()
    End Sub

    Private Sub ConfigurarCamposParaModificar()
        Label1_Titulo.Text = "Modificar Película"
        TextBox_NumPrestamo.Text = ""
        TextBox_NumPrestamo.Enabled = True
        TextBox_NumSocio.Enabled = False
        TextBox_NumPelicula.Enabled = False
        TextBox_FechPrestamo.Enabled = False
        TextBox_FechDevolucion.Enabled = False
        Button_Guardar.Text = "Guardar"
        LimpiarCampos()
    End Sub

    Private Sub ConfigurarCamposParaDevolucion()
        Label1_Titulo.Text = "Devolución"
        TextBox_NumPrestamo.Enabled = True
        TextBox_NumSocio.Enabled = False
        TextBox_NumPelicula.Enabled = False
        TextBox_FechPrestamo.Enabled = False
        TextBox_FechDevolucion.Enabled = False
        Button_Guardar.Text = "Aceptar"
        LimpiarCampos()
    End Sub

    Private Sub LimpiarCampos()
        TextBox_NumSocio.Text = ""
        TextBox_NumPelicula.Text = ""
        TextBox_FechPrestamo.Text = ""
        TextBox_FechDevolucion.Text = ""
    End Sub

    Private Sub CargarDatosAlquiler()
        Dim numeroPrestamo As Integer
        If Integer.TryParse(TextBox_NumPrestamo.Text, numeroPrestamo) Then
            Dim fila As DataRow = ModuleAlquiler.ObtenerAlquiler(numeroPrestamo)
            If fila IsNot Nothing Then
                TextBox_NumSocio.Text = fila("NumeroSocio").ToString()
                TextBox_NumPelicula.Text = fila("NumeroPelicula").ToString()

                ' FechaPrestamo como texto
                TextBox_FechPrestamo.Text = fila("FechaPrestamo").ToString()

                ' FechaDevolucion como texto (puede ser NULL)
                If Not fila.IsNull("FechaDevolucion") Then
                    TextBox_FechDevolucion.Text = fila("FechaDevolucion").ToString()
                Else
                    ' Si no hay fecha de devolución, se establece la fecha actual
                    TextBox_FechDevolucion.Text = Date.Today.ToString("yyyy-MM-dd")
                End If

                ' Habilitar solo el campo de fecha de devolución en modo "Devolver"
                If modoOperacion = "Devolver" Then
                    TextBox_FechDevolucion.Enabled = True
                ElseIf modoOperacion = "Modificar" Then
                    TextBox_NumSocio.Enabled = True
                    TextBox_NumPelicula.Enabled = True
                    TextBox_FechPrestamo.Enabled = True
                    TextBox_FechDevolucion.Enabled = True
                End If
            Else
                MsgBox("No se encontró ningún registro con el número de préstamo proporcionado.", MsgBoxStyle.Information, "Información")
                LimpiarCampos()
            End If
        End If
    End Sub

    Private Sub GuardarNuevoAlquiler()
        Dim numeroSocio As Integer
        Dim numeroPelicula As Integer
        If Not Integer.TryParse(TextBox_NumSocio.Text, numeroSocio) OrElse Not Integer.TryParse(TextBox_NumPelicula.Text, numeroPelicula) Then
            MsgBox("Los números de socio y película deben ser valores numéricos.", MsgBoxStyle.Critical, "Error")
            Return
        End If
        Dim fechaPrestamo As String = TextBox_FechPrestamo.Text
        Dim fechaDevolucion As String = TextBox_FechDevolucion.Text
        ModuleAlquiler.AgregarAlquiler(numeroSocio, numeroPelicula, fechaPrestamo, fechaDevolucion)
    End Sub

    Private Sub EliminarAlquilerExistente()
        Dim numeroPrestamo As Integer
        If Not Integer.TryParse(TextBox_NumPrestamo.Text, numeroPrestamo) Then
            MsgBox("El número de préstamo debe ser un valor numérico.", MsgBoxStyle.Critical, "Error")
            Return
        End If
        ModuleAlquiler.EliminarAlquiler(numeroPrestamo)
    End Sub

    Private Sub ModificarAlquilerExistente()
        Dim numeroPrestamo As Integer
        Dim numeroSocio As Integer
        Dim numeroPelicula As Integer
        If Not Integer.TryParse(TextBox_NumPrestamo.Text, numeroPrestamo) OrElse Not Integer.TryParse(TextBox_NumSocio.Text, numeroSocio) OrElse Not Integer.TryParse(TextBox_NumPelicula.Text, numeroPelicula) Then
            MsgBox("Los números de préstamo, socio y película deben ser valores numéricos.", MsgBoxStyle.Critical, "Error")
            Return
        End If
        Dim fechaPrestamo As String = TextBox_FechPrestamo.Text
        Dim fechaDevolucion As String = TextBox_FechDevolucion.Text
        ModuleAlquiler.ModificarAlquiler(numeroPrestamo, numeroSocio, numeroPelicula, fechaPrestamo, fechaDevolucion)
    End Sub

    Private Sub DevolverPelicula()
        Dim numeroPrestamo As Integer
        If Not Integer.TryParse(TextBox_NumPrestamo.Text, numeroPrestamo) Then
            MsgBox("El número de préstamo debe ser un valor numérico.", MsgBoxStyle.Critical, "Error")
            Return
        End If
        Dim fechaDevolucion As String = TextBox_FechDevolucion.Text
        If ModuleAlquiler.ActualizarFechaDevolucion(numeroPrestamo, fechaDevolucion) Then
            Me.Hide()
            Alquiler.Show()
        End If
    End Sub
End Class