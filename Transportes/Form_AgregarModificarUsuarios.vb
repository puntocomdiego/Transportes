Public Class Form_AgregarModificarUsuarios

    Private Sub Form_AgregarModificarUsuarios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Si Modifica o Ve.-
        If Me.Tag = "2" Or Me.Tag = "3" Or Me.Tag = "4" Then
            Dim ObjBD As New ClaseBD
            If ObjBD.Consulta("SELECT Usuarios.* FROM (Usuarios) WHERE (((Usuarios.IdUsuario)=" & CampoClaveInt & "));") = True Then
                Me.Label_Titulo.Text = "Modificar Usuario"
                Me.TextBox_Nombre.Text = DatosConsulta.Rows(0).Item("Nombre")
                Me.TextBox_Apellido.Text = DatosConsulta.Rows(0).Item("Apellido")
                Me.TextBox_CI.Text = DatosConsulta.Rows(0).Item("CI")
                Me.TextBox_Direccion.Text = DatosConsulta.Rows(0).Item("Direccion")
                Me.TextBox_Telefono.Text = DatosConsulta.Rows(0).Item("Telefono")
                Bot_Volver.Visible = False
                Label_Contraseña.Visible = True
            End If
        End If

        'Si Ve.-
        If Me.Tag = "3" Or Me.Tag = "4" Then
            Me.Label_Titulo.Text = "Datos del Usuario"
            TextBox_Contraseña.Enabled = False
            Bot_Ver.Enabled = False
            TextBox_ConfirmarContraseña.Enabled = False
            Bot_Ver2.Enabled = False
            Label_Contraseña.Visible = False
            Bot_Guardar.Text = "Modificar"
            Bot_Cancelar.Text = "Volver"
            For Each H As Control In Me.Controls
                If TypeOf H Is TextBox Then
                    Dim TB As TextBox = DirectCast(H, TextBox)
                    TB.ReadOnly = True
                End If
            Next
        End If

        'Si Restaura.-
        If Me.Tag = "4" Then
            Label_Titulo.Text += " Eliminado"
            Bot_Guardar.Text = "Restaurar"
        End If

        TextBox_Nombre.Focus()
    End Sub

#Region "BOTONES CONTRASEÑA"

    Private Sub Bot_Ver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Ver.Click
        If TextBox_Contraseña.PasswordChar = "*" Then
            TextBox_Contraseña.PasswordChar = ""
        Else
            TextBox_Contraseña.PasswordChar = "*"
        End If
    End Sub

    Private Sub Bot_Ver2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Ver2.Click
        If TextBox_ConfirmarContraseña.PasswordChar = "*" Then
            TextBox_ConfirmarContraseña.PasswordChar = ""
        Else
            TextBox_ConfirmarContraseña.PasswordChar = "*"
        End If
    End Sub

#End Region

#Region "BOTONES ABM"

    Private Sub Bot_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Guardar.Click
        'Verificaciones.-
        If Me.Tag = "1" Or Me.Tag = "2" Then 'Si está Agregando o Modificando.-
            If TextBox_Nombre.Text = "" Or TextBox_Apellido.Text = "" Then
                MsgBox("Debe ingresar el Nombre y Apellido del usuario para guardar", MsgBoxStyle.Information, "¡Atención!")
                TextBox_Nombre.Focus()
                Exit Sub
            End If
            If TextBox_CI.Text = "" Then
                MsgBox("Debe ingresar la Cédula de Idéntidad del usuario para guardar", MsgBoxStyle.Information, "¡Atención!")
                TextBox_CI.Focus()
                Exit Sub
            End If
            'Verificar que no exista CI.-
            Dim CIOrig As Integer = DatosConsulta.Rows(0).Item("CI")
            If CIOrig <> Val(TextBox_CI.Text) Then
                Dim ObjConsultaCI As New ClaseBD
                If ObjConsultaCI.Consulta("SELECT Usuarios.CI FROM Usuarios WHERE Usuarios.CI=" & Val(TextBox_CI.Text)) = True Then
                    If DatosConsulta.Rows.Count > 0 Then
                        MsgBox("La CI ingresada ya corresponde a un Usuario, verifique los datos", MsgBoxStyle.Exclamation, "¡Atención!")
                        TextBox_CI.Focus()
                        Exit Sub
                    End If
                End If
            End If
        End If

        Select Case Me.Tag
            Case Is = "1" 'Si está Agregando.-
                'Verificar contraseña.-
                If TextBox_Contraseña.Text = "" Or TextBox_Contraseña.Text <> TextBox_ConfirmarContraseña.Text Then
                    MsgBox("Debe ingresar una contraseña y confirmarla para guardar", MsgBoxStyle.Information, "¡Atención!")
                    TextBox_Contraseña.Focus()
                    Exit Sub
                End If

                'Guardando datos.-
                Dim ObjAgregar As New ClaseBD
                If ObjAgregar.Agregar("INSERT INTO Usuarios (Nombre, Apellido, Direccion, Telefono, CI, Contraseña, FechaRegistro) VALUES ('" & TextBox_Nombre.Text & "','" & TextBox_Apellido.Text & "','" & TextBox_Direccion.Text & "', '" & TextBox_Telefono.Text & "', '" & TextBox_CI.Text & "', '" & TextBox_Contraseña.Text & "', '" & DateTime.Now.ToString("d") & "')") = True Then
                    Select Case MessageBox.Show("Se han guardado los datos, ¿Desea continuar agregando Usuarios?", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        Case Windows.Forms.DialogResult.Yes
                            Call LimpiarTextboxForm(Me)
                        Case Windows.Forms.DialogResult.No
                            Me.Close()
                    End Select
                Else
                    MsgBox("No se han podido guardar los datos", MsgBoxStyle.Exclamation, "¡Atención!")
                End If

            Case Is = "2" 'Si está Modificando.-
                'Verificar Contraseña.-
                If (TextBox_Contraseña.Text <> "" Or TextBox_ConfirmarContraseña.Text <> "") And TextBox_Contraseña.Text <> TextBox_ConfirmarContraseña.Text Then
                    MsgBox("Las contraseñas no coinciden, deben coincidir si desea modificarla", MsgBoxStyle.Information, "¡Atención!")
                    TextBox_Contraseña.Focus()
                    Exit Sub
                End If

                'Actualizando datos.-
                Select Case MessageBox.Show("¿Está seguro de querer guardar los cambios? Esta acción no se podrá revertir", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    Case Windows.Forms.DialogResult.Yes
                        Dim ObjModificar As New ClaseBD
                        'Si quiere cambiar la contraseña.-
                        If TextBox_Contraseña.Text = "" Then
                            If ObjModificar.Modificar("UPDATE Usuarios SET Nombre='" & TextBox_Nombre.Text & "',Apellido='" & TextBox_Apellido.Text & "',Telefono='" & TextBox_Telefono.Text & "',Direccion='" & TextBox_Direccion.Text & "',CI='" & TextBox_CI.Text & "' WHERE Usuarios.IdUsuario=" & CampoClaveInt) = True Then
                                MsgBox("Se han modificado los datos del Usuario y la contraseña.", MsgBoxStyle.Information, "Cambios Guardados")
                                Me.Close()
                            Else
                                MsgBox("No se han podido modificar los datos del Usuario. Vuelva a intentarlo más tarde.", MsgBoxStyle.Information, "¡Atención!")
                                Exit Sub
                            End If
                        Else 'Si no quiere cambiar la contraseña.-
                            If ObjModificar.Modificar("UPDATE Usuarios SET Nombre='" & TextBox_Nombre.Text & "',Apellido='" & TextBox_Apellido.Text & "',Telefono='" & TextBox_Telefono.Text & "',Direccion='" & TextBox_Direccion.Text & "',CI='" & TextBox_CI.Text & "',Contraseña='" & TextBox_Contraseña.Text & "' WHERE Usuarios.IdUsuario=" & CampoClaveInt) = True Then
                                MsgBox("Se han modificado los datos del Usuario.", MsgBoxStyle.Information, "Cambios Guardados")
                                Me.Close()
                            Else
                                MsgBox("No se han podido modificar los datos del Usuario. Vuelva a intentarlo más tarde.", MsgBoxStyle.Information, "¡Atención!")
                                Exit Sub
                            End If
                        End If
                    Case Windows.Forms.DialogResult.No
                        Exit Sub
                End Select

            Case Is = "3" 'Si está Viendo.-
                For Each H As Control In Me.Controls
                    If TypeOf H Is TextBox Then
                        Dim TB As TextBox = DirectCast(H, TextBox)
                        TB.ReadOnly = False
                    End If
                Next
                Bot_Guardar.Text = "Guardar"
                Bot_Cancelar.Text = "Cancelar"
                Label_Titulo.Text = "Modificar Cliente"
                TextBox_Contraseña.Enabled = True
                Bot_Ver.Enabled = True
                TextBox_ConfirmarContraseña.Enabled = True
                Bot_Ver2.Enabled = True
                Label_Contraseña.Visible = True
                Me.Tag = "2"

            Case Is = "4" 'Si está Restaurando.-
                Select Case MessageBox.Show("¿Está seguro de querer Restaurar este dato?", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    Case Windows.Forms.DialogResult.Yes
                        Dim ObjEliminar As New ClaseBD
                        If ObjEliminar.Modificar("UPDATE Usuarios SET Usuarios.Estado = 1 WHERE Usuarios.IdUsuario=" & CampoClaveInt) = True Then
                            MsgBox("Se ha Restaurado correctamente", MsgBoxStyle.Information, "Restaurado Correctamente")
                            Me.Close()
                        Else
                            MsgBox("No se ha podido Restaurar el dato, vuelva a intentarlo más tarde", MsgBoxStyle.Exclamation, "Error")
                        End If
                    Case Windows.Forms.DialogResult.No
                        Exit Sub
                End Select
        End Select
    End Sub

    Private Sub Bot_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Cancelar.Click
        'Si está Viendo o Restaurando.-
        If Me.Tag = "3" Or Me.Tag = "4" Then
            Me.Close()
            Exit Sub
        End If

        'Si está Agregando o Modificando.-
        Select Case MessageBox.Show("¿Está seguro de querer cancelar? Se perderán los cambios no guardados", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            Case Windows.Forms.DialogResult.Yes
                If Me.Tag = "2" Then
                    Me.Close()
                Else
                    Call LimpiarTextboxForm(Me)
                End If
            Case Windows.Forms.DialogResult.No
                Exit Sub
        End Select
    End Sub

    Private Sub Bot_Volver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Volver.Click
        Select Case MessageBox.Show("¿Está seguro de querer volver? Se perderán los cambios no guardados", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            Case Windows.Forms.DialogResult.Yes
                Me.Close()
            Case Windows.Forms.DialogResult.No
                Exit Sub
        End Select
    End Sub

#End Region

#Region "VALIDACIÓN DE DATOS KEYPRESS"

    Private Sub TextBox_CI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_CI.KeyPress
        'Solo permite Números.-
        If InStr("0123456789" & Chr(8), e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

#End Region

End Class