Public Class Form1

    Private Sub ckOnTop_CheckedChanged(sender As Object, e As EventArgs) Handles ckOnTop.CheckedChanged
        If ckOnTop.Checked = True Then
            Me.TopMost = True
        Else
            Me.TopMost = True
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        txtTitle.Text = "Title"
        txtIncrement.Text = "1"
        'DateTimePicker1.CustomFormat = "MMMM dd, yyyy - dddd"
        DateTimePicker1.CustomFormat = "M'/'d'/'yyyy"
        DateTimePicker1.Update()
        Debug.Print(DateTimePicker1.Text)
    End Sub

    Public Sub zSaniBoxes()

        'SANDY CLAWS HUH????

        ' *#%####%###%####%####################%%#%@%%%%%@@@@@@@@@%%##%######%########%########%##%####%%%##%#
        ' #@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#**+@@@@@#=*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#
        ' %@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@:#@@%@@:-*+..:-:.-:.*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#
        ' %@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=:@@@+@@:=@+*@@*@@@@@@%-@@@@@@@@@@@@@@@@@@%@@@@@@@@@@@@@@@@@@@@#
        ' #@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@-:-*#@@@@@@@@@@@@+=:::-%.@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%
        ' #@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@-@@*@@@::.:....:++@@@@#:::@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%
        ' #@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%:@@@@@*-.:::%@@@#*-:++:-+%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#
        ' %@@@@@@@@@@@@@@@@@@@@@@@@@@@@@+@@@@@+::*@@@@@@::-=-@*::##:-.@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%
        ' #@@@@@@@@@@@@@@@@@@@@@@@@@@@@@-%@@@@-::.+@@=::::-*+==:@@@@@:.@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%@%
        ' #@@@@@@@@@@@@@@@@@@@@@@@@%@@@@@@@@@.@@@@@@@#*+=####==-@@@@@@:#@@@@@@@@@@@@@@@@@@@@@@@@@@%@@@@@@@@@@#
        ' #@@@@@@@@@@@@@@@@@@@@@@@%@@%@@#:%:::.::+*%%-*+-+++=--:@@@@@@:@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#
        ' #@@@@@@@@@@@@@@@@@@@@@-=*@@@@:.: =#@@@::.*@*#@@#*-==*:::-:.%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#
        ' #@@@@@@@@@@@@@@@ #*+@@@@@@::@@@@@@@@@@@@#:..%@@%@@@*#---.+@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#
        ' #@@@@@@@@@@@@@-@@@%##=--@=::.%@@@@@@@@@@@@@@:. .:=*%@%%::@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%
        ' #@@@@@@@@@=#%@@@@@@@#+=:%@%@@@@@@@@@@@@@@@@@@@@@%:...=@@@%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%
        ' #@@@@@+--#@@%.--@@:=*%*#@@#@@-%+@@@@@@@@@@@@@@@@@@@@@....@-.@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%
        ' #@@@::=*#%%@@@@@::=*++-++@*@+*#+%@@@@@@@@@@@@@@@@@@@@@@@:.. @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#
        ' @@.-=+=*+=:-::@@=+++++===@@@#==@*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#
        ' @.-@##%@@@@@@@+.#+==+=+++@@#@@-*=*#+@@@@@@@@@@@@@@@@@@@.@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#
        '  :=**#*%*#@+==@*++*=:**=#@==*@@=#@=-%:@@@@@@@@@@@@@@@@@.@@@@@%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#
        '  =++=+*==-==--@:##+=+@@%@%+###@@=%+:%+:-@@@@@@@@@@@@@@@@#-@#@@*=@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#
        '  +#+*#++*-::::@:-:@@@@@@@++####*@*@++::%@---:*%@@@@@@@+#:%@#:=%-+=*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#
        '  --#===%@@@@@@@--:@@@@@@*####%@*#@*@+%++-.+::==:..=:.-.:.@+*==#=-#+---#=-@@@@@@@@@@@@@@@@@@@@@@@@@@#
        '  =-*@@@@*#-:=#++*#@@@@@@@#***+#*%*@#@***#@@@@@@@*+#-+##@@@===+*+=*+*+++=+-:@@@@@@@@@@@@@@@@@@@@-@@@#
        '  =++-+:====#*+@@@@@@@@@@@@##*#*#%%%%@@#@@@=@#%*#%%+@@-:@@-=+*#**=@=*+++*+#+-+-@@@@@@@@@@@@@@@@@@:@@#
        '  +--=+=*-%+*-#*::+-+@@@@@@@@%*%%#%%::*#%@@#@:+=*=---@#@@-++++++++@=*++++*+*+*=---:@@@@@@@@@@@@@@@=@%
        '  ==*+-+=+=*=*++*-*:::@@@@@@@@@@*#@@@@%@%#*==+*=:-*+-%+:-=+*+=+**-#++**+*#*%+*#+#-=---=+@@@@@@@@@#.@%
        '  +=++=+===*=#+***#+#::@@@@@#%+%#%**#+*%+++*+=-=@@*===++**++++**=:@+++*=**=+***+++===--:::=:*@#=::.@#
        '  ====-=*==:=:#:%#.@*=@**:@====-+@+--*-+-=*==+##:-%@%#*++*++==#+:@@##===@**#=+**+***#*++*+=-:-==:.@@#
        '  =+*=#+==**======++:++:--:=++#++++++*+++=*=-+=#--=-=+***++#+@-::@%-==*@%++**+*+**++%%+=*+***++::@@@#
        '  =+-+++*+*+++*==-#%+*++#***#++*#*++*=*=+=+*@@@*#++:=++++***+@@@*@::*%@%*++++******+=##=-=+++:.:@@@@#
        '  ===+====-==+-=*#--+#*++=#=++*==*+#+=*-+*@*#++*++***++=****=:=@@@@*+-:::-++++*+++=+-=*+=-::..@@@@@@#
        '  ++++=+===+=++=--+*=-*+*=#+*+*=+==+++==#*=*+**+=+=+*++++----=:.@@@@@@@@@-:::::::::...:::.:%@@@@@@@@#
        '  --=+==============-=------===+=*+*-==@**+*#++++#=#*##++=@**=-:.@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#
        ' .@=:---===-+===+======*+*==+*-+++=+-@#*+=*****++#-+++***++%#*+-@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#
        '  *#%@+=++*=+=*--+-=+===-=-*-::--%@*=-=+*+*=#+=#=+=+=*+****++*%#:@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#
        '  -==+%**=+*==+-::.:::+--+=*@@@@*=**=*+++=*+**=+=#+==+++*****+++:-@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#
        '  .          . ::%@@#:  .. .      .    .     . ..  . .   .... .. @@########%###########%#%#%######%%*


        Dim zIncStr As String
        Dim zTitle As String

        zIncStr = txtIncrement.Text
        zTitle = txtTitle.Text

        'txtIncrement
        'txtTitle
        'txtIncrement.Text =
        'txtTitle.Text = 

        'txtIncrement.Text = zNumFilter(txtIncrement.Text)
        'txtTitle.Text = zAlphaNumFilterWithDashPlusSpace(txtIncrement.Text)

        zIncStr = zNumFilter(zIncStr)

        'switching to just leaving the title box alone because its easier
        'zTitle = zAlphaNumFilterWithDashPlusSpace(zTitle)

        If zIncStr = vbNullString Then
            zIncStr = "1"
            'Exit Sub
        End If

        If zTitle = vbNullString Then
            zTitle = "Title"
            'Exit Sub
        End If

        txtIncrement.Text = zIncStr
        'txtTitle.Text = zTitle
        'txtTitle.Text = totitlecase(zTitle)


    End Sub

    Public Sub zLazyCopy()

        'this just lazy copies whatever is in the textboxes
        Clipboard.Clear()
        Clipboard.SetText(txtTitle.Text & txtIncrement.Text)

    End Sub

    Private Sub btCopy_Click(sender As Object, e As EventArgs) Handles btCopy.Click
        zLazyCopy()
    End Sub

    Public Sub zIncrement()
        zSaniBoxes()
        Dim zIncToInt As Integer
        zIncToInt = CInt(txtIncrement.Text)
        zIncToInt = zIncToInt + 1
        txtIncrement.Text = zIncToInt

    End Sub

    Public Sub zDecrement()
        zSaniBoxes()
        Dim zIncToInt As Integer
        zIncToInt = CInt(txtIncrement.Text)
        zIncToInt = zIncToInt - 1
        txtIncrement.Text = zIncToInt

    End Sub

    Private Sub btIncrement_Click(sender As Object, e As EventArgs) Handles btIncrement.Click
        zIncrement()
    End Sub

    Private Sub btCopyIncrement_Click(sender As Object, e As EventArgs) Handles btCopyIncrement.Click
        zLazyCopy()
        zIncrement()
    End Sub

    Private Sub btDecrement_Click(sender As Object, e As EventArgs) Handles btDecrement.Click
        zDecrement()
    End Sub

    Private Sub btIncDate2DaysCopy_Click(sender As Object, e As EventArgs) Handles btIncDate2DaysCopy.Click

        'DateTimePicker1.CustomFormat = "M'/'d'/'yyyy"
        'DateTimePicker1.Update()

        Dim zTempDateTime As String
        zTempDateTime = DateTimePicker1.Text

        Dim zSlash1 As Integer
        Dim zSlash2 As Integer

        zSlash1 = InStr(1, zTempDateTime, "/")
        zSlash2 = InStr(zSlash1 + 1, zTempDateTime, "/")

        Dim zMonth As String
        Dim zDay As String
        Dim zYear As String

        zMonth = Mid(zTempDateTime, 1, zSlash1 - 1)
        zDay = Mid(zTempDateTime, zSlash1 + 1, zSlash2 - zSlash1 - 1)
        zYear = Mid(zTempDateTime, zSlash2 + 1, Len(zTempDateTime))

        Dim zTempDate As New DateTime(CInt(zYear), CInt(zMonth), CInt(zDay))

        Dim zTempDateString As String
        zTempDateString = zTempDate.Date.AddDays(2)

        Debug.Print(zTempDateString)

        zSlash1 = InStr(1, zTempDateString, "/")
        zSlash2 = InStr(zSlash1 + 1, zTempDateString, "/")

        zMonth = Mid(zTempDateString, 1, zSlash1 - 1)
        zDay = Mid(zTempDateString, zSlash1 + 1, zSlash2 - zSlash1 - 1)
        zYear = Mid(zTempDateString, zSlash2 + 1, Len(zTempDateString))

        DateTimePicker1.Value = New DateTime(CInt(zYear), CInt(zMonth), CInt(zDay), 0, 0, 0)
        DateTimePicker1.Update()

        Debug.Print(DateTimePicker1.Value)
        Debug.Print(DateTimePicker1.Text)

        Clipboard.Clear()
        Clipboard.SetText(DateTimePicker1.Text)

    End Sub
End Class
