Imports TextEditor.ThemeLoader
Imports System.IO
Imports System.ComponentModel

Public Class Editor


#Region "VARIABLES"
    Public Shared VERSION As String = "1.0.3"
#End Region


#Region "THEME LOADER"




    Private Sub LoadTimer_Tick(sender As Object, e As EventArgs) Handles LoadTimer.Tick
        Me.Show()
        LoadTimer.Stop()
    End Sub


    Private Sub DarkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Dunkel.Click
        My.Settings.Theme = 0
        My.Settings.Save()
        My.Settings.Reload()
        ThemeLoader.LoadTheme(THEMES.DARK, False)
    End Sub

    Private Sub LightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Hell.Click
        My.Settings.Theme = 1
        My.Settings.Save()
        My.Settings.Reload()
        LoadTheme(THEMES.LIGHT, False)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim startTheme As THEMES

        If My.Settings.Theme = 0 Then
            startTheme = THEMES.DARK
        ElseIf My.Settings.Theme = 1 Then
            startTheme = THEMES.LIGHT
        End If

        If Not My.Settings.Sprache = Nothing Then
            setLanguage(My.Settings.Sprache)
        Else
            setLanguage("Deutsch")
        End If

        LoadTheme(startTheme, True)

        VersionItem.Text = VERSION

    End Sub








#End Region
#Region "SAVE AND OPEN"


    Private Sub NeuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Neu.Click
        If String.IsNullOrEmpty(TextBox.Text) Then
            TextBox.Text = ""
            Me.Text = "Editor"
        Else
            Dim msgText As String = ""
            Dim msgTitle As String = ""
            If My.Settings.Sprache = "Deutsch" Then
                msgText = "Willst du die jetzige Datei speichern?"
                msgTitle = "Speichern?"
            ElseIf My.Settings.Sprache = "English" Then
                msgText = "Do you want to save your current text?"
                msgTitle = "Save?"
            End If
            Select Case MessageBox.Show(msgText, msgTitle, MessageBoxButtons.YesNo)
                Case Windows.Forms.DialogResult.Yes
                    SaveFileDialog1.Filter = "Textdatei|*.txt"
                    SaveFileDialog1.ShowDialog()
                Case Windows.Forms.DialogResult.No
                    TextBox.Text = ""
                    Me.Text = "Editor"
            End Select
        End If
    End Sub


    Private Sub ÖffnenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Öffnen.Click
        OpenFileDialog1.Filter = "Textdatei|*.txt"
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub SchließenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Schließen.Click
        Me.Close()
    End Sub

    Private Sub SpeichernToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Speichern.Click
        If String.IsNullOrEmpty(TextBox.Text) Then

        Else
            SaveFileDialog1.Filter = "Textdatei|*.txt"
            SaveFileDialog1.ShowDialog()
        End If
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, TextBox.Text, False)
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        TextBox.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
        Me.Text = System.IO.Path.GetFileName(OpenFileDialog1.FileName)
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            If String.IsNullOrEmpty(TextBox.Text) Then

            Else
                SaveFileDialog1.Filter = "Textdatei|*.txt"
                SaveFileDialog1.ShowDialog()
            End If
        End If
    End Sub


#End Region
#Region "FONT SIZE"





    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        TextBox.Font = New Font(TextBox.Font.FontFamily, 8)
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        TextBox.Font = New Font(TextBox.Font.FontFamily, 9)
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        TextBox.Font = New Font(TextBox.Font.FontFamily, 10)
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        TextBox.Font = New Font(TextBox.Font.FontFamily, 12)
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        TextBox.Font = New Font(TextBox.Font.FontFamily, 14)
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        TextBox.Font = New Font(TextBox.Font.FontFamily, 18)
    End Sub

    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click
        TextBox.Font = New Font(TextBox.Font.FontFamily, 20)
    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem9.Click
        TextBox.Font = New Font(TextBox.Font.FontFamily, 24)
    End Sub

    Private Sub ToolStripMenuItem10_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem10.Click
        TextBox.Font = New Font(TextBox.Font.FontFamily, 28)
    End Sub






#End Region
#Region "FONT"


    Private Sub SchriftartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Schriftart.Click
        FontDialog1.ShowDialog()
        TextBox.Font = FontDialog1.Font
    End Sub


#End Region
#Region "DESIGN STUFF"

    Private Sub Form1_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        TextBox.Size = New Size(Me.Size.Width - 15, Me.Size.Height - 60)
    End Sub

    Private Sub DefaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefaultItem.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
        Me.Size = New Size(800, 452)
    End Sub

    Private Sub Klein300x150ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Klein.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
        Me.Size = New Size(300, 150)
    End Sub

    Private Sub BildschirmgrößeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Bildschirmgröße.Click
        If Not Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub AsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsToolStripMenuItem.Click
        Process.Start("https://stackoverflow.com/questions/40710553/vb-change-color-border-menustrip")
    End Sub

    Private Sub Icons8IconToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Icons8IconToolStripMenuItem.Click
        Process.Start("https://icons8.de/free-icons/text_editor_icons")
    End Sub

#End Region
#Region "Languages"


    Private Sub setLanguage(language As String)
        If language.ToString = "Deutsch" Then
            Datei.Text = "Datei"
            Neu.Text = "Neu"
            Speichern.Text = "Speichern"
            Öffnen.Text = "Öffnen"
            ThemesItem.Text = "Themen"
            Dunkel.Text = "Dunkel"
            Hell.Text = "Hell"
            Schließen.Text = "Schließen"

            Bearbeiten.Text = "Bearbeiten"
            Schriftgröße.Text = "Schriftgröße"
            Schriftart.Text = "Schriftart"
            Fenstergröße.Text = "Fenstergröße"
            DefaultItem.Text = "Normal"
            Klein.Text = "Klein"
            Bildschirmgröße.Text = "Bildschirmgröße"

            Sprache.Text = "Sprache"
            Sprachen.Text = "Sprachen"

            My.Settings.Sprache = language
            My.Settings.Save()
            My.Settings.Reload()
        End If
        If language.ToString = "English" Then
            Datei.Text = "File"
            Neu.Text = "New"
            Speichern.Text = "Save"
            Öffnen.Text = "Open"
            ThemesItem.Text = "Themes"
            Dunkel.Text = "Dark"
            Hell.Text = "Light"
            Schließen.Text = "Close"

            Bearbeiten.Text = "Edit"
            Schriftgröße.Text = "Font Size"
            Schriftart.Text = "Font"
            Fenstergröße.Text = "Window Size"
            DefaultItem.Text = "Default"
            Klein.Text = "Small"
            Bildschirmgröße.Text = "Screen Size"

            Sprache.Text = "Language"
            Sprachen.Text = "Languages"

            My.Settings.Sprache = language
            My.Settings.Save()
            My.Settings.Reload()
        End If
    End Sub



    Private Sub DeutschToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeutschToolStripMenuItem.Click
        setLanguage("Deutsch")
    End Sub

    Private Sub EnglishToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnglishToolStripMenuItem.Click
        setLanguage("English")
    End Sub




#End Region












End Class
