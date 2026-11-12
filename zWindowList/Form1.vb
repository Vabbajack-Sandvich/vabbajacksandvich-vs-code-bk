Imports System.Xml

Public Class Form1

    Public Sub zUpdateTextboxAndLabel()
        If ListExplorerWindows.Items.Count <> 0 Then
            If ListExplorerWindows.SelectedIndex = -1 Then
                ListExplorerWindows.SelectedIndex = 0
            End If
            'zUpdateLabelWithListEntryLastPathOrFile(ListExplorerWindows, lbExplorerWindowOutput, txtSelectedWindow)
            lbExplorerWindowOutput.Text = ListExplorerWindows.Items.Item(ListExplorerWindows.SelectedIndex)
            zUpdateTextBoxWithListEntry(ListExplorerWindows, txtSelectedWindow, 1, 0)
        Else
            lbExplorerWindowOutput.Text = ""
            txtSelectedWindow.Text = ""
        End If

    End Sub
    Private Sub btGetWindowsExplorerWindows_Click(sender As Object, e As EventArgs) Handles btGetWindowsExplorerWindows.Click
        zGetActiveExplorerWindowsAddToListbox(ListExplorerWindows)
        zUpdateTextboxAndLabel()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.TopMost = True
        'lbExplorerWindowOutput.Text = ""
    End Sub

    Public zRefreshTimer As Boolean = False

    Private Sub ListExplorerWindows_DoubleClick(sender As Object, e As EventArgs) Handles ListExplorerWindows.DoubleClick
        If ListExplorerWindows.Items.Count = 0 Then Exit Sub
        If ListExplorerWindows.SelectedIndex = -1 Then
            ListExplorerWindows.SelectedIndex = 0
            Exit Sub
        End If
        Dim zListString As String
        zListString = ListExplorerWindows.Items.Item(ListExplorerWindows.SelectedIndex)
        'If InStr(zListString, "OneDrive\Documents") <> 0 Then
        If zListString = "C:\Users\zonid\OneDrive\Documents" Then
            zListString = "Documents"
        End If
        zBringExplorerWindowToFront(zListString)
    End Sub

    Private Sub btCloseAllWindowsExplorerWindows_Click(sender As Object, e As EventArgs) Handles btCloseAllWindowsExplorerWindows.Click
        zCloseAllExplorerWindows()
        ListExplorerWindows.Items.Clear()
        zUpdateTextboxAndLabel()
    End Sub

    Private Sub ListExplorerWindows_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListExplorerWindows.SelectedIndexChanged
        zUpdateTextboxAndLabel()
    End Sub

    Private Sub ListExplorerWindows_MouseUp(sender As Object, e As MouseEventArgs) Handles ListExplorerWindows.MouseUp
        If e.Button = MouseButtons.Right Then
            If ListExplorerWindows.Items.Count = 0 Then Exit Sub
            If ListExplorerWindows.SelectedIndex = -1 Then
                ListExplorerWindows.SelectedIndex = 0
            End If
            Application.DoEvents()

            zCloseExplorerWindowByPath(ListExplorerWindows.Items.Item(ListExplorerWindows.SelectedIndex))

            'zPause(2)

            'zGetActiveExplorerWindowsAddToListbox(ListExplorerWindows)
            'zUpdateTextboxAndLabel()

            zRefreshTimer = True
            tmrRefresh.Enabled = True

        End If
    End Sub

    Private Sub tmrRefresh_Tick(sender As Object, e As EventArgs) Handles tmrRefresh.Tick
        Application.DoEvents()
        If zRefreshTimer = True Then
            zGetActiveExplorerWindowsAddToListbox(ListExplorerWindows)
            zUpdateTextboxAndLabel()
            zRefreshTimer = False
            tmrRefresh.Enabled = False
        End If
    End Sub

    Private Sub ckOnTop_CheckedChanged(sender As Object, e As EventArgs) Handles ckOnTop.CheckedChanged
        zOnTopCheckBox(Me, ckOnTop)
    End Sub

    Private Sub tmrStart_Tick(sender As Object, e As EventArgs) Handles tmrStart.Tick
        Me.TopMost = True
        lbExplorerWindowOutput.Text = ""
        tmrStart.Enabled = False

        zGetActiveExplorerWindowsAddToListbox(ListExplorerWindows)

        'zLoadOpenWindowsAddToListbox(ListExplorerWindows)

        'zAddOpenWindowsToListBoxUsingWindowsAPI(ListExplorerWindows)

        zUpdateTextboxAndLabel()
    End Sub

    Private Sub bttxtSelectedWindowClear_Click(sender As Object, e As EventArgs) Handles bttxtSelectedWindowClear.Click
        txtSelectedWindow.Text = ""
    End Sub

    Private Sub bttxtSelectedWindowCopy_Click(sender As Object, e As EventArgs) Handles bttxtSelectedWindowCopy.Click
        Clipboard.Clear()
        Clipboard.SetText(txtSelectedWindow.Text)
    End Sub
End Class
