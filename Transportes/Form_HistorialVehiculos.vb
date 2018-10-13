Public Class Form_HistorialVehiculos
    Dim DatosCamion(2) As String

    Private Sub Form_HistorialVehiculos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ObjBD As New ClaseBD
        If ObjBD.Consulta("SELECT Camiones.idcamion, Camiones.Marca, Camiones.Modelo FROM Camiones WHERE Camiones.idcamion='" & CampoClaveStr & "';") = True Then
            Label_Vehiculo.Text = DatosConsulta.Rows(0).Item("IdCamion") & ", " & DatosConsulta.Rows(0).Item("Marca") & ", " & DatosConsulta.Rows(0).Item("Modelo")
            DatosCamion(0) = DatosConsulta.Rows(0).Item("IdCamion")
            DatosCamion(1) = DatosConsulta.Rows(0).Item("Marca")
            DatosCamion(2) = DatosConsulta.Rows(0).Item("Modelo")
        Else
            MsgBox("No se encontró el vehiculo en la base de datos. Por favor vuelva a intentarlo", MsgBoxStyle.Exclamation, "¡Atención!")
            Me.Close()
        End If
        Busqueda()
    End Sub

    Private Sub Bot_Borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Borrar.Click
        WMTextBox_Buscar.Text = ""
    End Sub

    Private Sub Bot_Volver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Volver.Click
        Me.Close()
    End Sub

#Region "BOTONES ABMV"

    Private Sub Bot_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Agregar.Click
        Panel_Accion.Visible = True
        Panel_Busqueda.Enabled = False
        Label_Accion.Text = sender.Tag
        GroupBox_Camion.Enabled = False
        GroupBox_Mantenimiento.Enabled = True
        TextBox_Matrícula.ReadOnly = True
        Bot_Guardar.Text = "Guardar"
        Bot_Cancelar.Text = "Cancelar"
        TextBox_Matrícula.Text = DatosCamion(0)
        TextBox_Marca.Text = DatosCamion(1)
        TextBox_Modelo.Text = DatosCamion(2)
    End Sub

    Private Sub BotonesAMV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Modificar.Click, Bot_VerDatos.Click
        If DataGridView_Historial.SelectedRows.Count <= 0 Then
            MsgBox("Debe seleccionar una entrada primero", MsgBoxStyle.Information, "¡Atención!")
            Exit Sub
        End If
        Panel_Accion.Visible = True
        Panel_Busqueda.Enabled = False
        Label_Accion.Text = sender.Tag
        Dim ObjBD As New ClaseBD
        If ObjBD.Consulta("SELECT ControlesCamiones.*, Camiones.Marca, Camiones.Modelo FROM Camiones INNER JOIN ControlesCamiones ON Camiones.idcamion = ControlesCamiones.idcamion WHERE ControlesCamiones.idcontrol=" & CampoClaveInt & ";") = True Then
            TextBox_Marca.Text = DatosConsulta.Rows(0).Item("Marca")
            TextBox_Modelo.Text = DatosConsulta.Rows(0).Item("Modelo")
            TextBox_Matrícula.Text = DatosConsulta.Rows(0).Item("IdCamion")
            TextBox_Gastos.Text = DatosConsulta.Rows(0).Item("GastosTaller")
            RichTextBox_Detalles.Text = DatosConsulta.Rows(0).Item("Detalle")
            DatePicker_Fecha.Value = DatosConsulta.Rows(0).Item("FechaControl")
        End If
        Select Case sender.tag
            Case Is = "Datos"
                TextBox_Gastos.ReadOnly = True
                RichTextBox_Detalles.ReadOnly = True
                DatePicker_Fecha.Enabled = False
                Bot_Guardar.Text = "Modificar"
                Bot_Cancelar.Text = "Volver"
            Case Is = "Modificar"
                TextBox_Gastos.ReadOnly = False
                RichTextBox_Detalles.ReadOnly = False
                DatePicker_Fecha.Enabled = True
                Bot_Guardar.Text = "Guardar"
                Bot_Cancelar.Text = "Cancelar"
        End Select
    End Sub

    Private Sub Bot_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Eliminar.Click
        If DataGridView_Historial.SelectedRows.Count > 0 Then
            Select Case MessageBox.Show("¿Está seguro de querer Eliminar esta entrada? Esta acción la puede revertir en la ventana Restaurar Eliminados", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                Case Windows.Forms.DialogResult.Yes
                    Dim ObjEliminar As New ClaseBD
                    If ObjEliminar.Modificar("UPDATE ControlesCamiones SET ControlesCamiones.Estado = 0 WHERE ControlesCamiones.IdControl=" & CampoClaveInt & ";") = True Then
                        MsgBox("Se ha eliminado correctamente entrada, si desea deshacer esta acción vaya a Restaurar Eliminados", MsgBoxStyle.Information, "Eliminado Correctamente")
                        Busqueda()
                    Else
                        MsgBox("No se ha podido eliminar la entrada, vuelva a intentarlo más tarde", MsgBoxStyle.Exclamation, "Error")
                    End If
                Case Windows.Forms.DialogResult.No
                    Exit Sub
            End Select
        Else
            MsgBox("Debe seleccionar una entrada primero para eliminarla.", MsgBoxStyle.Information, "¡Atención!")
            Exit Sub
        End If
    End Sub

#End Region

#Region "PANEL ADMINISTRACION"

    Private Sub Bot_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Guardar.Click
        Select Case sender.Text
            Case Is = "Guardar" 'Si quiere Agregar o Modificar.-
                'Verificaciones.-
                If TextBox_Gastos.Text = "" Or RichTextBox_Detalles.Text = "" Then
                    MsgBox("Debe ingresar los gastos totales y el detalle para poder guardar", MsgBoxStyle.Exclamation, "Atención")
                    Exit Sub
                End If

                'Guardando Datos.-
                Dim ObjAgregar As New ClaseBD
                If Label_Accion.Text = "Agregar" Then 'Si está Agregando.-
                    If ObjAgregar.Agregar("INSERT INTO ControlesCamiones (idcamion, GastosTaller, Detalle, FechaControl) VALUES ('" & TextBox_Matrícula.Text & "', " & Val(TextBox_Gastos.Text) & ", '" & RichTextBox_Detalles.Text & "', '" & DatePicker_Fecha.Text & "')") = True Then
                        MsgBox("Entrada de Historial guardada", MsgBoxStyle.Information, "Atención")
                    Else
                        MsgBox("No se ha podido guardar la entrada en el historial, por favor vuelva a intentarlo.", MsgBoxStyle.Exclamation, "¡Atención!")
                        Exit Sub
                    End If

                Else 'Si está Modificando.-
                    If ObjAgregar.Modificar("UPDATE ControlesCamiones SET idcamion='" & TextBox_Matrícula.Text & "', GastosTaller=" & Val(TextBox_Gastos.Text) & ", Detalle='" & RichTextBox_Detalles.Text & "', FechaControl='" & DatePicker_Fecha.Text & "' WHERE IdControl=" & CampoClaveInt & ";") = True Then
                        MsgBox("Entrada de Historial modificada", MsgBoxStyle.Information, "¡Atención")
                    Else
                        MsgBox("No se ha podido modificar la entrada en el historial, por favor vuelva a intentarlo.", MsgBoxStyle.Exclamation, "¡Atención!")
                        Exit Sub
                    End If
                End If
                Panel_Accion.Visible = False
                Panel_Busqueda.Enabled = True
                Busqueda()

            Case Is = "Modificar" 'Si está Viendo y quiere Modificar.-
                Label_Accion.Text = "Modificar"
                TextBox_Gastos.ReadOnly = False
                RichTextBox_Detalles.ReadOnly = False
                DatePicker_Fecha.Enabled = True
                Bot_Guardar.Text = "Guardar"
                Bot_Cancelar.Text = "Cancelar"
        End Select
    End Sub

    Private Sub Bot_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Cancelar.Click
        Select Case sender.Text
            Case Is = "Cancelar" 'Si está Agregando o Modificando.-
                Select Case MessageBox.Show("¿Está seguro de querer salir? Se perderán los cambios no guardados", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                    Case Windows.Forms.DialogResult.Yes
                        TextBox_Gastos.Enabled = True
                        TextBox_Gastos.Text = ""
                        RichTextBox_Detalles.Enabled = True
                        RichTextBox_Detalles.Text = ""
                        Panel_Accion.Visible = False
                    Case Windows.Forms.DialogResult.No
                        Exit Sub
                End Select

            Case Is = "Volver" 'Si está Viendo.-
                TextBox_Gastos.Enabled = True
                TextBox_Gastos.Text = ""
                RichTextBox_Detalles.Enabled = True
                RichTextBox_Detalles.Text = ""
                Panel_Accion.Visible = False
        End Select
        Panel_Busqueda.Enabled = True
    End Sub

    Private Sub Panel_Accion_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel_Accion.VisibleChanged
        'Cuando se cierra el Panel se actualiza el DataGrid.-
        If Panel_Accion.Visible = False Then
            Busqueda()
        End If
    End Sub

#End Region

#Region "BUSQUEDA DE DATOS"

    Private Sub Busqueda()
        If WMTextBox_Buscar.Text <> "" Then
            ActualizarTabla(DataGridView_Historial, "SELECT ControlesCamiones.IdControl, ControlesCamiones.FechaControl, ControlesCamiones.GastosTaller, ControlesCamiones.Detalle FROM ControlesCamiones WHERE ControlesCamiones.IdCamion='" & CampoClaveStr & "' AND ControlesCamiones.Detalle LIKE '%" & WMTextBox_Buscar.Text & "%' AND ControlesCamiones.Estado=1 ORDER BY ControlesCamiones.FechaControl DESC;", CS)
        Else
            ActualizarTabla(DataGridView_Historial, "SELECT ControlesCamiones.IdControl, ControlesCamiones.FechaControl, ControlesCamiones.GastosTaller, ControlesCamiones.Detalle FROM ControlesCamiones WHERE ControlesCamiones.IdCamion='" & CampoClaveStr & "' AND ControlesCamiones.Estado=1 ORDER BY ControlesCamiones.FechaControl DESC;", CS)
        End If
        If DataGridView_Historial.Rows.Count > 0 Then
            DataGridView_Historial.Columns(0).Visible = False
            DataGridView_Historial.Columns(1).HeaderText = "Fecha"
            DataGridView_Historial.Columns(2).HeaderText = "Gastos"
            DataGridView_Historial.Rows(0).Selected = True
            CampoClaveInt = DataGridView_Historial.SelectedRows(0).Cells(0).Value
        End If
    End Sub

    Private Sub WMTextBox_Buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WMTextBox_Buscar.TextChanged
        Busqueda()
    End Sub

    Private Sub DataGridView_Historial_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView_Historial.CurrentCellChanged
        If DataGridView_Historial.SelectedRows.Count > 0 Then
            CampoClaveInt = DataGridView_Historial.SelectedRows(0).Cells(0).Value
        End If
    End Sub

    Private Sub DataGridView_Historial_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView_Historial.DoubleClick
        Bot_VerDatos.PerformClick()
    End Sub

#End Region

#Region "VALIDACION DE DATOS KEYPRESS"

    Private Sub TextBox_Gastos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_Gastos.KeyPress
        'Solo permite Números.-
        If InStr("0123456789" & Chr(8), e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

#End Region
End Class