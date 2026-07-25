<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmzFilter
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        txtInput = New TextBox()
        btzAlphaNumFilter = New Button()
        btzAlphaNumFilterWithDashPlus = New Button()
        ckOnTop = New CheckBox()
        ckAutoCopy = New CheckBox()
        txtOutput = New TextBox()
        ckAutoTrim = New CheckBox()
        txtTrim = New TextBox()
        lbtxtInput = New Label()
        lbtxtTrim = New Label()
        lbtxtOutput = New Label()
        txtReplace = New TextBox()
        lbtxtReplace = New Label()
        lbtxtReplaceWith = New Label()
        txtReplaceWith = New TextBox()
        ckAutoReplace = New CheckBox()
        btTrim = New Button()
        btReplace = New Button()
        ckAutoRemoveDoubleSpace = New CheckBox()
        btRemoveDoubleSpace = New Button()
        lbCheckBoxExplanation = New Label()
        btOutputToInput = New Button()
        btRecursivelyRemoveDoubleSpace = New Button()
        btzAlphaNumFilterWithDashPlusSpace = New Button()
        btzAlphaNumFilterWithDot = New Button()
        btzNumFilter = New Button()
        btzNumFilterWithDot = New Button()
        btClearInput = New Button()
        txtTemp = New TextBox()
        lbtxtTemp = New Label()
        SuspendLayout()
        ' 
        ' txtInput
        ' 
        txtInput.BackColor = Color.Black
        txtInput.ForeColor = Color.LimeGreen
        txtInput.Location = New Point(83, 12)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(476, 27)
        txtInput.TabIndex = 0
        ' 
        ' btzAlphaNumFilter
        ' 
        btzAlphaNumFilter.BackColor = Color.Black
        btzAlphaNumFilter.ForeColor = Color.LimeGreen
        btzAlphaNumFilter.Location = New Point(5, 222)
        btzAlphaNumFilter.Name = "btzAlphaNumFilter"
        btzAlphaNumFilter.Size = New Size(135, 29)
        btzAlphaNumFilter.TabIndex = 1
        btzAlphaNumFilter.Text = "zAlphaNumFilter"
        btzAlphaNumFilter.UseVisualStyleBackColor = False
        ' 
        ' btzAlphaNumFilterWithDashPlus
        ' 
        btzAlphaNumFilterWithDashPlus.BackColor = Color.Black
        btzAlphaNumFilterWithDashPlus.ForeColor = Color.LimeGreen
        btzAlphaNumFilterWithDashPlus.Location = New Point(146, 222)
        btzAlphaNumFilterWithDashPlus.Name = "btzAlphaNumFilterWithDashPlus"
        btzAlphaNumFilterWithDashPlus.Size = New Size(239, 29)
        btzAlphaNumFilterWithDashPlus.TabIndex = 2
        btzAlphaNumFilterWithDashPlus.Text = "zAlphaNumFilterWithDashPlus"
        btzAlphaNumFilterWithDashPlus.UseVisualStyleBackColor = False
        ' 
        ' ckOnTop
        ' 
        ckOnTop.AutoSize = True
        ckOnTop.BackColor = Color.Black
        ckOnTop.Checked = True
        ckOnTop.CheckState = CheckState.Checked
        ckOnTop.ForeColor = Color.LimeGreen
        ckOnTop.Location = New Point(617, 14)
        ckOnTop.Name = "ckOnTop"
        ckOnTop.Size = New Size(79, 24)
        ckOnTop.TabIndex = 3
        ckOnTop.Text = "On Top"
        ckOnTop.UseVisualStyleBackColor = False
        ' 
        ' ckAutoCopy
        ' 
        ckAutoCopy.AutoSize = True
        ckAutoCopy.BackColor = Color.Black
        ckAutoCopy.Checked = True
        ckAutoCopy.CheckState = CheckState.Checked
        ckAutoCopy.ForeColor = Color.LimeGreen
        ckAutoCopy.Location = New Point(617, 108)
        ckAutoCopy.Name = "ckAutoCopy"
        ckAutoCopy.Size = New Size(101, 24)
        ckAutoCopy.TabIndex = 4
        ckAutoCopy.Text = "Auto Copy"
        ckAutoCopy.UseVisualStyleBackColor = False
        ' 
        ' txtOutput
        ' 
        txtOutput.BackColor = Color.Black
        txtOutput.ForeColor = Color.LimeGreen
        txtOutput.Location = New Point(83, 145)
        txtOutput.Name = "txtOutput"
        txtOutput.Size = New Size(476, 27)
        txtOutput.TabIndex = 5
        ' 
        ' ckAutoTrim
        ' 
        ckAutoTrim.AutoSize = True
        ckAutoTrim.BackColor = Color.Black
        ckAutoTrim.Checked = True
        ckAutoTrim.CheckState = CheckState.Checked
        ckAutoTrim.ForeColor = Color.LimeGreen
        ckAutoTrim.Location = New Point(617, 138)
        ckAutoTrim.Name = "ckAutoTrim"
        ckAutoTrim.Size = New Size(96, 24)
        ckAutoTrim.TabIndex = 6
        ckAutoTrim.Text = "Auto Trim"
        ckAutoTrim.UseVisualStyleBackColor = False
        ' 
        ' txtTrim
        ' 
        txtTrim.BackColor = Color.Black
        txtTrim.ForeColor = Color.LimeGreen
        txtTrim.Location = New Point(83, 79)
        txtTrim.Name = "txtTrim"
        txtTrim.Size = New Size(476, 27)
        txtTrim.TabIndex = 7
        txtTrim.Text = " English Dubbed"
        ' 
        ' lbtxtInput
        ' 
        lbtxtInput.AutoSize = True
        lbtxtInput.BackColor = Color.Black
        lbtxtInput.ForeColor = Color.LimeGreen
        lbtxtInput.Location = New Point(12, 19)
        lbtxtInput.Name = "lbtxtInput"
        lbtxtInput.Size = New Size(43, 20)
        lbtxtInput.TabIndex = 8
        lbtxtInput.Text = "Input"
        ' 
        ' lbtxtTrim
        ' 
        lbtxtTrim.AutoSize = True
        lbtxtTrim.BackColor = Color.Black
        lbtxtTrim.ForeColor = Color.LimeGreen
        lbtxtTrim.Location = New Point(12, 86)
        lbtxtTrim.Name = "lbtxtTrim"
        lbtxtTrim.Size = New Size(38, 20)
        lbtxtTrim.TabIndex = 9
        lbtxtTrim.Text = "Trim"
        ' 
        ' lbtxtOutput
        ' 
        lbtxtOutput.AutoSize = True
        lbtxtOutput.BackColor = Color.Black
        lbtxtOutput.ForeColor = Color.LimeGreen
        lbtxtOutput.Location = New Point(12, 152)
        lbtxtOutput.Name = "lbtxtOutput"
        lbtxtOutput.Size = New Size(55, 20)
        lbtxtOutput.TabIndex = 10
        lbtxtOutput.Text = "Output"
        ' 
        ' txtReplace
        ' 
        txtReplace.BackColor = Color.Black
        txtReplace.ForeColor = Color.LimeGreen
        txtReplace.Location = New Point(83, 112)
        txtReplace.Name = "txtReplace"
        txtReplace.Size = New Size(180, 27)
        txtReplace.TabIndex = 11
        ' 
        ' lbtxtReplace
        ' 
        lbtxtReplace.AutoSize = True
        lbtxtReplace.BackColor = Color.Black
        lbtxtReplace.ForeColor = Color.LimeGreen
        lbtxtReplace.Location = New Point(12, 119)
        lbtxtReplace.Name = "lbtxtReplace"
        lbtxtReplace.Size = New Size(62, 20)
        lbtxtReplace.TabIndex = 13
        lbtxtReplace.Text = "Replace"
        ' 
        ' lbtxtReplaceWith
        ' 
        lbtxtReplaceWith.AutoSize = True
        lbtxtReplaceWith.BackColor = Color.Black
        lbtxtReplaceWith.ForeColor = Color.LimeGreen
        lbtxtReplaceWith.Location = New Point(269, 119)
        lbtxtReplaceWith.Name = "lbtxtReplaceWith"
        lbtxtReplaceWith.Size = New Size(97, 20)
        lbtxtReplaceWith.TabIndex = 14
        lbtxtReplaceWith.Text = "Replace With"
        ' 
        ' txtReplaceWith
        ' 
        txtReplaceWith.BackColor = Color.Black
        txtReplaceWith.ForeColor = Color.LimeGreen
        txtReplaceWith.Location = New Point(384, 112)
        txtReplaceWith.Name = "txtReplaceWith"
        txtReplaceWith.Size = New Size(175, 27)
        txtReplaceWith.TabIndex = 15
        ' 
        ' ckAutoReplace
        ' 
        ckAutoReplace.AutoSize = True
        ckAutoReplace.BackColor = Color.Black
        ckAutoReplace.Checked = True
        ckAutoReplace.CheckState = CheckState.Checked
        ckAutoReplace.ForeColor = Color.LimeGreen
        ckAutoReplace.Location = New Point(617, 168)
        ckAutoReplace.Name = "ckAutoReplace"
        ckAutoReplace.Size = New Size(120, 24)
        ckAutoReplace.TabIndex = 16
        ckAutoReplace.Text = "Auto Replace"
        ckAutoReplace.UseVisualStyleBackColor = False
        ' 
        ' btTrim
        ' 
        btTrim.BackColor = Color.Black
        btTrim.ForeColor = Color.LimeGreen
        btTrim.Location = New Point(5, 187)
        btTrim.Name = "btTrim"
        btTrim.Size = New Size(62, 29)
        btTrim.TabIndex = 17
        btTrim.Text = "Trim"
        btTrim.UseVisualStyleBackColor = False
        ' 
        ' btReplace
        ' 
        btReplace.BackColor = Color.Black
        btReplace.ForeColor = Color.LimeGreen
        btReplace.Location = New Point(73, 187)
        btReplace.Name = "btReplace"
        btReplace.Size = New Size(90, 29)
        btReplace.TabIndex = 18
        btReplace.Text = "Replace"
        btReplace.UseVisualStyleBackColor = False
        ' 
        ' ckAutoRemoveDoubleSpace
        ' 
        ckAutoRemoveDoubleSpace.BackColor = Color.Black
        ckAutoRemoveDoubleSpace.Checked = True
        ckAutoRemoveDoubleSpace.CheckState = CheckState.Checked
        ckAutoRemoveDoubleSpace.ForeColor = Color.LimeGreen
        ckAutoRemoveDoubleSpace.Location = New Point(617, 191)
        ckAutoRemoveDoubleSpace.Name = "ckAutoRemoveDoubleSpace"
        ckAutoRemoveDoubleSpace.Size = New Size(124, 95)
        ckAutoRemoveDoubleSpace.TabIndex = 19
        ckAutoRemoveDoubleSpace.Text = "Auto Recursively Remove Double Space"
        ckAutoRemoveDoubleSpace.UseVisualStyleBackColor = False
        ' 
        ' btRemoveDoubleSpace
        ' 
        btRemoveDoubleSpace.BackColor = Color.Black
        btRemoveDoubleSpace.ForeColor = Color.LimeGreen
        btRemoveDoubleSpace.Location = New Point(168, 187)
        btRemoveDoubleSpace.Name = "btRemoveDoubleSpace"
        btRemoveDoubleSpace.Size = New Size(176, 29)
        btRemoveDoubleSpace.TabIndex = 20
        btRemoveDoubleSpace.Text = "Remove Double Space"
        btRemoveDoubleSpace.UseVisualStyleBackColor = False
        ' 
        ' lbCheckBoxExplanation
        ' 
        lbCheckBoxExplanation.BackColor = Color.Black
        lbCheckBoxExplanation.ForeColor = Color.LimeGreen
        lbCheckBoxExplanation.Location = New Point(617, 44)
        lbCheckBoxExplanation.Name = "lbCheckBoxExplanation"
        lbCheckBoxExplanation.Size = New Size(120, 61)
        lbCheckBoxExplanation.TabIndex = 21
        lbCheckBoxExplanation.Text = "Checkboxes Only Work With z Buttons"
        ' 
        ' btOutputToInput
        ' 
        btOutputToInput.BackColor = Color.Black
        btOutputToInput.ForeColor = Color.LimeGreen
        btOutputToInput.Location = New Point(565, 145)
        btOutputToInput.Name = "btOutputToInput"
        btOutputToInput.Size = New Size(40, 29)
        btOutputToInput.TabIndex = 22
        btOutputToInput.Text = "^"
        btOutputToInput.UseVisualStyleBackColor = False
        ' 
        ' btRecursivelyRemoveDoubleSpace
        ' 
        btRecursivelyRemoveDoubleSpace.BackColor = Color.Black
        btRecursivelyRemoveDoubleSpace.ForeColor = Color.LimeGreen
        btRecursivelyRemoveDoubleSpace.Location = New Point(350, 187)
        btRecursivelyRemoveDoubleSpace.Name = "btRecursivelyRemoveDoubleSpace"
        btRecursivelyRemoveDoubleSpace.Size = New Size(249, 29)
        btRecursivelyRemoveDoubleSpace.TabIndex = 23
        btRecursivelyRemoveDoubleSpace.Text = "Recursively Remove Double Space"
        btRecursivelyRemoveDoubleSpace.UseVisualStyleBackColor = False
        ' 
        ' btzAlphaNumFilterWithDashPlusSpace
        ' 
        btzAlphaNumFilterWithDashPlusSpace.BackColor = Color.Black
        btzAlphaNumFilterWithDashPlusSpace.ForeColor = Color.LimeGreen
        btzAlphaNumFilterWithDashPlusSpace.Location = New Point(5, 257)
        btzAlphaNumFilterWithDashPlusSpace.Name = "btzAlphaNumFilterWithDashPlusSpace"
        btzAlphaNumFilterWithDashPlusSpace.Size = New Size(272, 29)
        btzAlphaNumFilterWithDashPlusSpace.TabIndex = 24
        btzAlphaNumFilterWithDashPlusSpace.Text = "zAlphaNumFilterWithDashPlusSpace"
        btzAlphaNumFilterWithDashPlusSpace.UseVisualStyleBackColor = False
        ' 
        ' btzAlphaNumFilterWithDot
        ' 
        btzAlphaNumFilterWithDot.BackColor = Color.Black
        btzAlphaNumFilterWithDot.ForeColor = Color.LimeGreen
        btzAlphaNumFilterWithDot.Location = New Point(391, 222)
        btzAlphaNumFilterWithDot.Name = "btzAlphaNumFilterWithDot"
        btzAlphaNumFilterWithDot.Size = New Size(208, 29)
        btzAlphaNumFilterWithDot.TabIndex = 25
        btzAlphaNumFilterWithDot.Text = "zAlphaNumFilterWithDot"
        btzAlphaNumFilterWithDot.UseVisualStyleBackColor = False
        ' 
        ' btzNumFilter
        ' 
        btzNumFilter.BackColor = Color.Black
        btzNumFilter.ForeColor = Color.LimeGreen
        btzNumFilter.Location = New Point(283, 257)
        btzNumFilter.Name = "btzNumFilter"
        btzNumFilter.Size = New Size(102, 29)
        btzNumFilter.TabIndex = 26
        btzNumFilter.Text = "zNumFilter"
        btzNumFilter.UseVisualStyleBackColor = False
        ' 
        ' btzNumFilterWithDot
        ' 
        btzNumFilterWithDot.BackColor = Color.Black
        btzNumFilterWithDot.ForeColor = Color.LimeGreen
        btzNumFilterWithDot.Location = New Point(391, 257)
        btzNumFilterWithDot.Name = "btzNumFilterWithDot"
        btzNumFilterWithDot.Size = New Size(208, 29)
        btzNumFilterWithDot.TabIndex = 27
        btzNumFilterWithDot.Text = "zNumFilterWithDot"
        btzNumFilterWithDot.UseVisualStyleBackColor = False
        ' 
        ' btClearInput
        ' 
        btClearInput.BackColor = Color.Black
        btClearInput.ForeColor = Color.LimeGreen
        btClearInput.Location = New Point(565, 12)
        btClearInput.Name = "btClearInput"
        btClearInput.Size = New Size(40, 29)
        btClearInput.TabIndex = 28
        btClearInput.Text = "X"
        btClearInput.UseVisualStyleBackColor = False
        ' 
        ' txtTemp
        ' 
        txtTemp.BackColor = Color.Black
        txtTemp.ForeColor = Color.LimeGreen
        txtTemp.Location = New Point(83, 45)
        txtTemp.Name = "txtTemp"
        txtTemp.Size = New Size(476, 27)
        txtTemp.TabIndex = 29
        ' 
        ' lbtxtTemp
        ' 
        lbtxtTemp.AutoSize = True
        lbtxtTemp.BackColor = Color.Black
        lbtxtTemp.ForeColor = Color.LimeGreen
        lbtxtTemp.Location = New Point(12, 52)
        lbtxtTemp.Name = "lbtxtTemp"
        lbtxtTemp.Size = New Size(46, 20)
        lbtxtTemp.TabIndex = 30
        lbtxtTemp.Text = "Temp"
        ' 
        ' frmzFilter
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(748, 296)
        Controls.Add(lbtxtTemp)
        Controls.Add(txtTemp)
        Controls.Add(btClearInput)
        Controls.Add(btzNumFilterWithDot)
        Controls.Add(btzNumFilter)
        Controls.Add(btzAlphaNumFilterWithDot)
        Controls.Add(btzAlphaNumFilterWithDashPlusSpace)
        Controls.Add(btRecursivelyRemoveDoubleSpace)
        Controls.Add(btOutputToInput)
        Controls.Add(lbCheckBoxExplanation)
        Controls.Add(btRemoveDoubleSpace)
        Controls.Add(ckAutoRemoveDoubleSpace)
        Controls.Add(btReplace)
        Controls.Add(btTrim)
        Controls.Add(ckAutoReplace)
        Controls.Add(txtReplaceWith)
        Controls.Add(lbtxtReplaceWith)
        Controls.Add(lbtxtReplace)
        Controls.Add(txtReplace)
        Controls.Add(lbtxtOutput)
        Controls.Add(lbtxtTrim)
        Controls.Add(lbtxtInput)
        Controls.Add(txtTrim)
        Controls.Add(ckAutoTrim)
        Controls.Add(txtOutput)
        Controls.Add(ckAutoCopy)
        Controls.Add(ckOnTop)
        Controls.Add(btzAlphaNumFilterWithDashPlus)
        Controls.Add(btzAlphaNumFilter)
        Controls.Add(txtInput)
        ForeColor = Color.LimeGreen
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "frmzFilter"
        StartPosition = FormStartPosition.CenterScreen
        Text = "zFilter"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtInput As TextBox
    Friend WithEvents btzAlphaNumFilter As Button
    Friend WithEvents btzAlphaNumFilterWithDashPlus As Button
    Friend WithEvents ckOnTop As CheckBox
    Friend WithEvents ckAutoCopy As CheckBox
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents ckAutoTrim As CheckBox
    Friend WithEvents txtTrim As TextBox
    Friend WithEvents lbtxtInput As Label
    Friend WithEvents lbtxtTrim As Label
    Friend WithEvents lbtxtOutput As Label
    Friend WithEvents txtReplace As TextBox
    Friend WithEvents lbtxtReplace As Label
    Friend WithEvents lbtxtReplaceWith As Label
    Friend WithEvents txtReplaceWith As TextBox
    Friend WithEvents ckAutoReplace As CheckBox
    Friend WithEvents btTrim As Button
    Friend WithEvents btReplace As Button
    Friend WithEvents ckAutoRemoveDoubleSpace As CheckBox
    Friend WithEvents btRemoveDoubleSpace As Button
    Friend WithEvents lbCheckBoxExplanation As Label
    Friend WithEvents btOutputToInput As Button
    Friend WithEvents btRecursivelyRemoveDoubleSpace As Button
    Friend WithEvents btzAlphaNumFilterWithDashPlusSpace As Button
    Friend WithEvents btzAlphaNumFilterWithDot As Button
    Friend WithEvents btzNumFilter As Button
    Friend WithEvents btzNumFilterWithDot As Button
    Friend WithEvents btClearInput As Button
    Friend WithEvents txtTemp As TextBox
    Friend WithEvents lbtxtTemp As Label

End Class
