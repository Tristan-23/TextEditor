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
        Me.Datei = New System.Windows.Forms.ToolStripMenuItem()
        Me.Neu = New System.Windows.Forms.ToolStripMenuItem()
        Me.Speichern = New System.Windows.Forms.ToolStripMenuItem()
        Me.Öffnen = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThemesItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Dunkel = New System.Windows.Forms.ToolStripMenuItem()
        Me.Hell = New System.Windows.Forms.ToolStripMenuItem()
        Me.Schließen = New System.Windows.Forms.ToolStripMenuItem()
        Me.Bearbeiten = New System.Windows.Forms.ToolStripMenuItem()
        Me.Schriftgröße = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Schriftart = New System.Windows.Forms.ToolStripMenuItem()
        Me.Fenstergröße = New System.Windows.Forms.ToolStripMenuItem()
        Me.DefaultItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Klein = New System.Windows.Forms.ToolStripMenuItem()
        Me.Bildschirmgröße = New System.Windows.Forms.ToolStripMenuItem()
        Me.Info = New System.Windows.Forms.ToolStripMenuItem()
        Me.VersionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VersionItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TristanZiegerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Icons8IconToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Content = New System.Windows.Forms.Panel()
        Me.TextBox = New System.Windows.Forms.TextBox()
        Me.LoadTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.KeyTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Sprache = New System.Windows.Forms.ToolStripMenuItem()
        Me.Sprachen = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeutschToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnglishToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu.SuspendLayout()
        Me.Content.SuspendLayout()
        Me.SuspendLayout()
        '
        'Menu
        '
        Me.Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Datei, Me.Bearbeiten, Me.Sprache, Me.Info})
        Me.Menu.Location = New System.Drawing.Point(0, 0)
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(784, 24)
        Me.Menu.TabIndex = 0
        Me.Menu.Text = "MenuStrip1"
        '
        'Datei
        '
        Me.Datei.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Neu, Me.Speichern, Me.Öffnen, Me.ThemesItem, Me.Schließen})
        Me.Datei.Name = "Datei"
        Me.Datei.Size = New System.Drawing.Size(46, 20)
        Me.Datei.Text = "Datei"
        '
        'Neu
        '
        Me.Neu.Name = "Neu"
        Me.Neu.Size = New System.Drawing.Size(180, 22)
        Me.Neu.Text = "Neu"
        '
        'Speichern
        '
        Me.Speichern.Name = "Speichern"
        Me.Speichern.Size = New System.Drawing.Size(180, 22)
        Me.Speichern.Text = "Speichern"
        '
        'Öffnen
        '
        Me.Öffnen.Name = "Öffnen"
        Me.Öffnen.Size = New System.Drawing.Size(180, 22)
        Me.Öffnen.Text = "Öffnen"
        '
        'ThemesItem
        '
        Me.ThemesItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Dunkel, Me.Hell})
        Me.ThemesItem.Name = "ThemesItem"
        Me.ThemesItem.Size = New System.Drawing.Size(180, 22)
        Me.ThemesItem.Text = "Themes"
        '
        'Dunkel
        '
        Me.Dunkel.Name = "Dunkel"
        Me.Dunkel.Size = New System.Drawing.Size(180, 22)
        Me.Dunkel.Text = "Dunkel"
        '
        'Hell
        '
        Me.Hell.Name = "Hell"
        Me.Hell.Size = New System.Drawing.Size(180, 22)
        Me.Hell.Text = "Hell"
        '
        'Schließen
        '
        Me.Schließen.Name = "Schließen"
        Me.Schließen.Size = New System.Drawing.Size(180, 22)
        Me.Schließen.Text = "Schließen"
        '
        'Bearbeiten
        '
        Me.Bearbeiten.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Schriftgröße, Me.Schriftart, Me.Fenstergröße})
        Me.Bearbeiten.Name = "Bearbeiten"
        Me.Bearbeiten.Size = New System.Drawing.Size(75, 20)
        Me.Bearbeiten.Text = "Bearbeiten"
        '
        'Schriftgröße
        '
        Me.Schriftgröße.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5, Me.ToolStripMenuItem6, Me.ToolStripMenuItem7, Me.ToolStripMenuItem8, Me.ToolStripMenuItem9, Me.ToolStripMenuItem10})
        Me.Schriftgröße.Name = "Schriftgröße"
        Me.Schriftgröße.Size = New System.Drawing.Size(180, 22)
        Me.Schriftgröße.Text = "Schriftgröße"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem2.Text = "8"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem3.Text = "9"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem4.Text = "10"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem5.Text = "12"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem6.Text = "14"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem7.Text = "18"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem8.Text = "20"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem9.Text = "24"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem10.Text = "28"
        '
        'Schriftart
        '
        Me.Schriftart.Name = "Schriftart"
        Me.Schriftart.Size = New System.Drawing.Size(180, 22)
        Me.Schriftart.Text = "Schriftart"
        '
        'Fenstergröße
        '
        Me.Fenstergröße.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DefaultItem, Me.Klein, Me.Bildschirmgröße})
        Me.Fenstergröße.Name = "Fenstergröße"
        Me.Fenstergröße.Size = New System.Drawing.Size(180, 22)
        Me.Fenstergröße.Text = "Fenstergröße"
        '
        'DefaultItem
        '
        Me.DefaultItem.Name = "DefaultItem"
        Me.DefaultItem.Size = New System.Drawing.Size(180, 22)
        Me.DefaultItem.Text = "Default"
        '
        'Klein
        '
        Me.Klein.Name = "Klein"
        Me.Klein.Size = New System.Drawing.Size(180, 22)
        Me.Klein.Text = "Klein (300x150)"
        '
        'Bildschirmgröße
        '
        Me.Bildschirmgröße.Name = "Bildschirmgröße"
        Me.Bildschirmgröße.Size = New System.Drawing.Size(180, 22)
        Me.Bildschirmgröße.Text = "Bildschirmgröße"
        '
        'Info
        '
        Me.Info.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VersionToolStripMenuItem, Me.AutorToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.Info.Name = "Info"
        Me.Info.Size = New System.Drawing.Size(40, 20)
        Me.Info.Text = "Info"
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
        'Sprache
        '
        Me.Sprache.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Sprachen})
        Me.Sprache.Name = "Sprache"
        Me.Sprache.Size = New System.Drawing.Size(61, 20)
        Me.Sprache.Text = "Sprache"
        '
        'Sprachen
        '
        Me.Sprachen.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeutschToolStripMenuItem, Me.EnglishToolStripMenuItem})
        Me.Sprachen.Name = "Sprachen"
        Me.Sprachen.Size = New System.Drawing.Size(180, 22)
        Me.Sprachen.Text = "Sprachen"
        '
        'DeutschToolStripMenuItem
        '
        Me.DeutschToolStripMenuItem.Name = "DeutschToolStripMenuItem"
        Me.DeutschToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DeutschToolStripMenuItem.Text = "Deutsch"
        '
        'EnglishToolStripMenuItem
        '
        Me.EnglishToolStripMenuItem.Name = "EnglishToolStripMenuItem"
        Me.EnglishToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EnglishToolStripMenuItem.Text = "English"
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
    Friend WithEvents Datei As ToolStripMenuItem
    Friend WithEvents ThemesItem As ToolStripMenuItem
    Friend WithEvents Dunkel As ToolStripMenuItem
    Friend WithEvents Hell As ToolStripMenuItem
    Friend WithEvents Content As Panel
    Friend WithEvents LoadTimer As Timer
    Friend WithEvents Öffnen As ToolStripMenuItem
    Friend WithEvents Speichern As ToolStripMenuItem
    Friend WithEvents Schließen As ToolStripMenuItem
    Friend WithEvents Bearbeiten As ToolStripMenuItem
    Friend WithEvents Schriftgröße As ToolStripMenuItem
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
    Friend WithEvents Schriftart As ToolStripMenuItem
    Friend WithEvents Neu As ToolStripMenuItem
    Friend WithEvents KeyTimer As Timer
    Friend WithEvents Fenstergröße As ToolStripMenuItem
    Friend WithEvents DefaultItem As ToolStripMenuItem
    Friend WithEvents Klein As ToolStripMenuItem
    Friend WithEvents Bildschirmgröße As ToolStripMenuItem
    Friend WithEvents Info As ToolStripMenuItem
    Friend WithEvents VersionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VersionItem As ToolStripMenuItem
    Friend WithEvents AutorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TristanZiegerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Icons8IconToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Sprache As ToolStripMenuItem
    Friend WithEvents Sprachen As ToolStripMenuItem
    Friend WithEvents DeutschToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnglishToolStripMenuItem As ToolStripMenuItem
End Class
