<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_BuscarUsuarios
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
        Me.Bot_Eliminar = New System.Windows.Forms.Button()
        Me.Bot_Modificar = New System.Windows.Forms.Button()
        Me.Bot_Agregar = New System.Windows.Forms.Button()
        Me.Bot_Borrar = New System.Windows.Forms.Button()
        Me.DataGridView_Usuarios = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Bot_Ver = New System.Windows.Forms.Button()
        Me.WMTextBox_Buscar = New Transportes.WatermarkTextBox()
        CType(Me.DataGridView_Usuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bot_Eliminar
        '
        Me.Bot_Eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bot_Eliminar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Eliminar.FlatAppearance.BorderSize = 0
        Me.Bot_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Eliminar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Eliminar.Location = New System.Drawing.Point(845, 173)
        Me.Bot_Eliminar.Name = "Bot_Eliminar"
        Me.Bot_Eliminar.Size = New System.Drawing.Size(97, 31)
        Me.Bot_Eliminar.TabIndex = 5
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
        Me.Bot_Modificar.Location = New System.Drawing.Point(845, 136)
        Me.Bot_Modificar.Name = "Bot_Modificar"
        Me.Bot_Modificar.Size = New System.Drawing.Size(97, 31)
        Me.Bot_Modificar.TabIndex = 4
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
        Me.Bot_Agregar.Location = New System.Drawing.Point(845, 99)
        Me.Bot_Agregar.Name = "Bot_Agregar"
        Me.Bot_Agregar.Size = New System.Drawing.Size(97, 31)
        Me.Bot_Agregar.TabIndex = 3
        Me.Bot_Agregar.Text = "Agregar"
        Me.Bot_Agregar.UseVisualStyleBackColor = False
        '
        'Bot_Borrar
        '
        Me.Bot_Borrar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_Borrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Borrar.FlatAppearance.BorderSize = 0
        Me.Bot_Borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Borrar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Borrar.Location = New System.Drawing.Point(556, 64)
        Me.Bot_Borrar.Name = "Bot_Borrar"
        Me.Bot_Borrar.Size = New System.Drawing.Size(97, 31)
        Me.Bot_Borrar.TabIndex = 1
        Me.Bot_Borrar.Text = "Borrar"
        Me.Bot_Borrar.UseVisualStyleBackColor = False
        '
        'DataGridView_Usuarios
        '
        Me.DataGridView_Usuarios.AllowUserToAddRows = False
        Me.DataGridView_Usuarios.AllowUserToDeleteRows = False
        Me.DataGridView_Usuarios.AllowUserToResizeRows = False
        Me.DataGridView_Usuarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_Usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_Usuarios.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DataGridView_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Usuarios.Location = New System.Drawing.Point(68, 99)
        Me.DataGridView_Usuarios.MultiSelect = False
        Me.DataGridView_Usuarios.Name = "DataGridView_Usuarios"
        Me.DataGridView_Usuarios.ReadOnly = True
        Me.DataGridView_Usuarios.RowHeadersWidth = 30
        Me.DataGridView_Usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Usuarios.Size = New System.Drawing.Size(771, 579)
        Me.DataGridView_Usuarios.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(325, 36)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Búsqueda de Usuarios"
        '
        'Bot_Ver
        '
        Me.Bot_Ver.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bot_Ver.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_Ver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Ver.FlatAppearance.BorderSize = 0
        Me.Bot_Ver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Ver.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Ver.Location = New System.Drawing.Point(845, 210)
        Me.Bot_Ver.Name = "Bot_Ver"
        Me.Bot_Ver.Size = New System.Drawing.Size(97, 31)
        Me.Bot_Ver.TabIndex = 6
        Me.Bot_Ver.Text = "Ver Datos"
        Me.Bot_Ver.UseVisualStyleBackColor = False
        '
        'WMTextBox_Buscar
        '
        Me.WMTextBox_Buscar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WMTextBox_Buscar.Location = New System.Drawing.Point(68, 66)
        Me.WMTextBox_Buscar.Name = "WMTextBox_Buscar"
        Me.WMTextBox_Buscar.Size = New System.Drawing.Size(482, 27)
        Me.WMTextBox_Buscar.TabIndex = 0
        Me.WMTextBox_Buscar.WaterMarkColor = System.Drawing.Color.Gray
        Me.WMTextBox_Buscar.WaterMarkText = "Buscar Usuarios por Nombre, Apellido o CI"
        '
        'Form_BuscarUsuarios
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1004, 690)
        Me.Controls.Add(Me.WMTextBox_Buscar)
        Me.Controls.Add(Me.Bot_Ver)
        Me.Controls.Add(Me.Bot_Eliminar)
        Me.Controls.Add(Me.Bot_Modificar)
        Me.Controls.Add(Me.Bot_Agregar)
        Me.Controls.Add(Me.Bot_Borrar)
        Me.Controls.Add(Me.DataGridView_Usuarios)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_BuscarUsuarios"
        Me.Text = "Form_BuscarUsuarios"
        CType(Me.DataGridView_Usuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Bot_Eliminar As System.Windows.Forms.Button
    Friend WithEvents Bot_Modificar As System.Windows.Forms.Button
    Friend WithEvents Bot_Agregar As System.Windows.Forms.Button
    Friend WithEvents Bot_Borrar As System.Windows.Forms.Button
    Friend WithEvents DataGridView_Usuarios As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Bot_Ver As System.Windows.Forms.Button
    Friend WithEvents WMTextBox_Buscar As Transportes.WatermarkTextBox
End Class
