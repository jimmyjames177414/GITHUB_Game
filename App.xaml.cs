using Microsoft.Maui.Controls;

namespace GITHUB_Game;

/// <summary>
/// The root <see cref="Application"/> class.  Sets the starting page of the
/// application to <see cref="MainPage"/>.
/// </summary>
public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        // Set the main page to a MAUI page that hosts a BlazorWebView.
        MainPage = new MainPage();
    }
}
