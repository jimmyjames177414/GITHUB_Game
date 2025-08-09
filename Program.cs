using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace GITHUB_Game;

/// <summary>
/// Entry point for the application.  On each platform, MAUI will generate a
/// platform‑specific Main method that invokes this code.  The MauiApp itself is
/// created in <see cref="MauiProgram"/>.
/// </summary>
public class Program : MauiApplication
{
    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

    static void Main(string[] args)
    {
        var app = new Program();
        app.Run(args);
    }
}
