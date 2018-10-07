Imports TextEditor.Editor

Public Class ThemeLoader



#Region "THEME COLOR VARIABLES"
    Public Shared darkLightCol As Color = Color.FromArgb(54, 57, 61)
    Public Shared darkCol As Color = Color.FromArgb(61, 64, 68)
    Public Shared darkMenuCol As Color = Color.FromArgb(39, 42, 45)
    Public Shared darkMenuTextCol As Color = Color.FromArgb(255, 255, 255)

    Public Shared lightDarkMenuCol As Color = Color.White
    Public Shared lightCol As Color = Color.FromArgb(227, 229, 232)
    Public Shared lightMenuCol As Color = Color.FromArgb(127, 130, 135)
    Public Shared lightMenuFileCol As Color = Color.Black
    Public Shared lightMenuTextCol As Color = Color.White
#End Region
#Region "THEME LOADER"
    Public Enum THEMES
        DARK
        LIGHT
    End Enum

    Public Shared Sub LoadTheme(theme As THEMES, startForm As Boolean)

        If startForm = False Then
            Editor.Hide()
            Editor.LoadTimer.Start()
        End If

        If theme = THEMES.DARK Then
            darkTheme()
        End If

        If theme = THEMES.LIGHT Then
            lightTheme()
        End If


    End Sub
#End Region
#Region "THEMES"
    Private Shared Sub darkTheme()
        Editor.TextBox.BackColor = darkLightCol
        Editor.TextBox.ForeColor = darkMenuTextCol
        Editor.Menu.BackColor = darkMenuCol
        Editor.Content.BackColor = darkLightCol
        Editor.DateiMenuBtn.ForeColor = darkMenuTextCol
        Editor.DateiMenuBtn.BackColor = darkMenuCol
        Editor.BearbeitenMenuBtn.ForeColor = darkMenuTextCol

        For Each menuItem As ToolStripMenuItem In Editor.Menu.Items
            menuItem.ForeColor = Color.White
            For Each dropDownItem As ToolStripMenuItem In menuItem.DropDownItems
                dropDownItem.ForeColor = Color.White
                For Each lolCat As ToolStripMenuItem In dropDownItem.DropDownItems
                    lolCat.ForeColor = Color.White
                Next
            Next
        Next

        Dim t As CustomMenuBorderDark = New CustomMenuBorderDark
        Editor.Menu.Renderer = New ToolStripProfessionalRenderer(t)

    End Sub

    Private Shared Sub lightTheme()
        Editor.Content.BackColor = lightDarkMenuCol
        Editor.Menu.BackColor = lightMenuCol
        Editor.TextBox.BackColor = lightDarkMenuCol
        Editor.TextBox.ForeColor = lightMenuFileCol
        Editor.DateiMenuBtn.ForeColor = lightMenuTextCol
        Editor.DateiMenuBtn.BackColor = lightMenuCol
        Editor.BearbeitenMenuBtn.ForeColor = lightMenuFileCol

        For Each menuItem As ToolStripMenuItem In Editor.Menu.Items
            menuItem.ForeColor = Color.Black

            For Each dropDownItem As ToolStripMenuItem In menuItem.DropDownItems
                dropDownItem.ForeColor = Color.Black
                For Each lolCat As ToolStripMenuItem In dropDownItem.DropDownItems
                    lolCat.ForeColor = Color.Black
                Next
            Next
        Next

        Dim t As CustomMenuBorderLight = New CustomMenuBorderLight
        Editor.Menu.Renderer = New ToolStripProfessionalRenderer(t)

    End Sub
#End Region



End Class
