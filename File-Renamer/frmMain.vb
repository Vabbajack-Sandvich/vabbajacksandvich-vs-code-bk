Public Class frmMain

    Private Sub btListFiles_Click(sender As Object, e As EventArgs) Handles btListFiles.Click
        'zListDir()
        zListFiles()
    End Sub

    Private Sub btListDir_Click(sender As Object, e As EventArgs) Handles btListDir.Click
        zListDir()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        zListDir()
        zListFiles()
        listHist.Items.Add("C:\")
        lbFn.Text = ""
        lbDirName.Text = ""
        lbSubDCount.Text = "0"
        Me.TopMost = True
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
            listDirectories.Items.Add(zDir)
        Next
zHandler:
        If (TypeOf Err.GetException() Is System.UnauthorizedAccessException) Then
            ' Code for handling the error is entered here.
            If ckMsg.Checked = True Then
                MessageBox.Show("access denied")
                Exit Sub
            End If
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
            listFiles.Items.Add(zFile)
        Next
zHandler:
        If (TypeOf Err.GetException() Is System.UnauthorizedAccessException) Then
            ' Code for handling the error is entered here.
            If ckMsg.Checked = True Then
                MessageBox.Show("access denied")
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btListFiles_DoubleClick(sender As Object, e As EventArgs) Handles btListFiles.DoubleClick
        'Debug.Print(listFiles.SelectedItem.ToString)
        txtPath.Text = listFiles.SelectedItem.ToString
    End Sub

    Private Sub listDirectories_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listDirectories.SelectedIndexChanged
        If listDirectories.SelectedItem = Nothing Then Exit Sub
        If txtPath.Text = vbNullString Then Exit Sub
        Dim zFname As String
        Dim zFname2 As String
        Dim zPl As Integer
        zFname = listDirectories.SelectedItem.ToString
        'Debug.Print(Len(txtPath.Text))
        zPl = Len(txtPath.Text)
        If zPl = 3 Then
            zFname2 = Mid(zFname, Len(txtPath.Text) + 1)
        Else
            zFname2 = Mid(zFname, Len(txtPath.Text) + 2)
        End If
        'zFname2 = Strings.Replace(zFname, txtPath.Text, "")
        lbDirName.Text = zFname2
    End Sub

    Private Sub listDirectories_DoubleClick(sender As Object, e As EventArgs) Handles listDirectories.DoubleClick
        'Debug.Print(listDirectories.SelectedItem.ToString)
        If listDirectories.SelectedItem = Nothing Then Exit Sub
        txtPath.Text = listDirectories.SelectedItem.ToString
        zListDir()
        zListFiles()
        listHist.Items.Add(txtPath.Text)
        listHist.SetSelected((listHist.Items.Count - 1), True)
    End Sub

    Private Sub listHist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listHist.SelectedIndexChanged

    End Sub

    Private Sub listHist_DoubleClick(sender As Object, e As EventArgs) Handles listHist.DoubleClick
        If listHist.SelectedItem = Nothing Then Exit Sub
        txtPath.Text = listHist.SelectedItem.ToString
        zListDir()
        zListFiles()
    End Sub

    Private Sub btClearHistory_Click(sender As Object, e As EventArgs) Handles btClearHistory.Click
        listHist.Items.Clear()
        listHist.Items.Add("C:\")
    End Sub

    Private Sub btAddExt_Click(sender As Object, e As EventArgs) Handles btAddExt.Click
        zAddExtFiles()
    End Sub

    Public Sub zAddExtFiles()
        On Error GoTo zHandler
        'this adds extextion to the end of the file names
        If txtPath.Text = vbNullString Then
            txtPath.Text = "C:\"
        End If
        If LCase(txtPath.Text) = "d:\" Then
            MessageBox.Show("d:\ is restricted")
            Exit Sub
        ElseIf LCase(txtPath.Text) = "c:\" Then
            MessageBox.Show("c:\ is restricted")
            Exit Sub
        End If
        If txtExt.Text = vbNullString Then
            txtExt.Text = ".mp4"
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
            For zFindex As Long = 0 To listFiles.Items.Count - 1
                'Debug.Print(listFiles.Items.Item(zFindex).ToString)
                'My.Computer.FileSystem.RenameFile("C:\Test.txt", "SecondTest.txt")

                zFname = listFiles.Items.Item(zFindex).ToString
                zFname2 = Mid(zFname, Len(txtPath.Text) + 2)
                zFnameExt = Strings.Right(zFname2, 4)
                If zFname <> vbNullString And zFnameExt <> txtExt.Text Then
                    My.Computer.FileSystem.RenameFile(zFname, zFname2 & txtExt.Text)
                    'Debug.Print(zFname & txtExt.Text)
                End If
            Next
            'zListDir()
            'zListFiles()
            'need a timer here to wait for the file system to refresh
            tmRefresh.Enabled = True
        End If
zHandler:
        If (TypeOf Err.GetException() Is System.UnauthorizedAccessException) Then
            ' Code for handling the error is entered here.
            If ckMsg.Checked = True Then
                MessageBox.Show("access denied")
            End If
            Resume Next
        End If
    End Sub

    Private Sub tmRefresh_Tick(sender As Object, e As EventArgs) Handles tmRefresh.Tick
        zListDir()
        zListFiles()
        tmRefresh.Enabled = False
        'MessageBox.Show("refresh timer stopped")
    End Sub

    Private Sub btTrim_Click(sender As Object, e As EventArgs) Handles btTrim.Click
        zTrimTextFiles()
    End Sub

    Public Sub zTrimTextFiles()
        On Error GoTo zHandler
        'this removes any matching text from the file name

        If txtPath.Text = vbNullString Then
            txtPath.Text = "C:\"
        End If
        If LCase(txtPath.Text) = "d:\" Then
            MessageBox.Show("d:\ is restricted")
            Exit Sub
        ElseIf LCase(txtPath.Text) = "c:\" Then
            MessageBox.Show("c:\ is restricted")
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

                zFname = listFiles.Items.Item(zFindex).ToString
                zFname2 = Mid(zFname, Len(txtPath.Text) + 2)
                zFname3 = Strings.Replace(zFname2, txtTrim.Text, "")
                If zFname <> vbNullString And zFname3 <> vbNullString And zFname2 <> zFname3 Then
                    My.Computer.FileSystem.RenameFile(zFname, zFname3)
                    'Debug.Print(zFname & txtExt.Text)
                End If
            Next
            'zListDir()
            'zListFiles()
            'need a timer here to wait for the file system to refresh
            tmRefresh.Enabled = True
        End If
zHandler:
        If (TypeOf Err.GetException() Is System.UnauthorizedAccessException) Then
            ' Code for handling the error is entered here.
            If ckMsg.Checked = True Then
                MessageBox.Show("access denied")
            End If
            Resume Next
        End If
    End Sub

    Private Sub listFiles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listFiles.SelectedIndexChanged
        If listFiles.SelectedItem = Nothing Then Exit Sub
        If txtPath.Text = vbNullString Then Exit Sub
        Dim zFname As String
        Dim zFname2 As String
        Dim zPl As Integer
        zFname = listFiles.SelectedItem.ToString
        'Debug.Print(Len(txtPath.Text))
        zPl = Len(txtPath.Text)
        If zPl = 3 Then
            zFname2 = Mid(zFname, Len(txtPath.Text) + 1)
        Else
            zFname2 = Mid(zFname, Len(txtPath.Text) + 2)
        End If
        'zFname2 = Strings.Replace(zFname, txtPath.Text, "")
        lbFn.Text = zFname2
    End Sub

    Private Sub btSubD_Click(sender As Object, e As EventArgs) Handles btSubD.Click
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
        zListDir()
        zListFiles()

        If listDirectories.Items.Count = 0 Then
            MessageBox.Show("no sub directories in current directory")
            Exit Sub
        End If

        listSubD1.Items.Clear()
        listFiles.Items.Clear()

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
            If listDirectories.Items.Count > 0 Then
                For zSDI = 0 To listDirectories.Items.Count - 1
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
    End Sub

    Private Sub btClearSub_Click(sender As Object, e As EventArgs) Handles btClearSub.Click
        listSubD1.Items.Clear()
        lbSubDCount.Text = "0"
    End Sub

    Private Sub btReplace_Click(sender As Object, e As EventArgs) Handles btReplace.Click
        zReplaceStringFiles()
    End Sub

    Public Sub zReplaceStringFiles()
        On Error GoTo zHandler
        'this removes any matching text from the file name
        'and replaces it
        'case sensitive matching for now

        If txtPath.Text = vbNullString Then
            txtPath.Text = "C:\"
        End If
        If LCase(txtPath.Text) = "d:\" Then
            MessageBox.Show("d:\ is restricted")
            Exit Sub
        ElseIf LCase(txtPath.Text) = "c:\" Then
            MessageBox.Show("c:\ is restricted")
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

                zFname = listFiles.Items.Item(zFindex).ToString
                zFname2 = Mid(zFname, Len(txtPath.Text) + 2)
                zFname3 = Strings.Replace(zFname2, txtMatch.Text, txtReplace.Text)
                If zFname <> vbNullString And zFname3 <> vbNullString And zFname2 <> zFname3 Then
                    My.Computer.FileSystem.RenameFile(zFname, zFname3)
                    'Debug.Print(zFname & txtExt.Text)
                End If
            Next
            'zListDir()
            'zListFiles()
            'need a timer here to wait for the file system to refresh
            tmRefresh.Enabled = True
        End If
zHandler:
        If (TypeOf Err.GetException() Is System.UnauthorizedAccessException) Then
            ' Code for handling the error is entered here.
            If ckMsg.Checked = True Then
                MessageBox.Show("access denied")
            End If
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
            If System.IO.Directory.Exists(txtPath.Text) = False Then
                txtPath.Text = "C:\"
                MessageBox.Show("path does not exist")
                Exit Sub
            End If
            zListDir()
            zListFiles()
            listHist.Items.Add(txtPath.Text)
            listHist.SetSelected((listHist.Items.Count - 1), True)
        End If
    End Sub
End Class