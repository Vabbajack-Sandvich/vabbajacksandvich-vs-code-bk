    Private Sub btInsertDate_Click(sender As Object, e As EventArgs) Handles btInsertDate.Click
        Dim zTs As String
        'going to go for this output format
        'ended up adding more to it
        'fake numbers
        '1 == 02-14-2025
        '2 == 02-15-2025
        '4 == 03-14-2025
        '8 == 04-11-2025
        '9 == 04-18-2025

        'need to set the date constructor properly first
        'Dim specificDate As New DateTime(2025, 3, 18, 14, 30, 0)

        'this should filter out the day month and year in to seperate public
        'variables in the vabbajack module
        zTimeDateFilter(DateTimePicker1.Text)
        'zTDm
        'zTDd
        'zTDy
        If zTDm = vbNullString Then Exit Sub
        If zTDd = vbNullString Then Exit Sub
        If zTDy = vbNullString Then Exit Sub

        '2 weeks
        '2 * 7 = 14 days
        '4 weeks
        '4 * 7 = 28 days
        '8 weeks
        '8 * 7 = 56 days
        '9 weeks
        '9 * 7 = 63 days

        Dim z2ws As String
        Dim z4ws As String
        Dim z8ws As String
        Dim z9ws As String

        Dim zTempDate As New DateTime(CInt(zTDy), CInt(zTDm), CInt(zTDd))

        z2ws = zTempDate.Date.AddDays(14)
        z4ws = zTempDate.Date.AddDays(28)
        z8ws = zTempDate.Date.AddDays(56)
        z9ws = zTempDate.Date.AddDays(63)

        z2ws = z2ws.Replace("/", "-")
        z4ws = z4ws.Replace("/", "-")
        z8ws = z8ws.Replace("/", "-")
        z9ws = z9ws.Replace("/", "-")

        'out string
        Dim zWeekOut As String

        zWeekOut = zWeekOut & zEq & zR
        If ck2Week.Checked = True Then
            zWeekOut = zWeekOut & "====== 2 Week Cycle Batch #" & zR
        End If
        If ckMoonCycle.Checked = True Then
            zWeekOut = zWeekOut & "====== Moon Cycle 1 Month Batch #" & zR
        End If
        zWeekOut = zWeekOut & zEq & zR
        zWeekOut = zWeekOut & "1 week  == " & DateTimePicker1.Text & zR

        'this is for 2 week cycle
        If ck2Week.Checked = True Then
            zWeekOut = zWeekOut & "2 weeks == " & z2ws & " == next 2 week cycle start date goal" & zR
            zWeekOut = zWeekOut & "4 weeks == " & z4ws & zR
            zWeekOut = zWeekOut & "8 weeks == " & z8ws & zR
            zWeekOut = zWeekOut & "9 weeks == " & z9ws & zR
        End If

        If ckMoonCycle.Checked = True Then
            zWeekOut = zWeekOut & "2 weeks == " & z2ws & zR
            zWeekOut = zWeekOut & "4 weeks == " & z4ws & " == next 1 month moon cycle start date goal" & zR
            'zWeekOut = zWeekOut & "4 weeks == " & z4ws & zR
            'zWeekOut = zWeekOut & "8 weeks == " & z8ws & " == next moon cycle clone" & zR
            zWeekOut = zWeekOut & "8 weeks == " & z8ws & zR
            zWeekOut = zWeekOut & "9 weeks == " & z9ws & zR
        End If

        zWeekOut = zWeekOut & zEq

        zTs = zWeekOut

        'this puts selection point at the end of insert
        'zInsertTextIntoRichTextbox(txtLog, zTs, 3)
        'trying selection point at original spot
        'zInsertTextIntoRichTextbox(txtLog, zTs, 5)
        'added scrollscan
        zInsertTextIntoRichTextbox(txtLog, zTs, 5, -10)

    End Sub
