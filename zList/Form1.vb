Public Class Form1

    Public Sub zClearListsAndOutputText()
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        txtOutput.Text = ""
        zUpdateCounts()
    End Sub

    Public Sub zUpdateCounts()
        LbListBox1Count.Text = ListBox1.Items.Count
        LbListBox2Count.Text = ListBox2.Items.Count
        LbListBox3Count.Text = ListBox3.Items.Count
        LbListBox4Count.Text = ListBox4.Items.Count
        LbListBox5Count.Text = ListBox5.Items.Count
    End Sub

    Private Sub btInput1_Click(sender As Object, e As EventArgs) Handles btInput1.Click
        If txtInput1.Text = "" Then Exit Sub
        zTextLinesToListbox(txtInput1, ListBox1, 1)
        zUpdateCounts()
    End Sub

    Private Sub btInput2_Click(sender As Object, e As EventArgs) Handles btInput2.Click
        If txtInput2.Text = "" Then Exit Sub
        zTextLinesToListbox(txtInput2, ListBox2, 1)
        zUpdateCounts()
    End Sub

    Private Sub btCompare1to2KeepUnique_Click(sender As Object, e As EventArgs) Handles btCompare1to2KeepUnique.Click
        zCompareListBoxesKeepOnlyUnique(ListBox1, ListBox2, ListBox3)
        txtOutput.Text = zListboxtoStringWithReturn(ListBox3)
        zUpdateCounts()
    End Sub

    Private Sub btCompare2to1KeepUnique_Click(sender As Object, e As EventArgs) Handles btCompare2to1KeepUnique.Click
        zCompareListBoxesKeepOnlyUnique(ListBox2, ListBox1, ListBox3)
        txtOutput.Text = zListboxtoStringWithReturn(ListBox3)
        zUpdateCounts()
    End Sub

    Private Sub btClearInput1_Click(sender As Object, e As EventArgs) Handles btClearInput1.Click
        txtInput1.Text = ""
    End Sub

    Private Sub btClearInput2_Click(sender As Object, e As EventArgs) Handles btClearInput2.Click
        txtInput2.Text = ""
    End Sub

    Private Sub btCopyText3ToClipboard_Click(sender As Object, e As EventArgs) Handles btCopyText3ToClipboard.Click
        Clipboard.Clear()
        Clipboard.SetText(txtOutput.Text)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Me.Height = Me.Height / 2
        Me.Height = Me.Height * 0.66
    End Sub

    Private Sub btCrossCompareKeepUnique_Click(sender As Object, e As EventArgs) Handles btCrossCompareKeepUnique.Click
        zCompareListBoxesKeepOnlyUnique(ListBox1, ListBox2, ListBox4)
        zCompareListBoxesKeepOnlyUnique(ListBox2, ListBox1, ListBox5)
        txtOutputCrossCompare1To2.Text = zListboxtoStringWithReturn(ListBox4)
        txtOutputCrossCompare2To1.Text = zListboxtoStringWithReturn(ListBox5)
        zUpdateCounts()
    End Sub

    Private Sub txtOutputCrossCompare1To2_TextChanged(sender As Object, e As EventArgs) Handles txtOutputCrossCompare1To2.TextChanged

    End Sub

    Private Sub bttxtOutputCrossCompare1To2Clear_Click(sender As Object, e As EventArgs) Handles bttxtOutputCrossCompare1To2Clear.Click
        txtOutputCrossCompare1To2.Text = ""

    End Sub

    Private Sub bttxtOutputCrossCompare2To1Clear_Click(sender As Object, e As EventArgs) Handles bttxtOutputCrossCompare2To1Clear.Click
        txtOutputCrossCompare2To1.Text = ""

    End Sub

    Private Sub btMergeCrossCompareOutput_Click(sender As Object, e As EventArgs) Handles btMergeCrossCompareOutput.Click
        txtOutput.Text = txtOutputCrossCompare1To2.Text & zR & txtOutputCrossCompare2To1.Text
    End Sub

    Private Sub btCrossCompareAndMerge_Click(sender As Object, e As EventArgs) Handles btCrossCompareAndMerge.Click
        zCompareListBoxesKeepOnlyUnique(ListBox1, ListBox2, ListBox4)
        zCompareListBoxesKeepOnlyUnique(ListBox2, ListBox1, ListBox5)
        txtOutputCrossCompare1To2.Text = zListboxtoStringWithReturn(ListBox4)
        txtOutputCrossCompare2To1.Text = zListboxtoStringWithReturn(ListBox5)
        zUpdateCounts()
        txtOutput.Text = txtOutputCrossCompare1To2.Text & zR & txtOutputCrossCompare2To1.Text

    End Sub

    Private Sub btInput1And2_Click(sender As Object, e As EventArgs) Handles btInput1And2.Click
        If txtInput1.Text = "" Then Exit Sub
        zTextLinesToListbox(txtInput1, ListBox1, 1)
        If txtInput2.Text = "" Then Exit Sub
        zTextLinesToListbox(txtInput2, ListBox2, 1)
        zUpdateCounts()

    End Sub

    Private Sub btCrossCompareMergeShowBothUniqueNonDeduplicated_Click(sender As Object, e As EventArgs) Handles btCrossCompareMergeShowBothUniqueNonDeduplicated.Click
        zCompareListBoxesKeepOnlyUnique(ListBox1, ListBox2, ListBox4)
        zCompareListBoxesKeepOnlyUnique(ListBox2, ListBox1, ListBox5)
        txtOutputCrossCompare1To2.Text = zListboxtoStringWithReturn(ListBox4)
        txtOutputCrossCompare2To1.Text = zListboxtoStringWithReturn(ListBox5)
        'zUpdateCounts()
        'this is the merged unique list
        txtOutput.Text = txtOutputCrossCompare1To2.Text & zR & txtOutputCrossCompare2To1.Text
        'using listbox3 as the merged total list
        'using all entries from listbox1 and listbox2
        ListBox3.Items.Clear()
        zAddOneListboxToAnother(ListBox1, ListBox3)
        zAddOneListboxToAnother(ListBox2, ListBox3)
        'txtoutput contains the unique merged cross compare list
        'using listbox4
        zTextLinesToListbox(txtOutput, ListBox4, 1)
        'deduplicate the unique entries listbox4
        'zDeduplicateListBox(ListBox4)
        txtOutputCrossCompare1To2.Text = zListboxtoStringWithReturn(ListBox4)
        'then do a compare using the total list against the unique list
        'it should output just the ones that are inverted against the other list
        'all the ones that arent unique
        'then outputs to listbox5
        ListBox5.Items.Clear()
        zCompareListBoxesKeepOnlyUnique(ListBox3, ListBox4, ListBox5)
        'deduplicate the unique entries listbox5
        'zDeduplicateListBox(ListBox5)
        txtOutputCrossCompare2To1.Text = zListboxtoStringWithReturn(ListBox5)
        zUpdateCounts()
    End Sub

    Private Sub btInputTestData_Click(sender As Object, e As EventArgs) Handles btInputTestData.Click
        txtInput1.Text = "1" & zR & "2" & zR & "3" & zR & "4" & zR & "5" & zR
        txtInput2.Text = "2" & zR & "4" & zR & "6" & zR & "8" & zR & "10" & zR
        If txtInput1.Text = "" Then Exit Sub
        zTextLinesToListbox(txtInput1, ListBox1, 1)
        If txtInput2.Text = "" Then Exit Sub
        zTextLinesToListbox(txtInput2, ListBox2, 1)
        zUpdateCounts()

    End Sub

    Public Sub zClearAllInputOutputBoxes()
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
        ListBox5.Items.Clear()
        txtInput1.Text = ""
        txtInput2.Text = ""
        txtOutput.Text = ""
        txtOutputCrossCompare1To2.Text = ""
        txtOutputCrossCompare2To1.Text = ""
        zUpdateCounts()
    End Sub

    Private Sub btClearAll_Click(sender As Object, e As EventArgs) Handles btClearAll.Click
        zClearAllInputOutputBoxes()
    End Sub

    Private Sub btCrossCompareMergeShowBothUniqueDeduplicated_Click(sender As Object, e As EventArgs) Handles btCrossCompareMergeShowBothUniqueDeduplicated.Click
        zDeduplicateListBox(ListBox1)
        zDeduplicateListBox(ListBox2)

        zCompareListBoxesKeepOnlyUnique(ListBox1, ListBox2, ListBox4)
        zCompareListBoxesKeepOnlyUnique(ListBox2, ListBox1, ListBox5)
        txtOutputCrossCompare1To2.Text = zListboxtoStringWithReturn(ListBox4)
        txtOutputCrossCompare2To1.Text = zListboxtoStringWithReturn(ListBox5)
        'zUpdateCounts()
        'this is the merged unique list
        txtOutput.Text = txtOutputCrossCompare1To2.Text & zR & txtOutputCrossCompare2To1.Text
        'using listbox3 as the merged total list
        'using all entries from listbox1 and listbox2
        ListBox3.Items.Clear()
        zAddOneListboxToAnother(ListBox1, ListBox3)
        zAddOneListboxToAnother(ListBox2, ListBox3)
        zDeduplicateListBox(ListBox3)

        'txtoutput contains the unique merged cross compare list
        'using listbox4
        zTextLinesToListbox(txtOutput, ListBox4, 1)
        'deduplicate the unique entries listbox4
        zDeduplicateListBox(ListBox4)
        txtOutputCrossCompare1To2.Text = zListboxtoStringWithReturn(ListBox4)
        'then do a compare using the total list against the unique list
        'it should output just the ones that are inverted against the other list
        'all the ones that arent unique
        'then outputs to listbox5
        ListBox5.Items.Clear()
        zCompareListBoxesKeepOnlyUnique(ListBox3, ListBox4, ListBox5)
        'deduplicate the unique entries listbox5
        zDeduplicateListBox(ListBox5)
        txtOutputCrossCompare2To1.Text = zListboxtoStringWithReturn(ListBox5)
        zUpdateCounts()

    End Sub
End Class
