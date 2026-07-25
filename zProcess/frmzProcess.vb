Imports System.ServiceProcess
Imports System.Threading

'Public Class ServiceControl
'    Public Sub StopMyService(serviceName As String)
'        'Try
'        Dim myService As New ServiceController(serviceName)
'
'        If myService.Status = ServiceControllerStatus.Running Then
'            myService.Stop()
'            myService.WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromSeconds(10))
'            'Console.WriteLine($"Service '{serviceName}' stopped successfully.")
'            'Else
'            'Console.WriteLine($"Service '{serviceName}' is not running.")
'        End If
'
'        'Catch ex As Exception
'        'Console.WriteLine($"Error stopping service '{serviceName}': {ex.Message}")
'        'End Try
'    End Sub
'End Class

Public Class frmzProcess

    Public Sub zbtGetProcesses_Click()
        Application.DoEvents()

        '2026-07-07-21-06-50-PM
        'void old_school_faq_go(){
        'go find the odd character that is interpreted as a space
        'there you go
        '=============================================================
        '2026-07-07-20-59-16-PM
        '=============================================================
        'public sub z
        'double click
        'copy paste
        'now i can just call that shit wherever
        'and dont forget to copy paste this back in the button
        'that it came out of
        '=============================================================
        '=============================================================
        '                      ^( @ Y @ )^
        '
        '                           ♥
        '
        '                          ☺♥☻
        '=============================================================
        '                       its an owl
        '                      there you go
        '=============================================================
        'ow... elbow...
        '               zPlaySound("thx_noise.mp3")
        '=============================================================
        '                       gerald san
        '=============================================================
        '                    the hamburgers
        '=============================================================
        '                        must be
        '=============================================================
        '                          high
        '=============================================================
        '                        sincerely,
        '=============================================================
        '                    uncle grandfather
        '=============================================================

        '}


        Dim psList() As Process

        psList = Process.GetProcesses

        lstProcesses.Items.Clear()
        lstPID.Items.Clear()

        For Each p In psList
            Application.DoEvents()
            'Console.WriteLine(p.Id.ToString() + " " + p.ProcessName)
            'lstProcesses.Items.Add(p.Id.ToString() + " " + p.ProcessName)
            lstProcesses.Items.Add(p.ProcessName)
            lstPID.Items.Add(p.Id.ToString)
        Next p

        Dim zStrOut1 As String
        zStrOut1 = zListboxtoStringWithReturn(lstProcesses)
        txtlstProcessOutput.Text = zStrOut1
        Dim zStrOut2 As String
        zStrOut2 = zListboxtoStringWithReturn(lstPID)
        txtLstPIDOutput.Text = zStrOut2

    End Sub

    Private Sub btGetProcesses_Click(sender As Object, e As EventArgs) Handles btGetProcesses.Click
        zbtGetProcesses_Click()
    End Sub

    Private Sub lstProcesses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstProcesses.SelectedIndexChanged
        If lstProcesses.Items.Count = 0 Then Exit Sub
        If lstPID.Items.Count = 0 Then Exit Sub
        If lstProcesses.SelectedIndex = -1 Then Exit Sub
        lstPID.SelectedIndex = lstProcesses.SelectedIndex
        txtProcesses.Text = lstProcesses.Items.Item(lstProcesses.SelectedIndex)
        txtPID.Text = lstPID.Items.Item(lstPID.SelectedIndex)
    End Sub

    Private Sub lstPID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPID.SelectedIndexChanged
        If lstProcesses.Items.Count = 0 Then Exit Sub
        If lstPID.Items.Count = 0 Then Exit Sub
        If lstPID.SelectedIndex = -1 Then Exit Sub
        'lstPID.SelectedIndex = lstProcesses.SelectedIndex
        lstProcesses.SelectedIndex = lstPID.SelectedIndex
        txtProcesses.Text = lstProcesses.Items.Item(lstProcesses.SelectedIndex)
        txtPID.Text = lstPID.Items.Item(lstPID.SelectedIndex)

    End Sub

    Private Sub btKillProcessByPID_Click(sender As Object, e As EventArgs) Handles btKillProcessByPID.Click


        'Dim processName As String
        'Dim processes() As Process = Process.GetProcessesByName(processName)
        'Terminate each instance of the process
        'For Each proc As Process In processes
        'Application.DoEvents()
        'proc.Kill()
        'Next

        '=====================================================================
        '2026-07-07-20-53-39-PM
        '=====================================================================
        'updating to update the update
        'this one time at update camp
        'this uhhh
        'weed is really goo
        'd
        'mmmmmmm the hell was i doing
        'its orange chocolate treated with citric acid
        'adds peanut butter flavor too it
        'so its a peanut butter cup
        'also grease paint for some reason

        'but yeah im adding a list update
        'so it doesnt crash if you try to double kill the same thing
        '=====================================================================
        'fuck you you crash!!
        'not me
        'no you!
        '=====================================================================



        txtPID.Text = zNumFilter(txtPID.Text)

        If txtPID.Text = "" Then Exit Sub

        Dim zProcessID As Integer
        zProcessID = CInt(txtPID.Text)
        Dim zProc As Process = Process.GetProcessById(zProcessID)
        zProc.Kill()

        zbtGetProcesses_Click()

    End Sub

    Private Sub tmrLazyKill_Tick(sender As Object, e As EventArgs) Handles tmrLazyKill.Tick
        Application.DoEvents()
        'zLazyKillTest()
        zLazyKillTestUsingLists()
    End Sub

    Public Sub StopMyService(serviceName As String)
        On Error GoTo zErrorHandler
        'Try
        Dim myService As New ServiceController(serviceName)
        'Dim zTint As Integer

        If myService.Status = ServiceControllerStatus.Running Then
            myService.Stop()
            myService.WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromSeconds(1))
            'zTint = CInt(txtLazyKillCounter.Text)
            'zTint = zTint + 1
            'txtLazyKillCounter.Text = CStr(zTint)
            'lstKillTimeLog.Items.Add(txtDateTime.Text & " - " & serviceName)
            lstKillTimeLog.Items.Add(zTD & " - " & serviceName)
            zUpdateKillListCounter()

            'Console.WriteLine($"Service '{serviceName}' stopped successfully.")
            'Else
            'Console.WriteLine($"Service '{serviceName}' is not running.")
        End If

        'Catch ex As Exception
        'Console.WriteLine($"Error stopping service '{serviceName}': {ex.Message}")
        'End Try
        Exit Sub
zErrorHandler:
        Application.DoEvents()
        Debug.Print(Err.Description.ToString)
        'seems like its throwing errors for services that dont exist on the computer
        'which is new as of todays restart
        'adding new suffixes somehow even with update off
        'i knew there was some fucked up shit happening the background
        'seemingly without a tcp or udp connection
    End Sub

    Public Sub zPopKillLists()

        'old version

        'processes and services to kill

        'processes / exes
        'TiWorker
        'TrustedInstaller
        'CompatTelRunner
        'MusNotification
        'SIHClient
        'UsoClient
        'BackgroundTransferHost
        'sdiagnhost

        'realized this doesnt show as an actual process
        'removing it from the pop list
        'IKEEXT

        'services
        'McpManagementService
        'OneSyncSvc_6243a
        'DevicesFlowUserSvc_6243a
        'DevicePickerUserSvc_6243a
        'cbdhsvc_6243a
        'CaptureService_6243a
        'wuauserv
        'WinRM
        'WaaSMedicSvc
        'vmicvss
        'vmicvmsession
        'vmictimesync
        'vmicshutdown
        'vmicrdv
        'vmickvpexchange
        'vmicheartbeat
        'vmicguestinterface
        'UsoSvc
        'UmRdpService
        'TermService
        'SSDPSRV
        'SessionEnv
        'RemoteAccess
        'RasMan
        'RasAuto
        'PushToInstall
        'PolicyAgent
        'MapsBroker
        'lmhosts
        'InstallService
        'IKEEXT
        'HvHost
        'FrameServer
        'DsmSvc
        'DoSvc
        'DiagTrack
        'diagsvc
        'diagnosticshub.standardcollector.service
        'ClipSVC
        'BthAvctpSvc
        'BITS
        'AJRouter

        'clear lists
        lstProcessKillList.Items.Clear()
        lstServiceKillList.Items.Clear()

        '============================================
        'processes
        '============================================
        lstProcessKillList.Items.Add("TiWorker")
        lstProcessKillList.Items.Add("TrustedInstaller")

        'realized i hadnt added these exes
        'CompatTelRunner
        'MusNotification
        'SIHClient
        'UsoClient

        lstProcessKillList.Items.Add("CompatTelRunner")
        lstProcessKillList.Items.Add("MusNotification")
        lstProcessKillList.Items.Add("SIHClient")
        lstProcessKillList.Items.Add("UsoClient")
        lstProcessKillList.Items.Add("BackgroundTransferHost")
        lstProcessKillList.Items.Add("sdiagnhost")

        'realized this doesnt show as an actual process
        'removing it from the pop list
        'lstProcessKillList.Items.Add("IKEEXT")
        'for testing
        'lstProcessKillList.Items.Add("notepad")

        'intel graphics bullshit that got flagged for probalance out of nowhere while being connected

        '2026-07-08-00-43-37-AM
        'all of these have .exe on them
        'and i just now realized that
        'none of the othere process list entries
        'have the .exe
        'removing them now
        'yeah sometimes i forget to add the off button too

        lstProcessKillList.Items.Add("IGCC")
        lstProcessKillList.Items.Add("IGCCTray")
        lstProcessKillList.Items.Add("OneApp.IGCC.WinService")
        lstProcessKillList.Items.Add("igfxCUIService")
        lstProcessKillList.Items.Add("igfxEM")

        '2026-07-01-11-00-28-AM
        'C:\Program Files\WindowsApps\Microsoft.SkypeApp_14.53.77.0_x64__kzf8qxf38zg5c
        'SkypeApp
        lstProcessKillList.Items.Add("SkypeApp")
        lstProcessKillList.Items.Add("mscopilot_proxy")

        '2026-07-07-19-17-27-PM
        lstProcessKillList.Items.Add("M365Copilot")

        '2026-07-10-22-28-38-PM
        'lstProcessKillList.Items.Add("sihost")

        '2026-07-07-19-29-13-PM
        'this needs to be a checkbox incase i need to turn it on or off
        'in the lazy timer as if trees
        'commented out in the frmzProccess thing
        'the double click the form part
        'lstProcessKillList.Items.Add("msedge.exe")
        'lstProcessKillList.Items.Add("msedgewebview2.exe")

        '2026-07-04-18-48-48-PM
        'C:\Windows\System32\DriverStore\FileRepository\dal.inf_amd64_af50fdb80983f7bc\jhi_service.exe
        'jhi_service.exe
        '2026-07-04-19-41-37-PM
        'doesnt work
        'trying service
        'lstProcessKillList.Items.Add("jhi_service.exe")

        '============================================
        'services
        '============================================
        '2026-07-04-19-42-03-PM
        'jhi_service
        '2026-07-04-19-42-38-PM
        'aright that works
        lstServiceKillList.Items.Add("jhi_service")
        '============================================

        lstServiceKillList.Items.Add("McpManagementService")
        'apparently something is updating these services somehow
        'OneSyncSvc_6243a
        'changed to
        'OneSyncSvc_642c3
        'overnight since the last restart
        'i knew there was some other shit going on in the background
        'easiest thing to do for now is just comment out the list entries
        'because they all have the dll renamed so they cant start anyway
        'going to have to add a fuzzy scanner for the prefix that updates
        'based on whatever new suffix there is
        'lstServiceKillList.Items.Add("OneSyncSvc_6243a")
        'lstServiceKillList.Items.Add("DevicesFlowUserSvc_6243a")
        'lstServiceKillList.Items.Add("DevicePickerUserSvc_6243a")
        'lstServiceKillList.Items.Add("cbdhsvc_6243a")
        'lstServiceKillList.Items.Add("CaptureService_6243a")
        lstServiceKillList.Items.Add("wuauserv")
        lstServiceKillList.Items.Add("WinRM")
        lstServiceKillList.Items.Add("WaaSMedicSvc")
        lstServiceKillList.Items.Add("vmicvss")
        lstServiceKillList.Items.Add("vmicvmsession")
        lstServiceKillList.Items.Add("vmictimesync")
        lstServiceKillList.Items.Add("vmicshutdown")
        lstServiceKillList.Items.Add("vmicrdv")
        lstServiceKillList.Items.Add("vmickvpexchange")
        lstServiceKillList.Items.Add("vmicheartbeat")
        lstServiceKillList.Items.Add("vmicguestinterface")
        lstServiceKillList.Items.Add("UsoSvc")
        lstServiceKillList.Items.Add("UmRdpService")
        lstServiceKillList.Items.Add("TermService")
        lstServiceKillList.Items.Add("SSDPSRV")
        lstServiceKillList.Items.Add("SessionEnv")
        lstServiceKillList.Items.Add("RemoteAccess")
        lstServiceKillList.Items.Add("RasMan")
        lstServiceKillList.Items.Add("RasAuto")
        lstServiceKillList.Items.Add("PushToInstall")
        lstServiceKillList.Items.Add("PolicyAgent")
        lstServiceKillList.Items.Add("MapsBroker")
        lstServiceKillList.Items.Add("lmhosts")
        lstServiceKillList.Items.Add("InstallService")
        lstServiceKillList.Items.Add("IKEEXT")
        lstServiceKillList.Items.Add("HvHost")
        lstServiceKillList.Items.Add("FrameServer")
        lstServiceKillList.Items.Add("DsmSvc")
        lstServiceKillList.Items.Add("DoSvc")
        lstServiceKillList.Items.Add("DiagTrack")
        lstServiceKillList.Items.Add("diagsvc")
        lstServiceKillList.Items.Add("diagnosticshub.standardcollector.service")
        lstServiceKillList.Items.Add("ClipSVC")
        lstServiceKillList.Items.Add("BthAvctpSvc")
        lstServiceKillList.Items.Add("BITS")
        lstServiceKillList.Items.Add("AJRouter")

        '2026-06-15-04-47-51-AM
        'dont need this shit
        'QWAVE
        lstServiceKillList.Items.Add("QWAVE")

    End Sub

    Public Sub zLazyKillTest()
        'old version

        txtLazyKillCounter.Text = zNumFilter(txtLazyKillCounter.Text)

        If txtLazyKillCounter.Text = "" Then
            txtLazyKillCounter.Text = "0"
        End If

        Dim zProcessName As String
        'zProcessName = "notepad"

        'TiWorker
        zProcessName = "TiWorker"

        Dim zTint As Integer
        Dim zProcesses() As Process = Process.GetProcessesByName(zProcessName)

        'Terminate each instance of the process

        For Each proc As Process In zProcesses
            Application.DoEvents()
            proc.Kill()
            zTint = CInt(txtLazyKillCounter.Text)
            zTint = zTint + 1
            txtLazyKillCounter.Text = CStr(zTint)
        Next

        'TrustedInstaller

        zProcessName = "TrustedInstaller"
        Process.GetProcessesByName(zProcessName)

        'Terminate each instance of the process

        For Each proc As Process In zProcesses
            Application.DoEvents()
            proc.Kill()
            zTint = CInt(txtLazyKillCounter.Text)
            zTint = zTint + 1
            txtLazyKillCounter.Text = CStr(zTint)
        Next

        'IKEEXT

        zProcessName = "IKEEXT"
        Process.GetProcessesByName(zProcessName)

        'Terminate each instance of the process

        For Each proc As Process In zProcesses
            Application.DoEvents()
            proc.Kill()
            zTint = CInt(txtLazyKillCounter.Text)
            zTint = zTint + 1
            txtLazyKillCounter.Text = CStr(zTint)
        Next

        'trying to kill shit for svchost using image path

        'For Each proc In Process.GetProcessesByName(fileName).Where(Function(p) p.MainModule.FileName = filePath).ToArray()

        'For Each proc In Process.GetProcessesByName(fileName).Where(Function(p) p.MainModule.FileName = filePath).ToArray()

        '%SystemRoot%\system32\svchost.exe -k NetworkServiceNetworkRestricted -p

        'Dim sc As New ServiceController(ServiceName)
        'If sc.Status = ServiceControllerStatus.Running OrElse sc.Status = ServiceControllerStatus.StartPending Then
        'sc.Stop()
        'sc.WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromSeconds(30))

        StopMyService("PolicyAgent")
        StopMyService("IKEEXT")
    End Sub

    Public Sub zUpdateKillListCounter()
        'zUpdateTimeDate()
        txtLazyKillCounter.Text = CStr(lstKillTimeLog.Items.Count)
    End Sub
    Public Sub zLazyKillTestUsingLists()
        'new version

        'txtLazyKillCounter.Text = zNumFilter(txtLazyKillCounter.Text)
        '
        'If txtLazyKillCounter.Text = "" Then
        '    txtLazyKillCounter.Text = "0"
        'End If
        zUpdateTimeDate()

        Dim zProcessName As String
        'zProcessName = "notepad"

        'Dim zTint As Integer

        Dim zProcesses() As Process = Process.GetProcessesByName(zProcessName)

        'Terminate each instance of the process

        Dim zIt As Integer
        Dim zListCount As Integer

        zListCount = lstProcessKillList.Items.Count
        For zIt = 0 To zListCount - 1
            Application.DoEvents()
            'TiWorker
            'zProcessName = "TiWorker"
            zProcessName = lstProcessKillList.Items.Item(zIt)
            'Process.GetProcessesByName(zProcessName)
            For Each proc As Process In zProcesses
                Application.DoEvents()
                If proc.ProcessName() = zProcessName Then
                    proc.Kill()
                    'zTint = CInt(txtLazyKillCounter.Text)
                    'zTint = zTint + 1
                    'txtLazyKillCounter.Text = CStr(zTint)
                    'lstKillTimeLog.Items.Add(txtDateTime.Text & " - " & lstProcessKillList.Items.Item(zIt))
                    lstKillTimeLog.Items.Add(zTD & " - " & lstProcessKillList.Items.Item(zIt))
                    zUpdateKillListCounter()
                End If
            Next
        Next

        If ckNotepadTest.Checked = True Then
            zProcessName = "notepad"
            For Each proc As Process In zProcesses
                Application.DoEvents()
                If proc.ProcessName() = zProcessName Then
                    proc.Kill()
                    'zTint = CInt(txtLazyKillCounter.Text)
                    'zTint = zTint + 1
                    'txtLazyKillCounter.Text = CStr(zTint)
                    'lstKillTimeLog.Items.Add(txtDateTime.Text & " - " & zProcessName)
                    lstKillTimeLog.Items.Add(zTD & " - " & zProcessName)
                    zUpdateKillListCounter()
                End If
            Next
        End If

        '2026-07-07-19-29-13-PM
        'this needs to be a checkbox incase i need to turn it on or off
        'in the lazy timer as if trees
        'commented out in the frmzProccess thing
        'the double click the form part
        'lstProcessKillList.Items.Add("msedge.exe")
        'lstProcessKillList.Items.Add("msedgewebview2.exe")

        'lstProcessKillList.Items.Add("msedge.exe")
        If cKmsedge.Checked = True Then
            zProcessName = "msedge"
            For Each proc As Process In zProcesses
                Application.DoEvents()
                If proc.ProcessName() = zProcessName Then
                    proc.Kill()
                    'zTint = CInt(txtLazyKillCounter.Text)
                    'zTint = zTint + 1
                    'txtLazyKillCounter.Text = CStr(zTint)
                    'lstKillTimeLog.Items.Add(txtDateTime.Text & " - " & zProcessName)
                    lstKillTimeLog.Items.Add(zTD & " - " & zProcessName)
                    zUpdateKillListCounter()
                End If
            Next
        End If

        'lstProcessKillList.Items.Add("msedgewebview2.exe")
        If cKmsedgewebview2.Checked = True Then
            zProcessName = "msedgewebview2"
            For Each proc As Process In zProcesses
                Application.DoEvents()
                If proc.ProcessName() = zProcessName Then
                    proc.Kill()
                    'zTint = CInt(txtLazyKillCounter.Text)
                    'zTint = zTint + 1
                    'txtLazyKillCounter.Text = CStr(zTint)
                    'lstKillTimeLog.Items.Add(txtDateTime.Text & " - " & zProcessName)
                    lstKillTimeLog.Items.Add(zTD & " - " & zProcessName)
                    zUpdateKillListCounter()
                End If
            Next
        End If


        'StopMyService("PolicyAgent")
        zListCount = lstServiceKillList.Items.Count
        For zIt = 0 To zListCount - 1
            Application.DoEvents()
            StopMyService(lstServiceKillList.Items.Item(zIt))
        Next
    End Sub


    Private Sub btLazyKillTest_Click(sender As Object, e As EventArgs) Handles btLazyKillTest.Click
        'zLazyKillTest()
        zLazyKillTestUsingLists()
    End Sub

    Private Sub ckLazyKillTimer_CheckedChanged(sender As Object, e As EventArgs) Handles ckLazyKillTimer.CheckedChanged
        If ckLazyKillTimer.Checked = True Then
            tmrLazyKill.Enabled = True
        Else
            tmrLazyKill.Enabled = False
        End If
    End Sub

    Private Sub lstServiceKillList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstServiceKillList.SelectedIndexChanged

    End Sub

    'Public zFrmMainDefWidth As Integer = 664
    'Public zFrmMainDefHeight As Integer = 568
    'frmMain default size
    'width 664
    'height 568

    'Public zFrmMainMaxWidth As Integer = 664
    'Public zFrmMainMaxHeight As Integer = 568
    'frmMain max size
    'width 927
    'height 905


    '2026-07-07-20-49-21-PM
    Public zFrmMainDefWidth As Integer = 1201
    Public zFrmMainDefHeight As Integer = 697
    'frmMain default size
    'width 774
    'height 570

    Public zFrmMainMaxWidth As Integer = 1201
    Public zFrmMainMaxHeight As Integer = 697
    'frmMain max size
    'width 774
    'height 570


    Public Sub zFrmMainSetDefaultSize()
        Me.Width = zFrmMainDefWidth
        Me.Height = zFrmMainDefHeight
    End Sub


    Private Sub frmzProcess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Application.DoEvents()
        zPopKillLists()
        zUpdateTimeDate()
        '2026-07-07-22-41-44-PM
        'changing this
        'to thestart timer
        'tmrTimeDate.Enabled = True
        'tmrLazyKill.Enabled = True

        '2026-07-07-22-55-46-PM
        'turning this off
        'i think i had it on because of the
        'windows scaling dpi thing
        'which is fixed by chaning the dpi settings
        'to load from application
        'from right clicking through properties on the file
        'where the admin tick box is
        'zFrmMainSetDefaultSize()

        '2026-07-07-21-24-58-PM
        'populating process listbox on form load
        '2026-07-07-22-26-37-PM
        'putting this in a start timer
        'uses these
        'Public zProcessStart As Integer = 0
        'Public zProcessStartTick As Integer = 0

        'zbtGetProcesses_Click()

    End Sub

    Public zTD As String
    Public Sub zUpdateTimeDate()
        Application.DoEvents()
        'Dim zTD As String
        zTD = DateString & " - " & TimeString
        'txtDateTime.Text = zTD
    End Sub

    Public Sub zUpdateTimeDateTextbox()
        Application.DoEvents()
        'Dim zTD As String
        'zTD = DateString & " - " & TimeString
        'txtDateTime.Text = zTD
        txtDateTime.Text = DateString & " - " & TimeString
    End Sub


    Private Sub tmrTimeDate_Tick(sender As Object, e As EventArgs) Handles tmrTimeDate.Tick
        'zUpdateTimeDate()
        'this just updates the textbox readout
        'it doesnt update the zTD string which is called already from
        'the process killing sub
        'calling it twice more than normal is stupid
        zUpdateTimeDateTextbox()


    End Sub

    Private Sub txtLazyKillCounter_TextChanged(sender As Object, e As EventArgs) Handles txtLazyKillCounter.TextChanged

    End Sub

    Private Sub ckNotepadTest_CheckedChanged(sender As Object, e As EventArgs) Handles ckNotepadTest.CheckedChanged

    End Sub

    Private Sub frmzProcess_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.Width > zFrmMainMaxWidth Then
            Me.Width = zFrmMainMaxWidth
        End If
        If Me.Height > zFrmMainMaxHeight Then
            Me.Height = zFrmMainMaxHeight
        End If

    End Sub

    Private Sub btPIDTextClear_Click(sender As Object, e As EventArgs) Handles btPIDTextClear.Click
        txtlstProcessOutput.Text = ""
    End Sub

    Public zProcessStart As Integer = 0
    Public zProcessStartTick As Integer = 0

    Private Sub tmrStart_Tick(sender As Object, e As EventArgs) Handles tmrStart.Tick
        Application.DoEvents()
        If zProcessStart = 0 Then
            If zProcessStartTick = 1 Then
                cKmsedge.Checked = True
                cKmsedgewebview2.Checked = True
                zbtGetProcesses_Click()
                tmrTimeDate.Enabled = True
                tmrLazyKill.Enabled = True
                ckLazyKillTimer.Checked = True
                zProcessStartTick = 0
                zProcessStart = 1
            Else
                zProcessStartTick = zProcessStartTick + 1
            End If
        End If
    End Sub

    Private Sub txtLstPIDOutputClear_Click(sender As Object, e As EventArgs) Handles txtLstPIDOutputClear.Click
        txtLstPIDOutput.Text = ""
    End Sub

    Private Sub bttxtlstProcessOutputCopy_Click(sender As Object, e As EventArgs) Handles bttxtlstProcessOutputCopy.Click
        Clipboard.Clear()
        Clipboard.SetText(txtlstProcessOutput.Text)
    End Sub

    Private Sub bttxtLstPIDOutputCopy_Click(sender As Object, e As EventArgs) Handles bttxtLstPIDOutputCopy.Click
        Clipboard.Clear()
        Clipboard.SetText(txtLstPIDOutput.Text)

    End Sub
End Class
