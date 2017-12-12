<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.lbOutput = New System.Windows.Forms.ListBox()
        Me.tbxInput = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurpleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WhiteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlueToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurpleToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GreenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlackToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WhiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccentColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlueToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurpleToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GreenToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlackToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrayToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.WhiteToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BasicCommandsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoogleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YoutubeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaunchFavoriteWebsitesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreditsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbOutput
        '
        Me.lbOutput.BackColor = System.Drawing.SystemColors.Window
        Me.lbOutput.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbOutput.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lbOutput.FormattingEnabled = True
        Me.lbOutput.Items.AddRange(New Object() {"What can I help you with?", "Type 'Help' for some useful commands"})
        Me.lbOutput.Location = New System.Drawing.Point(13, 26)
        Me.lbOutput.Name = "lbOutput"
        Me.lbOutput.Size = New System.Drawing.Size(581, 329)
        Me.lbOutput.TabIndex = 0
        Me.lbOutput.TabStop = False
        '
        'tbxInput
        '
        Me.tbxInput.Location = New System.Drawing.Point(12, 364)
        Me.tbxInput.Name = "tbxInput"
        Me.tbxInput.Size = New System.Drawing.Size(582, 20)
        Me.tbxInput.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.BasicCommandsToolStripMenuItem, Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(606, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FontToolStripMenuItem, Me.FontColorToolStripMenuItem, Me.BackgroundColorToolStripMenuItem, Me.AccentColorToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.FileToolStripMenuItem.Text = "Options"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.FontToolStripMenuItem.Text = "Font"
        '
        'FontColorToolStripMenuItem
        '
        Me.FontColorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RedToolStripMenuItem, Me.BlueToolStripMenuItem, Me.PurpleToolStripMenuItem, Me.GreenToolStripMenuItem, Me.BlackToolStripMenuItem, Me.WhiteToolStripMenuItem1})
        Me.FontColorToolStripMenuItem.Name = "FontColorToolStripMenuItem"
        Me.FontColorToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.FontColorToolStripMenuItem.Text = "Font Color"
        '
        'RedToolStripMenuItem
        '
        Me.RedToolStripMenuItem.Name = "RedToolStripMenuItem"
        Me.RedToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.RedToolStripMenuItem.Text = "Red"
        '
        'BlueToolStripMenuItem
        '
        Me.BlueToolStripMenuItem.Name = "BlueToolStripMenuItem"
        Me.BlueToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.BlueToolStripMenuItem.Text = "Blue"
        '
        'PurpleToolStripMenuItem
        '
        Me.PurpleToolStripMenuItem.Name = "PurpleToolStripMenuItem"
        Me.PurpleToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.PurpleToolStripMenuItem.Text = "Purple"
        '
        'GreenToolStripMenuItem
        '
        Me.GreenToolStripMenuItem.Name = "GreenToolStripMenuItem"
        Me.GreenToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.GreenToolStripMenuItem.Text = "Green"
        '
        'BlackToolStripMenuItem
        '
        Me.BlackToolStripMenuItem.Name = "BlackToolStripMenuItem"
        Me.BlackToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.BlackToolStripMenuItem.Text = "Black"
        '
        'WhiteToolStripMenuItem1
        '
        Me.WhiteToolStripMenuItem1.Name = "WhiteToolStripMenuItem1"
        Me.WhiteToolStripMenuItem1.Size = New System.Drawing.Size(108, 22)
        Me.WhiteToolStripMenuItem1.Text = "White"
        '
        'BackgroundColorToolStripMenuItem
        '
        Me.BackgroundColorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BlueToolStripMenuItem1, Me.RedToolStripMenuItem1, Me.PurpleToolStripMenuItem1, Me.GreenToolStripMenuItem1, Me.BlackToolStripMenuItem1, Me.GrayToolStripMenuItem, Me.WhiteToolStripMenuItem})
        Me.BackgroundColorToolStripMenuItem.Name = "BackgroundColorToolStripMenuItem"
        Me.BackgroundColorToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.BackgroundColorToolStripMenuItem.Text = "Background Color"
        '
        'BlueToolStripMenuItem1
        '
        Me.BlueToolStripMenuItem1.Name = "BlueToolStripMenuItem1"
        Me.BlueToolStripMenuItem1.Size = New System.Drawing.Size(108, 22)
        Me.BlueToolStripMenuItem1.Text = "Red"
        '
        'RedToolStripMenuItem1
        '
        Me.RedToolStripMenuItem1.Name = "RedToolStripMenuItem1"
        Me.RedToolStripMenuItem1.Size = New System.Drawing.Size(108, 22)
        Me.RedToolStripMenuItem1.Text = "Blue"
        '
        'PurpleToolStripMenuItem1
        '
        Me.PurpleToolStripMenuItem1.Name = "PurpleToolStripMenuItem1"
        Me.PurpleToolStripMenuItem1.Size = New System.Drawing.Size(108, 22)
        Me.PurpleToolStripMenuItem1.Text = "Purple"
        '
        'GreenToolStripMenuItem1
        '
        Me.GreenToolStripMenuItem1.Name = "GreenToolStripMenuItem1"
        Me.GreenToolStripMenuItem1.Size = New System.Drawing.Size(108, 22)
        Me.GreenToolStripMenuItem1.Text = "Green"
        '
        'BlackToolStripMenuItem1
        '
        Me.BlackToolStripMenuItem1.Name = "BlackToolStripMenuItem1"
        Me.BlackToolStripMenuItem1.Size = New System.Drawing.Size(108, 22)
        Me.BlackToolStripMenuItem1.Text = "Black"
        '
        'GrayToolStripMenuItem
        '
        Me.GrayToolStripMenuItem.Name = "GrayToolStripMenuItem"
        Me.GrayToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.GrayToolStripMenuItem.Text = "Gray"
        '
        'WhiteToolStripMenuItem
        '
        Me.WhiteToolStripMenuItem.Name = "WhiteToolStripMenuItem"
        Me.WhiteToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.WhiteToolStripMenuItem.Text = "White"
        '
        'AccentColorToolStripMenuItem
        '
        Me.AccentColorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RedToolStripMenuItem2, Me.BlueToolStripMenuItem2, Me.PurpleToolStripMenuItem2, Me.GreenToolStripMenuItem2, Me.BlackToolStripMenuItem2, Me.GrayToolStripMenuItem1, Me.WhiteToolStripMenuItem2})
        Me.AccentColorToolStripMenuItem.Name = "AccentColorToolStripMenuItem"
        Me.AccentColorToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.AccentColorToolStripMenuItem.Text = "Accent Color"
        '
        'RedToolStripMenuItem2
        '
        Me.RedToolStripMenuItem2.Name = "RedToolStripMenuItem2"
        Me.RedToolStripMenuItem2.Size = New System.Drawing.Size(108, 22)
        Me.RedToolStripMenuItem2.Text = "Red"
        '
        'BlueToolStripMenuItem2
        '
        Me.BlueToolStripMenuItem2.Name = "BlueToolStripMenuItem2"
        Me.BlueToolStripMenuItem2.Size = New System.Drawing.Size(108, 22)
        Me.BlueToolStripMenuItem2.Text = "Blue"
        '
        'PurpleToolStripMenuItem2
        '
        Me.PurpleToolStripMenuItem2.Name = "PurpleToolStripMenuItem2"
        Me.PurpleToolStripMenuItem2.Size = New System.Drawing.Size(108, 22)
        Me.PurpleToolStripMenuItem2.Text = "Purple"
        '
        'GreenToolStripMenuItem2
        '
        Me.GreenToolStripMenuItem2.Name = "GreenToolStripMenuItem2"
        Me.GreenToolStripMenuItem2.Size = New System.Drawing.Size(108, 22)
        Me.GreenToolStripMenuItem2.Text = "Green"
        '
        'BlackToolStripMenuItem2
        '
        Me.BlackToolStripMenuItem2.Name = "BlackToolStripMenuItem2"
        Me.BlackToolStripMenuItem2.Size = New System.Drawing.Size(108, 22)
        Me.BlackToolStripMenuItem2.Text = "Black"
        '
        'GrayToolStripMenuItem1
        '
        Me.GrayToolStripMenuItem1.Name = "GrayToolStripMenuItem1"
        Me.GrayToolStripMenuItem1.Size = New System.Drawing.Size(108, 22)
        Me.GrayToolStripMenuItem1.Text = "Gray"
        '
        'WhiteToolStripMenuItem2
        '
        Me.WhiteToolStripMenuItem2.Name = "WhiteToolStripMenuItem2"
        Me.WhiteToolStripMenuItem2.Size = New System.Drawing.Size(108, 22)
        Me.WhiteToolStripMenuItem2.Text = "White"
        '
        'BasicCommandsToolStripMenuItem
        '
        Me.BasicCommandsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GoogleToolStripMenuItem, Me.YoutubeToolStripMenuItem, Me.LaunchFavoriteWebsitesToolStripMenuItem})
        Me.BasicCommandsToolStripMenuItem.Name = "BasicCommandsToolStripMenuItem"
        Me.BasicCommandsToolStripMenuItem.Size = New System.Drawing.Size(169, 20)
        Me.BasicCommandsToolStripMenuItem.Text = "Frequently Used Commands"
        '
        'GoogleToolStripMenuItem
        '
        Me.GoogleToolStripMenuItem.Name = "GoogleToolStripMenuItem"
        Me.GoogleToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.GoogleToolStripMenuItem.Text = "Google"
        '
        'YoutubeToolStripMenuItem
        '
        Me.YoutubeToolStripMenuItem.Name = "YoutubeToolStripMenuItem"
        Me.YoutubeToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.YoutubeToolStripMenuItem.Text = "Youtube"
        '
        'LaunchFavoriteWebsitesToolStripMenuItem
        '
        Me.LaunchFavoriteWebsitesToolStripMenuItem.Name = "LaunchFavoriteWebsitesToolStripMenuItem"
        Me.LaunchFavoriteWebsitesToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.LaunchFavoriteWebsitesToolStripMenuItem.Text = "Launch Favorite Websites"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem, Me.CreditsToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'CreditsToolStripMenuItem
        '
        Me.CreditsToolStripMenuItem.Name = "CreditsToolStripMenuItem"
        Me.CreditsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CreditsToolStripMenuItem.Text = "Credits"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(606, 396)
        Me.Controls.Add(Me.tbxInput)
        Me.Controls.Add(Me.lbOutput)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "AIDA - <Redacted>'s Digital Assistant"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbOutput As ListBox
    Friend WithEvents tbxInput As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackgroundColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreditsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents BasicCommandsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GoogleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YoutubeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BlueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PurpleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GreenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BlackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WhiteToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents BlueToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RedToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PurpleToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GreenToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents BlackToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GrayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WhiteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccentColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents BlueToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents PurpleToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents GreenToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents BlackToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents GrayToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents WhiteToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents LaunchFavoriteWebsitesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
End Class
