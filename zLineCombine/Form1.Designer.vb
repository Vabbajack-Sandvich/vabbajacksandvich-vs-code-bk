<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        listInput1 = New ListBox()
        listInput2 = New ListBox()
        listOutput1 = New ListBox()
        btCombineEveryOtherLine = New Button()
        txtInputText1 = New TextBox()
        lbInputText1 = New Label()
        lbInputText2 = New Label()
        txtInputText2 = New TextBox()
        lbInputList1 = New Label()
        lbInputList2 = New Label()
        lbOutputList1 = New Label()
        lbOutputText1 = New Label()
        txtOutputText1 = New TextBox()
        btClearInputText1 = New Button()
        btClearInputText2 = New Button()
        btClearOutputText1 = New Button()
        btCombineLeftThenRight = New Button()
        btCopyOutputText1 = New Button()
        btTestMoreLeft = New Button()
        btTestMoreRight = New Button()
        btTestEqual = New Button()
        lbInputList1Count = New Label()
        lbInputList2Count = New Label()
        lbOutputList1Count = New Label()
        btClearAll = New Button()
        ckOnTop = New CheckBox()
        btGetLineCount = New Button()
        SuspendLayout()
        ' 
        ' listInput1
        ' 
        listInput1.BackColor = Color.Black
        listInput1.ForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        listInput1.FormattingEnabled = True
        listInput1.Location = New Point(11, 187)
        listInput1.Margin = New Padding(2)
        listInput1.Name = "listInput1"
        listInput1.Size = New Size(268, 104)
        listInput1.TabIndex = 0
        listInput1.TabStop = False
        ' 
        ' listInput2
        ' 
        listInput2.BackColor = Color.Black
        listInput2.ForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        listInput2.FormattingEnabled = True
        listInput2.Location = New Point(285, 187)
        listInput2.Margin = New Padding(2)
        listInput2.Name = "listInput2"
        listInput2.Size = New Size(282, 104)
        listInput2.TabIndex = 1
        listInput2.TabStop = False
        ' 
        ' listOutput1
        ' 
        listOutput1.BackColor = Color.Black
        listOutput1.ForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        listOutput1.FormattingEnabled = True
        listOutput1.Location = New Point(583, 548)
        listOutput1.Margin = New Padding(2)
        listOutput1.Name = "listOutput1"
        listOutput1.Size = New Size(242, 104)
        listOutput1.TabIndex = 2
        listOutput1.TabStop = False
        ' 
        ' btCombineEveryOtherLine
        ' 
        btCombineEveryOtherLine.BackColor = Color.Black
        btCombineEveryOtherLine.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btCombineEveryOtherLine.Location = New Point(583, 270)
        btCombineEveryOtherLine.Margin = New Padding(2)
        btCombineEveryOtherLine.Name = "btCombineEveryOtherLine"
        btCombineEveryOtherLine.Size = New Size(242, 81)
        btCombineEveryOtherLine.TabIndex = 4
        btCombineEveryOtherLine.Text = "Left To Right Merge Combine Every Other Line With Lazy Merge Logic Assumes Similar File Size And Structure"
        btCombineEveryOtherLine.UseVisualStyleBackColor = False
        ' 
        ' txtInputText1
        ' 
        txtInputText1.BackColor = Color.Black
        txtInputText1.ForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        txtInputText1.Location = New Point(8, 28)
        txtInputText1.Margin = New Padding(2)
        txtInputText1.Multiline = True
        txtInputText1.Name = "txtInputText1"
        txtInputText1.Size = New Size(272, 96)
        txtInputText1.TabIndex = 4
        ' 
        ' lbInputText1
        ' 
        lbInputText1.AutoSize = True
        lbInputText1.Location = New Point(8, 6)
        lbInputText1.Margin = New Padding(2, 0, 2, 0)
        lbInputText1.Name = "lbInputText1"
        lbInputText1.Size = New Size(86, 20)
        lbInputText1.TabIndex = 5
        lbInputText1.Text = "Input Text 1"
        ' 
        ' lbInputText2
        ' 
        lbInputText2.AutoSize = True
        lbInputText2.Location = New Point(285, 6)
        lbInputText2.Margin = New Padding(2, 0, 2, 0)
        lbInputText2.Name = "lbInputText2"
        lbInputText2.Size = New Size(86, 20)
        lbInputText2.TabIndex = 7
        lbInputText2.Text = "Input Text 2"
        ' 
        ' txtInputText2
        ' 
        txtInputText2.BackColor = Color.Black
        txtInputText2.ForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        txtInputText2.Location = New Point(285, 28)
        txtInputText2.Margin = New Padding(2)
        txtInputText2.Multiline = True
        txtInputText2.Name = "txtInputText2"
        txtInputText2.Size = New Size(283, 96)
        txtInputText2.TabIndex = 6
        ' 
        ' lbInputList1
        ' 
        lbInputList1.AutoSize = True
        lbInputList1.Location = New Point(11, 165)
        lbInputList1.Margin = New Padding(2, 0, 2, 0)
        lbInputList1.Name = "lbInputList1"
        lbInputList1.Size = New Size(81, 20)
        lbInputList1.TabIndex = 8
        lbInputList1.Text = "Input List 1"
        ' 
        ' lbInputList2
        ' 
        lbInputList2.AutoSize = True
        lbInputList2.Location = New Point(285, 165)
        lbInputList2.Margin = New Padding(2, 0, 2, 0)
        lbInputList2.Name = "lbInputList2"
        lbInputList2.Size = New Size(81, 20)
        lbInputList2.TabIndex = 9
        lbInputList2.Text = "Input List 2"
        ' 
        ' lbOutputList1
        ' 
        lbOutputList1.AutoSize = True
        lbOutputList1.Location = New Point(583, 526)
        lbOutputList1.Margin = New Padding(2, 0, 2, 0)
        lbOutputList1.Name = "lbOutputList1"
        lbOutputList1.Size = New Size(93, 20)
        lbOutputList1.TabIndex = 10
        lbOutputList1.Text = "Output List 1"
        ' 
        ' lbOutputText1
        ' 
        lbOutputText1.AutoSize = True
        lbOutputText1.Location = New Point(8, 306)
        lbOutputText1.Margin = New Padding(2, 0, 2, 0)
        lbOutputText1.Name = "lbOutputText1"
        lbOutputText1.Size = New Size(98, 20)
        lbOutputText1.TabIndex = 12
        lbOutputText1.Text = "Output Text 1"
        ' 
        ' txtOutputText1
        ' 
        txtOutputText1.BackColor = Color.Black
        txtOutputText1.ForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        txtOutputText1.Location = New Point(7, 328)
        txtOutputText1.Margin = New Padding(2)
        txtOutputText1.Multiline = True
        txtOutputText1.Name = "txtOutputText1"
        txtOutputText1.ScrollBars = ScrollBars.Vertical
        txtOutputText1.Size = New Size(560, 324)
        txtOutputText1.TabIndex = 11
        ' 
        ' btClearInputText1
        ' 
        btClearInputText1.BackColor = Color.Black
        btClearInputText1.Location = New Point(243, 127)
        btClearInputText1.Margin = New Padding(2)
        btClearInputText1.Name = "btClearInputText1"
        btClearInputText1.Size = New Size(36, 28)
        btClearInputText1.TabIndex = 5
        btClearInputText1.Text = "X"
        btClearInputText1.UseVisualStyleBackColor = False
        ' 
        ' btClearInputText2
        ' 
        btClearInputText2.BackColor = Color.Black
        btClearInputText2.Location = New Point(531, 127)
        btClearInputText2.Margin = New Padding(2)
        btClearInputText2.Name = "btClearInputText2"
        btClearInputText2.Size = New Size(36, 28)
        btClearInputText2.TabIndex = 6
        btClearInputText2.Text = "X"
        btClearInputText2.UseVisualStyleBackColor = False
        ' 
        ' btClearOutputText1
        ' 
        btClearOutputText1.BackColor = Color.Black
        btClearOutputText1.Location = New Point(530, 656)
        btClearOutputText1.Margin = New Padding(2)
        btClearOutputText1.Name = "btClearOutputText1"
        btClearOutputText1.Size = New Size(36, 28)
        btClearOutputText1.TabIndex = 7
        btClearOutputText1.Text = "X"
        btClearOutputText1.UseVisualStyleBackColor = False
        ' 
        ' btCombineLeftThenRight
        ' 
        btCombineLeftThenRight.AutoSize = True
        btCombineLeftThenRight.BackColor = Color.Black
        btCombineLeftThenRight.Location = New Point(583, 233)
        btCombineLeftThenRight.Margin = New Padding(2)
        btCombineLeftThenRight.Name = "btCombineLeftThenRight"
        btCombineLeftThenRight.Size = New Size(242, 33)
        btCombineLeftThenRight.TabIndex = 13
        btCombineLeftThenRight.Text = "Combine Left Then Right"
        btCombineLeftThenRight.UseVisualStyleBackColor = False
        ' 
        ' btCopyOutputText1
        ' 
        btCopyOutputText1.BackColor = Color.Black
        btCopyOutputText1.Location = New Point(459, 656)
        btCopyOutputText1.Margin = New Padding(2)
        btCopyOutputText1.Name = "btCopyOutputText1"
        btCopyOutputText1.Size = New Size(63, 28)
        btCopyOutputText1.TabIndex = 14
        btCopyOutputText1.Text = "Copy"
        btCopyOutputText1.UseVisualStyleBackColor = False
        ' 
        ' btTestMoreLeft
        ' 
        btTestMoreLeft.AutoSize = True
        btTestMoreLeft.BackColor = Color.Black
        btTestMoreLeft.Location = New Point(583, 85)
        btTestMoreLeft.Margin = New Padding(2)
        btTestMoreLeft.Name = "btTestMoreLeft"
        btTestMoreLeft.Size = New Size(242, 33)
        btTestMoreLeft.TabIndex = 15
        btTestMoreLeft.Text = "Test Data More Left"
        btTestMoreLeft.UseVisualStyleBackColor = False
        ' 
        ' btTestMoreRight
        ' 
        btTestMoreRight.AutoSize = True
        btTestMoreRight.BackColor = Color.Black
        btTestMoreRight.Location = New Point(583, 122)
        btTestMoreRight.Margin = New Padding(2)
        btTestMoreRight.Name = "btTestMoreRight"
        btTestMoreRight.Size = New Size(242, 33)
        btTestMoreRight.TabIndex = 16
        btTestMoreRight.Text = "Test Data More Right"
        btTestMoreRight.UseVisualStyleBackColor = False
        ' 
        ' btTestEqual
        ' 
        btTestEqual.AutoSize = True
        btTestEqual.BackColor = Color.Black
        btTestEqual.Location = New Point(583, 159)
        btTestEqual.Margin = New Padding(2)
        btTestEqual.Name = "btTestEqual"
        btTestEqual.Size = New Size(242, 33)
        btTestEqual.TabIndex = 17
        btTestEqual.Text = "Test Data Equal"
        btTestEqual.UseVisualStyleBackColor = False
        ' 
        ' lbInputList1Count
        ' 
        lbInputList1Count.AutoSize = True
        lbInputList1Count.Location = New Point(121, 165)
        lbInputList1Count.Name = "lbInputList1Count"
        lbInputList1Count.Size = New Size(53, 20)
        lbInputList1Count.TabIndex = 18
        lbInputList1Count.Text = "Label1"
        ' 
        ' lbInputList2Count
        ' 
        lbInputList2Count.AutoSize = True
        lbInputList2Count.Location = New Point(395, 165)
        lbInputList2Count.Name = "lbInputList2Count"
        lbInputList2Count.Size = New Size(53, 20)
        lbInputList2Count.TabIndex = 19
        lbInputList2Count.Text = "Label2"
        ' 
        ' lbOutputList1Count
        ' 
        lbOutputList1Count.AutoSize = True
        lbOutputList1Count.Location = New Point(693, 526)
        lbOutputList1Count.Name = "lbOutputList1Count"
        lbOutputList1Count.Size = New Size(53, 20)
        lbOutputList1Count.TabIndex = 20
        lbOutputList1Count.Text = "Label3"
        ' 
        ' btClearAll
        ' 
        btClearAll.AutoSize = True
        btClearAll.BackColor = Color.Black
        btClearAll.Location = New Point(583, 196)
        btClearAll.Margin = New Padding(2)
        btClearAll.Name = "btClearAll"
        btClearAll.Size = New Size(242, 33)
        btClearAll.TabIndex = 21
        btClearAll.Text = "Clear All"
        btClearAll.UseVisualStyleBackColor = False
        ' 
        ' ckOnTop
        ' 
        ckOnTop.AutoSize = True
        ckOnTop.Checked = True
        ckOnTop.CheckState = CheckState.Checked
        ckOnTop.Location = New Point(746, 12)
        ckOnTop.Name = "ckOnTop"
        ckOnTop.Size = New Size(79, 24)
        ckOnTop.TabIndex = 22
        ckOnTop.Text = "On Top"
        ckOnTop.UseVisualStyleBackColor = True
        ' 
        ' btGetLineCount
        ' 
        btGetLineCount.AutoSize = True
        btGetLineCount.BackColor = Color.Black
        btGetLineCount.Location = New Point(583, 48)
        btGetLineCount.Margin = New Padding(2)
        btGetLineCount.Name = "btGetLineCount"
        btGetLineCount.Size = New Size(242, 33)
        btGetLineCount.TabIndex = 23
        btGetLineCount.Text = "Get Line Count"
        btGetLineCount.UseVisualStyleBackColor = False
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(841, 699)
        Controls.Add(btGetLineCount)
        Controls.Add(ckOnTop)
        Controls.Add(btClearAll)
        Controls.Add(lbOutputList1Count)
        Controls.Add(lbInputList2Count)
        Controls.Add(lbInputList1Count)
        Controls.Add(btTestEqual)
        Controls.Add(btTestMoreRight)
        Controls.Add(btTestMoreLeft)
        Controls.Add(btCopyOutputText1)
        Controls.Add(btCombineLeftThenRight)
        Controls.Add(btClearOutputText1)
        Controls.Add(btClearInputText2)
        Controls.Add(btClearInputText1)
        Controls.Add(lbOutputText1)
        Controls.Add(txtOutputText1)
        Controls.Add(lbOutputList1)
        Controls.Add(lbInputList2)
        Controls.Add(lbInputList1)
        Controls.Add(lbInputText2)
        Controls.Add(txtInputText2)
        Controls.Add(lbInputText1)
        Controls.Add(txtInputText1)
        Controls.Add(btCombineEveryOtherLine)
        Controls.Add(listOutput1)
        Controls.Add(listInput2)
        Controls.Add(listInput1)
        ForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(2)
        MaximizeBox = False
        Name = "frmMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "zLineCombine By Vabbajack Sandvich"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents listInput1 As ListBox
    Friend WithEvents listInput2 As ListBox
    Friend WithEvents listOutput1 As ListBox
    Friend WithEvents btCombineEveryOtherLine As Button
    Friend WithEvents txtInputText1 As TextBox
    Friend WithEvents lbInputText1 As Label
    Friend WithEvents lbInputText2 As Label
    Friend WithEvents txtInputText2 As TextBox
    Friend WithEvents lbInputList1 As Label
    Friend WithEvents lbInputList2 As Label
    Friend WithEvents lbOutputList1 As Label
    Friend WithEvents lbOutputText1 As Label
    Friend WithEvents txtOutputText1 As TextBox
    Friend WithEvents btClearInputText1 As Button
    Friend WithEvents btClearInputText2 As Button
    Friend WithEvents btClearOutputText1 As Button
    Friend WithEvents btCombineLeftThenRight As Button
    Friend WithEvents btCopyOutputText1 As Button
    Friend WithEvents btTestMoreLeft As Button
    Friend WithEvents btTestMoreRight As Button
    Friend WithEvents btTestEqual As Button
    Friend WithEvents lbInputList1Count As Label
    Friend WithEvents lbInputList2Count As Label
    Friend WithEvents lbOutputList1Count As Label
    Friend WithEvents btClearAll As Button
    Friend WithEvents ckOnTop As CheckBox
    Friend WithEvents btGetLineCount As Button

End Class
