<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_BuscarVehiculos
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
        Me.Panel_Accion = New System.Windows.Forms.Panel()
        Me.Bot_Cancelar = New System.Windows.Forms.Button()
        Me.Bot_Guardar = New System.Windows.Forms.Button()
        Me.GroupBox_Mantenimiento = New System.Windows.Forms.GroupBox()
        Me.DatePicker_Proximo = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DatePicker_Ultimo = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox_KMCubierta = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox_KMAceite = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox_KMActuales = New System.Windows.Forms.TextBox()
        Me.GroupBox_Camion = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox_Marca = New System.Windows.Forms.TextBox()
        Me.TextBox_Matrícula = New System.Windows.Forms.TextBox()
        Me.TextBox_Modelo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label_Accion = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel_Busqueda = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.DataGridView_Camiones = New System.Windows.Forms.DataGridView()
        Me.WMTextBox_Buscar = New Transportes.WatermarkTextBox()
        Me.Bot_VerDatos = New System.Windows.Forms.Button()
        Me.Bot_Historial = New System.Windows.Forms.Button()
        Me.Bot_Eliminar = New System.Windows.Forms.Button()
        Me.Bot_Borrar = New System.Windows.Forms.Button()
        Me.Bot_Modificar = New System.Windows.Forms.Button()
        Me.Bot_Agregar = New System.Windows.Forms.Button()
        Me.Panel_Accion.SuspendLayout()
        Me.GroupBox_Mantenimiento.SuspendLayout()
        Me.GroupBox_Camion.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Busqueda.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_Camiones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_Accion
        '
        Me.Panel_Accion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Accion.Controls.Add(Me.Bot_Cancelar)
        Me.Panel_Accion.Controls.Add(Me.Bot_Guardar)
        Me.Panel_Accion.Controls.Add(Me.GroupBox_Mantenimiento)
        Me.Panel_Accion.Controls.Add(Me.GroupBox_Camion)
        Me.Panel_Accion.Controls.Add(Me.Label_Accion)
        Me.Panel_Accion.Controls.Add(Me.PictureBox2)
        Me.Panel_Accion.Controls.Add(Me.PictureBox1)
        Me.Panel_Accion.Location = New System.Drawing.Point(768, 92)
        Me.Panel_Accion.Name = "Panel_Accion"
        Me.Panel_Accion.Size = New System.Drawing.Size(291, 497)
        Me.Panel_Accion.TabIndex = 32
        Me.Panel_Accion.Visible = False
        '
        'Bot_Cancelar
        '
        Me.Bot_Cancelar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Cancelar.FlatAppearance.BorderSize = 0
        Me.Bot_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Cancelar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Cancelar.Location = New System.Drawing.Point(83, 455)
        Me.Bot_Cancelar.Name = "Bot_Cancelar"
        Me.Bot_Cancelar.Size = New System.Drawing.Size(97, 31)
        Me.Bot_Cancelar.TabIndex = 9
        Me.Bot_Cancelar.Text = "Cancelar"
        Me.Bot_Cancelar.UseVisualStyleBackColor = False
        '
        'Bot_Guardar
        '
        Me.Bot_Guardar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_Guardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Guardar.FlatAppearance.BorderSize = 0
        Me.Bot_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Guardar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Guardar.Location = New System.Drawing.Point(186, 455)
        Me.Bot_Guardar.Name = "Bot_Guardar"
        Me.Bot_Guardar.Size = New System.Drawing.Size(97, 31)
        Me.Bot_Guardar.TabIndex = 8
        Me.Bot_Guardar.Text = "Guardar"
        Me.Bot_Guardar.UseVisualStyleBackColor = False
        '
        'GroupBox_Mantenimiento
        '
        Me.GroupBox_Mantenimiento.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox_Mantenimiento.Controls.Add(Me.DatePicker_Proximo)
        Me.GroupBox_Mantenimiento.Controls.Add(Me.Label10)
        Me.GroupBox_Mantenimiento.Controls.Add(Me.DatePicker_Ultimo)
        Me.GroupBox_Mantenimiento.Controls.Add(Me.Label9)
        Me.GroupBox_Mantenimiento.Controls.Add(Me.Label8)
        Me.GroupBox_Mantenimiento.Controls.Add(Me.TextBox_KMCubierta)
        Me.GroupBox_Mantenimiento.Controls.Add(Me.Label7)
        Me.GroupBox_Mantenimiento.Controls.Add(Me.TextBox_KMAceite)
        Me.GroupBox_Mantenimiento.Controls.Add(Me.Label6)
        Me.GroupBox_Mantenimiento.Controls.Add(Me.TextBox_KMActuales)
        Me.GroupBox_Mantenimiento.Location = New System.Drawing.Point(9, 256)
        Me.GroupBox_Mantenimiento.Name = "GroupBox_Mantenimiento"
        Me.GroupBox_Mantenimiento.Size = New System.Drawing.Size(274, 193)
        Me.GroupBox_Mantenimiento.TabIndex = 36
        Me.GroupBox_Mantenimiento.TabStop = False
        Me.GroupBox_Mantenimiento.Text = "Mantenimiento"
        '
        'DatePicker_Proximo
        '
        Me.DatePicker_Proximo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DatePicker_Proximo.Location = New System.Drawing.Point(143, 155)
        Me.DatePicker_Proximo.Name = "DatePicker_Proximo"
        Me.DatePicker_Proximo.Size = New System.Drawing.Size(125, 27)
        Me.DatePicker_Proximo.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(139, 131)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(127, 21)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Próximo SUCTA"
        '
        'DatePicker_Ultimo
        '
        Me.DatePicker_Ultimo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DatePicker_Ultimo.Location = New System.Drawing.Point(10, 155)
        Me.DatePicker_Ultimo.Name = "DatePicker_Ultimo"
        Me.DatePicker_Ultimo.Size = New System.Drawing.Size(125, 27)
        Me.DatePicker_Ultimo.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 131)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 21)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Último SUCTA"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(139, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 21)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "KM Cubiertas"
        '
        'TextBox_KMCubierta
        '
        Me.TextBox_KMCubierta.Location = New System.Drawing.Point(143, 101)
        Me.TextBox_KMCubierta.MaxLength = 255
        Me.TextBox_KMCubierta.Name = "TextBox_KMCubierta"
        Me.TextBox_KMCubierta.Size = New System.Drawing.Size(125, 27)
        Me.TextBox_KMCubierta.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 21)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "KM Aceite"
        '
        'TextBox_KMAceite
        '
        Me.TextBox_KMAceite.Location = New System.Drawing.Point(10, 101)
        Me.TextBox_KMAceite.MaxLength = 255
        Me.TextBox_KMAceite.Name = "TextBox_KMAceite"
        Me.TextBox_KMAceite.Size = New System.Drawing.Size(125, 27)
        Me.TextBox_KMAceite.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 21)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "KM Actuales"
        '
        'TextBox_KMActuales
        '
        Me.TextBox_KMActuales.Location = New System.Drawing.Point(10, 47)
        Me.TextBox_KMActuales.MaxLength = 255
        Me.TextBox_KMActuales.Name = "TextBox_KMActuales"
        Me.TextBox_KMActuales.Size = New System.Drawing.Size(258, 27)
        Me.TextBox_KMActuales.TabIndex = 3
        '
        'GroupBox_Camion
        '
        Me.GroupBox_Camion.Controls.Add(Me.Label3)
        Me.GroupBox_Camion.Controls.Add(Me.Label5)
        Me.GroupBox_Camion.Controls.Add(Me.TextBox_Marca)
        Me.GroupBox_Camion.Controls.Add(Me.TextBox_Matrícula)
        Me.GroupBox_Camion.Controls.Add(Me.TextBox_Modelo)
        Me.GroupBox_Camion.Controls.Add(Me.Label4)
        Me.GroupBox_Camion.Location = New System.Drawing.Point(9, 57)
        Me.GroupBox_Camion.Name = "GroupBox_Camion"
        Me.GroupBox_Camion.Size = New System.Drawing.Size(274, 193)
        Me.GroupBox_Camion.TabIndex = 35
        Me.GroupBox_Camion.TabStop = False
        Me.GroupBox_Camion.Text = "Vehículo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 21)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Marca *"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 21)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Matrícula *"
        '
        'TextBox_Marca
        '
        Me.TextBox_Marca.Location = New System.Drawing.Point(10, 101)
        Me.TextBox_Marca.MaxLength = 255
        Me.TextBox_Marca.Name = "TextBox_Marca"
        Me.TextBox_Marca.Size = New System.Drawing.Size(258, 27)
        Me.TextBox_Marca.TabIndex = 1
        '
        'TextBox_Matrícula
        '
        Me.TextBox_Matrícula.Location = New System.Drawing.Point(10, 47)
        Me.TextBox_Matrícula.MaxLength = 255
        Me.TextBox_Matrícula.Name = "TextBox_Matrícula"
        Me.TextBox_Matrícula.Size = New System.Drawing.Size(258, 27)
        Me.TextBox_Matrícula.TabIndex = 0
        '
        'TextBox_Modelo
        '
        Me.TextBox_Modelo.Location = New System.Drawing.Point(10, 155)
        Me.TextBox_Modelo.MaxLength = 255
        Me.TextBox_Modelo.Name = "TextBox_Modelo"
        Me.TextBox_Modelo.Size = New System.Drawing.Size(258, 27)
        Me.TextBox_Modelo.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 21)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Modelo *"
        '
        'Label_Accion
        '
        Me.Label_Accion.AutoSize = True
        Me.Label_Accion.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Accion.Location = New System.Drawing.Point(6, 11)
        Me.Label_Accion.Name = "Label_Accion"
        Me.Label_Accion.Size = New System.Drawing.Size(263, 36)
        Me.Label_Accion.TabIndex = 29
        Me.Label_Accion.Text = "Agregar Vehículo"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox2.Location = New System.Drawing.Point(5, 10)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(282, 480)
        Me.PictureBox2.TabIndex = 30
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.PictureBox1.Location = New System.Drawing.Point(1, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(290, 488)
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(347, 36)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Búsqueda de Vehículos"
        '
        'Panel_Busqueda
        '
        Me.Panel_Busqueda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Busqueda.Controls.Add(Me.Label2)
        Me.Panel_Busqueda.Controls.Add(Me.PictureBox3)
        Me.Panel_Busqueda.Controls.Add(Me.Label11)
        Me.Panel_Busqueda.Controls.Add(Me.PictureBox4)
        Me.Panel_Busqueda.Controls.Add(Me.DataGridView_Camiones)
        Me.Panel_Busqueda.Controls.Add(Me.WMTextBox_Buscar)
        Me.Panel_Busqueda.Controls.Add(Me.Bot_VerDatos)
        Me.Panel_Busqueda.Controls.Add(Me.Bot_Historial)
        Me.Panel_Busqueda.Controls.Add(Me.Bot_Eliminar)
        Me.Panel_Busqueda.Controls.Add(Me.Bot_Borrar)
        Me.Panel_Busqueda.Controls.Add(Me.Bot_Modificar)
        Me.Panel_Busqueda.Controls.Add(Me.Bot_Agregar)
        Me.Panel_Busqueda.Location = New System.Drawing.Point(66, 64)
        Me.Panel_Busqueda.Name = "Panel_Busqueda"
        Me.Panel_Busqueda.Size = New System.Drawing.Size(696, 608)
        Me.Panel_Busqueda.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(331, 587)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 21)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "- Cambio necesario"
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.BackColor = System.Drawing.Color.Firebrick
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Location = New System.Drawing.Point(312, 589)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(19, 19)
        Me.PictureBox3.TabIndex = 80
        Me.PictureBox3.TabStop = False
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(22, 587)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(284, 21)
        Me.Label11.TabIndex = 79
        Me.Label11.Text = "- Menos de 1000km para el Cambio"
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox4.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox4.Location = New System.Drawing.Point(3, 589)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(19, 19)
        Me.PictureBox4.TabIndex = 78
        Me.PictureBox4.TabStop = False
        '
        'DataGridView_Camiones
        '
        Me.DataGridView_Camiones.AllowUserToAddRows = False
        Me.DataGridView_Camiones.AllowUserToDeleteRows = False
        Me.DataGridView_Camiones.AllowUserToResizeRows = False
        Me.DataGridView_Camiones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_Camiones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_Camiones.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DataGridView_Camiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Camiones.Location = New System.Drawing.Point(3, 36)
        Me.DataGridView_Camiones.MultiSelect = False
        Me.DataGridView_Camiones.Name = "DataGridView_Camiones"
        Me.DataGridView_Camiones.ReadOnly = True
        Me.DataGridView_Camiones.RowHeadersWidth = 30
        Me.DataGridView_Camiones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Camiones.Size = New System.Drawing.Size(587, 547)
        Me.DataGridView_Camiones.TabIndex = 2
        '
        'WMTextBox_Buscar
        '
        Me.WMTextBox_Buscar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WMTextBox_Buscar.Location = New System.Drawing.Point(3, 3)
        Me.WMTextBox_Buscar.Name = "WMTextBox_Buscar"
        Me.WMTextBox_Buscar.Size = New System.Drawing.Size(482, 27)
        Me.WMTextBox_Buscar.TabIndex = 0
        Me.WMTextBox_Buscar.WaterMarkColor = System.Drawing.Color.Gray
        Me.WMTextBox_Buscar.WaterMarkText = "Buscar Vehículos por Matrícula, Marca o Modelo"
        '
        'Bot_VerDatos
        '
        Me.Bot_VerDatos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bot_VerDatos.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_VerDatos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_VerDatos.FlatAppearance.BorderSize = 0
        Me.Bot_VerDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_VerDatos.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_VerDatos.Location = New System.Drawing.Point(596, 111)
        Me.Bot_VerDatos.Name = "Bot_VerDatos"
        Me.Bot_VerDatos.Size = New System.Drawing.Size(97, 31)
        Me.Bot_VerDatos.TabIndex = 5
        Me.Bot_VerDatos.Tag = "Datos Vehículo"
        Me.Bot_VerDatos.Text = "Ver Datos"
        Me.Bot_VerDatos.UseVisualStyleBackColor = False
        '
        'Bot_Historial
        '
        Me.Bot_Historial.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bot_Historial.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_Historial.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Historial.FlatAppearance.BorderSize = 0
        Me.Bot_Historial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Historial.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Historial.Location = New System.Drawing.Point(596, 148)
        Me.Bot_Historial.Name = "Bot_Historial"
        Me.Bot_Historial.Size = New System.Drawing.Size(97, 31)
        Me.Bot_Historial.TabIndex = 6
        Me.Bot_Historial.Text = "Historial"
        Me.Bot_Historial.UseVisualStyleBackColor = False
        '
        'Bot_Eliminar
        '
        Me.Bot_Eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bot_Eliminar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Eliminar.FlatAppearance.BorderSize = 0
        Me.Bot_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Eliminar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Eliminar.Location = New System.Drawing.Point(596, 185)
        Me.Bot_Eliminar.Name = "Bot_Eliminar"
        Me.Bot_Eliminar.Size = New System.Drawing.Size(97, 31)
        Me.Bot_Eliminar.TabIndex = 7
        Me.Bot_Eliminar.Text = "Eliminar"
        Me.Bot_Eliminar.UseVisualStyleBackColor = False
        '
        'Bot_Borrar
        '
        Me.Bot_Borrar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_Borrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Borrar.FlatAppearance.BorderSize = 0
        Me.Bot_Borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Borrar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Borrar.Location = New System.Drawing.Point(491, 1)
        Me.Bot_Borrar.Name = "Bot_Borrar"
        Me.Bot_Borrar.Size = New System.Drawing.Size(94, 31)
        Me.Bot_Borrar.TabIndex = 1
        Me.Bot_Borrar.Text = "Borrar"
        Me.Bot_Borrar.UseVisualStyleBackColor = False
        '
        'Bot_Modificar
        '
        Me.Bot_Modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bot_Modificar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_Modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Modificar.FlatAppearance.BorderSize = 0
        Me.Bot_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Modificar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Modificar.Location = New System.Drawing.Point(596, 74)
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
        Me.Bot_Agregar.Location = New System.Drawing.Point(596, 37)
        Me.Bot_Agregar.Name = "Bot_Agregar"
        Me.Bot_Agregar.Size = New System.Drawing.Size(97, 31)
        Me.Bot_Agregar.TabIndex = 3
        Me.Bot_Agregar.Tag = "Agregar Vehículo"
        Me.Bot_Agregar.Text = "Agregar"
        Me.Bot_Agregar.UseVisualStyleBackColor = False
        '
        'Form_BuscarVehiculos
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1004, 690)
        Me.Controls.Add(Me.Panel_Accion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel_Busqueda)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_BuscarVehiculos"
        Me.Text = "Form_BuscarVehiculos"
        Me.Panel_Accion.ResumeLayout(False)
        Me.Panel_Accion.PerformLayout()
        Me.GroupBox_Mantenimiento.ResumeLayout(False)
        Me.GroupBox_Mantenimiento.PerformLayout()
        Me.GroupBox_Camion.ResumeLayout(False)
        Me.GroupBox_Camion.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Busqueda.ResumeLayout(False)
        Me.Panel_Busqueda.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_Camiones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel_Accion As System.Windows.Forms.Panel
    Friend WithEvents Bot_Cancelar As System.Windows.Forms.Button
    Friend WithEvents Bot_Guardar As System.Windows.Forms.Button
    Friend WithEvents GroupBox_Mantenimiento As System.Windows.Forms.GroupBox
    Friend WithEvents DatePicker_Proximo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DatePicker_Ultimo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox_KMCubierta As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox_KMAceite As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox_KMActuales As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox_Camion As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Marca As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Matrícula As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Modelo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label_Accion As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel_Busqueda As System.Windows.Forms.Panel
    Friend WithEvents Bot_VerDatos As System.Windows.Forms.Button
    Friend WithEvents Bot_Historial As System.Windows.Forms.Button
    Friend WithEvents Bot_Eliminar As System.Windows.Forms.Button
    Friend WithEvents Bot_Borrar As System.Windows.Forms.Button
    Friend WithEvents Bot_Modificar As System.Windows.Forms.Button
    Friend WithEvents Bot_Agregar As System.Windows.Forms.Button
    Friend WithEvents WMTextBox_Buscar As Transportes.WatermarkTextBox
    Friend WithEvents DataGridView_Camiones As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox4 As PictureBox
End Class
