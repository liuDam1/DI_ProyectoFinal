<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGenero
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormGenero))
        Tabla_Layaut = New TableLayoutPanel()
        TableLayoutPanel1 = New TableLayoutPanel()
        PictureBox1 = New PictureBox()
        Label1_Titulo = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        TableLayoutPanel3 = New TableLayoutPanel()
        Button_Guardar = New Button()
        TableLayoutPanel4 = New TableLayoutPanel()
        ListView_Genero = New ListView()
        NumeroGenero = New ColumnHeader()
        Genero = New ColumnHeader()
        TableLayoutPanel5 = New TableLayoutPanel()
        Label_NumeroGenero = New Label()
        TextBox_GeneroNum = New TextBox()
        TextBox_Genero = New TextBox()
        Label_Genero = New Label()
        MenuStrip1 = New MenuStrip()
        NuevoToolStripMenuItem = New ToolStripMenuItem()
        EliminarToolStripMenuItem = New ToolStripMenuItem()
        ModificarToolStripMenuItem = New ToolStripMenuItem()
        VolverInicioToolStripMenuItem = New ToolStripMenuItem()
        Tabla_Layaut.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        TableLayoutPanel5.SuspendLayout()
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
        Tabla_Layaut.TabIndex = 10
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
        Label1_Titulo.Text = "Genero"
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
        Button_Guardar.Location = New Point(497, 12)
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
        TableLayoutPanel4.ColumnCount = 1
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel4.Controls.Add(ListView_Genero, 0, 1)
        TableLayoutPanel4.Controls.Add(TableLayoutPanel5, 0, 0)
        TableLayoutPanel4.Dock = DockStyle.Fill
        TableLayoutPanel4.Location = New Point(3, 3)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 2
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 30F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 70F))
        TableLayoutPanel4.Size = New Size(1294, 457)
        TableLayoutPanel4.TabIndex = 2
        ' 
        ' ListView_Genero
        ' 
        ListView_Genero.BackColor = SystemColors.ScrollBar
        ListView_Genero.Columns.AddRange(New ColumnHeader() {NumeroGenero, Genero})
        ListView_Genero.Dock = DockStyle.Fill
        ListView_Genero.Location = New Point(3, 140)
        ListView_Genero.Name = "ListView_Genero"
        ListView_Genero.Size = New Size(1288, 314)
        ListView_Genero.TabIndex = 4
        ListView_Genero.UseCompatibleStateImageBehavior = False
        ListView_Genero.View = View.Details
        ' 
        ' NumeroGenero
        ' 
        NumeroGenero.Text = "Numero De Genero"
        NumeroGenero.Width = 400
        ' 
        ' Genero
        ' 
        Genero.Text = "Genero De Pelicula"
        Genero.TextAlign = HorizontalAlignment.Center
        Genero.Width = 600
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.BackColor = SystemColors.ControlLightLight
        TableLayoutPanel5.ColumnCount = 4
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 40F))
        TableLayoutPanel5.Controls.Add(Label_NumeroGenero, 0, 0)
        TableLayoutPanel5.Controls.Add(TextBox_GeneroNum, 1, 0)
        TableLayoutPanel5.Controls.Add(TextBox_Genero, 3, 0)
        TableLayoutPanel5.Controls.Add(Label_Genero, 2, 0)
        TableLayoutPanel5.Dock = DockStyle.Fill
        TableLayoutPanel5.Font = New Font("Segoe UI", 19F)
        TableLayoutPanel5.Location = New Point(3, 3)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 1
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel5.Size = New Size(1288, 131)
        TableLayoutPanel5.TabIndex = 3
        ' 
        ' Label_NumeroGenero
        ' 
        Label_NumeroGenero.Anchor = AnchorStyles.Right
        Label_NumeroGenero.AutoSize = True
        Label_NumeroGenero.Font = New Font("Segoe UI", 19F)
        Label_NumeroGenero.ForeColor = Color.Red
        Label_NumeroGenero.Location = New Point(30, 40)
        Label_NumeroGenero.Margin = New Padding(3, 0, 10, 0)
        Label_NumeroGenero.Name = "Label_NumeroGenero"
        Label_NumeroGenero.Size = New Size(217, 51)
        Label_NumeroGenero.TabIndex = 0
        Label_NumeroGenero.Text = "Nº Genero :"
        ' 
        ' TextBox_GeneroNum
        ' 
        TextBox_GeneroNum.Anchor = AnchorStyles.Left
        TextBox_GeneroNum.Font = New Font("Segoe UI", 19F)
        TextBox_GeneroNum.ForeColor = Color.Red
        TextBox_GeneroNum.Location = New Point(267, 36)
        TextBox_GeneroNum.Margin = New Padding(10, 3, 3, 3)
        TextBox_GeneroNum.Name = "TextBox_GeneroNum"
        TextBox_GeneroNum.Size = New Size(150, 58)
        TextBox_GeneroNum.TabIndex = 1
        TextBox_GeneroNum.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox_Genero
        ' 
        TextBox_Genero.Anchor = AnchorStyles.Left
        TextBox_Genero.Font = New Font("Segoe UI", 19F)
        TextBox_Genero.Location = New Point(781, 36)
        TextBox_Genero.Margin = New Padding(10, 3, 3, 3)
        TextBox_Genero.Name = "TextBox_Genero"
        TextBox_Genero.Size = New Size(376, 58)
        TextBox_Genero.TabIndex = 2
        ' 
        ' Label_Genero
        ' 
        Label_Genero.Anchor = AnchorStyles.Right
        Label_Genero.AutoSize = True
        Label_Genero.Font = New Font("Segoe UI", 19F)
        Label_Genero.Location = New Point(588, 40)
        Label_Genero.Margin = New Padding(3, 0, 10, 0)
        Label_Genero.Name = "Label_Genero"
        Label_Genero.Size = New Size(173, 51)
        Label_Genero.TabIndex = 3
        Label_Genero.Text = "Genero : "
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = SystemColors.ControlLight
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {NuevoToolStripMenuItem, EliminarToolStripMenuItem, ModificarToolStripMenuItem, VolverInicioToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1306, 33)
        MenuStrip1.TabIndex = 9
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
        ' VolverInicioToolStripMenuItem
        ' 
        VolverInicioToolStripMenuItem.Name = "VolverInicioToolStripMenuItem"
        VolverInicioToolStripMenuItem.Size = New Size(123, 29)
        VolverInicioToolStripMenuItem.Text = "Volver inicio"
        ' 
        ' FormGenero
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1306, 725)
        Controls.Add(Tabla_Layaut)
        Controls.Add(MenuStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimumSize = New Size(1328, 781)
        Name = "FormGenero"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Formulario Genero"
        Tabla_Layaut.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel5.ResumeLayout(False)
        TableLayoutPanel5.PerformLayout()
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
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Label_NumeroGenero As Label
    Friend WithEvents TextBox_GeneroNum As TextBox
    Friend WithEvents TextBox_Genero As TextBox
    Friend WithEvents Label_Genero As Label
    Friend WithEvents ListView_Genero As ListView
    Friend WithEvents NumeroGenero As ColumnHeader
    Friend WithEvents Genero As ColumnHeader
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VolverInicioToolStripMenuItem As ToolStripMenuItem
End Class
