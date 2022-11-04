using AppActions.Icons.Maui;
using CommunityToolkit.Maui;
using Friday.MobileApplication.ViewModels;
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
            .UseMauiMaps()
            .ConfigureFonts(fonts =>
            {
                //fonts.AddFont("OpenSans-Regular.ttf", "RobotoRegular");
                //fonts.AddFont("OpenSans-Semibold.ttf", "RobotoBold");
                fonts.AddFont("Roboto-Regular.ttf", "RobotoRegular");
                fonts.AddFont("Roboto-Bold.ttf", "RobotoBold");
                fonts.AddFont(filename: "materialdesignicons-webfont.ttf", alias: "MaterialDesignIcons");
            })
            ;


        #region [add services]    
        builder.Services.AddSingleton<IConnectivity>(Connectivity.Current);
        builder.Services.AddSingleton<FridayDatabase>();

        builder.Services.AddSingleton<LoginPage>();
        builder.Services.AddSingleton<HomePage>();
        builder.Services.AddSingleton<HomeViewModel>();
        builder.Services.AddSingleton<LoginViewModel>();

        builder.Services.AddSingleton<ChargeListPage>();
        builder.Services.AddSingleton<ChargeListViewModel>();
        builder.Services.AddTransient<ChargeNewPage>();
        builder.Services.AddTransient<ChargeDetailPage>();
        builder.Services.AddTransient<ChargeDetailViewModel>();

        //builder.Services.AddTransient<OcrListPage>();
        //builder.Services.AddTransient<OcrPage>();
        //builder.Services.AddTransient<OcrResultPage>();
        //builder.Services.AddTransient<SpinnerPopup>();
        //builder.Services.AddTransient<UserPage>();

        #endregion

        builder.Services.AddMauiBlazorWebView();
#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
#endif

        var app = builder.Build();        
        return app;
    }

}