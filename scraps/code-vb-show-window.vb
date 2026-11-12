Imports System.Runtime.InteropServices

Public Class ExplorerHelper

    ' Import required Windows API functions
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
    Private Shared Function FindWindow(lpClassName As String, lpWindowName As String) As IntPtr
    End Function

    <DllImport("user32.dll")>
    Private Shared Function SetForegroundWindow(hWnd As IntPtr) As Boolean
    End Function

    <DllImport("user32.dll")>
    Private Shared Function ShowWindow(hWnd As IntPtr, nCmdShow As Integer) As Boolean
    End Function

    <DllImport("user32.dll")>
    Private Shared Function IsIconic(hWnd As IntPtr) As Boolean
    End Function

    Private Const SW_RESTORE As Integer = 9

    Public Shared Sub BringExplorerToFront(folderTitle As String)
        ' "CabinetWClass" is the standard window class for File Explorer windows
        Dim hWnd As IntPtr = FindWindow("CabinetWClass", folderTitle)

        If hWnd <> IntPtr.Zero Then
            ' If the window is minimized, restore it first
            If IsIconic(hWnd) Then
                ShowWindow(hWnd, SW_RESTORE)
            End If

            ' Bring the window to the foreground
            SetForegroundWindow(hWnd)
        Else
            MessageBox.Show("Explorer window not found.")
        End If
    End Sub

End Class
