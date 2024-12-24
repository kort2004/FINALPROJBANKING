Imports MySql.Data.MySqlClient

Public Class adminviewform
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim dbdataset As New DataTable
    Private Sub dgv_customers_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgv_customers.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dgv_customers.Rows(e.RowIndex)
            txtbox_iddelete.Text = row.Cells("id").Value
        End If
    End Sub

    Private Sub adminviewform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=banking_database"

        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource

        Try
            conn.Open()
            Dim Query As String
            Query = "SELECT id,firstname,lastname,birthday,address,balance FROM banking_database.userinfo"
            COMMAND = New MySqlCommand(Query, conn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbdataset)
            bSource.DataSource = dbdataset
            dgv_customers.DataSource = bSource
            SDA.Update(dbdataset)
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=banking_database"
        Dim READER As MySqlDataReader
        Try
            conn.Open()
            Dim Query As String
            Query = "delete from banking_database.userinfo where id='" & txtbox_iddelete.Text & "'"
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader
            READER.Close()
            Query = "delete from banking_database.logininfo where id='" & txtbox_iddelete.Text & "'"
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader
            READER.Close()
            MessageBox.Show("Data deleted")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try

    End Sub

End Class