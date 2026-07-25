<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        btAddToList = New Button()
        zList1 = New ListBox()
        txtInput = New TextBox()
        btFormatTeleport = New Button()
        zList2 = New ListBox()
        txtOutput = New TextBox()
        ckEnumerateBots = New CheckBox()
        btAlias = New Button()
        txtAlias = New TextBox()
        txtAliasName = New TextBox()
        ckTeleportAlias = New CheckBox()
        ckCyclicalAlias = New CheckBox()
        txtACycles = New TextBox()
        ckBot = New CheckBox()
        ckBotName = New CheckBox()
        txtBotCmdName = New TextBox()
        ckBCmdTp = New CheckBox()
        ckBCMDClass = New CheckBox()
        cklbBCMDClass = New CheckedListBox()
        ckBCMDTeam = New CheckBox()
        ckTRed = New CheckBox()
        ckTBlue = New CheckBox()
        tmStart = New Timer(components)
        tmBotNameTextUpdate = New Timer(components)
        lbCheckText = New Label()
        lbCheckTime = New Label()
        ckBotKickAllFirst = New CheckBox()
        cklbOtherBotCmd = New CheckedListBox()
        lbNoti = New Label()
        lbNotiOut = New Label()
        tmNoti = New Timer(components)
        ckAliasAutoUpdate = New CheckBox()
        btClear = New Button()
        btDefault = New Button()
        btClearCommandBox = New Button()
        btClearAliasBox = New Button()
        txtAliasIncrement = New TextBox()
        ckMassTeleport = New CheckBox()
        zList3 = New ListBox()
        btzList3Clear = New Button()
        btSetCyclesTo1 = New Button()
        btSetAliasIncrimentTo0 = New Button()
        btMassAlias = New Button()
        btAliasTextToCmdList = New Button()
        btCmdListToAliasText = New Button()
        btAddAliasTextToCmdList = New Button()
        btCopyCmdList = New Button()
        btAlias2 = New Button()
        btEnumerateBotInCommandList = New Button()
        btAddFromConlog = New Button()
        ckClearConlog = New CheckBox()
        ckEnumerateCmdListBots = New CheckBox()
        ckEnumerateCmdListAliases = New CheckBox()
        btClearAliasTextAndCmdList = New Button()
        txtBotCommandForOtherCmd = New TextBox()
        lbtxtBotCommandForOtherCmd = New Label()
        cklbBotCmd1or0 = New CheckedListBox()
        lbBot1or0 = New Label()
        lb1or0Desc = New Label()
        cklbTfWeaponList = New CheckedListBox()
        Label1 = New Label()
        txtBotCmdHurtDamage = New TextBox()
        ckBotCmdHurtDamage = New CheckBox()
        btSetupNonCyclicalTpMass = New Button()
        txtACmd = New RichTextBox()
        btcklbOtherBotCmdClear = New Button()
        btcklbBotCmd1or0Clear = New Button()
        btcklbTfWeaponListClear = New Button()
        btClearAllBotCmdLists = New Button()
        txtBotCmdYawOffset = New TextBox()
        cklbYawOffset = New CheckedListBox()
        lbYawOffset = New Label()
        cklbBotCmdForBotCmd = New CheckedListBox()
        btClearConLog = New Button()
        ckEcho = New CheckBox()
        SuspendLayout()
        ' 
        ' btAddToList
        ' 
        btAddToList.BackColor = Color.Black
        btAddToList.ForeColor = Color.LimeGreen
        btAddToList.Location = New Point(8, 8)
        btAddToList.Margin = New Padding(2)
        btAddToList.Name = "btAddToList"
        btAddToList.Size = New Size(94, 28)
        btAddToList.TabIndex = 0
        btAddToList.Text = "Add To List"
        btAddToList.UseVisualStyleBackColor = False
        ' 
        ' zList1
        ' 
        zList1.BackColor = Color.Black
        zList1.ForeColor = Color.LimeGreen
        zList1.FormattingEnabled = True
        zList1.HorizontalScrollbar = True
        zList1.Location = New Point(6, 168)
        zList1.Margin = New Padding(2)
        zList1.Name = "zList1"
        zList1.Size = New Size(355, 84)
        zList1.TabIndex = 1
        ' 
        ' txtInput
        ' 
        txtInput.BackColor = Color.Black
        txtInput.ForeColor = Color.LimeGreen
        txtInput.Location = New Point(8, 46)
        txtInput.Margin = New Padding(2)
        txtInput.Multiline = True
        txtInput.Name = "txtInput"
        txtInput.ScrollBars = ScrollBars.Vertical
        txtInput.Size = New Size(353, 119)
        txtInput.TabIndex = 2
        txtInput.Text = resources.GetString("txtInput.Text")
        ' 
        ' btFormatTeleport
        ' 
        btFormatTeleport.BackColor = Color.Black
        btFormatTeleport.ForeColor = Color.LimeGreen
        btFormatTeleport.Location = New Point(106, 8)
        btFormatTeleport.Margin = New Padding(2)
        btFormatTeleport.Name = "btFormatTeleport"
        btFormatTeleport.Size = New Size(150, 28)
        btFormatTeleport.TabIndex = 3
        btFormatTeleport.Text = "Format Teleport"
        btFormatTeleport.UseVisualStyleBackColor = False
        ' 
        ' zList2
        ' 
        zList2.BackColor = Color.Black
        zList2.ForeColor = Color.LimeGreen
        zList2.FormattingEnabled = True
        zList2.HorizontalScrollbar = True
        zList2.Location = New Point(365, 168)
        zList2.Margin = New Padding(2)
        zList2.Name = "zList2"
        zList2.Size = New Size(362, 84)
        zList2.TabIndex = 4
        ' 
        ' txtOutput
        ' 
        txtOutput.BackColor = Color.Black
        txtOutput.ForeColor = Color.LimeGreen
        txtOutput.Location = New Point(365, 45)
        txtOutput.Margin = New Padding(2)
        txtOutput.Multiline = True
        txtOutput.Name = "txtOutput"
        txtOutput.ScrollBars = ScrollBars.Vertical
        txtOutput.Size = New Size(362, 119)
        txtOutput.TabIndex = 7
        ' 
        ' ckEnumerateBots
        ' 
        ckEnumerateBots.AutoSize = True
        ckEnumerateBots.BackColor = Color.Black
        ckEnumerateBots.Checked = True
        ckEnumerateBots.CheckState = CheckState.Checked
        ckEnumerateBots.ForeColor = Color.LimeGreen
        ckEnumerateBots.Location = New Point(417, 256)
        ckEnumerateBots.Margin = New Padding(2)
        ckEnumerateBots.Name = "ckEnumerateBots"
        ckEnumerateBots.Size = New Size(135, 24)
        ckEnumerateBots.TabIndex = 8
        ckEnumerateBots.Text = "Enumerate Bots"
        ckEnumerateBots.UseVisualStyleBackColor = False
        ' 
        ' btAlias
        ' 
        btAlias.BackColor = Color.Black
        btAlias.ForeColor = Color.LimeGreen
        btAlias.Location = New Point(8, 281)
        btAlias.Margin = New Padding(2)
        btAlias.Name = "btAlias"
        btAlias.Size = New Size(94, 31)
        btAlias.TabIndex = 10
        btAlias.Text = "Alias"
        btAlias.UseVisualStyleBackColor = False
        ' 
        ' txtAlias
        ' 
        txtAlias.BackColor = Color.Black
        txtAlias.Font = New Font("Segoe UI", 14F)
        txtAlias.ForeColor = Color.LimeGreen
        txtAlias.Location = New Point(6, 502)
        txtAlias.Margin = New Padding(2)
        txtAlias.Multiline = True
        txtAlias.Name = "txtAlias"
        txtAlias.ScrollBars = ScrollBars.Vertical
        txtAlias.Size = New Size(685, 291)
        txtAlias.TabIndex = 11
        ' 
        ' txtAliasName
        ' 
        txtAliasName.BackColor = Color.Black
        txtAliasName.ForeColor = Color.LimeGreen
        txtAliasName.Location = New Point(5, 352)
        txtAliasName.Margin = New Padding(2)
        txtAliasName.Name = "txtAliasName"
        txtAliasName.Size = New Size(106, 27)
        txtAliasName.TabIndex = 12
        txtAliasName.Text = "Alias"
        ' 
        ' ckTeleportAlias
        ' 
        ckTeleportAlias.AutoSize = True
        ckTeleportAlias.BackColor = Color.Black
        ckTeleportAlias.Checked = True
        ckTeleportAlias.CheckState = CheckState.Checked
        ckTeleportAlias.ForeColor = Color.LimeGreen
        ckTeleportAlias.Location = New Point(291, 256)
        ckTeleportAlias.Margin = New Padding(2)
        ckTeleportAlias.Name = "ckTeleportAlias"
        ckTeleportAlias.Size = New Size(122, 24)
        ckTeleportAlias.TabIndex = 13
        ckTeleportAlias.Text = "Teleport Alias"
        ckTeleportAlias.UseVisualStyleBackColor = False
        ' 
        ' ckCyclicalAlias
        ' 
        ckCyclicalAlias.AutoSize = True
        ckCyclicalAlias.BackColor = Color.Black
        ckCyclicalAlias.Checked = True
        ckCyclicalAlias.CheckState = CheckState.Checked
        ckCyclicalAlias.ForeColor = Color.LimeGreen
        ckCyclicalAlias.Location = New Point(8, 318)
        ckCyclicalAlias.Margin = New Padding(2)
        ckCyclicalAlias.Name = "ckCyclicalAlias"
        ckCyclicalAlias.Size = New Size(117, 24)
        ckCyclicalAlias.TabIndex = 14
        ckCyclicalAlias.Text = "Cyclical Alias"
        ckCyclicalAlias.UseVisualStyleBackColor = False
        ' 
        ' txtACycles
        ' 
        txtACycles.BackColor = Color.Black
        txtACycles.ForeColor = Color.LimeGreen
        txtACycles.Location = New Point(125, 317)
        txtACycles.Margin = New Padding(2)
        txtACycles.Name = "txtACycles"
        txtACycles.Size = New Size(30, 27)
        txtACycles.TabIndex = 16
        txtACycles.Text = "1"
        ' 
        ' ckBot
        ' 
        ckBot.AutoSize = True
        ckBot.BackColor = Color.Black
        ckBot.Checked = True
        ckBot.CheckState = CheckState.Checked
        ckBot.ForeColor = Color.LimeGreen
        ckBot.Location = New Point(164, 289)
        ckBot.Margin = New Padding(2)
        ckBot.Name = "ckBot"
        ckBot.Size = New Size(54, 24)
        ckBot.TabIndex = 18
        ckBot.Text = "Bot"
        ckBot.UseVisualStyleBackColor = False
        ' 
        ' ckBotName
        ' 
        ckBotName.AutoSize = True
        ckBotName.BackColor = Color.Black
        ckBotName.Checked = True
        ckBotName.CheckState = CheckState.Checked
        ckBotName.ForeColor = Color.LimeGreen
        ckBotName.Location = New Point(362, 289)
        ckBotName.Margin = New Padding(2)
        ckBotName.Name = "ckBotName"
        ckBotName.Size = New Size(98, 24)
        ckBotName.TabIndex = 19
        ckBotName.Text = "Bot Name"
        ckBotName.UseVisualStyleBackColor = False
        ' 
        ' txtBotCmdName
        ' 
        txtBotCmdName.BackColor = Color.Black
        txtBotCmdName.ForeColor = Color.LimeGreen
        txtBotCmdName.Location = New Point(193, 351)
        txtBotCmdName.Margin = New Padding(2)
        txtBotCmdName.Name = "txtBotCmdName"
        txtBotCmdName.Size = New Size(176, 27)
        txtBotCmdName.TabIndex = 20
        txtBotCmdName.Text = "bot0"
        ' 
        ' ckBCmdTp
        ' 
        ckBCmdTp.AutoSize = True
        ckBCmdTp.BackColor = Color.Black
        ckBCmdTp.Checked = True
        ckBCmdTp.CheckState = CheckState.Checked
        ckBCmdTp.ForeColor = Color.LimeGreen
        ckBCmdTp.Location = New Point(556, 256)
        ckBCmdTp.Margin = New Padding(2)
        ckBCmdTp.Name = "ckBCmdTp"
        ckBCmdTp.Size = New Size(86, 24)
        ckBCmdTp.TabIndex = 21
        ckBCmdTp.Text = "Teleport"
        ckBCmdTp.UseVisualStyleBackColor = False
        ' 
        ' ckBCMDClass
        ' 
        ckBCMDClass.AutoSize = True
        ckBCMDClass.BackColor = Color.Black
        ckBCMDClass.Checked = True
        ckBCMDClass.CheckState = CheckState.Checked
        ckBCMDClass.ForeColor = Color.LimeGreen
        ckBCMDClass.Location = New Point(753, 361)
        ckBCMDClass.Margin = New Padding(2)
        ckBCMDClass.Name = "ckBCMDClass"
        ckBCMDClass.Size = New Size(64, 24)
        ckBCMDClass.TabIndex = 22
        ckBCMDClass.Text = "Class"
        ckBCMDClass.UseVisualStyleBackColor = False
        ' 
        ' cklbBCMDClass
        ' 
        cklbBCMDClass.BackColor = Color.Black
        cklbBCMDClass.ForeColor = Color.LimeGreen
        cklbBCMDClass.FormattingEnabled = True
        cklbBCMDClass.Items.AddRange(New Object() {"demo", "engineer", "heavy", "medic", "pyro", "scout", "sniper", "soldier", "spy"})
        cklbBCMDClass.Location = New Point(755, 148)
        cklbBCMDClass.Margin = New Padding(2)
        cklbBCMDClass.Name = "cklbBCMDClass"
        cklbBCMDClass.Size = New Size(155, 202)
        cklbBCMDClass.Sorted = True
        cklbBCMDClass.TabIndex = 23
        ' 
        ' ckBCMDTeam
        ' 
        ckBCMDTeam.AutoSize = True
        ckBCMDTeam.BackColor = Color.Black
        ckBCMDTeam.Checked = True
        ckBCMDTeam.CheckState = CheckState.Checked
        ckBCMDTeam.ForeColor = Color.LimeGreen
        ckBCMDTeam.Location = New Point(464, 289)
        ckBCMDTeam.Margin = New Padding(2)
        ckBCMDTeam.Name = "ckBCMDTeam"
        ckBCMDTeam.Size = New Size(67, 24)
        ckBCMDTeam.TabIndex = 24
        ckBCMDTeam.Text = "Team"
        ckBCMDTeam.UseVisualStyleBackColor = False
        ' 
        ' ckTRed
        ' 
        ckTRed.AutoSize = True
        ckTRed.BackColor = Color.Black
        ckTRed.Checked = True
        ckTRed.CheckState = CheckState.Checked
        ckTRed.ForeColor = Color.LimeGreen
        ckTRed.Location = New Point(535, 289)
        ckTRed.Margin = New Padding(2)
        ckTRed.Name = "ckTRed"
        ckTRed.Size = New Size(53, 24)
        ckTRed.TabIndex = 25
        ckTRed.Text = "red"
        ckTRed.UseVisualStyleBackColor = False
        ' 
        ' ckTBlue
        ' 
        ckTBlue.AutoSize = True
        ckTBlue.BackColor = Color.Black
        ckTBlue.ForeColor = Color.LimeGreen
        ckTBlue.Location = New Point(592, 289)
        ckTBlue.Margin = New Padding(2)
        ckTBlue.Name = "ckTBlue"
        ckTBlue.Size = New Size(60, 24)
        ckTBlue.TabIndex = 26
        ckTBlue.Text = "blue"
        ckTBlue.UseVisualStyleBackColor = False
        ' 
        ' tmStart
        ' 
        tmStart.Enabled = True
        tmStart.Interval = 1000
        ' 
        ' tmBotNameTextUpdate
        ' 
        tmBotNameTextUpdate.Interval = 1000
        ' 
        ' lbCheckText
        ' 
        lbCheckText.AutoSize = True
        lbCheckText.BackColor = Color.Black
        lbCheckText.ForeColor = Color.LimeGreen
        lbCheckText.Location = New Point(373, 355)
        lbCheckText.Margin = New Padding(2, 0, 2, 0)
        lbCheckText.Name = "lbCheckText"
        lbCheckText.Size = New Size(49, 20)
        lbCheckText.TabIndex = 27
        lbCheckText.Text = "check:"
        ' 
        ' lbCheckTime
        ' 
        lbCheckTime.AutoSize = True
        lbCheckTime.BackColor = Color.Black
        lbCheckTime.ForeColor = Color.LimeGreen
        lbCheckTime.Location = New Point(426, 355)
        lbCheckTime.Margin = New Padding(2, 0, 2, 0)
        lbCheckTime.Name = "lbCheckTime"
        lbCheckTime.Size = New Size(17, 20)
        lbCheckTime.TabIndex = 28
        lbCheckTime.Text = "0"
        ' 
        ' ckBotKickAllFirst
        ' 
        ckBotKickAllFirst.AutoSize = True
        ckBotKickAllFirst.BackColor = Color.Black
        ckBotKickAllFirst.Checked = True
        ckBotKickAllFirst.CheckState = CheckState.Checked
        ckBotKickAllFirst.ForeColor = Color.LimeGreen
        ckBotKickAllFirst.Location = New Point(222, 289)
        ckBotKickAllFirst.Margin = New Padding(2)
        ckBotKickAllFirst.Name = "ckBotKickAllFirst"
        ckBotKickAllFirst.Size = New Size(138, 24)
        ckBotKickAllFirst.TabIndex = 29
        ckBotKickAllFirst.Text = "Bot Kick All First"
        ckBotKickAllFirst.UseVisualStyleBackColor = False
        ' 
        ' cklbOtherBotCmd
        ' 
        cklbOtherBotCmd.BackColor = Color.Black
        cklbOtherBotCmd.ForeColor = Color.LimeGreen
        cklbOtherBotCmd.FormattingEnabled = True
        cklbOtherBotCmd.Items.AddRange(New Object() {"bot", "bot_changeclass", "bot_changeteams", "bot_command", "bot_crouch", "bot_dontmove", "bot_forceattack", "bot_forceattack2", "bot_forceattack_down", "bot_forcefireweapon", "bot_hurt", "bot_jump", "bot_kick", "bot_kill", "bot_mimic", "bot_mimic_inverse", "bot_mimic_yaw_offset", "bot_mirror", "bot_randomnames", "bot_refill", "bot_saveme", "bot_selectweaponslot", "bot_teleport", "bot_whack", "cc_bot_selectweapon"})
        cklbOtherBotCmd.Location = New Point(1193, 70)
        cklbOtherBotCmd.Margin = New Padding(2)
        cklbOtherBotCmd.Name = "cklbOtherBotCmd"
        cklbOtherBotCmd.Size = New Size(158, 136)
        cklbOtherBotCmd.TabIndex = 30
        ' 
        ' lbNoti
        ' 
        lbNoti.AutoSize = True
        lbNoti.BackColor = Color.Black
        lbNoti.ForeColor = Color.LimeGreen
        lbNoti.Location = New Point(270, 8)
        lbNoti.Margin = New Padding(2, 0, 2, 0)
        lbNoti.Name = "lbNoti"
        lbNoti.Size = New Size(91, 20)
        lbNoti.TabIndex = 31
        lbNoti.Text = "Notification:"
        ' 
        ' lbNotiOut
        ' 
        lbNotiOut.AutoSize = True
        lbNotiOut.BackColor = Color.Black
        lbNotiOut.Font = New Font("Segoe UI", 10F)
        lbNotiOut.ForeColor = Color.LimeGreen
        lbNotiOut.Location = New Point(365, 11)
        lbNotiOut.Margin = New Padding(2, 0, 2, 0)
        lbNotiOut.Name = "lbNotiOut"
        lbNotiOut.Size = New Size(19, 23)
        lbNotiOut.TabIndex = 32
        lbNotiOut.Text = "0"
        ' 
        ' tmNoti
        ' 
        tmNoti.Interval = 1000
        ' 
        ' ckAliasAutoUpdate
        ' 
        ckAliasAutoUpdate.AutoSize = True
        ckAliasAutoUpdate.BackColor = Color.Black
        ckAliasAutoUpdate.Checked = True
        ckAliasAutoUpdate.CheckState = CheckState.Checked
        ckAliasAutoUpdate.ForeColor = Color.LimeGreen
        ckAliasAutoUpdate.Location = New Point(8, 254)
        ckAliasAutoUpdate.Margin = New Padding(2)
        ckAliasAutoUpdate.Name = "ckAliasAutoUpdate"
        ckAliasAutoUpdate.Size = New Size(152, 24)
        ckAliasAutoUpdate.TabIndex = 33
        ckAliasAutoUpdate.Text = "Alias Auto Update"
        ckAliasAutoUpdate.UseVisualStyleBackColor = False
        ' 
        ' btClear
        ' 
        btClear.BackColor = Color.Black
        btClear.ForeColor = Color.LimeGreen
        btClear.Location = New Point(903, 18)
        btClear.Margin = New Padding(2)
        btClear.Name = "btClear"
        btClear.Size = New Size(58, 34)
        btClear.TabIndex = 34
        btClear.Text = "Clear"
        btClear.UseVisualStyleBackColor = False
        ' 
        ' btDefault
        ' 
        btDefault.BackColor = Color.Black
        btDefault.ForeColor = Color.LimeGreen
        btDefault.Location = New Point(828, 18)
        btDefault.Margin = New Padding(2)
        btDefault.Name = "btDefault"
        btDefault.Size = New Size(71, 34)
        btDefault.TabIndex = 35
        btDefault.Text = "Default"
        btDefault.UseVisualStyleBackColor = False
        ' 
        ' btClearCommandBox
        ' 
        btClearCommandBox.BackColor = Color.Black
        btClearCommandBox.ForeColor = Color.LimeGreen
        btClearCommandBox.Location = New Point(698, 383)
        btClearCommandBox.Margin = New Padding(2)
        btClearCommandBox.Name = "btClearCommandBox"
        btClearCommandBox.Size = New Size(27, 29)
        btClearCommandBox.TabIndex = 36
        btClearCommandBox.Text = "X"
        btClearCommandBox.UseVisualStyleBackColor = False
        ' 
        ' btClearAliasBox
        ' 
        btClearAliasBox.BackColor = Color.Black
        btClearAliasBox.ForeColor = Color.LimeGreen
        btClearAliasBox.Location = New Point(698, 502)
        btClearAliasBox.Margin = New Padding(2)
        btClearAliasBox.Name = "btClearAliasBox"
        btClearAliasBox.Size = New Size(27, 29)
        btClearAliasBox.TabIndex = 37
        btClearAliasBox.Text = "X"
        btClearAliasBox.UseVisualStyleBackColor = False
        ' 
        ' txtAliasIncrement
        ' 
        txtAliasIncrement.BackColor = Color.Black
        txtAliasIncrement.ForeColor = Color.LimeGreen
        txtAliasIncrement.Location = New Point(125, 352)
        txtAliasIncrement.Margin = New Padding(2)
        txtAliasIncrement.Name = "txtAliasIncrement"
        txtAliasIncrement.Size = New Size(30, 27)
        txtAliasIncrement.TabIndex = 38
        txtAliasIncrement.Text = "0"
        ' 
        ' ckMassTeleport
        ' 
        ckMassTeleport.AutoSize = True
        ckMassTeleport.BackColor = Color.Black
        ckMassTeleport.ForeColor = Color.LimeGreen
        ckMassTeleport.Location = New Point(164, 256)
        ckMassTeleport.Margin = New Padding(2)
        ckMassTeleport.Name = "ckMassTeleport"
        ckMassTeleport.Size = New Size(123, 24)
        ckMassTeleport.TabIndex = 39
        ckMassTeleport.Text = "Mass Teleport"
        ckMassTeleport.UseVisualStyleBackColor = False
        ' 
        ' zList3
        ' 
        zList3.BackColor = Color.Black
        zList3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        zList3.ForeColor = Color.LimeGreen
        zList3.FormattingEnabled = True
        zList3.HorizontalScrollbar = True
        zList3.Location = New Point(734, 481)
        zList3.Margin = New Padding(2)
        zList3.Name = "zList3"
        zList3.Size = New Size(850, 284)
        zList3.TabIndex = 40
        ' 
        ' btzList3Clear
        ' 
        btzList3Clear.BackColor = Color.Black
        btzList3Clear.ForeColor = Color.LimeGreen
        btzList3Clear.Location = New Point(1557, 448)
        btzList3Clear.Margin = New Padding(2)
        btzList3Clear.Name = "btzList3Clear"
        btzList3Clear.Size = New Size(27, 29)
        btzList3Clear.TabIndex = 41
        btzList3Clear.Text = "X"
        btzList3Clear.UseVisualStyleBackColor = False
        ' 
        ' btSetCyclesTo1
        ' 
        btSetCyclesTo1.BackColor = Color.Black
        btSetCyclesTo1.ForeColor = Color.LimeGreen
        btSetCyclesTo1.Location = New Point(159, 317)
        btSetCyclesTo1.Margin = New Padding(2)
        btSetCyclesTo1.Name = "btSetCyclesTo1"
        btSetCyclesTo1.Size = New Size(27, 27)
        btSetCyclesTo1.TabIndex = 42
        btSetCyclesTo1.Text = "1"
        btSetCyclesTo1.UseVisualStyleBackColor = False
        ' 
        ' btSetAliasIncrimentTo0
        ' 
        btSetAliasIncrimentTo0.BackColor = Color.Black
        btSetAliasIncrimentTo0.ForeColor = Color.LimeGreen
        btSetAliasIncrimentTo0.Location = New Point(159, 352)
        btSetAliasIncrimentTo0.Margin = New Padding(2)
        btSetAliasIncrimentTo0.Name = "btSetAliasIncrimentTo0"
        btSetAliasIncrimentTo0.Size = New Size(27, 27)
        btSetAliasIncrimentTo0.TabIndex = 43
        btSetAliasIncrimentTo0.Text = "0"
        btSetAliasIncrimentTo0.UseVisualStyleBackColor = False
        ' 
        ' btMassAlias
        ' 
        btMassAlias.BackColor = Color.Black
        btMassAlias.ForeColor = Color.LimeGreen
        btMassAlias.Location = New Point(732, 400)
        btMassAlias.Margin = New Padding(2)
        btMassAlias.Name = "btMassAlias"
        btMassAlias.Size = New Size(117, 35)
        btMassAlias.TabIndex = 44
        btMassAlias.Text = "Mass Alias"
        btMassAlias.UseVisualStyleBackColor = False
        ' 
        ' btAliasTextToCmdList
        ' 
        btAliasTextToCmdList.BackColor = Color.Black
        btAliasTextToCmdList.ForeColor = Color.LimeGreen
        btAliasTextToCmdList.Location = New Point(853, 400)
        btAliasTextToCmdList.Margin = New Padding(2)
        btAliasTextToCmdList.Name = "btAliasTextToCmdList"
        btAliasTextToCmdList.Size = New Size(182, 35)
        btAliasTextToCmdList.TabIndex = 45
        btAliasTextToCmdList.Text = "V Alias Text To Cmd List"
        btAliasTextToCmdList.UseVisualStyleBackColor = False
        ' 
        ' btCmdListToAliasText
        ' 
        btCmdListToAliasText.BackColor = Color.Black
        btCmdListToAliasText.ForeColor = Color.LimeGreen
        btCmdListToAliasText.Location = New Point(1039, 400)
        btCmdListToAliasText.Margin = New Padding(2)
        btCmdListToAliasText.Name = "btCmdListToAliasText"
        btCmdListToAliasText.Size = New Size(182, 35)
        btCmdListToAliasText.TabIndex = 46
        btCmdListToAliasText.Text = "^ Cmd List To Alias Text"
        btCmdListToAliasText.UseVisualStyleBackColor = False
        ' 
        ' btAddAliasTextToCmdList
        ' 
        btAddAliasTextToCmdList.BackColor = Color.Black
        btAddAliasTextToCmdList.ForeColor = Color.LimeGreen
        btAddAliasTextToCmdList.Location = New Point(1039, 438)
        btAddAliasTextToCmdList.Margin = New Padding(2)
        btAddAliasTextToCmdList.Name = "btAddAliasTextToCmdList"
        btAddAliasTextToCmdList.Size = New Size(225, 34)
        btAddAliasTextToCmdList.TabIndex = 47
        btAddAliasTextToCmdList.Text = "V ADD Alias Text To Cmd List"
        btAddAliasTextToCmdList.UseVisualStyleBackColor = False
        ' 
        ' btCopyCmdList
        ' 
        btCopyCmdList.BackColor = Color.Black
        btCopyCmdList.ForeColor = Color.LimeGreen
        btCopyCmdList.Location = New Point(976, 439)
        btCopyCmdList.Margin = New Padding(2)
        btCopyCmdList.Name = "btCopyCmdList"
        btCopyCmdList.Size = New Size(59, 33)
        btCopyCmdList.TabIndex = 48
        btCopyCmdList.Text = "Copy"
        btCopyCmdList.UseVisualStyleBackColor = False
        ' 
        ' btAlias2
        ' 
        btAlias2.BackColor = Color.Black
        btAlias2.ForeColor = Color.LimeGreen
        btAlias2.Location = New Point(814, 359)
        btAlias2.Margin = New Padding(2)
        btAlias2.Name = "btAlias2"
        btAlias2.Size = New Size(94, 30)
        btAlias2.TabIndex = 49
        btAlias2.Text = "Alias"
        btAlias2.UseVisualStyleBackColor = False
        ' 
        ' btEnumerateBotInCommandList
        ' 
        btEnumerateBotInCommandList.BackColor = Color.Black
        btEnumerateBotInCommandList.ForeColor = Color.LimeGreen
        btEnumerateBotInCommandList.Location = New Point(734, 439)
        btEnumerateBotInCommandList.Margin = New Padding(2)
        btEnumerateBotInCommandList.Name = "btEnumerateBotInCommandList"
        btEnumerateBotInCommandList.Size = New Size(94, 38)
        btEnumerateBotInCommandList.TabIndex = 50
        btEnumerateBotInCommandList.Text = "Enumerate"
        btEnumerateBotInCommandList.UseVisualStyleBackColor = False
        ' 
        ' btAddFromConlog
        ' 
        btAddFromConlog.BackColor = Color.Black
        btAddFromConlog.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btAddFromConlog.ForeColor = Color.LimeGreen
        btAddFromConlog.Location = New Point(826, 56)
        btAddFromConlog.Margin = New Padding(2)
        btAddFromConlog.Name = "btAddFromConlog"
        btAddFromConlog.Size = New Size(133, 57)
        btAddFromConlog.TabIndex = 51
        btAddFromConlog.Text = "Add From conlog.txt"
        btAddFromConlog.UseVisualStyleBackColor = False
        ' 
        ' ckClearConlog
        ' 
        ckClearConlog.AutoSize = True
        ckClearConlog.BackColor = Color.Black
        ckClearConlog.Checked = True
        ckClearConlog.CheckState = CheckState.Checked
        ckClearConlog.ForeColor = Color.LimeGreen
        ckClearConlog.Location = New Point(965, 94)
        ckClearConlog.Margin = New Padding(2)
        ckClearConlog.Name = "ckClearConlog"
        ckClearConlog.Size = New Size(135, 24)
        ckClearConlog.TabIndex = 52
        ckClearConlog.Text = "Clear conlog.txt"
        ckClearConlog.UseVisualStyleBackColor = False
        ' 
        ' ckEnumerateCmdListBots
        ' 
        ckEnumerateCmdListBots.AutoSize = True
        ckEnumerateCmdListBots.BackColor = Color.Black
        ckEnumerateCmdListBots.Checked = True
        ckEnumerateCmdListBots.CheckState = CheckState.Checked
        ckEnumerateCmdListBots.ForeColor = Color.LimeGreen
        ckEnumerateCmdListBots.Location = New Point(832, 448)
        ckEnumerateCmdListBots.Margin = New Padding(2)
        ckEnumerateCmdListBots.Name = "ckEnumerateCmdListBots"
        ckEnumerateCmdListBots.Size = New Size(60, 24)
        ckEnumerateCmdListBots.TabIndex = 53
        ckEnumerateCmdListBots.Text = "Bots"
        ckEnumerateCmdListBots.UseVisualStyleBackColor = False
        ' 
        ' ckEnumerateCmdListAliases
        ' 
        ckEnumerateCmdListAliases.AutoSize = True
        ckEnumerateCmdListAliases.BackColor = Color.Black
        ckEnumerateCmdListAliases.Checked = True
        ckEnumerateCmdListAliases.CheckState = CheckState.Checked
        ckEnumerateCmdListAliases.ForeColor = Color.LimeGreen
        ckEnumerateCmdListAliases.Location = New Point(896, 448)
        ckEnumerateCmdListAliases.Margin = New Padding(2)
        ckEnumerateCmdListAliases.Name = "ckEnumerateCmdListAliases"
        ckEnumerateCmdListAliases.Size = New Size(77, 24)
        ckEnumerateCmdListAliases.TabIndex = 54
        ckEnumerateCmdListAliases.Text = "Aliases"
        ckEnumerateCmdListAliases.UseVisualStyleBackColor = False
        ' 
        ' btClearAliasTextAndCmdList
        ' 
        btClearAliasTextAndCmdList.BackColor = Color.Black
        btClearAliasTextAndCmdList.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btClearAliasTextAndCmdList.ForeColor = Color.LimeGreen
        btClearAliasTextAndCmdList.Location = New Point(698, 535)
        btClearAliasTextAndCmdList.Margin = New Padding(2)
        btClearAliasTextAndCmdList.Name = "btClearAliasTextAndCmdList"
        btClearAliasTextAndCmdList.Size = New Size(27, 29)
        btClearAliasTextAndCmdList.TabIndex = 55
        btClearAliasTextAndCmdList.Text = "X2"
        btClearAliasTextAndCmdList.UseVisualStyleBackColor = False
        ' 
        ' txtBotCommandForOtherCmd
        ' 
        txtBotCommandForOtherCmd.BackColor = Color.Black
        txtBotCommandForOtherCmd.ForeColor = Color.LimeGreen
        txtBotCommandForOtherCmd.Location = New Point(939, 236)
        txtBotCommandForOtherCmd.Margin = New Padding(2)
        txtBotCommandForOtherCmd.Name = "txtBotCommandForOtherCmd"
        txtBotCommandForOtherCmd.Size = New Size(229, 27)
        txtBotCommandForOtherCmd.TabIndex = 56
        txtBotCommandForOtherCmd.Text = "taunt"
        ' 
        ' lbtxtBotCommandForOtherCmd
        ' 
        lbtxtBotCommandForOtherCmd.AutoSize = True
        lbtxtBotCommandForOtherCmd.BackColor = Color.Black
        lbtxtBotCommandForOtherCmd.ForeColor = Color.LimeGreen
        lbtxtBotCommandForOtherCmd.Location = New Point(937, 162)
        lbtxtBotCommandForOtherCmd.Margin = New Padding(2, 0, 2, 0)
        lbtxtBotCommandForOtherCmd.Name = "lbtxtBotCommandForOtherCmd"
        lbtxtBotCommandForOtherCmd.Size = New Size(105, 20)
        lbtxtBotCommandForOtherCmd.TabIndex = 57
        lbtxtBotCommandForOtherCmd.Text = "bot_command"
        ' 
        ' cklbBotCmd1or0
        ' 
        cklbBotCmd1or0.BackColor = Color.Black
        cklbBotCmd1or0.ForeColor = Color.LimeGreen
        cklbBotCmd1or0.FormattingEnabled = True
        cklbBotCmd1or0.Items.AddRange(New Object() {"bot", "bot_changeclass", "bot_changeteams", "bot_command", "bot_crouch", "bot_dontmove", "bot_forceattack", "bot_forceattack2", "bot_forceattack_down", "bot_forcefireweapon", "bot_hurt", "bot_jump", "bot_kick", "bot_kill", "bot_mimic", "bot_mimic_inverse", "bot_mimic_yaw_offset", "bot_mirror", "bot_randomnames", "bot_refill", "bot_saveme", "bot_selectweaponslot", "bot_teleport", "bot_whack", "cc_bot_selectweapon"})
        cklbBotCmd1or0.Location = New Point(1355, 70)
        cklbBotCmd1or0.Margin = New Padding(2)
        cklbBotCmd1or0.Name = "cklbBotCmd1or0"
        cklbBotCmd1or0.Size = New Size(229, 136)
        cklbBotCmd1or0.TabIndex = 58
        ' 
        ' lbBot1or0
        ' 
        lbBot1or0.AutoSize = True
        lbBot1or0.BackColor = Color.Black
        lbBot1or0.ForeColor = Color.LimeGreen
        lbBot1or0.Location = New Point(753, 106)
        lbBot1or0.Margin = New Padding(2, 0, 2, 0)
        lbBot1or0.Name = "lbBot1or0"
        lbBot1or0.Size = New Size(47, 20)
        lbBot1or0.TabIndex = 59
        lbBot1or0.Text = "1 or 0"
        ' 
        ' lb1or0Desc
        ' 
        lb1or0Desc.AutoSize = True
        lb1or0Desc.BackColor = Color.Black
        lb1or0Desc.ForeColor = Color.LimeGreen
        lb1or0Desc.Location = New Point(751, 126)
        lb1or0Desc.Margin = New Padding(2, 0, 2, 0)
        lb1or0Desc.Name = "lb1or0Desc"
        lb1or0Desc.Size = New Size(157, 20)
        lb1or0Desc.TabIndex = 60
        lb1or0Desc.Text = "ignores nonapplicable"
        ' 
        ' cklbTfWeaponList
        ' 
        cklbTfWeaponList.BackColor = Color.Black
        cklbTfWeaponList.ForeColor = Color.LimeGreen
        cklbTfWeaponList.FormattingEnabled = True
        cklbTfWeaponList.Items.AddRange(New Object() {"none", "TF_Weapon_Wrench", "TF_ThermalThruster", "TF_Weapon_Ap_Sap", "TF_Weapon_Award", "TF_Weapon_Axe", "TF_Weapon_Bat", "TF_Weapon_Battle_Banner", "TF_Weapon_Bonesaw", "TF_Weapon_Bottle", "TF_Weapon_Camera", "TF_Weapon_Cannon", "TF_Weapon_Cleaver", "TF_Weapon_Club", "TF_Weapon_CompoundBow", "TF_Weapon_Crossbow", "TF_Weapon_Crowbar", "TF_Weapon_Disguise_Kit", "TF_Weapon_Disguise_Kit_Type", "TF_Weapon_DragonsFury", "TF_Weapon_FireAxe", "TF_Weapon_FireballLauncher", "TF_Weapon_Fish", "TF_Weapon_Fists", "TF_Weapon_FlameThrower", "TF_Weapon_FlareGun", "TF_Weapon_FryingPan", "TF_Weapon_GardenRake", "TF_Weapon_Gloves", "TF_Weapon_GoldFryingPan", "TF_Weapon_GrenadeLauncher", "TF_Weapon_Gunbai", "TF_Weapon_Hammer", "TF_Weapon_HotHand", "TF_Weapon_Jar", "TF_Weapon_Jar_Cleaver", "TF_Weapon_Jar_Gas", "TF_Weapon_Jar_Milk", "TF_Weapon_Knife", "TF_Weapon_Kunai", "TF_Weapon_Laser_Pointer", "TF_Weapon_LunchBox", "TF_Weapon_Machete", "TF_Weapon_MakeshiftClub", "TF_Weapon_Medigun", "TF_Weapon_Medigun_Prototype", "TF_Weapon_Medigun_Resist", "TF_Weapon_Medikit", "TF_Weapon_Minigun", "TF_Weapon_Nailgun", "TF_Weapon_ObjectSelection", "TF_Weapon_PDA_Engineer", "TF_Weapon_PDA_Engineer_Builder", "TF_Weapon_PDA_Engineer_Destroyer", "TF_Weapon_Parachute", "TF_Weapon_Peppergun", "TF_Weapon_Pickaxe", "TF_Weapon_PipebombLauncher", "TF_Weapon_Pistol", "TF_Weapon_Pork_Product", "TF_Weapon_Revolver", "TF_Weapon_RiftFireAxe", "TF_Weapon_RiftFireMace", "TF_Weapon_Robot_Arm", "TF_Weapon_RocketLauncher", "TF_Weapon_RocketPack", "TF_Weapon_SMG", "TF_Weapon_Scattergun", "TF_Weapon_Severed_Arm", "TF_Weapon_Shotgun", "TF_Weapon_Shotgun_Building_Rescue", "TF_Weapon_Shovel", "TF_Weapon_Sign", "TF_Weapon_Skullbat", "TF_Weapon_Slap", "TF_Weapon_SledgeHammer", "TF_Weapon_SniperRifle", "TF_Weapon_SoldierKatana", "TF_Weapon_SoldierSashimono", "TF_Weapon_Spy_Sapper", "TF_Weapon_Staff", "TF_Weapon_StickBomb", "TF_Weapon_StickybombLauncher", "TF_Weapon_SuperSMG", "TF_Weapon_Sword", "TF_Weapon_SyringeGun", "TF_Weapon_SyringeGun_Prototype", "TF_Weapon_Tranq", "TF_Weapon_Watch"})
        cklbTfWeaponList.Location = New Point(1355, 266)
        cklbTfWeaponList.Margin = New Padding(2)
        cklbTfWeaponList.Name = "cklbTfWeaponList"
        cklbTfWeaponList.Size = New Size(229, 136)
        cklbTfWeaponList.TabIndex = 61
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Black
        Label1.ForeColor = Color.LimeGreen
        Label1.Location = New Point(1384, 244)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 20)
        Label1.TabIndex = 62
        Label1.Text = "tf_weapon List"
        ' 
        ' txtBotCmdHurtDamage
        ' 
        txtBotCmdHurtDamage.BackColor = Color.Black
        txtBotCmdHurtDamage.ForeColor = Color.LimeGreen
        txtBotCmdHurtDamage.Location = New Point(940, 343)
        txtBotCmdHurtDamage.Margin = New Padding(2)
        txtBotCmdHurtDamage.Name = "txtBotCmdHurtDamage"
        txtBotCmdHurtDamage.Size = New Size(84, 27)
        txtBotCmdHurtDamage.TabIndex = 63
        txtBotCmdHurtDamage.Text = "25"
        ' 
        ' ckBotCmdHurtDamage
        ' 
        ckBotCmdHurtDamage.AutoSize = True
        ckBotCmdHurtDamage.BackColor = Color.Black
        ckBotCmdHurtDamage.Checked = True
        ckBotCmdHurtDamage.CheckState = CheckState.Checked
        ckBotCmdHurtDamage.ForeColor = Color.LimeGreen
        ckBotCmdHurtDamage.Location = New Point(1030, 345)
        ckBotCmdHurtDamage.Margin = New Padding(2)
        ckBotCmdHurtDamage.Name = "ckBotCmdHurtDamage"
        ckBotCmdHurtDamage.Size = New Size(148, 24)
        ckBotCmdHurtDamage.TabIndex = 65
        ckBotCmdHurtDamage.Text = "Bot Hurt Damage"
        ckBotCmdHurtDamage.UseVisualStyleBackColor = False
        ' 
        ' btSetupNonCyclicalTpMass
        ' 
        btSetupNonCyclicalTpMass.BackColor = Color.Black
        btSetupNonCyclicalTpMass.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btSetupNonCyclicalTpMass.ForeColor = Color.LimeGreen
        btSetupNonCyclicalTpMass.Location = New Point(965, 18)
        btSetupNonCyclicalTpMass.Margin = New Padding(2)
        btSetupNonCyclicalTpMass.Name = "btSetupNonCyclicalTpMass"
        btSetupNonCyclicalTpMass.Size = New Size(116, 34)
        btSetupNonCyclicalTpMass.TabIndex = 66
        btSetupNonCyclicalTpMass.Text = "Non Cyclical Telport Mode"
        btSetupNonCyclicalTpMass.UseVisualStyleBackColor = False
        ' 
        ' txtACmd
        ' 
        txtACmd.AutoWordSelection = True
        txtACmd.BackColor = Color.Black
        txtACmd.Font = New Font("Segoe UI", 14F)
        txtACmd.ForeColor = Color.LimeGreen
        txtACmd.Location = New Point(6, 383)
        txtACmd.Margin = New Padding(2)
        txtACmd.Name = "txtACmd"
        txtACmd.ScrollBars = RichTextBoxScrollBars.ForcedVertical
        txtACmd.Size = New Size(687, 94)
        txtACmd.TabIndex = 67
        txtACmd.Text = ""
        ' 
        ' btcklbOtherBotCmdClear
        ' 
        btcklbOtherBotCmdClear.BackColor = Color.Black
        btcklbOtherBotCmdClear.ForeColor = Color.LimeGreen
        btcklbOtherBotCmdClear.Location = New Point(1324, 207)
        btcklbOtherBotCmdClear.Margin = New Padding(2)
        btcklbOtherBotCmdClear.Name = "btcklbOtherBotCmdClear"
        btcklbOtherBotCmdClear.Size = New Size(27, 29)
        btcklbOtherBotCmdClear.TabIndex = 68
        btcklbOtherBotCmdClear.Text = "X"
        btcklbOtherBotCmdClear.UseVisualStyleBackColor = False
        ' 
        ' btcklbBotCmd1or0Clear
        ' 
        btcklbBotCmd1or0Clear.BackColor = Color.Black
        btcklbBotCmd1or0Clear.ForeColor = Color.LimeGreen
        btcklbBotCmd1or0Clear.Location = New Point(1557, 210)
        btcklbBotCmd1or0Clear.Margin = New Padding(2)
        btcklbBotCmd1or0Clear.Name = "btcklbBotCmd1or0Clear"
        btcklbBotCmd1or0Clear.Size = New Size(27, 29)
        btcklbBotCmd1or0Clear.TabIndex = 69
        btcklbBotCmd1or0Clear.Text = "X"
        btcklbBotCmd1or0Clear.UseVisualStyleBackColor = False
        ' 
        ' btcklbTfWeaponListClear
        ' 
        btcklbTfWeaponListClear.BackColor = Color.Black
        btcklbTfWeaponListClear.ForeColor = Color.LimeGreen
        btcklbTfWeaponListClear.Location = New Point(1557, 400)
        btcklbTfWeaponListClear.Margin = New Padding(2)
        btcklbTfWeaponListClear.Name = "btcklbTfWeaponListClear"
        btcklbTfWeaponListClear.Size = New Size(27, 29)
        btcklbTfWeaponListClear.TabIndex = 70
        btcklbTfWeaponListClear.Text = "X"
        btcklbTfWeaponListClear.UseVisualStyleBackColor = False
        ' 
        ' btClearAllBotCmdLists
        ' 
        btClearAllBotCmdLists.BackColor = Color.Black
        btClearAllBotCmdLists.ForeColor = Color.LimeGreen
        btClearAllBotCmdLists.Location = New Point(1203, 210)
        btClearAllBotCmdLists.Margin = New Padding(2)
        btClearAllBotCmdLists.Name = "btClearAllBotCmdLists"
        btClearAllBotCmdLists.Size = New Size(112, 36)
        btClearAllBotCmdLists.TabIndex = 71
        btClearAllBotCmdLists.Text = "Clear All Bot Command Lists"
        btClearAllBotCmdLists.UseVisualStyleBackColor = False
        ' 
        ' txtBotCmdYawOffset
        ' 
        txtBotCmdYawOffset.BackColor = Color.Black
        txtBotCmdYawOffset.ForeColor = Color.LimeGreen
        txtBotCmdYawOffset.Location = New Point(940, 316)
        txtBotCmdYawOffset.Margin = New Padding(2)
        txtBotCmdYawOffset.Name = "txtBotCmdYawOffset"
        txtBotCmdYawOffset.Size = New Size(84, 27)
        txtBotCmdYawOffset.TabIndex = 72
        txtBotCmdYawOffset.Text = "180"
        ' 
        ' cklbYawOffset
        ' 
        cklbYawOffset.BackColor = Color.Black
        cklbYawOffset.ForeColor = Color.LimeGreen
        cklbYawOffset.FormattingEnabled = True
        cklbYawOffset.Items.AddRange(New Object() {"0", "45", "90", "135", "180", "225", "270", "315", "360"})
        cklbYawOffset.Location = New Point(939, 263)
        cklbYawOffset.Margin = New Padding(2)
        cklbYawOffset.Name = "cklbYawOffset"
        cklbYawOffset.Size = New Size(229, 48)
        cklbYawOffset.TabIndex = 73
        ' 
        ' lbYawOffset
        ' 
        lbYawOffset.AutoSize = True
        lbYawOffset.BackColor = Color.Black
        lbYawOffset.ForeColor = Color.LimeGreen
        lbYawOffset.Location = New Point(1030, 317)
        lbYawOffset.Margin = New Padding(2, 0, 2, 0)
        lbYawOffset.Name = "lbYawOffset"
        lbYawOffset.Size = New Size(77, 20)
        lbYawOffset.TabIndex = 74
        lbYawOffset.Text = "yaw offset"
        ' 
        ' cklbBotCmdForBotCmd
        ' 
        cklbBotCmdForBotCmd.BackColor = Color.Black
        cklbBotCmdForBotCmd.ForeColor = Color.LimeGreen
        cklbBotCmdForBotCmd.FormattingEnabled = True
        cklbBotCmdForBotCmd.Items.AddRange(New Object() {"taunt"})
        cklbBotCmdForBotCmd.Location = New Point(937, 184)
        cklbBotCmdForBotCmd.Margin = New Padding(2)
        cklbBotCmdForBotCmd.Name = "cklbBotCmdForBotCmd"
        cklbBotCmdForBotCmd.Size = New Size(229, 48)
        cklbBotCmdForBotCmd.TabIndex = 75
        ' 
        ' btClearConLog
        ' 
        btClearConLog.BackColor = Color.Black
        btClearConLog.ForeColor = Color.LimeGreen
        btClearConLog.Location = New Point(965, 56)
        btClearConLog.Margin = New Padding(2)
        btClearConLog.Name = "btClearConLog"
        btClearConLog.Size = New Size(131, 34)
        btClearConLog.TabIndex = 76
        btClearConLog.Text = "Clear conlog.txt"
        btClearConLog.UseVisualStyleBackColor = False
        ' 
        ' ckEcho
        ' 
        ckEcho.AutoSize = True
        ckEcho.BackColor = Color.Black
        ckEcho.Checked = True
        ckEcho.CheckState = CheckState.Checked
        ckEcho.ForeColor = Color.LimeGreen
        ckEcho.Location = New Point(647, 256)
        ckEcho.Name = "ckEcho"
        ckEcho.Size = New Size(63, 24)
        ckEcho.TabIndex = 77
        ckEcho.Text = "Echo"
        ckEcho.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScrollMargin = New Size(0, 20)
        AutoSize = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = Color.Black
        ClientSize = New Size(1727, 867)
        Controls.Add(ckEcho)
        Controls.Add(btClearConLog)
        Controls.Add(cklbBotCmdForBotCmd)
        Controls.Add(lbYawOffset)
        Controls.Add(cklbYawOffset)
        Controls.Add(txtBotCmdYawOffset)
        Controls.Add(btClearAllBotCmdLists)
        Controls.Add(btcklbTfWeaponListClear)
        Controls.Add(btcklbBotCmd1or0Clear)
        Controls.Add(btcklbOtherBotCmdClear)
        Controls.Add(txtACmd)
        Controls.Add(btSetupNonCyclicalTpMass)
        Controls.Add(ckBotCmdHurtDamage)
        Controls.Add(txtBotCmdHurtDamage)
        Controls.Add(Label1)
        Controls.Add(cklbTfWeaponList)
        Controls.Add(lb1or0Desc)
        Controls.Add(lbBot1or0)
        Controls.Add(cklbBotCmd1or0)
        Controls.Add(lbtxtBotCommandForOtherCmd)
        Controls.Add(txtBotCommandForOtherCmd)
        Controls.Add(btClearAliasTextAndCmdList)
        Controls.Add(ckEnumerateCmdListAliases)
        Controls.Add(ckEnumerateCmdListBots)
        Controls.Add(ckClearConlog)
        Controls.Add(btAddFromConlog)
        Controls.Add(btEnumerateBotInCommandList)
        Controls.Add(btAlias2)
        Controls.Add(btCopyCmdList)
        Controls.Add(btAddAliasTextToCmdList)
        Controls.Add(btCmdListToAliasText)
        Controls.Add(btAliasTextToCmdList)
        Controls.Add(btMassAlias)
        Controls.Add(btSetAliasIncrimentTo0)
        Controls.Add(btSetCyclesTo1)
        Controls.Add(btzList3Clear)
        Controls.Add(zList3)
        Controls.Add(ckMassTeleport)
        Controls.Add(txtAliasIncrement)
        Controls.Add(btClearAliasBox)
        Controls.Add(btClearCommandBox)
        Controls.Add(btDefault)
        Controls.Add(btClear)
        Controls.Add(ckAliasAutoUpdate)
        Controls.Add(lbNotiOut)
        Controls.Add(lbNoti)
        Controls.Add(cklbOtherBotCmd)
        Controls.Add(ckBotKickAllFirst)
        Controls.Add(lbCheckTime)
        Controls.Add(lbCheckText)
        Controls.Add(ckTBlue)
        Controls.Add(ckTRed)
        Controls.Add(ckBCMDTeam)
        Controls.Add(cklbBCMDClass)
        Controls.Add(ckBCMDClass)
        Controls.Add(ckBCmdTp)
        Controls.Add(txtBotCmdName)
        Controls.Add(ckBotName)
        Controls.Add(ckBot)
        Controls.Add(txtACycles)
        Controls.Add(ckCyclicalAlias)
        Controls.Add(ckTeleportAlias)
        Controls.Add(txtAliasName)
        Controls.Add(txtAlias)
        Controls.Add(btAlias)
        Controls.Add(ckEnumerateBots)
        Controls.Add(txtOutput)
        Controls.Add(zList2)
        Controls.Add(btFormatTeleport)
        Controls.Add(txtInput)
        Controls.Add(zList1)
        Controls.Add(btAddToList)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(2)
        MaximizeBox = False
        MaximumSize = New Size(1745, 914)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "zTf2Script - GUI Gore"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btAddToList As Button
    Friend WithEvents zList1 As ListBox
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btFormatTeleport As Button
    Friend WithEvents zList2 As ListBox
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents ckEnumerateBots As CheckBox
    Friend WithEvents btAlias As Button
    Friend WithEvents txtAlias As TextBox
    Friend WithEvents txtAliasName As TextBox
    Friend WithEvents ckTeleportAlias As CheckBox
    Friend WithEvents ckCyclicalAlias As CheckBox
    Friend WithEvents txtACycles As TextBox
    Friend WithEvents ckBot As CheckBox
    Friend WithEvents ckBotName As CheckBox
    Friend WithEvents txtBotCmdName As TextBox
    Friend WithEvents ckBCmdTp As CheckBox
    Friend WithEvents ckBCMDClass As CheckBox
    Friend WithEvents cklbBCMDClass As CheckedListBox
    Friend WithEvents ckBCMDTeam As CheckBox
    Friend WithEvents ckTRed As CheckBox
    Friend WithEvents ckTBlue As CheckBox
    Friend WithEvents tmStart As Timer
    Friend WithEvents tmBotNameTextUpdate As Timer
    Friend WithEvents lbCheckText As Label
    Friend WithEvents lbCheckTime As Label
    Friend WithEvents ckBotKickAllFirst As CheckBox
    Friend WithEvents cklbOtherBotCmd As CheckedListBox
    Friend WithEvents lbNoti As Label
    Friend WithEvents lbNotiOut As Label
    Friend WithEvents tmNoti As Timer
    Friend WithEvents ckAliasAutoUpdate As CheckBox
    Friend WithEvents btClear As Button
    Friend WithEvents btDefault As Button
    Friend WithEvents btClearCommandBox As Button
    Friend WithEvents btClearAliasBox As Button
    Friend WithEvents txtAliasIncrement As TextBox
    Friend WithEvents ckMassTeleport As CheckBox
    Friend WithEvents zList3 As ListBox
    Friend WithEvents btzList3Clear As Button
    Friend WithEvents btSetCyclesTo1 As Button
    Friend WithEvents btSetAliasIncrimentTo0 As Button
    Friend WithEvents btMassAlias As Button
    Friend WithEvents btAliasTextToCmdList As Button
    Friend WithEvents btCmdListToAliasText As Button
    Friend WithEvents btAddAliasTextToCmdList As Button
    Friend WithEvents btCopyCmdList As Button
    Friend WithEvents btAlias2 As Button
    Friend WithEvents btEnumerateBotInCommandList As Button
    Friend WithEvents btAddFromConlog As Button
    Friend WithEvents ckClearConlog As CheckBox
    Friend WithEvents ckEnumerateCmdListBots As CheckBox
    Friend WithEvents ckEnumerateCmdListAliases As CheckBox
    Friend WithEvents btClearAliasTextAndCmdList As Button
    Friend WithEvents txtBotCommandForOtherCmd As TextBox
    Friend WithEvents lbtxtBotCommandForOtherCmd As Label
    Friend WithEvents cklbBotCmd1or0 As CheckedListBox
    Friend WithEvents lbBot1or0 As Label
    Friend WithEvents lb1or0Desc As Label
    Friend WithEvents cklbTfWeaponList As CheckedListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBotCmdHurtDamage As TextBox
    Friend WithEvents ckBotCmdHurtDamage As CheckBox
    Friend WithEvents btSetupNonCyclicalTpMass As Button
    Friend WithEvents txtACmd As RichTextBox
    Friend WithEvents btcklbOtherBotCmdClear As Button
    Friend WithEvents btcklbBotCmd1or0Clear As Button
    Friend WithEvents btcklbTfWeaponListClear As Button
    Friend WithEvents btClearAllBotCmdLists As Button
    Friend WithEvents txtBotCmdYawOffset As TextBox
    Friend WithEvents cklbYawOffset As CheckedListBox
    Friend WithEvents lbYawOffset As Label
    Friend WithEvents cklbBotCmdForBotCmd As CheckedListBox
    Friend WithEvents btClearConLog As Button
    Friend WithEvents ckEcho As CheckBox

End Class
