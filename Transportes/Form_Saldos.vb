Public Class Form_Saldos
    Dim BusquedaEstado As String 'Guarda el estado de pago (Debe/Pago).-
    Dim TotalOrdenes As Integer 'Guarda la suma de los totales.-

    Private Sub Form_Saldos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BusquedaClientes()
        Panel_Cliente.Location = Panel_Entrega.Location
        Panel_Orden.Location = Panel_Entrega.Location
        If Me.Tag = "1" Then 'Si viene desde Buscar Clientes.-
            Me.Panel_Cliente.Visible = False
            Me.Panel_Orden.Visible = True
            Radio_Debe.Checked = True
            IDS(0) = CampoClaveInt
            Label_Accion.Text = "Cliente: " & CampoClaveStr
            BusquedaOrdenes()
            Label_Titulo.Text = "Seleccione una Orden"
            WMTextBox_BuscarOrden.Focus()
            Exit Sub
        End If
        Label_Accion.Text = ""
        WMTextBox_BuscarCliente.Focus()
    End Sub

    'Botones de Volver, ambos vuelven a la tabla de Clientes.-
    Private Sub Bot_VolverACliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_VolverACliente.Click, Bot_Volver.Click
        'Si viene desde la ventana de Clientes.-
        If Me.Tag = "1" Then
            Me.Close()
            Exit Sub
        End If

        'Sino.-
        Me.Panel_Entrega.Visible = False
        Me.Panel_Orden.Visible = False
        Me.Panel_Cliente.Visible = True
        WMTextBox_BuscarEntrega.Text = ""
        WMTextBox_BuscarOrden.Text = ""
        WMTextBox_BuscarCliente.Text = ""
        TextBox_SaldoOrden.Text = ""
        TextBox_SaldoTotal.Text = ""
        TextBox_MontoOrden.Text = ""
        Label_Titulo.Text = "Seleccione un Cliente"
        Label_Accion.Text = ""
        WMTextBox_BuscarCliente.Focus()
    End Sub

#Region "B0TONES ABMV"

    Private Sub Bot_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Agregar.Click
        AbrirSegundoInPanel(New Form_AgregarModificarEntregaSaldo, Form_MenuPrincipal.Panel_AreaDeTrabajo, "1")
    End Sub

    Private Sub Bot_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Modificar.Click
        If DataGridView_Entregas.SelectedRows.Count > 0 Then
            AbrirSegundoInPanel(New Form_AgregarModificarEntregaSaldo, Form_MenuPrincipal.Panel_AreaDeTrabajo, "2")
        Else
            MsgBox("Debe seleccionar una Entrega para modificarla", MsgBoxStyle.Information, "¡Atención!")
            Exit Sub
        End If
    End Sub

    Private Sub Bot_Ver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_VerDatos.Click
        If DataGridView_Entregas.SelectedRows.Count > 0 Then
            AbrirSegundoInPanel(New Form_AgregarModificarEntregaSaldo, Form_MenuPrincipal.Panel_AreaDeTrabajo, "3")
        Else
            MsgBox("Debe seleccionar una Entrega para ver sus datos", MsgBoxStyle.Information, "¡Atención!")
            Exit Sub
        End If
    End Sub

    Private Sub Bot_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Eliminar.Click
        If DataGridView_Entregas.SelectedRows.Count > 0 Then
            Select Case MessageBox.Show("¿Está seguro de querer Eliminar esta Entrega? Esta acción la puede revertir en la ventana Restaurar Eliminados", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                Case Windows.Forms.DialogResult.Yes
                    Dim ObjEliminar As New ClaseBD
                    If ObjEliminar.Modificar("UPDATE Entregas SET Entregas.Estado = 0 WHERE Entregas.IdEntrega=" & CampoClaveInt & ";") = True Then
                        MsgBox("Se ha eliminado correctamente la Entrega, si desea deshacer esta acción vaya a Restaurar Eliminados", MsgBoxStyle.Information, "Eliminado Correctamente")
                        BusquedaEntregas()
                    Else
                        MsgBox("No se ha podido eliminar la Entrega, vuelva a intentarlo más tarde", MsgBoxStyle.Exclamation, "Error")
                    End If
                Case Windows.Forms.DialogResult.No
                    Exit Sub
            End Select
        Else
            MsgBox("Debe seleccionar una Entrega primero para eliminarla.", MsgBoxStyle.Information, "¡Atención!")
            Exit Sub
        End If
    End Sub

#End Region

#Region "BUSQUEDA DE CLIENTES"

    Private Sub BusquedaClientes()
        If WMTextBox_BuscarCliente.Text <> "" Then
            ActualizarTabla(DataGridView_Clientes, "SELECT Clientes.IdCliente, Clientes.Nombre, Clientes.Direccion, Clientes.Celular FROM Clientes WHERE (Clientes.IdCliente Like '%" & WMTextBox_BuscarCliente.Text & "%' OR Clientes.Nombre Like '%" & WMTextBox_BuscarCliente.Text & "%') AND Clientes.Estado=1;", CS)
        Else
            ActualizarTabla(DataGridView_Clientes, "SELECT Clientes.IdCliente, Clientes.Nombre, Clientes.Direccion, Clientes.Celular FROM Clientes WHERE Clientes.Estado=1;", CS)
        End If
        If DataGridView_Clientes.Rows.Count > 0 Then
            DataGridView_Clientes.Columns(0).HeaderText = "ID"
            DataGridView_Clientes.Columns(0).Width = 50
            DataGridView_Clientes.Rows(0).Selected = True
            IDS(0) = DataGridView_Clientes.SelectedRows(0).Cells(0).Value
        End If
    End Sub

    Private Sub DataGridView_Clientes_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView_Clientes.CurrentCellChanged
        If DataGridView_Clientes.SelectedRows.Count > 0 Then
            IDS(0) = DataGridView_Clientes.SelectedRows(0).Cells(0).Value
        End If
    End Sub


    Private Sub WMTextBox_BuscarCliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WMTextBox_BuscarCliente.TextChanged
        BusquedaClientes()
    End Sub

    Private Sub Bot_BorrarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_BorrarCliente.Click
        WMTextBox_BuscarCliente.Text = ""
    End Sub

    'Selecciona un cliente, y busca las ordenes del mismo.-
    Private Sub Bot_SeleccionarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_SeleccionarCliente.Click
        If DataGridView_Clientes.SelectedRows.Count = 0 Then
            MsgBox("Debe seleccionar un cliente primero", MsgBoxStyle.Information, "¡Atención!")
            Exit Sub
        End If

        Me.Panel_Cliente.Visible = False
        Me.Panel_Orden.Visible = True
        Radio_Debe.Checked = True
        BusquedaOrdenes()

        Label_Accion.Text = "Cliente: " & DataGridView_Clientes.SelectedRows(0).Cells(1).Value
        Label_Titulo.Text = "Seleccione una Orden"
        WMTextBox_BuscarOrden.Focus()
        'Guardar Datos de cliente en tabla
    End Sub

#End Region

#Region "BUSQUEDA DE ORDENES"

    Private Sub BusquedaOrdenes()
        If WMTextBox_BuscarOrden.Text <> "" Then
            ActualizarTabla(DataGridView_Ordenes, "SELECT OrdenesCD.IdOrden, OrdenesCD.Guia, OrdenesCD.IdCamion, OrdenesCD.detallecarga, OrdenesCD.Total FROM OrdenesCD WHERE (OrdenesCD.IdOrden Like '%" & WMTextBox_BuscarOrden.Text & "%' OR OrdenesCD.Guia Like '%" & WMTextBox_BuscarOrden.Text & "%' OR OrdenesCD.IdCamion Like '%" & WMTextBox_BuscarOrden.Text & "%' OR OrdenesCD.detallecarga Like '%" & WMTextBox_BuscarOrden.Text & "%' OR OrdenesCD.LugarCarga Like '%" & WMTextBox_BuscarOrden.Text & "%' OR OrdenesCD.LugarDescarga Like '%" & WMTextBox_BuscarOrden.Text & "%') AND OrdenesCD.CodigoCliente=" & IDS(0) & " AND OrdenesCD.EstadodePago='" & BusquedaEstado & "' AND OrdenesCD.EstadodePago<>'Pago' AND OrdenesCD.Estado=1 ORDER BY OrdenesCD.FechaOrden DESC;", CS)
        Else
            ActualizarTabla(DataGridView_Ordenes, "SELECT OrdenesCD.IdOrden, OrdenesCD.Guia, OrdenesCD.IdCamion, OrdenesCD.detallecarga, OrdenesCD.Total FROM OrdenesCD WHERE OrdenesCD.CodigoCliente=" & IDS(0) & " AND OrdenesCD.EstadodePago='" & BusquedaEstado & "' AND OrdenesCD.Estado=1 ORDER BY OrdenesCD.FechaOrden DESC;", CS)
        End If
        If DataGridView_Ordenes.Rows.Count > 0 Then
            DataGridView_Ordenes.Rows(0).Selected = True 'Selecciona la primer fila.-
            IDS(1) = DataGridView_Ordenes.SelectedRows(0).Cells(0).Value 'Guarda el ID de la primera fila.-
            TotalOrdenes = 0
            For Each row As DataGridViewRow In Me.DataGridView_Ordenes.Rows
                TotalOrdenes += Val(row.Cells(4).Value)
            Next
            TextBox_SaldoTotal.Text = ""
            If BusquedaEstado = "Debe" Then
                Dim ObjConsulta As New ClaseBD
                If ObjConsulta.Consulta("SELECT Sum(Entregas.MontoEntrega) AS SumaDeMontoEntrega FROM Entregas WHERE Entregas.Estado=1 GROUP BY Entregas.IdCliente HAVING Entregas.IdCliente=" & IDS(0) & ";") = True Then
                    If DatosConsulta.Rows.Count > 0 Then
                        TextBox_SaldoTotal.Text = DatosConsulta.Rows(0).Item("SumaDeMontoEntrega") - TotalOrdenes
                    Else
                        TextBox_SaldoTotal.Text = TotalOrdenes * -1
                    End If
                End If
            End If
        End If
        DataGridView_Ordenes.Columns(0).HeaderText = "ID"
        DataGridView_Ordenes.Columns(2).HeaderText = "Vehículo"
        DataGridView_Ordenes.Columns(3).HeaderText = "Carga"
        DataGridView_Ordenes.Columns(0).Width = 50
    End Sub

    Private Sub WMTextBox_BuscarOrden_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WMTextBox_BuscarOrden.TextChanged
        BusquedaOrdenes()
    End Sub

    Private Sub Bot_BorrarOrden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_BorrarOrden.Click
        WMTextBox_BuscarOrden.Text = ""
    End Sub

    Private Sub DataGridView_Ordenes_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView_Ordenes.CurrentCellChanged
        If DataGridView_Ordenes.SelectedRows.Count > 0 Then
            IDS(1) = DataGridView_Ordenes.SelectedRows(0).Cells(0).Value
        End If
    End Sub

    Private Sub Radio_DebePago_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Radio_Pago.CheckedChanged, Radio_Debe.CheckedChanged
        Radio_Debe.Font = New Font("Century Gothic", 9.75, FontStyle.Regular)
        Radio_Pago.Font = New Font("Century Gothic", 9.75, FontStyle.Regular)
        sender.font = New Font("Century Gothic", 9.75, FontStyle.Bold)
        BusquedaEstado = sender.Tag
        BusquedaOrdenes()
    End Sub

    'Selecciona una orden y busca las entregas hechas de la misma.-
    Private Sub Bot_SeleccionarOrden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_SeleccionarOrden.Click
        If DataGridView_Ordenes.SelectedRows.Count = 0 Then
            MsgBox("Debe seleccionar una orden para continuar", MsgBoxStyle.Information, "¡Atención!")
            Exit Sub
        End If
        BusquedaEntregas()
        TextBox_SaldoOrden.Text = ""
        Dim ObjConsulta As New ClaseBD
        If ObjConsulta.Consulta("SELECT OrdenesCD.Total, Sum(Entregas.MontoEntrega) AS SumaDeMontoEntrega FROM OrdenesCD INNER JOIN Entregas ON OrdenesCD.IdOrden = Entregas.NumOrden GROUP BY OrdenesCD.Total, OrdenesCD.IdOrden HAVING OrdenesCD.IdOrden=" & IDS(1) & ";") = True Then
            If DatosConsulta.Rows.Count > 0 Then
                TextBox_MontoOrden.Text = DatosConsulta.Rows(0).Item("Total")
                TextBox_SaldoOrden.Text = Val(TextBox_MontoOrden.Text) - Val(DatosConsulta.Rows(0).Item("SumaDeMontoEntrega"))
            End If
        End If
        Me.Panel_Orden.Visible = False
        Me.Panel_Entrega.Visible = True
        Label_Accion.Text += ", Orden: " & IDS(1)
        Label_Titulo.Text = "Seleccione una Entrega"
        WMTextBox_BuscarEntrega.Focus()
        'Guardar Datos de Orden en tabla
    End Sub

#End Region

#Region "BUSQUEDA DE ENTREGAS"

    Private Sub BusquedaEntregas()
        If WMTextBox_BuscarOrden.Text <> "" Then
            ActualizarTabla(DataGridView_Entregas, "SELECT Entregas.IdEntrega, Entregas.FechaEntrega, Entregas.NumFactura, Entregas.NumRecibo, Entregas.MontoEntrega FROM Entregas WHERE (Entregas.NumFactura Like '%" & WMTextBox_BuscarEntrega.Text & "%' OR Entregas.NumRecibo Like '%" & WMTextBox_BuscarEntrega.Text & "%') AND Entregas.NumOrden=" & IDS(1) & " AND Entregas.IdCliente=" & IDS(0) & " AND Entregas.Estado=1;", CS)
        Else
            ActualizarTabla(DataGridView_Entregas, "SELECT Entregas.IdEntrega, Entregas.FechaEntrega, Entregas.NumFactura, Entregas.NumRecibo, Entregas.MontoEntrega FROM Entregas WHERE Entregas.NumOrden=" & IDS(1) & " AND Entregas.IdCliente=" & IDS(0) & " AND Entregas.Estado=1;", CS)
        End If
        If DataGridView_Entregas.Rows.Count > 0 Then
            DataGridView_Entregas.Rows(0).Selected = True
            CampoClaveInt = DataGridView_Entregas.SelectedRows(0).Cells(0).Value
        End If
        DataGridView_Entregas.Columns(0).HeaderText = "ID"
        DataGridView_Entregas.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        DataGridView_Entregas.Columns(0).Width = 50
        DataGridView_Entregas.Columns(1).HeaderText = "Fecha"
        DataGridView_Entregas.Columns(2).HeaderText = "Factura"
        DataGridView_Entregas.Columns(3).HeaderText = "Recibo"
        DataGridView_Entregas.Columns(4).HeaderText = "Monto"
    End Sub

    Private Sub WMTextBox_BuscarEntrega_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WMTextBox_BuscarEntrega.TextChanged
        BusquedaEntregas()
    End Sub

    Private Sub Bot_BorrarEntrega_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_BorrarEntrega.Click
        WMTextBox_BuscarEntrega.Text = ""
    End Sub

    Private Sub DataGridView_Entregas_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView_Entregas.CurrentCellChanged
        If DataGridView_Entregas.SelectedRows.Count > 0 Then
            CampoClaveInt = DataGridView_Entregas.SelectedRows(0).Cells(0).Value
        End If
    End Sub

#End Region

    Private Sub Bot_ImprimirE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_ImprimirE.Click
        MsgBox("Función no Disponible", MsgBoxStyle.Critical, "Error")
    End Sub

    Private Sub Bot_ImprimirO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_ImprimirO.Click
        MsgBox("Función no Disponible", MsgBoxStyle.Critical, "Error")
    End Sub
End Class