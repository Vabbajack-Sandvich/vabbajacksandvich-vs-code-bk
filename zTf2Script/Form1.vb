Imports System.Diagnostics.Eventing
Imports System.IO
Imports System.Net.Mime.MediaTypeNames
Imports System.Xml

Public Class Form1

    Public zBotCmdNameTimerTick As Integer = 0

    Public zbtAliasCall As Integer = 0
    '0 is the default from auto updating check boxes
    '1 is from the button click

    Public zAUUstart As Boolean = False

    Public zDefaultUpdateBotTextboxDisable As Boolean = False


    Public zBCmdStart As Boolean = False
    Public zTf2Team As Integer = 0
    '0 = red
    '1 = blue
    'the default is red
    Public zBotCmdText As String = "taunt"

    Public Function zUpdateBotCommandTextbox(Optional zUbctf As Integer = 0)
        '2026-04-20-06-11-44-AM
        'this breaks things
        'zIterator = -1
        If zDefaultUpdateBotTextboxDisable = True Then Exit Function
        If zBCmdStart = False Then Exit Function
        Dim zTemp As String
        zTemp = zBotCMD()
        txtACmd.Text = zTemp

        If zUbctf = 0 Then
            'might have to remove this
            'or add an auto update check for the alias

            If ckAliasAutoUpdate.Checked = True Then
                zFormatTeleport(zList1, zList2, txtOutput, txtBotCmdName, ckEnumerateBots)
                'use a global to determine where the call for zbtalias came from
                zbtAliasCall = 0
                'this global is for stopping this firing
                'until after the first time its been ran
                'to prevent trying to format an empty teleport list box
                'on start up
                If zAUUstart = True Then
                    zbtAlias()
                Else
                    zAUUstart = True
                End If
            End If
        End If
    End Function

    Private Sub btAddToList_Click(sender As Object, e As EventArgs) Handles btAddToList.Click
        If txtInput.Text = vbNullString Then
            zNotiOut = "Nothing in Input Textbox - btAddToList_Click"
            zNotiTick = 0
            tmNoti.Enabled = True
        End If
        zTextLinesToListbox(txtInput, zList1, 1)
    End Sub

    Private Sub btFormatTeleport_Click(sender As Object, e As EventArgs) Handles btFormatTeleport.Click
        If zList1.Items.Count = 0 Then
            zNotiOut = "No Items In List1 - btFormatTeleport_Click"
            zNotiTick = 0
            tmNoti.Enabled = True
            Exit Sub
        End If
        'uses old bot text box
        'zFormatTeleport(zList1, zList2, txtOutput, txtBotName, ckEnumerateBots)
        'uses new text box with timer and auto formatting
        'have to change format teleport to expect the zero
        'for enumeration
        zFormatTeleport(zList1, zList2, txtOutput, txtBotCmdName, ckEnumerateBots)
        If ckAliasAutoUpdate.Checked = True Then
            zUpdateBotCommandTextbox()
        End If
    End Sub

    Public Sub zbtAlias()


        If zBCmdStart = False Then Exit Sub

        'todo
        'i could use 1 big check listbox for all other commands
        'for whatever order they might come in
        'is whatever the if tree path takes going down the line
        'so having bot spawn first makese sense
        'having other stuff that the would do come after means the bots would be spawned
        'but its mostly so i dont have to type out each command
        'like making the bots swing the wrench or something

        'bot name check
        'adds a 0 to the end if there isnt one
        Dim zBCT As String
        Dim zBotNameStart As Integer
        Dim zBotCmdFirstHalf As String
        Dim zBotCmdSecondHalf As String
        Dim zBCiout As String
        Dim zCycle As Integer
        Dim zCyI As Integer
        Dim zBotName As String
        Dim zListi As Integer
        Dim zMTp As String
        Dim zAii As Integer
        Dim zLine As String
        Dim zLi As Integer
        Dim zLiSo As String
        Dim zTemptxtAcmd As String
        Dim zTempTrim As String
        Dim zTempOutString As String
        Dim zTempList(400) As String

        zBotNameCheck()

        'this is going to be an overried with an exit sub
        'this is for mass teleport commands
        'it uses all the teleport commands in list2
        'and makes an alias for that particular command
        'while enumerating the aliases
        'while then making 1 alias at the end that combines all the other aliases
        'so if i want to move 20 bots at once
        'this is the method

        '=========================================
        '2026-04-20-06-57-03-AM
        'mass teleport overrides and exits
        'for now?
        '=========================================

        If ckMassTeleport.Checked = True Then
            If zList2.Items.Count = 0 Then
                zNotiOut = "No Items In List2 - ckMassTeleport"
                zNotiTick = 0
                tmNoti.Enabled = True
                Exit Sub
            End If
            txtAlias.Clear()
            'non cyclical teleport alias
            'just dumps list 2 in to the alias format
            For zListi = 0 To zList2.Items.Count - 1
                'txtAlias.Text = txtAlias.Text & vbCrLf & "alias " & zQ & txtAliasName.Text & zListi & zQ & " " & zQ & zList2.Items.Item(zListi) & zQ
                If ckEcho.Checked = True Then
                    'txtAlias.Text = txtAlias.Text & vbCrLf & "alias " & zQ & txtAliasName.Text & zListi & zQ & " " & zQ & zList2.Items.Item(zListi) & "; echo " & txtAliasName.Text & zListi & "=" & txtBotCmdName.Text & zQ
                    txtAlias.Text = txtAlias.Text & vbCrLf & "alias " & zQ & txtAliasName.Text & zListi & zQ & " " & zQ & zList2.Items.Item(zListi) & "; echo " & txtAliasName.Text & zListi & zQ
                Else
                    txtAlias.Text = txtAlias.Text & vbCrLf & "alias " & zQ & txtAliasName.Text & zListi & zQ & " " & zQ & zList2.Items.Item(zListi) & zQ
                End If
                zMTp = zMTp & txtAliasName.Text & zListi & "; "
            Next
            zMTp = Mid(zMTp, 1, Len(zMTp) - 1)
            txtAlias.Text = txtAlias.Text & vbCrLf & "alias " & zQ & txtAliasName.Text & "masstp" & zQ & " " & zQ & zMTp & zQ
            Exit Sub
        End If

        If ckTeleportAlias.Checked = False Then
            '2026-05-24-18-43-35-PM
            'echo added and works for this section
            'this is based off the base command box

            'non teleport alias
            If ckCyclicalAlias.Checked = False Then
                'non cyclical
                'just for adding whatever is in the command box
                'for now as far as i can think of, for the other command box
                'empty alias line
                'txtAlias.Text = txtAlias.Text & vbCrLf & "alias " & zQ & txtAliasName.Text & zQ & " " & zQ & zQ

                'just whatever is in the command box
                'txtAlias.Text = txtAlias.Text & vbCrLf & "alias " & zQ & txtAliasName.Text & zQ & " " & zQ & txtACmd.Text & zQ

                If zbtAliasCall = 1 Then
                    'this will only run if the global is set to 1
                    'meaning it came from the button click

                    'for incrimenting
                    txtAliasIncrement.Text = zNumFilter(txtAliasIncrement.Text)
                    If txtAliasIncrement.Text = vbNullString Then
                        txtAliasIncrement.Text = "0"
                    End If

                    'zAii = CInt(txtAliasIncrement.Text)
                    'zIterator = zIterator + 1
                    zAii = zIterator

                    'txtAlias.Text = txtAlias.Text & vbCrLf & "alias " & zQ & txtAliasName.Text & zAii & zQ & " " & zQ & txtACmd.Text & zQ
                    'add to list 3
                    'then populate the alias text box with entries
                    'If zAii = 0 Then
                    '    If ckBotKickAllFirst.Checked = True Then
                    '        'zLine = "alias " & zQ & txtAliasName.Text & zAii & zQ & " " & zQ & "bot_kick all; " & txtACmd.Text & zQ
                    '        If ckEcho.Checked = True Then
                    '            zLine = "alias " & zQ & txtAliasName.Text & zAii & zQ & " " & zQ & "bot_kick all; " & txtACmd.Text & "; echo " & txtAliasName.Text & zAii & zQ
                    '        Else
                    '            zLine = "alias " & zQ & txtAliasName.Text & zAii & zQ & " " & zQ & txtACmd.Text & zQ
                    '        End If
                    '    Else
                    '        If ckEcho.Checked = True Then
                    '            zLine = "alias " & zQ & txtAliasName.Text & zAii & zQ & " " & zQ & txtACmd.Text & "; echo " & txtAliasName.Text & zAii & zQ
                    '        Else
                    '            zLine = "alias " & zQ & txtAliasName.Text & zAii & zQ & " " & zQ & txtACmd.Text & zQ
                    '        End If
                    '    End If
                    'Else
                    '    If ckEcho.Checked = True Then
                    '        zLine = "alias " & zQ & txtAliasName.Text & zAii & zQ & " " & zQ & txtACmd.Text & "; echo " & txtAliasName.Text & zAii & zQ
                    '    Else
                    '        zLine = "alias " & zQ & txtAliasName.Text & zAii & zQ & " " & zQ & txtACmd.Text & zQ
                    '    End If
                    'End If

                    If zAii = 0 Then
                        If ckBotKickAllFirst.Checked = True Then
                            zLine = "alias " & zQ & txtAliasName.Text & zAii & zQ & " " & zQ & "bot_kick all; " & txtACmd.Text & zQ
                        Else
                            zLine = "alias " & zQ & txtAliasName.Text & zAii & zQ & " " & zQ & txtACmd.Text & zQ
                        End If
                    Else
                        zLine = "alias " & zQ & txtAliasName.Text & zAii & zQ & " " & zQ & txtACmd.Text & zQ
                    End If

                    zList3.Items.Add(zLine)

                    'this does only single digit trim

                    'potential enumator global iterator
                    'after this one is done

                    'If zbtAliasCall = 1 Then
                    'If ckTeleportAlias.Checked = False Then
                    'non teleport alias
                    'kCyclicalAlias.Checked = False Then

                    If ckEnumerateBots.Checked = True Then
                        If zList3.Items.Count <> 0 Then
                            For zLi = 0 To zList3.Items.Count - 1
                                zTemptxtAcmd = zList3.Items.Item(zLi)
                                zTempTrim = Mid(txtBotCmdName.Text, 1, Len(txtBotCmdName.Text) - 1)
                                zTempOutString = Replace(zTemptxtAcmd, txtBotCmdName.Text, zTempTrim & zLi)
                                zTempList(zLi) = zTempOutString
                            Next

                            Dim zTempCount As Integer
                            zTempCount = zList3.Items.Count

                            zList3.Items.Clear()

                            For zLi = 0 To zTempCount - 1
                                zList3.Items.Add(zTempList(zLi))
                                zTempList(zLi) = vbNullString
                            Next
                        End If
                    End If

                    If zList3.Items.Count <> 0 Then
                        For zLi = 0 To zList3.Items.Count - 1
                            zLiSo = zLiSo & vbCrLf & zList3.Items.Item(zLi)
                        Next
                    End If

                    txtAlias.Clear()
                    txtAlias.Text = zLiSo

                    zAii = zAii + 1
                    txtAliasIncrement.Text = zAii.ToString
                ElseIf zbtAliasCall = 0 Then
                    'specifically 0 because thats the update from check boxes
                    'this runs for check box updates
                    If zList3.Items.Count > 0 Then
                        For zLi = 0 To zList3.Items.Count - 1
                            zLiSo = zLiSo & vbCrLf & zList3.Items.Item(zLi)
                        Next
                        txtAlias.Clear()
                        txtAlias.Text = zLiSo
                    End If
                End If
            Else

                '2026-05-24-19-00-40-PM
                'have to add echo for this section

                zIterator = -1
                'this is for cyclical alias

                'default is 1 cycles otherwise whats the point
                txtAlias.Text = ""
                'If txtACmd.Text = vbNullString Then
                ' txtACmd.Text = "bot "
                ' End If
                txtACycles.Text = zNumFilter(txtACycles.Text)
                If txtACycles.Text = vbNullString Then
                    txtACycles.Text = "1"
                End If
                zCycle = CInt(txtACycles.Text)
                If zCycle < 2 Then
                    txtACycles.Text = "1"
                    zCycle = 1
                End If
                If zCycle > 100 Then
                    txtACycles.Text = "100"
                    zCycle = 100
                End If
                'this assumes that bot0 is most likely used
                'or that its going to be bot name 0 at the end
                zBCT = txtACmd.Text
                If ckBot.Checked = True And ckBotName.Checked = True Then
                    If zBCT <> vbNullString Then
                        zBotName = Mid(txtBotCmdName.Text, 1, Len(txtBotCmdName.Text) - 1)
                        zBotNameStart = InStr(1, zBCT, txtBotCmdName.Text)
                        If zBotNameStart = 0 Then
                            zNotiOut = "Command Format Problem - zBotNameStart"
                            zNotiTick = 0
                            tmNoti.Enabled = True
                            Exit Sub
                        End If
                        zBotCmdFirstHalf = Mid(zBCT, 1, zBotNameStart - 1)
                        zBotCmdSecondHalf = Mid(zBCT, zBotNameStart + Len(txtBotCmdName.Text), Len(zBCT))
                        'left off here 2026-04-19-20-46-56-PM
                    End If
                End If

                For zCyI = 0 To zCycle
                    'iterate the bot number here
                    If ckBot.Checked = True And ckBotName.Checked = True Then
                        If zBCT <> vbNullString Then
                            If ckEnumerateBots.Checked = True Then
                                zBCiout = zBotCmdFirstHalf & zBotName & zCyI & zBotCmdSecondHalf
                            Else
                                zBCiout = zBotCmdFirstHalf & txtBotCmdName.Text & zBotCmdSecondHalf
                            End If
                        Else
                            zBCiout = zBCT
                        End If
                    Else
                        'no bot command first
                        zBCiout = zBCT
                    End If
                    If zCyI = zCycle Then
                        'last one
                        'working version
                        'txtAlias.Text = txtAlias.Text & vbCrLf & "alias " & zQ & txtAliasName.Text & zCyI & zQ & " " & zQ & txtACmd.Text & "; alias " & txtAliasName.Text & "mod " & txtAliasName.Text & "0" & zQ
                        txtAlias.Text = txtAlias.Text & vbCrLf & "alias " & zQ & txtAliasName.Text & zCyI & zQ & " " & zQ & zBCiout & "; alias " & txtAliasName.Text & "mod " & txtAliasName.Text & "0" & zQ
                    Else
                        'working version
                        'txtAlias.Text = txtAlias.Text & vbCrLf & "alias " & zQ & txtAliasName.Text & zCyI & zQ & " " & zQ & txtACmd.Text & "; alias " & txtAliasName.Text & "mod " & txtAliasName.Text & zCyI + 1 & zQ
                        If ckBotKickAllFirst.Checked = True Then
                            If zCyI = 0 Then
                                txtAlias.Text = txtAlias.Text & vbCrLf & "alias " & zQ & txtAliasName.Text & zCyI & zQ & " " & zQ & "bot_kick all; " & zBCiout & "; alias " & txtAliasName.Text & "mod " & txtAliasName.Text & zCyI + 1 & zQ
                            Else
                                txtAlias.Text = txtAlias.Text & vbCrLf & "alias " & zQ & txtAliasName.Text & zCyI & zQ & " " & zQ & zBCiout & "; alias " & txtAliasName.Text & "mod " & txtAliasName.Text & zCyI + 1 & zQ
                            End If
                        Else
                            txtAlias.Text = txtAlias.Text & vbCrLf & "alias " & zQ & txtAliasName.Text & zCyI & zQ & " " & zQ & zBCiout & "; alias " & txtAliasName.Text & "mod " & txtAliasName.Text & zCyI + 1 & zQ
                        End If

                    End If
                Next
            End If
        Else
            'teleport alias
            'was going to add the add to list from text box thing
            'but i decided against it to keep the two things seperate
            'same for the format button itself
            'but the line below is easier
            'run the teleport format update
            zFormatTeleport(zList1, zList2, txtOutput, txtBotCmdName, ckEnumerateBots)
            If zList2.Items.Count = 0 Then
                zNotiOut = "No Items In List2 - zbtAlias - ckTeleportAlias"
                zNotiTick = 0
                tmNoti.Enabled = True
                Exit Sub
            End If
            txtAlias.Text = ""
            If ckCyclicalAlias.Checked = False Then
                'non cyclical teleport alias
                'just dumps list 2 in to the alias format
                For zListi = 0 To zList2.Items.Count - 1
                    txtAlias.Text = txtAlias.Text & vbCrLf & "alias " & zQ & txtAliasName.Text & zListi & zQ & " " & zQ & zList2.Items.Item(zListi) & zQ
                Next
            Else
                'cyclical teleport alias
                'dumps list 2 in to the cyclical alias format
                'this part is for bot name iteration
                'always going to enumerate bot names using the bot command name text box
                For zListi = 0 To zList2.Items.Count - 1
                    zBCT = zList2.Items.Item(zListi)
                    If zBCT <> vbNullString Then
                        Dim zTpASpace1 As String
                        Dim zTpASpace2 As String
                        zBotName = Mid(txtBotCmdName.Text, 1, Len(txtBotCmdName.Text) - 1)
                    End If
                    If zListi <> zList2.Items.Count - 1 Then
                        If ckEcho.Checked = True Then
                            txtAlias.Text = txtAlias.Text & vbCrLf & "alias " & zQ & txtAliasName.Text & zListi & zQ & " " & zQ & zList2.Items.Item(zListi) & "; alias " & txtAliasName.Text & "mod " & txtAliasName.Text & zListi + 1 & "; echo " & txtAliasName.Text & zListi + 1 & zQ
                        Else
                            txtAlias.Text = txtAlias.Text & vbCrLf & "alias " & zQ & txtAliasName.Text & zListi & zQ & " " & zQ & zList2.Items.Item(zListi) & "; alias " & txtAliasName.Text & "mod " & txtAliasName.Text & zListi + 1 & zQ
                        End If
                    Else
                        If ckEcho.Checked = True Then
                            txtAlias.Text = txtAlias.Text & vbCrLf & "alias " & zQ & txtAliasName.Text & zListi & zQ & " " & zQ & zList2.Items.Item(zListi) & "; alias " & txtAliasName.Text & "mod " & txtAliasName.Text & "0" & "; echo " & txtAliasName.Text & zListi & zQ
                        Else
                            txtAlias.Text = txtAlias.Text & vbCrLf & "alias " & zQ & txtAliasName.Text & zListi & zQ & " " & zQ & zList2.Items.Item(zListi) & "; alias " & txtAliasName.Text & "mod " & txtAliasName.Text & "0" & zQ
                        End If
                    End If
                Next
                If ckEcho.Checked = True Then
                    txtAlias.Text = txtAlias.Text & vbCrLf & "alias " & zQ & txtAliasName.Text & "mod" & zQ & " " & zQ & txtAliasName.Text & "0" & "; echo " & txtAliasName.Text & "mod" & zQ
                Else
                    txtAlias.Text = txtAlias.Text & vbCrLf & "alias " & zQ & txtAliasName.Text & "mod" & zQ & " " & zQ & txtAliasName.Text & "0" & zQ
                End If
            End If
        End If
        'reset global to 0
        zbtAliasCall = 0
    End Sub

    Private Sub btAlias_Click(sender As Object, e As EventArgs) Handles btAlias.Click
        zBotNameCheck()
        zUpdateBotCommandTextbox()
        zBotCmdNameTimerTick = 0
        zFormatTeleport(zList1, zList2, txtOutput, txtBotCmdName, ckEnumerateBots)
        tmBotNameTextUpdate.Enabled = False
        lbCheckTime.Text = 10 - zBotCmdNameTimerTick

        zbtAliasCall = 1
        zbtAlias()
    End Sub

    Private Sub cklbBCMDClass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cklbBCMDClass.SelectedIndexChanged

    End Sub

    Private Sub cklbBCMDClass_MouseUp(sender As Object, e As MouseEventArgs) Handles cklbBCMDClass.MouseUp
        Dim zCiC As Boolean
        Dim zLSi As Integer
        Dim zLi As Integer
        zLSi = cklbBCMDClass.SelectedIndex
        zCiC = cklbBCMDClass.GetItemChecked(zLSi)
        If zCiC = True Then
            For zLi = 0 To cklbBCMDClass.Items.Count - 1
                If zLi <> zLSi Then
                    cklbBCMDClass.SetItemChecked(zLi, False)
                End If
            Next
        End If
    End Sub

    Private Sub cklbBCMDClass_MouseDown(sender As Object, e As MouseEventArgs) Handles cklbBCMDClass.MouseDown
        ckBCMDClass.Checked = True
        cklbBCMDClass.SetItemChecked(cklbBCMDClass.SelectedIndex, True)
        'set the global to the new class
        zTf2Class = cklbBCMDClass.Items.Item(cklbBCMDClass.SelectedIndex)
        zUpdateBotCommandTextbox()
    End Sub

    Private Sub txtBotCmdName_TextChanged(sender As Object, e As EventArgs) Handles txtBotCmdName.TextChanged
        zIterator = -1
        If zBCmdStart = False Then Exit Sub
        zBotCmdNameTimerTick = 0
        tmBotNameTextUpdate.Enabled = True
    End Sub

    Private Sub ckTRed_CheckedChanged(sender As Object, e As EventArgs) Handles ckTRed.CheckedChanged
        zIterator = -1
        If zBCmdStart = False Then Exit Sub
        ckBCMDTeam.Checked = True
        If ckTRed.Checked = True Then
            zTf2Team = 0
        Else
            zTf2Team = 1
        End If
        zUpdateBotCommandTextbox()
    End Sub

    Private Sub ckTRed_ControlRemoved(sender As Object, e As ControlEventArgs) Handles ckTRed.ControlRemoved

    End Sub

    Private Sub ckTBlue_CheckedChanged(sender As Object, e As EventArgs) Handles ckTBlue.CheckedChanged
        zIterator = -1
        If zBCmdStart = False Then Exit Sub
        ckBCMDTeam.Checked = True
        If ckTBlue.Checked = True Then
            zTf2Team = 1
        Else
            zTf2Team = 0
        End If
        zUpdateBotCommandTextbox()
    End Sub

    Private Sub ckTBlue_MouseUp(sender As Object, e As MouseEventArgs) Handles ckTBlue.MouseUp
        ckTRed.Checked = False
        ckTBlue.Checked = True
    End Sub

    Private Sub ckTRed_MouseClick(sender As Object, e As MouseEventArgs) Handles ckTRed.MouseClick

    End Sub

    Private Sub ckTBlue_MouseClick(sender As Object, e As MouseEventArgs) Handles ckTBlue.MouseClick

    End Sub

    Private Sub ckTBlue_MouseDown(sender As Object, e As MouseEventArgs) Handles ckTBlue.MouseDown

    End Sub

    Private Sub ckTRed_MouseDown(sender As Object, e As MouseEventArgs) Handles ckTRed.MouseDown

    End Sub

    Private Sub ckTRed_MouseUp(sender As Object, e As MouseEventArgs) Handles ckTRed.MouseUp
        ckTRed.Checked = True
        ckTBlue.Checked = False
    End Sub

    Public Function zBotCmd1or0BaseString(zB1 As String, zI As Integer, Optional zBn As String = "") As String
        Dim zBase As String
        'zb1 = just the command name
        'zi the zBoCi integer for the corresoponding entry in the 1 or 0 checklist box
        'optional zBn string is the bot name
        'if its exlcuded it will only do a the command with a space
        'this is only intended for simple 1 or 0 all or bot name commands
        'this saves me from haveing to write out this same thing for every 1 or 0
        'the same if tree every time
        'im the bot name as an obtional
        'zBCout = zBCout & "bot_kick " & zBotName & " " & zBotCmdOck(zBoCi) & zBcmdSemiColon
        If zBotCmdOck(zI) = 1 Then
            'if the 1 or 0 box is checked it will use all
            zBase = zB1 & " all"
        Else
            If zBn = "" Then
                zBase = zB1 & " "
            Else
                zBase = zB1 & " " & zBn
            End If
        End If
        zBotCmd1or0BaseString = zBase
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'normal form size 1199, 1106
        'shrunk size 
        Me.Height = 900
        'Me.Width = 1220
        Me.Width = 1550
        Me.CenterToScreen()
        'set the class check box to engineer
        'zTf2Class is engineer by default
        cklbBCMDClass.SetItemChecked(1, True)
        'set the othercommand listbox to have the bot state be the same
        'between checkboxes
        cklbOtherBotCmd.SetItemChecked(0, True)
        'set the notification output to nothing
        lbNotiOut.Text = ""
        'fswConlog.BeginInit()
        'set the tf weapon to wrech
        'cklbTfWeaponList.SetItemChecked(0, True)
        txtACmd.AutoWordSelection = True
        txtACmd.RightMargin = txtACmd.Width - 100
        'txtACmd.ZoomFactor = 2.0F
        'set the yaw offset box 180 to checked
        cklbYawOffset.SetItemChecked(4, True)
    End Sub
    Private Sub ckBot_CheckedChanged(sender As Object, e As EventArgs) Handles ckBot.CheckedChanged
        zIterator = -1
        If zBCmdStart = False Then Exit Sub
        'cklbOtherBotCmd.SetItemChecked(0, ckBot.Checked)
        zUpdateOtherBotCmdListAnd1or0List(0, ckBot, 0)
        zUpdateBotCommandTextbox()
    End Sub

    Private Sub ckBotName_CheckedChanged(sender As Object, e As EventArgs) Handles ckBotName.CheckedChanged
        zIterator = -1
        zUpdateBotCommandTextbox()
    End Sub

    Private Sub ckBCMDTeam_CheckedChanged(sender As Object, e As EventArgs) Handles ckBCMDTeam.CheckedChanged
        zIterator = -1
        zUpdateBotCommandTextbox()
    End Sub

    Private Sub ckBCmdTp_CheckedChanged(sender As Object, e As EventArgs) Handles ckBCmdTp.CheckedChanged
        zIterator = -1
        zUpdateBotCommandTextbox()
    End Sub

    Private Sub ckBCMDClass_CheckedChanged(sender As Object, e As EventArgs) Handles ckBCMDClass.CheckedChanged
        zUpdateBotCommandTextbox()
    End Sub
    Private Sub tmStart_Tick(sender As Object, e As EventArgs) Handles tmStart.Tick
        'set this to true to allow zbotcmd to work
        zBCmdStart = True
        zUpdateBotCommandTextbox()
        zTextLinesToListbox(txtInput, zList1, 1)
        zFormatTeleport(zList1, zList2, txtOutput, txtBotCmdName, ckEnumerateBots)
        zbtAlias()
        tmStart.Enabled = False

    End Sub

    Private Sub tmBotNameTextUpdate_Tick(sender As Object, e As EventArgs) Handles tmBotNameTextUpdate.Tick
        zBotCmdNameTimerTick = zBotCmdNameTimerTick + 1
        If zBotCmdNameTimerTick = 10 Then
            zBotNameCheck()
            zUpdateBotCommandTextbox()
            zBotCmdNameTimerTick = 0
            'If ckTeleportAlias.Checked = True Then
            'if the teleport alias check box is checked
            're format the stuff in the teleport box
            zFormatTeleport(zList1, zList2, txtOutput, txtBotCmdName, ckEnumerateBots)
            'End If
            zbtAlias()
            tmBotNameTextUpdate.Enabled = False
        End If
        lbCheckTime.Text = 10 - zBotCmdNameTimerTick
    End Sub

    Private Sub txtBotCmdName_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBotCmdName.KeyUp
        If e.KeyCode = 13 Then
            'enter pressed key up
            'same code as timer off
            zBotNameCheck()
            zUpdateBotCommandTextbox()
            zBotCmdNameTimerTick = 0
            'If ckTeleportAlias.Checked = True Then
            'if the teleport alias check box is checked
            're format the stuff in the teleport box
            zFormatTeleport(zList1, zList2, txtOutput, txtBotCmdName, ckEnumerateBots)
            'End If
            zbtAlias()
            tmBotNameTextUpdate.Enabled = False
            lbCheckTime.Text = 10 - zBotCmdNameTimerTick
        End If
    End Sub

    Private Sub ckEnumerateBots_CheckedChanged(sender As Object, e As EventArgs) Handles ckEnumerateBots.CheckedChanged
        zIterator = -1
        zUpdateBotCommandTextbox()
        zFormatTeleport(zList1, zList2, txtOutput, txtBotCmdName, ckEnumerateBots)
        zbtAlias()
    End Sub

    Private Sub ckTeleportAlias_CheckedChanged(sender As Object, e As EventArgs) Handles ckTeleportAlias.CheckedChanged
        zIterator = -1
        zFormatTeleport(zList1, zList2, txtOutput, txtBotCmdName, ckEnumerateBots)
        If ckTeleportAlias.Checked = True And ckCyclicalAlias.Checked = False Then
            zbtAlias()
        ElseIf ckTeleportAlias.Checked = True And ckCyclicalAlias.Checked = True Then
            zbtAlias()
        ElseIf ckTeleportAlias.Checked = False And ckCyclicalAlias.Checked = True Then
            zbtAlias()
        ElseIf ckTeleportAlias.Checked = False And ckCyclicalAlias.Checked = False Then
            txtAlias.Clear()
            txtAliasIncrement.Text = "0"
            zbtAlias()
            txtAliasIncrement.Text = "0"
        End If
        zUpdateBotCommandTextbox()
    End Sub

    Private Sub zList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles zList1.SelectedIndexChanged

    End Sub

    Private Sub zList1_DoubleClick(sender As Object, e As EventArgs) Handles zList1.DoubleClick
        If zList1.Items.Count = 0 Then Exit Sub
        Dim zItem As String
        zItem = zList1.Items.Item(zList1.SelectedIndex)
        If zItem <> vbNullString Then
            Clipboard.Clear()
            Clipboard.SetText(zItem)
            zNotiOut = "Copied To Clipboard"
            zNotiTick = 0
            lbNotiOut.Text = "5 - " & zNotiOut
            tmNoti.Enabled = True
        End If
    End Sub

    Private Sub zList2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles zList2.SelectedIndexChanged
        If zList2.Items.Count = 0 Then Exit Sub
        Dim zItem As String
        zItem = zList2.Items.Item(zList2.SelectedIndex)
        If zItem <> vbNullString Then
            Clipboard.Clear()
            Clipboard.SetText(zItem)
            zNotiOut = "Copied To Clipboard"
            zNotiTick = 0
            lbNotiOut.Text = "5 - " & zNotiOut
            tmNoti.Enabled = True
        End If
    End Sub

    Public zNotiTick As Integer = 0
    Public zNotiOut As String

    Private Sub tmNoti_Tick(sender As Object, e As EventArgs) Handles tmNoti.Tick
        zNotiTick = zNotiTick + 1
        If zNotiTick = 5 Then
            zNotiTick = 0
            zNotiOut = ""
            tmNoti.Enabled = False
            lbNotiOut.Text = ""
        Else
            lbNotiOut.Text = 5 - zNotiTick & " - " & zNotiOut
        End If
    End Sub

    Public Sub zUpdateOtherBotCmdListAnd1or0List(zIndex As Integer, zCk As CheckBox, Optional z1or0 As Integer = -1)
        If zBCmdStart = False Then Exit Sub
        cklbOtherBotCmd.SetItemChecked(zIndex, zCk.Checked)
        If z1or0 <> -1 Then
            cklbBotCmd1or0.SetItemChecked(zIndex, z1or0)
        Else
            cklbBotCmd1or0.SetItemChecked(zIndex, zCk.Checked)
        End If
        cklbOtherBotCmd.SetSelected(zIndex, True)
        cklbBotCmd1or0.SetSelected(zIndex, True)
        cklbBotCmd1or0.TopIndex = cklbOtherBotCmd.TopIndex
    End Sub

    Public Sub zUpdateOtherBotCmdListAnd1or0ListManualValue(zIndex As Integer, zCk As Boolean, zCk2 As Boolean)
        If zBCmdStart = False Then Exit Sub
        cklbOtherBotCmd.SetItemChecked(zIndex, zCk)
        cklbBotCmd1or0.SetItemChecked(zIndex, zCk2)
        cklbOtherBotCmd.SetSelected(zIndex, True)
        cklbBotCmd1or0.SetSelected(zIndex, True)
        cklbBotCmd1or0.TopIndex = cklbOtherBotCmd.TopIndex
    End Sub

    Private Sub ckBotKickAllFirst_CheckedChanged(sender As Object, e As EventArgs) Handles ckBotKickAllFirst.CheckedChanged
        zIterator = -1
        '12   bot_kick
        'zUpdateOtherBotCmdListAnd1or0List(12, ckBotKickAllFirst)
        'decided to seperate the other kick command
        zUpdateBotCommandTextbox()
    End Sub

    Private Sub txtACycles_KeyUp(sender As Object, e As KeyEventArgs) Handles txtACycles.KeyUp
        If e.KeyCode = 13 Then
            zbtAlias()
        End If
    End Sub

    Private Sub btClear_Click(sender As Object, e As EventArgs) Handles btClear.Click
        txtInput.Clear()
        zList1.Items.Clear()
        txtOutput.Clear()
        zList2.Items.Clear()
        txtACycles.Text = "1"
        txtACmd.Clear()
        txtAlias.Clear()
    End Sub

    Public Sub zDefaultSet()
        zDefaultUpdateBotTextboxDisable = True
        zAUUstart = False
        Dim zTxtInput As String
        zTxtInput = "setpos -431.827515 -1490.849609 331.031311;setang 7.523998 -138.771698 0.000000"
        zTxtInput = zTxtInput & vbCrLf & "setpos -566.792969 -1556.649658 331.031311;setang 10.031998 159.980255 0.000000"
        zTxtInput = zTxtInput & vbCrLf & "setpos -659.785095 -1485.778809 331.031311;setang 12.143997 90.416214 0.000000"
        zTxtInput = zTxtInput & vbCrLf & "setpos -619.155823 -1385.716675 331.031311;setang 13.463997 22.172215 0.000000"
        zTxtInput = zTxtInput & vbCrLf & "setpos -466.910309 -1379.900391 331.031311;setang 13.067997 -19.803782 0.000000"
        zTxtInput = zTxtInput & vbCrLf & "setpos -379.412048 -1410.921875 331.031311;setang 13.463997 -32.211781 0.000000"
        txtInput.Text = zTxtInput
        ckBot.Checked = True
        ckBotKickAllFirst.Checked = True
        ckBotName.Checked = True
        txtBotCmdName.Text = "bot0"
        ckTeleportAlias.Checked = True
        ckEnumerateBots.Checked = True
        ckBCMDTeam.Checked = True
        ckTRed.Checked = True
        zTf2Team = 0
        ckTBlue.Checked = False
        ckBCmdTp.Checked = True
        ckAliasAutoUpdate.Checked = True
        ckEnumerateCmdListAliases.Checked = True
        ckEnumerateCmdListBots.Checked = True
        ckBotCmdHurtDamage.Checked = True
        Dim zLi As Integer
        For zLi = 0 To cklbBCMDClass.Items.Count - 1
            cklbBCMDClass.SetItemChecked(zLi, False)
        Next
        cklbBCMDClass.SetItemChecked(1, True)
        For zLi = 0 To cklbOtherBotCmd.Items.Count - 1
            cklbOtherBotCmd.SetItemChecked(zLi, False)
        Next
        cklbOtherBotCmd.SetItemChecked(0, True)
        lbNotiOut.Text = ""
        ckCyclicalAlias.Checked = True
        txtAliasName.Text = "Alias"
        zTf2Class = "engineer"
        txtAliasIncrement.Text = "0"
        ckMassTeleport.Checked = False
        zDefaultUpdateBotTextboxDisable = False
        cklbYawOffset.SetItemChecked(4, True)

        tmStart.Enabled = True

    End Sub

    Private Sub btDefault_Click(sender As Object, e As EventArgs) Handles btDefault.Click
        zDefaultSet()
    End Sub

    Private Sub cklbOtherBotCmd_MouseUp(sender As Object, e As MouseEventArgs) Handles cklbOtherBotCmd.MouseUp
        If cklbOtherBotCmd.GetItemChecked(0) = True Then
            ckBot.Checked = True
        Else
            ckBot.Checked = False
        End If
        If cklbOtherBotCmd.SelectedIndex <> -1 Then
            cklbBotCmd1or0.SetSelected(cklbOtherBotCmd.SelectedIndex, True)
            cklbBotCmd1or0.TopIndex = cklbOtherBotCmd.TopIndex
        End If
        zUpdateBotCommandTextbox()
    End Sub

    Private Sub btClearCommandBox_Click(sender As Object, e As EventArgs) Handles btClearCommandBox.Click
        txtACmd.Clear()
    End Sub

    Private Sub btClearAliasBox_Click(sender As Object, e As EventArgs) Handles btClearAliasBox.Click
        txtAlias.Clear()
        txtAliasIncrement.Text = "0"
    End Sub

    Private Sub ckCyclicalAlias_CheckedChanged(sender As Object, e As EventArgs) Handles ckCyclicalAlias.CheckedChanged
        zIterator = -1
        zFormatTeleport(zList1, zList2, txtOutput, txtBotCmdName, ckEnumerateBots)
        If ckTeleportAlias.Checked = True And ckCyclicalAlias.Checked = False Then
            zbtAlias()
        ElseIf ckTeleportAlias.Checked = True And ckCyclicalAlias.Checked = True Then
            zbtAlias()
        ElseIf ckTeleportAlias.Checked = False And ckCyclicalAlias.Checked = True Then
            zbtAlias()
        ElseIf ckTeleportAlias.Checked = False And ckCyclicalAlias.Checked = False Then
            txtAlias.Clear()
            txtAliasIncrement.Text = "0"
            zbtAlias()
            txtAliasIncrement.Text = "0"
        End If
    End Sub

    Private Sub ckMassTeleport_CheckedChanged(sender As Object, e As EventArgs) Handles ckMassTeleport.CheckedChanged
        zIterator = -1
        zUpdateBotCommandTextbox()
        zbtAlias()
    End Sub

    Private Sub btzList3Clear_Click(sender As Object, e As EventArgs) Handles btzList3Clear.Click
        zList3.Items.Clear()
    End Sub

    Private Sub btSetCyclesTo1_Click(sender As Object, e As EventArgs) Handles btSetCyclesTo1.Click
        txtACycles.Text = "1"
    End Sub

    Private Sub btSetAliasIncrimentTo0_Click(sender As Object, e As EventArgs) Handles btSetAliasIncrimentTo0.Click
        txtAliasIncrement.Text = "0"
    End Sub

    Private Sub btMassAlias_Click(sender As Object, e As EventArgs) Handles btMassAlias.Click
        '2026-05-22-09-28-58-AM
        'i cant / wont remember this
        'changing this to just setting these to true
        'instead of exiting
        'old
        'If ckCyclicalAlias.Checked = True Then Exit Sub
        'If ckMassTeleport.Checked = True Then Exit Sub
        'If ckTeleportAlias.Checked = True Then Exit Sub

        'this exit needs to be here
        If zList3.Items.Count = 0 Then Exit Sub

        ckCyclicalAlias.Checked = True
        ckMassTeleport.Checked = True
        ckTeleportAlias.Checked = True


        Dim zLi As Integer
        Dim zLiSo As String
        Dim zMass As String
        Dim zMout As String

        For zLi = 0 To zList3.Items.Count - 1
            'txtAlias.Text = txtAlias.Text & vbCrLf & "alias " & zQ & txtAliasName.Text & zLi & zQ & " " & zQ & zList3.Items.Item(zLi) & zQ
            'txtAlias.Text = txtAlias.Text & vbCrLf & "alias " & zQ & txtAliasName.Text & zLi & zQ & " " & zQ & zList3.Items.Item(zLi) & zQ
            zMass = zMass & txtAliasName.Text & zLi & "; "
        Next

        zMass = Mid(zMass, 1, Len(zMass) - 1)
        zMout = "alias " & zQ & txtAliasName.Text & "masscmd" & zQ & " " & zQ & zMass & zQ


        txtAlias.Text = txtAlias.Text & vbCrLf & zMout

        '2026-05-22-09-36-00-AM
        'adding the mass teleport line to the list box which i forgot last time for some reason
        zList3.Items.Add(zMout)

        'below adds to the list, then sets the textbox to whats in the list
        'i really just need it to add the command to whatever is in the text box
        'zList3.Items.Add(zMout)

        'If zList3.Items.Count > 0 Then
        'For zLi = 0 To zList3.Items.Count - 1
        'zLiSo = zLiSo & vbCrLf & zList3.Items.Item(zLi)
        'Next
        'End If
        'txtAlias.Clear()
        'txtAlias.Text = zLiSo


    End Sub

    Private Sub btAliasTextToCmdList_Click(sender As Object, e As EventArgs) Handles btAliasTextToCmdList.Click
        If txtAlias.Text = vbNullString Then
            zNotiOut = "Nothing in Alias Input Textbox - btAliasTextToCmdList_Click"
            zNotiTick = 0
            tmNoti.Enabled = True
        End If
        zTextLinesToListbox(txtAlias, zList3, 1)
    End Sub

    Private Sub zList3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles zList3.SelectedIndexChanged

    End Sub

    Private Sub zList3_KeyUp(sender As Object, e As KeyEventArgs) Handles zList3.KeyUp
        If zList3.Items.Count > 0 And zList3.SelectedIndex <> -1 Then
            If e.KeyValue = Keys.Delete Then
                'MsgBox("farts")
                zList3.Items.RemoveAt(zList3.SelectedIndex)
            End If
        End If
    End Sub

    Private Sub btCmdListToAliasText_Click(sender As Object, e As EventArgs) Handles btCmdListToAliasText.Click
        If zList3.Items.Count = 0 Then Exit Sub

        Dim zLi As Integer
        Dim zLiSo As String

        For zLi = 0 To zList3.Items.Count - 1
            zLiSo = zLiSo & vbCrLf & zList3.Items.Item(zLi)
        Next

        txtAlias.Clear()
        txtAlias.Text = zLiSo
    End Sub

    Private Sub btAddAliasTextToCmdList_Click(sender As Object, e As EventArgs) Handles btAddAliasTextToCmdList.Click
        If txtAlias.Text = vbNullString Then
            zNotiOut = "Nothing in Alias Input Textbox - btAddAliasTextToCmdList_Click"
            zNotiTick = 0
            tmNoti.Enabled = True
        End If
        zTextLinesToListbox(txtAlias, zList3, 0)
    End Sub

    Private Sub btCopyCmdList_Click(sender As Object, e As EventArgs) Handles btCopyCmdList.Click
        If zList3.Items.Count = 0 Then Exit Sub

        Dim zLi As Integer
        Dim zLiSo As String

        For zLi = 0 To zList3.Items.Count - 1
            zLiSo = zLiSo & vbCrLf & zList3.Items.Item(zLi)
        Next

        'txtAlias.Clear()
        'txtAlias.Text = zLiSo
        Clipboard.Clear()
        Clipboard.SetText(zLiSo)
    End Sub

    Private Sub btAlias2_Click(sender As Object, e As EventArgs) Handles btAlias2.Click
        'zIterator = -1
        zBotNameCheck()
        zUpdateBotCommandTextbox()
        zBotCmdNameTimerTick = 0
        zFormatTeleport(zList1, zList2, txtOutput, txtBotCmdName, ckEnumerateBots)

        tmBotNameTextUpdate.Enabled = False
        lbCheckTime.Text = 10 - zBotCmdNameTimerTick

        zbtAliasCall = 1
        zbtAlias()
    End Sub

    Private Sub cklbBCMDClass_KeyUp(sender As Object, e As KeyEventArgs) Handles cklbBCMDClass.KeyUp
        If e.KeyCode = 13 Then
            zbtAliasCall = 1
            zbtAlias()
        End If
    End Sub

    Private Sub btEnumerateBotInCommandList_Click(sender As Object, e As EventArgs) Handles btEnumerateBotInCommandList.Click

        If ckEnumerateCmdListBots.Checked = False And ckEnumerateCmdListAliases.Checked = False Then Exit Sub

        Dim zAii As Integer
        Dim zLi As Integer
        Dim zLiSo As String
        Dim zTemptxtAcmd As String
        Dim zTempTrim As String
        Dim zTempOutString As String
        Dim zTempList(400) As String

        Dim zTempWordList(400) As String
        Dim zTempSpaceLocations(400) As Integer
        Dim zLenTempTxtAcmd As Integer
        Dim zWi As Integer
        Dim zFindSpace As String
        Dim zWiCounter As Integer
        Dim zWordListI As Integer
        Dim zWordTemp As String

        Dim zBotCmdU As Integer
        Dim zBotCmdSpace As Integer
        Dim zBotCmdNameCheck As Integer
        Dim zBotCmdUCheck As Integer
        Dim zBotNameTrim2 As String

        Dim zWordCount As Integer
        Dim zTempLineString As String

        Dim zTempCount As Integer

        If zList3.Items.Count <> 0 Then
            For zLi = 0 To zList3.Items.Count - 1
                'this enumerates the bots
                'saving the old version
                'zTemptxtAcmd = zList3.Items.Item(zLi)
                'zTempTrim = Mid(txtBotCmdName.Text, 1, Len(txtBotCmdName.Text) - 1)
                'zTempOutString = Replace(zTemptxtAcmd, txtBotCmdName.Text, zTempTrim & zLi)
                'zTempList(zLi) = zTempOutString
                '--------------------------------------------------------

                'for bot names in each entry
                'list entry
                zTemptxtAcmd = zList3.Items.Item(zLi)

                'trimmed bot name
                'zTempTrim = Mid(txtBotCmdName.Text, 1, Len(txtBotCmdName.Text) - 1)
                'find and replace all instanes of the trimmed bot name with the index
                'zTempOutString = Replace(zTemptxtAcmd, txtBotCmdName.Text, zTempTrim & zLi)

                'example line: alias "Alias0" "bot -name bot0 -team red -class engineer -teleport"

                'has to be bot space or bot underscore

                If ckEnumerateCmdListBots.Checked = True Then

                    'this assumes certain command formatting
                    'there will only ever be 1 bot spawn command per line
                    'so i can make a mass spawn and make a mass teleport
                    'while keeping the script lines seperated
                    'while allowing enumeration through each line
                    'trying to have multiple bot spawns in one line makes it a huge pain in the ass
                    'so, for now, it is assumed that there will only ever be one
                    'iteration of the botcmd function from the text box per line
                    'since the program is for script gernation and manipulation
                    'i have to make it conform to a certain format for ease of use
                    'ease of readability of the script
                    'and ease of writing the program
                    'which translates to, it will only ever add one instance of each command
                    'from the command list, per each alias line
                    'the botcmd generator that sets the bot command list output
                    'generates commands in a single pass
                    'which also includes the potential order the commands should follow
                    'which is written in to the botcmd generator function
                    'which translates to you wont ever see a bot spawn come after the command
                    'that tries to affect the bot, which wouldnt be spawned
                    'example:
                    'bot bot0 command will always come before bot_changeclass bot0

                    'i think the easiest way to itteratate through the string
                    'might be to just break everything in to values using spaces
                    'and add each entry to a temp list
                    'then iterate through each "word"
                    'and if it contains the botcmdname string

                    'i think recording each spaces location would be easiest

                    'might turn this in to a function to add all words in a string to a list

                    zLenTempTxtAcmd = Len(zTemptxtAcmd)

                    zWiCounter = 0
                    For zWi = 1 To zLenTempTxtAcmd
                        zFindSpace = Mid(zTemptxtAcmd, zWi, 1)
                        If zFindSpace = " " Then
                            'this is subtracted by 1 so that the indexes run off 0
                            zWiCounter = zWiCounter + 1
                            zTempSpaceLocations(zWiCounter - 1) = zWi - 1
                        End If
                    Next

                    For zWordListI = 0 To zWiCounter
                        'seperate out each word using space locations
                        If zWordListI = 0 Then
                            'first entry
                            'there wont be a seperator space so start from 1
                            zWordTemp = Mid(zTemptxtAcmd, 1, zTempSpaceLocations(zWordListI))
                            zTempWordList(zWordListI) = zWordTemp
                        ElseIf zWordListI < zWiCounter Then
                            'all the middle entries
                            'this cycles through each index in the space list
                            'then uses the current index value as the starting value
                            'and the current index + 1 as the ending value
                            zWordTemp = Mid(zTemptxtAcmd, zTempSpaceLocations(zWordListI - 1) + 2, zTempSpaceLocations(zWordListI) - zTempSpaceLocations(zWordListI - 1) - 1)
                            zTempWordList(zWordListI) = zWordTemp
                        ElseIf zWordListI = zWiCounter Then
                            'last one
                            zWordTemp = Mid(zTemptxtAcmd, zTempSpaceLocations(zWordListI - 1) + 2, zLenTempTxtAcmd)
                            zTempWordList(zWordListI) = zWordTemp
                        End If
                    Next

                    'since the bot spawn always comes first
                    'ignore checking for the botname because it will match bot

                    'ignore index 2 everytime because its the bot command

                    'have to add a thing to check the full temp word list to get an accurate count
                    'for values that have stuff in them and not nothing

                    zWordCount = 0
                    For zWordListI = 0 To 399
                        '399 is the total of the array
                        If zTempWordList(zWordListI) <> Nothing Then
                            zWordCount = zWordCount + 1
                        End If
                    Next

                    zBotCmdU = InStr(1, zTemptxtAcmd, "_")
                    zBotCmdSpace = InStr(1, zTemptxtAcmd, "bot ")
                    zBotNameTrim2 = Mid(txtBotCmdName.Text, 1, Len(txtBotCmdName.Text) - 1)

                    'cycle through the temp list using the word count
                    For zWordListI = 0 To zWordCount - 1

                        zBotCmdNameCheck = InStr(1, zTempWordList(zWordListI), zBotNameTrim2)
                        zBotCmdUCheck = InStr(1, zTempWordList(zWordListI), "_")

                        'just the bot spawn command
                        'no other commands
                        If zWordListI <> 1 And zWordListI <> 2 And zBotCmdUCheck = 0 Then
                            If zBotCmdNameCheck <> 0 And zBotCmdUCheck = 0 Then
                                zTempWordList(zWordListI) = zBotNameTrim2 & zLi
                            End If
                        End If
                    Next

                    'reassmble lines from word list

                    For zWordListI = 0 To zWordCount - 1
                        If zWordListI = 0 Then
                            zTempLineString = zTempWordList(zWordListI)
                        Else
                            zTempLineString = zTempLineString & " " & zTempWordList(zWordListI)
                        End If
                    Next

                    zTempOutString = zTempLineString

                End If

                If ckEnumerateCmdListAliases.Checked = True Then
                    'for alias names in each entry

                    'for this i have to find the alias name from the alias text box
                    'then find the next quote
                    'then make the temp string find the full number because it might be more than 1 digit
                    'like alias10 or alias100 or something
                    'then replace all of whichever alias it is with the alias name and the index

                    'finding the alias number
                    'example line: alias "Alias0" "bot -name bot0 -team red -class engineer -teleport"
                    If ckEnumerateCmdListBots.Checked = False Then
                        zTempOutString = zTemptxtAcmd
                    End If

                    Dim zAliasStart As Integer
                    'starting with the first quote and the alias name
                    zAliasStart = InStr(1, zTempOutString, zQ & txtAliasName.Text)
                    If zAliasStart <> 0 Then
                        Dim zAliasEnd As Integer
                        zAliasEnd = InStr(zAliasStart + Len(txtAliasName.Text) + 1, zTempOutString, zQ & " ")
                        If zAliasEnd <> 0 Then
                            Dim zAliasTrim As String
                            zAliasTrim = Mid(zTempOutString, zAliasStart + 1, zAliasEnd - zAliasStart - 1)
                            'find and replace all instanes of the trimmed bot name with the index
                            zTempOutString = Replace(zTempOutString, zAliasTrim, txtAliasName.Text & zLi)
                        End If
                    End If
                End If

                'this adds it to the temp list in memory
                zTempList(zLi) = zTempOutString
            Next

            zTempCount = zList3.Items.Count

            zList3.Items.Clear()

            For zLi = 0 To zTempCount - 1
                zList3.Items.Add(zTempList(zLi))
                zTempList(zLi) = vbNullString
            Next
        End If

        If zList3.Items.Count <> 0 Then
            For zLi = 0 To zList3.Items.Count - 1
                zLiSo = zLiSo & vbCrLf & zList3.Items.Item(zLi)
            Next
        End If

        txtAlias.Clear()
        txtAlias.Text = zLiSo

        zAii = zAii + 1
        txtAliasIncrement.Text = zAii.ToString

    End Sub

    Private Sub btAddFromConlog_Click(sender As Object, e As EventArgs) Handles btAddFromConlog.Click
        On Error GoTo zHandler
        txtInput.Clear()

        'set default

        ckBot.Checked = True
        ckBotKickAllFirst.Checked = True
        ckBotName.Checked = True
        txtBotCmdName.Text = "bot0"
        ckTeleportAlias.Checked = True
        ckEnumerateBots.Checked = True
        ckBCMDTeam.Checked = True
        ckTRed.Checked = True
        zTf2Team = 0
        ckTBlue.Checked = False
        ckBCmdTp.Checked = True
        ckAliasAutoUpdate.Checked = True
        Dim zLi As Integer
        For zLi = 0 To cklbBCMDClass.Items.Count - 1
            cklbBCMDClass.SetItemChecked(zLi, False)
        Next
        cklbBCMDClass.SetItemChecked(1, True)
        For zLi = 0 To cklbOtherBotCmd.Items.Count - 1
            cklbOtherBotCmd.SetItemChecked(zLi, False)
        Next
        cklbOtherBotCmd.SetItemChecked(0, True)
        lbNotiOut.Text = ""
        ckCyclicalAlias.Checked = True
        txtAliasName.Text = "Alias"
        zTf2Class = "engineer"
        txtAliasIncrement.Text = "0"
        ckMassTeleport.Checked = False
        zDefaultUpdateBotTextboxDisable = False

        ckEnumerateCmdListAliases.Checked = True
        ckEnumerateCmdListBots.Checked = True

        ckBotCmdHurtDamage.Checked = True

        cklbYawOffset.SetItemChecked(4, True)

        Dim zPath As String
        Dim zLine As String
        Dim zSout As String

        zPath = "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\conlog.txt"

        Using zStream As New FileStream(zPath,
                               FileMode.Open,
                               FileAccess.Read,
                               FileShare.ReadWrite),
      zReader As New StreamReader(zStream)
            'Use reader here.

            While zReader.Peek() >= 0
                zLine = zReader.ReadLine()
                zSout = zSout & zLine & vbCrLf
            End While

            zReader.Close()

        End Using

        txtInput.Text = zSout

        If ckClearConlog.Checked = True Then

            Using zStreamW As New FileStream(zPath,
                               FileMode.Open,
                               FileAccess.Write,
                               FileShare.ReadWrite),
      zWriter As New StreamWriter(zStreamW)

                zStreamW.SetLength(0)
                'tells me i cant close a closed file?
                'zStreamW.Close()
            End Using
        End If

        'clear button

        'txtInput.Clear()
        zList1.Items.Clear()
        txtOutput.Clear()
        zList2.Items.Clear()
        txtACycles.Text = "1"
        txtACmd.Clear()
        txtAlias.Clear()

        'add to text box button

        If txtInput.Text = vbNullString Then
            zNotiOut = "Nothing in Input Textbox - btAddToList_Click"
            zNotiTick = 0
            tmNoti.Enabled = True
        End If
        zTextLinesToListbox(txtInput, zList1, 1)

        'format teleport button

        If zList1.Items.Count = 0 Then
            zNotiOut = "No Items In List1 - btFormatTeleport_Click"
            zNotiTick = 0
            tmNoti.Enabled = True
            Exit Sub
        End If

        'uses old bot text box
        'zFormatTeleport(zList1, zList2, txtOutput, txtBotName, ckEnumerateBots)
        'uses new text box with timer and auto formatting
        'have to change format teleport to expect the zero
        'for enumeration
        zFormatTeleport(zList1, zList2, txtOutput, txtBotCmdName, ckEnumerateBots)
        If ckAliasAutoUpdate.Checked = True Then
            zUpdateBotCommandTextbox()
        End If

        Exit Sub
zHandler:
        MsgBox(Err.Description, MsgBoxStyle.OkOnly, "Error:")
    End Sub

    Private Sub cklbOtherBotCmd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cklbOtherBotCmd.SelectedIndexChanged

    End Sub

    Private Sub btClearAliasTextAndCmdList_Click(sender As Object, e As EventArgs) Handles btClearAliasTextAndCmdList.Click
        txtAlias.Clear()
        txtAliasIncrement.Text = "0"
        zList3.Items.Clear()
    End Sub

    Private Sub cklbOtherBotCmd_MouseDown(sender As Object, e As MouseEventArgs) Handles cklbOtherBotCmd.MouseDown

    End Sub

    '2026-04-20-05-03-04-AM
    'this is for zBotCmd2
    'which does the same thing
    'but uses a global iterator
    'instead of the individual iterators
    'in cases where its easier to just use the bot cmd for the echo command
    'nevermind
    'just adding it to the original as an always updated option?
    'if i have it incriment every time automatically from whatever value
    'i can set it to whatever thing whenever
    'so
    'i have to start with -1 to match 0 as a base
    Public zIterator As Integer = -1

    Public Function zBotCMD() As String
        'this allows me to call the bot command string anywhere

        'when adding to the string
        'always end with a space

        If zBCmdStart = False Then Exit Function

        Dim zBCout As String

        'since all the sub commands are for the bot command
        'its better to leave this
        'as it allows me to add more options
        'for more commands

        If ckBot.Checked = True Then
            'add bot to the output string
            zBCout = zBCout & "bot "

            'name
            If ckBotName.Checked = True Then
                'add bot to the output string
                If txtBotCmdName.Text = vbNullString Then
                    txtBotCmdName.Text = "bot0"
                End If
                zBCout = zBCout & "-name " & txtBotCmdName.Text & " "
            End If
            'team

            If ckBCMDTeam.Checked = True Then
                'add bot to the output string
                If ckTRed.Checked = True Then
                    'red team selected
                    zBCout = zBCout & "-team red "
                    zTf2Team = 0
                Else
                    'blue team selected
                    zBCout = zBCout & "-team blue "
                    zTf2Team = 1
                End If
            End If
            'class
            If ckBCMDClass.Checked = True Then
                'add bot to the output string
                If zTf2Class = vbNullString Then
                    zTf2Class = "engineer"
                End If
                zBCout = zBCout & "-class " & zTf2Class & " "
            End If
            'teleport
            If ckBCmdTp.Checked = True Then
                'add bot to the output string
                zBCout = zBCout & "-teleport"
            End If
        End If

        'add other commands from other list box

        'this is used to add to the front of the end string zBCout
        'if bot is checked it adds the string
        'if bot isnt checked it doesnt add the string

        Dim zBcmdSemiColon As String
        zBcmdSemiColon = "; "

        Dim zBCk As Boolean
        zBCk = ckBot.Checked

        Dim zBoCi As Integer

        'need to check if more than one is checked
        'then add the semi colin if there is and bot is checked
        Dim zBocMcheck As Integer
        zBocMcheck = 0
        For zBoCi = 0 To cklbOtherBotCmd.Items.Count - 1
            If cklbOtherBotCmd.GetItemChecked(zBoCi) = True Then
                zBocMcheck = zBocMcheck + 1
            End If
        Next

        If zBocMcheck > 1 And zBCk = True Then
            'bot is checked
            'and there is more than one selection
            'add the semicolon
            zBCout = zBCout & zBcmdSemiColon
        ElseIf zBocMcheck = 0 Then
            zNotiOut = "Nothing Checked In Bot Command Box - zBotCMD"
            zNotiTick = 0
            tmNoti.Enabled = True
            Exit Function
        End If

        Dim zBotName As String
        zBotName = txtBotCmdName.Text

        If zBotName = vbNullString Then
            'this may be redundant but just in case
            zNotiOut = "No Bot Name Setting bot0 - zBotCMD"
            zNotiTick = 0
            tmNoti.Enabled = True
            txtBotCmdName.Text = "bot0"
            zBotName = txtBotCmdName.Text
            'Exit Function
        End If

        'i should do the check to see if these ran here
        Dim zOtherBotCmd As Integer
        zOtherBotCmd = 0

        Dim zBotCmdText As String

        zBotCmdText = txtBotCommandForOtherCmd.Text
        zBotCmdText = zAlphaNumFilterWithDashPlus(zBotCmdText)
        If zBotCmdText = vbNullString Then
            txtBotCommandForOtherCmd.Text = "taunt"
            zBotCmdText = txtBotCommandForOtherCmd.Text
        End If

        'bot commands and their index
        '0    bot
        '1    bot_changeclass
        '2    bot_changeteams
        '3    bot_command
        '4    bot_crouch
        '5    bot_dontmove
        '6    bot_forceattack
        '7    bot_forceattack2
        '8    bot_forceattack_down
        '9    bot_forcefireweapon
        '10   bot_hurt
        'needs its own set of check boxes
        'not unless i just use the existing ones
        '11   bot_jump
        '12   bot_kick
        '13   bot_kill
        '14   bot_mimic
        '15   bot_mimic_inverse
        '16   bot_mimic_yaw_offset
        '17   bot_mirror
        '18   bot_randomnames
        '19   bot_refill
        '20   bot_saveme
        '21   bot_selectweaponslot
        '22   bot_teleport
        '23   bot_whack
        '24   cc_bot_selectweapon

        Dim zTempHurtDamage As String
        Dim zTempHurtDamageInt As Integer
        Dim zBase As String

        For zBoCi = 0 To cklbOtherBotCmd.Items.Count - 1
            If cklbOtherBotCmd.GetItemChecked(zBoCi) = True And zBoCi <> 0 Then
                'sets it to trim the semi colon
                zOtherBotCmd = zOtherBotCmd + 1
                Select Case zBoCi
                    Case 1
                        'bot_changeclass bot01 Soldier
                        zBCout = zBCout & "bot_changeclass " & zBotName & " " & zTf2Class & zBcmdSemiColon
                    Case 2
                        'bot_changeteams bot01 Soldier
                        zBCout = zBCout & "bot_changeteams" & zBcmdSemiColon
                    Case 3
                        'bot_command taunt
                        zBCout = zBCout & "bot_command " & zBotName & " " & zBotCmdText & zBcmdSemiColon
                    Case 4
                        'bot_crouch 1 / 0
                        zBCout = zBCout & "bot_crouch " & zBotName & " " & zBotCmdOck(zBoCi) & zBcmdSemiColon
                    Case 5
                        'bot_dontmove 1 / 0
                        zBCout = zBCout & "bot_dontmove " & zBotCmdOck(zBoCi) & zBcmdSemiColon
                    Case 6
                        'bot_forceattack 1 / 0
                        zBCout = zBCout & "bot_forceattack " & zBotName & " " & zBotCmdOck(zBoCi) & zBcmdSemiColon
                    Case 7
                        'bot_forceattack2 1 / 0
                        zBCout = zBCout & "bot_forceattack2 " & zBotName & " " & zBotCmdOck(zBoCi) & zBcmdSemiColon
                    Case 8
                        'bot_forceattack_down 1 / 0
                        zBCout = zBCout & "bot_forceattack_down " & zBotName & " " & zBotCmdOck(zBoCi) & zBcmdSemiColon
                    Case 9
                        'bot_forcefireweapon 1 / 0
                        zBCout = zBCout & "bot_forcefireweapon " & zBotCmdTFWeapon() & zBcmdSemiColon
                    Case 10
                        'bot_hurt name team all
                        'zTmpAdditive
                        'zBCout = zBCout & "bot_hurt " & zBotName & " " & zBotCmdOck(zBoCi) & zBcmdSemiColon
                        zTempHurtDamage = zNumFilter(txtBotCmdHurtDamage.Text)
                        If zTempHurtDamage = vbNullString Then
                            txtBotCmdHurtDamage.Text = "25"
                        End If
                        zTempHurtDamageInt = CInt(zTempHurtDamage)
                        If zBotCmdOck(zBoCi) = 1 Then
                            'if the 1 or 0 box is checked it will use all
                            zBase = zBase & "bot_hurt all "
                        Else
                            zBase = zBase & "bot_hurt " & zBotName & " "
                            'box is not checked not using all
                        End If
                        If ckBCMDTeam.Checked = True And ckBotCmdHurtDamage.Checked = True Then
                            zBase = zBase & "-team " & zTf2TeamToStr() & " -damage " & zTempHurtDamageInt
                        ElseIf ckBCMDTeam.Checked = False And ckBotCmdHurtDamage.Checked = True Then
                            zBase = zBase & "-damage " & zTempHurtDamageInt
                        ElseIf ckBCMDTeam.Checked = True And ckBotCmdHurtDamage.Checked = False Then
                            zBase = zBase & "-team " & zTf2TeamToStr()
                        End If
                        zBCout = zBCout & zBase & zBcmdSemiColon
                    Case 11
                        'bot_jump 1 / 0
                        zBCout = zBCout & "bot_jump " & zBotName & " " & zBotCmdOck(zBoCi) & zBcmdSemiColon
                    Case 12
                        'bot_kick 1 / 0
                        'zBCout = zBCout & "bot_kick " & zBotName & " " & zBotCmdOck(zBoCi) & zBcmdSemiColon
                        If zBotCmdOck(zBoCi) = 1 Then
                            'if the 1 or 0 box is checked it will use all
                            zBase = zBase & "bot_kick all "
                        Else
                            'box is not checked not using all
                            If ckBCMDTeam.Checked = True Then
                                'zBase = zBase & "-team " & zTf2TeamToStr() & " -damage " & zTempHurtDamageInt
                                zBase = zBase & "bot_kick " & zTf2TeamToStr()
                            Else
                                zBase = zBase & "bot_kick " & zBotName
                            End If
                        End If
                        zBCout = zBCout & zBase & zBcmdSemiColon
                    Case 13
                        'bot_kill all name
                        'zBCout = zBCout & "bot_kill " & zBotName & " " & zBotCmdOck(zBoCi) & zBcmdSemiColon
                        zBase = zBotCmd1or0BaseString("bot_kill", zBoCi, zBotName)
                        zBCout = zBCout & zBase & zBcmdSemiColon
                    Case 14
                        'bot_mimic 1 / 0
                        zBCout = zBCout & "bot_mimic " & zBotCmdOck(zBoCi) & zBcmdSemiColon
                    Case 15
                        'bot_mimic_inverse 1 / 0
                        zBCout = zBCout & "bot_mimic_inverse " & zBotCmdOck(zBoCi) & zBcmdSemiColon
                    Case 16
                        zCheckYaw()
                        'zMatchYaw()
                        'bot_mimic_yaw_offset uses yaw text box
                        zBCout = zBCout & "bot_mimic_yaw_offset " & zTf2BotCmdYawOffset & zBcmdSemiColon
                    Case 17
                        'bot_mirror 1 / 0
                        'zBCout = zBCout & "bot_mirror " & zBotName & " " & zBotCmdOck(zBoCi) & zBcmdSemiColon
                        zBase = zBotCmd1or0BaseString("bot_mirror", zBoCi, zBotName)
                        zBCout = zBCout & zBase & zBcmdSemiColon
                    Case 18
                        'bot_randomnames 1 / 0
                        zBCout = zBCout & "bot_randomnames " & zBotCmdOck(zBoCi) & zBcmdSemiColon
                    Case 19
                        'bot_refill no 1 or 0 or all
                        'all bots by default
                        zBCout = zBCout & "bot_refill" & zBcmdSemiColon
                    Case 20
                        'bot_saveme 1 / 0
                        zBCout = zBCout & "bot_saveme " & zBotCmdOck(zBoCi) & zBcmdSemiColon
                    Case 21
                        'bot_selectweaponslot
                        '0 = primary; 1 = secondary; 2 = melee; 3 = special
                        zBCout = zBCout & "bot_selectweaponslot " & zBotName & " " & zBotCmdOck(zBoCi) & zBcmdSemiColon
                    Case 22
                        'bot_crouch 1 / 0
                        zBCout = zBCout & "bot_crouch " & zBotName & " " & zBotCmdOck(zBoCi) & zBcmdSemiColon
                    Case 23
                        'bot_crouch 1 / 0
                        zBCout = zBCout & "bot_crouch " & zBotName & " " & zBotCmdOck(zBoCi) & zBcmdSemiColon
                    Case 24
                        'bot_crouch 1 / 0
                        zBCout = zBCout & "bot_crouch " & zBotName & " " & zBotCmdOck(zBoCi) & zBcmdSemiColon
                    Case 25
                        'bot_crouch 1 / 0
                        zBCout = zBCout & "bot_crouch " & zBotName & " " & zBotCmdOck(zBoCi) & zBcmdSemiColon
                End Select
            End If
        Next

        'if any of the other bot commands have been run
        'there will be a semi colon
        'trim it
        If zOtherBotCmd > 0 Then
            Dim zScTrim As String
            If zBCout <> vbNullString Then
                zScTrim = Mid(zBCout, 1, Len(zBCout) - 2)
                zBCout = zScTrim
            End If
        End If

        If zBCout = Nothing Then
            zBCout = vbNullString
        End If

        If ckEcho.Checked = True Then
            'txtAliasName
            'zBCout = zBCout & zBcmdSemiColon & "echo " & txtAliasName.Text & "=" & txtBotCmdName.Text & zBcmdSemiColon
            'zBCout = zBCout & zBcmdSemiColon & "echo " & txtAliasName.Text
            'starts at -1 on start up
            zIterator = zIterator + 1
            zBCout = zBCout & zBcmdSemiColon & "echo " & txtAliasName.Text & zIterator
        End If

        zBotCMD = zBCout

    End Function

    Public Function zBotCmdOck(zBoCiInput As Integer) As Integer
        Dim zTb As Boolean
        zTb = cklbBotCmd1or0.GetItemChecked(zBoCiInput)
        If zTb = True Then
            zBotCmdOck = 1
        Else
            zBotCmdOck = 0
        End If
    End Function

    Public Function zBotCmdTFWeapon() As String
        Dim zTb As Boolean
        Dim zCy As Integer
        Dim zCount As Integer
        zCount = cklbTfWeaponList.Items.Count
        For zCy = 0 To zCount - 1
            zTb = cklbTfWeaponList.GetItemChecked(zCy)
            If zTb = True Then
                zBotCmdTFWeapon = cklbTfWeaponList.Items.Item(zCy)
            End If
        Next
    End Function

    Private Sub cklbTfWeaponList_MouseUp(sender As Object, e As MouseEventArgs) Handles cklbTfWeaponList.MouseUp
        'for this clear all other 
        Dim zSelI As Integer = cklbTfWeaponList.SelectedIndex
        If zSelI <> -1 Then
            zTfWeaponUpdate(zSelI)
            If cklbTfWeaponList.GetItemChecked(zSelI) = True Then
                zUpdateOtherBotCmdListAnd1or0ListManualValue(9, True, False)
            Else
                zUpdateOtherBotCmdListAnd1or0ListManualValue(9, False, False)
            End If
        End If

        zUpdateBotCommandTextbox()

    End Sub

    Public Function zTf2TeamToStr() As String
        If zTf2Team = 0 Then
            'red
            zTf2TeamToStr = "red"
        Else
            'blue
            zTf2TeamToStr = "blue"
        End If
    End Function

    Private Sub cklbBotCmd1or0_MouseUp(sender As Object, e As MouseEventArgs) Handles cklbBotCmd1or0.MouseUp
        If cklbBotCmd1or0.SelectedIndex <> -1 Then
            cklbOtherBotCmd.SetSelected(cklbBotCmd1or0.SelectedIndex, True)
            cklbOtherBotCmd.TopIndex = cklbBotCmd1or0.TopIndex
        End If
        zUpdateBotCommandTextbox()
    End Sub

    Private Sub ckBotCmdHurtDamage_CheckedChanged(sender As Object, e As EventArgs) Handles ckBotCmdHurtDamage.CheckedChanged
        zUpdateBotCommandTextbox()
    End Sub

    Private Sub txtBotCmdHurtDamage_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBotCmdHurtDamage.KeyUp
        If e.KeyCode = 13 Then
            Dim zBotHurtDamageTxt As String
            zBotHurtDamageTxt = txtBotCmdHurtDamage.Text
            zBotHurtDamageTxt = zNumFilter(zBotHurtDamageTxt)
            If zBotHurtDamageTxt = vbNullString Then
                txtBotCmdHurtDamage.Text = "taunt"
            Else
                txtBotCmdHurtDamage.Text = zBotHurtDamageTxt
            End If
            zUpdateBotCommandTextbox()
        End If
    End Sub

    Private Sub txtBotCommandForOtherCmd_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBotCommandForOtherCmd.KeyUp
        If e.KeyCode = 13 Then
            Dim zBotCmdTxt As String
            zBotCmdTxt = txtBotCommandForOtherCmd.Text
            zBotCmdTxt = zAlphaNumFilterWithDashPlus(zBotCmdTxt)
            If zBotCmdTxt = vbNullString Then
                txtBotCommandForOtherCmd.Text = "taunt"
            Else
                txtBotCommandForOtherCmd.Text = zBotCmdTxt
            End If
            zUpdateBotCommandTextbox()
        End If
    End Sub

    Public Sub zSetupNonCyclicalTpMass()
        ckTeleportAlias.Checked = False
        ckEnumerateBots.Checked = False
        ckCyclicalAlias.Checked = False
    End Sub

    Private Sub btSetupNonCyclicalTpMass_Click(sender As Object, e As EventArgs) Handles btSetupNonCyclicalTpMass.Click
        zDefaultSet()
        zSetupNonCyclicalTpMass()
        zUpdateBotCommandTextbox()
    End Sub

    Public zUpdateBotCommandTextboxFlag As Integer = 0
    'the flag is optional on the sub
    '0 is normal mode
    '1 is from the bot command text box

    Private Sub txtACmd_KeyUp(sender As Object, e As KeyEventArgs) Handles txtACmd.KeyUp
        If zBCmdStart = False Then Exit Sub
        zUpdateBotCommandTextbox(1)
    End Sub

    Private Sub btcklbOtherBotCmdClear_Click(sender As Object, e As EventArgs) Handles btcklbOtherBotCmdClear.Click
        zClearCheckListBoxChecks(cklbOtherBotCmd)
        ckBot.Checked = False
        zUpdateBotCommandTextbox()
    End Sub

    Private Sub btcklbBotCmd1or0Clear_Click(sender As Object, e As EventArgs) Handles btcklbBotCmd1or0Clear.Click
        zClearCheckListBoxChecks(cklbBotCmd1or0)
        zUpdateBotCommandTextbox()
    End Sub

    Private Sub btcklbTfWeaponListClear_Click(sender As Object, e As EventArgs) Handles btcklbTfWeaponListClear.Click
        zClearCheckListBoxChecks(cklbTfWeaponList)
        zUpdateBotCommandTextbox()
    End Sub

    Private Sub btClearAllBotCmdLists_Click(sender As Object, e As EventArgs) Handles btClearAllBotCmdLists.Click
        zClearCheckListBoxChecks(cklbOtherBotCmd)
        zClearCheckListBoxChecks(cklbBotCmd1or0)
        zClearCheckListBoxChecks(cklbTfWeaponList)
        zUpdateBotCommandTextbox()
    End Sub

    Public Function zGetWeaponFirstChecked() As Integer
        Dim zLi As Integer
        Dim zLTi As Integer = -1
        Dim zCount As Integer = cklbTfWeaponList.Items.Count

        For zLi = 0 To zCount - 1
            If cklbTfWeaponList.GetItemChecked(zLi) = True And zLTi = -1 Then
                zLTi = zLi
            End If
        Next

        zGetWeaponFirstChecked = zLTi
    End Function

    Public Sub zTfWeaponUpdate(zLSi As Integer)
        'Dim zLSi As Integer
        Dim zLi As Integer
        Dim zCount As Integer

        zCount = cklbTfWeaponList.Items.Count

        'set all other entries to unchecked

        For zLi = 0 To zCount - 1
            If zLi <> zLSi Then
                cklbTfWeaponList.SetItemChecked(zLi, False)
            End If
        Next

    End Sub

    Private Sub cklbTfWeaponList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cklbTfWeaponList.SelectedIndexChanged

    End Sub

    Public Sub zCheckYaw()
        Dim zTemp As String
        Dim zI As Integer
        zTemp = txtBotCmdYawOffset.Text
        zTemp = zNumFilter(zTemp)
        If zTemp = vbNullString Then
            txtBotCmdYawOffset.Text = "180"
        Else
            zI = CInt(zTemp)
            If zI > 360 Then
                txtBotCmdYawOffset.Text = "360"
            ElseIf zI < 0 Then
                txtBotCmdYawOffset.Text = "180"
            Else
                txtBotCmdYawOffset.Text = zTemp
            End If
        End If
        'this will also update the global variable
        zTf2BotCmdYawOffset = CInt(txtBotCmdYawOffset.Text)
    End Sub

    Public zTf2BotCmdYawOffset As Integer = 180

    Private Sub cklbYawOffset_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cklbYawOffset.SelectedIndexChanged
    End Sub

    Private Sub txtBotCmdYawOffset_TextChanged(sender As Object, e As EventArgs) Handles txtBotCmdYawOffset.TextChanged

    End Sub

    Public Sub zMatchYaw()
        'this scans the check list box for the entry in the text box
        'and if it matches it checks that entry
        'this doesnt run checkyaw it only matches
        '0    0
        '1    45
        '2    90
        '3    135
        '4    180
        '5    225
        '6    270
        '7    315
        '8    360

        Dim zTxt As TextBox = txtBotCmdYawOffset
        Dim zCklb As CheckedListBox = cklbYawOffset
        Dim zCy As Integer
        Dim zCheck As Integer = 0
        Dim zMatch As Boolean = False
        Dim zMatchedIndex As Integer = -1
        For zCy = 0 To 8
            If zCklb.GetItemChecked(zCy) = True Then
                zCheck = zCheck + 1
            End If
        Next

        If zCheck = 1 Then
            For zCy = 0 To 8
                If zTxt.Text = zCklb.Items.Item(zCy) And zMatch = False Then
                    zMatch = True
                    zMatchedIndex = zCy
                End If
            Next
            If zMatch = True Then
                zClearCheckListBoxChecks(zCklb, zMatchedIndex)
                zCklb.SetItemChecked(zMatchedIndex, True)
                zCklb.SetSelected(zMatchedIndex, True)
            Else
                zClearCheckListBoxChecks(zCklb)
            End If
        ElseIf zCheck > 1 Then
            zClearCheckListBoxChecks(zCklb, 4)
            zCklb.SetItemChecked(4, True)
            zCklb.SetSelected(4, True)
            zTxt.Text = "180"
        ElseIf zCheck = 0 Then
            'this is for a value that has passed zCheckYaw
            'but its not in the list so dont check anything
            zClearCheckListBoxChecks(zCklb)
            For zCy = 0 To 8
                If zTxt.Text = zCklb.Items.Item(zCy) Then
                    zCklb.SetItemChecked(zCy, True)
                    zClearCheckListBoxChecks(zCklb, zCy)
                    zCklb.SetSelected(zCy, True)
                End If
            Next
        End If

    End Sub

    Private Sub txtBotCmdYawOffset_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBotCmdYawOffset.KeyUp
        Dim zSelI As Integer = cklbYawOffset.SelectedIndex
        If e.KeyCode = 13 Then
            zCheckYaw()
            zMatchYaw()
            'bot_mimic_yaw_offset = 16    
            zUpdateOtherBotCmdListAnd1or0ListManualValue(16, True, False)
            zUpdateBotCommandTextbox()
        End If
    End Sub

    Private Sub cklbYawOffset_MouseUp(sender As Object, e As MouseEventArgs) Handles cklbYawOffset.MouseUp
        'for this clear all other 
        Dim zSelI As Integer = cklbYawOffset.SelectedIndex
        If zSelI <> -1 Then
            zClearCheckListBoxChecks(cklbYawOffset, zSelI)

            If cklbYawOffset.GetItemChecked(zSelI) = True Then
                txtBotCmdYawOffset.Text = cklbYawOffset.Items.Item(zSelI)
            Else
                txtBotCmdYawOffset.Text = "180"
                cklbYawOffset.SetItemChecked(4, True)
            End If
        End If

        zCheckYaw()
        'bot_mimic_yaw_offset = 16    
        zUpdateOtherBotCmdListAnd1or0ListManualValue(16, True, False)
        zUpdateBotCommandTextbox()

    End Sub

    Private Sub cklbYawOffset_RegionChanged(sender As Object, e As EventArgs) Handles cklbYawOffset.RegionChanged

    End Sub

    Private Sub btClearConLog_Click(sender As Object, e As EventArgs) Handles btClearConLog.Click
        On Error GoTo zHandler
        Dim zPath As String
        'Dim zLine As String
        'Dim zSout As String

        zPath = "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\conlog.txt"

        Using zStreamW As New FileStream(zPath,
                   FileMode.Open,
                   FileAccess.Write,
                   FileShare.ReadWrite),
zWriter As New StreamWriter(zStreamW)

            zStreamW.SetLength(0)
            'tells me i cant close a closed file?
            'zStreamW.Close()
        End Using

        Exit Sub

zHandler:
        MsgBox(Err.Description, MsgBoxStyle.OkOnly, "Error:")
    End Sub

    Private Sub ckClearConlog_CheckedChanged(sender As Object, e As EventArgs) Handles ckClearConlog.CheckedChanged

    End Sub

    Private Sub ckEcho_CheckedChanged(sender As Object, e As EventArgs) Handles ckEcho.CheckedChanged
        zIterator = -1
        zUpdateBotCommandTextbox()
    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub

    Private Sub lbBot1or0_Click(sender As Object, e As EventArgs) Handles lbBot1or0.Click

    End Sub

    Private Sub txtAliasName_TextChanged(sender As Object, e As EventArgs) Handles txtAliasName.TextChanged

    End Sub
End Class
