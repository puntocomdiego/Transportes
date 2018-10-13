Imports System.Threading
Imports System.Net.Mail

Public Class Form_MenuPrincipal
    Dim PositionForm(1) As Integer 'Guarda la Posición del Form para el botón Maximizar.-
    Dim Adjunto As String 'Variable array para adjuntos.-
    Dim oHebra As Thread 'Instanciar la hebra.-
    'Objeto SMTP.-
    Dim SMPT As New SmtpClient
    Dim V() As String
    Dim u As Integer

    Private Sub Form_MenuPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Label_NombreUser.Text = DatosUsuario.Rows(0).Item("Nombre") & " " & DatosUsuario.Rows(0).Item("Apellido") 'Trae el Nombre del Usuario desde la DataTable DatosUsuario donde se mantienen guardados.-
        Timer1.Enabled = True
        Bot_Maximizar.PerformClick()
        Bot_Inicio.PerformClick()
        ConsultaNofiticacion()
        ConsultaNofiticacion2()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label_FechaHora.Text = DateTime.Now.ToString 'Actualiza la Feha y Hora en el Label del usuario.-
    End Sub

#Region "BOTONES MENÚ VERTICAL"

    'Coloca el Panel verde en el botón seleccionado y cambia los titulos e iconos de los Labels.-
    Private Sub BotMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Inicio.Click, Bot_Clientes.Click, Bot_Vehiculos.Click, Bot_TiposCarga.Click, Bot_LugaresCarga.Click, Bot_OrdenesCD.Click, Bot_Saldos.Click, Bot_Sucta.Click, Bot_Eliminados.Click, Bot_Usuarios.Click
        Panel_Seleccionado.Top = sender.Top
        Panel_Seleccionado.Visible = True
        Label_VentanaActual.Text = sender.Text
        Label_TituloVentana.Text = sender.Text
        Me.Text = "Transportes - " & sender.Text
        PictureBox_Activo.Image = sender.Image
    End Sub

    'Método que cierra cualquier Form abierto dentro del Panel_AreaDeTrabajo y abre el seleccionado dentro del mismo.-
    Private Sub Bot_Inicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Inicio.Click
        AbrirFormInPanel(New Form_MainScreen, Me.Panel_AreaDeTrabajo)
    End Sub

    Private Sub Bot_Clientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Clientes.Click
        AbrirFormInPanel(New Form_BuscarClientes, Me.Panel_AreaDeTrabajo)
    End Sub

    Private Sub Bot_Vehiculos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Vehiculos.Click
        AbrirFormInPanel(New Form_BuscarVehiculos, Me.Panel_AreaDeTrabajo)
    End Sub

    Private Sub Bot_TiposCarga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_TiposCarga.Click
        AbrirFormInPanel(New Form_TiposDeCarga, Me.Panel_AreaDeTrabajo)
    End Sub

    Private Sub Bot_LugaresCarga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_LugaresCarga.Click
        AbrirFormInPanel(New Form_LugaesDeCarga, Me.Panel_AreaDeTrabajo)
    End Sub

    Private Sub Bot_OrdenesCD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_OrdenesCD.Click
        AbrirFormInPanel(New Form_OrdenCargaDescarga, Me.Panel_AreaDeTrabajo)
    End Sub

    Private Sub Bot_Saldos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Saldos.Click
        AbrirFormInPanel(New Form_Saldos, Me.Panel_AreaDeTrabajo)
    End Sub

    Private Sub Bot_Sucta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Sucta.Click
        AbrirFormInPanel(New Form_VencimientosSucta, Me.Panel_AreaDeTrabajo)
    End Sub

    Private Sub Bot_Eliminados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Eliminados.Click
        AbrirFormInPanel(New Form_RestaurarEliminados, Me.Panel_AreaDeTrabajo)
    End Sub

    Private Sub Bot_Usuarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Usuarios.Click
        AbrirFormInPanel(New Form_BuscarUsuarios, Me.Panel_AreaDeTrabajo)
    End Sub

    Private Sub Bot_Respaldo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Respaldo.Click
        If (MessageBox.Show("¿Está seguro que desea realizar un respaldo en Google Drive?" & vbNewLine & "No debe cerrar el programa ni apagar el equipo hasta que se complete la operación.", "Respaldando datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        'Obtenemos los adjuntos.-
        Adjunto = RutaBD
        Me.Cursor = Cursors.WaitCursor
        Me.Panel_AreaDeTrabajo.Cursor = Cursors.WaitCursor
        Me.Enabled = False
        'Poner en marcha la hebra.-
        oHebra = New Thread(AddressOf Envio)
        oHebra.Start()
    End Sub

    Private Sub Bot_Recuperacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Recuperacion.Click
        MsgBox("Función no Disponible", MsgBoxStyle.Critical, "Error")
    End Sub

#End Region

#Region "BOTONES CONTROL DEL FORMULARIO"

    'Al cerrar Form_MenuPrincipal, desde botones o Alt+F4 en el evento FormClosing pregunta si está seguro.-
    Private Sub Botones_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Salir.Click, Bot_Cerrar.Click
        Me.Close()
    End Sub

    Private Sub Form_MenuPrincipal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If (MessageBox.Show("¿Está seguro de querer salir? Se perderán los cambios no guardados", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Information)) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        Else
            End
        End If
    End Sub

    'No utiliza la propiedad FormWindowState.Maximized porque al ser un Form con BorderStyle.None queda en pantalla completa,
    'En su lugar este código cambia el tamaño del Form al del Area de trabajo de Windows.-
    Private Sub Bot_Maximizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Maximizar.Click
        If Bot_Maximizar.Text = "O" Then
            PositionForm(0) = Me.Location.X
            PositionForm(1) = Me.Location.Y
            Me.Size = Screen.PrimaryScreen.WorkingArea.Size
            Me.Location = Screen.PrimaryScreen.WorkingArea.Location
            Bot_Maximizar.Text = "-"
        Else
            Me.Size = New Size(1280, 720)
            Me.Location = New Point(PositionForm(0), PositionForm(1))
            Bot_Maximizar.Text = "O"
        End If
    End Sub

    'El botón Minimizar simplemente cambia el FormWindowState a Minimized.-
    Private Sub Bot_Minimizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

#End Region

#Region "BOTONES DESPLEGABLES DEL MENÚ VERTICAL"

    'Estos botones cambian la propiedad Visible de los inferiores para contraer o desplegarse, ya que al estar todos con la propiedad Dock.Top se juntan solos.-
    Private Sub Bot_Menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Menu.Click
        If Bot_Clientes.Visible = True Then
            Bot_Inicio.Visible = False
            Bot_Clientes.Visible = False
            Bot_Vehiculos.Visible = False
            Bot_TiposCarga.Visible = False
            Bot_LugaresCarga.Visible = False
            Bot_OrdenesCD.Visible = False
            Bot_Salir.Visible = False
        Else
            Bot_Inicio.Visible = True
            Bot_Clientes.Visible = True
            Bot_Vehiculos.Visible = True
            Bot_TiposCarga.Visible = True
            Bot_LugaresCarga.Visible = True
            Bot_OrdenesCD.Visible = True
            Bot_Salir.Visible = True
        End If
    End Sub

    Private Sub Bot_InformesConsultas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_InformesConsultas.Click
        If Bot_Saldos.Visible = True Then
            Bot_Saldos.Visible = False
            Bot_Sucta.Visible = False
            Bot_Eliminados.Visible = False
        Else
            Bot_Saldos.Visible = True
            Bot_Sucta.Visible = True
            Bot_Eliminados.Visible = True
        End If
    End Sub

    Private Sub Bot_Configuracion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Configuracion.Click
        If Bot_Usuarios.Visible = True Then
            Bot_Usuarios.Visible = False
            Bot_Respaldo.Visible = False
            Bot_Recuperacion.Visible = False
        Else
            Bot_Usuarios.Visible = True
            Bot_Respaldo.Visible = True
            Bot_Recuperacion.Visible = True
        End If
    End Sub

    Private Sub Bot_Clientes_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bot_Inicio.VisibleChanged, Bot_Clientes.VisibleChanged, Bot_Vehiculos.VisibleChanged, Bot_TiposCarga.VisibleChanged, Bot_LugaresCarga.VisibleChanged, Bot_OrdenesCD.VisibleChanged, Bot_Saldos.VisibleChanged, Bot_Sucta.VisibleChanged, Bot_Eliminados.VisibleChanged, Bot_Usuarios.VisibleChanged
        If Panel_Seleccionado.Top = sender.Top Then
            Panel_Seleccionado.Visible = sender.Visible
        End If
    End Sub

#End Region

#Region "NOTIFICACION ACEITE"

    Private Sub Bot_Vehiculos_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bot_Vehiculos.LocationChanged
        Label_NotifAceite.Top = sender.Top + 8
    End Sub

    Private Sub Bot_Vehiculos_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bot_Vehiculos.VisibleChanged
        If Label_NotifAceite.Text <> "+00" Then
            Label_NotifAceite.Visible = sender.Visible
        End If
    End Sub

    Private Sub Label_NotifAceite_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label_NotifAceite.Click
        Bot_Vehiculos.PerformClick()
    End Sub

    Private Sub Label_NotifAceite_MouseHover(ByVal sender As Object, ByVal e As EventArgs) Handles Label_NotifAceite.MouseHover, Bot_Vehiculos.MouseHover
        Label_NotifAceite.BackColor = Color.FromArgb(49, 46, 48)
    End Sub

    Private Sub Bot_Vehiculos_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles Bot_Vehiculos.MouseLeave
        Label_NotifAceite.BackColor = Color.FromArgb(41, 39, 40)
    End Sub

#End Region

#Region "NOTIFICACION SUCTA"

    Private Sub Bot_Sucta_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bot_Sucta.LocationChanged
        Label_NotifSucta.Top = sender.Top + 8
    End Sub

    Private Sub Bot_Sucta_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bot_Sucta.VisibleChanged
        If Label_NotifSucta.Text <> "+00" Then
            Label_NotifSucta.Visible = sender.Visible
        End If
    End Sub

    Private Sub Label_NotifSucta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label_NotifSucta.Click
        Bot_Sucta.PerformClick()
    End Sub

    Private Sub Label_NotifSucta_MouseHover(ByVal sender As Object, ByVal e As EventArgs) Handles Label_NotifSucta.MouseHover, Bot_Sucta.MouseHover
        Label_NotifSucta.BackColor = Color.FromArgb(49, 46, 48)
    End Sub

    Private Sub Bot_Sucta_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles Bot_Sucta.MouseLeave
        Label_NotifSucta.BackColor = Color.FromArgb(41, 39, 40)
    End Sub

#End Region

#Region "RESPALDO DE INFORMACION EN GMAIL"

    Private Sub Envio()
        'Al finalizar el envío, abortar la hebra.-
        Control.CheckForIllegalCrossThreadCalls = False
        EnviarMail("respaldosvillasboas2018@gmail.com", "respaldosvillasboas2018@gmail.com", "BackupDBDrive", Adjunto, "Respaldo del " & DateTime.Now.ToString)
        oHebra.Abort()
    End Sub

    'Procedimiento.-
    Private Sub EnviarMail(ByVal StrDe As String, ByVal StrPara As String,
                           ByVal StrAsunto As String, ByVal sAdjunto As String,
                           ByVal StrMensaje As String)
        Try
            'Variable tipo mensaje con parametros <<De: Para:>>.-
            Dim Msg As New MailMessage(New MailAddress(StrDe), New MailAddress(StrPara))
            'Asunto.-
            Msg.Subject = StrAsunto
            'Mensaje.-
            Msg.Body = StrMensaje

            'ADJUNTOS.-
            If Not sAdjunto = "" Then
                'Objeto tipo attachment.-
                Dim Adjunto As New Attachment(sAdjunto)
                'Agregar adjunto al objeto mensaje.-
                Msg.Attachments.Add(Adjunto)
            End If

            'DATOS SMTP.-
            'Credenciales.-
            SMPT.Credentials = New System.Net.NetworkCredential _
            (StrDe, "Transportes*2018")
            'Host, Puerto, Autenticacion.-
            SMPT.Host = "smtp.gmail.com"
            SMPT.Port = 587
            SMPT.EnableSsl = True
            SMPT.Timeout = 10
            'Enviar.-
            SMPT.Send(Msg)

            'Regresar cursor y controles a modo normal.-
            MsgBox("Se ha realizado el respaldo de la Base de Datos" & vbNewLine & "Dentro de 1 hora lo podrá ver en la cuenta de Google Drive", MsgBoxStyle.Information, "Respaldo de Datos")
            Me.Cursor = Cursors.Default
            Me.Panel_AreaDeTrabajo.Cursor = Cursors.Default
            Me.Enabled = True
        Catch ex As Exception
            'Regresar cursor y controles a modo normal.-
            Me.Cursor = Cursors.Default
            Me.Panel_AreaDeTrabajo.Cursor = Cursors.Default
            Me.Enabled = True
            MsgBox("No se ha podido realizar el respaldo. Error: " & ex.Message)
        End Try
    End Sub

#End Region

    
    Private Sub Panel_AreaDeTrabajo_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel_AreaDeTrabajo.Paint

    End Sub
End Class

'Private Sub Bot_Inicio_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Bot_Inicio.Click
'    ReDim ControlHijo(1)
'    ReDim ControlPadre(0)
'    ControlHijo(0) = Me.Control_VencimientosSucta
'    'ControlHijo(1) = Me.Control_ModificarUsuarios
'    ControlPadre(0) = Me.Control_Principal
'    Control_Principal.BringToFront()
'    Label_TituloVentana.Text = "Menú Principal"
'    Label_VentanaActual.Text = "Menú Principal"
'End Sub

'Private Sub Bot_Vehiculos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Vehiculos.Click
'    ReDim ControlHijo(2)
'    ReDim ControlPadre(0)
'    ControlHijo(0) = Me.Control_HistorialCamiones
'    'ControlHijo(1) = Me.Control_ModificarClientes
'    ControlPadre(0) = Me.Control_BuscarCamiones
'    Control_BuscarCamiones.BringToFront()
'    Label_TituloVentana.Text = "Vehiculos"
'    Label_VentanaActual.Text = "Vehiculos"
'End Sub

'Private Sub Bot_Clientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Clientes.Click
'    'En array guardo controles para abrir con los botones.-
'    ReDim ControlHijo(1)
'    ReDim ControlPadre(0)
'    ControlHijo(0) = Me.Control_AgregarClientes
'    ControlHijo(1) = Me.Control_ModificarClientes
'    ControlPadre(0) = Me.Control_BusquedaClientes
'    Control_BusquedaClientes.BringToFront()
'    Label_TituloVentana.Text = "Clientes"
'    Label_VentanaActual.Text = "Clientes"
'End Sub

'Private Sub Bot_Usuarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Usuarios.Click
'    ReDim ControlHijo(1)
'    ReDim ControlPadre(0)
'    ControlHijo(0) = Me.Control_AgregarUsuarios
'    ControlHijo(1) = Me.Control_ModificarUsuarios
'    ControlPadre(0) = Me.Control_BuscarUsuarios
'    Control_BuscarUsuarios.BringToFront()
'    Label_TituloVentana.Text = "Usuarios"
'    Label_VentanaActual.Text = "Usuarios"
'End Sub

'Private Sub Bot_Sucta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Sucta.Click
'    Control_VencimientosSucta.BringToFront()
'    Label_TituloVentana.Text = "Vencimientos Sucta"
'    Label_VentanaActual.Text = "Vencimientos Sucta"
'End Sub
