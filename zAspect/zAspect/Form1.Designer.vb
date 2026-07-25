<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmzAspect
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
        Txt0 = New TextBox()
        Txt2 = New TextBox()
        Txt1 = New TextBox()
        Txt3 = New TextBox()
        BtCalculate = New Button()
        btClear = New Button()
        ckOnTop = New CheckBox()
        btDefault = New Button()
        SuspendLayout()
        ' 
        ' Txt0
        ' 
        Txt0.BackColor = Color.Black
        Txt0.ForeColor = Color.LimeGreen
        Txt0.Location = New Point(12, 12)
        Txt0.Name = "Txt0"
        Txt0.Size = New Size(103, 27)
        Txt0.TabIndex = 0
        Txt0.Text = "0"
        ' 
        ' Txt2
        ' 
        Txt2.BackColor = Color.Black
        Txt2.ForeColor = Color.LimeGreen
        Txt2.Location = New Point(152, 12)
        Txt2.Name = "Txt2"
        Txt2.Size = New Size(103, 27)
        Txt2.TabIndex = 1
        Txt2.Text = "0"
        ' 
        ' Txt1
        ' 
        Txt1.BackColor = Color.Black
        Txt1.ForeColor = Color.LimeGreen
        Txt1.Location = New Point(12, 45)
        Txt1.Name = "Txt1"
        Txt1.Size = New Size(103, 27)
        Txt1.TabIndex = 2
        Txt1.Text = "0"
        ' 
        ' Txt3
        ' 
        Txt3.BackColor = Color.Black
        Txt3.ForeColor = Color.LimeGreen
        Txt3.Location = New Point(152, 45)
        Txt3.Name = "Txt3"
        Txt3.Size = New Size(103, 27)
        Txt3.TabIndex = 3
        Txt3.Text = "0"
        ' 
        ' BtCalculate
        ' 
        BtCalculate.BackColor = Color.Black
        BtCalculate.ForeColor = Color.LimeGreen
        BtCalculate.Location = New Point(152, 114)
        BtCalculate.Name = "BtCalculate"
        BtCalculate.Size = New Size(103, 31)
        BtCalculate.TabIndex = 4
        BtCalculate.Text = "Calculate"
        BtCalculate.UseVisualStyleBackColor = False
        ' 
        ' btClear
        ' 
        btClear.BackColor = Color.Black
        btClear.ForeColor = Color.LimeGreen
        btClear.Location = New Point(12, 114)
        btClear.Name = "btClear"
        btClear.Size = New Size(103, 31)
        btClear.TabIndex = 5
        btClear.Text = "Clear"
        btClear.UseVisualStyleBackColor = False
        ' 
        ' ckOnTop
        ' 
        ckOnTop.AutoSize = True
        ckOnTop.Location = New Point(152, 82)
        ckOnTop.Name = "ckOnTop"
        ckOnTop.Size = New Size(79, 24)
        ckOnTop.TabIndex = 6
        ckOnTop.Text = "On Top"
        ckOnTop.UseVisualStyleBackColor = True
        ' 
        ' btDefault
        ' 
        btDefault.BackColor = Color.Black
        btDefault.ForeColor = Color.LimeGreen
        btDefault.Location = New Point(12, 78)
        btDefault.Name = "btDefault"
        btDefault.Size = New Size(103, 31)
        btDefault.TabIndex = 7
        btDefault.Text = "Default"
        btDefault.UseVisualStyleBackColor = False
        ' 
        ' FrmzAspect
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(279, 157)
        Controls.Add(btDefault)
        Controls.Add(ckOnTop)
        Controls.Add(btClear)
        Controls.Add(BtCalculate)
        Controls.Add(Txt3)
        Controls.Add(Txt1)
        Controls.Add(Txt2)
        Controls.Add(Txt0)
        ForeColor = Color.LimeGreen
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FrmzAspect"
        StartPosition = FormStartPosition.CenterScreen
        Text = "zAspect"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Txt0 As TextBox
    Friend WithEvents Txt2 As TextBox
    Friend WithEvents Txt1 As TextBox
    Friend WithEvents Txt3 As TextBox
    Friend WithEvents BtCalculate As Button
    Friend WithEvents btClear As Button
    Friend WithEvents ckOnTop As CheckBox
    Friend WithEvents btDefault As Button

End Class
