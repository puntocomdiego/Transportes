<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_MenuPrincipal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_MenuPrincipal))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel_Ventana = New System.Windows.Forms.Panel()
        Me.Panel_AreaDeTrabajo = New System.Windows.Forms.Panel()
        Me.Panel_Titulo = New System.Windows.Forms.Panel()
        Me.PictureBox_Activo = New System.Windows.Forms.PictureBox()
        Me.Label_TituloVentana = New System.Windows.Forms.Label()
        Me.Bot_Minimizar = New System.Windows.Forms.Button()
        Me.Bot_Maximizar = New System.Windows.Forms.Button()
        Me.Bot_Cerrar = New System.Windows.Forms.Button()
        Me.Panel_Menu = New System.Windows.Forms.Panel()
        Me.Label_NotifAceite = New System.Windows.Forms.Label()
        Me.Label_NotifSucta = New System.Windows.Forms.Label()
        Me.Panel_Seleccionado = New System.Windows.Forms.Panel()
        Me.Bot_Recuperacion = New System.Windows.Forms.Button()
        Me.Bot_Respaldo = New System.Windows.Forms.Button()
        Me.Bot_Usuarios = New System.Windows.Forms.Button()
        Me.Bot_Configuracion = New System.Windows.Forms.Button()
        Me.Bot_Eliminados = New System.Windows.Forms.Button()
        Me.Bot_Sucta = New System.Windows.Forms.Button()
        Me.Bot_Saldos = New System.Windows.Forms.Button()
        Me.Bot_InformesConsultas = New System.Windows.Forms.Button()
        Me.Bot_Salir = New System.Windows.Forms.Button()
        Me.Bot_OrdenesCD = New System.Windows.Forms.Button()
        Me.Bot_LugaresCarga = New System.Windows.Forms.Button()
        Me.Bot_TiposCarga = New System.Windows.Forms.Button()
        Me.Bot_Vehiculos = New System.Windows.Forms.Button()
        Me.Bot_Clientes = New System.Windows.Forms.Button()
        Me.Bot_Inicio = New System.Windows.Forms.Button()
        Me.Bot_Menu = New System.Windows.Forms.Button()
        Me.Panel_Usuario = New System.Windows.Forms.Panel()
        Me.Label_NombreUser = New System.Windows.Forms.Label()
        Me.ZDivision1 = New System.Windows.Forms.Panel()
        Me.PictureBox_FotoUser = New System.Windows.Forms.PictureBox()
        Me.Label_VentanaActual = New System.Windows.Forms.Label()
        Me.Label_FechaHora = New System.Windows.Forms.Label()
        Me.Panel_Ventana.SuspendLayout()
        Me.Panel_Titulo.SuspendLayout()
        CType(Me.PictureBox_Activo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Menu.SuspendLayout()
        Me.Panel_Usuario.SuspendLayout()
        CType(Me.PictureBox_FotoUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'Panel_Ventana
        '
        Me.Panel_Ventana.Controls.Add(Me.Panel_AreaDeTrabajo)
        Me.Panel_Ventana.Controls.Add(Me.Panel_Titulo)
        Me.Panel_Ventana.Controls.Add(Me.Panel_Menu)
        Me.Panel_Ventana.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Ventana.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Ventana.Name = "Panel_Ventana"
        Me.Panel_Ventana.Size = New System.Drawing.Size(1280, 720)
        Me.Panel_Ventana.TabIndex = 0
        '
        'Panel_AreaDeTrabajo
        '
        Me.Panel_AreaDeTrabajo.BackColor = System.Drawing.SystemColors.Control
        Me.Panel_AreaDeTrabajo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_AreaDeTrabajo.Location = New System.Drawing.Point(276, 30)
        Me.Panel_AreaDeTrabajo.Name = "Panel_AreaDeTrabajo"
        Me.Panel_AreaDeTrabajo.Size = New System.Drawing.Size(1004, 690)
        Me.Panel_AreaDeTrabajo.TabIndex = 16
        '
        'Panel_Titulo
        '
        Me.Panel_Titulo.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel_Titulo.Controls.Add(Me.PictureBox_Activo)
        Me.Panel_Titulo.Controls.Add(Me.Label_TituloVentana)
        Me.Panel_Titulo.Controls.Add(Me.Bot_Minimizar)
        Me.Panel_Titulo.Controls.Add(Me.Bot_Maximizar)
        Me.Panel_Titulo.Controls.Add(Me.Bot_Cerrar)
        Me.Panel_Titulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Titulo.ForeColor = System.Drawing.Color.White
        Me.Panel_Titulo.Location = New System.Drawing.Point(276, 0)
        Me.Panel_Titulo.Name = "Panel_Titulo"
        Me.Panel_Titulo.Size = New System.Drawing.Size(1004, 30)
        Me.Panel_Titulo.TabIndex = 7
        '
        'PictureBox_Activo
        '
        Me.PictureBox_Activo.Location = New System.Drawing.Point(5, 5)
        Me.PictureBox_Activo.Name = "PictureBox_Activo"
        Me.PictureBox_Activo.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox_Activo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox_Activo.TabIndex = 0
        Me.PictureBox_Activo.TabStop = False
        '
        'Label_TituloVentana
        '
        Me.Label_TituloVentana.AutoSize = True
        Me.Label_TituloVentana.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TituloVentana.Location = New System.Drawing.Point(27, 5)
        Me.Label_TituloVentana.Name = "Label_TituloVentana"
        Me.Label_TituloVentana.Size = New System.Drawing.Size(148, 19)
        Me.Label_TituloVentana.TabIndex = 5
        Me.Label_TituloVentana.Text = "UserControl.Name"
        '
        'Bot_Minimizar
        '
        Me.Bot_Minimizar.BackColor = System.Drawing.Color.SeaGreen
        Me.Bot_Minimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Minimizar.Dock = System.Windows.Forms.DockStyle.Right
        Me.Bot_Minimizar.FlatAppearance.BorderSize = 0
        Me.Bot_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Minimizar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Minimizar.ForeColor = System.Drawing.Color.White
        Me.Bot_Minimizar.Location = New System.Drawing.Point(914, 0)
        Me.Bot_Minimizar.Name = "Bot_Minimizar"
        Me.Bot_Minimizar.Size = New System.Drawing.Size(30, 30)
        Me.Bot_Minimizar.TabIndex = 17
        Me.Bot_Minimizar.Text = "_"
        Me.Bot_Minimizar.UseVisualStyleBackColor = False
        '
        'Bot_Maximizar
        '
        Me.Bot_Maximizar.BackColor = System.Drawing.Color.SeaGreen
        Me.Bot_Maximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Maximizar.Dock = System.Windows.Forms.DockStyle.Right
        Me.Bot_Maximizar.FlatAppearance.BorderSize = 0
        Me.Bot_Maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Maximizar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Maximizar.ForeColor = System.Drawing.Color.White
        Me.Bot_Maximizar.Location = New System.Drawing.Point(944, 0)
        Me.Bot_Maximizar.Name = "Bot_Maximizar"
        Me.Bot_Maximizar.Size = New System.Drawing.Size(30, 30)
        Me.Bot_Maximizar.TabIndex = 18
        Me.Bot_Maximizar.Text = "O"
        Me.Bot_Maximizar.UseVisualStyleBackColor = False
        '
        'Bot_Cerrar
        '
        Me.Bot_Cerrar.BackColor = System.Drawing.Color.SeaGreen
        Me.Bot_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Cerrar.Dock = System.Windows.Forms.DockStyle.Right
        Me.Bot_Cerrar.FlatAppearance.BorderSize = 0
        Me.Bot_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Cerrar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Cerrar.ForeColor = System.Drawing.Color.White
        Me.Bot_Cerrar.Location = New System.Drawing.Point(974, 0)
        Me.Bot_Cerrar.Name = "Bot_Cerrar"
        Me.Bot_Cerrar.Size = New System.Drawing.Size(30, 30)
        Me.Bot_Cerrar.TabIndex = 19
        Me.Bot_Cerrar.Text = "X"
        Me.Bot_Cerrar.UseVisualStyleBackColor = False
        '
        'Panel_Menu
        '
        Me.Panel_Menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel_Menu.Controls.Add(Me.Label_NotifAceite)
        Me.Panel_Menu.Controls.Add(Me.Label_NotifSucta)
        Me.Panel_Menu.Controls.Add(Me.Panel_Seleccionado)
        Me.Panel_Menu.Controls.Add(Me.Bot_Recuperacion)
        Me.Panel_Menu.Controls.Add(Me.Bot_Respaldo)
        Me.Panel_Menu.Controls.Add(Me.Bot_Usuarios)
        Me.Panel_Menu.Controls.Add(Me.Bot_Configuracion)
        Me.Panel_Menu.Controls.Add(Me.Bot_Eliminados)
        Me.Panel_Menu.Controls.Add(Me.Bot_Sucta)
        Me.Panel_Menu.Controls.Add(Me.Bot_Saldos)
        Me.Panel_Menu.Controls.Add(Me.Bot_InformesConsultas)
        Me.Panel_Menu.Controls.Add(Me.Bot_Salir)
        Me.Panel_Menu.Controls.Add(Me.Bot_OrdenesCD)
        Me.Panel_Menu.Controls.Add(Me.Bot_LugaresCarga)
        Me.Panel_Menu.Controls.Add(Me.Bot_TiposCarga)
        Me.Panel_Menu.Controls.Add(Me.Bot_Vehiculos)
        Me.Panel_Menu.Controls.Add(Me.Bot_Clientes)
        Me.Panel_Menu.Controls.Add(Me.Bot_Inicio)
        Me.Panel_Menu.Controls.Add(Me.Bot_Menu)
        Me.Panel_Menu.Controls.Add(Me.Panel_Usuario)
        Me.Panel_Menu.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_Menu.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Menu.Name = "Panel_Menu"
        Me.Panel_Menu.Size = New System.Drawing.Size(276, 720)
        Me.Panel_Menu.TabIndex = 0
        '
        'Label_NotifAceite
        '
        Me.Label_NotifAceite.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_NotifAceite.BackColor = System.Drawing.Color.Transparent
        Me.Label_NotifAceite.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label_NotifAceite.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_NotifAceite.ForeColor = System.Drawing.Color.White
        Me.Label_NotifAceite.Image = CType(resources.GetObject("Label_NotifAceite.Image"), System.Drawing.Image)
        Me.Label_NotifAceite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_NotifAceite.Location = New System.Drawing.Point(235, 201)
        Me.Label_NotifAceite.Name = "Label_NotifAceite"
        Me.Label_NotifAceite.Size = New System.Drawing.Size(30, 16)
        Me.Label_NotifAceite.TabIndex = 21
        Me.Label_NotifAceite.Text = "+00"
        Me.Label_NotifAceite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label_NotifAceite.Visible = False
        '
        'Label_NotifSucta
        '
        Me.Label_NotifSucta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_NotifSucta.BackColor = System.Drawing.Color.Transparent
        Me.Label_NotifSucta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label_NotifSucta.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_NotifSucta.ForeColor = System.Drawing.Color.White
        Me.Label_NotifSucta.Image = CType(resources.GetObject("Label_NotifSucta.Image"), System.Drawing.Image)
        Me.Label_NotifSucta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_NotifSucta.Location = New System.Drawing.Point(235, 444)
        Me.Label_NotifSucta.Name = "Label_NotifSucta"
        Me.Label_NotifSucta.Size = New System.Drawing.Size(30, 16)
        Me.Label_NotifSucta.TabIndex = 20
        Me.Label_NotifSucta.Text = "+00"
        Me.Label_NotifSucta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label_NotifSucta.Visible = False
        '
        'Panel_Seleccionado
        '
        Me.Panel_Seleccionado.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Panel_Seleccionado.Location = New System.Drawing.Point(270, 654)
        Me.Panel_Seleccionado.Name = "Panel_Seleccionado"
        Me.Panel_Seleccionado.Size = New System.Drawing.Size(6, 34)
        Me.Panel_Seleccionado.TabIndex = 15
        Me.Panel_Seleccionado.Visible = False
        '
        'Bot_Recuperacion
        '
        Me.Bot_Recuperacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Recuperacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.Bot_Recuperacion.FlatAppearance.BorderSize = 0
        Me.Bot_Recuperacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Recuperacion.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Recuperacion.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Bot_Recuperacion.Image = CType(resources.GetObject("Bot_Recuperacion.Image"), System.Drawing.Image)
        Me.Bot_Recuperacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bot_Recuperacion.Location = New System.Drawing.Point(0, 612)
        Me.Bot_Recuperacion.Name = "Bot_Recuperacion"
        Me.Bot_Recuperacion.Size = New System.Drawing.Size(276, 34)
        Me.Bot_Recuperacion.TabIndex = 15
        Me.Bot_Recuperacion.Text = "Recuperación de Datos"
        Me.Bot_Recuperacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bot_Recuperacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Bot_Recuperacion.UseVisualStyleBackColor = True
        '
        'Bot_Respaldo
        '
        Me.Bot_Respaldo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Respaldo.Dock = System.Windows.Forms.DockStyle.Top
        Me.Bot_Respaldo.FlatAppearance.BorderSize = 0
        Me.Bot_Respaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Respaldo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Respaldo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Bot_Respaldo.Image = CType(resources.GetObject("Bot_Respaldo.Image"), System.Drawing.Image)
        Me.Bot_Respaldo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bot_Respaldo.Location = New System.Drawing.Point(0, 578)
        Me.Bot_Respaldo.Name = "Bot_Respaldo"
        Me.Bot_Respaldo.Size = New System.Drawing.Size(276, 34)
        Me.Bot_Respaldo.TabIndex = 14
        Me.Bot_Respaldo.Text = "Respaldo de Información"
        Me.Bot_Respaldo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bot_Respaldo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Bot_Respaldo.UseVisualStyleBackColor = True
        '
        'Bot_Usuarios
        '
        Me.Bot_Usuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Usuarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.Bot_Usuarios.FlatAppearance.BorderSize = 0
        Me.Bot_Usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Usuarios.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Usuarios.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Bot_Usuarios.Image = CType(resources.GetObject("Bot_Usuarios.Image"), System.Drawing.Image)
        Me.Bot_Usuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bot_Usuarios.Location = New System.Drawing.Point(0, 544)
        Me.Bot_Usuarios.Name = "Bot_Usuarios"
        Me.Bot_Usuarios.Size = New System.Drawing.Size(276, 34)
        Me.Bot_Usuarios.TabIndex = 13
        Me.Bot_Usuarios.Tag = "Control_BusquedaUsuarios"
        Me.Bot_Usuarios.Text = "Usuarios"
        Me.Bot_Usuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bot_Usuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Bot_Usuarios.UseVisualStyleBackColor = True
        '
        'Bot_Configuracion
        '
        Me.Bot_Configuracion.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_Configuracion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Configuracion.Dock = System.Windows.Forms.DockStyle.Top
        Me.Bot_Configuracion.FlatAppearance.BorderSize = 0
        Me.Bot_Configuracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Configuracion.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Configuracion.Image = CType(resources.GetObject("Bot_Configuracion.Image"), System.Drawing.Image)
        Me.Bot_Configuracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bot_Configuracion.Location = New System.Drawing.Point(0, 504)
        Me.Bot_Configuracion.Name = "Bot_Configuracion"
        Me.Bot_Configuracion.Size = New System.Drawing.Size(276, 40)
        Me.Bot_Configuracion.TabIndex = 12
        Me.Bot_Configuracion.Text = "  Configuración"
        Me.Bot_Configuracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bot_Configuracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Bot_Configuracion.UseVisualStyleBackColor = False
        '
        'Bot_Eliminados
        '
        Me.Bot_Eliminados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Eliminados.Dock = System.Windows.Forms.DockStyle.Top
        Me.Bot_Eliminados.FlatAppearance.BorderSize = 0
        Me.Bot_Eliminados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Eliminados.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Eliminados.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Bot_Eliminados.Image = CType(resources.GetObject("Bot_Eliminados.Image"), System.Drawing.Image)
        Me.Bot_Eliminados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bot_Eliminados.Location = New System.Drawing.Point(0, 470)
        Me.Bot_Eliminados.Name = "Bot_Eliminados"
        Me.Bot_Eliminados.Size = New System.Drawing.Size(276, 34)
        Me.Bot_Eliminados.TabIndex = 11
        Me.Bot_Eliminados.Tag = "Control_BusquedaUsuarios"
        Me.Bot_Eliminados.Text = "Restaurar Eliminados"
        Me.Bot_Eliminados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bot_Eliminados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Bot_Eliminados.UseVisualStyleBackColor = True
        '
        'Bot_Sucta
        '
        Me.Bot_Sucta.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Bot_Sucta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Sucta.Dock = System.Windows.Forms.DockStyle.Top
        Me.Bot_Sucta.FlatAppearance.BorderSize = 0
        Me.Bot_Sucta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Sucta.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Sucta.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Bot_Sucta.Image = CType(resources.GetObject("Bot_Sucta.Image"), System.Drawing.Image)
        Me.Bot_Sucta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bot_Sucta.Location = New System.Drawing.Point(0, 436)
        Me.Bot_Sucta.Name = "Bot_Sucta"
        Me.Bot_Sucta.Size = New System.Drawing.Size(276, 34)
        Me.Bot_Sucta.TabIndex = 10
        Me.Bot_Sucta.Text = "Vencimientos SUCTA"
        Me.Bot_Sucta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bot_Sucta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Bot_Sucta.UseVisualStyleBackColor = False
        '
        'Bot_Saldos
        '
        Me.Bot_Saldos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Saldos.Dock = System.Windows.Forms.DockStyle.Top
        Me.Bot_Saldos.FlatAppearance.BorderSize = 0
        Me.Bot_Saldos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Saldos.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Saldos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Bot_Saldos.Image = CType(resources.GetObject("Bot_Saldos.Image"), System.Drawing.Image)
        Me.Bot_Saldos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bot_Saldos.Location = New System.Drawing.Point(0, 402)
        Me.Bot_Saldos.Name = "Bot_Saldos"
        Me.Bot_Saldos.Size = New System.Drawing.Size(276, 34)
        Me.Bot_Saldos.TabIndex = 9
        Me.Bot_Saldos.Text = "Saldos por Cliente"
        Me.Bot_Saldos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bot_Saldos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Bot_Saldos.UseVisualStyleBackColor = True
        '
        'Bot_InformesConsultas
        '
        Me.Bot_InformesConsultas.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_InformesConsultas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_InformesConsultas.Dock = System.Windows.Forms.DockStyle.Top
        Me.Bot_InformesConsultas.FlatAppearance.BorderSize = 0
        Me.Bot_InformesConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_InformesConsultas.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_InformesConsultas.Image = CType(resources.GetObject("Bot_InformesConsultas.Image"), System.Drawing.Image)
        Me.Bot_InformesConsultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bot_InformesConsultas.Location = New System.Drawing.Point(0, 362)
        Me.Bot_InformesConsultas.Name = "Bot_InformesConsultas"
        Me.Bot_InformesConsultas.Size = New System.Drawing.Size(276, 40)
        Me.Bot_InformesConsultas.TabIndex = 8
        Me.Bot_InformesConsultas.Text = "  Informes y Consultas"
        Me.Bot_InformesConsultas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bot_InformesConsultas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Bot_InformesConsultas.UseVisualStyleBackColor = False
        '
        'Bot_Salir
        '
        Me.Bot_Salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Salir.Dock = System.Windows.Forms.DockStyle.Top
        Me.Bot_Salir.FlatAppearance.BorderSize = 0
        Me.Bot_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Salir.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Salir.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Bot_Salir.Image = CType(resources.GetObject("Bot_Salir.Image"), System.Drawing.Image)
        Me.Bot_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bot_Salir.Location = New System.Drawing.Point(0, 328)
        Me.Bot_Salir.Name = "Bot_Salir"
        Me.Bot_Salir.Size = New System.Drawing.Size(276, 34)
        Me.Bot_Salir.TabIndex = 7
        Me.Bot_Salir.Text = "Salir"
        Me.Bot_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bot_Salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Bot_Salir.UseVisualStyleBackColor = True
        '
        'Bot_OrdenesCD
        '
        Me.Bot_OrdenesCD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_OrdenesCD.Dock = System.Windows.Forms.DockStyle.Top
        Me.Bot_OrdenesCD.FlatAppearance.BorderSize = 0
        Me.Bot_OrdenesCD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_OrdenesCD.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_OrdenesCD.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Bot_OrdenesCD.Image = CType(resources.GetObject("Bot_OrdenesCD.Image"), System.Drawing.Image)
        Me.Bot_OrdenesCD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bot_OrdenesCD.Location = New System.Drawing.Point(0, 294)
        Me.Bot_OrdenesCD.Name = "Bot_OrdenesCD"
        Me.Bot_OrdenesCD.Size = New System.Drawing.Size(276, 34)
        Me.Bot_OrdenesCD.TabIndex = 6
        Me.Bot_OrdenesCD.Text = "Ordenes de Carga y Descarga"
        Me.Bot_OrdenesCD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bot_OrdenesCD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Bot_OrdenesCD.UseVisualStyleBackColor = True
        '
        'Bot_LugaresCarga
        '
        Me.Bot_LugaresCarga.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_LugaresCarga.Dock = System.Windows.Forms.DockStyle.Top
        Me.Bot_LugaresCarga.FlatAppearance.BorderSize = 0
        Me.Bot_LugaresCarga.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_LugaresCarga.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_LugaresCarga.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Bot_LugaresCarga.Image = CType(resources.GetObject("Bot_LugaresCarga.Image"), System.Drawing.Image)
        Me.Bot_LugaresCarga.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bot_LugaresCarga.Location = New System.Drawing.Point(0, 260)
        Me.Bot_LugaresCarga.Name = "Bot_LugaresCarga"
        Me.Bot_LugaresCarga.Size = New System.Drawing.Size(276, 34)
        Me.Bot_LugaresCarga.TabIndex = 5
        Me.Bot_LugaresCarga.Text = "Lugares de Carga"
        Me.Bot_LugaresCarga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bot_LugaresCarga.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Bot_LugaresCarga.UseVisualStyleBackColor = True
        '
        'Bot_TiposCarga
        '
        Me.Bot_TiposCarga.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_TiposCarga.Dock = System.Windows.Forms.DockStyle.Top
        Me.Bot_TiposCarga.FlatAppearance.BorderSize = 0
        Me.Bot_TiposCarga.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_TiposCarga.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_TiposCarga.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Bot_TiposCarga.Image = CType(resources.GetObject("Bot_TiposCarga.Image"), System.Drawing.Image)
        Me.Bot_TiposCarga.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bot_TiposCarga.Location = New System.Drawing.Point(0, 226)
        Me.Bot_TiposCarga.Name = "Bot_TiposCarga"
        Me.Bot_TiposCarga.Size = New System.Drawing.Size(276, 34)
        Me.Bot_TiposCarga.TabIndex = 4
        Me.Bot_TiposCarga.Text = "Tipos de Carga"
        Me.Bot_TiposCarga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bot_TiposCarga.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Bot_TiposCarga.UseVisualStyleBackColor = True
        '
        'Bot_Vehiculos
        '
        Me.Bot_Vehiculos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Vehiculos.Dock = System.Windows.Forms.DockStyle.Top
        Me.Bot_Vehiculos.FlatAppearance.BorderSize = 0
        Me.Bot_Vehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Vehiculos.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Vehiculos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Bot_Vehiculos.Image = CType(resources.GetObject("Bot_Vehiculos.Image"), System.Drawing.Image)
        Me.Bot_Vehiculos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bot_Vehiculos.Location = New System.Drawing.Point(0, 192)
        Me.Bot_Vehiculos.Name = "Bot_Vehiculos"
        Me.Bot_Vehiculos.Size = New System.Drawing.Size(276, 34)
        Me.Bot_Vehiculos.TabIndex = 3
        Me.Bot_Vehiculos.Text = "Vehiculos - Historial"
        Me.Bot_Vehiculos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bot_Vehiculos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Bot_Vehiculos.UseVisualStyleBackColor = True
        '
        'Bot_Clientes
        '
        Me.Bot_Clientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Clientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.Bot_Clientes.FlatAppearance.BorderSize = 0
        Me.Bot_Clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Clientes.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Clientes.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Bot_Clientes.Image = CType(resources.GetObject("Bot_Clientes.Image"), System.Drawing.Image)
        Me.Bot_Clientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bot_Clientes.Location = New System.Drawing.Point(0, 158)
        Me.Bot_Clientes.Name = "Bot_Clientes"
        Me.Bot_Clientes.Size = New System.Drawing.Size(276, 34)
        Me.Bot_Clientes.TabIndex = 2
        Me.Bot_Clientes.Tag = "Control_BusquedaClientes"
        Me.Bot_Clientes.Text = "Clientes"
        Me.Bot_Clientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bot_Clientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Bot_Clientes.UseVisualStyleBackColor = True
        '
        'Bot_Inicio
        '
        Me.Bot_Inicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Inicio.Dock = System.Windows.Forms.DockStyle.Top
        Me.Bot_Inicio.FlatAppearance.BorderSize = 0
        Me.Bot_Inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Inicio.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Inicio.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Bot_Inicio.Image = CType(resources.GetObject("Bot_Inicio.Image"), System.Drawing.Image)
        Me.Bot_Inicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bot_Inicio.Location = New System.Drawing.Point(0, 124)
        Me.Bot_Inicio.Name = "Bot_Inicio"
        Me.Bot_Inicio.Size = New System.Drawing.Size(276, 34)
        Me.Bot_Inicio.TabIndex = 1
        Me.Bot_Inicio.Text = "Inicio"
        Me.Bot_Inicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bot_Inicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Bot_Inicio.UseVisualStyleBackColor = True
        '
        'Bot_Menu
        '
        Me.Bot_Menu.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_Menu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Menu.Dock = System.Windows.Forms.DockStyle.Top
        Me.Bot_Menu.FlatAppearance.BorderSize = 0
        Me.Bot_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Menu.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Menu.Image = CType(resources.GetObject("Bot_Menu.Image"), System.Drawing.Image)
        Me.Bot_Menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bot_Menu.Location = New System.Drawing.Point(0, 84)
        Me.Bot_Menu.Name = "Bot_Menu"
        Me.Bot_Menu.Size = New System.Drawing.Size(276, 40)
        Me.Bot_Menu.TabIndex = 0
        Me.Bot_Menu.Text = " Menú"
        Me.Bot_Menu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bot_Menu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Bot_Menu.UseVisualStyleBackColor = False
        '
        'Panel_Usuario
        '
        Me.Panel_Usuario.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Panel_Usuario.Controls.Add(Me.Label_NombreUser)
        Me.Panel_Usuario.Controls.Add(Me.ZDivision1)
        Me.Panel_Usuario.Controls.Add(Me.PictureBox_FotoUser)
        Me.Panel_Usuario.Controls.Add(Me.Label_VentanaActual)
        Me.Panel_Usuario.Controls.Add(Me.Label_FechaHora)
        Me.Panel_Usuario.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Usuario.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Usuario.Name = "Panel_Usuario"
        Me.Panel_Usuario.Size = New System.Drawing.Size(276, 84)
        Me.Panel_Usuario.TabIndex = 19
        '
        'Label_NombreUser
        '
        Me.Label_NombreUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label_NombreUser.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_NombreUser.Location = New System.Drawing.Point(79, 15)
        Me.Label_NombreUser.Name = "Label_NombreUser"
        Me.Label_NombreUser.Size = New System.Drawing.Size(193, 19)
        Me.Label_NombreUser.TabIndex = 20
        Me.Label_NombreUser.Text = "Nombre Usuario"
        '
        'ZDivision1
        '
        Me.ZDivision1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ZDivision1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ZDivision1.Location = New System.Drawing.Point(0, 81)
        Me.ZDivision1.Name = "ZDivision1"
        Me.ZDivision1.Size = New System.Drawing.Size(276, 3)
        Me.ZDivision1.TabIndex = 16
        '
        'PictureBox_FotoUser
        '
        Me.PictureBox_FotoUser.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox_FotoUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_FotoUser.Image = CType(resources.GetObject("PictureBox_FotoUser.Image"), System.Drawing.Image)
        Me.PictureBox_FotoUser.Location = New System.Drawing.Point(13, 12)
        Me.PictureBox_FotoUser.Name = "PictureBox_FotoUser"
        Me.PictureBox_FotoUser.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox_FotoUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox_FotoUser.TabIndex = 0
        Me.PictureBox_FotoUser.TabStop = False
        '
        'Label_VentanaActual
        '
        Me.Label_VentanaActual.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_VentanaActual.Location = New System.Drawing.Point(80, 36)
        Me.Label_VentanaActual.Name = "Label_VentanaActual"
        Me.Label_VentanaActual.Size = New System.Drawing.Size(192, 17)
        Me.Label_VentanaActual.TabIndex = 0
        Me.Label_VentanaActual.Text = "Ventana Actual"
        '
        'Label_FechaHora
        '
        Me.Label_FechaHora.AutoSize = True
        Me.Label_FechaHora.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_FechaHora.Location = New System.Drawing.Point(80, 54)
        Me.Label_FechaHora.Name = "Label_FechaHora"
        Me.Label_FechaHora.Size = New System.Drawing.Size(133, 17)
        Me.Label_FechaHora.TabIndex = 1
        Me.Label_FechaHora.Text = "DD/MM/YYY HH/MM"
        '
        'Form_MenuPrincipal
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.Panel_Ventana)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1278, 720)
        Me.Name = "Form_MenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transportes"
        Me.Panel_Ventana.ResumeLayout(False)
        Me.Panel_Titulo.ResumeLayout(False)
        Me.Panel_Titulo.PerformLayout()
        CType(Me.PictureBox_Activo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Menu.ResumeLayout(False)
        Me.Panel_Usuario.ResumeLayout(False)
        Me.Panel_Usuario.PerformLayout()
        CType(Me.PictureBox_FotoUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Panel_Ventana As System.Windows.Forms.Panel
    Friend WithEvents Panel_Menu As System.Windows.Forms.Panel
    Friend WithEvents Panel_Seleccionado As System.Windows.Forms.Panel
    Friend WithEvents Bot_Recuperacion As System.Windows.Forms.Button
    Friend WithEvents Bot_Respaldo As System.Windows.Forms.Button
    Friend WithEvents Bot_Usuarios As System.Windows.Forms.Button
    Friend WithEvents Bot_Configuracion As System.Windows.Forms.Button
    Friend WithEvents Bot_Sucta As System.Windows.Forms.Button
    Friend WithEvents Bot_Saldos As System.Windows.Forms.Button
    Friend WithEvents Bot_InformesConsultas As System.Windows.Forms.Button
    Friend WithEvents Bot_Salir As System.Windows.Forms.Button
    Friend WithEvents Bot_OrdenesCD As System.Windows.Forms.Button
    Friend WithEvents Bot_LugaresCarga As System.Windows.Forms.Button
    Friend WithEvents Bot_TiposCarga As System.Windows.Forms.Button
    Friend WithEvents Bot_Vehiculos As System.Windows.Forms.Button
    Friend WithEvents Bot_Clientes As System.Windows.Forms.Button
    Friend WithEvents Bot_Inicio As System.Windows.Forms.Button
    Friend WithEvents Bot_Menu As System.Windows.Forms.Button
    Friend WithEvents Panel_Usuario As System.Windows.Forms.Panel
    Friend WithEvents ZDivision1 As System.Windows.Forms.Panel
    Friend WithEvents Label_FechaHora As System.Windows.Forms.Label
    Friend WithEvents Label_VentanaActual As System.Windows.Forms.Label
    Friend WithEvents Label_NombreUser As System.Windows.Forms.Label
    Friend WithEvents PictureBox_FotoUser As System.Windows.Forms.PictureBox
    Friend WithEvents Panel_Titulo As System.Windows.Forms.Panel
    Friend WithEvents PictureBox_Activo As System.Windows.Forms.PictureBox
    Friend WithEvents Label_TituloVentana As System.Windows.Forms.Label
    Friend WithEvents Bot_Minimizar As System.Windows.Forms.Button
    Friend WithEvents Bot_Maximizar As System.Windows.Forms.Button
    Friend WithEvents Bot_Cerrar As System.Windows.Forms.Button
    Friend WithEvents Panel_AreaDeTrabajo As System.Windows.Forms.Panel
    Friend WithEvents Bot_Eliminados As System.Windows.Forms.Button
    Friend WithEvents Label_NotifSucta As System.Windows.Forms.Label
    Friend WithEvents Label_NotifAceite As System.Windows.Forms.Label

End Class
