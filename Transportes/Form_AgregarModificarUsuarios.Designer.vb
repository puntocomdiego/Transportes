<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_AgregarModificarUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_AgregarModificarUsuarios))
        Me.Bot_Volver = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox_Direccion = New System.Windows.Forms.TextBox()
        Me.TextBox_Telefono = New System.Windows.Forms.TextBox()
        Me.Bot_Cancelar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label_Contraseña = New System.Windows.Forms.Label()
        Me.Bot_Ver2 = New System.Windows.Forms.Button()
        Me.Bot_Ver = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox_ConfirmarContraseña = New System.Windows.Forms.TextBox()
        Me.TextBox_Contraseña = New System.Windows.Forms.TextBox()
        Me.TextBox_Nombre = New System.Windows.Forms.TextBox()
        Me.TextBox_Apellido = New System.Windows.Forms.TextBox()
        Me.TextBox_CI = New System.Windows.Forms.TextBox()
        Me.Bot_Guardar = New System.Windows.Forms.Button()
        Me.Label_Titulo = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Bot_Volver
        '
        Me.Bot_Volver.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bot_Volver.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_Volver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Volver.FlatAppearance.BorderSize = 0
        Me.Bot_Volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Volver.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Volver.Location = New System.Drawing.Point(845, 173)
        Me.Bot_Volver.Name = "Bot_Volver"
        Me.Bot_Volver.Size = New System.Drawing.Size(97, 31)
        Me.Bot_Volver.TabIndex = 9
        Me.Bot_Volver.Text = "Volver"
        Me.Bot_Volver.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(68, 373)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(771, 149)
        Me.GroupBox2.TabIndex = 50
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información de Contacto"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 21)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Dirección"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 21)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Teléfono"
        '
        'TextBox_Direccion
        '
        Me.TextBox_Direccion.Location = New System.Drawing.Point(82, 427)
        Me.TextBox_Direccion.MaxLength = 50
        Me.TextBox_Direccion.Name = "TextBox_Direccion"
        Me.TextBox_Direccion.Size = New System.Drawing.Size(545, 27)
        Me.TextBox_Direccion.TabIndex = 5
        '
        'TextBox_Telefono
        '
        Me.TextBox_Telefono.Location = New System.Drawing.Point(82, 481)
        Me.TextBox_Telefono.MaxLength = 50
        Me.TextBox_Telefono.Name = "TextBox_Telefono"
        Me.TextBox_Telefono.Size = New System.Drawing.Size(266, 27)
        Me.TextBox_Telefono.TabIndex = 6
        '
        'Bot_Cancelar
        '
        Me.Bot_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bot_Cancelar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Cancelar.FlatAppearance.BorderSize = 0
        Me.Bot_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Cancelar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Cancelar.Location = New System.Drawing.Point(845, 136)
        Me.Bot_Cancelar.Name = "Bot_Cancelar"
        Me.Bot_Cancelar.Size = New System.Drawing.Size(97, 31)
        Me.Bot_Cancelar.TabIndex = 8
        Me.Bot_Cancelar.Text = "Cancelar"
        Me.Bot_Cancelar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label_Contraseña)
        Me.GroupBox1.Controls.Add(Me.Bot_Ver2)
        Me.GroupBox1.Controls.Add(Me.Bot_Ver)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(68, 89)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(771, 278)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Personales"
        '
        'Label_Contraseña
        '
        Me.Label_Contraseña.Location = New System.Drawing.Point(382, 169)
        Me.Label_Contraseña.Name = "Label_Contraseña"
        Me.Label_Contraseña.Size = New System.Drawing.Size(354, 84)
        Me.Label_Contraseña.TabIndex = 36
        Me.Label_Contraseña.Text = ">No se mostrará la contraseña del usuario, pero en caso de que desee modificarla " & _
            "ingrese una nueva. De lo contrario deje los campos en blanco"
        Me.Label_Contraseña.Visible = False
        '
        'Bot_Ver2
        '
        Me.Bot_Ver2.BackColor = System.Drawing.SystemColors.Control
        Me.Bot_Ver2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Ver2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Bot_Ver2.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_Ver2.FlatAppearance.BorderSize = 0
        Me.Bot_Ver2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Ver2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Ver2.Image = CType(resources.GetObject("Bot_Ver2.Image"), System.Drawing.Image)
        Me.Bot_Ver2.Location = New System.Drawing.Point(345, 223)
        Me.Bot_Ver2.Name = "Bot_Ver2"
        Me.Bot_Ver2.Size = New System.Drawing.Size(27, 27)
        Me.Bot_Ver2.TabIndex = 6
        Me.Bot_Ver2.TabStop = False
        Me.Bot_Ver2.UseVisualStyleBackColor = False
        '
        'Bot_Ver
        '
        Me.Bot_Ver.BackColor = System.Drawing.SystemColors.Control
        Me.Bot_Ver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Ver.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Bot_Ver.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_Ver.FlatAppearance.BorderSize = 0
        Me.Bot_Ver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Ver.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Ver.Image = CType(resources.GetObject("Bot_Ver.Image"), System.Drawing.Image)
        Me.Bot_Ver.Location = New System.Drawing.Point(345, 169)
        Me.Bot_Ver.Name = "Bot_Ver"
        Me.Bot_Ver.Size = New System.Drawing.Size(27, 27)
        Me.Bot_Ver.TabIndex = 4
        Me.Bot_Ver.TabStop = False
        Me.Bot_Ver.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(194, 21)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Confirmar Contraseña *"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 21)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Nombre *"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(10, 91)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(186, 21)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "Cédula de Idéntidad *"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(374, 34)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 21)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Apellido *"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 21)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Contraseña *"
        '
        'TextBox_ConfirmarContraseña
        '
        Me.TextBox_ConfirmarContraseña.Location = New System.Drawing.Point(82, 312)
        Me.TextBox_ConfirmarContraseña.MaxLength = 50
        Me.TextBox_ConfirmarContraseña.Name = "TextBox_ConfirmarContraseña"
        Me.TextBox_ConfirmarContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox_ConfirmarContraseña.Size = New System.Drawing.Size(325, 27)
        Me.TextBox_ConfirmarContraseña.TabIndex = 4
        '
        'TextBox_Contraseña
        '
        Me.TextBox_Contraseña.Location = New System.Drawing.Point(82, 258)
        Me.TextBox_Contraseña.MaxLength = 50
        Me.TextBox_Contraseña.Name = "TextBox_Contraseña"
        Me.TextBox_Contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox_Contraseña.Size = New System.Drawing.Size(325, 27)
        Me.TextBox_Contraseña.TabIndex = 3
        '
        'TextBox_Nombre
        '
        Me.TextBox_Nombre.Location = New System.Drawing.Point(82, 147)
        Me.TextBox_Nombre.MaxLength = 50
        Me.TextBox_Nombre.Name = "TextBox_Nombre"
        Me.TextBox_Nombre.Size = New System.Drawing.Size(358, 27)
        Me.TextBox_Nombre.TabIndex = 0
        '
        'TextBox_Apellido
        '
        Me.TextBox_Apellido.Location = New System.Drawing.Point(446, 147)
        Me.TextBox_Apellido.MaxLength = 50
        Me.TextBox_Apellido.Name = "TextBox_Apellido"
        Me.TextBox_Apellido.Size = New System.Drawing.Size(358, 27)
        Me.TextBox_Apellido.TabIndex = 1
        '
        'TextBox_CI
        '
        Me.TextBox_CI.Location = New System.Drawing.Point(82, 204)
        Me.TextBox_CI.MaxLength = 50
        Me.TextBox_CI.Name = "TextBox_CI"
        Me.TextBox_CI.Size = New System.Drawing.Size(182, 27)
        Me.TextBox_CI.TabIndex = 2
        '
        'Bot_Guardar
        '
        Me.Bot_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bot_Guardar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_Guardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Guardar.FlatAppearance.BorderSize = 0
        Me.Bot_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Guardar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Guardar.Location = New System.Drawing.Point(845, 99)
        Me.Bot_Guardar.Name = "Bot_Guardar"
        Me.Bot_Guardar.Size = New System.Drawing.Size(97, 31)
        Me.Bot_Guardar.TabIndex = 7
        Me.Bot_Guardar.Text = "Guardar"
        Me.Bot_Guardar.UseVisualStyleBackColor = False
        '
        'Label_Titulo
        '
        Me.Label_Titulo.AutoSize = True
        Me.Label_Titulo.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Titulo.Location = New System.Drawing.Point(12, 9)
        Me.Label_Titulo.Name = "Label_Titulo"
        Me.Label_Titulo.Size = New System.Drawing.Size(241, 36)
        Me.Label_Titulo.TabIndex = 44
        Me.Label_Titulo.Text = "Agregar Usuario"
        '
        'Form_AgregarModificarUsuarios
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1004, 690)
        Me.Controls.Add(Me.Bot_Volver)
        Me.Controls.Add(Me.Bot_Cancelar)
        Me.Controls.Add(Me.Bot_Guardar)
        Me.Controls.Add(Me.TextBox_ConfirmarContraseña)
        Me.Controls.Add(Me.TextBox_Direccion)
        Me.Controls.Add(Me.TextBox_Contraseña)
        Me.Controls.Add(Me.TextBox_Telefono)
        Me.Controls.Add(Me.TextBox_Nombre)
        Me.Controls.Add(Me.TextBox_CI)
        Me.Controls.Add(Me.TextBox_Apellido)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label_Titulo)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_AgregarModificarUsuarios"
        Me.Text = "Form_AgregarUsuarios"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Bot_Volver As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Direccion As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Telefono As System.Windows.Forms.TextBox
    Friend WithEvents Bot_Cancelar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Bot_Ver2 As System.Windows.Forms.Button
    Friend WithEvents Bot_Ver As System.Windows.Forms.Button
    Friend WithEvents TextBox_ConfirmarContraseña As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Contraseña As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Apellido As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_CI As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Bot_Guardar As System.Windows.Forms.Button
    Friend WithEvents Label_Titulo As System.Windows.Forms.Label
    Friend WithEvents Label_Contraseña As System.Windows.Forms.Label
End Class
