Public Class Form_MainScreen

    Private Sub Form_MainScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Enabled = True
        ActualizarTabla(DataGridView_Sucta, "SELECT Camiones.idcamion AS [Vehículo], DateDiff('d',DATE(),Camiones.SuctaHasta) AS [Días para próximo SUCTA], (10000 - Camiones.KMAceite) As [KM para cambio de Aceite] FROM Camiones WHERE Camiones.Estado=1", CS)
        If DataGridView_Sucta.Rows.Count > 0 Then
            DataGridView_Sucta.Columns(0).Width = 85
        End If
        Estadisticas()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label_Hora.Text = DateTime.Now.ToString("HH:mm")
        Label_Fecha.Text = DateTime.Now.ToString("d")
    End Sub

    Private Sub Bot_Sucta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Sucta.Click
        AbrirFormInPanel(New Form_VencimientosSucta, Form_MenuPrincipal.Panel_AreaDeTrabajo)
        Form_MenuPrincipal.Panel_Seleccionado.Top = Form_MenuPrincipal.Bot_Sucta.Top
    End Sub

    Private Sub Bot_Aceite_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Bot_Aceite.Click
        AbrirFormInPanel(New Form_BuscarVehiculos, Form_MenuPrincipal.Panel_AreaDeTrabajo)
        Form_MenuPrincipal.Panel_Seleccionado.Top = Form_MenuPrincipal.Bot_Vehiculos.Top
    End Sub

#Region "MODIFICACIONES ESTETICAS"

    Private Sub DataGridView_Sucta_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView_Sucta.CellFormatting
        'Me.DataGridView_Sucta.ColumnHeadersDefaultCellStyle.Font = New Font("Century Gothic", 8, FontStyle.Regular)
        DataGridView_Sucta.Columns(1).HeaderCell.Style.Font = New Font("Century Gothic", 8, FontStyle.Regular)
        DataGridView_Sucta.Columns(2).HeaderCell.Style.Font = New Font("Century Gothic", 8, FontStyle.Regular)

        For Each Row As DataGridViewRow In DataGridView_Sucta.Rows
            'Colores SUCTA.-
            If Val(Row.Cells(2).Value) <= 50 And Val(Row.Cells(1).Value) > 0 Then
                Row.Cells(1).Style.BackColor = Color.MediumSeaGreen
                Row.Cells(1).Style.ForeColor = Color.White
            ElseIf Val(Row.Cells(2).Value) <= 0 Then
                Row.Cells(1).Style.BackColor = Color.Firebrick
                Row.Cells(1).Style.ForeColor = Color.White
            Else
                Row.Cells(1).Style.BackColor = Color.White
                Row.Cells(1).Style.ForeColor = Color.Black
            End If
            'Colores Aceite.-
            If Val(Row.Cells(2).Value) > 0 And Val(Row.Cells(2).Value) <= 1000 Then
                Row.Cells(2).Style.BackColor = Color.MediumSeaGreen
                Row.Cells(2).Style.ForeColor = Color.White
            ElseIf Val(Row.Cells(2).Value) < 0 Then
                Row.Cells(2).Style.BackColor = Color.Firebrick
                Row.Cells(2).Style.ForeColor = Color.White
            Else
                Row.Cells(2).Style.BackColor = Color.White
                Row.Cells(2).Style.ForeColor = Color.Black
            End If
        Next
    End Sub

    Private Sub Form_MainScreen_SizeChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Me.SizeChanged
        GroupBox_Estadisticas.Top = (Me.ClientSize.Height / 2) - ((GroupBox_Estadisticas.Height + Panel_FechaHora.Height) / 2)
        GroupBox_Estadisticas.Left = ((Me.ClientSize.Width / 4) * 3) - (GroupBox_Estadisticas.Width / 2)
        Panel_FechaHora.Top = GroupBox_Estadisticas.Bottom + 4
        Panel_FechaHora.Left = GroupBox_Estadisticas.Left
        GroupBox_Sucta.Height = PictureBoxSplit.Height
        GroupBox_Sucta.Width = PictureBoxSplit.Right - GroupBox_Sucta.Left - 64
    End Sub

#End Region

#Region "ESTADISTICAS"

    Sub Estadisticas()
        Dim ObjBD As New ClaseBD
        If ObjBD.Consulta("SELECT Count(Camiones.idcamion) AS CantCamion FROM Camiones WHERE Camiones.Estado=1;") = True Then
            Label_DatoCamion.Text = DatosConsulta.Rows(0).Item("CantCamion")
        End If
        If ObjBD.Consulta("SELECT Count(OrdenesCD.IdOrden) AS CantOrden FROM OrdenesCD WHERE OrdenesCD.Estado=1;") = True Then
            Label_DatoOrdenes.Text = DatosConsulta.Rows(0).Item("CantOrden")
        End If
        If ObjBD.Consulta("SELECT Count(Clientes.IdCliente) AS CantCliente FROM Clientes WHERE Clientes.Estado=1;") = True Then
            Label_DatoClientes.Text = DatosConsulta.Rows(0).Item("CantCliente")
        End If
        If ObjBD.Consulta("SELECT Count(Lugares.IdLugar) AS CantLugar FROM Lugares WHERE Lugares.Estado=1;") = True Then
            Label_DatoLugares.Text = DatosConsulta.Rows(0).Item("CantLugar")
        End If
        If ObjBD.Consulta("SELECT Count(TiposCargas.idcarga) AS CantCarga FROM TiposCargas WHERE TiposCargas.Estado=1;") = True Then
            Label_DatoTiposCarga.Text = DatosConsulta.Rows(0).Item("CantCarga")
        End If
        If ObjBD.Consulta("SELECT Count(Usuarios.IdUsuario) AS CantUsuario FROM Usuarios WHERE Usuarios.Estado=1;") = True Then
            Label_DatosUsuario.Text = DatosConsulta.Rows(0).Item("CantUsuario")
        End If
    End Sub

    Private Sub Panel_Clientes_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Panel_Clientes.Click, Panel_Clientes2.Click, PictureBox_Clientes.Click, Label_DatoClientes.Click, Label_DesClientes.Click
        AbrirFormInPanel(Form_BuscarClientes, Form_MenuPrincipal.Panel_AreaDeTrabajo)
        Form_MenuPrincipal.Panel_Seleccionado.Top = Form_MenuPrincipal.Bot_Clientes.Top
    End Sub

    Private Sub Panel_Lugares_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Panel_Lugares.Click, Panel_Lugares2.Click, PictureBox_Lugares.Click, Label_DatoLugares.Click, Label_DesLugares.Click
        AbrirFormInPanel(Form_LugaesDeCarga, Form_MenuPrincipal.Panel_AreaDeTrabajo)
        Form_MenuPrincipal.Panel_Seleccionado.Top = Form_MenuPrincipal.Bot_LugaresCarga.Top
    End Sub

    Private Sub Panel_Ordenes_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Panel_Ordenes.Click, Panel_Ordenes2.Click, PictureBox_Ordenes.Click, Label_DatoOrdenes.Click, Label_DesOrdenes.Click
        AbrirFormInPanel(Form_OrdenCargaDescarga, Form_MenuPrincipal.Panel_AreaDeTrabajo)
        Form_MenuPrincipal.Panel_Seleccionado.Top = Form_MenuPrincipal.Bot_OrdenesCD.Top
    End Sub

    Private Sub Panel_TiposCarga_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Panel_TiposCarga.Click, Panel_Cargas2.Click, PictureBox_TiposCarga.Click, Label_DatoTiposCarga.Click, Label_DesCargas.Click
        AbrirFormInPanel(Form_TiposDeCarga, Form_MenuPrincipal.Panel_AreaDeTrabajo)
        Form_MenuPrincipal.Panel_Seleccionado.Top = Form_MenuPrincipal.Bot_TiposCarga.Top
    End Sub

    Private Sub Panel_Usuarios_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Panel_Usuarios.Click, Panel_Usuarios2.Click, PictureBox_Usuario.Click, Label_DatosUsuario.Click, Label_DesUsuarios.Click
        AbrirFormInPanel(Form_BuscarUsuarios, Form_MenuPrincipal.Panel_AreaDeTrabajo)
        Form_MenuPrincipal.Panel_Seleccionado.Top = Form_MenuPrincipal.Bot_Usuarios.Top
    End Sub

    Private Sub Panel_Vehiculos_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Panel_Vehiculos.Click, Panel_Vehiculos2.Click, PictureBox_Vehiculos.Click, Label_DatoCamion.Click, Label_DesVehiculo.Click
        AbrirFormInPanel(Form_BuscarVehiculos, Form_MenuPrincipal.Panel_AreaDeTrabajo)
        Form_MenuPrincipal.Panel_Seleccionado.Top = Form_MenuPrincipal.Bot_Vehiculos.Top
    End Sub

    Private Sub EstadisticasTextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Label_DatoCamion.TextChanged, Label_DatoClientes.TextChanged, Label_DatoLugares.TextChanged, Label_DatoOrdenes.TextChanged, Label_DatosUsuario.TextChanged, Label_DatoTiposCarga.TextChanged
        If Val(sender.Text) > 9999 Then
            sender.Text = "9999"
        End If
    End Sub

#End Region

End Class