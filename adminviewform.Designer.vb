<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminviewform
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
        dgv_customers = New DataGridView()
        btn_delete = New Button()
        txtbox_iddelete = New TextBox()
        CType(dgv_customers, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgv_customers
        ' 
        dgv_customers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_customers.Location = New Point(222, 175)
        dgv_customers.Margin = New Padding(4, 5, 4, 5)
        dgv_customers.Name = "dgv_customers"
        dgv_customers.RowHeadersWidth = 62
        dgv_customers.Size = New Size(659, 448)
        dgv_customers.TabIndex = 0
        ' 
        ' btn_delete
        ' 
        btn_delete.Location = New Point(222, 636)
        btn_delete.Margin = New Padding(4, 5, 4, 5)
        btn_delete.Name = "btn_delete"
        btn_delete.Size = New Size(107, 38)
        btn_delete.TabIndex = 1
        btn_delete.Text = "Delete"
        btn_delete.UseVisualStyleBackColor = True
        ' 
        ' txtbox_iddelete
        ' 
        txtbox_iddelete.Location = New Point(340, 640)
        txtbox_iddelete.Margin = New Padding(4, 5, 4, 5)
        txtbox_iddelete.Name = "txtbox_iddelete"
        txtbox_iddelete.PlaceholderText = "Input Id Here"
        txtbox_iddelete.Size = New Size(541, 31)
        txtbox_iddelete.TabIndex = 2
        ' 
        ' adminviewform
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Black_Aesthetic_Motivational_Quote_Your_Story__7_
        ClientSize = New Size(1143, 750)
        Controls.Add(txtbox_iddelete)
        Controls.Add(btn_delete)
        Controls.Add(dgv_customers)
        Margin = New Padding(4, 5, 4, 5)
        Name = "adminviewform"
        Text = "adminviewform"
        CType(dgv_customers, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgv_customers As DataGridView
    Friend WithEvents btn_delete As Button
    Friend WithEvents txtbox_iddelete As TextBox
End Class
