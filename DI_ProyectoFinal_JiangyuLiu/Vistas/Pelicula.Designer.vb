<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pelicula
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pelicula))
        Tabla_Layaut = New TableLayoutPanel()
        TableLayoutPanel1 = New TableLayoutPanel()
        PictureBox1 = New PictureBox()
        Label1_Titulo = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        ListView_Pelicula = New ListView()
        NumeroPelicula = New ColumnHeader()
        TituloPelicula = New ColumnHeader()
        DirectorPelicula = New ColumnHeader()
        AnoPelicula = New ColumnHeader()
        GeneroPelicula = New ColumnHeader()
        DuracionPelicula = New ColumnHeader()
        CalificacionPelicula = New ColumnHeader()
        TableLayoutPanel3 = New TableLayoutPanel()
        Button_NuevaPelicula = New Button()
        Button_VolverInicio = New Button()
        Tabla_Layaut.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Tabla_Layaut
        ' 
        Tabla_Layaut.ColumnCount = 2
        Tabla_Layaut.ColumnStyles.Add(New ColumnStyle())
        Tabla_Layaut.ColumnStyles.Add(New ColumnStyle())
        Tabla_Layaut.Controls.Add(TableLayoutPanel1, 1, 2)
        Tabla_Layaut.Controls.Add(TableLayoutPanel2, 1, 3)
        Tabla_Layaut.Dock = DockStyle.Fill
        Tabla_Layaut.Location = New Point(0, 0)
        Tabla_Layaut.Name = "Tabla_Layaut"
        Tabla_Layaut.RowCount = 4
        Tabla_Layaut.RowStyles.Add(New RowStyle())
        Tabla_Layaut.RowStyles.Add(New RowStyle())
        Tabla_Layaut.RowStyles.Add(New RowStyle())
        Tabla_Layaut.RowStyles.Add(New RowStyle())
        Tabla_Layaut.Size = New Size(1306, 725)
        Tabla_Layaut.TabIndex = 4
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
        Label1_Titulo.Text = "Listas de Peliculas"
        Label1_Titulo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel2.Controls.Add(ListView_Pelicula, 0, 0)
        TableLayoutPanel2.Controls.Add(TableLayoutPanel3, 0, 1)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(3, 110)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 80F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel2.Size = New Size(1300, 612)
        TableLayoutPanel2.TabIndex = 3
        ' 
        ' ListView_Pelicula
        ' 
        ListView_Pelicula.BackColor = SystemColors.ScrollBar
        ListView_Pelicula.Columns.AddRange(New ColumnHeader() {NumeroPelicula, TituloPelicula, DirectorPelicula, AnoPelicula, GeneroPelicula, DuracionPelicula, CalificacionPelicula})
        ListView_Pelicula.Dock = DockStyle.Fill
        ListView_Pelicula.Location = New Point(3, 3)
        ListView_Pelicula.Name = "ListView_Pelicula"
        ListView_Pelicula.Size = New Size(1294, 483)
        ListView_Pelicula.TabIndex = 0
        ListView_Pelicula.UseCompatibleStateImageBehavior = False
        ListView_Pelicula.View = View.Details
        ' 
        ' NumeroPelicula
        ' 
        NumeroPelicula.Text = "Nº Pelicula"
        NumeroPelicula.Width = 180
        ' 
        ' TituloPelicula
        ' 
        TituloPelicula.Text = "Titulo"
        TituloPelicula.TextAlign = HorizontalAlignment.Center
        TituloPelicula.Width = 400
        ' 
        ' DirectorPelicula
        ' 
        DirectorPelicula.Text = "Director"
        DirectorPelicula.TextAlign = HorizontalAlignment.Center
        DirectorPelicula.Width = 250
        ' 
        ' AnoPelicula
        ' 
        AnoPelicula.Text = "Año"
        AnoPelicula.TextAlign = HorizontalAlignment.Center
        AnoPelicula.Width = 100
        ' 
        ' GeneroPelicula
        ' 
        GeneroPelicula.Text = "Nº Genero"
        GeneroPelicula.TextAlign = HorizontalAlignment.Center
        GeneroPelicula.Width = 120
        ' 
        ' DuracionPelicula
        ' 
        DuracionPelicula.Text = "Duración"
        DuracionPelicula.TextAlign = HorizontalAlignment.Center
        DuracionPelicula.Width = 120
        ' 
        ' CalificacionPelicula
        ' 
        CalificacionPelicula.Text = "Calificación"
        CalificacionPelicula.TextAlign = HorizontalAlignment.Center
        CalificacionPelicula.Width = 120
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        TableLayoutPanel3.ColumnCount = 2
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Controls.Add(Button_NuevaPelicula, 0, 0)
        TableLayoutPanel3.Controls.Add(Button_VolverInicio, 1, 0)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(3, 492)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.Size = New Size(1294, 117)
        TableLayoutPanel3.TabIndex = 1
        ' 
        ' Button_NuevaPelicula
        ' 
        Button_NuevaPelicula.Anchor = AnchorStyles.Right
        Button_NuevaPelicula.AutoSize = True
        Button_NuevaPelicula.FlatAppearance.BorderColor = SystemColors.ActiveCaption
        Button_NuevaPelicula.FlatAppearance.BorderSize = 5
        Button_NuevaPelicula.FlatStyle = FlatStyle.Flat
        Button_NuevaPelicula.Font = New Font("Segoe UI", 19F)
        Button_NuevaPelicula.ForeColor = SystemColors.ActiveCaption
        Button_NuevaPelicula.Location = New Point(147, 21)
        Button_NuevaPelicula.Margin = New Padding(3, 15, 200, 3)
        Button_NuevaPelicula.MaximumSize = New Size(300, 86)
        Button_NuevaPelicula.MinimumSize = New Size(300, 86)
        Button_NuevaPelicula.Name = "Button_NuevaPelicula"
        Button_NuevaPelicula.Size = New Size(300, 86)
        Button_NuevaPelicula.TabIndex = 0
        Button_NuevaPelicula.Text = "Nueva Pelicula"
        Button_NuevaPelicula.UseVisualStyleBackColor = True
        ' 
        ' Button_VolverInicio
        ' 
        Button_VolverInicio.Anchor = AnchorStyles.Left
        Button_VolverInicio.FlatAppearance.BorderColor = SystemColors.ActiveCaption
        Button_VolverInicio.FlatAppearance.BorderSize = 5
        Button_VolverInicio.FlatStyle = FlatStyle.Flat
        Button_VolverInicio.Font = New Font("Segoe UI", 19F)
        Button_VolverInicio.ForeColor = SystemColors.ActiveCaption
        Button_VolverInicio.Location = New Point(847, 21)
        Button_VolverInicio.Margin = New Padding(200, 15, 3, 3)
        Button_VolverInicio.MaximumSize = New Size(300, 86)
        Button_VolverInicio.MinimumSize = New Size(300, 86)
        Button_VolverInicio.Name = "Button_VolverInicio"
        Button_VolverInicio.Size = New Size(300, 86)
        Button_VolverInicio.TabIndex = 1
        Button_VolverInicio.Text = "Volver Inicio"
        Button_VolverInicio.UseVisualStyleBackColor = True
        ' 
        ' Pelicula
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(1306, 725)
        Controls.Add(Tabla_Layaut)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimumSize = New Size(1328, 781)
        Name = "Pelicula"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Peliculas"
        Tabla_Layaut.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Tabla_Layaut As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1_Titulo As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents ListView_Pelicula As ListView
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Button_NuevaPelicula As Button
    Friend WithEvents Button_VolverInicio As Button
    Friend WithEvents NumeroPelicula As ColumnHeader
    Friend WithEvents TituloPelicula As ColumnHeader
    Friend WithEvents DirectorPelicula As ColumnHeader
    Friend WithEvents AnoPelicula As ColumnHeader
    Friend WithEvents GeneroPelicula As ColumnHeader
    Friend WithEvents DuracionPelicula As ColumnHeader
    Friend WithEvents CalificacionPelicula As ColumnHeader
End Class
