<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SDTForm1
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
        ShutdownTimer1 = New Timer(components)
        lbvStatus = New Label()
        lbvStatusOnOff = New Label()
        btToggle = New Button()
        lbCounter = New Label()
        lbzTc = New Label()
        btReset = New Button()
        btSet = New Button()
        txtSet = New TextBox()
        btConvert = New Button()
        txtHours = New TextBox()
        txtMin = New TextBox()
        txtSec = New TextBox()
        lbHours = New Label()
        lbMin = New Label()
        lbSec = New Label()
        lbRemaining = New Label()
        lbTotalHMS = New Label()
        lbElapsed = New Label()
        lbTotalSec = New Label()
        ckCloseVLC = New CheckBox()
        ckShutdown = New CheckBox()
        btMin = New Button()
        btClose = New Button()
        ckDarkMode = New CheckBox()
        ckCloseMPC = New CheckBox()
        SuspendLayout()
        ' 
        ' ShutdownTimer1
        ' 
        ShutdownTimer1.Interval = 1000
        ' 
        ' lbvStatus
        ' 
        lbvStatus.AutoEllipsis = True
        lbvStatus.AutoSize = True
        lbvStatus.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lbvStatus.Location = New Point(12, 9)
        lbvStatus.Name = "lbvStatus"
        lbvStatus.Size = New Size(63, 20)
        lbvStatus.TabIndex = 0
        lbvStatus.Text = "Status -"
        ' 
        ' lbvStatusOnOff
        ' 
        lbvStatusOnOff.AutoSize = True
        lbvStatusOnOff.BackColor = Color.Red
        lbvStatusOnOff.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lbvStatusOnOff.Location = New Point(111, 9)
        lbvStatusOnOff.Name = "lbvStatusOnOff"
        lbvStatusOnOff.Size = New Size(32, 20)
        lbvStatusOnOff.TabIndex = 1
        lbvStatusOnOff.Text = "Off"
        ' 
        ' btToggle
        ' 
        btToggle.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btToggle.Location = New Point(10, 155)
        btToggle.Name = "btToggle"
        btToggle.Size = New Size(79, 40)
        btToggle.TabIndex = 2
        btToggle.Text = "Toggle"
        btToggle.UseVisualStyleBackColor = True
        ' 
        ' lbCounter
        ' 
        lbCounter.AutoSize = True
        lbCounter.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lbCounter.Location = New Point(12, 29)
        lbCounter.Name = "lbCounter"
        lbCounter.Size = New Size(79, 20)
        lbCounter.TabIndex = 3
        lbCounter.Text = "Counter - "
        ' 
        ' lbzTc
        ' 
        lbzTc.AutoSize = True
        lbzTc.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lbzTc.Location = New Point(111, 29)
        lbzTc.Name = "lbzTc"
        lbzTc.Size = New Size(18, 20)
        lbzTc.TabIndex = 4
        lbzTc.Text = "0"
        ' 
        ' btReset
        ' 
        btReset.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btReset.Location = New Point(95, 155)
        btReset.Name = "btReset"
        btReset.Size = New Size(75, 40)
        btReset.TabIndex = 5
        btReset.Text = "Reset"
        btReset.UseVisualStyleBackColor = True
        ' 
        ' btSet
        ' 
        btSet.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btSet.Location = New Point(176, 155)
        btSet.Name = "btSet"
        btSet.Size = New Size(75, 40)
        btSet.TabIndex = 6
        btSet.Text = "Set"
        btSet.UseVisualStyleBackColor = True
        ' 
        ' txtSet
        ' 
        txtSet.Location = New Point(257, 162)
        txtSet.Name = "txtSet"
        txtSet.Size = New Size(65, 27)
        txtSet.TabIndex = 7
        txtSet.Text = "0"
        ' 
        ' btConvert
        ' 
        btConvert.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btConvert.Location = New Point(176, 212)
        btConvert.Name = "btConvert"
        btConvert.Size = New Size(79, 40)
        btConvert.TabIndex = 8
        btConvert.Text = "Convert"
        btConvert.UseVisualStyleBackColor = True
        ' 
        ' txtHours
        ' 
        txtHours.Location = New Point(10, 219)
        txtHours.Margin = New Padding(2, 2, 2, 2)
        txtHours.Name = "txtHours"
        txtHours.Size = New Size(51, 27)
        txtHours.TabIndex = 9
        txtHours.Text = "1"
        ' 
        ' txtMin
        ' 
        txtMin.Location = New Point(65, 219)
        txtMin.Margin = New Padding(2, 2, 2, 2)
        txtMin.Name = "txtMin"
        txtMin.Size = New Size(51, 27)
        txtMin.TabIndex = 10
        txtMin.Text = "0"
        ' 
        ' txtSec
        ' 
        txtSec.Location = New Point(120, 219)
        txtSec.Margin = New Padding(2, 2, 2, 2)
        txtSec.Name = "txtSec"
        txtSec.Size = New Size(51, 27)
        txtSec.TabIndex = 11
        txtSec.Text = "0"
        ' 
        ' lbHours
        ' 
        lbHours.AutoSize = True
        lbHours.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lbHours.Location = New Point(10, 199)
        lbHours.Name = "lbHours"
        lbHours.Size = New Size(51, 20)
        lbHours.TabIndex = 12
        lbHours.Text = "Hours"
        ' 
        ' lbMin
        ' 
        lbMin.AutoSize = True
        lbMin.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lbMin.Location = New Point(65, 199)
        lbMin.Name = "lbMin"
        lbMin.Size = New Size(36, 20)
        lbMin.TabIndex = 13
        lbMin.Text = "Min"
        ' 
        ' lbSec
        ' 
        lbSec.AutoSize = True
        lbSec.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lbSec.Location = New Point(120, 199)
        lbSec.Name = "lbSec"
        lbSec.Size = New Size(32, 20)
        lbSec.TabIndex = 14
        lbSec.Text = "Sec"
        ' 
        ' lbRemaining
        ' 
        lbRemaining.AutoSize = True
        lbRemaining.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lbRemaining.Location = New Point(12, 99)
        lbRemaining.Name = "lbRemaining"
        lbRemaining.Size = New Size(167, 20)
        lbRemaining.TabIndex = 15
        lbRemaining.Text = "Remaining - 1h-0m-0s"
        ' 
        ' lbTotalHMS
        ' 
        lbTotalHMS.AutoSize = True
        lbTotalHMS.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lbTotalHMS.Location = New Point(12, 53)
        lbTotalHMS.Name = "lbTotalHMS"
        lbTotalHMS.Size = New Size(127, 20)
        lbTotalHMS.TabIndex = 16
        lbTotalHMS.Text = "Total - 1h-0m-0s"
        ' 
        ' lbElapsed
        ' 
        lbElapsed.AutoSize = True
        lbElapsed.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lbElapsed.Location = New Point(12, 124)
        lbElapsed.Name = "lbElapsed"
        lbElapsed.Size = New Size(145, 20)
        lbElapsed.TabIndex = 17
        lbElapsed.Text = "Elapsed - 0h-0m-0s"
        ' 
        ' lbTotalSec
        ' 
        lbTotalSec.AutoSize = True
        lbTotalSec.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lbTotalSec.Location = New Point(12, 76)
        lbTotalSec.Name = "lbTotalSec"
        lbTotalSec.Size = New Size(155, 20)
        lbTotalSec.TabIndex = 18
        lbTotalSec.Text = "Total Seconds - 3600"
        ' 
        ' ckCloseVLC
        ' 
        ckCloseVLC.AutoSize = True
        ckCloseVLC.Checked = True
        ckCloseVLC.CheckState = CheckState.Checked
        ckCloseVLC.Location = New Point(10, 261)
        ckCloseVLC.Margin = New Padding(2, 2, 2, 2)
        ckCloseVLC.Name = "ckCloseVLC"
        ckCloseVLC.Size = New Size(95, 24)
        ckCloseVLC.TabIndex = 19
        ckCloseVLC.Text = "Close VLC"
        ckCloseVLC.UseVisualStyleBackColor = True
        ' 
        ' ckShutdown
        ' 
        ckShutdown.AutoSize = True
        ckShutdown.Checked = True
        ckShutdown.CheckState = CheckState.Checked
        ckShutdown.Location = New Point(10, 301)
        ckShutdown.Margin = New Padding(2, 2, 2, 2)
        ckShutdown.Name = "ckShutdown"
        ckShutdown.Size = New Size(97, 24)
        ckShutdown.TabIndex = 20
        ckShutdown.Text = "Shutdown"
        ckShutdown.UseVisualStyleBackColor = True
        ' 
        ' btMin
        ' 
        btMin.Location = New Point(231, 36)
        btMin.Margin = New Padding(2, 2, 2, 2)
        btMin.Name = "btMin"
        btMin.Size = New Size(39, 29)
        btMin.TabIndex = 21
        btMin.Text = "__"
        btMin.UseVisualStyleBackColor = True
        ' 
        ' btClose
        ' 
        btClose.Location = New Point(282, 36)
        btClose.Margin = New Padding(2, 2, 2, 2)
        btClose.Name = "btClose"
        btClose.Size = New Size(39, 29)
        btClose.TabIndex = 22
        btClose.Text = "X"
        btClose.UseVisualStyleBackColor = True
        ' 
        ' ckDarkMode
        ' 
        ckDarkMode.AutoSize = True
        ckDarkMode.Location = New Point(231, 9)
        ckDarkMode.Margin = New Padding(2, 2, 2, 2)
        ckDarkMode.Name = "ckDarkMode"
        ckDarkMode.Size = New Size(105, 24)
        ckDarkMode.TabIndex = 23
        ckDarkMode.Text = "Dark Mode"
        ckDarkMode.UseVisualStyleBackColor = True
        ' 
        ' ckCloseMPC
        ' 
        ckCloseMPC.AutoSize = True
        ckCloseMPC.Checked = True
        ckCloseMPC.CheckState = CheckState.Checked
        ckCloseMPC.Location = New Point(120, 261)
        ckCloseMPC.Margin = New Padding(2)
        ckCloseMPC.Name = "ckCloseMPC"
        ckCloseMPC.Size = New Size(101, 24)
        ckCloseMPC.TabIndex = 24
        ckCloseMPC.Text = "Close MPC"
        ckCloseMPC.UseVisualStyleBackColor = True
        ' 
        ' SDTForm1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(331, 337)
        Controls.Add(ckCloseMPC)
        Controls.Add(ckDarkMode)
        Controls.Add(btClose)
        Controls.Add(btMin)
        Controls.Add(ckShutdown)
        Controls.Add(ckCloseVLC)
        Controls.Add(lbTotalSec)
        Controls.Add(lbElapsed)
        Controls.Add(lbTotalHMS)
        Controls.Add(lbRemaining)
        Controls.Add(lbSec)
        Controls.Add(lbMin)
        Controls.Add(lbHours)
        Controls.Add(txtSec)
        Controls.Add(txtMin)
        Controls.Add(txtHours)
        Controls.Add(btConvert)
        Controls.Add(txtSet)
        Controls.Add(btSet)
        Controls.Add(btReset)
        Controls.Add(lbzTc)
        Controls.Add(lbCounter)
        Controls.Add(btToggle)
        Controls.Add(lbvStatusOnOff)
        Controls.Add(lbvStatus)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "SDTForm1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "zTimer"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ShutdownTimer1 As Timer
    Friend WithEvents lbvStatus As Label
    Friend WithEvents lbvStatusOnOff As Label
    Friend WithEvents btToggle As Button
    Friend WithEvents lbCounter As Label
    Friend WithEvents lbzTc As Label
    Friend WithEvents btReset As Button
    Friend WithEvents btSet As Button
    Friend WithEvents txtSet As TextBox
    Friend WithEvents btConvert As Button
    Friend WithEvents txtHours As TextBox
    Friend WithEvents txtMin As TextBox
    Friend WithEvents txtSec As TextBox
    Friend WithEvents lbHours As Label
    Friend WithEvents lbMin As Label
    Friend WithEvents lbSec As Label
    Friend WithEvents lbRemaining As Label
    Friend WithEvents lbTotalHMS As Label
    Friend WithEvents lbElapsed As Label
    Friend WithEvents lbTotalSec As Label
    Friend WithEvents ckCloseVLC As CheckBox
    Friend WithEvents ckShutdown As CheckBox
    Friend WithEvents btMin As Button
    Friend WithEvents btClose As Button
    Friend WithEvents ckDarkMode As CheckBox
    Friend WithEvents ckCloseMPC As CheckBox
End Class
