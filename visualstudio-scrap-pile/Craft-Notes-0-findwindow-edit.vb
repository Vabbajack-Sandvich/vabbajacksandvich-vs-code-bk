Public Class frmTextBoxFindPopUpModular

    Public zFindPreviousLen As Integer = 0
    Public zFindIndexList(1000) As Integer
    'find index selected index
    Public zFLSI As Integer = -1
	
	public zTxtLog as TextBox

    Public Sub zFindTextInString()
        'todo:

        'tldr: just make the whole form modular in the sense that
        'you can drop it in any project with a text box
        'to use as the source string to run everything against
        'and just change txtlog to whatever

        'make this modular as much as possible
        'it will go in to the module file eventually
        'but the first version will work with this form
        'as the form and its controls is the intended
        'overall module that the code should work for

        'which it already does and this will take a while

        'make a version that has the option
        'with all the combinations being just optional flags
        'because they are one or the other

        'to use:
        'a listbox or not
        'this will default to using an array

        'a textbox or not
        'input box driven

        'an array or not
        'the no listbox option will be the default
        'and use an array

    End Sub

    Public Sub zFindTextClick()
        If ztxtLog.Text = vbNullString Then Exit Sub
        If txtFindText.Text = vbNullString Then Exit Sub
        Dim zFind0 As Integer
        'Dim zI As Integer
        'zI = 0

        'zFindIndexList(zI) = zFind0

        'this scans for as many as it can find
        'not just the first one

        zFind0 = InStr(ztxtLog.Text, txtFindText.Text)
        If zFind0 > 0 Then
            'zClearFindIndexList()
            'zFindIndexList(zI) = zFind0
            'zI = zI + 1

            zFindPreviousLen = Len(txtFindText.Text)
            listFindIndex.Items.Clear()
            listFindIndex.Items.Add(zFind0)

            'this stops the loop if there arent anymore found
            Dim zLoopStop As Boolean = False
            'it found one, now check for more than one
            Dim zFind1 As Integer
            Do
                'set the second one to the old one
                zFind1 = zFind0
                'set the new one to the next one if there is a next one
                zFind0 = InStr(zFind1 + 1, ztxtLog.Text, txtFindText.Text)
                If zFind0 > 0 Then
                    'zFindIndexList(zI) = zFind0
                    listFindIndex.Items.Add(zFind0)
                    'zI = zI + 1
                Else
                    'no more found
                    zLoopStop = True
                End If
            Loop Until zLoopStop = True

            'ztxtLog.SelectionStart = zFind0 - 1
            ztxtLog.SelectionStart = listFindIndex.Items.Item(0) - 1
            listFindIndex.SetSelected(0, True)
            'ztxtLog.SelectionLength = Len(txtFindText.Text)
            ztxtLog.SelectionLength = zFindPreviousLen
            ztxtLog.Select()
            ztxtLog.ScrollToCaret()
            lbFindListCount.Text = listFindIndex.Items.Count
        Else
            MsgBox("not found", vbOKOnly, "Craft Notes 0")
        End If

    End Sub

    Private Sub btFindText_Click(sender As Object, e As EventArgs) Handles btFindText.Click
        zFindTextClick()
    End Sub

    Private Sub frmTextBoxFindPopUpModular_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
    End Sub

    Private Sub txtFindText_KeyUp(sender As Object, e As KeyEventArgs) Handles txtFindText.KeyUp
        If e.KeyCode = 13 Then
            'enter key
            If txtFindText.Text = vbNullString Then
                MsgBox("enter search string", vbOKOnly, "Craft Notes 0")
                Exit Sub
            Else
                zFindTextClick()
            End If
        End If
    End Sub

    Public Sub zUpdate2025()
        If ztxtLog.Text = vbNullString Then Exit Sub
        txtFindText.Text = "2025"
        zFindTextClick()
        If listFindIndex.Items.Count = 0 Then Exit Sub
        Dim zSelI As Integer
        listFindIndex.SetSelected(listFindIndex.Items.Count - 1, True)
        zSelI = listFindIndex.SelectedIndex
        ztxtLog.SelectionStart = CInt(listFindIndex.Items.Item(zSelI)) - 1
        ztxtLog.SelectionLength = zFindPreviousLen
        ztxtLog.Select()
        ztxtLog.ScrollToCaret()

    End Sub

    Private Sub btClearFindText_Click(sender As Object, e As EventArgs) Handles btClearFindText.Click
        txtFindText.Text = vbNullString
        listFindIndex.Items.Clear()
        zFindPreviousLen = 0
        lbFindListCount.Text = listFindIndex.Items.Count
    End Sub

    Private Sub btFindPrevious_Click(sender As Object, e As EventArgs) Handles btFindPrevious.Click
        If ztxtLog.Text = vbNullString Then Exit Sub
        If txtFindText.Text = vbNullString Then Exit Sub

        If listFindIndex.Items.Count = 0 Then
            zFindTextClick()
        End If
        If listFindIndex.Items.Count = 0 Then Exit Sub
        Dim zSelI As Integer = listFindIndex.SelectedIndex
        If zSelI = -1 Then
            listFindIndex.SetSelected(0, True)
        ElseIf zSelI = 0 Then
            'bottom of the list
            'loop back around
            listFindIndex.SetSelected(listFindIndex.Items.Count - 1, True)
        Else
            listFindIndex.SetSelected(zSelI - 1, True)
        End If

        zSelI = listFindIndex.SelectedIndex
        ztxtLog.SelectionStart = CInt(listFindIndex.Items.Item(zSelI)) - 1
        ztxtLog.SelectionLength = zFindPreviousLen
        ztxtLog.Select()
        ztxtLog.ScrollToCaret()

    End Sub

    Private Sub btFindNext_Click(sender As Object, e As EventArgs) Handles btFindNext.Click
        If ztxtLog.Text = vbNullString Then Exit Sub
        If txtFindText.Text = vbNullString Then Exit Sub

        If listFindIndex.Items.Count = 0 Then
            zFindTextClick()
        End If
        If listFindIndex.Items.Count = 0 Then Exit Sub
        Dim zSelI As Integer = listFindIndex.SelectedIndex
        If zSelI = -1 Then
            listFindIndex.SetSelected(0, True)
        ElseIf zSelI = listFindIndex.Items.Count - 1 Then
            'top of the list
            'loop back around
            listFindIndex.SetSelected(0, True)
        Else
            listFindIndex.SetSelected(zSelI + 1, True)
        End If

        zSelI = listFindIndex.SelectedIndex
        ztxtLog.SelectionStart = CInt(listFindIndex.Items.Item(zSelI)) - 1
        ztxtLog.SelectionLength = zFindPreviousLen
        ztxtLog.Select()
        ztxtLog.ScrollToCaret()

    End Sub


    Private Sub bt2025_Click(sender As Object, e As EventArgs) Handles bt2025.Click
        zUpdate2025()
    End Sub

    Private Sub txtFindText_TextChanged(sender As Object, e As EventArgs) Handles txtFindText.TextChanged

    End Sub
    Private Sub listFindIndex_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles listFindIndex.MouseDoubleClick
        Dim zSelI As Integer = listFindIndex.SelectedIndex
        If zSelI <> -1 Then
            'ztxtLog.SelectionStart = zFindIndexList(zSelI) - 1
            ztxtLog.SelectionStart = CInt(listFindIndex.Items.Item(zSelI)) - 1
            ztxtLog.SelectionLength = zFindPreviousLen
            ztxtLog.Select()
            ztxtLog.ScrollToCaret()
        End If
    End Sub

    Private Sub listFindIndex_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listFindIndex.SelectedIndexChanged

    End Sub

    Private Sub btFindCaret_Click(sender As Object, e As EventArgs) Handles btFindCaret.Click
        If Len(ztxtLog.Text) > 0 Then
            If ztxtLog.SelectionStart > -1 Then
                'ztxtLog.SelectionStart = Len(ztxtLog.Text)
                ztxtLog.SelectionLength = 0
                ztxtLog.Select()
                ztxtLog.ScrollToCaret()
            ElseIf ztxtLog.SelectionStart = -1 Then
                'no selection go to end
                ztxtLog.SelectionStart = Len(ztxtLog.Text)
                ztxtLog.SelectionLength = 0
                ztxtLog.Select()
                ztxtLog.ScrollToCaret()
            End If
        End If
    End Sub

    Private Sub btEnd_Click(sender As Object, e As EventArgs) Handles btEnd.Click
        If Len(ztxtLog.Text) > 0 Then
            ztxtLog.SelectionStart = Len(ztxtLog.Text)
            ztxtLog.SelectionLength = 0
            ztxtLog.Select()
            ztxtLog.ScrollToCaret()
        End If
    End Sub


    Private Sub btTop_Click(sender As Object, e As EventArgs) Handles btTop.Click
        If Len(ztxtLog.Text) > 0 Then
            ztxtLog.SelectionStart = 0
            ztxtLog.SelectionLength = 0
            ztxtLog.Select()
            ztxtLog.ScrollToCaret()
        End If

    End Sub
End Class