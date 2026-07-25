Public Class frmTextBoxFindPopUpModular

    Public zFindPreviousLen As Integer = 0
    Public zFindIndexList(1000) As Integer
    'find index selected index
    Public zFLSI As Integer = -1

    'Public zTxtLog As TextBox
    'should work with richtextbox and no changes?
    'no error on first test run
    'but that didnt call the form
    'testing that now
    Public zTxtLog As RichTextBox
    Public zFormTemp As Form
    'this is to hide and how the form without having to change
    'all of the code in every spot
    'this meand i have to add both

    'frmTextBoxFindPopUpModular.zTxtLog = txtLog
    'and
    'frmTextBoxFindPopUpModular.zFormTemp = Me

    'to the main form load for a project when i add this

    'doing it this way is insanely easier than making everything modular

    'this way means the entire form is modular
    'and that i can do it this way for any section of any form in the future

    'if i want to break off a section of form in to its own thing for other projects

    'passing controls through the code between forms is possible without
    'changing anything besides the control names to the public variables


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

    Public zFormTempTopMost As Boolean
    'temp storage which functions independantly of the checkbox

    'between these two subs
    'the goal is to make it so the form switches to the main form
    'highlights the text if it found it
    'but then disables the window on top for the main form
    'so the search window can sit on top
    'it remembers if the window was on top before hand
    'and automatically sets it back to its starting value
    'when the search window is closed
    'the end result is, you can search and click next and previous
    'while the search window sits on top while the main window text box
    'has focus after the click but doesnt hide the search window
    'or make either form blink a bunch of times which looks like shit
    'it also lets you click off the window whether it was on top or not
    'keeping the search window on top
    'if you click next or something on the search winddow it will
    'bring the other window back behind it
    'im going to make the search window always default to being checked and on top
    'it can be unchecked while its open and stay that way until its checked again
    'until its closed and opened again

    Public Sub zFormTextBoxFocus()
        'zFormTemp.Hide()
        'If zFormTemp.TopMost = True Then
        '    zFormTempTopMost = True
        '    zFormTemp.TopMost = False
        'End If
        'zFormTemp.Show()
        zTxtLog.Focus()
    End Sub

    Public Sub zSearchWindowFocus()
        'If zFormTempTopMost = True Then
        '    zFormTemp.TopMost = True
        '    zFormTempTopMost = False
        'End If

        'Me.Hide()
        'Me.Show()
        'txtFindText.Focus()

        zFormTemp.Show()
        zTxtLog.Focus()

    End Sub

    Public Sub zFindTextClick()
        If zTxtLog.Text = vbNullString Then Exit Sub
        If txtFindText.Text = vbNullString Then Exit Sub
        Dim zFind0 As Integer
        'Dim zI As Integer
        'zI = 0

        'zFindIndexList(zI) = zFind0

        'this scans for as many as it can find
        'not just the first one

        zFind0 = InStr(zTxtLog.Text, txtFindText.Text)
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
                zFind0 = InStr(zFind1 + 1, zTxtLog.Text, txtFindText.Text)
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
            zTxtLog.SelectionStart = listFindIndex.Items.Item(0) - 1

            zFormTextBoxFocus()

            listFindIndex.SetSelected(0, True)
            'ztxtLog.SelectionLength = Len(txtFindText.Text)
            zTxtLog.SelectionLength = zFindPreviousLen
            zTxtLog.Select()
            zTxtLog.ScrollToCaret()

            'bring focus back to the search window
            zSearchWindowFocus()

            lbFindListCount.Text = listFindIndex.Items.Count
        Else
            MsgBox("not found", vbOKOnly, "Craft Notes 0")
        End If

    End Sub

    Private Sub btFindText_Click(sender As Object, e As EventArgs) Handles btFindText.Click
        zFindTextClick()
    End Sub

    Private Sub frmTextBoxFindPopUpModular_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.TopMost = True
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

    Public Sub zUpdateBC123()
        If zTxtLog.Text = vbNullString Then Exit Sub
        txtFindText.Text = "bc123"
        zFindTextClick()
        If listFindIndex.Items.Count = 0 Then Exit Sub
        Dim zSelI As Integer
        listFindIndex.SetSelected(listFindIndex.Items.Count - 1, True)
        zSelI = listFindIndex.SelectedIndex

        zFormTextBoxFocus()

        zTxtLog.SelectionStart = CInt(listFindIndex.Items.Item(zSelI)) - 1
        zTxtLog.SelectionLength = zFindPreviousLen
        zTxtLog.Select()
        zTxtLog.ScrollToCaret()

        zSearchWindowFocus()

    End Sub


    Public Sub zUpdate2025()
        If zTxtLog.Text = vbNullString Then Exit Sub
        'txtFindText.Text = "2025"
        txtFindText.Text = "2025 - "
        zFindTextClick()
        If listFindIndex.Items.Count = 0 Then Exit Sub
        Dim zSelI As Integer
        listFindIndex.SetSelected(listFindIndex.Items.Count - 1, True)
        zSelI = listFindIndex.SelectedIndex

        zFormTextBoxFocus()

        zTxtLog.SelectionStart = CInt(listFindIndex.Items.Item(zSelI)) - 1
        zTxtLog.SelectionLength = zFindPreviousLen
        zTxtLog.Select()
        zTxtLog.ScrollToCaret()

        zSearchWindowFocus()

    End Sub

    Private Sub btClearFindText_Click(sender As Object, e As EventArgs) Handles btClearFindText.Click
        txtFindText.Text = vbNullString
        listFindIndex.Items.Clear()
        zFindPreviousLen = 0
        lbFindListCount.Text = listFindIndex.Items.Count
    End Sub

    Private Sub btFindPrevious_Click(sender As Object, e As EventArgs) Handles btFindPrevious.Click
        If zTxtLog.Text = vbNullString Then Exit Sub
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

        zFormTextBoxFocus()

        zTxtLog.SelectionStart = CInt(listFindIndex.Items.Item(zSelI)) - 1
        zTxtLog.SelectionLength = zFindPreviousLen
        zTxtLog.Select()
        zTxtLog.ScrollToCaret()

        zSearchWindowFocus()

    End Sub

    Private Sub btFindNext_Click(sender As Object, e As EventArgs) Handles btFindNext.Click
        If zTxtLog.Text = vbNullString Then Exit Sub
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

        zFormTextBoxFocus()

        zTxtLog.SelectionStart = CInt(listFindIndex.Items.Item(zSelI)) - 1
        zTxtLog.SelectionLength = zFindPreviousLen
        zTxtLog.Select()
        zTxtLog.ScrollToCaret()

        zSearchWindowFocus()

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

            zFormTextBoxFocus()

            zTxtLog.SelectionStart = CInt(listFindIndex.Items.Item(zSelI)) - 1
            zTxtLog.SelectionLength = zFindPreviousLen
            zTxtLog.Select()
            zTxtLog.ScrollToCaret()

            zSearchWindowFocus()

        End If
    End Sub

    Private Sub listFindIndex_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listFindIndex.SelectedIndexChanged

    End Sub

    Private Sub btFindCaret_Click(sender As Object, e As EventArgs) Handles btFindCaret.Click
        If Len(zTxtLog.Text) > 0 Then
            If zTxtLog.SelectionStart > -1 Then
                'ztxtLog.SelectionStart = Len(ztxtLog.Text)

                zFormTextBoxFocus()

                zTxtLog.SelectionLength = 0
                zTxtLog.Select()
                zTxtLog.ScrollToCaret()

                zSearchWindowFocus()

            ElseIf zTxtLog.SelectionStart = -1 Then
                'no selection go to end

                zFormTextBoxFocus()

                zTxtLog.SelectionStart = Len(zTxtLog.Text)
                zTxtLog.SelectionLength = 0
                zTxtLog.Select()
                zTxtLog.ScrollToCaret()

                zSearchWindowFocus()

            End If
        End If
    End Sub

    Private Sub btEnd_Click(sender As Object, e As EventArgs) Handles btEnd.Click
        If Len(zTxtLog.Text) > 0 Then

            zFormTextBoxFocus()

            zTxtLog.SelectionStart = Len(zTxtLog.Text)
            zTxtLog.SelectionLength = 0
            zTxtLog.Select()
            zTxtLog.ScrollToCaret()

            zSearchWindowFocus()

        End If
    End Sub


    Private Sub btTop_Click(sender As Object, e As EventArgs) Handles btTop.Click
        If Len(zTxtLog.Text) > 0 Then

            zFormTextBoxFocus()

            zTxtLog.SelectionStart = 0
            zTxtLog.SelectionLength = 0
            zTxtLog.Select()
            zTxtLog.ScrollToCaret()

            zSearchWindowFocus()

        End If



    End Sub

    Private Sub frmTextBoxFindPopUpModular_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.TopMost = True
        ckOnTop.Checked = True
        'If zFormTemp.Handle <> 0 Then 
        If zFormTemp.TopMost = True Then
            zFormTempTopMost = True
            zFormTemp.TopMost = False
        End If
        'End If
    End Sub

    Private Sub frmTextBoxFindPopUpModular_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If zFormTempTopMost = True Then
            zFormTemp.TopMost = True
            zFormTempTopMost = False
        End If
    End Sub

    Private Sub ckOnTop_CheckedChanged(sender As Object, e As EventArgs) Handles ckOnTop.CheckedChanged
        If ckOnTop.Checked = True Then
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If
    End Sub

    Private Sub btBC123_Click(sender As Object, e As EventArgs) Handles btBC123.Click
        zUpdateBC123()
    End Sub
End Class