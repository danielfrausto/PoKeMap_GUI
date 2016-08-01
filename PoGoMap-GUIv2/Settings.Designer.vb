<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.uPwd = New System.Windows.Forms.TextBox()
        Me.uName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.aType = New System.Windows.Forms.ComboBox()
        Me.uLocation = New System.Windows.Forms.TextBox()
        Me.uSteps = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RememberMe = New System.Windows.Forms.CheckBox()
        Me.pythonDir = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_SetApiKey = New System.Windows.Forms.Button()
        Me.btn_PoGoMapDir = New System.Windows.Forms.Button()
        Me.btn_NodeDir = New System.Windows.Forms.Button()
        Me.btn_PipDir = New System.Windows.Forms.Button()
        Me.btn_PyDir = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ApiKey = New System.Windows.Forms.TextBox()
        Me.PoGoMapDir = New System.Windows.Forms.TextBox()
        Me.nodejsDir = New System.Windows.Forms.TextBox()
        Me.pipDir = New System.Windows.Forms.TextBox()
        Me.FBD = New System.Windows.Forms.FolderBrowserDialog()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'uPwd
        '
        Me.uPwd.Location = New System.Drawing.Point(78, 72)
        Me.uPwd.Name = "uPwd"
        Me.uPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.uPwd.Size = New System.Drawing.Size(136, 20)
        Me.uPwd.TabIndex = 15
        '
        'uName
        '
        Me.uName.Location = New System.Drawing.Point(78, 46)
        Me.uName.Name = "uName"
        Me.uName.Size = New System.Drawing.Size(136, 20)
        Me.uName.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(109, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Steps : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Location : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Password : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "UserName : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Service : "
        '
        'aType
        '
        Me.aType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.aType.FormattingEnabled = True
        Me.aType.Items.AddRange(New Object() {"Google", "Pokemon Trainer Club"})
        Me.aType.Location = New System.Drawing.Point(78, 19)
        Me.aType.Name = "aType"
        Me.aType.Size = New System.Drawing.Size(136, 21)
        Me.aType.TabIndex = 8
        '
        'uLocation
        '
        Me.uLocation.Location = New System.Drawing.Point(78, 118)
        Me.uLocation.Name = "uLocation"
        Me.uLocation.Size = New System.Drawing.Size(136, 20)
        Me.uLocation.TabIndex = 16
        '
        'uSteps
        '
        Me.uSteps.FormattingEnabled = True
        Me.uSteps.Location = New System.Drawing.Point(158, 144)
        Me.uSteps.Name = "uSteps"
        Me.uSteps.Size = New System.Drawing.Size(56, 21)
        Me.uSteps.TabIndex = 17
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RememberMe)
        Me.GroupBox1.Controls.Add(Me.aType)
        Me.GroupBox1.Controls.Add(Me.uSteps)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.uLocation)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.uPwd)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.uName)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(232, 212)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LogIn"
        '
        'RememberMe
        '
        Me.RememberMe.AutoSize = True
        Me.RememberMe.Location = New System.Drawing.Point(119, 98)
        Me.RememberMe.Name = "RememberMe"
        Me.RememberMe.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RememberMe.Size = New System.Drawing.Size(95, 17)
        Me.RememberMe.TabIndex = 20
        Me.RememberMe.Text = "Remember Me"
        Me.RememberMe.UseVisualStyleBackColor = True
        '
        'pythonDir
        '
        Me.pythonDir.Location = New System.Drawing.Point(77, 19)
        Me.pythonDir.Name = "pythonDir"
        Me.pythonDir.Size = New System.Drawing.Size(200, 20)
        Me.pythonDir.TabIndex = 18
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_SetApiKey)
        Me.GroupBox2.Controls.Add(Me.btn_PoGoMapDir)
        Me.GroupBox2.Controls.Add(Me.btn_NodeDir)
        Me.GroupBox2.Controls.Add(Me.btn_PipDir)
        Me.GroupBox2.Controls.Add(Me.btn_PyDir)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.ApiKey)
        Me.GroupBox2.Controls.Add(Me.PoGoMapDir)
        Me.GroupBox2.Controls.Add(Me.nodejsDir)
        Me.GroupBox2.Controls.Add(Me.pipDir)
        Me.GroupBox2.Controls.Add(Me.pythonDir)
        Me.GroupBox2.Location = New System.Drawing.Point(250, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(374, 212)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "System Files"
        '
        'btn_SetApiKey
        '
        Me.btn_SetApiKey.Location = New System.Drawing.Point(283, 120)
        Me.btn_SetApiKey.Name = "btn_SetApiKey"
        Me.btn_SetApiKey.Size = New System.Drawing.Size(75, 23)
        Me.btn_SetApiKey.TabIndex = 32
        Me.btn_SetApiKey.Text = "Set"
        Me.btn_SetApiKey.UseVisualStyleBackColor = True
        '
        'btn_PoGoMapDir
        '
        Me.btn_PoGoMapDir.Location = New System.Drawing.Point(283, 94)
        Me.btn_PoGoMapDir.Name = "btn_PoGoMapDir"
        Me.btn_PoGoMapDir.Size = New System.Drawing.Size(75, 23)
        Me.btn_PoGoMapDir.TabIndex = 31
        Me.btn_PoGoMapDir.Text = "Set"
        Me.btn_PoGoMapDir.UseVisualStyleBackColor = True
        '
        'btn_NodeDir
        '
        Me.btn_NodeDir.Location = New System.Drawing.Point(283, 68)
        Me.btn_NodeDir.Name = "btn_NodeDir"
        Me.btn_NodeDir.Size = New System.Drawing.Size(75, 23)
        Me.btn_NodeDir.TabIndex = 30
        Me.btn_NodeDir.Text = "Set"
        Me.btn_NodeDir.UseVisualStyleBackColor = True
        '
        'btn_PipDir
        '
        Me.btn_PipDir.Location = New System.Drawing.Point(283, 42)
        Me.btn_PipDir.Name = "btn_PipDir"
        Me.btn_PipDir.Size = New System.Drawing.Size(75, 23)
        Me.btn_PipDir.TabIndex = 29
        Me.btn_PipDir.Text = "Set"
        Me.btn_PipDir.UseVisualStyleBackColor = True
        '
        'btn_PyDir
        '
        Me.btn_PyDir.Location = New System.Drawing.Point(283, 17)
        Me.btn_PyDir.Name = "btn_PyDir"
        Me.btn_PyDir.Size = New System.Drawing.Size(75, 23)
        Me.btn_PyDir.TabIndex = 28
        Me.btn_PyDir.Text = "Set"
        Me.btn_PyDir.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 125)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "ApiKey : "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 99)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "PoGoMap : "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Nodejs : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Pip : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Python : "
        '
        'ApiKey
        '
        Me.ApiKey.Location = New System.Drawing.Point(77, 122)
        Me.ApiKey.Name = "ApiKey"
        Me.ApiKey.Size = New System.Drawing.Size(200, 20)
        Me.ApiKey.TabIndex = 22
        '
        'PoGoMapDir
        '
        Me.PoGoMapDir.Location = New System.Drawing.Point(77, 96)
        Me.PoGoMapDir.Name = "PoGoMapDir"
        Me.PoGoMapDir.Size = New System.Drawing.Size(200, 20)
        Me.PoGoMapDir.TabIndex = 21
        '
        'nodejsDir
        '
        Me.nodejsDir.Location = New System.Drawing.Point(77, 70)
        Me.nodejsDir.Name = "nodejsDir"
        Me.nodejsDir.Size = New System.Drawing.Size(200, 20)
        Me.nodejsDir.TabIndex = 20
        '
        'pipDir
        '
        Me.pipDir.Location = New System.Drawing.Point(77, 44)
        Me.pipDir.Name = "pipDir"
        Me.pipDir.Size = New System.Drawing.Size(200, 20)
        Me.pipDir.TabIndex = 19
        '
        'OFD
        '
        Me.OFD.FileName = "OpenFileDialog1"
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 236)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents uPwd As TextBox
    Friend WithEvents uName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents aType As ComboBox
    Friend WithEvents uLocation As TextBox
    Friend WithEvents uSteps As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents pythonDir As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ApiKey As TextBox
    Friend WithEvents PoGoMapDir As TextBox
    Friend WithEvents nodejsDir As TextBox
    Friend WithEvents pipDir As TextBox
    Friend WithEvents RememberMe As CheckBox
    Friend WithEvents btn_SetApiKey As Button
    Friend WithEvents btn_PoGoMapDir As Button
    Friend WithEvents btn_NodeDir As Button
    Friend WithEvents btn_PipDir As Button
    Friend WithEvents btn_PyDir As Button
    Friend WithEvents FBD As FolderBrowserDialog
    Friend WithEvents OFD As OpenFileDialog
End Class
