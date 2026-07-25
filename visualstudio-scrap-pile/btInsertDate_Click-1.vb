    Private Sub btInsertDate_Click(sender As Object, e As EventArgs) Handles btInsertDate.Click
        Dim zTs As String
        'zTs = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")

        'zTs = txtDate.Text

        'Debug.Print(DateTimePicker1.CustomFormat)

        'zTs = DateTimePicker1.Value
        'zTs = DateTimePicker1.Text
        'If ck2Week.Checked = False Then
        '    zTs = "==== " & zTs & " === "
        'Else
        'so it turns out its pretty easy
        'used to be very not easy if i remember correctly
        'but yeah
        'its easy to do previous and past date stuff now
        'Dim futureDate As DateTime = DateTime.Now.AddDays(5)
        'i can do the week break down thing here
        'zTs = "==== " & zTs & " === Week === "

        'going to go for this output format
        'ended up adding more to it
        'fake numbers
        '1 == 02-14-2025
        '2 == 02-15-2025
        '4 == 03-14-2025
        '8 == 04-11-2025
        '9 == 04-18-2025

        '2 weeks
        '2 * 7 = 14 days
        Dim z2w As DateTime = DateTime.Now.AddDays(14)
        '4 weeks
        '4 * 7 = 28 days
        Dim z4w As DateTime = DateTime.Now.AddDays(28)
            '8 weeks
            '8 * 7 = 56 days
            Dim z8w As DateTime = DateTime.Now.AddDays(56)
            '9 weeks
            '9 * 7 = 63 days
            Dim z9w As DateTime = DateTime.Now.AddDays(63)

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

            'zWeekOut = zWeekOut & "4 == " & z4w & zR
            'zWeekOut = zWeekOut & "8 == " & z8w & zR
            'zWeekOut = zWeekOut & "9 == " & z9w & zR

            'DateTime.Now.ToString("dd/MM/yyyy")
            '.Now.ToString("dd/MM/yyyy")
            'zWeekOut = zWeekOut & "4 == " & z4w.Now.ToString("dd/MM/yyyy") & zR
            'zWeekOut = zWeekOut & "8 == " & z8w.Now.ToString("dd/MM/yyyy") & zR
            'zWeekOut = zWeekOut & "9 == " & z9w.Now.ToString("dd/MM/yyyy") & zR

            Dim z2ws As String
            Dim z4ws As String
            Dim z8ws As String
            Dim z9ws As String

            z2ws = z2w.Date.ToString("MM-dd-yyyy")
            'z4ws = z4w.Date.ToString("MM/dd/yyyy")
            z4ws = z4w.Date.ToString("MM-dd-yyyy")
            'z4ws = z4ws.Replace("/", "-")
            'z8ws = z8w.Date.ToString("MM/dd/yyyy")
            z8ws = z8w.Date.ToString("MM-dd-yyyy")
            'z8ws = z8ws.Replace("/", "-")
            'z9ws = z9w.Date.ToString("MM/dd/yyyy")
            z9ws = z9w.Date.ToString("MM-dd-yyyy")
            'z9ws = z9ws.Replace("/", "-")

            'Dim startDate As Date = #2023-01-01#
            'Dim endDate As Date = #2023-02-15#
            'Dim daysDiff As Integer = DateDiff(DateInterval.Day, startDate, endDate)
            'Console.WriteLine("Number of days difference: " & daysDiff)

            'this works
            'just using the date objects works
            'Debug.Print(DateDiff(DateInterval.Day, DateTime.Now, z9w))

            'either 2 week or moon will be checked
            'based on the click and check value handling
            'they act like option boxes

            'this is for 2 week cycle

            If ck2Week.Checked = True Then

                zWeekOut = zWeekOut & "2 weeks == " & z2ws & " == next 2 week cycle start date goal" & zR
                'zWeekOut = zWeekOut & "4 weeks == " & z4ws & " == next moon cycle start date goal" & zR
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


        'End If

        zInsertTextIntoRichTextbox(txtLog, zTs, 3)

    End Sub
