Public Class Form_RestaurarEliminados
    Dim Consulta(1) As String 'Guarda las dos consultas según lo que escriba.-
    Dim Restaurar As String 'Guarda el UPDATE según la categoría.-
    Dim SQLRestaurar As String 'Guarda el UPDATE + el campo Clave.-
    Dim PanelActivo As Panel 'Guarda el Panel que esté visible.-
    Dim VehiculosRes(0) As String 'Guarda los vehiculos para Restaurar KM.-
    Dim KM As Integer 'Guarda los KM de la Orden.-

    Private Sub Form_RestaurarEliminados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CentrarPaneles()
    End Sub

    Private Sub Form_RestaurarEliminados_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        CentrarPaneles()
    End Sub

#Region "BOTONES RESTAURAR/VER"

    Private Sub Bot_Restaurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Restaurar.Click
        'Verificaciones.-
        If Restaurar = "" Then 'Si el update no está cargado.-
            MsgBox("Debe seleccionar una categoría primero.", MsgBoxStyle.Information, "¡Atención!")
            Exit Sub
        End If
        If CampoClaveStr = Nothing Then 'Si la clave no está cargada.-
            MsgBox("Debe seleccionar un dato para Restaurarlo.", MsgBoxStyle.Information, "¡Atención!")
            Exit Sub
        End If

        'Solo si es vehículo coloca las '', sino solo toma el valor de la clave.-
        If ComboBox_Categoria.Text = "Vehículos" Then
            SQLRestaurar = Restaurar & CampoClaveStr & "';"
        Else
            SQLRestaurar = Restaurar & Val(CampoClaveStr) & ";"
        End If

        'Actualizando los datos.-
        Select Case MessageBox.Show("¿Está seguro de querer Restaurar este dato?", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case Windows.Forms.DialogResult.Yes
                Dim ObjEliminar As New ClaseBD
                If ObjEliminar.Modificar(SQLRestaurar) = True Then
                    MsgBox("Se ha Restaurado correctamente", MsgBoxStyle.Information, "Restaurado Correctamente")

                    'Si es Orden, agrega los KM a los Vehiculos.-
                    If ComboBox_Categoria.Text = "Ordenes" Then
                        If ObjEliminar.Consulta("SELECT OrdenesCD.IdCamion, OrdenesCD.kmcamion FROM OrdenesCD WHERE OrdenesCD.IdOrden=" & Val(CampoClaveStr)) = True Then
                            VehiculosRes = Split(DatosConsulta.Rows(0).Item("IdCamion"), ",")
                            KM = DatosConsulta.Rows(0).Item("kmcamion")
                            For i = 0 To VehiculosRes.Length - 1
                                If VehiculosRes(i) <> Nothing Then
                                    If ActualizarKM(VehiculosRes(i), KM * 2.2) = False Then
                                        MsgBox("No se han podido actualizar los datos del Kilometraje, es posible que el vehiculo no se encuentre en la base de datos", MsgBoxStyle.Exclamation, "Error")
                                    End If
                                End If
                            Next
                        End If
                    End If

                    Busqueda()
                    'Actualiza la Notificacion.-
                    ConsultaNofiticacion()
                    ConsultaNofiticacion2()
                Else
                    MsgBox("No se ha podido Restaurar el dato, vuelva a intentarlo más tarde", MsgBoxStyle.Exclamation, "Error")
                End If
            Case Windows.Forms.DialogResult.No
                Exit Sub
        End Select
    End Sub

    Private Sub Bot_Ver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Ver.Click
        'Verificaciones.-
        If Restaurar = "" Then 'Si el update no está cargado.-
            MsgBox("Debe seleccionar una categoría primero.", MsgBoxStyle.Information, "¡Atención!")
            Exit Sub
        End If
        If CampoClaveStr = Nothing Then 'Si la clave no está cargada.-
            MsgBox("Primero debe seleccionar un Dato para verlo", MsgBoxStyle.Information, "¡Atención!")
            Exit Sub
        End If

        'Mostrando Datos.-
        Select Case ComboBox_Categoria.Text
            Case Is = "Clientes"
                CampoClaveInt = Val(CampoClaveStr)
                AbrirSegundoInPanel(New Form_AgregarModificarClientes, Form_MenuPrincipal.Panel_AreaDeTrabajo, "4")

            Case Is = "Vehículos"
                Panel_Vehiculo.Visible = True
                PanelActivo = Panel_Vehiculo
                CargarVehiculo(CampoClaveStr)
                BusquedaVisible(False)

            Case Is = "Historial Vehículos"
                Panel_Historial.Visible = True
                PanelActivo = Panel_Historial
                CargarHistorial(Val(CampoClaveStr))
                BusquedaVisible(False)

            Case Is = "Tipos de Carga"
                Exit Sub

            Case Is = "Lugares de Carga"
                Exit Sub

            Case Is = "Ordenes"
                CampoClaveInt = Val(CampoClaveStr)
                AbrirSegundoInPanel(New Form_AgregarModificarOrden, Form_MenuPrincipal.Panel_AreaDeTrabajo, "4")

            Case Is = "Entregas Saldo"
                CampoClaveInt = Val(CampoClaveStr)
                AbrirSegundoInPanel(New Form_AgregarModificarEntregaSaldo, Form_MenuPrincipal.Panel_AreaDeTrabajo, "4")

            Case Is = "Usuarios"
                CampoClaveInt = Val(CampoClaveStr)
                AbrirSegundoInPanel(New Form_AgregarModificarUsuarios, Form_MenuPrincipal.Panel_AreaDeTrabajo, "4")

            Case Is = ""

        End Select
    End Sub

#End Region

#Region "BUSQUEDA DE DATOS"

    Private Sub Busqueda()
        'Carga la consulta para el DataGrid según la categoría seleccionada.-
        Select Case ComboBox_Categoria.Text
            Case Is = "Clientes"
                Consulta(0) = "SELECT Clientes.IdCliente, Clientes.Nombre, Clientes.Direccion, Clientes.Celular FROM Clientes WHERE (Clientes.IdCliente Like '%" & WMTextBox_Buscar.Text & "%' OR Clientes.Nombre Like '%" & WMTextBox_Buscar.Text & "%') AND Clientes.Estado=0;"
                Consulta(1) = "SELECT Clientes.IdCliente, Clientes.Nombre, Clientes.Direccion, Clientes.Celular FROM Clientes WHERE Clientes.Estado=0;"

            Case Is = "Vehículos"
                Consulta(0) = "SELECT Camiones.idcamion, Camiones.Marca, Camiones.Modelo, Camiones.kmactual FROM Camiones WHERE (Camiones.idcamion Like '%" & WMTextBox_Buscar.Text & "%' OR Camiones.Marca Like '%" & WMTextBox_Buscar.Text & "%' OR Camiones.Modelo Like '%" & WMTextBox_Buscar.Text & "%') AND Camiones.Estado=0;"
                Consulta(1) = "SELECT Camiones.idcamion, Camiones.Marca, Camiones.Modelo, Camiones.kmactual FROM Camiones WHERE Camiones.Estado=0;"

            Case Is = "Historial Vehículos"
                Consulta(0) = "SELECT ControlesCamiones.IdControl, ControlesCamiones.IdCamion, ControlesCamiones.FechaControl, ControlesCamiones.GastosTaller, ControlesCamiones.Detalle FROM ControlesCamiones WHERE ControlesCamiones.Detalle LIKE '%" & WMTextBox_Buscar.Text & "%' AND ControlesCamiones.Estado=0;"
                Consulta(1) = "SELECT ControlesCamiones.IdControl, ControlesCamiones.IdCamion, ControlesCamiones.FechaControl, ControlesCamiones.GastosTaller, ControlesCamiones.Detalle FROM ControlesCamiones WHERE ControlesCamiones.Estado=0;"

            Case Is = "Tipos de Carga"
                Consulta(0) = "SELECT TiposCargas.idCarga, TiposCargas.Carga FROM TiposCargas WHERE TiposCargas.Carga LIKE '%" & WMTextBox_Buscar.Text & "%' AND TiposCargas.Estado=0;"
                Consulta(1) = "SELECT TiposCargas.idCarga, TiposCargas.Carga FROM TiposCargas WHERE TiposCargas.Estado=0;"

            Case Is = "Lugares de Carga"
                Consulta(0) = "SELECT Lugares.idLugar, Lugares.Lugar FROM Lugares WHERE Lugares.Lugar LIKE '%" & WMTextBox_Buscar.Text & "%' AND Lugares.Estado=0;"
                Consulta(1) = "SELECT Lugares.idLugar, Lugares.Lugar FROM Lugares WHERE Lugares.Estado=0;"

            Case Is = "Ordenes"
                Consulta(0) = "SELECT OrdenesCD.IdOrden, Clientes.Nombre, OrdenesCD.Guia, OrdenesCD.IdCamion, OrdenesCD.detallecarga FROM Clientes INNER JOIN OrdenesCD ON Clientes.IdCliente = OrdenesCD.Codigocliente WHERE (OrdenesCD.IdOrden Like '%" & WMTextBox_Buscar.Text & "%' OR OrdenesCD.Codigocliente Like '%" & WMTextBox_Buscar.Text & "%' OR OrdenesCD.Guia Like '%" & WMTextBox_Buscar.Text & "%' OR OrdenesCD.IdCamion Like '%" & WMTextBox_Buscar.Text & "%' OR OrdenesCD.detallecarga Like '%" & WMTextBox_Buscar.Text & "%' OR OrdenesCD.LugarCarga Like '%" & WMTextBox_Buscar.Text & "%' OR OrdenesCD.LugarDescarga Like '%" & WMTextBox_Buscar.Text & "%' OR Clientes.Nombre Like '%" & WMTextBox_Buscar.Text & "%') AND OrdenesCD.Estado=0;"
                Consulta(1) = "SELECT OrdenesCD.IdOrden, Clientes.Nombre, OrdenesCD.Guia, OrdenesCD.IdCamion, OrdenesCD.detallecarga FROM Clientes INNER JOIN OrdenesCD ON Clientes.IdCliente = OrdenesCD.Codigocliente WHERE OrdenesCD.Estado=0;"

            Case Is = "Entregas Saldo"
                Consulta(0) = "SELECT Entregas.IdEntrega, Clientes.Nombre, Entregas.FechaEntrega, Entregas.NumFactura, Entregas.NumRecibo, Entregas.MontoEntrega FROM Clientes INNER JOIN Entregas ON Clientes.IdCliente = Entregas.IdCliente WHERE (Clientes.Nombre Like '%" & WMTextBox_Buscar.Text & "%' OR  Entregas.NumFactura Like '%" & WMTextBox_Buscar.Text & "%' OR Entregas.NumRecibo Like '%" & WMTextBox_Buscar.Text & "%') AND Entregas.Estado=0;"
                Consulta(1) = "SELECT Entregas.IdEntrega, Clientes.Nombre, Entregas.FechaEntrega, Entregas.NumFactura, Entregas.NumRecibo, Entregas.MontoEntrega FROM Clientes INNER JOIN Entregas ON Clientes.IdCliente = Entregas.IdCliente WHERE Entregas.Estado=0;"

            Case Is = "Usuarios"
                Consulta(0) = "SELECT Usuarios.IdUsuario, Usuarios.Nombre, Usuarios.Apellido, Usuarios.CI, Usuarios.Telefono FROM Usuarios WHERE (Usuarios.CI Like '%" & WMTextBox_Buscar.Text & "%' OR Usuarios.Nombre Like '%" & WMTextBox_Buscar.Text & "%' OR Usuarios.Apellido Like '%" & WMTextBox_Buscar.Text & "%') AND Usuarios.Estado=0;"
                Consulta(1) = "SELECT Usuarios.IdUsuario, Usuarios.Nombre, Usuarios.Apellido, Usuarios.CI, Usuarios.Telefono FROM Usuarios WHERE Usuarios.Estado=0;"

            Case Is = ""
                Consulta(0) = ""
                Consulta(1) = ""
                Exit Sub
        End Select

        'Realiza la consulta y llena el DataGrid.-
        If WMTextBox_Buscar.Text <> "" Then
            ActualizarTabla(DataGridView_Eliminados, Consulta(0), CS)
        Else
            ActualizarTabla(DataGridView_Eliminados, Consulta(1), CS)
        End If
        If DataGridView_Eliminados.Rows.Count > 0 Then
            DataGridView_Eliminados.Rows(0).Selected = True
            CampoClaveStr = DataGridView_Eliminados.SelectedRows(0).Cells(0).Value
        Else
            CampoClaveStr = Nothing
        End If

        'Da Formato al DataGrid según la categoría seleccionada.-
        Select Case ComboBox_Categoria.Text
            Case Is = "Clientes"
                DataGridView_Eliminados.Columns(0).HeaderText = "ID"
                DataGridView_Eliminados.Columns(0).Width = 70
            Case Is = "Vehículos"
                DataGridView_Eliminados.Columns(0).HeaderText = "Matrícula"
                DataGridView_Eliminados.Columns(3).HeaderText = "KM Total"
            Case Is = "Historial Vehículos"
                DataGridView_Eliminados.Columns(0).Visible = False
                DataGridView_Eliminados.Columns(1).HeaderText = "Vehículo"
                DataGridView_Eliminados.Columns(2).HeaderText = "Fecha"
                DataGridView_Eliminados.Columns(3).HeaderText = "Gatos"
            Case Is = "Tipos de Carga"
                DataGridView_Eliminados.Columns(0).HeaderText = "ID"
                DataGridView_Eliminados.Columns(0).Width = 50
            Case Is = "Lugares de Carga"
                DataGridView_Eliminados.Columns(0).HeaderText = "ID"
                DataGridView_Eliminados.Columns(0).Width = 50
            Case Is = "Ordenes"
                DataGridView_Eliminados.Columns(0).HeaderText = "ID"
                DataGridView_Eliminados.Columns(1).HeaderText = "Cliente"
                DataGridView_Eliminados.Columns(2).HeaderText = "Guía"
                DataGridView_Eliminados.Columns(3).HeaderText = "Vehículo"
                DataGridView_Eliminados.Columns(4).HeaderText = "Carga"
                DataGridView_Eliminados.Columns(0).Width = 50
            Case Is = "Entregas Saldo"
                DataGridView_Eliminados.Columns(0).Visible = False
                DataGridView_Eliminados.Columns(1).HeaderText = "Cliente"
                DataGridView_Eliminados.Columns(2).HeaderText = "Fecha"
                DataGridView_Eliminados.Columns(3).HeaderText = "Factura"
                DataGridView_Eliminados.Columns(4).HeaderText = "Recibo"
                DataGridView_Eliminados.Columns(5).HeaderText = "Monto"
            Case Is = "Usuarios"
                DataGridView_Eliminados.Columns(0).Visible = False
                Exit Sub
        End Select
    End Sub

    Private Sub WMTextBox_Buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WMTextBox_Buscar.TextChanged
        Busqueda()
    End Sub

    Private Sub Bot_Borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Borrar.Click
        WMTextBox_Buscar.Text = ""
        ComboBox_Categoria.SelectedItem = Nothing
        DataGridView_Eliminados.DataSource = Nothing
        DataGridView_Eliminados.Rows.Clear()
        CampoClaveStr = Nothing
    End Sub

    Private Sub ComboBox_Categoria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_Categoria.SelectedIndexChanged
        'Según la categoría que seleccione cambia la marca de agua, el update y el Enabled del botón Ver Datos.-
        Select Case sender.Text
            Case Is = "Clientes"
                WMTextBox_Buscar.WaterMarkText = "Buscar Clientes por Nombre o Código"
                Restaurar = "UPDATE Clientes SET Clientes.Estado = 1 WHERE Clientes.IdCliente="
                Bot_Ver.Enabled = True
            Case Is = "Vehículos"
                WMTextBox_Buscar.WaterMarkText = "Buscar por Matrícula, Marca o Modelo"
                Restaurar = "UPDATE Camiones SET Camiones.Estado = 1 WHERE Camiones.IdCamion='"
                Bot_Ver.Enabled = True
            Case Is = "Historial Vehículos"
                WMTextBox_Buscar.WaterMarkText = "Buscar Control por Detalles"
                Restaurar = "UPDATE ControlesCamiones SET ControlesCamiones.Estado = 1 WHERE ControlesCamiones.IdControl="
                Bot_Ver.Enabled = True
            Case Is = "Tipos de Carga"
                WMTextBox_Buscar.WaterMarkText = "Buscar por Carga"
                Restaurar = "UPDATE TiposCargas SET TiposCargas.Estado = 1 WHERE TiposCargas.idCarga="
                Bot_Ver.Enabled = False
            Case Is = "Lugares de Carga"
                WMTextBox_Buscar.WaterMarkText = "Buscar por Lugar"
                Restaurar = "UPDATE Lugares SET Lugares.Estado = 1 WHERE Lugares.idLugar="
                Bot_Ver.Enabled = False
            Case Is = "Ordenes"
                WMTextBox_Buscar.WaterMarkText = "Nº, Cliente, Guía, Camión, Detalle o Lugar"
                Restaurar = "UPDATE OrdenesCD SET OrdenesCD.Estado = 1 WHERE OrdenesCD.IdOrden="
                Bot_Ver.Enabled = True
            Case Is = "Entregas Saldo"
                WMTextBox_Buscar.WaterMarkText = "Buscar Entregas por Nº de Recibo, Nº de Factura o Cliente"
                Restaurar = "UPDATE Entregas SET Entregas.Estado = 1 WHERE Entregas.IdEntrega="
                Bot_Ver.Enabled = True
            Case Is = "Usuarios"
                WMTextBox_Buscar.WaterMarkText = "Buscar Usuarios por Nombre, Apellido o CI"
                Restaurar = "UPDATE Usuarios SET Usuarios.Estado = 1 WHERE Usuarios.IdUsuario="
                Bot_Ver.Enabled = True
            Case Is = ""
                WMTextBox_Buscar.WaterMarkText = "Seleccione una Categoría"
                Restaurar = ""
                Bot_Ver.Enabled = True
                Exit Sub
        End Select
        Busqueda()
    End Sub

    Private Sub DataGridView_Eliminados_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView_Eliminados.CurrentCellChanged
        If DataGridView_Eliminados.SelectedRows.Count > 0 Then
            CampoClaveStr = DataGridView_Eliminados.SelectedRows(0).Cells(0).Value
        End If
    End Sub

#End Region

#Region "PANELES DE DATOS"

    'Oculta/Muestra los campos.-
    Private Sub BusquedaVisible(ByVal Bool As Boolean)
        Label_Titulo.Visible = Bool
        WMTextBox_Buscar.Visible = Bool
        ComboBox_Categoria.Visible = Bool
        Bot_Borrar.Visible = Bool
        DataGridView_Eliminados.Visible = Bool
        Bot_Ver.Visible = Bool
        Bot_Restaurar.Visible = Bool
        If Bool = True Then
            PanelActivo.Visible = False
        End If
    End Sub

    'Centra los Paneles.-
    Private Sub CentrarPaneles()
        'Panel vehículo.-
        Panel_Vehiculo.Top = (Me.ClientSize.Height / 2) - (Panel_Vehiculo.Height / 2)
        Panel_Vehiculo.Left = (Me.ClientSize.Width / 2) - (Panel_Vehiculo.Width / 2)
        'Panel Historial.-
        Panel_Historial.Top = (Me.ClientSize.Height / 2) - (Panel_Historial.Height / 2)
        Panel_Historial.Left = (Me.ClientSize.Width / 2) - (Panel_Historial.Width / 2)
    End Sub

    'Carga los Datos del Vehículo.-
    Private Sub CargarVehiculo(ByVal Clave As String)
        Dim ObjBD As New ClaseBD
        If ObjBD.Consulta("SELECT Camiones.* FROM Camiones WHERE Camiones.IdCamion='" & Clave & "';") = True Then
            TextBox_MarcaV.Text = DatosConsulta.Rows(0).Item("Marca")
            TextBox_ModeloV.Text = DatosConsulta.Rows(0).Item("Modelo")
            TextBox_MatrículaV.Text = DatosConsulta.Rows(0).Item("IdCamion")
            TextBox_KMActuales.Text = DatosConsulta.Rows(0).Item("kmactual")
            TextBox_KMAceite.Text = DatosConsulta.Rows(0).Item("kmaceite")
            TextBox_KMCubierta.Text = DatosConsulta.Rows(0).Item("kmcubiertas")
            TextBox_Ultimo.Text = DatosConsulta.Rows(0).Item("SuctaDesde").ToString
            TextBox_Proximo.Text = DatosConsulta.Rows(0).Item("SuctaHasta").ToString
        Else
            MsgBox("No se encontró el vehiculo en la base de datos. Por favor vuelva a intentarlo", MsgBoxStyle.Exclamation, "¡Atención!")
            Me.Close()
        End If
    End Sub

    'Carga los Datos del Vehículo y el Historial.-
    Private Sub CargarHistorial(ByVal Clave As Integer)
        Dim ObjBD As New ClaseBD
        If ObjBD.Consulta("SELECT ControlesCamiones.*, Camiones.Marca, Camiones.Modelo FROM Camiones INNER JOIN ControlesCamiones ON Camiones.idcamion = ControlesCamiones.idcamion WHERE ControlesCamiones.idcontrol=" & Clave & ";") = True Then
            TextBox_MarcaH.Text = DatosConsulta.Rows(0).Item("Marca")
            TextBox_ModeloH.Text = DatosConsulta.Rows(0).Item("Modelo")
            TextBox_MatriculaH.Text = DatosConsulta.Rows(0).Item("IdCamion")
            TextBox_Gastos.Text = DatosConsulta.Rows(0).Item("GastosTaller")
            RichTextBox_Detalles.Text = DatosConsulta.Rows(0).Item("Detalle")
            TextBox_Fecha.Text = DatosConsulta.Rows(0).Item("FechaControl").ToString
        Else
            MsgBox("No se encontró el vehiculo en la base de datos. Por favor vuelva a intentarlo", MsgBoxStyle.Exclamation, "¡Atención!")
            Me.Close()
        End If
    End Sub

    Private Sub RestaurarDesdePaneles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_RestaurarV.Click, Bot_RestaurarH.Click
        'Solo si es vehículo coloca las '', sino solo toma el valor de la clave.-
        If ComboBox_Categoria.Text = "Vehículos" Then
            SQLRestaurar = Restaurar & CampoClaveStr & "';"
        Else
            SQLRestaurar = Restaurar & Val(CampoClaveStr) & ";"
        End If

        'Actualizando los datos.-
        Select Case MessageBox.Show("¿Está seguro de querer Restaurar este dato?", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case Windows.Forms.DialogResult.Yes
                Dim ObjEliminar As New ClaseBD
                If ObjEliminar.Modificar(SQLRestaurar) = True Then
                    MsgBox("Se ha Restaurado correctamente", MsgBoxStyle.Information, "Restaurado Correctamente")
                    BusquedaVisible(True)
                    Busqueda()
                Else
                    MsgBox("No se ha podido Restaurar el dato, vuelva a intentarlo más tarde", MsgBoxStyle.Exclamation, "Error")
                End If
            Case Windows.Forms.DialogResult.No
                Exit Sub
        End Select
    End Sub

    Private Sub CerrarPaneles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_VolverV.Click, Bot_VolverH.Click
        'Vacía los campos.-
        Select Case PanelActivo.Name
            Case Is = "Panel_Vehiculo"
                LimpiarTextboxGroupBox(GroupBox_CamionV)
                LimpiarTextboxGroupBox(GroupBox_MantenimientoV)
            Case Is = "Panel_Historial"
                LimpiarTextboxGroupBox(GroupBox_CamionH)
                LimpiarTextboxGroupBox(GroupBox_MantenimientoH)
        End Select

        'Cierra el Panel y Muestra los demás.-
        BusquedaVisible(True)
    End Sub

#End Region

#Region "ACTUALIZAR NOTIFICACION"

    Private Sub ActualizarNotifAceite() Handles Panel_Vehiculo.VisibleChanged, Panel_Historial.VisibleChanged
        ConsultaNofiticacion2()
    End Sub

#End Region

End Class