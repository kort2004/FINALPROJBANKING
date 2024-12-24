Imports MySql.Data.MySqlClient

Public Class form_login
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=banking_database"
        Dim READER As MySqlDataReader
        Dim Id
        Try
            conn.Open()
            Dim Query As String
            Query = "SELECT id FROM banking_database.logininfo where username ='" & txtbox_username.Text & "'"
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                Id = READER.GetInt32("id")
            End While
            UserForm.id = Id
            READER.Close()

            Query = "SELECT * FROM logininfo WHERE username = '" & txtbox_username.Text & "' AND password = '" & txtbox_password.Text & "'"
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader
            Dim count As Integer
            count = 0
            While READER.Read
                count = count + 1
            End While
            If count = 1 Then
                If txtbox_username.Text = "admin" Then
                    adminviewform.Show()
                    Me.Close()
                Else
                    UserForm.Show()
                    Me.Close()
                End If

            ElseIf count > 1 Then
                MessageBox.Show("Username and password are duplicate!")
            Else
                MessageBox.Show("Username and password are incorrect!")
            End If

            READER.Close()




            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub btn_NewAccClick(sender As Object, e As EventArgs) Handles btn_NewAcc.Click
        NewForm.Show()
        Me.Close()
    End Sub

    Private Sub Txtbox_password_KeyDown(sender As Object, e As KeyPressEventArgs) Handles txtbox_password.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            btn_login.PerformClick()
            e.Handled = True
        End If

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
