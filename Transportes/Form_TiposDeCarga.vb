Public Class Form_TiposDeCarga

    Private Sub Form_TiposDeCarga_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Busqueda()
        WMTextBox_Buscar.Focus()
    End Sub

#Region "BOTONES ABM"

    Private Sub Botones_AMV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Agregar.Click, Bot_Modificar.Click
        If sender.Tag = "Modificar" And DataGridView_Cargas.SelectedRows.Count <= 0 Then
            MsgBox("Debe seleccionar una carga para modificarla.", MsgBoxStyle.Information, "¡Atención!")
            Exit Sub
        End If
        Panel_Accion.Visible = True
        Label_Accion.Text = sender.Tag
        Panel_Busqueda.Enabled = False
        If sender.Tag = "Agregar" Then
            TextBox_Cargas.Text = ""
        Else
            Dim ObjConsulta As New ClaseBD
            If ObjConsulta.Consulta("SELECT TiposCargas.Carga FROM TiposCargas WHERE TiposCargas.idCarga=" & CampoClaveInt & ";") = False Then
                MsgBox("No se han podido cargar los datos, intentelo denuevo", MsgBoxStyle.Information, "Error")
                Exit Sub
            End If
            TextBox_Cargas.Text = DatosConsulta.Rows(0).Item("Carga")
        End If
    End Sub

    Private Sub Bot_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Eliminar.Click
        If CampoClaveInt <> Nothing Then
            Select Case MessageBox.Show("¿Está seguro de querer Eliminar esta carga? Esta acción la puede revertir en la ventana Restaurar Eliminados", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                Case Windows.Forms.DialogResult.Yes
                    Dim ObjEliminar As New ClaseBD
                    If ObjEliminar.Modificar("UPDATE TiposCargas SET TiposCargas.Estado = 0 WHERE TiposCargas.idCarga=" & CampoClaveInt & ";") = True Then
                        MsgBox("Se ha eliminado correctamente la carga, si desea deshacer esta acción vaya a Restaurar Eliminados", MsgBoxStyle.Information, "Eliminado Correctamente")
                        Busqueda()
                    Else
                        MsgBox("No se ha podido eliminar la carga, vuelva a intentarlo más tarde", MsgBoxStyle.Exclamation, "Error")
                    End If
                Case Windows.Forms.DialogResult.No
                    Exit Sub
            End Select
        Else
            MsgBox("Debe seleccionar una carga primero para eliminarla.", MsgBoxStyle.Information, "¡Atención!")
            Exit Sub
        End If
    End Sub

#End Region

#Region "PANEL ABM"

    Private Sub Bot_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Guardar.Click
        'Verificaciones.-
        If TextBox_Cargas.Text = "" Then
            MsgBox("Debe ingresar algún dato para poder guardar", MsgBoxStyle.Information, "¡Atención!")
            Exit Sub
        End If

        'Guardando Datos.-
        If Label_Accion.Text = "Agregar" Then 'Si está Agregando.-
            Dim ObjGuardar As New ClaseBD
            If ObjGuardar.Agregar("INSERT INTO TiposCargas(Carga) VALUES ('" & TextBox_Cargas.Text & "')") = False Then
                MsgBox("No se han podido guardar los datos, vuelva a intentarlo", MsgBoxStyle.Information, "Error")
                Exit Sub
            End If
            Select Case MessageBox.Show("Se han guardado los datos, ¿Desea continuar agregando tipos de carga?", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                Case Windows.Forms.DialogResult.Yes
                    TextBox_Cargas.Text = ""
                Case Windows.Forms.DialogResult.No
                    Panel_Accion.Visible = False
                    Panel_Busqueda.Enabled = True
                    Busqueda()
            End Select

        Else 'Si está Modificando.-
            Select Case MessageBox.Show("¿Está seguro de querer guardar los cambios? Esta acción no se podrá revertir", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                Case Windows.Forms.DialogResult.Yes
                    Dim ObjModificar As New ClaseBD
                    If ObjModificar.Modificar("UPDATE TiposCargas SET Carga='" & TextBox_Cargas.Text & "' WHERE idCarga=" & CampoClaveInt & ";") = False Then
                        MsgBox("No se han podido modificar los datos, vuelva a intentarlo", MsgBoxStyle.Information, "Error")
                        Exit Sub
                    End If
                    MsgBox("Se han modificado los datos del Tipo de Carga.", MsgBoxStyle.Information, "Cambios Guardados")
                    TextBox_Cargas.Text = ""
                    Panel_Accion.Visible = False
                    Panel_Busqueda.Enabled = True
                    Busqueda()
                Case Windows.Forms.DialogResult.No
                    Exit Sub
            End Select
        End If
    End Sub

    Private Sub Bot_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Cancelar.Click
        Select Case MessageBox.Show("¿Está seguro de querer salir? Se perderán los cambios no guardados", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            Case Windows.Forms.DialogResult.Yes
                TextBox_Cargas.Text = ""
                Panel_Busqueda.Enabled = True
                Panel_Accion.Visible = False
            Case Windows.Forms.DialogResult.No
                Exit Sub
        End Select
    End Sub

    Private Sub Panel_Accion_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel_Accion.VisibleChanged
        If Panel_Accion.Visible = False Then
            Busqueda()
        End If
    End Sub

#End Region

#Region "BUSQUEDA DE DATOS"

    Private Sub Busqueda()
        If WMTextBox_Buscar.Text <> "" Then
            ActualizarTabla(DataGridView_Cargas, "SELECT TiposCargas.idCarga, TiposCargas.Carga FROM TiposCargas WHERE TiposCargas.Carga LIKE '%" & WMTextBox_Buscar.Text & "%' AND TiposCargas.Estado=1;", CS)
        Else
            ActualizarTabla(DataGridView_Cargas, "SELECT TiposCargas.idCarga, TiposCargas.Carga FROM TiposCargas WHERE TiposCargas.Estado=1;", CS)
        End If
        If DataGridView_Cargas.Rows.Count > 0 Then
            DataGridView_Cargas.Rows(0).Selected = True
            CampoClaveInt = DataGridView_Cargas.Rows(0).Cells(0).Value
            DataGridView_Cargas.Columns(0).HeaderText = "ID"
            DataGridView_Cargas.Columns(0).Width = 50
        End If
    End Sub

    Private Sub WMTextBox_Buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WMTextBox_Buscar.TextChanged
        Busqueda()
    End Sub

    Private Sub DataGridView_Cargas_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView_Cargas.CurrentCellChanged
        If DataGridView_Cargas.SelectedRows.Count > 0 Then
            CampoClaveInt = DataGridView_Cargas.SelectedRows(0).Cells(0).Value
        End If
    End Sub

    Private Sub Bot_Borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Borrar.Click
        WMTextBox_Buscar.Text = ""
    End Sub
#End Region

End Class