<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResizer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        lbResizerX = New Label()
        tmrResizeUpdateTimer = New Timer(components)
        tmrResizeRunOnce = New Timer(components)
        SuspendLayout()
        ' 
        ' lbResizerX
        ' 
        lbResizerX.ForeColor = Color.FromArgb(CByte(4), CByte(213), CByte(20))
        lbResizerX.Location = New Point(0, 0)
        lbResizerX.Name = "lbResizerX"
        lbResizerX.Size = New Size(34, 36)
        lbResizerX.TabIndex = 0
        lbResizerX.Text = "X"
        lbResizerX.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' tmrResizeUpdateTimer
        ' 
        tmrResizeUpdateTimer.Interval = 1000
        ' 
        ' tmrResizeRunOnce
        ' 
        tmrResizeRunOnce.Interval = 1000
        ' 
        ' frmResizer
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = Color.Black
        ClientSize = New Size(133, 85)
        ControlBox = False
        Controls.Add(lbResizerX)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmResizer"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmResizer"
        TopMost = True
        ResumeLayout(False)
    End Sub

    Friend WithEvents lbResizerX As Label
    Friend WithEvents tmrResizeUpdateTimer As Timer
    Friend WithEvents tmrResizeRunOnce As Timer
End Class
