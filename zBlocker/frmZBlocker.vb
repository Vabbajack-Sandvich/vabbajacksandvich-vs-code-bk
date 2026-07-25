Public Class frmZBlocker

    Public Sub zInputButtonClick()
        If txtInput.Text = "" And lstIterator.Items.Count = 0 Then
            Exit Sub
        End If
        'If txtOld.Text = "" Then Exit Sub

        'i could add an ip only filter here
        'but for now it expects a list of ips only 1 on each line
        '123.123.123.123
        '123.123.123.123
        '123.123.123.123
        '123.123.123.123
        '123.123.123.123
        'like that

        'zTextLinesToListbox(txtInput, lstInput, 1)
        'testing the filter
        zTextLinesToListboxIPAdressFilter(txtInput, lstInput, 1)

        'adding the tcpview copy and paste to the input filter
        'without clearing the list, since it already gets cleared by the ip filter
        'this should just add matching tcpview copy and paste lines
        'tested and works fine
        zExtractRemoteAddressFromTCPViewTextBoxAddToListbox(txtInput, lstInput, 0)

        'tcpviewcon filter
        zExtractRemoteAddressFromTCPViewConTextBoxAddToListbox(txtInput, lstInput, 0)

        zDeduplicateListBoxWithProgress(lstInput, pbSaveLoad)

        zUpdateListboxCountLabels()

        'adding this to prevent screw ups
        If lstInput.Items.Count = 0 Then
            MsgBox("nothing in input listbox", vbSystemModal, "zBlocker")
            Exit Sub
        End If

        'for testing filters
        'Exit Sub

        zCompareListBoxesKeepOnlyUnique(lstInput, lstOld, lstUnique)
        zMoveList(lstUnique, lstInput)
        If lstUnique.Items.Count = 0 And lstOld.Items.Count <> 0 Then
            lstInput.Items.Clear()
            MsgBox("nothing in unique listbox", vbSystemModal, "zBlocker")
            Exit Sub
        End If
        'zDeduplicateListBox(lstInput)
        zDeduplicateListBoxWithProgress(lstInput, pbSaveLoad)
        zUpdateListboxCountLabels()
    End Sub


    Private Sub btInput_Click(sender As Object, e As EventArgs) Handles btInput.Click
        zInputButtonClick()
    End Sub

    Private Sub btDefault_Click(sender As Object, e As EventArgs) Handles btDef.Click
        txtI1.Text = "netsh advfirewall firewall add rule name=" & Chr(34) & "block " & Chr(34)
        txtI2.Text = Chr(34) & " dir=in action=block remoteip=" & Chr(34)
        txtI3.Text = Chr(34)
    End Sub

    Private Sub btIn_Click(sender As Object, e As EventArgs) Handles btIn.Click
        txtI2.Text = Chr(34) & " dir=in action=block remoteip=" & Chr(34)
    End Sub

    Private Sub btOut_Click(sender As Object, e As EventArgs) Handles btOut.Click
        txtI2.Text = Chr(34) & " dir=out action=block remoteip=" & Chr(34)
    End Sub

    Private Sub btClearInserts_Click(sender As Object, e As EventArgs) Handles btClearInserts.Click
        txtI1.Text = ""
        txtI2.Text = ""
        txtI3.Text = ""
    End Sub

    Private Sub btCopy_Click(sender As Object, e As EventArgs) Handles btCopy.Click
        Clipboard.Clear()
        Clipboard.SetText(txtOut.Text)
    End Sub

    Public Sub zGenerateClick()
        If lstInput.Items.Count = 0 Then Exit Sub
        Dim zIterator As Integer
        Dim zOutString As String
        pbSaveLoad.Visible = True
        pbSaveLoad.Maximum = lstInput.Items.Count
        For zIterator = 0 To lstInput.Items.Count - 1
            Application.DoEvents()
            pbSaveLoad.Value = zIterator + 1
            zOutString = zOutString & txtI1.Text & lstInput.Items.Item(zIterator) & txtI2.Text & lstInput.Items.Item(zIterator) & txtI3.Text & zR
        Next
        txtOut.Text = zOutString
        pbSaveLoad.Visible = False
    End Sub

    Private Sub btGenerate_Click(sender As Object, e As EventArgs) Handles btGenerate.Click
        zGenerateClick()
    End Sub

    Private Sub btInputGenerate_Click(sender As Object, e As EventArgs) Handles btInputGenerate.Click
        'input
        zInputButtonClick()
        'generate
        zGenerateClick()
    End Sub

    Private Sub ckOnTop_CheckedChanged(sender As Object, e As EventArgs) Handles ckOnTop.CheckedChanged
        If ckOnTop.Checked = True Then
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If
    End Sub


    'these paths get set here and on load
    'the loading process determines if the program
    'is running on my computer or a computer
    'that is a different one
    'if it finds that the default path doesnt exist
    'it swaps it on load to the C drive

    Public zBatchPath As String = "D:\"
    'default
    'zBatchPath = "D:\"

    Public zListPath As String = "D:\zonide\fwip\"
    'default
    'zFwipDir = "D:\zonide\fwip\"

    Public Sub zbtLoadListClick()
        'My.Computer.FileSystem.WriteAllText(zBpFn, "mode=1", False, System.Text.Encoding.ASCII)

        'firewall ip list
        'D:\zonide\fwip
        Dim zFwipDir As String
        zFwipDir = "D:\zonide\fwip\"
        zListPath = zFwipDir
        zBatchPath = "D:\"

        'D:\zonide\fwip\fwip.txt
        Dim zFwip As String
        zFwip = "D:\zonide\fwip\fwip.txt"

        If My.Computer.FileSystem.DirectoryExists(zFwipDir) = False Then
            zFwipDir = "c:\fwip\"
            zListPath = zFwipDir
            zBatchPath = "C:\"
            'this only changes if the default d drive
            'directory isnt there
            'otherwise its D:\zonide\fwip\
            zListPath = zFwipDir
            If My.Computer.FileSystem.DirectoryExists(zFwipDir) = False Then
                My.Computer.FileSystem.CreateDirectory(zFwipDir)
            End If
        End If

        If My.Computer.FileSystem.FileExists(zFwip) = False Then
            zFwip = "C:\fwip\fwip.txt"
            'the existing code creates a file in the directory already
            'just have to change the variable
        End If

        Dim zFeFwip As Boolean
        zFeFwip = My.Computer.FileSystem.FileExists(zFwip)
        If zFeFwip = False Then
            My.Computer.FileSystem.WriteAllText(zFwip, "", False, System.Text.Encoding.ASCII)
        End If
        Dim zfileReader
        zfileReader = My.Computer.FileSystem.ReadAllText(zFwip)
        If zfileReader = "" Then
            'MsgBox("time is up", vbSystemModal, "zTimer")
            MsgBox("nothing in file", vbSystemModal, "zBlocker")
            Exit Sub
        Else
            txtOld.Text = zfileReader
            If txtOld.Text = "" Then Exit Sub
            'zTextLinesToListbox(txtOld, lstOld, 1)
            zTextLinesToListboxWithProgress(txtOld, lstOld, pbSaveLoad, 1)
            'zDeduplicateListBox(lstOld)
            zDeduplicateListBoxWithProgress(lstOld, pbSaveLoad)
            zUpdateListboxCountLabels()
        End If
    End Sub

    Private Sub btLoadList_Click(sender As Object, e As EventArgs) Handles btLoadList.Click
        zbtLoadListClick()
    End Sub

    Public Sub zSaveIPClick()
        'My.Computer.FileSystem.WriteAllText(zBpFn, "mode=1", False, System.Text.Encoding.ASCII)
        'trying this without exiting on no count in lstinput
        'If lstInput.Items.Count = 0 Then Exit Sub
        'zAddOneListboxToAnother(lstInput, lstOld)
        zAddOneListboxToAnotherWithProgress(lstInput, lstOld, pbSaveLoad)
        'zDeduplicateListBox(lstOld)
        zDeduplicateListBoxWithProgress(lstOld, pbSaveLoad)
        Dim zFwip As String
        zFwip = "d:\zonide\fwip\fwip.txt"

        'firewall ip list
        'D:\zonide\fwip
        Dim zFwipDir As String
        zFwipDir = "D:\zonide\fwip\"

        If My.Computer.FileSystem.DirectoryExists(zFwipDir) = False Then
            zFwipDir = "c:\fwip\"
            If My.Computer.FileSystem.DirectoryExists(zFwipDir) = False Then
                My.Computer.FileSystem.CreateDirectory(zFwipDir)
            End If
        End If

        If My.Computer.FileSystem.FileExists(zFwip) = False Then
            zFwip = "C:\fwip\fwip.txt"
            'the existing code creates a file in the directory already
            'just have to change the variable
        End If


        Dim zOutString As String
        'zOutString = zListboxtoStringWithReturn(lstOld)
        zOutString = zListboxtoStringWithReturnWithProgress(lstOld, pbSaveLoad)
        My.Computer.FileSystem.WriteAllText(zFwip, zOutString, False, System.Text.Encoding.ASCII)
    End Sub

    Private Sub btSaveIP_Click(sender As Object, e As EventArgs) Handles btSaveIP.Click
        zSaveIPClick()
    End Sub

    Private Sub btSaveBatch_Click(sender As Object, e As EventArgs) Handles btSaveBatch.Click
        'My.Computer.FileSystem.WriteAllText(zBpFn, "mode=1", False, System.Text.Encoding.ASCII)

        If txtOut.Text = "" Then
            MsgBox("nothing in output", vbSystemModal, "zBlocker")
            Exit Sub
        End If

        'D:\fw-block-ips-in.bat
        'D:\fw-block-ips-out.bat
        Dim zFwBatch As String

        If ckInBatch.Checked = True Then
            zFwBatch = "D:\fw-block-ips-in.bat"
        Else
            zFwBatch = "D:\fw-block-ips-out.bat"
        End If

        'D:\zonide\fwip
        Dim zFwipDir As String
        zFwipDir = "D:\zonide\fwip\"

        If My.Computer.FileSystem.DirectoryExists(zFwipDir) = False Then
            zFwipDir = "c:\fwip\"
            If My.Computer.FileSystem.DirectoryExists(zFwipDir) = False Then
                My.Computer.FileSystem.CreateDirectory(zFwipDir)
            End If
        End If

        If My.Computer.FileSystem.FileExists(zFwBatch) = False Then
            'the existing code creates a file in the directory already
            'just have to change the variable
            If ckInBatch.Checked = True Then
                zFwBatch = "c:\fw-block-ips-in.bat"
            Else
                zFwBatch = "c:\fw-block-ips-out.bat"
            End If
        End If

        My.Computer.FileSystem.WriteAllText(zFwBatch, txtOut.Text, False, System.Text.Encoding.ASCII)

    End Sub

    Public zFrmMainDefWidth As Integer = 818
    Public zFrmMainDefHeight As Integer = 776
    'frmMain default size
    'width 818
    'height 776

    Public zFrmMainMaxWidth As Integer = 818
    Public zFrmMainMaxHeight As Integer = 776
    'frmMain max size
    'width 818
    'height 776

    Public Sub zFrmMainSetDefaultSize()
        Me.Width = zFrmMainDefWidth
        Me.Height = zFrmMainDefHeight
    End Sub


    Private Sub frmZBlocker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'zbtLoadListClick()
        'zSetIterationCheckboxDefaults()
        Me.TopMost = True
        zLoadtimer.Enabled = True
        zFrmMainSetDefaultSize()
        zSaveOnExit = True
    End Sub

    Private Sub ckInBatch_CheckedChanged(sender As Object, e As EventArgs) Handles ckInBatch.CheckedChanged
        If ckInBatch.Checked = True Then
            'ckInBatch.Checked = True
            ckOutBatch.Checked = False
        Else
            'ckInBatch.Checked = False
            ckOutBatch.Checked = True
        End If
    End Sub

    Private Sub ckOutBatch_CheckedChanged(sender As Object, e As EventArgs) Handles ckOutBatch.CheckedChanged
        If ckOutBatch.Checked = True Then
            ckInBatch.Checked = False
            'ckOutBatch.Checked = True
        Else
            ckInBatch.Checked = True
            'ckOutBatch.Checked = False
        End If
    End Sub

    Private Sub btClearInput_Click(sender As Object, e As EventArgs) Handles btClearInput.Click
        txtInput.Text = ""
    End Sub

    Public zSaveOnExit As Boolean

    Private Sub frmZBlocker_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If zSaveOnExit = True Then
            zSaveIPClick()
        End If
    End Sub
    Public Sub zGenerateBothClick()
        If lstInput.Items.Count = 0 Then Exit Sub
        Dim zIterator As Integer
        Dim zOutString As String

        'in
        txtI2.Text = Chr(34) & " dir=in action=block remoteip=" & Chr(34)

        pbSaveLoad.Visible = True
        pbSaveLoad.Maximum = lstInput.Items.Count

        For zIterator = 0 To lstInput.Items.Count - 1
            Application.DoEvents()
            pbSaveLoad.Value = zIterator + 1
            zOutString = zOutString & txtI1.Text & lstInput.Items.Item(zIterator) & txtI2.Text & lstInput.Items.Item(zIterator) & txtI3.Text & zR
        Next

        'out
        txtI2.Text = Chr(34) & " dir=out action=block remoteip=" & Chr(34)

        For zIterator = 0 To lstInput.Items.Count - 1
            Application.DoEvents()
            pbSaveLoad.Value = zIterator + 1
            zOutString = zOutString & txtI1.Text & lstInput.Items.Item(zIterator) & txtI2.Text & lstInput.Items.Item(zIterator) & txtI3.Text & zR
        Next

        txtOut.Text = zOutString
        pbSaveLoad.Visible = False
        pbSaveLoad.Value = 0
        pbSaveLoad.Maximum = 0
    End Sub

    Private Sub btInputGenerateSaveBoth_Click(sender As Object, e As EventArgs) Handles btInputGenerateSaveBoth.Click
        'input
        zInputButtonClick()

        'generate
        zGenerateBothClick()

        'save both in one batch
        'My.Computer.FileSystem.WriteAllText(zBpFn, "mode=1", False, System.Text.Encoding.ASCII)

        If txtOut.Text = "" Then
            MsgBox("nothing in output", vbSystemModal, "zBlocker")
            Exit Sub
        End If

        'have to add something to check between the two computers
        'easiest way is if the default, dragon, directory isnt there
        'then just use the c drive versions

        If My.Computer.FileSystem.FileExists("D:\fwbip.bat") = True Then
            'D:\fwbip.bat
            zBatchPath = "D:\"

            My.Computer.FileSystem.WriteAllText("D:\fwbip.bat", txtOut.Text, False, System.Text.Encoding.ASCII)
        Else
            'assume not dragon
            'c:\fwbip.bat
            zBatchPath = "C:\"

            My.Computer.FileSystem.WriteAllText("c:\fwbip.bat", txtOut.Text, False, System.Text.Encoding.ASCII)
        End If

        zSaveIPClick()

    End Sub

    Private Sub btClearOld_Click(sender As Object, e As EventArgs) Handles btClearOld.Click
        lstOld.Items.Clear()
        zUpdateListboxCountLabels()
    End Sub

    Public Sub zSetIterationInputDefault()
        txtIteratorInput.Text = "123.123.123.123"
    End Sub
    Public Sub zIterateClick()
        'this iterates the entry through whichever selected check box
        'from 0 to 255 and add it to the iteration list box

        'if somehow none are checked fix it and set it to 4
        zCheckIterationCheckboxesForAllEmptyAndFix()

        'filter out anything but numbers and dot
        txtIteratorInput.Text = zNumFilterWithDot(txtIteratorInput.Text)

        If txtIteratorInput.Text = "" Then
            MsgBox("nothing in iteration input", vbSystemModal, "zBlocker")
            Exit Sub
        End If

        Dim zDot1 As Integer
        Dim zDot2 As Integer
        Dim zDot3 As Integer

        Dim ztInput As String

        ztInput = txtIteratorInput.Text

        zDot1 = InStr(1, ztInput, ".")
        If zDot1 = 0 Then
            MsgBox("incorrect format no first dot", vbSystemModal, "zBlocker")
            zSetIterationInputDefault()
            Exit Sub
        End If
        zDot2 = InStr(zDot1 + 1, ztInput, ".")
        If zDot2 = 0 Then
            MsgBox("incorrect format no second dot", vbSystemModal, "zBlocker")
            zSetIterationInputDefault()
            Exit Sub
        End If
        zDot3 = InStr(zDot2 + 1, ztInput, ".")
        If zDot3 = 0 Then
            MsgBox("incorrect format no third dot", vbSystemModal, "zBlocker")
            zSetIterationInputDefault()
            Exit Sub
        End If

        'have to get the values for the numbers between the dots
        Dim zEntry1 As String
        Dim zEntry2 As String
        Dim zEntry3 As String
        Dim zEntry4 As String

        zEntry1 = Mid(ztInput, 1, zDot1 - 1)
        zEntry2 = Mid(ztInput, zDot1 + 1, zDot2 - 1 - zDot1)
        zEntry3 = Mid(ztInput, zDot2 + 1, zDot3 - 1 - zDot2)
        zEntry4 = Mid(ztInput, zDot3 + 1, Len(ztInput))

        'correct format so far, it has all three dots
        'check for the length of the entries
        If Len(zEntry1) > 3 Then
            MsgBox("incorrect format entry 1 too long", vbSystemModal, "zBlocker")
            zSetIterationInputDefault()
            Exit Sub
        End If
        If Len(zEntry2) > 3 Then
            MsgBox("incorrect format entry 2 too long", vbSystemModal, "zBlocker")
            zSetIterationInputDefault()
            Exit Sub
        End If
        If Len(zEntry3) > 3 Then
            MsgBox("incorrect format entry 3 too long", vbSystemModal, "zBlocker")
            zSetIterationInputDefault()
            Exit Sub
        End If
        If Len(zEntry4) > 3 Then
            MsgBox("incorrect format entry 4 too long", vbSystemModal, "zBlocker")
            zSetIterationInputDefault()
            Exit Sub
        End If

        'seems like the format is correct
        'now iterate based on which value to iterate

        Dim zIter As Integer
        Dim ztOut As String

        lstIterator.Items.Clear()

        If ckIter1.Checked = True Then
            For zIter = 0 To 255
                Application.DoEvents()
                '"." &
                ztOut = zIter & "." & zEntry2 & "." & zEntry3 & "." & zEntry4
                lstIterator.Items.Add(ztOut)
            Next
        ElseIf ckIter2.Checked = True Then
            For zIter = 0 To 255
                Application.DoEvents()
                ztOut = zEntry1 & "." & zIter & "." & zEntry3 & "." & zEntry4
                lstIterator.Items.Add(ztOut)
            Next
        ElseIf ckIter3.Checked = True Then
            For zIter = 0 To 255
                Application.DoEvents()
                ztOut = zEntry1 & "." & zEntry2 & "." & zIter & "." & zEntry4
                lstIterator.Items.Add(ztOut)
            Next
        ElseIf ckIter4.Checked = True Then
            For zIter = 0 To 255
                Application.DoEvents()
                ztOut = zEntry1 & "." & zEntry2 & "." & zEntry3 & "." & zIter
                lstIterator.Items.Add(ztOut)
            Next
        End If

        zUpdateListboxCountLabels()

    End Sub

    Private Sub btIterate_Click(sender As Object, e As EventArgs) Handles btIterate.Click
        zIterateClick()
    End Sub

    Private Sub btMoveIterations_Click(sender As Object, e As EventArgs) Handles btMoveIterations.Click
        'this moves all of the entries that arent already in the old list
        'that way the entries can be generated using the same code

        lstInput.Items.Clear()

        If lstIterator.Items.Count = 0 Then Exit Sub

        zCompareListBoxesKeepOnlyUnique(lstIterator, lstOld, lstUnique)

        zUpdateListboxCountLabels()

    End Sub

    Public Sub zCheckIterationCheckboxesForAllEmptyAndFix()
        If ckIter1.Checked = False And ckIter2.Checked = False And ckIter3.Checked = False And ckIter4.Checked = False Then
            zSetIterationCheckboxDefaults()
        End If
    End Sub

    Public Sub zSetIterationCheckboxDefaults()
        ckIter1.Checked = False
        ckIter2.Checked = False
        ckIter3.Checked = False
        ckIter4.Checked = True
    End Sub

    Private Sub ckIter1_CheckedChanged(sender As Object, e As EventArgs) Handles ckIter1.CheckedChanged
        If ckIter1.Checked = True Then
            'ckIter1.Checked = False
            ckIter2.Checked = False
            ckIter3.Checked = False
            ckIter4.Checked = False
        End If
        zCheckIterationCheckboxesForAllEmptyAndFix()
    End Sub

    Private Sub ckIter2_CheckedChanged(sender As Object, e As EventArgs) Handles ckIter2.CheckedChanged
        If ckIter2.Checked = True Then
            ckIter1.Checked = False
            'ckIter2.Checked = False
            ckIter3.Checked = False
            ckIter4.Checked = False
        End If
        zCheckIterationCheckboxesForAllEmptyAndFix()
    End Sub

    Private Sub ckIter3_CheckedChanged(sender As Object, e As EventArgs) Handles ckIter3.CheckedChanged
        If ckIter3.Checked = True Then
            ckIter1.Checked = False
            ckIter2.Checked = False
            'ckIter3.Checked = False
            ckIter4.Checked = False
        End If
        zCheckIterationCheckboxesForAllEmptyAndFix()
    End Sub

    Private Sub ckIter4_CheckedChanged(sender As Object, e As EventArgs) Handles ckIter4.CheckedChanged
        If ckIter4.Checked = True Then
            ckIter1.Checked = False
            ckIter2.Checked = False
            ckIter3.Checked = False
            'ckIter4.Checked = False
        End If
        zCheckIterationCheckboxesForAllEmptyAndFix()
    End Sub

    Private Sub btIterateSelected_Click(sender As Object, e As EventArgs) Handles btIterateSelected.Click
        'this uses the selected entry in the old list box
        'sets the iteration input box to the entry
        'then iterates the entry
        If lstOld.Items.Count = 0 Then
            MsgBox("nothing in old list box", vbSystemModal, "zBlocker")
            Exit Sub
        End If
        If lstOld.SelectedIndex = -1 Then
            MsgBox("nothing selected", vbSystemModal, "zBlocker")
            Exit Sub
        End If

        txtIteratorInput.Text = lstOld.Items.Item(lstOld.SelectedIndex)

        zIterateClick()
    End Sub

    Public Sub zGenerateBothFromOldClick()
        If lstOld.Items.Count = 0 Then Exit Sub
        Dim zIterator As Integer
        Dim zOutString As String

        'in
        txtI2.Text = Chr(34) & " dir=in action=block remoteip=" & Chr(34)

        pbSaveLoad.Maximum = lstOld.Items.Count
        pbSaveLoad.Visible = True

        For zIterator = 0 To lstOld.Items.Count - 1
            Application.DoEvents()
            pbSaveLoad.Value = zIterator + 1
            zOutString = zOutString & txtI1.Text & lstOld.Items.Item(zIterator) & txtI2.Text & lstOld.Items.Item(zIterator) & txtI3.Text & zR
        Next

        'out
        txtI2.Text = Chr(34) & " dir=out action=block remoteip=" & Chr(34)

        For zIterator = 0 To lstOld.Items.Count - 1
            Application.DoEvents()
            pbSaveLoad.Value = zIterator + 1
            zOutString = zOutString & txtI1.Text & lstOld.Items.Item(zIterator) & txtI2.Text & lstOld.Items.Item(zIterator) & txtI3.Text & zR
        Next

        txtOut.Text = zOutString
        pbSaveLoad.Value = 0
        pbSaveLoad.Maximum = 0
        pbSaveLoad.Visible = False

    End Sub


    Private Sub btGenerateFromOld_Click(sender As Object, e As EventArgs) Handles btGenerateFromOld.Click
        'input
        zInputButtonClick()

        'generate
        zGenerateBothFromOldClick()

        'save both in one batch
        'My.Computer.FileSystem.WriteAllText(zBpFn, "mode=1", False, System.Text.Encoding.ASCII)

        If txtOut.Text = "" Then
            MsgBox("nothing in output", vbSystemModal, "zBlocker")
            Exit Sub
        End If

        If My.Computer.FileSystem.FileExists("D:\fwbip.bat") = True Then
            'D:\fwbip.bat
            My.Computer.FileSystem.WriteAllText("D:\fwbip.bat", txtOut.Text, False, System.Text.Encoding.ASCII)
        Else
            'assume not dragon
            'c:\fwbip.bat
            My.Computer.FileSystem.WriteAllText("c:\fwbip.bat", txtOut.Text, False, System.Text.Encoding.ASCII)
        End If

        zSaveIPClick()

    End Sub

    Public zLoaded As Boolean = False

    Private Sub zLoadtimer_Tick(sender As Object, e As EventArgs) Handles zLoadtimer.Tick
        If zLoaded = True Then
            zLoadtimer.Enabled = False
            Exit Sub
        End If
        zLoaded = True
        zbtLoadListClick()
        zSetIterationCheckboxDefaults()
    End Sub

    Private Sub frmZBlocker_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.Width > zFrmMainMaxWidth Then
            Me.Width = zFrmMainMaxWidth
        End If
        If Me.Height > zFrmMainMaxHeight Then
            Me.Height = zFrmMainMaxHeight
        End If

    End Sub

    Public Sub zUpdateListboxCountLabels()
        Application.DoEvents()
        'lblstInput
        'lblstOld
        'lblstIterator
        'lblstUnique

        'lblstInput.Text = lstInput.Items.Count
        'lblstOld.Text = lstOld.Items.Count
        'lblstIterator.Text = lstIterator.Items.Count
        'lblstUnique.Text = lstUnique.Items.Count

        lblstInput.Text = "Input - " & lstInput.Items.Count
        lblstOld.Text = "Old - " & lstOld.Items.Count
        lblstIterator.Text = "Iterator - " & lstIterator.Items.Count
        lblstUnique.Text = "Unique - " & lstUnique.Items.Count


    End Sub

    Private Sub btExtractRemoteAddressFromTCPView_Click(sender As Object, e As EventArgs) Handles btExtractRemoteAddressFromTCPView.Click


        'sets the listbox to only matching entries for TCPView copy and paste
        'works as a garbage sort
        'where as the old version still runs on expecting a strict input
        'of only ips on each line
        'and screws up if there isnt one
        'leaving it for now
        'this way i can just save a list of copy an pastes and dump it in the text box
        'while still leaving the other way intact

        'ip filter
        zTextLinesToListboxIPAdressFilter(txtInput, lstInput, 1)

        'tldr
        'this filters the input and only adds an entry
        'if it matches the tcpview copy paste format
        zExtractRemoteAddressFromTCPViewTextBoxAddToListbox(txtInput, lstInput, 0)

        'tcpviewcon filter
        zExtractRemoteAddressFromTCPViewConTextBoxAddToListbox(txtInput, lstInput, 0)

        zDeduplicateListBoxWithProgress(lstInput, pbSaveLoad)

        zUpdateListboxCountLabels()

        'adding this to prevent screw ups
        If lstInput.Items.Count = 0 Then
            MsgBox("nothing in input listbox", vbSystemModal, "zBlocker")
            Exit Sub
        End If

        zCompareListBoxesKeepOnlyUnique(lstInput, lstOld, lstUnique)
        zMoveList(lstUnique, lstInput)

        If lstUnique.Items.Count = 0 And lstOld.Items.Count <> 0 Then
            lstInput.Items.Clear()
            MsgBox("nothing in unique listbox", vbSystemModal, "zBlocker")
            Exit Sub
        End If
        'zDeduplicateListBox(lstInput)
        zDeduplicateListBoxWithProgress(lstInput, pbSaveLoad)

        zGenerateBothClick()

        'save both in one batch
        'My.Computer.FileSystem.WriteAllText(zBpFn, "mode=1", False, System.Text.Encoding.ASCII)

        If txtOut.Text = "" Then
            MsgBox("nothing in output", vbSystemModal, "zBlocker")
            Exit Sub
        End If

        'have to add something to check between the two computers
        'easiest way is if the default, dragon, directory isnt there
        'then just use the c drive versions

        If My.Computer.FileSystem.FileExists("D:\fwbip.bat") = True Then
            'D:\fwbip.bat
            My.Computer.FileSystem.WriteAllText("D:\fwbip.bat", txtOut.Text, False, System.Text.Encoding.ASCII)
        Else
            'assume not dragon
            'c:\fwbip.bat
            My.Computer.FileSystem.WriteAllText("c:\fwbip.bat", txtOut.Text, False, System.Text.Encoding.ASCII)
        End If

        zSaveIPClick()

    End Sub

    Private Sub btDontSaveOnExit_Click(sender As Object, e As EventArgs) Handles btDontSaveOnExit.Click
        zSaveOnExit = False
        Me.Close()
    End Sub

    Private Sub btFilterAndCopyToClipboard_Click(sender As Object, e As EventArgs) Handles btFilterAndCopyToClipboard.Click
        'ip filter
        zTextLinesToListboxIPAdressFilter(txtInput, lstInput, 1)

        'tldr
        'this filters the input and only adds an entry
        'if it matches the tcpview copy paste format
        zExtractRemoteAddressFromTCPViewTextBoxAddToListbox(txtInput, lstInput, 0)

        zExtractRemoteAddressFromTCPViewConTextBoxAddToListbox(txtInput, lstInput, 0)

        zDeduplicateListBoxWithProgress(lstInput, pbSaveLoad)

        zUpdateListboxCountLabels()

        'adding this to prevent screw ups
        If lstInput.Items.Count = 0 Then
            MsgBox("nothing in input listbox", vbSystemModal, "zBlocker")
            Exit Sub
        End If

        Dim zIterator As Integer
        Dim zTempOutStr As String

        For zIterator = 0 To lstInput.Items.Count - 1
            Application.DoEvents()
            zTempOutStr = zTempOutStr & lstInput.Items.Item(zIterator) & zR
        Next

        Clipboard.Clear()
        Clipboard.SetText(zTempOutStr)

    End Sub

    Private Sub btClearListInput_Click(sender As Object, e As EventArgs) Handles btClearListInput.Click
        lstInput.Items.Clear()
        zUpdateListboxCountLabels()
    End Sub

    Private Sub btClearlstUnique_Click(sender As Object, e As EventArgs) Handles btClearlstUnique.Click
        lstUnique.Items.Clear()
        zUpdateListboxCountLabels()
    End Sub

    Private Sub lstInput_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstInput.SelectedIndexChanged

    End Sub

    Private Sub lstInput_KeyUp(sender As Object, e As KeyEventArgs) Handles lstInput.KeyUp
        zListBoxKeyUp(e.KeyCode, lstInput)
        zUpdateListboxCountLabels()
    End Sub

    Private Sub lstOld_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstOld.SelectedIndexChanged

    End Sub

    Private Sub lstOld_KeyUp(sender As Object, e As KeyEventArgs) Handles lstOld.KeyUp
        'since this is the old list
        'im putting a check for deletion
        If e.KeyCode = Keys.Delete Then
            Dim zMsgbox As MsgBoxResult
            zMsgbox = MsgBox("this is the old list, are you sure you want to delete this entry?", vbYesNo, "zBlocker")
            If zMsgbox = vbYes Then
                zListBoxKeyUp(e.KeyCode, lstOld)
                zUpdateListboxCountLabels()
            End If
        End If
    End Sub

    Private Sub lstIterator_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstIterator.SelectedIndexChanged

    End Sub

    Private Sub lstIterator_KeyUp(sender As Object, e As KeyEventArgs) Handles lstIterator.KeyUp
        zListBoxKeyUp(e.KeyCode, lstIterator)
        zUpdateListboxCountLabels()

    End Sub

    Private Sub lstUnique_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstUnique.SelectedIndexChanged

    End Sub

    Private Sub lstUnique_KeyUp(sender As Object, e As KeyEventArgs) Handles lstUnique.KeyUp
        zListBoxKeyUp(e.KeyCode, lstUnique)
        zUpdateListboxCountLabels()

    End Sub

    Private Sub lstInput_MouseClick(sender As Object, e As MouseEventArgs) Handles lstInput.MouseClick
    End Sub

    Private Sub lstInput_MouseUp(sender As Object, e As MouseEventArgs) Handles lstInput.MouseUp
        zListBoxMouseUp(e.Button, lstInput)

    End Sub

    Private Sub lstOld_MouseUp(sender As Object, e As MouseEventArgs) Handles lstOld.MouseUp
        zListBoxMouseUp(e.Button, lstOld)

    End Sub

    Private Sub lstIterator_MouseUp(sender As Object, e As MouseEventArgs) Handles lstIterator.MouseUp
        zListBoxMouseUp(e.Button, lstIterator)

    End Sub

    Private Sub lstUnique_MouseUp(sender As Object, e As MouseEventArgs) Handles lstUnique.MouseUp
        zListBoxMouseUp(e.Button, lstUnique)

    End Sub

    Private Sub btOpenBatchFolder_Click(sender As Object, e As EventArgs) Handles btOpenBatchFolder.Click
        zOpenWindowsDirectoryInExplorer(zBatchPath, "fwbip.bat")
        'zOpenWindowsDirectoryInExplorer(zBatchPath, "testfwbip.bat")
    End Sub

    Private Sub btOpenListFolder_Click(sender As Object, e As EventArgs) Handles btOpenListFolder.Click
        zOpenWindowsDirectoryInExplorer(zListPath, "fwip.txt")

    End Sub

    Private Sub btTest_Click(sender As Object, e As EventArgs) Handles btTest.Click
        'svchost.exe,5124,TCP,Established,192.168.18.198,49710,23.194.99.73,443,10/4/2025 7:53:23 PM,WpnUserService_61beb,,,,
        Dim zTestStrInput As String

        'zTestStrInput = "svchost.exe,5124,TCP,Established,192.168.18.198,49710,23.194.99.73,443,10/4/2025 7:53:23 PM,WpnUserService_61beb,,,,"
        'zTestStrInput = "TCP,OneApp.IGCC.WinService.exe,3980,LISTENING,0.0.0.0,0.0.0.0"
        'zTestStrInput = "this is a test string for testing to see what happens when i scan for spaces"
        zTestStrInput = "this" & vbCrLf & "is" & vbCrLf & "a" & vbCrLf & "test" & vbCrLf & "string" & vbCrLf & "for" & vbCrLf & "testing" & vbCrLf & "to" & vbCrLf & "see" & vbCrLf & "what" & vbCrLf & "happens" & vbCrLf & "when" & vbCrLf & "i" & vbCrLf & "scan" & vbCrLf & "for" & vbCrLf & "spaces"

        'Public Function zScanReturnAsArrayWithProgress(zSRInputString As String, zSRFind As String, zSRProgressBar As ProgressBar) As Array
        Dim zTempArrayTest As Array
        'this works
        'going from a function defined as a blank array
        'then defining a temp array inside that function
        'then making that functions array = the tmparray
        'then making the procedure level blank array = the function
        'zTempArrayTest = zScanReturnAsArrayWithProgress(zTestStrInput, ",", pbSaveLoad)
        'zTempArrayTest = zScanStringReturnAsArrayWithProgress(zTestStrInput, ",", pbSaveLoad)
        'zTempArrayTest = zScanStringReturnAsArrayWithProgress(zTestStrInput, " ", pbSaveLoad)
        zTempArrayTest = zScanStringReturnAsArrayWithProgress(zTestStrInput, vbCrLf, pbSaveLoad)

        'need to write get array count
        '0 is the dimension which is columns and rows in higher dimensions
        'Debug.Print(zTempArrayTest.GetUpperBound(0))
        'need to write array to listbox
        'MsgBox("farts")

        Debug.Print(zTempArrayTest(3))

        'Debug.Print()

        'Debug.Print(zGetArrayCount(zTempArrayTest))

        'MsgBox(zTempArrayTest(0))

        lstInput.Sorted = False
        zArrayToListBox(zTempArrayTest, lstInput, 1)

        Dim zTempArrayTest2(lstInput.Items.Count - 1) As String
        'Dim zTempArrayTest2(0) As String
        zListBoxToArray(zTempArrayTest2, lstInput)

        Debug.Print(zTempArrayTest2(1))

        Dim zTmpStr As String
        'zTmpStr = zArrayToString(zTempArrayTest2)
        'zTmpStr = zArrayToString(zTempArrayTest2, " ")
        zTmpStr = zArrayToString(zTempArrayTest2, "-")

        Clipboard.Clear()
        Clipboard.SetText(zTmpStr)

    End Sub
End Class
