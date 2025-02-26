<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPelicula
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPelicula))
        Tabla_Layaut = New TableLayoutPanel()
        TableLayoutPanel1 = New TableLayoutPanel()
        PictureBox1 = New PictureBox()
        Label1_Titulo = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        TableLayoutPanel3 = New TableLayoutPanel()
        Button_Guardar = New Button()
        TableLayoutPanel4 = New TableLayoutPanel()
        TableLayoutPanel5 = New TableLayoutPanel()
        Label_DuracionPelicula = New Label()
        TextBox_DuracionPelic = New TextBox()
        TableLayoutPanel6 = New TableLayoutPanel()
        Label_CalificacionPelicula = New Label()
        TextBox_CalificacionPelic = New TextBox()
        TableLayoutPanel7 = New TableLayoutPanel()
        Label_AnoPelicula = New Label()
        TextBox_AnoPelic = New TextBox()
        TableLayoutPanel8 = New TableLayoutPanel()
        Label_GeneroPelicula = New Label()
        ComboBox_GeneroPelic = New ComboBox()
        Label_NumPelicula = New Label()
        Label_DirectorPelicula = New Label()
        Label_TituloPelicula = New Label()
        TextBox_NumPelicula = New TextBox()
        TextBox_DirectorPelic = New TextBox()
        TextBox_TituloPelic = New TextBox()
        MenuStrip1 = New MenuStrip()
        NuevoToolStripMenuItem = New ToolStripMenuItem()
        EliminarToolStripMenuItem = New ToolStripMenuItem()
        ModificarToolStripMenuItem = New ToolStripMenuItem()
        VaolverPeliculaToolStripMenuItem = New ToolStripMenuItem()
        Tabla_Layaut.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        TableLayoutPanel5.SuspendLayout()
        TableLayoutPanel6.SuspendLayout()
        TableLayoutPanel7.SuspendLayout()
        TableLayoutPanel8.SuspendLayout()
        MenuStrip1.SuspendLayout()
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
        Tabla_Layaut.TabIndex = 8
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
        Label1_Titulo.Text = "Nueva Película"
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
        TableLayoutPanel2.Size = New Size(1300, 588)
        TableLayoutPanel2.TabIndex = 3
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        TableLayoutPanel3.ColumnCount = 1
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Controls.Add(Button_Guardar, 0, 0)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(3, 473)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.Size = New Size(1294, 112)
        TableLayoutPanel3.TabIndex = 1
        ' 
        ' Button_Guardar
        ' 
        Button_Guardar.Anchor = AnchorStyles.None
        Button_Guardar.AutoSize = True
        Button_Guardar.FlatAppearance.BorderColor = SystemColors.ActiveCaption
        Button_Guardar.FlatAppearance.BorderSize = 5
        Button_Guardar.FlatStyle = FlatStyle.Flat
        Button_Guardar.Font = New Font("Segoe UI", 19F)
        Button_Guardar.ForeColor = SystemColors.ActiveCaption
        Button_Guardar.Location = New Point(497, 13)
        Button_Guardar.MaximumSize = New Size(300, 86)
        Button_Guardar.MinimumSize = New Size(300, 86)
        Button_Guardar.Name = "Button_Guardar"
        Button_Guardar.Size = New Size(300, 86)
        Button_Guardar.TabIndex = 0
        Button_Guardar.Text = "Guardar"
        Button_Guardar.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.BackColor = SystemColors.ControlLight
        TableLayoutPanel4.ColumnCount = 2
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Controls.Add(TableLayoutPanel5, 0, 4)
        TableLayoutPanel4.Controls.Add(TableLayoutPanel6, 1, 4)
        TableLayoutPanel4.Controls.Add(TableLayoutPanel7, 0, 3)
        TableLayoutPanel4.Controls.Add(TableLayoutPanel8, 1, 3)
        TableLayoutPanel4.Controls.Add(Label_NumPelicula, 0, 0)
        TableLayoutPanel4.Controls.Add(Label_DirectorPelicula, 0, 1)
        TableLayoutPanel4.Controls.Add(Label_TituloPelicula, 0, 2)
        TableLayoutPanel4.Controls.Add(TextBox_NumPelicula, 1, 0)
        TableLayoutPanel4.Controls.Add(TextBox_DirectorPelic, 1, 1)
        TableLayoutPanel4.Controls.Add(TextBox_TituloPelic, 1, 2)
        TableLayoutPanel4.Dock = DockStyle.Fill
        TableLayoutPanel4.Location = New Point(3, 3)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 5
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel4.Size = New Size(1294, 464)
        TableLayoutPanel4.TabIndex = 2
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.ColumnCount = 2
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.Controls.Add(Label_DuracionPelicula, 0, 0)
        TableLayoutPanel5.Controls.Add(TextBox_DuracionPelic, 1, 0)
        TableLayoutPanel5.Dock = DockStyle.Fill
        TableLayoutPanel5.Location = New Point(3, 371)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 1
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.Size = New Size(641, 90)
        TableLayoutPanel5.TabIndex = 0
        ' 
        ' Label_DuracionPelicula
        ' 
        Label_DuracionPelicula.Anchor = AnchorStyles.Right
        Label_DuracionPelicula.AutoSize = True
        Label_DuracionPelicula.Font = New Font("Segoe UI", 19F)
        Label_DuracionPelicula.Location = New Point(108, 19)
        Label_DuracionPelicula.Margin = New Padding(3, 0, 10, 0)
        Label_DuracionPelicula.Name = "Label_DuracionPelicula"
        Label_DuracionPelicula.Size = New Size(202, 51)
        Label_DuracionPelicula.TabIndex = 0
        Label_DuracionPelicula.Text = "Duración : "
        ' 
        ' TextBox_DuracionPelic
        ' 
        TextBox_DuracionPelic.Anchor = AnchorStyles.Left
        TextBox_DuracionPelic.Font = New Font("Segoe UI", 19F)
        TextBox_DuracionPelic.Location = New Point(330, 16)
        TextBox_DuracionPelic.Margin = New Padding(10, 3, 3, 3)
        TextBox_DuracionPelic.Name = "TextBox_DuracionPelic"
        TextBox_DuracionPelic.Size = New Size(150, 58)
        TextBox_DuracionPelic.TabIndex = 1
        ' 
        ' TableLayoutPanel6
        ' 
        TableLayoutPanel6.ColumnCount = 2
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel6.Controls.Add(Label_CalificacionPelicula, 0, 0)
        TableLayoutPanel6.Controls.Add(TextBox_CalificacionPelic, 1, 0)
        TableLayoutPanel6.Dock = DockStyle.Fill
        TableLayoutPanel6.Location = New Point(650, 371)
        TableLayoutPanel6.Name = "TableLayoutPanel6"
        TableLayoutPanel6.RowCount = 1
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel6.Size = New Size(641, 90)
        TableLayoutPanel6.TabIndex = 1
        ' 
        ' Label_CalificacionPelicula
        ' 
        Label_CalificacionPelicula.Anchor = AnchorStyles.Right
        Label_CalificacionPelicula.AutoSize = True
        Label_CalificacionPelicula.Font = New Font("Segoe UI", 19F)
        Label_CalificacionPelicula.Location = New Point(70, 19)
        Label_CalificacionPelicula.Margin = New Padding(3, 0, 10, 0)
        Label_CalificacionPelicula.Name = "Label_CalificacionPelicula"
        Label_CalificacionPelicula.Size = New Size(240, 51)
        Label_CalificacionPelicula.TabIndex = 0
        Label_CalificacionPelicula.Text = "Calificación : "
        ' 
        ' TextBox_CalificacionPelic
        ' 
        TextBox_CalificacionPelic.Anchor = AnchorStyles.Left
        TextBox_CalificacionPelic.Font = New Font("Segoe UI", 19F)
        TextBox_CalificacionPelic.Location = New Point(330, 16)
        TextBox_CalificacionPelic.Margin = New Padding(10, 3, 3, 3)
        TextBox_CalificacionPelic.Name = "TextBox_CalificacionPelic"
        TextBox_CalificacionPelic.Size = New Size(150, 58)
        TextBox_CalificacionPelic.TabIndex = 1
        ' 
        ' TableLayoutPanel7
        ' 
        TableLayoutPanel7.ColumnCount = 2
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel7.Controls.Add(Label_AnoPelicula, 0, 0)
        TableLayoutPanel7.Controls.Add(TextBox_AnoPelic, 1, 0)
        TableLayoutPanel7.Dock = DockStyle.Fill
        TableLayoutPanel7.Location = New Point(3, 279)
        TableLayoutPanel7.Name = "TableLayoutPanel7"
        TableLayoutPanel7.RowCount = 1
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel7.Size = New Size(641, 86)
        TableLayoutPanel7.TabIndex = 2
        ' 
        ' Label_AnoPelicula
        ' 
        Label_AnoPelicula.Anchor = AnchorStyles.Right
        Label_AnoPelicula.AutoSize = True
        Label_AnoPelicula.Font = New Font("Segoe UI", 19F)
        Label_AnoPelicula.Location = New Point(191, 17)
        Label_AnoPelicula.Margin = New Padding(3, 0, 10, 0)
        Label_AnoPelicula.Name = "Label_AnoPelicula"
        Label_AnoPelicula.Size = New Size(119, 51)
        Label_AnoPelicula.TabIndex = 0
        Label_AnoPelicula.Text = "Año : "
        ' 
        ' TextBox_AnoPelic
        ' 
        TextBox_AnoPelic.Anchor = AnchorStyles.Left
        TextBox_AnoPelic.Font = New Font("Segoe UI", 19F)
        TextBox_AnoPelic.Location = New Point(330, 14)
        TextBox_AnoPelic.Margin = New Padding(10, 3, 3, 3)
        TextBox_AnoPelic.Name = "TextBox_AnoPelic"
        TextBox_AnoPelic.Size = New Size(150, 58)
        TextBox_AnoPelic.TabIndex = 1
        ' 
        ' TableLayoutPanel8
        ' 
        TableLayoutPanel8.ColumnCount = 2
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel8.Controls.Add(Label_GeneroPelicula, 0, 0)
        TableLayoutPanel8.Controls.Add(ComboBox_GeneroPelic, 1, 0)
        TableLayoutPanel8.Dock = DockStyle.Fill
        TableLayoutPanel8.Location = New Point(650, 279)
        TableLayoutPanel8.Name = "TableLayoutPanel8"
        TableLayoutPanel8.RowCount = 1
        TableLayoutPanel8.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel8.Size = New Size(641, 86)
        TableLayoutPanel8.TabIndex = 3
        ' 
        ' Label_GeneroPelicula
        ' 
        Label_GeneroPelicula.Anchor = AnchorStyles.Right
        Label_GeneroPelicula.AutoSize = True
        Label_GeneroPelicula.Font = New Font("Segoe UI", 19F)
        Label_GeneroPelicula.Location = New Point(137, 17)
        Label_GeneroPelicula.Margin = New Padding(3, 0, 10, 0)
        Label_GeneroPelicula.Name = "Label_GeneroPelicula"
        Label_GeneroPelicula.Size = New Size(173, 51)
        Label_GeneroPelicula.TabIndex = 0
        Label_GeneroPelicula.Text = "Genero : "
        ' 
        ' ComboBox_GeneroPelic
        ' 
        ComboBox_GeneroPelic.Anchor = AnchorStyles.Left
        ComboBox_GeneroPelic.Font = New Font("Segoe UI", 19F)
        ComboBox_GeneroPelic.FormattingEnabled = True
        ComboBox_GeneroPelic.Location = New Point(330, 13)
        ComboBox_GeneroPelic.Margin = New Padding(10, 3, 3, 3)
        ComboBox_GeneroPelic.Name = "ComboBox_GeneroPelic"
        ComboBox_GeneroPelic.Size = New Size(257, 59)
        ComboBox_GeneroPelic.TabIndex = 1
        ' 
        ' Label_NumPelicula
        ' 
        Label_NumPelicula.Anchor = AnchorStyles.Right
        Label_NumPelicula.AutoSize = True
        Label_NumPelicula.Font = New Font("Segoe UI", 19F)
        Label_NumPelicula.ForeColor = Color.Red
        Label_NumPelicula.Location = New Point(407, 20)
        Label_NumPelicula.Margin = New Padding(3, 0, 10, 0)
        Label_NumPelicula.Name = "Label_NumPelicula"
        Label_NumPelicula.Size = New Size(230, 51)
        Label_NumPelicula.TabIndex = 4
        Label_NumPelicula.Text = "Nº Pelicula : "
        ' 
        ' Label_DirectorPelicula
        ' 
        Label_DirectorPelicula.Anchor = AnchorStyles.Right
        Label_DirectorPelicula.AutoSize = True
        Label_DirectorPelicula.Font = New Font("Segoe UI", 19F)
        Label_DirectorPelicula.Location = New Point(434, 112)
        Label_DirectorPelicula.Margin = New Padding(3, 0, 10, 0)
        Label_DirectorPelicula.Name = "Label_DirectorPelicula"
        Label_DirectorPelicula.Size = New Size(203, 51)
        Label_DirectorPelicula.TabIndex = 5
        Label_DirectorPelicula.Text = "Direcctor : "
        ' 
        ' Label_TituloPelicula
        ' 
        Label_TituloPelicula.Anchor = AnchorStyles.Right
        Label_TituloPelicula.AutoSize = True
        Label_TituloPelicula.Font = New Font("Segoe UI", 19F)
        Label_TituloPelicula.Location = New Point(492, 204)
        Label_TituloPelicula.Margin = New Padding(3, 0, 10, 0)
        Label_TituloPelicula.Name = "Label_TituloPelicula"
        Label_TituloPelicula.Size = New Size(145, 51)
        Label_TituloPelicula.TabIndex = 6
        Label_TituloPelicula.Text = "Titulo : "
        ' 
        ' TextBox_NumPelicula
        ' 
        TextBox_NumPelicula.Anchor = AnchorStyles.Left
        TextBox_NumPelicula.Font = New Font("Segoe UI", 19F)
        TextBox_NumPelicula.ForeColor = Color.Red
        TextBox_NumPelicula.Location = New Point(657, 17)
        TextBox_NumPelicula.Margin = New Padding(10, 3, 3, 3)
        TextBox_NumPelicula.Name = "TextBox_NumPelicula"
        TextBox_NumPelicula.Size = New Size(150, 58)
        TextBox_NumPelicula.TabIndex = 7
        TextBox_NumPelicula.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox_DirectorPelic
        ' 
        TextBox_DirectorPelic.Anchor = AnchorStyles.Left
        TextBox_DirectorPelic.Font = New Font("Segoe UI", 19F)
        TextBox_DirectorPelic.Location = New Point(657, 109)
        TextBox_DirectorPelic.Margin = New Padding(10, 3, 3, 3)
        TextBox_DirectorPelic.Name = "TextBox_DirectorPelic"
        TextBox_DirectorPelic.Size = New Size(348, 58)
        TextBox_DirectorPelic.TabIndex = 8
        ' 
        ' TextBox_TituloPelic
        ' 
        TextBox_TituloPelic.Anchor = AnchorStyles.Left
        TextBox_TituloPelic.Font = New Font("Segoe UI", 19F)
        TextBox_TituloPelic.Location = New Point(657, 201)
        TextBox_TituloPelic.Margin = New Padding(10, 3, 3, 3)
        TextBox_TituloPelic.Name = "TextBox_TituloPelic"
        TextBox_TituloPelic.Size = New Size(580, 58)
        TextBox_TituloPelic.TabIndex = 9
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = SystemColors.ControlLight
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {NuevoToolStripMenuItem, EliminarToolStripMenuItem, ModificarToolStripMenuItem, VaolverPeliculaToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1306, 33)
        MenuStrip1.TabIndex = 7
        MenuStrip1.Text = "MenuStrip_Pelicula"
        ' 
        ' NuevoToolStripMenuItem
        ' 
        NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        NuevoToolStripMenuItem.Size = New Size(80, 29)
        NuevoToolStripMenuItem.Text = "Nuevo"
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
        ' VaolverPeliculaToolStripMenuItem
        ' 
        VaolverPeliculaToolStripMenuItem.Name = "VaolverPeliculaToolStripMenuItem"
        VaolverPeliculaToolStripMenuItem.Size = New Size(148, 29)
        VaolverPeliculaToolStripMenuItem.Text = "Vaolver Pelicula"
        ' 
        ' FormPelicula
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1306, 725)
        Controls.Add(Tabla_Layaut)
        Controls.Add(MenuStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimumSize = New Size(1328, 781)
        Name = "FormPelicula"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Formulario Película"
        Tabla_Layaut.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel4.PerformLayout()
        TableLayoutPanel5.ResumeLayout(False)
        TableLayoutPanel5.PerformLayout()
        TableLayoutPanel6.ResumeLayout(False)
        TableLayoutPanel6.PerformLayout()
        TableLayoutPanel7.ResumeLayout(False)
        TableLayoutPanel7.PerformLayout()
        TableLayoutPanel8.ResumeLayout(False)
        TableLayoutPanel8.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Tabla_Layaut As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1_Titulo As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Button_Guardar As Button
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents Label_DuracionPelicula As Label
    Friend WithEvents Label_CalificacionPelicula As Label
    Friend WithEvents Label_AnoPelicula As Label
    Friend WithEvents Label_GeneroPelicula As Label
    Friend WithEvents Label_NumPelicula As Label
    Friend WithEvents Label_DirectorPelicula As Label
    Friend WithEvents Label_TituloPelicula As Label
    Friend WithEvents TextBox_DuracionPelic As TextBox
    Friend WithEvents TextBox_CalificacionPelic As TextBox
    Friend WithEvents TextBox_AnoPelic As TextBox
    Friend WithEvents ComboBox_GeneroPelic As ComboBox
    Friend WithEvents TextBox_NumPelicula As TextBox
    Friend WithEvents TextBox_DirectorPelic As TextBox
    Friend WithEvents TextBox_TituloPelic As TextBox
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VaolverPeliculaToolStripMenuItem As ToolStripMenuItem
End Class

