Public Class Form_AgregarModificarOrden
    Dim BotonQueAbre As String 'Guarda que botón abre el Panel de Selección.-
    Dim EstadoFactura As String 'Guarda el Estado de Facturación.-
    Dim EstadoPago As String 'Guarda el Estado de Pago.-
    Dim Cliente(1) As String 'Guarda el ID(0) y el Nombre del Cliente(1).-
    Dim Camiones(0) As String 'Guarda las Matrículas de los Vehiculos seleccionados.-
    Dim VehiculosOrigArr(0) As String 'Guarda las Matrículas de los Vehiculos originales.-
    Dim VehiculosOrig As String
    Dim KMT As Integer 'Guarda KM totales del recorrido.-
    Dim KMOG As Integer

    Private Sub Form_AgregarModificarOrden_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Llena los ComboBox.-
        ActualizarComboBox(CS, ComboBox_Detalle, "SELECT TiposCargas.Carga FROM TiposCargas WHERE TiposCargas.Estado=1 ORDER BY TiposCargas.Carga;", "Carga")
        ActualizarComboBox(CS, ComboBox_LugarCarga, "SELECT Lugares.Lugar FROM Lugares WHERE Lugares.Estado=1 ORDER BY Lugares.Lugar;", "Lugar")
        ActualizarComboBox(CS, ComboBox_LugarDescarga, "SELECT Lugares.Lugar FROM Lugares WHERE Lugares.Estado=1 ORDER BY Lugares.Lugar;", "Lugar")
        'Lena CheckedListBox.-
        ActualizarCheckedLisBox(CheckedListBox_Vehiculos, "SELECT Camiones.idcamion, Camiones.Marca, Camiones.Modelo FROM Camiones WHERE Camiones.Estado=1;", CS)
        For Each row As DataRow In DatosConsulta.Rows
            CheckedListBox_Vehiculos.Items.Add(Convert.ToString(row("IdCamion")) & "-" & Convert.ToString(row("Marca")) & "," & Convert.ToString(row("Modelo")))
        Next

        'Si Agrega.-
        If Me.Tag = "1" Then
            Dim ObjConsulta As New ClaseBD
            If ObjConsulta.Consulta("SELECT Max(OrdenesCD.IdOrden) AS IdOrden FROM OrdenesCD") = True Then
                TextBox_NumOrden.Text = DatosConsulta.Rows(0).Item("IdOrden") + 1
            End If
        End If

        'Si Modifica, Ve o Restaura.-
        If Me.Tag = "2" Or Me.Tag = "3" Or Me.Tag = "4" Then
            Label_Titulo.Text = "Modificar Orden"
            Dim ObjBD As New ClaseBD
            If ObjBD.Consulta("SELECT OrdenesCD.*, Clientes.Nombre FROM Clientes INNER JOIN OrdenesCD ON Clientes.IdCliente = OrdenesCD.Codigocliente WHERE OrdenesCD.IdOrden=" & CampoClaveInt & ";") = False Then
                MsgBox("Not Found")
                Me.Close()
            End If
            TextBox_Cliente.Text = DatosConsulta.Rows(0).Item("CodigoCliente") & ", " & DatosConsulta.Rows(0).Item("Nombre")
            DatePicker_Fecha.Value = DatosConsulta.Rows(0).Item("FechaOrden")
            TextBox_NumOrden.Text = DatosConsulta.Rows(0).Item("IdOrden")
            TextBox_NumGuia.Text = DatosConsulta.Rows(0).Item("Guia")
            TextBox_NumRemito.Text = DatosConsulta.Rows(0).Item("Remito")
            TextBox_Vehiculo.Text = DatosConsulta.Rows(0).Item("IdCamion")
            VehiculosOrig = DatosConsulta.Rows(0).Item("IdCamion")
            VehiculosOrigArr = Split(DatosConsulta.Rows(0).Item("IdCamion"), ",")
            TextBox_KMCamion.Text = DatosConsulta.Rows(0).Item("kmcamion")
            KMOG = Val(DatosConsulta.Rows(0).Item("kmcamion"))
            TextBox_KMValor.Text = DatosConsulta.Rows(0).Item("valorkm")
            TextBox_NumCarga.Text = DatosConsulta.Rows(0).Item("numcarga")
            ComboBox_Detalle.Text = DatosConsulta.Rows(0).Item("detallecarga")
            ComboBox_LugarCarga.Text = DatosConsulta.Rows(0).Item("LugarCarga")
            ComboBox_LugarDescarga.Text = DatosConsulta.Rows(0).Item("LugarDescarga")
            TextBox_Gastos.Text = DatosConsulta.Rows(0).Item("GastosVarios")
            TextBox_DetalleGastos.Text = DatosConsulta.Rows(0).Item("DetalleGastos")
            'Carga Estado de Pago.-
            If DatosConsulta.Rows(0).Item("EstadoDePago") = "Pago" Then
                RadioButton_Pago.Checked = True
            ElseIf DatosConsulta.Rows(0).Item("EstadoDepago") = "Debe" Then
                RadioButton_Debe.Checked = True
            Else
                RadioButton_Debe.Checked = False
                RadioButton_Pago.Checked = False
            End If
            'Carga Estado de Facturación.-
            If DatosConsulta.Rows(0).Item("EstadoDeFacturacion") = "Facturado" Then
                RadioButton_Facturado.Checked = True
            ElseIf DatosConsulta.Rows(0).Item("EstadoDeFacturacion") = "No Facturado" Then
                RadioButton_NoFacturado.Checked = True
            Else
                RadioButton_Facturado.Checked = False
                RadioButton_NoFacturado.Checked = False
            End If
            Bot_Volver.Visible = False
        End If

        'Si Ve.-
        If Me.Tag = "3" Or Me.Tag = "4" Then
            Label_Titulo.Text = "Datos Orden"
            Bot_Guardar.Text = "Modificar"
            Bot_Cancelar.Text = "Volver"
            Bot_MostrarClientes.Enabled = False
            Bot_MostrarVehiculos.Enabled = False
            DatePicker_Fecha.Enabled = False
            RadioButton_Debe.Enabled = False
            RadioButton_Facturado.Enabled = False
            RadioButton_NoFacturado.Enabled = False
            RadioButton_Pago.Enabled = False
            For Each H As Control In Me.GroupBox_Datos.Controls
                If TypeOf H Is TextBox Then
                    Dim TB As TextBox = DirectCast(H, TextBox)
                    TB.ReadOnly = True
                    TB.BackColor = Color.White
                End If
                If TypeOf H Is ComboBox Or TypeOf H Is RadioButton Then
                    H.Enabled = False
                End If
            Next
        End If

        'Si está Restaurando.-
        If Me.Tag = "4" Then
            Label_Titulo.Text += " Eliminada"
            Bot_Guardar.Text = "Restaurar"
        End If
    End Sub

    Private Sub Form_AgregarModificarOrden_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ConsultaNofiticacion2()
    End Sub

#Region "BOTONES ABM"

    Private Sub Bot_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Guardar.Click
        'Verificaciones.-
        If Me.Tag = "1" Or Me.Tag = "2" Then
            If TextBox_Cliente.Text = "" Then
                MsgBox("Debe ingresar un cliente para guardar", MsgBoxStyle.Information, "¡Atención!")
                TextBox_Cliente.Focus()
                Exit Sub
            End If
            If TextBox_NumGuia.Text = "" Then
                MsgBox("Debe ingresar un número de guía para guardar", MsgBoxStyle.Information, "¡Atención!")
                TextBox_NumGuia.Focus()
                Exit Sub
            End If
            If TextBox_NumRemito.Text = "" Then
                MsgBox("Debe ingresar un número de remito para guardar", MsgBoxStyle.Information, "¡Atención!")
                TextBox_NumRemito.Focus()
                Exit Sub
            End If
            If TextBox_Vehiculo.Text = "" Then
                MsgBox("Debe ingresar un vehículo para guardar", MsgBoxStyle.Information, "¡Atención!")
                TextBox_Vehiculo.Focus()
                Exit Sub
            End If
            If TextBox_KMCamion.Text = "" Or TextBox_KMValor.Text = "" Then
                MsgBox("Debe ingresar los kilómetros del recorrido y el valor por kilómetro para guardar", MsgBoxStyle.Information, "¡Atención!")
                TextBox_KMCamion.Focus()
                Exit Sub
            End If
            If TextBox_NumCarga.Text = "" Or ComboBox_Detalle.Text = "" Then
                MsgBox("Debe ingresar la carga y cantidad para guardar", MsgBoxStyle.Information, "¡Atención!")
                TextBox_NumCarga.Focus()
                Exit Sub
            End If
            If ComboBox_LugarCarga.Text = "" Or ComboBox_LugarDescarga.Text = "" Then
                MsgBox("Debe ingresar el lugar de carga y descarga para guardar", MsgBoxStyle.Information, "¡Atención!")
                ComboBox_LugarCarga.Focus()
                Exit Sub
            End If
            If EstadoFactura = "" Or EstadoPago = "" Then
                MsgBox("Debe seleccionar el estado del pago y la factura para guardar", MsgBoxStyle.Information, "¡Atención!")
                Exit Sub
            End If
            If TextBox_Gastos.Text = "" Then
                TextBox_Gastos.Text = "0"
            End If
            'Sacando IdCliente.-
            Cliente = Split(TextBox_Cliente.Text, ",")
            'Calculando KM Totales.-
            KMT = Val(TextBox_KMCamion.Text) * 2.2
            'Separando Matriculas.-
            Camiones = Split(TextBox_Vehiculo.Text, ",")
        End If

        'Guardando Datos.-
        Select Case Me.Tag
            Case Is = "1" 'Si está Agregando.-
                'Actualizando KM de Camion, Aceite y Cubiertas.-
                For i = 0 To Camiones.Length - 1
                    If Camiones(i) <> Nothing Then
                        If ActualizarKM(Camiones(i), KMT) = False Then
                            MsgBox("No se han podido actualizar los datos del Kilometraje, es posible que el vehiculo no se encuentre en la base de datos", MsgBoxStyle.Exclamation, "Error")
                        End If
                    End If
                Next
                'Exit Sub

                'Guardando datos.-
                Dim ObjAgregar As New ClaseBD
                If ObjAgregar.Agregar("INSERT INTO OrdenesCD (FechaOrden, Guia, Remito, kmcamion, IdCamion, valorkm, numcarga, detallecarga, LugarCarga, LugarDescarga, GastosVarios, DetalleGastos, Total, EstadodePago, EstadodeFacturacion, CodigoCliente) " _
                                      + "VALUES ('" & DatePicker_Fecha.Text & "','" & TextBox_NumGuia.Text & "','" & TextBox_NumRemito.Text & "', '" & TextBox_KMCamion.Text & "', '" & TextBox_Vehiculo.Text & "', " & TextBox_KMValor.Text & "," _
                                      + " '" & TextBox_NumCarga.Text & "','" & ComboBox_Detalle.Text & "','" & ComboBox_LugarCarga.Text & "','" & ComboBox_LugarDescarga.Text & "','" & TextBox_Gastos.Text & "','" & TextBox_DetalleGastos.Text & "'," & TextBox_Total.Text & ",'" & EstadoPago & "','" & EstadoFactura & "'," & Cliente(0) & ")") = True Then
                    Select Case MessageBox.Show("Se han guardado los datos, ¿Desea continuar agregando ordenes?", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        Case Windows.Forms.DialogResult.Yes
                            Call LimpiarTextboxGroupBox(Me.GroupBox_Datos)
                            ComboBox_Detalle.SelectedItem = Nothing
                            ComboBox_LugarCarga.SelectedItem = Nothing
                            ComboBox_LugarDescarga.SelectedItem = Nothing
                            RadioButton_Debe.Checked = True
                            RadioButton_NoFacturado.Checked = True
                            ConsultaNofiticacion2()
                        Case Windows.Forms.DialogResult.No
                            Me.Close()
                    End Select
                Else
                    MsgBox("No se han podido guardar los datos", MsgBoxStyle.Exclamation, "¡Atención!")
                End If

            Case Is = "2" 'Si está Modificando.-
                'Si cambia el Kilometraje o los Vehiculos.-
                If Val(TextBox_KMCamion.Text) <> KMOG Or TextBox_Vehiculo.Text <> VehiculosOrig Then
                    'Borra KM viejos.-
                    For i = 0 To VehiculosOrigArr.Length - 1
                        If VehiculosOrigArr(i) <> Nothing Then
                            If ActualizarKM(VehiculosOrigArr(i), (KMOG * (-2.2))) = False Then
                                MsgBox("No se han podido actualizar los datos del Kilometraje, es posible que el vehiculo no se encuentre en la base de datos", MsgBoxStyle.Exclamation, "Error")
                            End If
                        End If
                    Next
                    'Agrega KM nuevos.-
                    For i = 0 To Camiones.Length - 1
                        If Camiones(i) <> Nothing Then
                            If ActualizarKM(Camiones(i), KMT) = False Then
                                MsgBox("No se han podido actualizar los datos del Kilometraje, es posible que el vehiculo no se encuentre en la base de datos", MsgBoxStyle.Exclamation, "Error")
                            End If
                        End If
                    Next
                End If

                'Actualizando Datos.-
                Select Case MessageBox.Show("¿Está seguro de querer guardar los cambios? Esta acción no se podrá revertir", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    Case Windows.Forms.DialogResult.Yes
                        Dim ObjModificar As New ClaseBD
                        If ObjModificar.Modificar("UPDATE OrdenesCD SET FechaOrden='" & DatePicker_Fecha.Text & "',Guia='" & TextBox_NumGuia.Text & "',Remito='" & TextBox_NumRemito.Text & "',kmcamion='" & TextBox_KMCamion.Text & "',IdCamion='" & TextBox_Vehiculo.Text & "',valorkm=" & TextBox_KMValor.Text & ",NumCarga='" & TextBox_NumCarga.Text & "',DetalleCarga='" & ComboBox_Detalle.Text & "',LugarCarga='" & ComboBox_LugarCarga.Text & "',LugarDescarga='" & ComboBox_LugarDescarga.Text & "',GastosVarios='" & TextBox_Gastos.Text & "',DetalleGastos='" & TextBox_DetalleGastos.Text & "',Total=" & TextBox_Total.Text & ",EstadoDePago='" & EstadoPago & "',EstadoDeFacturacion='" & EstadoFactura & "',CodigoCliente=" & Cliente(0) & " WHERE OrdenesCD.IdOrden=" & TextBox_NumOrden.Text) = False Then
                            MsgBox("No se han podido guardar los cambios", MsgBoxStyle.Information, "¡Atención!")
                            Exit Sub
                        End If
                        MsgBox("Se han modificado los datos de la orden.", MsgBoxStyle.Information, "Cambios Guardados")
                        Me.Close()
                    Case Windows.Forms.DialogResult.No
                        Exit Sub
                End Select

            Case Is = "3" 'Si está Viendo.-
                    Label_Titulo.Text = "Modificar Orden"
                    DatePicker_Fecha.Enabled = True
                    Bot_Guardar.Text = "Guardar"
                    Bot_Cancelar.Text = "Cancelar"
                    Bot_MostrarClientes.Enabled = True
                    Bot_MostrarVehiculos.Enabled = True
                    RadioButton_Debe.Enabled = True
                    RadioButton_Facturado.Enabled = True
                    RadioButton_NoFacturado.Enabled = True
                    RadioButton_Pago.Enabled = True
                    Me.Tag = "2"
                    For Each H As Control In Me.GroupBox_Datos.Controls
                        If TypeOf H Is TextBox Then
                            Dim TB As TextBox = DirectCast(H, TextBox)
                            TB.ReadOnly = False
                        End If
                        If TypeOf H Is ComboBox Or TypeOf H Is RadioButton Then
                            H.Enabled = True
                        End If
                    Next
                    TextBox_NumOrden.ReadOnly = True
                    TextBox_Cliente.ReadOnly = True
                    TextBox_Vehiculo.ReadOnly = True
                    TextBox_Total.ReadOnly = True

            Case Is = "4" 'Si está Restaurando.-
                    Select Case MessageBox.Show("¿Está seguro de querer Restaurar este dato?", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        Case Windows.Forms.DialogResult.Yes
                            Dim ObjEliminar As New ClaseBD
                        If ObjEliminar.Modificar("UPDATE OrdenesCD SET OrdenesCD.Estado = 1 WHERE OrdenesCD.IdOrden=" & TextBox_NumOrden.Text) = True Then
                            'Vuelve a agregar KM.-
                            For i = 0 To VehiculosOrigArr.Length - 1
                                If VehiculosOrigArr(i) <> Nothing Then
                                    If ActualizarKM(VehiculosOrigArr(i), KMOG * 2.2) = False Then
                                        MsgBox("No se han podido actualizar los datos del Kilometraje, es posible que el vehiculo no se encuentre en la base de datos", MsgBoxStyle.Exclamation, "Error")
                                    End If
                                End If
                            Next
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

#Region "GENERANDO DATOS"

    Private Sub TextBox_KMCamion_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox_KMCamion.LostFocus, TextBox_Vehiculo.TextChanged
        TextBox_AceiteMil.Text = ""
        TextBox_AceiteVencido.Text = ""
        If TextBox_KMCamion.Text = "" Or TextBox_Vehiculo.Text = "" Then
            Panel_Aceite.Visible = False
            Exit Sub
        End If
        Camiones = Split(TextBox_Vehiculo.Text, ",")
        Dim KMA(Camiones.Length - 1) As Integer
        For i = 0 To Camiones.Length - 1
            If Camiones(i) <> Nothing Then
                Dim ObjConsultaKM As New ClaseBD
                If ObjConsultaKM.Consulta("SELECT Camiones.kmaceite FROM Camiones WHERE Camiones.idcamion='" & Camiones(i) & "';") = True Then
                    KMA(i) = DatosConsulta.Rows(0).Item("kmaceite") + (Val(TextBox_KMCamion.Text) * (2.2))
                    Select Case KMA(i)
                        Case Is >= 10000
                            If TextBox_AceiteVencido.Text <> "" Then
                                TextBox_AceiteVencido.Text += ", " & Camiones(i)
                            Else
                                TextBox_AceiteVencido.Text = Camiones(i)
                            End If
                        Case Is >= 9000 And KMA(i) < 10000
                            If TextBox_AceiteMil.Text <> "" Then
                                TextBox_AceiteMil.Text += ", " & Camiones(i)
                            Else
                                TextBox_AceiteMil.Text = Camiones(i)
                            End If
                    End Select
                End If
            End If
        Next
        If TextBox_AceiteMil.Text = "" And TextBox_AceiteVencido.Text = "" Then
            Panel_Aceite.Visible = False
        Else
            Panel_Aceite.Visible = True
        End If
    End Sub

    Private Sub CalculoTotal(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox_KMCamion.TextChanged, TextBox_KMValor.TextChanged, TextBox_Gastos.TextChanged
        If TextBox_KMCamion.Text <> "" And TextBox_KMValor.Text <> "" Then
            TextBox_Total.Text = (Val(TextBox_KMValor.Text) * Val(TextBox_KMCamion.Text)) + Val(TextBox_Gastos.Text)
        End If
    End Sub


    Private Sub RadioEstadoPago(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton_Debe.CheckedChanged, RadioButton_Pago.CheckedChanged
        EstadoPago = sender.Text
    End Sub

    Private Sub RadioEstadoFactura(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton_Facturado.CheckedChanged, RadioButton_NoFacturado.CheckedChanged
        EstadoFactura = sender.Text
    End Sub



#End Region

#Region "SELECCION DE CLIENTE/VEHICULOS"

    Private Sub Bot_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_MostrarClientes.Click, Bot_MostrarVehiculos.Click
        Panel_Datos.Left = 18
        Panel_Datos.Enabled = False
        Panel_Tablas.Left = Bot_Guardar.Left + 5
        Panel_Tablas.Visible = True
        Label_TituloTabla.Text = "Seleccionar " & sender.Tag
        BotonQueAbre = sender.Tag
        If sender.Tag = "Cliente" Then 'Si está seleccionando Cliente.-
            WMTextBox_Buscar.WaterMarkText = "Buscar Cliente por Nombre"
            Busqueda()
        Else 'Si está seleccionando Vehiculos.-
            WMTextBox_Buscar.WaterMarkText = "Matrícula, Marca o Modelo"
            CheckedListBox_Vehiculos.Visible = True
            WMTextBox_Buscar.Visible = False
            Bot_Borrar.Visible = False
            DataGridView_Datos.Visible = False
        End If
        WMTextBox_Buscar.Focus()
    End Sub


    Private Sub TextBox_Vehiculo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox_Vehiculo.Click
        Bot_MostrarVehiculos.PerformClick()
    End Sub

    Private Sub Busqueda()
        If WMTextBox_Buscar.Text <> "" Then
            ActualizarTabla(DataGridView_Datos, "SELECT Clientes.IdCliente, Clientes.Nombre FROM Clientes WHERE  Clientes.Nombre Like '%" & WMTextBox_Buscar.Text & "%' AND Clientes.Estado=1;", CS)
        Else
            ActualizarTabla(DataGridView_Datos, "SELECT Clientes.IdCliente, Clientes.Nombre FROM Clientes WHERE Clientes.Estado=1;", CS)
        End If
        If DataGridView_Datos.Rows.Count > 0 Then
            DataGridView_Datos.Rows(0).Selected = True
            DataGridView_Datos.Columns(0).HeaderText = "ID"
            DataGridView_Datos.Columns(0).Width = 50
        End If
    End Sub

    Private Sub WMTextBox_Buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WMTextBox_Buscar.TextChanged
        Busqueda()
    End Sub

    Private Sub TextBox_Cliente_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox_Cliente.Click
        Bot_MostrarClientes.PerformClick()
    End Sub

    Private Sub Bot_Borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Borrar.Click
        WMTextBox_Buscar.Text = ""
    End Sub

    Private Sub Bot_Seleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Seleccionar.Click
        'Si Muestra Clientes.-
        If Label_TituloTabla.Text = "Seleccionar Cliente" Then
            TextBox_Cliente.Text = ""
            TextBox_Cliente.Text = DataGridView_Datos.SelectedRows(0).Cells(0).Value & ", " & DataGridView_Datos.SelectedRows(0).Cells(1).Value
            'Si muestra Vehículos.-
        Else
            TextBox_Vehiculo.Text = ""
            'Checkea si tiene alguno seleccionado.-
            If CheckedListBox_Vehiculos.CheckedItems.Count = 0 Then
                MsgBox("No hay vehículos seleciconados", MsgBoxStyle.Exclamation, "Atención")
                Exit Sub
            Else
                Dim Vehiculo(1) As String
                Dim Obj As Object
                For Each Obj In CheckedListBox_Vehiculos.CheckedItems
                    Vehiculo = Split(Obj.ToString, "-")
                    If TextBox_Vehiculo.Text = "" Then
                        TextBox_Vehiculo.Text = Vehiculo(0)
                    Else
                        TextBox_Vehiculo.Text += "," & Vehiculo(0)
                    End If
                Next
            End If
        End If
        Bot_CerrarTabla.PerformClick()
    End Sub

    Private Sub Bot_CerrarTabla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_CerrarTabla.Click
        WMTextBox_Buscar.Text = ""
        If CheckedListBox_Vehiculos.Visible = True Then
            CheckedListBox_Vehiculos.Visible = False
            WMTextBox_Buscar.Visible = True
            Bot_Borrar.Visible = True
            DataGridView_Datos.Visible = True
        End If
        Panel_Tablas.Visible = False
        Panel_Datos.Left = 68
        Panel_Datos.Enabled = True
        Panel_Tablas.Left = Panel_Datos.Right
        If BotonQueAbre = "Cliente" Then
            TextBox_Cliente.Focus()
        Else
            TextBox_Vehiculo.Focus()
        End If
    End Sub

#End Region

#Region "VALIDACIÓN DE DATOS KEYPRESS"

    Private Sub TextBox_SoloNumeros_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_KMCamion.KeyPress, TextBox_KMValor.KeyPress, TextBox_Gastos.KeyPress
        'Solo permite Números.-
        If InStr("0123456789" & Chr(8), e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

#End Region

End Class