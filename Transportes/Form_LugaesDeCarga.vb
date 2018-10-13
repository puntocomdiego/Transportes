Public Class Form_LugaesDeCarga

    Private Sub Form_LugaesDeCarga_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Busqueda()
    End Sub

#Region "BOTONES ABM"

    Private Sub Botones_AMV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Agregar.Click, Bot_Modificar.Click
        If sender.Tag = "Modificar" And CampoClaveInt = Nothing Then
            MsgBox("Debe seleccionar un lugar para modificarlo.", MsgBoxStyle.Information, "¡Atención!")
            Exit Sub
        End If
        Panel_Accion.Visible = True
        Label_Accion.Text = sender.Tag
        Panel_Busqueda.Enabled = False
        If sender.Tag = "Agregar" Then
            TextBox_Lugares.Text = ""
        Else
            Dim ObjConsulta As New ClaseBD
            If ObjConsulta.Consulta("SELECT Lugares.Lugar FROM Lugares WHERE Lugares.idLugar=" & CampoClaveInt & ";") = False Then
                MsgBox("No se han podido cargar los datos, intentelo denuevo", MsgBoxStyle.Information, "Error")
                Exit Sub
            End If
            TextBox_Lugares.Text = DatosConsulta.Rows(0).Item("Lugar")
        End If
    End Sub

    Private Sub Bot_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Eliminar.Click
        If CampoClaveInt <> Nothing Then
            Select Case MessageBox.Show("¿Está seguro de querer Eliminar este Lugar? Esta acción la puede revertir en la ventana Restaurar Eliminados", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                Case Windows.Forms.DialogResult.Yes
                    Dim ObjEliminar As New ClaseBD
                    If ObjEliminar.Modificar("UPDATE Lugares SET Lugares.Estado = 0 WHERE Lugares.idLugar=" & CampoClaveInt & ";") = True Then
                        MsgBox("Se ha eliminado correctamente el Lugar, si desea deshacer esta acción vaya a Restaurar Eliminados", MsgBoxStyle.Information, "Eliminado Correctamente")
                        Busqueda()
                    Else
                        MsgBox("No se ha podido eliminar el Lugar, vuelva a intentarlo más tarde", MsgBoxStyle.Exclamation, "Error")
                    End If
                Case Windows.Forms.DialogResult.No
                    Exit Sub
            End Select
        Else
            MsgBox("Debe seleccionar un Lugar primero para eliminarlo.", MsgBoxStyle.Information, "¡Atención!")
            Exit Sub
        End If
    End Sub

#End Region

#Region "PANEL ABM"

    Private Sub Bot_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Guardar.Click
        'Verificaciones.-
        If TextBox_Lugares.Text = "" Then
            MsgBox("Debe ingresar algún dato para poder guardar", MsgBoxStyle.Information, "¡Atención!")
            Exit Sub
        End If

        'Guardando Datos.-
        If Label_Accion.Text = "Agregar" Then 'Si está Agregando.-
            Dim ObjGuardar As New ClaseBD
            If ObjGuardar.Agregar("INSERT INTO Lugares(Lugar) VALUES ('" & TextBox_Lugares.Text & "')") = False Then
                MsgBox("No se han podido guardar los datos, vuelva a intentarlo", MsgBoxStyle.Information, "Error")
                Exit Sub
            End If
            Select Case MessageBox.Show("Se han guardado los datos, ¿Desea continuar agregando Lugares de Carga?", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                Case Windows.Forms.DialogResult.Yes
                    TextBox_Lugares.Text = ""
                Case Windows.Forms.DialogResult.No
                    Panel_Accion.Visible = False
                    Panel_Busqueda.Enabled = True
                    Busqueda()
            End Select

        Else 'Si está Modificando.-
            Select Case MessageBox.Show("¿Está seguro de querer guardar los cambios? Esta acción no se podrá revertir", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                Case Windows.Forms.DialogResult.Yes
                    Dim ObjModificar As New ClaseBD
                    If ObjModificar.Modificar("UPDATE Lugares SET Lugar='" & TextBox_Lugares.Text & "' WHERE idLugar=" & CampoClaveInt & ";") = False Then
                        MsgBox("No se han podido modificar los datos, vuelva a intentarlo", MsgBoxStyle.Information, "Error")
                        Exit Sub
                    End If
                    MsgBox("Se han modificado los datos del Lugar de Carga.", MsgBoxStyle.Information, "Cambios Guardados")
                    TextBox_Lugares.Text = ""
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
                TextBox_Lugares.Text = ""
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
            ActualizarTabla(DataGridView_Lugares, "SELECT Lugares.idLugar, Lugares.Lugar FROM Lugares WHERE Lugares.Lugar LIKE '%" & WMTextBox_Buscar.Text & "%' AND Lugares.Estado=1;", CS)
        Else
            ActualizarTabla(DataGridView_Lugares, "SELECT Lugares.idLugar, Lugares.Lugar FROM Lugares WHERE Lugares.Estado=1;", CS)
        End If
        If DataGridView_Lugares.Rows.Count > 0 Then
            DataGridView_Lugares.Rows(0).Selected = True
            CampoClaveInt = DataGridView_Lugares.Rows(0).Cells(0).Value
            DataGridView_Lugares.Columns(0).HeaderText = "ID"
            DataGridView_Lugares.Columns(0).Width = 50
        End If
    End Sub

    Private Sub Bot_Borrar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Borrar.Click
        WMTextBox_Buscar.Text = ""
    End Sub

    Private Sub WMTextBox_Buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WMTextBox_Buscar.TextChanged
        Busqueda()
    End Sub

    Private Sub DataGridView_Cargas_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView_Lugares.CurrentCellChanged
        If DataGridView_Lugares.SelectedRows.Count > 0 Then
            CampoClaveInt = DataGridView_Lugares.SelectedRows(0).Cells(0).Value
        End If
    End Sub

#End Region
End Class