Imports MySql.Data.MySqlClient

Public Class History
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim dbdataset As New DataTable

    Private Sub History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=banking_database"

        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource

        Try
            conn.Open()
            Dim Query As String
            Query = "SELECT id as 'Id',amount as 'Amount',action as 'Action',receiver as 'Receiver Id',time as 'Transaction Time' FROM banking_database.historyinfo where id= '" & UserForm.id & "'"
            COMMAND = New MySqlCommand(Query, conn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbdataset)
            bSource.DataSource = dbdataset
            dgv_history.DataSource = bSource
            SDA.Update(dbdataset)
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
End Class