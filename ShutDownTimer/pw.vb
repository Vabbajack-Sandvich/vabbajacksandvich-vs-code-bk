Public Class pw
    Private Sub txtCheck_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCheck.KeyUp
        If e.KeyCode = 13 Then
            If txtCheck.Text = "1234" Then
                Application.Exit()
                End
            Else
                txtCheck.Text = ""
            End If
        End If
    End Sub

    Private Sub txtCheck_TextChanged(sender As Object, e As EventArgs) Handles txtCheck.TextChanged

    End Sub
End Class