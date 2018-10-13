<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_RespaldoInformacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_RespaldoInformacion))
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Bot_Borrar = New System.Windows.Forms.Button()
        Me.Bot_Zip = New System.Windows.Forms.Button()
        Me.Bot_Drive = New System.Windows.Forms.Button()
        Me.DataGridView_Respaldos = New System.Windows.Forms.DataGridView()
        Me.WMTextBox_Buscar = New Transportes.WatermarkTextBox()
        CType(Me.DataGridView_Respaldos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(12, 12)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(63, 31)
        Me.Button5.TabIndex = 63
        Me.Button5.TabStop = False
        Me.Button5.Text = "GUIA"
        Me.Button5.UseVisualStyleBackColor = False
        Me.Button5.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(88, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(370, 36)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Respaldo de Información"
        '
        'Bot_Borrar
        '
        Me.Bot_Borrar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_Borrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Borrar.FlatAppearance.BorderSize = 0
        Me.Bot_Borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Borrar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Borrar.Location = New System.Drawing.Point(631, 112)
        Me.Bot_Borrar.Name = "Bot_Borrar"
        Me.Bot_Borrar.Size = New System.Drawing.Size(97, 31)
        Me.Bot_Borrar.TabIndex = 64
        Me.Bot_Borrar.Text = "Borrar"
        Me.Bot_Borrar.UseVisualStyleBackColor = False
        '
        'Bot_Zip
        '
        Me.Bot_Zip.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bot_Zip.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_Zip.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Zip.FlatAppearance.BorderSize = 0
        Me.Bot_Zip.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Zip.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Zip.Image = CType(resources.GetObject("Bot_Zip.Image"), System.Drawing.Image)
        Me.Bot_Zip.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Bot_Zip.Location = New System.Drawing.Point(631, 216)
        Me.Bot_Zip.Name = "Bot_Zip"
        Me.Bot_Zip.Size = New System.Drawing.Size(164, 48)
        Me.Bot_Zip.TabIndex = 66
        Me.Bot_Zip.Tag = "Ver"
        Me.Bot_Zip.Text = "Crear Archivo Comprimido"
        Me.Bot_Zip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Bot_Zip.UseVisualStyleBackColor = False
        '
        'Bot_Drive
        '
        Me.Bot_Drive.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bot_Drive.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_Drive.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Drive.FlatAppearance.BorderSize = 0
        Me.Bot_Drive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Drive.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Drive.Image = CType(resources.GetObject("Bot_Drive.Image"), System.Drawing.Image)
        Me.Bot_Drive.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Bot_Drive.Location = New System.Drawing.Point(631, 162)
        Me.Bot_Drive.Name = "Bot_Drive"
        Me.Bot_Drive.Size = New System.Drawing.Size(164, 48)
        Me.Bot_Drive.TabIndex = 65
        Me.Bot_Drive.Tag = "Actualizar"
        Me.Bot_Drive.Text = "Crear con Google Drive"
        Me.Bot_Drive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Bot_Drive.UseVisualStyleBackColor = False
        '
        'DataGridView_Respaldos
        '
        Me.DataGridView_Respaldos.AllowUserToAddRows = False
        Me.DataGridView_Respaldos.AllowUserToDeleteRows = False
        Me.DataGridView_Respaldos.AllowUserToResizeRows = False
        Me.DataGridView_Respaldos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_Respaldos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_Respaldos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DataGridView_Respaldos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Respaldos.Location = New System.Drawing.Point(143, 162)
        Me.DataGridView_Respaldos.MultiSelect = False
        Me.DataGridView_Respaldos.Name = "DataGridView_Respaldos"
        Me.DataGridView_Respaldos.ReadOnly = True
        Me.DataGridView_Respaldos.RowHeadersWidth = 30
        Me.DataGridView_Respaldos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Respaldos.Size = New System.Drawing.Size(482, 446)
        Me.DataGridView_Respaldos.TabIndex = 67
        '
        'WMTextBox_Buscar
        '
        Me.WMTextBox_Buscar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WMTextBox_Buscar.Location = New System.Drawing.Point(143, 114)
        Me.WMTextBox_Buscar.Name = "WMTextBox_Buscar"
        Me.WMTextBox_Buscar.Size = New System.Drawing.Size(482, 27)
        Me.WMTextBox_Buscar.TabIndex = 60
        Me.WMTextBox_Buscar.WaterMarkColor = System.Drawing.Color.Gray
        Me.WMTextBox_Buscar.WaterMarkText = "Buscar Respaldos por Usuarios"
        '
        'Form_RespaldoInformacion
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1004, 690)
        Me.Controls.Add(Me.Bot_Zip)
        Me.Controls.Add(Me.Bot_Drive)
        Me.Controls.Add(Me.DataGridView_Respaldos)
        Me.Controls.Add(Me.Bot_Borrar)
        Me.Controls.Add(Me.WMTextBox_Buscar)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_RespaldoInformacion"
        Me.Text = "Form_RespaldoInformacion"
        CType(Me.DataGridView_Respaldos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WMTextBox_Buscar As WatermarkTextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Bot_Borrar As Button
    Friend WithEvents Bot_Zip As Button
    Friend WithEvents Bot_Drive As Button
    Friend WithEvents DataGridView_Respaldos As DataGridView
End Class
