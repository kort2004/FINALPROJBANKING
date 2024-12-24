Imports MySql.Data.MySqlClient

Public Class UserForm
    Public id
    Public mybalance
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub reloadform()
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=banking_database"
        Dim READER As MySqlDataReader
        Dim newbalance
        Try
            conn.Open()
            Dim Query As String
            Query = "SELECT balance FROM banking_database.userinfo where id='" & id & "'"
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                mybalance = READER.GetInt32("balance")
                Lbl_AvailBal.Text = mybalance
            End While

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Private Sub btn_withdraw_Click(sender As Object, e As EventArgs) Handles btn_withdraw.Click
        Dim change = InputBox("Please enter Amount:", "Withdraw", "")
        If IsNumeric(change) Then
            conn = New MySqlConnection
            conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=banking_database"
            Dim READER As MySqlDataReader
            Dim balance
            Try
                conn.Open()
                Dim Query As String
                Query = "SELECT * FROM banking_database.userinfo where id='" & id & "'"
                COMMAND = New MySqlCommand(Query, conn)
                READER = COMMAND.ExecuteReader

                While READER.Read
                    balance = READER.GetInt32("balance")
                    balance -= change
                End While

                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                conn.Close()
            End Try
            Try
                conn.Open()
                Dim Query As String
                Query = "Update banking_database.userinfo SET balance='" & balance & "' where id='" & id & "'"
                COMMAND = New MySqlCommand(Query, conn)
                READER = COMMAND.ExecuteReader
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                conn.Close()
            End Try
            Try
                conn.Open()
                Dim Query As String
                Dim Timestamp As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                Query = "insert into banking_database.historyinfo (id,amount,action,receiver,time) Values (" & id & " , -" & change & ", 'Withdraw' , 'Self','" & Timestamp & "')"
                COMMAND = New MySqlCommand(Query, conn)
                READER = COMMAND.ExecuteReader
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                conn.Close()
            End Try
        ElseIf Not change = "" Then
            MsgBox("Incorrect Info, Please Try Again")
        End If
        Me.reloadform()
    End Sub

    Private Sub btn_deposit_Click(sender As Object, e As EventArgs) Handles btn_deposit.Click
        Dim change = InputBox("Please enter Amount:", "Deposit", "")
        If IsNumeric(change) Then
            conn = New MySqlConnection
            conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=banking_database"
            Dim READER As MySqlDataReader
            Dim balance
            Try
                conn.Open()
                Dim Query As String
                Query = "SELECT balance FROM banking_database.userinfo where id='" & id & "'"
                COMMAND = New MySqlCommand(Query, conn)
                READER = COMMAND.ExecuteReader

                While READER.Read
                    balance = READER.GetInt32("balance")
                    balance += change
                End While

                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                conn.Close()
            End Try
            Try
                conn.Open()
                Dim Query As String
                Query = "Update banking_database.userinfo SET balance='" & balance & "' where id='" & id & "'"
                COMMAND = New MySqlCommand(Query, conn)
                READER = COMMAND.ExecuteReader
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                conn.Close()
            End Try
            Try
                conn.Open()
                Dim Query As String
                Dim Timestamp As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                Query = "insert into banking_database.historyinfo (id,amount,action,receiver,time) Values (" & id & " , +" & change & ", 'Deposit' , 'Self','" & Timestamp & "')"
                COMMAND = New MySqlCommand(Query, conn)
                READER = COMMAND.ExecuteReader
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                conn.Close()
            End Try
        ElseIf Not change = "" Then
            MsgBox("Incorrect Info, Please Try Again")

        End If
        Me.reloadform()
    End Sub

    Private Sub UserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reloadform()
    End Sub

    Private Sub btn_transfer_Click(sender As Object, e As EventArgs) Handles btn_transfer.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=banking_database"
        Dim READER As MySqlDataReader
        Dim balance
        Dim checkid = InputBox("Please enter Id:", "Select Reciever", "")
        Dim change
        If IsNumeric(checkid) Then
            Try
                conn.Open()
                Dim Query As String
                Query = "SELECT * FROM banking_database.userinfo where id='" & checkid & "'"
                COMMAND = New MySqlCommand(Query, conn)
                READER = COMMAND.ExecuteReader
                While READER.Read
                    change = InputBox("Please enter amount:", "Select Amount", "")
                    If IsNumeric(change) Then
                        mybalance -= change
                        READER.Close()
                        Query = "Update banking_database.userinfo SET balance='" & mybalance & "' where id='" & id & "'"
                        COMMAND = New MySqlCommand(Query, conn)
                        READER = COMMAND.ExecuteReader
                        READER.Close()

                        Query = "SELECT balance FROM banking_database.userinfo where id='" & checkid & "'"
                        COMMAND = New MySqlCommand(Query, conn)
                        READER = COMMAND.ExecuteReader
                        While READER.Read
                            balance = READER.GetInt32("balance")
                            balance += change
                        End While
                        READER.Close()
                        Query = "Update banking_database.userinfo SET balance='" & balance & "' where id='" & checkid & "'"
                        COMMAND = New MySqlCommand(Query, conn)
                        READER = COMMAND.ExecuteReader
                        Try
                            conn.Open()
                            Dim Timestamp As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                            Query = "insert into banking_database.historyinfo (id,amount,action,receiver,time) Values (" & id & " , " & change & ", 'Withdraw' ," & checkid & " ,'" & Timestamp & "')"
                            COMMAND = New MySqlCommand(Query, conn)
                            READER = COMMAND.ExecuteReader
                            conn.Close()
                        Catch ex As Exception
                            MsgBox(ex.Message)
                            conn.Close()
                        End Try
                    ElseIf Not change = "" Then
                        MsgBox("Incorrect Info, Please Try Again")
                    End If
                End While
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                conn.Close()
            End Try
        ElseIf Not checkid = "" Then
            MsgBox("Incorrect Info, Please Try Again")
        End If
        reloadform()
    End Sub

    Private Sub btn_history_Click(sender As Object, e As EventArgs) Handles btn_history.Click
        If History.Visible = False Then
            History.Show()
        End If

    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        form_login.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub Lbl_AvailBal_Click(sender As Object, e As EventArgs) Handles Lbl_AvailBal.Click

    End Sub
End Class