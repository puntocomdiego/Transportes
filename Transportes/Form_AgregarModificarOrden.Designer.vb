<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_AgregarModificarOrden
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_AgregarModificarOrden))
        Me.GroupBox_Datos = New System.Windows.Forms.GroupBox()
        Me.Bot_MostrarVehiculos = New System.Windows.Forms.Button()
        Me.Bot_MostrarClientes = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_NumOrden = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox_Cliente = New System.Windows.Forms.TextBox()
        Me.TextBox_Total = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DatePicker_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.TextBox_DetalleGastos = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox_NumGuia = New System.Windows.Forms.TextBox()
        Me.TextBox_Gastos = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox_LugarDescarga = New System.Windows.Forms.ComboBox()
        Me.TextBox_NumRemito = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox_LugarCarga = New System.Windows.Forms.ComboBox()
        Me.TextBox_KMCamion = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox_Detalle = New System.Windows.Forms.ComboBox()
        Me.TextBox_Vehiculo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox_KMValor = New System.Windows.Forms.TextBox()
        Me.TextBox_NumCarga = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label_Titulo = New System.Windows.Forms.Label()
        Me.GroupBox_Pago = New System.Windows.Forms.GroupBox()
        Me.RadioButton_Pago = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Debe = New System.Windows.Forms.RadioButton()
        Me.GroupBox_Factura = New System.Windows.Forms.GroupBox()
        Me.RadioButton_Facturado = New System.Windows.Forms.RadioButton()
        Me.RadioButton_NoFacturado = New System.Windows.Forms.RadioButton()
        Me.Bot_Volver = New System.Windows.Forms.Button()
        Me.Bot_Cancelar = New System.Windows.Forms.Button()
        Me.Bot_Guardar = New System.Windows.Forms.Button()
        Me.Panel_Tablas = New System.Windows.Forms.Panel()
        Me.CheckedListBox_Vehiculos = New System.Windows.Forms.CheckedListBox()
        Me.WMTextBox_Buscar = New Transportes.WatermarkTextBox()
        Me.Bot_CerrarTabla = New System.Windows.Forms.Button()
        Me.Bot_Seleccionar = New System.Windows.Forms.Button()
        Me.Bot_Borrar = New System.Windows.Forms.Button()
        Me.Label_TituloTabla = New System.Windows.Forms.Label()
        Me.DataGridView_Datos = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel_Datos = New System.Windows.Forms.Panel()
        Me.Panel_Aceite = New System.Windows.Forms.Panel()
        Me.TextBox_AceiteVencido = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TextBox_AceiteMil = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox_Datos.SuspendLayout()
        Me.GroupBox_Pago.SuspendLayout()
        Me.GroupBox_Factura.SuspendLayout()
        Me.Panel_Tablas.SuspendLayout()
        CType(Me.DataGridView_Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Datos.SuspendLayout()
        Me.Panel_Aceite.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox_Datos
        '
        Me.GroupBox_Datos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_Datos.Controls.Add(Me.Bot_MostrarVehiculos)
        Me.GroupBox_Datos.Controls.Add(Me.Bot_MostrarClientes)
        Me.GroupBox_Datos.Controls.Add(Me.Label1)
        Me.GroupBox_Datos.Controls.Add(Me.TextBox_NumOrden)
        Me.GroupBox_Datos.Controls.Add(Me.Label15)
        Me.GroupBox_Datos.Controls.Add(Me.TextBox_Cliente)
        Me.GroupBox_Datos.Controls.Add(Me.TextBox_Total)
        Me.GroupBox_Datos.Controls.Add(Me.Label2)
        Me.GroupBox_Datos.Controls.Add(Me.Label14)
        Me.GroupBox_Datos.Controls.Add(Me.DatePicker_Fecha)
        Me.GroupBox_Datos.Controls.Add(Me.TextBox_DetalleGastos)
        Me.GroupBox_Datos.Controls.Add(Me.Label3)
        Me.GroupBox_Datos.Controls.Add(Me.Label13)
        Me.GroupBox_Datos.Controls.Add(Me.TextBox_NumGuia)
        Me.GroupBox_Datos.Controls.Add(Me.TextBox_Gastos)
        Me.GroupBox_Datos.Controls.Add(Me.Label4)
        Me.GroupBox_Datos.Controls.Add(Me.ComboBox_LugarDescarga)
        Me.GroupBox_Datos.Controls.Add(Me.TextBox_NumRemito)
        Me.GroupBox_Datos.Controls.Add(Me.Label12)
        Me.GroupBox_Datos.Controls.Add(Me.Label5)
        Me.GroupBox_Datos.Controls.Add(Me.ComboBox_LugarCarga)
        Me.GroupBox_Datos.Controls.Add(Me.TextBox_KMCamion)
        Me.GroupBox_Datos.Controls.Add(Me.Label11)
        Me.GroupBox_Datos.Controls.Add(Me.Label6)
        Me.GroupBox_Datos.Controls.Add(Me.ComboBox_Detalle)
        Me.GroupBox_Datos.Controls.Add(Me.TextBox_Vehiculo)
        Me.GroupBox_Datos.Controls.Add(Me.Label10)
        Me.GroupBox_Datos.Controls.Add(Me.Label7)
        Me.GroupBox_Datos.Controls.Add(Me.Label9)
        Me.GroupBox_Datos.Controls.Add(Me.TextBox_KMValor)
        Me.GroupBox_Datos.Controls.Add(Me.TextBox_NumCarga)
        Me.GroupBox_Datos.Controls.Add(Me.Label8)
        Me.GroupBox_Datos.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox_Datos.Name = "GroupBox_Datos"
        Me.GroupBox_Datos.Size = New System.Drawing.Size(605, 415)
        Me.GroupBox_Datos.TabIndex = 45
        Me.GroupBox_Datos.TabStop = False
        Me.GroupBox_Datos.Text = "Datos de Carga"
        '
        'Bot_MostrarVehiculos
        '
        Me.Bot_MostrarVehiculos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bot_MostrarVehiculos.BackColor = System.Drawing.SystemColors.Control
        Me.Bot_MostrarVehiculos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_MostrarVehiculos.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bot_MostrarVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_MostrarVehiculos.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_MostrarVehiculos.Image = CType(resources.GetObject("Bot_MostrarVehiculos.Image"), System.Drawing.Image)
        Me.Bot_MostrarVehiculos.Location = New System.Drawing.Point(205, 155)
        Me.Bot_MostrarVehiculos.Name = "Bot_MostrarVehiculos"
        Me.Bot_MostrarVehiculos.Size = New System.Drawing.Size(27, 27)
        Me.Bot_MostrarVehiculos.TabIndex = 7
        Me.Bot_MostrarVehiculos.Tag = "Vehículo"
        Me.Bot_MostrarVehiculos.UseVisualStyleBackColor = False
        '
        'Bot_MostrarClientes
        '
        Me.Bot_MostrarClientes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bot_MostrarClientes.BackColor = System.Drawing.SystemColors.Control
        Me.Bot_MostrarClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_MostrarClientes.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bot_MostrarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_MostrarClientes.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_MostrarClientes.Image = CType(resources.GetObject("Bot_MostrarClientes.Image"), System.Drawing.Image)
        Me.Bot_MostrarClientes.Location = New System.Drawing.Point(437, 47)
        Me.Bot_MostrarClientes.Name = "Bot_MostrarClientes"
        Me.Bot_MostrarClientes.Size = New System.Drawing.Size(27, 27)
        Me.Bot_MostrarClientes.TabIndex = 2
        Me.Bot_MostrarClientes.Tag = "Cliente"
        Me.Bot_MostrarClientes.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 21)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Nº de Orden"
        '
        'TextBox_NumOrden
        '
        Me.TextBox_NumOrden.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_NumOrden.BackColor = System.Drawing.Color.White
        Me.TextBox_NumOrden.Location = New System.Drawing.Point(10, 47)
        Me.TextBox_NumOrden.MaxLength = 255
        Me.TextBox_NumOrden.Name = "TextBox_NumOrden"
        Me.TextBox_NumOrden.ReadOnly = True
        Me.TextBox_NumOrden.Size = New System.Drawing.Size(222, 27)
        Me.TextBox_NumOrden.TabIndex = 0
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 349)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(115, 21)
        Me.Label15.TabIndex = 86
        Me.Label15.Text = "Total a Pagar"
        '
        'TextBox_Cliente
        '
        Me.TextBox_Cliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Cliente.BackColor = System.Drawing.Color.White
        Me.TextBox_Cliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TextBox_Cliente.Location = New System.Drawing.Point(242, 47)
        Me.TextBox_Cliente.Name = "TextBox_Cliente"
        Me.TextBox_Cliente.ReadOnly = True
        Me.TextBox_Cliente.Size = New System.Drawing.Size(189, 27)
        Me.TextBox_Cliente.TabIndex = 1
        '
        'TextBox_Total
        '
        Me.TextBox_Total.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Total.BackColor = System.Drawing.Color.White
        Me.TextBox_Total.Location = New System.Drawing.Point(10, 373)
        Me.TextBox_Total.MaxLength = 255
        Me.TextBox_Total.Name = "TextBox_Total"
        Me.TextBox_Total.ReadOnly = True
        Me.TextBox_Total.Size = New System.Drawing.Size(222, 27)
        Me.TextBox_Total.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(238, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 21)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Cliente *"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(238, 297)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(149, 21)
        Me.Label14.TabIndex = 84
        Me.Label14.Text = "Detalle de Gastos"
        '
        'DatePicker_Fecha
        '
        Me.DatePicker_Fecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DatePicker_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DatePicker_Fecha.Location = New System.Drawing.Point(474, 47)
        Me.DatePicker_Fecha.Name = "DatePicker_Fecha"
        Me.DatePicker_Fecha.Size = New System.Drawing.Size(123, 27)
        Me.DatePicker_Fecha.TabIndex = 3
        '
        'TextBox_DetalleGastos
        '
        Me.TextBox_DetalleGastos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_DetalleGastos.Location = New System.Drawing.Point(242, 321)
        Me.TextBox_DetalleGastos.MaxLength = 255
        Me.TextBox_DetalleGastos.Name = "TextBox_DetalleGastos"
        Me.TextBox_DetalleGastos.Size = New System.Drawing.Size(222, 27)
        Me.TextBox_DetalleGastos.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(470, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 21)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Fecha"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 295)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 21)
        Me.Label13.TabIndex = 82
        Me.Label13.Text = "Gastos"
        '
        'TextBox_NumGuia
        '
        Me.TextBox_NumGuia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_NumGuia.Location = New System.Drawing.Point(10, 101)
        Me.TextBox_NumGuia.MaxLength = 255
        Me.TextBox_NumGuia.Name = "TextBox_NumGuia"
        Me.TextBox_NumGuia.Size = New System.Drawing.Size(222, 27)
        Me.TextBox_NumGuia.TabIndex = 4
        '
        'TextBox_Gastos
        '
        Me.TextBox_Gastos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Gastos.Location = New System.Drawing.Point(10, 319)
        Me.TextBox_Gastos.MaxLength = 255
        Me.TextBox_Gastos.Name = "TextBox_Gastos"
        Me.TextBox_Gastos.Size = New System.Drawing.Size(222, 27)
        Me.TextBox_Gastos.TabIndex = 14
        Me.TextBox_Gastos.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 21)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Nº de Guia *"
        '
        'ComboBox_LugarDescarga
        '
        Me.ComboBox_LugarDescarga.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_LugarDescarga.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox_LugarDescarga.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox_LugarDescarga.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ComboBox_LugarDescarga.FormattingEnabled = True
        Me.ComboBox_LugarDescarga.ItemHeight = 21
        Me.ComboBox_LugarDescarga.Location = New System.Drawing.Point(242, 265)
        Me.ComboBox_LugarDescarga.MaxLength = 255
        Me.ComboBox_LugarDescarga.Name = "ComboBox_LugarDescarga"
        Me.ComboBox_LugarDescarga.Size = New System.Drawing.Size(222, 29)
        Me.ComboBox_LugarDescarga.TabIndex = 13
        '
        'TextBox_NumRemito
        '
        Me.TextBox_NumRemito.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_NumRemito.Location = New System.Drawing.Point(242, 101)
        Me.TextBox_NumRemito.MaxLength = 255
        Me.TextBox_NumRemito.Name = "TextBox_NumRemito"
        Me.TextBox_NumRemito.Size = New System.Drawing.Size(222, 27)
        Me.TextBox_NumRemito.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(238, 241)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(169, 21)
        Me.Label12.TabIndex = 79
        Me.Label12.Text = "Lugar de Descarga *"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(238, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 21)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Nº de Remito *"
        '
        'ComboBox_LugarCarga
        '
        Me.ComboBox_LugarCarga.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_LugarCarga.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox_LugarCarga.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox_LugarCarga.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ComboBox_LugarCarga.FormattingEnabled = True
        Me.ComboBox_LugarCarga.ItemHeight = 21
        Me.ComboBox_LugarCarga.Location = New System.Drawing.Point(10, 263)
        Me.ComboBox_LugarCarga.MaxLength = 255
        Me.ComboBox_LugarCarga.Name = "ComboBox_LugarCarga"
        Me.ComboBox_LugarCarga.Size = New System.Drawing.Size(222, 29)
        Me.ComboBox_LugarCarga.TabIndex = 12
        '
        'TextBox_KMCamion
        '
        Me.TextBox_KMCamion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_KMCamion.Location = New System.Drawing.Point(242, 155)
        Me.TextBox_KMCamion.MaxLength = 255
        Me.TextBox_KMCamion.Name = "TextBox_KMCamion"
        Me.TextBox_KMCamion.Size = New System.Drawing.Size(222, 27)
        Me.TextBox_KMCamion.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 239)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(144, 21)
        Me.Label11.TabIndex = 77
        Me.Label11.Text = "Lugar de Carga *"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(238, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 21)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "KM Camión *"
        '
        'ComboBox_Detalle
        '
        Me.ComboBox_Detalle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_Detalle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox_Detalle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox_Detalle.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ComboBox_Detalle.FormattingEnabled = True
        Me.ComboBox_Detalle.ItemHeight = 21
        Me.ComboBox_Detalle.Location = New System.Drawing.Point(242, 209)
        Me.ComboBox_Detalle.MaxLength = 255
        Me.ComboBox_Detalle.Name = "ComboBox_Detalle"
        Me.ComboBox_Detalle.Size = New System.Drawing.Size(222, 29)
        Me.ComboBox_Detalle.TabIndex = 11
        '
        'TextBox_Vehiculo
        '
        Me.TextBox_Vehiculo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Vehiculo.BackColor = System.Drawing.Color.White
        Me.TextBox_Vehiculo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TextBox_Vehiculo.Location = New System.Drawing.Point(10, 155)
        Me.TextBox_Vehiculo.Name = "TextBox_Vehiculo"
        Me.TextBox_Vehiculo.ReadOnly = True
        Me.TextBox_Vehiculo.Size = New System.Drawing.Size(189, 27)
        Me.TextBox_Vehiculo.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(238, 185)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(156, 21)
        Me.Label10.TabIndex = 75
        Me.Label10.Text = "Detalle de Carga *"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 21)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "Vehículo *"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 185)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(207, 21)
        Me.Label9.TabIndex = 73
        Me.Label9.Text = "Nº de Animales o Carga *"
        '
        'TextBox_KMValor
        '
        Me.TextBox_KMValor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_KMValor.Location = New System.Drawing.Point(474, 155)
        Me.TextBox_KMValor.MaxLength = 255
        Me.TextBox_KMValor.Name = "TextBox_KMValor"
        Me.TextBox_KMValor.Size = New System.Drawing.Size(123, 27)
        Me.TextBox_KMValor.TabIndex = 9
        '
        'TextBox_NumCarga
        '
        Me.TextBox_NumCarga.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_NumCarga.Location = New System.Drawing.Point(10, 209)
        Me.TextBox_NumCarga.MaxLength = 255
        Me.TextBox_NumCarga.Name = "TextBox_NumCarga"
        Me.TextBox_NumCarga.Size = New System.Drawing.Size(222, 27)
        Me.TextBox_NumCarga.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(470, 131)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 21)
        Me.Label8.TabIndex = 71
        Me.Label8.Text = "Valor por KM *"
        '
        'Label_Titulo
        '
        Me.Label_Titulo.AutoSize = True
        Me.Label_Titulo.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Titulo.Location = New System.Drawing.Point(12, 9)
        Me.Label_Titulo.Name = "Label_Titulo"
        Me.Label_Titulo.Size = New System.Drawing.Size(203, 36)
        Me.Label_Titulo.TabIndex = 43
        Me.Label_Titulo.Text = "Nueva Orden"
        '
        'GroupBox_Pago
        '
        Me.GroupBox_Pago.Controls.Add(Me.RadioButton_Pago)
        Me.GroupBox_Pago.Controls.Add(Me.RadioButton_Debe)
        Me.GroupBox_Pago.Location = New System.Drawing.Point(0, 421)
        Me.GroupBox_Pago.Name = "GroupBox_Pago"
        Me.GroupBox_Pago.Size = New System.Drawing.Size(232, 74)
        Me.GroupBox_Pago.TabIndex = 87
        Me.GroupBox_Pago.TabStop = False
        Me.GroupBox_Pago.Text = "Estado de Pago *"
        '
        'RadioButton_Pago
        '
        Me.RadioButton_Pago.AutoSize = True
        Me.RadioButton_Pago.Location = New System.Drawing.Point(87, 26)
        Me.RadioButton_Pago.Name = "RadioButton_Pago"
        Me.RadioButton_Pago.Size = New System.Drawing.Size(50, 17)
        Me.RadioButton_Pago.TabIndex = 18
        Me.RadioButton_Pago.TabStop = True
        Me.RadioButton_Pago.Text = "Pago"
        Me.RadioButton_Pago.UseVisualStyleBackColor = True
        '
        'RadioButton_Debe
        '
        Me.RadioButton_Debe.AutoSize = True
        Me.RadioButton_Debe.Location = New System.Drawing.Point(10, 26)
        Me.RadioButton_Debe.Name = "RadioButton_Debe"
        Me.RadioButton_Debe.Size = New System.Drawing.Size(51, 17)
        Me.RadioButton_Debe.TabIndex = 17
        Me.RadioButton_Debe.TabStop = True
        Me.RadioButton_Debe.Text = "Debe"
        Me.RadioButton_Debe.UseVisualStyleBackColor = True
        '
        'GroupBox_Factura
        '
        Me.GroupBox_Factura.Controls.Add(Me.RadioButton_Facturado)
        Me.GroupBox_Factura.Controls.Add(Me.RadioButton_NoFacturado)
        Me.GroupBox_Factura.Location = New System.Drawing.Point(238, 421)
        Me.GroupBox_Factura.Name = "GroupBox_Factura"
        Me.GroupBox_Factura.Size = New System.Drawing.Size(266, 74)
        Me.GroupBox_Factura.TabIndex = 88
        Me.GroupBox_Factura.TabStop = False
        Me.GroupBox_Factura.Text = "Estado de Facturación *"
        '
        'RadioButton_Facturado
        '
        Me.RadioButton_Facturado.AutoSize = True
        Me.RadioButton_Facturado.Location = New System.Drawing.Point(149, 26)
        Me.RadioButton_Facturado.Name = "RadioButton_Facturado"
        Me.RadioButton_Facturado.Size = New System.Drawing.Size(73, 17)
        Me.RadioButton_Facturado.TabIndex = 20
        Me.RadioButton_Facturado.TabStop = True
        Me.RadioButton_Facturado.Text = "Facturado"
        Me.RadioButton_Facturado.UseVisualStyleBackColor = True
        '
        'RadioButton_NoFacturado
        '
        Me.RadioButton_NoFacturado.AutoSize = True
        Me.RadioButton_NoFacturado.Location = New System.Drawing.Point(9, 26)
        Me.RadioButton_NoFacturado.Name = "RadioButton_NoFacturado"
        Me.RadioButton_NoFacturado.Size = New System.Drawing.Size(87, 17)
        Me.RadioButton_NoFacturado.TabIndex = 19
        Me.RadioButton_NoFacturado.TabStop = True
        Me.RadioButton_NoFacturado.Text = "No facturado"
        Me.RadioButton_NoFacturado.UseVisualStyleBackColor = True
        '
        'Bot_Volver
        '
        Me.Bot_Volver.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bot_Volver.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_Volver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Volver.FlatAppearance.BorderSize = 0
        Me.Bot_Volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Volver.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Volver.Location = New System.Drawing.Point(622, 85)
        Me.Bot_Volver.Name = "Bot_Volver"
        Me.Bot_Volver.Size = New System.Drawing.Size(97, 31)
        Me.Bot_Volver.TabIndex = 23
        Me.Bot_Volver.Text = "Volver"
        Me.Bot_Volver.UseVisualStyleBackColor = False
        '
        'Bot_Cancelar
        '
        Me.Bot_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bot_Cancelar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Cancelar.FlatAppearance.BorderSize = 0
        Me.Bot_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Cancelar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Cancelar.Location = New System.Drawing.Point(622, 48)
        Me.Bot_Cancelar.Name = "Bot_Cancelar"
        Me.Bot_Cancelar.Size = New System.Drawing.Size(97, 31)
        Me.Bot_Cancelar.TabIndex = 22
        Me.Bot_Cancelar.Text = "Cancelar"
        Me.Bot_Cancelar.UseVisualStyleBackColor = False
        '
        'Bot_Guardar
        '
        Me.Bot_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bot_Guardar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_Guardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Guardar.FlatAppearance.BorderSize = 0
        Me.Bot_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Guardar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Guardar.Location = New System.Drawing.Point(622, 11)
        Me.Bot_Guardar.Name = "Bot_Guardar"
        Me.Bot_Guardar.Size = New System.Drawing.Size(97, 31)
        Me.Bot_Guardar.TabIndex = 21
        Me.Bot_Guardar.Text = "Guardar"
        Me.Bot_Guardar.UseVisualStyleBackColor = False
        '
        'Panel_Tablas
        '
        Me.Panel_Tablas.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Panel_Tablas.Controls.Add(Me.CheckedListBox_Vehiculos)
        Me.Panel_Tablas.Controls.Add(Me.WMTextBox_Buscar)
        Me.Panel_Tablas.Controls.Add(Me.Bot_CerrarTabla)
        Me.Panel_Tablas.Controls.Add(Me.Bot_Seleccionar)
        Me.Panel_Tablas.Controls.Add(Me.Bot_Borrar)
        Me.Panel_Tablas.Controls.Add(Me.Label_TituloTabla)
        Me.Panel_Tablas.Controls.Add(Me.DataGridView_Datos)
        Me.Panel_Tablas.Controls.Add(Me.PictureBox1)
        Me.Panel_Tablas.Location = New System.Drawing.Point(797, 94)
        Me.Panel_Tablas.Name = "Panel_Tablas"
        Me.Panel_Tablas.Size = New System.Drawing.Size(355, 495)
        Me.Panel_Tablas.TabIndex = 92
        Me.Panel_Tablas.Visible = False
        '
        'CheckedListBox_Vehiculos
        '
        Me.CheckedListBox_Vehiculos.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.CheckedListBox_Vehiculos.CheckOnClick = True
        Me.CheckedListBox_Vehiculos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckedListBox_Vehiculos.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckedListBox_Vehiculos.ForeColor = System.Drawing.Color.White
        Me.CheckedListBox_Vehiculos.FormattingEnabled = True
        Me.CheckedListBox_Vehiculos.Location = New System.Drawing.Point(13, 58)
        Me.CheckedListBox_Vehiculos.Name = "CheckedListBox_Vehiculos"
        Me.CheckedListBox_Vehiculos.Size = New System.Drawing.Size(328, 378)
        Me.CheckedListBox_Vehiculos.TabIndex = 26
        Me.CheckedListBox_Vehiculos.Visible = False
        '
        'WMTextBox_Buscar
        '
        Me.WMTextBox_Buscar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WMTextBox_Buscar.Location = New System.Drawing.Point(13, 52)
        Me.WMTextBox_Buscar.Name = "WMTextBox_Buscar"
        Me.WMTextBox_Buscar.Size = New System.Drawing.Size(259, 27)
        Me.WMTextBox_Buscar.TabIndex = 24
        Me.WMTextBox_Buscar.WaterMarkColor = System.Drawing.Color.Gray
        Me.WMTextBox_Buscar.WaterMarkText = "Que Buscar?"
        '
        'Bot_CerrarTabla
        '
        Me.Bot_CerrarTabla.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_CerrarTabla.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_CerrarTabla.FlatAppearance.BorderSize = 0
        Me.Bot_CerrarTabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_CerrarTabla.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_CerrarTabla.Location = New System.Drawing.Point(13, 449)
        Me.Bot_CerrarTabla.Name = "Bot_CerrarTabla"
        Me.Bot_CerrarTabla.Size = New System.Drawing.Size(110, 31)
        Me.Bot_CerrarTabla.TabIndex = 28
        Me.Bot_CerrarTabla.Text = "Cerrar"
        Me.Bot_CerrarTabla.UseVisualStyleBackColor = False
        '
        'Bot_Seleccionar
        '
        Me.Bot_Seleccionar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_Seleccionar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Seleccionar.FlatAppearance.BorderSize = 0
        Me.Bot_Seleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Seleccionar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Seleccionar.Location = New System.Drawing.Point(231, 449)
        Me.Bot_Seleccionar.Name = "Bot_Seleccionar"
        Me.Bot_Seleccionar.Size = New System.Drawing.Size(110, 31)
        Me.Bot_Seleccionar.TabIndex = 27
        Me.Bot_Seleccionar.Text = "Seleccionar"
        Me.Bot_Seleccionar.UseVisualStyleBackColor = False
        '
        'Bot_Borrar
        '
        Me.Bot_Borrar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_Borrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Borrar.FlatAppearance.BorderSize = 0
        Me.Bot_Borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Borrar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Borrar.Location = New System.Drawing.Point(278, 50)
        Me.Bot_Borrar.Name = "Bot_Borrar"
        Me.Bot_Borrar.Size = New System.Drawing.Size(63, 31)
        Me.Bot_Borrar.TabIndex = 25
        Me.Bot_Borrar.Text = "Borrar"
        Me.Bot_Borrar.UseVisualStyleBackColor = False
        '
        'Label_TituloTabla
        '
        Me.Label_TituloTabla.AutoSize = True
        Me.Label_TituloTabla.BackColor = System.Drawing.SystemColors.Control
        Me.Label_TituloTabla.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TituloTabla.Location = New System.Drawing.Point(7, 11)
        Me.Label_TituloTabla.Name = "Label_TituloTabla"
        Me.Label_TituloTabla.Size = New System.Drawing.Size(334, 36)
        Me.Label_TituloTabla.TabIndex = 93
        Me.Label_TituloTabla.Text = "Seleccionar VEHICULO"
        '
        'DataGridView_Datos
        '
        Me.DataGridView_Datos.AllowUserToAddRows = False
        Me.DataGridView_Datos.AllowUserToDeleteRows = False
        Me.DataGridView_Datos.AllowUserToResizeRows = False
        Me.DataGridView_Datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_Datos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DataGridView_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Datos.Location = New System.Drawing.Point(13, 87)
        Me.DataGridView_Datos.MultiSelect = False
        Me.DataGridView_Datos.Name = "DataGridView_Datos"
        Me.DataGridView_Datos.ReadOnly = True
        Me.DataGridView_Datos.RowHeadersVisible = False
        Me.DataGridView_Datos.RowHeadersWidth = 30
        Me.DataGridView_Datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Datos.Size = New System.Drawing.Size(328, 355)
        Me.DataGridView_Datos.TabIndex = 25
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(349, 489)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel_Datos
        '
        Me.Panel_Datos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Datos.Controls.Add(Me.Panel_Aceite)
        Me.Panel_Datos.Controls.Add(Me.Bot_Guardar)
        Me.Panel_Datos.Controls.Add(Me.GroupBox_Factura)
        Me.Panel_Datos.Controls.Add(Me.Bot_Volver)
        Me.Panel_Datos.Controls.Add(Me.GroupBox_Pago)
        Me.Panel_Datos.Controls.Add(Me.Bot_Cancelar)
        Me.Panel_Datos.Controls.Add(Me.GroupBox_Datos)
        Me.Panel_Datos.Location = New System.Drawing.Point(68, 89)
        Me.Panel_Datos.Name = "Panel_Datos"
        Me.Panel_Datos.Size = New System.Drawing.Size(723, 499)
        Me.Panel_Datos.TabIndex = 93
        '
        'Panel_Aceite
        '
        Me.Panel_Aceite.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Aceite.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Panel_Aceite.Controls.Add(Me.TextBox_AceiteVencido)
        Me.Panel_Aceite.Controls.Add(Me.Label18)
        Me.Panel_Aceite.Controls.Add(Me.TextBox_AceiteMil)
        Me.Panel_Aceite.Controls.Add(Me.Label16)
        Me.Panel_Aceite.Controls.Add(Me.Label17)
        Me.Panel_Aceite.Controls.Add(Me.PictureBox2)
        Me.Panel_Aceite.Location = New System.Drawing.Point(474, 188)
        Me.Panel_Aceite.Name = "Panel_Aceite"
        Me.Panel_Aceite.Size = New System.Drawing.Size(246, 199)
        Me.Panel_Aceite.TabIndex = 95
        Me.Panel_Aceite.Visible = False
        '
        'TextBox_AceiteVencido
        '
        Me.TextBox_AceiteVencido.BackColor = System.Drawing.Color.LightCoral
        Me.TextBox_AceiteVencido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_AceiteVencido.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_AceiteVencido.ForeColor = System.Drawing.Color.Black
        Me.TextBox_AceiteVencido.Location = New System.Drawing.Point(11, 89)
        Me.TextBox_AceiteVencido.MaxLength = 255
        Me.TextBox_AceiteVencido.Name = "TextBox_AceiteVencido"
        Me.TextBox_AceiteVencido.ReadOnly = True
        Me.TextBox_AceiteVencido.Size = New System.Drawing.Size(225, 27)
        Me.TextBox_AceiteVencido.TabIndex = 87
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.SystemColors.Control
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Firebrick
        Me.Label18.Location = New System.Drawing.Point(4, 6)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(87, 19)
        Me.Label18.TabIndex = 87
        Me.Label18.Text = "¡Atención!"
        '
        'TextBox_AceiteMil
        '
        Me.TextBox_AceiteMil.BackColor = System.Drawing.Color.LightGreen
        Me.TextBox_AceiteMil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_AceiteMil.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_AceiteMil.ForeColor = System.Drawing.Color.Black
        Me.TextBox_AceiteMil.Location = New System.Drawing.Point(11, 161)
        Me.TextBox_AceiteMil.MaxLength = 255
        Me.TextBox_AceiteMil.Name = "TextBox_AceiteMil"
        Me.TextBox_AceiteMil.ReadOnly = True
        Me.TextBox_AceiteMil.Size = New System.Drawing.Size(225, 27)
        Me.TextBox_AceiteMil.TabIndex = 89
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(7, 26)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(233, 75)
        Me.Label16.TabIndex = 87
        Me.Label16.Text = "Si realiza esta orden debe realizar un cambio de aceite en los vehiculos:"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.SystemColors.Control
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(7, 117)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(233, 43)
        Me.Label17.TabIndex = 88
        Me.Label17.Text = "Y faltarán menos de 1000km para cambiarle el aceite a:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox2.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(240, 193)
        Me.PictureBox2.TabIndex = 90
        Me.PictureBox2.TabStop = False
        '
        'Form_AgregarModificarOrden
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1004, 690)
        Me.Controls.Add(Me.Panel_Tablas)
        Me.Controls.Add(Me.Label_Titulo)
        Me.Controls.Add(Me.Panel_Datos)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_AgregarModificarOrden"
        Me.Text = "Form_AgregarModificarOrden"
        Me.GroupBox_Datos.ResumeLayout(False)
        Me.GroupBox_Datos.PerformLayout()
        Me.GroupBox_Pago.ResumeLayout(False)
        Me.GroupBox_Pago.PerformLayout()
        Me.GroupBox_Factura.ResumeLayout(False)
        Me.GroupBox_Factura.PerformLayout()
        Me.Panel_Tablas.ResumeLayout(False)
        Me.Panel_Tablas.PerformLayout()
        CType(Me.DataGridView_Datos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Datos.ResumeLayout(False)
        Me.Panel_Aceite.ResumeLayout(False)
        Me.Panel_Aceite.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox_Datos As System.Windows.Forms.GroupBox
    Friend WithEvents Label_Titulo As System.Windows.Forms.Label
    Friend WithEvents TextBox_NumOrden As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Cliente As System.Windows.Forms.TextBox
    Friend WithEvents DatePicker_Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox_NumGuia As System.Windows.Forms.TextBox
    Friend WithEvents Bot_MostrarVehiculos As System.Windows.Forms.Button
    Friend WithEvents Bot_MostrarClientes As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Total As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TextBox_DetalleGastos As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Gastos As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox_LugarDescarga As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox_NumRemito As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComboBox_LugarCarga As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox_KMCamion As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboBox_Detalle As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox_Vehiculo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox_KMValor As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_NumCarga As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox_Pago As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton_Pago As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_Debe As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox_Factura As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton_Facturado As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_NoFacturado As System.Windows.Forms.RadioButton
    Friend WithEvents Bot_Volver As System.Windows.Forms.Button
    Friend WithEvents Bot_Cancelar As System.Windows.Forms.Button
    Friend WithEvents Bot_Guardar As System.Windows.Forms.Button
    Friend WithEvents Panel_Tablas As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label_TituloTabla As System.Windows.Forms.Label
    Friend WithEvents Bot_Seleccionar As System.Windows.Forms.Button
    Friend WithEvents Bot_Borrar As System.Windows.Forms.Button
    Friend WithEvents Panel_Datos As System.Windows.Forms.Panel
    Friend WithEvents Bot_CerrarTabla As System.Windows.Forms.Button
    Friend WithEvents WMTextBox_Buscar As Transportes.WatermarkTextBox
    Friend WithEvents DataGridView_Datos As System.Windows.Forms.DataGridView
    Friend WithEvents CheckedListBox_Vehiculos As System.Windows.Forms.CheckedListBox
    Friend WithEvents Panel_Aceite As System.Windows.Forms.Panel
    Friend WithEvents TextBox_AceiteVencido As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TextBox_AceiteMil As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
