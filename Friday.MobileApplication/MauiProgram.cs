using AppActions.Icons.Maui;
using CommunityToolkit.Maui;
using Friday.MobileApplication.Views;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Hosting;

namespace Friday.MobileApplication;

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
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("glyphicons-halflings-regular.ttf", "BootstrapIcons");
                fonts.AddFont(filename: "materialdesignicons-webfont.ttf", alias: "MaterialDesignIcons");
            })
            ;

        
#region [add services]                                
        builder.Services.AddSingleton<AppShell>();
        builder.Services.AddTransient<OcrListPage>();
        builder.Services.AddTransient<OcrPage>();
        builder.Services.AddTransient<OcrResultPage>();
        builder.Services.AddTransient<SpinnerPopup>();
        builder.Services.AddTransient<UserPage>();
        builder.Services.AddSingleton<IConnectivity>(Connectivity.Current);
        builder.Services.AddSingleton<FridayDatabase>();
        #endregion

        

        return builder.Build();
    }

}