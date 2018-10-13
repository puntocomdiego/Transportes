
Public Class Form_AgregarModificarClientes

    Private Sub Form_AgregarModificarClientes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Si Modifica, Vé o Restaura.-
        If Me.Tag = "2" Or Me.Tag = "3" Or Me.Tag = "4" Then
            Try
                Dim ObjBD As New ClaseBD
                If ObjBD.Consulta("SELECT Clientes.* FROM (Clientes) WHERE (((Clientes.IdCliente)=" & CampoClaveInt & "));") = True Then
                    Me.Label_Titulo.Text = "Modificar Cliente"
                    Me.TextBox_Nombre.Text = DatosConsulta.Rows(0).Item("Nombre")
                    Me.TextBox_Direccion.Text = DatosConsulta.Rows(0).Item("Direccion")
                    Me.TextBox_Telefono.Text = DatosConsulta.Rows(0).Item("Telefono")
                    Me.TextBox_Celular.Text = DatosConsulta.Rows(0).Item("Celular")
                    Me.TextBox_Correo.Text = DatosConsulta.Rows(0).Item("Correo")
                    Me.TextBox_Registrado.Text = DatosConsulta.Rows(0).Item("FechaRegistro")
                    Me.TextBox_Campo1.Text = DatosConsulta.Rows(0).Item("Campo1")
                    Me.TextBox_DISCOSE1.Text = DatosConsulta.Rows(0).Item("DICOSE1")
                    Me.TextBox_Campo2.Text = DatosConsulta.Rows(0).Item("Campo2")
                    Me.TextBox_DISCOSE2.Text = DatosConsulta.Rows(0).Item("DICOSE2")
                    Me.TextBox_RUT.Text = DatosConsulta.Rows(0).Item("RUT")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                Me.Close()
                Exit Sub
            End Try
            Bot_Volver.Visible = False
        End If

        'Si Vé o Restaura.-
        If Me.Tag = "3" Or Me.Tag = "4" Then
            TextBox_Registrado.Visible = True
            Label_Registrado.Visible = True
            Label_Titulo.Text = "Datos del Cliente"
            Bot_Guardar.Text = "Modificar"
            Bot_Cancelar.Text = "Volver"
            For Each H As Control In Me.Controls
                If TypeOf H Is TextBox Then
                    Dim TB As TextBox = DirectCast(H, TextBox)
                    TB.ReadOnly = True
                    TB.BackColor = Color.White
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

#Region "BOTONES ABM"

    Private Sub Bot_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Guardar.Click
        'Verificaciones.-
        If Me.Tag = "1" Or Me.Tag = "2" Then
            If TextBox_Nombre.Text = "" Then
                MsgBox("Debe ingresar el Nombre y Apellido del usuario para guardar", MsgBoxStyle.Information, "¡Atención!")
                TextBox_Nombre.Focus()
                Exit Sub
            End If
            If TextBox_Telefono.Text = "" And TextBox_Celular.Text = "" Then
                MsgBox("Debe ingresar un contacto para guardar", MsgBoxStyle.Information, "¡Atención!")
                TextBox_Telefono.Focus()
                Exit Sub
            End If
        End If

        Select Case Me.Tag
            Case Is = "1" 'Si está Agregando.-
                Dim ObjAgregar As New ClaseBD
                If ObjAgregar.Agregar("INSERT INTO Clientes (Nombre, Direccion, Telefono, Celular, RUT, Correo, Campo1, DICOSE1, Campo2, DICOSE2, FechaRegistro) VALUES ('" & TextBox_Nombre.Text & "','" & TextBox_Direccion.Text & "','" & TextBox_Telefono.Text & "', '" & TextBox_Celular.Text & "', '" & TextBox_RUT.Text & "', '" & TextBox_Correo.Text & "','" & TextBox_Campo1.Text & "','" & TextBox_DISCOSE1.Text & "','" & TextBox_Campo2.Text & "','" & TextBox_DISCOSE2.Text & "','" & DateTime.Now.ToString("d") & "')") = True Then
                    Select Case MessageBox.Show("Se han guardado los datos, ¿Desea continuar agregando clientes?", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        Case Windows.Forms.DialogResult.Yes
                            Call LimpiarTextboxForm(Me)
                        Case Windows.Forms.DialogResult.No
                            Me.Close()
                    End Select
                Else
                    MsgBox("No se han podido guardar los datos. Vuelva a intentarlo más tarde", MsgBoxStyle.Exclamation, "¡Atención!")
                End If

            Case Is = "2" 'Si está Modificando.-
                Select Case MessageBox.Show("¿Está seguro de querer guardar los cambios? Esta acción no se podrá revertir", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    Case Windows.Forms.DialogResult.Yes
                        Dim ObjModificar As New ClaseBD
                        If ObjModificar.Modificar("UPDATE Clientes SET Nombre='" & TextBox_Nombre.Text & "',Direccion='" & TextBox_Direccion.Text & "',Telefono='" & TextBox_Telefono.Text & "',Celular='" & TextBox_Celular.Text & "',RUT='" & TextBox_RUT.Text & "',Correo='" & TextBox_Correo.Text & "',Campo1='" & TextBox_Campo1.Text & "',DICOSE1='" & TextBox_DISCOSE1.Text & "',Campo2='" & TextBox_Campo2.Text & "',DICOSE2='" & TextBox_DISCOSE2.Text & "' WHERE Clientes.IdCliente=" & DatosConsulta.Rows(0).Item("IdCliente")) = True Then
                            MsgBox("Se han modificado los datos del cliente.", MsgBoxStyle.Information, "Cambios Guardados")
                            Me.Close()
                        Else
                            MsgBox("No se han podido modificar los datos del cliente. Vuelva a intentarlo más tarde.", MsgBoxStyle.Exclamation, "¡Atención!")
                            Exit Sub
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
                TextBox_Registrado.Visible = False
                Label_Registrado.Visible = False
                Label_Titulo.Text = "Modificar Cliente"
                Bot_Guardar.Text = "Guardar"
                Bot_Cancelar.Text = "Cancelar"
                Me.Tag = "2"

            Case Is = "4" 'Si está Restaurando.-
                Select Case MessageBox.Show("¿Está seguro de querer Restaurar este dato?", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    Case Windows.Forms.DialogResult.Yes
                        Dim ObjEliminar As New ClaseBD
                        If ObjEliminar.Modificar("UPDATE Clientes SET Clientes.Estado = 1 WHERE Clientes.IdCliente=" & CampoClaveInt) = True Then
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

End Class