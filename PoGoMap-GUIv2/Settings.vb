Public Class Settings
    Public Sub sSettings()
        My.Settings.Save()
    End Sub


    Private Sub Settings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If RememberMe.Checked = True Then
            My.Settings.aType = aType.SelectedIndex
            My.Settings.uName = uName.Text
            My.Settings.uPwd = uPwd.Text
            My.Settings.RememberMe = RememberMe.Checked
            sSettings()
        Else
            My.Settings.aType = ""
            My.Settings.uName = ""
            My.Settings.uPwd = ""

        End If

        My.Settings.RememberMe = RememberMe.Checked
        My.Settings.uLocation = uLocation.Text
        My.Settings.uSteps = uSteps.Text
        My.Settings.PythonDir = pythonDir.Text
        My.Settings.PipDir = pipDir.Text
        My.Settings.NodejsDir = nodejsDir.Text
        My.Settings.PoGoMapDir = PoGoMapDir.Text
        My.Settings.uApiKey = ApiKey.Text
        sSettings()

    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        aType.SelectedIndex = My.Settings.aType
        uName.Text = My.Settings.uName
        uPwd.Text = My.Settings.uPwd
        RememberMe.Checked = My.Settings.RememberMe
        uLocation.Text = My.Settings.uLocation
        uSteps.Text = My.Settings.uSteps



        pythonDir.Text = My.Settings.PythonDir
        pipDir.Text = My.Settings.PipDir
        nodejsDir.Text = My.Settings.NodejsDir
        PoGoMapDir.Text = My.Settings.PoGoMapDir
        ApiKey.Text = My.Settings.uApiKey



    End Sub
End Class