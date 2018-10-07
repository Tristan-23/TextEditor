<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Editor
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Editor))
        Me.Menu = New System.Windows.Forms.MenuStrip()
        Me.DateiMenuBtn = New System.Windows.Forms.ToolStripMenuItem()
        Me.NeuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpeichernToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÖffnenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThemesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DarkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LightToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SchließenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BearbeitenMenuBtn = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextgrößeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SchriftartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FenstergrößeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DefaultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Klein300x150ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BildschirmgrößeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Content = New System.Windows.Forms.Panel()
        Me.TextBox = New System.Windows.Forms.TextBox()
        Me.LoadTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.KeyTimer = New System.Windows.Forms.Timer(Me.components)
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VersionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VersionItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TristanZiegerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Icons8IconToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu.SuspendLayout()
        Me.Content.SuspendLayout()
        Me.SuspendLayout()
        '
        'Menu
        '
        Me.Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiMenuBtn, Me.BearbeitenMenuBtn, Me.InfoToolStripMenuItem})
        Me.Menu.Location = New System.Drawing.Point(0, 0)
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(784, 24)
        Me.Menu.TabIndex = 0
        Me.Menu.Text = "MenuStrip1"
        '
        'DateiMenuBtn
        '
        Me.DateiMenuBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NeuToolStripMenuItem, Me.SpeichernToolStripMenuItem, Me.ÖffnenToolStripMenuItem, Me.ThemesToolStripMenuItem, Me.SchließenToolStripMenuItem})
        Me.DateiMenuBtn.Name = "DateiMenuBtn"
        Me.DateiMenuBtn.Size = New System.Drawing.Size(46, 20)
        Me.DateiMenuBtn.Text = "Datei"
        '
        'NeuToolStripMenuItem
        '
        Me.NeuToolStripMenuItem.Name = "NeuToolStripMenuItem"
        Me.NeuToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.NeuToolStripMenuItem.Text = "Neu"
        '
        'SpeichernToolStripMenuItem
        '
        Me.SpeichernToolStripMenuItem.Name = "SpeichernToolStripMenuItem"
        Me.SpeichernToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.SpeichernToolStripMenuItem.Text = "Speichern"
        '
        'ÖffnenToolStripMenuItem
        '
        Me.ÖffnenToolStripMenuItem.Name = "ÖffnenToolStripMenuItem"
        Me.ÖffnenToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.ÖffnenToolStripMenuItem.Text = "Öffnen"
        '
        'ThemesToolStripMenuItem
        '
        Me.ThemesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DarkToolStripMenuItem, Me.LightToolStripMenuItem})
        Me.ThemesToolStripMenuItem.Name = "ThemesToolStripMenuItem"
        Me.ThemesToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.ThemesToolStripMenuItem.Text = "Themes"
        '
        'DarkToolStripMenuItem
        '
        Me.DarkToolStripMenuItem.Name = "DarkToolStripMenuItem"
        Me.DarkToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.DarkToolStripMenuItem.Text = "Dunkel"
        '
        'LightToolStripMenuItem
        '
        Me.LightToolStripMenuItem.Name = "LightToolStripMenuItem"
        Me.LightToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.LightToolStripMenuItem.Text = "Hell"
        '
        'SchließenToolStripMenuItem
        '
        Me.SchließenToolStripMenuItem.Name = "SchließenToolStripMenuItem"
        Me.SchließenToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.SchließenToolStripMenuItem.Text = "Schließen"
        '
        'BearbeitenMenuBtn
        '
        Me.BearbeitenMenuBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TextgrößeToolStripMenuItem, Me.SchriftartToolStripMenuItem, Me.FenstergrößeToolStripMenuItem})
        Me.BearbeitenMenuBtn.Name = "BearbeitenMenuBtn"
        Me.BearbeitenMenuBtn.Size = New System.Drawing.Size(75, 20)
        Me.BearbeitenMenuBtn.Text = "Bearbeiten"
        '
        'TextgrößeToolStripMenuItem
        '
        Me.TextgrößeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5, Me.ToolStripMenuItem6, Me.ToolStripMenuItem7, Me.ToolStripMenuItem8, Me.ToolStripMenuItem9, Me.ToolStripMenuItem10})
        Me.TextgrößeToolStripMenuItem.Name = "TextgrößeToolStripMenuItem"
        Me.TextgrößeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TextgrößeToolStripMenuItem.Text = "Schriftgröße"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(86, 22)
        Me.ToolStripMenuItem2.Text = "8"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(86, 22)
        Me.ToolStripMenuItem3.Text = "9"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(86, 22)
        Me.ToolStripMenuItem4.Text = "10"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(86, 22)
        Me.ToolStripMenuItem5.Text = "12"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(86, 22)
        Me.ToolStripMenuItem6.Text = "14"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(86, 22)
        Me.ToolStripMenuItem7.Text = "18"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(86, 22)
        Me.ToolStripMenuItem8.Text = "20"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(86, 22)
        Me.ToolStripMenuItem9.Text = "24"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(86, 22)
        Me.ToolStripMenuItem10.Text = "28"
        '
        'SchriftartToolStripMenuItem
        '
        Me.SchriftartToolStripMenuItem.Name = "SchriftartToolStripMenuItem"
        Me.SchriftartToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SchriftartToolStripMenuItem.Text = "Schriftart"
        '
        'FenstergrößeToolStripMenuItem
        '
        Me.FenstergrößeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DefaultToolStripMenuItem, Me.Klein300x150ToolStripMenuItem, Me.BildschirmgrößeToolStripMenuItem})
        Me.FenstergrößeToolStripMenuItem.Name = "FenstergrößeToolStripMenuItem"
        Me.FenstergrößeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FenstergrößeToolStripMenuItem.Text = "Fenstergröße"
        '
        'DefaultToolStripMenuItem
        '
        Me.DefaultToolStripMenuItem.Name = "DefaultToolStripMenuItem"
        Me.DefaultToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.DefaultToolStripMenuItem.Text = "Default"
        '
        'Klein300x150ToolStripMenuItem
        '
        Me.Klein300x150ToolStripMenuItem.Name = "Klein300x150ToolStripMenuItem"
        Me.Klein300x150ToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.Klein300x150ToolStripMenuItem.Text = "Klein (300x150)"
        '
        'BildschirmgrößeToolStripMenuItem
        '
        Me.BildschirmgrößeToolStripMenuItem.Name = "BildschirmgrößeToolStripMenuItem"
        Me.BildschirmgrößeToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.BildschirmgrößeToolStripMenuItem.Text = "Bildschirmgröße"
        '
        'Content
        '
        Me.Content.BackColor = System.Drawing.SystemColors.Control
        Me.Content.Controls.Add(Me.TextBox)
        Me.Content.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Content.Location = New System.Drawing.Point(0, 24)
        Me.Content.Name = "Content"
        Me.Content.Size = New System.Drawing.Size(784, 389)
        Me.Content.TabIndex = 1
        '
        'TextBox
        '
        Me.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox.Location = New System.Drawing.Point(0, 0)
        Me.TextBox.Multiline = True
        Me.TextBox.Name = "TextBox"
        Me.TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox.Size = New System.Drawing.Size(784, 389)
        Me.TextBox.TabIndex = 1
        '
        'LoadTimer
        '
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'SaveFileDialog1
        '
        '
        'KeyTimer
        '
        Me.KeyTimer.Interval = 1
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VersionToolStripMenuItem, Me.AutorToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.InfoToolStripMenuItem.Text = "Info"
        '
        'VersionToolStripMenuItem
        '
        Me.VersionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VersionItem})
        Me.VersionToolStripMenuItem.Name = "VersionToolStripMenuItem"
        Me.VersionToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.VersionToolStripMenuItem.Text = "Version"
        '
        'VersionItem
        '
        Me.VersionItem.Name = "VersionItem"
        Me.VersionItem.Size = New System.Drawing.Size(180, 22)
        Me.VersionItem.Text = "1.0.3"
        '
        'AutorToolStripMenuItem
        '
        Me.AutorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TristanZiegerToolStripMenuItem})
        Me.AutorToolStripMenuItem.Name = "AutorToolStripMenuItem"
        Me.AutorToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.AutorToolStripMenuItem.Text = "Developed and createt by"
        '
        'TristanZiegerToolStripMenuItem
        '
        Me.TristanZiegerToolStripMenuItem.Name = "TristanZiegerToolStripMenuItem"
        Me.TristanZiegerToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TristanZiegerToolStripMenuItem.Text = "Tristan Zieger"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AsToolStripMenuItem, Me.Icons8IconToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AsToolStripMenuItem
        '
        Me.AsToolStripMenuItem.Name = "AsToolStripMenuItem"
        Me.AsToolStripMenuItem.Size = New System.Drawing.Size(260, 22)
        Me.AsToolStripMenuItem.Text = "Stack Overflow (Menu Strip Border)"
        '
        'Icons8IconToolStripMenuItem
        '
        Me.Icons8IconToolStripMenuItem.Name = "Icons8IconToolStripMenuItem"
        Me.Icons8IconToolStripMenuItem.Size = New System.Drawing.Size(260, 22)
        Me.Icons8IconToolStripMenuItem.Text = "Icons8 (Icon)"
        '
        'Editor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 413)
        Me.Controls.Add(Me.Content)
        Me.Controls.Add(Me.Menu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.Menu
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(300, 150)
        Me.Name = "Editor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editor"
        Me.Menu.ResumeLayout(False)
        Me.Menu.PerformLayout()
        Me.Content.ResumeLayout(False)
        Me.Content.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Menu As MenuStrip
    Friend WithEvents DateiMenuBtn As ToolStripMenuItem
    Friend WithEvents ThemesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DarkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LightToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Content As Panel
    Friend WithEvents LoadTimer As Timer
    Friend WithEvents ÖffnenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SpeichernToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SchließenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BearbeitenMenuBtn As ToolStripMenuItem
    Friend WithEvents TextgrößeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents TextBox As TextBox
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As ToolStripMenuItem
    Friend WithEvents SchriftartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NeuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeyTimer As Timer
    Friend WithEvents FenstergrößeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DefaultToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Klein300x150ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BildschirmgrößeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VersionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VersionItem As ToolStripMenuItem
    Friend WithEvents AutorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TristanZiegerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Icons8IconToolStripMenuItem As ToolStripMenuItem
End Class
