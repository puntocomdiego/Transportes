Public Class Form_BuscarVehiculos

    Private Sub Form_BuscarVehiculos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Busqueda()
    End Sub

    Private Sub Bot_Borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Borrar.Click
        WMTextBox_Buscar.Text = ""
    End Sub

#Region "BOTONES ABMV"

    Private Sub Bot_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Agregar.Click
        AbrirPanel()
        DatePicker_Proximo.Value = DateTime.Today
        DatePicker_Ultimo.Value = DateTime.Today
        Label_Accion.Text = sender.Tag
        For Each H As Control In Me.GroupBox_Camion.Controls
            If TypeOf H Is TextBox Then
                Dim TB As TextBox = DirectCast(H, TextBox)
                TB.ReadOnly = False
            End If
        Next
        For Each H As Control In Me.GroupBox_Mantenimiento.Controls
            If TypeOf H Is TextBox Then
                Dim TB As TextBox = DirectCast(H, TextBox)
                TB.ReadOnly = False
            End If
        Next
        DatePicker_Ultimo.Enabled = True
        DatePicker_Proximo.Enabled = True
        Bot_Guardar.Text = "Guardar"
        Bot_Cancelar.Text = "Cancelar"
    End Sub

    Private Sub Botones_ModificarVer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Modificar.Click, Bot_VerDatos.Click
        If DataGridView_Camiones.SelectedRows.Count <= 0 Then
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
            Case Is = "Datos Vehículo"
                For Each H As Control In Me.GroupBox_Camion.Controls
                    If TypeOf H Is TextBox Then
                        Dim TB As TextBox = DirectCast(H, TextBox)
                        TB.ReadOnly = True
                        TB.BackColor = Color.White
                    End If
                Next
                For Each H As Control In Me.GroupBox_Mantenimiento.Controls
                    If TypeOf H Is TextBox Then
                        Dim TB As TextBox = DirectCast(H, TextBox)
                        TB.ReadOnly = True
                        TB.BackColor = Color.White
                    End If
                Next
                DatePicker_Ultimo.Enabled = False
                DatePicker_Proximo.Enabled = False
                Bot_Guardar.Text = "Modificar"
                Bot_Cancelar.Text = "Volver"
            Case Is = "Modificar Vehículo"
                'Label_Accion.Text = sender.Tag
                For Each H As Control In Me.GroupBox_Camion.Controls
                    If TypeOf H Is TextBox Then
                        Dim TB As TextBox = DirectCast(H, TextBox)
                        TB.ReadOnly = False
                    End If
                Next
                For Each H As Control In Me.GroupBox_Mantenimiento.Controls
                    If TypeOf H Is TextBox Then
                        Dim TB As TextBox = DirectCast(H, TextBox)
                        TB.ReadOnly = False
                    End If
                Next
                DatePicker_Ultimo.Enabled = True
                DatePicker_Proximo.Enabled = True
                Bot_Guardar.Text = "Guardar"
                Bot_Cancelar.Text = "Cancelar"
        End Select
    End Sub

    Private Sub Bot_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Eliminar.Click
        If DataGridView_Camiones.SelectedRows.Count > 0 Then
            Select Case MessageBox.Show("¿Está seguro de querer Eliminar este Vehículo? Esta acción la puede revertir en la ventana Restaurar Eliminados", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                Case Windows.Forms.DialogResult.Yes
                    Dim ObjEliminar As New ClaseBD
                    If ObjEliminar.Modificar("UPDATE Camiones SET Camiones.Estado = 0 WHERE Camiones.IdCamion='" & CampoClaveStr & "';") = True Then
                        MsgBox("Se ha eliminado correctamente el Vehículo, si desea deshacer esta acción vaya a Restaurar Eliminados", MsgBoxStyle.Information, "Eliminado Correctamente")
                        Busqueda()
                        ConsultaNofiticacion()
                        ConsultaNofiticacion2()
                    Else
                        MsgBox("No se ha podido eliminar el Vehículo, vuelva a intentarlo más tarde", MsgBoxStyle.Exclamation, "Error")
                    End If
                Case Windows.Forms.DialogResult.No
                    Exit Sub
            End Select
        Else
            MsgBox("Debe seleccionar un Vehículo primero para eliminarlo.", MsgBoxStyle.Information, "¡Atención!")
            Exit Sub
        End If
    End Sub

#End Region

#Region "ADMINISTRACIÓN DATOS"

    Private Sub Bot_Historial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Historial.Click
        If DataGridView_Camiones.SelectedRows.Count <= 0 Then
            MsgBox("Debe seleccionar un vehículo primero para ver su historial", MsgBoxStyle.Information, "¡Atención!")
            Exit Sub
        End If
        AbrirSegundoInPanel(New Form_HistorialVehiculos, Form_MenuPrincipal.Panel_AreaDeTrabajo, "")
    End Sub

#End Region

#Region "PANEL ABM"

    Private Sub AbrirPanel()
        Panel_Accion.Visible = True
        Panel_Busqueda.Left = (Me.Width / 2) - ((Panel_Busqueda.Width + Panel_Accion.Width) / 2)
        Panel_Accion.Left = Panel_Busqueda.Right
        Panel_Busqueda.Enabled = False
    End Sub

    Private Sub Bot_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Guardar.Click
        Select Case sender.Text
            Case Is = "Guardar" 'Si está Agregando o Modificando.-
                'Verifricaciones.-
                If TextBox_Marca.Text = "" Or TextBox_Modelo.Text = "" Or TextBox_Matrícula.Text = "" Then
                    MsgBox("Debe ingresar marca, modelo y matrícula del vehiculo para poder guardar", MsgBoxStyle.Exclamation, "Atención")
                    Exit Sub
                End If
                'Verificando que Matrícula no exista.-
                If Label_Accion.Text = "Agregar Vehículo" Or (Label_Accion.Text = "Modificar Vehículo" And TextBox_Matrícula.Text <> CampoClaveStr) Then
                    Dim ObjConsultaM As New ClaseBD
                    If ObjConsultaM.Consulta("SELECT Camiones.IdCamion FROM Camiones WHERE Camiones.IdCamion='" & TextBox_Matrícula.Text & "';") = True Then
                        If DatosConsulta.Rows.Count > 0 Then
                            MsgBox("Ya existe un vehículo con la matrícula: " & DatosConsulta.Rows(0).Item("IdCamion") & "." & vbNewLine & "Verifique los datos ingresados", MsgBoxStyle.Information, "¡Atención!")
                            TextBox_Matrícula.Focus()
                            Exit Sub
                        End If
                    End If
                End If

                'Guardando Datos.-
                If Label_Accion.Text = "Agregar Vehículo" Then 'Si está Agregando.-
                    Dim ObjAgregar As New ClaseBD
                    If ObjAgregar.Agregar("INSERT INTO Camiones(IdCamion, Marca, Modelo, kmactual, kmaceite, kmcubiertas, SuctaDesde, SuctaHasta) VALUES ('" & TextBox_Matrícula.Text & "','" & TextBox_Marca.Text & "','" & TextBox_Modelo.Text & "', " & Val(TextBox_KMActuales.Text) & ", " & Val(TextBox_KMAceite.Text) & ", " & Val(TextBox_KMCubierta.Text) & ",'" & DatePicker_Ultimo.Text & "','" & DatePicker_Proximo.Text & "')") = True Then
                        Select Case MessageBox.Show("Se han guardado los datos, ¿Desea continuar agregando vehículos?", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            Case Windows.Forms.DialogResult.Yes
                                Call LimpiarTextboxGroupBox(Me.GroupBox_Camion)
                                Call LimpiarTextboxGroupBox(Me.GroupBox_Mantenimiento)
                                Exit Sub
                        End Select
                    Else
                        MsgBox("No se han podido guardar los datos", MsgBoxStyle.Exclamation, "¡Atención!")
                        Exit Sub
                    End If

                Else 'Si está Modificando.-
                    Select Case MessageBox.Show("¿Está seguro de querer guardar los cambios? Esta acción no se podrá revertir", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                        Case Windows.Forms.DialogResult.Yes
                            Dim ObjModificar As New ClaseBD
                            If ObjModificar.Modificar("UPDATE Camiones SET IdCamion='" & TextBox_Matrícula.Text & "',Marca='" & TextBox_Marca.Text & "',Modelo='" & TextBox_Modelo.Text & "',kmactual='" & TextBox_KMActuales.Text & "',kmaceite='" & TextBox_KMAceite.Text & "',kmcubiertas='" & TextBox_KMCubierta.Text & "',SuctaDesde='" & DatePicker_Ultimo.Text & "',SuctaHasta='" & DatePicker_Proximo.Text & "' WHERE Camiones.IdCamion='" & CampoClaveStr & "'") = True Then
                                MsgBox("Se han modificado los datos del vehículo.", MsgBoxStyle.Information, "Cambios Guardados")
                                Call LimpiarTextboxGroupBox(Me.GroupBox_Camion)
                                Call LimpiarTextboxGroupBox(Me.GroupBox_Mantenimiento)
                            Else
                                MsgBox("No se han podido modificar los datos del vehículo. Vuelva a intentarlo más tarde.", MsgBoxStyle.Information, "¡Atención!")
                                Call LimpiarTextboxGroupBox(Me.GroupBox_Camion)
                                Call LimpiarTextboxGroupBox(Me.GroupBox_Mantenimiento)
                                Exit Sub
                            End If
                        Case Windows.Forms.DialogResult.No
                            Exit Sub
                    End Select
                End If
                Panel_Accion.Visible = False
                Panel_Busqueda.Enabled = True
                Panel_Busqueda.Left = 66

            Case Is = "Modificar" 'Si quiere pasar de Ver a Modificar.-
                Label_Accion.Text = "Modificar Vehículo"
                For Each H As Control In Me.GroupBox_Camion.Controls
                    If TypeOf H Is TextBox Then
                        Dim TB As TextBox = DirectCast(H, TextBox)
                        TB.ReadOnly = False
                    End If
                Next
                For Each H As Control In Me.GroupBox_Mantenimiento.Controls
                    If TypeOf H Is TextBox Then
                        Dim TB As TextBox = DirectCast(H, TextBox)
                        TB.ReadOnly = False
                    End If
                Next
                DatePicker_Ultimo.Enabled = True
                DatePicker_Proximo.Enabled = True
                Bot_Guardar.Text = "Guardar"
                Bot_Cancelar.Text = "Cancelar"
        End Select
    End Sub

    Private Sub Bot_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Cancelar.Click
        If Bot_Cancelar.Text = "Cancelar" Then 'Si está Agregando o Modificando.-
            Select Case MessageBox.Show("¿Está seguro de querer salir? Se perderán los cambios no guardados", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                Case Windows.Forms.DialogResult.Yes
                    LimpiarTextboxGroupBox(GroupBox_Camion)
                    LimpiarTextboxGroupBox(GroupBox_Mantenimiento)
                    Panel_Accion.Visible = False
                    Panel_Busqueda.Left = 66
                Case Windows.Forms.DialogResult.No
                    Exit Sub
            End Select

        Else 'Si está Viendo.-
            LimpiarTextboxGroupBox(GroupBox_Camion)
            LimpiarTextboxGroupBox(GroupBox_Mantenimiento)
            Panel_Accion.Visible = False
            Panel_Busqueda.Left = 66
        End If
        Panel_Busqueda.Enabled = True
    End Sub

    Private Sub Panel_Accion_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel_Accion.VisibleChanged
        'Cuando se cierra el Panel se actualiza el DataGrid y la Notificacion.-
        If Panel_Accion.Visible = False Then
            Busqueda()
            ConsultaNofiticacion()
            ConsultaNofiticacion2()
        End If
    End Sub

#End Region

#Region "BUSQUEDA DE DATOS"

    Private Sub Busqueda()
        If WMTextBox_Buscar.Text <> "" Then
            ActualizarTabla(DataGridView_Camiones, "SELECT Camiones.idcamion, Camiones.Marca, Camiones.Modelo, Camiones.kmactual, (10000 - Camiones.kmaceite) FROM Camiones WHERE (Camiones.idcamion Like '%" & WMTextBox_Buscar.Text & "%' OR Camiones.Marca Like '%" & WMTextBox_Buscar.Text & "%' OR Camiones.Modelo Like '%" & WMTextBox_Buscar.Text & "%') AND Camiones.Estado=1;", CS)
        Else
            ActualizarTabla(DataGridView_Camiones, "SELECT Camiones.idcamion, Camiones.Marca, Camiones.Modelo, Camiones.kmactual, (10000 - Camiones.kmaceite) FROM Camiones WHERE Camiones.Estado=1;", CS)
        End If
        If DataGridView_Camiones.Rows.Count > 0 Then
            DataGridView_Camiones.Columns(0).HeaderText = "Matrícula"
            DataGridView_Camiones.Columns(3).HeaderText = "KM Total"
            DataGridView_Camiones.Columns(4).HeaderText = "KM para cambio de Aceite"
            DataGridView_Camiones.Rows(0).Selected = True
            CampoClaveStr = DataGridView_Camiones.Rows(0).Cells(0).Value
        End If
    End Sub

    Private Sub WMTextBox_Buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WMTextBox_Buscar.TextChanged
        Busqueda()
    End Sub

    Private Sub DataGridView_Camiones_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView_Camiones.CurrentCellChanged
        If DataGridView_Camiones.SelectedRows.Count > 0 Then
            CampoClaveStr = DataGridView_Camiones.SelectedRows(0).Cells(0).Value
        End If
    End Sub

    Private Sub DataGridView_Camiones_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView_Camiones.DoubleClick
        Bot_VerDatos.PerformClick()
    End Sub

#End Region

#Region "VALIDACIÓN DE DATOS KEYPRESS"

    Private Sub TextBox_KM_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_KMActuales.KeyPress, TextBox_KMAceite.KeyPress, TextBox_KMCubierta.KeyPress
        'Solo permite Números.-
        If InStr("0123456789" & Chr(8), e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub DataGridView_Camiones_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView_Camiones.CellFormatting
        DataGridView_Camiones.Columns(4).HeaderCell.Style.Font = New Font("Century Gothic", 9, FontStyle.Regular)
        For Each Row As DataGridViewRow In DataGridView_Camiones.Rows
            If Val(Row.Cells(4).Value) > 0 And Val(Row.Cells(4).Value) <= 1000 Then
                Row.DefaultCellStyle.BackColor = Color.MediumSeaGreen
                Row.DefaultCellStyle.ForeColor = Color.White
            ElseIf Val(Row.Cells(4).Value) < 0 Then
                Row.DefaultCellStyle.BackColor = Color.Firebrick
                Row.DefaultCellStyle.ForeColor = Color.White
            Else
                Row.DefaultCellStyle.BackColor = Color.White
                Row.DefaultCellStyle.ForeColor = Color.Black
            End If
        Next
    End Sub

#End Region
End Class