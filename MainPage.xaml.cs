using Microsoft.Maui.Controls;

namespace GITHUB_Game;

/// <summary>
/// Wraps a BlazorWebView in a MAUI page.  The XAML defines the control,
/// so this class simply calls InitializeComponent().
/// </summary>
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }
}
