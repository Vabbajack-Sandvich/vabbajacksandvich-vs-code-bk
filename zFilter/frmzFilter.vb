Public Class frmzFilter
    Public Sub zAutoCopy()
        If ckAutoCopy.Checked = True Then
            If txtOutput.Text = "" Then Exit Sub
            Clipboard.Clear()
            Clipboard.SetText(txtOutput.Text)
        End If
    End Sub
    Public Sub zAutoTrim()
        If ckAutoTrim.Checked = True Then
            If txtTrim.Text = "" Then Exit Sub
            If txtInput.Text = "" Then Exit Sub
            Dim zTempTrimInput As String
            If txtTemp.Text = "" Then
                zTempTrimInput = txtInput.Text
            Else
                zTempTrimInput = txtTemp.Text
            End If
            zTempTrimInput = zTempTrimInput.Replace(txtTrim.Text, "")
            'txtInput.Text = zTempTrimInput
            txtTemp.Text = zTempTrimInput
        End If
    End Sub
    Public Sub zAutoReplace()
        If ckAutoReplace.Checked = True Then
            If txtReplace.Text = "" Then Exit Sub
            If txtInput.Text = "" Then Exit Sub
            Dim zTempTrimInput As String
            If txtTemp.Text = "" Then
                zTempTrimInput = txtInput.Text
            Else
                zTempTrimInput = txtTemp.Text
            End If
            zTempTrimInput = zTempTrimInput.Replace(txtReplace.Text, txtReplaceWith.Text)
            'txtInput.Text = zTempTrimInput
            txtTemp.Text = zTempTrimInput
        End If
    End Sub
    Public Sub zAutoRemoveDoubleSpace()
        If ckAutoRemoveDoubleSpace.Checked = True Then
            If txtInput.Text = "" Then Exit Sub
            'txtInput.Text = zRemoveAllDoubleSpace(txtInput.Text)
            If txtTemp.Text = "" Then
                txtTemp.Text = zRemoveAllDoubleSpace(txtInput.Text)
            Else
                txtTemp.Text = zRemoveAllDoubleSpace(txtTemp.Text)
            End If
        End If
    End Sub
    Public Sub zAutoAutos()
        zAutoRemoveDoubleSpace()
        zAutoTrim()
        zAutoReplace()
    End Sub
    Private Sub btzAlphaNumFilter_Click(sender As Object, e As EventArgs) Handles btzAlphaNumFilter.Click
        If txtInput.Text = "" Then Exit Sub
        zAutoAutos()
        If txtTemp.Text = "" Then Exit Sub
        'txtOutput.Text = zAlphaNumFilter(txtInput.Text)
        txtOutput.Text = zAlphaNumFilter(txtTemp.Text)
        'zAutoAutos()
        zAutoCopy()
    End Sub
    Private Sub btzAlphaNumFilterWithDashPlus_Click(sender As Object, e As EventArgs) Handles btzAlphaNumFilterWithDashPlus.Click
        If txtInput.Text = "" Then Exit Sub
        zAutoAutos()
        If txtTemp.Text = "" Then Exit Sub
        'txtOutput.Text = zAlphaNumFilterWithDashPlus(txtInput.Text)
        txtOutput.Text = zAlphaNumFilterWithDashPlus(txtTemp.Text)
        'zAutoAutos()
        zAutoCopy()
    End Sub
    Private Sub ckOnTop_CheckedChanged(sender As Object, e As EventArgs) Handles ckOnTop.CheckedChanged
        If ckOnTop.Checked = True Then
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If
    End Sub
    Private Sub frmzFilter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        txtInput.Text = "This Is a    Test    String : 123 1 2 3 a b c d 123 1  2   3   a    b  c   d English Dubbed"
    End Sub
    Private Sub btTrim_Click(sender As Object, e As EventArgs) Handles btTrim.Click
        If txtTrim.Text = "" Then Exit Sub
        If txtInput.Text = "" Then Exit Sub
        Dim zTempTrimInput As String
        If txtTemp.Text = "" Then
            zTempTrimInput = txtInput.Text
        Else
            zTempTrimInput = txtTemp.Text
        End If
        zTempTrimInput = zTempTrimInput.Replace(txtTrim.Text, "")
        txtTemp.Text = zTempTrimInput
        txtOutput.Text = zTempTrimInput
    End Sub
    Private Sub btReplace_Click(sender As Object, e As EventArgs) Handles btReplace.Click
        If txtReplace.Text = "" Then Exit Sub
        If txtInput.Text = "" Then Exit Sub
        Dim zTempTrimInput As String
        If txtTemp.Text = "" Then
            zTempTrimInput = txtInput.Text
        Else
            zTempTrimInput = txtTemp.Text
        End If
        zTempTrimInput = zTempTrimInput.Replace(txtReplace.Text, txtReplaceWith.Text)
        txtTemp.Text = zTempTrimInput
        txtOutput.Text = zTempTrimInput
    End Sub

    Private Sub btRemoveDoubleSpace_Click(sender As Object, e As EventArgs) Handles btRemoveDoubleSpace.Click
        If txtInput.Text = "" Then Exit Sub
        'txtOutput.Text = zRemoveAllDoubleSpace(txtInput.Text)
        'txtTemp.Text = zRemoveAllDoubleSpace(txtInput.Text)
        If txtTemp.Text = "" Then
            txtTemp.Text = zRemoveAllDoubleSpace(txtInput.Text)
        Else
            txtTemp.Text = zRemoveAllDoubleSpace(txtTemp.Text)
        End If
        txtOutput.Text = txtTemp.Text
    End Sub

    Private Sub btOutputToInput_Click(sender As Object, e As EventArgs) Handles btOutputToInput.Click
        If txtOutput.Text = "" Then Exit Sub
        txtInput.Text = txtOutput.Text
    End Sub

    Private Sub btRecursivelyRemoveDoubleSpace_Click(sender As Object, e As EventArgs) Handles btRecursivelyRemoveDoubleSpace.Click
        If txtInput.Text = "" Then Exit Sub
        'txtOutput.Text = zRemoveAllDoubleSpace(txtInput.Text)
        'txtTemp.Text = zRemoveAllDoubleSpace(txtInput.Text)
        If txtTemp.Text = "" Then
            txtTemp.Text = zRemoveAllDoubleSpace(txtInput.Text)
        Else
            txtTemp.Text = zRemoveAllDoubleSpace(txtTemp.Text)
        End If
        txtOutput.Text = txtTemp.Text
    End Sub

    Private Sub btzAlphaNumFilterWithDashPlusSpace_Click(sender As Object, e As EventArgs) Handles btzAlphaNumFilterWithDashPlusSpace.Click
        If txtInput.Text = "" Then Exit Sub
        zAutoAutos()
        If txtTemp.Text = "" Then Exit Sub
        'txtOutput.Text = zAlphaNumFilterWithDashPlusSpace(txtInput.Text)
        txtOutput.Text = zAlphaNumFilterWithDashPlusSpace(txtTemp.Text)
        'zAutoAutos()
        zAutoCopy()
    End Sub

    Private Sub btzNumFilter_Click(sender As Object, e As EventArgs) Handles btzNumFilter.Click
        If txtInput.Text = "" Then Exit Sub
        zAutoAutos()
        If txtTemp.Text = "" Then Exit Sub
        'txtOutput.Text = zNumFilter(txtInput.Text)
        txtOutput.Text = zNumFilter(txtTemp.Text)
        'zAutoAutos()
        'txtOutput.Text = txtTemp.Text
        zAutoCopy()
    End Sub

    Private Sub btzNumFilterWithDot_Click(sender As Object, e As EventArgs) Handles btzNumFilterWithDot.Click
        If txtInput.Text = "" Then Exit Sub
        zAutoAutos()
        If txtTemp.Text = "" Then Exit Sub
        'txtOutput.Text = zNumFilterWithDot(txtInput.Text)
        txtOutput.Text = zNumFilterWithDot(txtTemp.Text)
        'txtTemp.Text = zNumFilterWithDot(txtTemp.Text)
        'zAutoAutos()
        'txtOutput.Text = txtTemp.Text
        zAutoCopy()
    End Sub

    Private Sub btClearInput_Click(sender As Object, e As EventArgs) Handles btClearInput.Click
        txtInput.Text = ""
    End Sub

    Private Sub btzAlphaNumFilterWithDot_Click(sender As Object, e As EventArgs) Handles btzAlphaNumFilterWithDot.Click
        If txtInput.Text = "" Then Exit Sub
        zAutoAutos()
        If txtTemp.Text = "" Then Exit Sub
        'txtOutput.Text = zNumFilterWithDot(txtInput.Text)
        txtOutput.Text = zAlphaNumFilterWithDot(txtTemp.Text)
        'txtTemp.Text = zNumFilterWithDot(txtTemp.Text)
        'zAutoAutos()
        'txtOutput.Text = txtTemp.Text
        zAutoCopy()
    End Sub
End Class
