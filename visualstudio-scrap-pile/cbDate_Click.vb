    Private Sub cbDate_Click(sender As Object, e As EventArgs) Handles cbDate.Click

        'old code

        'txtLog.Text = txtLog.Text & vbCrLf & vbCrLf & txtDate.Text & vbCrLf & vbCrLf
        'Dim zLog As String
        'zLog = txtLog.Text
        ''Debug.Print(zLog.Length)
        'txtLog.Select(zLog.Length, 0)
        'txtLog.Focus()

        'Private Sub btTimestamp_Click(sender As Object, e As EventArgs) Handles btTimestamp.Click
        'txtLog.Focus()

        'new updated code from craft notes

        Dim zTs As String
        'zTs = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")

        zTs = txtDate.Text
        'zTs = "==== " & zTs & " === "
        zTs = zR2 & "==== " & zTs & " === " & zR2

        If txtLog.Text = vbNullString Then
            'txtLog.Text = txtLog.Text & vbCrLf & vbCrLf & zTs & vbCrLf & vbCrLf
            'txtLog.Text = vbCrLf & zTs & vbCrLf & vbCrLf
            txtLog.Text = vbCrLf & zTs & vbCrLf
            txtLog.SelectionStart = Len(txtLog.Text)
            txtLog.Select()
            txtLog.ScrollToCaret()
            Exit Sub
        Else
            If txtLog.SelectionStart = -1 Then
                'txtLog.Text = txtLog.Text & vbCrLf & vbCrLf & zTs & vbCrLf & vbCrLf
                'txtLog.Text = txtLog.Text & vbCrLf & zTs & vbCrLf & vbCrLf
                txtLog.Text = txtLog.Text & vbCrLf & zTs & vbCrLf
                txtLog.SelectionStart = Len(txtLog.Text)
                txtLog.Select()
                txtLog.ScrollToCaret()
                Exit Sub
            ElseIf txtLog.SelectionStart = 0 Then
                txtLog.SelectionStart = 1
            End If
        End If


        'trying the built in insert thing

        'Dim zBefore As String
        'Dim zAfter As String
        'zBefore = Mid(txtLog.Text, 1, txtLog.SelectionStart)
        ''MsgBox(zBefore)
        'zAfter = Mid(txtLog.Text, txtLog.SelectionStart + 1, Len(txtLog.Text))
        ''MsgBox(zAfter)
        '
        'If txtLog.SelectionStart = Len(txtLog.Text) Then
        '    zAfter = vbNullString
        'End If
        '
        'txtLog.Text = zBefore & vbCrLf & vbCrLf & zTs & vbCrLf & vbCrLf & zAfter
        '
        'txtLog.SelectionStart = Len(zBefore & vbCrLf & vbCrLf & zTs & vbCrLf & vbCrLf) - 1
        '
        'txtLog.Select()
        'txtLog.ScrollToCaret()
        '
        'End Sub

        'Str.Insert(4, " ")

        txtLog.SelectionStart = txtLog.SelectionStart + Len(zTs) - 1

        txtLog.Text = String.Insert(txtLog.SelectionStart + 1, zTs)
        txtLog.Select()
        txtLog.ScrollToCaret()

    End Sub
