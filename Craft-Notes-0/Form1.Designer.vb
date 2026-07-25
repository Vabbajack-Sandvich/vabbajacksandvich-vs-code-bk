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
        components = New ComponentModel.Container()
        btLoad = New Button()
        btSave = New Button()
        txtBaseDir = New TextBox()
        btOpenBasePath = New Button()
        txtLog = New TextBox()
        btTimestamp = New Button()
        txtX = New TextBox()
        txtY = New TextBox()
        txtZ = New TextBox()
        txtOZ = New TextBox()
        txtOY = New TextBox()
        txtOX = New TextBox()
        txtNZ = New TextBox()
        txtNY = New TextBox()
        txtNX = New TextBox()
        lbCValues = New Label()
        lbOverWorldValues = New Label()
        lbNetherValues = New Label()
        btCalc = New Button()
        btInsertO = New Button()
        btInsertN = New Button()
        ckRound = New CheckBox()
        ckInsertOpposite = New CheckBox()
        lbInit = New Label()
        tmrStart = New Timer(components)
        btClear = New Button()
        lbControl = New Label()
        ckOnTop = New CheckBox()
        Label1 = New Label()
        btFindCaret = New Button()
        btTop = New Button()
        btEnd = New Button()
        btFindText = New Button()
        txtFindText = New TextBox()
        listFindIndex = New ListBox()
        btFindPrevious = New Button()
        btFindNext = New Button()
        btClearFindText = New Button()
        lbFindListCount = New Label()
        lbFindCountText = New Label()
        bt2025 = New Button()
        SuspendLayout()
        ' 
        ' btLoad
        ' 
        btLoad.BackColor = Color.Black
        btLoad.ForeColor = Color.Gray
        btLoad.Location = New Point(20, 66)
        btLoad.Margin = New Padding(4)
        btLoad.Name = "btLoad"
        btLoad.Size = New Size(156, 49)
        btLoad.TabIndex = 16
        btLoad.Text = "Load Log"
        btLoad.UseVisualStyleBackColor = False
        ' 
        ' btSave
        ' 
        btSave.BackColor = Color.Black
        btSave.ForeColor = Color.Gray
        btSave.Location = New Point(194, 67)
        btSave.Margin = New Padding(4)
        btSave.Name = "btSave"
        btSave.Size = New Size(137, 47)
        btSave.TabIndex = 17
        btSave.Text = "Save Log"
        btSave.UseVisualStyleBackColor = False
        ' 
        ' txtBaseDir
        ' 
        txtBaseDir.BackColor = Color.Black
        txtBaseDir.ForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        txtBaseDir.Location = New Point(14, 14)
        txtBaseDir.Margin = New Padding(4)
        txtBaseDir.Name = "txtBaseDir"
        txtBaseDir.Size = New Size(653, 35)
        txtBaseDir.TabIndex = 2
        txtBaseDir.TabStop = False
        txtBaseDir.Visible = False
        ' 
        ' btOpenBasePath
        ' 
        btOpenBasePath.BackColor = Color.Black
        btOpenBasePath.ForeColor = Color.Gray
        btOpenBasePath.Location = New Point(350, 68)
        btOpenBasePath.Margin = New Padding(4)
        btOpenBasePath.Name = "btOpenBasePath"
        btOpenBasePath.Size = New Size(144, 47)
        btOpenBasePath.TabIndex = 18
        btOpenBasePath.Text = "Open Path"
        btOpenBasePath.UseVisualStyleBackColor = False
        ' 
        ' txtLog
        ' 
        txtLog.BackColor = Color.Black
        txtLog.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        txtLog.ForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        txtLog.Location = New Point(14, 126)
        txtLog.Margin = New Padding(4)
        txtLog.Multiline = True
        txtLog.Name = "txtLog"
        txtLog.ScrollBars = ScrollBars.Vertical
        txtLog.Size = New Size(653, 623)
        txtLog.TabIndex = 0
        ' 
        ' btTimestamp
        ' 
        btTimestamp.BackColor = Color.Black
        btTimestamp.ForeColor = Color.Gray
        btTimestamp.Location = New Point(512, 68)
        btTimestamp.Margin = New Padding(4)
        btTimestamp.Name = "btTimestamp"
        btTimestamp.Size = New Size(144, 47)
        btTimestamp.TabIndex = 19
        btTimestamp.Text = "Time Stamp"
        btTimestamp.UseVisualStyleBackColor = False
        ' 
        ' txtX
        ' 
        txtX.BackColor = Color.Black
        txtX.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtX.ForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        txtX.Location = New Point(688, 151)
        txtX.Margin = New Padding(4)
        txtX.Name = "txtX"
        txtX.Size = New Size(87, 30)
        txtX.TabIndex = 1
        ' 
        ' txtY
        ' 
        txtY.BackColor = Color.Black
        txtY.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtY.ForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        txtY.Location = New Point(783, 151)
        txtY.Margin = New Padding(4)
        txtY.Name = "txtY"
        txtY.Size = New Size(87, 30)
        txtY.TabIndex = 2
        ' 
        ' txtZ
        ' 
        txtZ.BackColor = Color.Black
        txtZ.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtZ.ForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        txtZ.Location = New Point(878, 151)
        txtZ.Margin = New Padding(4)
        txtZ.Name = "txtZ"
        txtZ.Size = New Size(87, 30)
        txtZ.TabIndex = 3
        ' 
        ' txtOZ
        ' 
        txtOZ.BackColor = Color.Black
        txtOZ.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtOZ.ForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        txtOZ.Location = New Point(879, 247)
        txtOZ.Margin = New Padding(4)
        txtOZ.Name = "txtOZ"
        txtOZ.Size = New Size(87, 30)
        txtOZ.TabIndex = 6
        ' 
        ' txtOY
        ' 
        txtOY.BackColor = Color.Black
        txtOY.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtOY.ForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        txtOY.Location = New Point(784, 247)
        txtOY.Margin = New Padding(4)
        txtOY.Name = "txtOY"
        txtOY.Size = New Size(87, 30)
        txtOY.TabIndex = 5
        ' 
        ' txtOX
        ' 
        txtOX.BackColor = Color.Black
        txtOX.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtOX.ForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        txtOX.Location = New Point(689, 247)
        txtOX.Margin = New Padding(4)
        txtOX.Name = "txtOX"
        txtOX.Size = New Size(87, 30)
        txtOX.TabIndex = 4
        ' 
        ' txtNZ
        ' 
        txtNZ.BackColor = Color.Black
        txtNZ.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtNZ.ForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        txtNZ.Location = New Point(879, 343)
        txtNZ.Margin = New Padding(4)
        txtNZ.Name = "txtNZ"
        txtNZ.Size = New Size(87, 30)
        txtNZ.TabIndex = 9
        ' 
        ' txtNY
        ' 
        txtNY.BackColor = Color.Black
        txtNY.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtNY.ForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        txtNY.Location = New Point(784, 343)
        txtNY.Margin = New Padding(4)
        txtNY.Name = "txtNY"
        txtNY.Size = New Size(87, 30)
        txtNY.TabIndex = 8
        ' 
        ' txtNX
        ' 
        txtNX.BackColor = Color.Black
        txtNX.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtNX.ForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        txtNX.Location = New Point(689, 343)
        txtNX.Margin = New Padding(4)
        txtNX.Name = "txtNX"
        txtNX.Size = New Size(87, 30)
        txtNX.TabIndex = 7
        ' 
        ' lbCValues
        ' 
        lbCValues.AutoSize = True
        lbCValues.Location = New Point(732, 114)
        lbCValues.Margin = New Padding(4, 0, 4, 0)
        lbCValues.Name = "lbCValues"
        lbCValues.Size = New Size(181, 30)
        lbCValues.TabIndex = 15
        lbCValues.Text = "Calculation Values"
        ' 
        ' lbOverWorldValues
        ' 
        lbOverWorldValues.AutoSize = True
        lbOverWorldValues.Location = New Point(732, 213)
        lbOverWorldValues.Margin = New Padding(4, 0, 4, 0)
        lbOverWorldValues.Name = "lbOverWorldValues"
        lbOverWorldValues.Size = New Size(205, 30)
        lbOverWorldValues.TabIndex = 16
        lbOverWorldValues.Text = "Overworld Values * 8"
        ' 
        ' lbNetherValues
        ' 
        lbNetherValues.AutoSize = True
        lbNetherValues.Location = New Point(743, 299)
        lbNetherValues.Margin = New Padding(4, 0, 4, 0)
        lbNetherValues.Name = "lbNetherValues"
        lbNetherValues.Size = New Size(173, 30)
        lbNetherValues.TabIndex = 17
        lbNetherValues.Text = "Nether Values / 8"
        ' 
        ' btCalc
        ' 
        btCalc.BackColor = Color.Black
        btCalc.ForeColor = Color.Gray
        btCalc.Location = New Point(982, 119)
        btCalc.Margin = New Padding(4)
        btCalc.Name = "btCalc"
        btCalc.Size = New Size(144, 53)
        btCalc.TabIndex = 12
        btCalc.Text = "Calculate"
        btCalc.UseVisualStyleBackColor = False
        ' 
        ' btInsertO
        ' 
        btInsertO.BackColor = Color.Black
        btInsertO.ForeColor = Color.Gray
        btInsertO.Location = New Point(982, 235)
        btInsertO.Margin = New Padding(4)
        btInsertO.Name = "btInsertO"
        btInsertO.Size = New Size(144, 53)
        btInsertO.TabIndex = 13
        btInsertO.Text = "Insert"
        btInsertO.UseVisualStyleBackColor = False
        ' 
        ' btInsertN
        ' 
        btInsertN.BackColor = Color.Black
        btInsertN.ForeColor = Color.Gray
        btInsertN.Location = New Point(982, 330)
        btInsertN.Margin = New Padding(4)
        btInsertN.Name = "btInsertN"
        btInsertN.Size = New Size(144, 53)
        btInsertN.TabIndex = 14
        btInsertN.Text = "Insert"
        btInsertN.UseVisualStyleBackColor = False
        ' 
        ' ckRound
        ' 
        ckRound.AutoSize = True
        ckRound.Checked = True
        ckRound.CheckState = CheckState.Checked
        ckRound.Location = New Point(992, 180)
        ckRound.Margin = New Padding(4)
        ckRound.Name = "ckRound"
        ckRound.Size = New Size(127, 34)
        ckRound.TabIndex = 11
        ckRound.Text = "Round Up"
        ckRound.UseVisualStyleBackColor = True
        ' 
        ' ckInsertOpposite
        ' 
        ckInsertOpposite.AutoSize = True
        ckInsertOpposite.Checked = True
        ckInsertOpposite.CheckState = CheckState.Checked
        ckInsertOpposite.Location = New Point(699, 470)
        ckInsertOpposite.Margin = New Padding(4)
        ckInsertOpposite.Name = "ckInsertOpposite"
        ckInsertOpposite.Size = New Size(325, 34)
        ckInsertOpposite.TabIndex = 15
        ckInsertOpposite.Text = "Insert Initial Values as Opposite"
        ckInsertOpposite.UseVisualStyleBackColor = True
        ' 
        ' lbInit
        ' 
        lbInit.AutoSize = True
        lbInit.Location = New Point(710, 84)
        lbInit.Margin = New Padding(4, 0, 4, 0)
        lbInit.Name = "lbInit"
        lbInit.Size = New Size(227, 30)
        lbInit.TabIndex = 19
        lbInit.Text = "Initial Calculation X Y Z"
        ' 
        ' tmrStart
        ' 
        tmrStart.Interval = 1000
        ' 
        ' btClear
        ' 
        btClear.BackColor = Color.Black
        btClear.ForeColor = Color.Gray
        btClear.Location = New Point(982, 16)
        btClear.Margin = New Padding(4)
        btClear.Name = "btClear"
        btClear.Size = New Size(144, 53)
        btClear.TabIndex = 10
        btClear.Text = "Clear"
        btClear.UseVisualStyleBackColor = False
        ' 
        ' lbControl
        ' 
        lbControl.Location = New Point(688, 400)
        lbControl.Margin = New Padding(4, 0, 4, 0)
        lbControl.Name = "lbControl"
        lbControl.Size = New Size(400, 76)
        lbControl.TabIndex = 21
        lbControl.Text = "Holding Control and using the arrow keys will move through the text boxes."
        ' 
        ' ckOnTop
        ' 
        ckOnTop.AutoSize = True
        ckOnTop.Checked = True
        ckOnTop.CheckState = CheckState.Checked
        ckOnTop.Location = New Point(732, 46)
        ckOnTop.Margin = New Padding(4)
        ckOnTop.Name = "ckOnTop"
        ckOnTop.Size = New Size(184, 34)
        ckOnTop.TabIndex = 22
        ckOnTop.Text = "Window On Top"
        ckOnTop.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        Label1.Location = New Point(699, 2)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(252, 40)
        Label1.TabIndex = 23
        Label1.Text = "Craft-Notes Version 0"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btFindCaret
        ' 
        btFindCaret.BackColor = Color.Black
        btFindCaret.ForeColor = Color.Gray
        btFindCaret.Location = New Point(822, 512)
        btFindCaret.Margin = New Padding(4)
        btFindCaret.Name = "btFindCaret"
        btFindCaret.Size = New Size(144, 47)
        btFindCaret.TabIndex = 24
        btFindCaret.Text = "Find Caret"
        btFindCaret.UseVisualStyleBackColor = False
        ' 
        ' btTop
        ' 
        btTop.BackColor = Color.Black
        btTop.ForeColor = Color.Gray
        btTop.Location = New Point(675, 512)
        btTop.Margin = New Padding(4)
        btTop.Name = "btTop"
        btTop.Size = New Size(144, 47)
        btTop.TabIndex = 25
        btTop.Text = "Top"
        btTop.UseVisualStyleBackColor = False
        ' 
        ' btEnd
        ' 
        btEnd.BackColor = Color.Black
        btEnd.ForeColor = Color.Gray
        btEnd.Location = New Point(968, 512)
        btEnd.Margin = New Padding(4)
        btEnd.Name = "btEnd"
        btEnd.Size = New Size(144, 47)
        btEnd.TabIndex = 26
        btEnd.Text = "End"
        btEnd.UseVisualStyleBackColor = False
        ' 
        ' btFindText
        ' 
        btFindText.BackColor = Color.Black
        btFindText.ForeColor = Color.Gray
        btFindText.Location = New Point(675, 567)
        btFindText.Margin = New Padding(4)
        btFindText.Name = "btFindText"
        btFindText.Size = New Size(144, 47)
        btFindText.TabIndex = 27
        btFindText.Text = "Find Text"
        btFindText.UseVisualStyleBackColor = False
        ' 
        ' txtFindText
        ' 
        txtFindText.BackColor = Color.Black
        txtFindText.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtFindText.ForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        txtFindText.Location = New Point(839, 577)
        txtFindText.Margin = New Padding(4)
        txtFindText.Name = "txtFindText"
        txtFindText.Size = New Size(127, 30)
        txtFindText.TabIndex = 28
        ' 
        ' listFindIndex
        ' 
        listFindIndex.BackColor = Color.Black
        listFindIndex.ForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        listFindIndex.FormattingEnabled = True
        listFindIndex.ItemHeight = 30
        listFindIndex.Location = New Point(839, 614)
        listFindIndex.Name = "listFindIndex"
        listFindIndex.Size = New Size(284, 94)
        listFindIndex.TabIndex = 30
        ' 
        ' btFindPrevious
        ' 
        btFindPrevious.BackColor = Color.Black
        btFindPrevious.ForeColor = Color.Gray
        btFindPrevious.Location = New Point(675, 622)
        btFindPrevious.Margin = New Padding(4)
        btFindPrevious.Name = "btFindPrevious"
        btFindPrevious.Size = New Size(144, 47)
        btFindPrevious.TabIndex = 31
        btFindPrevious.Text = "Previous"
        btFindPrevious.UseVisualStyleBackColor = False
        ' 
        ' btFindNext
        ' 
        btFindNext.BackColor = Color.Black
        btFindNext.ForeColor = Color.Gray
        btFindNext.Location = New Point(675, 677)
        btFindNext.Margin = New Padding(4)
        btFindNext.Name = "btFindNext"
        btFindNext.Size = New Size(144, 47)
        btFindNext.TabIndex = 32
        btFindNext.Text = "Next"
        btFindNext.UseVisualStyleBackColor = False
        ' 
        ' btClearFindText
        ' 
        btClearFindText.BackColor = Color.Black
        btClearFindText.ForeColor = Color.Gray
        btClearFindText.Location = New Point(1060, 567)
        btClearFindText.Margin = New Padding(4)
        btClearFindText.Name = "btClearFindText"
        btClearFindText.Size = New Size(63, 40)
        btClearFindText.TabIndex = 33
        btClearFindText.Text = "X"
        btClearFindText.UseVisualStyleBackColor = False
        ' 
        ' lbFindListCount
        ' 
        lbFindListCount.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        lbFindListCount.ForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        lbFindListCount.Location = New Point(993, 709)
        lbFindListCount.Margin = New Padding(4, 0, 4, 0)
        lbFindListCount.Name = "lbFindListCount"
        lbFindListCount.Size = New Size(64, 40)
        lbFindListCount.TabIndex = 34
        lbFindListCount.Text = "0"
        lbFindListCount.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbFindCountText
        ' 
        lbFindCountText.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        lbFindCountText.ForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        lbFindCountText.Location = New Point(827, 711)
        lbFindCountText.Margin = New Padding(4, 0, 4, 0)
        lbFindCountText.Name = "lbFindCountText"
        lbFindCountText.Size = New Size(158, 40)
        lbFindCountText.TabIndex = 35
        lbFindCountText.Text = "Find Count:"
        lbFindCountText.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' bt2025
        ' 
        bt2025.BackColor = Color.Black
        bt2025.ForeColor = Color.Gray
        bt2025.Location = New Point(976, 567)
        bt2025.Margin = New Padding(4)
        bt2025.Name = "bt2025"
        bt2025.Size = New Size(75, 40)
        bt2025.TabIndex = 36
        bt2025.Text = "2025"
        bt2025.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(1139, 764)
        Controls.Add(bt2025)
        Controls.Add(lbFindCountText)
        Controls.Add(lbFindListCount)
        Controls.Add(btClearFindText)
        Controls.Add(btFindNext)
        Controls.Add(btFindPrevious)
        Controls.Add(listFindIndex)
        Controls.Add(txtFindText)
        Controls.Add(btFindText)
        Controls.Add(btEnd)
        Controls.Add(btTop)
        Controls.Add(btFindCaret)
        Controls.Add(Label1)
        Controls.Add(ckOnTop)
        Controls.Add(lbControl)
        Controls.Add(btClear)
        Controls.Add(lbInit)
        Controls.Add(ckInsertOpposite)
        Controls.Add(ckRound)
        Controls.Add(btInsertN)
        Controls.Add(btInsertO)
        Controls.Add(btCalc)
        Controls.Add(lbNetherValues)
        Controls.Add(lbOverWorldValues)
        Controls.Add(lbCValues)
        Controls.Add(txtNZ)
        Controls.Add(txtNY)
        Controls.Add(txtNX)
        Controls.Add(txtOZ)
        Controls.Add(txtOY)
        Controls.Add(txtOX)
        Controls.Add(txtZ)
        Controls.Add(txtY)
        Controls.Add(txtX)
        Controls.Add(btTimestamp)
        Controls.Add(txtLog)
        Controls.Add(btOpenBasePath)
        Controls.Add(txtBaseDir)
        Controls.Add(btSave)
        Controls.Add(btLoad)
        ForeColor = Color.Gray
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(4)
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Craft-Notes-0"
        TopMost = True
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btLoad As Button
    Friend WithEvents btSave As Button
    Friend WithEvents txtBaseDir As TextBox
    Friend WithEvents btOpenBasePath As Button
    Friend WithEvents txtLog As TextBox
    Friend WithEvents btTimestamp As Button
    Friend WithEvents txtX As TextBox
    Friend WithEvents txtY As TextBox
    Friend WithEvents txtZ As TextBox
    Friend WithEvents txtOZ As TextBox
    Friend WithEvents txtOY As TextBox
    Friend WithEvents txtOX As TextBox
    Friend WithEvents txtNZ As TextBox
    Friend WithEvents txtNY As TextBox
    Friend WithEvents txtNX As TextBox
    Friend WithEvents lbCValues As Label
    Friend WithEvents lbOverWorldValues As Label
    Friend WithEvents lbNetherValues As Label
    Friend WithEvents btCalc As Button
    Friend WithEvents btInsertO As Button
    Friend WithEvents btInsertN As Button
    Friend WithEvents ckRound As CheckBox
    Friend WithEvents ckInsertOpposite As CheckBox
    Friend WithEvents lbInit As Label
    Friend WithEvents tmrStart As Timer
    Friend WithEvents btClear As Button
    Friend WithEvents lbControl As Label
    Friend WithEvents ckOnTop As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btFindCaret As Button
    Friend WithEvents btTop As Button
    Friend WithEvents btEnd As Button
    Friend WithEvents btFindText As Button
    Friend WithEvents txtFindText As TextBox
    Friend WithEvents listFindIndex As ListBox
    Friend WithEvents btFindPrevious As Button
    Friend WithEvents btFindNext As Button
    Friend WithEvents btClearFindText As Button
    Friend WithEvents lbFindListCount As Label
    Friend WithEvents lbFindCountText As Label
    Friend WithEvents bt2025 As Button
End Class
