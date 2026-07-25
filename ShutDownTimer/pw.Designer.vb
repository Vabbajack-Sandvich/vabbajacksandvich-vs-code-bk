<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pw
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
        txtCheck = New TextBox()
        SuspendLayout()
        ' 
        ' txtCheck
        ' 
        txtCheck.Location = New Point(21, 12)
        txtCheck.Name = "txtCheck"
        txtCheck.PasswordChar = "*"c
        txtCheck.Size = New Size(251, 34)
        txtCheck.TabIndex = 0
        ' 
        ' pw
        ' 
        AutoScaleDimensions = New SizeF(11F, 28F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(298, 60)
        Controls.Add(txtCheck)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "pw"
        Text = "Password"
        TopMost = True
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtCheck As TextBox
End Class
