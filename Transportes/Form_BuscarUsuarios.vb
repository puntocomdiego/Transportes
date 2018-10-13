Public Class Form_BuscarUsuarios

    Private Sub Form_BuscarUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Busqueda()
        CampoClaveInt = DataGridView_Usuarios.Rows(0).Cells(0).Value
    End Sub

    Private Sub WMTextBox_Buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WMTextBox_Buscar.TextChanged
        Busqueda()
    End Sub

    Private Sub Bot_Borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Borrar.Click
        WMTextBox_Buscar.Text = ""
        WMTextBox_Buscar.Focus()
    End Sub

#Region "BOTONES ABMV"

    Private Sub Bot_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Agregar.Click
        AbrirSegundoInPanel(New Form_AgregarModificarUsuarios, Form_MenuPrincipal.Panel_AreaDeTrabajo, "1")
    End Sub

    Private Sub Bot_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Modificar.Click
        If CampoClaveInt <> Nothing Then
            AbrirSegundoInPanel(New Form_AgregarModificarUsuarios, Form_MenuPrincipal.Panel_AreaDeTrabajo, "2")
        Else
            MsgBox("Debe seleccionar un Usuario para modificarlo", MsgBoxStyle.Information, "¡Atención!")
            Exit Sub
        End If
    End Sub

    Private Sub Bot_Ver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Ver.Click
        If CampoClaveInt <> Nothing Then
            AbrirSegundoInPanel(New Form_AgregarModificarUsuarios, Form_MenuPrincipal.Panel_AreaDeTrabajo, "3")
        Else
            MsgBox("Debe seleccionar un Usuario para ver sus datos", MsgBoxStyle.Information, "¡Atención!")
            Exit Sub
        End If
    End Sub

    Private Sub Bot_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Eliminar.Click
        If CampoClaveInt <> Nothing Then
            Select Case MessageBox.Show("¿Está seguro de querer Eliminar a este Usuario? Esta acción la puede revertir en la ventana Restaurar Eliminados", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                Case Windows.Forms.DialogResult.Yes
                    Dim ObjEliminar As New ClaseBD
                    If ObjEliminar.Modificar("UPDATE Usuarios SET Usuarios.Estado = 0 WHERE Usuarios.IdUsuario=" & CampoClaveInt & ";") = True Then
                        MsgBox("Se ha eliminado correctamente al Usuario, si desea deshacer esta acción vaya a Restaurar Eliminados", MsgBoxStyle.Information, "Eliminado Correctamente")
                        Busqueda()
                    Else
                        MsgBox("No se ha podido eliminar al Usuario, vuelva a intentarlo más tarde", MsgBoxStyle.Exclamation, "Error")
                    End If
                Case Windows.Forms.DialogResult.No
                    Exit Sub
            End Select
        Else
            MsgBox("Debe seleccionar un Usuario primero para eliminarlo.", MsgBoxStyle.Information, "¡Atención!")
            Exit Sub
        End If
    End Sub

#End Region

#Region "DATAGRIDVIEW"

    Private Sub Busqueda()
        If WMTextBox_Buscar.Text <> "" Then
            ActualizarTabla(DataGridView_Usuarios, "SELECT Usuarios.IdUsuario, Usuarios.Nombre, Usuarios.Apellido, Usuarios.CI, Usuarios.Telefono FROM Usuarios WHERE (Usuarios.CI Like '%" & WMTextBox_Buscar.Text & "%' OR Usuarios.Nombre Like '%" & WMTextBox_Buscar.Text & "%' OR Usuarios.Apellido Like '%" & WMTextBox_Buscar.Text & "%') AND Usuarios.Estado=1 ORDER BY Usuarios.Nombre;", CS)
        Else
            ActualizarTabla(DataGridView_Usuarios, "SELECT Usuarios.IdUsuario, Usuarios.Nombre, Usuarios.Apellido, Usuarios.CI, Usuarios.Telefono FROM Usuarios WHERE Usuarios.Estado=1 ORDER BY Usuarios.Nombre;", CS)
        End If
        If DataGridView_Usuarios.Rows.Count > 0 Then
            DataGridView_Usuarios.Columns(0).Visible = False
            DataGridView_Usuarios.Rows(0).Selected = True
            CampoClaveInt = DataGridView_Usuarios.SelectedRows(0).Cells(0).Value
        End If
    End Sub

    Private Sub DataGridView_Clientes_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView_Usuarios.CurrentCellChanged
        If DataGridView_Usuarios.SelectedRows.Count > 0 Then
            CampoClaveInt = DataGridView_Usuarios.SelectedRows(0).Cells(0).Value
        End If
    End Sub

    Private Sub DataGridView_Clientes_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView_Usuarios.DoubleClick
        Bot_Ver.PerformClick()
    End Sub

#End Region
    
End Class