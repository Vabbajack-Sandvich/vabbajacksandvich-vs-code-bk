<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        components = New ComponentModel.Container()
        btTimeStamp = New Button()
        txtDate = New TextBox()
        cbCopy = New Button()
        tmrDate = New Timer(components)
        txtLog = New RichTextBox()
        tmrRunOnce = New Timer(components)
        btSave = New Button()
        tmrSave = New Timer(components)
        lbSave = New Label()
        btRestore = New Button()
        btTop = New Button()
        btEnd = New Button()
        btFindCaret = New Button()
        lbTitle = New Label()
        btClose = New Button()
        btMinimize = New Button()
        btMaximize = New Button()
        btUndoBack = New Button()
        btUndoForward = New Button()
        tmrUndoListUpdate = New Timer(components)
        DateTimePicker1 = New DateTimePicker()
        btInsertDate = New Button()
        ck2Week = New CheckBox()
        btAddEqualsLine = New Button()
        DateTimePicker2 = New DateTimePicker()
        btCompare = New Button()
        btFind = New Button()
        ckMoonCycle = New CheckBox()
        SuspendLayout()
        ' 
        ' btTimeStamp
        ' 
        btTimeStamp.BackColor = Color.Black
        btTimeStamp.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btTimeStamp.ForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        btTimeStamp.Location = New Point(7, 58)
        btTimeStamp.Margin = New Padding(4)
        btTimeStamp.Name = "btTimeStamp"
        btTimeStamp.Size = New Size(141, 44)
        btTimeStamp.TabIndex = 0
        btTimeStamp.Text = "Time Stamp"
        btTimeStamp.UseVisualStyleBackColor = False
        ' 
        ' txtDate
        ' 
        txtDate.BackColor = Color.Black
        txtDate.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtDate.ForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        txtDate.Location = New Point(301, 65)
        txtDate.Margin = New Padding(4)
        txtDate.Name = "txtDate"
        txtDate.Size = New Size(336, 30)
        txtDate.TabIndex = 2
        ' 
        ' cbCopy
        ' 
        cbCopy.BackColor = Color.Black
        cbCopy.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        cbCopy.ForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        cbCopy.Location = New Point(152, 58)
        cbCopy.Margin = New Padding(4)
        cbCopy.Name = "cbCopy"
        cbCopy.Size = New Size(141, 44)
        cbCopy.TabIndex = 1
        cbCopy.Text = "Copy"
        cbCopy.UseVisualStyleBackColor = False
        ' 
        ' tmrDate
        ' 
        tmrDate.Enabled = True
        tmrDate.Interval = 1000
        ' 
        ' txtLog
        ' 
        txtLog.BackColor = Color.Black
        txtLog.BorderStyle = BorderStyle.FixedSingle
        txtLog.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        txtLog.ForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        txtLog.Location = New Point(4, 206)
        txtLog.Margin = New Padding(10, 10, 10, 100)
        txtLog.Name = "txtLog"
        txtLog.ScrollBars = RichTextBoxScrollBars.Vertical
        txtLog.Size = New Size(1175, 438)
        txtLog.TabIndex = 3
        txtLog.Text = ""
        ' 
        ' tmrRunOnce
        ' 
        tmrRunOnce.Enabled = True
        tmrRunOnce.Interval = 1000
        ' 
        ' btSave
        ' 
        btSave.BackColor = Color.Black
        btSave.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btSave.ForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        btSave.Location = New Point(1018, 58)
        btSave.Margin = New Padding(4)
        btSave.Name = "btSave"
        btSave.Size = New Size(87, 44)
        btSave.TabIndex = 4
        btSave.Text = "Save"
        btSave.UseVisualStyleBackColor = False
        ' 
        ' tmrSave
        ' 
        tmrSave.Enabled = True
        tmrSave.Interval = 1000
        ' 
        ' lbSave
        ' 
        lbSave.AutoSize = True
        lbSave.BackColor = Color.Black
        lbSave.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lbSave.ForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        lbSave.Location = New Point(1121, 68)
        lbSave.Margin = New Padding(4, 0, 4, 0)
        lbSave.Name = "lbSave"
        lbSave.Size = New Size(23, 25)
        lbSave.TabIndex = 5
        lbSave.Text = "1"
        ' 
        ' btRestore
        ' 
        btRestore.BackColor = Color.Black
        btRestore.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btRestore.ForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        btRestore.Location = New Point(904, 58)
        btRestore.Margin = New Padding(4)
        btRestore.Name = "btRestore"
        btRestore.Size = New Size(93, 44)
        btRestore.TabIndex = 6
        btRestore.Text = "Restore"
        btRestore.UseVisualStyleBackColor = False
        ' 
        ' btTop
        ' 
        btTop.BackColor = Color.Black
        btTop.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btTop.ForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        btTop.Location = New Point(644, 58)
        btTop.Margin = New Padding(4)
        btTop.Name = "btTop"
        btTop.Size = New Size(76, 44)
        btTop.TabIndex = 7
        btTop.Text = "Top"
        btTop.UseVisualStyleBackColor = False
        ' 
        ' btEnd
        ' 
        btEnd.BackColor = Color.Black
        btEnd.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btEnd.ForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        btEnd.Location = New Point(810, 58)
        btEnd.Margin = New Padding(4)
        btEnd.Name = "btEnd"
        btEnd.Size = New Size(76, 44)
        btEnd.TabIndex = 8
        btEnd.Text = "End"
        btEnd.UseVisualStyleBackColor = False
        ' 
        ' btFindCaret
        ' 
        btFindCaret.BackColor = Color.Black
        btFindCaret.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btFindCaret.ForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        btFindCaret.Location = New Point(726, 58)
        btFindCaret.Margin = New Padding(4)
        btFindCaret.Name = "btFindCaret"
        btFindCaret.Size = New Size(76, 44)
        btFindCaret.TabIndex = 9
        btFindCaret.Text = "C"
        btFindCaret.UseVisualStyleBackColor = False
        ' 
        ' lbTitle
        ' 
        lbTitle.BackColor = Color.Black
        lbTitle.ForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        lbTitle.Location = New Point(0, 0)
        lbTitle.Margin = New Padding(4, 0, 4, 0)
        lbTitle.Name = "lbTitle"
        lbTitle.Size = New Size(997, 49)
        lbTitle.TabIndex = 10
        lbTitle.Text = "gLog - by Vabbajack Sandvich"
        lbTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btClose
        ' 
        btClose.BackColor = Color.Black
        btClose.ForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        btClose.Location = New Point(1131, 5)
        btClose.Margin = New Padding(4)
        btClose.Name = "btClose"
        btClose.Size = New Size(56, 45)
        btClose.TabIndex = 11
        btClose.Text = "X"
        btClose.UseVisualStyleBackColor = False
        ' 
        ' btMinimize
        ' 
        btMinimize.BackColor = Color.Black
        btMinimize.ForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        btMinimize.Location = New Point(1016, 5)
        btMinimize.Margin = New Padding(4)
        btMinimize.Name = "btMinimize"
        btMinimize.Size = New Size(56, 45)
        btMinimize.TabIndex = 12
        btMinimize.Text = "__"
        btMinimize.UseVisualStyleBackColor = False
        ' 
        ' btMaximize
        ' 
        btMaximize.BackColor = Color.Black
        btMaximize.ForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        btMaximize.Location = New Point(1074, 5)
        btMaximize.Margin = New Padding(4)
        btMaximize.Name = "btMaximize"
        btMaximize.Size = New Size(56, 45)
        btMaximize.TabIndex = 13
        btMaximize.Text = "■"
        btMaximize.UseVisualStyleBackColor = False
        ' 
        ' btUndoBack
        ' 
        btUndoBack.BackColor = Color.Black
        btUndoBack.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btUndoBack.ForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        btUndoBack.Location = New Point(6, 105)
        btUndoBack.Margin = New Padding(4)
        btUndoBack.Name = "btUndoBack"
        btUndoBack.Size = New Size(139, 44)
        btUndoBack.TabIndex = 14
        btUndoBack.Text = "Undo <-"
        btUndoBack.UseVisualStyleBackColor = False
        ' 
        ' btUndoForward
        ' 
        btUndoForward.BackColor = Color.Black
        btUndoForward.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btUndoForward.ForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        btUndoForward.Location = New Point(6, 149)
        btUndoForward.Margin = New Padding(4)
        btUndoForward.Name = "btUndoForward"
        btUndoForward.Size = New Size(139, 44)
        btUndoForward.TabIndex = 15
        btUndoForward.Text = "Undo ->"
        btUndoForward.UseVisualStyleBackColor = False
        ' 
        ' tmrUndoListUpdate
        ' 
        tmrUndoListUpdate.Enabled = True
        tmrUndoListUpdate.Interval = 15000
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarFont = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        DateTimePicker1.CalendarForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        DateTimePicker1.CalendarMonthBackground = Color.Black
        DateTimePicker1.CalendarTitleForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        DateTimePicker1.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.Location = New Point(152, 109)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(380, 39)
        DateTimePicker1.TabIndex = 16
        ' 
        ' btInsertDate
        ' 
        btInsertDate.BackColor = Color.Black
        btInsertDate.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btInsertDate.ForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        btInsertDate.Location = New Point(539, 105)
        btInsertDate.Margin = New Padding(4)
        btInsertDate.Name = "btInsertDate"
        btInsertDate.Size = New Size(195, 44)
        btInsertDate.TabIndex = 17
        btInsertDate.Text = "Insert Batch Calculations"
        btInsertDate.UseVisualStyleBackColor = False
        ' 
        ' ck2Week
        ' 
        ck2Week.AutoSize = True
        ck2Week.BackColor = Color.Black
        ck2Week.Checked = True
        ck2Week.CheckState = CheckState.Checked
        ck2Week.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ck2Week.Location = New Point(741, 110)
        ck2Week.Name = "ck2Week"
        ck2Week.Size = New Size(102, 29)
        ck2Week.TabIndex = 18
        ck2Week.Text = "2 Week"
        ck2Week.UseVisualStyleBackColor = False
        ' 
        ' btAddEqualsLine
        ' 
        btAddEqualsLine.BackColor = Color.Black
        btAddEqualsLine.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btAddEqualsLine.ForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        btAddEqualsLine.Location = New Point(984, 103)
        btAddEqualsLine.Margin = New Padding(4)
        btAddEqualsLine.Name = "btAddEqualsLine"
        btAddEqualsLine.Size = New Size(121, 44)
        btAddEqualsLine.TabIndex = 19
        btAddEqualsLine.Text = "====="
        btAddEqualsLine.UseVisualStyleBackColor = False
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.CalendarFont = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        DateTimePicker2.CalendarForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        DateTimePicker2.CalendarMonthBackground = Color.Black
        DateTimePicker2.CalendarTitleForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        DateTimePicker2.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.Location = New Point(152, 154)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(380, 39)
        DateTimePicker2.TabIndex = 20
        ' 
        ' btCompare
        ' 
        btCompare.BackColor = Color.Black
        btCompare.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        btCompare.ForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        btCompare.Location = New Point(539, 151)
        btCompare.Margin = New Padding(4)
        btCompare.Name = "btCompare"
        btCompare.Size = New Size(195, 44)
        btCompare.TabIndex = 21
        btCompare.Text = "Compare Dates"
        btCompare.UseVisualStyleBackColor = False
        ' 
        ' btFind
        ' 
        btFind.BackColor = Color.Black
        btFind.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        btFind.ForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        btFind.Location = New Point(964, 149)
        btFind.Margin = New Padding(4)
        btFind.Name = "btFind"
        btFind.Size = New Size(141, 44)
        btFind.TabIndex = 22
        btFind.Text = "Find"
        btFind.UseVisualStyleBackColor = False
        ' 
        ' ckMoonCycle
        ' 
        ckMoonCycle.AutoSize = True
        ckMoonCycle.BackColor = Color.Black
        ckMoonCycle.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ckMoonCycle.Location = New Point(849, 110)
        ckMoonCycle.Name = "ckMoonCycle"
        ckMoonCycle.Size = New Size(84, 29)
        ckMoonCycle.TabIndex = 23
        ckMoonCycle.Text = "Moon"
        ckMoonCycle.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.DimGray
        ClientSize = New Size(1200, 675)
        Controls.Add(ckMoonCycle)
        Controls.Add(btFind)
        Controls.Add(btCompare)
        Controls.Add(DateTimePicker2)
        Controls.Add(btAddEqualsLine)
        Controls.Add(ck2Week)
        Controls.Add(btInsertDate)
        Controls.Add(DateTimePicker1)
        Controls.Add(btUndoForward)
        Controls.Add(btUndoBack)
        Controls.Add(btMaximize)
        Controls.Add(btMinimize)
        Controls.Add(btClose)
        Controls.Add(lbTitle)
        Controls.Add(btFindCaret)
        Controls.Add(btEnd)
        Controls.Add(btTop)
        Controls.Add(btRestore)
        Controls.Add(lbSave)
        Controls.Add(btSave)
        Controls.Add(txtLog)
        Controls.Add(cbCopy)
        Controls.Add(txtDate)
        Controls.Add(btTimeStamp)
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "gLog"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Private Sub Form1_BackgroundImageLayoutChanged(sender As Object, e As EventArgs) Handles Me.BackgroundImageLayoutChanged

    End Sub

    Friend WithEvents btTimeStamp As Button
    Friend WithEvents txtDate As TextBox
    Friend WithEvents cbCopy As Button
    Friend WithEvents tmrDate As Timer
    Friend WithEvents txtLog As RichTextBox
    Friend WithEvents tmrRunOnce As Timer
    Friend WithEvents btSave As Button
    Friend WithEvents tmrSave As Timer
    Friend WithEvents lbSave As Label
    Friend WithEvents btRestore As Button
    Friend WithEvents btTop As Button
    Friend WithEvents btEnd As Button
    Friend WithEvents btFindCaret As Button
    Friend WithEvents lbTitle As Label
    Friend WithEvents btClose As Button
    Friend WithEvents btMinimize As Button
    Friend WithEvents btMaximize As Button
    Friend WithEvents btUndoBack As Button
    Friend WithEvents btUndoForward As Button
    Friend WithEvents tmrUndoListUpdate As Timer
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btInsertDate As Button
    Friend WithEvents ck2Week As CheckBox
    Friend WithEvents btAddEqualsLine As Button
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents btCompare As Button
    Friend WithEvents btFind As Button
    Friend WithEvents ckMoonCycle As CheckBox
End Class
