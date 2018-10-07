Public Class CustomMenuBorderLight
    Inherits ProfessionalColorTable



#Region "COLORS"
    Dim Color1 = Color.FromArgb(188, 193, 196)
    Dim Color2 = Color.FromArgb(210, 213, 216)
#End Region
#Region "MENU STRIP BORDER"
    Public Overrides ReadOnly Property MenuBorder() _
    As System.Drawing.Color
        Get
            Return ThemeLoader.darkMenuCol
        End Get
    End Property

    Public Overrides ReadOnly Property ImageMarginGradientBegin() As System.Drawing.Color
        Get
            Return ThemeLoader.lightDarkMenuCol
        End Get
    End Property
    Public Overrides ReadOnly Property ImageMarginGradientEnd() As System.Drawing.Color
        Get
            Return ThemeLoader.lightDarkMenuCol
        End Get
    End Property
    Public Overrides ReadOnly Property ImageMarginGradientMiddle() As System.Drawing.Color
        Get
            Return ThemeLoader.lightDarkMenuCol
        End Get
    End Property

    Public Overrides ReadOnly Property SeparatorDark() As Color
        Get
            Return ThemeLoader.lightDarkMenuCol
        End Get
    End Property

    Public Overrides ReadOnly Property ToolStripDropDownBackground() As Color
        Get
            Return ThemeLoader.lightDarkMenuCol
        End Get
    End Property




    Public Overrides ReadOnly Property MenuItemSelectedGradientBegin() As Color
        Get
            Return Color2
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemSelectedGradientEnd() As Color
        Get
            Return Color2
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemSelected() As Color
        Get
            Return Color2
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemBorder() As Color
        Get
            Return Color1
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemPressedGradientBegin() As Color
        Get
            Return Color2
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemPressedGradientEnd() As Color
        Get
            Return Color2
        End Get
    End Property
#End Region



End Class
