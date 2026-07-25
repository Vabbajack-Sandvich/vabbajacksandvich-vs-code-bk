Public Class FrmzAspect

    Public Sub zBtCalculate_Click()
        Dim zInt0 As Integer
        Dim zInt1 As Integer
        Dim zInt2 As Integer
        Dim zInt3 As Integer

        '2026-06-03-01-17-34-AM
        'have to add an upper limit and 0 checks
        'lazy 0 fix
        If Txt0.Text = "0" Then
            Txt0.Text = "1"
            'Exit Sub
        End If
        If Txt1.Text = "0" Then
            Txt1.Text = "1"
            'Exit Sub
        End If
        If Txt2.Text = "0" Then
            Txt2.Text = "1"
            'Exit Sub
        End If

        'Txt0.Text = ""
        'Txt1.Text = ""
        'Txt2.Text = ""
        'Txt3.Text = ""
        'zNumFilter()
        Txt0.Text = zTrimLeadingZero2(Txt0.Text)
        Txt1.Text = zTrimLeadingZero2(Txt1.Text)
        Txt2.Text = zTrimLeadingZero2(Txt2.Text)
        'Txt3.Text = zTrimLeadingZero2(Txt3.Text)
        Txt3.Text = ""

        If Txt0.Text = vbNullString Then
            Exit Sub
        End If
        If Txt1.Text = vbNullString Then
            Exit Sub
        End If
        If Txt2.Text = vbNullString Then
            Exit Sub
        End If
        'If Txt3.Text = vbNullString Then
        '    Exit Sub
        'End If

        zInt0 = CInt(Txt0.Text)
        zInt1 = CInt(Txt1.Text)
        zInt2 = CInt(Txt2.Text)

        '2026-06-03-01-23-28-AM
        'lazy 0 or upper limit fix
        'if it gets set to 1
        'they will be like what the fuck
        'but
        'thats kind of stupid

        'If zInt0 = 0 Or zInt0 > 6000 Then
        '    zInt0 = 1
        'End If
        'If zInt1 = 0 Or zInt1 > 6000 Then
        '    zInt1 = 1
        'End If
        'If zInt2 = 0 Or zInt2 > 6000 Then
        '    zInt2 = 1
        'End If

        '2026-06-03-01-26-57-AM
        'lazy but better 0 and upper limit fix
        'would be better to just have it exit or msgbox
        'or both

        'If zInt0 = 0 Then
        '    zInt0 = 1
        'End If
        'If zInt1 = 0 Then
        '    zInt1 = 1
        'End If
        'If zInt2 = 0 Then
        '    zInt2 = 1
        'End If
        '
        'If zInt0 > 6000 Then
        '    zInt0 = 6000
        'End If
        'If zInt1 > 6000 Then
        '    zInt1 = 6000
        'End If
        'If zInt2 > 6000 Then
        '    zInt2 = 6000
        'End If

        '2026-06-03-01-30-35-AM
        'update for both msgbox and reset

        If zInt0 = 0 Then
            zInt0 = 1
            MsgBox("cant be 0")
            Exit Sub
        End If
        If zInt1 = 0 Then
            zInt1 = 1
            MsgBox("cant be 0")
            Exit Sub
        End If
        If zInt2 = 0 Then
            zInt2 = 1
            MsgBox("cant be 0")
            Exit Sub
        End If

        If zInt0 > 100000 Then
            zInt0 = 100000
            MsgBox("cant be above 100000")
            Exit Sub
        End If
        If zInt1 > 100000 Then
            zInt1 = 100000
            MsgBox("cant be above 100000")
            Exit Sub
        End If
        If zInt2 > 100000 Then
            zInt2 = 100000
            MsgBox("cant be above 100000")
            Exit Sub
        End If

        zInt3 = zInt1 * zInt2 / zInt0

        Txt3.Text = CStr(zInt3)
    End Sub


    Private Sub BtCalculate_Click(sender As Object, e As EventArgs) Handles BtCalculate.Click
        zBtCalculate_Click()
    End Sub

    Private Sub ckOnTop_CheckedChanged(sender As Object, e As EventArgs) Handles ckOnTop.CheckedChanged
        If ckOnTop.Checked = True Then
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If
    End Sub

    Private Sub FrmzAspect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        ckOnTop.Checked = True
        zDefaultValues()
        Txt0.TabIndex = 0
        Txt1.TabIndex = 1
        Txt2.TabIndex = 2
        Txt3.TabIndex = 3
        btDefault.TabIndex = 4
        btClear.TabIndex = 5
        ckOnTop.TabIndex = 6
        BtCalculate.TabIndex = 7
    End Sub


    Public Sub zClearBoxes()
        Txt0.Text = ""
        Txt1.Text = ""
        Txt2.Text = ""
        Txt3.Text = ""
    End Sub
    Private Sub btClear_Click(sender As Object, e As EventArgs) Handles btClear.Click
        zClearBoxes()
    End Sub

    Public Sub zDefaultValues()
        Txt0.Text = "1920"
        Txt1.Text = "1080"
        Txt2.Text = "960"
        Txt3.Text = ""
    End Sub
    Private Sub btDefault_Click(sender As Object, e As EventArgs) Handles btDefault.Click
        zDefaultValues()
    End Sub

    Private Sub Txt0_KeyUp(sender As Object, e As KeyEventArgs) Handles Txt0.KeyUp
        If e.KeyCode = 13 Then
            zBtCalculate_Click()
        End If
    End Sub

    Private Sub Txt1_KeyUp(sender As Object, e As KeyEventArgs) Handles Txt1.KeyUp
        If e.KeyCode = 13 Then
            zBtCalculate_Click()
        End If
    End Sub

    Private Sub Txt2_KeyUp(sender As Object, e As KeyEventArgs) Handles Txt2.KeyUp
        If e.KeyCode = 13 Then
            zBtCalculate_Click()
        End If
    End Sub

    Private Sub Txt3_KeyUp(sender As Object, e As KeyEventArgs) Handles Txt3.KeyUp
        If e.KeyCode = 13 Then
            zBtCalculate_Click()
        End If
    End Sub


End Class
