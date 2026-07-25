Module Module1

    '===================================================================
    '===================================================================
    'todo:
    'i should add a scanner that scans for time stamps
    'and automatically adds them and their text index to
    'a time stamp box that lets you double click it and go
    'to that time stamp like a book mark
    '
    'i should add an undo thing too
    'a listbox that stores the entire log after every change lol
    'then when i do control z or y
    'it just sets the text box to the list box entries lol
    '===================================================================
    '===================================================================
    '


    Public Function zTrimLeadingZero(zTlzs As String) As String
        'filters out any characters but 0 to 9 using znumfilter
        'then returns a whole number without any potential leading zeros
        zTlzs = zNumFilter(zTlzs)
        If zTlzs = "" Then
            zTlzs = "0"
            Return zTlzs
        Else
            Dim zTcfc As String
            Dim zTs As String
            Dim zSetPass As Boolean
            Dim zTsL As Long

            zTs = zTlzs
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
                    zTlzs = "0"
                    Return zTlzs
                    Exit Function
                End If

            Loop Until zSetPass = True

            zTlzs = zTs
            Return zTlzs
        End If
    End Function

    Public Function zNumFilter(zNf As String) As String
        'this filters out any characters that arent 0 through 9
        'it leaves them in the original order
        'then it passes the filtered string back

        'changing this version to include the dash for negative numbers

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
                Case "-"
                    zNfos = zNfos & "-"
                Case Else
                    zNfos = zNfos & ""
            End Select
        Next
        zNumFilter = zNfos
    End Function

End Module
