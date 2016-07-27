<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.F_ = New System.Windows.Forms.ToolStripSplitButton()
        Me.F_E = New System.Windows.Forms.ToolStripMenuItem()
        Me.F_O = New System.Windows.Forms.ToolStripMenuItem()
        Me.F_O_S = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ForgetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoogleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PokemonClubToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.F_O_A_F_ALL = New System.Windows.Forms.ToolStripMenuItem()
        Me.File_OpenExternal = New System.Windows.Forms.ToolStripMenuItem()
        Me.File_OpenInternal = New System.Windows.Forms.ToolStripMenuItem()
        Me.File_StopServer = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.cb_aType = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_uName = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_uPwd = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel6 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_uLocation = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.cb_Steps = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_Go = New System.Windows.Forms.ToolStripButton()
        Me.btn_VarsTest = New System.Windows.Forms.ToolStripButton()
        Me.wb = New System.Windows.Forms.WebBrowser()
        Me.xBox_rMe = New System.Windows.Forms.CheckBox()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.F_, Me.ToolStripSeparator1, Me.ToolStripLabel5, Me.cb_aType, Me.ToolStripLabel1, Me.txt_uName, Me.ToolStripSeparator2, Me.ToolStripLabel2, Me.txt_uPwd, Me.ToolStripSeparator3, Me.ToolStripLabel6, Me.ToolStripSeparator6, Me.ToolStripLabel3, Me.txt_uLocation, Me.ToolStripSeparator4, Me.ToolStripLabel4, Me.cb_Steps, Me.ToolStripSeparator5, Me.btn_Go, Me.btn_VarsTest})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1345, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'F_
        '
        Me.F_.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.F_.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.F_E, Me.F_O, Me.File_OpenExternal, Me.File_OpenInternal, Me.File_StopServer})
        Me.F_.Image = CType(resources.GetObject("F_.Image"), System.Drawing.Image)
        Me.F_.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.F_.Name = "F_"
        Me.F_.Size = New System.Drawing.Size(41, 22)
        Me.F_.Text = "File"
        '
        'F_E
        '
        Me.F_E.Name = "F_E"
        Me.F_E.Size = New System.Drawing.Size(147, 22)
        Me.F_E.Text = "Exit"
        '
        'F_O
        '
        Me.F_O.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.F_O_S, Me.AccountsToolStripMenuItem})
        Me.F_O.Name = "F_O"
        Me.F_O.Size = New System.Drawing.Size(147, 22)
        Me.F_O.Text = "Options"
        '
        'F_O_S
        '
        Me.F_O_S.Name = "F_O_S"
        Me.F_O_S.Size = New System.Drawing.Size(124, 22)
        Me.F_O_S.Text = "Settings"
        '
        'AccountsToolStripMenuItem
        '
        Me.AccountsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ForgetToolStripMenuItem})
        Me.AccountsToolStripMenuItem.Name = "AccountsToolStripMenuItem"
        Me.AccountsToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.AccountsToolStripMenuItem.Text = "Accounts"
        '
        'ForgetToolStripMenuItem
        '
        Me.ForgetToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GoogleToolStripMenuItem, Me.PokemonClubToolStripMenuItem, Me.ToolStripSeparator7, Me.F_O_A_F_ALL})
        Me.ForgetToolStripMenuItem.Name = "ForgetToolStripMenuItem"
        Me.ForgetToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.ForgetToolStripMenuItem.Text = "Forget"
        '
        'GoogleToolStripMenuItem
        '
        Me.GoogleToolStripMenuItem.Name = "GoogleToolStripMenuItem"
        Me.GoogleToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.GoogleToolStripMenuItem.Text = "Google"
        '
        'PokemonClubToolStripMenuItem
        '
        Me.PokemonClubToolStripMenuItem.Name = "PokemonClubToolStripMenuItem"
        Me.PokemonClubToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.PokemonClubToolStripMenuItem.Text = "Pokemon Club"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(150, 6)
        '
        'F_O_A_F_ALL
        '
        Me.F_O_A_F_ALL.Name = "F_O_A_F_ALL"
        Me.F_O_A_F_ALL.Size = New System.Drawing.Size(153, 22)
        Me.F_O_A_F_ALL.Text = "All"
        '
        'File_OpenExternal
        '
        Me.File_OpenExternal.Name = "File_OpenExternal"
        Me.File_OpenExternal.Size = New System.Drawing.Size(147, 22)
        Me.File_OpenExternal.Text = "Open External"
        '
        'File_OpenInternal
        '
        Me.File_OpenInternal.Name = "File_OpenInternal"
        Me.File_OpenInternal.Size = New System.Drawing.Size(147, 22)
        Me.File_OpenInternal.Text = "Open Internal"
        '
        'File_StopServer
        '
        Me.File_StopServer.Name = "File_StopServer"
        Me.File_StopServer.Size = New System.Drawing.Size(147, 22)
        Me.File_StopServer.Text = "Stop Server"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(91, 22)
        Me.ToolStripLabel5.Text = "Acoount Type : "
        '
        'cb_aType
        '
        Me.cb_aType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_aType.Items.AddRange(New Object() {"Google", "Pokemon Trainer Club"})
        Me.cb_aType.Name = "cb_aType"
        Me.cb_aType.Size = New System.Drawing.Size(150, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(71, 22)
        Me.ToolStripLabel1.Text = "UserName : "
        '
        'txt_uName
        '
        Me.txt_uName.Name = "txt_uName"
        Me.txt_uName.Size = New System.Drawing.Size(100, 25)
        Me.txt_uName.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(89, 22)
        Me.ToolStripLabel2.Text = "UserPassword : "
        '
        'txt_uPwd
        '
        Me.txt_uPwd.Name = "txt_uPwd"
        Me.txt_uPwd.Size = New System.Drawing.Size(100, 25)
        Me.txt_uPwd.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel6
        '
        Me.ToolStripLabel6.AutoSize = False
        Me.ToolStripLabel6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripLabel6.Enabled = False
        Me.ToolStripLabel6.ForeColor = System.Drawing.SystemColors.Control
        Me.ToolStripLabel6.Name = "ToolStripLabel6"
        Me.ToolStripLabel6.Size = New System.Drawing.Size(100, 22)
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(62, 22)
        Me.ToolStripLabel3.Text = "Location : "
        '
        'txt_uLocation
        '
        Me.txt_uLocation.Name = "txt_uLocation"
        Me.txt_uLocation.Size = New System.Drawing.Size(150, 25)
        Me.txt_uLocation.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(44, 22)
        Me.ToolStripLabel4.Text = "Steps : "
        '
        'cb_Steps
        '
        Me.cb_Steps.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cb_Steps.Name = "cb_Steps"
        Me.cb_Steps.Size = New System.Drawing.Size(75, 25)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'btn_Go
        '
        Me.btn_Go.AutoSize = False
        Me.btn_Go.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btn_Go.Image = CType(resources.GetObject("btn_Go.Image"), System.Drawing.Image)
        Me.btn_Go.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Go.Name = "btn_Go"
        Me.btn_Go.Size = New System.Drawing.Size(50, 22)
        Me.btn_Go.Text = "Go"
        '
        'btn_VarsTest
        '
        Me.btn_VarsTest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btn_VarsTest.Image = CType(resources.GetObject("btn_VarsTest.Image"), System.Drawing.Image)
        Me.btn_VarsTest.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_VarsTest.Name = "btn_VarsTest"
        Me.btn_VarsTest.Size = New System.Drawing.Size(55, 22)
        Me.btn_VarsTest.Text = "VarsTest"
        Me.btn_VarsTest.Visible = False
        '
        'wb
        '
        Me.wb.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.wb.Location = New System.Drawing.Point(0, 27)
        Me.wb.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wb.Name = "wb"
        Me.wb.Size = New System.Drawing.Size(1342, 493)
        Me.wb.TabIndex = 1
        '
        'xBox_rMe
        '
        Me.xBox_rMe.AutoSize = True
        Me.xBox_rMe.BackColor = System.Drawing.Color.White
        Me.xBox_rMe.FlatAppearance.BorderSize = 0
        Me.xBox_rMe.ForeColor = System.Drawing.SystemColors.ControlText
        Me.xBox_rMe.Location = New System.Drawing.Point(676, 4)
        Me.xBox_rMe.Name = "xBox_rMe"
        Me.xBox_rMe.Size = New System.Drawing.Size(95, 17)
        Me.xBox_rMe.TabIndex = 2
        Me.xBox_rMe.Text = "Remember Me"
        Me.xBox_rMe.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1345, 520)
        Me.Controls.Add(Me.xBox_rMe)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.wb)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "PoKeMap"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents F_ As ToolStripSplitButton
    Friend WithEvents F_E As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents txt_uName As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents txt_uPwd As ToolStripTextBox
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents txt_uLocation As ToolStripTextBox
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents cb_Steps As ToolStripComboBox
    Friend WithEvents wb As WebBrowser
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents btn_Go As ToolStripButton
    Friend WithEvents ToolStripLabel5 As ToolStripLabel
    Friend WithEvents cb_aType As ToolStripComboBox
    Friend WithEvents F_O As ToolStripMenuItem
    Friend WithEvents F_O_S As ToolStripMenuItem
    Friend WithEvents btn_VarsTest As ToolStripButton
    Friend WithEvents xBox_rMe As CheckBox
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ToolStripLabel6 As ToolStripLabel
    Friend WithEvents AccountsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ForgetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GoogleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PokemonClubToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents F_O_A_F_ALL As ToolStripMenuItem
    Friend WithEvents File_OpenExternal As ToolStripMenuItem
    Friend WithEvents File_OpenInternal As ToolStripMenuItem
    Friend WithEvents File_StopServer As ToolStripMenuItem
End Class
