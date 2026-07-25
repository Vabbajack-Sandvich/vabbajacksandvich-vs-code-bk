

Imports System.IO

Public Class SDTForm1
    Public Shared zStatus As Boolean
    Public zStxt(2) As String

    'current timer count in seconds
    Public zTc As Long

    'this is the new versions total seconds for the counter
    'instead of counting up to 3600 it counts up to this variable
    Public zTotalSeconds As Long

    'these are for the readout calculation sub and count down labels
    'totals
    Public ztHours As Integer
    Public ztMinutes As Integer
    Public ztSeconds As Integer

    'remaining - uses total seconds - current timer counter
    Public zrHours As Integer
    Public zrMinutes As Integer
    Public zrSeconds As Integer

    'elapsed - uses current timer counter
    Public zeHours As Integer
    Public zeMinutes As Integer
    Public zeSeconds As Integer

    'this is for file loading
    Public zBasePath As String
    Public zBaseFileName As String
    Public zBpFn As String
    Public zGsS As String
    Public zMode As String

    Private Sub SDTForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'shutdown timer code - original start state
        zStxt(0) = "Off"
        zStxt(1) = "On"

        zReset()

        Me.TopMost = True

        'set the default total seconds to 1 hour or 3600 seconds
        zTotalSeconds = 3600

        '--------------

        'new config file loading code

        'config file generation, detection, loading

        'get documents path
        Dim baseDir As String
        baseDir = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        'txtBaseDir.Text = baseDir
        'check if craft-notes folder exists
        Dim DirEx As Boolean
        Dim bdwCn As String
        'base directory with craft-notes
        'bdwCn = baseDir & "\craft-notes-0"
        bdwCn = baseDir & "\ztimer"

        'txtBaseDir.Text = bdwCn
        zBasePath = bdwCn
        DirEx = Directory.Exists(bdwCn)
        If DirEx = False Then
            'if not make folder for craft-notes
            My.Computer.FileSystem.CreateDirectory(zBasePath)
        End If
        'zBaseFileName = "craft-notes-0.txt"
        zBaseFileName = "ztimer.cfg"

        zBpFn = zBasePath & "\" & zBaseFileName
        Dim zFe As Boolean
        zFe = File.Exists(zBpFn)
        Dim zfileReader As String
        If zFe = False Then
            My.Computer.FileSystem.WriteAllText(zBpFn, "mode=1", False)
            'mode: this determines if the timer is in shutdown vlc mode
            'or in timer only mode
            '0=shutdown vlc mode
            'the check boxes are enabled and checked by default
            '1=timer only mode
            'the check boxes are disabled and unchecked by default
            'im setting the default mode to 1
            'incase the kids find or delete the file
            'so the program on first load and by default will be the
            'lock out timer
            zfileReader = My.Computer.FileSystem.ReadAllText(zBpFn)
            'txtLog.Text = zfileReader
            zGsS = zfileReader
        Else
            zfileReader = My.Computer.FileSystem.ReadAllText(zBpFn)
            'txtLog.Text = zfileReader
            'changing this to a global settings string
            'to where i can just pick data out of it as needed
            'zGsS
            zGsS = zfileReader
        End If

        Dim zModeString As String

        zModeString = Mid(zGsS, 6)
        zMode = zModeString

        'MsgBox(zModeString)

        If zModeString = "2" Then
            'this is the temp time of 3 seconds for testing
            txtHours.Text = "0"
            txtMin.Text = "0"
            txtSec.Text = "5"
            zModeString = "1"
            My.Computer.FileSystem.WriteAllText(zBpFn, "mode=1", False)
        ElseIf zModeString = "1" Then
            'set the time for the 2 hour mark
            txtHours.Text = "2"
        End If

        If zModeString = "1" Then
            'this is the manually enabled timer only mode
            'you enable this by changing mode=0 to mode=1
            'in the users documents/ztimer/ztimer.cfg file
            zMode = "1"

            Me.ControlBox = False

            'hit the convert button to update the mode times
            zCt()

            lbRemaining.BackColor = Color.Green

            ckCloseVLC.Checked = False
            ckCloseVLC.Enabled = False
            ckShutdown.Checked = False
            ckShutdown.Enabled = False
            btSet.Enabled = False
            btReset.Enabled = False
            btConvert.Enabled = False
            txtHours.Enabled = False
            txtMin.Enabled = False
            txtSec.Enabled = False
            txtSet.Enabled = False

            'visibility
            ckCloseVLC.Visible = False
            ckCloseVLC.Visible = False
            ckShutdown.Visible = False
            ckShutdown.Visible = False
            btSet.Visible = False
            btReset.Visible = False
            btConvert.Visible = False
            txtHours.Visible = False
            txtMin.Visible = False
            txtSec.Visible = False
            txtSet.Visible = False
            lbHours.Visible = False
            lbMin.Visible = False
            lbSec.Visible = False

            'form1 default height is 521
            'short height is 332

            Me.Height = 332

            lbRemaining.ForeColor = Color.White
        Else
            zMode = "0"
            zGsS = "mode=0"
            btClose.Enabled = False
            btClose.Visible = False
            btMin.Enabled = False
            btMin.Visible = False
        End If

        Me.ShowInTaskbar = True

        zTheme(1)

        ckDarkMode.Checked = True

    End Sub

    Public Function zStatusToggle()
        If zStatus = True Then
            'zReset()
            'this just pauses
            zStatus = False
            ShutdownTimer1.Enabled = False

            lbvStatusOnOff.Text = zStxt(0)
            lbvStatusOnOff.BackColor = Color.Red
        Else
            zStatus = True
            lbvStatusOnOff.Text = zStxt(1)
            lbvStatusOnOff.BackColor = Color.Lime
            ShutdownTimer1.Enabled = True
        End If
    End Function

    Public Function zReset()
        'this is also the initialization

        lbvStatusOnOff.Text = zStxt(0)
        lbvStatusOnOff.BackColor = Color.Red

        lbzTc.Text = "0"

        zTc = 0
        zStatus = False
        ShutdownTimer1.Enabled = False

        txtHours.Text = "1"
        txtMin.Text = "0"
        txtSec.Text = "0"

        zTotalSeconds = 3600

        lbTotalHMS.Text = "Total - 1h-0m-0s"

        If zMode = "0" Then
            ckCloseVLC.Checked = True
            ckShutdown.Checked = True
        Else
            lbRemaining.BackColor = Color.Green
        End If

        zUpdateHMS()
    End Function

    Private Sub btToggle_Click(sender As Object, e As EventArgs) Handles btToggle.Click
        zStatusToggle()
        If zMode = "1" Then
            btToggle.Enabled = False
        End If
    End Sub

    Private Sub btReset_Click(sender As Object, e As EventArgs) Handles btReset.Click
        zReset()
    End Sub

    Private Sub ShutdownTimer1_Tick(sender As Object, e As EventArgs) Handles ShutdownTimer1.Tick
        If zStatus = True Then
            If zTc < zTotalSeconds Then
                If zMode = "1" Then
                    lbRemaining.BackColor = Color.Green
                Else
                    If ckDarkMode.Checked = True Then
                        lbRemaining.BackColor = Color.Black
                    Else
                        lbRemaining.BackColor = Color.FromKnownColor(5)
                    End If
                End If
                zTc = zTc + 1
                lbzTc.Text = zTc
                zUpdateHMS()
                If zTc = (zTotalSeconds - 2) Then
                    If ckCloseVLC.Checked = True Then
                        Process.Start("taskkill", "/f /im vlc.exe")
                    End If

                    'need to add a checkbox and later potential add a modular
                    'command list that can be edited and saved
                    'but for now i need to add one for mpc

                    If ckCloseMPC.Checked = True Then
                        Process.Start("taskkill", "/f /im mpc-hc64.exe")
                    End If

                End If
            ElseIf zTc = zTotalSeconds Then
                lbRemaining.BackColor = Color.Red
                'these lines are the debug test
                'need commented out for final version
                'zReset()
                'MsgBox("shutting down")

                'this is the shutdown code
                'needs uncommented for final version
                If zMode = "0" Then
                    If ckShutdown.Checked = True Then
                        ShutdownTimer1.Enabled = False
                        Process.Start("shutdown", "/s /f")
                        Application.Exit()
                        End
                    Else
                        zReset()
                    End If
                ElseIf zMode = "1" Then
                    'this is where we start counting overtime
                    zTc = zTc + 1
                    lbzTc.Text = zTc
                    zUpdateHMS()
                    btMin.Visible = False
                    btMin.Enabled = False
                    Me.FormBorderStyle = FormBorderStyle.None
                    Me.WindowState = WindowState.Maximized
                    'this is also where we send them the time is up message
                    MsgBox("time is up", vbSystemModal, "zTimer")
                End If
            ElseIf zTc > zTotalSeconds Then
                If zMode = "0" Then
                    zReset()
                ElseIf zMode = "1" Then
                    'this is where we start counting overtime
                    zTc = zTc + 1
                    lbzTc.Text = zTc
                    zUpdateHMS()
                    lbRemaining.BackColor = Color.Red
                    Me.WindowState = WindowState.Maximized
                End If
            End If
        End If
    End Sub

    Private Sub btSet_Click(sender As Object, e As EventArgs) Handles btSet.Click
        zSet()
    End Sub

    Public Sub zSet()
        txtSet.Text = zNumFilter(txtSet.Text)
        If txtSet.Text = "" Then
            txtSet.Text = "0"
            zTc = 0
            lbzTc.Text = "0"
        Else
            Dim zTcfc As String
            Dim zTs As String
            Dim zSetPass As Boolean
            Dim zTsL As Long

            zTs = txtSet.Text
            zSetPass = False

            Do
                'this filters out as many potential leading 0s
                'and trims the output to a whole number
                zTsL = Len(zTs)
                If zTsL > 1 Then
                    zTcfc = Mid(zTs, 1, 1)
                    If zTcfc = "0" Then
                        zTs = Mid(zTs, 2, zTsL - 1)
                    Else
                        zSetPass = True
                    End If
                ElseIf zTsL = 1 Then
                    zSetPass = True
                Else
                    zTc = 0
                    lbzTc.Text = zTc
                    Exit Sub
                End If

            Loop Until zSetPass = True

            Dim zTcsc As Single
            zTcsc = CSng(zTs)

            '3600 is the max which is an hour in seconds
            'setting it to the max would trigger the shutdown
            'so im setting it to 3540
            'which gives the user 1 min to do other stuff if it was a mistake

            'If zTcsc > 3600 Then zTcsc = 3600

            'If zTcsc >= 3600 Then zTcsc = 3540

            'zTotalSeconds
            If zTcsc >= zTotalSeconds Then zTcsc = zTotalSeconds

            zTc = CLng(zTcsc)

            lbzTc.Text = zTc
            txtSet.Text = zTc
        End If
    End Sub

    Private Sub btConvert_Click(sender As Object, e As EventArgs) Handles btConvert.Click
        zCt()
    End Sub

    Public Sub zUpdateHMS()

        Dim zH As Integer
        Dim zM As Integer
        Dim zS As Integer

        Dim zMd As Decimal
        Dim zSd As Decimal

        Dim zMi As Decimal
        Dim zSi As Decimal

        Dim zSt As Integer
        Dim zMt As Integer

        'update total seconds label
        lbTotalSec.Text = "Total Seconds - " & zTotalSeconds

        'this is the total amount of seconds - current counter
        'which leaves the remaining amount of seconds
        'for timer countdown converstion to hours min sec

        'this just checks to see if the counter has gone over the total seconds
        'and if it has, instead of counting down
        'it reverses the negative and starts counting back up again
        Dim zOTcheck As Integer

        zOTcheck = zTotalSeconds - zTc

        If zOTcheck < 0 Then
            zOTcheck = zOTcheck * -1
        End If

        zS = zOTcheck

        If zS >= 60 Then
            'decimal division to see how many multiples of 60 there are
            zSd = zS / 60
            'get just the whole number of multiples of 60
            zSi = Int(zSd)
            'subtract the whole multiples from the max to get remaining seconds
            zSt = zS - (zSi * 60)
            'add the whole multiples to the minutes max
            zM = zSi + zM
        Else
            zSt = zS
        End If

        If zM >= 60 Then
            'decimal division to see how many multiples of 60 there are
            zMd = zM / 60
            'get just the whole number of multiples of 60
            zMi = Int(zMd)
            'subtract the whole multiples from the max to get remaining minutes
            zMt = zM - (zMi * 60)
            'add the whole multiples to the hours max
            zH = zMi + zH
        Else
            zMt = zM
        End If

        'set global current hours mins secs value for read outs
        'for elapsed using 
        zrSeconds = zSt
        zrMinutes = zMt
        zrHours = zH

        lbRemaining.Text = "Remaining - " & zrHours & " h - " & zrMinutes & " m - " & zrSeconds & " s"

        'this is for the elapsed counter
        'update the labels with the zTc current counter value

        'reset the values so theres no bleed over
        zH = 0
        zM = 0
        zS = zTc

        If zS >= 60 Then
            'decimal division to see how many multiples of 60 there are
            zSd = zS / 60
            'get just the whole number of multiples of 60
            zSi = Int(zSd)
            'subtract the whole multiples from the max to get remaining seconds
            zSt = zS - (zSi * 60)
            'add the whole multiples to the minutes max
            zM = zSi + zM
        Else
            zSt = zS
        End If

        If zM >= 60 Then
            'decimal division to see how many multiples of 60 there are
            zMd = zM / 60
            'get just the whole number of multiples of 60
            zMi = Int(zMd)
            'subtract the whole multiples from the max to get remaining minutes
            zMt = zM - (zMi * 60)
            'add the whole multiples to the hours max
            zH = zMi + zH
        Else
            zMt = zM
        End If

        'set global current hours mins secs value for read outs
        'for elapsed using 
        zeSeconds = zSt
        zeMinutes = zMt
        zeHours = zH

        lbElapsed.Text = "Elapsed - " & zeHours & " h - " & zeMinutes & " m - " & zeSeconds & " s"

    End Sub

    Private Sub ckCloseVLC_CheckedChanged(sender As Object, e As EventArgs) Handles ckCloseVLC.CheckedChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles ckShutdown.CheckedChanged

    End Sub

    Public Sub zTheme(zT As Integer)

        Dim zCts As String
        Dim zcType As Integer

        Select Case zT
            Case 0
                'default - system theme
                For Each c As Control In Me.Controls
                    zCts = c.Name
                    zcType = InStr(zCts, "txt")
                    'the text boxes use window text
                    'everything else uses control text
                    'for the forecolor
                    'label
                    'control text - 10
                    'c.ForeColor = Color.FromKnownColor(10)
                    'textbox
                    'window text - 26
                    'c.ForeColor = Color.FromKnownColor(26)
                    'background colors:
                    'everything besides the text boxes use control 5
                    'everything else = control = 5
                    'c.backcolor = Color.FromKnownColor(5)
                    'text boxes = winddow = 24
                    'c.backcolor = Color.FromKnownColor(24)

                    If zcType > 0 Then
                        'textbox
                        c.ForeColor = Color.FromKnownColor(26)
                        c.BackColor = Color.FromKnownColor(24)
                    Else
                        'non textbox
                        c.ForeColor = Color.FromKnownColor(10)
                        c.BackColor = Color.FromKnownColor(5)
                    End If
                Next

                Me.BackColor = Color.FromKnownColor(5)

                If zStatus = True Then
                    lbvStatusOnOff.BackColor = Color.Lime
                Else
                    lbvStatusOnOff.BackColor = Color.Red
                End If

            Case 1
                'dark theme
                For Each c As Control In Me.Controls
                    zCts = c.Name
                    zcType = InStr(zCts, "txt")

                    If zcType > 0 Then
                        'textbox
                        c.ForeColor = Color.Black
                        c.BackColor = Color.DarkGray
                    Else
                        'non textbox
                        c.ForeColor = Color.DarkGray
                        c.BackColor = Color.Black
                    End If
                Next

                Me.BackColor = Color.Black

                If zStatus = True Then
                    lbvStatusOnOff.BackColor = Color.Lime
                Else
                    lbvStatusOnOff.BackColor = Color.Red
                End If

                lbvStatusOnOff.ForeColor = Color.Black

            Case Else
                'just in case
                Exit Sub

        End Select
    End Sub
    Public Sub zCt()
        'contents of the convert button
        'specific to the shutdown timer form1
        If zStatus = True Then Exit Sub
        txtHours.Text = zTrimLeadingZero(txtHours.Text)
        txtMin.Text = zTrimLeadingZero(txtMin.Text)
        txtSec.Text = zTrimLeadingZero(txtSec.Text)

        If txtHours.Text = vbNullString Then txtHours.Text = "1"
        If txtMin.Text = vbNullString Then txtMin.Text = "0"
        If txtSec.Text = vbNullString Then txtSec.Text = "0"

        If txtHours.Text = "0" And txtMin.Text = "0" And txtSec.Text = "0" Then txtHours.Text = "1"

        'should all be numbers

        Dim zH As Integer
        Dim zM As Integer
        Dim zS As Integer

        Dim zMd As Decimal
        Dim zSd As Decimal

        Dim zMi As Decimal
        Dim zSi As Decimal

        Dim zSt As Integer
        Dim zMt As Integer

        zH = txtHours.Text
        zM = txtMin.Text
        zS = txtSec.Text

        If zS >= 60 Then
            'decimal division to see how many multiples of 60 there are
            zSd = zS / 60
            'get just the whole number of multiples of 60
            zSi = Int(zSd)
            'subtract the whole multiples from the max to get remaining seconds
            zSt = zS - (zSi * 60)
            'add the whole multiples to the minutes max
            zM = zSi + zM
        Else
            zSt = zS
        End If

        If zM >= 60 Then
            'decimal division to see how many multiples of 60 there are
            zMd = zM / 60
            'get just the whole number of multiples of 60
            zMi = Int(zMd)
            'subtract the whole multiples from the max to get remaining minutes
            zMt = zM - (zMi * 60)
            'add the whole multiples to the hours max
            zH = zMi + zH
        Else
            zMt = zM
        End If

        'update textboxes
        txtSec.Text = zSt
        txtMin.Text = zMt
        txtHours.Text = zH

        'set global current hours mins secs value for read outs
        ztSeconds = zSt
        ztMinutes = zMt
        ztHours = zH

        'update the total hours min sec label
        'doesnt need to be part of the update sub
        lbTotalHMS.Text = "Total - " & ztHours & "h-" & ztMinutes & "m-" & ztSeconds & "s"

        Dim zCountTemp As Integer

        '(total hours * 60) = mins
        '+ whole minutes = total minutes
        zCountTemp = (zH * 60) + zMt
        'total minutes * 60 = total seconds
        zCountTemp = (zCountTemp * 60) + zSt

        'set the global count down total to the total number of seconds
        zTotalSeconds = zCountTemp

        'update the labels
        zUpdateHMS()

        'set the global current counter to 0
        zTc = 0
    End Sub

    Private Sub btMin_Click(sender As Object, e As EventArgs) Handles btMin.Click
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub btClose_Click(sender As Object, e As EventArgs) Handles btClose.Click
        Dim zpwXc As Integer
        Dim zpwYc As Integer

        Dim zsXc As Integer
        Dim zsYc As Integer

        zpwXc = pw.Width / 2
        zpwYc = pw.Height / 2

        zsXc = Me.Width / 2
        zsYc = Me.Height / 2

        pw.Show()
        pw.Left = Me.Left + (zsXc - zpwXc)
        pw.Top = Me.Top + (zsYc - zpwYc)
    End Sub

    Private Sub SDTForm1_LostFocus(sender As Object, e As EventArgs) Handles MyBase.LostFocus
        If zTc >= zTotalSeconds Then
            If zMode = "1" Then
                Show()
            End If
        End If
    End Sub

    Private Sub SDTForm1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If zMode = "1" Then
            If e.CloseReason = CloseReason.UserClosing Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub ckDarkMode_CheckedChanged(sender As Object, e As EventArgs) Handles ckDarkMode.CheckedChanged
        If ckDarkMode.Checked = True Then
            zTheme(1)
        Else
            zTheme(0)
        End If
    End Sub


End Class
