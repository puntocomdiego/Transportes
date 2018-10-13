


Public Class Form_RespaldoInformacion


    Private Sub Bot_Zip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Zip.Click
        'http://mkasoft.com/how-to/39-how-to-compress-file
    End Sub

    Private Sub Bot_Drive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Drive.Click

    End Sub



    Sub EnableBusqueda(ByVal Bool As Boolean)
        WMTextBox_Buscar.Enabled = Bool
        Bot_Borrar.Enabled = Bool
        DataGridView_Respaldos.Enabled = Bool
        Bot_Drive.Enabled = Bool
        Bot_Zip.Enabled = Bool
    End Sub

End Class