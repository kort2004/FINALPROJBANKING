<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserForm))
        btn_withdraw = New Button()
        btn_deposit = New Button()
        Label1 = New Label()
        btn_history = New Button()
        btn_transfer = New Button()
        Lbl_AvailBal = New Label()
        btn_logout = New Button()
        Label2 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox7 = New PictureBox()
        PictureBox8 = New PictureBox()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btn_withdraw
        ' 
        btn_withdraw.BackColor = Color.Gainsboro
        btn_withdraw.BackgroundImageLayout = ImageLayout.None
        btn_withdraw.FlatStyle = FlatStyle.Flat
        btn_withdraw.Font = New Font("Viner Hand ITC", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_withdraw.ForeColor = Color.Black
        btn_withdraw.Image = CType(resources.GetObject("btn_withdraw.Image"), Image)
        btn_withdraw.Location = New Point(44, 396)
        btn_withdraw.Name = "btn_withdraw"
        btn_withdraw.Size = New Size(83, 36)
        btn_withdraw.TabIndex = 0
        btn_withdraw.Text = "Withdraw"
        btn_withdraw.UseVisualStyleBackColor = False
        ' 
        ' btn_deposit
        ' 
        btn_deposit.BackColor = Color.Gainsboro
        btn_deposit.BackgroundImageLayout = ImageLayout.None
        btn_deposit.FlatStyle = FlatStyle.Flat
        btn_deposit.Font = New Font("Viner Hand ITC", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_deposit.ForeColor = Color.Black
        btn_deposit.Image = CType(resources.GetObject("btn_deposit.Image"), Image)
        btn_deposit.Location = New Point(185, 396)
        btn_deposit.Name = "btn_deposit"
        btn_deposit.Size = New Size(94, 36)
        btn_deposit.TabIndex = 1
        btn_deposit.Text = "Deposit"
        btn_deposit.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Gainsboro
        Label1.Font = New Font("Viner Hand ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Image = CType(resources.GetObject("Label1.Image"), Image)
        Label1.Location = New Point(152, 195)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(155, 26)
        Label1.TabIndex = 4
        Label1.Text = "Available Balance"
        ' 
        ' btn_history
        ' 
        btn_history.BackColor = SystemColors.Control
        btn_history.Font = New Font("Viner Hand ITC", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_history.ForeColor = SystemColors.ControlText
        btn_history.Location = New Point(348, 12)
        btn_history.Name = "btn_history"
        btn_history.Size = New Size(102, 28)
        btn_history.TabIndex = 7
        btn_history.Text = "History"
        btn_history.UseVisualStyleBackColor = False
        ' 
        ' btn_transfer
        ' 
        btn_transfer.BackColor = Color.Gainsboro
        btn_transfer.FlatStyle = FlatStyle.Flat
        btn_transfer.Font = New Font("Viner Hand ITC", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_transfer.ForeColor = Color.Black
        btn_transfer.Image = CType(resources.GetObject("btn_transfer.Image"), Image)
        btn_transfer.Location = New Point(333, 396)
        btn_transfer.Name = "btn_transfer"
        btn_transfer.Size = New Size(86, 36)
        btn_transfer.TabIndex = 9
        btn_transfer.Text = "Transfer"
        btn_transfer.UseVisualStyleBackColor = False
        ' 
        ' Lbl_AvailBal
        ' 
        Lbl_AvailBal.AutoSize = True
        Lbl_AvailBal.BackColor = Color.Gainsboro
        Lbl_AvailBal.Font = New Font("Viner Hand ITC", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbl_AvailBal.ForeColor = SystemColors.ActiveCaptionText
        Lbl_AvailBal.Image = CType(resources.GetObject("Lbl_AvailBal.Image"), Image)
        Lbl_AvailBal.Location = New Point(161, 143)
        Lbl_AvailBal.Margin = New Padding(2, 0, 2, 0)
        Lbl_AvailBal.Name = "Lbl_AvailBal"
        Lbl_AvailBal.RightToLeft = RightToLeft.Yes
        Lbl_AvailBal.Size = New Size(71, 78)
        Lbl_AvailBal.TabIndex = 11
        Lbl_AvailBal.Text = "10"
        Lbl_AvailBal.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btn_logout
        ' 
        btn_logout.BackColor = SystemColors.Control
        btn_logout.Font = New Font("Viner Hand ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_logout.ForeColor = SystemColors.ControlText
        btn_logout.Location = New Point(354, 545)
        btn_logout.Name = "btn_logout"
        btn_logout.Size = New Size(96, 40)
        btn_logout.TabIndex = 12
        btn_logout.Text = "Sign out"
        btn_logout.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Gainsboro
        Label2.Font = New Font("Viner Hand ITC", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Image = CType(resources.GetObject("Label2.Image"), Image)
        Label2.Location = New Point(113, 160)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 57)
        Label2.TabIndex = 13
        Label2.Tag = ""
        Label2.Text = "₱"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = SystemColors.Control
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(30, 304)
        PictureBox2.Margin = New Padding(3, 2, 3, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(112, 96)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 15
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(175, 304)
        PictureBox3.Margin = New Padding(3, 2, 3, 2)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(113, 96)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 16
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(320, 304)
        PictureBox4.Margin = New Padding(3, 2, 3, 2)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(114, 96)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 17
        PictureBox4.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Viner Hand ITC", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(56, 27)
        Label3.Name = "Label3"
        Label3.Size = New Size(176, 78)
        Label3.TabIndex = 18
        Label3.Text = "Hello!"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(18, 293)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(136, 117)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 19
        PictureBox1.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(163, 293)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(136, 117)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 20
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(309, 293)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(136, 117)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 21
        PictureBox6.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = Color.Transparent
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(11, 39)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(59, 52)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 24
        PictureBox7.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BackColor = Color.Transparent
        PictureBox8.ErrorImage = Nothing
        PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), Image)
        PictureBox8.Location = New Point(18, 97)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(438, 167)
        PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox8.TabIndex = 25
        PictureBox8.TabStop = False
        ' 
        ' UserForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(461, 606)
        Controls.Add(Label1)
        Controls.Add(Lbl_AvailBal)
        Controls.Add(Label2)
        Controls.Add(PictureBox7)
        Controls.Add(btn_transfer)
        Controls.Add(btn_withdraw)
        Controls.Add(btn_logout)
        Controls.Add(btn_history)
        Controls.Add(btn_deposit)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox8)
        Controls.Add(Label3)
        Name = "UserForm"
        ShowIcon = False
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Banking APP"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_withdraw As Button
    Friend WithEvents btn_deposit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_rewards As Button
    Friend WithEvents btn_credit As Button
    Friend WithEvents btn_history As Button
    Friend WithEvents btn_invest As Button
    Friend WithEvents btn_transfer As Button
    Friend WithEvents Lbl_AvailBal As Label
    Friend WithEvents btn_logout As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
End Class
