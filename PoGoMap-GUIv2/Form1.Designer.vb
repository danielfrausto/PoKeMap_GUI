<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Menu_ = New System.Windows.Forms.MenuStrip()
        Me.File_ = New System.Windows.Forms.ToolStripMenuItem()
        Me.File_Exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.File_Debug = New System.Windows.Forms.ToolStripMenuItem()
        Me.File_Settings = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Debug = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_Go = New System.Windows.Forms.ToolStripButton()
        Me.BGW = New System.ComponentModel.BackgroundWorker()
        Me.WebControl1 = New EO.WebBrowser.WinForm.WebControl()
        Me.WebView1 = New EO.WebBrowser.WebView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ShowStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.File_StopServer = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Menu_
        '
        Me.Menu_.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.File_, Me.ToolStripMenuItem1})
        Me.Menu_.Location = New System.Drawing.Point(0, 0)
        Me.Menu_.Name = "Menu_"
        Me.Menu_.Size = New System.Drawing.Size(1208, 24)
        Me.Menu_.TabIndex = 0
        Me.Menu_.Text = "MenuStrip1"
        '
        'File_
        '
        Me.File_.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.File_Exit, Me.File_Debug, Me.File_Settings, Me.File_StopServer})
        Me.File_.Name = "File_"
        Me.File_.Size = New System.Drawing.Size(37, 20)
        Me.File_.Text = "File"
        '
        'File_Exit
        '
        Me.File_Exit.Name = "File_Exit"
        Me.File_Exit.Size = New System.Drawing.Size(152, 22)
        Me.File_Exit.Text = "Exit"
        '
        'File_Debug
        '
        Me.File_Debug.Name = "File_Debug"
        Me.File_Debug.Size = New System.Drawing.Size(152, 22)
        Me.File_Debug.Text = "Debug"
        '
        'File_Settings
        '
        Me.File_Settings.Name = "File_Settings"
        Me.File_Settings.Size = New System.Drawing.Size(152, 22)
        Me.File_Settings.Text = "Settings"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(12, 20)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.StatusStrip1)
        Me.GroupBox1.Controls.Add(Me.WebControl1)
        Me.GroupBox1.Controls.Add(Me.Debug)
        Me.GroupBox1.Controls.Add(Me.ToolStrip1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1208, 496)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Debug
        '
        Me.Debug.Location = New System.Drawing.Point(618, 16)
        Me.Debug.Multiline = True
        Me.Debug.Name = "Debug"
        Me.Debug.Size = New System.Drawing.Size(569, 25)
        Me.Debug.TabIndex = 1
        Me.Debug.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_Go})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 16)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1202, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_Go
        '
        Me.btn_Go.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btn_Go.Image = CType(resources.GetObject("btn_Go.Image"), System.Drawing.Image)
        Me.btn_Go.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Go.Name = "btn_Go"
        Me.btn_Go.Size = New System.Drawing.Size(26, 22)
        Me.btn_Go.Text = "Go"
        '
        'BGW
        '
        '
        'WebControl1
        '
        Me.WebControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebControl1.BackColor = System.Drawing.Color.White
        Me.WebControl1.Location = New System.Drawing.Point(3, 44)
        Me.WebControl1.Name = "WebControl1"
        Me.WebControl1.Size = New System.Drawing.Size(1205, 424)
        Me.WebControl1.TabIndex = 2
        Me.WebControl1.Text = "WebControl1"
        Me.WebControl1.WebView = Me.WebView1
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ShowStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(3, 471)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1202, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(48, 17)
        Me.ToolStripStatusLabel1.Text = "Status : "
        '
        'ShowStatus
        '
        Me.ShowStatus.Name = "ShowStatus"
        Me.ShowStatus.Size = New System.Drawing.Size(0, 17)
        '
        'File_StopServer
        '
        Me.File_StopServer.Name = "File_StopServer"
        Me.File_StopServer.Size = New System.Drawing.Size(152, 22)
        Me.File_StopServer.Text = "Stop Server"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1208, 520)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Menu_)
        Me.MainMenuStrip = Me.Menu_
        Me.Name = "Form1"
        Me.Text = "PoGoMap - G.U.I v2"
        Me.Menu_.ResumeLayout(False)
        Me.Menu_.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Menu_ As MenuStrip
    Friend WithEvents File_ As ToolStripMenuItem
    Friend WithEvents File_Exit As ToolStripMenuItem
    Friend WithEvents File_Debug As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btn_Go As ToolStripButton
    Friend WithEvents File_Settings As ToolStripMenuItem
    Friend WithEvents Debug As TextBox
    Friend WithEvents BGW As System.ComponentModel.BackgroundWorker
    Friend WithEvents WebControl1 As EO.WebBrowser.WinForm.WebControl
    Friend WithEvents WebView1 As EO.WebBrowser.WebView
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ShowStatus As ToolStripStatusLabel
    Friend WithEvents File_StopServer As ToolStripMenuItem
End Class
