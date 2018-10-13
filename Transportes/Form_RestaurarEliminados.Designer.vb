<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_RestaurarEliminados
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
        Me.Label_Titulo = New System.Windows.Forms.Label()
        Me.Panel_Vehiculo = New System.Windows.Forms.Panel()
        Me.Bot_VolverV = New System.Windows.Forms.Button()
        Me.Bot_RestaurarV = New System.Windows.Forms.Button()
        Me.GroupBox_MantenimientoV = New System.Windows.Forms.GroupBox()
        Me.TextBox_Proximo = New System.Windows.Forms.TextBox()
        Me.TextBox_Ultimo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox_KMCubierta = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox_KMAceite = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox_KMActuales = New System.Windows.Forms.TextBox()
        Me.GroupBox_CamionV = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox_MarcaV = New System.Windows.Forms.TextBox()
        Me.TextBox_MatrículaV = New System.Windows.Forms.TextBox()
        Me.TextBox_ModeloV = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label_Accion = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel_Historial = New System.Windows.Forms.Panel()
        Me.Bot_VolverH = New System.Windows.Forms.Button()
        Me.Bot_RestaurarH = New System.Windows.Forms.Button()
        Me.GroupBox_MantenimientoH = New System.Windows.Forms.GroupBox()
        Me.TextBox_Fecha = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RichTextBox_Detalles = New System.Windows.Forms.RichTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox_Gastos = New System.Windows.Forms.TextBox()
        Me.GroupBox_CamionH = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox_MarcaH = New System.Windows.Forms.TextBox()
        Me.TextBox_MatriculaH = New System.Windows.Forms.TextBox()
        Me.TextBox_ModeloH = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.DataGridView_Eliminados = New System.Windows.Forms.DataGridView()
        Me.Bot_Borrar = New System.Windows.Forms.Button()
        Me.Bot_Restaurar = New System.Windows.Forms.Button()
        Me.Bot_Ver = New System.Windows.Forms.Button()
        Me.ComboBox_Categoria = New System.Windows.Forms.ComboBox()
        Me.WMTextBox_Buscar = New Transportes.WatermarkTextBox()
        Me.Panel_Vehiculo.SuspendLayout()
        Me.GroupBox_MantenimientoV.SuspendLayout()
        Me.GroupBox_CamionV.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Historial.SuspendLayout()
        Me.GroupBox_MantenimientoH.SuspendLayout()
        Me.GroupBox_CamionH.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_Eliminados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label_Titulo
        '
        Me.Label_Titulo.AutoSize = True
        Me.Label_Titulo.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Titulo.Location = New System.Drawing.Point(12, 9)
        Me.Label_Titulo.Name = "Label_Titulo"
        Me.Label_Titulo.Size = New System.Drawing.Size(267, 36)
        Me.Label_Titulo.TabIndex = 24
        Me.Label_Titulo.Text = "Buscar Eliminados"
        '
        'Panel_Vehiculo
        '
        Me.Panel_Vehiculo.Controls.Add(Me.Bot_VolverV)
        Me.Panel_Vehiculo.Controls.Add(Me.Bot_RestaurarV)
        Me.Panel_Vehiculo.Controls.Add(Me.GroupBox_MantenimientoV)
        Me.Panel_Vehiculo.Controls.Add(Me.GroupBox_CamionV)
        Me.Panel_Vehiculo.Controls.Add(Me.Label_Accion)
        Me.Panel_Vehiculo.Controls.Add(Me.PictureBox2)
        Me.Panel_Vehiculo.Controls.Add(Me.PictureBox1)
        Me.Panel_Vehiculo.Location = New System.Drawing.Point(18, 635)
        Me.Panel_Vehiculo.Name = "Panel_Vehiculo"
        Me.Panel_Vehiculo.Size = New System.Drawing.Size(291, 497)
        Me.Panel_Vehiculo.TabIndex = 33
        Me.Panel_Vehiculo.Visible = False
        '
        'Bot_VolverV
        '
        Me.Bot_VolverV.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_VolverV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_VolverV.FlatAppearance.BorderSize = 0
        Me.Bot_VolverV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_VolverV.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_VolverV.Location = New System.Drawing.Point(83, 455)
        Me.Bot_VolverV.Name = "Bot_VolverV"
        Me.Bot_VolverV.Size = New System.Drawing.Size(97, 31)
        Me.Bot_VolverV.TabIndex = 9
        Me.Bot_VolverV.Text = "Volver"
        Me.Bot_VolverV.UseVisualStyleBackColor = False
        '
        'Bot_RestaurarV
        '
        Me.Bot_RestaurarV.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_RestaurarV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_RestaurarV.FlatAppearance.BorderSize = 0
        Me.Bot_RestaurarV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_RestaurarV.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_RestaurarV.Location = New System.Drawing.Point(186, 455)
        Me.Bot_RestaurarV.Name = "Bot_RestaurarV"
        Me.Bot_RestaurarV.Size = New System.Drawing.Size(97, 31)
        Me.Bot_RestaurarV.TabIndex = 8
        Me.Bot_RestaurarV.Tag = "Camiones"
        Me.Bot_RestaurarV.Text = "Restaurar"
        Me.Bot_RestaurarV.UseVisualStyleBackColor = False
        '
        'GroupBox_MantenimientoV
        '
        Me.GroupBox_MantenimientoV.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox_MantenimientoV.Controls.Add(Me.TextBox_Proximo)
        Me.GroupBox_MantenimientoV.Controls.Add(Me.TextBox_Ultimo)
        Me.GroupBox_MantenimientoV.Controls.Add(Me.Label10)
        Me.GroupBox_MantenimientoV.Controls.Add(Me.Label9)
        Me.GroupBox_MantenimientoV.Controls.Add(Me.Label8)
        Me.GroupBox_MantenimientoV.Controls.Add(Me.TextBox_KMCubierta)
        Me.GroupBox_MantenimientoV.Controls.Add(Me.Label7)
        Me.GroupBox_MantenimientoV.Controls.Add(Me.TextBox_KMAceite)
        Me.GroupBox_MantenimientoV.Controls.Add(Me.Label6)
        Me.GroupBox_MantenimientoV.Controls.Add(Me.TextBox_KMActuales)
        Me.GroupBox_MantenimientoV.Location = New System.Drawing.Point(9, 256)
        Me.GroupBox_MantenimientoV.Name = "GroupBox_MantenimientoV"
        Me.GroupBox_MantenimientoV.Size = New System.Drawing.Size(274, 193)
        Me.GroupBox_MantenimientoV.TabIndex = 36
        Me.GroupBox_MantenimientoV.TabStop = False
        Me.GroupBox_MantenimientoV.Text = "Mantenimiento"
        '
        'TextBox_Proximo
        '
        Me.TextBox_Proximo.BackColor = System.Drawing.Color.White
        Me.TextBox_Proximo.Location = New System.Drawing.Point(143, 155)
        Me.TextBox_Proximo.MaxLength = 255
        Me.TextBox_Proximo.Name = "TextBox_Proximo"
        Me.TextBox_Proximo.ReadOnly = True
        Me.TextBox_Proximo.Size = New System.Drawing.Size(125, 27)
        Me.TextBox_Proximo.TabIndex = 7
        '
        'TextBox_Ultimo
        '
        Me.TextBox_Ultimo.BackColor = System.Drawing.Color.White
        Me.TextBox_Ultimo.Location = New System.Drawing.Point(10, 155)
        Me.TextBox_Ultimo.MaxLength = 255
        Me.TextBox_Ultimo.Name = "TextBox_Ultimo"
        Me.TextBox_Ultimo.ReadOnly = True
        Me.TextBox_Ultimo.Size = New System.Drawing.Size(125, 27)
        Me.TextBox_Ultimo.TabIndex = 6
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
        Me.TextBox_KMCubierta.BackColor = System.Drawing.Color.White
        Me.TextBox_KMCubierta.Location = New System.Drawing.Point(143, 101)
        Me.TextBox_KMCubierta.MaxLength = 255
        Me.TextBox_KMCubierta.Name = "TextBox_KMCubierta"
        Me.TextBox_KMCubierta.ReadOnly = True
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
        Me.TextBox_KMAceite.BackColor = System.Drawing.Color.White
        Me.TextBox_KMAceite.Location = New System.Drawing.Point(10, 101)
        Me.TextBox_KMAceite.MaxLength = 255
        Me.TextBox_KMAceite.Name = "TextBox_KMAceite"
        Me.TextBox_KMAceite.ReadOnly = True
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
        Me.TextBox_KMActuales.BackColor = System.Drawing.Color.White
        Me.TextBox_KMActuales.Location = New System.Drawing.Point(10, 47)
        Me.TextBox_KMActuales.MaxLength = 255
        Me.TextBox_KMActuales.Name = "TextBox_KMActuales"
        Me.TextBox_KMActuales.ReadOnly = True
        Me.TextBox_KMActuales.Size = New System.Drawing.Size(258, 27)
        Me.TextBox_KMActuales.TabIndex = 3
        '
        'GroupBox_CamionV
        '
        Me.GroupBox_CamionV.Controls.Add(Me.Label3)
        Me.GroupBox_CamionV.Controls.Add(Me.Label5)
        Me.GroupBox_CamionV.Controls.Add(Me.TextBox_MarcaV)
        Me.GroupBox_CamionV.Controls.Add(Me.TextBox_MatrículaV)
        Me.GroupBox_CamionV.Controls.Add(Me.TextBox_ModeloV)
        Me.GroupBox_CamionV.Controls.Add(Me.Label4)
        Me.GroupBox_CamionV.Location = New System.Drawing.Point(9, 57)
        Me.GroupBox_CamionV.Name = "GroupBox_CamionV"
        Me.GroupBox_CamionV.Size = New System.Drawing.Size(274, 193)
        Me.GroupBox_CamionV.TabIndex = 35
        Me.GroupBox_CamionV.TabStop = False
        Me.GroupBox_CamionV.Text = "Vehículo"
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
        'TextBox_MarcaV
        '
        Me.TextBox_MarcaV.BackColor = System.Drawing.Color.White
        Me.TextBox_MarcaV.Location = New System.Drawing.Point(10, 101)
        Me.TextBox_MarcaV.MaxLength = 255
        Me.TextBox_MarcaV.Name = "TextBox_MarcaV"
        Me.TextBox_MarcaV.ReadOnly = True
        Me.TextBox_MarcaV.Size = New System.Drawing.Size(258, 27)
        Me.TextBox_MarcaV.TabIndex = 1
        '
        'TextBox_MatrículaV
        '
        Me.TextBox_MatrículaV.BackColor = System.Drawing.Color.White
        Me.TextBox_MatrículaV.Location = New System.Drawing.Point(10, 47)
        Me.TextBox_MatrículaV.MaxLength = 255
        Me.TextBox_MatrículaV.Name = "TextBox_MatrículaV"
        Me.TextBox_MatrículaV.ReadOnly = True
        Me.TextBox_MatrículaV.Size = New System.Drawing.Size(258, 27)
        Me.TextBox_MatrículaV.TabIndex = 0
        '
        'TextBox_ModeloV
        '
        Me.TextBox_ModeloV.BackColor = System.Drawing.Color.White
        Me.TextBox_ModeloV.Location = New System.Drawing.Point(10, 155)
        Me.TextBox_ModeloV.MaxLength = 255
        Me.TextBox_ModeloV.Name = "TextBox_ModeloV"
        Me.TextBox_ModeloV.ReadOnly = True
        Me.TextBox_ModeloV.Size = New System.Drawing.Size(258, 27)
        Me.TextBox_ModeloV.TabIndex = 2
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
        Me.Label_Accion.Font = New System.Drawing.Font("Century Gothic", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Accion.Location = New System.Drawing.Point(6, 11)
        Me.Label_Accion.Name = "Label_Accion"
        Me.Label_Accion.Size = New System.Drawing.Size(278, 34)
        Me.Label_Accion.TabIndex = 29
        Me.Label_Accion.Text = "Vehículo Eliminado"
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
        'Panel_Historial
        '
        Me.Panel_Historial.Controls.Add(Me.Bot_VolverH)
        Me.Panel_Historial.Controls.Add(Me.Bot_RestaurarH)
        Me.Panel_Historial.Controls.Add(Me.GroupBox_MantenimientoH)
        Me.Panel_Historial.Controls.Add(Me.GroupBox_CamionH)
        Me.Panel_Historial.Controls.Add(Me.Label16)
        Me.Panel_Historial.Controls.Add(Me.PictureBox3)
        Me.Panel_Historial.Controls.Add(Me.PictureBox4)
        Me.Panel_Historial.Location = New System.Drawing.Point(328, 635)
        Me.Panel_Historial.Name = "Panel_Historial"
        Me.Panel_Historial.Size = New System.Drawing.Size(291, 497)
        Me.Panel_Historial.TabIndex = 37
        Me.Panel_Historial.Visible = False
        '
        'Bot_VolverH
        '
        Me.Bot_VolverH.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_VolverH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_VolverH.FlatAppearance.BorderSize = 0
        Me.Bot_VolverH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_VolverH.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_VolverH.Location = New System.Drawing.Point(83, 455)
        Me.Bot_VolverH.Name = "Bot_VolverH"
        Me.Bot_VolverH.Size = New System.Drawing.Size(97, 31)
        Me.Bot_VolverH.TabIndex = 7
        Me.Bot_VolverH.Text = "Volver"
        Me.Bot_VolverH.UseVisualStyleBackColor = False
        '
        'Bot_RestaurarH
        '
        Me.Bot_RestaurarH.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_RestaurarH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_RestaurarH.FlatAppearance.BorderSize = 0
        Me.Bot_RestaurarH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_RestaurarH.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_RestaurarH.Location = New System.Drawing.Point(186, 455)
        Me.Bot_RestaurarH.Name = "Bot_RestaurarH"
        Me.Bot_RestaurarH.Size = New System.Drawing.Size(97, 31)
        Me.Bot_RestaurarH.TabIndex = 6
        Me.Bot_RestaurarH.Tag = "ControlesCamiones"
        Me.Bot_RestaurarH.Text = "Restaurar"
        Me.Bot_RestaurarH.UseVisualStyleBackColor = False
        '
        'GroupBox_MantenimientoH
        '
        Me.GroupBox_MantenimientoH.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox_MantenimientoH.Controls.Add(Me.TextBox_Fecha)
        Me.GroupBox_MantenimientoH.Controls.Add(Me.Label2)
        Me.GroupBox_MantenimientoH.Controls.Add(Me.RichTextBox_Detalles)
        Me.GroupBox_MantenimientoH.Controls.Add(Me.Label11)
        Me.GroupBox_MantenimientoH.Controls.Add(Me.Label12)
        Me.GroupBox_MantenimientoH.Controls.Add(Me.TextBox_Gastos)
        Me.GroupBox_MantenimientoH.Location = New System.Drawing.Point(9, 199)
        Me.GroupBox_MantenimientoH.Name = "GroupBox_MantenimientoH"
        Me.GroupBox_MantenimientoH.Size = New System.Drawing.Size(274, 250)
        Me.GroupBox_MantenimientoH.TabIndex = 36
        Me.GroupBox_MantenimientoH.TabStop = False
        Me.GroupBox_MantenimientoH.Text = "Datos del Mantenimiento"
        '
        'TextBox_Fecha
        '
        Me.TextBox_Fecha.BackColor = System.Drawing.Color.White
        Me.TextBox_Fecha.Location = New System.Drawing.Point(10, 217)
        Me.TextBox_Fecha.MaxLength = 255
        Me.TextBox_Fecha.Name = "TextBox_Fecha"
        Me.TextBox_Fecha.ReadOnly = True
        Me.TextBox_Fecha.Size = New System.Drawing.Size(125, 27)
        Me.TextBox_Fecha.TabIndex = 5
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
        Me.RichTextBox_Detalles.BackColor = System.Drawing.Color.White
        Me.RichTextBox_Detalles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RichTextBox_Detalles.Location = New System.Drawing.Point(10, 101)
        Me.RichTextBox_Detalles.MaxLength = 500
        Me.RichTextBox_Detalles.Name = "RichTextBox_Detalles"
        Me.RichTextBox_Detalles.ReadOnly = True
        Me.RichTextBox_Detalles.Size = New System.Drawing.Size(258, 89)
        Me.RichTextBox_Detalles.TabIndex = 4
        Me.RichTextBox_Detalles.Text = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 77)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 21)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Detalles"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 23)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(123, 21)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Gastos Totales"
        '
        'TextBox_Gastos
        '
        Me.TextBox_Gastos.BackColor = System.Drawing.Color.White
        Me.TextBox_Gastos.Location = New System.Drawing.Point(10, 47)
        Me.TextBox_Gastos.MaxLength = 255
        Me.TextBox_Gastos.Name = "TextBox_Gastos"
        Me.TextBox_Gastos.ReadOnly = True
        Me.TextBox_Gastos.Size = New System.Drawing.Size(258, 27)
        Me.TextBox_Gastos.TabIndex = 3
        '
        'GroupBox_CamionH
        '
        Me.GroupBox_CamionH.Controls.Add(Me.Label13)
        Me.GroupBox_CamionH.Controls.Add(Me.Label14)
        Me.GroupBox_CamionH.Controls.Add(Me.TextBox_MarcaH)
        Me.GroupBox_CamionH.Controls.Add(Me.TextBox_MatriculaH)
        Me.GroupBox_CamionH.Controls.Add(Me.TextBox_ModeloH)
        Me.GroupBox_CamionH.Controls.Add(Me.Label15)
        Me.GroupBox_CamionH.Location = New System.Drawing.Point(9, 57)
        Me.GroupBox_CamionH.Name = "GroupBox_CamionH"
        Me.GroupBox_CamionH.Size = New System.Drawing.Size(274, 136)
        Me.GroupBox_CamionH.TabIndex = 35
        Me.GroupBox_CamionH.TabStop = False
        Me.GroupBox_CamionH.Text = "Vehículo"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 77)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 21)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Marca"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 23)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(85, 21)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "Matrícula"
        '
        'TextBox_MarcaH
        '
        Me.TextBox_MarcaH.BackColor = System.Drawing.Color.White
        Me.TextBox_MarcaH.Location = New System.Drawing.Point(10, 101)
        Me.TextBox_MarcaH.MaxLength = 255
        Me.TextBox_MarcaH.Name = "TextBox_MarcaH"
        Me.TextBox_MarcaH.ReadOnly = True
        Me.TextBox_MarcaH.Size = New System.Drawing.Size(100, 27)
        Me.TextBox_MarcaH.TabIndex = 1
        '
        'TextBox_MatriculaH
        '
        Me.TextBox_MatriculaH.BackColor = System.Drawing.Color.White
        Me.TextBox_MatriculaH.Location = New System.Drawing.Point(10, 47)
        Me.TextBox_MatriculaH.MaxLength = 255
        Me.TextBox_MatriculaH.Name = "TextBox_MatriculaH"
        Me.TextBox_MatriculaH.ReadOnly = True
        Me.TextBox_MatriculaH.Size = New System.Drawing.Size(258, 27)
        Me.TextBox_MatriculaH.TabIndex = 0
        '
        'TextBox_ModeloH
        '
        Me.TextBox_ModeloH.BackColor = System.Drawing.Color.White
        Me.TextBox_ModeloH.Location = New System.Drawing.Point(116, 101)
        Me.TextBox_ModeloH.MaxLength = 255
        Me.TextBox_ModeloH.Name = "TextBox_ModeloH"
        Me.TextBox_ModeloH.ReadOnly = True
        Me.TextBox_ModeloH.Size = New System.Drawing.Size(152, 27)
        Me.TextBox_ModeloH.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(112, 77)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 21)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "Modelo"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(6, 11)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(270, 36)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "Historial Eliminado"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox3.Location = New System.Drawing.Point(5, 10)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(282, 480)
        Me.PictureBox3.TabIndex = 30
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.PictureBox4.Location = New System.Drawing.Point(1, 6)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(290, 488)
        Me.PictureBox4.TabIndex = 29
        Me.PictureBox4.TabStop = False
        '
        'DataGridView_Eliminados
        '
        Me.DataGridView_Eliminados.AllowUserToAddRows = False
        Me.DataGridView_Eliminados.AllowUserToDeleteRows = False
        Me.DataGridView_Eliminados.AllowUserToResizeRows = False
        Me.DataGridView_Eliminados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_Eliminados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_Eliminados.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DataGridView_Eliminados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Eliminados.Location = New System.Drawing.Point(68, 99)
        Me.DataGridView_Eliminados.MultiSelect = False
        Me.DataGridView_Eliminados.Name = "DataGridView_Eliminados"
        Me.DataGridView_Eliminados.ReadOnly = True
        Me.DataGridView_Eliminados.RowHeadersWidth = 30
        Me.DataGridView_Eliminados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Eliminados.Size = New System.Drawing.Size(771, 579)
        Me.DataGridView_Eliminados.TabIndex = 3
        '
        'Bot_Borrar
        '
        Me.Bot_Borrar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_Borrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Borrar.FlatAppearance.BorderSize = 0
        Me.Bot_Borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Borrar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Borrar.Location = New System.Drawing.Point(608, 65)
        Me.Bot_Borrar.Name = "Bot_Borrar"
        Me.Bot_Borrar.Size = New System.Drawing.Size(64, 31)
        Me.Bot_Borrar.TabIndex = 2
        Me.Bot_Borrar.Text = "Borrar"
        Me.Bot_Borrar.UseVisualStyleBackColor = False
        '
        'Bot_Restaurar
        '
        Me.Bot_Restaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bot_Restaurar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_Restaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Restaurar.FlatAppearance.BorderSize = 0
        Me.Bot_Restaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Restaurar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Restaurar.Location = New System.Drawing.Point(845, 136)
        Me.Bot_Restaurar.Name = "Bot_Restaurar"
        Me.Bot_Restaurar.Size = New System.Drawing.Size(97, 31)
        Me.Bot_Restaurar.TabIndex = 5
        Me.Bot_Restaurar.Text = "Restaurar"
        Me.Bot_Restaurar.UseVisualStyleBackColor = False
        '
        'Bot_Ver
        '
        Me.Bot_Ver.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bot_Ver.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_Ver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Ver.FlatAppearance.BorderSize = 0
        Me.Bot_Ver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Ver.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Ver.Location = New System.Drawing.Point(845, 99)
        Me.Bot_Ver.Name = "Bot_Ver"
        Me.Bot_Ver.Size = New System.Drawing.Size(97, 31)
        Me.Bot_Ver.TabIndex = 4
        Me.Bot_Ver.Text = "Ver Datos"
        Me.Bot_Ver.UseVisualStyleBackColor = False
        '
        'ComboBox_Categoria
        '
        Me.ComboBox_Categoria.BackColor = System.Drawing.Color.White
        Me.ComboBox_Categoria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBox_Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Categoria.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_Categoria.FormattingEnabled = True
        Me.ComboBox_Categoria.Items.AddRange(New Object() {"Clientes", "Vehículos", "Historial Vehículos", "Tipos de Carga", "Lugares de Carga", "Ordenes", "Entregas Saldo", "Usuarios"})
        Me.ComboBox_Categoria.Location = New System.Drawing.Point(437, 66)
        Me.ComboBox_Categoria.Name = "ComboBox_Categoria"
        Me.ComboBox_Categoria.Size = New System.Drawing.Size(165, 29)
        Me.ComboBox_Categoria.TabIndex = 1
        '
        'WMTextBox_Buscar
        '
        Me.WMTextBox_Buscar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WMTextBox_Buscar.Location = New System.Drawing.Point(68, 66)
        Me.WMTextBox_Buscar.Name = "WMTextBox_Buscar"
        Me.WMTextBox_Buscar.Size = New System.Drawing.Size(363, 27)
        Me.WMTextBox_Buscar.TabIndex = 0
        Me.WMTextBox_Buscar.WaterMarkColor = System.Drawing.Color.Gray
        Me.WMTextBox_Buscar.WaterMarkText = "Seleccione una Categoría"
        '
        'Form_RestaurarEliminados
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1004, 690)
        Me.Controls.Add(Me.Panel_Historial)
        Me.Controls.Add(Me.Panel_Vehiculo)
        Me.Controls.Add(Me.ComboBox_Categoria)
        Me.Controls.Add(Me.WMTextBox_Buscar)
        Me.Controls.Add(Me.Bot_Ver)
        Me.Controls.Add(Me.Bot_Restaurar)
        Me.Controls.Add(Me.Bot_Borrar)
        Me.Controls.Add(Me.DataGridView_Eliminados)
        Me.Controls.Add(Me.Label_Titulo)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_RestaurarEliminados"
        Me.Text = "Form_RestaurarEliminados"
        Me.Panel_Vehiculo.ResumeLayout(False)
        Me.Panel_Vehiculo.PerformLayout()
        Me.GroupBox_MantenimientoV.ResumeLayout(False)
        Me.GroupBox_MantenimientoV.PerformLayout()
        Me.GroupBox_CamionV.ResumeLayout(False)
        Me.GroupBox_CamionV.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Historial.ResumeLayout(False)
        Me.Panel_Historial.PerformLayout()
        Me.GroupBox_MantenimientoH.ResumeLayout(False)
        Me.GroupBox_MantenimientoH.PerformLayout()
        Me.GroupBox_CamionH.ResumeLayout(False)
        Me.GroupBox_CamionH.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_Eliminados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WMTextBox_Buscar As Transportes.WatermarkTextBox
    Friend WithEvents Label_Titulo As System.Windows.Forms.Label
    Friend WithEvents Panel_Vehiculo As System.Windows.Forms.Panel
    Friend WithEvents Bot_VolverV As System.Windows.Forms.Button
    Friend WithEvents Bot_RestaurarV As System.Windows.Forms.Button
    Friend WithEvents GroupBox_MantenimientoV As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox_KMCubierta As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox_KMAceite As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox_KMActuales As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox_CamionV As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox_MarcaV As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_MatrículaV As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_ModeloV As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label_Accion As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel_Historial As System.Windows.Forms.Panel
    Friend WithEvents Bot_VolverH As System.Windows.Forms.Button
    Friend WithEvents Bot_RestaurarH As System.Windows.Forms.Button
    Friend WithEvents GroupBox_MantenimientoH As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox_Detalles As System.Windows.Forms.RichTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Gastos As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox_CamionH As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TextBox_MarcaH As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_MatriculaH As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_ModeloH As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridView_Eliminados As System.Windows.Forms.DataGridView
    Friend WithEvents Bot_Borrar As System.Windows.Forms.Button
    Friend WithEvents Bot_Restaurar As System.Windows.Forms.Button
    Friend WithEvents Bot_Ver As System.Windows.Forms.Button
    Friend WithEvents ComboBox_Categoria As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox_Proximo As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Ultimo As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Fecha As System.Windows.Forms.TextBox
End Class
