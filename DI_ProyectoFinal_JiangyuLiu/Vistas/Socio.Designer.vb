<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Socio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Socio))
        Tabla_Layaut = New TableLayoutPanel()
        TableLayoutPanel1 = New TableLayoutPanel()
        PictureBox1 = New PictureBox()
        Label1_Titulo = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        ListView_Socio = New ListView()
        NumeroSocio = New ColumnHeader()
        TableLayoutPanel3 = New TableLayoutPanel()
        Button_NuevaSocio = New Button()
        Button_VolverInicio = New Button()
        NombreSocio = New ColumnHeader()
        ApellidoSocio = New ColumnHeader()
        DNIsocio = New ColumnHeader()
        DireccionSocio = New ColumnHeader()
        TelefonoSocio = New ColumnHeader()
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
        Tabla_Layaut.TabIndex = 5
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
        Label1_Titulo.Text = "Socios "
        Label1_Titulo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel2.Controls.Add(ListView_Socio, 0, 0)
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
        ' ListView_Socio
        ' 
        ListView_Socio.BackColor = SystemColors.ScrollBar
        ListView_Socio.Columns.AddRange(New ColumnHeader() {NumeroSocio, NombreSocio, ApellidoSocio, DNIsocio, DireccionSocio, TelefonoSocio})
        ListView_Socio.Dock = DockStyle.Fill
        ListView_Socio.Location = New Point(3, 3)
        ListView_Socio.Name = "ListView_Socio"
        ListView_Socio.Size = New Size(1294, 483)
        ListView_Socio.TabIndex = 0
        ListView_Socio.UseCompatibleStateImageBehavior = False
        ListView_Socio.View = View.Details
        ' 
        ' NumeroSocio
        ' 
        NumeroSocio.Text = "Nº Socio"
        NumeroSocio.Width = 100
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        TableLayoutPanel3.ColumnCount = 2
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Controls.Add(Button_NuevaSocio, 0, 0)
        TableLayoutPanel3.Controls.Add(Button_VolverInicio, 1, 0)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(3, 492)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.Size = New Size(1294, 117)
        TableLayoutPanel3.TabIndex = 1
        ' 
        ' Button_NuevaSocio
        ' 
        Button_NuevaSocio.Anchor = AnchorStyles.Right
        Button_NuevaSocio.AutoSize = True
        Button_NuevaSocio.FlatAppearance.BorderColor = SystemColors.ActiveCaption
        Button_NuevaSocio.FlatAppearance.BorderSize = 5
        Button_NuevaSocio.FlatStyle = FlatStyle.Flat
        Button_NuevaSocio.Font = New Font("Segoe UI", 19F)
        Button_NuevaSocio.ForeColor = SystemColors.ActiveCaption
        Button_NuevaSocio.Location = New Point(147, 21)
        Button_NuevaSocio.Margin = New Padding(3, 15, 200, 3)
        Button_NuevaSocio.MaximumSize = New Size(300, 86)
        Button_NuevaSocio.MinimumSize = New Size(300, 86)
        Button_NuevaSocio.Name = "Button_NuevaSocio"
        Button_NuevaSocio.Size = New Size(300, 86)
        Button_NuevaSocio.TabIndex = 0
        Button_NuevaSocio.Text = "Nueva Socio"
        Button_NuevaSocio.UseVisualStyleBackColor = True
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
        ' NombreSocio
        ' 
        NombreSocio.Text = "Nombre "
        NombreSocio.TextAlign = HorizontalAlignment.Center
        NombreSocio.Width = 200
        ' 
        ' ApellidoSocio
        ' 
        ApellidoSocio.Text = "Apellido"
        ApellidoSocio.TextAlign = HorizontalAlignment.Center
        ApellidoSocio.Width = 200
        ' 
        ' DNIsocio
        ' 
        DNIsocio.Text = "DNI"
        DNIsocio.TextAlign = HorizontalAlignment.Center
        DNIsocio.Width = 200
        ' 
        ' DireccionSocio
        ' 
        DireccionSocio.Text = "Dirección"
        DireccionSocio.TextAlign = HorizontalAlignment.Center
        DireccionSocio.Width = 390
        ' 
        ' TelefonoSocio
        ' 
        TelefonoSocio.Text = "Teléfono"
        TelefonoSocio.TextAlign = HorizontalAlignment.Center
        TelefonoSocio.Width = 200
        ' 
        ' Socio
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(1306, 725)
        Controls.Add(Tabla_Layaut)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimumSize = New Size(1328, 781)
        Name = "Socio"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Socios"
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
    Friend WithEvents ListView_Socio As ListView
    Friend WithEvents NumeroSocio As ColumnHeader
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Button_NuevaSocio As Button
    Friend WithEvents Button_VolverInicio As Button
    Friend WithEvents NombreSocio As ColumnHeader
    Friend WithEvents ApellidoSocio As ColumnHeader
    Friend WithEvents DNIsocio As ColumnHeader
    Friend WithEvents DireccionSocio As ColumnHeader
    Friend WithEvents TelefonoSocio As ColumnHeader
End Class
