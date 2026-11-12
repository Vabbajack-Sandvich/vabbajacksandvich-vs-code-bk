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
        components = New ComponentModel.Container()
        btGetWindowsExplorerWindows = New Button()
        ListExplorerWindows = New ListBox()
        ckOnTop = New CheckBox()
        btCloseAllWindowsExplorerWindows = New Button()
        txtSelectedWindow = New TextBox()
        lbExplorerWindow = New Label()
        lbExplorerWindowOutput = New Label()
        tmrRefresh = New Timer(components)
        tmrStart = New Timer(components)
        bttxtSelectedWindowCopy = New Button()
        bttxtSelectedWindowClear = New Button()
        SuspendLayout()
        ' 
        ' btGetWindowsExplorerWindows
        ' 
        btGetWindowsExplorerWindows.FlatStyle = FlatStyle.Flat
        btGetWindowsExplorerWindows.Location = New Point(12, 12)
        btGetWindowsExplorerWindows.Name = "btGetWindowsExplorerWindows"
        btGetWindowsExplorerWindows.Size = New Size(280, 33)
        btGetWindowsExplorerWindows.TabIndex = 0
        btGetWindowsExplorerWindows.Text = "Get Windows Explorer Windows"
        btGetWindowsExplorerWindows.UseVisualStyleBackColor = True
        ' 
        ' ListExplorerWindows
        ' 
        ListExplorerWindows.BackColor = Color.Black
        ListExplorerWindows.ForeColor = Color.LimeGreen
        ListExplorerWindows.FormattingEnabled = True
        ListExplorerWindows.Location = New Point(12, 51)
        ListExplorerWindows.Name = "ListExplorerWindows"
        ListExplorerWindows.Size = New Size(852, 204)
        ListExplorerWindows.TabIndex = 1
        ' 
        ' ckOnTop
        ' 
        ckOnTop.AutoSize = True
        ckOnTop.Checked = True
        ckOnTop.CheckState = CheckState.Checked
        ckOnTop.Location = New Point(785, 12)
        ckOnTop.Name = "ckOnTop"
        ckOnTop.Size = New Size(79, 24)
        ckOnTop.TabIndex = 2
        ckOnTop.Text = "On Top"
        ckOnTop.UseVisualStyleBackColor = True
        ' 
        ' btCloseAllWindowsExplorerWindows
        ' 
        btCloseAllWindowsExplorerWindows.FlatStyle = FlatStyle.Flat
        btCloseAllWindowsExplorerWindows.Location = New Point(499, 7)
        btCloseAllWindowsExplorerWindows.Name = "btCloseAllWindowsExplorerWindows"
        btCloseAllWindowsExplorerWindows.Size = New Size(280, 33)
        btCloseAllWindowsExplorerWindows.TabIndex = 3
        btCloseAllWindowsExplorerWindows.Text = "Close All Windows Explorer Windows"
        btCloseAllWindowsExplorerWindows.UseVisualStyleBackColor = True
        ' 
        ' txtSelectedWindow
        ' 
        txtSelectedWindow.BackColor = Color.Black
        txtSelectedWindow.ForeColor = Color.LimeGreen
        txtSelectedWindow.Location = New Point(12, 297)
        txtSelectedWindow.Name = "txtSelectedWindow"
        txtSelectedWindow.Size = New Size(852, 27)
        txtSelectedWindow.TabIndex = 4
        ' 
        ' lbExplorerWindow
        ' 
        lbExplorerWindow.AutoSize = True
        lbExplorerWindow.Location = New Point(20, 264)
        lbExplorerWindow.Name = "lbExplorerWindow"
        lbExplorerWindow.Size = New Size(123, 20)
        lbExplorerWindow.TabIndex = 5
        lbExplorerWindow.Text = "Explorer Window"
        ' 
        ' lbExplorerWindowOutput
        ' 
        lbExplorerWindowOutput.AutoSize = True
        lbExplorerWindowOutput.Location = New Point(149, 264)
        lbExplorerWindowOutput.Name = "lbExplorerWindowOutput"
        lbExplorerWindowOutput.Size = New Size(165, 20)
        lbExplorerWindowOutput.TabIndex = 6
        lbExplorerWindowOutput.Text = "ExplorerWindowOutput"
        ' 
        ' tmrRefresh
        ' 
        tmrRefresh.Interval = 1000
        ' 
        ' tmrStart
        ' 
        tmrStart.Enabled = True
        tmrStart.Interval = 1000
        ' 
        ' bttxtSelectedWindowCopy
        ' 
        bttxtSelectedWindowCopy.FlatStyle = FlatStyle.Flat
        bttxtSelectedWindowCopy.Location = New Point(701, 261)
        bttxtSelectedWindowCopy.Name = "bttxtSelectedWindowCopy"
        bttxtSelectedWindowCopy.Size = New Size(78, 33)
        bttxtSelectedWindowCopy.TabIndex = 7
        bttxtSelectedWindowCopy.Text = "Copy"
        bttxtSelectedWindowCopy.UseVisualStyleBackColor = True
        ' 
        ' bttxtSelectedWindowClear
        ' 
        bttxtSelectedWindowClear.FlatStyle = FlatStyle.Flat
        bttxtSelectedWindowClear.Location = New Point(785, 261)
        bttxtSelectedWindowClear.Name = "bttxtSelectedWindowClear"
        bttxtSelectedWindowClear.Size = New Size(78, 33)
        bttxtSelectedWindowClear.TabIndex = 8
        bttxtSelectedWindowClear.Text = "Clear"
        bttxtSelectedWindowClear.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(875, 333)
        Controls.Add(bttxtSelectedWindowClear)
        Controls.Add(bttxtSelectedWindowCopy)
        Controls.Add(lbExplorerWindowOutput)
        Controls.Add(lbExplorerWindow)
        Controls.Add(txtSelectedWindow)
        Controls.Add(btCloseAllWindowsExplorerWindows)
        Controls.Add(ckOnTop)
        Controls.Add(ListExplorerWindows)
        Controls.Add(btGetWindowsExplorerWindows)
        ForeColor = Color.LimeGreen
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "zWindowList"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btGetWindowsExplorerWindows As Button
    Friend WithEvents ListExplorerWindows As ListBox
    Friend WithEvents ckOnTop As CheckBox
    Friend WithEvents btCloseAllWindowsExplorerWindows As Button
    Friend WithEvents txtSelectedWindow As TextBox
    Friend WithEvents lbExplorerWindow As Label
    Friend WithEvents lbExplorerWindowOutput As Label
    Friend WithEvents tmrRefresh As Timer
    Friend WithEvents tmrStart As Timer
    Friend WithEvents bttxtSelectedWindowCopy As Button
    Friend WithEvents bttxtSelectedWindowClear As Button

End Class
