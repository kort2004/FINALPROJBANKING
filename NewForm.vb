Imports System.Diagnostics.Eventing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.X509

Public Class NewForm
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_create.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=banking_database"
        Dim READER As MySqlDataReader
        Dim id
        Try
            conn.Open()
            Dim Query As String
            If txtbox_password.Text = txtbox_confirmpass.Text Then
                Query = "INSERT INTO banking_database.userinfo (id,firstname,lastname,birthday,address) Values ((Select COALESCE(MAX(id), 0) + 1 FROM logininfo), '" & txtbox_firstname.Text & "' ,'" & txtbox_lastname.Text & "' , '" & datepicker_dob.Text & "' , '" & txtbox_address.Text & "')"
                COMMAND = New MySqlCommand(Query, conn)
                READER = COMMAND.ExecuteReader
                READER.Close()
                Query = "INSERT INTO banking_database.logininfo (id,username,password) Values ((SELECT COALESCE(MAX(id), 0) FROM userinfo),'" & txtbox_username.Text & "' ,'" & txtbox_password.Text & "')"
                COMMAND = New MySqlCommand(Query, conn)
                READER = COMMAND.ExecuteReader
                READER.Close()

                Query = "SELECT id FROM banking_database.userinfo where firstname ='" & txtbox_firstname.Text & "'"
                COMMAND = New MySqlCommand(Query, conn)
                READER = COMMAND.ExecuteReader
                While READER.Read
                    id = READER.GetInt32("id")
                End While

                READER.Close()


                conn.Close()
                UserForm.id = id
                UserForm.Show()
                Me.Close()
            Else
                MessageBox.Show("Password Doesn't Match")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btn_NewAcc_Click(sender As Object, e As EventArgs) Handles btn_NewAcc.Click
        form_login.Show()
        Me.Close()
    End Sub
End Class