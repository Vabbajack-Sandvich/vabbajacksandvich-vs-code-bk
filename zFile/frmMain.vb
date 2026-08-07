Imports Microsoft.WindowsAPICodePack.Shell
Imports Microsoft.WindowsAPICodePack.Shell.PropertySystem
Imports Windows.Security.EnterpriseData

Public Class frmMain
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public zLStop As Boolean = False

    Public Function zGetVideoDuration(ByVal filePath As String) As TimeSpan
        On Error GoTo zHandler

        Using shell As ShellObject = ShellObject.FromParsingName(filePath)
            Dim prop As IShellProperty = shell.Properties.System.Media.Duration
            Dim t As ULong = DirectCast(prop.ValueAsObject, ULong)
            Return TimeSpan.FromTicks(CType(t, Long))
        End Using
zHandler:
        'some other shit happened
        MessageBox.Show(Err.Number & zR2 & Err.Description)
        'Resume Next
    End Function


    Private Sub btListFiles_Click(sender As Object, e As EventArgs) Handles btListFiles.Click
        'zListDir()
        zListFiles()
        zDone()
    End Sub

    Private Sub btListDir_Click(sender As Object, e As EventArgs) Handles btListDir.Click
        zListDir()
        zDone()
    End Sub

    Public zFrmMainDefWidth As Integer = 927
    Public zFrmMainDefHeight As Integer = 477
    'frmMain default size
    'width 927
    'height 477

    Public zFrmMainMaxWidth As Integer = 927
    Public zFrmMainMaxHeight As Integer = 905
    'frmMain max size
    'width 927
    'height 905

    Public Sub zFrmMainSetDefaultSize()
        Me.Width = zFrmMainDefWidth
        Me.Height = zFrmMainDefHeight
    End Sub

    Public zStartUpVar As Integer = 0

    Public Sub zStartUp()
        If zStartUpVar = 1 Then Exit Sub
        '2026-08-03-07-41-58-AM
        'was the old form load thing
        'added it to a start up timer with a load global variable
        'zStartUp = 1 or 0
        listHist.Items.Add("C:\")
        lbFn.Text = ""
        lbDirName.Text = ""
        lbSubDCount.Text = "0"
        Me.TopMost = True
        zListDir()
        zListFiles()
        zStartUpVar = 1
        tmStartUp.Enabled = False
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'zListDir()
        'zListFiles()
        'listHist.Items.Add("C:\")
        'lbFn.Text = ""
        'lbDirName.Text = ""
        'lbSubDCount.Text = "0"
        'Me.TopMost = True

        'zDone()
        '2026-07-14-18-11-34-PM
        'disabling this
        'was using this becaue of the scaling issue a long time ago
        'setting the appliction scaling in properties on windows explorer
        'on the file fixes it
        'zFrmMainSetDefaultSize()

        tmStartUp.Enabled = True
    End Sub

    Public Sub zListDir()
        On Error GoTo zHandler
        If System.IO.Directory.Exists(txtPath.Text) = False Then
            txtPath.Text = "C:\"
            MessageBox.Show("path does not exist")
            Exit Sub
        End If

        listDirectories.Items.Clear()

        For Each zDir As String In System.IO.Directory.GetDirectories(txtPath.Text)
            Application.DoEvents()
            If zLStop = True Then
                Exit Sub
            End If
            listDirectories.Items.Add(zDir)
        Next

        If listHist.Items.Count = 0 Then Exit Sub
        If listHist.SelectedIndex = -1 Then
            listHist.SelectedIndex = 0
            'Exit Sub
        End If

        If listDirectories.Items.Count = 0 Then Exit Sub
        If listDirectories.SelectedIndex = -1 Then
            listDirectories.SelectedIndex = 0
            'Exit Sub
        End If

        'zDone()
        'exit before zhandler
        Exit Sub
zHandler:
        If (TypeOf Err.GetException() Is System.UnauthorizedAccessException) Then
            ' Code for handling the error is entered here.
            If ckMsg.Checked = True Then
                MessageBox.Show("access denied")
                Exit Sub
            End If
        Else
            'some other shit happened
            MessageBox.Show(Err.Description & zR2 & Err.Number)
            'Resume Next
        End If
    End Sub

    Public Sub zListFiles()
        On Error GoTo zHandler
        If System.IO.Directory.Exists(txtPath.Text) = False Then
            txtPath.Text = "C:\"
            'MessageBox.Show("path does not exist")
            Exit Sub
        End If

        listFiles.Items.Clear()

        For Each zFile As String In System.IO.Directory.GetFiles(txtPath.Text)
            Application.DoEvents()
            If zLStop = True Then
                Exit Sub
            End If

            listFiles.Items.Add(zFile)
        Next
        'zDone()
        'exit before zhandler
        Exit Sub
zHandler:
        If (TypeOf Err.GetException() Is System.UnauthorizedAccessException) Then
            ' Code for handling the error is entered here.
            If ckMsg.Checked = True Then
                MessageBox.Show("access denied")
                Exit Sub
            End If
        Else
            'some other shit happened
            MessageBox.Show(Err.Number & zR2 & Err.Description)
            'Resume Next
        End If
    End Sub

    Private Sub btListFiles_DoubleClick(sender As Object, e As EventArgs) Handles btListFiles.DoubleClick
        'Debug.Print(listFiles.SelectedItem.ToString)
        txtPath.Text = listFiles.SelectedItem.ToString
    End Sub

    Private Sub listDirectories_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listDirectories.SelectedIndexChanged
        '2026-08-06-19-08-45-PM
        'made functions that do this
        'added them to the vabbajack sandvich module
        'If listDirectories.SelectedItem = Nothing Then Exit Sub
        'If txtPath.Text = vbNullString Then Exit Sub
        'Dim zFname As String
        'Dim zFname2 As String
        'Dim zPl As Integer
        'zFname = listDirectories.SelectedItem.ToString
        ''Debug.Print(Len(txtPath.Text))
        'zPl = Len(txtPath.Text)
        'If zPl = 3 Then
        '    zFname2 = Mid(zFname, Len(txtPath.Text) + 1)
        'Else
        '    zFname2 = Mid(zFname, Len(txtPath.Text) + 2)
        'End If
        ''zFname2 = Strings.Replace(zFname, txtPath.Text, "")
        'lbDirName.Text = zFname2

        zUpdateLabelWithListEntryLastPathOrFile(listDirectories, lbDirName, txtPath)
        'zUpdateTextBoxWithListEntryLastPathOrFile(listDirectories, txtDirectoryOut, txtPath)
        zUpdateTextBoxWithListEntry(listDirectories, txtDirectoryOut, 1, 0)

    End Sub

    Private Sub listDirectories_DoubleClick(sender As Object, e As EventArgs) Handles listDirectories.DoubleClick
        'Debug.Print(listDirectories.SelectedItem.ToString)
        If listDirectories.SelectedItem = Nothing Then Exit Sub
        txtPath.Text = listDirectories.SelectedItem.ToString
        zListDir()
        zListFiles()
        listHist.Items.Add(txtPath.Text)
        listHist.SetSelected((listHist.Items.Count - 1), True)

        zUpdateLabelWithListEntryLastPathOrFile(listDirectories, lbDirName, txtPath)
        'zUpdateTextBoxWithListEntryLastPathOrFile(listDirectories, txtDirectoryOut, txtPath)
        zUpdateTextBoxWithListEntry(listDirectories, txtDirectoryOut, 1, 0)

    End Sub

    Private Sub listHist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listHist.SelectedIndexChanged
        'zUpdateLabelWithListEntryLastPathOrFile(listHist, lbDirName, txtPath)
        'zUpdateTextBoxWithListEntryLastPathOrFile(listDirectories, txtDirectoryOut, txtPath)
        zUpdateTextBoxWithListEntry(listHist, txtHistoryOut, 1, 0)

    End Sub

    Private Sub listHist_DoubleClick(sender As Object, e As EventArgs) Handles listHist.DoubleClick
        If listHist.SelectedItem = Nothing Then Exit Sub
        txtPath.Text = listHist.SelectedItem.ToString
        zListDir()
        zListFiles()
        'zUpdateLabelWithListEntryLastPathOrFile(listHist, lbDirName, txtPath)
        'zUpdateTextBoxWithListEntryLastPathOrFile(listDirectories, txtDirectoryOut, txtPath)
        zUpdateTextBoxWithListEntry(listHist, txtHistoryOut, 1, 0)

    End Sub

    Private Sub btClearHistory_Click(sender As Object, e As EventArgs) Handles btClearHistory.Click
        listHist.Items.Clear()
        listHist.Items.Add("C:\")
        'zDone()
    End Sub

    Private Sub btAddExt_Click(sender As Object, e As EventArgs) Handles btAddExt.Click
        zAddExtFiles()
    End Sub

    Public Sub zAddPrefixFiles()
        On Error GoTo zHandler

        '2026-07-14-18-01-04-PM
        'trying this without a pause
        Application.DoEvents()
        zRefreshFilesAndDirectories()

        If txtPath.Text = vbNullString Then
            txtPath.Text = "C:\"
        End If

        'If LCase(txtPath.Text) = "d:\" Then
        '    MessageBox.Show("d:\ is restricted")
        '    Exit Sub
        'ElseIf LCase(txtPath.Text) = "c:\" Then
        '    MessageBox.Show("c:\ is restricted")
        '    Exit Sub
        'End If

        '2026-08-03-07-17-30-AM
        'replacing with zCheckBasePath
        txtPath.Text = LCase(txtPath.Text)

        If zCheckBasePath(txtPath.Text) = 1 Then
            MessageBox.Show(txtPath.Text & " is restricted")
            Exit Sub
        End If

        'this adds extextion to the end of the file names
        '.mp3 as default
        If txtExt.Text = vbNullString Then
            txtExt.Text = ".mp3"
        End If
        If listFiles.Items.Count = 0 Then
            If ckMsg.Checked = True Then
                MessageBox.Show("no files to add extention to in current directory")
            End If
            Exit Sub
        End If

        Dim zMsg As DialogResult

        If ckMsg.Checked = True Then
            'zMsg = MessageBox.Show("Are you sure you want to add the file extention to every file in this directory?", "File Renamer", MessageBoxButtons.YesNo)
            zMsg = MessageBox.Show("Are you sure you want to add the prefix to every file in this directory?", "File Renamer", MessageBoxButtons.YesNo)
        Else
            zMsg = DialogResult.Yes
        End If

        If zMsg = DialogResult.No Then
            'MessageBox.Show("No pressed")
            Exit Sub
        ElseIf zMsg = DialogResult.Yes Then
            'MessageBox.Show("Yes pressed")
            'Exit Sub
            Dim zFname As String
            Dim zFname2 As String
            Dim zFnameExt As String
            Dim zFname3 As String
            For zFindex As Long = 0 To listFiles.Items.Count - 1
                'Debug.Print(listFiles.Items.Item(zFindex).ToString)
                'My.Computer.FileSystem.RenameFile("C:\Test.txt", "SecondTest.txt")
                Application.DoEvents()
                If zLStop = True Then
                    Exit Sub
                End If

                zFname = listFiles.Items.Item(zFindex).ToString
                zFname2 = Mid(zFname, Len(txtPath.Text) + 2)
                zFnameExt = Strings.Right(zFname2, 4)
                zFname3 = txtExt.Text & zFname2
                If zFname <> vbNullString And zFnameExt <> txtExt.Text Then
                    If ckSpaceToUnderscore.Checked = True Then
                        zFname2 = zSpaceToUnderscore(zFname2)
                    End If
                    If ckForceLcase.Checked = True Then
                        'My.Computer.FileSystem.RenameFile(zFname, LCase(zFname2 & txtExt.Text))
                        'My.Computer.FileSystem.RenameFile(zFname, LCase(txtExt.Text & zFname2))
                        If My.Computer.FileSystem.FileExists(txtPath.Text & "\" & zFname3) = False Then
                            My.Computer.FileSystem.RenameFile(zFname, LCase(zFname3))
                        Else
                            If ckDeleteOnExistingRename.Checked = True Then
                                'just delete the original attempting to be renamed
                                My.Computer.FileSystem.DeleteFile(zFname, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
                            End If
                        End If
                    Else
                        'My.Computer.FileSystem.RenameFile(zFname, zFname2 & txtExt.Text)
                        'My.Computer.FileSystem.RenameFile(zFname, txtExt.Text & zFname2)
                        If My.Computer.FileSystem.FileExists(txtPath.Text & "\" & zFname3) = False Then
                            My.Computer.FileSystem.RenameFile(zFname, zFname3)
                        Else
                            If ckDeleteOnExistingRename.Checked = True Then
                                'just delete the original attempting to be renamed
                                My.Computer.FileSystem.DeleteFile(zFname, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
                            End If
                        End If
                    End If

                    'My.Computer.FileSystem.RenameFile(zFname, zFname2 & txtExt.Text)
                    'Debug.Print(zFname & txtExt.Text)
                End If
            Next
            'zListDir()
            'zListFiles()
            'need a timer here to wait for the file system to refresh
            tmRefresh.Enabled = True
            zDone()
            Exit Sub
        End If
        'exit before zhandler
        Exit Sub
zHandler:
        If (TypeOf Err.GetException() Is System.UnauthorizedAccessException) Then
            ' Code for handling the error is entered here.
            If ckMsg.Checked = True Then
                MessageBox.Show("access denied")
            End If
            Resume Next
        Else
            'some other shit happened
            MessageBox.Show(Err.Number & zR2 & Err.Description)
            Resume Next
        End If
    End Sub


    Public Sub zAddExtFiles()
        On Error GoTo zHandler

        '2026-07-14-18-01-04-PM
        'trying this without a pause
        Application.DoEvents()
        zRefreshFilesAndDirectories()

        If txtPath.Text = vbNullString Then
            txtPath.Text = "C:\"
        End If

        'If LCase(txtPath.Text) = "d:\" Then
        '    MessageBox.Show("d:\ is restricted")
        '    Exit Sub
        'ElseIf LCase(txtPath.Text) = "c:\" Then
        '    MessageBox.Show("c:\ is restricted")
        '    Exit Sub
        'End If

        '2026-08-03-07-17-30-AM
        'replacing with zCheckBasePath
        txtPath.Text = LCase(txtPath.Text)

        If zCheckBasePath(txtPath.Text) = 1 Then
            MessageBox.Show(txtPath.Text & " is restricted")
            Exit Sub
        End If

        'this adds extextion to the end of the file names
        'mp3 as default
        If txtExt.Text = vbNullString Then
            txtExt.Text = ".mp3"
        End If
        If listFiles.Items.Count = 0 Then
            If ckMsg.Checked = True Then
                MessageBox.Show("no files to add extention to in current directory")
            End If
            Exit Sub
        End If

        Dim zMsg As DialogResult

        If ckMsg.Checked = True Then
            zMsg = MessageBox.Show("Are you sure you want to add the file extention to every file in this directory?", "File Renamer", MessageBoxButtons.YesNo)
        Else
            zMsg = DialogResult.Yes
        End If

        If zMsg = DialogResult.No Then
            'MessageBox.Show("No pressed")
            Exit Sub
        ElseIf zMsg = DialogResult.Yes Then
            'MessageBox.Show("Yes pressed")
            'Exit Sub
            Dim zFname As String
            Dim zFname2 As String
            Dim zFnameExt As String
            Dim zFname3 As String
            For zFindex As Long = 0 To listFiles.Items.Count - 1
                'Debug.Print(listFiles.Items.Item(zFindex).ToString)
                'My.Computer.FileSystem.RenameFile("C:\Test.txt", "SecondTest.txt")
                Application.DoEvents()
                If zLStop = True Then
                    Exit Sub
                End If

                zFname = listFiles.Items.Item(zFindex).ToString
                zFname2 = Mid(zFname, Len(txtPath.Text) + 2)
                zFnameExt = Strings.Right(zFname2, 4)
                zFname3 = zFname2 & txtExt.Text
                If zFname <> vbNullString And zFnameExt <> txtExt.Text Then
                    If ckSpaceToUnderscore.Checked = True Then
                        zFname2 = zSpaceToUnderscore(zFname2)
                    End If
                    If ckForceLcase.Checked = True Then
                        If My.Computer.FileSystem.FileExists(txtPath.Text & "\" & zFname3) = False Then
                            'My.Computer.FileSystem.RenameFile(zFname, LCase(zFname2 & txtExt.Text))
                            My.Computer.FileSystem.RenameFile(zFname, LCase(zFname3))
                        Else
                            If ckDeleteOnExistingRename.Checked = True Then
                                My.Computer.FileSystem.DeleteFile(zFname, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
                            End If
                        End If
                    Else
                        If My.Computer.FileSystem.FileExists(txtPath.Text & "\" & zFname3) = False Then
                            'My.Computer.FileSystem.RenameFile(zFname, zFname2 & txtExt.Text)
                            My.Computer.FileSystem.RenameFile(zFname, zFname3)
                        Else
                            If ckDeleteOnExistingRename.Checked = True Then
                                My.Computer.FileSystem.DeleteFile(zFname, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
                            End If
                        End If
                        'My.Computer.FileSystem.RenameFile(zFname, zFname2 & txtExt.Text)
                        'Debug.Print(zFname & txtExt.Text)
                    End If
                End If
            Next
            'zListDir()
            'zListFiles()
            'need a timer here to wait for the file system to refresh
            tmRefresh.Enabled = True
            zDone()
            Exit Sub
        End If
        'exit before zhandler
        Exit Sub
zHandler:
        If (TypeOf Err.GetException() Is System.UnauthorizedAccessException) Then
            ' Code for handling the error is entered here.
            If ckMsg.Checked = True Then
                MessageBox.Show("access denied")
            End If
            Resume Next
        Else
            'some other shit happened
            MessageBox.Show(Err.Number & zR2 & Err.Description)
            Resume Next
        End If
    End Sub

    Public Sub zRefreshFilesAndDirectories()
        '2026-07-14-17-59-36-PM
        'added this for use outside of the timer
        'stuff like refreshing before prefixing etc
        Application.DoEvents()
        zListDir()
        zListFiles()
    End Sub

    Private Sub tmRefresh_Tick(sender As Object, e As EventArgs) Handles tmRefresh.Tick
        'Application.DoEvents()
        'zListDir()
        'zListFiles()
        zRefreshFilesAndDirectories()
        tmRefresh.Enabled = False
        'MessageBox.Show("refresh timer stopped")
    End Sub

    Private Sub btTrim_Click(sender As Object, e As EventArgs) Handles btTrim.Click
        zTrimTextFromFiles()
    End Sub

    Public Sub zForceLCaseButton()
        'for the button
        'just forces lcase
        On Error GoTo zHandler

        '2026-07-14-18-01-04-PM
        'trying this without a pause
        Application.DoEvents()
        zRefreshFilesAndDirectories()

        'this removes any matching text from the file name

        If txtPath.Text = vbNullString Then
            txtPath.Text = "C:\"
        End If

        'If LCase(txtPath.Text) = "d:\" Then
        '    MessageBox.Show("d:\ is restricted")
        '    Exit Sub
        'ElseIf LCase(txtPath.Text) = "c:\" Then
        '    MessageBox.Show("c:\ is restricted")
        '    Exit Sub
        'End If

        '2026-08-03-07-17-30-AM
        'replacing with zCheckBasePath
        txtPath.Text = LCase(txtPath.Text)

        If zCheckBasePath(txtPath.Text) = 1 Then
            MessageBox.Show(txtPath.Text & " is restricted")
            Exit Sub
        End If

        If txtTrim.Text = vbNullString Then
            txtTrim.Text = " English Dubbed"
        End If
        If listFiles.Items.Count = 0 Then
            If ckMsg.Checked = True Then
                MessageBox.Show("no files to work with in current directory")
            End If
            Exit Sub
        End If

        Dim zMsg As DialogResult

        If ckMsg.Checked = True Then
            'Dim zMsg As DialogResult = MessageBox.Show("Are you sure you want to trim the string from every file in this directory?", "File Renamer", MessageBoxButtons.YesNo)
            'zMsg = MessageBox.Show("Are you sure you want to trim the string from every file in this directory?", "File Renamer", MessageBoxButtons.YesNo)
            zMsg = MessageBox.Show("Are you sure you want to force all file names to lower case in this directory?", "File Renamer", MessageBoxButtons.YesNo)
        Else
            zMsg = DialogResult.Yes
        End If

        If zMsg = DialogResult.No Then
            'MessageBox.Show("No pressed")
            Exit Sub
        ElseIf zMsg = DialogResult.Yes Then
            'MessageBox.Show("Yes pressed")
            'Exit Sub
            Dim zFname As String
            Dim zFname2 As String
            'Dim zFname3 As String
            For zFindex As Long = 0 To listFiles.Items.Count - 1
                'Debug.Print(listFiles.Items.Item(zFindex).ToString)
                'My.Computer.FileSystem.RenameFile("C:\Test.txt", "SecondTest.txt")
                Application.DoEvents()
                If zLStop = True Then
                    Exit Sub
                End If


                zFname = listFiles.Items.Item(zFindex).ToString
                zFname2 = Mid(zFname, Len(txtPath.Text) + 2)
                'zFname3 = Strings.Replace(zFname2, txtTrim.Text, "")
                'If zFname <> vbNullString And zFname3 <> vbNullString And zFname2 <> zFname3 Then

                'If ckSpaceToUnderscore.Checked = True Then

                'zFname2 = zSpaceToUnderscore(zFname)
                'zFname2 = zSpaceToUnderscore(zFname)
                ' End If

                ' If ckForceLcase.Checked = True Then
                ' If My.Computer.FileSystem.FileExists(txtPath.Text & "\" & LCase(zFname2)) = False Then
                'My.Computer.FileSystem.RenameFile(zFname, LCase(zFname))
                My.Computer.FileSystem.RenameFile(zFname, zFname2 & "-zfile-temp-renamed-file")
                My.Computer.FileSystem.RenameFile(txtPath.Text & "\" & zFname2 & "-zfile-temp-renamed-file", LCase(zFname2))
                'Else
                'If ckDeleteOnExistingRename.Checked = True Then
                'just delete the original attempting to be renamed
                'My.Computer.FileSystem.DeleteFile(LCase(zFname), FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
                'End If
                'End If
                'Else
                'My.Computer.FileSystem.RenameFile(zFname, zFname2)
                'End If'

                'My.Computer.FileSystem.RenameFile(zFname, zFname3)
                'Debug.Print(zFname & txtExt.Text)
                'End If
            Next
            'zListDir()
            'zListFiles()
            'need a timer here to wait for the file system to refresh
            tmRefresh.Enabled = True
            'add message thing there
            zDone()
            Exit Sub
        End If
        'exit before error handler
        Exit Sub
zHandler:
        If (TypeOf Err.GetException() Is System.UnauthorizedAccessException) Then
            ' Code for handling the error is entered here.
            If ckMsg.Checked = True Then
                MessageBox.Show("access denied")
            End If
            Resume Next
        Else
            'some other shit happened
            MessageBox.Show(Err.Number & zR2 & Err.Description)
            Resume Next
        End If
    End Sub


    Public Sub zReplaceSpaceWithUnderscore()
        'for the button
        'this doesnt operate on the checkbox for replace spaces with underscore
        'but does work for lcase
        On Error GoTo zHandler

        '2026-07-14-18-01-04-PM
        'trying this without a pause
        Application.DoEvents()
        zRefreshFilesAndDirectories()

        'this removes any matching text from the file name

        If txtPath.Text = vbNullString Then
            txtPath.Text = "C:\"
        End If

        'If LCase(txtPath.Text) = "d:\" Then
        '    MessageBox.Show("d:\ is restricted")
        '    Exit Sub
        'ElseIf LCase(txtPath.Text) = "c:\" Then
        '    MessageBox.Show("c:\ is restricted")
        '    Exit Sub
        'End If

        '2026-08-03-07-17-30-AM
        'replacing with zCheckBasePath
        txtPath.Text = LCase(txtPath.Text)

        If zCheckBasePath(txtPath.Text) = 1 Then
            MessageBox.Show(txtPath.Text & " is restricted")
            Exit Sub
        End If

        If txtTrim.Text = vbNullString Then
            txtTrim.Text = " English Dubbed"
        End If
        If listFiles.Items.Count = 0 Then
            If ckMsg.Checked = True Then
                MessageBox.Show("no files to work with in current directory")
            End If
            Exit Sub
        End If

        Dim zMsg As DialogResult

        If ckMsg.Checked = True Then
            'Dim zMsg As DialogResult = MessageBox.Show("Are you sure you want to trim the string from every file in this directory?", "File Renamer", MessageBoxButtons.YesNo)
            'zMsg = MessageBox.Show("Are you sure you want to trim the string from every file in this directory?", "File Renamer", MessageBoxButtons.YesNo)
            zMsg = MessageBox.Show("Are you sure you want to replace spaces with underscore in this directory?", "File Renamer", MessageBoxButtons.YesNo)
        Else
            zMsg = DialogResult.Yes
        End If

        If zMsg = DialogResult.No Then
            'MessageBox.Show("No pressed")
            Exit Sub
        ElseIf zMsg = DialogResult.Yes Then
            'MessageBox.Show("Yes pressed")
            'Exit Sub
            Dim zFname As String
            Dim zFname2 As String
            'Dim zFname3 As String
            For zFindex As Long = 0 To listFiles.Items.Count - 1
                'Debug.Print(listFiles.Items.Item(zFindex).ToString)
                'My.Computer.FileSystem.RenameFile("C:\Test.txt", "SecondTest.txt")

                Application.DoEvents()
                If zLStop = True Then
                    Exit Sub
                End If

                zFname = listFiles.Items.Item(zFindex).ToString
                'zFname2 = Mid(zFname, Len(txtPath.Text) + 2)
                'zFname3 = Strings.Replace(zFname2, txtTrim.Text, "")
                'If zFname <> vbNullString And zFname3 <> vbNullString And zFname2 <> zFname3 Then

                'If ckSpaceToUnderscore.Checked = True Then

                zFname2 = zSpaceToUnderscore(zFname)
                ' End If

                If ckForceLcase.Checked = True Then
                    My.Computer.FileSystem.RenameFile(zFname, LCase(zFname2))
                Else
                    My.Computer.FileSystem.RenameFile(zFname, zFname2)
                End If

                'My.Computer.FileSystem.RenameFile(zFname, zFname3)
                'Debug.Print(zFname & txtExt.Text)
                'End If
            Next
            'zListDir()
            'zListFiles()
            'need a timer here to wait for the file system to refresh
            tmRefresh.Enabled = True
            'add message thing there
            zDone()
            Exit Sub
        End If
        'exit before error handler
        Exit Sub
zHandler:
        If (TypeOf Err.GetException() Is System.UnauthorizedAccessException) Then
            ' Code for handling the error is entered here.
            If ckMsg.Checked = True Then
                MessageBox.Show("access denied")
            End If
            Resume Next
        Else
            'some other shit happened
            MessageBox.Show(Err.Number & zR2 & Err.Description)
            Resume Next
        End If
    End Sub


    Public Sub zTrimTextFromFiles()
        On Error GoTo zHandler

        '2026-07-14-18-01-04-PM
        'trying this without a pause
        Application.DoEvents()
        zRefreshFilesAndDirectories()

        'this removes any matching text from the file name

        If txtPath.Text = vbNullString Then
            txtPath.Text = "C:\"
        End If

        'If LCase(txtPath.Text) = "d:\" Then
        '    MessageBox.Show("d:\ is restricted")
        '    Exit Sub
        'ElseIf LCase(txtPath.Text) = "c:\" Then
        '    MessageBox.Show("c:\ is restricted")
        '    Exit Sub
        'End If

        '2026-08-03-07-17-30-AM
        'replacing with zCheckBasePath
        txtPath.Text = LCase(txtPath.Text)

        If zCheckBasePath(txtPath.Text) = 1 Then
            MessageBox.Show(txtPath.Text & " is restricted")
            Exit Sub
        End If

        If txtTrim.Text = vbNullString Then
            txtTrim.Text = " English Dubbed"
        End If
        If listFiles.Items.Count = 0 Then
            If ckMsg.Checked = True Then
                MessageBox.Show("no files to trim in current directory")
            End If
            Exit Sub
        End If

        Dim zMsg As DialogResult

        If ckMsg.Checked = True Then
            'Dim zMsg As DialogResult = MessageBox.Show("Are you sure you want to trim the string from every file in this directory?", "File Renamer", MessageBoxButtons.YesNo)
            zMsg = MessageBox.Show("Are you sure you want to trim the string from every file in this directory?", "File Renamer", MessageBoxButtons.YesNo)
        Else
            zMsg = DialogResult.Yes
        End If

        If zMsg = DialogResult.No Then
            'MessageBox.Show("No pressed")
            Exit Sub
        ElseIf zMsg = DialogResult.Yes Then
            'MessageBox.Show("Yes pressed")
            'Exit Sub

            Dim zFname As String
            Dim zFname2 As String
            Dim zFname3 As String

            For zFindex As Long = 0 To listFiles.Items.Count - 1
                'Debug.Print(listFiles.Items.Item(zFindex).ToString)
                'My.Computer.FileSystem.RenameFile("C:\Test.txt", "SecondTest.txt")

                Application.DoEvents()
                If zLStop = True Then
                    Exit Sub
                End If

                zFname = listFiles.Items.Item(zFindex).ToString
                zFname2 = Mid(zFname, Len(txtPath.Text) + 2)
                zFname3 = Strings.Replace(zFname2, txtTrim.Text, "")

                'On Error GoTo zHandler

                If zFname <> vbNullString And zFname3 <> vbNullString And zFname2 <> zFname3 Then
                    If ckSpaceToUnderscore.Checked = True Then
                        zFname3 = zSpaceToUnderscore(zFname3)
                    End If
                    If ckForceLcase.Checked = True Then
                        If My.Computer.FileSystem.FileExists(txtPath.Text & "\" & zFname3) = False Then
                            My.Computer.FileSystem.RenameFile(zFname, LCase(zFname3))
                        Else
                            If ckDeleteOnExistingRename.Checked = True Then
                                My.Computer.FileSystem.DeleteFile(zFname, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
                            End If
                        End If
                    Else
                        If My.Computer.FileSystem.FileExists(txtPath.Text & "\" & zFname3) = False Then
                            My.Computer.FileSystem.RenameFile(zFname, zFname3)
                        Else
                            'file already exists with renamed name
                            If ckDeleteOnExistingRename.Checked = True Then
                                'just delete the original attempting to be renamed
                                My.Computer.FileSystem.DeleteFile(zFname, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
                            End If
                        End If
                        'My.Computer.FileSystem.RenameFile(zFname, zFname3)
                        'Debug.Print(zFname & txtExt.Text)
                    End If
                End If
            Next
            'zListDir()
            'zListFiles()
            'need a timer here to wait for the file system to refresh
            tmRefresh.Enabled = True
            'add message thing there
            zDone()
            Exit Sub
        End If
        'exit before error handler
        Exit Sub

zHandler:
        If (TypeOf Err.GetException() Is System.UnauthorizedAccessException) Then
            ' Code for handling the error is entered here.
            If ckMsg.Checked = True Then
                MessageBox.Show("access denied")
            End If
            Resume Next
        Else
            'some other shit happened
            MessageBox.Show(Err.Number & zR2 & Err.Description)
            Resume Next
        End If
    End Sub

    Public Sub zDone()
        If ckMsg.Checked = True Then
            MessageBox.Show("done")
        End If
    End Sub

    Private Sub listFiles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listFiles.SelectedIndexChanged
        'If listFiles.SelectedItem = Nothing Then Exit Sub
        'If txtPath.Text = vbNullString Then Exit Sub
        'Dim zFname As String
        'Dim zFname2 As String
        'Dim zPl As Integer
        'zFname = listFiles.SelectedItem.ToString
        ''Debug.Print(Len(txtPath.Text))
        'zPl = Len(txtPath.Text)
        'If zPl = 3 Then
        '    zFname2 = Mid(zFname, Len(txtPath.Text) + 1)
        'Else
        '    zFname2 = Mid(zFname, Len(txtPath.Text) + 2)
        'End If
        ''zFname2 = Strings.Replace(zFname, txtPath.Text, "")
        'lbFn.Text = zFname2

        zUpdateLabelWithListEntryLastPathOrFile(listFiles, lbFn, txtPath)
        zUpdateTextBoxWithListEntry(listFiles, txtFilesOut, 1, 0)

    End Sub

    Private Sub btSubD_Click(sender As Object, e As EventArgs) Handles btSubD.Click
        On Error GoTo zHandler

        Dim zckMsg As Boolean
        If ckMsg.Checked = True Then
            zckMsg = True
        Else
            zckMsg = False
        End If
        ckMsg.Checked = False

        'populate sub directories box starting from the main path
        If txtPath.Text = vbNullString Then
            txtPath.Text = "C:\"
        End If

        '2026-07-14-18-01-04-PM
        'trying this without a pause
        Application.DoEvents()
        zRefreshFilesAndDirectories()

        '2026-07-14-18-03-38-PM
        'replacing this with zRefreshFilesAndDirectories()
        'zListDir()
        'zListFiles()

        If listDirectories.Items.Count = 0 Then
            MessageBox.Show("no sub directories in current directory")
            Exit Sub
        End If

        listSubD1.Items.Clear()
        listFiles.Items.Clear()

        If LCase(txtPath.Text) = "c:\" Then
            MessageBox.Show("yeah we arent doing the entire drive")
            Exit Sub
        End If

        If LCase(txtPath.Text) = "d:\" Then
            MessageBox.Show("yeah we arent doing the entire drive")
            Exit Sub
        End If

        If LCase(txtPath.Text) = "e:\" Then
            MessageBox.Show("yeah we arent doing the entire drive")
            Exit Sub
        End If

        If LCase(txtPath.Text) = "f:\" Then
            MessageBox.Show("yeah we arent doing the entire drive")
            Exit Sub
        End If

        Dim zSDI As Long
        Dim zSDI2 As Long
        Dim zDn As String
        Dim zSdn As String
        Dim zDD As Boolean
        Dim zSdStop As Boolean
        Dim zSDI3 As Long
        Dim zStartingPath As String

        zSDI3 = 0
        zSdStop = False
        'zStartingPath = txtPath.Text & "\"
        zStartingPath = txtPath.Text

        Do
            Application.DoEvents()

            If zLStop = True Then
                Exit Sub
            End If

            If listDirectories.Items.Count > 0 Then
                For zSDI = 0 To listDirectories.Items.Count - 1
                    Application.DoEvents()
                    If zLStop = True Then
                        Exit Sub
                    End If

                    'go through every directory in the main directory list
                    'zdn is the current directory name
                    zDn = listDirectories.Items.Item(zSDI)
                    If listSubD1.Items.Count = 0 Then
                        'if its the first entry dont bother with the dedeuplication check
                        'just add it to the subdirectories list
                        listSubD1.Items.Add(zDn)
                    Else
                        'the list has stuff in it to deduplicate against
                        'this shouldnt be necessary but just incase
                        zDD = False
                        For zSDI2 = 0 To listSubD1.Items.Count - 1
                            Application.DoEvents()
                            If zLStop = True Then
                                Exit Sub
                            End If

                            'zsdn is the current directory name via zSDI2 index
                            zSdn = listSubD1.Items.Item(zSDI2)
                            If zSdn = zDn Then
                                'a match was found so set the dedupe flag to true
                                zDD = True
                                'break the loop and continue
                                Exit For
                            End If
                        Next
                        If zDD = False Then
                            'there were no duplicates
                            'add the entry to the sub directory list box
                            listSubD1.Items.Add(zDn)
                        End If
                    End If
                Next
            End If
            'update the label count
            lbSubDCount.Text = listSubD1.Items.Count
            'proceed to next entry in the sub directory list box
            If zSDI3 < listSubD1.Items.Count Then
                txtPath.Text = listSubD1.Items.Item(zSDI3)
                zListDir()
                'zListFiles()
            End If
            'incriment the sub directory index
            zSDI3 = zSDI3 + 1
            If zSDI3 > listSubD1.Items.Count Then
                zSdStop = True
            End If
        Loop Until zSdStop = True

        'add the main directory to the sub directory list
        'for when the extention and trim stuff happens

        listSubD1.Items.Add(zStartingPath)

        listFiles.Items.Clear()

        'then do trim

        'If ckTrim.Checked = True Then
        ''iterate through sub directory box
        'For zSDI = 0 To listSubD1.Items.Count - 1
        ''set path
        'txtPath.Text = listSubD1.Items.Item(zSDI)
        ''list directories
        'zListDir()
        ''list files
        'zListFiles()
        ''trim text
        'zTrimTextFiles()
        'Next
        'End If

        'replacing trim with replace
        'zReplaceStringFiles()

        If ckReplace.Checked = True Then
            'iterate through sub directory box
            For zSDI = 0 To listSubD1.Items.Count - 1
                Application.DoEvents()
                If zLStop = True Then
                    Exit Sub
                End If

                'set path
                txtPath.Text = listSubD1.Items.Item(zSDI)
                'list directories
                zListDir()
                'list files
                zListFiles()
                'replace text
                zReplaceStringFiles()
            Next
        End If

        'then do extention

        If ckSubDExt.Checked = True Then
            'iterate through sub directory box
            For zSDI = 0 To listSubD1.Items.Count - 1
                Application.DoEvents()
                If zLStop = True Then
                    Exit Sub
                End If

                'set path
                txtPath.Text = listSubD1.Items.Item(zSDI)
                'list directories
                zListDir()
                'list files
                zListFiles()
                'add extention
                zAddExtFiles()
            Next
        End If

        ckMsg.Checked = zckMsg

        zDone()
        Exit Sub
zHandler:
        'some other shit happened
        MessageBox.Show(Err.Number & zR2 & Err.Description)
        Resume Next
    End Sub

    Private Sub btClearSub_Click(sender As Object, e As EventArgs) Handles btClearSub.Click
        '2026-07-14-18-01-04-PM
        'trying this without a pause
        Application.DoEvents()
        zRefreshFilesAndDirectories()

        listSubD1.Items.Clear()
        lbSubDCount.Text = "0"
    End Sub

    Private Sub btReplace_Click(sender As Object, e As EventArgs) Handles btReplace.Click
        zReplaceStringFiles()
    End Sub

    Public Function zCheckBasePath(zPath As String) As Integer
        '2026-08-03-07-08-28-AM
        'this checks all the alphabetical base paths
        'then returns 1 or 0 based on pass or fail
        '0 is pass
        '1 is fail
        '1 means that it scanned all the possible ones
        'matched with a base path
        'a null input for zPath will return 1
        'If LCase(txtPath.Text) = "d:\" Then
        'used in all the places where this is used:
        'MessageBox.Show("d:\ is restricted")
        'replacing all those with this check function
        Dim zPathPass As Integer
        zPath = LCase(zPath)
        Select Case zPath
            Case ""
                'null
                zPathPass = 1
            Case "a:\"
                zPathPass = 1
            Case "b:\"
                zPathPass = 1
            Case "c:\"
                zPathPass = 1
            Case "d:\"
                zPathPass = 1
            Case "e:\"
                zPathPass = 1
            Case "f:\"
                zPathPass = 1
            Case "g:\"
                zPathPass = 1
            Case "h:\"
                zPathPass = 1
            Case "i:\"
                zPathPass = 1
            Case "j:\"
                zPathPass = 1
            Case "k:\"
                zPathPass = 1
            Case "l:\"
                zPathPass = 1
            Case "m:\"
                zPathPass = 1
            Case "n:\"
                zPathPass = 1
            Case "o:\"
                zPathPass = 1
            Case "p:\"
                zPathPass = 1
            Case "q:\"
                zPathPass = 1
            Case "r:\"
                zPathPass = 1
            Case "s:\"
                zPathPass = 1
            Case "t:\"
                zPathPass = 1
            Case "u:\"
                zPathPass = 1
            Case "v:\"
                zPathPass = 1
            Case "w:\"
                zPathPass = 1
            Case "x:\"
                zPathPass = 1
            Case "y:\"
                zPathPass = 1
            Case "z:\"
                zPathPass = 1
        End Select

        zCheckBasePath = zPathPass

    End Function

    Public Sub zReplaceStringFiles()
        On Error GoTo zHandler

        '2026-07-14-18-01-04-PM
        'trying this without a pause
        Application.DoEvents()
        zRefreshFilesAndDirectories()

        'this removes any matching text from the file name
        'and replaces it
        'case sensitive matching for now

        If txtPath.Text = vbNullString Then
            txtPath.Text = "C:\"
        End If

        '2026-08-03-07-17-30-AM
        'replacing with zCheckBasePath
        'If LCase(txtPath.Text) = "d:\" Then
        '    MessageBox.Show("d:\ is restricted")
        '    Exit Sub
        'ElseIf LCase(txtPath.Text) = "c:\" Then
        '    MessageBox.Show("c:\ is restricted")
        '    Exit Sub
        'End If

        txtPath.Text = LCase(txtPath.Text)

        If zCheckBasePath(txtPath.Text) = 1 Then
            MessageBox.Show(txtPath.Text & " is restricted")
            Exit Sub
        End If

        If txtMatch.Text = vbNullString Then
            txtMatch.Text = "Match"
            MessageBox.Show("the match field must have a value")
            Exit Sub
        End If

        'If txtReplace.Text = vbNullString Then
        'txtReplace.Text = "Replace"
        'End If

        If listFiles.Items.Count = 0 Then
            If ckMsg.Checked = True Then
                MessageBox.Show("no files to match and replace in current directory")
            End If
            Exit Sub
        End If

        Dim zMsg As DialogResult

        If ckMsg.Checked = True Then
            'Dim zMsg As DialogResult = MessageBox.Show("Are you sure you want to trim the string from every file in this directory?", "File Renamer", MessageBoxButtons.YesNo)
            zMsg = MessageBox.Show("Are you sure you want to match and replace the string from every file in this directory?", "File Renamer", MessageBoxButtons.YesNo)
        Else
            zMsg = DialogResult.Yes
        End If

        If zMsg = DialogResult.No Then
            'MessageBox.Show("No pressed")
            Exit Sub
        ElseIf zMsg = DialogResult.Yes Then
            'MessageBox.Show("Yes pressed")
            'Exit Sub
            Dim zFname As String
            Dim zFname2 As String
            Dim zFname3 As String
            For zFindex As Long = 0 To listFiles.Items.Count - 1
                'Debug.Print(listFiles.Items.Item(zFindex).ToString)
                'My.Computer.FileSystem.RenameFile("C:\Test.txt", "SecondTest.txt")
                Application.DoEvents()
                If zLStop = True Then
                    Exit Sub
                End If


                zFname = listFiles.Items.Item(zFindex).ToString
                zFname2 = Mid(zFname, Len(txtPath.Text) + 2)
                zFname3 = Strings.Replace(zFname2, txtMatch.Text, txtReplace.Text)
                If zFname <> vbNullString And zFname3 <> vbNullString And zFname2 <> zFname3 Then
                    If ckSpaceToUnderscore.Checked = True Then
                        zFname3 = zSpaceToUnderscore(zFname3)
                    End If
                    If ckForceLcase.Checked = True Then
                        If My.Computer.FileSystem.FileExists(txtPath.Text & "\" & zFname3) = False Then
                            My.Computer.FileSystem.RenameFile(zFname, LCase(zFname3))
                        Else
                            If ckDeleteOnExistingRename.Checked = True Then
                                My.Computer.FileSystem.DeleteFile(zFname, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
                            End If
                        End If
                    Else
                        If My.Computer.FileSystem.FileExists(txtPath.Text & "\" & zFname3) = False Then
                            My.Computer.FileSystem.RenameFile(zFname, zFname3)
                        Else
                            If ckDeleteOnExistingRename.Checked = True Then
                                My.Computer.FileSystem.DeleteFile(zFname, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
                            End If
                        End If
                    End If
                    'Debug.Print(zFname & txtExt.Text)
                End If
            Next
            'zListDir()
            'zListFiles()
            'need a timer here to wait for the file system to refresh
            tmRefresh.Enabled = True
            zDone()
            'exit before zhandler
            Exit Sub
        End If
        'exit before zhandler
        Exit Sub
zHandler:
        If (TypeOf Err.GetException() Is System.UnauthorizedAccessException) Then
            ' Code for handling the error is entered here.
            If ckMsg.Checked = True Then
                MessageBox.Show("access denied")
            End If
            Resume Next
        Else
            'some other shit happened
            MessageBox.Show(Err.Number & zR2 & Err.Description)
            Resume Next
        End If
    End Sub

    Private Sub ckOnTop_CheckedChanged(sender As Object, e As EventArgs) Handles ckOnTop.CheckedChanged
        If ckOnTop.Checked = True Then
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If
    End Sub

    Private Sub listHist_KeyPress(sender As Object, e As KeyPressEventArgs) Handles listHist.KeyPress

    End Sub

    Private Sub listHist_KeyUp(sender As Object, e As KeyEventArgs) Handles listHist.KeyUp
        'Debug.Print(e.KeyCode)
        'exit Sub
        If e.KeyCode = 13 Then
            If listHist.SelectedItem = Nothing Then Exit Sub
            txtPath.Text = listHist.SelectedItem.ToString
            zListDir()
            zListFiles()
        End If
    End Sub

    Private Sub listDirectories_KeyUp(sender As Object, e As KeyEventArgs) Handles listDirectories.KeyUp
        If e.KeyCode = 13 Then
            'Debug.Print(listDirectories.SelectedItem.ToString)
            If listDirectories.SelectedItem = Nothing Then Exit Sub
            txtPath.Text = listDirectories.SelectedItem.ToString
            zListDir()
            zListFiles()
            listHist.Items.Add(txtPath.Text)
            listHist.SetSelected((listHist.Items.Count - 1), True)
        End If
    End Sub

    Private Sub txtPath_TextChanged(sender As Object, e As EventArgs) Handles txtPath.TextChanged

    End Sub

    Private Sub txtPath_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPath.KeyUp
        If e.KeyCode = 13 Then
            If IO.Directory.Exists(txtPath.Text) = False Then
                txtPath.Text = "C:\"
                MessageBox.Show("path does not exist")
                Exit Sub
            End If
            zListDir()
            zListFiles()
            listHist.Items.Add(txtPath.Text)
            listHist.SetSelected(listHist.Items.Count - 1, True)
        End If
    End Sub

    Private Sub ckMsg_CheckedChanged(sender As Object, e As EventArgs) Handles ckMsg.CheckedChanged

    End Sub

    Private Sub btForceLcase_Click(sender As Object, e As EventArgs) Handles btForceLcase.Click
        zForceLCaseButton()
    End Sub

    Private Sub btReplaceSpaceUnderScore_Click(sender As Object, e As EventArgs) Handles btReplaceSpaceUnderScore.Click
        zReplaceSpaceWithUnderscore()
    End Sub

    Private Sub ckEstop_CheckedChanged(sender As Object, e As EventArgs) Handles ckEstop.CheckedChanged
        If ckEstop.Checked = True Then
            zLStop = True
        Else
            zLStop = False
        End If
    End Sub

    Private Sub listSubD1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listSubD1.SelectedIndexChanged
        ''If listDirectories.SelectedItem = Nothing Then Exit Sub
        'If listSubD1.SelectedItem = Nothing Then Exit Sub
        'If txtPath.Text = vbNullString Then Exit Sub
        'Dim zFname As String
        'Dim zFname2 As String
        'Dim zPl As Integer
        ''zFname = listDirectories.SelectedItem.ToString
        'zFname = listSubD1.SelectedItem.ToString
        ''Debug.Print(Len(txtPath.Text))
        'zPl = Len(txtPath.Text)
        'If zPl = 3 Then
        '    zFname2 = Mid(zFname, Len(txtPath.Text) + 1)
        'Else
        '    zFname2 = Mid(zFname, Len(txtPath.Text) + 2)
        'End If
        ''zFname2 = Strings.Replace(zFname, txtPath.Text, "")
        'lbDirName.Text = zFname2

        zUpdateLabelWithListEntryLastPathOrFile(listSubD1, lbFn, txtPath)
        zUpdateTextBoxWithListEntry(listSubD1, txtSubD1Out, 1, 0)

    End Sub

    Private Sub listSubD1_DoubleClick(sender As Object, e As EventArgs) Handles listSubD1.DoubleClick
        'Debug.Print(listDirectories.SelectedItem.ToString)
        'If listDirectories.SelectedItem = Nothing Then Exit Sub
        If listSubD1.SelectedItem = Nothing Then Exit Sub
        txtPath.Text = listSubD1.SelectedItem.ToString
        zListDir()
        zListFiles()
        listHist.Items.Add(txtPath.Text)
        listHist.SetSelected((listHist.Items.Count - 1), True)

        zUpdateLabelWithListEntryLastPathOrFile(listSubD1, lbFn, txtPath)
        zUpdateTextBoxWithListEntry(listSubD1, txtSubD1Out, 1, 0)

    End Sub

    Private Sub btCDrive_Click(sender As Object, e As EventArgs) Handles btCDrive.Click
        txtPath.Text = "c:\"
        zListDir()
        zListFiles()
        listHist.Items.Add(txtPath.Text)
        listHist.SetSelected((listHist.Items.Count - 1), True)
    End Sub

    Private Sub btDDrive_Click(sender As Object, e As EventArgs) Handles btDDrive.Click
        txtPath.Text = "d:\"
        zListDir()
        zListFiles()
        listHist.Items.Add(txtPath.Text)
        listHist.SetSelected((listHist.Items.Count - 1), True)

    End Sub

    Private Sub btAddPrefix_Click(sender As Object, e As EventArgs) Handles btAddPrefix.Click
        zAddPrefixFiles()
    End Sub

    Private Sub frmMain_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.Width > zFrmMainMaxWidth Then
            Me.Width = zFrmMainMaxWidth
        End If
        If Me.Height > zFrmMainMaxHeight Then
            Me.Height = zFrmMainMaxHeight
        End If

    End Sub

    Private Sub btOpenDirectory_Click(sender As Object, e As EventArgs) Handles btOpenDirectoryDir.Click
        If listDirectories.Items.Count = 0 Then Exit Sub
        If listDirectories.SelectedIndex = -1 Then
            listDirectories.SelectedIndex = 0
            'Exit Sub
        End If
        zOpenWindowsDirectoryInExplorer(listDirectories.Items.Item(listDirectories.SelectedIndex))

    End Sub

    Private Sub btOpenDirectoryHist_Click(sender As Object, e As EventArgs) Handles btOpenDirectoryHist.Click
        If listHist.Items.Count = 0 Then Exit Sub
        If listHist.SelectedIndex = -1 Then
            listHist.SelectedIndex = 0
            'Exit Sub
        End If
        zOpenWindowsDirectoryInExplorer(listHist.Items.Item(listHist.SelectedIndex))

    End Sub

    Private Sub btEDrive_Click(sender As Object, e As EventArgs) Handles btEDrive.Click
        txtPath.Text = "e:\"
        zListDir()
        zListFiles()
        listHist.Items.Add(txtPath.Text)
        listHist.SetSelected((listHist.Items.Count - 1), True)

    End Sub

    Private Sub btFDrive_Click(sender As Object, e As EventArgs) Handles btFDrive.Click
        txtPath.Text = "f:\"
        zListDir()
        zListFiles()
        listHist.Items.Add(txtPath.Text)
        listHist.SetSelected((listHist.Items.Count - 1), True)

    End Sub

    Private Sub tmStartUp_Tick(sender As Object, e As EventArgs) Handles tmStartUp.Tick
        Application.DoEvents()
        zStartUp()
    End Sub
End Class