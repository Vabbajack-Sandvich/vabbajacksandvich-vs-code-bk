'i cant believe
'i got the old
'fucking system dll
'hWnd shit to work again
'oh fuck yes
'oh fucking fuck yes
'vb updated hWnds to be some kind of object with a new thing to it
'trying to do Any in the dll declare fucks up and needs to be changed to this
'<System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.AsAny)>
'that before the variable name
'then
'As Object
'afterward
'then instead of hWnd when you use SendMessage
'you use Handle which a new thing in vb.net and not hWnd

'there might even be some object that contains all the old constants
'that you used to have define

'this is the updated code for vb.net

        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0&)
        End If

    Public Const HTCAPTION As Long = 2
    Public Const WM_NCLBUTTONDOWN As Long = &HA1

    Public Declare Function ReleaseCapture Lib "user32" () As Long
    Public Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal Handle As Long, ByVal wMsg As Long, ByVal wParam As Long, <System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.AsAny)> lParam As Object) As Long
