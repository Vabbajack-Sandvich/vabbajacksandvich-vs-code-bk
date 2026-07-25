Imports System.ComponentModel
Imports System.Runtime.Intrinsics

Public Class Form1


    Public Const HTCAPTION As Long = 2
    Public Const WM_NCLBUTTONDOWN As Long = &HA1

    Public Declare Function ReleaseCapture Lib "user32" () As Long
    Public Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal Handle As Long, ByVal wMsg As Long, ByVal wParam As Long, <System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.AsAny)> lParam As Object) As Long

    'to use:
    'put in mouse down

    'If e.Button = MouseButtons.Left Then
    '    ReleaseCapture()
    '    SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0&)
    'End If

    Private Sub zSave()
        'this doesnt write the backup file
        'that only happens once during load
        'and not on exit either
        'or the save timer

        Dim zFile As String
        zFile = txtLog.Text

        If zFile = vbNullString And zFirstVersionWhenLoaded = vbNullString Then
            'text box is empty
            'first version is empty
            'first run probably
            'or a reset
            'this is just for writing the first log file
            'which skips the error of "file not found" by making one
            'even if its empty
            'even if there wasnt and zfile is still nothing for the first run
            'write the file

            'if there is a previous version restore everything
            'if there isnt, do nothing, its probably the first run
            If zPreviousLog <> vbNullString Then
                zFile = zPreviousLog
                zFirstVersionWhenLoaded = zFile
                txtLog.Text = zFile
            End If
            My.Computer.FileSystem.WriteAllText("D:\zonide\glog\glog.log", zFile, False)

        ElseIf zFile <> vbNullString And zFirstVersionWhenLoaded <> vbNullString Then
            'the text box isnt empty
            'the first version isnt empty
            If zFile <> zFirstVersionWhenLoaded Then
                'there have been changes
                'save it
                My.Computer.FileSystem.WriteAllText("D:\zonide\glog\glog.log", zFile, False)
            End If
            'no point in putting if there havent been changes

        ElseIf zFile = vbNullString And zFirstVersionWhenLoaded <> vbNullString Then
            'the text box is empty
            'the first version isnt empty
            'assume a screw up because of an empty text box
            'then restore the first working version

            zFile = zFirstVersionWhenLoaded
            txtLog.Text = zFile

            If zFile <> zFirstVersionWhenLoaded Then
                'there have been changes
                'save it
                My.Computer.FileSystem.WriteAllText("D:\zonide\glog\glog.log", zFile, False)
                'no changes would be do nothing so
                'im not making the else tree
            End If

            'else would go here
            'no changes would be do nothing so
            'im not making the else tree
        End If
    End Sub

    Public zSaveCount As Integer
    Public zFirstVersionWhenLoaded As String
    Public zPreviousLog As String

    Public Sub zSnapResizerToMain()
        'frmResizer.Show()
        'frmResizer.TopMost = True

        frmResizer.Left = Me.Left + Me.Width - frmResizer.Width
        frmResizer.Top = Me.Top + Me.Height - frmResizer.Height

        zPreviousResizerLocationX = frmResizer.Left
        zPreviousResizerLocationY = frmResizer.Top

        'this does the same as these 2 lines

        ''getting location
        'Dim Form1Point As Point
        'Form1Point = Me.Location
        'Debug.Print("Form1.Left - " & Me.Left)
        'Debug.Print("Form1.Top - " & Me.Top)
        'Debug.Print("Form1 Form1Point.X - " & Form1Point.X)
        'Debug.Print("Form1 Form1Point.Y - " & Form1Point.Y)
        '
        'Dim frmResizerPoint As Point
        'frmResizerPoint = frmResizer.Location
        'Debug.Print("frmResizer.Left - " & frmResizer.Left)
        'Debug.Print("frmResizer.Top - " & frmResizer.Top)
        'Debug.Print("frmResizerPoint - " & frmResizerPoint.X)
        'Debug.Print("frmResizerPoint - " & frmResizerPoint.Y)
        '
        ''hmm same values either way
        '
        ''setting location
        ''frm.Location = New Point(100, 300)
        'frmResizer.Location = New Point(Form1Point.X + Me.Width - frmResizer.Width, Form1Point.Y + Me.Height - frmResizer.Height)


    End Sub

    'going to start putting public variables and subs above form load
    'so its easy to click to

    'this is for the undo list
    Public zUndolist As ListBox
    Public zUndolistD As ListBox

    Public Sub zWriteTimeStampedBackup()
        On Error GoTo zHandler
        'this is for manual backups
        'incase shit gets really fucked up somehow
        'decided by accident in the middle of this
        'that leaving the original code for the form loading that deals with this
        'is the easiest way
        'and just loading the log file in this sub independantly
        'then i can just add this sub where i need it

        Dim zFTD As String
        zFTD = DateString & "_" & TimeString.Replace(":", "-")
        Dim zFile As String
        'D:\zonide\glog\glog-bk

        'zFile = My.Computer.FileSystem.ReadAllText("D:\zonide\glog\glog.log")
        zFile = My.Computer.FileSystem.ReadAllText("D:\zonide\glog\glog.log")

        If zFile <> "" Then
            'only write the time stamped back up if the log has anything it
            'fuck it if it doesnt
            'My.Computer.FileSystem.WriteAllText("D:\zonide\glog\glog-bk.log", zFile, False)
            My.Computer.FileSystem.WriteAllText("D:\zonide\glog\glog-bk\" & zFTD & "_glog-bk.log", zFile, False)
        End If

        Exit Sub

zHandler:
        'something got fucked up
        MsgBox("zWriteTimeStampedBackup - " & zR2 & Err.Description, vbOKOnly, "gLog - Error")
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        On Error GoTo zHandler

        'just adding this at the very start
        'because the way i wrote it, it should account for any potential
        'other shit, and write the time stamped backup before
        'any potential other shit fucks up the files
        zWriteTimeStampedBackup()

        'this is for importing the search form
        'just so i dont forget again
        'the way this works, is, every thing on the form
        'calls these two "fake" runtime objects
        'calling the runtime objects that are created by the import form
        'from within the form
        'means i can set these two things to whichever text box
        'or form i want to
        'and the find form modular import will operate just fine
        'using all of the data and controls for the fake controls
        'but actually using the real controls that have been passed to it
        'small snag, this program uses a rich textbox
        'so i need to modify either the textbox
        'or the form
        'im modding the form
        'changing the thing to rich text box on the other form
        'seemed to work with no other changes

        frmTextBoxFindPopUpModular.zTxtLog = txtLog
        frmTextBoxFindPopUpModular.zFormTemp = Me

        Dim zUndoListT As New ListBox
        zUndolist = zUndoListT
        'MsgBox("zundolist handle test - " & zUndolist.Handle.ToString)
        'zUndolist.Items.Add("farts")
        'MsgBox(zUndolist.Items.Item(0))
        'cool this works

        'temp list box for deduplication
        Dim zUndoListTD As New ListBox
        zUndolistD = zUndoListTD

        Me.Controls.Add(zUndolist)
        Me.Controls.Add(zUndolistD)

        zUndolist.Visible = False
        zUndolistD.Visible = False


        'default form size
        '1200, 675


        'do the resizer stuff before the log stuff

        frmResizer.Show()
        frmResizer.TopMost = True

        'zSnapResizerToMain()

        'set the log textbox to the right spot
        '6, 162
        '4, 206
        txtLog.Left = 4
        txtLog.Top = 206

        'Debug.Print(txtLog.Top)
        'Debug.Print(txtLog.Left)
        'End

        'DateTimePicker1.Format = DateTimePickerFormat.Custom
        'DateTimePicker1.CustomFormat = "MMMM dd, yyyy - dddd"


        Dim zFile As String

        zFile = My.Computer.FileSystem.ReadAllText("D:\zonide\glog\glog.log")
        txtLog.Text = zFile

        'this is for comparing any changes to, to avoid saving the same thing
        zFirstVersionWhenLoaded = zFile

        'this is the backup which saves the previous version
        'this doesnt change by the save function
        'only on load does this get updated
        'this is for overwriting the previous back up if there were no changes
        'kind of overkill
        'might not use it
        'then again i could make a restore button
        zPreviousLog = My.Computer.FileSystem.ReadAllText("D:\zonide\glog\glog-bk.log")

        'after the current backup gets read in to memory for restore
        'the new back up gets written by using the current version
        'of the new file from zFile.
        'which means, i can restore the old version from memory with restore
        'and the new back up only gets written every time the program is started
        'and not any other time
        'which means when i close the program
        'the backup will always be the previous version
        'changes or not.

        'but....

        'there is another case where no text box, no first version
        'but there is a previous version from the backup
        'so before writing
        'restore everything

        'adding a timestamped backup in addtion to the regular method
        'it just uses the current zFile, if there is one
        'and writes it to a time stamped back up
        'as a back up back up that isnt the restore backup
        'path
        'D:\zonide\glog\glog-bk


        If zFile = vbNullString And zPreviousLog = vbNullString Then
            'empty file
            'empty backup
            'assume first run or reset
            My.Computer.FileSystem.WriteAllText("D:\zonide\glog\glog-bk.log", zFile, False)
            zSaveCount = 1
            Exit Sub
        ElseIf zFile = vbNullString And zPreviousLog <> vbNullString Then
            'empty file
            'non empty backup
            'assume a screw up some how
            'this means that the current log was empty
            'but the previous log was fine
            'restore everything to the backup
            zFile = zPreviousLog
            zFirstVersionWhenLoaded = zFile
            My.Computer.FileSystem.WriteAllText("D:\zonide\glog\glog.log", zFile, False)
            'My.Computer.FileSystem.WriteAllText("D:\zonide\glog\glog-bk.log", zFile, False)
            zSaveCount = 1
            Exit Sub
        ElseIf zFile <> vbNullString And zPreviousLog = vbNullString Then
            'this shouldnt happen
            'but just in case
            'non empty file
            'empty backup
            'just write the file to the backup and go from there in the cycle
            'of backing up the file
            'fix zpreviouslog
            zPreviousLog = zFile
            My.Computer.FileSystem.WriteAllText("D:\zonide\glog\glog-bk.log", zFile, False)
            zSaveCount = 1
            Exit Sub
        ElseIf zFile <> vbNullString And zPreviousLog <> vbNullString Then
            'neither are empty
            'this should be the normal start
            'where there is stuff in both things
            'nothing is weird or screwed up
            'just write the current file to the backup
            My.Computer.FileSystem.WriteAllText("D:\zonide\glog\glog-bk.log", zFile, False)
            zSaveCount = 1
            Exit Sub
        End If

        'this is the old end of this before the handler
        'the code shouldnt get here now

        'My.Computer.FileSystem.WriteAllText("D:\zonide\glog\glog-bk.log", zFile, False)

        'zSaveCount = 1

        'just incase


        Exit Sub

zHandler:

        zSave()

        'this is old
        'and is written this way out of laziness
        'and that it handles the error of no log file by writing one
        'and doing it silently

        'the save function does the same thing as the code below

        'MsgBox("no log file found", MsgBoxStyle.OkOnly, "Error: no log")
        'zFile = txtLog.Text
        'My.Computer.FileSystem.WriteAllText("D:\zonide\glog\glog.log", zFile, False)
    End Sub

    Private Sub Form1_ResizeEnd(sender As Object, e As EventArgs) Handles MyBase.ResizeEnd


    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        'txtLog.Height = Me.Height - 130
        'txtLog.Height = Me.Height - 145
        'txtLog.Height = Me.Height - 170
        txtLog.Height = Me.Height - 214
        'txtLog.Width = Me.Width - 45
        txtLog.Width = Me.Width - 60

        'default form size
        '1200, 675
        If Me.Width < 1200 Then
            Me.Width = 1200
        End If
        If Me.Height < 300 Then
            Me.Height = 300
        End If

        'zSnapResizerToMain()

    End Sub

    Public zPreviousResizerLocationX As Integer = -1
    Public zPreviousResizerLocationY As Integer = -1

    Private Sub tmrDate_Tick(sender As Object, e As EventArgs) Handles tmrDate.Tick

        Dim zTD As String

        zTD = DateString & " - " & TimeString

        txtDate.Text = zTD

    End Sub

    Private Sub cbCopy_Click(sender As Object, e As EventArgs) Handles cbCopy.Click
        Clipboard.SetText(txtDate.Text)
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        zSave()
    End Sub

    Public Sub zDisplayUndoLists()
        'just for debug purposes im going to make them visible
        zUndolist.Visible = True
        zUndolistD.Visible = True

        zUndolist.Width = 300
        zUndolist.Height = 200
        zUndolistD.Width = 300
        zUndolistD.Height = 200

        zUndolist.BackColor = Color.Black
        zUndolistD.BackColor = Color.Black

        zUndolist.ForeColor = Color.DarkGreen
        zUndolistD.ForeColor = Color.DarkGreen

        zUndolist.Top = btUndoBack.Top + btUndoBack.Height
        zUndolist.Left = btUndoBack.Left

        zUndolistD.Top = zUndolist.Top
        zUndolistD.Left = zUndolist.Left + zUndolist.Width + 5

        txtLog.Top = zUndolist.Top + zUndolist.Height + 10
        txtLog.Left = zUndolist.Left


        zUndolist.BringToFront()
        zUndolistD.BringToFront()

    End Sub

    Private Sub tmrRunOnce_Tick(sender As Object, e As EventArgs) Handles tmrRunOnce.Tick
        Dim zLog As String

        zLog = txtLog.Text
        'Debug.Print(zLog.Length)
        txtLog.Select(zLog.Length, 0)
        txtLog.Focus()

        '38, 36
        'Me.Width = 38
        'Me.Height = 38
        'Debug.Print("run once timer should be setting the resizer size")
        'doesnt, not sure why
        'frmResizer.Width = 38
        'frmResizer.Height = 38
        'frmResizer.lbResizerX.Left = (38 / 2) - (frmResizer.lbResizerX.Width / 2)
        'frmResizer.lbResizerX.Top = (38 / 2) - (frmResizer.lbResizerX.Height / 2)

        'zSnapResizerToMain()

        'zDisplayUndoLists()

        zUndoUpdate()

        'DateTimePicker1.CustomFormat = "MMMM dd, yyyy - dddd"
        'MM'/'dd'/'yyyy hh':'mm tt

        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "MM-dd-yyyy"

        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = "MM-dd-yyyy"

        tmrRunOnce.Enabled = False
    End Sub

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click
        zSave()
    End Sub

    Private Sub tmrSave_Tick(sender As Object, e As EventArgs) Handles tmrSave.Tick
        Select Case zSaveCount
            Case 60
                zSaveCount = 1
                zSave()
                lbSave.Text = zSaveCount
                Exit Sub
        End Select
        zSaveCount = zSaveCount + 1
        lbSave.Text = zSaveCount
    End Sub

    Private Sub btRestore_Click(sender As Object, e As EventArgs) Handles btRestore.Click
        Dim zMsg As MsgBoxResult = MsgBox("Are you sure you want to restore to the previous log?", vbYesNo, "gLog")
        If zMsg = vbYes Then
            If zPreviousLog <> vbNullString Then
                'dont restore to empty
                'protects for first run screw ups
                txtLog.Text = zPreviousLog
            End If
        End If
    End Sub

    Private Sub btTop_Click(sender As Object, e As EventArgs) Handles btTop.Click
        If Len(txtLog.Text) > 0 Then
            txtLog.SelectionStart = 0
            txtLog.SelectionLength = 0
            txtLog.Select()
            txtLog.ScrollToCaret()
        End If
    End Sub

    Private Sub btEnd_Click(sender As Object, e As EventArgs) Handles btEnd.Click
        If Len(txtLog.Text) > 0 Then
            txtLog.SelectionStart = Len(txtLog.Text)
            txtLog.SelectionLength = 0
            txtLog.Select()
            txtLog.ScrollToCaret()
        End If
    End Sub

    Private Sub btFindCaret_Click(sender As Object, e As EventArgs) Handles btFindCaret.Click
        If Len(txtLog.Text) > 0 Then
            If txtLog.SelectionStart > -1 Then
                'txtLog.SelectionStart = Len(txtLog.Text)
                txtLog.SelectionLength = 0
                txtLog.Select()
                txtLog.ScrollToCaret()
            ElseIf txtLog.SelectionStart = -1 Then
                'no selection go to end
                txtLog.SelectionStart = Len(txtLog.Text)
                txtLog.SelectionLength = 0
                txtLog.Select()
                txtLog.ScrollToCaret()
            End If
        End If
    End Sub

    Private Sub Form1_MaximizedBoundsChanged(sender As Object, e As EventArgs) Handles Me.MaximizedBoundsChanged

    End Sub

    Private Sub lbTitle_Click(sender As Object, e As EventArgs) Handles lbTitle.Click

    End Sub

    Private Sub lbTitle_MouseDown(sender As Object, e As MouseEventArgs) Handles lbTitle.MouseDown
        If e.Button = MouseButtons.Left Then
            'zMouseLeftClick = True
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0&)
        End If
    End Sub

    Private Sub btClose_Click(sender As Object, e As EventArgs) Handles btClose.Click
        End
    End Sub

    Private Sub btMinimize_Click(sender As Object, e As EventArgs) Handles btMinimize.Click
        tmrDate.Enabled = False
        Me.WindowState = FormWindowState.Normal
        Me.WindowState = FormWindowState.Minimized
        tmrDate.Enabled = True
    End Sub

    Private Sub lbTitle_MouseUp(sender As Object, e As MouseEventArgs) Handles lbTitle.MouseUp
        'zSnapResizerToMain()
    End Sub

    Private Sub lbTitle_MouseMove(sender As Object, e As MouseEventArgs) Handles lbTitle.MouseMove
        zSnapResizerToMain()
    End Sub

    Public zPrevTop As Integer
    Public zPrevLeft As Integer
    Public zPrevHeight As Integer
    Public zPrevWidth As Integer

    Private Sub btMaximize_Click(sender As Object, e As EventArgs) Handles btMaximize.Click
        If Me.WindowState = FormWindowState.Normal Then
            zPrevTop = Me.Top
            zPrevLeft = Me.Left
            zPrevHeight = Me.Height
            zPrevWidth = Me.Width
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
            Me.Top = Top
            Me.Left = zPrevLeft
            Me.Height = zPrevHeight
            Me.Width = zPrevWidth
        End If
        zSnapResizerToMain()
    End Sub

    'this is for making sure the undo dedupe doesnt run while this one runs
    Public zDedupeTimer As Boolean = False

    Public Sub zUndoUpdate()

        'this doesnt de duplicate entries or sort them
        'this just takes snap shots in time
        'so going through the undo list a bunch of times will end up
        'where you create new entries

        'i might want to deduplicate this everytime

        If zUndolist.Items.Count = 0 Then
            If txtLog.Text <> vbNullString Then
                zUndolist.Items.Add(txtLog.Text)
            End If
            Exit Sub
        Else
            'this fixes the selection for iterating through the list
            'just incase it ever happens to get deselected somehow
            If zUndolist.SelectedIndex() = -1 Then
                'nothing selected
                'might happen on load or with nothing in the box after the first item
                'being added
                'set it to the last entry
                'this way i dont need a global that tracks this since
                'the list box control does that anyway
                zUndolist.SetSelected(zUndolist.Items.Count - 1, True)
            End If

            Dim zPreviousSindex As Integer = zUndolist.SelectedIndex

            Dim zLastEntry As String
            zLastEntry = zUndolist.Items.Item(zUndolist.Items.Count - 1)
            'If txtLog.Text <> zLastEntry Then
            'last entry in the undo log is not the same as the text box
            'so add it as the last entry

            'add the new entry to the end
            'If txtLog.Text <> zLastEntry Then
            'zUndolist.Items.Insert(zPreviousSindex, txtLog.Text)
            zUndolist.Items.Add(txtLog.Text)
            'End If

            'add deduplication here
            zUndolistD.Items.Clear()
            Dim zI As Integer
            Dim zI2 As Integer
            Dim zTs As String
            Dim zTs2 As String
            Dim zInDupe As Boolean = False

            zDedupeTimer = True

            For zI = 0 To zUndolist.Items.Count - 1
                'main undo list
                'entry being searched for
                zTs = zUndolist.Items.Item(zI)
                If zUndolistD.Items.Count > 0 Then
                    For zI2 = 0 To zUndolistD.Items.Count - 1
                        'temp list
                        'temp entry to compare against
                        zTs2 = zUndolistD.Items.Item(zI2)
                        If zTs = zTs2 Then
                            zInDupe = True
                        End If
                    Next

                    If zInDupe = False Then
                        'entry was not in the dupe box
                        'add it to the dupe box
                        zUndolistD.Items.Add(zTs)
                    Else
                        'set to false for next pass
                        zInDupe = False
                    End If
                Else
                    zUndolistD.Items.Add(zTs)
                    zInDupe = False
                End If
            Next

            'clear the regular list and fill it with the temp list

            zUndolist.Items.Clear()

            For zI = 0 To zUndolistD.Items.Count - 1
                zUndolist.Items.Add(zUndolistD.Items.Item(zI))
            Next

            'clear the temp list just because
            zUndolistD.Items.Clear()

            If zPreviousSindex >= 0 And zPreviousSindex <= zUndolist.Items.Count - 1 Then
                zUndolist.SelectedIndex = zPreviousSindex
            End If


            If zUndolist.SelectedIndex() = -1 Then
                'nothing selected
                'might happen on load or with nothing in the box after the first item
                'being added
                'set it to the last entry
                'this way i dont need a global that tracks this since
                'the list box control does that anyway
                zUndolist.SetSelected(zUndolist.Items.Count - 1, True)
            End If
            'End If

            zDedupeTimer = False
        End If

    End Sub


    Private Sub tmrUndoListUpdate_Tick(sender As Object, e As EventArgs) Handles tmrUndoListUpdate.Tick
        zUndoUpdate()
    End Sub

    Private Sub txtLog_TextChanged(sender As Object, e As EventArgs) Handles txtLog.TextChanged

    End Sub

    Private Sub txtLog_KeyUp(sender As Object, e As KeyEventArgs) Handles txtLog.KeyUp
        If zUndolist.Items.Count > 0 Then
            'If zUndolist.SelectedIndex() = -1 Then
            zUndolist.SetSelected(zUndolist.Items.Count - 1, True)
            'End If
        End If

    End Sub

    Public Sub zUpdateUndo(zInt As Integer)

        'zint
        '0 = move backward through undo list
        '1 = move forward through undo list

        If zInt > 1 Then Exit Sub
        If zInt < 0 Then Exit Sub

        If zDedupeTimer = True Then Exit Sub

        Dim zBeforeUndo As String = txtLog.Text

        If zUndolist.Items.Count = 0 Then
            Exit Sub
        Else
            'this fixes the selection for iterating through the list
            'just incase it ever happens to get deselected somehow
            If zUndolist.SelectedIndex() = -1 Then
                'nothing selected
                'might happen on load or with nothing in the box after the first item
                'being added
                'set it to the last entry
                'this way i dont need a global that tracks this since
                'the list box control does that anyway
                zUndolist.SetSelected(zUndolist.Items.Count - 1, True)
            Else
                'something is selected
                'move through the list and update the textbox
                Dim zSelI As Integer
                zSelI = zUndolist.SelectedIndex

                If zInt = 0 Then
                    'backward
                    If zSelI = 0 Then
                        'at zero loop back to the max
                        zUndolist.SetSelected(zUndolist.Items.Count - 1, True)
                    ElseIf zSelI = zUndolist.Items.Count - 1 Then
                        zUndolist.SetSelected(zSelI - 1, True)
                    Else
                        zUndolist.SetSelected(zSelI - 1, True)
                    End If
                ElseIf zInt = 1 Then
                    'forward
                    If zSelI = 0 Then
                        zUndolist.SetSelected(zSelI + 1, True)
                    ElseIf zSelI = zUndolist.Items.Count - 1 Then
                        'at the max go to 0
                        zUndolist.SetSelected(0, True)
                    Else
                        zUndolist.SetSelected(zSelI + 1, True)
                    End If
                End If

                'update the index after the move

                zSelI = zUndolist.SelectedIndex

                txtLog.Text = zUndolist.Items.Item(zSelI)

                If zUndolist.Items.Count > 0 Then
                    'this dedupe only adds the new entry
                    'if it isnt a duplicate
                    Dim zI As Integer
                    Dim zDupe As Boolean = False
                    For zI = 0 To zUndolist.Items.Count - 1
                        If zUndolist.Items.Item(zI) = zBeforeUndo Then
                            zDupe = True
                        End If
                    Next
                    If zDupe = False Then
                        If zUndolist.Items.Count > 1 Then
                            If zUndolist.Items.Count >= 15 Then
                                'remove the lowest in the list before adding another
                                'the list has hit the upper limit or past it
                                zUndolist.Items.Remove(0)
                            End If
                        End If
                        zUndolist.Items.Add(zBeforeUndo)
                    End If
                End If

                If txtLog.Text <> vbNullString Then
                    txtLog.SelectionStart = Len(txtLog.Text)
                    txtLog.Select()
                    txtLog.ScrollToCaret()
                End If
            End If


        End If

    End Sub

    Private Sub btUndoBack_Click(sender As Object, e As EventArgs) Handles btUndoBack.Click
        zUpdateUndo(0)
    End Sub

    Private Sub btUndoForward_Click(sender As Object, e As EventArgs) Handles btUndoForward.Click
        zUpdateUndo(1)
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
    End Sub

    Private Sub btInsertDate_Click(sender As Object, e As EventArgs) Handles btInsertDate.Click
        Dim zTs As String
        'going to go for this output format
        'ended up adding more to it
        'fake numbers
        '1 == 02-14-2025
        '2 == 02-15-2025
        '4 == 03-14-2025
        '8 == 04-11-2025
        '9 == 04-18-2025

        'need to set the date constructor properly first
        'Dim specificDate As New DateTime(2025, 3, 18, 14, 30, 0)

        'this should filter out the day month and year in to seperate public
        'variables in the vabbajack module
        zTimeDateFilter(DateTimePicker1.Text)
        'zTDm
        'zTDd
        'zTDy
        If zTDm = vbNullString Then Exit Sub
        If zTDd = vbNullString Then Exit Sub
        If zTDy = vbNullString Then Exit Sub

        '2 weeks
        '2 * 7 = 14 days
        '4 weeks
        '4 * 7 = 28 days
        '8 weeks
        '8 * 7 = 56 days
        '9 weeks
        '9 * 7 = 63 days

        Dim z2ws As String
        Dim z4ws As String
        Dim z8ws As String
        Dim z9ws As String
        Dim z10ws As String

        Dim zTempDate As New DateTime(CInt(zTDy), CInt(zTDm), CInt(zTDd))

        z2ws = zTempDate.Date.AddDays(14)
        z4ws = zTempDate.Date.AddDays(28)
        z8ws = zTempDate.Date.AddDays(56)
        z9ws = zTempDate.Date.AddDays(63)
        z10ws = zTempDate.Date.AddDays(70)

        z2ws = z2ws.Replace("/", "-")
        z4ws = z4ws.Replace("/", "-")
        z8ws = z8ws.Replace("/", "-")
        z9ws = z9ws.Replace("/", "-")
        z10ws = z10ws.Replace("/", "-")

        'out string
        Dim zWeekOut As String

        zWeekOut = zWeekOut & zEq & zR
        If ck2Week.Checked = True Then
            zWeekOut = zWeekOut & "====== 2 Week Cycle Batch #" & zR
            zWeekOut = zWeekOut & "====== start date == " & DateTimePicker1.Text & " + X days = output" & zR
        End If
        If ckMoonCycle.Checked = True Then
            zWeekOut = zWeekOut & "====== Moon Cycle 1 Month Batch #" & zR
            zWeekOut = zWeekOut & "====== start date == " & DateTimePicker1.Text & " + X days = output" & zR
        End If
        zWeekOut = zWeekOut & zEq & zR
        zWeekOut = zWeekOut & "0 week  == start date == " & DateTimePicker1.Text & zR

        '14 days
        '28 days
        '56 days
        '63 days
        '70 days

        'this is for 2 week cycle
        If ck2Week.Checked = True Then
            zWeekOut = zWeekOut & "2 weeks == 14 days == " & z2ws & " == next 2 week cycle start date goal" & zR
            zWeekOut = zWeekOut & "4 weeks == 28 days == " & z4ws & zR
            zWeekOut = zWeekOut & "8 weeks == 56 days == " & z8ws & zR
            zWeekOut = zWeekOut & "9 weeks == 63 days == " & z9ws & zR
            zWeekOut = zWeekOut & "10 weeks == 70 days == " & z10ws & zR
        End If

        If ckMoonCycle.Checked = True Then
            zWeekOut = zWeekOut & "2 weeks == 14 days == " & z2ws & zR
            zWeekOut = zWeekOut & "4 weeks == 28 days == " & z4ws & " == next 1 month moon cycle start date goal" & zR
            'zWeekOut = zWeekOut & "4 weeks == " & z4ws & zR
            'zWeekOut = zWeekOut & "8 weeks == " & z8ws & " == next moon cycle clone" & zR
            zWeekOut = zWeekOut & "8 weeks == 56 days == " & z8ws & zR
            zWeekOut = zWeekOut & "9 weeks == 63 days == " & z9ws & zR
            zWeekOut = zWeekOut & "10 weeks == 70 days == " & z10ws & zR
        End If

        zWeekOut = zWeekOut & zEq

        zTs = zWeekOut

        'this puts selection point at the end of insert
        'zInsertTextIntoRichTextbox(txtLog, zTs, 3)
        'trying selection point at original spot
        'zInsertTextIntoRichTextbox(txtLog, zTs, 5)
        'added scrollscan
        zInsertTextIntoRichTextbox(txtLog, zTs, 5, -10)

    End Sub

    Private Sub btTimeStamp_Click(sender As Object, e As EventArgs) Handles btTimeStamp.Click
        'new code uses zInsertTextIntoTextbox
        'got tired of having to do the same thing
        'made it modular

        Dim zTs As String
        'zTs = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")

        zTs = txtDate.Text
        zTs = "==== " & zTs & " === "

        zInsertTextIntoRichTextbox(txtLog, zTs, 1)

    End Sub

    Public zEq As String = "=============================="

    Private Sub btAddEqualsLine_Click(sender As Object, e As EventArgs) Handles btAddEqualsLine.Click
        'inserts the equals break line

        zInsertTextIntoRichTextbox(txtLog, zEq, 3)
    End Sub

    Private Sub btCompare_Click(sender As Object, e As EventArgs) Handles btCompare.Click


        'Debug.Print(DateDiff(DateInterval.Day, DateTime.Now, z9w))
        Dim zOut As String
        zOut = zOut & zEq & zR
        zOut = zOut & "Date 1 - " & DateTimePicker1.Text & zR
        zOut = zOut & "Date 2 - " & DateTimePicker2.Text & zR
        zOut = zOut & "Days Difference - " & DateDiff(DateInterval.Day, DateTimePicker1.Value, DateTimePicker2.Value) & zR
        zOut = zOut & zEq

        'zInsertTextIntoRichTextbox(txtLog, zOut, 3)
        zInsertTextIntoRichTextbox(txtLog, zOut, 5, 10)

    End Sub

    Private Sub btFind_Click(sender As Object, e As EventArgs) Handles btFind.Click
        'have to set this everytime before the form gets shown
        'it "forgets" when it gets closed
        frmTextBoxFindPopUpModular.zFormTemp = Me
        frmTextBoxFindPopUpModular.zTxtLog = txtLog
        frmTextBoxFindPopUpModular.Show()
    End Sub

    Private Sub ck2Week_CheckedChanged(sender As Object, e As EventArgs) Handles ck2Week.CheckedChanged

    End Sub

    Private Sub ckMoonCycle_CheckedChanged(sender As Object, e As EventArgs) Handles ckMoonCycle.CheckedChanged

    End Sub

    Private Sub ck2Week_MouseUp(sender As Object, e As MouseEventArgs) Handles ck2Week.MouseUp
        If ck2Week.Checked = True Then
            ckMoonCycle.Checked = False
        Else
            ckMoonCycle.Checked = True
        End If
    End Sub

    Private Sub ckMoonCycle_MouseUp(sender As Object, e As MouseEventArgs) Handles ckMoonCycle.MouseUp
        If ckMoonCycle.Checked = True Then
            ck2Week.Checked = False
        Else
            ck2Week.Checked = True
        End If
    End Sub
End Class
