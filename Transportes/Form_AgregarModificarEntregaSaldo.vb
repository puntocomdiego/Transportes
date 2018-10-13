Public Class Form_AgregarModificarEntregaSaldo
    Dim EstadoFactura As String = "" 'Guarda el estado de la Factura según RadioButton.Checked.-

    Private Sub Form_AgregarModificarEntregaSaldo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ObjConsulta As New ClaseBD
        If ObjConsulta.Consulta("SELECT Clientes.IdCliente, Clientes.Nombre, Clientes.Direccion, Clientes.Telefono, Clientes.Celular, Clientes.RUT, OrdenesCD.IdOrden, OrdenesCD.IdCamion, OrdenesCD.detallecarga, OrdenesCD.FechaOrden, OrdenesCD.LugarCarga, OrdenesCD.LugarDescarga, OrdenesCD.EstadodePago, OrdenesCD.EstadodeFacturacion, OrdenesCD.Total FROM Clientes INNER JOIN OrdenesCD ON Clientes.IdCliente = OrdenesCD.Codigocliente WHERE Clientes.IdCliente=" & IDS(0) & " AND OrdenesCD.IdOrden=" & IDS(1) & " AND Clientes.Estado=1 AND OrdenesCD.Estado=1;") = False Then
            MsgBox("No data")
            Me.Close()
        End If
        If DatosConsulta.Rows.Count > 0 Then
            'Información del Cliente.-
            TextBox_CodigoCliente.Text = DatosConsulta.Rows(0).Item("IdCliente").ToString
            TextBox_NombreCliente.Text = DatosConsulta.Rows(0).Item("Nombre").ToString
            TextBox_DireccionCliente.Text = DatosConsulta.Rows(0).Item("Direccion").ToString
            TextBox_TelefonoCliente.Text = DatosConsulta.Rows(0).Item("Telefono").ToString
            TextBox_CelularCliente.Text = DatosConsulta.Rows(0).Item("Celular").ToString
            TextBox_RUTCliente.Text = DatosConsulta.Rows(0).Item("RUT").ToString

            'Información de la Orden.-
            TextBox_NOrden.Text = DatosConsulta.Rows(0).Item("IdOrden").ToString
            TextBox_Camion.Text = DatosConsulta.Rows(0).Item("IdCamion").ToString
            TextBox_Carga.Text = DatosConsulta.Rows(0).Item("detallecarga").ToString
            TextBox_Fecha.Text = DatosConsulta.Rows(0).Item("FechaOrden").ToString
            TextBox_LugarCarga.Text = DatosConsulta.Rows(0).Item("LugarCarga").ToString
            TextBox_LugarDescarga.Text = DatosConsulta.Rows(0).Item("LugarDescarga").ToString
            TextBox_EstadoPago.Text = DatosConsulta.Rows(0).Item("EstadoDePago").ToString
            TextBox_EstadoFactura.Text = DatosConsulta.Rows(0).Item("EstadodeFacturacion").ToString
            TextBox_TotalOrden.Text = DatosConsulta.Rows(0).Item("Total").ToString
            Dim ObjSQL As New ClaseBD
            If ObjConsulta.Consulta("SELECT OrdenesCD.Total, Sum(Entregas.MontoEntrega) AS SumaDeMontoEntrega FROM OrdenesCD INNER JOIN Entregas ON OrdenesCD.IdOrden = Entregas.NumOrden GROUP BY OrdenesCD.Total, OrdenesCD.IdOrden HAVING OrdenesCD.IdOrden=" & IDS(1) & ";") = True Then
                If DatosConsulta.Rows.Count > 0 Then
                    TextBox_SaldoActual.Text = Val(TextBox_TotalOrden.Text) - Val(DatosConsulta.Rows(0).Item("SumaDeMontoEntrega"))
                End If
            End If
        End If

        'Si está Modificando o Viendo.-
        If Me.Tag = "2" Or Me.Tag = "3" Or Me.Tag = "4" Then
            Label_Titulo.Text = "Modificar Entrega de Saldo"
            If ObjConsulta.Consulta("SELECT * FROM Entregas WHERE IdEntrega=" & CampoClaveInt) = False Then
                MsgBox("No ")
                Me.Close()
            End If
            If DatosConsulta.Rows.Count > 0 Then
                DatePicker_FechaEntrega.Value = DatosConsulta.Rows(0).Item("FechaEntrega")
                TextBox_Recibo.Text = DatosConsulta.Rows(0).Item("NumRecibo").ToString
                TextBox_Factura.Text = DatosConsulta.Rows(0).Item("NumFactura").ToString
                TextBox_Monto.Text = DatosConsulta.Rows(0).Item("MontoEntrega").ToString
                TextBox_TipoEntrega.Text = DatosConsulta.Rows(0).Item("TipoEntrega").ToString
                'Estado de Factura.-
                If DatosConsulta.Rows(0).Item("EstadoFactura") = "Facturado" Then
                    RadioButton_Facturado.Checked = True
                ElseIf DatosConsulta.Rows(0).Item("EstadoFactura") = "No Facturado" Then
                    RadioButton_NoFacturado.Checked = True
                Else
                    RadioButton_Facturado.Checked = False
                    RadioButton_NoFacturado.Checked = False
                End If
                Bot_Volver.Visible = False
            End If
        End If

        'Si está Viendo o Restaurando.-
        If Me.Tag = "3" Or Me.Tag = "4" Then
            Label_Titulo.Text = "Datos de Entrega de Saldo"
            Bot_Guardar.Text = "Modificar"
            Bot_Cancelar.Text = "Volver"
            For Each H As Control In Me.GroupBox_Entrega.Controls
                If TypeOf H Is TextBox Then
                    Dim TB As TextBox = DirectCast(H, TextBox)
                    TB.ReadOnly = True
                    TB.BackColor = Color.White
                End If
            Next
            DatePicker_FechaEntrega.Enabled = False
            RadioButton_Facturado.Enabled = False
            RadioButton_NoFacturado.Enabled = False
        End If

        'Si Restaura.-
        If Me.Tag = "4" Then
            Label_Titulo.Text += " Eliminada"
            Bot_Guardar.Text = "Restaurar"
        End If

        TextBox_Recibo.Focus()
    End Sub

#Region "BOTONES GUARDAR/VOLVER"

    Private Sub Bot_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Guardar.Click
        'Verificaciones.-
        If Me.Tag = "1" Or Me.Tag = "2" Then
            If TextBox_Recibo.Text = "" Or TextBox_Factura.Text = "" Or TextBox_SaldoFinal.Text = "" Or TextBox_Monto.Text = "" Then
                MsgBox("Debe completar los datos para guardar", MsgBoxStyle.Information, "¡Atención!")
                TextBox_Recibo.Focus()
                Exit Sub
            End If
            If EstadoFactura = "" Then
                MsgBox("Debe seleccionar un Estado de Facturación", MsgBoxStyle.Information, "¡Atención!")
                RadioButton_Facturado.Focus()
                Exit Sub
            End If
        End If

        Select Case Me.Tag
            Case Is = "1" 'Si está Agregando.-
                Dim ObjAgregar As New ClaseBD
                If ObjAgregar.Agregar("INSERT INTO Entregas (FechaEntrega,NumFactura,NumRecibo,MontoEntrega,IdCliente,EstadoFactura,TipoEntrega,NumOrden) VALUES ('" & DatePicker_FechaEntrega.Text & "','" & TextBox_Factura.Text & "','" & TextBox_Recibo.Text & "'," & Val(TextBox_Monto.Text) & "," & Val(TextBox_CodigoCliente.Text) & ",'" & EstadoFactura & "','" & TextBox_TipoEntrega.Text & "'," & Val(TextBox_NOrden.Text) & ")") = True Then
                    MsgBox("Se han guardado los datos de la entrega de Saldo", MsgBoxStyle.Information, "¡Atención!")
                    Me.Close()
                Else
                    MsgBox("No se han podido guardar los datos, inténtelo denuevo", MsgBoxStyle.Exclamation, "Error")
                    Exit Sub
                End If

            Case Is = "2" 'Si está Modificando.-
                Select Case MessageBox.Show("¿Está seguro de querer guardar los cambios? Esta acción no se podrá revertir", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    Case Windows.Forms.DialogResult.Yes
                        Dim ObjModificar As New ClaseBD
                        If ObjModificar.Modificar("UPDATE Entregas SET FechaEntrega='" & DatePicker_FechaEntrega.Text & "',NumFactura='" & TextBox_Factura.Text & "',NumRecibo='" & TextBox_Recibo.Text & "',MontoEntrega=" & Val(TextBox_Monto.Text) & ",IdCliente=" & Val(TextBox_CodigoCliente.Text) & ",EstadoFactura='" & EstadoFactura & "',TipoEntrega='" & TextBox_TipoEntrega.Text & "',NumOrden=" & Val(TextBox_NOrden.Text) & " WHERE IdEntrega=" & DatosConsulta.Rows(0).Item("IdEntrega")) = False Then
                            MsgBox("No se pudieron modificar los datos de la entrega, inténtelo denuevo.", MsgBoxStyle.Exclamation, "Error")
                            Exit Sub
                        End If
                        MsgBox("Se han modificado los datos de la entrega.", MsgBoxStyle.Information, "Cambios Guardados")
                        Me.Close()
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
                Label_Titulo.Text = "Modificar Entrega de Saldo"
                DatePicker_FechaEntrega.Enabled = True
                RadioButton_Facturado.Enabled = True
                RadioButton_NoFacturado.Enabled = True
                Bot_Guardar.Text = "Guardar"
                Bot_Cancelar.Text = "Cancelar"
                Me.Tag = "2"

            Case Is = "4" 'Si está Restaurando.-
                Select Case MessageBox.Show("¿Está seguro de querer Restaurar este dato?", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    Case Windows.Forms.DialogResult.Yes
                        Dim ObjEliminar As New ClaseBD
                        If ObjEliminar.Modificar("UPDATE Entregas SET Entregas.Estado = 1 WHERE Entregas.IdEntrega=" & CampoClaveInt) = True Then
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
                    Call LimpiarTextboxGroupBox(Me.GroupBox_Entrega)
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

#Region "VERIFICAICONES DE DATOS INGRESADOS"

    Private Sub TextBox_TotalMonto_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox_TotalOrden.TextChanged, TextBox_Monto.TextChanged
        TextBox_SaldoFinal.Text = Val(TextBox_TotalOrden.Text) - Val(TextBox_Monto.Text)
    End Sub

    Private Sub RadioButton_Facturacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton_Facturado.CheckedChanged, RadioButton_NoFacturado.CheckedChanged
        EstadoFactura = sender.Text
    End Sub

    Private Sub TextBox_Monto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_Monto.KeyPress
        'Solo permite Números.-
        If InStr("0123456789" & Chr(8), e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

#End Region
    
End Class