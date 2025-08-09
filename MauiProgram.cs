uusing Microsoft.Maui;
using Microsoft.Maui.Hosting;
using CommunityToolkit.Maui;

namespace GITHUB_Game;

/// <summary>
/// Configures and builds the MAUI application.  Services, fonts and other
/// configuration should be added here.  Note that fonts are intentionally
/// omitted from this example to avoid bundling additional assets.
/// </summary>
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
            {
                // Fonts can be added here using fonts.AddFont(<file>, <alias>);
                // e.g.: fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

        return builder.Build();
    }
}
