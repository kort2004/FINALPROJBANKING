<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewForm))
        btn_create = New Button()
        txtbox_firstname = New TextBox()
        txtbox_lastname = New TextBox()
        txtbox_address = New TextBox()
        datepicker_dob = New DateTimePicker()
        txtbox_username = New TextBox()
        txtbox_password = New TextBox()
        txtbox_confirmpass = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        EMPYREAN = New Label()
        PictureBox7 = New PictureBox()
        Label8 = New Label()
        btn_NewAcc = New Button()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btn_create
        ' 
        btn_create.Font = New Font("Viner Hand ITC", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_create.Location = New Point(146, 481)
        btn_create.Name = "btn_create"
        btn_create.Size = New Size(177, 44)
        btn_create.TabIndex = 0
        btn_create.Text = "Register"
        btn_create.UseVisualStyleBackColor = True
        ' 
        ' txtbox_firstname
        ' 
        txtbox_firstname.BackColor = SystemColors.Window
        txtbox_firstname.Location = New Point(69, 133)
        txtbox_firstname.Name = "txtbox_firstname"
        txtbox_firstname.PlaceholderText = "firstname"
        txtbox_firstname.Size = New Size(166, 23)
        txtbox_firstname.TabIndex = 1
        ' 
        ' txtbox_lastname
        ' 
        txtbox_lastname.BackColor = SystemColors.Window
        txtbox_lastname.Location = New Point(260, 133)
        txtbox_lastname.Name = "txtbox_lastname"
        txtbox_lastname.PlaceholderText = "lastname"
        txtbox_lastname.Size = New Size(131, 23)
        txtbox_lastname.TabIndex = 3
        ' 
        ' txtbox_address
        ' 
        txtbox_address.ForeColor = SystemColors.WindowText
        txtbox_address.Location = New Point(69, 250)
        txtbox_address.Name = "txtbox_address"
        txtbox_address.PlaceholderText = "address"
        txtbox_address.Size = New Size(322, 23)
        txtbox_address.TabIndex = 5
        ' 
        ' datepicker_dob
        ' 
        datepicker_dob.CalendarFont = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        datepicker_dob.CalendarForeColor = SystemColors.Window
        datepicker_dob.CalendarTitleBackColor = SystemColors.Window
        datepicker_dob.CalendarTitleForeColor = SystemColors.Window
        datepicker_dob.CalendarTrailingForeColor = SystemColors.Window
        datepicker_dob.CustomFormat = "yyyy.MM.dd"
        datepicker_dob.Format = DateTimePickerFormat.Custom
        datepicker_dob.Location = New Point(69, 202)
        datepicker_dob.Name = "datepicker_dob"
        datepicker_dob.Size = New Size(158, 23)
        datepicker_dob.TabIndex = 6
        datepicker_dob.Value = New Date(2024, 12, 7, 13, 45, 48, 0)
        ' 
        ' txtbox_username
        ' 
        txtbox_username.Location = New Point(69, 298)
        txtbox_username.Name = "txtbox_username"
        txtbox_username.PlaceholderText = "username"
        txtbox_username.Size = New Size(322, 23)
        txtbox_username.TabIndex = 7
        ' 
        ' txtbox_password
        ' 
        txtbox_password.Location = New Point(69, 357)
        txtbox_password.Name = "txtbox_password"
        txtbox_password.PlaceholderText = "password"
        txtbox_password.Size = New Size(322, 23)
        txtbox_password.TabIndex = 8
        ' 
        ' txtbox_confirmpass
        ' 
        txtbox_confirmpass.Location = New Point(69, 414)
        txtbox_confirmpass.Name = "txtbox_confirmpass"
        txtbox_confirmpass.PlaceholderText = "confirm password"
        txtbox_confirmpass.Size = New Size(322, 23)
        txtbox_confirmpass.TabIndex = 9
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(72, 111)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 19)
        Label1.TabIndex = 10
        Label1.Text = "First Name"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(260, 111)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 19)
        Label2.TabIndex = 11
        Label2.Text = "Last Name"
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(72, 180)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(123, 19)
        Label3.TabIndex = 12
        Label3.Text = "Enter Date of Birth"
        Label3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(72, 228)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(95, 19)
        Label4.TabIndex = 13
        Label4.Text = "Enter Address"
        Label4.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ButtonHighlight
        Label5.Location = New Point(72, 276)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(126, 19)
        Label5.TabIndex = 14
        Label5.Text = "Create a Username"
        Label5.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ButtonHighlight
        Label6.Location = New Point(72, 335)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(116, 19)
        Label6.TabIndex = 15
        Label6.Text = "Enter a Password"
        Label6.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ButtonHighlight
        Label7.Location = New Point(69, 392)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(122, 19)
        Label7.TabIndex = 16
        Label7.Text = "Confirm Password"
        Label7.TextAlign = ContentAlignment.TopCenter
        ' 
        ' EMPYREAN
        ' 
        EMPYREAN.AutoSize = True
        EMPYREAN.BackColor = Color.Transparent
        EMPYREAN.Font = New Font("Viner Hand ITC", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        EMPYREAN.ForeColor = SystemColors.Control
        EMPYREAN.Location = New Point(125, 9)
        EMPYREAN.Name = "EMPYREAN"
        EMPYREAN.Size = New Size(211, 78)
        EMPYREAN.TabIndex = 17
        EMPYREAN.Text = "Sign Up"
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = Color.Transparent
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(69, 23)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(59, 52)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 25
        PictureBox7.TabStop = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = SystemColors.ButtonHighlight
        Label8.Location = New Point(69, 552)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(165, 19)
        Label8.TabIndex = 27
        Label8.Text = "Already have an account?"
        ' 
        ' btn_NewAcc
        ' 
        btn_NewAcc.Font = New Font("Viner Hand ITC", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_NewAcc.Location = New Point(239, 551)
        btn_NewAcc.Name = "btn_NewAcc"
        btn_NewAcc.Size = New Size(98, 23)
        btn_NewAcc.TabIndex = 26
        btn_NewAcc.Text = "Sign In"
        btn_NewAcc.UseVisualStyleBackColor = True
        ' 
        ' NewForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(461, 606)
        Controls.Add(Label8)
        Controls.Add(btn_NewAcc)
        Controls.Add(PictureBox7)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtbox_confirmpass)
        Controls.Add(txtbox_password)
        Controls.Add(txtbox_username)
        Controls.Add(datepicker_dob)
        Controls.Add(txtbox_address)
        Controls.Add(txtbox_lastname)
        Controls.Add(txtbox_firstname)
        Controls.Add(btn_create)
        Controls.Add(EMPYREAN)
        Name = "NewForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_create As Button
    Friend WithEvents txtbox_firstname As TextBox
    Friend WithEvents txtbox_lastname As TextBox
    Friend WithEvents txtbox_address As TextBox
    Friend WithEvents datepicker_dob As DateTimePicker
    Friend WithEvents txtbox_username As TextBox
    Friend WithEvents txtbox_password As TextBox
    Friend WithEvents txtbox_confirmpass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents EMPYREAN As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_NewAcc As Button
End Class
