    Function zGenerateRandomAlphanumeric(zLength As Integer) As String
		'2026-06-24-03-01-12-AM
		'usage
		''Always initialize the random generator seed
        'Randomize()
        ''Generate an 8-character random code
        'Dim randomString As String = GenerateRandomAlphanumeric(8)
        'Console.WriteLine($"Generated Code: {randomString}")

        Const zPool As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim zResult As New StringBuilder()

        For i As Integer = 1 To zLength
			application.doevents
            'Rnd() returns a fraction between 0.0 and 1.0
            'Math.Floor maps that fraction to an integer index within our pool length
            Dim zIndex As Integer = CInt(Math.Floor(zPool.Length * Rnd()))
            
            zResult.Append(zPool(zIndex))
        Next

        Return zResult.ToString()
    End Function