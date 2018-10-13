<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Saldos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel_Entrega = New System.Windows.Forms.Panel()
        Me.Bot_ImprimirE = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_MontoOrden = New System.Windows.Forms.TextBox()
        Me.TextBox_SaldoOrden = New System.Windows.Forms.TextBox()
        Me.WMTextBox_BuscarEntrega = New Transportes.WatermarkTextBox()
        Me.Bot_BorrarEntrega = New System.Windows.Forms.Button()
        Me.Bot_VerDatos = New System.Windows.Forms.Button()
        Me.Bot_Eliminar = New System.Windows.Forms.Button()
        Me.Bot_Modificar = New System.Windows.Forms.Button()
        Me.Bot_Agregar = New System.Windows.Forms.Button()
        Me.DataGridView_Entregas = New System.Windows.Forms.DataGridView()
        Me.Bot_Volver = New System.Windows.Forms.Button()
        Me.Panel_Cliente = New System.Windows.Forms.Panel()
        Me.WMTextBox_BuscarCliente = New Transportes.WatermarkTextBox()
        Me.Bot_BorrarCliente = New System.Windows.Forms.Button()
        Me.Bot_SeleccionarCliente = New System.Windows.Forms.Button()
        Me.DataGridView_Clientes = New System.Windows.Forms.DataGridView()
        Me.Panel_Orden = New System.Windows.Forms.Panel()
        Me.Bot_ImprimirO = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Radio_Pago = New System.Windows.Forms.RadioButton()
        Me.Radio_Debe = New System.Windows.Forms.RadioButton()
        Me.TextBox_SaldoTotal = New System.Windows.Forms.TextBox()
        Me.WMTextBox_BuscarOrden = New Transportes.WatermarkTextBox()
        Me.Bot_BorrarOrden = New System.Windows.Forms.Button()
        Me.Bot_VolverACliente = New System.Windows.Forms.Button()
        Me.Bot_SeleccionarOrden = New System.Windows.Forms.Button()
        Me.DataGridView_Ordenes = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label_Titulo = New System.Windows.Forms.Label()
        Me.Label_Accion = New System.Windows.Forms.Label()
        Me.Panel_Entrega.SuspendLayout()
        CType(Me.DataGridView_Entregas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Cliente.SuspendLayout()
        CType(Me.DataGridView_Clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Orden.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView_Ordenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(383, 36)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Buscar entregas por Saldo"
        '
        'Panel_Entrega
        '
        Me.Panel_Entrega.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Entrega.Controls.Add(Me.Bot_ImprimirE)
        Me.Panel_Entrega.Controls.Add(Me.Label4)
        Me.Panel_Entrega.Controls.Add(Me.Label3)
        Me.Panel_Entrega.Controls.Add(Me.TextBox_MontoOrden)
        Me.Panel_Entrega.Controls.Add(Me.TextBox_SaldoOrden)
        Me.Panel_Entrega.Controls.Add(Me.WMTextBox_BuscarEntrega)
        Me.Panel_Entrega.Controls.Add(Me.Bot_BorrarEntrega)
        Me.Panel_Entrega.Controls.Add(Me.Bot_VerDatos)
        Me.Panel_Entrega.Controls.Add(Me.Bot_Eliminar)
        Me.Panel_Entrega.Controls.Add(Me.Bot_Modificar)
        Me.Panel_Entrega.Controls.Add(Me.Bot_Agregar)
        Me.Panel_Entrega.Controls.Add(Me.DataGridView_Entregas)
        Me.Panel_Entrega.Controls.Add(Me.Bot_Volver)
        Me.Panel_Entrega.Location = New System.Drawing.Point(66, 64)
        Me.Panel_Entrega.Name = "Panel_Entrega"
        Me.Panel_Entrega.Size = New System.Drawing.Size(879, 614)
        Me.Panel_Entrega.TabIndex = 33
        Me.Panel_Entrega.Visible = False
        '
        'Bot_ImprimirE
        '
        Me.Bot_ImprimirE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bot_ImprimirE.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_ImprimirE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_ImprimirE.FlatAppearance.BorderSize = 0
        Me.Bot_ImprimirE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_ImprimirE.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_ImprimirE.Location = New System.Drawing.Point(779, 184)
        Me.Bot_ImprimirE.Name = "Bot_ImprimirE"
        Me.Bot_ImprimirE.Size = New System.Drawing.Size(97, 31)
        Me.Bot_ImprimirE.TabIndex = 7
        Me.Bot_ImprimirE.Text = "Imprimir"
        Me.Bot_ImprimirE.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(508, 584)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 21)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Saldo restante:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(237, 584)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 21)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Monto de la orden:"
        '
        'TextBox_MontoOrden
        '
        Me.TextBox_MontoOrden.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_MontoOrden.BackColor = System.Drawing.Color.White
        Me.TextBox_MontoOrden.Location = New System.Drawing.Point(402, 581)
        Me.TextBox_MontoOrden.Name = "TextBox_MontoOrden"
        Me.TextBox_MontoOrden.ReadOnly = True
        Me.TextBox_MontoOrden.Size = New System.Drawing.Size(100, 27)
        Me.TextBox_MontoOrden.TabIndex = 9
        '
        'TextBox_SaldoOrden
        '
        Me.TextBox_SaldoOrden.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_SaldoOrden.BackColor = System.Drawing.Color.White
        Me.TextBox_SaldoOrden.Location = New System.Drawing.Point(641, 581)
        Me.TextBox_SaldoOrden.Name = "TextBox_SaldoOrden"
        Me.TextBox_SaldoOrden.ReadOnly = True
        Me.TextBox_SaldoOrden.Size = New System.Drawing.Size(100, 27)
        Me.TextBox_SaldoOrden.TabIndex = 10
        '
        'WMTextBox_BuscarEntrega
        '
        Me.WMTextBox_BuscarEntrega.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WMTextBox_BuscarEntrega.Location = New System.Drawing.Point(3, 3)
        Me.WMTextBox_BuscarEntrega.Name = "WMTextBox_BuscarEntrega"
        Me.WMTextBox_BuscarEntrega.Size = New System.Drawing.Size(482, 27)
        Me.WMTextBox_BuscarEntrega.TabIndex = 0
        Me.WMTextBox_BuscarEntrega.WaterMarkColor = System.Drawing.Color.Gray
        Me.WMTextBox_BuscarEntrega.WaterMarkText = "Buscar Entregas por Nº de Recibo o Nº de Factura"
        '
        'Bot_BorrarEntrega
        '
        Me.Bot_BorrarEntrega.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_BorrarEntrega.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_BorrarEntrega.FlatAppearance.BorderSize = 0
        Me.Bot_BorrarEntrega.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_BorrarEntrega.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_BorrarEntrega.Location = New System.Drawing.Point(491, 1)
        Me.Bot_BorrarEntrega.Name = "Bot_BorrarEntrega"
        Me.Bot_BorrarEntrega.Size = New System.Drawing.Size(97, 31)
        Me.Bot_BorrarEntrega.TabIndex = 1
        Me.Bot_BorrarEntrega.Text = "Borrar"
        Me.Bot_BorrarEntrega.UseVisualStyleBackColor = False
        '
        'Bot_VerDatos
        '
        Me.Bot_VerDatos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bot_VerDatos.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_VerDatos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_VerDatos.FlatAppearance.BorderSize = 0
        Me.Bot_VerDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_VerDatos.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_VerDatos.Location = New System.Drawing.Point(779, 110)
        Me.Bot_VerDatos.Name = "Bot_VerDatos"
        Me.Bot_VerDatos.Size = New System.Drawing.Size(97, 31)
        Me.Bot_VerDatos.TabIndex = 5
        Me.Bot_VerDatos.Tag = "Datos Vehículo"
        Me.Bot_VerDatos.Text = "Ver Datos"
        Me.Bot_VerDatos.UseVisualStyleBackColor = False
        '
        'Bot_Eliminar
        '
        Me.Bot_Eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bot_Eliminar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Eliminar.FlatAppearance.BorderSize = 0
        Me.Bot_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Eliminar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Eliminar.Location = New System.Drawing.Point(779, 147)
        Me.Bot_Eliminar.Name = "Bot_Eliminar"
        Me.Bot_Eliminar.Size = New System.Drawing.Size(97, 31)
        Me.Bot_Eliminar.TabIndex = 6
        Me.Bot_Eliminar.Text = "Eliminar"
        Me.Bot_Eliminar.UseVisualStyleBackColor = False
        '
        'Bot_Modificar
        '
        Me.Bot_Modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bot_Modificar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_Modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Modificar.FlatAppearance.BorderSize = 0
        Me.Bot_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Modificar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Modificar.Location = New System.Drawing.Point(779, 73)
        Me.Bot_Modificar.Name = "Bot_Modificar"
        Me.Bot_Modificar.Size = New System.Drawing.Size(97, 31)
        Me.Bot_Modificar.TabIndex = 4
        Me.Bot_Modificar.Tag = "Modificar Vehículo"
        Me.Bot_Modificar.Text = "Modificar"
        Me.Bot_Modificar.UseVisualStyleBackColor = False
        '
        'Bot_Agregar
        '
        Me.Bot_Agregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bot_Agregar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_Agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Agregar.FlatAppearance.BorderSize = 0
        Me.Bot_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Agregar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Agregar.Location = New System.Drawing.Point(779, 36)
        Me.Bot_Agregar.Name = "Bot_Agregar"
        Me.Bot_Agregar.Size = New System.Drawing.Size(97, 31)
        Me.Bot_Agregar.TabIndex = 3
        Me.Bot_Agregar.Tag = "Agregar Vehículo"
        Me.Bot_Agregar.Text = "Agregar"
        Me.Bot_Agregar.UseVisualStyleBackColor = False
        '
        'DataGridView_Entregas
        '
        Me.DataGridView_Entregas.AllowUserToAddRows = False
        Me.DataGridView_Entregas.AllowUserToDeleteRows = False
        Me.DataGridView_Entregas.AllowUserToResizeRows = False
        Me.DataGridView_Entregas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_Entregas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_Entregas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DataGridView_Entregas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Entregas.Location = New System.Drawing.Point(3, 36)
        Me.DataGridView_Entregas.MultiSelect = False
        Me.DataGridView_Entregas.Name = "DataGridView_Entregas"
        Me.DataGridView_Entregas.ReadOnly = True
        Me.DataGridView_Entregas.RowHeadersWidth = 30
        Me.DataGridView_Entregas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Entregas.Size = New System.Drawing.Size(770, 539)
        Me.DataGridView_Entregas.TabIndex = 55
        '
        'Bot_Volver
        '
        Me.Bot_Volver.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bot_Volver.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_Volver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Volver.FlatAppearance.BorderSize = 0
        Me.Bot_Volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Volver.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Volver.Location = New System.Drawing.Point(779, 221)
        Me.Bot_Volver.Name = "Bot_Volver"
        Me.Bot_Volver.Size = New System.Drawing.Size(97, 31)
        Me.Bot_Volver.TabIndex = 8
        Me.Bot_Volver.Text = "Volver"
        Me.Bot_Volver.UseVisualStyleBackColor = False
        '
        'Panel_Cliente
        '
        Me.Panel_Cliente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Cliente.Controls.Add(Me.WMTextBox_BuscarCliente)
        Me.Panel_Cliente.Controls.Add(Me.Bot_BorrarCliente)
        Me.Panel_Cliente.Controls.Add(Me.Bot_SeleccionarCliente)
        Me.Panel_Cliente.Controls.Add(Me.DataGridView_Clientes)
        Me.Panel_Cliente.Location = New System.Drawing.Point(41, 648)
        Me.Panel_Cliente.Name = "Panel_Cliente"
        Me.Panel_Cliente.Size = New System.Drawing.Size(876, 614)
        Me.Panel_Cliente.TabIndex = 34
        '
        'WMTextBox_BuscarCliente
        '
        Me.WMTextBox_BuscarCliente.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WMTextBox_BuscarCliente.Location = New System.Drawing.Point(3, 3)
        Me.WMTextBox_BuscarCliente.Name = "WMTextBox_BuscarCliente"
        Me.WMTextBox_BuscarCliente.Size = New System.Drawing.Size(482, 27)
        Me.WMTextBox_BuscarCliente.TabIndex = 0
        Me.WMTextBox_BuscarCliente.WaterMarkColor = System.Drawing.Color.Gray
        Me.WMTextBox_BuscarCliente.WaterMarkText = "Buscar Clientes por Nombre o Código"
        '
        'Bot_BorrarCliente
        '
        Me.Bot_BorrarCliente.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_BorrarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_BorrarCliente.FlatAppearance.BorderSize = 0
        Me.Bot_BorrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_BorrarCliente.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_BorrarCliente.Location = New System.Drawing.Point(491, 1)
        Me.Bot_BorrarCliente.Name = "Bot_BorrarCliente"
        Me.Bot_BorrarCliente.Size = New System.Drawing.Size(97, 31)
        Me.Bot_BorrarCliente.TabIndex = 1
        Me.Bot_BorrarCliente.Text = "Borrar"
        Me.Bot_BorrarCliente.UseVisualStyleBackColor = False
        '
        'Bot_SeleccionarCliente
        '
        Me.Bot_SeleccionarCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bot_SeleccionarCliente.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_SeleccionarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_SeleccionarCliente.FlatAppearance.BorderSize = 0
        Me.Bot_SeleccionarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_SeleccionarCliente.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_SeleccionarCliente.Location = New System.Drawing.Point(776, 36)
        Me.Bot_SeleccionarCliente.Name = "Bot_SeleccionarCliente"
        Me.Bot_SeleccionarCliente.Size = New System.Drawing.Size(97, 31)
        Me.Bot_SeleccionarCliente.TabIndex = 3
        Me.Bot_SeleccionarCliente.Tag = "Agregar Vehículo"
        Me.Bot_SeleccionarCliente.Text = "Elegir"
        Me.Bot_SeleccionarCliente.UseVisualStyleBackColor = False
        '
        'DataGridView_Clientes
        '
        Me.DataGridView_Clientes.AllowUserToAddRows = False
        Me.DataGridView_Clientes.AllowUserToDeleteRows = False
        Me.DataGridView_Clientes.AllowUserToResizeRows = False
        Me.DataGridView_Clientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_Clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_Clientes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DataGridView_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Clientes.Location = New System.Drawing.Point(3, 36)
        Me.DataGridView_Clientes.MultiSelect = False
        Me.DataGridView_Clientes.Name = "DataGridView_Clientes"
        Me.DataGridView_Clientes.ReadOnly = True
        Me.DataGridView_Clientes.RowHeadersWidth = 30
        Me.DataGridView_Clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Clientes.Size = New System.Drawing.Size(767, 572)
        Me.DataGridView_Clientes.TabIndex = 2
        '
        'Panel_Orden
        '
        Me.Panel_Orden.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Orden.Controls.Add(Me.Bot_ImprimirO)
        Me.Panel_Orden.Controls.Add(Me.GroupBox1)
        Me.Panel_Orden.Controls.Add(Me.TextBox_SaldoTotal)
        Me.Panel_Orden.Controls.Add(Me.WMTextBox_BuscarOrden)
        Me.Panel_Orden.Controls.Add(Me.Bot_BorrarOrden)
        Me.Panel_Orden.Controls.Add(Me.Bot_VolverACliente)
        Me.Panel_Orden.Controls.Add(Me.Bot_SeleccionarOrden)
        Me.Panel_Orden.Controls.Add(Me.DataGridView_Ordenes)
        Me.Panel_Orden.Controls.Add(Me.Label2)
        Me.Panel_Orden.Location = New System.Drawing.Point(961, 64)
        Me.Panel_Orden.Name = "Panel_Orden"
        Me.Panel_Orden.Size = New System.Drawing.Size(879, 614)
        Me.Panel_Orden.TabIndex = 35
        Me.Panel_Orden.Visible = False
        '
        'Bot_ImprimirO
        '
        Me.Bot_ImprimirO.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bot_ImprimirO.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_ImprimirO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_ImprimirO.FlatAppearance.BorderSize = 0
        Me.Bot_ImprimirO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_ImprimirO.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_ImprimirO.Location = New System.Drawing.Point(779, 73)
        Me.Bot_ImprimirO.Name = "Bot_ImprimirO"
        Me.Bot_ImprimirO.Size = New System.Drawing.Size(97, 31)
        Me.Bot_ImprimirO.TabIndex = 4
        Me.Bot_ImprimirO.Tag = "Modificar Vehículo"
        Me.Bot_ImprimirO.Text = "Imprimir"
        Me.Bot_ImprimirO.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Radio_Pago)
        Me.GroupBox1.Controls.Add(Me.Radio_Debe)
        Me.GroupBox1.Location = New System.Drawing.Point(779, 147)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(97, 70)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
        '
        'Radio_Pago
        '
        Me.Radio_Pago.AutoSize = True
        Me.Radio_Pago.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Radio_Pago.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radio_Pago.Location = New System.Drawing.Point(7, 20)
        Me.Radio_Pago.Name = "Radio_Pago"
        Me.Radio_Pago.Size = New System.Drawing.Size(66, 21)
        Me.Radio_Pago.TabIndex = 7
        Me.Radio_Pago.TabStop = True
        Me.Radio_Pago.Tag = "Pago"
        Me.Radio_Pago.Text = "Pagas"
        Me.Radio_Pago.UseVisualStyleBackColor = True
        '
        'Radio_Debe
        '
        Me.Radio_Debe.AutoSize = True
        Me.Radio_Debe.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Radio_Debe.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radio_Debe.Location = New System.Drawing.Point(7, 43)
        Me.Radio_Debe.Name = "Radio_Debe"
        Me.Radio_Debe.Size = New System.Drawing.Size(89, 21)
        Me.Radio_Debe.TabIndex = 8
        Me.Radio_Debe.TabStop = True
        Me.Radio_Debe.Tag = "Debe"
        Me.Radio_Debe.Text = "No Pagas"
        Me.Radio_Debe.UseVisualStyleBackColor = True
        '
        'TextBox_SaldoTotal
        '
        Me.TextBox_SaldoTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_SaldoTotal.BackColor = System.Drawing.Color.White
        Me.TextBox_SaldoTotal.Location = New System.Drawing.Point(641, 581)
        Me.TextBox_SaldoTotal.Name = "TextBox_SaldoTotal"
        Me.TextBox_SaldoTotal.ReadOnly = True
        Me.TextBox_SaldoTotal.Size = New System.Drawing.Size(100, 27)
        Me.TextBox_SaldoTotal.TabIndex = 7
        '
        'WMTextBox_BuscarOrden
        '
        Me.WMTextBox_BuscarOrden.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WMTextBox_BuscarOrden.Location = New System.Drawing.Point(3, 3)
        Me.WMTextBox_BuscarOrden.Name = "WMTextBox_BuscarOrden"
        Me.WMTextBox_BuscarOrden.Size = New System.Drawing.Size(482, 27)
        Me.WMTextBox_BuscarOrden.TabIndex = 0
        Me.WMTextBox_BuscarOrden.WaterMarkColor = System.Drawing.Color.Gray
        Me.WMTextBox_BuscarOrden.WaterMarkText = "Buscar Orden por Nº, Guía, Camión, Detalle o Lugar"
        '
        'Bot_BorrarOrden
        '
        Me.Bot_BorrarOrden.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_BorrarOrden.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_BorrarOrden.FlatAppearance.BorderSize = 0
        Me.Bot_BorrarOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_BorrarOrden.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_BorrarOrden.Location = New System.Drawing.Point(491, 1)
        Me.Bot_BorrarOrden.Name = "Bot_BorrarOrden"
        Me.Bot_BorrarOrden.Size = New System.Drawing.Size(97, 31)
        Me.Bot_BorrarOrden.TabIndex = 1
        Me.Bot_BorrarOrden.Text = "Borrar"
        Me.Bot_BorrarOrden.UseVisualStyleBackColor = False
        '
        'Bot_VolverACliente
        '
        Me.Bot_VolverACliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bot_VolverACliente.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_VolverACliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_VolverACliente.FlatAppearance.BorderSize = 0
        Me.Bot_VolverACliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_VolverACliente.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_VolverACliente.Location = New System.Drawing.Point(779, 110)
        Me.Bot_VolverACliente.Name = "Bot_VolverACliente"
        Me.Bot_VolverACliente.Size = New System.Drawing.Size(97, 31)
        Me.Bot_VolverACliente.TabIndex = 5
        Me.Bot_VolverACliente.Tag = "Modificar Vehículo"
        Me.Bot_VolverACliente.Text = "Volver"
        Me.Bot_VolverACliente.UseVisualStyleBackColor = False
        '
        'Bot_SeleccionarOrden
        '
        Me.Bot_SeleccionarOrden.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bot_SeleccionarOrden.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_SeleccionarOrden.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_SeleccionarOrden.FlatAppearance.BorderSize = 0
        Me.Bot_SeleccionarOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_SeleccionarOrden.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_SeleccionarOrden.Location = New System.Drawing.Point(779, 36)
        Me.Bot_SeleccionarOrden.Name = "Bot_SeleccionarOrden"
        Me.Bot_SeleccionarOrden.Size = New System.Drawing.Size(97, 31)
        Me.Bot_SeleccionarOrden.TabIndex = 3
        Me.Bot_SeleccionarOrden.Tag = "Agregar Vehículo"
        Me.Bot_SeleccionarOrden.Text = "Elegir"
        Me.Bot_SeleccionarOrden.UseVisualStyleBackColor = False
        '
        'DataGridView_Ordenes
        '
        Me.DataGridView_Ordenes.AllowUserToAddRows = False
        Me.DataGridView_Ordenes.AllowUserToDeleteRows = False
        Me.DataGridView_Ordenes.AllowUserToResizeRows = False
        Me.DataGridView_Ordenes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_Ordenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_Ordenes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DataGridView_Ordenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Ordenes.Location = New System.Drawing.Point(3, 36)
        Me.DataGridView_Ordenes.MultiSelect = False
        Me.DataGridView_Ordenes.Name = "DataGridView_Ordenes"
        Me.DataGridView_Ordenes.ReadOnly = True
        Me.DataGridView_Ordenes.RowHeadersWidth = 30
        Me.DataGridView_Ordenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Ordenes.Size = New System.Drawing.Size(770, 539)
        Me.DataGridView_Ordenes.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(427, 584)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(211, 21)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Saldo a Pagar del Cliente:"
        '
        'Label_Titulo
        '
        Me.Label_Titulo.AutoSize = True
        Me.Label_Titulo.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Titulo.Location = New System.Drawing.Point(388, 19)
        Me.Label_Titulo.Name = "Label_Titulo"
        Me.Label_Titulo.Size = New System.Drawing.Size(236, 24)
        Me.Label_Titulo.TabIndex = 39
        Me.Label_Titulo.Text = "Seleccione un Cliente"
        '
        'Label_Accion
        '
        Me.Label_Accion.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Accion.Location = New System.Drawing.Point(66, 48)
        Me.Label_Accion.Name = "Label_Accion"
        Me.Label_Accion.Size = New System.Drawing.Size(584, 24)
        Me.Label_Accion.TabIndex = 51
        Me.Label_Accion.Text = "Cliente, Orden"
        '
        'Form_Saldos
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1004, 690)
        Me.Controls.Add(Me.Panel_Cliente)
        Me.Controls.Add(Me.Panel_Orden)
        Me.Controls.Add(Me.Panel_Entrega)
        Me.Controls.Add(Me.Label_Accion)
        Me.Controls.Add(Me.Label_Titulo)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_Saldos"
        Me.Text = "Form_Saldos"
        Me.Panel_Entrega.ResumeLayout(False)
        Me.Panel_Entrega.PerformLayout()
        CType(Me.DataGridView_Entregas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Cliente.ResumeLayout(False)
        Me.Panel_Cliente.PerformLayout()
        CType(Me.DataGridView_Clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Orden.ResumeLayout(False)
        Me.Panel_Orden.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView_Ordenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel_Entrega As System.Windows.Forms.Panel
    Friend WithEvents Bot_VerDatos As System.Windows.Forms.Button
    Friend WithEvents Bot_Eliminar As System.Windows.Forms.Button
    Friend WithEvents Bot_Modificar As System.Windows.Forms.Button
    Friend WithEvents Bot_Agregar As System.Windows.Forms.Button
    Friend WithEvents Bot_Volver As System.Windows.Forms.Button
    Friend WithEvents Bot_BorrarEntrega As System.Windows.Forms.Button
    Friend WithEvents Panel_Cliente As System.Windows.Forms.Panel
    Friend WithEvents Bot_BorrarCliente As System.Windows.Forms.Button
    Friend WithEvents Bot_SeleccionarCliente As System.Windows.Forms.Button
    Friend WithEvents Panel_Orden As System.Windows.Forms.Panel
    Friend WithEvents Bot_BorrarOrden As System.Windows.Forms.Button
    Friend WithEvents Bot_VolverACliente As System.Windows.Forms.Button
    Friend WithEvents Bot_SeleccionarOrden As System.Windows.Forms.Button
    Friend WithEvents WMTextBox_BuscarEntrega As Transportes.WatermarkTextBox
    Friend WithEvents WMTextBox_BuscarCliente As Transportes.WatermarkTextBox
    Friend WithEvents WMTextBox_BuscarOrden As Transportes.WatermarkTextBox
    Friend WithEvents TextBox_SaldoTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox_SaldoOrden As System.Windows.Forms.TextBox
    Friend WithEvents Label_Titulo As System.Windows.Forms.Label
    Friend WithEvents DataGridView_Clientes As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView_Ordenes As System.Windows.Forms.DataGridView
    Friend WithEvents Label_Accion As Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox_MontoOrden As System.Windows.Forms.TextBox
    Friend WithEvents Radio_Debe As System.Windows.Forms.RadioButton
    Friend WithEvents Radio_Pago As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView_Entregas As DataGridView
    Friend WithEvents Bot_ImprimirE As System.Windows.Forms.Button
    Friend WithEvents Bot_ImprimirO As System.Windows.Forms.Button
End Class
