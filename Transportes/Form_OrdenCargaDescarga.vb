Public Class Form_OrdenCargaDescarga
    Dim VehiculosOrigArr(0) As String 'Guarda las Matrículas de los Vehiculos.-
    Dim KMOG As Integer 'Guarda los KM de la Orden a Eliminar.-
    Private Sub Form_OrdenCargaDescarga_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Busqueda()
    End Sub

#Region "BOTONES ABMV"

    Private Sub Bot_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Agregar.Click
        AbrirSegundoInPanel(New Form_AgregarModificarOrden, Form_MenuPrincipal.Panel_AreaDeTrabajo, "1")
    End Sub

    Private Sub Bot_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Modificar.Click
        If CampoClaveInt <> Nothing Then
            AbrirSegundoInPanel(New Form_AgregarModificarOrden, Form_MenuPrincipal.Panel_AreaDeTrabajo, "2")
        Else
            MsgBox("Debe seleccionar un Cliente para modificarla", MsgBoxStyle.Information, "¡Atención!")
            Exit Sub
        End If
    End Sub

    Private Sub Bot_Ver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Ver.Click
        If CampoClaveInt <> Nothing Then
            AbrirSegundoInPanel(New Form_AgregarModificarOrden, Form_MenuPrincipal.Panel_AreaDeTrabajo, "3")
        Else
            MsgBox("Debe seleccionar un Cliente para modificarla", MsgBoxStyle.Information, "¡Atención!")
            Exit Sub
        End If
    End Sub

    Private Sub Bot_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Eliminar.Click
        If CampoClaveInt <> Nothing Then
            Select Case MessageBox.Show("¿Está seguro de querer Eliminar esta Orden? Esta acción la puede revertir en la ventana Restaurar Eliminados", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                Case Windows.Forms.DialogResult.Yes
                    Dim ObjEliminar As New ClaseBD
                    'Eliminando Orden.-
                    If ObjEliminar.Modificar("UPDATE OrdenesCD SET OrdenesCD.Estado = 0 WHERE OrdenesCD.IdOrden=" & CampoClaveInt & ";") = True Then
                        MsgBox("Se ha eliminado correctamente la Orden, si desea deshacer esta acción vaya a Restaurar Eliminados", MsgBoxStyle.Information, "Eliminado Correctamente")

                        'Quitando KM de Vehiculos.-
                        If ObjEliminar.Consulta("SELECT OrdenesCD.IdCamion, OrdenesCD.kmcamion FROM OrdenesCD WHERE OrdenesCD.IdOrden=" & CampoClaveInt & ";") = True Then
                            VehiculosOrigArr = Split(DatosConsulta.Rows(0).Item("IdCamion").ToString, ",")
                            KMOG = Val(DatosConsulta.Rows(0).Item("kmcamion"))
                            For i = 0 To VehiculosOrigArr.Length - 1
                                If VehiculosOrigArr(i) <> Nothing Then
                                    If ActualizarKM(VehiculosOrigArr(i), (KMOG * (-2.2))) = False Then
                                        MsgBox("No se han podido actualizar los datos del Kilometraje", MsgBoxStyle.Exclamation, "Error")
                                    End If
                                End If
                            Next
                        End If

                        Busqueda()
                    Else
                        MsgBox("No se ha podido eliminar la Orden, vuelva a intentarlo más tarde", MsgBoxStyle.Exclamation, "Error")
                        Exit Sub
                    End If

                   
                    
                Case Windows.Forms.DialogResult.No
                    Exit Sub
            End Select
        Else
            MsgBox("Debe seleccionar una Orden primero para eliminarla.", MsgBoxStyle.Information, "¡Atención!")
            Exit Sub
        End If
    End Sub

#End Region

#Region "BUSQUEDA DE DATOS"

    Private Sub Busqueda()
        If WMTextBox_Buscar.Text <> "" Then
            ActualizarTabla(DataGridView_Ordenes, "SELECT OrdenesCD.IdOrden, Clientes.Nombre, OrdenesCD.Guia, OrdenesCD.IdCamion, OrdenesCD.detallecarga FROM Clientes INNER JOIN OrdenesCD ON Clientes.IdCliente = OrdenesCD.Codigocliente WHERE (OrdenesCD.IdOrden Like '%" & WMTextBox_Buscar.Text & "%' OR OrdenesCD.Codigocliente Like '%" & WMTextBox_Buscar.Text & "%' OR OrdenesCD.Guia Like '%" & WMTextBox_Buscar.Text & "%' OR OrdenesCD.IdCamion Like '%" & WMTextBox_Buscar.Text & "%' OR OrdenesCD.detallecarga Like '%" & WMTextBox_Buscar.Text & "%' OR OrdenesCD.LugarCarga Like '%" & WMTextBox_Buscar.Text & "%' OR OrdenesCD.LugarDescarga Like '%" & WMTextBox_Buscar.Text & "%' OR Clientes.Nombre Like '%" & WMTextBox_Buscar.Text & "%') AND OrdenesCD.Estado=1;", CS)
        Else
            ActualizarTabla(DataGridView_Ordenes, "SELECT OrdenesCD.IdOrden, Clientes.Nombre, OrdenesCD.Guia, OrdenesCD.IdCamion, OrdenesCD.detallecarga FROM Clientes INNER JOIN OrdenesCD ON Clientes.IdCliente = OrdenesCD.Codigocliente WHERE OrdenesCD.Estado=1;", CS)
        End If
        If DataGridView_Ordenes.Rows.Count > 0 Then
            DataGridView_Ordenes.Rows(0).Selected = True
            CampoClaveInt = DataGridView_Ordenes.SelectedRows(0).Cells(0).Value
        End If
        DataGridView_Ordenes.Columns(0).HeaderText = "ID"
        DataGridView_Ordenes.Columns(1).HeaderText = "Cliente"
        DataGridView_Ordenes.Columns(3).HeaderText = "Vehículo"
        DataGridView_Ordenes.Columns(4).HeaderText = "Carga"
        DataGridView_Ordenes.Columns(0).Width = 50
    End Sub

    Private Sub WMTextBox_Buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WMTextBox_Buscar.TextChanged
        Busqueda()
    End Sub

    Private Sub DataGridView_Clientes_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView_Ordenes.CurrentCellChanged
        If DataGridView_Ordenes.SelectedRows.Count > 0 Then
            CampoClaveInt = DataGridView_Ordenes.SelectedRows(0).Cells(0).Value
        End If
    End Sub

    Private Sub Bot_Borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Borrar.Click
        WMTextBox_Buscar.Text = ""
    End Sub

#End Region
    
End Class