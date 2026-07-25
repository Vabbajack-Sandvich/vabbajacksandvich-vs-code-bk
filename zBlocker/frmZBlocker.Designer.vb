<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmZBlocker
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        lstInput = New ListBox()
        txtInput = New TextBox()
        btInput = New Button()
        txtI1 = New TextBox()
        txtI2 = New TextBox()
        txtI3 = New TextBox()
        btClearInserts = New Button()
        txtOut = New TextBox()
        btCopy = New Button()
        btDef = New Button()
        btIn = New Button()
        btOut = New Button()
        btGenerate = New Button()
        btInputGenerate = New Button()
        ckOnTop = New CheckBox()
        btLoadList = New Button()
        btSaveIP = New Button()
        txtOld = New TextBox()
        lstOld = New ListBox()
        lstUnique = New ListBox()
        btSaveBatch = New Button()
        ckInBatch = New CheckBox()
        ckOutBatch = New CheckBox()
        btClearInput = New Button()
        btClearOutput = New Button()
        btInputGenerateSaveBoth = New Button()
        btClearOld = New Button()
        txtIteratorInput = New TextBox()
        ckIter1 = New CheckBox()
        ckIter2 = New CheckBox()
        ckIter3 = New CheckBox()
        ckIter4 = New CheckBox()
        btIterate = New Button()
        lstIterator = New ListBox()
        btMoveIterations = New Button()
        lbInputGenerateInOutSave = New Label()
        btIterateSelected = New Button()
        btGenerateFromOld = New Button()
        pbSaveLoad = New ProgressBar()
        zLoadtimer = New Timer(components)
        btExtractRemoteAddressFromTCPView = New Button()
        btDontSaveOnExit = New Button()
        btFilterAndCopyToClipboard = New Button()
        btClearListInput = New Button()
        lblstInput = New Label()
        lblstOld = New Label()
        lblstIterator = New Label()
        lblstUnique = New Label()
        btClearlstUnique = New Button()
        btOpenBatchFolder = New Button()
        btOpenListFolder = New Button()
        btTest = New Button()
        SuspendLayout()
        ' 
        ' lstInput
        ' 
        lstInput.BackColor = Color.Black
        lstInput.ForeColor = Color.LimeGreen
        lstInput.FormattingEnabled = True
        lstInput.Location = New Point(338, 12)
        lstInput.Name = "lstInput"
        lstInput.Size = New Size(309, 104)
        lstInput.Sorted = True
        lstInput.TabIndex = 0
        ' 
        ' txtInput
        ' 
        txtInput.BackColor = Color.Black
        txtInput.ForeColor = Color.LimeGreen
        txtInput.Location = New Point(12, 12)
        txtInput.Multiline = True
        txtInput.Name = "txtInput"
        txtInput.ScrollBars = ScrollBars.Vertical
        txtInput.Size = New Size(309, 144)
        txtInput.TabIndex = 1
        ' 
        ' btInput
        ' 
        btInput.BackColor = Color.Black
        btInput.ForeColor = Color.LimeGreen
        btInput.Location = New Point(669, 237)
        btInput.Name = "btInput"
        btInput.Size = New Size(107, 33)
        btInput.TabIndex = 2
        btInput.Text = "Input"
        btInput.UseVisualStyleBackColor = False
        ' 
        ' txtI1
        ' 
        txtI1.BackColor = Color.Black
        txtI1.ForeColor = Color.LimeGreen
        txtI1.Location = New Point(12, 243)
        txtI1.Name = "txtI1"
        txtI1.Size = New Size(309, 27)
        txtI1.TabIndex = 3
        txtI1.Text = "netsh advfirewall firewall add rule name=""block "
        ' 
        ' txtI2
        ' 
        txtI2.BackColor = Color.Black
        txtI2.ForeColor = Color.LimeGreen
        txtI2.Location = New Point(12, 276)
        txtI2.Name = "txtI2"
        txtI2.Size = New Size(309, 27)
        txtI2.TabIndex = 4
        txtI2.Text = """ dir=in action=block remoteip="""
        ' 
        ' txtI3
        ' 
        txtI3.BackColor = Color.Black
        txtI3.ForeColor = Color.LimeGreen
        txtI3.Location = New Point(12, 309)
        txtI3.Name = "txtI3"
        txtI3.Size = New Size(309, 27)
        txtI3.TabIndex = 5
        txtI3.Text = """"
        ' 
        ' btClearInserts
        ' 
        btClearInserts.BackColor = Color.Black
        btClearInserts.ForeColor = Color.LimeGreen
        btClearInserts.Location = New Point(276, 342)
        btClearInserts.Name = "btClearInserts"
        btClearInserts.Size = New Size(45, 33)
        btClearInserts.TabIndex = 8
        btClearInserts.Text = "X"
        btClearInserts.UseVisualStyleBackColor = False
        ' 
        ' txtOut
        ' 
        txtOut.BackColor = Color.Black
        txtOut.ForeColor = Color.LimeGreen
        txtOut.Location = New Point(338, 162)
        txtOut.Multiline = True
        txtOut.Name = "txtOut"
        txtOut.ScrollBars = ScrollBars.Vertical
        txtOut.Size = New Size(309, 144)
        txtOut.TabIndex = 9
        ' 
        ' btCopy
        ' 
        btCopy.BackColor = Color.Black
        btCopy.ForeColor = Color.LimeGreen
        btCopy.Location = New Point(520, 312)
        btCopy.Name = "btCopy"
        btCopy.Size = New Size(76, 33)
        btCopy.TabIndex = 10
        btCopy.Text = "Copy"
        btCopy.UseVisualStyleBackColor = False
        ' 
        ' btDef
        ' 
        btDef.BackColor = Color.Black
        btDef.Location = New Point(12, 342)
        btDef.Name = "btDef"
        btDef.Size = New Size(79, 33)
        btDef.TabIndex = 11
        btDef.Text = "Default"
        btDef.UseVisualStyleBackColor = False
        ' 
        ' btIn
        ' 
        btIn.BackColor = Color.Black
        btIn.ForeColor = Color.LimeGreen
        btIn.Location = New Point(97, 342)
        btIn.Name = "btIn"
        btIn.Size = New Size(68, 33)
        btIn.TabIndex = 12
        btIn.Text = "In"
        btIn.UseVisualStyleBackColor = False
        ' 
        ' btOut
        ' 
        btOut.BackColor = Color.Black
        btOut.ForeColor = Color.LimeGreen
        btOut.Location = New Point(171, 342)
        btOut.Name = "btOut"
        btOut.Size = New Size(68, 33)
        btOut.TabIndex = 13
        btOut.Text = "Out"
        btOut.UseVisualStyleBackColor = False
        ' 
        ' btGenerate
        ' 
        btGenerate.BackColor = Color.Black
        btGenerate.ForeColor = Color.LimeGreen
        btGenerate.Location = New Point(669, 276)
        btGenerate.Name = "btGenerate"
        btGenerate.Size = New Size(107, 33)
        btGenerate.TabIndex = 14
        btGenerate.Text = "Generate"
        btGenerate.UseVisualStyleBackColor = False
        ' 
        ' btInputGenerate
        ' 
        btInputGenerate.BackColor = Color.Black
        btInputGenerate.ForeColor = Color.LimeGreen
        btInputGenerate.Location = New Point(669, 315)
        btInputGenerate.Name = "btInputGenerate"
        btInputGenerate.Size = New Size(107, 62)
        btInputGenerate.TabIndex = 15
        btInputGenerate.Text = "Input and Generate"
        btInputGenerate.UseVisualStyleBackColor = False
        ' 
        ' ckOnTop
        ' 
        ckOnTop.AutoSize = True
        ckOnTop.BackColor = Color.Black
        ckOnTop.Checked = True
        ckOnTop.CheckState = CheckState.Checked
        ckOnTop.ForeColor = Color.LimeGreen
        ckOnTop.Location = New Point(653, 14)
        ckOnTop.Name = "ckOnTop"
        ckOnTop.Size = New Size(79, 24)
        ckOnTop.TabIndex = 16
        ckOnTop.Text = "On Top"
        ckOnTop.UseVisualStyleBackColor = False
        ' 
        ' btLoadList
        ' 
        btLoadList.BackColor = Color.Black
        btLoadList.ForeColor = Color.LimeGreen
        btLoadList.Location = New Point(669, 44)
        btLoadList.Name = "btLoadList"
        btLoadList.Size = New Size(107, 33)
        btLoadList.TabIndex = 17
        btLoadList.Text = "Load"
        btLoadList.UseVisualStyleBackColor = False
        ' 
        ' btSaveIP
        ' 
        btSaveIP.BackColor = Color.Black
        btSaveIP.ForeColor = Color.LimeGreen
        btSaveIP.Location = New Point(669, 83)
        btSaveIP.Name = "btSaveIP"
        btSaveIP.Size = New Size(107, 33)
        btSaveIP.TabIndex = 18
        btSaveIP.Text = "Save IP"
        btSaveIP.UseVisualStyleBackColor = False
        ' 
        ' txtOld
        ' 
        txtOld.BackColor = Color.Black
        txtOld.ForeColor = Color.LimeGreen
        txtOld.Location = New Point(12, 380)
        txtOld.Multiline = True
        txtOld.Name = "txtOld"
        txtOld.ScrollBars = ScrollBars.Vertical
        txtOld.Size = New Size(309, 150)
        txtOld.TabIndex = 19
        ' 
        ' lstOld
        ' 
        lstOld.BackColor = Color.Black
        lstOld.ForeColor = Color.LimeGreen
        lstOld.FormattingEnabled = True
        lstOld.Location = New Point(338, 442)
        lstOld.Name = "lstOld"
        lstOld.Size = New Size(309, 104)
        lstOld.Sorted = True
        lstOld.TabIndex = 20
        ' 
        ' lstUnique
        ' 
        lstUnique.BackColor = Color.Black
        lstUnique.ForeColor = Color.LimeGreen
        lstUnique.FormattingEnabled = True
        lstUnique.Location = New Point(338, 595)
        lstUnique.Name = "lstUnique"
        lstUnique.Size = New Size(309, 84)
        lstUnique.Sorted = True
        lstUnique.TabIndex = 21
        ' 
        ' btSaveBatch
        ' 
        btSaveBatch.BackColor = Color.Black
        btSaveBatch.ForeColor = Color.LimeGreen
        btSaveBatch.Location = New Point(669, 123)
        btSaveBatch.Name = "btSaveBatch"
        btSaveBatch.Size = New Size(107, 33)
        btSaveBatch.TabIndex = 22
        btSaveBatch.Text = "Save Batch"
        btSaveBatch.UseVisualStyleBackColor = False
        ' 
        ' ckInBatch
        ' 
        ckInBatch.AutoSize = True
        ckInBatch.Checked = True
        ckInBatch.CheckState = CheckState.Checked
        ckInBatch.Location = New Point(673, 164)
        ckInBatch.Name = "ckInBatch"
        ckInBatch.Size = New Size(84, 24)
        ckInBatch.TabIndex = 23
        ckInBatch.Text = "In Batch"
        ckInBatch.UseVisualStyleBackColor = True
        ' 
        ' ckOutBatch
        ' 
        ckOutBatch.AutoSize = True
        ckOutBatch.Location = New Point(673, 194)
        ckOutBatch.Name = "ckOutBatch"
        ckOutBatch.Size = New Size(96, 24)
        ckOutBatch.TabIndex = 24
        ckOutBatch.Text = "Out Batch"
        ckOutBatch.UseVisualStyleBackColor = True
        ' 
        ' btClearInput
        ' 
        btClearInput.BackColor = Color.Black
        btClearInput.ForeColor = Color.LimeGreen
        btClearInput.Location = New Point(276, 162)
        btClearInput.Name = "btClearInput"
        btClearInput.Size = New Size(45, 33)
        btClearInput.TabIndex = 25
        btClearInput.Text = "X"
        btClearInput.UseVisualStyleBackColor = False
        ' 
        ' btClearOutput
        ' 
        btClearOutput.BackColor = Color.Black
        btClearOutput.ForeColor = Color.LimeGreen
        btClearOutput.Location = New Point(602, 312)
        btClearOutput.Name = "btClearOutput"
        btClearOutput.Size = New Size(45, 33)
        btClearOutput.TabIndex = 26
        btClearOutput.Text = "X"
        btClearOutput.UseVisualStyleBackColor = False
        ' 
        ' btInputGenerateSaveBoth
        ' 
        btInputGenerateSaveBoth.BackColor = Color.Black
        btInputGenerateSaveBoth.ForeColor = Color.LimeGreen
        btInputGenerateSaveBoth.Location = New Point(669, 515)
        btInputGenerateSaveBoth.Name = "btInputGenerateSaveBoth"
        btInputGenerateSaveBoth.Size = New Size(107, 128)
        btInputGenerateSaveBoth.TabIndex = 27
        btInputGenerateSaveBoth.Text = "Input and Generate for In and Out and Save In-Out Batch"
        btInputGenerateSaveBoth.UseVisualStyleBackColor = False
        ' 
        ' btClearOld
        ' 
        btClearOld.BackColor = Color.Black
        btClearOld.ForeColor = Color.LimeGreen
        btClearOld.Location = New Point(602, 552)
        btClearOld.Name = "btClearOld"
        btClearOld.Size = New Size(45, 33)
        btClearOld.TabIndex = 28
        btClearOld.Text = "X"
        btClearOld.UseVisualStyleBackColor = False
        ' 
        ' txtIteratorInput
        ' 
        txtIteratorInput.BackColor = Color.Black
        txtIteratorInput.ForeColor = Color.LimeGreen
        txtIteratorInput.Location = New Point(12, 536)
        txtIteratorInput.Name = "txtIteratorInput"
        txtIteratorInput.Size = New Size(309, 27)
        txtIteratorInput.TabIndex = 29
        txtIteratorInput.Text = "123.123.123.123"
        ' 
        ' ckIter1
        ' 
        ckIter1.AutoSize = True
        ckIter1.Checked = True
        ckIter1.CheckState = CheckState.Checked
        ckIter1.Location = New Point(12, 575)
        ckIter1.Name = "ckIter1"
        ckIter1.Size = New Size(39, 24)
        ckIter1.TabIndex = 30
        ckIter1.Text = "1"
        ckIter1.UseVisualStyleBackColor = True
        ' 
        ' ckIter2
        ' 
        ckIter2.AutoSize = True
        ckIter2.Checked = True
        ckIter2.CheckState = CheckState.Checked
        ckIter2.Location = New Point(57, 575)
        ckIter2.Name = "ckIter2"
        ckIter2.Size = New Size(39, 24)
        ckIter2.TabIndex = 31
        ckIter2.Text = "2"
        ckIter2.UseVisualStyleBackColor = True
        ' 
        ' ckIter3
        ' 
        ckIter3.AutoSize = True
        ckIter3.Checked = True
        ckIter3.CheckState = CheckState.Checked
        ckIter3.Location = New Point(102, 575)
        ckIter3.Name = "ckIter3"
        ckIter3.Size = New Size(39, 24)
        ckIter3.TabIndex = 32
        ckIter3.Text = "3"
        ckIter3.UseVisualStyleBackColor = True
        ' 
        ' ckIter4
        ' 
        ckIter4.AutoSize = True
        ckIter4.Checked = True
        ckIter4.CheckState = CheckState.Checked
        ckIter4.Location = New Point(147, 575)
        ckIter4.Name = "ckIter4"
        ckIter4.Size = New Size(39, 24)
        ckIter4.TabIndex = 33
        ckIter4.Text = "4"
        ckIter4.UseVisualStyleBackColor = True
        ' 
        ' btIterate
        ' 
        btIterate.BackColor = Color.Black
        btIterate.ForeColor = Color.LimeGreen
        btIterate.Location = New Point(192, 573)
        btIterate.Name = "btIterate"
        btIterate.Size = New Size(78, 33)
        btIterate.TabIndex = 34
        btIterate.Text = "Iterate"
        btIterate.UseVisualStyleBackColor = False
        ' 
        ' lstIterator
        ' 
        lstIterator.BackColor = Color.Black
        lstIterator.ForeColor = Color.LimeGreen
        lstIterator.FormattingEnabled = True
        lstIterator.Location = New Point(12, 615)
        lstIterator.Name = "lstIterator"
        lstIterator.Size = New Size(309, 64)
        lstIterator.TabIndex = 35
        ' 
        ' btMoveIterations
        ' 
        btMoveIterations.BackColor = Color.Black
        btMoveIterations.ForeColor = Color.LimeGreen
        btMoveIterations.Location = New Point(276, 573)
        btMoveIterations.Name = "btMoveIterations"
        btMoveIterations.Size = New Size(45, 33)
        btMoveIterations.TabIndex = 36
        btMoveIterations.Text = "^"
        btMoveIterations.UseVisualStyleBackColor = False
        ' 
        ' lbInputGenerateInOutSave
        ' 
        lbInputGenerateInOutSave.Location = New Point(673, 389)
        lbInputGenerateInOutSave.Name = "lbInputGenerateInOutSave"
        lbInputGenerateInOutSave.Size = New Size(98, 123)
        lbInputGenerateInOutSave.TabIndex = 37
        lbInputGenerateInOutSave.Text = "This button works for the input text box and the iteration listbox"
        ' 
        ' btIterateSelected
        ' 
        btIterateSelected.BackColor = Color.Black
        btIterateSelected.ForeColor = Color.LimeGreen
        btIterateSelected.Location = New Point(430, 552)
        btIterateSelected.Name = "btIterateSelected"
        btIterateSelected.Size = New Size(166, 33)
        btIterateSelected.TabIndex = 38
        btIterateSelected.Text = "Iterate Selected Entry"
        btIterateSelected.UseVisualStyleBackColor = False
        ' 
        ' btGenerateFromOld
        ' 
        btGenerateFromOld.BackColor = Color.Black
        btGenerateFromOld.ForeColor = Color.LimeGreen
        btGenerateFromOld.Location = New Point(669, 649)
        btGenerateFromOld.Name = "btGenerateFromOld"
        btGenerateFromOld.Size = New Size(107, 56)
        btGenerateFromOld.TabIndex = 39
        btGenerateFromOld.Text = "Generate From Old List"
        btGenerateFromOld.UseVisualStyleBackColor = False
        ' 
        ' pbSaveLoad
        ' 
        pbSaveLoad.ForeColor = Color.LimeGreen
        pbSaveLoad.Location = New Point(430, 408)
        pbSaveLoad.Name = "pbSaveLoad"
        pbSaveLoad.Size = New Size(217, 28)
        pbSaveLoad.TabIndex = 40
        pbSaveLoad.Value = 1
        pbSaveLoad.Visible = False
        ' 
        ' zLoadtimer
        ' 
        zLoadtimer.Interval = 1000
        ' 
        ' btExtractRemoteAddressFromTCPView
        ' 
        btExtractRemoteAddressFromTCPView.BackColor = Color.ForestGreen
        btExtractRemoteAddressFromTCPView.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btExtractRemoteAddressFromTCPView.ForeColor = Color.Black
        btExtractRemoteAddressFromTCPView.Location = New Point(12, 162)
        btExtractRemoteAddressFromTCPView.Name = "btExtractRemoteAddressFromTCPView"
        btExtractRemoteAddressFromTCPView.Size = New Size(258, 33)
        btExtractRemoteAddressFromTCPView.TabIndex = 41
        btExtractRemoteAddressFromTCPView.Text = "Filter TCPView + IP IGIOSIOBat"
        btExtractRemoteAddressFromTCPView.UseVisualStyleBackColor = False
        ' 
        ' btDontSaveOnExit
        ' 
        btDontSaveOnExit.BackColor = Color.Black
        btDontSaveOnExit.ForeColor = Color.LimeGreen
        btDontSaveOnExit.Location = New Point(743, 5)
        btDontSaveOnExit.Name = "btDontSaveOnExit"
        btDontSaveOnExit.Size = New Size(45, 33)
        btDontSaveOnExit.TabIndex = 42
        btDontSaveOnExit.Text = "X"
        btDontSaveOnExit.UseVisualStyleBackColor = False
        ' 
        ' btFilterAndCopyToClipboard
        ' 
        btFilterAndCopyToClipboard.BackColor = Color.Black
        btFilterAndCopyToClipboard.ForeColor = Color.LimeGreen
        btFilterAndCopyToClipboard.Location = New Point(12, 204)
        btFilterAndCopyToClipboard.Name = "btFilterAndCopyToClipboard"
        btFilterAndCopyToClipboard.Size = New Size(258, 33)
        btFilterAndCopyToClipboard.TabIndex = 43
        btFilterAndCopyToClipboard.Text = "Filter + Copy To Clipboard"
        btFilterAndCopyToClipboard.UseVisualStyleBackColor = False
        ' 
        ' btClearListInput
        ' 
        btClearListInput.BackColor = Color.Black
        btClearListInput.ForeColor = Color.LimeGreen
        btClearListInput.Location = New Point(602, 122)
        btClearListInput.Name = "btClearListInput"
        btClearListInput.Size = New Size(45, 33)
        btClearListInput.TabIndex = 44
        btClearListInput.Text = "X"
        btClearListInput.UseVisualStyleBackColor = False
        ' 
        ' lblstInput
        ' 
        lblstInput.AutoSize = True
        lblstInput.Location = New Point(342, 123)
        lblstInput.Name = "lblstInput"
        lblstInput.Size = New Size(17, 20)
        lblstInput.TabIndex = 45
        lblstInput.Text = "0"
        ' 
        ' lblstOld
        ' 
        lblstOld.AutoSize = True
        lblstOld.Location = New Point(338, 413)
        lblstOld.Name = "lblstOld"
        lblstOld.Size = New Size(17, 20)
        lblstOld.TabIndex = 47
        lblstOld.Text = "0"
        ' 
        ' lblstIterator
        ' 
        lblstIterator.AutoSize = True
        lblstIterator.Location = New Point(12, 685)
        lblstIterator.Name = "lblstIterator"
        lblstIterator.Size = New Size(17, 20)
        lblstIterator.TabIndex = 49
        lblstIterator.Text = "0"
        ' 
        ' lblstUnique
        ' 
        lblstUnique.AutoSize = True
        lblstUnique.Location = New Point(342, 685)
        lblstUnique.Name = "lblstUnique"
        lblstUnique.Size = New Size(17, 20)
        lblstUnique.TabIndex = 50
        lblstUnique.Text = "0"
        ' 
        ' btClearlstUnique
        ' 
        btClearlstUnique.BackColor = Color.Black
        btClearlstUnique.ForeColor = Color.LimeGreen
        btClearlstUnique.Location = New Point(602, 685)
        btClearlstUnique.Name = "btClearlstUnique"
        btClearlstUnique.Size = New Size(45, 33)
        btClearlstUnique.TabIndex = 51
        btClearlstUnique.Text = "X"
        btClearlstUnique.UseVisualStyleBackColor = False
        ' 
        ' btOpenBatchFolder
        ' 
        btOpenBatchFolder.BackColor = Color.Black
        btOpenBatchFolder.ForeColor = Color.LimeGreen
        btOpenBatchFolder.Location = New Point(348, 312)
        btOpenBatchFolder.Name = "btOpenBatchFolder"
        btOpenBatchFolder.Size = New Size(166, 33)
        btOpenBatchFolder.TabIndex = 52
        btOpenBatchFolder.Text = "Open Batch Folder"
        btOpenBatchFolder.UseVisualStyleBackColor = False
        ' 
        ' btOpenListFolder
        ' 
        btOpenListFolder.BackColor = Color.Black
        btOpenListFolder.ForeColor = Color.LimeGreen
        btOpenListFolder.Location = New Point(348, 351)
        btOpenListFolder.Name = "btOpenListFolder"
        btOpenListFolder.Size = New Size(166, 33)
        btOpenListFolder.TabIndex = 53
        btOpenListFolder.Text = "Open List Folder"
        btOpenListFolder.UseVisualStyleBackColor = False
        ' 
        ' btTest
        ' 
        btTest.BackColor = Color.Black
        btTest.ForeColor = Color.LimeGreen
        btTest.Location = New Point(520, 351)
        btTest.Name = "btTest"
        btTest.Size = New Size(127, 33)
        btTest.TabIndex = 54
        btTest.Text = "Test"
        btTest.UseVisualStyleBackColor = False
        btTest.Visible = False
        ' 
        ' frmZBlocker
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.Black
        ClientSize = New Size(800, 729)
        Controls.Add(btTest)
        Controls.Add(btOpenListFolder)
        Controls.Add(btOpenBatchFolder)
        Controls.Add(btClearlstUnique)
        Controls.Add(lblstUnique)
        Controls.Add(lblstIterator)
        Controls.Add(lblstOld)
        Controls.Add(lblstInput)
        Controls.Add(btClearListInput)
        Controls.Add(btFilterAndCopyToClipboard)
        Controls.Add(btDontSaveOnExit)
        Controls.Add(btExtractRemoteAddressFromTCPView)
        Controls.Add(pbSaveLoad)
        Controls.Add(btGenerateFromOld)
        Controls.Add(btIterateSelected)
        Controls.Add(lbInputGenerateInOutSave)
        Controls.Add(btMoveIterations)
        Controls.Add(lstIterator)
        Controls.Add(btIterate)
        Controls.Add(ckIter4)
        Controls.Add(ckIter3)
        Controls.Add(ckIter2)
        Controls.Add(ckIter1)
        Controls.Add(txtIteratorInput)
        Controls.Add(btClearOld)
        Controls.Add(btInputGenerateSaveBoth)
        Controls.Add(btClearOutput)
        Controls.Add(btClearInput)
        Controls.Add(ckOutBatch)
        Controls.Add(ckInBatch)
        Controls.Add(btSaveBatch)
        Controls.Add(lstUnique)
        Controls.Add(lstOld)
        Controls.Add(txtOld)
        Controls.Add(btSaveIP)
        Controls.Add(btLoadList)
        Controls.Add(ckOnTop)
        Controls.Add(btInputGenerate)
        Controls.Add(btGenerate)
        Controls.Add(btOut)
        Controls.Add(btIn)
        Controls.Add(btDef)
        Controls.Add(btCopy)
        Controls.Add(txtOut)
        Controls.Add(btClearInserts)
        Controls.Add(txtI3)
        Controls.Add(txtI2)
        Controls.Add(txtI1)
        Controls.Add(btInput)
        Controls.Add(txtInput)
        Controls.Add(lstInput)
        ForeColor = Color.LimeGreen
        MaximizeBox = False
        Name = "frmZBlocker"
        StartPosition = FormStartPosition.CenterScreen
        Text = "zBlocker"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lstInput As ListBox
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btInput As Button
    Friend WithEvents txtI1 As TextBox
    Friend WithEvents txtI2 As TextBox
    Friend WithEvents txtI3 As TextBox
    Friend WithEvents btClearInserts As Button
    Friend WithEvents txtOut As TextBox
    Friend WithEvents btCopy As Button
    Friend WithEvents btDef As Button
    Friend WithEvents btIn As Button
    Friend WithEvents btOut As Button
    Friend WithEvents btGenerate As Button
    Friend WithEvents btInputGenerate As Button
    Friend WithEvents ckOnTop As CheckBox
    Friend WithEvents btLoadList As Button
    Friend WithEvents btSaveIP As Button
    Friend WithEvents txtOld As TextBox
    Friend WithEvents lstOld As ListBox
    Friend WithEvents lstUnique As ListBox
    Friend WithEvents btSaveBatch As Button
    Friend WithEvents ckInBatch As CheckBox
    Friend WithEvents ckOutBatch As CheckBox
    Friend WithEvents btClearInput As Button
    Friend WithEvents btClearOutput As Button
    Friend WithEvents btInputGenerateSaveBoth As Button
    Friend WithEvents btClearOld As Button
    Friend WithEvents txtIteratorInput As TextBox
    Friend WithEvents ckIter1 As CheckBox
    Friend WithEvents ckIter2 As CheckBox
    Friend WithEvents ckIter3 As CheckBox
    Friend WithEvents ckIter4 As CheckBox
    Friend WithEvents btIterate As Button
    Friend WithEvents lstIterator As ListBox
    Friend WithEvents btMoveIterations As Button
    Friend WithEvents lbInputGenerateInOutSave As Label
    Friend WithEvents btIterateSelected As Button
    Friend WithEvents btGenerateFromOld As Button
    Friend WithEvents pbSaveLoad As ProgressBar
    Friend WithEvents zLoadtimer As Timer
    Friend WithEvents btExtractRemoteAddressFromTCPView As Button
    Friend WithEvents btDontSaveOnExit As Button
    Friend WithEvents btFilterAndCopyToClipboard As Button
    Friend WithEvents btClearListInput As Button
    Friend WithEvents lblstInput As Label
    Friend WithEvents lblstOld As Label
    Friend WithEvents lblstIterator As Label
    Friend WithEvents lblstUnique As Label
    Friend WithEvents btClearlstUnique As Button
    Friend WithEvents btOpenBatchFolder As Button
    Friend WithEvents btOpenListFolder As Button
    Friend WithEvents btTest As Button

End Class
