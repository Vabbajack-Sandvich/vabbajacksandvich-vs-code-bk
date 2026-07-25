Imports System.ComponentModel
Imports System.IO

Public Class Form1
    Public zBasePath As String
    Public zBaseFileName As String
    Public zBpFn As String

    Public zFindIndexList(1000) As Integer

    Public zFindPreviousLen As Integer = 0

    Private Sub btLoad_Click(sender As Object, e As EventArgs) Handles btLoad.Click
        Dim zFe As Boolean
        zFe = File.Exists(zBpFn)
        If zFe = False Then
            My.Computer.FileSystem.WriteAllText(zBpFn, "Craft-Notes-0 Log File" & vbCrLf, False)
        Else
            Dim zfileReader As String
            zfileReader = My.Computer.FileSystem.ReadAllText(zBpFn)
            txtLog.Text = zfileReader
        End If
    End Sub

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click
        My.Computer.FileSystem.WriteAllText(zBpFn, txtLog.Text, False)
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'get documents path
        Dim baseDir As String
        baseDir = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        'txtBaseDir.Text = baseDir
        'check if craft-notes folder exists
        Dim DirEx As Boolean
        Dim bdwCn As String
        'base directory with craft-notes
        bdwCn = baseDir & "\craft-notes-0"
        txtBaseDir.Text = bdwCn
        zBasePath = bdwCn
        DirEx = Directory.Exists(bdwCn)
        If DirEx = False Then
            'if not make folder for craft-notes
            My.Computer.FileSystem.CreateDirectory(zBasePath)
        End If
        zBaseFileName = "craft-notes-0.txt"
        zBpFn = zBasePath & "\" & zBaseFileName
        Dim zFe As Boolean
        zFe = File.Exists(zBpFn)
        Dim zfileReader As String
        If zFe = False Then
            My.Computer.FileSystem.WriteAllText(zBpFn, "Craft-Notes-0 Log File" & vbCrLf, False)
            zfileReader = My.Computer.FileSystem.ReadAllText(zBpFn)
            txtLog.Text = zfileReader
        Else
            zfileReader = My.Computer.FileSystem.ReadAllText(zBpFn)
            txtLog.Text = zfileReader
        End If

        txtLog.SelectionStart = 0

        tmrStart.Enabled = True

        Me.TopMost = True

        'for test
        'test works
        'it operate everything on form1 txtlog
        'just like it was it was its own thing
        'so i just have to add this to whatever project
        'kind of like an import
        frmTextBoxFindPopUpModular.zTxtLog = txtLog
        frmTextBoxFindPopUpModular.zFormTemp = Me

    End Sub

    Private Sub btOpenBasePath_Click(sender As Object, e As EventArgs) Handles btOpenBasePath.Click
        Dim DirEx As Boolean
        DirEx = Directory.Exists(zBasePath)
        If DirEx = True Then
            Shell("explorer " & zBasePath, AppWinStyle.NormalFocus)
        Else
            My.Computer.FileSystem.CreateDirectory(zBasePath)
            Shell("explorer " & zBasePath, AppWinStyle.NormalFocus)
        End If
    End Sub

    Private Sub txtLog_TextChanged(sender As Object, e As EventArgs) Handles txtLog.TextChanged

    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        My.Computer.FileSystem.WriteAllText(zBpFn, txtLog.Text, False)
    End Sub

    Private Sub btTimestamp_Click(sender As Object, e As EventArgs) Handles btTimestamp.Click
        'txtLog.Focus()
        Dim zTs As String
        zTs = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")

        If txtLog.Text = vbNullString Then
            'txtLog.Text = txtLog.Text & vbCrLf & vbCrLf & zTs & vbCrLf & vbCrLf
            'txtLog.Text = vbCrLf & zTs & vbCrLf & vbCrLf
            txtLog.Text = vbCrLf & zTs & vbCrLf
            txtLog.SelectionStart = Len(txtLog.Text)
            txtLog.Select()
            txtLog.ScrollToCaret()
            Exit Sub
        Else
            If txtLog.SelectionStart = -1 Then
                'txtLog.Text = txtLog.Text & vbCrLf & vbCrLf & zTs & vbCrLf & vbCrLf
                'txtLog.Text = txtLog.Text & vbCrLf & zTs & vbCrLf & vbCrLf
                txtLog.Text = txtLog.Text & vbCrLf & zTs & vbCrLf
                txtLog.SelectionStart = Len(txtLog.Text)
                txtLog.Select()
                txtLog.ScrollToCaret()
                Exit Sub
            ElseIf txtLog.SelectionStart = 0 Then
                txtLog.SelectionStart = 1
            End If
        End If

        Dim zBefore As String
        Dim zAfter As String
        zBefore = Mid(txtLog.Text, 1, txtLog.SelectionStart)
        'MsgBox(zBefore)
        zAfter = Mid(txtLog.Text, txtLog.SelectionStart + 1, Len(txtLog.Text))
        'MsgBox(zAfter)

        If txtLog.SelectionStart = Len(txtLog.Text) Then
            zAfter = vbNullString
        End If

        txtLog.Text = zBefore & vbCrLf & vbCrLf & zTs & vbCrLf & vbCrLf & zAfter

        txtLog.SelectionStart = Len(zBefore & vbCrLf & vbCrLf & zTs & vbCrLf & vbCrLf) - 1

        txtLog.Select()
        txtLog.ScrollToCaret()
    End Sub

    Private Sub btCalc_Click(sender As Object, e As EventArgs) Handles btCalc.Click
        txtX.Text = zTrimLeadingZero(txtX.Text)
        txtY.Text = zTrimLeadingZero(txtY.Text)
        txtZ.Text = zTrimLeadingZero(txtZ.Text)

        If txtX.Text = vbNullString Then Exit Sub
        If txtY.Text = vbNullString Then Exit Sub
        If txtZ.Text = vbNullString Then Exit Sub

        Dim zX As Decimal
        'Dim zY As Decimal
        Dim zZ As Decimal

        zX = Convert.ToInt64(txtX.Text)
        'zY = Convert.ToInt64(txtY.Text)
        zZ = Convert.ToInt64(txtZ.Text)

        If ckRound.Checked = False Then
            'no rounding
            txtOX.Text = Convert.ToString(zX * 8)
            'txtOY.Text = Convert.ToString(zY * 8)
            txtOY.Text = txtY.Text
            txtOZ.Text = Convert.ToString(zZ * 8)

            txtNX.Text = Convert.ToString(zX / 8)
            'txtNY.Text = Convert.ToString(zY / 8)
            txtNY.Text = txtY.Text
            txtNZ.Text = Convert.ToString(zZ / 8)
        Else
            'rounding up
            txtOX.Text = Convert.ToString(Math.Round(zX * 8))
            'txtOY.Text = Convert.ToString(zY * 8)
            txtOY.Text = txtY.Text
            txtOZ.Text = Convert.ToString(Math.Round(zZ * 8))

            txtNX.Text = Convert.ToString(Math.Round(zX / 8))
            'txtNY.Text = Convert.ToString(zY / 8)
            txtNY.Text = txtY.Text
            txtNZ.Text = Convert.ToString(Math.Round(zZ / 8))
        End If
    End Sub

    Private Sub btInsertO_Click(sender As Object, e As EventArgs) Handles btInsertO.Click

        txtX.Text = zTrimLeadingZero(txtX.Text)
        txtY.Text = zTrimLeadingZero(txtY.Text)
        txtZ.Text = zTrimLeadingZero(txtZ.Text)

        txtOX.Text = zTrimLeadingZero(txtOX.Text)
        txtOY.Text = zTrimLeadingZero(txtOY.Text)
        txtOZ.Text = zTrimLeadingZero(txtOZ.Text)

        txtNX.Text = zTrimLeadingZero(txtNX.Text)
        txtNY.Text = zTrimLeadingZero(txtNY.Text)
        txtNZ.Text = zTrimLeadingZero(txtNZ.Text)

        If txtOX.Text = vbNullString Then Exit Sub
        If txtOY.Text = vbNullString Then Exit Sub
        If txtOZ.Text = vbNullString Then Exit Sub

        Dim zOp As String
        Dim zXYZ As String

        If ckInsertOpposite.Checked = False Then
            zXYZ = "o" & vbCrLf & txtOX.Text & " " & txtOY.Text & " " & txtOZ.Text
        Else
            'old - switching order of n an o so that o is always on top
            'zOp = "n" & vbCrLf & txtX.Text & " " & txtY.Text & " " & txtZ.Text & vbCrLf
            'zXYZ = zOp & "o" & vbCrLf & txtOX.Text & " " & txtOY.Text & " " & txtOZ.Text
            zOp = "n - initial coordinates" & vbCrLf & txtX.Text & " " & txtY.Text & " " & txtZ.Text
            'zXYZ = "o" & vbCrLf & txtOX.Text & " " & txtOY.Text & " " & txtOZ.Text & vbCrLf & zOp
            'zXYZ = "nether to the overworld" & vbCrLf & "o" & vbCrLf & txtOX.Text & " " & txtOY.Text & " " & txtOZ.Text & vbCrLf & zOp
            zXYZ = "nether to the overworld" & vbCrLf & "o - should be" & vbCrLf & txtOX.Text & " " & txtOY.Text & " " & txtOZ.Text & vbCrLf & zOp
        End If

        If txtLog.Text = vbNullString Then
            'txtLog.Text = txtLog.Text & vbCrLf & vbCrLf & zXYZ & vbCrLf & vbCrLf
            'txtLog.Text = vbCrLf & zXYZ & vbCrLf & vbCrLf
            txtLog.Text = vbCrLf & zXYZ & vbCrLf
            txtLog.SelectionStart = Len(txtLog.Text)
            txtLog.Select()
            txtLog.ScrollToCaret()
            Exit Sub
        Else
            'txtLog.Focus()
            If txtLog.SelectionStart = -1 Then
                'txtLog.Text = txtLog.Text & vbCrLf & vbCrLf & zXYZ & vbCrLf & vbCrLf
                txtLog.Text = txtLog.Text & vbCrLf & zXYZ & vbCrLf
                txtLog.SelectionStart = Len(txtLog.Text)
                txtLog.Select()
                txtLog.ScrollToCaret()
                Exit Sub
            ElseIf txtLog.SelectionStart = 0 Then
                txtLog.SelectionStart = 1
            End If
        End If

        Dim zBefore As String
        Dim zAfter As String
        zBefore = Mid(txtLog.Text, 1, txtLog.SelectionStart)
        'MsgBox(zBefore)
        zAfter = Mid(txtLog.Text, txtLog.SelectionStart + 1, Len(txtLog.Text))
        'MsgBox(zAfter)

        If txtLog.SelectionStart = Len(txtLog.Text) Then
            zAfter = vbNullString
        End If

        'txtLog.Text = zBefore & vbCrLf & vbCrLf & zXYZ & vbCrLf & vbCrLf & zAfter
        txtLog.Text = zBefore & zXYZ & vbCrLf & vbCrLf & zAfter
        'txtLog.Text = zBefore & zXYZ & vbCrLf & zAfter

        'txtLog.SelectionStart = Len(zBefore & vbCrLf & vbCrLf & zXYZ & vbCrLf & vbCrLf) - 1
        'txtLog.SelectionStart = Len(zBefore & zXYZ & vbCrLf & vbCrLf) - 1
        'txtLog.SelectionStart = Len(zBefore & zXYZ & vbCrLf) - 1
        txtLog.SelectionStart = Len(zBefore & zXYZ & vbCrLf)
        'txtLog.SelectionStart = Len(zBefore & zXYZ & vbCrLf) + 1

        txtLog.Select()
        txtLog.ScrollToCaret()
    End Sub

    Private Sub btInsertN_Click(sender As Object, e As EventArgs) Handles btInsertN.Click
        'txtLog.Focus()

        txtX.Text = zTrimLeadingZero(txtX.Text)
        txtY.Text = zTrimLeadingZero(txtY.Text)
        txtZ.Text = zTrimLeadingZero(txtZ.Text)

        txtOX.Text = zTrimLeadingZero(txtOX.Text)
        txtOY.Text = zTrimLeadingZero(txtOY.Text)
        txtOZ.Text = zTrimLeadingZero(txtOZ.Text)

        txtNX.Text = zTrimLeadingZero(txtNX.Text)
        txtNY.Text = zTrimLeadingZero(txtNY.Text)
        txtNZ.Text = zTrimLeadingZero(txtNZ.Text)

        If txtNX.Text = vbNullString Then Exit Sub
        If txtNY.Text = vbNullString Then Exit Sub
        If txtNZ.Text = vbNullString Then Exit Sub

        Dim zOp As String
        Dim zXYZ As String

        'zXYZ = "n" & vbCrLf & txtNX.Text & " " & txtNY.Text & " " & txtNZ.Text

        If ckInsertOpposite.Checked = False Then
            zXYZ = "n" & vbCrLf & txtNX.Text & " " & txtNY.Text & " " & txtNZ.Text
        Else
            zOp = "o - initial coordinates" & vbCrLf & txtX.Text & " " & txtY.Text & " " & txtZ.Text & vbCrLf
            'zXYZ = zOp & "n" & vbCrLf & txtNX.Text & " " & txtNY.Text & " " & txtNZ.Text
            'zXYZ = "overworld to the nether" & vbCrLf & zOp & "n" & vbCrLf & txtNX.Text & " " & txtNY.Text & " " & txtNZ.Text
            zXYZ = "overworld to the nether" & vbCrLf & zOp & "n - should be" & vbCrLf & txtNX.Text & " " & txtNY.Text & " " & txtNZ.Text
        End If

        If txtLog.Text = vbNullString Then
            'txtLog.Text = txtLog.Text & vbCrLf & vbCrLf & zXYZ & vbCrLf & vbCrLf
            txtLog.Text = vbCrLf & zXYZ & vbCrLf
            txtLog.SelectionStart = Len(txtLog.Text)
            txtLog.Select()
            txtLog.ScrollToCaret()
            Exit Sub
        Else
            'txtLog.Focus()
            If txtLog.SelectionStart = -1 Then
                txtLog.Text = txtLog.Text & vbCrLf & vbCrLf & zXYZ & vbCrLf & vbCrLf
                txtLog.SelectionStart = Len(txtLog.Text)
                txtLog.Select()
                txtLog.ScrollToCaret()
                Exit Sub
            ElseIf txtLog.SelectionStart = 0 Then
                txtLog.SelectionStart = 1
            End If
        End If

        Dim zBefore As String
        Dim zAfter As String
        zBefore = Mid(txtLog.Text, 1, txtLog.SelectionStart)
        'MsgBox(zBefore)
        zAfter = Mid(txtLog.Text, txtLog.SelectionStart + 1, Len(txtLog.Text))
        'MsgBox(zAfter)

        If txtLog.SelectionStart = Len(txtLog.Text) Then
            zAfter = vbNullString
        End If

        'txtLog.Text = zBefore & vbCrLf & vbCrLf & zXYZ & vbCrLf & vbCrLf & zAfter
        txtLog.Text = zBefore & zXYZ & vbCrLf & vbCrLf & zAfter
        'txtLog.Text = zBefore & zXYZ & vbCrLf & zAfter

        'txtLog.SelectionStart = Len(zBefore & vbCrLf & vbCrLf & zXYZ & vbCrLf & vbCrLf) - 1
        'txtLog.SelectionStart = Len(zBefore & zXYZ & vbCrLf & vbCrLf) - 1
        'txtLog.SelectionStart = Len(zBefore & zXYZ & vbCrLf) - 1
        'txtLog.SelectionStart = Len(zBefore & zXYZ & vbCrLf) + 1
        txtLog.SelectionStart = Len(zBefore & zXYZ & vbCrLf)


        txtLog.Select()
        txtLog.ScrollToCaret()
    End Sub

    Public zFind2025Start As Boolean = True

    Private Sub tmrStart_Tick(sender As Object, e As EventArgs) Handles tmrStart.Tick
        If Len(txtLog.Text) > 0 Then
            'txtLog.SelectionStart = Len(txtLog.Text)
            'txtLog.Select()
            'txtLog.ScrollToCaret()
            txtFindText.Text = "2025"
            'zFindTextClick()
            tmrStart.Enabled = False
            zUpdate2025()
        End If
        tmrStart.Enabled = False
    End Sub

    Private Sub btClear_Click(sender As Object, e As EventArgs) Handles btClear.Click
        txtX.Text = vbNullString
        txtY.Text = vbNullString
        txtZ.Text = vbNullString

        txtOX.Text = vbNullString
        txtOY.Text = vbNullString
        txtOZ.Text = vbNullString

        txtNX.Text = vbNullString
        txtNY.Text = vbNullString
        txtNZ.Text = vbNullString

    End Sub

    Private Sub txtX_TextChanged(sender As Object, e As EventArgs) Handles txtX.TextChanged

    End Sub

    Private Sub txtX_KeyUp(sender As Object, e As KeyEventArgs) Handles txtX.KeyUp
        'arrow left - 37
        'arrow up - 38
        'arrow right - 39
        'arrow down - 40

        'If e.Modifiers = Keys.Control Then
        'txtLog.Text = e.KeyCode
        'End If
        'Exit Sub

        If e.Modifiers = Keys.Control Then
            Dim zKc As Integer
            zKc = e.KeyCode
            Select Case zKc
                Case 37
                    'arrow left
                    txtLog.Select()
                Case 38
                    'arrow up
                    txtNX.Select()
                Case 39
                    'arrow right
                    txtY.Select()
                Case 40
                    'arrow down
                    txtOX.Select()
            End Select
        End If
    End Sub

    Private Sub txtLog_KeyUp(sender As Object, e As KeyEventArgs) Handles txtLog.KeyUp
        'arrow left - 37
        'arrow up - 38
        'arrow right - 39
        'arrow down - 40

        'If e.Modifiers = Keys.Control Then
        'txtLog.Text = e.KeyCode
        'End If
        'Exit Sub

        If e.Modifiers = Keys.Control Then
            Dim zKc As Integer
            zKc = e.KeyCode
            Select Case zKc
                Case 37
                    'arrow left
                    txtNZ.Select()
                Case 38
                    'arrow up
                Case 39
                    'arrow right
                    txtX.Select()
                Case 40
                    'arrow down
            End Select
        End If
    End Sub

    Private Sub txtY_TextChanged(sender As Object, e As EventArgs) Handles txtY.TextChanged

    End Sub

    Private Sub txtY_KeyUp(sender As Object, e As KeyEventArgs) Handles txtY.KeyUp
        'arrow left - 37
        'arrow up - 38
        'arrow right - 39
        'arrow down - 40

        'If e.Modifiers = Keys.Control Then
        'txtLog.Text = e.KeyCode
        'End If
        'Exit Sub

        If e.Modifiers = Keys.Control Then
            Dim zKc As Integer
            zKc = e.KeyCode
            Select Case zKc
                Case 37
                    'arrow left
                    txtX.Select()
                Case 38
                    'arrow up
                    txtNY.Select()
                Case 39
                    'arrow right
                    txtZ.Select()
                Case 40
                    'arrow down
                    txtOY.Select()
            End Select
        End If
    End Sub

    Private Sub txtZ_TextChanged(sender As Object, e As EventArgs) Handles txtZ.TextChanged

    End Sub

    Private Sub txtZ_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtZ.KeyPress

    End Sub

    Private Sub txtOX_TextChanged(sender As Object, e As EventArgs) Handles txtOX.TextChanged

    End Sub

    Private Sub txtOX_KeyUp(sender As Object, e As KeyEventArgs) Handles txtOX.KeyUp
        'arrow left - 37
        'arrow up - 38
        'arrow right - 39
        'arrow down - 40

        'If e.Modifiers = Keys.Control Then
        'txtLog.Text = e.KeyCode
        'End If
        'Exit Sub

        If e.Modifiers = Keys.Control Then
            Dim zKc As Integer
            zKc = e.KeyCode
            Select Case zKc
                Case 37
                    'arrow left
                    txtZ.Select()
                Case 38
                    'arrow up
                    txtX.Select()
                Case 39
                    'arrow right
                    txtOY.Select()
                Case 40
                    'arrow down
                    txtNX.Select()
            End Select
        End If
    End Sub

    Private Sub txtOY_TextChanged(sender As Object, e As EventArgs) Handles txtOY.TextChanged

    End Sub

    Private Sub txtOY_KeyUp(sender As Object, e As KeyEventArgs) Handles txtOY.KeyUp
        'arrow left - 37
        'arrow up - 38
        'arrow right - 39
        'arrow down - 40

        'If e.Modifiers = Keys.Control Then
        'txtLog.Text = e.KeyCode
        'End If
        'Exit Sub

        If e.Modifiers = Keys.Control Then
            Dim zKc As Integer
            zKc = e.KeyCode
            Select Case zKc
                Case 37
                    'arrow left
                    txtOX.Select()
                Case 38
                    'arrow up
                    txtY.Select()
                Case 39
                    'arrow right
                    txtOZ.Select()
                Case 40
                    'arrow down
                    txtNY.Select()
            End Select
        End If
    End Sub

    Private Sub txtOZ_TextChanged(sender As Object, e As EventArgs) Handles txtOZ.TextChanged

    End Sub

    Private Sub txtOZ_LocationChanged(sender As Object, e As EventArgs) Handles txtOZ.LocationChanged

    End Sub

    Private Sub txtOZ_KeyUp(sender As Object, e As KeyEventArgs) Handles txtOZ.KeyUp
        'arrow left - 37
        'arrow up - 38
        'arrow right - 39
        'arrow down - 40

        'If e.Modifiers = Keys.Control Then
        'txtLog.Text = e.KeyCode
        'End If
        'Exit Sub

        If e.Modifiers = Keys.Control Then
            Dim zKc As Integer
            zKc = e.KeyCode
            Select Case zKc
                Case 37
                    'arrow left
                    txtOY.Select()
                Case 38
                    'arrow up
                    txtZ.Select()
                Case 39
                    'arrow right
                    txtNX.Select()
                Case 40
                    'arrow down
                    txtNZ.Select()
            End Select
        End If
    End Sub

    Private Sub txtZ_KeyUp(sender As Object, e As KeyEventArgs) Handles txtZ.KeyUp
        'arrow left - 37
        'arrow up - 38
        'arrow right - 39
        'arrow down - 40

        'If e.Modifiers = Keys.Control Then
        'txtLog.Text = e.KeyCode
        'End If
        'Exit Sub

        If e.Modifiers = Keys.Control Then
            Dim zKc As Integer
            zKc = e.KeyCode
            Select Case zKc
                Case 37
                    'arrow left
                    txtY.Select()
                Case 38
                    'arrow up
                    txtNZ.Select()
                Case 39
                    'arrow right
                    txtOX.Select()
                Case 40
                    'arrow down
                    txtOZ.Select()
            End Select
        End If
    End Sub

    Private Sub txtNX_TextChanged(sender As Object, e As EventArgs) Handles txtNX.TextChanged

    End Sub

    Private Sub txtNX_KeyUp(sender As Object, e As KeyEventArgs) Handles txtNX.KeyUp
        'arrow left - 37
        'arrow up - 38
        'arrow right - 39
        'arrow down - 40

        'If e.Modifiers = Keys.Control Then
        'txtLog.Text = e.KeyCode
        'End If
        'Exit Sub

        If e.Modifiers = Keys.Control Then
            Dim zKc As Integer
            zKc = e.KeyCode
            Select Case zKc
                Case 37
                    'arrow left
                    txtOZ.Select()
                Case 38
                    'arrow up
                    txtOX.Select()
                Case 39
                    'arrow right
                    txtNY.Select()
                Case 40
                    'arrow down
                    txtX.Select()
            End Select
        End If
    End Sub

    Private Sub txtNY_TextChanged(sender As Object, e As EventArgs) Handles txtNY.TextChanged

    End Sub

    Private Sub txtNY_KeyUp(sender As Object, e As KeyEventArgs) Handles txtNY.KeyUp
        'arrow left - 37
        'arrow up - 38
        'arrow right - 39
        'arrow down - 40

        'If e.Modifiers = Keys.Control Then
        'txtLog.Text = e.KeyCode
        'End If
        'Exit Sub

        If e.Modifiers = Keys.Control Then
            Dim zKc As Integer
            zKc = e.KeyCode
            Select Case zKc
                Case 37
                    'arrow left
                    txtNX.Select()
                Case 38
                    'arrow up
                    txtOY.Select()
                Case 39
                    'arrow right
                    txtNZ.Select()
                Case 40
                    'arrow down
                    txtY.Select()
            End Select
        End If
    End Sub

    Private Sub txtNZ_TextChanged(sender As Object, e As EventArgs) Handles txtNZ.TextChanged

    End Sub

    Private Sub txtNZ_KeyUp(sender As Object, e As KeyEventArgs) Handles txtNZ.KeyUp
        'arrow left - 37
        'arrow up - 38
        'arrow right - 39
        'arrow down - 40

        'If e.Modifiers = Keys.Control Then
        'txtLog.Text = e.KeyCode
        'End If
        'Exit Sub

        If e.Modifiers = Keys.Control Then
            Dim zKc As Integer
            zKc = e.KeyCode
            Select Case zKc
                Case 37
                    'arrow left
                    txtNY.Select()
                Case 38
                    'arrow up
                    txtOZ.Select()
                Case 39
                    'arrow right
                    txtLog.Select()
                Case 40
                    'arrow down
                    txtZ.Select()
            End Select
        End If
    End Sub

    Private Sub ckOnTop_CheckedChanged(sender As Object, e As EventArgs) Handles ckOnTop.CheckedChanged
        If ckOnTop.Checked = True Then
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If
    End Sub

    Private Sub btFindCaret_Click(sender As Object, e As EventArgs) Handles btFindCaret.Click
        If Len(txtLog.Text) > 0 Then
            If txtLog.SelectionStart > -1 Then
                'txtLog.SelectionStart = Len(txtLog.Text)
                txtLog.SelectionLength = 0
                txtLog.Select()
                txtLog.ScrollToCaret()
            ElseIf txtLog.SelectionStart = -1 Then
                'no selection go to end
                txtLog.SelectionStart = Len(txtLog.Text)
                txtLog.SelectionLength = 0
                txtLog.Select()
                txtLog.ScrollToCaret()
            End If
        End If
    End Sub

    Private Sub btTop_Click(sender As Object, e As EventArgs) Handles btTop.Click

        If Len(txtLog.Text) > 0 Then
            txtLog.SelectionStart = 0
            txtLog.SelectionLength = 0
            txtLog.Select()
            txtLog.ScrollToCaret()
        End If
    End Sub

    Private Sub btEnd_Click(sender As Object, e As EventArgs) Handles btEnd.Click
        If Len(txtLog.Text) > 0 Then
            txtLog.SelectionStart = Len(txtLog.Text)
            txtLog.SelectionLength = 0
            txtLog.Select()
            txtLog.ScrollToCaret()
        End If
    End Sub

    Public Sub zClearFindIndexList()
        listFindIndex.Items.Clear()
        Dim zI As Integer
        For zI = 0 To 1000
            zFindIndexList(zI) = 0
        Next
    End Sub

    Public Sub zUpdateFindListBox()
        listFindIndex.Items.Clear()
        Dim zI As Integer
        For zI = 0 To 1000
            If zFindIndexList(zI) <> 0 Then
                listFindIndex.Items.Add(zFindIndexList(zI))
            End If
        Next
    End Sub

    Public Sub zFindTextClick()
        If txtLog.Text = vbNullString Then Exit Sub
        If txtFindText.Text = vbNullString Then Exit Sub
        Dim zFind0 As Integer
        'Dim zI As Integer
        'zI = 0

        'zFindIndexList(zI) = zFind0

        'this scans for as many as it can find
        'not just the first one

        zFind0 = InStr(txtLog.Text, txtFindText.Text)
        If zFind0 > 0 Then
            'zClearFindIndexList()
            'zFindIndexList(zI) = zFind0
            'zI = zI + 1

            zFindPreviousLen = Len(txtFindText.Text)
            listFindIndex.Items.Clear()
            listFindIndex.Items.Add(zFind0)

            'this stops the loop if there arent anymore found
            Dim zLoopStop As Boolean = False
            'it found one, now check for more than one
            Dim zFind1 As Integer
            Do
                'set the second one to the old one
                zFind1 = zFind0
                'set the new one to the next one if there is a next one
                zFind0 = InStr(zFind1 + 1, txtLog.Text, txtFindText.Text)
                If zFind0 > 0 Then
                    'zFindIndexList(zI) = zFind0
                    listFindIndex.Items.Add(zFind0)
                    'zI = zI + 1
                Else
                    'no more found
                    zLoopStop = True
                End If
            Loop Until zLoopStop = True

            'txtLog.SelectionStart = zFind0 - 1
            txtLog.SelectionStart = listFindIndex.Items.Item(0) - 1
            listFindIndex.SetSelected(0, True)
            'txtLog.SelectionLength = Len(txtFindText.Text)
            txtLog.SelectionLength = zFindPreviousLen
            txtLog.Select()
            txtLog.ScrollToCaret()
            lbFindListCount.Text = listFindIndex.Items.Count
        Else
            If zFind2025Start = True Then
                zFind2025Start = False
            Else
                MsgBox("not found", vbOKOnly, "Craft Notes 0")
            End If
        End If

    End Sub

    Private Sub btFindText_Click(sender As Object, e As EventArgs) Handles btFindText.Click

        'test
        'frmTextBoxFindPopUpModular.Show()
        'Exit Sub
        'end test

        zFindTextClick()

    End Sub

    Private Sub listFindIndex_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listFindIndex.SelectedIndexChanged

    End Sub

    Private Sub listFindIndex_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles listFindIndex.MouseDoubleClick
        Dim zSelI As Integer = listFindIndex.SelectedIndex
        If zSelI <> -1 Then
            'txtLog.SelectionStart = zFindIndexList(zSelI) - 1
            txtLog.SelectionStart = CInt(listFindIndex.Items.Item(zSelI)) - 1
            txtLog.SelectionLength = zFindPreviousLen
            txtLog.Select()
            txtLog.ScrollToCaret()
        End If
    End Sub

    Private Sub btFindPrevious_Click(sender As Object, e As EventArgs) Handles btFindPrevious.Click
        If txtLog.Text = vbNullString Then Exit Sub
        If txtFindText.Text = vbNullString Then Exit Sub

        If listFindIndex.Items.Count = 0 Then
            zFindTextClick()
        End If
        If listFindIndex.Items.Count = 0 Then Exit Sub
        Dim zSelI As Integer = listFindIndex.SelectedIndex
        If zSelI = -1 Then
            listFindIndex.SetSelected(0, True)
        ElseIf zSelI = 0 Then
            'bottom of the list
            'loop back around
            listFindIndex.SetSelected(listFindIndex.Items.Count - 1, True)
        Else
            listFindIndex.SetSelected(zSelI - 1, True)
        End If

        zSelI = listFindIndex.SelectedIndex
        txtLog.SelectionStart = CInt(listFindIndex.Items.Item(zSelI)) - 1
        txtLog.SelectionLength = zFindPreviousLen
        txtLog.Select()
        txtLog.ScrollToCaret()

    End Sub

    Private Sub btFindNext_Click(sender As Object, e As EventArgs) Handles btFindNext.Click
        If txtLog.Text = vbNullString Then Exit Sub
        If txtFindText.Text = vbNullString Then Exit Sub

        If listFindIndex.Items.Count = 0 Then
            zFindTextClick()
        End If
        If listFindIndex.Items.Count = 0 Then Exit Sub
        Dim zSelI As Integer = listFindIndex.SelectedIndex
        If zSelI = -1 Then
            listFindIndex.SetSelected(0, True)
        ElseIf zSelI = listFindIndex.Items.Count - 1 Then
            'top of the list
            'loop back around
            listFindIndex.SetSelected(0, True)
        Else
            listFindIndex.SetSelected(zSelI + 1, True)
        End If

        zSelI = listFindIndex.SelectedIndex
        txtLog.SelectionStart = CInt(listFindIndex.Items.Item(zSelI)) - 1
        txtLog.SelectionLength = zFindPreviousLen
        txtLog.Select()
        txtLog.ScrollToCaret()

    End Sub

    Private Sub btClearFindText_Click(sender As Object, e As EventArgs) Handles btClearFindText.Click
        txtFindText.Text = vbNullString
        listFindIndex.Items.Clear()
        zFindPreviousLen = 0
        lbFindListCount.Text = listFindIndex.Items.Count
    End Sub

    Private Sub txtFindText_TextChanged(sender As Object, e As EventArgs) Handles txtFindText.TextChanged

    End Sub

    Private Sub txtFindText_KeyUp(sender As Object, e As KeyEventArgs) Handles txtFindText.KeyUp
        If e.KeyCode = 13 Then
            'enter key
            If txtFindText.Text = vbNullString Then
                MsgBox("enter search string", vbOKOnly, "Craft Notes 0")
                Exit Sub
            Else
                zFindTextClick()
            End If
        End If
    End Sub

    Public Sub zUpdate2025()
        If txtLog.Text = vbNullString Then Exit Sub
        txtFindText.Text = "2025"
        zFindTextClick()
        If listFindIndex.Items.Count = 0 Then Exit Sub
        Dim zSelI As Integer
        listFindIndex.SetSelected(listFindIndex.Items.Count - 1, True)
        zSelI = listFindIndex.SelectedIndex
        txtLog.SelectionStart = CInt(listFindIndex.Items.Item(zSelI)) - 1
        txtLog.SelectionLength = zFindPreviousLen
        txtLog.Select()
        txtLog.ScrollToCaret()

    End Sub


    Private Sub bt2025_Click(sender As Object, e As EventArgs) Handles bt2025.Click
        zUpdate2025()
    End Sub

    Private Sub btFindPrevious_MouseHover(sender As Object, e As EventArgs) Handles btFindPrevious.MouseHover

    End Sub
End Class

'todo:
'add a book mark list box
'add a book mark log file
' copy and paste the stuff for loading and saving the first log file and change the name
'make it so the time stamp button adds a book mark
'using the selectionstart thing should be good enough for the book mark system
'it just saves wherever the caret is
'and then sets the caret to where ever the number is in the list box
'then updates the scrollbars for where the caret is

'its just more work that i want to do right now
