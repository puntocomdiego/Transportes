Imports System.Data
Imports System.Data.OleDb
Imports System.Reflection

Public Class Form_LogIn

    Private Sub Form_LogIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label_Version.Text = "v" & Assembly.GetExecutingAssembly().GetName().Version.ToString 'Coloca Version en Label_Version.-
    End Sub

#Region "INICIANDO SESION"

    Private Sub Bot_Ingresar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Bot_Ingresar.Click
        Try
            If TextBox_Nombre.Text = "" Or TextBox_Contraseña.Text = "" Then
                MsgBox("Ingrese nombre de Usuario y Contraseña", MsgBoxStyle.Information, "¡Atención!")
                TextBox_Nombre.Focus()
                Exit Sub
            Else
                Dim sql As String = "SELECT * FROM Usuarios WHERE (CI=" & Val(TextBox_Nombre.Text) & " OR Nombre='" & TextBox_Nombre.Text & "') AND Contraseña='" & TextBox_Contraseña.Text & "';"
                Dim da As New OleDbDataAdapter(sql, CS)
                Dim dt As New DataTable
                da.Fill(dt) 'Lleno dt con consulta.-
                If dt.Rows.Count = 0 Then
                    MsgBox("El Usuario o Contraseña ingresados no es correcto", MsgBoxStyle.Critical, "Error")
                    Exit Sub
                Else
                    'Verifica el estado del Usuario.-
                    If dt.Rows(0).Item("Estado") = 0 Then
                        MsgBox("Su usuario se encuentra desactivado, contáctese con un administrador para restablecerlo", MsgBoxStyle.Exclamation, "Usuario Bloqueado")
                        Exit Sub
                    End If

                    'Verifica que la resolución sea la mínima.-
                    If Val(Screen.PrimaryScreen.Bounds.Width) < Val(Form_MenuPrincipal.MinimumSize.Width) Or Val(Screen.PrimaryScreen.Bounds.Height) < Val(Form_MenuPrincipal.MinimumSize.Height) Then
                        Select Case MessageBox.Show("Su resolución no cumple los estándares mínimos, puede continuar, pero es posible que el programa no funcione correctamente" & vbNewLine & "¿Desea Continuar?", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                            Case MsgBoxResult.No
                                End
                        End Select
                    End If
                    DatosUsuario = dt
                    Form_MenuPrincipal.Show()
                    Me.Hide()
                End If
            End If
        Catch exsql As OleDbException
            MsgBox("Error al cargar los Datos: " & exsql.Message)
        Catch ex As Exception
            MsgBox("Error al cargar los Datos: " & ex.Message)
        End Try
    End Sub

#End Region

#Region "CONTROLES"

    'Permite Ver/Ocultar la Contraseña.-
    Private Sub PictureBox_Ver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Ver.Click
        If TextBox_Contraseña.PasswordChar = "*" Then
            TextBox_Contraseña.PasswordChar = ""
        Else
            TextBox_Contraseña.PasswordChar = "*"
        End If
    End Sub

    Private Sub Bot_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Salir.Click
        End
    End Sub

    Private Sub Bot_Borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Borrar.Click
        TextBox_Nombre.Text = ""
    End Sub

#End Region

#Region "KEYPRESS DE LOS TEXTBOX"

    'Cuando el Usuario apretar Enter cambia al TextBox de abajo o Presiona Ingresar.-
    Private Sub TextBox_Enter_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_Nombre.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            TextBox_Contraseña.Focus()
        End If
    End Sub

    Private Sub TextBox_Contraseña_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_Contraseña.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            Bot_Ingresar.PerformClick()
        End If
    End Sub

#End Region
End Class