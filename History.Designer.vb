<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class History
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(History))
        dgv_history = New DataGridView()
        EMPYREAN = New Label()
        PictureBox1 = New PictureBox()
        PictureBox7 = New PictureBox()
        CType(dgv_history, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgv_history
        ' 
        dgv_history.BackgroundColor = SystemColors.Window
        dgv_history.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_history.GridColor = SystemColors.ControlText
        dgv_history.Location = New Point(57, 166)
        dgv_history.Name = "dgv_history"
        dgv_history.RowHeadersWidth = 62
        dgv_history.Size = New Size(565, 339)
        dgv_history.TabIndex = 0
        ' 
        ' EMPYREAN
        ' 
        EMPYREAN.AutoSize = True
        EMPYREAN.BackColor = Color.Transparent
        EMPYREAN.Font = New Font("Viner Hand ITC", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        EMPYREAN.ForeColor = SystemColors.Control
        EMPYREAN.Location = New Point(210, 9)
        EMPYREAN.Name = "EMPYREAN"
        EMPYREAN.Size = New Size(263, 103)
        EMPYREAN.TabIndex = 18
        EMPYREAN.Text = "History"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 99)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(658, 474)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 22
        PictureBox1.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = Color.Transparent
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(169, 32)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(59, 52)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 25
        PictureBox7.TabStop = False
        ' 
        ' History
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(681, 598)
        Controls.Add(PictureBox7)
        Controls.Add(dgv_history)
        Controls.Add(PictureBox1)
        Controls.Add(EMPYREAN)
        Name = "History"
        StartPosition = FormStartPosition.CenterScreen
        Text = "History"
        CType(dgv_history, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgv_history As DataGridView
    Friend WithEvents EMPYREAN As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
End Class
