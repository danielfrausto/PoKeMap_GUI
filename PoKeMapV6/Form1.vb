Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' wb.Navigate("https://www.google.com/ncr")



        If My.Settings.Steps = "" Then
            cb_Steps.SelectedIndex = 9
        Else
            cb_Steps.SelectedIndex = My.Settings.Steps
        End If


        If My.Settings.aType = "" Then

            cb_aType.SelectedIndex = 1
        Else
            cb_aType.SelectedIndex = My.Settings.aType
        End If


        'If cb_aType.SelectedIndex = 0 Then
        '    txt_uName.Text = My.Settings.ggl_uName
        '    txt_uPwd.Text = My.Settings.ggl_uPwd
        'Else
        '    If cb_aType.SelectedIndex = 1 Then
        '        txt_uName.Text = My.Settings.ptc_uName
        '        txt_uPwd.Text = My.Settings.ptc_uPwd
        '    End If
        'End If


        txt_uPwd.TextBox.PasswordChar = "*"
        SetVars()
        SetLocation()
        xBox_rMe.Checked = My.Settings.RememberMe
    End Sub
    Dim MapVer = 2
    Dim ScriptName = ""
    Dim PythonDir = ""
    Dim PipDir = ""
    Dim PokeMapDir = ""
    Dim aType = ""
    Dim uName = ""
    Dim uPwd = ""
    Dim uLocation = ""
    Dim Steps = ""
    Public Sub SetVars()
        PythonDir = My.Settings.PythonDir
        PipDir = My.Settings.PipDir
        PokeMapDir = My.Settings.PokeMapDir
        SetLogIn()
        uLocation = My.Settings.uLocation
        'Steps = My.Settings.Steps + 1
        Steps = cb_Steps.Text
    End Sub
    Public Sub SetLocation()
        txt_uLocation.Text = uLocation
    End Sub
    Private Sub SetLogIn()
        Select Case cb_aType.SelectedIndex
            Case 0
                uName = My.Settings.ggl_uName
                uPwd = My.Settings.ggl_uPwd
                txt_uName.Text = My.Settings.ggl_uName
                txt_uPwd.Text = My.Settings.ggl_uPwd
                aType = "google"
            Case 1
                uName = My.Settings.ptc_uName
                uPwd = My.Settings.ptc_uPwd
                txt_uName.Text = My.Settings.ptc_uName
                txt_uPwd.Text = My.Settings.ptc_uPwd
                aType = "ptc"
        End Select



    End Sub


    Private Sub File_Exit_Click(sender As Object, e As EventArgs) Handles F_E.Click
        Application.Exit()
    End Sub

    Private Sub F_O_S_Click(sender As Object, e As EventArgs) Handles F_O_S.Click
        Settings.Show()
    End Sub

    Private Sub btn_VarsTest_Click(sender As Object, e As EventArgs) Handles btn_VarsTest.Click
        MsgBox(My.Settings.PythonDir & vbNewLine &
             My.Settings.PipDir & vbNewLine &
             My.Settings.PokeMapDir & vbNewLine &
             My.Settings.ggl_uName & vbNewLine &
             My.Settings.ggl_uPwd & vbNewLine &
           My.Settings.ptc_uName & vbNewLine &
          My.Settings.ptc_uPwd & vbNewLine &
          My.Settings.uLocation)

        MsgBox(PythonDir & vbNewLine &
             PipDir & vbNewLine &
             PokeMapDir & vbNewLine &
             uName & vbNewLine &
             uPwd & vbNewLine &
             uLocation)
        MsgBox(My.Settings.Steps)
    End Sub

    Private Sub cb_Steps_DropDownClosed(sender As Object, e As EventArgs) Handles cb_Steps.DropDownClosed
        ' MsgBox("YouChanged")
        My.Settings.Steps = cb_Steps.SelectedIndex
        My.Settings.Save()
    End Sub

    Private Sub cb_aType_DropDownClosed(sender As Object, e As EventArgs) Handles cb_aType.DropDownClosed
        My.Settings.aType = cb_aType.SelectedIndex
        My.Settings.Save()
        SetLogIn()
    End Sub

    Private Sub xBox_rMe_CheckStateChanged(sender As Object, e As EventArgs) Handles xBox_rMe.CheckStateChanged
        'If xBox_rMe.Checked = True Then

        '    If txt_uName.Text = "" Then
        '        MsgBox("No User Name Detected")
        '        UnCheck()
        '    Else
        '        If txt_uPwd.Text = "" Then
        '            MsgBox("No Password Detected")
        '            UnCheck()

        '        Else
        '            RememberMe()

        '        End If
        '    End If
        'End If

    End Sub
    Private Sub UnCheck()
        xBox_rMe.Checked = False
    End Sub
    Private Sub RememberMe()
        If xBox_rMe.Checked = True Then
            ' MsgBox("Will Remember")
            If cb_aType.SelectedIndex = 0 Then
                My.Settings.ggl_uName = txt_uName.Text
                My.Settings.ggl_uPwd = txt_uPwd.Text
                My.Settings.Save()
            End If

            If cb_aType.SelectedIndex = 1 Then
                My.Settings.ptc_uName = txt_uName.Text
                My.Settings.ptc_uPwd = txt_uPwd.Text
                My.Settings.Save()
            End If
        End If




        If Not uLocation = "" Then
            My.Settings.uLocation = uLocation
            SaveSettings()
        Else

            If Not txt_uLocation.Text = "" Then
                My.Settings.uLocation = txt_uLocation.Text
                SaveSettings()
            End If

        End If
    End Sub
    Private Sub SaveSettings()
        My.Settings.Save()
    End Sub

    Private Sub ForgetAll()
        If cb_aType.SelectedIndex = 0 Then
            My.Settings.ggl_uName = ""
            My.Settings.ggl_uPwd = ""
            My.Settings.Save()
        End If

        If cb_aType.SelectedIndex = 1 Then
            My.Settings.ptc_uName = ""
            My.Settings.ptc_uPwd = ""
            My.Settings.Save()
        End If
    End Sub
    Private Sub ClearLogin()
        txt_uName.Clear()
        txt_uPwd.Clear()
    End Sub
    Private Sub Forget_GGL()
        My.Settings.ggl_uName = ""
        My.Settings.ggl_uPwd = ""
        My.Settings.Save()
    End Sub

    Private Sub Forget_PTC()
        My.Settings.ptc_uName = ""
        My.Settings.ptc_uPwd = ""
        My.Settings.Save()
    End Sub
    Private Sub btn_Go_Click(sender As Object, e As EventArgs) Handles btn_Go.Click
        '   MsgBox(xBox_rMe.Checked)
        ' RememberMe()
        GetPoke()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If xBox_rMe.Checked = True Then
            RememberMe()
        ElseIf xBox_rMe.Checked = False Then
            ForgetAll()

        End If
        My.Settings.RememberMe = xBox_rMe.Checked
        My.Settings.Save()

        KillPython()

    End Sub

    Private Sub F_O_A_F_ALL_Click(sender As Object, e As EventArgs) Handles F_O_A_F_ALL.Click

        Dim result As DialogResult = MessageBox.Show("This option will remove ALL accounts." & vbNewLine &
               "Are you Sure?", "Warning!", MessageBoxButtons.YesNo)

        If (result = DialogResult.Yes) Then
            ForgetAll()
            ClearLogin()
        Else

        End If

    End Sub

    Private Sub SetScriptName()
        Select Case MapVer
            Case 1
                ScriptName = "example.py"
            Case 2
                ScriptName = "runserver.py"

        End Select
    End Sub


    Private Sub GetPoke()
        SetScriptName()
        Dim arg = ""



        arg = ScriptName & " -a " & aType & " -u " & uName & " -p " & uPwd & " -l " & """" & uLocation & """" & " -st " & Steps
        ' MsgBox(arg)


        'Dim tx As New TextBox

        'Dim proc As New Process
        'proc.StartInfo.FileName = "cmd.exe"
        'proc.StartInfo.Arguments = "/k cd " & PokeMapDir & "&&" & arg
        'proc.StartInfo.CreateNoWindow = True
        'proc.StartInfo.UseShellExecute = False
        'proc.StartInfo.RedirectStandardOutput = True
        'proc.Start()
        'proc.WaitForExit()
        'Dim output() As String = proc.StandardOutput.ReadToEnd.Split(CChar(vbLf))
        'For Each ln As String In output
        '    tx.AppendText(ln & vbNewLine)
        'Next
        'wb.DocumentText = tx.Text
        Process.Start("cmd.exe", "/k cd " & PokeMapDir & "&&" & arg)
        wb.Navigate("http://localhost:5000/")
    End Sub

    Private Sub File_OpenExternal_Click(sender As Object, e As EventArgs) Handles File_OpenExternal.Click
        Process.Start("http://localhost:5000/")
    End Sub

    Private Sub File_OpenInternal_Click(sender As Object, e As EventArgs) Handles File_OpenInternal.Click
        wb.Navigate("http://localhost:5000/")
    End Sub

    Private Sub File_StopServer_Click(sender As Object, e As EventArgs) Handles File_StopServer.Click
        KillPython
    End Sub
    Private Sub KillPython()
        Try

            Dim _proceses As Process()
            _proceses = Process.GetProcessesByName("python")
            For Each process As Process In _proceses
                process.Kill()
            Next


            Dim cmd As Process()
            cmd = Process.GetProcessesByName("cmd")
            For Each process As Process In cmd
                process.Kill()
            Next
        Catch ex As Exception
        End Try

    End Sub
End Class
