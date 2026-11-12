    Public Class zExplorerHelper
        '2026-11-11-19-03-52-PM
        Public Shared Function GetOpenExplorerPaths() As List(Of String)
            Dim paths As New List(Of String)()

            ' Create an instance of the Shell.Application COM object
            Dim shellType As Type = Type.GetTypeFromProgID("Shell.Application")
            Dim shell As Object = Activator.CreateInstance(shellType)

            ' Retrieve the collection of open Shell windows
            Dim windows As Object = shell.Windows()

            For Each window As Object In windows
                Application.DoEvents()
                Try
                    ' Check the process name to ensure it is File Explorer (explorer.exe)
                    ' This filters out legacy Internet Explorer instances if any exist
                    Dim fullName As String = window.FullName.ToString()
                    If Path.GetFileNameWithoutExtension(fullName).Equals("explorer", StringComparison.OrdinalIgnoreCase) Then

                        ' LocationURL returns a file URI (e.g., "file:///C:/Users/Name/Documents")
                        Dim locationUrl As String = window.LocationURL.ToString()

                        If Not String.IsNullOrEmpty(locationUrl) Then
                            ' Convert the URI into a standard local file path
                            Dim localPath As String = New Uri(locationUrl).LocalPath
                            paths.Add(localPath)
                        Else
                            ' Special folders like "This PC" or "Recycle Bin" have an empty LocationURL
                            ' You can fall back to LocationName for the window title
                            paths.Add($"[Special Folder] {window.LocationName}")
                        End If
                    End If
                Catch ex As Exception
                    ' Ignore windows that might close while iterating or lack valid properties
                End Try
            Next

            Return paths
        End Function
    End Class

    Public Sub zGetActiveExplorerWindowsAddToListbox(zGAWListBox As ListBox)
        '2026-11-11-19-03-52-PM
        'expects the listbox to be there
        'will crash if its not right

        zGAWListBox.Items.Clear()

        Dim openFolders As List(Of String) = zExplorerHelper.GetOpenExplorerPaths()

        For Each folderPath As String In openFolders
            Application.DoEvents()
            'Console.WriteLine(folderPath)
            zGAWListBox.Items.Add(folderPath)
        Next

    End Sub
