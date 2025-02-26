<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alquiler
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Alquiler))
        MenuStrip1 = New MenuStrip()
        AlquilerToolStripMenuItem = New ToolStripMenuItem()
        SocioToolStripMenuItem = New ToolStripMenuItem()
        PelículaToolStripMenuItem = New ToolStripMenuItem()
        GeneroToolStripMenuItem = New ToolStripMenuItem()
        Tabla_Layaut = New TableLayoutPanel()
        TableLayoutPanel1 = New TableLayoutPanel()
        PictureBox1 = New PictureBox()
        Label1_Titulo = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        ListView_Alquiler = New ListView()
        NumeroPrestamo = New ColumnHeader()
        NumeroSocio = New ColumnHeader()
        NumeroPelicula = New ColumnHeader()
        FechaAlquilada = New ColumnHeader()
        FechaDevuelta = New ColumnHeader()
        TableLayoutPanel3 = New TableLayoutPanel()
        Button_NuevaAlquiler = New Button()
        Button_DevolverPelicula = New Button()
        MenuStrip1.SuspendLayout()
        Tabla_Layaut.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = SystemColors.ControlLight
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {AlquilerToolStripMenuItem, SocioToolStripMenuItem, PelículaToolStripMenuItem, GeneroToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1306, 33)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip_Alquiler"
        ' 
        ' AlquilerToolStripMenuItem
        ' 
        AlquilerToolStripMenuItem.Name = "AlquilerToolStripMenuItem"
        AlquilerToolStripMenuItem.Size = New Size(88, 29)
        AlquilerToolStripMenuItem.Text = "Alquiler"
        ' 
        ' SocioToolStripMenuItem
        ' 
        SocioToolStripMenuItem.Name = "SocioToolStripMenuItem"
        SocioToolStripMenuItem.Size = New Size(72, 29)
        SocioToolStripMenuItem.Text = "Socio"
        ' 
        ' PelículaToolStripMenuItem
        ' 
        PelículaToolStripMenuItem.Name = "PelículaToolStripMenuItem"
        PelículaToolStripMenuItem.Size = New Size(85, 29)
        PelículaToolStripMenuItem.Text = "Película"
        ' 
        ' GeneroToolStripMenuItem
        ' 
        GeneroToolStripMenuItem.Name = "GeneroToolStripMenuItem"
        GeneroToolStripMenuItem.Size = New Size(85, 29)
        GeneroToolStripMenuItem.Text = "Genero"
        ' 
        ' Tabla_Layaut
        ' 
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
        Tabla_Layaut.TabIndex = 3
        ' 
        ' TableLayoutPanel1
        ' 
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
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(1300, 101)
        TableLayoutPanel1.TabIndex = 2
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
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
        Label1_Titulo.Text = "Peliculas Alquiladas"
        Label1_Titulo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel2.Controls.Add(ListView_Alquiler, 0, 0)
        TableLayoutPanel2.Controls.Add(TableLayoutPanel3, 0, 1)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(3, 110)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 80F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel2.Size = New Size(1300, 579)
        TableLayoutPanel2.TabIndex = 3
        ' 
        ' ListView_Alquiler
        ' 
        ListView_Alquiler.BackColor = SystemColors.ScrollBar
        ListView_Alquiler.Columns.AddRange(New ColumnHeader() {NumeroPrestamo, NumeroSocio, NumeroPelicula, FechaAlquilada, FechaDevuelta})
        ListView_Alquiler.Dock = DockStyle.Fill
        ListView_Alquiler.Location = New Point(3, 3)
        ListView_Alquiler.Name = "ListView_Alquiler"
        ListView_Alquiler.Size = New Size(1294, 457)
        ListView_Alquiler.TabIndex = 0
        ListView_Alquiler.UseCompatibleStateImageBehavior = False
        ListView_Alquiler.View = View.Details
        ' 
        ' NumeroPrestamo
        ' 
        NumeroPrestamo.Text = "Nº Prestamo"
        NumeroPrestamo.Width = 150
        ' 
        ' NumeroSocio
        ' 
        NumeroSocio.Text = "Nº Socio"
        NumeroSocio.TextAlign = HorizontalAlignment.Center
        NumeroSocio.Width = 220
        ' 
        ' NumeroPelicula
        ' 
        NumeroPelicula.Text = "Nº Pelicula"
        NumeroPelicula.TextAlign = HorizontalAlignment.Center
        NumeroPelicula.Width = 220
        ' 
        ' FechaAlquilada
        ' 
        FechaAlquilada.Text = "Fecha de Alquilada"
        FechaAlquilada.TextAlign = HorizontalAlignment.Center
        FechaAlquilada.Width = 340
        ' 
        ' FechaDevuelta
        ' 
        FechaDevuelta.Text = "Fecha de Devolución"
        FechaDevuelta.TextAlign = HorizontalAlignment.Center
        FechaDevuelta.Width = 340
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        TableLayoutPanel3.ColumnCount = 2
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Controls.Add(Button_NuevaAlquiler, 0, 0)
        TableLayoutPanel3.Controls.Add(Button_DevolverPelicula, 1, 0)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(3, 466)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.Size = New Size(1294, 110)
        TableLayoutPanel3.TabIndex = 1
        ' 
        ' Button_NuevaAlquiler
        ' 
        Button_NuevaAlquiler.Anchor = AnchorStyles.Right
        Button_NuevaAlquiler.AutoSize = True
        Button_NuevaAlquiler.FlatAppearance.BorderColor = SystemColors.ActiveCaption
        Button_NuevaAlquiler.FlatAppearance.BorderSize = 5
        Button_NuevaAlquiler.FlatStyle = FlatStyle.Flat
        Button_NuevaAlquiler.Font = New Font("Segoe UI", 19F)
        Button_NuevaAlquiler.ForeColor = SystemColors.ActiveCaption
        Button_NuevaAlquiler.Location = New Point(147, 18)
        Button_NuevaAlquiler.Margin = New Padding(3, 15, 200, 3)
        Button_NuevaAlquiler.MaximumSize = New Size(300, 86)
        Button_NuevaAlquiler.MinimumSize = New Size(300, 86)
        Button_NuevaAlquiler.Name = "Button_NuevaAlquiler"
        Button_NuevaAlquiler.Size = New Size(300, 86)
        Button_NuevaAlquiler.TabIndex = 0
        Button_NuevaAlquiler.Text = "Nuevo Alquiler"
        Button_NuevaAlquiler.UseVisualStyleBackColor = True
        ' 
        ' Button_DevolverPelicula
        ' 
        Button_DevolverPelicula.Anchor = AnchorStyles.Left
        Button_DevolverPelicula.FlatAppearance.BorderColor = SystemColors.ActiveCaption
        Button_DevolverPelicula.FlatAppearance.BorderSize = 5
        Button_DevolverPelicula.FlatStyle = FlatStyle.Flat
        Button_DevolverPelicula.Font = New Font("Segoe UI", 19F)
        Button_DevolverPelicula.ForeColor = SystemColors.ActiveCaption
        Button_DevolverPelicula.Location = New Point(847, 18)
        Button_DevolverPelicula.Margin = New Padding(200, 15, 3, 3)
        Button_DevolverPelicula.MaximumSize = New Size(300, 86)
        Button_DevolverPelicula.MinimumSize = New Size(300, 86)
        Button_DevolverPelicula.Name = "Button_DevolverPelicula"
        Button_DevolverPelicula.Size = New Size(300, 86)
        Button_DevolverPelicula.TabIndex = 1
        Button_DevolverPelicula.Text = "Devolvolución"
        Button_DevolverPelicula.UseVisualStyleBackColor = True
        ' 
        ' Alquiler
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(1306, 725)
        Controls.Add(Tabla_Layaut)
        Controls.Add(MenuStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        MinimumSize = New Size(1328, 781)
        Name = "Alquiler"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Peliculas Alquiladas"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        Tabla_Layaut.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Tabla_Layaut As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents ListView_Alquiler As ListView
    Friend WithEvents NumeroPrestamo As ColumnHeader
    Friend WithEvents NumeroSocio As ColumnHeader
    Friend WithEvents NumeroPelicula As ColumnHeader
    Friend WithEvents FechaAlquilada As ColumnHeader
    Friend WithEvents FechaDevuelta As ColumnHeader
    Friend WithEvents Label1_Titulo As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Button_NuevaAlquiler As Button
    Friend WithEvents Button_DevolverPelicula As Button
    Friend WithEvents AlquilerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SocioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PelículaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GeneroToolStripMenuItem As ToolStripMenuItem
End Class
