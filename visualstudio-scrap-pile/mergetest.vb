
    Private Sub btUndoBack_Click(sender As Object, e As EventArgs) Handles btUndoBack.Click
    Private Sub btUndoForward_Click(sender As Object, e As EventArgs) Handles btUndoForward.Click
        If zDedupeTimer = True Then Exit Sub
        Dim zBeforeUndo As String = txtLog.Text
        If zUndolist.Items.Count = 0 Then
            Exit Sub
        Else
            'this fixes the selection for iterating through the list
            'just incase it ever happens to get deselected somehow
            If zUndolist.SelectedIndex() = -1 Then
                'nothing selected
                'might happen on load or with nothing in the box after the first item
                'being added
                'set it to the last entry
                'this way i dont need a global that tracks this since
                'the list box control does that anyway
                zUndolist.SetSelected(zUndolist.Items.Count - 1, True)
            Else
                'something is selected
                'move through the list and update the textbox
                Dim zSelI As Integer
                zSelI = zUndolist.SelectedIndex
                If zSelI = 0 Then
                    zUndolist.SetSelected(zUndolist.Items.Count - 1, True)
                    'this is from the other one
                ElseIf zSelI = zUndolist.Items.Count - 1 Then
                    'but this just incriments like normal
                    'just do the normal negative move
                    'im leaving it
                    'zUndolist.SetSelected(zUndolist.Items.Count - 1, True)
                    zUndolist.SetSelected(zSelI - 1, True)
                    zUndolist.SetSelected(zSelI + 1, True)
                Else
                ElseIf zSelI = zUndolist.Items.Count - 1 Then
                    zUndolist.SetSelected(zSelI - 1, True)
                    'at the end go to 0
                End If
                    zUndolist.SetSelected(0, True)
                txtLog.Text = zUndolist.Items.Item(zSelI)
                Else
                If zUndolist.Items.Count > 0 Then
                    zUndolist.SetSelected(zSelI + 1, True)
                    Dim zI As Integer
                End If
                    Dim zDupe As Boolean = False
                txtLog.Text = zUndolist.Items.Item(zSelI)
                    For zI = 0 To zUndolist.Items.Count - 1
                If zUndolist.Items.Count > 0 Then
                        If zUndolist.Items.Item(zI) = zBeforeUndo Then
                    Dim zI As Integer
                            zDupe = True
                    Dim zDupe As Boolean = False
                        End If
                    For zI = 0 To zUndolist.Items.Count - 1
                    Next
                        If zUndolist.Items.Item(zI) = zBeforeUndo Then
                    If zDupe = False Then
                            zDupe = True
                        zUndolist.Items.Add(zBeforeUndo)
                        End If
                    End If
                    Next
                End If
                    If zDupe = False Then
                If txtLog.Text <> vbNullString Then
                        zUndolist.Items.Add(zBeforeUndo)
                    txtLog.SelectionStart = Len(txtLog.Text)
                    End If
                    txtLog.Select()
                End If
                    txtLog.ScrollToCaret()
                If txtLog.Text <> vbNullString Then
                End If
                    txtLog.SelectionStart = Len(txtLog.Text)
            End If
                    txtLog.Select()
            End If
                    txtLog.ScrollToCaret()
    End Sub
                End If