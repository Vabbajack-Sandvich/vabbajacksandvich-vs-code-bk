<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        txtRaw = New TextBox()
        ListNonD = New ListBox()
        ListD = New ListBox()
        btCheck = New Button()
        ListRaw = New ListBox()
        lbRaw = New Label()
        lbND = New Label()
        lbD = New Label()
        ckDash = New CheckBox()
        lbUnique = New Label()
        btCopyND = New Button()
        btCopyD = New Button()
        SuspendLayout()
        ' 
        ' txtRaw
        ' 
        txtRaw.Location = New Point(14, 18)
        txtRaw.Multiline = True
        txtRaw.Name = "txtRaw"
        txtRaw.Size = New Size(763, 193)
        txtRaw.TabIndex = 0
        ' 
        ' ListNonD
        ' 
        ListNonD.FormattingEnabled = True
        ListNonD.ItemHeight = 25
        ListNonD.Location = New Point(14, 442)
        ListNonD.Name = "ListNonD"
        ListNonD.Size = New Size(374, 154)
        ListNonD.TabIndex = 1
        ' 
        ' ListD
        ' 
        ListD.FormattingEnabled = True
        ListD.ItemHeight = 25
        ListD.Location = New Point(406, 442)
        ListD.Name = "ListD"
        ListD.Size = New Size(371, 154)
        ListD.TabIndex = 2
        ' 
        ' btCheck
        ' 
        btCheck.Location = New Point(601, 217)
        btCheck.Name = "btCheck"
        btCheck.Size = New Size(176, 47)
        btCheck.TabIndex = 3
        btCheck.Text = "Check"
        btCheck.UseVisualStyleBackColor = True
        ' 
        ' ListRaw
        ' 
        ListRaw.FormattingEnabled = True
        ListRaw.ItemHeight = 25
        ListRaw.Location = New Point(12, 252)
        ListRaw.Name = "ListRaw"
        ListRaw.Size = New Size(376, 154)
        ListRaw.TabIndex = 4
        ' 
        ' lbRaw
        ' 
        lbRaw.AutoSize = True
        lbRaw.Location = New Point(12, 224)
        lbRaw.Name = "lbRaw"
        lbRaw.Size = New Size(22, 25)
        lbRaw.TabIndex = 5
        lbRaw.Text = "0"
        ' 
        ' lbND
        ' 
        lbND.AutoSize = True
        lbND.Location = New Point(12, 414)
        lbND.Name = "lbND"
        lbND.Size = New Size(22, 25)
        lbND.TabIndex = 6
        lbND.Text = "0"
        ' 
        ' lbD
        ' 
        lbD.AutoSize = True
        lbD.Location = New Point(406, 414)
        lbD.Name = "lbD"
        lbD.Size = New Size(22, 25)
        lbD.TabIndex = 7
        lbD.Text = "0"
        ' 
        ' ckDash
        ' 
        ckDash.AutoSize = True
        ckDash.Location = New Point(601, 270)
        ckDash.Name = "ckDash"
        ckDash.Size = New Size(126, 29)
        ckDash.TabIndex = 8
        ckDash.Text = "Dash Check"
        ckDash.UseVisualStyleBackColor = True
        ' 
        ' lbUnique
        ' 
        lbUnique.AutoSize = True
        lbUnique.Location = New Point(469, 336)
        lbUnique.Name = "lbUnique"
        lbUnique.Size = New Size(129, 25)
        lbUnique.TabIndex = 9
        lbUnique.Text = "Unique Entires:"
        ' 
        ' btCopyND
        ' 
        btCopyND.Location = New Point(311, 602)
        btCopyND.Name = "btCopyND"
        btCopyND.Size = New Size(77, 31)
        btCopyND.TabIndex = 10
        btCopyND.Text = "Copy"
        btCopyND.UseVisualStyleBackColor = True
        ' 
        ' btCopyD
        ' 
        btCopyD.Location = New Point(700, 604)
        btCopyD.Name = "btCopyD"
        btCopyD.Size = New Size(77, 31)
        btCopyD.TabIndex = 11
        btCopyD.Text = "Copy"
        btCopyD.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(793, 647)
        Controls.Add(btCopyD)
        Controls.Add(btCopyND)
        Controls.Add(lbUnique)
        Controls.Add(ckDash)
        Controls.Add(lbD)
        Controls.Add(lbND)
        Controls.Add(lbRaw)
        Controls.Add(ListRaw)
        Controls.Add(btCheck)
        Controls.Add(ListD)
        Controls.Add(ListNonD)
        Controls.Add(txtRaw)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form1"
        Text = "Duplicate Check"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtRaw As TextBox
    Friend WithEvents ListNonD As ListBox
    Friend WithEvents ListD As ListBox
    Friend WithEvents btCheck As Button
    Friend WithEvents ListRaw As ListBox
    Friend WithEvents lbRaw As Label
    Friend WithEvents lbND As Label
    Friend WithEvents lbD As Label
    Friend WithEvents ckDash As CheckBox
    Friend WithEvents lbUnique As Label
    Friend WithEvents btCopyND As Button
    Friend WithEvents btCopyD As Button
End Class
