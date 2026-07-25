'vabbajacksandvich.vb
'master file
'every sub version gets consolodated here
'since every project uses its own version of modules
'it makes it kind of a pain in the head to add stuff and then consolodate
'and remember which one i made which changes to
'so this is just meant to be copied and pasted into a module file each time
'then have the new changes appened back here from each project
'unless there is a way to use 1 file for each one like it used to be
'but i havent found it yet

'===================================================
'                   ideas and todo
'===================================================
'2025-10-19-05-48-30-AM
'just had the idea to try passing arrays to functions
'for individual use things that require an array
'if i use a public array that is defined particularly
'for one usage
'i dont have to worry about using listboxes
'===================================================

'===================================================

Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms.AxHost
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock

Module vabbajacksandvich
    '-------------------------------------
    'api declarations, globals and project junk oh my
    '-------------------------------------
    'project specific public variables
    '-------------------------------------
    'tf2script
    Public zTf2Class As String = "engineer"
    '-------------------------------------
    'windows api junk
    '-------------------------------------
    Public Const HTCAPTION As Long = 2
    Public Const WM_NCLBUTTONDOWN As Long = &HA1
    '-------------------------------------
    Public Declare Function ReleaseCapture Lib "user32" () As Long
    Public Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal Handle As Long, ByVal wMsg As Long, ByVal wParam As Long, <System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.AsAny)> lParam As Object) As Long
    Public Declare Function GetCursorPos Lib "user32" (lpPoint As zPOINTAPI) As Long
    Public Declare Function ScreenToClient Lib "user32" (ByVal Handle As Long, lpPoint As zPOINTAPI) As Long
    '-------------------------------------
    Public Structure zPOINTAPI
        Public zX1 As Long
        Public zY1 As Long
    End Structure
    Function zMouseX(Optional ByVal hWnd As Long = 0) As Long
        ' Get mouse X coordinates in pixels
        ' If a window handle is passed, the result is relative to the client area
        ' of that window, otherwise the result is relative to the screen
        Dim lpPoint As zPOINTAPI
        GetCursorPos(lpPoint)
        If hWnd Then ScreenToClient(hWnd, lpPoint)
        zMouseX = lpPoint.zX1
    End Function
    Function zMouseY(Optional ByVal hWnd As Long = 0) As Long
        ' Get mouse Y coordinates in pixels
        ' If a window handle is passed, the result is relative to the client area
        ' of that window, otherwise the result is relative to the screen
        Dim lpPoint As zPOINTAPI
        GetCursorPos(lpPoint)
        If hWnd Then ScreenToClient(hWnd, lpPoint)
        zMouseY = lpPoint.zY1
    End Function
    '-------------------------------------
    'control scraps for copy and pasting:
    '-------------------------------------
    'this is for dragging a form by dragging a control
    'it goes in the mousedown section of the control
    'If e.Button = MouseButtons.Left Then
    '        ReleaseCapture()
    '        SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0&)
    'End If
    '-------------------------------------
    'lazy short hand variables
    '-------------------------------------
    'short return string
    Public zR As String = vbCrLf
    Public zR2 As String = vbCrLf & vbCrLf
    'short quote string
    Public zQ As String = Chr(34)

    '-------------------------------------
    Public Function zListboxtoStringWithReturn(zsList As ListBox) As String
        'this goes through and adds each entry to a string with return at the end
        If zsList.Items.Count = 0 Then Exit Function
        Dim zListI As Integer
        Dim ztOut As String
        For zListI = 0 To zsList.Items.Count - 1
            Application.DoEvents()
            ztOut = ztOut & zsList.Items.Item(zListI) & zR
        Next
        zListboxtoStringWithReturn = ztOut
    End Function
    Public Function zListboxtoStringWithReturnWithProgress(zsList As ListBox, zsProgress As ProgressBar) As String
        'this goes through and adds each entry to a string with return at the end
        'assumes list and progress bar are there
        'assumes progress bar is hidden, shows it while in use then hides it
        If zsList.Items.Count = 0 Then Exit Function
        Dim zListI As Integer
        Dim ztOut As String
        zsProgress.Maximum = zsList.Items.Count
        zsProgress.Visible = True
        For zListI = 0 To zsList.Items.Count - 1
            Application.DoEvents()
            zsProgress.Value = zListI + 1
            ztOut = ztOut & zsList.Items.Item(zListI) & zR
        Next
        zsProgress.Visible = False
        zsProgress.Value = 0
        zsProgress.Maximum = 0
        zListboxtoStringWithReturnWithProgress = ztOut
    End Function
    Public Function zAddOneListboxToAnother(zaList1 As ListBox, zaList2 As ListBox)
        'this adds one list box to another without checking for duplicates
        'similar to zmovelist but it doesnt clear the the target listbox
        'if there is nothing in the initial list box it just exits
        If zaList1.Items.Count = 0 Then Exit Function
        Dim zListI As Integer
        For zListI = 0 To zaList1.Items.Count - 1
            Application.DoEvents()
            zaList2.Items.Add(zaList1.Items.Item(zListI))
        Next
    End Function
    Public Function zAddOneListboxToAnotherWithProgress(zaList1 As ListBox, zaList2 As ListBox, zaProgress As ProgressBar)
        'this adds one list box to another without checking for duplicates
        'similar to zmovelist but it doesnt clear the the target listbox
        'if there is nothing in the initial list box it just exits
        'assumes list and progress bar are there
        'assumes progress bar is hidden, shows it while in use then hides it
        If zaList1.Items.Count = 0 Then Exit Function
        Dim zListI As Integer
        zaProgress.Maximum = zaList1.Items.Count
        zaProgress.Visible = True
        For zListI = 0 To zaList1.Items.Count - 1
            Application.DoEvents()
            zaProgress.Value = zListI + 1
            zaList2.Items.Add(zaList1.Items.Item(zListI))
        Next
        zaProgress.Visible = False
        zaProgress.Value = 0
        zaProgress.Maximum = 0
    End Function
    Public Function zMoveList(zmList1 As ListBox, zmList2 As ListBox)
        'this moves list 1 to list 2
        If zmList1.Items.Count = 0 Then Exit Function
        zmList2.Items.Clear()
        Dim zListI As Integer
        For zListI = 0 To zmList1.Items.Count - 1
            Application.DoEvents()
            zmList2.Items.Add(zmList1.Items.Item(zListI))
        Next
    End Function
    Public Function zCompareListBoxesKeepOnlyUnique(zcList1 As ListBox, zcList2 As ListBox, zcList3 As ListBox)
        'this compares list1 and 2 and puts the unique entries in list3
        'if list 1 or 2 have nothing in them it will exit Function
        If zcList1.Items.Count = 0 Then Exit Function
        If zcList2.Items.Count = 0 Then Exit Function
        Dim zL1 As Integer
        Dim zL2 As Integer
        Dim zL1Item As String
        Dim zL1Item2 As String
        Dim zComp As Boolean
        zcList3.Items.Clear()
        zComp = False
        For zL1 = 0 To zcList1.Items.Count - 1
            Application.DoEvents()
            zL1Item = zcList1.Items.Item(zL1)
            For zL2 = 0 To zcList2.Items.Count - 1
                Application.DoEvents()
                zL1Item2 = zcList2.Items.Item(zL2)
                If zL1Item = zL1Item2 = True Then
                    zComp = True
                End If
            Next
            If zComp = False Then
                zcList3.Items.Add(zL1Item)
            End If
            zComp = False
        Next
    End Function
    Public Function zTrimLeadingZero2(zTlzs As String) As String
        'filters out any characters but 0 to 9 using znumfilter
        'then returns a whole number without any potential leading zeros
        'this version returns nothing instead of zero
        zTlzs = zNumFilter(zTlzs)
        If zTlzs = "" Then
            'zTlzs = "0"
            zTlzs = ""
            Return zTlzs
        Else
            Dim zTcfc As String
            Dim zTs As String
            Dim zSetPass As Boolean
            Dim zTsL As Long
            zTs = zTlzs
            zSetPass = False
            Do
                Application.DoEvents()
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
                    'zTlzs = "0"
                    zTlzs = ""
                    Return zTlzs
                    Exit Function
                End If
            Loop Until zSetPass = True
            zTlzs = zTs
            Return zTlzs
        End If
    End Function
    Public Function zTrimDecimals(zTrimDec As String) As String
        'this scans the input for decimals
        'if it finds one it keeps the place of that decimal
        'but ignores all the rest and reformats the string with only the fist found one
        'if the only returned string is a single decimal it will return nothing
        Dim zFirstFound As Boolean = False
        If zTrimDec = vbNullString Then
            zTrimDecimals = vbNullString
            Exit Function
        End If
        Dim zTempTD As String
        zTempTD = LCase(zTrimDec)
        Dim zANfi As Integer
        Dim zANfos As String
        Dim zANfl As Integer
        Dim zANfis As String
        zANfl = Len(zTempTD)
        For zANfi = 1 To zANfl
            Application.DoEvents()
            zANfis = Mid(zTempTD, zANfi, 1)
            If zANfis = "." And zFirstFound = False Then
                'its a decimal and the tracker is false
                zANfos = zANfos & "."
                zFirstFound = True
            ElseIf zANfis <> "." Then
                'its not a decimal
                'tracker doesnt matter
                zANfos = zANfos & zANfis
            ElseIf zANfis = "." And zFirstFound = True Then
                'it found a decimal and the tracker has already found one
                'basically do nothing
                'arguably not needed
                zANfos = zANfos
            End If
        Next
        If zANfos = "." Then
            'the whole string was just a decimal
            'return nothing
            zTrimDecimals = vbNullString
            Exit Function
        Else
            zTrimDecimals = zANfos
        End If
    End Function

    Public Function zTextLinesToListboxWithProgress(zTLTLWPInputTxt As TextBox, zTLTLWPInputListBox As ListBox, zTLTLWPProgressBar As ProgressBar, Optional zTLTLWPListClear As Integer = 0)
        'this assumes that whichever text or list box exists
        'and is correct
        'this function adds every line of text to a list box
        'this also clears the list box based on zListClear
        'this wont clear the list unless its set to 1
        'this also trims return characters when adding entires
        'this also trims blank lines vbcrlf
        If zTLTLWPInputTxt.Text = vbNullString Then Exit Function

        'have to make sure the last character is a return character
        Dim zLastCharacter1 As String
        Dim zLastCharacter2 As String
        zLastCharacter1 = Mid(zTLTLWPInputTxt.Text, Len(zTLTLWPInputTxt.Text))
        zLastCharacter2 = Mid(zTLTLWPInputTxt.Text, Len(zTLTLWPInputTxt.Text) - 1)
        If zLastCharacter1 <> Chr(13) And zLastCharacter2 <> Chr(10) Then
            zTLTLWPInputTxt.Text = zTLTLWPInputTxt.Text & vbCrLf
        End If

        zTLTLWPProgressBar.Maximum = Len(zTLTLWPInputTxt.Text)
        zTLTLWPProgressBar.Visible = True

        Dim zRt As Integer, zRt2 As Integer, zTstr As String
        Dim zRstop As Boolean
        zRstop = False
        zRt = InStr(zTLTLWPInputTxt.Text, vbCrLf)
        If zRt = 0 Then
            'no return character
            'assuming just one line
            If zTLTLWPListClear = 1 Then
                zTLTLWPInputListBox.Items.Clear()
            End If
            zTLTLWPInputListBox.Items.Add(zTLTLWPInputTxt.Text)
        Else
            If zTLTLWPListClear = 1 Then
                zTLTLWPInputListBox.Items.Clear()
            End If
            'found a return character
            'check to see if there is more than one
            zRt2 = InStr(zRt + 2, zTLTLWPInputTxt.Text, vbCrLf)
            If zRt2 > 0 Then
                'there is more than one
                zRt2 = zRt
                zRt = 1
                'first pass
                zTstr = Mid(zTLTLWPInputTxt.Text, zRt, zRt2 - 1)
                If zTstr <> vbNullString And zTstr <> vbCrLf Then
                    zTLTLWPInputListBox.Items.Add(zTstr)
                End If
                'every other pass to the end
                zRt = zRt2
                zRt2 = InStr(zRt + 2, zTLTLWPInputTxt.Text, vbCrLf)
                Do
                    Application.DoEvents()
                    'zTLTLWPProgressBar.Value = zRt
                    zTstr = Mid(zTLTLWPInputTxt.Text, zRt + 2, zRt2 - zRt - 2)
                    If zTstr <> vbNullString And zTstr <> vbCrLf Then
                        zTLTLWPInputListBox.Items.Add(zTstr)
                    End If
                    zRt = zRt2
                    zRt2 = InStr(zRt + 2, zTLTLWPInputTxt.Text, vbCrLf)
                    zTLTLWPProgressBar.Value = zRt2
                    If zRt2 = 0 Then
                        zRstop = True
                        zTstr = Mid(zTLTLWPInputTxt.Text, zRt, Len(zTLTLWPInputTxt.Text))
                        If zTstr <> vbNullString And zTstr <> vbCrLf Then
                            zTLTLWPInputListBox.Items.Add(zTstr)
                        End If
                    End If
                Loop Until zRstop = True
            Else
                'there isnt more than one
                'add the string to the list box minus the return character
                zTstr = Mid(zTLTLWPInputTxt.Text, 1, Len(zTLTLWPInputTxt.Text) - 2)
                zTLTLWPInputListBox.Items.Add(zTstr)
            End If
        End If

        zTLTLWPProgressBar.Value = zTLTLWPProgressBar.Maximum
        zTLTLWPProgressBar.Visible = False
        zTLTLWPProgressBar.Value = 0
        zTLTLWPProgressBar.Maximum = 0

    End Function

    Public Function zTextLinesToListbox(zTxt As TextBox, zList As ListBox, Optional zListClear As Integer = 0)
        'this assumes that whichever text or list box exists
        'and is correct
        'this function adds every line of text to a list box
        'this also clears the list box based on zListClear
        'this wont clear the list unless its set to 1
        'this also trims return characters when adding entires
        'this also trims blank lines vbcrlf
        If zTxt.Text = vbNullString Then Exit Function
        'have to make sure the last character is a return character
        Dim zLastCharacter1 As String
        Dim zLastCharacter2 As String
        zLastCharacter1 = Mid(zTxt.Text, Len(zTxt.Text))
        zLastCharacter2 = Mid(zTxt.Text, Len(zTxt.Text) - 1)
        If zLastCharacter1 <> Chr(13) And zLastCharacter2 <> Chr(10) Then
            zTxt.Text = zTxt.Text & vbCrLf
        End If
        Dim zRt As Integer, zRt2 As Integer, zTstr As String
        Dim zRstop As Boolean
        zRstop = False
        zRt = InStr(zTxt.Text, vbCrLf)
        If zRt = 0 Then
            'no return character
            'assuming just one line
            If zListClear = 1 Then
                zList.Items.Clear()
            End If
            zList.Items.Add(zTxt.Text)
        Else
            If zListClear = 1 Then
                zList.Items.Clear()
            End If
            'found a return character
            'check to see if there is more than one
            zRt2 = InStr(zRt + 2, zTxt.Text, vbCrLf)
            If zRt2 > 0 Then
                'there is more than one
                zRt2 = zRt
                zRt = 1
                'first pass
                zTstr = Mid(zTxt.Text, zRt, zRt2 - 1)
                If zTstr <> vbNullString And zTstr <> vbCrLf Then
                    zList.Items.Add(zTstr)
                End If
                'every other pass to the end
                zRt = zRt2
                zRt2 = InStr(zRt + 2, zTxt.Text, vbCrLf)
                Do
                    Application.DoEvents()
                    zTstr = Mid(zTxt.Text, zRt + 2, zRt2 - zRt - 2)
                    If zTstr <> vbNullString And zTstr <> vbCrLf Then
                        zList.Items.Add(zTstr)
                    End If
                    zRt = zRt2
                    zRt2 = InStr(zRt + 2, zTxt.Text, vbCrLf)
                    If zRt2 = 0 Then
                        zRstop = True
                        zTstr = Mid(zTxt.Text, zRt, Len(zTxt.Text))
                        If zTstr <> vbNullString And zTstr <> vbCrLf Then
                            zList.Items.Add(zTstr)
                        End If
                    End If
                Loop Until zRstop = True
            Else
                'there isnt more than one
                'add the string to the list box minus the return character
                zTstr = Mid(zTxt.Text, 1, Len(zTxt.Text) - 2)
                zList.Items.Add(zTstr)
            End If
        End If
    End Function
    Public Function zAlphaNumFilter(zANf As String) As String
        'this filters out any characters that arent 0 through 9
        'it leaves them in the original order
        'then it passes the filtered string back
        If zANf = "" Then Exit Function
        zANf = LCase(zANf)
        Dim zANfi As Long
        Dim zANfos As String
        Dim zANfl As Long
        Dim zANfis As String
        zANfl = Len(zANf)
        For zANfi = 1 To zANfl
            Application.DoEvents()
            zANfis = Mid(zANf, zANfi, 1)
            Select Case zANfis
                Case "0"
                    zANfos = zANfos & "0"
                Case "1"
                    zANfos = zANfos & "1"
                Case "2"
                    zANfos = zANfos & "2"
                Case "3"
                    zANfos = zANfos & "3"
                Case "4"
                    zANfos = zANfos & "4"
                Case "5"
                    zANfos = zANfos & "5"
                Case "6"
                    zANfos = zANfos & "6"
                Case "7"
                    zANfos = zANfos & "7"
                Case "8"
                    zANfos = zANfos & "8"
                Case "9"
                    zANfos = zANfos & "9"
                Case "a"
                    zANfos = zANfos & "a"
                Case "b"
                    zANfos = zANfos & "b"
                Case "c"
                    zANfos = zANfos & "c"
                Case "d"
                    zANfos = zANfos & "d"
                Case "e"
                    zANfos = zANfos & "e"
                Case "f"
                    zANfos = zANfos & "f"
                Case "g"
                    zANfos = zANfos & "g"
                Case "h"
                    zANfos = zANfos & "h"
                Case "i"
                    zANfos = zANfos & "i"
                Case "j"
                    zANfos = zANfos & "j"
                Case "k"
                    zANfos = zANfos & "k"
                Case "l"
                    zANfos = zANfos & "l"
                Case "m"
                    zANfos = zANfos & "m"
                Case "n"
                    zANfos = zANfos & "n"
                Case "o"
                    zANfos = zANfos & "o"
                Case "p"
                    zANfos = zANfos & "p"
                Case "q"
                    zANfos = zANfos & "q"
                Case "r"
                    zANfos = zANfos & "r"
                Case "s"
                    zANfos = zANfos & "s"
                Case "t"
                    zANfos = zANfos & "t"
                Case "u"
                    zANfos = zANfos & "u"
                Case "v"
                    zANfos = zANfos & "v"
                Case "w"
                    zANfos = zANfos & "w"
                Case "x"
                    zANfos = zANfos & "x"
                Case "y"
                    zANfos = zANfos & "y"
                Case "z"
                    zANfos = zANfos & "z"
                Case Else
                    zANfos = zANfos & ""
            End Select
        Next
        zAlphaNumFilter = zANfos
    End Function
    Public Function zAlphaNumFilterWithDot(zANf As String) As String
        'this filters out any characters that arent 0 through 9
        'it leaves them in the original order
        'then it passes the filtered string back
        'includes dot but no other symbols
        If zANf = "" Then Exit Function
        zANf = LCase(zANf)
        Dim zANfi As Long
        Dim zANfos As String
        Dim zANfl As Long
        Dim zANfis As String
        zANfl = Len(zANf)
        For zANfi = 1 To zANfl
            Application.DoEvents()
            zANfis = Mid(zANf, zANfi, 1)
            Select Case zANfis
                Case "0"
                    zANfos = zANfos & "0"
                Case "1"
                    zANfos = zANfos & "1"
                Case "2"
                    zANfos = zANfos & "2"
                Case "3"
                    zANfos = zANfos & "3"
                Case "4"
                    zANfos = zANfos & "4"
                Case "5"
                    zANfos = zANfos & "5"
                Case "6"
                    zANfos = zANfos & "6"
                Case "7"
                    zANfos = zANfos & "7"
                Case "8"
                    zANfos = zANfos & "8"
                Case "9"
                    zANfos = zANfos & "9"
                Case "a"
                    zANfos = zANfos & "a"
                Case "b"
                    zANfos = zANfos & "b"
                Case "c"
                    zANfos = zANfos & "c"
                Case "d"
                    zANfos = zANfos & "d"
                Case "e"
                    zANfos = zANfos & "e"
                Case "f"
                    zANfos = zANfos & "f"
                Case "g"
                    zANfos = zANfos & "g"
                Case "h"
                    zANfos = zANfos & "h"
                Case "i"
                    zANfos = zANfos & "i"
                Case "j"
                    zANfos = zANfos & "j"
                Case "k"
                    zANfos = zANfos & "k"
                Case "l"
                    zANfos = zANfos & "l"
                Case "m"
                    zANfos = zANfos & "m"
                Case "n"
                    zANfos = zANfos & "n"
                Case "o"
                    zANfos = zANfos & "o"
                Case "p"
                    zANfos = zANfos & "p"
                Case "q"
                    zANfos = zANfos & "q"
                Case "r"
                    zANfos = zANfos & "r"
                Case "s"
                    zANfos = zANfos & "s"
                Case "t"
                    zANfos = zANfos & "t"
                Case "u"
                    zANfos = zANfos & "u"
                Case "v"
                    zANfos = zANfos & "v"
                Case "w"
                    zANfos = zANfos & "w"
                Case "x"
                    zANfos = zANfos & "x"
                Case "y"
                    zANfos = zANfos & "y"
                Case "z"
                    zANfos = zANfos & "z"
                Case "."
                    zANfos = zANfos & "."
                Case Else
                    zANfos = zANfos & ""
            End Select
        Next
        zAlphaNumFilterWithDot = zANfos
    End Function
    Public Sub zClearCheckListBoxChecks(zCkLb As CheckedListBox, Optional zIndex As Integer = -1)
        'cklbOtherBotCmd
        'this clears all the checks in the check list box
        'if the index is specfied then it will ignore clearing that index
        'adding the optional means i dont have to change the retro active usages
        Dim zCount As Integer
        zCount = zCkLb.Items.Count
        If zCount = 0 Then Exit Sub
        Dim zCycle As Integer
        zCycle = 0
        For zCycle = 0 To zCount - 1
            Application.DoEvents()
            If zIndex = -1 Then
                zCkLb.SetItemChecked(zCycle, False)
            Else
                If zCycle <> zIndex Then
                    zCkLb.SetItemChecked(zCycle, False)
                End If
            End If
        Next
    End Sub
    Public Function zFormatTeleport(zList As ListBox, zList2 As ListBox, zTxtOut As TextBox, zBotName As TextBox, zEnumBots As CheckBox)
        'this will go through each line and if it meets the format critera
        'it will add that line
        'if a line doesnt meet the criteria then it will skip it
        'by not adding it
        If zBotName.Text = vbNullString Then
            zBotName.Text = "bot"
        End If
        If zList.Items.Count = 0 Then Exit Function
        zList2.Items.Clear()
        zTxtOut.Text = vbNullString
        Dim zListI As Integer
        Dim zLentry As String
        Dim zSetpos As Integer, zSetang As Integer
        'set pos
        Dim zspSpace1 As Integer, zspSpace2 As Integer, zspSpace3 As Integer
        'set angle
        Dim zsaSpace1 As Integer, zsaSpace2 As Integer, zsaSpace3 As Integer
        'teleport formatting
        Dim zSemiColon As Integer
        Dim zFirstHalf As String
        Dim zSecondHalf As String
        Dim zTp As String
        Dim zTxtOutString As String
        Dim zBotI As Integer
        zBotI = 0
        Dim zBNnolastchar As String
        'go through each entry in the list
        For zListI = 0 To zList.Items.Count - 1
            Application.DoEvents()
            'setpos -52.407482 662.477600 353.586365;setang 33.054932 -4.829772 0.000000
            'thats how it comes out of the game using getpos
            'thats the string i have to take apart
            zLentry = zList.Items.Item(zListI)
            zSetpos = InStr(1, zLentry, "setpos")
            zSetang = InStr(1, zLentry, "setang")
            If (zSetpos > 0) And (zSetang > 0) Then
                'both exist
                'test for further formatting stuff
                'for setpos section
                zspSpace1 = InStr(1, zLentry, " ")
                zspSpace2 = InStr(zspSpace1 + 1, zLentry, " ")
                zspSpace3 = InStr(zspSpace2 + 1, zLentry, " ")
                zsaSpace1 = InStr(zspSpace3 + 1, zLentry, " ")
                zsaSpace2 = InStr(zsaSpace1 + 1, zLentry, " ")
                zsaSpace3 = InStr(zsaSpace2 + 1, zLentry, " ")
                If (zspSpace1 > 0) And (zspSpace2 > 0) And (zspSpace3 > 0) And (zsaSpace1 > 0) And (zsaSpace2 > 0) And (zsaSpace3 > 0) Then
                    'this should be a copy and pasted line from the console
                    'setpos -52.407482 662.477600 353.586365;setang 33.054932 -4.829772 0.000000
                    zSemiColon = InStr(1, zLentry, ";")
                    'so starting from the first space
                    If zSemiColon > 0 Then
                        'to - 1 the semicolon
                        'should be the first half of the teleport command
                        'coordinates
                        zFirstHalf = Mid(zLentry, zspSpace1 + 1, zSemiColon - 1 - zspSpace1)
                        zSecondHalf = Mid(zLentry, zsaSpace1 + 1, Len(zLentry))
                        'zList2.Items.Add(zFirstHalf)
                        'zList2.Items.Add(zSecondHalf)
                        'now that i have the first and second coordinates
                        'make the teleport command
                        'bot_teleport "hoovy1" -301.160034 -588.444153 78.468124 18.458006 15.540970 0.000000
                        If zEnumBots.Checked = True Then
                            'add the index to the end of the bot name text
                            'quotes for bot
                            'zTp = "bot_teleport " & zQ & zBotName.Text & zBotI & zQ & " " & zFirstHalf & " " & zSecondHalf
                            'no quotes for bot
                            'zTp = "bot_teleport " & zBotName.Text & zBotI & " " & zFirstHalf & " " & zSecondHalf
                            zBNnolastchar = Mid(zBotName.Text, 1, Len(zBotName.Text) - 1)
                            zTp = "bot_teleport " & zBNnolastchar & zBotI & " " & zFirstHalf & " " & zSecondHalf
                            zBotI = zBotI + 1
                        Else
                            'dont enumerate bots
                            'quotes for bot
                            'zTp = "bot_teleport " & zQ & zBotName.Text & zQ & " " & zFirstHalf & " " & zSecondHalf
                            'no quotes for bot
                            zTp = "bot_teleport " & zBotName.Text & " " & zFirstHalf & " " & zSecondHalf
                        End If
                        zList2.Items.Add(zTp)
                        zTxtOutString = zTxtOutString & zTp & vbCrLf
                        'If zListI = (zList.Items.Count - 1) Then
                        zTxtOut.Text = zTxtOutString
                        'End If
                    End If
                End If
            End If
        Next
    End Function
    Public Function zNumFilter(zNf As String) As String
        'only numbers no symbols
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
            Application.DoEvents()
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
    Public Function zNumFilterWithDot(zNf As String) As String
        'only numbers no symbols except for dot
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
            Application.DoEvents()
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
                Case "."
                    zNfos = zNfos & "."
                Case Else
                    zNfos = zNfos & ""
            End Select
        Next
        zNumFilterWithDot = zNfos
    End Function
    Public Function zAlphaNumFilterWithDashPlus(zANf As String) As String
        'this filters out any characters that arent 0 through 9
        'and symbols
        'it leaves them in the original order
        'then it passes the filtered string back
        If zANf = "" Then Exit Function
        zANf = LCase(zANf)
        Dim zANfi As Long
        Dim zANfos As String
        Dim zANfl As Long
        Dim zANfis As String
        zANfl = Len(zANf)
        For zANfi = 1 To zANfl
            Application.DoEvents()
            zANfis = Mid(zANf, zANfi, 1)
            Select Case zANfis
                Case "0"
                    zANfos = zANfos & "0"
                Case "1"
                    zANfos = zANfos & "1"
                Case "2"
                    zANfos = zANfos & "2"
                Case "3"
                    zANfos = zANfos & "3"
                Case "4"
                    zANfos = zANfos & "4"
                Case "5"
                    zANfos = zANfos & "5"
                Case "6"
                    zANfos = zANfos & "6"
                Case "7"
                    zANfos = zANfos & "7"
                Case "8"
                    zANfos = zANfos & "8"
                Case "9"
                    zANfos = zANfos & "9"
                Case "a"
                    zANfos = zANfos & "a"
                Case "b"
                    zANfos = zANfos & "b"
                Case "c"
                    zANfos = zANfos & "c"
                Case "d"
                    zANfos = zANfos & "d"
                Case "e"
                    zANfos = zANfos & "e"
                Case "f"
                    zANfos = zANfos & "f"
                Case "g"
                    zANfos = zANfos & "g"
                Case "h"
                    zANfos = zANfos & "h"
                Case "i"
                    zANfos = zANfos & "i"
                Case "j"
                    zANfos = zANfos & "j"
                Case "k"
                    zANfos = zANfos & "k"
                Case "l"
                    zANfos = zANfos & "l"
                Case "m"
                    zANfos = zANfos & "m"
                Case "n"
                    zANfos = zANfos & "n"
                Case "o"
                    zANfos = zANfos & "o"
                Case "p"
                    zANfos = zANfos & "p"
                Case "q"
                    zANfos = zANfos & "q"
                Case "r"
                    zANfos = zANfos & "r"
                Case "s"
                    zANfos = zANfos & "s"
                Case "t"
                    zANfos = zANfos & "t"
                Case "u"
                    zANfos = zANfos & "u"
                Case "v"
                    zANfos = zANfos & "v"
                Case "w"
                    zANfos = zANfos & "w"
                Case "x"
                    zANfos = zANfos & "x"
                Case "y"
                    zANfos = zANfos & "y"
                Case "z"
                    zANfos = zANfos & "z"
                Case "-"
                    zANfos = zANfos & "-"
                Case "+"
                    zANfos = zANfos & "+"
                Case Else
                    zANfos = zANfos & ""
            End Select
        Next
        zAlphaNumFilterWithDashPlus = zANfos
    End Function
    Public Function zAlphaNumFilterWithDashPlusSpace(zANf As String) As String
        'this filters out any characters that arent 0 through 9
        'and symbols
        'it leaves them in the original order
        'then it passes the filtered string back
        'also leaves spaces
        If zANf = "" Then Exit Function
        zANf = LCase(zANf)
        Dim zANfi As Long
        Dim zANfos As String
        Dim zANfl As Long
        Dim zANfis As String
        zANfl = Len(zANf)
        For zANfi = 1 To zANfl
            Application.DoEvents()
            zANfis = Mid(zANf, zANfi, 1)
            Select Case zANfis
                Case "0"
                    zANfos = zANfos & "0"
                Case "1"
                    zANfos = zANfos & "1"
                Case "2"
                    zANfos = zANfos & "2"
                Case "3"
                    zANfos = zANfos & "3"
                Case "4"
                    zANfos = zANfos & "4"
                Case "5"
                    zANfos = zANfos & "5"
                Case "6"
                    zANfos = zANfos & "6"
                Case "7"
                    zANfos = zANfos & "7"
                Case "8"
                    zANfos = zANfos & "8"
                Case "9"
                    zANfos = zANfos & "9"
                Case "a"
                    zANfos = zANfos & "a"
                Case "b"
                    zANfos = zANfos & "b"
                Case "c"
                    zANfos = zANfos & "c"
                Case "d"
                    zANfos = zANfos & "d"
                Case "e"
                    zANfos = zANfos & "e"
                Case "f"
                    zANfos = zANfos & "f"
                Case "g"
                    zANfos = zANfos & "g"
                Case "h"
                    zANfos = zANfos & "h"
                Case "i"
                    zANfos = zANfos & "i"
                Case "j"
                    zANfos = zANfos & "j"
                Case "k"
                    zANfos = zANfos & "k"
                Case "l"
                    zANfos = zANfos & "l"
                Case "m"
                    zANfos = zANfos & "m"
                Case "n"
                    zANfos = zANfos & "n"
                Case "o"
                    zANfos = zANfos & "o"
                Case "p"
                    zANfos = zANfos & "p"
                Case "q"
                    zANfos = zANfos & "q"
                Case "r"
                    zANfos = zANfos & "r"
                Case "s"
                    zANfos = zANfos & "s"
                Case "t"
                    zANfos = zANfos & "t"
                Case "u"
                    zANfos = zANfos & "u"
                Case "v"
                    zANfos = zANfos & "v"
                Case "w"
                    zANfos = zANfos & "w"
                Case "x"
                    zANfos = zANfos & "x"
                Case "y"
                    zANfos = zANfos & "y"
                Case "z"
                    zANfos = zANfos & "z"
                Case "-"
                    zANfos = zANfos & "-"
                Case "+"
                    zANfos = zANfos & "+"
                Case " "
                    zANfos = zANfos & " "
                Case Else
                    zANfos = zANfos & ""
            End Select
        Next
        zAlphaNumFilterWithDashPlusSpace = zANfos
    End Function
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
                Application.DoEvents()
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
    Public Function zDeduplicateListBox(zList As ListBox)
        'this assumes it wont ever receive a bad control
        'and will crash if it does
        'which means, if you send a listbox that doesnt exist
        'to this function, it will error with no handling
        'this is also limited to 50000 entries
        'any more than that is stupid to use vb for
        'and thats within the range of merging small bits of code
        'and not being insane with the temp array
        Dim zC As Integer = zList.Items.Count
        If zC = 0 Then Exit Function
        If zC > 50001 Then Exit Function
        Dim zTmp(50000) As String
        'the temp array will only ever go up to the listbox count
        'so theres not really a reason to worry about that
        Dim zI As Integer
        Dim zSi As String
        Dim zI2 As Integer
        Dim zTmpStr As String
        Dim zDupe As Boolean
        Dim zTmpCount As Integer = 0
        'im going to have to make a rolling index for the tempcount
        'so that it adds based on its own count and not the listindex
        zI = 0
        For zI = 0 To zC - 1
            Application.DoEvents()
            'this loop is adding items to the temp list
            'and scanning the temp list every time
            'and only adding a new entry to the temp list
            'if it wasnt found in the entire list
            'i just realizd i cant use this for the combiner
            'and have to modify the combiner method
            'but this method for this deduplicator is fine
            'after this loop i need to clear the actual listbox
            'then fill it will the tmp list while clearing the temp list
            'at the same time
            zSi = zList.Items.Item(zI)
            If zI = 0 Then
                'first entry no need to scan
                zTmp(zI) = zSi
                zTmpCount = 1
            Else
                'every other entry i dedupe and add
                zDupe = False
                For zI2 = 0 To zTmpCount - 1
                    Application.DoEvents()
                    'scan for duplicates in the temp list
                    zTmpStr = zTmp(zI2)
                    If zSi = zTmpStr Then
                        zDupe = True
                    End If
                Next
                'scanned through all of the temp list for the list entry
                'now check to see if there was a duplicate
                If zDupe = True Then
                    'theres a duplicate
                    'dont add it but reset the var for next scan
                    zDupe = False
                ElseIf zDupe = False Then
                    'zdupe should still be false obviously
                    'so no reset needed
                    'no dupe add it to the temp list
                    zTmpCount = zTmpCount + 1
                    zTmp(zTmpCount - 1) = zSi
                End If
            End If
        Next
        'now the temp list is full and deduplicated against itself
        'now i need to clear the real list
        'then add the temp list to it
        'and clear the temp list
        zList.Items.Clear()
        'now add the temp list to the normal list
        For zI = 0 To zTmpCount - 1
            Application.DoEvents()
            'Debug.Print(zTmp(zI))
            zList.Items.Add(zTmp(zI))
        Next
    End Function
    Public Function zDeduplicateListBoxWithProgress(zList As ListBox, zProgress As ProgressBar)
        'this assumes it wont ever receive a bad control
        'and will crash if it does
        'which means, if you send a listbox that doesnt exist
        'to this function, it will error with no handling
        'this is also limited to 50000 entries
        'any more than that is stupid to use vb for
        'and thats within the range of merging small bits of code
        'and not being insane with the temp array
        'assumes list and progress bar are there
        'assumes progress bar is hidden, shows it while in use then hides it
        Dim zC As Integer = zList.Items.Count
        If zC = 0 Then Exit Function
        If zC > 50001 Then Exit Function
        Dim zTmp(50000) As String
        'the temp array will only ever go up to the listbox count
        'so theres not really a reason to worry about that
        Dim zI As Integer
        Dim zSi As String
        Dim zI2 As Integer
        Dim zTmpStr As String
        Dim zDupe As Boolean
        Dim zTmpCount As Integer = 0
        'im going to have to make a rolling index for the tempcount
        'so that it adds based on its own count and not the listindex
        zI = 0
        zProgress.Maximum = zC
        zProgress.Visible = True
        For zI = 0 To zC - 1
            Application.DoEvents()
            zProgress.Value = zI + 1
            'this loop is adding items to the temp list
            'and scanning the temp list every time
            'and only adding a new entry to the temp list
            'if it wasnt found in the entire list
            'i just realizd i cant use this for the combiner
            'and have to modify the combiner method
            'but this method for this deduplicator is fine
            'after this loop i need to clear the actual listbox
            'then fill it will the tmp list while clearing the temp list
            'at the same time
            zSi = zList.Items.Item(zI)
            If zI = 0 Then
                'first entry no need to scan
                zTmp(zI) = zSi
                zTmpCount = 1
            Else
                'every other entry i dedupe and add
                zDupe = False
                For zI2 = 0 To zTmpCount - 1
                    Application.DoEvents()
                    'scan for duplicates in the temp list
                    zTmpStr = zTmp(zI2)
                    If zSi = zTmpStr Then
                        zDupe = True
                    End If
                Next
                'scanned through all of the temp list for the list entry
                'now check to see if there was a duplicate
                If zDupe = True Then
                    'theres a duplicate
                    'dont add it but reset the var for next scan
                    zDupe = False
                ElseIf zDupe = False Then
                    'zdupe should still be false obviously
                    'so no reset needed
                    'no dupe add it to the temp list
                    zTmpCount = zTmpCount + 1
                    zTmp(zTmpCount - 1) = zSi
                End If
            End If
        Next
        'now the temp list is full and deduplicated against itself
        'now i need to clear the real list
        'then add the temp list to it
        'and clear the temp list
        zList.Items.Clear()
        'now add the temp list to the normal list
        For zI = 0 To zTmpCount - 1
            Application.DoEvents()
            'Debug.Print(zTmp(zI))
            zList.Items.Add(zTmp(zI))
        Next
        zProgress.Visible = False
        zProgress.Value = 0
        zProgress.Maximum = 0
    End Function
    Public Function zInsertTextIntoRichTextbox(zTxt As RichTextBox, zStr As String, Optional zRt As Integer = 0, Optional zScrollScan As Integer = 0)
        'assumes textbox is real
        'will crash if it gets a non existant box
        'default selection start is the end of the insert point
        'other cases change it
        If zStr = "" Then Exit Function
        Dim zTs As String
        Select Case zRt
            Case 0
                'no returns
                'arguably not needed
                'this is just the string
                zTs = zStr
            Case 1
                '1 return
                zTs = zR & zStr & zR
            Case 2
                '2 returns
                zTs = zR2 & zStr & zR2
            Case 3
                '3
                'no return in front
                '1 return at the end
                zTs = zStr & zR
            Case 4
                '3
                'no return in front
                '2 returns at the end
                zTs = zStr & zR2
            Case 5
                'same as 3
                'but selection is in the front
                'changes down the bottom
                'no return in front
                '1 return at the end
                zTs = zStr & zR
        End Select
        If zTxt.Text = vbNullString Then
            'no text just insert the text
            zTxt.Text = zTs
            zTxt.SelectionStart = Len(zTxt.Text)
            zTxt.Select()
            zTxt.ScrollToCaret()
            Exit Function
        Else
            'selection start is messed up
            'fix it
            'not sure if i should make an option for front start or end start
            'or to default to the end
            If zTxt.SelectionStart <= 0 Then
                'start
                'zTxt.SelectionStart = 1
                'end
                zTxt.SelectionStart = Len(zTxt.Text)
            End If
        End If
        Dim zTStr As String
        zTStr = zTxt.Text
        Dim zPreviousSelection As Integer
        Dim zPrev2 As Integer
        zPreviousSelection = zTxt.SelectionStart
        'just to keep this seperate for the optional
        zPrev2 = zPreviousSelection
        Dim zBefore As String
        Dim zAfter As String
        zBefore = Mid(zTxt.Text, 1, zTxt.SelectionStart)
        zAfter = Mid(zTxt.Text, zTxt.SelectionStart + 1, Len(zTxt.Text))
        zTxt.Text = zBefore & zTs & zAfter
        Select Case zRt
            Case 5
                'same as 3
                'puts the selction at the front
                'by not putting it at the end of the insert
                zTxt.SelectionStart = zPreviousSelection
            Case Else
                zTxt.SelectionStart = zPreviousSelection
                'puts the selection at the end
                zTxt.SelectionStart = zTxt.SelectionStart + Len(zTs) - 1
        End Select
        'sets it to after the insert
        'this screws with the scroll bars too much
        'zTxt.SelectionStart = zTxt.SelectionStart + Len(zTs) - 1
        If zScrollScan > 0 Then
            'this late added optional
            'causes the caret to jump X amount in either direction
            'scroll the box there, then scroll to the "correct" one
            'this is an attempt to jankily fix the screwed up scroll focus
            If zScrollScan + Len(zTxt.Text) <= Len(zTxt.Text) And zScrollScan + Len(zTxt.Text) > 0 Then
                'the sum of adding zscrollscan if its positive or negative
                'has to be less than or equale to the len of the string
                'or it would go over
                'while also being above zero
                'so it doesnt go outside the range
                'since it made it here
                'that means it should pass through these next branches
                If zTxt.SelectionStart + zScrollScan < Len(zTxt.Text) Then
                    zTxt.SelectionStart = zTxt.SelectionStart + zScrollScan
                    zTxt.Select()
                    zTxt.ScrollToCaret()
                    zTxt.SelectionStart = zPrev2
                ElseIf zTxt.SelectionStart + zScrollScan > Len(zTxt.Text) Then
                    zTxt.SelectionStart = zTxt.SelectionStart - zScrollScan
                    zTxt.Select()
                    zTxt.ScrollToCaret()
                    zTxt.SelectionStart = zPrev2
                ElseIf zTxt.SelectionStart + zScrollScan = Len(zTxt.Text) Then
                    zTxt.SelectionStart = zTxt.SelectionStart - zScrollScan
                    zTxt.Select()
                    zTxt.ScrollToCaret()
                    zTxt.SelectionStart = zPrev2
                End If
                'the else here would mean that its outside the range
                'so just dont bother
            End If
        End If
        zTxt.Select()
        zTxt.ScrollToCaret()
    End Function
    'this works with these public variables
    'month
    Public zTDm As String
    'day
    Public zTDd As String
    'year
    Public zTDy As String
    Public Function zTimeDateFilter(zTd As String) As String
        'this works for 00-00-0000 only
        If zTd = "" Then Exit Function
        If Len(zTd) <> Len("00-00-0000") Then Exit Function
        'this does this the laziest way possible
        'if people feed crap in to this it will spit crap out or crash
        Dim zMonth As String
        zMonth = Mid(zTd, 1, 2)
        Dim zDay As String
        zDay = Mid(zTd, 4, 2)
        Dim zYear As String
        zYear = Mid(zTd, 7, 4)
        zTDm = zMonth
        zTDd = zDay
        zTDy = zYear
    End Function
    Public Function zSpaceToUnderscore(zStUStr As String) As String
        If zStUStr = vbNullString Then Exit Function
        'changes spaces in a string to underscores
        Dim zNfi As Long
        Dim zNfos As String
        Dim zNfl As Long
        Dim zNfis As String
        zNfl = Len(zStUStr)
        For zNfi = 1 To zNfl
            Application.DoEvents()
            zNfis = Mid(zStUStr, zNfi, 1)
            Select Case zNfis
                Case " "
                    'character was a space
                    'change it to underscore
                    zNfos = zNfos & "_"
                Case Else
                    'anything besides a space
                    'just add whatever it was
                    zNfos = zNfos & zNfis
            End Select
        Next
        zSpaceToUnderscore = zNfos
    End Function
    Public Function zRemoveDoubleSpace(zTmpIStr As String) As String
        'this removes all double spaces and returns the modified string
        'with only a single space
        'this only does this once
        If zTmpIStr = "" Then Exit Function
        Dim zTmpStr As String
        zTmpStr = zTmpIStr
        zTmpStr = zTmpStr.Replace("  ", " ")
        zRemoveDoubleSpace = zTmpStr
    End Function

    Public Function zRemoveAllDoubleSpace(zTmpIStr As String) As String
        'this removes all double spaces and returns the modified string
        'with only a single space
        'this does it over and over again until all double space are gone
        If zTmpIStr = "" Then Exit Function
        Dim zTmpStr As String
        zTmpStr = zTmpIStr
        zTmpStr = zTmpStr.Replace("  ", " ")
        Dim zDsCheck As Integer
        Dim zDsCheckPass As Boolean = False
        zDsCheck = InStr(1, zTmpStr, "  ")
        If zDsCheck > 0 Then
            Do
                Application.DoEvents()
                zDsCheck = InStr(1, zTmpStr, "  ")
                If zDsCheck = 0 Then
                    zDsCheckPass = True
                Else
                    zDsCheckPass = False
                    zTmpStr = zTmpStr.Replace("  ", " ")
                End If
            Loop Until zDsCheckPass = True
            zRemoveAllDoubleSpace = zTmpStr
        Else
            zRemoveAllDoubleSpace = zTmpStr
        End If
    End Function

    Public Function zMatchListIndex(zMList1 As ListBox, zMList2 As ListBox)
        'this wont update the index of list 2 if the item counts dont match
        If zMList1.Items.Count = 0 Then Exit Function
        If zMList2.Items.Count = 0 Then Exit Function
        If zMList1.Items.Count <> zMList2.Items.Count Then Exit Function
        If zMList1.SelectedIndex = -1 Then Exit Function
        zMList2.SelectedIndex = zMList1.SelectedIndex
    End Function

    Public Function zCodeGenMultiLineTextBoxToVBListBoxAddItemsTextBlock(zCGTxtIn As TextBox, zCGTxtOut As TextBox)
        'tldr
        'this is for generating code for list box pops from a multiline textbox
        'this version doesnt add public sub


        'rambling
        'this just does
        'ListBox1.Items.Add("")
        'i can use the rename thing to rename it
        'but i should make a version that does add public sub
        'but i would need a sub name text box for input
        'might do that later

        'this takes a full multi line text box
        'then converts it into pasteable code
        'the code will turn each entry, each line,
        'in to a line that adds that line to a textbox
        'uses an input multi line text box
        'a multiline output text box

        'Using the code below as a base

        'Public Function zTextLinesToListbox(zTxt As TextBox, zList As ListBox, Optional zListClear As Integer = 0)
        'this assumes that whichever text or list box exists
        'and is correct
        'this function adds every line of text to a list box
        'this also clears the list box based on zListClear
        'this wont clear the list unless its set to 1
        'this also trims return characters when adding entires
        'this also trims blank lines vbcrlf
        If zCGTxtIn.Text = vbNullString Then Exit Function
        'have to make sure the last character is a return character
        Dim zLastCharacter1 As String
        Dim zLastCharacter2 As String
        zLastCharacter1 = Mid(zCGTxtIn.Text, Len(zCGTxtIn.Text))
        zLastCharacter2 = Mid(zCGTxtIn.Text, Len(zCGTxtIn.Text) - 1)
        If zLastCharacter1 <> Chr(13) And zLastCharacter2 <> Chr(10) Then
            zCGTxtIn.Text = zCGTxtIn.Text & vbCrLf
        End If
        Dim zRt As Integer, zRt2 As Integer, zTstr As String
        Dim zRstop As Boolean
        zRstop = False

        'this is the temporary array that acts as a list box for each line
        'this has a max of 50000
        Dim zTmpList(50000) As String
        Dim zTmpCount As Integer = 0

        Dim zTempCodeLine As String

        'to add to the list
        'zTmp(zI) = zSi

        zRt = InStr(zCGTxtIn.Text, vbCrLf)
        If zRt = 0 Then
            'no return character
            'assuming just one line
            'this is where i have to make it gen the one line of code
            'zTstr = zCGTxtIn.Text
            zTempCodeLine = "ListBox1.Items.Add(" & Chr(34) & Mid(zCGTxtIn.Text, 1, Len(zCGTxtIn.Text) - 2) & Chr(34) & ")" & zR2
            'how the output line should look
            'ListBox1.Items.Add("")
            'zCGTxtOut.Text = "ListBox1.Items.Add(" & Chr(34) & zTstr & Chr(34) & ")"
            zCGTxtOut.Text = zTempCodeLine
            'zTmpCount = 1
        Else
            'found a return character
            'check to see if there is more than one
            zRt2 = InStr(zRt + 2, zCGTxtIn.Text, vbCrLf)
            If zRt2 > 0 Then
                'there is more than one
                zRt2 = zRt
                zRt = 1
                'first pass
                zTstr = Mid(zCGTxtIn.Text, zRt, zRt2 - 1)
                If zTstr <> vbNullString And zTstr <> vbCrLf Then
                    'zList.Items.Add(zTstr)
                    'zTempCodeLine = "ListBox1.Items.Add(" & Chr(34) & zTstr & Chr(34) & ")"
                    'zTempCodeLine = "ListBox1.Items.Add(" & Chr(34) & zTstr & Chr(34) & ")" & zR2
                    zTempCodeLine = "ListBox1.Items.Add(" & Chr(34) & zTstr & Chr(34) & ")" & zR
                    zTmpList(zTmpCount) = zTempCodeLine
                    zTmpCount = zTmpCount + 1
                End If
                'every other pass to the end
                zRt = zRt2
                zRt2 = InStr(zRt + 2, zCGTxtIn.Text, vbCrLf)
                Do
                    Application.DoEvents()
                    zTstr = Mid(zCGTxtIn.Text, zRt + 2, zRt2 - zRt - 2)
                    If zTstr <> vbNullString And zTstr <> vbCrLf Then
                        'zList.Items.Add(zTstr)
                        'zTempCodeLine = "ListBox1.Items.Add(" & Chr(34) & zTstr & Chr(34) & ")"
                        zTempCodeLine = "ListBox1.Items.Add(" & Chr(34) & zTstr & Chr(34) & ")" & zR
                        zTmpList(zTmpCount) = zTempCodeLine
                        zTmpCount = zTmpCount + 1
                    End If
                    zRt = zRt2
                    zRt2 = InStr(zRt + 2, zCGTxtIn.Text, vbCrLf)
                    If zRt2 = 0 Then
                        zRstop = True
                        zTstr = Mid(zCGTxtIn.Text, zRt, Len(zCGTxtIn.Text))
                        If zTstr <> vbNullString And zTstr <> vbCrLf Then
                            'zList.Items.Add(zTstr)
                            'zTempCodeLine = "ListBox1.Items.Add(" & Chr(34) & zTstr & Chr(34) & ")"
                            zTempCodeLine = "ListBox1.Items.Add(" & Chr(34) & zTstr & Chr(34) & ")" & zR
                            zTmpList(zTmpCount) = zTempCodeLine
                            zTmpCount = zTmpCount + 1
                        End If
                    End If
                Loop Until zRstop = True
            Else
                'there isnt more than one
                'add the string to the list box minus the return character
                zTstr = Mid(zCGTxtIn.Text, 1, Len(zCGTxtIn.Text) - 2)
                'zList.Items.Add(zTstr)
                'zTempCodeLine = "ListBox1.Items.Add(" & Chr(34) & zTstr & Chr(34) & ")"
                zTempCodeLine = "ListBox1.Items.Add(" & Chr(34) & zTstr & Chr(34) & ")" & zR
                zTmpList(zTmpCount) = zTempCodeLine
                zTmpCount = zTmpCount + 1
            End If

            'heres where i need to compile the
            'main output code gen string from the temp list
            Dim zTmpI As Integer
            Dim zTmpOut As String
            For zTmpI = 0 To zTmpCount - 1
                Application.DoEvents()
                zTmpOut = zTmpOut & zTmpList(zTmpI)
            Next
            zCGTxtOut.Text = zTmpOut
        End If

    End Function

    Public Function zExtractValueFromTCPViewLine(zExTcpTxt As String, Optional zExTcpValue As Integer = 0) As String

        'returns nothing if it doesnt pass a check

        'zExtractValueFromTCPViewLine = ""

        'the copy and paste from the gui is formatted differently than from tcpvcon

        'default copy and paste
        'svchost.exe,5124,TCP,Established,192.168.18.198,49710,23.194.99.73,443,10/4/2025 7:53:23 PM,WpnUserService_61beb,,,,

        'entries in the line

        'svchost.exe,
        '5124,
        'TCP,
        'Established,
        '192.168.18.198,
        '49710,
        '23.194.99.73,
        '443,
        '10/4/2025 7:53:23 PM,
        'WpnUserService_61beb,
        ',
        ',
        ',

        'this uses zExTcpValue
        '0 is the default which if one is not specified it returns the remote address if there is one

        '1     svchost.exe,               - Process
        '2     5124,                      - PID (Process ID)
        '3     TCP,                       - Protocol
        '4     Established,               - State
        '5     192.168.18.198,            - Local Address
        '6     49710,                     - Local Port
        '7     23.194.99.73,              - Remote Address
        '8     443,                       - Remote Port
        '9     10/4/2025 7:53:23 PM,      - Create Time
        '10    WpnUserService_61beb,      - Module Name
        '11    ,                          - null?
        '12    ,                          - null?
        '13    ,                          - null?


        'going to use the 13 commas , and the 7 dots . as a valid pass to extract values
        'there isnt many things that will have that specifically
        'the first version only works on tcp v4
        'and doesnt check for : addresses

        'going to count the , as a format check
        'if it passes that
        'do more format checking if needed

        '13 total commas , to check for

        Dim zComma1 As Integer
        Dim zComma2 As Integer
        Dim zComma3 As Integer
        Dim zComma4 As Integer
        Dim zComma5 As Integer
        Dim zComma6 As Integer
        Dim zComma7 As Integer
        Dim zComma8 As Integer
        Dim zComma9 As Integer
        Dim zComma10 As Integer
        Dim zComma11 As Integer
        Dim zComma12 As Integer
        Dim zComma13 As Integer

        zComma1 = InStr(1, zExTcpTxt, ",")
        zComma2 = InStr(zComma1 + 1, zExTcpTxt, ",")
        zComma3 = InStr(zComma2 + 1, zExTcpTxt, ",")
        zComma4 = InStr(zComma3 + 1, zExTcpTxt, ",")
        zComma5 = InStr(zComma4 + 1, zExTcpTxt, ",")
        zComma6 = InStr(zComma5 + 1, zExTcpTxt, ",")
        zComma7 = InStr(zComma6 + 1, zExTcpTxt, ",")
        zComma8 = InStr(zComma7 + 1, zExTcpTxt, ",")
        zComma9 = InStr(zComma8 + 1, zExTcpTxt, ",")
        zComma10 = InStr(zComma9 + 1, zExTcpTxt, ",")
        zComma11 = InStr(zComma10 + 1, zExTcpTxt, ",")
        zComma12 = InStr(zComma11 + 1, zExTcpTxt, ",")
        zComma13 = InStr(zComma12 + 1, zExTcpTxt, ",")

        'If zComma1 <> 0 Then
        'End If

        Dim z13CommaCheck As Boolean = False

        'these trees help keep the if blocks with a lot of code in them to a minimum
        'and they are easy to write in notepad ++ with the column numerator and alt shift selecting

        If zComma1 <> 0 Then
            If zComma2 <> 0 Then
                If zComma3 <> 0 Then
                    If zComma4 <> 0 Then
                        If zComma5 <> 0 Then
                            If zComma6 <> 0 Then
                                If zComma7 <> 0 Then
                                    If zComma8 <> 0 Then
                                        If zComma9 <> 0 Then
                                            If zComma10 <> 0 Then
                                                If zComma11 <> 0 Then
                                                    If zComma12 <> 0 Then
                                                        If zComma13 <> 0 Then
                                                            z13CommaCheck = True
                                                        Else
                                                            zExtractValueFromTCPViewLine = ""
                                                            Exit Function
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

        'these are kind of redundant but whatever
        If z13CommaCheck = True Then

            '1 dot at least in the exe line?
            'the 6 dots in the 2 ips

            '7dots total?

            'these trees help keep the if blocks with a lot of code in them to a minimum
            'and they are easy to write in notepad ++ with the column numerator and alt shift selecting


            'these are kind of redundant but whatever

            'this uses zExTcpValue
            '0 is the default which if one is not specified it returns the remote address if there is one

            '1     svchost.exe,               - Process
            '2     5124,                      - PID (Process ID)
            '3     TCP,                       - Protocol
            '4     Established,               - State
            '5     192.168.18.198,            - Local Address
            '6     49710,                     - Local Port
            '7     23.194.99.73,              - Remote Address
            '8     443,                       - Remote Port
            '9     10/4/2025 7:53:23 PM,      - Create Time
            '10    WpnUserService_61beb,      - Module Name
            '11    ,                          - null?
            '12    ,                          - null?
            '13    ,                          - null?

            'do the string extraction here
            'first get all of the strings
            'then pass the output to the function string
            'instead of handling it for each string matching the input index zExTcpValue

            Dim zStrProcess As String
            Dim zStrPID As String
            Dim zStrProtocol As String
            Dim zStrState As String
            Dim zStrLocalAddress As String
            Dim zStrLocalPort As String
            Dim zStrRemoteAddress As String
            Dim zStrRemotePort As String
            Dim zStrCreateTime As String
            Dim zStrModuleName As String

            'this might screw up if they are null
            Dim zValue11 As String
            Dim zValue12 As String
            Dim zValue13 As String

            zStrProcess = Mid(zExTcpTxt, 1, zComma1 - 1)
            zStrPID = Mid(zExTcpTxt, zComma1 + 1, zComma2 - zComma1 - 1)
            zStrProtocol = Mid(zExTcpTxt, zComma2 + 1, zComma3 - zComma2 - 1)
            zStrState = Mid(zExTcpTxt, zComma3 + 1, zComma4 - zComma3 - 1)
            zStrLocalAddress = Mid(zExTcpTxt, zComma4 + 1, zComma5 - zComma4 - 1)
            zStrLocalPort = Mid(zExTcpTxt, zComma5 + 1, zComma6 - zComma5 - 1)
            zStrRemoteAddress = Mid(zExTcpTxt, zComma6 + 1, zComma7 - zComma6 - 1)
            zStrRemotePort = Mid(zExTcpTxt, zComma7 + 1, zComma8 - zComma7 - 1)
            zStrCreateTime = Mid(zExTcpTxt, zComma8 + 1, zComma9 - zComma8 - 1)
            zStrModuleName = Mid(zExTcpTxt, zComma9 + 1, zComma10 - zComma9 - 1)

            zValue11 = Mid(zExTcpTxt, zComma10 + 1, zComma11 - zComma10 - 1)
            zValue12 = Mid(zExTcpTxt, zComma11 + 1, zComma12 - zComma11 - 1)
            zValue13 = Mid(zExTcpTxt, zComma12 + 1, zComma13 - zComma12 - 1)

            'zExTcpValue
            'zExtractValueFromTCPViewLine = ""

            'if this gets a screwed up pass it will either error or return nothing

            'removed dot checks since im using the ipv filter check
            'this just returns whatever entry

            Select Case zExTcpValue
                Case 0
                    'default 0 no optional
                    'returns remote address
                    zExtractValueFromTCPViewLine = zStrRemoteAddress
                Case 1
                    '1 returns Process
                    zExtractValueFromTCPViewLine = zStrProcess
                Case 2
                    '2 returns PID
                    zExtractValueFromTCPViewLine = zStrPID
                Case 3
                    '3 returns Protocol
                    zExtractValueFromTCPViewLine = zStrProtocol
                Case 4
                    '4 returns State
                    zExtractValueFromTCPViewLine = zStrState
                Case 5
                    '5 returns Local Address
                    zExtractValueFromTCPViewLine = zStrLocalAddress
                Case 6
                    '6 returns Local Port
                    zExtractValueFromTCPViewLine = zStrLocalPort
                Case 7
                    '7 returns Remote Address
                    zExtractValueFromTCPViewLine = zStrRemoteAddress
                Case 8
                    '8 returns Remote Address
                    zExtractValueFromTCPViewLine = zStrRemotePort
                Case 9
                    '9 returns Remote Address
                    zExtractValueFromTCPViewLine = zStrRemotePort
                Case 10
                    '10 returns Module Name
                    zExtractValueFromTCPViewLine = zStrModuleName
                Case 11
                    '11 returns seemingly always null value
                    zExtractValueFromTCPViewLine = zValue11
                Case 12
                    '12 returns seemingly always null value
                    zExtractValueFromTCPViewLine = zValue12
                Case 13
                    '13 returns seemingly always null value
                    zExtractValueFromTCPViewLine = zValue13
            End Select
            'end of If z7DotCheck = True Then
        End If

    End Function

    Public Function zExtractRemoteAddressFromTCPViewTextBoxAddToListbox(zERADFTCPViewTextboxInput As TextBox, zERADFTCPViewListboxOutput As ListBox, Optional zERADFTCPViewListboxOutputClear As Integer = 0)

        'zERADFTCPView

        'going to make this kind of a garbage sort where it doesnt exit function if it doesnt find a value in a line
        'so it will just skip those lines and only pick out valid matches
        '
        'this sorts through tcpview copy and paste entries
        'and extracts the remote address

        'needs to be its own function
        'i could also make it so it has the option to scan the program or service name
        'and from thre isolate just those ips
        'i should put that in a seperate function

        'going to have to copy and paste add textbox to list box and add this to it as a filter

        'zExtractValueFromTCPViewLine()

        'this assumes that whichever text or list box exists
        'and is correct
        'this function adds every line of text to a list box
        'this also clears the list box based on zeftcpvListboxOutputClear
        'this wont clear the list unless its set to 1
        'this also trims return characters when adding entires
        'this also trims blank lines vbcrlf
        If zERADFTCPViewTextboxInput.Text = vbNullString Then Exit Function
        'have to make sure the last character is a return character
        Dim zLastCharacter1 As String
        Dim zLastCharacter2 As String
        zLastCharacter1 = Mid(zERADFTCPViewTextboxInput.Text, Len(zERADFTCPViewTextboxInput.Text))
        zLastCharacter2 = Mid(zERADFTCPViewTextboxInput.Text, Len(zERADFTCPViewTextboxInput.Text) - 1)
        If zLastCharacter1 <> Chr(13) And zLastCharacter2 <> Chr(10) Then
            zERADFTCPViewTextboxInput.Text = zERADFTCPViewTextboxInput.Text & vbCrLf
        End If
        Dim zRt As Integer, zRt2 As Integer, zTstr As String
        Dim zRstop As Boolean
        Dim zExtractValue As String
        zRstop = False
        zRt = InStr(zERADFTCPViewTextboxInput.Text, vbCrLf)
        If zRt = 0 Then
            'no return character
            'assuming just one line
            If zERADFTCPViewListboxOutputClear = 1 Then
                zERADFTCPViewListboxOutput.Items.Clear()
            End If
            'zeftcpvListboxOutput.Items.Add(zeftcpvTextboxInput.Text)

            'add to every spot where the list box gets an entry added
            'this checks to see if the line containss the extraction value
            'default 0 optional returns remote address
            zExtractValue = zExtractValueFromTCPViewLine(zERADFTCPViewTextboxInput.Text)
            'adding ip filter
            zExtractValue = zIPAddressLineCheck(zExtractValue)
            If zExtractValue <> "" Then
                'add it to the list if it found the value
                zERADFTCPViewListboxOutput.Items.Add(zExtractValue)
            Else
                'didnt return a value
                'this is the only time it will exit function
                Exit Function
            End If

        Else
            If zERADFTCPViewListboxOutputClear = 1 Then
                zERADFTCPViewListboxOutput.Items.Clear()
            End If
            'found a return character
            'check to see if there is more than one
            zRt2 = InStr(zRt + 2, zERADFTCPViewTextboxInput.Text, vbCrLf)
            If zRt2 > 0 Then
                'there is more than one
                zRt2 = zRt
                zRt = 1
                'first pass
                zTstr = Mid(zERADFTCPViewTextboxInput.Text, zRt, zRt2 - 1)
                If zTstr <> vbNullString And zTstr <> vbCrLf Then
                    'zeftcpvListboxOutput.Items.Add(zTstr)

                    'add to every spot where the list box gets an entry added
                    'this checks to see if the line containss the extraction value
                    'default 0 optional returns remote address
                    zExtractValue = zExtractValueFromTCPViewLine(zTstr)
                    'adding ip filter
                    zExtractValue = zIPAddressLineCheck(zExtractValue)
                    If zExtractValue <> "" Then
                        'add it to the list if it found the value
                        zERADFTCPViewListboxOutput.Items.Add(zExtractValue)
                    End If
                End If
                'every other pass to the end
                zRt = zRt2
                zRt2 = InStr(zRt + 2, zERADFTCPViewTextboxInput.Text, vbCrLf)
                Do
                    Application.DoEvents()
                    zTstr = Mid(zERADFTCPViewTextboxInput.Text, zRt + 2, zRt2 - zRt - 2)
                    If zTstr <> vbNullString And zTstr <> vbCrLf Then
                        'zeftcpvListboxOutput.Items.Add(zTstr)

                        'add to every spot where the list box gets an entry added
                        'this checks to see if the line containss the extraction value
                        'default 0 optional returns remote address
                        zExtractValue = zExtractValueFromTCPViewLine(zTstr)
                        'adding ip filter
                        zExtractValue = zIPAddressLineCheck(zExtractValue)
                        If zExtractValue <> "" Then
                            'add it to the list if it found the value
                            zERADFTCPViewListboxOutput.Items.Add(zExtractValue)
                        End If
                    End If
                    zRt = zRt2
                    zRt2 = InStr(zRt + 2, zERADFTCPViewTextboxInput.Text, vbCrLf)
                    If zRt2 = 0 Then
                        zRstop = True
                        zTstr = Mid(zERADFTCPViewTextboxInput.Text, zRt, Len(zERADFTCPViewTextboxInput.Text))
                        If zTstr <> vbNullString And zTstr <> vbCrLf Then
                            'zeftcpvListboxOutput.Items.Add(zTstr)

                            'add to every spot where the list box gets an entry added
                            'this checks to see if the line containss the extraction value
                            'default 0 optional returns remote address
                            zExtractValue = zExtractValueFromTCPViewLine(zTstr)
                            'adding ip filter
                            zExtractValue = zIPAddressLineCheck(zExtractValue)
                            If zExtractValue <> "" Then
                                'add it to the list if it found the value
                                zERADFTCPViewListboxOutput.Items.Add(zExtractValue)
                            End If
                        End If
                    End If
                Loop Until zRstop = True
            Else
                'there isnt more than one
                'add the string to the list box minus the return character
                zTstr = Mid(zERADFTCPViewTextboxInput.Text, 1, Len(zERADFTCPViewTextboxInput.Text) - 2)

                'zeftcpvListboxOutput.Items.Add(zTstr)

                'add to every spot where the list box gets an entry added
                'this checks to see if the line containss the extraction value
                'default 0 optional returns remote address
                zExtractValue = zExtractValueFromTCPViewLine(zTstr)
                'adding ip filter
                zExtractValue = zIPAddressLineCheck(zExtractValue)
                If zExtractValue <> "" Then
                    'add it to the list if it found the value
                    zERADFTCPViewListboxOutput.Items.Add(zExtractValue)
                End If
            End If
        End If

    End Function

    Public Function zIPAddressLineCheck(zIPAddressInputTxt As String) As String

        'easier to just have this pass the ip back if its true
        'but return nothing if its not a valid ip
        'only checks for ipv4 addresses

        'this also wont return 0.0.0.0

        'this checks for 3 dots
        'gets the sections between the dots
        'then checks the lengths of each section
        'then checks to see if the sections are within a normal iprange

        Dim zDot1 As Integer
        Dim zDot2 As Integer
        Dim zDot3 As Integer

        Dim z3DotCheck As Boolean = False

        Dim zTempzIPAddressInputTxt As String

        zTempzIPAddressInputTxt = zIPAddressInputTxt

        zTempzIPAddressInputTxt = zNumFilterWithDot(zTempzIPAddressInputTxt)

        If zTempzIPAddressInputTxt = "" Then
            'zIPAddressLineCheck = False
            zIPAddressLineCheck = ""
            Exit Function
        End If

        zDot1 = InStr(1, zTempzIPAddressInputTxt, ".")
        zDot2 = InStr(zDot1 + 1, zTempzIPAddressInputTxt, ".")
        zDot3 = InStr(zDot2 + 1, zTempzIPAddressInputTxt, ".")

        If zDot1 <> 0 Then
            If zDot2 <> 0 Then
                If zDot3 <> 0 Then
                    'all three dots
                    Dim zS1 As String
                    Dim zS2 As String
                    Dim zS3 As String
                    Dim zS4 As String

                    zS1 = Mid(zTempzIPAddressInputTxt, 1, zDot1 - 1)
                    zS2 = Mid(zTempzIPAddressInputTxt, zDot1 + 1, zDot2 - zDot1 - 1)
                    zS3 = Mid(zTempzIPAddressInputTxt, zDot2 + 1, zDot3 - zDot2 - 1)
                    zS4 = Mid(zTempzIPAddressInputTxt, zDot3 + 1, Len(zTempzIPAddressInputTxt))

                    If Len(zS1) <= 3 And Len(zS1) >= 1 Then
                        If Len(zS2) <= 3 And Len(zS2) >= 1 Then
                            If Len(zS3) <= 3 And Len(zS3) >= 1 Then
                                If Len(zS4) <= 3 And Len(zS4) >= 1 Then
                                    'passed all checks so far
                                    'got filtered for numbers and dots only
                                    'has 3 dots
                                    'has 4 sections which must be numbers
                                    'the sections are at least 1
                                    'and not greater than 3
                                    'check to see if their values are all within
                                    'the ip range
                                    '0 to 255
                                    If CInt(zS1) >= 0 And CInt(zS1) <= 255 Then
                                        If CInt(zS2) >= 0 And CInt(zS2) <= 255 Then
                                            If CInt(zS3) >= 0 And CInt(zS3) <= 255 Then
                                                If CInt(zS4) >= 0 And CInt(zS4) <= 255 Then
                                                    'each section is within ip range
                                                    '0 to 255
                                                    'zIPAddressLineCheck = True
                                                    If zIPAddressInputTxt <> "0.0.0.0" Then
                                                        zIPAddressLineCheck = zIPAddressInputTxt
                                                        Exit Function
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

        'this just makes sure that its false before it exits
        'the only way it will be set to true is if it passes all the checks
        'zIPAddressLineCheck = False
        zIPAddressLineCheck = ""
    End Function


    Public Function zTextLinesToListboxIPAdressFilter(zTLTLBIPADDtxtInput As TextBox, zTLTLBIPADDListboxOutput As ListBox, Optional zTLTLBIPADDListboxOutputClear As Integer = 0)
        'this checks the line being added for a bunch of stuff
        'to see if its a valid ip
        'before adding it to the listbox
        'this assumes that whichever text or list box exists
        'and is correct
        'this function adds every line of text to a list box
        'this also clears the list box based on zeftcpvListboxOutputClear
        'this wont clear the list unless its set to 1
        'this also trims return characters when adding entires
        'this also trims blank lines vbcrlf
        If zTLTLBIPADDtxtInput.Text = vbNullString Then Exit Function
        'have to make sure the last character is a return character
        Dim zLastCharacter1 As String
        Dim zLastCharacter2 As String
        zLastCharacter1 = Mid(zTLTLBIPADDtxtInput.Text, Len(zTLTLBIPADDtxtInput.Text))
        zLastCharacter2 = Mid(zTLTLBIPADDtxtInput.Text, Len(zTLTLBIPADDtxtInput.Text) - 1)
        If zLastCharacter1 <> Chr(13) And zLastCharacter2 <> Chr(10) Then
            zTLTLBIPADDtxtInput.Text = zTLTLBIPADDtxtInput.Text & vbCrLf
        End If
        Dim zRt As Integer, zRt2 As Integer, zTstr As String
        Dim zRstop As Boolean
        Dim zIpCheck As String
        zRstop = False
        zRt = InStr(zTLTLBIPADDtxtInput.Text, vbCrLf)
        If zRt = 0 Then
            'no return character
            'assuming just one line
            If zTLTLBIPADDListboxOutputClear = 1 Then
                zTLTLBIPADDListboxOutput.Items.Clear()
            End If
            'zeftcpvListboxOutput.Items.Add(zeftcpvTextboxInput.Text)

            'add to every spot where the list box gets an entry added
            'this checks to see if the line containss the extraction value
            'default 0 optional returns remote address
            zIpCheck = zIPAddressLineCheck(zTLTLBIPADDtxtInput.Text)
            If zIpCheck <> "" Then
                'add it to the list if it found the value
                zTLTLBIPADDListboxOutput.Items.Add(zIpCheck)
            Else
                'didnt return a value
                'this is the only time it will exit function
                Exit Function
            End If
        Else
            If zTLTLBIPADDListboxOutputClear = 1 Then
                zTLTLBIPADDListboxOutput.Items.Clear()
            End If
            'found a return character
            'check to see if there is more than one
            zRt2 = InStr(zRt + 2, zTLTLBIPADDtxtInput.Text, vbCrLf)
            If zRt2 > 0 Then
                'there is more than one
                zRt2 = zRt
                zRt = 1
                'first pass
                zTstr = Mid(zTLTLBIPADDtxtInput.Text, zRt, zRt2 - 1)
                If zTstr <> vbNullString And zTstr <> vbCrLf Then
                    'zeftcpvListboxOutput.Items.Add(zTstr)

                    zIpCheck = zIPAddressLineCheck(zTstr)
                    If zIpCheck <> "" Then
                        'add it to the list if it found the value
                        zTLTLBIPADDListboxOutput.Items.Add(zIpCheck)
                    End If
                End If
                'every other pass to the end
                zRt = zRt2
                zRt2 = InStr(zRt + 2, zTLTLBIPADDtxtInput.Text, vbCrLf)
                Do
                    Application.DoEvents()
                    zTstr = Mid(zTLTLBIPADDtxtInput.Text, zRt + 2, zRt2 - zRt - 2)
                    If zTstr <> vbNullString And zTstr <> vbCrLf Then
                        'zeftcpvListboxOutput.Items.Add(zTstr)

                        'add to every spot where the list box gets an entry added
                        'this checks to see if the line containss the extraction value
                        'default 0 optional returns remote address
                        zIpCheck = zIPAddressLineCheck(zTstr)
                        If zIpCheck <> "" Then
                            'add it to the list if it found the value
                            zTLTLBIPADDListboxOutput.Items.Add(zIpCheck)
                        End If
                    End If
                    zRt = zRt2
                    zRt2 = InStr(zRt + 2, zTLTLBIPADDtxtInput.Text, vbCrLf)
                    If zRt2 = 0 Then
                        zRstop = True
                        zTstr = Mid(zTLTLBIPADDtxtInput.Text, zRt, Len(zTLTLBIPADDtxtInput.Text))
                        If zTstr <> vbNullString And zTstr <> vbCrLf Then
                            'zeftcpvListboxOutput.Items.Add(zTstr)

                            'add to every spot where the list box gets an entry added
                            'this checks to see if the line containss the extraction value
                            'default 0 optional returns remote address
                            zIpCheck = zIPAddressLineCheck(zTstr)
                            If zIpCheck <> "" Then
                                'add it to the list if it found the value
                                zTLTLBIPADDListboxOutput.Items.Add(zIpCheck)
                            End If
                        End If
                    End If
                Loop Until zRstop = True
            Else
                'there isnt more than one
                'add the string to the list box minus the return character
                zTstr = Mid(zTLTLBIPADDtxtInput.Text, 1, Len(zTLTLBIPADDtxtInput.Text) - 2)

                'zeftcpvListboxOutput.Items.Add(zTstr)

                'add to every spot where the list box gets an entry added
                'this checks to see if the line containss the extraction value
                'default 0 optional returns remote address
                zIpCheck = zIPAddressLineCheck(zTstr)
                If zIpCheck <> "" Then
                    'add it to the list if it found the value
                    zTLTLBIPADDListboxOutput.Items.Add(zIpCheck)
                End If
            End If
        End If

    End Function

    Public Function zListBoxKeyUp(zLBKUKeycode As Integer, zLBKUListBox As ListBox)
        'this is for copy and pasting in to a listbox key up section
        'you pass the key code and the list box to it
        'and it does all of the key up checks
        'del = delete entry of currently selected index

        Select Case zLBKUKeycode
            Case Keys.Delete
                If zLBKUListBox.Items.Count <> 0 Then
                    If zLBKUListBox.SelectedIndex <> -1 Then
                        zLBKUListBox.Items.RemoveAt(zLBKUListBox.SelectedIndex)
                    End If
                End If
        End Select
    End Function

    Public Function zListBoxMouseUp(zLBMCButton As Integer, zLBMCListBox As ListBox)
        'e.Button
        'Windows.Forms.MouseButtons.Middle
        'dont need to use the windows.forms part i guess

        'middle mouse copies the entry to the clipboard
        Select Case zLBMCButton
            Case MouseButtons.Middle
                If zLBMCListBox.Items.Count <> 0 Then
                    If zLBMCListBox.SelectedIndex <> -1 Then
                        Clipboard.Clear()
                        Clipboard.SetText(CStr(zLBMCListBox.Items.Item(zLBMCListBox.SelectedIndex)))
                    End If
                End If
        End Select

    End Function

    Public Function zOpenWindowsDirectoryInExplorer(zOWInputPathString As String, Optional zOWInputFileString As String = "", Optional zOWInputArg As String = "")
        'dosnt use a path filter
        'path has to be a properly formatted path
        'or it will error

        'some formatting to fix laziness and forgetting to add a slash
        'check if the last character of the path is a \
        'if there isnt one
        'add one
        Dim zLastPathChar As String
        Dim zMsgOut As String
        zMsgOut = "Folder doesn't Exist."

        zLastPathChar = Mid(zOWInputPathString, Len(zOWInputPathString), 1)
        If zLastPathChar <> "\" Then
            zOWInputPathString = zOWInputPathString & "\"
        End If
        If System.IO.File.Exists(zOWInputPathString & zOWInputFileString) = False Then
            'check to see if the file exists
            'it does not
            'set the input file and the arguments to nothing
            zOWInputFileString = ""
            zOWInputArg = ""
            'this prevents any screw ups on a file that doesnt exist
            zMsgOut = zMsgOut & " File doesn't Exist"
        End If

        If System.IO.Directory.Exists(zOWInputPathString) Then
            'check to see if the path exists
            'it does
            If zOWInputFileString <> "" And zOWInputArg = "" Then
                'the file is not nothing but the arguments are nothing
                'this the default to use /select, as the argument
                '/select,
                Process.Start("explorer.exe", "/select," & zOWInputPathString & zOWInputFileString)
            ElseIf zOWInputFileString <> "" And zOWInputArg <> "" Then
                'both the file and the arguments are not nothing
                'use custom argument and file
                Process.Start("explorer.exe", zOWInputArg & zOWInputPathString & zOWInputFileString)
            ElseIf zOWInputFileString = "" And zOWInputArg = "" Then
                'both optionals are nothing
                'just opeth the path
                ' Open the folder using Windows Explorer
                Process.Start("explorer.exe", zOWInputPathString)
            End If
        Else
            'MessageBox.Show("The specified folder does not exist.", "zBlocker", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'if the file doesnt exist it tacks the message on to the message output
            'the default message is that the folder doesnt exist
            MessageBox.Show(zMsgOut, "zBlocker", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Function

    Public Function zExtractValueFromTCPViewConLine(zExTcpViewConTxt As String, Optional zExTcpViewConValue As Integer = 0) As String

        'returns nothing if it doesnt pass a check

        'zExtractValueFromTCPViewLine = ""

        'the copy and paste from the gui is formatted differently than from tcpvcon

        'going to need this for writing something that loops running tcpvcon

        'D:\zonide\tools\sysinternals\SysinternalsSuite\

        'need to loop this command to a log file
        'tcpvcon -a -c -n

        'the output from tcpvcon -a -c -n
        'TCP,svchost.exe,924,LISTENING,0.0.0.0,0.0.0.0
        'TCP,OneApp.IGCC.WinService.exe,3904,LISTENING,0.0.0.0,0.0.0.0
        'TCP,svchost.exe,3912,LISTENING,0.0.0.0,0.0.0.0
        'TCP,NahimicService.exe,3976,LISTENING,127.0.0.1,0.0.0.0
        'TCP,lsass.exe,852,LISTENING,0.0.0.0,0.0.0.0
        'TCP,wininit.exe,756,LISTENING,0.0.0.0,0.0.0.0
        'TCP,svchost.exe,1452,LISTENING,0.0.0.0,0.0.0.0
        'TCP,svchost.exe,1948,LISTENING,0.0.0.0,0.0.0.0
        'TCP,spoolsv.exe,3356,LISTENING,0.0.0.0,0.0.0.0
        'TCP,services.exe,840,LISTENING,0.0.0.0,0.0.0.0
        'TCP,firefox.exe,13116,ESTABLISHED,127.0.0.1,127.0.0.1
        'TCP,firefox.exe,13116,ESTABLISHED,127.0.0.1,127.0.0.1
        'TCP,firefox.exe,11900,ESTABLISHED,127.0.0.1,127.0.0.1
        'TCP,firefox.exe,11900,ESTABLISHED,127.0.0.1,127.0.0.1
        'UDP,svchost.exe,4108,*,0.0.0.0,*
        'UDP,svchost.exe,3912,*,0.0.0.0,*
        'UDP,svchost.exe,3956,*,127.0.0.1,*
        'TCPV6,svchost.exe,924,LISTENING,[0:0:0:0:0:0:0:0],[0:0:0:0:0:0:0:0]
        'TCPV6,OneApp.IGCC.WinService.exe,3904,LISTENING,[0:0:0:0:0:0:0:0],[0:0:0:0:0:0:0:0]

        '1 - Protocol
        '2 - Process
        '3 - PID(Process ID)
        '4 - State
        '5 - Local Address
        '6 - Remote Address

        'tcpviewcon doesnt have these?
        'Local Port
        'Remote Port
        'Create Time
        'Module Name

        'tcpvcon

        'going to count the , as a format check
        'if it passes that
        'do more format checking if needed

        '5 total commas , to check for

        Dim zComma1 As Integer
        Dim zComma2 As Integer
        Dim zComma3 As Integer
        Dim zComma4 As Integer
        Dim zComma5 As Integer

        zComma1 = InStr(1, zExTcpViewConTxt, ",")
        zComma2 = InStr(zComma1 + 1, zExTcpViewConTxt, ",")
        zComma3 = InStr(zComma2 + 1, zExTcpViewConTxt, ",")
        zComma4 = InStr(zComma3 + 1, zExTcpViewConTxt, ",")
        zComma5 = InStr(zComma4 + 1, zExTcpViewConTxt, ",")

        'If zComma1 <> 0 Then
        'End If

        Dim z5CommaCheck As Boolean = False

        'these trees help keep the if blocks with a lot of code in them to a minimum
        'and they are easy to write in notepad ++ with the column numerator and alt shift selecting

        If zComma1 <> 0 Then
            If zComma2 <> 0 Then
                If zComma3 <> 0 Then
                    If zComma4 <> 0 Then
                        If zComma5 <> 0 Then
                            z5CommaCheck = True
                        Else
                            zExtractValueFromTCPViewConLine = ""
                            Exit Function
                        End If
                    End If
                End If
            End If
        End If

        If z5CommaCheck = True Then

            '1 - Protocol
            '2 - Process
            '3 - PID(Process ID)
            '4 - State
            '5 - Local Address
            '6 - Remote Address

            Dim zStrProtocol As String
            Dim zStrProcess As String
            Dim zStrPID As String
            Dim zStrState As String
            Dim zStrLocalAddress As String
            Dim zStrRemoteAddress As String

            zStrProcess = Mid(zExTcpViewConTxt, 1, zComma1 - 1)
            zStrPID = Mid(zExTcpViewConTxt, zComma1 + 1, zComma2 - zComma1 - 1)
            zStrProtocol = Mid(zExTcpViewConTxt, zComma2 + 1, zComma3 - zComma2 - 1)
            zStrState = Mid(zExTcpViewConTxt, zComma3 + 1, zComma4 - zComma3 - 1)
            zStrLocalAddress = Mid(zExTcpViewConTxt, zComma4 + 1, zComma5 - zComma4 - 1)
            zStrRemoteAddress = Mid(zExTcpViewConTxt, zComma5 + 1, Len(zExTcpViewConTxt))

            '1 - Protocol
            '2 - Process
            '3 - PID(Process ID)
            '4 - State
            '5 - Local Address
            '6 - Remote Address

            'since im filtering this with the ip check for ipv4
            'i dont need to check for the donts in the line extractors
            'this just extracts whatever is in there and returns it

            Select Case zExTcpViewConValue
                Case 0
                    'default 0 no optional
                    'returns remote address
                    zExtractValueFromTCPViewConLine = zStrRemoteAddress
                Case 1
                    '1 returns Protocol
                    zExtractValueFromTCPViewConLine = zStrProtocol
                Case 2
                    '2 returns Process
                    zExtractValueFromTCPViewConLine = zStrProcess
                Case 3
                    '3 returns PID
                    zExtractValueFromTCPViewConLine = zStrPID
                Case 4
                    '4 returns State
                    zExtractValueFromTCPViewConLine = zStrState
                Case 5
                    '5 returns Local Address
                    zExtractValueFromTCPViewConLine = zStrLocalAddress
                Case 6
                    '6 returns Remote Address
                    zExtractValueFromTCPViewConLine = zStrRemoteAddress
            End Select
        End If

    End Function


    Public Function zExtractRemoteAddressFromTCPViewConTextBoxAddToListbox(zERAFTCPViewConTextBoxInput As TextBox, zERAFTCPViewConListboxOutput As ListBox, Optional zERAFTCPViewConListboxOutputClear As Integer = 0)
        'going to make this kind of a garbage sort where it doesnt exit function if it doesnt find a value in a line
        'so it will just skip those lines and only pick out valid matches
        '
        'this sorts through tcpview con copy and paste entries
        'and extracts the remote address

        'needs to be its own function
        'i could also make it so it has the option to scan the program or service name
        'and from thre isolate just those ips
        'i should put that in a seperate function

        'going to have to copy and paste add textbox to list box and add this to it as a filter

        'zExtractValueFromTCPViewLine()

        'this assumes that whichever text or list box exists
        'and is correct
        'this function adds every line of text to a list box
        'this also clears the list box based on zeftcpvListboxOutputClear
        'this wont clear the list unless its set to 1
        'this also trims return characters when adding entires
        'this also trims blank lines vbcrlf
        If zERAFTCPViewConTextBoxInput.Text = vbNullString Then Exit Function
        'have to make sure the last character is a return character
        Dim zLastCharacter1 As String
        Dim zLastCharacter2 As String
        zLastCharacter1 = Mid(zERAFTCPViewConTextBoxInput.Text, Len(zERAFTCPViewConTextBoxInput.Text))
        zLastCharacter2 = Mid(zERAFTCPViewConTextBoxInput.Text, Len(zERAFTCPViewConTextBoxInput.Text) - 1)
        If zLastCharacter1 <> Chr(13) And zLastCharacter2 <> Chr(10) Then
            zERAFTCPViewConTextBoxInput.Text = zERAFTCPViewConTextBoxInput.Text & vbCrLf
        End If
        Dim zRt As Integer, zRt2 As Integer, zTstr As String
        Dim zRstop As Boolean
        Dim zExtractValue As String
        zRstop = False
        zRt = InStr(zERAFTCPViewConTextBoxInput.Text, vbCrLf)
        If zRt = 0 Then
            'no return character
            'assuming just one line
            If zERAFTCPViewConListboxOutputClear = 1 Then
                zERAFTCPViewConListboxOutput.Items.Clear()
            End If
            'zeftcpvListboxOutput.Items.Add(zeftcpvTextboxInput.Text)

            'add to every spot where the list box gets an entry added
            'this checks to see if the line containss the extraction value
            'default 0 optional returns remote address
            zExtractValue = zExtractValueFromTCPViewConLine(zERAFTCPViewConTextBoxInput.Text)
            'adding ip filter
            zExtractValue = zIPAddressLineCheck(zExtractValue)
            If zExtractValue <> "" Then
                'add it to the list if it found the value
                zERAFTCPViewConListboxOutput.Items.Add(zExtractValue)
            Else
                'didnt return a value
                'this is the only time it will exit function
                Exit Function
            End If

        Else
            If zERAFTCPViewConListboxOutputClear = 1 Then
                zERAFTCPViewConListboxOutput.Items.Clear()
            End If
            'found a return character
            'check to see if there is more than one
            zRt2 = InStr(zRt + 2, zERAFTCPViewConTextBoxInput.Text, vbCrLf)
            If zRt2 > 0 Then
                'there is more than one
                zRt2 = zRt
                zRt = 1
                'first pass
                zTstr = Mid(zERAFTCPViewConTextBoxInput.Text, zRt, zRt2 - 1)
                If zTstr <> vbNullString And zTstr <> vbCrLf Then
                    'zeftcpvListboxOutput.Items.Add(zTstr)

                    'add to every spot where the list box gets an entry added
                    'this checks to see if the line containss the extraction value
                    'default 0 optional returns remote address
                    zExtractValue = zExtractValueFromTCPViewConLine(zTstr)
                    'adding ip filter
                    zExtractValue = zIPAddressLineCheck(zExtractValue)
                    If zExtractValue <> "" Then
                        'add it to the list if it found the value
                        zERAFTCPViewConListboxOutput.Items.Add(zExtractValue)
                    End If

                    'add to every spot where the list box gets an entry added
                    'this checks to see if the line containss the extraction value
                    'default 0 optional returns remote address
                    zExtractValue = zExtractValueFromTCPViewConLine(zERAFTCPViewConTextBoxInput.Text)
                    'adding ip filter
                    zExtractValue = zIPAddressLineCheck(zExtractValue)
                    If zExtractValue <> "" Then
                        'add it to the list if it found the value
                        zERAFTCPViewConListboxOutput.Items.Add(zExtractValue)
                    Else
                        'didnt return a value
                        'this is the only time it will exit function
                        Exit Function
                    End If

                Else
                    If zERAFTCPViewConListboxOutputClear = 1 Then
                        zERAFTCPViewConListboxOutput.Items.Clear()
                    End If
                    'every other pass to the end
                    zRt = zRt2
                    zRt2 = InStr(zRt + 2, zERAFTCPViewConTextBoxInput.Text, vbCrLf)
                    Do
                        Application.DoEvents()
                        zTstr = Mid(zERAFTCPViewConTextBoxInput.Text, zRt + 2, zRt2 - zRt - 2)
                        If zTstr <> vbNullString And zTstr <> vbCrLf Then
                            'zeftcpvListboxOutput.Items.Add(zTstr)

                            'add to every spot where the list box gets an entry added
                            'this checks to see if the line containss the extraction value
                            'default 0 optional returns remote address
                            zExtractValue = zExtractValueFromTCPViewConLine(zTstr)
                            'adding ip filter
                            zExtractValue = zIPAddressLineCheck(zExtractValue)
                            If zExtractValue <> "" Then
                                'add it to the list if it found the value
                                zERAFTCPViewConListboxOutput.Items.Add(zExtractValue)
                            End If


                        End If
                        'every other pass to the end
                        zRt = zRt2
                        zRt2 = InStr(zRt + 2, zERAFTCPViewConTextBoxInput.Text, vbCrLf)
                        If zRt2 = 0 Then
                            zRstop = True
                            zTstr = Mid(zERAFTCPViewConTextBoxInput.Text, zRt, Len(zERAFTCPViewConTextBoxInput.Text))
                            If zTstr <> vbNullString And zTstr <> vbCrLf Then
                                'zeftcpvListboxOutput.Items.Add(zTstr)

                                'add to every spot where the list box gets an entry added
                                'this checks to see if the line containss the extraction value
                                'default 0 optional returns remote address
                                zExtractValue = zExtractValueFromTCPViewConLine(zTstr)
                                'adding ip filter
                                zExtractValue = zIPAddressLineCheck(zExtractValue)
                                If zExtractValue <> "" Then
                                    'add it to the list if it found the value
                                    zERAFTCPViewConListboxOutput.Items.Add(zExtractValue)
                                End If
                            End If
                            zRt = zRt2
                            zRt2 = InStr(zRt + 2, zERAFTCPViewConTextBoxInput.Text, vbCrLf)
                            If zRt2 = 0 Then
                                zRstop = True
                                zTstr = Mid(zERAFTCPViewConTextBoxInput.Text, zRt, Len(zERAFTCPViewConTextBoxInput.Text))
                                If zTstr <> vbNullString And zTstr <> vbCrLf Then
                                    'zeftcpvListboxOutput.Items.Add(zTstr)

                                    'add to every spot where the list box gets an entry added
                                    'this checks to see if the line containss the extraction value
                                    'default 0 optional returns remote address
                                    zExtractValue = zExtractValueFromTCPViewConLine(zTstr)
                                    'adding ip filter
                                    zExtractValue = zIPAddressLineCheck(zExtractValue)
                                    If zExtractValue <> "" Then
                                        'add it to the list if it found the value
                                        zERAFTCPViewConListboxOutput.Items.Add(zExtractValue)
                                    End If

                                End If
                            End If
                        End If
                    Loop Until zRstop = True
                End If
            Else
                'there isnt more than one
                'add the string to the list box minus the return character
                zTstr = Mid(zERAFTCPViewConTextBoxInput.Text, 1, Len(zERAFTCPViewConTextBoxInput.Text) - 2)

                'zeftcpvListboxOutput.Items.Add(zTstr)

                'add to every spot where the list box gets an entry added
                'this checks to see if the line containss the extraction value
                'default 0 optional returns remote address
                zExtractValue = zExtractValueFromTCPViewConLine(zTstr)
                'adding ip filter
                zExtractValue = zIPAddressLineCheck(zExtractValue)
                If zExtractValue <> "" Then
                    'add it to the list if it found the value
                    zERAFTCPViewConListboxOutput.Items.Add(zExtractValue)
                End If
            End If
        End If
    End Function

    Public Function zScanStringReturnAsArrayWithProgress(zSRInputString As String, zSRFind As String, zSRProgressBar As ProgressBar) As Array
        'just got done testing this
        'this works to find any amount of the find string
        'and puts it in to an array that can be iterated through

        'i wrote a zgetarraycount for use with this
        'it gets all consecutive entries and lets you
        'iterate through them with a for statement

        'tested all of these and they work
        'this can be used for comma seperated
        'space seperated - looks for words
        'return character seperated - looks for text lines
        'any string delimted by the find string and returned as an array - tested and this works too

        'the way you use this
        'from the code that calls the function

        'example 1 i use this way: from procedure side
        'Dim zTempArrayTest As Array
        'zTempArrayTest = zScanStringReturnAsArrayWithProgress(zTestStrInput, vbCrLf, pbSaveLoad)
        'Debug.Print(zTempArrayTest(3))
        'Debug.Print(zGetArrayCount(zTempArrayTest))

        'example 2: from procedure side
        'Dim zTmp(50000) As String
        'zTmp = zScanReturnAsArray(Input String, Thing to find)
        'Debug.Print(zGetArrayCount(zTmp))

        'this assumes that whichever text or list box exists
        'and is correct
        'this function adds every line of text to a list box
        'this also clears the list box based on zListClear
        'this wont clear the list unless its set to 1
        'this also trims return characters when adding entires
        'this also trims blank lines vbcrlf

        If zSRInputString = vbNullString Then Exit Function
        zSRProgressBar.Maximum = Len(zSRInputString)
        zSRProgressBar.Visible = True
        Dim zFind1 As Integer, zFind2 As Integer, zTempstr As String
        Dim zFindStop As Boolean
        zFindStop = False
        Dim zTmpArray(50000) As String
        Dim zTmpArrayCount As Integer = 0
        Dim zTmpIterator As Integer = 0
        zFind1 = InStr(zSRInputString, zSRFind)
        If zFind1 = 0 Then
            'no find string found
            'assuming just one line
            zSRProgressBar.Value = zSRProgressBar.Maximum
            zSRProgressBar.Visible = False
            zSRProgressBar.Value = 0
            zSRProgressBar.Maximum = 0
            Exit Function
        Else
            'found a find string 
            'check to see if there is more than one
            zFind2 = InStr(zFind1 + Len(zSRFind), zSRInputString, zSRFind)
            If zFind2 > 0 Then
                'there is more than one
                zFind2 = zFind1
                zFind1 = 1
                'first pass
                zTempstr = Mid(zSRInputString, zFind1, zFind2 - 1)
                If zTempstr <> vbNullString And zTempstr <> zSRFind Then
                    zTmpArray(zTmpIterator) = zTempstr
                    zTmpIterator = zTmpIterator + 1
                End If
                'every other pass to the end
                zFind1 = zFind2
                zFind2 = InStr(zFind1 + Len(zSRFind), zSRInputString, zSRFind)
                Do
                    Application.DoEvents()
                    zTempstr = Mid(zSRInputString, zFind1 + Len(zSRFind), zFind2 - zFind1 - Len(zSRFind))
                    If zTempstr <> vbNullString And zTempstr <> zSRFind Then
                        zTmpArray(zTmpIterator) = zTempstr
                        zTmpIterator = zTmpIterator + 1
                    End If
                    zFind1 = zFind2
                    zFind2 = InStr(zFind1 + Len(zSRFind), zSRInputString, zSRFind)
                    zSRProgressBar.Value = zFind2
                    If zFind2 = 0 Then
                        zFindStop = True
                        zTempstr = Mid(zSRInputString, zFind1 + Len(zSRFind), Len(zSRInputString))
                        If zTempstr <> vbNullString And zTempstr <> zSRFind Then
                            zTmpArray(zTmpIterator) = zTempstr
                        End If
                    End If
                Loop Until zFindStop = True
            Else
                'there isnt more than one
                'add the string to the list box minus the length of the find string
                zTempstr = Mid(zSRInputString, 1, Len(zSRInputString) - Len(zSRFind))
                zTmpArray(zTmpIterator) = zTempstr
            End If
            zScanStringReturnAsArrayWithProgress = zTmpArray
        End If
        zSRProgressBar.Value = zSRProgressBar.Maximum
        zSRProgressBar.Visible = False
        zSRProgressBar.Value = 0
        zSRProgressBar.Maximum = 0
    End Function

    Public Function zScanStringReturnAsArray(zSRInputString As String, zSRFind As String) As Array
        'same as the other one but with no progress bar

        'just got done testing this
        'this works to find any amount of the find string
        'and puts it in to an array that can be iterated through

        'i wrote a zgetarraycount for use with this
        'it gets all consecutive entries and lets you
        'iterate through them with a for statement

        'tested all of these and they work
        'this can be used for comma seperated
        'space seperated - looks for words
        'return character seperated - looks for text lines
        'any string delimted by the find string and returned as an array - tested and this works too

        'the way you use this
        'from the code that calls the function

        'example 1 i use this way: from procedure side
        'Dim zTempArrayTest As Array
        'zTempArrayTest = zScanStringReturnAsArrayWithProgress(zTestStrInput, vbCrLf, pbSaveLoad)
        'Debug.Print(zTempArrayTest(3))
        'Debug.Print(zGetArrayCount(zTempArrayTest))

        'example 2: from procedure side
        'Dim zTmp(50000) As String
        'zTmp = zScanReturnAsArray(Input String, Thing to find)
        'Debug.Print(zGetArrayCount(zTmp))

        'this assumes that whichever text or list box exists
        'and is correct
        'this function adds every line of text to a list box
        'this also clears the list box based on zListClear
        'this wont clear the list unless its set to 1
        'this also trims return characters when adding entires
        'this also trims blank lines vbcrlf

        If zSRInputString = vbNullString Then Exit Function
        Dim zFind1 As Integer, zFind2 As Integer, zTempstr As String
        Dim zFindStop As Boolean
        zFindStop = False
        Dim zTmpArray(50000) As String
        Dim zTmpArrayCount As Integer = 0
        Dim zTmpIterator As Integer = 0
        zFind1 = InStr(zSRInputString, zSRFind)
        If zFind1 = 0 Then
            'no find string found
            'assuming just one line
            Exit Function
        Else
            'found a find string 
            'check to see if there is more than one
            zFind2 = InStr(zFind1 + Len(zSRFind), zSRInputString, zSRFind)
            If zFind2 > 0 Then
                'there is more than one
                zFind2 = zFind1
                zFind1 = 1
                'first pass
                zTempstr = Mid(zSRInputString, zFind1, zFind2 - 1)
                If zTempstr <> vbNullString And zTempstr <> zSRFind Then
                    zTmpArray(zTmpIterator) = zTempstr
                    zTmpIterator = zTmpIterator + 1
                End If
                'every other pass to the end
                zFind1 = zFind2
                zFind2 = InStr(zFind1 + Len(zSRFind), zSRInputString, zSRFind)
                Do
                    Application.DoEvents()
                    zTempstr = Mid(zSRInputString, zFind1 + Len(zSRFind), zFind2 - zFind1 - Len(zSRFind))
                    If zTempstr <> vbNullString And zTempstr <> zSRFind Then
                        zTmpArray(zTmpIterator) = zTempstr
                        zTmpIterator = zTmpIterator + 1
                    End If
                    zFind1 = zFind2
                    zFind2 = InStr(zFind1 + Len(zSRFind), zSRInputString, zSRFind)
                    If zFind2 = 0 Then
                        zFindStop = True
                        zTempstr = Mid(zSRInputString, zFind1 + Len(zSRFind), Len(zSRInputString))
                        If zTempstr <> vbNullString And zTempstr <> zSRFind Then
                            zTmpArray(zTmpIterator) = zTempstr
                        End If
                    End If
                Loop Until zFindStop = True
            Else
                'there isnt more than one
                'add the string to the list box minus the length of the find string
                zTempstr = Mid(zSRInputString, 1, Len(zSRInputString) - Len(zSRFind))
                zTmpArray(zTmpIterator) = zTempstr
            End If
            zScanStringReturnAsArray = zTmpArray
        End If
    End Function

    Public Function zGetArrayCount(zTmpArray As Array) As Integer
        'this gets all valid entires that arent nothing from any 1 dimensional any size array
        'this assumes the array has no blank spots from the lower to the upper limits
        Dim zTmpArrayUpperbound As Integer
        zTmpArrayUpperbound = zTmpArray.GetUpperBound(0)
        Dim zTmpArrayLowerbound As Integer
        zTmpArrayLowerbound = zTmpArray.GetLowerBound(0)
        Dim zTmpCount As Integer = 0
        Dim zI As Integer
        For zI = zTmpArrayLowerbound To zTmpArrayUpperbound
            Application.DoEvents()
            If zTmpArray(zI) <> "" Then
                zTmpCount = zTmpCount + 1
            End If
        Next
        zGetArrayCount = zTmpCount
    End Function

    Public Function zArrayToListBox(zATLTmpArray As Array, zATLListBox As ListBox, Optional zATLClearListBox As Integer = 0)
        'the default doesnt clear the listbox
        'specifiying 1 on the optional zATLClearListBox will
        'clear the destination listbox before adding the array
        Dim zTmpArrayCount As Integer
        zTmpArrayCount = zGetArrayCount(zATLTmpArray)

        If zTmpArrayCount = 0 Then
            Exit Function
        End If

        If zATLClearListBox = 1 Then
            zATLListBox.Items.Clear()
        End If

        Dim zI As Integer
        For zI = 0 To zTmpArrayCount - 1
            Application.DoEvents()
            zATLListBox.Items.Add(zATLTmpArray(zI))
        Next
    End Function

    Public Function zListBoxToArray(zLTATmpArray As Array, zLTAListBox As ListBox, Optional zZTLClearListBox As Integer = 0)

        'expects string arrays with a predefined listbox limit
        'have to do it this way because you cant use redim from the module level
        'this example works since you already know the list box size before you call the function
        'you can define the string array to the listbox count
        'this just save you from having to write the code to make a temporary list box array

        'example: from procedure level calling this function
        'Dim zTempArrayTest2(lstInput.Items.Count - 1) As String
        'zListBoxToArray(zTempArrayTest2, lstInput)

        'the default doesnt clear the listbox
        'specifiying 1 on the optional zATLClearListBox will
        'clear the destination listbox before adding the array

        If zLTAListBox.Items.Count = 0 Then
            Exit Function
        End If

        If zZTLClearListBox = 1 Then
            zLTAListBox.Items.Clear()
        End If

        'cant redim from within a module
        'ReDim zLTATmpArray(zLTAListBox.Items.Count - 1) As String

        Dim zI As Integer
        For zI = 0 To zLTAListBox.Items.Count - 1
            Application.DoEvents()
            zLTATmpArray(zI) = zLTAListBox.Items.Item(zI)
        Next

    End Function

    Public Function zArrayToString(zATSTmpArray As Array, Optional zSeparator As String = "") As String

        'the default of nothing will do a return character vbcrlf
        'i should make another version that does accept nothing and has no default
        'on the weird case where i want to merge a whole array in to 1 line with no seperators

        'this expects an array with consecutive entires
        'no blanks with potential blank entires at the end
        'that will be skipped

        Dim zTmpArrayCount As Integer
        zTmpArrayCount = zGetArrayCount(zATSTmpArray)

        If zTmpArrayCount = 0 Then
            Exit Function
        End If

        If zSeparator = "" Then
            zSeparator = zR
        End If

        Dim zTmpStr As String
        Dim zI As Integer
        For zI = 0 To zTmpArrayCount - 1
            Application.DoEvents()
            If zI = 0 Then
                zTmpStr = zATSTmpArray(zI)
            Else
                zTmpStr = zTmpStr & zSeparator & zATSTmpArray(zI)
            End If
        Next

        zArrayToString = zTmpStr

    End Function

    Public Function zArrayToStringNoDefault(zATSNDTmpArray As Array, zATSNDSeparator As String) As String

        'this is the no default version that will accept nothing
        'but does require you to specify the input
        'even if it is nothing

        'this expects an array with consecutive entires
        'no blanks with potential blank entires at the end
        'that will be skipped

        Dim zTmpArrayCount As Integer
        zTmpArrayCount = zGetArrayCount(zATSNDTmpArray)

        If zTmpArrayCount = 0 Then
            Exit Function
        End If

        Dim zTmpStr As String
        Dim zI As Integer
        For zI = 0 To zTmpArrayCount - 1
            Application.DoEvents()
            If zI = 0 Then
                zTmpStr = zATSNDTmpArray(zI)
            Else
                zTmpStr = zTmpStr & zATSNDSeparator & zATSNDTmpArray(zI)
            End If
        Next

        zArrayToStringNoDefault = zTmpStr

    End Function




    '==================================================================================================
    '                                   todo at end of file:
    '==================================================================================================
    'since its just easier to add new stuff to the bottom
    'im putting this downhere instead of up at the top
    '==================================================================================================

    '==================================================================================================

End Module
