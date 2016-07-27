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
        Me.btn_Settings_Show = New System.Windows.Forms.Button()
        Me.txt_pythonDir = New System.Windows.Forms.TextBox()
        Me.txt_pipDir = New System.Windows.Forms.TextBox()
        Me.txt_pokemapDir = New System.Windows.Forms.TextBox()
        Me.btn_PYTHONset = New System.Windows.Forms.Button()
        Me.btn_PIPset = New System.Windows.Forms.Button()
        Me.btn_PGMset = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fbd = New System.Windows.Forms.FolderBrowserDialog()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.btn_ClearSettings = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_Settings_Show
        '
        Me.btn_Settings_Show.Location = New System.Drawing.Point(412, 119)
        Me.btn_Settings_Show.Name = "btn_Settings_Show"
        Me.btn_Settings_Show.Size = New System.Drawing.Size(75, 23)
        Me.btn_Settings_Show.TabIndex = 0
        Me.btn_Settings_Show.Text = "Show"
        Me.btn_Settings_Show.UseVisualStyleBackColor = True
        '
        'txt_pythonDir
        '
        Me.txt_pythonDir.Location = New System.Drawing.Point(122, 18)
        Me.txt_pythonDir.Name = "txt_pythonDir"
        Me.txt_pythonDir.Size = New System.Drawing.Size(284, 20)
        Me.txt_pythonDir.TabIndex = 1
        '
        'txt_pipDir
        '
        Me.txt_pipDir.Location = New System.Drawing.Point(122, 44)
        Me.txt_pipDir.Name = "txt_pipDir"
        Me.txt_pipDir.Size = New System.Drawing.Size(284, 20)
        Me.txt_pipDir.TabIndex = 2
        '
        'txt_pokemapDir
        '
        Me.txt_pokemapDir.Location = New System.Drawing.Point(122, 70)
        Me.txt_pokemapDir.Name = "txt_pokemapDir"
        Me.txt_pokemapDir.Size = New System.Drawing.Size(284, 20)
        Me.txt_pokemapDir.TabIndex = 3
        '
        'btn_PYTHONset
        '
        Me.btn_PYTHONset.Location = New System.Drawing.Point(412, 15)
        Me.btn_PYTHONset.Name = "btn_PYTHONset"
        Me.btn_PYTHONset.Size = New System.Drawing.Size(75, 23)
        Me.btn_PYTHONset.TabIndex = 4
        Me.btn_PYTHONset.Text = "Set"
        Me.btn_PYTHONset.UseVisualStyleBackColor = True
        '
        'btn_PIPset
        '
        Me.btn_PIPset.Location = New System.Drawing.Point(412, 42)
        Me.btn_PIPset.Name = "btn_PIPset"
        Me.btn_PIPset.Size = New System.Drawing.Size(75, 23)
        Me.btn_PIPset.TabIndex = 5
        Me.btn_PIPset.Text = "Set"
        Me.btn_PIPset.UseVisualStyleBackColor = True
        '
        'btn_PGMset
        '
        Me.btn_PGMset.Location = New System.Drawing.Point(412, 68)
        Me.btn_PGMset.Name = "btn_PGMset"
        Me.btn_PGMset.Size = New System.Drawing.Size(75, 23)
        Me.btn_PGMset.TabIndex = 6
        Me.btn_PGMset.Text = "Set"
        Me.btn_PGMset.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Pyhton : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Pip : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "PokemonGo - Map : "
        '
        'ofd
        '
        Me.ofd.Filter = "Python File |*.py"
        '
        'btn_ClearSettings
        '
        Me.btn_ClearSettings.Location = New System.Drawing.Point(12, 118)
        Me.btn_ClearSettings.Name = "btn_ClearSettings"
        Me.btn_ClearSettings.Size = New System.Drawing.Size(75, 23)
        Me.btn_ClearSettings.TabIndex = 10
        Me.btn_ClearSettings.Text = "Clear"
        Me.btn_ClearSettings.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 153)
        Me.Controls.Add(Me.btn_ClearSettings)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_PGMset)
        Me.Controls.Add(Me.btn_PIPset)
        Me.Controls.Add(Me.btn_PYTHONset)
        Me.Controls.Add(Me.txt_pokemapDir)
        Me.Controls.Add(Me.txt_pipDir)
        Me.Controls.Add(Me.txt_pythonDir)
        Me.Controls.Add(Me.btn_Settings_Show)
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Settings_Show As Button
    Friend WithEvents txt_pythonDir As TextBox
    Friend WithEvents txt_pipDir As TextBox
    Friend WithEvents txt_pokemapDir As TextBox
    Friend WithEvents btn_PYTHONset As Button
    Friend WithEvents btn_PIPset As Button
    Friend WithEvents btn_PGMset As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents fbd As FolderBrowserDialog
    Friend WithEvents ofd As OpenFileDialog
    Friend WithEvents btn_ClearSettings As Button
End Class
