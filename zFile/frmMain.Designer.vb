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
        ckForceLcase = New CheckBox()
        ckSpaceToUnderscore = New CheckBox()
        btForceLcase = New Button()
        btReplaceSpaceUnderScore = New Button()
        ckEstop = New CheckBox()
        btCDrive = New Button()
        btDDrive = New Button()
        btAddPrefix = New Button()
        ckDeleteOnExistingRename = New CheckBox()
        btOpenDirectoryDir = New Button()
        btOpenDirectoryHist = New Button()
        tmStartUp = New Timer(components)
        btEDrive = New Button()
        btFDrive = New Button()
        txtHistoryOut = New TextBox()
        txtDirectoryOut = New TextBox()
        txtFilesOut = New TextBox()
        txtSubD1Out = New TextBox()
        SuspendLayout()
        ' 
        ' btListDir
        ' 
        btListDir.BackColor = Color.Black
        btListDir.Font = New Font("Segoe UI", 8F)
        btListDir.ForeColor = Color.LimeGreen
        btListDir.Location = New Point(695, 39)
        btListDir.Name = "btListDir"
        btListDir.Size = New Size(170, 30)
        btListDir.TabIndex = 5
        btListDir.Text = "List Directories"
        btListDir.UseVisualStyleBackColor = False
        ' 
        ' listDirectories
        ' 
        listDirectories.BackColor = Color.Black
        listDirectories.ForeColor = Color.LimeGreen
        listDirectories.FormattingEnabled = True
        listDirectories.Location = New Point(9, 291)
        listDirectories.Name = "listDirectories"
        listDirectories.Size = New Size(671, 104)
        listDirectories.TabIndex = 2
        ' 
        ' txtPath
        ' 
        txtPath.BackColor = Color.Black
        txtPath.ForeColor = Color.LimeGreen
        txtPath.Location = New Point(9, 58)
        txtPath.Name = "txtPath"
        txtPath.Size = New Size(672, 27)
        txtPath.TabIndex = 0
        txtPath.Text = "C:\"
        ' 
        ' lbPath
        ' 
        lbPath.AutoSize = True
        lbPath.BackColor = Color.Black
        lbPath.ForeColor = Color.LimeGreen
        lbPath.Location = New Point(10, 34)
        lbPath.Name = "lbPath"
        lbPath.Size = New Size(37, 20)
        lbPath.TabIndex = 3
        lbPath.Text = "Path"
        ' 
        ' btListFiles
        ' 
        btListFiles.BackColor = Color.Black
        btListFiles.Font = New Font("Segoe UI", 8F)
        btListFiles.ForeColor = Color.LimeGreen
        btListFiles.Location = New Point(695, 75)
        btListFiles.Name = "btListFiles"
        btListFiles.Size = New Size(170, 30)
        btListFiles.TabIndex = 6
        btListFiles.Text = "List Files"
        btListFiles.UseVisualStyleBackColor = False
        ' 
        ' listFiles
        ' 
        listFiles.BackColor = Color.Black
        listFiles.ForeColor = Color.LimeGreen
        listFiles.FormattingEnabled = True
        listFiles.Location = New Point(9, 470)
        listFiles.Name = "listFiles"
        listFiles.Size = New Size(671, 104)
        listFiles.TabIndex = 3
        ' 
        ' lbHistory
        ' 
        lbHistory.AutoSize = True
        lbHistory.BackColor = Color.Black
        lbHistory.Font = New Font("Segoe UI", 8F)
        lbHistory.ForeColor = Color.LimeGreen
        lbHistory.Location = New Point(9, 88)
        lbHistory.Name = "lbHistory"
        lbHistory.Size = New Size(53, 19)
        lbHistory.TabIndex = 6
        lbHistory.Text = "History"
        ' 
        ' listHist
        ' 
        listHist.BackColor = Color.Black
        listHist.ForeColor = Color.LimeGreen
        listHist.FormattingEnabled = True
        listHist.Location = New Point(9, 111)
        listHist.Name = "listHist"
        listHist.Size = New Size(671, 104)
        listHist.TabIndex = 1
        ' 
        ' lbDirectories
        ' 
        lbDirectories.AutoSize = True
        lbDirectories.BackColor = Color.Black
        lbDirectories.Font = New Font("Segoe UI", 8F)
        lbDirectories.ForeColor = Color.LimeGreen
        lbDirectories.Location = New Point(8, 269)
        lbDirectories.Name = "lbDirectories"
        lbDirectories.Size = New Size(74, 19)
        lbDirectories.TabIndex = 8
        lbDirectories.Text = "Directories"
        ' 
        ' lbFiles
        ' 
        lbFiles.AutoSize = True
        lbFiles.BackColor = Color.Black
        lbFiles.Font = New Font("Segoe UI", 8F)
        lbFiles.ForeColor = Color.LimeGreen
        lbFiles.Location = New Point(12, 448)
        lbFiles.Name = "lbFiles"
        lbFiles.Size = New Size(35, 19)
        lbFiles.TabIndex = 9
        lbFiles.Text = "Files"
        ' 
        ' btClearHistory
        ' 
        btClearHistory.BackColor = Color.Black
        btClearHistory.Font = New Font("Segoe UI", 8F)
        btClearHistory.ForeColor = Color.LimeGreen
        btClearHistory.Location = New Point(695, 111)
        btClearHistory.Name = "btClearHistory"
        btClearHistory.Size = New Size(170, 30)
        btClearHistory.TabIndex = 7
        btClearHistory.Text = "Clear History"
        btClearHistory.UseVisualStyleBackColor = False
        ' 
        ' btAddExt
        ' 
        btAddExt.BackColor = Color.Black
        btAddExt.Font = New Font("Segoe UI", 8F)
        btAddExt.ForeColor = Color.LimeGreen
        btAddExt.Location = New Point(695, 180)
        btAddExt.Name = "btAddExt"
        btAddExt.Size = New Size(170, 30)
        btAddExt.TabIndex = 9
        btAddExt.Text = "Add Extention"
        btAddExt.UseVisualStyleBackColor = False
        ' 
        ' txtExt
        ' 
        txtExt.BackColor = Color.Black
        txtExt.ForeColor = Color.LimeGreen
        txtExt.Location = New Point(695, 147)
        txtExt.Name = "txtExt"
        txtExt.Size = New Size(170, 27)
        txtExt.TabIndex = 8
        txtExt.Text = ".mp4"
        ' 
        ' txtTrim
        ' 
        txtTrim.BackColor = Color.Black
        txtTrim.ForeColor = Color.LimeGreen
        txtTrim.Location = New Point(695, 251)
        txtTrim.Name = "txtTrim"
        txtTrim.Size = New Size(170, 27)
        txtTrim.TabIndex = 10
        txtTrim.Text = " English Dubbed"
        ' 
        ' btTrim
        ' 
        btTrim.BackColor = Color.Black
        btTrim.Font = New Font("Segoe UI", 8F)
        btTrim.ForeColor = Color.LimeGreen
        btTrim.Location = New Point(695, 284)
        btTrim.Name = "btTrim"
        btTrim.Size = New Size(170, 30)
        btTrim.TabIndex = 11
        btTrim.Text = "Trim"
        btTrim.UseVisualStyleBackColor = False
        ' 
        ' tmRefresh
        ' 
        tmRefresh.Interval = 1000
        ' 
        ' lbFn
        ' 
        lbFn.AutoSize = True
        lbFn.BackColor = Color.Black
        lbFn.Font = New Font("Segoe UI", 8F)
        lbFn.ForeColor = Color.LimeGreen
        lbFn.Location = New Point(50, 448)
        lbFn.Name = "lbFn"
        lbFn.Size = New Size(65, 19)
        lbFn.TabIndex = 15
        lbFn.Text = "FileName"
        ' 
        ' lbDirName
        ' 
        lbDirName.AutoSize = True
        lbDirName.BackColor = Color.Black
        lbDirName.Font = New Font("Segoe UI", 8F)
        lbDirName.ForeColor = Color.LimeGreen
        lbDirName.Location = New Point(85, 269)
        lbDirName.Name = "lbDirName"
        lbDirName.Size = New Size(105, 19)
        lbDirName.TabIndex = 16
        lbDirName.Text = "Directory Name"
        lbDirName.Visible = False
        ' 
        ' lbSubDCount
        ' 
        lbSubDCount.AutoSize = True
        lbSubDCount.BackColor = Color.Black
        lbSubDCount.Font = New Font("Segoe UI", 8F)
        lbSubDCount.ForeColor = Color.LimeGreen
        lbSubDCount.Location = New Point(115, 610)
        lbSubDCount.Name = "lbSubDCount"
        lbSubDCount.Size = New Size(134, 19)
        lbSubDCount.TabIndex = 19
        lbSubDCount.Text = "Sub Directory Count"
        ' 
        ' lbSubD1
        ' 
        lbSubD1.AutoSize = True
        lbSubD1.BackColor = Color.Black
        lbSubD1.Font = New Font("Segoe UI", 8F)
        lbSubD1.ForeColor = Color.LimeGreen
        lbSubD1.Location = New Point(9, 610)
        lbSubD1.Name = "lbSubD1"
        lbSubD1.Size = New Size(101, 19)
        lbSubD1.TabIndex = 18
        lbSubD1.Text = "Sub Directories"
        ' 
        ' listSubD1
        ' 
        listSubD1.BackColor = Color.Black
        listSubD1.ForeColor = Color.LimeGreen
        listSubD1.FormattingEnabled = True
        listSubD1.Location = New Point(9, 632)
        listSubD1.Name = "listSubD1"
        listSubD1.Size = New Size(671, 124)
        listSubD1.TabIndex = 4
        ' 
        ' ckSubDExt
        ' 
        ckSubDExt.AutoSize = True
        ckSubDExt.BackColor = Color.Black
        ckSubDExt.Font = New Font("Segoe UI", 8F)
        ckSubDExt.ForeColor = Color.LimeGreen
        ckSubDExt.Location = New Point(789, 646)
        ckSubDExt.Name = "ckSubDExt"
        ckSubDExt.Size = New Size(88, 23)
        ckSubDExt.TabIndex = 16
        ckSubDExt.Text = "Extention"
        ckSubDExt.UseVisualStyleBackColor = False
        ' 
        ' ckTrim
        ' 
        ckTrim.AutoSize = True
        ckTrim.BackColor = Color.Black
        ckTrim.Enabled = False
        ckTrim.Font = New Font("Segoe UI", 8F)
        ckTrim.ForeColor = Color.LimeGreen
        ckTrim.Location = New Point(697, 617)
        ckTrim.Name = "ckTrim"
        ckTrim.Size = New Size(57, 23)
        ckTrim.TabIndex = 15
        ckTrim.Text = "Trim"
        ckTrim.UseVisualStyleBackColor = False
        ckTrim.Visible = False
        ' 
        ' btSubD
        ' 
        btSubD.BackColor = Color.Black
        btSubD.Font = New Font("Segoe UI", 8F)
        btSubD.ForeColor = Color.LimeGreen
        btSubD.Location = New Point(696, 733)
        btSubD.Name = "btSubD"
        btSubD.Size = New Size(170, 30)
        btSubD.TabIndex = 18
        btSubD.Text = "Sub Directories"
        btSubD.UseVisualStyleBackColor = False
        ' 
        ' ckMsg
        ' 
        ckMsg.AutoSize = True
        ckMsg.BackColor = Color.Black
        ckMsg.Checked = True
        ckMsg.CheckState = CheckState.Checked
        ckMsg.Font = New Font("Segoe UI", 8F)
        ckMsg.ForeColor = Color.LimeGreen
        ckMsg.Location = New Point(696, 675)
        ckMsg.Name = "ckMsg"
        ckMsg.Size = New Size(91, 23)
        ckMsg.TabIndex = 17
        ckMsg.Text = "Messages"
        ckMsg.UseVisualStyleBackColor = False
        ' 
        ' btClearSub
        ' 
        btClearSub.BackColor = Color.Black
        btClearSub.Font = New Font("Segoe UI", 8F)
        btClearSub.ForeColor = Color.LimeGreen
        btClearSub.Location = New Point(696, 769)
        btClearSub.Name = "btClearSub"
        btClearSub.Size = New Size(170, 30)
        btClearSub.TabIndex = 19
        btClearSub.Text = "Clear Sub Dir List"
        btClearSub.UseVisualStyleBackColor = False
        ' 
        ' txtReplace
        ' 
        txtReplace.BackColor = Color.Black
        txtReplace.ForeColor = Color.LimeGreen
        txtReplace.Location = New Point(695, 391)
        txtReplace.Name = "txtReplace"
        txtReplace.Size = New Size(170, 27)
        txtReplace.TabIndex = 13
        txtReplace.Text = "Replace"
        ' 
        ' btReplace
        ' 
        btReplace.BackColor = Color.Black
        btReplace.Font = New Font("Segoe UI", 8F)
        btReplace.ForeColor = Color.LimeGreen
        btReplace.Location = New Point(695, 424)
        btReplace.Name = "btReplace"
        btReplace.Size = New Size(170, 30)
        btReplace.TabIndex = 14
        btReplace.Text = "Replace"
        btReplace.UseVisualStyleBackColor = False
        ' 
        ' lbMatch
        ' 
        lbMatch.AutoSize = True
        lbMatch.BackColor = Color.Black
        lbMatch.Font = New Font("Segoe UI", 8F)
        lbMatch.ForeColor = Color.LimeGreen
        lbMatch.Location = New Point(695, 317)
        lbMatch.Name = "lbMatch"
        lbMatch.Size = New Size(48, 19)
        lbMatch.TabIndex = 28
        lbMatch.Text = "Match"
        ' 
        ' txtMatch
        ' 
        txtMatch.BackColor = Color.Black
        txtMatch.ForeColor = Color.LimeGreen
        txtMatch.Location = New Point(695, 339)
        txtMatch.Name = "txtMatch"
        txtMatch.Size = New Size(170, 27)
        txtMatch.TabIndex = 12
        txtMatch.Text = "Match"
        ' 
        ' lbReplace
        ' 
        lbReplace.AutoSize = True
        lbReplace.BackColor = Color.Black
        lbReplace.Font = New Font("Segoe UI", 8F)
        lbReplace.ForeColor = Color.LimeGreen
        lbReplace.Location = New Point(695, 369)
        lbReplace.Name = "lbReplace"
        lbReplace.Size = New Size(55, 19)
        lbReplace.TabIndex = 30
        lbReplace.Text = "Replace"
        ' 
        ' ckReplace
        ' 
        ckReplace.AutoSize = True
        ckReplace.BackColor = Color.Black
        ckReplace.Font = New Font("Segoe UI", 8F)
        ckReplace.ForeColor = Color.LimeGreen
        ckReplace.Location = New Point(696, 646)
        ckReplace.Name = "ckReplace"
        ckReplace.Size = New Size(77, 23)
        ckReplace.TabIndex = 15
        ckReplace.Text = "Replace"
        ckReplace.UseVisualStyleBackColor = False
        ' 
        ' ckOnTop
        ' 
        ckOnTop.AutoSize = True
        ckOnTop.BackColor = Color.Black
        ckOnTop.Checked = True
        ckOnTop.CheckState = CheckState.Checked
        ckOnTop.Font = New Font("Segoe UI", 8F)
        ckOnTop.ForeColor = Color.LimeGreen
        ckOnTop.Location = New Point(696, 9)
        ckOnTop.Name = "ckOnTop"
        ckOnTop.Size = New Size(76, 23)
        ckOnTop.TabIndex = 31
        ckOnTop.Text = "On Top"
        ckOnTop.UseVisualStyleBackColor = False
        ' 
        ' ckForceLcase
        ' 
        ckForceLcase.AutoSize = True
        ckForceLcase.BackColor = Color.Black
        ckForceLcase.Font = New Font("Segoe UI", 8F)
        ckForceLcase.ForeColor = Color.LimeGreen
        ckForceLcase.Location = New Point(789, 675)
        ckForceLcase.Name = "ckForceLcase"
        ckForceLcase.Size = New Size(101, 23)
        ckForceLcase.TabIndex = 32
        ckForceLcase.Text = "Force Lcase"
        ckForceLcase.UseVisualStyleBackColor = False
        ' 
        ' ckSpaceToUnderscore
        ' 
        ckSpaceToUnderscore.AutoSize = True
        ckSpaceToUnderscore.BackColor = Color.Black
        ckSpaceToUnderscore.Font = New Font("Segoe UI", 8F)
        ckSpaceToUnderscore.ForeColor = Color.LimeGreen
        ckSpaceToUnderscore.Location = New Point(696, 704)
        ckSpaceToUnderscore.Name = "ckSpaceToUnderscore"
        ckSpaceToUnderscore.Size = New Size(158, 23)
        ckSpaceToUnderscore.TabIndex = 33
        ckSpaceToUnderscore.Text = "Space To Underscore"
        ckSpaceToUnderscore.UseVisualStyleBackColor = False
        ' 
        ' btForceLcase
        ' 
        btForceLcase.BackColor = Color.Black
        btForceLcase.Font = New Font("Segoe UI", 8F)
        btForceLcase.ForeColor = Color.LimeGreen
        btForceLcase.Location = New Point(695, 519)
        btForceLcase.Name = "btForceLcase"
        btForceLcase.Size = New Size(170, 30)
        btForceLcase.TabIndex = 34
        btForceLcase.Text = "Force LCase"
        btForceLcase.UseVisualStyleBackColor = False
        ' 
        ' btReplaceSpaceUnderScore
        ' 
        btReplaceSpaceUnderScore.BackColor = Color.Black
        btReplaceSpaceUnderScore.Font = New Font("Segoe UI", 8F)
        btReplaceSpaceUnderScore.ForeColor = Color.LimeGreen
        btReplaceSpaceUnderScore.Location = New Point(696, 460)
        btReplaceSpaceUnderScore.Name = "btReplaceSpaceUnderScore"
        btReplaceSpaceUnderScore.Size = New Size(170, 53)
        btReplaceSpaceUnderScore.TabIndex = 35
        btReplaceSpaceUnderScore.Text = "Replace Space With Underscore"
        btReplaceSpaceUnderScore.UseVisualStyleBackColor = False
        ' 
        ' ckEstop
        ' 
        ckEstop.AutoSize = True
        ckEstop.BackColor = Color.Black
        ckEstop.Font = New Font("Segoe UI", 8F)
        ckEstop.ForeColor = Color.LimeGreen
        ckEstop.Location = New Point(695, 805)
        ckEstop.Name = "ckEstop"
        ckEstop.Size = New Size(165, 23)
        ckEstop.TabIndex = 36
        ckEstop.Text = "Loop Emergency Stop"
        ckEstop.UseVisualStyleBackColor = False
        ' 
        ' btCDrive
        ' 
        btCDrive.BackColor = Color.Black
        btCDrive.Font = New Font("Segoe UI", 8F)
        btCDrive.ForeColor = Color.LimeGreen
        btCDrive.Location = New Point(97, 11)
        btCDrive.Name = "btCDrive"
        btCDrive.Size = New Size(61, 36)
        btCDrive.TabIndex = 37
        btCDrive.Text = "C:\"
        btCDrive.UseVisualStyleBackColor = False
        ' 
        ' btDDrive
        ' 
        btDDrive.BackColor = Color.Black
        btDDrive.Font = New Font("Segoe UI", 8F)
        btDDrive.ForeColor = Color.LimeGreen
        btDDrive.Location = New Point(166, 11)
        btDDrive.Name = "btDDrive"
        btDDrive.Size = New Size(61, 36)
        btDDrive.TabIndex = 38
        btDDrive.Text = "D:\"
        btDDrive.UseVisualStyleBackColor = False
        ' 
        ' btAddPrefix
        ' 
        btAddPrefix.BackColor = Color.Black
        btAddPrefix.Font = New Font("Segoe UI", 8F)
        btAddPrefix.ForeColor = Color.LimeGreen
        btAddPrefix.Location = New Point(695, 215)
        btAddPrefix.Name = "btAddPrefix"
        btAddPrefix.Size = New Size(170, 30)
        btAddPrefix.TabIndex = 39
        btAddPrefix.Text = "Add Prefix"
        btAddPrefix.UseVisualStyleBackColor = False
        ' 
        ' ckDeleteOnExistingRename
        ' 
        ckDeleteOnExistingRename.BackColor = Color.Black
        ckDeleteOnExistingRename.Font = New Font("Segoe UI", 8F)
        ckDeleteOnExistingRename.ForeColor = Color.LimeGreen
        ckDeleteOnExistingRename.Location = New Point(696, 560)
        ckDeleteOnExistingRename.Name = "ckDeleteOnExistingRename"
        ckDeleteOnExistingRename.Size = New Size(170, 51)
        ckDeleteOnExistingRename.TabIndex = 40
        ckDeleteOnExistingRename.Text = "Will Delete On Existing Rename"
        ckDeleteOnExistingRename.UseVisualStyleBackColor = False
        ' 
        ' btOpenDirectoryDir
        ' 
        btOpenDirectoryDir.BackColor = Color.Black
        btOpenDirectoryDir.Font = New Font("Segoe UI", 8F)
        btOpenDirectoryDir.ForeColor = Color.LimeGreen
        btOpenDirectoryDir.Location = New Point(510, 434)
        btOpenDirectoryDir.Name = "btOpenDirectoryDir"
        btOpenDirectoryDir.Size = New Size(170, 30)
        btOpenDirectoryDir.TabIndex = 41
        btOpenDirectoryDir.Text = "Open Selected Directory"
        btOpenDirectoryDir.UseVisualStyleBackColor = False
        ' 
        ' btOpenDirectoryHist
        ' 
        btOpenDirectoryHist.BackColor = Color.Black
        btOpenDirectoryHist.Font = New Font("Segoe UI", 8F)
        btOpenDirectoryHist.ForeColor = Color.LimeGreen
        btOpenDirectoryHist.Location = New Point(510, 255)
        btOpenDirectoryHist.Name = "btOpenDirectoryHist"
        btOpenDirectoryHist.Size = New Size(170, 30)
        btOpenDirectoryHist.TabIndex = 42
        btOpenDirectoryHist.Text = "Open Selected Directory"
        btOpenDirectoryHist.UseVisualStyleBackColor = False
        ' 
        ' tmStartUp
        ' 
        tmStartUp.Interval = 1000
        ' 
        ' btEDrive
        ' 
        btEDrive.BackColor = Color.Black
        btEDrive.Font = New Font("Segoe UI", 8F)
        btEDrive.ForeColor = Color.LimeGreen
        btEDrive.Location = New Point(233, 11)
        btEDrive.Name = "btEDrive"
        btEDrive.Size = New Size(61, 36)
        btEDrive.TabIndex = 43
        btEDrive.Text = "E:\"
        btEDrive.UseVisualStyleBackColor = False
        ' 
        ' btFDrive
        ' 
        btFDrive.BackColor = Color.Black
        btFDrive.Font = New Font("Segoe UI", 8F)
        btFDrive.ForeColor = Color.LimeGreen
        btFDrive.Location = New Point(300, 12)
        btFDrive.Name = "btFDrive"
        btFDrive.Size = New Size(61, 36)
        btFDrive.TabIndex = 44
        btFDrive.Text = "F:\"
        btFDrive.UseVisualStyleBackColor = False
        ' 
        ' txtHistoryOut
        ' 
        txtHistoryOut.BackColor = Color.Black
        txtHistoryOut.ForeColor = Color.LimeGreen
        txtHistoryOut.Location = New Point(8, 222)
        txtHistoryOut.Name = "txtHistoryOut"
        txtHistoryOut.Size = New Size(672, 27)
        txtHistoryOut.TabIndex = 45
        txtHistoryOut.Text = "C:\"
        ' 
        ' txtDirectoryOut
        ' 
        txtDirectoryOut.BackColor = Color.Black
        txtDirectoryOut.ForeColor = Color.LimeGreen
        txtDirectoryOut.Location = New Point(8, 401)
        txtDirectoryOut.Name = "txtDirectoryOut"
        txtDirectoryOut.Size = New Size(672, 27)
        txtDirectoryOut.TabIndex = 46
        txtDirectoryOut.Text = "C:\"
        ' 
        ' txtFilesOut
        ' 
        txtFilesOut.BackColor = Color.Black
        txtFilesOut.ForeColor = Color.LimeGreen
        txtFilesOut.Location = New Point(8, 580)
        txtFilesOut.Name = "txtFilesOut"
        txtFilesOut.Size = New Size(672, 27)
        txtFilesOut.TabIndex = 47
        txtFilesOut.Text = "C:\"
        ' 
        ' txtSubD1Out
        ' 
        txtSubD1Out.BackColor = Color.Black
        txtSubD1Out.ForeColor = Color.LimeGreen
        txtSubD1Out.Location = New Point(8, 769)
        txtSubD1Out.Name = "txtSubD1Out"
        txtSubD1Out.Size = New Size(672, 27)
        txtSubD1Out.TabIndex = 48
        txtSubD1Out.Text = "C:\"
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.Black
        ClientSize = New Size(891, 834)
        Controls.Add(txtSubD1Out)
        Controls.Add(txtFilesOut)
        Controls.Add(txtDirectoryOut)
        Controls.Add(txtHistoryOut)
        Controls.Add(btFDrive)
        Controls.Add(btEDrive)
        Controls.Add(btOpenDirectoryHist)
        Controls.Add(btOpenDirectoryDir)
        Controls.Add(ckDeleteOnExistingRename)
        Controls.Add(btAddPrefix)
        Controls.Add(btDDrive)
        Controls.Add(btCDrive)
        Controls.Add(ckEstop)
        Controls.Add(ckSpaceToUnderscore)
        Controls.Add(ckForceLcase)
        Controls.Add(ckOnTop)
        Controls.Add(ckReplace)
        Controls.Add(lbReplace)
        Controls.Add(txtMatch)
        Controls.Add(lbMatch)
        Controls.Add(txtReplace)
        Controls.Add(btReplace)
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
        Controls.Add(btClearSub)
        Controls.Add(btForceLcase)
        Controls.Add(btReplaceSpaceUnderScore)
        ForeColor = Color.LimeGreen
        MaximizeBox = False
        Name = "frmMain"
        SizeGripStyle = SizeGripStyle.Show
        StartPosition = FormStartPosition.CenterScreen
        Text = "zFile"
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
    Friend WithEvents ckForceLcase As CheckBox
    Friend WithEvents ckSpaceToUnderscore As CheckBox
    Friend WithEvents btForceLcase As Button
    Friend WithEvents btReplaceSpaceUnderScore As Button
    Friend WithEvents ckEstop As CheckBox
    Friend WithEvents btCDrive As Button
    Friend WithEvents btDDrive As Button
    Friend WithEvents btAddPrefix As Button
    Friend WithEvents ckDeleteOnExistingRename As CheckBox
    Friend WithEvents btOpenDirectoryDir As Button
    Friend WithEvents btOpenDirectoryHist As Button
    Friend WithEvents tmStartUp As Timer
    Friend WithEvents btEDrive As Button
    Friend WithEvents btFDrive As Button
    Friend WithEvents txtHistoryOut As TextBox
    Friend WithEvents txtDirectoryOut As TextBox
    Friend WithEvents txtFilesOut As TextBox
    Friend WithEvents txtSubD1Out As TextBox
End Class
