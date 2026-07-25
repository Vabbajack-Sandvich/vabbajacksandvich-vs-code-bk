    Public Function zInsertTextIntoRichTextbox(zTxt As RichTextBox, zStr As String, Optional zRt As Integer = 0)
        'assumes textbox is real
        'will crash if it gets a non existant box

        'this adds optional returns around the insertion
        'zRt
        '0 = default none
        '1 = 1 return around the input string
        '2 = 2 return2 around the input string


        If zStr = "" Then Exit Function

        Dim zTs As String

        Select Case zRt
            Case 0
                'no returns
                'arguably not needed
                zTs = zTs
            Case 1
                '1 return
                zTs = zR & zTs & zR
            Case 2
                '2 returns
                zTs = zR2 & zTs & zR2
        End Select

        If zTxt.Text = vbNullString Then
            'ztxt.Text = vbCrLf & zTs & vbCrLf
            zTxt.Text = zTs
            zTxt.SelectionStart = Len(zTxt.Text)
            zTxt.Select()
            zTxt.ScrollToCaret()
            Exit Function
        Else
            If zTxt.SelectionStart <= 0 Then
                zTxt.SelectionStart = 1
            End If
        End If

        zTxt.SelectionStart = zTxt.SelectionStart + Len(zTs) - 1

        Dim zTStr As String
        zTStr = zTxt.Text

        zTxt.Text = zTStr.Insert(zTxt.SelectionStart + 1, zTs)
        zTxt.Select()
        zTxt.ScrollToCaret()

    End Function
