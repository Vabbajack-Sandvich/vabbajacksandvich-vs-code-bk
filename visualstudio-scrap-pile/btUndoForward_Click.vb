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
                    'this is from the other one
                    'but this just incriments like normal
                    'im leaving it
                    'zUndolist.SetSelected(zUndolist.Items.Count - 1, True)
                    zUndolist.SetSelected(zSelI + 1, True)
                ElseIf zSelI = zUndolist.Items.Count - 1 Then
                    'at the end go to 0
                    zUndolist.SetSelected(0, True)
                Else
                    zUndolist.SetSelected(zSelI + 1, True)
                End If

                txtLog.Text = zUndolist.Items.Item(zSelI)

                If zUndolist.Items.Count > 0 Then
                    Dim zI As Integer
                    Dim zDupe As Boolean = False
                    For zI = 0 To zUndolist.Items.Count - 1
                        If zUndolist.Items.Item(zI) = zBeforeUndo Then
                            zDupe = True
                        End If
                    Next
                    If zDupe = False Then
                        zUndolist.Items.Add(zBeforeUndo)
                    End If
                End If

                If txtLog.Text <> vbNullString Then
                    txtLog.SelectionStart = Len(txtLog.Text)
                    txtLog.Select()
                    txtLog.ScrollToCaret()
                End If
            End If


        End If
    End Sub
