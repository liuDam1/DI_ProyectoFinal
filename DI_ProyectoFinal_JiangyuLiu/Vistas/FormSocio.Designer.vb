<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSocio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSocio))
        Tabla_Layaut = New TableLayoutPanel()
        TableLayoutPanel1 = New TableLayoutPanel()
        PictureBox1 = New PictureBox()
        Label1_Titulo = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        TableLayoutPanel4 = New TableLayoutPanel()
        Label_NumSocio = New Label()
        Label_NombreSocio = New Label()
        Label_ApellidoSocio = New Label()
        Label_DniSocio = New Label()
        Label_TelefonoSocio = New Label()
        Label_DireccionSocio = New Label()
        TextBox_NumSocio = New TextBox()
        TextBox_NombreSocio = New TextBox()
        TextBoxApellidoSocio = New TextBox()
        TextBox_DniSocio = New TextBox()
        TextBox_TelefonoSocio = New TextBox()
        TextBox_DireccionSocio = New TextBox()
        MenuStrip1 = New MenuStrip()
        AgregarToolStripMenuItem = New ToolStripMenuItem()
        EliminarToolStripMenuItem = New ToolStripMenuItem()
        ModificarToolStripMenuItem = New ToolStripMenuItem()
        VolverInicioToolStripMenuItem = New ToolStripMenuItem()
        TableLayoutPanel3 = New TableLayoutPanel()
        Button_Guardar = New Button()
        Tabla_Layaut.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        MenuStrip1.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        SuspendLayout()
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
        Tabla_Layaut.TabIndex = 6
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
        Label1_Titulo.Font = New Font("Segoe UI", 39F)
        Label1_Titulo.ForeColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        Label1_Titulo.Location = New Point(153, 0)
        Label1_Titulo.Name = "Label1_Titulo"
        Label1_Titulo.Size = New Size(1144, 104)
        Label1_Titulo.TabIndex = 2
        Label1_Titulo.Text = "Nuevo Socio"
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
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 80F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel2.Size = New Size(1300, 579)
        TableLayoutPanel2.TabIndex = 3
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.BackColor = SystemColors.ControlLight
        TableLayoutPanel4.ColumnCount = 2
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Controls.Add(Label_NumSocio, 0, 0)
        TableLayoutPanel4.Controls.Add(Label_NombreSocio, 0, 1)
        TableLayoutPanel4.Controls.Add(Label_ApellidoSocio, 0, 2)
        TableLayoutPanel4.Controls.Add(Label_DniSocio, 0, 3)
        TableLayoutPanel4.Controls.Add(Label_TelefonoSocio, 0, 4)
        TableLayoutPanel4.Controls.Add(Label_DireccionSocio, 0, 5)
        TableLayoutPanel4.Controls.Add(TextBox_NumSocio, 1, 0)
        TableLayoutPanel4.Controls.Add(TextBox_NombreSocio, 1, 1)
        TableLayoutPanel4.Controls.Add(TextBoxApellidoSocio, 1, 2)
        TableLayoutPanel4.Controls.Add(TextBox_DniSocio, 1, 3)
        TableLayoutPanel4.Controls.Add(TextBox_TelefonoSocio, 1, 4)
        TableLayoutPanel4.Controls.Add(TextBox_DireccionSocio, 1, 5)
        TableLayoutPanel4.Dock = DockStyle.Fill
        TableLayoutPanel4.Location = New Point(3, 3)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 6
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 16.6666679F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 16.6666679F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 16.6666679F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 16.6666679F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 16.6666679F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 16.6666679F))
        TableLayoutPanel4.Size = New Size(1294, 457)
        TableLayoutPanel4.TabIndex = 2
        ' 
        ' Label_NumSocio
        ' 
        Label_NumSocio.Anchor = AnchorStyles.Right
        Label_NumSocio.AutoSize = True
        Label_NumSocio.Font = New Font("Segoe UI", 19F)
        Label_NumSocio.ForeColor = Color.Red
        Label_NumSocio.Location = New Point(442, 12)
        Label_NumSocio.Margin = New Padding(3, 0, 10, 0)
        Label_NumSocio.Name = "Label_NumSocio"
        Label_NumSocio.Size = New Size(195, 51)
        Label_NumSocio.TabIndex = 0
        Label_NumSocio.Text = "Nº Socio : "
        ' 
        ' Label_NombreSocio
        ' 
        Label_NombreSocio.Anchor = AnchorStyles.Right
        Label_NombreSocio.AutoSize = True
        Label_NombreSocio.Font = New Font("Segoe UI", 19F)
        Label_NombreSocio.Location = New Point(449, 88)
        Label_NombreSocio.Margin = New Padding(3, 0, 10, 0)
        Label_NombreSocio.Name = "Label_NombreSocio"
        Label_NombreSocio.Size = New Size(188, 51)
        Label_NombreSocio.TabIndex = 1
        Label_NombreSocio.Text = "Nombre : "
        ' 
        ' Label_ApellidoSocio
        ' 
        Label_ApellidoSocio.Anchor = AnchorStyles.Right
        Label_ApellidoSocio.AutoSize = True
        Label_ApellidoSocio.Font = New Font("Segoe UI", 19F)
        Label_ApellidoSocio.Location = New Point(449, 164)
        Label_ApellidoSocio.Margin = New Padding(3, 0, 10, 0)
        Label_ApellidoSocio.Name = "Label_ApellidoSocio"
        Label_ApellidoSocio.Size = New Size(188, 51)
        Label_ApellidoSocio.TabIndex = 2
        Label_ApellidoSocio.Text = "Apellido : "
        ' 
        ' Label_DniSocio
        ' 
        Label_DniSocio.Anchor = AnchorStyles.Right
        Label_DniSocio.AutoSize = True
        Label_DniSocio.Font = New Font("Segoe UI", 19F)
        Label_DniSocio.Location = New Point(522, 240)
        Label_DniSocio.Margin = New Padding(3, 0, 10, 0)
        Label_DniSocio.Name = "Label_DniSocio"
        Label_DniSocio.Size = New Size(115, 51)
        Label_DniSocio.TabIndex = 3
        Label_DniSocio.Text = "DNI : "
        ' 
        ' Label_TelefonoSocio
        ' 
        Label_TelefonoSocio.Anchor = AnchorStyles.Right
        Label_TelefonoSocio.AutoSize = True
        Label_TelefonoSocio.Font = New Font("Segoe UI", 19F)
        Label_TelefonoSocio.Location = New Point(444, 316)
        Label_TelefonoSocio.Margin = New Padding(3, 0, 10, 0)
        Label_TelefonoSocio.Name = "Label_TelefonoSocio"
        Label_TelefonoSocio.Size = New Size(193, 51)
        Label_TelefonoSocio.TabIndex = 4
        Label_TelefonoSocio.Text = "Teléfono : "
        ' 
        ' Label_DireccionSocio
        ' 
        Label_DireccionSocio.Anchor = AnchorStyles.Right
        Label_DireccionSocio.AutoSize = True
        Label_DireccionSocio.Font = New Font("Segoe UI", 19F)
        Label_DireccionSocio.Location = New Point(429, 393)
        Label_DireccionSocio.Margin = New Padding(3, 0, 10, 0)
        Label_DireccionSocio.Name = "Label_DireccionSocio"
        Label_DireccionSocio.Size = New Size(208, 51)
        Label_DireccionSocio.TabIndex = 5
        Label_DireccionSocio.Text = "Dirección : "
        ' 
        ' TextBox_NumSocio
        ' 
        TextBox_NumSocio.Anchor = AnchorStyles.Left
        TextBox_NumSocio.Font = New Font("Segoe UI", 19F)
        TextBox_NumSocio.ForeColor = Color.Red
        TextBox_NumSocio.Location = New Point(657, 9)
        TextBox_NumSocio.Margin = New Padding(10, 3, 3, 3)
        TextBox_NumSocio.Name = "TextBox_NumSocio"
        TextBox_NumSocio.Size = New Size(150, 58)
        TextBox_NumSocio.TabIndex = 6
        TextBox_NumSocio.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox_NombreSocio
        ' 
        TextBox_NombreSocio.Anchor = AnchorStyles.Left
        TextBox_NombreSocio.Font = New Font("Segoe UI", 19F)
        TextBox_NombreSocio.Location = New Point(657, 85)
        TextBox_NombreSocio.Margin = New Padding(10, 3, 3, 3)
        TextBox_NombreSocio.Name = "TextBox_NombreSocio"
        TextBox_NombreSocio.Size = New Size(347, 58)
        TextBox_NombreSocio.TabIndex = 7
        ' 
        ' TextBoxApellidoSocio
        ' 
        TextBoxApellidoSocio.Anchor = AnchorStyles.Left
        TextBoxApellidoSocio.Font = New Font("Segoe UI", 19F)
        TextBoxApellidoSocio.Location = New Point(657, 161)
        TextBoxApellidoSocio.Margin = New Padding(10, 3, 3, 3)
        TextBoxApellidoSocio.Name = "TextBoxApellidoSocio"
        TextBoxApellidoSocio.Size = New Size(347, 58)
        TextBoxApellidoSocio.TabIndex = 8
        ' 
        ' TextBox_DniSocio
        ' 
        TextBox_DniSocio.Anchor = AnchorStyles.Left
        TextBox_DniSocio.Font = New Font("Segoe UI", 19F)
        TextBox_DniSocio.Location = New Point(657, 237)
        TextBox_DniSocio.Margin = New Padding(10, 3, 3, 3)
        TextBox_DniSocio.Name = "TextBox_DniSocio"
        TextBox_DniSocio.Size = New Size(347, 58)
        TextBox_DniSocio.TabIndex = 9
        ' 
        ' TextBox_TelefonoSocio
        ' 
        TextBox_TelefonoSocio.Anchor = AnchorStyles.Left
        TextBox_TelefonoSocio.Font = New Font("Segoe UI", 19F)
        TextBox_TelefonoSocio.Location = New Point(657, 313)
        TextBox_TelefonoSocio.Margin = New Padding(10, 3, 3, 3)
        TextBox_TelefonoSocio.Name = "TextBox_TelefonoSocio"
        TextBox_TelefonoSocio.Size = New Size(347, 58)
        TextBox_TelefonoSocio.TabIndex = 10
        ' 
        ' TextBox_DireccionSocio
        ' 
        TextBox_DireccionSocio.Anchor = AnchorStyles.Left
        TextBox_DireccionSocio.Font = New Font("Segoe UI", 19F)
        TextBox_DireccionSocio.Location = New Point(657, 389)
        TextBox_DireccionSocio.Margin = New Padding(10, 3, 3, 3)
        TextBox_DireccionSocio.Name = "TextBox_DireccionSocio"
        TextBox_DireccionSocio.Size = New Size(587, 58)
        TextBox_DireccionSocio.TabIndex = 11
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = SystemColors.ControlLight
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {AgregarToolStripMenuItem, EliminarToolStripMenuItem, ModificarToolStripMenuItem, VolverInicioToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1306, 33)
        MenuStrip1.TabIndex = 5
        MenuStrip1.Text = "MenuStrip_Socio"
        ' 
        ' AgregarToolStripMenuItem
        ' 
        AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        AgregarToolStripMenuItem.Size = New Size(80, 29)
        AgregarToolStripMenuItem.Text = "Nuevo"
        ' 
        ' EliminarToolStripMenuItem
        ' 
        EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        EliminarToolStripMenuItem.Size = New Size(90, 29)
        EliminarToolStripMenuItem.Text = "Eliminar"
        ' 
        ' ModificarToolStripMenuItem
        ' 
        ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        ModificarToolStripMenuItem.Size = New Size(103, 29)
        ModificarToolStripMenuItem.Text = "Modificar"
        ' 
        ' VolverInicioToolStripMenuItem
        ' 
        VolverInicioToolStripMenuItem.Name = "VolverInicioToolStripMenuItem"
        VolverInicioToolStripMenuItem.Size = New Size(126, 29)
        VolverInicioToolStripMenuItem.Text = "Volver Socio"
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        TableLayoutPanel3.ColumnCount = 1
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Controls.Add(Button_Guardar, 0, 0)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(3, 466)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.Size = New Size(1294, 110)
        TableLayoutPanel3.TabIndex = 3
        ' 
        ' Button_Guardar
        ' 
        Button_Guardar.Anchor = AnchorStyles.None
        Button_Guardar.AutoSize = True
        Button_Guardar.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        Button_Guardar.FlatAppearance.BorderColor = SystemColors.ActiveCaption
        Button_Guardar.FlatAppearance.BorderSize = 5
        Button_Guardar.FlatStyle = FlatStyle.Flat
        Button_Guardar.Font = New Font("Segoe UI", 19F)
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
        ' FormSocio
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(1306, 725)
        Controls.Add(Tabla_Layaut)
        Controls.Add(MenuStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimumSize = New Size(1328, 781)
        Name = "FormSocio"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Formulario Socio"
        Tabla_Layaut.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel4.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Tabla_Layaut As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1_Titulo As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label_NumSocio As Label
    Friend WithEvents Label_NombreSocio As Label
    Friend WithEvents Label_ApellidoSocio As Label
    Friend WithEvents Label_DniSocio As Label
    Friend WithEvents Label_TelefonoSocio As Label
    Friend WithEvents Label_DireccionSocio As Label
    Friend WithEvents TextBox_NumSocio As TextBox
    Friend WithEvents TextBox_NombreSocio As TextBox
    Friend WithEvents TextBoxApellidoSocio As TextBox
    Friend WithEvents TextBox_DniSocio As TextBox
    Friend WithEvents TextBox_TelefonoSocio As TextBox
    Friend WithEvents TextBox_DireccionSocio As TextBox
    Friend WithEvents AgregarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VolverInicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Button_Guardar As Button
End Class
