Public Class Form1
    Private Sub btCheck_Click(sender As Object, e As EventArgs) Handles btCheck.Click
        If txtRaw.Text = vbNullString Then Exit Sub
        ListRaw.Items.Clear()
        lbRaw.Text = "0"
        ListD.Items.Clear()
        lbD.Text = "0"
        ListNonD.Items.Clear()
        lbND.Text = "0"
        Dim zStop As Boolean
        zStop = False
        Dim zRaw As String
        zRaw = txtRaw.Text
        Dim zR As Integer
        zR = InStr(1, zRaw, vbCrLf)
        Dim zL As String
        Dim zI As Integer
        Dim zI2 As Integer
        Dim zI3 As Integer
        Dim zDupe As Boolean
        Dim zDupe2 As Boolean
        Dim zDc As Integer
        Dim zDcS As String
        Dim zLR1 As String
        Dim zLR2 As String
        Dim zLD As String

        If zR = 0 Then
            ListRaw.Items.Add(zRaw)
            lbRaw.Text = ListRaw.Items.Count
        Else
            'first go through the text and remove all blank lines
            'then add them to the box
            zRaw = zRaw & vbCrLf
            Do
                zL = Mid(zRaw, 1, zR + 1)
                If zL <> vbCrLf Then
                    ListRaw.Items.Add(zL)
                    lbRaw.Text = ListRaw.Items.Count
                End If
                zRaw = Mid(zRaw, zR + 2)
                zR = InStr(1, zRaw, vbCrLf)
                If zR = 0 Then zStop = True
            Loop Until zStop = True

            'then go through and check for duplicates against itself
            For zI = 0 To ListRaw.Items.Count - 1
                'this is the outer loop that iterates through the list
                'to be checked against
                zDupe = False
                For zI2 = 0 To ListRaw.Items.Count - 1
                    'this is the inner loop that checks the list against itself
                    'and determines if the checked item is a duplicate or not
                    zLR1 = ListRaw.Items.Item(zI)
                    zLR2 = ListRaw.Items.Item(zI2)
                    If ckDash.Checked = True Then
                        'this assumes the dash in the string is always going to be in the front
                        zDc = InStr(zLR1, "-")
                        If zDc = 1 Then
                            zDcS = Mid(zLR1, 2)
                            zLR1 = zDcS
                        End If
                        zDc = InStr(zLR2, "-")
                        If zDc = 1 Then
                            zDcS = Mid(zLR2, 2)
                            zLR2 = zDcS
                        End If
                    End If

                    If (zLR1 = zLR2 And zI <> zI2) Then
                        'this checks the outer string against the inner string
                        'in addition to making sure the outer index and the inner index
                        'are not the same
                        'but if it does match and the index isnt the same
                        'that means its a duplicate
                        zDupe = True
                        If ListD.Items.Count <> 0 Then
                            'if the duplicate list has something to check itself against
                            'it does, to prevent duplicates of duplicates showing up in the list
                            zDupe2 = False
                            For zI3 = 0 To ListD.Items.Count - 1
                                zLD = ListD.Items.Item(zI3)
                                If ckDash.Checked = True Then
                                    zDc = InStr(zLD, "-")
                                    If zDc <> 0 Then
                                        zDcS = Mid(zLD, 2)
                                        zLD = zDcS
                                    End If
                                End If
                                If zLR1 = zLD Then
                                    zDupe2 = True
                                End If
                            Next
                            If zDupe2 = False Then
                                ListD.Items.Add(ListRaw.Items.Item(zI))
                            End If
                        Else
                            ListD.Items.Add(ListRaw.Items.Item(zI))
                        End If
                    End If
                Next
                'its done checking the entry against the list
                'if zdupe is still false then it adds it to the non duplicated list
                If zDupe = False Then
                    ListNonD.Items.Add(ListRaw.Items.Item(zI))
                End If
            Next
            lbND.Text = ListNonD.Items.Count
            lbD.Text = ListD.Items.Count
            lbUnique.Text = "Unique Entires: " & ListNonD.Items.Count + ListD.Items.Count
        End If
    End Sub

    Private Sub btCopyND_Click(sender As Object, e As EventArgs) Handles btCopyND.Click
        If ListNonD.Items.Count = 0 Then Exit Sub
        Dim zI As Long
        Dim zTempString As String
        For zI = 0 To ListNonD.Items.Count - 1
            zTempString = zTempString & ListNonD.Items.Item(zI)
        Next
        Clipboard.Clear()
        Clipboard.SetText(zTempString)
    End Sub

    Private Sub btCopyD_Click(sender As Object, e As EventArgs) Handles btCopyD.Click
        If ListD.Items.Count = 0 Then Exit Sub
        Dim zI As Long
        Dim zTempString As String
        For zI = 0 To ListD.Items.Count - 1
            zTempString = zTempString & ListD.Items.Item(zI)
        Next
        Clipboard.Clear()
        Clipboard.SetText(zTempString)
    End Sub
End Class
