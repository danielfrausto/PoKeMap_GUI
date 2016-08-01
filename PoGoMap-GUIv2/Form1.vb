
Public Class Form1

    Private psi As ProcessStartInfo
    Private cmd As Process
    Private Delegate Sub InvokeWithString(ByVal text As String)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub btn_Go_Click(sender As Object, e As EventArgs) Handles btn_Go.Click



        ' GetMap()
        BGW.RunWorkerAsync()

    End Sub
    Private Sub SHowMeVars()
        MsgBox("aType : " & My.Settings.aType & vbNewLine &
        "Uname : " & My.Settings.uName & vbNewLine &
        "uPwd : " & My.Settings.uPwd & vbNewLine &
        "RememberMe : " & My.Settings.RememberMe & vbNewLine &
        "uLocation : " & My.Settings.uLocation & vbNewLine &
         "uSteps : " & My.Settings.uSteps & vbNewLine &
        "PythonDir : " & My.Settings.PythonDir & vbNewLine &
        "PipDir : " & My.Settings.PipDir & vbNewLine &
        "NodeJsDir : " & My.Settings.NodejsDir & vbNewLine &
        "PoGoMapDir : " & My.Settings.PoGoMapDir & vbNewLine &
        "uApiKey : " & My.Settings.uApiKey)
    End Sub

    Private Sub File_Settings_Click(sender As Object, e As EventArgs) Handles File_Settings.Click
        Settings.Show()
    End Sub
    Private Sub GetMap()
        'Dim AppName = "python "
        'Dim ScriptName = My.Settings.PoGoMapDir & "\" & "runserver.py "
        'Dim uName = "-u " & My.Settings.uName
        'Dim uPwd = " -p " & My.Settings.uPwd
        'Dim uApikey = " -k " & My.Settings.uApiKey
        'Dim uLocation = " -l """ & My.Settings.uLocation & """"
        'Dim arg = AppName & ScriptName & uName & uPwd & uApikey & uLocation
        'Dim arg2 = ScriptName & uName & uPwd & uApikey & uLocation
        'Dim arg3 = "cd " & My.Settings.PoGoMapDir
        'MsgBox(arg3)


        ' Debug.AppendText("aType : " & My.Settings.aType & vbNewLine &
        '"Uname : " & My.Settings.uName & vbNewLine &
        '"uPwd : " & My.Settings.uPwd & vbNewLine &
        '"RememberMe : " & My.Settings.RememberMe & vbNewLine &
        '"uLocation : " & My.Settings.uLocation & vbNewLine &
        ' "uSteps : " & My.Settings.uSteps & vbNewLine &
        '"PythonDir : " & My.Settings.PythonDir & vbNewLine &
        '"PipDir : " & My.Settings.PipDir & vbNewLine &
        '"NodeJsDir : " & My.Settings.NodejsDir & vbNewLine &
        '"PoGoMapDir : " & My.Settings.PoGoMapDir & vbNewLine &
        '"uApiKey : " & My.Settings.uApiKey)




        'Dim AppName = "python "
        'Dim ScriptName = My.Settings.PoGoMapDir & "\" & "runserver.py "
        'Dim uName = "-u " & My.Settings.uName
        'Dim uPwd = " -p " & My.Settings.uPwd
        'Dim uApikey = " -k " & My.Settings.uApiKey
        'Dim uLocation = " -l """ & My.Settings.uLocation & """"
        'Dim arg = AppName & ScriptName & uName & uPwd & uApikey & uLocation
        'Dim arg2 = ScriptName & uName & uPwd & uApikey & uLocation
        'Debug.AppendText(arg & vbNewLine)
        'Debug.AppendText(arg2 & vbNewLine)


        ' WebControl1.WebView.LoadUrl("http://localhost:5000")


    End Sub

    Dim Err00 = "No Account Type"
    Dim Err01 = "No UserName"
    Dim Err02 = "No Password"
    Dim Err03 = ""
    Dim Err04 = ""

    Private Sub BGW_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGW.DoWork


        If My.Settings.aType = "" Then
            MsgBox(Err00)
        Else
            If My.Settings.uName = "" Then
                MsgBox(Err01)
            Else
                If My.Settings.uPwd = "" Then
                    MsgBox(Err02)
                End If
            End If
        End If





        Dim AppName = "python "
        Dim ScriptName = My.Settings.PoGoMapDir & "\" & "runserver.py "
        Dim uName = "-u " & My.Settings.uName
        Dim uPwd = " -p " & My.Settings.uPwd
        Dim uSteps = " -st " & My.Settings.uSteps
        Dim uApikey = " -k " & My.Settings.uApiKey
        Dim uLocation = " -l """ & My.Settings.uLocation & """"
        Dim arg = AppName & ScriptName & uName & uPwd & uApikey & uLocation
        Dim arg2 = ScriptName & uName & uPwd & uSteps & uApikey & uLocation

        '  MsgBox(arg2)


        Try
            cmd.Kill()
        Catch ex As Exception
        End Try
        'Debug.Clear()
        ShowStatus.Text = "Working..."


        psi = New ProcessStartInfo("python", arg2)


        Dim systemencoding As System.Text.Encoding
        System.Text.Encoding.GetEncoding(Globalization.CultureInfo.CurrentUICulture.TextInfo.OEMCodePage)
        With psi
            .UseShellExecute = False
            .RedirectStandardError = True
            .RedirectStandardOutput = True
            .RedirectStandardInput = True
            .CreateNoWindow = True
            .StandardOutputEncoding = systemencoding
            .StandardErrorEncoding = systemencoding
        End With
        cmd = New Process With {.StartInfo = psi, .EnableRaisingEvents = True}
        AddHandler cmd.ErrorDataReceived, AddressOf Async_Data_Received
        AddHandler cmd.OutputDataReceived, AddressOf Async_Data_Received
        cmd.Start()
        cmd.BeginOutputReadLine()
        cmd.BeginErrorReadLine()
    End Sub
    Private Sub Async_Data_Received(ByVal sender As Object, ByVal e As DataReceivedEventArgs)
        Me.Invoke(New InvokeWithString(AddressOf Sync_Output), e.Data)
    End Sub
    Private Sub Sync_Output(ByVal text As String)
        ' Debug.AppendText(text & Environment.NewLine)
        ShowStatus.Text = text
        Try
            If text.Contains("Login to Pokemon Go successful") Then
                ' MsgBox("Login Successful!")
                WebControl1.WebView.LoadUrl("http://localhost:5000")
            End If
            ' Debug.ScrollToCaret()
        Catch ex As Exception

        End Try




    End Sub

    Private Sub BGW_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGW.RunWorkerCompleted
        ShowStatus.Text = "Done!"
    End Sub

    Private Sub File_StopServer_Click(sender As Object, e As EventArgs) Handles File_StopServer.Click
        KillPython()
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

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        KillPython()
    End Sub
End Class
