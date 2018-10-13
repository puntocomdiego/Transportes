Public Class Form_BuscarClientes

    Private Sub Form_BuscarClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Busqueda()
    End Sub

    Private Sub WMTextBox_Buscar_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles WMTextBox_Buscar.TextChanged
        Busqueda()
    End Sub

    Private Sub Bot_Borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Borrar.Click
        WMTextBox_Buscar.Text = ""
        WMTextBox_Buscar.Focus()
    End Sub

#Region "BOTONES ABMV"

    Private Sub Bot_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Agregar.Click
        AbrirSegundoInPanel(New Form_AgregarModificarClientes, Form_MenuPrincipal.Panel_AreaDeTrabajo, "1")
    End Sub

    Private Sub Bot_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Modificar.Click
        If CampoClaveInt <> Nothing Then
            AbrirSegundoInPanel(New Form_AgregarModificarClientes, Form_MenuPrincipal.Panel_AreaDeTrabajo, "2")
        Else
            MsgBox("Debe seleccionar un Cliente para modificarlo", MsgBoxStyle.Information, "¡Atención!")
            Exit Sub
        End If
    End Sub

    Private Sub Bot_Ver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Ver.Click
        If CampoClaveInt <> Nothing Then
            AbrirSegundoInPanel(New Form_AgregarModificarClientes, Form_MenuPrincipal.Panel_AreaDeTrabajo, "3")
        Else
            MsgBox("Debe seleccionar un Cliente para ver sus datos", MsgBoxStyle.Information, "¡Atención!")
            Exit Sub
        End If
    End Sub

    Private Sub Bot_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Eliminar.Click
        If CampoClaveInt <> Nothing Then
            Select Case MessageBox.Show("¿Está seguro de querer Eliminar a este Cliente? Esta acción la puede revertir en la ventana Restaurar Eliminados", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                Case Windows.Forms.DialogResult.Yes
                    Dim ObjEliminar As New ClaseBD
                    If ObjEliminar.Modificar("UPDATE Clientes SET Clientes.Estado = 0 WHERE Clientes.IdCliente=" & CampoClaveInt & ";") = True Then
                        MsgBox("Se ha eliminado correctamente al Cliente, si desea deshacer esta acción vaya a Restaurar Eliminados", MsgBoxStyle.Information, "Eliminado Correctamente")
                        Busqueda()
                    Else
                        MsgBox("No se ha podido eliminar al Cliente, vuelva a intentarlo más tarde", MsgBoxStyle.Exclamation, "Error")
                    End If
                Case Windows.Forms.DialogResult.No
                    Exit Sub
            End Select
        Else
            MsgBox("Debe seleccionar un Cliente primero para eliminarlo.", MsgBoxStyle.Information, "¡Atención!")
            Exit Sub
        End If
    End Sub

#End Region

#Region "BOTONES ADMINISTRACION"

    Private Sub Bot_VerSaldo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_VerSaldo.Click
        If DataGridView_Clientes.SelectedRows.Count > 0 Then
            CampoClaveInt = DataGridView_Clientes.SelectedRows(0).Cells(0).Value
            CampoClaveStr = DataGridView_Clientes.SelectedRows(0).Cells(1).Value.ToString
            AbrirSegundoInPanel(New Form_Saldos, Form_MenuPrincipal.Panel_AreaDeTrabajo, "1")
        End If
    End Sub

#End Region
    
#Region "DATAGRIDVIEW"

    Private Sub Busqueda()
        If WMTextBox_Buscar.Text <> "" Then
            ActualizarTabla(DataGridView_Clientes, "SELECT Clientes.IdCliente, Clientes.Nombre, Clientes.Direccion, Clientes.Celular FROM Clientes WHERE (Clientes.IdCliente Like '%" & WMTextBox_Buscar.Text & "%' OR Clientes.Nombre Like '%" & WMTextBox_Buscar.Text & "%') AND Clientes.Estado=1;", CS)
        Else
            ActualizarTabla(DataGridView_Clientes, "SELECT Clientes.IdCliente, Clientes.Nombre, Clientes.Direccion, Clientes.Celular FROM Clientes WHERE Clientes.Estado=1;", CS)
        End If
        If DataGridView_Clientes.Rows.Count > 0 Then
            DataGridView_Clientes.Columns(0).HeaderText = "ID"
            DataGridView_Clientes.Columns(0).Width = 70
            DataGridView_Clientes.Rows(0).Selected = True
            CampoClaveInt = DataGridView_Clientes.SelectedRows(0).Cells(0).Value
        End If
    End Sub

    Private Sub DataGridView_Clientes_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView_Clientes.CurrentCellChanged
        If DataGridView_Clientes.SelectedRows.Count > 0 Then
            CampoClaveInt = DataGridView_Clientes.SelectedRows(0).Cells(0).Value
        End If
    End Sub

    Private Sub DataGridView_Clientes_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView_Clientes.DoubleClick
        Bot_Ver.PerformClick()
    End Sub

#End Region

End Class