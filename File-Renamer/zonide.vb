Module zonide

    Public Function zNumFilter(zNf As String) As String
        'this filters out any characters that arent 0 through 9
        'it leaves them in the original order
        'then it passes the filtered string back
        If zNf = "" Then Exit Function

        Dim zNfi As Long
        Dim zNfos As String
        Dim zNfl As Long
        Dim zNfis As String
        zNfl = Len(zNf)
        For zNfi = 1 To zNfl
            zNfis = Mid(zNf, zNfi, 1)
            Select Case zNfis
                Case "0"
                    zNfos = zNfos & "0"
                Case "1"
                    zNfos = zNfos & "1"
                Case "2"
                    zNfos = zNfos & "2"
                Case "3"
                    zNfos = zNfos & "3"
                Case "4"
                    zNfos = zNfos & "4"
                Case "5"
                    zNfos = zNfos & "5"
                Case "6"
                    zNfos = zNfos & "6"
                Case "7"
                    zNfos = zNfos & "7"
                Case "8"
                    zNfos = zNfos & "8"
                Case "9"
                    zNfos = zNfos & "9"
                Case Else
                    zNfos = zNfos & ""
            End Select
        Next
        zNumFilter = zNfos
    End Function

End Module
