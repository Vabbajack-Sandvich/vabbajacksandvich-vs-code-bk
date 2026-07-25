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
        txtPPM = New TextBox()
        txtNumMachines = New TextBox()
        txtNewIO = New TextBox()
        btCalc = New Button()
        txtConverted = New TextBox()
        lbPPM = New Label()
        lbNumberMachinesCube = New Label()
        lbNewValue = New Label()
        lbConvertedValue = New Label()
        txtCalcCubeBase = New TextBox()
        lbCalcCubeBase = New Label()
        btDefault = New Button()
        lbAbout = New Label()
        ckOnTop = New CheckBox()
        btAbout = New Button()
        lbInput0 = New Label()
        lbInput1 = New Label()
        lbInput2 = New Label()
        lbInput4 = New Label()
        ckHelp = New CheckBox()
        lbInput3 = New Label()
        SuspendLayout()
        ' 
        ' txtPPM
        ' 
        txtPPM.BackColor = Color.Black
        txtPPM.ForeColor = Color.LimeGreen
        txtPPM.Location = New Point(20, 106)
        txtPPM.Margin = New Padding(2)
        txtPPM.Name = "txtPPM"
        txtPPM.Size = New Size(89, 27)
        txtPPM.TabIndex = 0
        ' 
        ' txtNumMachines
        ' 
        txtNumMachines.BackColor = Color.Black
        txtNumMachines.ForeColor = Color.LimeGreen
        txtNumMachines.Location = New Point(20, 163)
        txtNumMachines.Margin = New Padding(2)
        txtNumMachines.Name = "txtNumMachines"
        txtNumMachines.Size = New Size(89, 27)
        txtNumMachines.TabIndex = 1
        ' 
        ' txtNewIO
        ' 
        txtNewIO.BackColor = Color.Black
        txtNewIO.ForeColor = Color.LimeGreen
        txtNewIO.Location = New Point(21, 219)
        txtNewIO.Margin = New Padding(2)
        txtNewIO.Name = "txtNewIO"
        txtNewIO.Size = New Size(89, 27)
        txtNewIO.TabIndex = 3
        ' 
        ' btCalc
        ' 
        btCalc.BackColor = Color.Black
        btCalc.ForeColor = Color.LimeGreen
        btCalc.Location = New Point(232, 402)
        btCalc.Margin = New Padding(2)
        btCalc.Name = "btCalc"
        btCalc.Size = New Size(97, 27)
        btCalc.TabIndex = 5
        btCalc.Text = "Calculate"
        btCalc.UseVisualStyleBackColor = False
        ' 
        ' txtConverted
        ' 
        txtConverted.BackColor = Color.Black
        txtConverted.ForeColor = Color.LimeGreen
        txtConverted.Location = New Point(31, 353)
        txtConverted.Margin = New Padding(2)
        txtConverted.Name = "txtConverted"
        txtConverted.Size = New Size(89, 27)
        txtConverted.TabIndex = 4
        ' 
        ' lbPPM
        ' 
        lbPPM.AutoSize = True
        lbPPM.BackColor = Color.Black
        lbPPM.ForeColor = Color.LimeGreen
        lbPPM.Location = New Point(17, 80)
        lbPPM.Margin = New Padding(2, 0, 2, 0)
        lbPPM.Name = "lbPPM"
        lbPPM.Size = New Size(159, 20)
        lbPPM.TabIndex = 5
        lbPPM.Text = "Input PPM x 1 Machine"
        ' 
        ' lbNumberMachinesCube
        ' 
        lbNumberMachinesCube.AutoSize = True
        lbNumberMachinesCube.BackColor = Color.Black
        lbNumberMachinesCube.ForeColor = Color.LimeGreen
        lbNumberMachinesCube.Location = New Point(17, 137)
        lbNumberMachinesCube.Margin = New Padding(2, 0, 2, 0)
        lbNumberMachinesCube.Name = "lbNumberMachinesCube"
        lbNumberMachinesCube.Size = New Size(190, 20)
        lbNumberMachinesCube.TabIndex = 6
        lbNumberMachinesCube.Text = "Number Of Machines In Set"
        ' 
        ' lbNewValue
        ' 
        lbNewValue.AutoSize = True
        lbNewValue.BackColor = Color.Black
        lbNewValue.ForeColor = Color.LimeGreen
        lbNewValue.Location = New Point(17, 194)
        lbNewValue.Margin = New Padding(2, 0, 2, 0)
        lbNewValue.Name = "lbNewValue"
        lbNewValue.Size = New Size(150, 20)
        lbNewValue.TabIndex = 7
        lbNewValue.Text = "New PPM Input Value"
        ' 
        ' lbConvertedValue
        ' 
        lbConvertedValue.AutoSize = True
        lbConvertedValue.BackColor = Color.Black
        lbConvertedValue.ForeColor = Color.LimeGreen
        lbConvertedValue.Location = New Point(25, 315)
        lbConvertedValue.Margin = New Padding(2, 0, 2, 0)
        lbConvertedValue.Name = "lbConvertedValue"
        lbConvertedValue.Size = New Size(322, 20)
        lbConvertedValue.TabIndex = 8
        lbConvertedValue.Text = "Converted Percent Value To Set All Machines To"
        ' 
        ' txtCalcCubeBase
        ' 
        txtCalcCubeBase.BackColor = Color.Black
        txtCalcCubeBase.ForeColor = Color.LimeGreen
        txtCalcCubeBase.Location = New Point(20, 277)
        txtCalcCubeBase.Margin = New Padding(2)
        txtCalcCubeBase.Name = "txtCalcCubeBase"
        txtCalcCubeBase.Size = New Size(89, 27)
        txtCalcCubeBase.TabIndex = 2
        ' 
        ' lbCalcCubeBase
        ' 
        lbCalcCubeBase.AutoSize = True
        lbCalcCubeBase.BackColor = Color.Black
        lbCalcCubeBase.ForeColor = Color.LimeGreen
        lbCalcCubeBase.Location = New Point(17, 251)
        lbCalcCubeBase.Margin = New Padding(2, 0, 2, 0)
        lbCalcCubeBase.Name = "lbCalcCubeBase"
        lbCalcCubeBase.Size = New Size(139, 20)
        lbCalcCubeBase.TabIndex = 10
        lbCalcCubeBase.Text = "Calculated Set Base"
        ' 
        ' btDefault
        ' 
        btDefault.BackColor = Color.Black
        btDefault.ForeColor = Color.LimeGreen
        btDefault.Location = New Point(134, 402)
        btDefault.Margin = New Padding(2)
        btDefault.Name = "btDefault"
        btDefault.Size = New Size(94, 27)
        btDefault.TabIndex = 6
        btDefault.TabStop = False
        btDefault.Text = "Default"
        btDefault.UseVisualStyleBackColor = False
        ' 
        ' lbAbout
        ' 
        lbAbout.BackColor = Color.Black
        lbAbout.Font = New Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbAbout.ForeColor = Color.LimeGreen
        lbAbout.Location = New Point(-13, 9)
        lbAbout.Margin = New Padding(2, 0, 2, 0)
        lbAbout.Name = "lbAbout"
        lbAbout.Size = New Size(326, 70)
        lbAbout.TabIndex = 13
        lbAbout.Text = "By: Vabbajack Sandvich" & vbCrLf & "youtube channel:" & vbCrLf & "https://www.youtube.com/@vabbajack-sandvich" & vbCrLf & "double click to copy link" & vbCrLf
        lbAbout.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ckOnTop
        ' 
        ckOnTop.AutoSize = True
        ckOnTop.BackColor = Color.Black
        ckOnTop.Checked = True
        ckOnTop.CheckState = CheckState.Checked
        ckOnTop.ForeColor = Color.LimeGreen
        ckOnTop.Location = New Point(286, 11)
        ckOnTop.Margin = New Padding(2)
        ckOnTop.Name = "ckOnTop"
        ckOnTop.Size = New Size(79, 24)
        ckOnTop.TabIndex = 7
        ckOnTop.Text = "On Top"
        ckOnTop.UseVisualStyleBackColor = False
        ' 
        ' btAbout
        ' 
        btAbout.BackColor = Color.Black
        btAbout.ForeColor = Color.LimeGreen
        btAbout.Location = New Point(36, 402)
        btAbout.Margin = New Padding(2)
        btAbout.Name = "btAbout"
        btAbout.Size = New Size(94, 27)
        btAbout.TabIndex = 14
        btAbout.TabStop = False
        btAbout.Text = "About"
        btAbout.UseVisualStyleBackColor = False
        ' 
        ' lbInput0
        ' 
        lbInput0.AutoSize = True
        lbInput0.BackColor = Color.Black
        lbInput0.ForeColor = Color.DarkGray
        lbInput0.Location = New Point(194, 106)
        lbInput0.Margin = New Padding(2, 0, 2, 0)
        lbInput0.Name = "lbInput0"
        lbInput0.Size = New Size(140, 20)
        lbInput0.TabIndex = 15
        lbInput0.Text = "< - input in to these"
        ' 
        ' lbInput1
        ' 
        lbInput1.AutoSize = True
        lbInput1.BackColor = Color.Black
        lbInput1.ForeColor = Color.DarkGray
        lbInput1.Location = New Point(195, 163)
        lbInput1.Margin = New Padding(2, 0, 2, 0)
        lbInput1.Name = "lbInput1"
        lbInput1.Size = New Size(140, 20)
        lbInput1.TabIndex = 16
        lbInput1.Text = "< - input in to these"
        ' 
        ' lbInput2
        ' 
        lbInput2.AutoSize = True
        lbInput2.BackColor = Color.Black
        lbInput2.ForeColor = Color.DarkGray
        lbInput2.Location = New Point(195, 219)
        lbInput2.Margin = New Padding(2, 0, 2, 0)
        lbInput2.Name = "lbInput2"
        lbInput2.Size = New Size(140, 20)
        lbInput2.TabIndex = 17
        lbInput2.Text = "< - input in to these"
        ' 
        ' lbInput4
        ' 
        lbInput4.BackColor = Color.Black
        lbInput4.Font = New Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbInput4.ForeColor = Color.DarkGray
        lbInput4.Location = New Point(133, 339)
        lbInput4.Margin = New Padding(2, 0, 2, 0)
        lbInput4.Name = "lbInput4"
        lbInput4.Size = New Size(221, 55)
        lbInput4.TabIndex = 18
        lbInput4.Text = "< - paste this in all the machines" & vbCrLf & "in the blueprint. hitting enter calculates and copies to clipboard."
        ' 
        ' ckHelp
        ' 
        ckHelp.AutoSize = True
        ckHelp.BackColor = Color.Black
        ckHelp.ForeColor = Color.DarkGray
        ckHelp.Location = New Point(238, 80)
        ckHelp.Margin = New Padding(2)
        ckHelp.Name = "ckHelp"
        ckHelp.Size = New Size(63, 24)
        ckHelp.TabIndex = 19
        ckHelp.Text = "Help"
        ckHelp.UseVisualStyleBackColor = False
        ' 
        ' lbInput3
        ' 
        lbInput3.AutoSize = True
        lbInput3.BackColor = Color.Black
        lbInput3.ForeColor = Color.DarkGray
        lbInput3.Location = New Point(214, 277)
        lbInput3.Margin = New Padding(2, 0, 2, 0)
        lbInput3.Name = "lbInput3"
        lbInput3.Size = New Size(103, 20)
        lbInput3.TabIndex = 20
        lbInput3.Text = "< - ignore this"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(374, 446)
        Controls.Add(lbInput3)
        Controls.Add(ckHelp)
        Controls.Add(lbInput4)
        Controls.Add(lbInput2)
        Controls.Add(lbInput1)
        Controls.Add(lbInput0)
        Controls.Add(btAbout)
        Controls.Add(ckOnTop)
        Controls.Add(lbAbout)
        Controls.Add(btDefault)
        Controls.Add(lbCalcCubeBase)
        Controls.Add(txtCalcCubeBase)
        Controls.Add(lbConvertedValue)
        Controls.Add(lbNewValue)
        Controls.Add(lbNumberMachinesCube)
        Controls.Add(lbPPM)
        Controls.Add(txtConverted)
        Controls.Add(btCalc)
        Controls.Add(txtNewIO)
        Controls.Add(txtNumMachines)
        Controls.Add(txtPPM)
        ForeColor = Color.LimeGreen
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(2)
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Machine Set Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtPPM As TextBox
    Friend WithEvents txtNumMachines As TextBox
    Friend WithEvents txtNewIO As TextBox
    Friend WithEvents btCalc As Button
    Friend WithEvents txtConverted As TextBox
    Friend WithEvents lbPPM As Label
    Friend WithEvents lbNumberMachinesCube As Label
    Friend WithEvents lbNewValue As Label
    Friend WithEvents lbConvertedValue As Label
    Friend WithEvents txtCalcCubeBase As TextBox
    Friend WithEvents lbCalcCubeBase As Label
    Friend WithEvents btDefault As Button
    Friend WithEvents lbAbout As Label
    Friend WithEvents ckOnTop As CheckBox
    Friend WithEvents btAbout As Button
    Friend WithEvents lbInput0 As Label
    Friend WithEvents lbInput1 As Label
    Friend WithEvents lbInput2 As Label
    Friend WithEvents lbInput4 As Label
    Friend WithEvents ckHelp As CheckBox
    Friend WithEvents lbInput3 As Label

End Class
