<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_TiposDeCarga
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Bot_Cancelar = New System.Windows.Forms.Button()
        Me.TextBox_Cargas = New System.Windows.Forms.TextBox()
        Me.Bot_Guardar = New System.Windows.Forms.Button()
        Me.Label_Accion = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel_Busqueda = New System.Windows.Forms.Panel()
        Me.WMTextBox_Buscar = New Transportes.WatermarkTextBox()
        Me.Bot_Eliminar = New System.Windows.Forms.Button()
        Me.Bot_Borrar = New System.Windows.Forms.Button()
        Me.Bot_Agregar = New System.Windows.Forms.Button()
        Me.Bot_Modificar = New System.Windows.Forms.Button()
        Me.DataGridView_Cargas = New System.Windows.Forms.DataGridView()
        Me.Panel_Accion.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Busqueda.SuspendLayout()
        CType(Me.DataGridView_Cargas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_Accion
        '
        Me.Panel_Accion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Accion.Controls.Add(Me.Label5)
        Me.Panel_Accion.Controls.Add(Me.Bot_Cancelar)
        Me.Panel_Accion.Controls.Add(Me.TextBox_Cargas)
        Me.Panel_Accion.Controls.Add(Me.Bot_Guardar)
        Me.Panel_Accion.Controls.Add(Me.Label_Accion)
        Me.Panel_Accion.Controls.Add(Me.PictureBox2)
        Me.Panel_Accion.Controls.Add(Me.PictureBox1)
        Me.Panel_Accion.Location = New System.Drawing.Point(644, 93)
        Me.Panel_Accion.Name = "Panel_Accion"
        Me.Panel_Accion.Size = New System.Drawing.Size(291, 161)
        Me.Panel_Accion.TabIndex = 41
        Me.Panel_Accion.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 21)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Tipo de Carga"
        '
        'Bot_Cancelar
        '
        Me.Bot_Cancelar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Cancelar.FlatAppearance.BorderSize = 0
        Me.Bot_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Cancelar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Cancelar.Location = New System.Drawing.Point(75, 112)
        Me.Bot_Cancelar.Name = "Bot_Cancelar"
        Me.Bot_Cancelar.Size = New System.Drawing.Size(97, 31)
        Me.Bot_Cancelar.TabIndex = 2
        Me.Bot_Cancelar.Text = "Cancelar"
        Me.Bot_Cancelar.UseVisualStyleBackColor = False
        '
        'TextBox_Cargas
        '
        Me.TextBox_Cargas.Location = New System.Drawing.Point(17, 79)
        Me.TextBox_Cargas.MaxLength = 255
        Me.TextBox_Cargas.Name = "TextBox_Cargas"
        Me.TextBox_Cargas.Size = New System.Drawing.Size(258, 27)
        Me.TextBox_Cargas.TabIndex = 0
        '
        'Bot_Guardar
        '
        Me.Bot_Guardar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_Guardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Guardar.FlatAppearance.BorderSize = 0
        Me.Bot_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Guardar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Guardar.Location = New System.Drawing.Point(178, 112)
        Me.Bot_Guardar.Name = "Bot_Guardar"
        Me.Bot_Guardar.Size = New System.Drawing.Size(97, 31)
        Me.Bot_Guardar.TabIndex = 1
        Me.Bot_Guardar.Text = "Guardar"
        Me.Bot_Guardar.UseVisualStyleBackColor = False
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
        Me.PictureBox2.Size = New System.Drawing.Size(282, 144)
        Me.PictureBox2.TabIndex = 30
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.PictureBox1.Location = New System.Drawing.Point(1, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(290, 152)
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 36)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Tipos de Carga"
        '
        'Panel_Busqueda
        '
        Me.Panel_Busqueda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Busqueda.Controls.Add(Me.WMTextBox_Buscar)
        Me.Panel_Busqueda.Controls.Add(Me.Bot_Eliminar)
        Me.Panel_Busqueda.Controls.Add(Me.Bot_Borrar)
        Me.Panel_Busqueda.Controls.Add(Me.Bot_Agregar)
        Me.Panel_Busqueda.Controls.Add(Me.Bot_Modificar)
        Me.Panel_Busqueda.Controls.Add(Me.DataGridView_Cargas)
        Me.Panel_Busqueda.Location = New System.Drawing.Point(66, 64)
        Me.Panel_Busqueda.Name = "Panel_Busqueda"
        Me.Panel_Busqueda.Size = New System.Drawing.Size(572, 614)
        Me.Panel_Busqueda.TabIndex = 43
        '
        'WMTextBox_Buscar
        '
        Me.WMTextBox_Buscar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WMTextBox_Buscar.Location = New System.Drawing.Point(3, 3)
        Me.WMTextBox_Buscar.Name = "WMTextBox_Buscar"
        Me.WMTextBox_Buscar.Size = New System.Drawing.Size(274, 27)
        Me.WMTextBox_Buscar.TabIndex = 0
        Me.WMTextBox_Buscar.WaterMarkColor = System.Drawing.Color.Gray
        Me.WMTextBox_Buscar.WaterMarkText = "Buscar por Carga"
        '
        'Bot_Eliminar
        '
        Me.Bot_Eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bot_Eliminar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Eliminar.FlatAppearance.BorderSize = 0
        Me.Bot_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Eliminar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Eliminar.Location = New System.Drawing.Point(472, 110)
        Me.Bot_Eliminar.Name = "Bot_Eliminar"
        Me.Bot_Eliminar.Size = New System.Drawing.Size(97, 31)
        Me.Bot_Eliminar.TabIndex = 5
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
        'Bot_Agregar
        '
        Me.Bot_Agregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bot_Agregar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Bot_Agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_Agregar.FlatAppearance.BorderSize = 0
        Me.Bot_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Agregar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Agregar.Location = New System.Drawing.Point(472, 36)
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
        Me.Bot_Modificar.Location = New System.Drawing.Point(472, 73)
        Me.Bot_Modificar.Name = "Bot_Modificar"
        Me.Bot_Modificar.Size = New System.Drawing.Size(97, 31)
        Me.Bot_Modificar.TabIndex = 4
        Me.Bot_Modificar.Tag = "Modificar"
        Me.Bot_Modificar.Text = "Modificar"
        Me.Bot_Modificar.UseVisualStyleBackColor = False
        '
        'DataGridView_Cargas
        '
        Me.DataGridView_Cargas.AllowUserToAddRows = False
        Me.DataGridView_Cargas.AllowUserToDeleteRows = False
        Me.DataGridView_Cargas.AllowUserToResizeRows = False
        Me.DataGridView_Cargas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_Cargas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_Cargas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DataGridView_Cargas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Cargas.Location = New System.Drawing.Point(3, 36)
        Me.DataGridView_Cargas.MultiSelect = False
        Me.DataGridView_Cargas.Name = "DataGridView_Cargas"
        Me.DataGridView_Cargas.ReadOnly = True
        Me.DataGridView_Cargas.RowHeadersWidth = 30
        Me.DataGridView_Cargas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Cargas.Size = New System.Drawing.Size(463, 573)
        Me.DataGridView_Cargas.TabIndex = 2
        '
        'Form_TiposDeCarga
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1004, 690)
        Me.Controls.Add(Me.Panel_Accion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel_Busqueda)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_TiposDeCarga"
        Me.Text = "Form_TiposDeCarga"
        Me.Panel_Accion.ResumeLayout(False)
        Me.Panel_Accion.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Busqueda.ResumeLayout(False)
        Me.Panel_Busqueda.PerformLayout()
        CType(Me.DataGridView_Cargas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel_Accion As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Bot_Cancelar As System.Windows.Forms.Button
    Friend WithEvents TextBox_Cargas As System.Windows.Forms.TextBox
    Friend WithEvents Bot_Guardar As System.Windows.Forms.Button
    Friend WithEvents Label_Accion As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel_Busqueda As System.Windows.Forms.Panel
    Friend WithEvents Bot_Eliminar As System.Windows.Forms.Button
    Friend WithEvents Bot_Borrar As System.Windows.Forms.Button
    Friend WithEvents Bot_Agregar As System.Windows.Forms.Button
    Friend WithEvents Bot_Modificar As System.Windows.Forms.Button
    Friend WithEvents WMTextBox_Buscar As Transportes.WatermarkTextBox
    Friend WithEvents DataGridView_Cargas As System.Windows.Forms.DataGridView
End Class
