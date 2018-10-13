<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_HistorialVehiculos
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
        Me.Label_Vehiculo = New System.Windows.Forms.Label()
        Me.Panel_Accion = New System.Windows.Forms.Panel()
        Me.Bot_Cancelar = New System.Windows.Forms.Button()
        Me.Bot_Guardar = New System.Windows.Forms.Button()
        Me.GroupBox_Mantenimiento = New System.Windows.Forms.GroupBox()
        Me.DatePicker_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RichTextBox_Detalles = New System.Windows.Forms.RichTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox_Gastos = New System.Windows.Forms.TextBox()
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
        Me.DataGridView_Historial = New System.Windows.Forms.DataGridView()
        Me.WMTextBox_Buscar = New Transportes.WatermarkTextBox()
        Me.Bot_Volver = New System.Windows.Forms.Button()
        Me.Bot_Eliminar = New System.Windows.Forms.Button()
        Me.Bot_Borrar = New System.Windows.Forms.Button()
        Me.Bot_VerDatos = New System.Windows.Forms.Button()
        Me.Bot_Agregar = New System.Windows.Forms.Button()
        Me.Bot_Modificar = New System.Windows.Forms.Button()
        Me.Panel_Accion.SuspendLayout()
        Me.GroupBox_Mantenimiento.SuspendLayout()
        Me.GroupBox_Camion.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Busqueda.SuspendLayout()
        CType(Me.DataGridView_Historial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label_Vehiculo
        '
        Me.Label_Vehiculo.AutoSize = True
        Me.Label_Vehiculo.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Vehiculo.Location = New System.Drawing.Point(325, 19)
        Me.Label_Vehiculo.Name = "Label_Vehiculo"
        Me.Label_Vehiculo.Size = New System.Drawing.Size(276, 24)
        Me.Label_Vehiculo.TabIndex = 37
        Me.Label_Vehiculo.Text = "Marca, Modelo, Matrícula"
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
        Me.Panel_Accion.Location = New System.Drawing.Point(701, 93)
        Me.Panel_Accion.Name = "Panel_Accion"
        Me.Panel_Accion.Size = New System.Drawing.Size(291, 497)
        Me.Panel_Accion.TabIndex = 36
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
        Me.Bot_Cancelar.TabIndex = 7
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
        Me.Bot_Guardar.TabIndex = 6
        Me.Bot_Guardar.Text = "Guardar"
        Me.Bot_Guardar.UseVisualStyleBackColor = False
        '
        'GroupBox_Mantenimiento
        '
        Me.GroupBox_Mantenimiento.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox_Mantenimiento.Controls.Add(Me.DatePicker_Fecha)
        Me.GroupBox_Mantenimiento.Controls.Add(Me.Label2)
        Me.GroupBox_Mantenimiento.Controls.Add(Me.RichTextBox_Detalles)
        Me.GroupBox_Mantenimiento.Controls.Add(Me.Label7)
        Me.GroupBox_Mantenimiento.Controls.Add(Me.Label6)
        Me.GroupBox_Mantenimiento.Controls.Add(Me.TextBox_Gastos)
        Me.GroupBox_Mantenimiento.Location = New System.Drawing.Point(9, 199)
        Me.GroupBox_Mantenimiento.Name = "GroupBox_Mantenimiento"
        Me.GroupBox_Mantenimiento.Size = New System.Drawing.Size(274, 250)
        Me.GroupBox_Mantenimiento.TabIndex = 36
        Me.GroupBox_Mantenimiento.TabStop = False
        Me.GroupBox_Mantenimiento.Text = "Datos del Mantenimiento"
        '
        'DatePicker_Fecha
        '
        Me.DatePicker_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DatePicker_Fecha.Location = New System.Drawing.Point(10, 217)
        Me.DatePicker_Fecha.Name = "DatePicker_Fecha"
        Me.DatePicker_Fecha.Size = New System.Drawing.Size(125, 27)
        Me.DatePicker_Fecha.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 21)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Fecha"
        '
        'RichTextBox_Detalles
        '
        Me.RichTextBox_Detalles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RichTextBox_Detalles.Location = New System.Drawing.Point(10, 101)
        Me.RichTextBox_Detalles.MaxLength = 500
        Me.RichTextBox_Detalles.Name = "RichTextBox_Detalles"
        Me.RichTextBox_Detalles.Size = New System.Drawing.Size(258, 89)
        Me.RichTextBox_Detalles.TabIndex = 4
        Me.RichTextBox_Detalles.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 21)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Detalles"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 21)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Gastos Totales"
        '
        'TextBox_Gastos
        '
        Me.TextBox_Gastos.Location = New System.Drawing.Point(10, 47)
        Me.TextBox_Gastos.MaxLength = 255
        Me.TextBox_Gastos.Name = "TextBox_Gastos"
        Me.TextBox_Gastos.Size = New System.Drawing.Size(258, 27)
        Me.TextBox_Gastos.TabIndex = 3
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
        Me.GroupBox_Camion.Size = New System.Drawing.Size(274, 136)
        Me.GroupBox_Camion.TabIndex = 35
        Me.GroupBox_Camion.TabStop = False
        Me.GroupBox_Camion.Text = "Vehículo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 21)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Marca"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 21)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Matrícula"
        '
        'TextBox_Marca
        '
        Me.TextBox_Marca.BackColor = System.Drawing.Color.White
        Me.TextBox_Marca.Location = New System.Drawing.Point(10, 101)
        Me.TextBox_Marca.MaxLength = 255
        Me.TextBox_Marca.Name = "TextBox_Marca"
        Me.TextBox_Marca.ReadOnly = True
        Me.TextBox_Marca.Size = New System.Drawing.Size(100, 27)
        Me.TextBox_Marca.TabIndex = 1
        '
        'TextBox_Matrícula
        '
        Me.TextBox_Matrícula.BackColor = System.Drawing.Color.White
        Me.TextBox_Matrícula.Location = New System.Drawing.Point(10, 47)
        Me.TextBox_Matrícula.MaxLength = 255
        Me.TextBox_Matrícula.Name = "TextBox_Matrícula"
        Me.TextBox_Matrícula.ReadOnly = True
        Me.TextBox_Matrícula.Size = New System.Drawing.Size(258, 27)
        Me.TextBox_Matrícula.TabIndex = 0
        '
        'TextBox_Modelo
        '
        Me.TextBox_Modelo.BackColor = System.Drawing.Color.White
        Me.TextBox_Modelo.Location = New System.Drawing.Point(116, 101)
        Me.TextBox_Modelo.MaxLength = 255
        Me.TextBox_Modelo.Name = "TextBox_Modelo"
        Me.TextBox_Modelo.ReadOnly = True
        Me.TextBox_Modelo.Size = New System.Drawing.Size(152, 27)
        Me.TextBox_Modelo.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(112, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 21)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Modelo"
        '
        'Label_Accion
        '
        Me.Label_Accion.AutoSize = True
        Me.Label_Accion.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Accion.Location = New System.Drawing.Point(6, 11)
        Me.Label_Accion.Name = "Label_Accion"
        Me.Label_Accion.Size = New System.Drawing.Size(130, 36)
        Me.Label_Accion.TabIndex = 29
        Me.Label_Accion.Text = "Agregar"
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
        Me.Label1.Size = New System.Drawing.Size(319, 36)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Historial del Vehículo:"
        '
        'Panel_Busqueda
        '
        Me.Panel_Busqueda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Busqueda.Controls.Add(Me.DataGridView_Historial)
        Me.Panel_Busqueda.Controls.Add(Me.WMTextBox_Buscar)
        Me.Panel_Busqueda.Controls.Add(Me.Bot_Volver)
        Me.Panel_Busqueda.Controls.Add(Me.Bot_Eliminar)
        Me.Panel_Busqueda.Controls.Add(Me.Bot_Borrar)
        Me.Panel_Busqueda.Controls.Add(Me.Bot_VerDatos)
        Me.Panel_Busqueda.Controls.Add(Me.Bot_Agregar)
        Me.Panel_Busqueda.Controls.Add(Me.Bot_Modificar)
        Me.Panel_Busqueda.Location = New System.Drawing.Point(66, 64)
        Me.Panel_Busqueda.Name = "Panel_Busqueda"
        Me.Panel_Busqueda.Size = New System.Drawing.Size(629, 614)
        Me.Panel_Busqueda.TabIndex = 38
        '
        'DataGridView_Historial
        '
        Me.DataGridView_Historial.AllowUserToAddRows = False
        Me.DataGridView_Historial.AllowUserToDeleteRows = False
        Me.DataGridView_Historial.AllowUserToResizeRows = False
        Me.DataGridView_Historial.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_Historial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_Historial.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DataGridView_Historial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Historial.Location = New System.Drawing.Point(3, 36)
        Me.DataGridView_Historial.MultiSelect = False
        Me.DataGridView_Historial.Name = "DataGridView_Historial"
        Me.DataGridView_Historial.ReadOnly = True
        Me.DataGridView_Historial.RowHeadersWidth = 30
        Me.DataGridView_Historial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Historial.Size = New System.Drawing.Size(520, 574)
        Me.DataGridView_Historial.TabIndex = 2
        '
        'WMTextBox_Buscar
        '
        Me.WMTextBox_Buscar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WMTextBox_Buscar.Location = New System.Drawing.Point(3, 3)
        Me.WMTextBox_Buscar.Name = "WMTextBox_Buscar"
        Me.WMTextBox_Buscar.Size = New System.Drawing.Size(274, 27)
        Me.WMTextBox_Buscar.TabIndex = 0
        Me.WMTextBox_Buscar.WaterMarkColor = System.Drawing.Color.Gray
        Me.WMTextBox_Buscar.WaterMarkText = "Buscar Control por Detalles"
        '
        'Bot_Volver
        '
        Me.Bot_Volver.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bot_Volver.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_Volver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Volver.FlatAppearance.BorderSize = 0
        Me.Bot_Volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Volver.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Volver.Location = New System.Drawing.Point(529, 184)
        Me.Bot_Volver.Name = "Bot_Volver"
        Me.Bot_Volver.Size = New System.Drawing.Size(97, 31)
        Me.Bot_Volver.TabIndex = 7
        Me.Bot_Volver.Tag = "Eliminar"
        Me.Bot_Volver.Text = "Volver"
        Me.Bot_Volver.UseVisualStyleBackColor = False
        '
        'Bot_Eliminar
        '
        Me.Bot_Eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bot_Eliminar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Eliminar.FlatAppearance.BorderSize = 0
        Me.Bot_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Eliminar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Eliminar.Location = New System.Drawing.Point(529, 147)
        Me.Bot_Eliminar.Name = "Bot_Eliminar"
        Me.Bot_Eliminar.Size = New System.Drawing.Size(97, 31)
        Me.Bot_Eliminar.TabIndex = 6
        Me.Bot_Eliminar.Tag = "Eliminar"
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
        Me.Bot_Borrar.Location = New System.Drawing.Point(283, 1)
        Me.Bot_Borrar.Name = "Bot_Borrar"
        Me.Bot_Borrar.Size = New System.Drawing.Size(97, 31)
        Me.Bot_Borrar.TabIndex = 1
        Me.Bot_Borrar.Text = "Borrar"
        Me.Bot_Borrar.UseVisualStyleBackColor = False
        '
        'Bot_VerDatos
        '
        Me.Bot_VerDatos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bot_VerDatos.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_VerDatos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_VerDatos.FlatAppearance.BorderSize = 0
        Me.Bot_VerDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_VerDatos.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_VerDatos.Location = New System.Drawing.Point(529, 110)
        Me.Bot_VerDatos.Name = "Bot_VerDatos"
        Me.Bot_VerDatos.Size = New System.Drawing.Size(97, 31)
        Me.Bot_VerDatos.TabIndex = 5
        Me.Bot_VerDatos.Tag = "Datos"
        Me.Bot_VerDatos.Text = "Ver Datos"
        Me.Bot_VerDatos.UseVisualStyleBackColor = False
        '
        'Bot_Agregar
        '
        Me.Bot_Agregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bot_Agregar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_Agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Agregar.FlatAppearance.BorderSize = 0
        Me.Bot_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Agregar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Agregar.Location = New System.Drawing.Point(529, 36)
        Me.Bot_Agregar.Name = "Bot_Agregar"
        Me.Bot_Agregar.Size = New System.Drawing.Size(97, 31)
        Me.Bot_Agregar.TabIndex = 3
        Me.Bot_Agregar.Tag = "Agregar"
        Me.Bot_Agregar.Text = "Agregar"
        Me.Bot_Agregar.UseVisualStyleBackColor = False
        '
        'Bot_Modificar
        '
        Me.Bot_Modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bot_Modificar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_Modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Modificar.FlatAppearance.BorderSize = 0
        Me.Bot_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Modificar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Modificar.Location = New System.Drawing.Point(529, 73)
        Me.Bot_Modificar.Name = "Bot_Modificar"
        Me.Bot_Modificar.Size = New System.Drawing.Size(97, 31)
        Me.Bot_Modificar.TabIndex = 4
        Me.Bot_Modificar.Tag = "Modificar"
        Me.Bot_Modificar.Text = "Modificar"
        Me.Bot_Modificar.UseVisualStyleBackColor = False
        '
        'Form_HistorialVehiculos
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1004, 690)
        Me.Controls.Add(Me.Label_Vehiculo)
        Me.Controls.Add(Me.Panel_Accion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel_Busqueda)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_HistorialVehiculos"
        Me.Text = "Form_HistorialVehiculos"
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
        CType(Me.DataGridView_Historial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label_Vehiculo As System.Windows.Forms.Label
    Friend WithEvents Panel_Accion As System.Windows.Forms.Panel
    Friend WithEvents Bot_Cancelar As System.Windows.Forms.Button
    Friend WithEvents Bot_Guardar As System.Windows.Forms.Button
    Friend WithEvents GroupBox_Mantenimiento As System.Windows.Forms.GroupBox
    Friend WithEvents RichTextBox_Detalles As System.Windows.Forms.RichTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Gastos As System.Windows.Forms.TextBox
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
    Friend WithEvents Bot_Eliminar As System.Windows.Forms.Button
    Friend WithEvents Bot_Borrar As System.Windows.Forms.Button
    Friend WithEvents Bot_VerDatos As System.Windows.Forms.Button
    Friend WithEvents Bot_Agregar As System.Windows.Forms.Button
    Friend WithEvents Bot_Modificar As System.Windows.Forms.Button
    Friend WithEvents Bot_Volver As System.Windows.Forms.Button
    Friend WithEvents WMTextBox_Buscar As Transportes.WatermarkTextBox
    Friend WithEvents DataGridView_Historial As System.Windows.Forms.DataGridView
    Friend WithEvents DatePicker_Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
