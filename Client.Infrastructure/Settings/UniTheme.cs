using MudBlazor;

namespace Synaplic.UniRH.Client.Infrastructure.Settings
{
    public class UniTheme
    {
        private static Typography DefaultTypography = new Typography()
        {
            Default = new Default()
            {
                FontFamily = new[] { "Montserrat", "Helvetica", "Arial", "sans-serif" },
                FontSize = ".875rem",
                FontWeight = 400,
                LineHeight = 1.43,
                LetterSpacing = ".01071em"
            },
            H1 = new H1()
            {
                FontFamily = new[] { "Montserrat", "Helvetica", "Arial", "sans-serif" },
                FontSize = "6rem",
                FontWeight = 300,
                LineHeight = 1.167,
                LetterSpacing = "-.01562em"
            },
            H2 = new H2()
            {
                FontFamily = new[] { "Montserrat", "Helvetica", "Arial", "sans-serif" },
                FontSize = "3.75rem",
                FontWeight = 300,
                LineHeight = 1.2,
                LetterSpacing = "-.00833em"
            },
            H3 = new H3()
            {
                FontFamily = new[] { "Montserrat", "Helvetica", "Arial", "sans-serif" },
                FontSize = "3rem",
                FontWeight = 400,
                LineHeight = 1.167,
                LetterSpacing = "0"
            },
            H4 = new H4()
            {
                FontFamily = new[] { "Montserrat", "Helvetica", "Arial", "sans-serif" },
                FontSize = "2.125rem",
                FontWeight = 400,
                LineHeight = 1.235,
                LetterSpacing = ".00735em"
            },
            H5 = new H5()
            {
                FontFamily = new[] { "Montserrat", "Helvetica", "Arial", "sans-serif" },
                FontSize = "1.5rem",
                FontWeight = 400,
                LineHeight = 1.334,
                LetterSpacing = "0"
            },
            H6 = new H6()
            {
                FontFamily = new[] { "Montserrat", "Helvetica", "Arial", "sans-serif" },
                FontSize = "1.25rem",
                FontWeight = 400,
                LineHeight = 1.6,
                LetterSpacing = ".0075em"
            },
            Button = new Button()
            {
                FontFamily = new[] { "Montserrat", "Helvetica", "Arial", "sans-serif" },
                FontSize = ".875rem",
                FontWeight = 500,
                LineHeight = 1.75,
                LetterSpacing = ".02857em"
            },
            Body1 = new Body1()
            {
                FontFamily = new[] { "Montserrat", "Helvetica", "Arial", "sans-serif" },
                FontSize = "1rem",
                FontWeight = 400,
                LineHeight = 1.5,
                LetterSpacing = ".00938em"
            },
            Body2 = new Body2()
            {
                FontFamily = new[] { "Montserrat", "Helvetica", "Arial", "sans-serif" },
                FontSize = ".875rem",
                FontWeight = 400,
                LineHeight = 1.43,
                LetterSpacing = ".01071em"
            },
            Caption = new Caption()
            {
                FontFamily = new[] { "Montserrat", "Helvetica", "Arial", "sans-serif" },
                FontSize = ".75rem",
                FontWeight = 400,
                LineHeight = 1.66,
                LetterSpacing = ".03333em"
            },
            Subtitle2 = new Subtitle2()
            {
                FontFamily = new[] { "Montserrat", "Helvetica", "Arial", "sans-serif" },
                FontSize = ".875rem",
                FontWeight = 500,
                LineHeight = 1.57,
                LetterSpacing = ".00714em"
            }
        };

        private static Typography DarkTypography = new Typography()
        {
            Default = new Default()
            {
                FontFamily = new[] { "Roboto", "Arial", "sans-serif" },
                FontSize = ".875rem",
                FontWeight = 400,
                LineHeight = 1.5,
                LetterSpacing = ".01071em"
            },
            H1 = new H1()
            {
                FontFamily = new[] { "Roboto", "Arial", "sans-serif" },
                FontSize = "2.5rem",
                FontWeight = 600,
                LineHeight = 1.2,
                LetterSpacing = "-.01562em"
            },
            H2 = new H2()
            {
                FontFamily = new[] { "Roboto", "Arial", "sans-serif" },
                FontSize = "2rem",
                FontWeight = 600,
                LineHeight = 1.25,
                LetterSpacing = "-.00833em"
            },
            H3 = new H3()
            {
                FontFamily = new[] { "Roboto", "Arial", "sans-serif" },
                FontSize = "1.75rem",
                FontWeight = 600,
                LineHeight = 1.3,
                LetterSpacing = "0"
            },
            H4 = new H4()
            {
                FontFamily = new[] { "Roboto", "Arial", "sans-serif" },
                FontSize = "1.5rem",
                FontWeight = 600,
                LineHeight = 1.35,
                LetterSpacing = ".00735em"
            },
            H5 = new H5()
            {
                FontFamily = new[] { "Roboto", "Arial", "sans-serif" },
                FontSize = "1.25rem",
                FontWeight = 600,
                LineHeight = 1.4,
                LetterSpacing = "0"
            },
            H6 = new H6()
            {
                FontFamily = new[] { "Roboto", "Arial", "sans-serif" },
                FontSize = "1rem",
                FontWeight = 600,
                LineHeight = 1.45,
                LetterSpacing = ".0075em"
            },
            Button = new Button()
            {
                FontFamily = new[] { "Roboto", "Arial", "sans-serif" },
                FontSize = ".875rem",
                FontWeight = 600,
                LineHeight = 1.75,
                LetterSpacing = ".02857em"
            },
            // You can customize other typography settings as needed for dark mode.
        };


        private static LayoutProperties DefaultLayoutProperties = new LayoutProperties()
        {
            DefaultBorderRadius = "3px"
        };

        public static MudTheme DefaultTheme = new MudTheme()
        {
            Palette = new Palette()
            {
                Primary = "#363062",
                Secondary = "#4D4C7D",
                AppbarBackground = "#827397",
                Background = "#f7f7f7",
                DrawerBackground = "#FFF",
                DrawerText = "rgba(0,0,0, 0.7)",
                Success = "#007E33"
            },
            Typography = DefaultTypography,
            LayoutProperties = DefaultLayoutProperties
        };

        public static MudTheme DarkTheme = new MudTheme()
        {
            Palette = new Palette()
            {
                Primary = "#0000ff", // A deep blue color
                Secondary = "#6C757D", // A muted gray color
                Success = "#28A745", // A green color for success
                Black = "#121212", // Dark background color
                Background = "#1E1E1E", // Slightly lighter background
                Surface = "#333333", // Cards and surfaces
                DrawerBackground = "#121212", // Dark drawer background
                DrawerText = "rgba(255, 255, 255, 0.7)", // Drawer text color
                AppbarBackground = "#1E1E1E", // Appbar background
                AppbarText = "rgba(255, 255, 255, 0.9)", // Appbar text color
                TextPrimary = "rgba(255, 255, 255, 0.9)", // Primary text color
                TextSecondary = "rgba(255, 255, 255, 0.7)", // Secondary text color
                ActionDefault = "#6C757D", // Default action color
                ActionDisabled = "rgba(255, 255, 255, 0.5)", // Disabled action color
                ActionDisabledBackground = "rgba(255, 255, 255, 0.1)", // Disabled action background
                DrawerIcon = "rgba(255, 255, 255, 0.7)", // Drawer icon color
                PrimaryContrastText = "#FFFFFF",
              

            },

         
            Typography = DefaultTypography,
            LayoutProperties = DefaultLayoutProperties,
   
        };

    }
}