Imports System.Data.OleDb
Public Class ClaseBD
    Dim ComandoSql As OleDbCommand

    Function Consulta(ByVal SQL As String) As Boolean
        Try
            Dim Da As New OleDbDataAdapter
            Da = New OleDbDataAdapter(SQL, CS)
            DatosConsulta = New DataTable
            Da.Fill(DatosConsulta)
            Return True
        Catch exsql As OleDbException
            MsgBox(exsql.Message)
            Return False
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Function Agregar(ByVal SQL As String) As Boolean
        Try
            Dim con As New OleDbConnection(CS)
            con.Open()
            ComandoSql = New OleDbCommand(Sql, con)
            ComandoSql.ExecuteNonQuery()
            ComandoSql.Dispose()
            Sql = String.Empty
            con.Close()
            Return True
        Catch exsql As OleDbException
            MsgBox(exsql.Message)
            Return False
        Catch ex As Exception
            Return False
        End Try

    End Function

    Function Modificar(ByVal SQL As String) As Boolean
        Try
            Dim con As New OleDbConnection(CS)
            con.Open()
            ComandoSql = New OleDbCommand(Sql, con)
            ComandoSql.ExecuteNonQuery()
            ComandoSql.Dispose()
            Sql = String.Empty
            con.Close()
            Return True
        Catch exsql As OleDbException
            MsgBox(exsql.Message)
            Return False
        Catch ex As Exception
            Return False
        End Try
    End Function

End Class
