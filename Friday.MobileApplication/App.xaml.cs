using Friday.MobileApplication.Views;

namespace Friday.MobileApplication;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        //set theme light 
        Application.Current.UserAppTheme = AppTheme.Light;

        Microsoft.Maui.Handlers.WindowHandler.Mapper.AppendToMapping(nameof(IWindow), (handler, view) =>
        {
#if WINDOWS
            var mauiWindow = handler.VirtualView;
            var nativeWindow = handler.PlatformView;
            nativeWindow.Activate();
            IntPtr windowHandle = WinRT.Interop.WindowNative.GetWindowHandle(nativeWindow);
            Microsoft.UI.WindowId windowId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(windowHandle);
            Microsoft.UI.Windowing.AppWindow appWindow = Microsoft.UI.Windowing.AppWindow.GetFromWindowId(windowId);
            appWindow.Resize(new Windows.Graphics.SizeInt32(390, 844));
#endif
        });

        this.MainPage = new AppShell();
        //this.MainPage = new LoginPage(appShell, database);
        //this.MainPage = new ComponetViewPage();
        //this.MainPage.Loaded += (s, e) =>
        //{
        //    connectivity.ConnectivityChanged += async (s, e) =>
        //    {
        //        if (e.NetworkAccess != NetworkAccess.Internet)
        //        {
        //            await Shell.Current.DisplayAlert("오류", "인터넷에 연결 할 수 없습니다.", "OK");
        //        }
        //        else
        //        {
        //            await Shell.Current.DisplayAlert("환영", "환영", "OK");
        //        }
        //    };
        //};
    }

    public override void CloseWindow(Window window)
    {
        base.CloseWindow(window);
    }
}