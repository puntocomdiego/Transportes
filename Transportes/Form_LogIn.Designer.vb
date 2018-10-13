<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_LogIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_LogIn))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_Nombre = New System.Windows.Forms.TextBox()
        Me.TextBox_Contraseña = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Bot_Ingresar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Bot_Salir = New System.Windows.Forms.Button()
        Me.PictureBox_FotoUser = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Bot_Ver = New System.Windows.Forms.Button()
        Me.Panel_Info = New System.Windows.Forms.Panel()
        Me.Label_Version = New System.Windows.Forms.Label()
        Me.Bot_Borrar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_FotoUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Info.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 36)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Iniciar Sesión"
        '
        'TextBox_Nombre
        '
        Me.TextBox_Nombre.Location = New System.Drawing.Point(68, 93)
        Me.TextBox_Nombre.Name = "TextBox_Nombre"
        Me.TextBox_Nombre.Size = New System.Drawing.Size(193, 27)
        Me.TextBox_Nombre.TabIndex = 0
        '
        'TextBox_Contraseña
        '
        Me.TextBox_Contraseña.Location = New System.Drawing.Point(68, 152)
        Me.TextBox_Contraseña.Name = "TextBox_Contraseña"
        Me.TextBox_Contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox_Contraseña.Size = New System.Drawing.Size(193, 27)
        Me.TextBox_Contraseña.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 19)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Nombre o CI"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(64, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 19)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Contraseña"
        '
        'Bot_Ingresar
        '
        Me.Bot_Ingresar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_Ingresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Ingresar.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_Ingresar.FlatAppearance.BorderSize = 0
        Me.Bot_Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Ingresar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Ingresar.Location = New System.Drawing.Point(217, 188)
        Me.Bot_Ingresar.Name = "Bot_Ingresar"
        Me.Bot_Ingresar.Size = New System.Drawing.Size(85, 31)
        Me.Bot_Ingresar.TabIndex = 2
        Me.Bot_Ingresar.Text = "Ingresar"
        Me.Bot_Ingresar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Bot_Salir)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(311, 61)
        Me.Panel1.TabIndex = 15
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 10)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'Bot_Salir
        '
        Me.Bot_Salir.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_Salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Bot_Salir.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_Salir.FlatAppearance.BorderSize = 0
        Me.Bot_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Salir.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Salir.Location = New System.Drawing.Point(295, -5)
        Me.Bot_Salir.Name = "Bot_Salir"
        Me.Bot_Salir.Size = New System.Drawing.Size(17, 24)
        Me.Bot_Salir.TabIndex = 5
        Me.Bot_Salir.Text = "x"
        Me.Bot_Salir.UseVisualStyleBackColor = False
        '
        'PictureBox_FotoUser
        '
        Me.PictureBox_FotoUser.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox_FotoUser.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.PictureBox_FotoUser.Image = CType(resources.GetObject("PictureBox_FotoUser.Image"), System.Drawing.Image)
        Me.PictureBox_FotoUser.Location = New System.Drawing.Point(12, 71)
        Me.PictureBox_FotoUser.Name = "PictureBox_FotoUser"
        Me.PictureBox_FotoUser.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox_FotoUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox_FotoUser.TabIndex = 17
        Me.PictureBox_FotoUser.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 130)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'Bot_Ver
        '
        Me.Bot_Ver.BackColor = System.Drawing.SystemColors.Control
        Me.Bot_Ver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Ver.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Bot_Ver.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Bot_Ver.FlatAppearance.BorderSize = 0
        Me.Bot_Ver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Ver.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Ver.Image = CType(resources.GetObject("Bot_Ver.Image"), System.Drawing.Image)
        Me.Bot_Ver.Location = New System.Drawing.Point(264, 152)
        Me.Bot_Ver.Name = "Bot_Ver"
        Me.Bot_Ver.Size = New System.Drawing.Size(27, 27)
        Me.Bot_Ver.TabIndex = 4
        Me.Bot_Ver.UseVisualStyleBackColor = False
        '
        'Panel_Info
        '
        Me.Panel_Info.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Panel_Info.Controls.Add(Me.Label_Version)
        Me.Panel_Info.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_Info.Location = New System.Drawing.Point(0, 228)
        Me.Panel_Info.Name = "Panel_Info"
        Me.Panel_Info.Size = New System.Drawing.Size(311, 22)
        Me.Panel_Info.TabIndex = 22
        '
        'Label_Version
        '
        Me.Label_Version.AutoSize = True
        Me.Label_Version.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Version.Location = New System.Drawing.Point(3, 2)
        Me.Label_Version.Name = "Label_Version"
        Me.Label_Version.Size = New System.Drawing.Size(43, 18)
        Me.Label_Version.TabIndex = 23
        Me.Label_Version.Text = "vXXX"
        '
        'Bot_Borrar
        '
        Me.Bot_Borrar.BackColor = System.Drawing.SystemColors.Control
        Me.Bot_Borrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Borrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Bot_Borrar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Bot_Borrar.FlatAppearance.BorderSize = 0
        Me.Bot_Borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Borrar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Borrar.Location = New System.Drawing.Point(264, 93)
        Me.Bot_Borrar.Name = "Bot_Borrar"
        Me.Bot_Borrar.Size = New System.Drawing.Size(27, 27)
        Me.Bot_Borrar.TabIndex = 3
        Me.Bot_Borrar.Text = "X"
        Me.Bot_Borrar.UseVisualStyleBackColor = False
        '
        'Form_LogIn
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.CancelButton = Me.Bot_Salir
        Me.ClientSize = New System.Drawing.Size(311, 250)
        Me.Controls.Add(Me.Bot_Borrar)
        Me.Controls.Add(Me.Panel_Info)
        Me.Controls.Add(Me.Bot_Ver)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox_FotoUser)
        Me.Controls.Add(Me.Bot_Ingresar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox_Contraseña)
        Me.Controls.Add(Me.TextBox_Nombre)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_LogIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transportes - LogIn"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_FotoUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Info.ResumeLayout(False)
        Me.Panel_Info.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_Nombre As TextBox
    Friend WithEvents TextBox_Contraseña As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Bot_Ingresar As Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Bot_Salir As System.Windows.Forms.Button
    Friend WithEvents PictureBox_FotoUser As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Bot_Ver As System.Windows.Forms.Button
    Friend WithEvents Panel_Info As System.Windows.Forms.Panel
    Friend WithEvents Label_Version As System.Windows.Forms.Label
    Friend WithEvents Bot_Borrar As System.Windows.Forms.Button
End Class
