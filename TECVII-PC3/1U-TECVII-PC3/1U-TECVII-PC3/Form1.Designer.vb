<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.btn_Mostrar = New Guna.UI.WinForms.GunaButton()
        Me.btn_Insertar = New Guna.UI.WinForms.GunaButton()
        Me.txt_Telefono = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txt_Provincia = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txt_Poblacion = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txt_CodPostal = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txt_Direccion = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txt_Apellido = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txt_Nombre = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txt_Cif = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txt_CodCliente = New Guna.UI.WinForms.GunaLineTextBox()
        Me.dataGrid2 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.ClienteDataSet = New _1U_TECVII_PC3.ClienteDataSet()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New _1U_TECVII_PC3.ClienteDataSetTableAdapters.ClientesTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.GunaGroupBox1.SuspendLayout()
        CType(Me.dataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.Color.White
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox1.Controls.Add(Me.btn_Mostrar)
        Me.GunaGroupBox1.Controls.Add(Me.btn_Insertar)
        Me.GunaGroupBox1.Controls.Add(Me.txt_Telefono)
        Me.GunaGroupBox1.Controls.Add(Me.txt_Provincia)
        Me.GunaGroupBox1.Controls.Add(Me.txt_Poblacion)
        Me.GunaGroupBox1.Controls.Add(Me.txt_CodPostal)
        Me.GunaGroupBox1.Controls.Add(Me.txt_Direccion)
        Me.GunaGroupBox1.Controls.Add(Me.txt_Apellido)
        Me.GunaGroupBox1.Controls.Add(Me.txt_Nombre)
        Me.GunaGroupBox1.Controls.Add(Me.txt_Cif)
        Me.GunaGroupBox1.Controls.Add(Me.txt_CodCliente)
        Me.GunaGroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox1.Location = New System.Drawing.Point(105, 12)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Size = New System.Drawing.Size(604, 176)
        Me.GunaGroupBox1.TabIndex = 2
        Me.GunaGroupBox1.Text = "Datos De Cliente"
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(10, 8)
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.AnimationHoverSpeed = 0.07!
        Me.btn_Mostrar.AnimationSpeed = 0.03!
        Me.btn_Mostrar.BackColor = System.Drawing.Color.Transparent
        Me.btn_Mostrar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Mostrar.BorderColor = System.Drawing.Color.Black
        Me.btn_Mostrar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_Mostrar.FocusedColor = System.Drawing.Color.Empty
        Me.btn_Mostrar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Mostrar.ForeColor = System.Drawing.Color.Black
        Me.btn_Mostrar.Image = Nothing
        Me.btn_Mostrar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_Mostrar.Location = New System.Drawing.Point(496, 138)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Mostrar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_Mostrar.OnHoverForeColor = System.Drawing.Color.Black
        Me.btn_Mostrar.OnHoverImage = Nothing
        Me.btn_Mostrar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_Mostrar.Radius = 10
        Me.btn_Mostrar.Size = New System.Drawing.Size(97, 31)
        Me.btn_Mostrar.TabIndex = 12
        Me.btn_Mostrar.Text = "Mostrar"
        Me.btn_Mostrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_Insertar
        '
        Me.btn_Insertar.AnimationHoverSpeed = 0.07!
        Me.btn_Insertar.AnimationSpeed = 0.03!
        Me.btn_Insertar.BackColor = System.Drawing.Color.Transparent
        Me.btn_Insertar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btn_Insertar.BorderColor = System.Drawing.Color.Black
        Me.btn_Insertar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_Insertar.FocusedColor = System.Drawing.Color.Empty
        Me.btn_Insertar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Insertar.ForeColor = System.Drawing.Color.Black
        Me.btn_Insertar.Image = Nothing
        Me.btn_Insertar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_Insertar.Location = New System.Drawing.Point(311, 138)
        Me.btn_Insertar.Name = "btn_Insertar"
        Me.btn_Insertar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btn_Insertar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_Insertar.OnHoverForeColor = System.Drawing.Color.Black
        Me.btn_Insertar.OnHoverImage = Nothing
        Me.btn_Insertar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_Insertar.Radius = 10
        Me.btn_Insertar.Size = New System.Drawing.Size(97, 31)
        Me.btn_Insertar.TabIndex = 6
        Me.btn_Insertar.Text = "Insertar"
        Me.btn_Insertar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_Telefono
        '
        Me.txt_Telefono.BackColor = System.Drawing.Color.White
        Me.txt_Telefono.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Telefono.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Telefono.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_Telefono.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_Telefono.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_Telefono.Location = New System.Drawing.Point(163, 138)
        Me.txt_Telefono.Name = "txt_Telefono"
        Me.txt_Telefono.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Telefono.SelectedText = ""
        Me.txt_Telefono.Size = New System.Drawing.Size(109, 26)
        Me.txt_Telefono.TabIndex = 11
        Me.txt_Telefono.Text = "Telefono"
        '
        'txt_Provincia
        '
        Me.txt_Provincia.BackColor = System.Drawing.Color.White
        Me.txt_Provincia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Provincia.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Provincia.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_Provincia.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_Provincia.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.txt_Provincia.Location = New System.Drawing.Point(14, 138)
        Me.txt_Provincia.Name = "txt_Provincia"
        Me.txt_Provincia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Provincia.SelectedText = ""
        Me.txt_Provincia.Size = New System.Drawing.Size(109, 26)
        Me.txt_Provincia.TabIndex = 10
        Me.txt_Provincia.Text = "Provincia"
        '
        'txt_Poblacion
        '
        Me.txt_Poblacion.BackColor = System.Drawing.Color.White
        Me.txt_Poblacion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Poblacion.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Poblacion.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_Poblacion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_Poblacion.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.txt_Poblacion.Location = New System.Drawing.Point(484, 88)
        Me.txt_Poblacion.Name = "txt_Poblacion"
        Me.txt_Poblacion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Poblacion.SelectedText = ""
        Me.txt_Poblacion.Size = New System.Drawing.Size(109, 26)
        Me.txt_Poblacion.TabIndex = 9
        Me.txt_Poblacion.Text = "Poblacion"
        '
        'txt_CodPostal
        '
        Me.txt_CodPostal.BackColor = System.Drawing.Color.White
        Me.txt_CodPostal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_CodPostal.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_CodPostal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_CodPostal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_CodPostal.LineColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txt_CodPostal.Location = New System.Drawing.Point(311, 88)
        Me.txt_CodPostal.Name = "txt_CodPostal"
        Me.txt_CodPostal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_CodPostal.SelectedText = ""
        Me.txt_CodPostal.Size = New System.Drawing.Size(109, 26)
        Me.txt_CodPostal.TabIndex = 8
        Me.txt_CodPostal.Text = "Codigo Postal"
        '
        'txt_Direccion
        '
        Me.txt_Direccion.BackColor = System.Drawing.Color.White
        Me.txt_Direccion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Direccion.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Direccion.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_Direccion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_Direccion.LineColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.txt_Direccion.Location = New System.Drawing.Point(14, 88)
        Me.txt_Direccion.Name = "txt_Direccion"
        Me.txt_Direccion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Direccion.SelectedText = ""
        Me.txt_Direccion.Size = New System.Drawing.Size(258, 26)
        Me.txt_Direccion.TabIndex = 7
        Me.txt_Direccion.Text = "Direccion"
        '
        'txt_Apellido
        '
        Me.txt_Apellido.BackColor = System.Drawing.Color.White
        Me.txt_Apellido.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Apellido.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Apellido.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_Apellido.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_Apellido.LineColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.txt_Apellido.Location = New System.Drawing.Point(484, 41)
        Me.txt_Apellido.Name = "txt_Apellido"
        Me.txt_Apellido.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Apellido.SelectedText = ""
        Me.txt_Apellido.Size = New System.Drawing.Size(109, 26)
        Me.txt_Apellido.TabIndex = 6
        Me.txt_Apellido.Text = "Apellido"
        '
        'txt_Nombre
        '
        Me.txt_Nombre.BackColor = System.Drawing.Color.White
        Me.txt_Nombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Nombre.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Nombre.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_Nombre.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_Nombre.LineColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.txt_Nombre.Location = New System.Drawing.Point(311, 41)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Nombre.SelectedText = ""
        Me.txt_Nombre.Size = New System.Drawing.Size(109, 26)
        Me.txt_Nombre.TabIndex = 5
        Me.txt_Nombre.Text = "Nombre"
        '
        'txt_Cif
        '
        Me.txt_Cif.BackColor = System.Drawing.Color.White
        Me.txt_Cif.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Cif.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Cif.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_Cif.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_Cif.LineColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.txt_Cif.Location = New System.Drawing.Point(163, 41)
        Me.txt_Cif.Name = "txt_Cif"
        Me.txt_Cif.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Cif.SelectedText = ""
        Me.txt_Cif.Size = New System.Drawing.Size(109, 26)
        Me.txt_Cif.TabIndex = 4
        Me.txt_Cif.Text = "CIF"
        '
        'txt_CodCliente
        '
        Me.txt_CodCliente.BackColor = System.Drawing.Color.White
        Me.txt_CodCliente.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_CodCliente.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_CodCliente.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_CodCliente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_CodCliente.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_CodCliente.Location = New System.Drawing.Point(14, 41)
        Me.txt_CodCliente.Name = "txt_CodCliente"
        Me.txt_CodCliente.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_CodCliente.SelectedText = ""
        Me.txt_CodCliente.Size = New System.Drawing.Size(109, 26)
        Me.txt_CodCliente.TabIndex = 3
        Me.txt_CodCliente.Text = "Cod_Cliente"
        '
        'dataGrid2
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.dataGrid2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dataGrid2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataGrid2.BackgroundColor = System.Drawing.Color.White
        Me.dataGrid2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dataGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGrid2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dataGrid2.ColumnHeadersHeight = 21
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(216, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGrid2.DefaultCellStyle = DataGridViewCellStyle3
        Me.dataGrid2.EnableHeadersVisualStyles = False
        Me.dataGrid2.GridColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.dataGrid2.Location = New System.Drawing.Point(12, 194)
        Me.dataGrid2.Name = "dataGrid2"
        Me.dataGrid2.RowHeadersVisible = False
        Me.dataGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGrid2.Size = New System.Drawing.Size(774, 174)
        Me.dataGrid2.TabIndex = 5
        Me.dataGrid2.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Alizarin
        Me.dataGrid2.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.dataGrid2.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dataGrid2.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dataGrid2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dataGrid2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dataGrid2.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dataGrid2.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.dataGrid2.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.dataGrid2.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dataGrid2.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dataGrid2.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dataGrid2.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dataGrid2.ThemeStyle.HeaderStyle.Height = 21
        Me.dataGrid2.ThemeStyle.ReadOnly = False
        Me.dataGrid2.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.dataGrid2.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dataGrid2.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dataGrid2.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dataGrid2.ThemeStyle.RowsStyle.Height = 22
        Me.dataGrid2.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.dataGrid2.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'ClienteDataSet
        '
        Me.ClienteDataSet.DataSetName = "ClienteDataSet"
        Me.ClienteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.ClienteDataSet
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ClientesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "_1U_TECVII_PC3.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 374)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(774, 215)
        Me.ReportViewer1.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 601)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.dataGrid2)
        Me.Controls.Add(Me.GunaGroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GunaGroupBox1.ResumeLayout(False)
        CType(Me.dataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents txt_CodCliente As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txt_Telefono As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txt_Provincia As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txt_Poblacion As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txt_CodPostal As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txt_Direccion As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txt_Apellido As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txt_Nombre As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txt_Cif As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents dataGrid2 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btn_Insertar As Guna.UI.WinForms.GunaButton
    Friend WithEvents btn_Mostrar As Guna.UI.WinForms.GunaButton
    Friend WithEvents ClienteDataSet As ClienteDataSet
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As ClienteDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
