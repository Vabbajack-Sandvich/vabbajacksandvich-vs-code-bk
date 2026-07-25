<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTextBoxFindPopUpModular
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
        bt2025 = New Button()
        lbFindCountText = New Label()
        lbFindListCount = New Label()
        btClearFindText = New Button()
        btFindNext = New Button()
        btFindPrevious = New Button()
        listFindIndex = New ListBox()
        txtFindText = New TextBox()
        btFindText = New Button()
        btEnd = New Button()
        btTop = New Button()
        btFindCaret = New Button()
        ckOnTop = New CheckBox()
        SuspendLayout()
        ' 
        ' bt2025
        ' 
        bt2025.BackColor = Color.Black
        bt2025.ForeColor = Color.Gray
        bt2025.Location = New Point(211, 45)
        bt2025.Name = "bt2025"
        bt2025.Size = New Size(50, 27)
        bt2025.TabIndex = 45
        bt2025.Text = "2025"
        bt2025.UseVisualStyleBackColor = False
        ' 
        ' lbFindCountText
        ' 
        lbFindCountText.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        lbFindCountText.ForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        lbFindCountText.Location = New Point(120, 163)
        lbFindCountText.Name = "lbFindCountText"
        lbFindCountText.Size = New Size(105, 27)
        lbFindCountText.TabIndex = 44
        lbFindCountText.Text = "Find Count:"
        lbFindCountText.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbFindListCount
        ' 
        lbFindListCount.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        lbFindListCount.ForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        lbFindListCount.Location = New Point(241, 163)
        lbFindListCount.Name = "lbFindListCount"
        lbFindListCount.Size = New Size(43, 27)
        lbFindListCount.TabIndex = 43
        lbFindListCount.Text = "0"
        lbFindListCount.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btClearFindText
        ' 
        btClearFindText.BackColor = Color.Black
        btClearFindText.ForeColor = Color.Gray
        btClearFindText.Location = New Point(267, 45)
        btClearFindText.Name = "btClearFindText"
        btClearFindText.Size = New Size(42, 27)
        btClearFindText.TabIndex = 42
        btClearFindText.Text = "X"
        btClearFindText.UseVisualStyleBackColor = False
        ' 
        ' btFindNext
        ' 
        btFindNext.BackColor = Color.Black
        btFindNext.ForeColor = Color.Gray
        btFindNext.Location = New Point(11, 118)
        btFindNext.Name = "btFindNext"
        btFindNext.Size = New Size(96, 31)
        btFindNext.TabIndex = 41
        btFindNext.Text = "Next"
        btFindNext.UseVisualStyleBackColor = False
        ' 
        ' btFindPrevious
        ' 
        btFindPrevious.BackColor = Color.Black
        btFindPrevious.ForeColor = Color.Gray
        btFindPrevious.Location = New Point(11, 81)
        btFindPrevious.Name = "btFindPrevious"
        btFindPrevious.Size = New Size(96, 31)
        btFindPrevious.TabIndex = 40
        btFindPrevious.Text = "Previous"
        btFindPrevious.UseVisualStyleBackColor = False
        ' 
        ' listFindIndex
        ' 
        listFindIndex.BackColor = Color.Black
        listFindIndex.ForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        listFindIndex.FormattingEnabled = True
        listFindIndex.ItemHeight = 20
        listFindIndex.Location = New Point(120, 76)
        listFindIndex.Margin = New Padding(2, 2, 2, 2)
        listFindIndex.Name = "listFindIndex"
        listFindIndex.Size = New Size(191, 84)
        listFindIndex.TabIndex = 39
        ' 
        ' txtFindText
        ' 
        txtFindText.BackColor = Color.Black
        txtFindText.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtFindText.ForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        txtFindText.Location = New Point(119, 47)
        txtFindText.Name = "txtFindText"
        txtFindText.Size = New Size(86, 30)
        txtFindText.TabIndex = 38
        ' 
        ' btFindText
        ' 
        btFindText.BackColor = Color.Black
        btFindText.ForeColor = Color.Gray
        btFindText.Location = New Point(11, 45)
        btFindText.Name = "btFindText"
        btFindText.Size = New Size(96, 31)
        btFindText.TabIndex = 37
        btFindText.Text = "Find Text"
        btFindText.UseVisualStyleBackColor = False
        ' 
        ' btEnd
        ' 
        btEnd.BackColor = Color.Black
        btEnd.ForeColor = Color.Gray
        btEnd.Location = New Point(210, 8)
        btEnd.Name = "btEnd"
        btEnd.Size = New Size(96, 31)
        btEnd.TabIndex = 48
        btEnd.Text = "End"
        btEnd.UseVisualStyleBackColor = False
        ' 
        ' btTop
        ' 
        btTop.BackColor = Color.Black
        btTop.ForeColor = Color.Gray
        btTop.Location = New Point(11, 8)
        btTop.Name = "btTop"
        btTop.Size = New Size(96, 31)
        btTop.TabIndex = 47
        btTop.Text = "Top"
        btTop.UseVisualStyleBackColor = False
        ' 
        ' btFindCaret
        ' 
        btFindCaret.BackColor = Color.Black
        btFindCaret.ForeColor = Color.Gray
        btFindCaret.Location = New Point(111, 8)
        btFindCaret.Name = "btFindCaret"
        btFindCaret.Size = New Size(96, 31)
        btFindCaret.TabIndex = 46
        btFindCaret.Text = "Find Caret"
        btFindCaret.UseVisualStyleBackColor = False
        ' 
        ' ckOnTop
        ' 
        ckOnTop.AutoSize = True
        ckOnTop.Checked = True
        ckOnTop.CheckState = CheckState.Checked
        ckOnTop.ForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        ckOnTop.Location = New Point(25, 161)
        ckOnTop.Margin = New Padding(2, 2, 2, 2)
        ckOnTop.Name = "ckOnTop"
        ckOnTop.Size = New Size(79, 24)
        ckOnTop.TabIndex = 49
        ckOnTop.Text = "On Top"
        ckOnTop.UseVisualStyleBackColor = True
        ' 
        ' frmTextBoxFindPopUpModular
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(317, 196)
        Controls.Add(ckOnTop)
        Controls.Add(btEnd)
        Controls.Add(btTop)
        Controls.Add(btFindCaret)
        Controls.Add(bt2025)
        Controls.Add(lbFindCountText)
        Controls.Add(lbFindListCount)
        Controls.Add(btClearFindText)
        Controls.Add(btFindNext)
        Controls.Add(btFindPrevious)
        Controls.Add(listFindIndex)
        Controls.Add(txtFindText)
        Controls.Add(btFindText)
        ForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(2, 2, 2, 2)
        MaximizeBox = False
        Name = "frmTextBoxFindPopUpModular"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Search Textbox"
        TopMost = True
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents bt2025 As Button
    Friend WithEvents lbFindCountText As Label
    Friend WithEvents lbFindListCount As Label
    Friend WithEvents btClearFindText As Button
    Friend WithEvents btFindNext As Button
    Friend WithEvents btFindPrevious As Button
    Friend WithEvents listFindIndex As ListBox
    Friend WithEvents txtFindText As TextBox
    Friend WithEvents btFindText As Button
    Friend WithEvents btEnd As Button
    Friend WithEvents btTop As Button
    Friend WithEvents btFindCaret As Button
    Friend WithEvents ckOnTop As CheckBox
End Class
