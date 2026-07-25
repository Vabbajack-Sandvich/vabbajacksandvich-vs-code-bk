<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmzProcess
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
        components = New ComponentModel.Container()
        btGetProcesses = New Button()
        lstProcesses = New ListBox()
        lstPID = New ListBox()
        txtProcesses = New TextBox()
        txtPID = New TextBox()
        btKillProcessByPID = New Button()
        ckLazyKillTimer = New CheckBox()
        btLazyKillTest = New Button()
        tmrLazyKill = New Timer(components)
        txtLazyKillCounter = New TextBox()
        lstProcessKillList = New ListBox()
        lstKillTimeLog = New ListBox()
        lstServiceKillList = New ListBox()
        tmrTimeDate = New Timer(components)
        txtDateTime = New TextBox()
        ckNotepadTest = New CheckBox()
        cKmsedge = New CheckBox()
        cKmsedgewebview2 = New CheckBox()
        txtlstProcessOutput = New TextBox()
        LbSortedByProcessID = New Label()
        btPIDTextClear = New Button()
        tmrStart = New Timer(components)
        txtLstPIDOutputClear = New Button()
        txtLstPIDOutput = New TextBox()
        bttxtlstProcessOutputCopy = New Button()
        bttxtLstPIDOutputCopy = New Button()
        SuspendLayout()
        ' 
        ' btGetProcesses
        ' 
        btGetProcesses.BackColor = Color.Black
        btGetProcesses.ForeColor = Color.LimeGreen
        btGetProcesses.Location = New Point(12, 32)
        btGetProcesses.Name = "btGetProcesses"
        btGetProcesses.Size = New Size(193, 33)
        btGetProcesses.TabIndex = 0
        btGetProcesses.Text = "Get Processes"
        btGetProcesses.UseVisualStyleBackColor = False
        ' 
        ' lstProcesses
        ' 
        lstProcesses.BackColor = Color.Black
        lstProcesses.ForeColor = Color.LimeGreen
        lstProcesses.FormattingEnabled = True
        lstProcesses.Location = New Point(214, 32)
        lstProcesses.Name = "lstProcesses"
        lstProcesses.Size = New Size(379, 164)
        lstProcesses.TabIndex = 1
        ' 
        ' lstPID
        ' 
        lstPID.BackColor = Color.Black
        lstPID.ForeColor = Color.LimeGreen
        lstPID.FormattingEnabled = True
        lstPID.Location = New Point(799, 32)
        lstPID.Name = "lstPID"
        lstPID.Size = New Size(146, 164)
        lstPID.TabIndex = 2
        ' 
        ' txtProcesses
        ' 
        txtProcesses.BackColor = Color.Black
        txtProcesses.ForeColor = Color.LimeGreen
        txtProcesses.Location = New Point(214, 202)
        txtProcesses.Name = "txtProcesses"
        txtProcesses.Size = New Size(379, 27)
        txtProcesses.TabIndex = 3
        ' 
        ' txtPID
        ' 
        txtPID.BackColor = Color.Black
        txtPID.ForeColor = Color.LimeGreen
        txtPID.Location = New Point(799, 202)
        txtPID.Name = "txtPID"
        txtPID.Size = New Size(146, 27)
        txtPID.TabIndex = 4
        ' 
        ' btKillProcessByPID
        ' 
        btKillProcessByPID.BackColor = Color.Black
        btKillProcessByPID.ForeColor = Color.LimeGreen
        btKillProcessByPID.Location = New Point(12, 71)
        btKillProcessByPID.Name = "btKillProcessByPID"
        btKillProcessByPID.Size = New Size(193, 33)
        btKillProcessByPID.TabIndex = 5
        btKillProcessByPID.Text = "Kill Process By PID"
        btKillProcessByPID.UseVisualStyleBackColor = False
        ' 
        ' ckLazyKillTimer
        ' 
        ckLazyKillTimer.AutoSize = True
        ckLazyKillTimer.BackColor = Color.Black
        ckLazyKillTimer.ForeColor = Color.LimeGreen
        ckLazyKillTimer.Location = New Point(29, 149)
        ckLazyKillTimer.Name = "ckLazyKillTimer"
        ckLazyKillTimer.Size = New Size(127, 24)
        ckLazyKillTimer.TabIndex = 6
        ckLazyKillTimer.Text = "Lazy Kill Timer"
        ckLazyKillTimer.UseVisualStyleBackColor = False
        ' 
        ' btLazyKillTest
        ' 
        btLazyKillTest.BackColor = Color.Black
        btLazyKillTest.ForeColor = Color.LimeGreen
        btLazyKillTest.Location = New Point(12, 110)
        btLazyKillTest.Name = "btLazyKillTest"
        btLazyKillTest.Size = New Size(193, 33)
        btLazyKillTest.TabIndex = 7
        btLazyKillTest.Text = "Lazy Kill Test"
        btLazyKillTest.UseVisualStyleBackColor = False
        ' 
        ' tmrLazyKill
        ' 
        tmrLazyKill.Interval = 500
        ' 
        ' txtLazyKillCounter
        ' 
        txtLazyKillCounter.BackColor = Color.Black
        txtLazyKillCounter.ForeColor = Color.LimeGreen
        txtLazyKillCounter.Location = New Point(679, 255)
        txtLazyKillCounter.Name = "txtLazyKillCounter"
        txtLazyKillCounter.Size = New Size(66, 27)
        txtLazyKillCounter.TabIndex = 8
        txtLazyKillCounter.Text = "0"
        ' 
        ' lstProcessKillList
        ' 
        lstProcessKillList.BackColor = Color.Black
        lstProcessKillList.ForeColor = Color.LimeGreen
        lstProcessKillList.FormattingEnabled = True
        lstProcessKillList.Location = New Point(12, 298)
        lstProcessKillList.Name = "lstProcessKillList"
        lstProcessKillList.Size = New Size(275, 104)
        lstProcessKillList.TabIndex = 9
        ' 
        ' lstKillTimeLog
        ' 
        lstKillTimeLog.BackColor = Color.Black
        lstKillTimeLog.ForeColor = Color.LimeGreen
        lstKillTimeLog.FormattingEnabled = True
        lstKillTimeLog.Location = New Point(305, 288)
        lstKillTimeLog.Name = "lstKillTimeLog"
        lstKillTimeLog.Size = New Size(440, 244)
        lstKillTimeLog.TabIndex = 10
        ' 
        ' lstServiceKillList
        ' 
        lstServiceKillList.BackColor = Color.Black
        lstServiceKillList.ForeColor = Color.LimeGreen
        lstServiceKillList.FormattingEnabled = True
        lstServiceKillList.Location = New Point(12, 408)
        lstServiceKillList.Name = "lstServiceKillList"
        lstServiceKillList.Size = New Size(275, 124)
        lstServiceKillList.TabIndex = 11
        ' 
        ' tmrTimeDate
        ' 
        tmrTimeDate.Interval = 1000
        ' 
        ' txtDateTime
        ' 
        txtDateTime.BackColor = Color.Black
        txtDateTime.ForeColor = Color.LimeGreen
        txtDateTime.Location = New Point(305, 255)
        txtDateTime.Name = "txtDateTime"
        txtDateTime.Size = New Size(368, 27)
        txtDateTime.TabIndex = 12
        ' 
        ' ckNotepadTest
        ' 
        ckNotepadTest.AutoSize = True
        ckNotepadTest.Location = New Point(29, 239)
        ckNotepadTest.Name = "ckNotepadTest"
        ckNotepadTest.Size = New Size(120, 24)
        ckNotepadTest.TabIndex = 13
        ckNotepadTest.Text = "Notepad Test"
        ckNotepadTest.UseVisualStyleBackColor = True
        ' 
        ' cKmsedge
        ' 
        cKmsedge.AutoSize = True
        cKmsedge.Location = New Point(29, 179)
        cKmsedge.Name = "cKmsedge"
        cKmsedge.Size = New Size(110, 24)
        cKmsedge.TabIndex = 14
        cKmsedge.Text = "msedge.exe"
        cKmsedge.UseVisualStyleBackColor = True
        ' 
        ' cKmsedgewebview2
        ' 
        cKmsedgewebview2.AutoSize = True
        cKmsedgewebview2.Location = New Point(29, 209)
        cKmsedgewebview2.Name = "cKmsedgewebview2"
        cKmsedgewebview2.Size = New Size(176, 24)
        cKmsedgewebview2.TabIndex = 15
        cKmsedgewebview2.Text = "msedgewebview2.exe"
        cKmsedgewebview2.UseVisualStyleBackColor = True
        ' 
        ' txtlstProcessOutput
        ' 
        txtlstProcessOutput.BackColor = Color.Black
        txtlstProcessOutput.ForeColor = Color.LimeGreen
        txtlstProcessOutput.Location = New Point(599, 35)
        txtlstProcessOutput.Multiline = True
        txtlstProcessOutput.Name = "txtlstProcessOutput"
        txtlstProcessOutput.Size = New Size(194, 161)
        txtlstProcessOutput.TabIndex = 16
        ' 
        ' LbSortedByProcessID
        ' 
        LbSortedByProcessID.AutoSize = True
        LbSortedByProcessID.Location = New Point(513, 9)
        LbSortedByProcessID.Name = "LbSortedByProcessID"
        LbSortedByProcessID.Size = New Size(145, 20)
        LbSortedByProcessID.TabIndex = 17
        LbSortedByProcessID.Text = "Sorted By Process ID"
        ' 
        ' btPIDTextClear
        ' 
        btPIDTextClear.BackColor = Color.Black
        btPIDTextClear.ForeColor = Color.LimeGreen
        btPIDTextClear.Location = New Point(746, 202)
        btPIDTextClear.Name = "btPIDTextClear"
        btPIDTextClear.Size = New Size(47, 33)
        btPIDTextClear.TabIndex = 18
        btPIDTextClear.Text = "X"
        btPIDTextClear.UseVisualStyleBackColor = False
        ' 
        ' tmrStart
        ' 
        tmrStart.Enabled = True
        tmrStart.Interval = 1000
        ' 
        ' txtLstPIDOutputClear
        ' 
        txtLstPIDOutputClear.BackColor = Color.Black
        txtLstPIDOutputClear.ForeColor = Color.LimeGreen
        txtLstPIDOutputClear.Location = New Point(1051, 196)
        txtLstPIDOutputClear.Name = "txtLstPIDOutputClear"
        txtLstPIDOutputClear.Size = New Size(47, 33)
        txtLstPIDOutputClear.TabIndex = 20
        txtLstPIDOutputClear.Text = "X"
        txtLstPIDOutputClear.UseVisualStyleBackColor = False
        ' 
        ' txtLstPIDOutput
        ' 
        txtLstPIDOutput.BackColor = Color.Black
        txtLstPIDOutput.ForeColor = Color.LimeGreen
        txtLstPIDOutput.Location = New Point(951, 32)
        txtLstPIDOutput.Multiline = True
        txtLstPIDOutput.Name = "txtLstPIDOutput"
        txtLstPIDOutput.Size = New Size(147, 161)
        txtLstPIDOutput.TabIndex = 19
        ' 
        ' bttxtlstProcessOutputCopy
        ' 
        bttxtlstProcessOutputCopy.BackColor = Color.Black
        bttxtlstProcessOutputCopy.ForeColor = Color.LimeGreen
        bttxtlstProcessOutputCopy.Location = New Point(666, 202)
        bttxtlstProcessOutputCopy.Name = "bttxtlstProcessOutputCopy"
        bttxtlstProcessOutputCopy.Size = New Size(74, 33)
        bttxtlstProcessOutputCopy.TabIndex = 21
        bttxtlstProcessOutputCopy.Text = "Copy"
        bttxtlstProcessOutputCopy.UseVisualStyleBackColor = False
        ' 
        ' bttxtLstPIDOutputCopy
        ' 
        bttxtLstPIDOutputCopy.BackColor = Color.Black
        bttxtLstPIDOutputCopy.ForeColor = Color.LimeGreen
        bttxtLstPIDOutputCopy.Location = New Point(971, 196)
        bttxtLstPIDOutputCopy.Name = "bttxtLstPIDOutputCopy"
        bttxtLstPIDOutputCopy.Size = New Size(74, 33)
        bttxtLstPIDOutputCopy.TabIndex = 22
        bttxtLstPIDOutputCopy.Text = "Copy"
        bttxtLstPIDOutputCopy.UseVisualStyleBackColor = False
        ' 
        ' frmzProcess
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(1108, 544)
        Controls.Add(bttxtLstPIDOutputCopy)
        Controls.Add(bttxtlstProcessOutputCopy)
        Controls.Add(txtLstPIDOutputClear)
        Controls.Add(txtLstPIDOutput)
        Controls.Add(btPIDTextClear)
        Controls.Add(LbSortedByProcessID)
        Controls.Add(txtlstProcessOutput)
        Controls.Add(cKmsedgewebview2)
        Controls.Add(cKmsedge)
        Controls.Add(ckNotepadTest)
        Controls.Add(txtDateTime)
        Controls.Add(lstServiceKillList)
        Controls.Add(lstKillTimeLog)
        Controls.Add(lstProcessKillList)
        Controls.Add(txtLazyKillCounter)
        Controls.Add(btLazyKillTest)
        Controls.Add(ckLazyKillTimer)
        Controls.Add(btKillProcessByPID)
        Controls.Add(txtPID)
        Controls.Add(txtProcesses)
        Controls.Add(lstPID)
        Controls.Add(lstProcesses)
        Controls.Add(btGetProcesses)
        ForeColor = Color.LimeGreen
        MaximizeBox = False
        Name = "frmzProcess"
        StartPosition = FormStartPosition.CenterScreen
        Text = "zProcess - Dak-toh, are you sure this will work¿!?¡"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btGetProcesses As Button
    Friend WithEvents lstProcesses As ListBox
    Friend WithEvents lstPID As ListBox
    Friend WithEvents txtProcesses As TextBox
    Friend WithEvents txtPID As TextBox
    Friend WithEvents btKillProcessByPID As Button
    Friend WithEvents ckLazyKillTimer As CheckBox
    Friend WithEvents btLazyKillTest As Button
    Friend WithEvents tmrLazyKill As Timer
    Friend WithEvents txtLazyKillCounter As TextBox
    Friend WithEvents lstProcessKillList As ListBox
    Friend WithEvents lstKillTimeLog As ListBox
    Friend WithEvents lstServiceKillList As ListBox
    Friend WithEvents tmrTimeDate As Timer
    Friend WithEvents txtDateTime As TextBox
    Friend WithEvents ckNotepadTest As CheckBox
    Friend WithEvents cKmsedge As CheckBox
    Friend WithEvents cKmsedgewebview2 As CheckBox
    Friend WithEvents txtlstProcessOutput As TextBox
    Friend WithEvents LbSortedByProcessID As Label
    Friend WithEvents btPIDTextClear As Button
    Friend WithEvents tmrStart As Timer
    Friend WithEvents txtLstPIDOutputClear As Button
    Friend WithEvents txtLstPIDOutput As TextBox
    Friend WithEvents bttxtlstProcessOutputCopy As Button
    Friend WithEvents bttxtLstPIDOutputCopy As Button

End Class
