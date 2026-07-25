Public Class frmResizer

    Public zResPrevX As Integer
    Public zResPrevY As Integer


    Public Const HTCAPTION As Long = 2
    Public Const WM_NCLBUTTONDOWN As Long = &HA1
    Public Const WM_NCLBUTTONUP As Long = &HA2

    Public Declare Function ReleaseCapture Lib "user32" () As Long
    Public Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal Handle As Long, ByVal wMsg As Long, ByVal wParam As Long, <System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.AsAny)> lParam As Object) As Long

    Private Sub frmResizer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'zMouseLeftClick = False
        tmrResizeRunOnce.Enabled = True
        tmrResizeUpdateTimer.Enabled = True

    End Sub

    Private Sub lbResizerX_Click(sender As Object, e As EventArgs) Handles lbResizerX.Click

    End Sub

    Public zMouseLeftClick As Boolean = False

    Private Sub lbResizerX_MouseDown(sender As Object, e As MouseEventArgs) Handles lbResizerX.MouseDown
        If e.Button = MouseButtons.Left Then

            zResPrevX = Me.Left
            zResPrevX = Me.Top

            'Form1.tmrDate.Enabled = False
            'Form1.tmrDate.Stop()
            'tmrRestartDateTimer.Enabled = True
            'tmrRestartDateTimer.Start()
            'zMouseLeftClick = True
            zResMoved = True

            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0&)
        End If
    End Sub

    Public zResMoved As Boolean = False

    Private Sub frmResizer_Move(sender As Object, e As EventArgs) Handles Me.Move

        If zResizeStart = False Then Exit Sub
        'Dim zPX As Integer
        'Dim zPY As Integer
        'zPX = Form1.zPreviousResizerLocationX
        'zPY = Form1.zPreviousResizerLocationY
        'Dim zTempLeft As Integer
        'Dim zTempTop As Integer
        'zTempLeft = Me.Left
        'zTempTop = Me.Top
        'If zPX <> zTempLeft Or zPY <> zTempTop Then
        '    'moved
        '    Debug.Print("frmResizer_Move - moved")
        '    Form1.zPreviousResizerLocationX = Me.Left
        '    Form1.zPreviousResizerLocationY = Me.Top
        '    zForm1SnapToResizer()
        'End If
        '
        ''Form1.zSnapResizerToMain()

        'Debug.Print("frmResizer_Move")
        'Debug.Print("======================")
        'Debug.Print("Me.Left " & Me.Left)
        'Debug.Print("Me.Top " & Me.Top)
        'Debug.Print("Me.Width " & Me.Width)
        'Debug.Print("Me.Height " & Me.Height)

        'zResMoved = True

        'Form1.zPreviousResizerLocationX = Me.Left
        'Form1.zPreviousResizerLocationY = Me.Top

        'zForm1SnapToResizer()
        'Form1.zSnapResizerToMain()
    End Sub

    Public Sub zForm1SnapToResizer()
        If zResizeStart = False Then Exit Sub

        'this is wrong
        'Form1.Width = Me.Left + Me.Width - Form1.Left
        'Form1.Height = Me.Height + Me.Height - Form1.Height

        'If Form1.WindowState = FormWindowState.Maximized Then
        ' Form1.WindowState = FormWindowState.Normal
        ' End If

        Form1.Width = Me.Left + Me.Width - Form1.Left
        Form1.Height = Me.Top + Me.Height - Form1.Top

        'Debug.Print("zForm1SnapToResizer")
        'Debug.Print("======================")
        'Debug.Print("Me.Left " & Me.Left)
        'Debug.Print("Me.Top " & Me.Top)
        'Debug.Print("Me.Width " & Me.Width)
        'Debug.Print("Me.Height " & Me.Height)
        'Debug.Print("======================")
        'Debug.Print("Form1.Left " & Form1.Left)
        'Debug.Print("Form1.Top " & Form1.Top)
        'Debug.Print("Form1.Width " & Form1.Width)
        'Debug.Print("Form1.Height " & Form1.Height)


        'sooo
        'the resizer should be
        'starting from the left of the window

        'frmResizer.Left = Me.Left + Me.Width - frmResizer.Width
        'frmResizer.Top = Me.Top + Me.Height - frmResizer.Height

        'Form1.zPreviousResizerLocationX = Me.Left
        'Form1.zPreviousResizerLocationY = Me.Top

        'Form1.zSnapResizerToMain()

    End Sub


    Private Sub lbResizerX_MouseUp(sender As Object, e As MouseEventArgs) Handles lbResizerX.MouseUp
        'zMouseLeftClick = False
        'ReleaseCapture()

        'zForm1SnapToResizer()
        'Form1.Left = Me.Left + Me.Width + Form1.Width
        'Form1.Height = Me.Height + Me.Width + Form1.Height
        'Debug.Print("lbResizerX_MouseUp")
        'this never fires using the sendmessage moving thing

        'If e.Button = MouseButtons.Left Then
        'Debug.Print("lbResizerX_MouseUp")
        'Form1.tmrDate.Enabled = False
        'tmrRestartDateTimer.Enabled = True
        'zMouseLeftClick = True
        'zResMoved = False

        'ReleaseCapture()
        'SendMessage(Handle, WM_NCLBUTTONUP, HTCAPTION, 0&)
        'End If
    End Sub

    Private Sub tmrRestartDateTimer_Tick(sender As Object, e As EventArgs) Handles tmrResizeUpdateTimer.Tick
        If zResizeStart = False Then Exit Sub

        If zResPrevX <> Me.Left Or zResPrevY <> Me.Top Then
            'Debug.Print("zForm1SnapToResizer from tmrRestartDateTimer_Tick")
            zForm1SnapToResizer()
            Form1.zSnapResizerToMain()
            zResMoved = False
        End If

        If Form1.WindowState = FormWindowState.Minimized Then
            Me.WindowState = FormWindowState.Minimized
        ElseIf Form1.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Normal
        End If

        'tmrRestartDateTimer.Enabled = False
    End Sub

    Public zResizeStart As Boolean = False

    Private Sub tmrResizeRunOnce_Tick(sender As Object, e As EventArgs) Handles tmrResizeRunOnce.Tick
        zResizeStart = True

        If Me.Width <> 38 Then
            Me.Width = 38
            Me.lbResizerX.Left = (38 / 2) - (Me.lbResizerX.Width / 2)
            Form1.zSnapResizerToMain()
        End If

        If Me.Height <> 38 Then
            Me.Height = 38
            Me.lbResizerX.Top = (38 / 2) - (Me.lbResizerX.Height / 2)
            Form1.zSnapResizerToMain()
        End If

        tmrResizeRunOnce.Enabled = False
        tmrResizeRunOnce.Stop()

    End Sub
End Class