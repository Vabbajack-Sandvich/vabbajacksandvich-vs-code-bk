    Public Sub zUpdateUndo(zInt As Integer)

        'zint
        '0 = move backward through undo list
        '1 = move forward through undo list

        If zInt > 1 Then Exit Sub
        If zInt < 0 Then Exit Sub

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

                If zInt = 0 Then
                    'backward
                    If zSelI = 0 Then
                        'at zero loop back to the max
                        zUndolist.SetSelected(zUndolist.Items.Count - 1, True)
                    ElseIf zSelI = zUndolist.Items.Count - 1 Then
                        zUndolist.SetSelected(zSelI - 1, True)
                    Else
                        zUndolist.SetSelected(zSelI - 1, True)
                    End If
                ElseIf zInt = 1 Then
                    'forward
                    If zSelI = 0 Then
                        zUndolist.SetSelected(zSelI + 1, True)
                    ElseIf zSelI = zUndolist.Items.Count - 1 Then
                        'at the max go to 0
                        zUndolist.SetSelected(0, True)
                    Else
                        zUndolist.SetSelected(zSelI + 1, True)
                    End If
                End If

                'update the index after the move

                zSelI = zUndolist.SelectedIndex

                txtLog.Text = zUndolist.Items.Item(zSelI)

                If zUndolist.Items.Count > 0 Then
                    'this dedupe only adds the new entry
                    'if it isnt a duplicate
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
