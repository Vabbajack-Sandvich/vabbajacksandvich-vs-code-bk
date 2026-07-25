<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        txtInput = New TextBox()
        ListQuestNames = New ListBox()
        ListQuestIDs = New ListBox()
        btAdd = New Button()
        btGenListWithNames = New Button()
        btClear = New Button()
        ListCompareInput = New ListBox()
        txtCompareOutput = New TextBox()
        SuspendLayout()
        ' 
        ' txtInput
        ' 
        txtInput.Location = New Point(12, 12)
        txtInput.Multiline = True
        txtInput.Name = "txtInput"
        txtInput.ScrollBars = ScrollBars.Vertical
        txtInput.Size = New Size(233, 124)
        txtInput.TabIndex = 0
        ' 
        ' ListQuestNames
        ' 
        ListQuestNames.FormattingEnabled = True
        ListQuestNames.Location = New Point(251, 12)
        ListQuestNames.Name = "ListQuestNames"
        ListQuestNames.Size = New Size(272, 124)
        ListQuestNames.TabIndex = 1
        ' 
        ' ListQuestIDs
        ' 
        ListQuestIDs.FormattingEnabled = True
        ListQuestIDs.Location = New Point(529, 12)
        ListQuestIDs.Name = "ListQuestIDs"
        ListQuestIDs.Size = New Size(272, 124)
        ListQuestIDs.TabIndex = 2
        ' 
        ' btAdd
        ' 
        btAdd.Location = New Point(12, 142)
        btAdd.Name = "btAdd"
        btAdd.Size = New Size(87, 39)
        btAdd.TabIndex = 3
        btAdd.Text = "Add"
        btAdd.UseVisualStyleBackColor = True
        ' 
        ' btGenListWithNames
        ' 
        btGenListWithNames.Location = New Point(12, 187)
        btGenListWithNames.Name = "btGenListWithNames"
        btGenListWithNames.Size = New Size(162, 39)
        btGenListWithNames.TabIndex = 4
        btGenListWithNames.Text = "btGenListWithNames"
        btGenListWithNames.UseVisualStyleBackColor = True
        ' 
        ' btClear
        ' 
        btClear.Location = New Point(155, 142)
        btClear.Name = "btClear"
        btClear.Size = New Size(90, 39)
        btClear.TabIndex = 5
        btClear.Text = "Clear"
        btClear.UseVisualStyleBackColor = True
        ' 
        ' ListCompareInput
        ' 
        ListCompareInput.FormattingEnabled = True
        ListCompareInput.Location = New Point(251, 142)
        ListCompareInput.Name = "ListCompareInput"
        ListCompareInput.Size = New Size(272, 124)
        ListCompareInput.TabIndex = 6
        ' 
        ' txtCompareOutput
        ' 
        txtCompareOutput.Location = New Point(251, 272)
        txtCompareOutput.Multiline = True
        txtCompareOutput.Name = "txtCompareOutput"
        txtCompareOutput.ScrollBars = ScrollBars.Vertical
        txtCompareOutput.Size = New Size(440, 124)
        txtCompareOutput.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(821, 450)
        Controls.Add(txtCompareOutput)
        Controls.Add(ListCompareInput)
        Controls.Add(btClear)
        Controls.Add(btGenListWithNames)
        Controls.Add(btAdd)
        Controls.Add(ListQuestIDs)
        Controls.Add(ListQuestNames)
        Controls.Add(txtInput)
        Name = "Form1"
        Text = "zOblivionQuestCompare"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtInput As TextBox
    Friend WithEvents ListQuestNames As ListBox
    Friend WithEvents ListQuestIDs As ListBox
    Friend WithEvents btAdd As Button
    Friend WithEvents btGenListWithNames As Button
    Friend WithEvents btClear As Button
    Friend WithEvents ListCompareInput As ListBox
    Friend WithEvents txtCompareOutput As TextBox

End Class
