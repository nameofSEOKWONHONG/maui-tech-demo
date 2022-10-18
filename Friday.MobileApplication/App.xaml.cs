using Friday.MobileApplication.Views;

namespace Friday.MobileApplication;

public partial class App : Application
{
    public App(IConnectivity connectivity, AppShell appShell, FridayDatabase database)
    {
        InitializeComponent();

        Application.Current.UserAppTheme = AppTheme.Light;

        this.MainPage = new LoginPage(appShell, database);
        this.MainPage.Loaded += (s, e) =>
        {
            connectivity.ConnectivityChanged += async (s, e) =>
            {
                if (e.NetworkAccess != NetworkAccess.Internet)
                {
                    await Shell.Current.DisplayAlert("오류", "인터넷에 연결 할 수 없습니다.", "OK");
                }
                else
                {
                    await Shell.Current.DisplayAlert("환영", "환영", "OK");
                }
            };
        };
    }
}