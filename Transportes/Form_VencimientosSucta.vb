Public Class Form_VencimientosSucta

    Private Sub Form_VencimientosSucta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Busqueda()
    End Sub

    Private Sub Busqueda()
        If WMTextBox_Buscar.Text <> "" Then
            ActualizarTabla(DataGridView_Sucta, "SELECT Camiones.idcamion, Camiones.Marca & ', ' & Camiones.Modelo AS [Vehículo], Camiones.SuctaDesde, Camiones.SuctaHasta, DateDiff('d',DATE(),Camiones.SuctaHasta) AS [Días] FROM Camiones WHERE (Camiones.idcamion Like '%" & WMTextBox_Buscar.Text & "%' OR Camiones.Marca Like '%" & WMTextBox_Buscar.Text & "%' OR Camiones.Modelo Like '%" & WMTextBox_Buscar.Text & "%') AND Camiones.Estado=1;", CS)
        Else
            ActualizarTabla(DataGridView_Sucta, "SELECT Camiones.idcamion, Camiones.Marca & ', ' & Camiones.Modelo AS [Vehículo], Camiones.SuctaDesde, Camiones.SuctaHasta, DateDiff('d',DATE(),Camiones.SuctaHasta) AS [Días] FROM Camiones WHERE Camiones.Estado=1;", CS)
        End If
        If DataGridView_Sucta.Rows.Count > 0 Then
            DataGridView_Sucta.Columns(0).HeaderText = "Matrícula"
            DataGridView_Sucta.Columns(2).HeaderText = "Último"
            DataGridView_Sucta.Columns(3).HeaderText = "Próximo"
            DataGridView_Sucta.Columns(0).Width = 90
            DataGridView_Sucta.Rows(0).Selected = True
            CampoClaveStr = DataGridView_Sucta.SelectedRows(0).Cells(0).Value
        End If
    End Sub

    Private Sub AbrirPanel()
        Panel_Busqueda.Left = (Me.Width / 2) - ((Panel_Busqueda.Width + Panel_Accion.Width) / 2)
        Panel_Accion.Left = Panel_Busqueda.Right
        Panel_Accion.Visible = True
        Panel_Busqueda.Enabled = False
    End Sub

    Private Sub Bot_Actualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Actualizar.Click, Bot_Ver.Click
        If CampoClaveStr = Nothing Then
            MsgBox("Debe seleccionar un vehículo primero", MsgBoxStyle.Information, "¡Atención!")
            Exit Sub
        End If
        AbrirPanel()
        Label_Accion.Text = sender.Tag
        Dim ObjBD As New ClaseBD
        If ObjBD.Consulta("SELECT Camiones.* FROM Camiones WHERE Camiones.IdCamion='" & CampoClaveStr & "';") = True Then
            TextBox_Marca.Text = DatosConsulta.Rows(0).Item("Marca")
            TextBox_Modelo.Text = DatosConsulta.Rows(0).Item("Modelo")
            TextBox_Matrícula.Text = DatosConsulta.Rows(0).Item("IdCamion")
            TextBox_KMActuales.Text = DatosConsulta.Rows(0).Item("kmactual")
            TextBox_KMAceite.Text = DatosConsulta.Rows(0).Item("kmaceite")
            TextBox_KMCubierta.Text = DatosConsulta.Rows(0).Item("kmcubiertas")
            DatePicker_Ultimo.Value = DatosConsulta.Rows(0).Item("SuctaDesde")
            DatePicker_Proximo.Value = DatosConsulta.Rows(0).Item("SuctaHasta")
        End If
        Select Case sender.tag
            Case Is = "Actualizar"
                Bot_Guardar.Text = "Guardar"
                Bot_Cancelar.Text = "Cancelar"
                DatePicker_Proximo.Enabled = True
                DatePicker_Ultimo.Enabled = True
            Case Is = "Ver"
                Bot_Guardar.Text = "Actualizar"
                Bot_Cancelar.Text = "Volver"
                DatePicker_Proximo.Enabled = False
                DatePicker_Ultimo.Enabled = False
        End Select
    End Sub

    Private Sub Bot_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Guardar.Click
        Select Case sender.Text
            Case Is = "Guardar"
                Dim ObjModificar As New ClaseBD
                If ObjModificar.Modificar("UPDATE Camiones SET SuctaDesde='" & DatePicker_Ultimo.Text & "',SuctaHasta='" & DatePicker_Proximo.Text & "' WHERE Camiones.IdCamion='" & TextBox_Matrícula.Text & "'") = False Then
                    MsgBox("No se han podido actualizar los datos, inténtelo más tarde", MsgBoxStyle.Exclamation, "¡Error!")
                    Exit Sub
                End If
                MsgBox("Datos actualizados", MsgBoxStyle.Information, "Atención")
                Panel_Accion.Visible = False
                Panel_Busqueda.Enabled = True
                Panel_Busqueda.Left = 140
            Case Is = "Actualizar"
                Bot_Guardar.Text = "Guardar"
                Bot_Cancelar.Text = "Cancelar"
                DatePicker_Proximo.Enabled = True
                DatePicker_Ultimo.Enabled = True
        End Select
    End Sub

    Private Sub Bot_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Cancelar.Click
        If Bot_Cancelar.Text = "Cancelar" Then
            Select Case MessageBox.Show("¿Está seguro de querer salir? Se perderán los cambios no guardados", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                Case Windows.Forms.DialogResult.Yes
                    Panel_Accion.Visible = False
                    Panel_Busqueda.Left = 140
                Case Windows.Forms.DialogResult.No
                    Exit Sub
            End Select
        Else
            Panel_Accion.Visible = False
            Panel_Busqueda.Left = 140
        End If
        Panel_Busqueda.Enabled = True
    End Sub

    Private Sub WMTextBox_Buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WMTextBox_Buscar.TextChanged
        Busqueda()
    End Sub

    Private Sub DataGridView_Sucta_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView_Sucta.CellFormatting
        ColoresDataGrid()
    End Sub

    Private Sub DataGridView_Camiones_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView_Sucta.CurrentCellChanged
        If DataGridView_Sucta.SelectedRows.Count > 0 Then
            CampoClaveStr = DataGridView_Sucta.SelectedRows(0).Cells(0).Value
        End If
    End Sub

    Private Sub Panel_Accion_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel_Accion.VisibleChanged
        If Panel_Accion.Visible = False Then
            Busqueda()
            ConsultaNofiticacion()
        End If
    End Sub

    Private Sub DataGridView_Camiones_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView_Sucta.DoubleClick
        Bot_Ver.PerformClick()
    End Sub

    Private Sub ColoresDataGrid()
        For Each Row As DataGridViewRow In DataGridView_Sucta.Rows
            If Val(Row.Cells("Días").Value) <= 50 And Val(Row.Cells("Días").Value) > 0 Then
                Row.DefaultCellStyle.BackColor = Color.MediumSeaGreen
                Row.DefaultCellStyle.ForeColor = Color.White
            ElseIf Val(Row.Cells("Días").Value) <= 0 Then
                Row.DefaultCellStyle.BackColor = Color.Firebrick
                Row.DefaultCellStyle.ForeColor = Color.White
            Else
                Row.DefaultCellStyle.BackColor = Color.White
                Row.DefaultCellStyle.ForeColor = Color.Black
            End If
        Next
    End Sub

    Private Sub Bot_Borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Borrar.Click
        WMTextBox_Buscar.Text = ""
    End Sub
End Class