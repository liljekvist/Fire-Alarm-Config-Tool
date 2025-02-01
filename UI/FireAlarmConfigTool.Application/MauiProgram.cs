using System.Reflection;
using Microsoft.Extensions.Logging;
using FireAlarmConfigTool.Ui.Lib.Services;
using FireAlarmConfigTool.Application.Services;
using FireAlarmConfigTool.Logic.Http.Client.Api;
using FireAlarmConfigTool.Ui.Lib.Distribution;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.DependencyInjection;

namespace FireAlarmConfigTool.Application;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });
        
        // Add device-specific services used by the FireAlarmConfigTool.Shared project
        builder.Services.AddSingleton<IFormFactor, FormFactor>();
        // Använd aldrig localhost utan använd 127.0.0.1. Http clienten blir långsam och tar över 3 sekunder att svara.
        builder.Services.AddSingleton<IDefaultApi>(api => new DefaultApi("http://127.0.0.1:8080"));
        builder.Services.AddSingleton<ITest, Test>();

        builder.Services.AddMauiBlazorWebView();

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
