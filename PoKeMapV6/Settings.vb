Public Class Settings
    Private Sub btn_PYTHONset_Click(sender As Object, e As EventArgs) Handles btn_PYTHONset.Click
        Dim result As DialogResult = fbd.ShowDialog()
        ' fbd.ShowDialog()
        If result = DialogResult.OK Then
            txt_pythonDir.Text = fbd.SelectedPath
            My.Settings.PythonDir = fbd.SelectedPath
            My.Settings.Save()
        End If
    End Sub

    Private Sub btn_PIPset_Click(sender As Object, e As EventArgs) Handles btn_PIPset.Click
        Dim result As DialogResult = ofd.ShowDialog()
        ' fbd.ShowDialog()
        If result = DialogResult.OK Then
            txt_pipDir.Text = ofd.FileName
            My.Settings.PipDir = ofd.FileName
            My.Settings.Save()
        End If
    End Sub

    Private Sub btn_PGMset_Click(sender As Object, e As EventArgs) Handles btn_PGMset.Click
        Dim result As DialogResult = fbd.ShowDialog()
        ' fbd.ShowDialog()
        If result = DialogResult.OK Then
            txt_pokemapDir.Text = fbd.SelectedPath
            My.Settings.PokeMapDir = fbd.SelectedPath
            My.Settings.Save()
        End If
    End Sub



    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_pythonDir.Text = My.Settings.PythonDir
        txt_pipDir.Text = My.Settings.PipDir
        txt_pokemapDir.Text = My.Settings.PokeMapDir
    End Sub

    Private Sub btn_Settings_Show_Click(sender As Object, e As EventArgs) Handles btn_Settings_Show.Click
        MsgBox(My.Settings.PythonDir & vbNewLine &
              My.Settings.PipDir & vbNewLine &
              My.Settings.PokeMapDir)
    End Sub

    Private Sub btn_ClearSettings_Click(sender As Object, e As EventArgs) Handles btn_ClearSettings.Click
        My.Settings.PythonDir = ""
        My.Settings.PipDir = ""
        My.Settings.PokeMapDir = ""
        My.Settings.Save()
    End Sub
End Class