<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        txtInput1 = New TextBox()
        ListBox1 = New ListBox()
        ListBox2 = New ListBox()
        txtInput2 = New TextBox()
        btInput1 = New Button()
        btInput2 = New Button()
        LbListBox1Count = New Label()
        LbListBox2Count = New Label()
        btCompare1to2KeepUnique = New Button()
        btCompare2to1KeepUnique = New Button()
        ListBox3 = New ListBox()
        LbListBox3Count = New Label()
        txtOutput = New TextBox()
        btCopyText3ToClipboard = New Button()
        btClearInput1 = New Button()
        btClearInput2 = New Button()
        btCrossCompareKeepUnique = New Button()
        LbListBox4Count = New Label()
        LbListBox5Count = New Label()
        ListBox4 = New ListBox()
        ListBox5 = New ListBox()
        bttxtOutputCrossCompare1To2Copy = New Button()
        txtOutputCrossCompare1To2 = New TextBox()
        bttxtOutputCrossCompare2T12Copy = New Button()
        txtOutputCrossCompare2To1 = New TextBox()
        bttxtOutputCrossCompare1To2Clear = New Button()
        bttxtOutputCrossCompare2To1Clear = New Button()
        btMergeCrossCompareOutput = New Button()
        btCrossCompareAndMerge = New Button()
        btInput1And2 = New Button()
        btCrossCompareMergeShowBothUniqueNonDeduplicated = New Button()
        btInputTestData = New Button()
        btClearAll = New Button()
        btCrossCompareMergeShowBothUniqueDeduplicated = New Button()
        SuspendLayout()
        ' 
        ' txtInput1
        ' 
        txtInput1.BackColor = Color.Black
        txtInput1.ForeColor = Color.LimeGreen
        txtInput1.Location = New Point(12, 12)
        txtInput1.Multiline = True
        txtInput1.Name = "txtInput1"
        txtInput1.Size = New Size(389, 144)
        txtInput1.TabIndex = 0
        ' 
        ' ListBox1
        ' 
        ListBox1.BackColor = Color.Black
        ListBox1.ForeColor = Color.LimeGreen
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(12, 207)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(389, 144)
        ListBox1.TabIndex = 1
        ' 
        ' ListBox2
        ' 
        ListBox2.BackColor = Color.Black
        ListBox2.ForeColor = Color.LimeGreen
        ListBox2.FormattingEnabled = True
        ListBox2.Location = New Point(407, 207)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(389, 144)
        ListBox2.TabIndex = 2
        ' 
        ' txtInput2
        ' 
        txtInput2.BackColor = Color.Black
        txtInput2.ForeColor = Color.LimeGreen
        txtInput2.Location = New Point(407, 12)
        txtInput2.Multiline = True
        txtInput2.Name = "txtInput2"
        txtInput2.Size = New Size(389, 144)
        txtInput2.TabIndex = 3
        ' 
        ' btInput1
        ' 
        btInput1.FlatStyle = FlatStyle.Flat
        btInput1.Location = New Point(802, 102)
        btInput1.Name = "btInput1"
        btInput1.Size = New Size(101, 39)
        btInput1.TabIndex = 4
        btInput1.Text = "Input1"
        btInput1.UseVisualStyleBackColor = True
        ' 
        ' btInput2
        ' 
        btInput2.FlatStyle = FlatStyle.Flat
        btInput2.Location = New Point(926, 102)
        btInput2.Name = "btInput2"
        btInput2.Size = New Size(101, 39)
        btInput2.TabIndex = 5
        btInput2.Text = "Input2"
        btInput2.UseVisualStyleBackColor = True
        ' 
        ' LbListBox1Count
        ' 
        LbListBox1Count.AutoSize = True
        LbListBox1Count.Location = New Point(12, 354)
        LbListBox1Count.Name = "LbListBox1Count"
        LbListBox1Count.Size = New Size(17, 20)
        LbListBox1Count.TabIndex = 6
        LbListBox1Count.Text = "0"
        ' 
        ' LbListBox2Count
        ' 
        LbListBox2Count.AutoSize = True
        LbListBox2Count.Location = New Point(407, 354)
        LbListBox2Count.Name = "LbListBox2Count"
        LbListBox2Count.Size = New Size(17, 20)
        LbListBox2Count.TabIndex = 7
        LbListBox2Count.Text = "0"
        ' 
        ' btCompare1to2KeepUnique
        ' 
        btCompare1to2KeepUnique.FlatStyle = FlatStyle.Flat
        btCompare1to2KeepUnique.Location = New Point(802, 192)
        btCompare1to2KeepUnique.Name = "btCompare1to2KeepUnique"
        btCompare1to2KeepUnique.Size = New Size(225, 39)
        btCompare1to2KeepUnique.TabIndex = 8
        btCompare1to2KeepUnique.Text = "Compare 1 To 2 Keep Unique"
        btCompare1to2KeepUnique.UseVisualStyleBackColor = True
        ' 
        ' btCompare2to1KeepUnique
        ' 
        btCompare2to1KeepUnique.FlatStyle = FlatStyle.Flat
        btCompare2to1KeepUnique.Location = New Point(802, 237)
        btCompare2to1KeepUnique.Name = "btCompare2to1KeepUnique"
        btCompare2to1KeepUnique.Size = New Size(225, 39)
        btCompare2to1KeepUnique.TabIndex = 9
        btCompare2to1KeepUnique.Text = "Compare 2 To 1 Keep Unique"
        btCompare2to1KeepUnique.UseVisualStyleBackColor = True
        ' 
        ' ListBox3
        ' 
        ListBox3.BackColor = Color.Black
        ListBox3.ForeColor = Color.LimeGreen
        ListBox3.FormattingEnabled = True
        ListBox3.Location = New Point(12, 377)
        ListBox3.Name = "ListBox3"
        ListBox3.Size = New Size(389, 144)
        ListBox3.TabIndex = 10
        ' 
        ' LbListBox3Count
        ' 
        LbListBox3Count.AutoSize = True
        LbListBox3Count.Location = New Point(12, 521)
        LbListBox3Count.Name = "LbListBox3Count"
        LbListBox3Count.Size = New Size(17, 20)
        LbListBox3Count.TabIndex = 11
        LbListBox3Count.Text = "0"
        ' 
        ' txtOutput
        ' 
        txtOutput.BackColor = Color.Black
        txtOutput.ForeColor = Color.LimeGreen
        txtOutput.Location = New Point(407, 377)
        txtOutput.Multiline = True
        txtOutput.Name = "txtOutput"
        txtOutput.Size = New Size(389, 144)
        txtOutput.TabIndex = 12
        ' 
        ' btCopyText3ToClipboard
        ' 
        btCopyText3ToClipboard.FlatStyle = FlatStyle.Flat
        btCopyText3ToClipboard.Location = New Point(695, 527)
        btCopyText3ToClipboard.Name = "btCopyText3ToClipboard"
        btCopyText3ToClipboard.Size = New Size(101, 39)
        btCopyText3ToClipboard.TabIndex = 13
        btCopyText3ToClipboard.Text = "Copy"
        btCopyText3ToClipboard.UseVisualStyleBackColor = True
        ' 
        ' btClearInput1
        ' 
        btClearInput1.FlatStyle = FlatStyle.Flat
        btClearInput1.Location = New Point(12, 162)
        btClearInput1.Name = "btClearInput1"
        btClearInput1.Size = New Size(101, 39)
        btClearInput1.TabIndex = 14
        btClearInput1.Text = "Clear"
        btClearInput1.UseVisualStyleBackColor = True
        ' 
        ' btClearInput2
        ' 
        btClearInput2.FlatStyle = FlatStyle.Flat
        btClearInput2.Location = New Point(407, 162)
        btClearInput2.Name = "btClearInput2"
        btClearInput2.Size = New Size(101, 39)
        btClearInput2.TabIndex = 15
        btClearInput2.Text = "Clear"
        btClearInput2.UseVisualStyleBackColor = True
        ' 
        ' btCrossCompareKeepUnique
        ' 
        btCrossCompareKeepUnique.FlatStyle = FlatStyle.Flat
        btCrossCompareKeepUnique.Location = New Point(802, 282)
        btCrossCompareKeepUnique.Name = "btCrossCompareKeepUnique"
        btCrossCompareKeepUnique.Size = New Size(225, 39)
        btCrossCompareKeepUnique.TabIndex = 20
        btCrossCompareKeepUnique.Text = "Cross Compare Keep Unique"
        btCrossCompareKeepUnique.UseVisualStyleBackColor = True
        ' 
        ' LbListBox4Count
        ' 
        LbListBox4Count.AutoSize = True
        LbListBox4Count.Location = New Point(12, 720)
        LbListBox4Count.Name = "LbListBox4Count"
        LbListBox4Count.Size = New Size(17, 20)
        LbListBox4Count.TabIndex = 19
        LbListBox4Count.Text = "0"
        ' 
        ' LbListBox5Count
        ' 
        LbListBox5Count.AutoSize = True
        LbListBox5Count.Location = New Point(407, 720)
        LbListBox5Count.Name = "LbListBox5Count"
        LbListBox5Count.Size = New Size(17, 20)
        LbListBox5Count.TabIndex = 18
        LbListBox5Count.Text = "0"
        ' 
        ' ListBox4
        ' 
        ListBox4.BackColor = Color.Black
        ListBox4.ForeColor = Color.LimeGreen
        ListBox4.FormattingEnabled = True
        ListBox4.Location = New Point(12, 573)
        ListBox4.Name = "ListBox4"
        ListBox4.Size = New Size(389, 144)
        ListBox4.TabIndex = 17
        ' 
        ' ListBox5
        ' 
        ListBox5.BackColor = Color.Black
        ListBox5.ForeColor = Color.LimeGreen
        ListBox5.FormattingEnabled = True
        ListBox5.Location = New Point(407, 573)
        ListBox5.Name = "ListBox5"
        ListBox5.Size = New Size(389, 144)
        ListBox5.TabIndex = 16
        ' 
        ' bttxtOutputCrossCompare1To2Copy
        ' 
        bttxtOutputCrossCompare1To2Copy.FlatStyle = FlatStyle.Flat
        bttxtOutputCrossCompare1To2Copy.Location = New Point(300, 893)
        bttxtOutputCrossCompare1To2Copy.Name = "bttxtOutputCrossCompare1To2Copy"
        bttxtOutputCrossCompare1To2Copy.Size = New Size(101, 39)
        bttxtOutputCrossCompare1To2Copy.TabIndex = 22
        bttxtOutputCrossCompare1To2Copy.Text = "Copy"
        bttxtOutputCrossCompare1To2Copy.UseVisualStyleBackColor = True
        ' 
        ' txtOutputCrossCompare1To2
        ' 
        txtOutputCrossCompare1To2.BackColor = Color.Black
        txtOutputCrossCompare1To2.ForeColor = Color.LimeGreen
        txtOutputCrossCompare1To2.Location = New Point(12, 743)
        txtOutputCrossCompare1To2.Multiline = True
        txtOutputCrossCompare1To2.Name = "txtOutputCrossCompare1To2"
        txtOutputCrossCompare1To2.Size = New Size(389, 144)
        txtOutputCrossCompare1To2.TabIndex = 21
        ' 
        ' bttxtOutputCrossCompare2T12Copy
        ' 
        bttxtOutputCrossCompare2T12Copy.FlatStyle = FlatStyle.Flat
        bttxtOutputCrossCompare2T12Copy.Location = New Point(695, 893)
        bttxtOutputCrossCompare2T12Copy.Name = "bttxtOutputCrossCompare2T12Copy"
        bttxtOutputCrossCompare2T12Copy.Size = New Size(101, 39)
        bttxtOutputCrossCompare2T12Copy.TabIndex = 24
        bttxtOutputCrossCompare2T12Copy.Text = "Copy"
        bttxtOutputCrossCompare2T12Copy.UseVisualStyleBackColor = True
        ' 
        ' txtOutputCrossCompare2To1
        ' 
        txtOutputCrossCompare2To1.BackColor = Color.Black
        txtOutputCrossCompare2To1.ForeColor = Color.LimeGreen
        txtOutputCrossCompare2To1.Location = New Point(407, 743)
        txtOutputCrossCompare2To1.Multiline = True
        txtOutputCrossCompare2To1.Name = "txtOutputCrossCompare2To1"
        txtOutputCrossCompare2To1.Size = New Size(389, 144)
        txtOutputCrossCompare2To1.TabIndex = 23
        ' 
        ' bttxtOutputCrossCompare1To2Clear
        ' 
        bttxtOutputCrossCompare1To2Clear.FlatStyle = FlatStyle.Flat
        bttxtOutputCrossCompare1To2Clear.Location = New Point(12, 893)
        bttxtOutputCrossCompare1To2Clear.Name = "bttxtOutputCrossCompare1To2Clear"
        bttxtOutputCrossCompare1To2Clear.Size = New Size(101, 39)
        bttxtOutputCrossCompare1To2Clear.TabIndex = 25
        bttxtOutputCrossCompare1To2Clear.Text = "Clear"
        bttxtOutputCrossCompare1To2Clear.UseVisualStyleBackColor = True
        ' 
        ' bttxtOutputCrossCompare2To1Clear
        ' 
        bttxtOutputCrossCompare2To1Clear.FlatStyle = FlatStyle.Flat
        bttxtOutputCrossCompare2To1Clear.Location = New Point(407, 893)
        bttxtOutputCrossCompare2To1Clear.Name = "bttxtOutputCrossCompare2To1Clear"
        bttxtOutputCrossCompare2To1Clear.Size = New Size(101, 39)
        bttxtOutputCrossCompare2To1Clear.TabIndex = 26
        bttxtOutputCrossCompare2To1Clear.Text = "Clear"
        bttxtOutputCrossCompare2To1Clear.UseVisualStyleBackColor = True
        ' 
        ' btMergeCrossCompareOutput
        ' 
        btMergeCrossCompareOutput.FlatStyle = FlatStyle.Flat
        btMergeCrossCompareOutput.Location = New Point(802, 327)
        btMergeCrossCompareOutput.Name = "btMergeCrossCompareOutput"
        btMergeCrossCompareOutput.Size = New Size(225, 39)
        btMergeCrossCompareOutput.TabIndex = 27
        btMergeCrossCompareOutput.Text = "Merge Cross Compare Output"
        btMergeCrossCompareOutput.UseVisualStyleBackColor = True
        ' 
        ' btCrossCompareAndMerge
        ' 
        btCrossCompareAndMerge.FlatStyle = FlatStyle.Flat
        btCrossCompareAndMerge.Location = New Point(802, 372)
        btCrossCompareAndMerge.Name = "btCrossCompareAndMerge"
        btCrossCompareAndMerge.Size = New Size(225, 39)
        btCrossCompareAndMerge.TabIndex = 28
        btCrossCompareAndMerge.Text = "Cross Compare And Merge Output"
        btCrossCompareAndMerge.UseVisualStyleBackColor = True
        ' 
        ' btInput1And2
        ' 
        btInput1And2.FlatStyle = FlatStyle.Flat
        btInput1And2.Location = New Point(802, 147)
        btInput1And2.Name = "btInput1And2"
        btInput1And2.Size = New Size(225, 39)
        btInput1And2.TabIndex = 29
        btInput1And2.Text = "Input 1 And 2"
        btInput1And2.UseVisualStyleBackColor = True
        ' 
        ' btCrossCompareMergeShowBothUniqueNonDeduplicated
        ' 
        btCrossCompareMergeShowBothUniqueNonDeduplicated.FlatStyle = FlatStyle.Flat
        btCrossCompareMergeShowBothUniqueNonDeduplicated.Location = New Point(802, 417)
        btCrossCompareMergeShowBothUniqueNonDeduplicated.Name = "btCrossCompareMergeShowBothUniqueNonDeduplicated"
        btCrossCompareMergeShowBothUniqueNonDeduplicated.Size = New Size(225, 80)
        btCrossCompareMergeShowBothUniqueNonDeduplicated.TabIndex = 30
        btCrossCompareMergeShowBothUniqueNonDeduplicated.Text = "Cross Compare Merge Show Both Unique Lists Non-Deduplicated"
        btCrossCompareMergeShowBothUniqueNonDeduplicated.UseVisualStyleBackColor = True
        ' 
        ' btInputTestData
        ' 
        btInputTestData.FlatStyle = FlatStyle.Flat
        btInputTestData.Location = New Point(802, 12)
        btInputTestData.Name = "btInputTestData"
        btInputTestData.Size = New Size(225, 39)
        btInputTestData.TabIndex = 31
        btInputTestData.Text = "Input Test Data"
        btInputTestData.UseVisualStyleBackColor = True
        ' 
        ' btClearAll
        ' 
        btClearAll.FlatStyle = FlatStyle.Flat
        btClearAll.Location = New Point(802, 57)
        btClearAll.Name = "btClearAll"
        btClearAll.Size = New Size(225, 39)
        btClearAll.TabIndex = 32
        btClearAll.Text = "Clear All"
        btClearAll.UseVisualStyleBackColor = True
        ' 
        ' btCrossCompareMergeShowBothUniqueDeduplicated
        ' 
        btCrossCompareMergeShowBothUniqueDeduplicated.FlatStyle = FlatStyle.Flat
        btCrossCompareMergeShowBothUniqueDeduplicated.Location = New Point(802, 506)
        btCrossCompareMergeShowBothUniqueDeduplicated.Name = "btCrossCompareMergeShowBothUniqueDeduplicated"
        btCrossCompareMergeShowBothUniqueDeduplicated.Size = New Size(225, 80)
        btCrossCompareMergeShowBothUniqueDeduplicated.TabIndex = 33
        btCrossCompareMergeShowBothUniqueDeduplicated.Text = "Cross Compare Merge Show Both Unique Lists Deduplicated"
        btCrossCompareMergeShowBothUniqueDeduplicated.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.Black
        ClientSize = New Size(1077, 1055)
        Controls.Add(btCrossCompareMergeShowBothUniqueDeduplicated)
        Controls.Add(btClearAll)
        Controls.Add(btInputTestData)
        Controls.Add(btCrossCompareMergeShowBothUniqueNonDeduplicated)
        Controls.Add(btInput1And2)
        Controls.Add(btCrossCompareAndMerge)
        Controls.Add(btMergeCrossCompareOutput)
        Controls.Add(bttxtOutputCrossCompare2To1Clear)
        Controls.Add(bttxtOutputCrossCompare1To2Clear)
        Controls.Add(bttxtOutputCrossCompare2T12Copy)
        Controls.Add(txtOutputCrossCompare2To1)
        Controls.Add(bttxtOutputCrossCompare1To2Copy)
        Controls.Add(txtOutputCrossCompare1To2)
        Controls.Add(btCrossCompareKeepUnique)
        Controls.Add(LbListBox4Count)
        Controls.Add(LbListBox5Count)
        Controls.Add(ListBox4)
        Controls.Add(ListBox5)
        Controls.Add(btClearInput2)
        Controls.Add(btClearInput1)
        Controls.Add(btCopyText3ToClipboard)
        Controls.Add(txtOutput)
        Controls.Add(LbListBox3Count)
        Controls.Add(ListBox3)
        Controls.Add(btCompare2to1KeepUnique)
        Controls.Add(btCompare1to2KeepUnique)
        Controls.Add(LbListBox2Count)
        Controls.Add(LbListBox1Count)
        Controls.Add(btInput2)
        Controls.Add(btInput1)
        Controls.Add(txtInput2)
        Controls.Add(ListBox2)
        Controls.Add(ListBox1)
        Controls.Add(txtInput1)
        ForeColor = Color.LimeGreen
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "zList"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtInput1 As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents txtInput2 As TextBox
    Friend WithEvents btInput1 As Button
    Friend WithEvents btInput2 As Button
    Friend WithEvents LbListBox1Count As Label
    Friend WithEvents LbListBox2Count As Label
    Friend WithEvents btCompare1to2KeepUnique As Button
    Friend WithEvents btCompare2to1KeepUnique As Button
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents LbListBox3Count As Label
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents btCopyText3ToClipboard As Button
    Friend WithEvents btClearInput1 As Button
    Friend WithEvents btClearInput2 As Button
    Friend WithEvents btCrossCompareKeepUnique As Button
    Friend WithEvents LbListBox4Count As Label
    Friend WithEvents LbListBox5Count As Label
    Friend WithEvents ListBox4 As ListBox
    Friend WithEvents ListBox5 As ListBox
    Friend WithEvents bttxtOutputCrossCompare1To2Copy As Button
    Friend WithEvents txtOutputCrossCompare1To2 As TextBox
    Friend WithEvents bttxtOutputCrossCompare2T12Copy As Button
    Friend WithEvents txtOutputCrossCompare2To1 As TextBox
    Friend WithEvents bttxtOutputCrossCompare1To2Clear As Button
    Friend WithEvents bttxtOutputCrossCompare2To1Clear As Button
    Friend WithEvents btMergeCrossCompareOutput As Button
    Friend WithEvents btCrossCompareAndMerge As Button
    Friend WithEvents btInput1And2 As Button
    Friend WithEvents btCrossCompareMergeShowBothUniqueNonDeduplicated As Button
    Friend WithEvents btInputTestData As Button
    Friend WithEvents btClearAll As Button
    Friend WithEvents btCrossCompareMergeShowBothUniqueDeduplicated As Button

End Class
