Public Class frmTitleBar

'i dont need a seperate title bar anymore if i just use a draggable icon at the top

    Public Const HTCAPTION As Long = 2
    Public Const WM_NCLBUTTONDOWN As Long = &HA1

    Public Declare Function ReleaseCapture Lib "user32" () As Long
    Public Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal Handle As Long, ByVal wMsg As Long, ByVal wParam As Long, <System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.AsAny)> lParam As Object) As Long

    Public Sub zSnapMainToTitle()
        'this snaps the main window to the bottom of the title window
        Form1.Top = Me.Top + Me.Height
        Form1.Left = Me.Left
    End Sub

    Private Sub frmTitleBar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        zSnapMainToTitle()
    End Sub

    Private Sub lbTitle_Click(sender As Object, e As EventArgs) Handles lbTitle.Click

    End Sub

    Private Sub lbTitle_MouseDown(sender As Object, e As MouseEventArgs) Handles lbTitle.MouseDown
        'Debug.Print("e.button - " & e.Button)
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0&)
        End If

    End Sub
End Class