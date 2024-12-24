<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_login))
        txtbox_username = New TextBox()
        txtbox_password = New TextBox()
        btn_login = New Button()
        btn_NewAcc = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        PictureBox2 = New PictureBox()
        Label6 = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtbox_username
        ' 
        txtbox_username.Location = New Point(129, 213)
        txtbox_username.Name = "txtbox_username"
        txtbox_username.PlaceholderText = "Type your username"
        txtbox_username.Size = New Size(200, 23)
        txtbox_username.TabIndex = 0
        ' 
        ' txtbox_password
        ' 
        txtbox_password.Location = New Point(130, 278)
        txtbox_password.Name = "txtbox_password"
        txtbox_password.PlaceholderText = "Type your password"
        txtbox_password.Size = New Size(200, 23)
        txtbox_password.TabIndex = 1
        txtbox_password.UseSystemPasswordChar = True
        ' 
        ' btn_login
        ' 
        btn_login.Font = New Font("Viner Hand ITC", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_login.Location = New Point(129, 349)
        btn_login.Name = "btn_login"
        btn_login.Size = New Size(199, 23)
        btn_login.TabIndex = 2
        btn_login.Text = "LOGIN"
        btn_login.UseVisualStyleBackColor = True
        ' 
        ' btn_NewAcc
        ' 
        btn_NewAcc.Font = New Font("Viner Hand ITC", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_NewAcc.Location = New Point(264, 471)
        btn_NewAcc.Name = "btn_NewAcc"
        btn_NewAcc.Size = New Size(92, 23)
        btn_NewAcc.TabIndex = 3
        btn_NewAcc.Text = "Register "
        btn_NewAcc.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(129, 185)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 25)
        Label1.TabIndex = 4
        Label1.Text = "Username"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(129, 250)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 25)
        Label2.TabIndex = 5
        Label2.Text = "Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(109, 475)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(150, 19)
        Label3.TabIndex = 6
        Label3.Text = "Don't have an account?"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(0, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 15)
        Label4.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Viner Hand ITC", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.Control
        Label5.Location = New Point(77, 64)
        Label5.Name = "Label5"
        Label5.Size = New Size(317, 78)
        Label5.TabIndex = 8
        Label5.Text = "PANTHEON"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(29, 75)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(59, 52)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 24
        PictureBox2.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Viner Hand ITC", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ButtonHighlight
        Label6.Location = New Point(149, 118)
        Label6.Name = "Label6"
        Label6.Size = New Size(160, 24)
        Label6.TabIndex = 25
        Label6.Text = "ONLINE BANKING"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(68, -30)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(338, 145)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 26
        PictureBox1.TabStop = False
        ' 
        ' form_login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(461, 606)
        Controls.Add(Label6)
        Controls.Add(PictureBox2)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btn_NewAcc)
        Controls.Add(btn_login)
        Controls.Add(txtbox_password)
        Controls.Add(txtbox_username)
        Controls.Add(PictureBox1)
        Name = "form_login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "BANKING APP"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtbox_username As TextBox
    Friend WithEvents txtbox_password As TextBox
    Friend WithEvents btn_login As Button
    Friend WithEvents btn_NewAcc As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox

End Class
