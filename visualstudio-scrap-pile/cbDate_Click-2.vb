    Private Sub cbDate_Click(sender As Object, e As EventArgs) Handles btTimeStamp.Click
        'old code is in a scrap file
        'new code uses zInsertTextIntoTextbox
        'got tired of having to do the same thing
        'made it modular

        Dim zTs As String
        'zTs = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")

        zTs = txtDate.Text
        zTs = zR2 & "==== " & zTs & " === " & zR2

        zInsertTextIntoRichTextbox(txtLog, zTs, 1)

    End Sub
