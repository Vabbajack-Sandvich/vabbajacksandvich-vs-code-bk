Public Class frmMain

    '------------------------------------------------
    '------------------------------------------------
    'todo:
    'change the method to checking 3 lines from list 2
    'start with all of list one
    'then dedupe list 2 against list 1
    'keep unique entries
    'then merge unique entries - differences
    'while scanning for duplicates remember the original index
    'put the original index in a second listbox as its being scanned
    'for unique entries
    'that way as i iterate through the lines of list 1 to merge the new lines from 2
    'i can scan before, now, after
    'those 3 lines each time
    'and since list 1 is the base and im just adding the differences
    'the difference might not be exactly onthe same line
    'and if they matched the now line anyway
    'they would be considered a duplicate and not added
    'try using the insert thing instead of the add thing
    'instead of scanning through list 1 index
    'then i can just jump to each index in the original list 2 line index box
    'and insert it in to list 1 if it passes the 3 line duplicate scan
    'that should reduce the double end ifs
    'since the original end ifs should be there anyway
    '------------------------------------------------
    'i guess copy and paste the existing method before changing to the scrap pile
    '------------------------------------------------
    '------------------------------------------------



    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btCombine_Click(sender As Object, e As EventArgs) Handles btCombineEveryOtherLine.Click

        'this does a rough merge by adding the lines
        'to a listbox then going through the listbox
        'and adding the lines first from 1 then from 2
        'and if you are adding very similar text like code from
        '2 different functions but you want them to remain mostly the same
        'and in order, then you cant deduplicate them
        'so this only adds a line to the final output listbox
        'if it doesnt match the same line in the last entry of the output box
        'but it keeps all unique entries going through each line of each box of text

        'its a rough version merger

        Dim zTxt1 = txtInputText1.Text
        Dim zTxt2 = txtInputText2.Text
        If zTxt1 = "" Then Exit Sub
        If zTxt2 = "" Then Exit Sub
        'both boxes have stuff in them
        'add both text boxes to the list boxes
        zTextLinesToListbox(txtInputText1, listInput1, 1)
        zTextLinesToListbox(txtInputText2, listInput2, 1)
        'check to see if there is stuff in the list boxes
        'if either list has nothing in it exit sub
        'cant do anything with either one being empty
        Dim zLi1 = listInput1.Items.Count
        Dim zLi2 = listInput2.Items.Count
        If zLi1 = 0 Then Exit Sub
        If zLi2 = 0 Then Exit Sub
        'it made it here so clear the output box
        listOutput1.Items.Clear()
        Dim zI1 As Integer
        Dim zLiO As Integer
        'going to have to check to see the listbox count states
        'which one is higher than the other or if they are equal
        'this sets zlio to whichever is the highest
        'so the for loop will go through to the higheset value of the greatest list
        'it checks when it tries to add the entries to see if the index
        'is within the range of the lower listbox
        'if it isnt within the range, meaning it would cause an error
        'it just skips those indexes but continues adding entries
        'from the greater count list box until its finished
        If zLi1 = zLi2 Then
            'theyre equal
            zLiO = zLi1
        ElseIf zLi1 > zLi2 Then
            'list1 is greater than list2
            zLiO = zLi1
        ElseIf zLi2 > zLi1 Then
            'list2 is greater than list1
            zLiO = zLi2
        End If
        'now combine every other line
        For zI1 = 0 To zLiO - 1
            Application.DoEvents()
            'this itterates to the greatest listcount
            'i need to check to see if the index is within
            'of the listbox count
            'add both lines to the output listbox each pass
            'using the same index
            If zI1 <= zLi1 - 1 Then
                'this will only try to add the entry if it is less than
                'or equal to -1 for the total in list1
                If listOutput1.Items.Count > 0 Then
                    If listInput1.Items.Item(zI1) <> listOutput1.Items.Item(listOutput1.Items.Count - 1) Then
                        'wont add if its the same as the last entry
                        listOutput1.Items.Add(listInput1.Items.Item(zI1))
                    End If
                Else
                    listOutput1.Items.Add(listInput1.Items.Item(zI1))
                End If
                If zI1 <= zLi2 - 1 Then
                    'this will only try to add the entry if it is less than
                    'or equal to -1 for the total in list2
                    If listOutput1.Items.Count > 0 Then
                        If listInput2.Items.Item(zI1) <> listOutput1.Items.Item(listOutput1.Items.Count - 1) Then
                            listOutput1.Items.Add(listInput2.Items.Item(zI1))
                        End If
                    Else
                        listOutput1.Items.Add(listInput2.Items.Item(zI1))
                    End If
                End If
            End If
        Next

        'not using dedupe for this
        'deduplicate listbox
        'zDeduplicateListBox(listOutput1)

        txtOutputText1.Text = ""

        Dim zTmpOutStr As String

        For zi = 0 To listOutput1.Items.Count - 1
            Application.DoEvents()
            zTmpOutStr = zTmpOutStr & zR & listOutput1.Items.Item(zi)
        Next

        txtOutputText1.Text = zTmpOutStr

        zUpdateListCounts()

    End Sub

    Private Sub btClearInputText1_Click(sender As Object, e As EventArgs) Handles btClearInputText1.Click
        txtInputText1.Text = ""
        txtInputText1.Focus()
    End Sub

    Private Sub btClearInputText2_Click(sender As Object, e As EventArgs) Handles btClearInputText2.Click
        txtInputText2.Text = ""
        txtInputText2.Focus()

    End Sub

    Private Sub btClearOutputText1_Click(sender As Object, e As EventArgs) Handles btClearOutputText1.Click
        txtOutputText1.Text = ""
        txtOutputText1.Focus()

    End Sub

    Public Sub zUpdateListCounts()
        lbInputList1Count.Text = listInput1.Items.Count
        lbInputList2Count.Text = listInput2.Items.Count
        lbOutputList1Count.Text = listOutput1.Items.Count
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        zUpdateListCounts()
    End Sub

    Public Sub zGetTextLineCount()
        zTextLinesToListbox(txtInputText1, listInput1, 1)
        zTextLinesToListbox(txtInputText2, listInput2, 1)
        zUpdateListCounts()
    End Sub

    Private Sub btCombineLeftThenRight_Click(sender As Object, e As EventArgs) Handles btCombineLeftThenRight.Click
        '2026-06-21-02-59-00-AM
        'adding left then right with no merge logic
        Dim zTxt1 = txtInputText1.Text
        Dim zTxt2 = txtInputText2.Text
        Dim zLiO As Integer
        Dim zI1 As Integer
        Dim zoStr As String

        If zTxt1 = "" Then Exit Sub
        If zTxt2 = "" Then Exit Sub

        zTextLinesToListbox(txtInputText1, listInput1, 1)
        zTextLinesToListbox(txtInputText2, listInput2, 1)

        zUpdateListCounts()

        Dim zLi1 = listInput1.Items.Count
        Dim zLi2 = listInput2.Items.Count

        If zLi1 = 0 Then Exit Sub
        If zLi2 = 0 Then Exit Sub

        listOutput1.Items.Clear()
        txtOutputText1.Text = ""

        Dim zListState As Integer

        If zLi1 = zLi2 Then
            'theyre equal
            zLiO = zLi1
            zListState = 0
        ElseIf zLi1 > zLi2 Then
            'list1 is greater than list2
            zLiO = zLi1
            zListState = 1
        ElseIf zLi2 > zLi1 Then
            'list2 is greater than list1
            zLiO = zLi2
            zListState = 2
        End If

        For zI1 = 0 To zLiO - 1
            Application.DoEvents()
            Select Case zListState
                Case 0
                    'equal
                    zoStr = zoStr & listInput1.Items.Item(zI1) & listInput2.Items.Item(zI1) & zR
                    listOutput1.Items.Add(listInput1.Items.Item(zI1) & listInput2.Items.Item(zI1) & zR)
                Case 1
                    'list1 is greater than list2
                    If zI1 < zLi2 Then
                        zoStr = zoStr & listInput1.Items.Item(zI1) & listInput2.Items.Item(zI1) & zR
                        listOutput1.Items.Add(listInput1.Items.Item(zI1) & listInput2.Items.Item(zI1) & zR)
                    Else
                        zoStr = zoStr & listInput1.Items.Item(zI1) & zR
                        listOutput1.Items.Add(listInput1.Items.Item(zI1) & zR)
                    End If
                Case 2
                    'list2 is greater than list1
                    If zI1 < zLi1 Then
                        zoStr = zoStr & listInput1.Items.Item(zI1) & listInput2.Items.Item(zI1) & zR
                        listOutput1.Items.Add(listInput1.Items.Item(zI1) & listInput2.Items.Item(zI1) & zR)
                    Else
                        zoStr = zoStr & listInput2.Items.Item(zI1) & zR
                        listOutput1.Items.Add(listInput2.Items.Item(zI1) & zR)
                    End If
            End Select
        Next
        txtOutputText1.Text = zoStr
        zUpdateListCounts()
    End Sub

    Private Sub btCopyOutputText1_Click(sender As Object, e As EventArgs) Handles btCopyOutputText1.Click
        If txtOutputText1.Text = "" Then Exit Sub
        Clipboard.Clear()
        Clipboard.SetText(txtOutputText1.Text)
    End Sub

    Public Sub zUpdateTestDataCounts()
        zTextLinesToListbox(txtInputText1, listInput1, 1)
        zTextLinesToListbox(txtInputText2, listInput2, 1)
        zUpdateListCounts()
    End Sub

    Private Sub btTest_Click(sender As Object, e As EventArgs) Handles btTestMoreLeft.Click
        Dim zI1 As Integer
        Dim zI2 As Integer
        Dim zTstr1 As String = "ruck" & zR
        Dim zTstr2 As String = "foo" & zR
        txtInputText1.Text = ""
        txtInputText2.Text = ""
        For zI1 = 0 To 12
            Application.DoEvents()
            txtInputText1.Text = txtInputText1.Text & zTstr1
        Next
        For zI1 = 0 To 7
            Application.DoEvents()
            txtInputText2.Text = txtInputText2.Text & zTstr2
        Next
        zUpdateTestDataCounts()
    End Sub

    Private Sub btTestMoreRight_Click(sender As Object, e As EventArgs) Handles btTestMoreRight.Click
        Dim zI1 As Integer
        Dim zI2 As Integer
        Dim zTstr1 As String = "ruck" & zR
        Dim zTstr2 As String = "foo" & zR
        txtInputText1.Text = ""
        txtInputText2.Text = ""
        For zI1 = 0 To 7
            Application.DoEvents()
            txtInputText1.Text = txtInputText1.Text & zTstr1
        Next
        For zI1 = 0 To 12
            Application.DoEvents()
            txtInputText2.Text = txtInputText2.Text & zTstr2
        Next
        zUpdateTestDataCounts()
    End Sub

    Private Sub btTestEqual_Click(sender As Object, e As EventArgs) Handles btTestEqual.Click
        Dim zI1 As Integer
        Dim zI2 As Integer
        Dim zTstr1 As String = "ruck" & zR
        Dim zTstr2 As String = "foo" & zR
        txtInputText1.Text = ""
        txtInputText2.Text = ""
        For zI1 = 0 To 12
            Application.DoEvents()
            txtInputText1.Text = txtInputText1.Text & zTstr1
        Next
        For zI1 = 0 To 12
            Application.DoEvents()
            txtInputText2.Text = txtInputText2.Text & zTstr2
        Next
        zUpdateTestDataCounts()
    End Sub

    Private Sub btClearAll_Click(sender As Object, e As EventArgs) Handles btClearAll.Click
        txtInputText1.Text = ""
        txtInputText2.Text = ""
        txtOutputText1.Text = ""
        listInput1.Items.Clear()
        listInput2.Items.Clear()
        listOutput1.Items.Clear()
        zUpdateListCounts()
    End Sub

    Private Sub ckOnTop_CheckedChanged(sender As Object, e As EventArgs) Handles ckOnTop.CheckedChanged
        zOnTopCheckBox(Me, ckOnTop)
    End Sub

    Private Sub btGetLineCount_Click(sender As Object, e As EventArgs) Handles btGetLineCount.Click
        zGetTextLineCount()
    End Sub
End Class
