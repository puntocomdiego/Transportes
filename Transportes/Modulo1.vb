Imports System.Data.OleDb

Module Modulo1
    'Conexion DB.-
    Public RutaBD As String = My.Application.Info.DirectoryPath & "\VillasboasDB.mdb" 'Ruta de la Base de Datos.-
    Public CS As String = "Provider=Microsoft.ace.OLEDB.12.0; Data Source=" & RutaBD 'String de conexión.-
    'DatosGuardados.-
    Public DatosUsuario As DataTable 'Guarda los datos del Usurio que inicia sesión.-
    Public CampoClaveInt As Integer 'Guarda clave de consulta tipo Integer.-
    Public CampoClaveStr As String 'Guarda clave de consulta tipo String.-
    Public DatosConsulta As DataTable 'Guarda los datos de una consulta.-
    Public IDS(1) As Integer 'Guarda Claves para consultas de Saldos.-
    Public KMConsulta(2) As Integer 'Guarda KM anteriores.-

#Region "BASE DE DATOS"

    Sub ActualizarTabla(ByVal Grilla As DataGridView, ByVal Consulta As String, ByVal Conexion As String)
        Try
            Dim da As OleDbDataAdapter
            Dim dt As DataTable
            da = New OleDbDataAdapter(Consulta, Conexion)
            dt = New DataTable
            da.Fill(dt)
            Grilla.DataSource = dt
            Grilla.ReadOnly = True
        Catch exsql As OleDbException
            MsgBox("Error al Actualizar la Tabla: " & exsql.Message)
        Catch ex As Exception
            MsgBox("Error al Actualizar la Tabla: " & ex.Message)
        End Try
    End Sub

    Sub ActualizarCheckedLisBox(ByVal List As CheckedListBox, ByVal Consulta As String, ByVal Conexion As String)
        Try
            Dim da As OleDbDataAdapter
            Dim dt As DataTable
            da = New OleDbDataAdapter(Consulta, Conexion)
            dt = New DataTable
            da.Fill(dt)
            DatosConsulta = dt
        Catch exsql As OleDbException
            MsgBox("Error al Actualizar la Lista: " & exsql.Message)
        Catch ex As Exception
            MsgBox("Error al Actualizar la Lista: " & ex.Message)
        End Try
    End Sub

    Sub ActualizarComboBox(ByVal Conexion As String, ByVal Combo As ComboBox, ByVal SQL As String, ByVal NombreColumna As String)
        Try
            Dim cn As New OleDbConnection(Conexion)
            Dim da As New OleDbDataAdapter()
            Dim dt As New DataTable()
            cn.Open()
            da.SelectCommand = New OleDbCommand(SQL, cn)
            da.Fill(dt)
            Combo.DataSource = dt
            Combo.DisplayMember = NombreColumna
            Combo.SelectedItem = Nothing
        Catch exsql As OleDbException
            MsgBox("Error al Actualizar la Lista: " & exsql.Message)
        Catch ex As Exception
            MsgBox("Error al Actualizar la Lista: " & ex.Message)
        End Try
    End Sub

    Public Sub ConsultaNofiticacion()
        Try
            Dim ObjNotif As New ClaseBD
            If ObjNotif.Consulta("SELECT Count(DateDiff('d',Date(),Camiones.SuctaHasta)) AS DiasR FROM Camiones WHERE (DateDiff('d',Date(),Camiones.SuctaHasta)<=50) GROUP BY Camiones.Estado HAVING Camiones.Estado=1;") = True Then
                If DatosConsulta.Rows.Count > 0 Then
                    Select Case DatosConsulta.Rows(0).Item("DiasR")
                        Case Is <= 0
                            Form_MenuPrincipal.Label_NotifSucta.Visible = False
                            Form_MenuPrincipal.Label_NotifSucta.Text = "+00"
                        Case Is < 10
                            Form_MenuPrincipal.Label_NotifSucta.Visible = True
                            Form_MenuPrincipal.Label_NotifSucta.Text = " 0" & Val(DatosConsulta.Rows(0).Item("DiasR"))
                        Case Is >= 10
                            Form_MenuPrincipal.Label_NotifSucta.Visible = True
                            Form_MenuPrincipal.Label_NotifSucta.Text = Val(DatosConsulta.Rows(0).Item("DiasR"))
                        Case Is > 99
                            Form_MenuPrincipal.Label_NotifSucta.Visible = True
                            Form_MenuPrincipal.Label_NotifSucta.Text = "+99"
                    End Select
                End If
            End If
        Catch exsql As OleDbException
            MsgBox("Error al Actualizar la Notificación: " & exsql.Message)
        Catch ex As Exception
            MsgBox("Error al Actualizar la Notificación: " & ex.Message)
        End Try
    End Sub

    Public Sub ConsultaNofiticacion2()
        Try
            Dim ObjNotif As New ClaseBD
            If ObjNotif.Consulta("SELECT Count(Camiones.kmaceite) AS CantAceite FROM Camiones WHERE Camiones.Estado=1 AND Camiones.kmaceite>=9000;") = True Then
                If DatosConsulta.Rows.Count > 0 Then
                    Select Case DatosConsulta.Rows(0).Item("CantAceite")
                        Case Is <= 0
                            Form_MenuPrincipal.Label_NotifAceite.Visible = False
                            Form_MenuPrincipal.Label_NotifAceite.Text = "+00"
                        Case Is < 10
                            Form_MenuPrincipal.Label_NotifAceite.Visible = True
                            Form_MenuPrincipal.Label_NotifAceite.Text = " 0" & Val(DatosConsulta.Rows(0).Item("CantAceite"))
                        Case Is >= 10
                            Form_MenuPrincipal.Label_NotifAceite.Visible = True
                            Form_MenuPrincipal.Label_NotifAceite.Text = Val(DatosConsulta.Rows(0).Item("CantAceite"))
                        Case Is > 99
                            Form_MenuPrincipal.Label_NotifAceite.Visible = True
                            Form_MenuPrincipal.Label_NotifAceite.Text = "+99"
                    End Select
                End If
            End If
        Catch exsql As OleDbException
            MsgBox("Error al Actualizar la Notificación: " & exsql.Message)
        Catch ex As Exception
            MsgBox("Error al Actualizar la Notificación: " & ex.Message)
        End Try
    End Sub

#End Region

#Region "NAVEGACION EN FORM"

    Public Sub AbrirFormInPanel(ByVal FormHijo As Form, ByVal PanelPadre As Panel)
        Try
            For Each Formulario As Form In PanelPadre.Controls
                Formulario.Dispose()
            Next
            Dim FH As Form = FormHijo
            FH.TopLevel = False
            FH.Dock = DockStyle.Fill
            PanelPadre.Controls.Add(FH)
            PanelPadre.Tag = FH
            FH.Show()
            FH.BringToFront()
        Catch exsql As OleDbException
            MsgBox("Error al cargar los Datos: " & exsql.Message)
        Catch ex As Exception
            MsgBox("Error al cargar los Datos: " & ex.Message)
        End Try
    End Sub

    Public Sub AbrirSegundoInPanel(ByVal FormHijo As Form, ByVal PanelPadre As Panel, ByVal Opcion As String)
        Try
            Dim FH As Form = FormHijo
            FH.TopLevel = False
            FH.Dock = DockStyle.Fill
            PanelPadre.Controls.Add(FH)
            PanelPadre.Tag = FH
            'El Tag del Form determina que opciones se van a mostrar.-
            FH.Tag = Opcion
            FH.Show()
            FH.BringToFront()
        Catch exsql As OleDbException
            MsgBox("Error al cargar los Datos: " & exsql.Message)
        Catch ex As Exception
            MsgBox("Error al cargar los Datos: " & ex.Message)
        End Try
    End Sub

#End Region

#Region "DATOS CAMPOS"

    Sub LimpiarTextboxForm(ByVal f As Form)
        For Each H As Control In f.Controls
            If TypeOf H Is TextBox Or TypeOf H Is MaskedTextBox Or TypeOf H Is RichTextBox Then
                H.Text = ""
            End If
        Next
    End Sub

    Sub LimpiarTextboxGroupBox(ByVal g As GroupBox)
        For Each H As Control In g.Controls
            If TypeOf H Is TextBox Or TypeOf H Is MaskedTextBox Or TypeOf H Is RichTextBox Then
                H.Text = ""
            End If
        Next
    End Sub

#End Region

    Public Function ActualizarKM(ByVal Vehiculo As String, ByVal KMDif As Integer) As Boolean
        'Seleccionando valores viejos.-
        Dim ObjCons As New ClaseBD
        If ObjCons.Consulta("SELECT Camiones.kmactual, Camiones.kmaceite, Camiones.kmcubiertas FROM Camiones WHERE Camiones.IdCamion='" & Vehiculo & "'") = True Then
            If DatosConsulta.Rows.Count = 0 Then
                Return False
                Exit Function
            End If
            KMConsulta(0) = Val(DatosConsulta.Rows(0).Item("kmactual"))
            KMConsulta(1) = Val(DatosConsulta.Rows(0).Item("kmaceite"))
            KMConsulta(2) = Val(DatosConsulta.Rows(0).Item("kmcubiertas"))
        Else
            Return False
            Exit Function
        End If
        KMConsulta(0) = KMConsulta(0) + KMDif
        KMConsulta(1) = KMConsulta(1) + KMDif
        KMConsulta(2) = KMConsulta(2) + KMDif
        Dim ObjAct As New ClaseBD
        If ObjAct.Modificar("UPDATE Camiones SET Camiones.kmactual=" & KMConsulta(0) & ", Camiones.kmaceite=" & KMConsulta(1) & ", Camiones.kmcubiertas=" & KMConsulta(2) & " WHERE Camiones.IdCamion='" & Vehiculo & "'") = False Then
            Return False
            Exit Function
        End If
        Return True
    End Function

End Module

'Métodos y Códigos:

'Para hacer Enter en MsgBox: " & vbNewLine & "

