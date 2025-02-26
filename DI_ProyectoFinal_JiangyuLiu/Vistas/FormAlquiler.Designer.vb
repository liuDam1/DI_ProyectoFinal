<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAlquiler
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAlquiler))
        MenuStrip1 = New MenuStrip()
        NuevoAlquilerToolStripMenuItem = New ToolStripMenuItem()
        BorrarAlquilerToolStripMenuItem = New ToolStripMenuItem()
        ModificarToolStripMenuItem = New ToolStripMenuItem()
        ListaToolStripMenuItem = New ToolStripMenuItem()
        Tabla_Layaut = New TableLayoutPanel()
        TableLayoutPanel1 = New TableLayoutPanel()
        PictureBox1 = New PictureBox()
        Label1_Titulo = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        TableLayoutPanel3 = New TableLayoutPanel()
        Button_Guardar = New Button()
        TableLayoutPanel4 = New TableLayoutPanel()
        Label_NumSocio = New Label()
        Label_NumPelicula = New Label()
        TextBox_NumPrestamo = New TextBox()
        TextBox_NumSocio = New TextBox()
        TextBox_NumPelicula = New TextBox()
        TextBox_FechPrestamo = New TextBox()
        TextBox_FechDevolucion = New TextBox()
        Label_NumPrestamo = New Label()
        Label_Fech_Devolucion = New Label()
        Label_FechPrestamo = New Label()
        MenuStrip1.SuspendLayout()
        Tabla_Layaut.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = SystemColors.ControlLight
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {NuevoAlquilerToolStripMenuItem, BorrarAlquilerToolStripMenuItem, ModificarToolStripMenuItem, ListaToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1306, 33)
        MenuStrip1.TabIndex = 2
        MenuStrip1.Text = "MenuStrip_Alquiler"
        ' 
        ' NuevoAlquilerToolStripMenuItem
        ' 
        NuevoAlquilerToolStripMenuItem.Name = "NuevoAlquilerToolStripMenuItem"
        NuevoAlquilerToolStripMenuItem.Size = New Size(80, 29)
        NuevoAlquilerToolStripMenuItem.Text = "Nuevo"
        ' 
        ' BorrarAlquilerToolStripMenuItem
        ' 
        BorrarAlquilerToolStripMenuItem.Name = "BorrarAlquilerToolStripMenuItem"
        BorrarAlquilerToolStripMenuItem.Size = New Size(90, 29)
        BorrarAlquilerToolStripMenuItem.Text = "Eliminar"
        ' 
        ' ModificarToolStripMenuItem
        ' 
        ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        ModificarToolStripMenuItem.Size = New Size(103, 29)
        ModificarToolStripMenuItem.Text = "Modificar"
        ' 
        ' ListaToolStripMenuItem
        ' 
        ListaToolStripMenuItem.Name = "ListaToolStripMenuItem"
        ListaToolStripMenuItem.Size = New Size(124, 29)
        ListaToolStripMenuItem.Text = "Volver Inicio"
        ' 
        ' Tabla_Layaut
        ' 
        Tabla_Layaut.BackColor = SystemColors.ControlLightLight
        Tabla_Layaut.ColumnCount = 2
        Tabla_Layaut.ColumnStyles.Add(New ColumnStyle())
        Tabla_Layaut.ColumnStyles.Add(New ColumnStyle())
        Tabla_Layaut.Controls.Add(TableLayoutPanel1, 1, 2)
        Tabla_Layaut.Controls.Add(TableLayoutPanel2, 1, 3)
        Tabla_Layaut.Dock = DockStyle.Fill
        Tabla_Layaut.Location = New Point(0, 33)
        Tabla_Layaut.Name = "Tabla_Layaut"
        Tabla_Layaut.RowCount = 4
        Tabla_Layaut.RowStyles.Add(New RowStyle())
        Tabla_Layaut.RowStyles.Add(New RowStyle())
        Tabla_Layaut.RowStyles.Add(New RowStyle())
        Tabla_Layaut.RowStyles.Add(New RowStyle())
        Tabla_Layaut.Size = New Size(1306, 692)
        Tabla_Layaut.TabIndex = 4
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = SystemColors.ControlLightLight
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.Controls.Add(PictureBox1, 0, 0)
        TableLayoutPanel1.Controls.Add(Label1_Titulo, 1, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(3, 3)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.Size = New Size(1300, 101)
        TableLayoutPanel1.TabIndex = 2
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox1.BackColor = SystemColors.ControlLightLight
        PictureBox1.Image = My.Resources.Resources.Logo__1_
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(144, 98)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label1_Titulo
        ' 
        Label1_Titulo.AutoSize = True
        Label1_Titulo.BackColor = SystemColors.ActiveCaption
        Label1_Titulo.Dock = DockStyle.Fill
        Label1_Titulo.Font = New Font("Segoe UI", 39.0F)
        Label1_Titulo.ForeColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        Label1_Titulo.Location = New Point(153, 0)
        Label1_Titulo.Name = "Label1_Titulo"
        Label1_Titulo.Size = New Size(1144, 104)
        Label1_Titulo.TabIndex = 2
        Label1_Titulo.Text = "Nueva Alquiler"
        Label1_Titulo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel2.Controls.Add(TableLayoutPanel3, 0, 1)
        TableLayoutPanel2.Controls.Add(TableLayoutPanel4, 0, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(3, 110)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 80.0F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
        TableLayoutPanel2.Size = New Size(1300, 579)
        TableLayoutPanel2.TabIndex = 3
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        TableLayoutPanel3.ColumnCount = 1
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel3.Controls.Add(Button_Guardar, 0, 0)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(3, 466)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        TableLayoutPanel3.Size = New Size(1294, 110)
        TableLayoutPanel3.TabIndex = 1
        ' 
        ' Button_Guardar
        ' 
        Button_Guardar.Anchor = AnchorStyles.None
        Button_Guardar.AutoSize = True
        Button_Guardar.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        Button_Guardar.FlatAppearance.BorderColor = SystemColors.ActiveCaption
        Button_Guardar.FlatAppearance.BorderSize = 5
        Button_Guardar.FlatStyle = FlatStyle.Flat
        Button_Guardar.Font = New Font("Segoe UI", 19.0F)
        Button_Guardar.ForeColor = SystemColors.ActiveCaption
        Button_Guardar.Location = New Point(497, 12)
        Button_Guardar.MaximumSize = New Size(300, 86)
        Button_Guardar.MinimumSize = New Size(300, 86)
        Button_Guardar.Name = "Button_Guardar"
        Button_Guardar.Size = New Size(300, 86)
        Button_Guardar.TabIndex = 0
        Button_Guardar.Text = "Guardar"
        Button_Guardar.UseVisualStyleBackColor = False
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.AutoSize = True
        TableLayoutPanel4.BackColor = SystemColors.ControlLight
        TableLayoutPanel4.ColumnCount = 2
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel4.Controls.Add(Label_NumSocio, 0, 1)
        TableLayoutPanel4.Controls.Add(Label_NumPelicula, 0, 2)
        TableLayoutPanel4.Controls.Add(TextBox_NumPrestamo, 1, 0)
        TableLayoutPanel4.Controls.Add(TextBox_NumSocio, 1, 1)
        TableLayoutPanel4.Controls.Add(TextBox_NumPelicula, 1, 2)
        TableLayoutPanel4.Controls.Add(TextBox_FechPrestamo, 1, 3)
        TableLayoutPanel4.Controls.Add(TextBox_FechDevolucion, 1, 4)
        TableLayoutPanel4.Controls.Add(Label_NumPrestamo, 0, 0)
        TableLayoutPanel4.Controls.Add(Label_Fech_Devolucion, 0, 4)
        TableLayoutPanel4.Controls.Add(Label_FechPrestamo, 0, 3)
        TableLayoutPanel4.Dock = DockStyle.Fill
        TableLayoutPanel4.Location = New Point(3, 3)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 5
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
        TableLayoutPanel4.Size = New Size(1294, 457)
        TableLayoutPanel4.TabIndex = 2
        ' 
        ' Label_NumSocio
        ' 
        Label_NumSocio.Anchor = AnchorStyles.Right
        Label_NumSocio.AutoSize = True
        Label_NumSocio.Font = New Font("Segoe UI", 19.0F)
        Label_NumSocio.Location = New Point(432, 111)
        Label_NumSocio.Margin = New Padding(3, 0, 30, 0)
        Label_NumSocio.Name = "Label_NumSocio"
        Label_NumSocio.Size = New Size(185, 51)
        Label_NumSocio.TabIndex = 1
        Label_NumSocio.Text = "Nº Socio :"
        Label_NumSocio.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label_NumPelicula
        ' 
        Label_NumPelicula.Anchor = AnchorStyles.Right
        Label_NumPelicula.AutoSize = True
        Label_NumPelicula.Font = New Font("Segoe UI", 19.0F)
        Label_NumPelicula.Location = New Point(397, 202)
        Label_NumPelicula.Margin = New Padding(3, 0, 30, 0)
        Label_NumPelicula.Name = "Label_NumPelicula"
        Label_NumPelicula.Size = New Size(220, 51)
        Label_NumPelicula.TabIndex = 2
        Label_NumPelicula.Text = "Nº Pelicula :"
        Label_NumPelicula.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TextBox_NumPrestamo
        ' 
        TextBox_NumPrestamo.Anchor = AnchorStyles.Left
        TextBox_NumPrestamo.Font = New Font("Segoe UI", 19.0F)
        TextBox_NumPrestamo.ForeColor = Color.Red
        TextBox_NumPrestamo.Location = New Point(650, 16)
        TextBox_NumPrestamo.Name = "TextBox_NumPrestamo"
        TextBox_NumPrestamo.Size = New Size(192, 58)
        TextBox_NumPrestamo.TabIndex = 5
        TextBox_NumPrestamo.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox_NumSocio
        ' 
        TextBox_NumSocio.Anchor = AnchorStyles.Left
        TextBox_NumSocio.Font = New Font("Segoe UI", 19.0F)
        TextBox_NumSocio.Location = New Point(650, 107)
        TextBox_NumSocio.Name = "TextBox_NumSocio"
        TextBox_NumSocio.Size = New Size(192, 58)
        TextBox_NumSocio.TabIndex = 6
        ' 
        ' TextBox_NumPelicula
        ' 
        TextBox_NumPelicula.Anchor = AnchorStyles.Left
        TextBox_NumPelicula.Font = New Font("Segoe UI", 19.0F)
        TextBox_NumPelicula.Location = New Point(650, 198)
        TextBox_NumPelicula.Name = "TextBox_NumPelicula"
        TextBox_NumPelicula.Size = New Size(192, 58)
        TextBox_NumPelicula.TabIndex = 7
        ' 
        ' TextBox_FechPrestamo
        ' 
        TextBox_FechPrestamo.Anchor = AnchorStyles.Left
        TextBox_FechPrestamo.Font = New Font("Segoe UI", 19.0F)
        TextBox_FechPrestamo.Location = New Point(650, 289)
        TextBox_FechPrestamo.Name = "TextBox_FechPrestamo"
        TextBox_FechPrestamo.Size = New Size(394, 58)
        TextBox_FechPrestamo.TabIndex = 8
        ' 
        ' TextBox_FechDevolucion
        ' 
        TextBox_FechDevolucion.Anchor = AnchorStyles.Left
        TextBox_FechDevolucion.Font = New Font("Segoe UI", 19.0F)
        TextBox_FechDevolucion.Location = New Point(650, 381)
        TextBox_FechDevolucion.Name = "TextBox_FechDevolucion"
        TextBox_FechDevolucion.Size = New Size(394, 58)
        TextBox_FechDevolucion.TabIndex = 9
        ' 
        ' Label_NumPrestamo
        ' 
        Label_NumPrestamo.Anchor = AnchorStyles.Right
        Label_NumPrestamo.AutoSize = True
        Label_NumPrestamo.Font = New Font("Segoe UI", 19.0F)
        Label_NumPrestamo.ForeColor = Color.Red
        Label_NumPrestamo.Location = New Point(366, 20)
        Label_NumPrestamo.Margin = New Padding(3, 0, 30, 0)
        Label_NumPrestamo.Name = "Label_NumPrestamo"
        Label_NumPrestamo.Size = New Size(251, 51)
        Label_NumPrestamo.TabIndex = 0
        Label_NumPrestamo.Text = "Nº Prestamo :"
        Label_NumPrestamo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label_Fech_Devolucion
        ' 
        Label_Fech_Devolucion.Anchor = AnchorStyles.Right
        Label_Fech_Devolucion.AutoSize = True
        Label_Fech_Devolucion.Font = New Font("Segoe UI", 19.0F)
        Label_Fech_Devolucion.Location = New Point(280, 385)
        Label_Fech_Devolucion.Margin = New Padding(3, 0, 30, 0)
        Label_Fech_Devolucion.Name = "Label_Fech_Devolucion"
        Label_Fech_Devolucion.Size = New Size(337, 51)
        Label_Fech_Devolucion.TabIndex = 3
        Label_Fech_Devolucion.Text = "Fecha Devolución :"
        Label_Fech_Devolucion.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label_FechPrestamo
        ' 
        Label_FechPrestamo.Anchor = AnchorStyles.Right
        Label_FechPrestamo.AutoSize = True
        Label_FechPrestamo.Font = New Font("Segoe UI", 19.0F)
        Label_FechPrestamo.Location = New Point(312, 293)
        Label_FechPrestamo.Margin = New Padding(3, 0, 30, 0)
        Label_FechPrestamo.Name = "Label_FechPrestamo"
        Label_FechPrestamo.Size = New Size(305, 51)
        Label_FechPrestamo.TabIndex = 4
        Label_FechPrestamo.Text = "Fecha Prestamo :"
        Label_FechPrestamo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' FormAlquiler
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1306, 725)
        Controls.Add(Tabla_Layaut)
        Controls.Add(MenuStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimumSize = New Size(1328, 781)
        Name = "FormAlquiler"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Formulario Alquiler"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        Tabla_Layaut.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel4.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Tabla_Layaut As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1_Titulo As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Button_Guardar As Button
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label_NumPrestamo As Label
    Friend WithEvents Label_NumSocio As Label
    Friend WithEvents Label_NumPelicula As Label
    Friend WithEvents Label_Fech_Devolucion As Label
    Friend WithEvents Label_FechPrestamo As Label
    Friend WithEvents TextBox_NumPrestamo As TextBox
    Friend WithEvents TextBox_NumSocio As TextBox
    Friend WithEvents TextBox_NumPelicula As TextBox
    Friend WithEvents TextBox_FechPrestamo As TextBox
    Friend WithEvents TextBox_FechDevolucion As TextBox
    Friend WithEvents NuevoAlquilerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorrarAlquilerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaToolStripMenuItem As ToolStripMenuItem
End Class
