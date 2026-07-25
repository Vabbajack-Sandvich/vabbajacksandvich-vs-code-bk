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
        btCopy = New Button()
        txtTitle = New TextBox()
        txtIncrement = New TextBox()
        btIncrement = New Button()
        btCopyIncrement = New Button()
        ckOnTop = New CheckBox()
        btDecrement = New Button()
        DateTimePicker1 = New DateTimePicker()
        btIncDate2DaysCopy = New Button()
        SuspendLayout()
        ' 
        ' btCopy
        ' 
        btCopy.BackColor = Color.Black
        btCopy.Font = New Font("Segoe UI", 10.2F)
        btCopy.ForeColor = Color.LimeGreen
        btCopy.Location = New Point(551, 12)
        btCopy.Name = "btCopy"
        btCopy.Size = New Size(153, 35)
        btCopy.TabIndex = 0
        btCopy.Text = "Copy"
        btCopy.UseVisualStyleBackColor = False
        ' 
        ' txtTitle
        ' 
        txtTitle.BackColor = Color.Black
        txtTitle.Font = New Font("Segoe UI", 10.2F)
        txtTitle.ForeColor = Color.LimeGreen
        txtTitle.Location = New Point(13, 12)
        txtTitle.Name = "txtTitle"
        txtTitle.Size = New Size(444, 30)
        txtTitle.TabIndex = 1
        ' 
        ' txtIncrement
        ' 
        txtIncrement.BackColor = Color.Black
        txtIncrement.Font = New Font("Segoe UI", 10.2F)
        txtIncrement.ForeColor = Color.LimeGreen
        txtIncrement.Location = New Point(464, 12)
        txtIncrement.Name = "txtIncrement"
        txtIncrement.Size = New Size(81, 30)
        txtIncrement.TabIndex = 2
        ' 
        ' btIncrement
        ' 
        btIncrement.BackColor = Color.Black
        btIncrement.Font = New Font("Segoe UI", 10.2F)
        btIncrement.ForeColor = Color.LimeGreen
        btIncrement.Location = New Point(710, 12)
        btIncrement.Name = "btIncrement"
        btIncrement.Size = New Size(65, 35)
        btIncrement.TabIndex = 3
        btIncrement.Text = "+"
        btIncrement.UseVisualStyleBackColor = False
        ' 
        ' btCopyIncrement
        ' 
        btCopyIncrement.BackColor = Color.Black
        btCopyIncrement.Font = New Font("Segoe UI", 10.2F)
        btCopyIncrement.ForeColor = Color.LimeGreen
        btCopyIncrement.Location = New Point(509, 49)
        btCopyIncrement.Name = "btCopyIncrement"
        btCopyIncrement.Size = New Size(241, 35)
        btCopyIncrement.TabIndex = 4
        btCopyIncrement.Text = "Copy +"
        btCopyIncrement.UseVisualStyleBackColor = False
        ' 
        ' ckOnTop
        ' 
        ckOnTop.AutoSize = True
        ckOnTop.Checked = True
        ckOnTop.CheckState = CheckState.Checked
        ckOnTop.Font = New Font("Segoe UI", 10.2F)
        ckOnTop.Location = New Point(756, 53)
        ckOnTop.Name = "ckOnTop"
        ckOnTop.Size = New Size(82, 27)
        ckOnTop.TabIndex = 5
        ckOnTop.Text = "OnTop"
        ckOnTop.UseVisualStyleBackColor = True
        ' 
        ' btDecrement
        ' 
        btDecrement.BackColor = Color.Black
        btDecrement.Font = New Font("Segoe UI", 10.2F)
        btDecrement.ForeColor = Color.LimeGreen
        btDecrement.Location = New Point(781, 12)
        btDecrement.Name = "btDecrement"
        btDecrement.Size = New Size(65, 35)
        btDecrement.TabIndex = 6
        btDecrement.Text = "-"
        btDecrement.UseVisualStyleBackColor = False
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Segoe UI", 10.2F)
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.Location = New Point(12, 50)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(204, 30)
        DateTimePicker1.TabIndex = 7
        ' 
        ' btIncDate2DaysCopy
        ' 
        btIncDate2DaysCopy.BackColor = Color.Black
        btIncDate2DaysCopy.Font = New Font("Segoe UI", 10.2F)
        btIncDate2DaysCopy.ForeColor = Color.LimeGreen
        btIncDate2DaysCopy.Location = New Point(223, 49)
        btIncDate2DaysCopy.Name = "btIncDate2DaysCopy"
        btIncDate2DaysCopy.Size = New Size(280, 35)
        btIncDate2DaysCopy.TabIndex = 8
        btIncDate2DaysCopy.Text = "Inc Date 2 Days Copy"
        btIncDate2DaysCopy.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13.0F, 30.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(856, 91)
        Controls.Add(btIncDate2DaysCopy)
        Controls.Add(DateTimePicker1)
        Controls.Add(btDecrement)
        Controls.Add(ckOnTop)
        Controls.Add(btCopyIncrement)
        Controls.Add(btIncrement)
        Controls.Add(txtIncrement)
        Controls.Add(txtTitle)
        Controls.Add(btCopy)
        Font = New Font("Segoe UI", 13.2000008F, FontStyle.Bold)
        ForeColor = Color.LimeGreen
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Title Date Incrementor"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btCopy As Button
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtIncrement As TextBox
    Friend WithEvents btIncrement As Button
    Friend WithEvents btCopyIncrement As Button
    Friend WithEvents ckOnTop As CheckBox
    Friend WithEvents btDecrement As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btIncDate2DaysCopy As Button

End Class
