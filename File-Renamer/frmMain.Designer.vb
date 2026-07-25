<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        btListDir = New Button()
        listDirectories = New ListBox()
        txtPath = New TextBox()
        lbPath = New Label()
        btListFiles = New Button()
        listFiles = New ListBox()
        lbHistory = New Label()
        listHist = New ListBox()
        lbDirectories = New Label()
        lbFiles = New Label()
        btClearHistory = New Button()
        btAddExt = New Button()
        txtExt = New TextBox()
        txtTrim = New TextBox()
        btTrim = New Button()
        tmRefresh = New Timer(components)
        lbFn = New Label()
        lbDirName = New Label()
        lbSubDCount = New Label()
        lbSubD1 = New Label()
        listSubD1 = New ListBox()
        ckSubDExt = New CheckBox()
        ckTrim = New CheckBox()
        btSubD = New Button()
        ckMsg = New CheckBox()
        btClearSub = New Button()
        txtReplace = New TextBox()
        btReplace = New Button()
        lbMatch = New Label()
        txtMatch = New TextBox()
        lbReplace = New Label()
        ckReplace = New CheckBox()
        ckOnTop = New CheckBox()
        SuspendLayout()
        ' 
        ' btListDir
        ' 
        btListDir.Font = New Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point)
        btListDir.Location = New Point(869, 41)
        btListDir.Name = "btListDir"
        btListDir.Size = New Size(178, 31)
        btListDir.TabIndex = 5
        btListDir.Text = "List Directories"
        btListDir.UseVisualStyleBackColor = True
        ' 
        ' listDirectories
        ' 
        listDirectories.FormattingEnabled = True
        listDirectories.ItemHeight = 25
        listDirectories.Location = New Point(12, 240)
        listDirectories.Name = "listDirectories"
        listDirectories.Size = New Size(839, 104)
        listDirectories.TabIndex = 2
        ' 
        ' txtPath
        ' 
        txtPath.Location = New Point(12, 41)
        txtPath.Name = "txtPath"
        txtPath.Size = New Size(839, 31)
        txtPath.TabIndex = 0
        txtPath.Text = "C:\"
        ' 
        ' lbPath
        ' 
        lbPath.AutoSize = True
        lbPath.Location = New Point(14, 12)
        lbPath.Name = "lbPath"
        lbPath.Size = New Size(46, 25)
        lbPath.TabIndex = 3
        lbPath.Text = "Path"
        ' 
        ' btListFiles
        ' 
        btListFiles.Font = New Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point)
        btListFiles.Location = New Point(869, 75)
        btListFiles.Name = "btListFiles"
        btListFiles.Size = New Size(178, 31)
        btListFiles.TabIndex = 6
        btListFiles.Text = "List Files"
        btListFiles.UseVisualStyleBackColor = True
        ' 
        ' listFiles
        ' 
        listFiles.FormattingEnabled = True
        listFiles.ItemHeight = 25
        listFiles.Location = New Point(12, 372)
        listFiles.Name = "listFiles"
        listFiles.Size = New Size(839, 104)
        listFiles.TabIndex = 3
        ' 
        ' lbHistory
        ' 
        lbHistory.AutoSize = True
        lbHistory.Font = New Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point)
        lbHistory.Location = New Point(14, 75)
        lbHistory.Name = "lbHistory"
        lbHistory.Size = New Size(53, 19)
        lbHistory.TabIndex = 6
        lbHistory.Text = "History"
        ' 
        ' listHist
        ' 
        listHist.FormattingEnabled = True
        listHist.ItemHeight = 25
        listHist.Location = New Point(12, 103)
        listHist.Name = "listHist"
        listHist.Size = New Size(839, 104)
        listHist.TabIndex = 1
        ' 
        ' lbDirectories
        ' 
        lbDirectories.AutoSize = True
        lbDirectories.Font = New Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point)
        lbDirectories.Location = New Point(14, 212)
        lbDirectories.Name = "lbDirectories"
        lbDirectories.Size = New Size(74, 19)
        lbDirectories.TabIndex = 8
        lbDirectories.Text = "Directories"
        ' 
        ' lbFiles
        ' 
        lbFiles.AutoSize = True
        lbFiles.Font = New Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point)
        lbFiles.Location = New Point(12, 344)
        lbFiles.Name = "lbFiles"
        lbFiles.Size = New Size(35, 19)
        lbFiles.TabIndex = 9
        lbFiles.Text = "Files"
        ' 
        ' btClearHistory
        ' 
        btClearHistory.Font = New Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point)
        btClearHistory.Location = New Point(869, 112)
        btClearHistory.Name = "btClearHistory"
        btClearHistory.Size = New Size(178, 31)
        btClearHistory.TabIndex = 7
        btClearHistory.Text = "Clear History"
        btClearHistory.UseVisualStyleBackColor = True
        ' 
        ' btAddExt
        ' 
        btAddExt.Font = New Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point)
        btAddExt.Location = New Point(869, 186)
        btAddExt.Name = "btAddExt"
        btAddExt.Size = New Size(178, 31)
        btAddExt.TabIndex = 9
        btAddExt.Text = "Add Extention"
        btAddExt.UseVisualStyleBackColor = True
        ' 
        ' txtExt
        ' 
        txtExt.Location = New Point(869, 149)
        txtExt.Name = "txtExt"
        txtExt.Size = New Size(178, 31)
        txtExt.TabIndex = 8
        txtExt.Text = ".mp4"
        ' 
        ' txtTrim
        ' 
        txtTrim.Location = New Point(869, 223)
        txtTrim.Name = "txtTrim"
        txtTrim.Size = New Size(178, 31)
        txtTrim.TabIndex = 10
        txtTrim.Text = " English Dubbed"
        ' 
        ' btTrim
        ' 
        btTrim.Font = New Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point)
        btTrim.Location = New Point(869, 260)
        btTrim.Name = "btTrim"
        btTrim.Size = New Size(178, 31)
        btTrim.TabIndex = 11
        btTrim.Text = "Trim"
        btTrim.UseVisualStyleBackColor = True
        ' 
        ' tmRefresh
        ' 
        tmRefresh.Interval = 2000
        ' 
        ' lbFn
        ' 
        lbFn.AutoSize = True
        lbFn.Font = New Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point)
        lbFn.Location = New Point(53, 344)
        lbFn.Name = "lbFn"
        lbFn.Size = New Size(65, 19)
        lbFn.TabIndex = 15
        lbFn.Text = "FileName"
        ' 
        ' lbDirName
        ' 
        lbDirName.AutoSize = True
        lbDirName.Font = New Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point)
        lbDirName.Location = New Point(94, 212)
        lbDirName.Name = "lbDirName"
        lbDirName.Size = New Size(105, 19)
        lbDirName.TabIndex = 16
        lbDirName.Text = "Directory Name"
        ' 
        ' lbSubDCount
        ' 
        lbSubDCount.AutoSize = True
        lbSubDCount.Font = New Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point)
        lbSubDCount.Location = New Point(121, 479)
        lbSubDCount.Name = "lbSubDCount"
        lbSubDCount.Size = New Size(134, 19)
        lbSubDCount.TabIndex = 19
        lbSubDCount.Text = "Sub Directory Count"
        ' 
        ' lbSubD1
        ' 
        lbSubD1.AutoSize = True
        lbSubD1.Font = New Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point)
        lbSubD1.Location = New Point(14, 480)
        lbSubD1.Name = "lbSubD1"
        lbSubD1.Size = New Size(101, 19)
        lbSubD1.TabIndex = 18
        lbSubD1.Text = "Sub Directories"
        ' 
        ' listSubD1
        ' 
        listSubD1.FormattingEnabled = True
        listSubD1.ItemHeight = 25
        listSubD1.Location = New Point(14, 508)
        listSubD1.Name = "listSubD1"
        listSubD1.Size = New Size(837, 104)
        listSubD1.TabIndex = 4
        ' 
        ' ckSubDExt
        ' 
        ckSubDExt.AutoSize = True
        ckSubDExt.Font = New Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point)
        ckSubDExt.Location = New Point(952, 458)
        ckSubDExt.Name = "ckSubDExt"
        ckSubDExt.Size = New Size(88, 23)
        ckSubDExt.TabIndex = 16
        ckSubDExt.Text = "Extention"
        ckSubDExt.UseVisualStyleBackColor = True
        ' 
        ' ckTrim
        ' 
        ckTrim.AutoSize = True
        ckTrim.Enabled = False
        ckTrim.Font = New Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point)
        ckTrim.Location = New Point(784, 482)
        ckTrim.Name = "ckTrim"
        ckTrim.Size = New Size(57, 23)
        ckTrim.TabIndex = 15
        ckTrim.Text = "Trim"
        ckTrim.UseVisualStyleBackColor = True
        ckTrim.Visible = False
        ' 
        ' btSubD
        ' 
        btSubD.Font = New Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point)
        btSubD.Location = New Point(866, 528)
        btSubD.Name = "btSubD"
        btSubD.Size = New Size(178, 31)
        btSubD.TabIndex = 18
        btSubD.Text = "Sub Directories"
        btSubD.UseVisualStyleBackColor = True
        ' 
        ' ckMsg
        ' 
        ckMsg.AutoSize = True
        ckMsg.Checked = True
        ckMsg.CheckState = CheckState.Checked
        ckMsg.Font = New Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point)
        ckMsg.Location = New Point(869, 493)
        ckMsg.Name = "ckMsg"
        ckMsg.Size = New Size(91, 23)
        ckMsg.TabIndex = 17
        ckMsg.Text = "Messages"
        ckMsg.UseVisualStyleBackColor = True
        ' 
        ' btClearSub
        ' 
        btClearSub.Font = New Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point)
        btClearSub.Location = New Point(866, 565)
        btClearSub.Name = "btClearSub"
        btClearSub.Size = New Size(178, 31)
        btClearSub.TabIndex = 19
        btClearSub.Text = "Clear Sub Dir List"
        btClearSub.UseVisualStyleBackColor = True
        ' 
        ' txtReplace
        ' 
        txtReplace.Location = New Point(869, 384)
        txtReplace.Name = "txtReplace"
        txtReplace.Size = New Size(178, 31)
        txtReplace.TabIndex = 13
        txtReplace.Text = "Replace"
        ' 
        ' btReplace
        ' 
        btReplace.Font = New Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point)
        btReplace.Location = New Point(869, 421)
        btReplace.Name = "btReplace"
        btReplace.Size = New Size(178, 31)
        btReplace.TabIndex = 14
        btReplace.Text = "Replace"
        btReplace.UseVisualStyleBackColor = True
        ' 
        ' lbMatch
        ' 
        lbMatch.AutoSize = True
        lbMatch.Font = New Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point)
        lbMatch.Location = New Point(866, 294)
        lbMatch.Name = "lbMatch"
        lbMatch.Size = New Size(48, 19)
        lbMatch.TabIndex = 28
        lbMatch.Text = "Match"
        ' 
        ' txtMatch
        ' 
        txtMatch.Location = New Point(869, 322)
        txtMatch.Name = "txtMatch"
        txtMatch.Size = New Size(178, 31)
        txtMatch.TabIndex = 12
        txtMatch.Text = "Match"
        ' 
        ' lbReplace
        ' 
        lbReplace.AutoSize = True
        lbReplace.Font = New Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point)
        lbReplace.Location = New Point(866, 356)
        lbReplace.Name = "lbReplace"
        lbReplace.Size = New Size(55, 19)
        lbReplace.TabIndex = 30
        lbReplace.Text = "Replace"
        ' 
        ' ckReplace
        ' 
        ckReplace.AutoSize = True
        ckReplace.Font = New Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point)
        ckReplace.Location = New Point(869, 458)
        ckReplace.Name = "ckReplace"
        ckReplace.Size = New Size(77, 23)
        ckReplace.TabIndex = 15
        ckReplace.Text = "Replace"
        ckReplace.UseVisualStyleBackColor = True
        ' 
        ' ckOnTop
        ' 
        ckOnTop.AutoSize = True
        ckOnTop.Checked = True
        ckOnTop.CheckState = CheckState.Checked
        ckOnTop.Font = New Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point)
        ckOnTop.Location = New Point(870, 12)
        ckOnTop.Name = "ckOnTop"
        ckOnTop.Size = New Size(76, 23)
        ckOnTop.TabIndex = 31
        ckOnTop.Text = "On Top"
        ckOnTop.UseVisualStyleBackColor = True
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(1069, 624)
        Controls.Add(ckOnTop)
        Controls.Add(ckReplace)
        Controls.Add(lbReplace)
        Controls.Add(txtMatch)
        Controls.Add(lbMatch)
        Controls.Add(txtReplace)
        Controls.Add(btReplace)
        Controls.Add(btClearSub)
        Controls.Add(ckMsg)
        Controls.Add(btSubD)
        Controls.Add(ckTrim)
        Controls.Add(ckSubDExt)
        Controls.Add(lbSubDCount)
        Controls.Add(lbSubD1)
        Controls.Add(listSubD1)
        Controls.Add(lbDirName)
        Controls.Add(lbFn)
        Controls.Add(txtTrim)
        Controls.Add(btTrim)
        Controls.Add(txtExt)
        Controls.Add(btAddExt)
        Controls.Add(btClearHistory)
        Controls.Add(lbFiles)
        Controls.Add(lbDirectories)
        Controls.Add(listHist)
        Controls.Add(lbHistory)
        Controls.Add(listFiles)
        Controls.Add(btListFiles)
        Controls.Add(lbPath)
        Controls.Add(txtPath)
        Controls.Add(listDirectories)
        Controls.Add(btListDir)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "frmMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "File Renamer"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btListDir As Button
    Friend WithEvents listDirectories As ListBox
    Friend WithEvents txtPath As TextBox
    Friend WithEvents lbPath As Label
    Friend WithEvents btListFiles As Button
    Friend WithEvents listFiles As ListBox
    Friend WithEvents lbHistory As Label
    Friend WithEvents listHist As ListBox
    Friend WithEvents lbDirectories As Label
    Friend WithEvents lbFiles As Label
    Friend WithEvents btClearHistory As Button
    Friend WithEvents btAddExt As Button
    Friend WithEvents txtExt As TextBox
    Friend WithEvents txtTrim As TextBox
    Friend WithEvents btTrim As Button
    Friend WithEvents tmRefresh As Timer
    Friend WithEvents lbFn As Label
    Friend WithEvents lbDirName As Label
    Friend WithEvents lbSubDCount As Label
    Friend WithEvents lbSubD1 As Label
    Friend WithEvents listSubD1 As ListBox
    Friend WithEvents ckSubDExt As CheckBox
    Friend WithEvents ckTrim As CheckBox
    Friend WithEvents btSubD As Button
    Friend WithEvents ckMsg As CheckBox
    Friend WithEvents btClearSub As Button
    Friend WithEvents txtReplace As TextBox
    Friend WithEvents btReplace As Button
    Friend WithEvents lbMatch As Label
    Friend WithEvents txtMatch As TextBox
    Friend WithEvents lbReplace As Label
    Friend WithEvents ckReplace As CheckBox
    Friend WithEvents ckOnTop As CheckBox
End Class
