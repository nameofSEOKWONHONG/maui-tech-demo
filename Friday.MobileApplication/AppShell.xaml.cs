using CommunityToolkit.Maui.Alerts;
using Friday.MobileApplication.Views;

namespace Friday.MobileApplication;

public partial class AppShell : Shell
{
    public Dictionary<string, Type> Routes { get; private set; } = new Dictionary<string, Type>();
    public AppShell()
    {
        InitializeComponent();
        RegisterRoutes();        
        this.Loaded += async (s, e) =>
        {
            //await Shell.Current.GoToAsync("//LoginPage", false);
        };
    }

    void RegisterRoutes()
    {
        Routes.Add("HomePage", typeof(HomePage));
        Routes.Add("ChargeListPage", typeof(ChargeListPage));
        Routes.Add("SettingPage", typeof(SettingPage));
        Routes.Add("LoginPage", typeof(LoginPage));

        foreach (var item in Routes)
        {
            Routing.RegisterRoute(item.Key, item.Value);
        }
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
    }

    protected override void OnNavigating(ShellNavigatingEventArgs args)
    {
        base.OnNavigating(args);
        if (args.Current == null) return;
        if (args.Current.Location.ToString() != "//App/MainPage")
        {
            //var vm = ServiceHelper.GetService<LoginViewModel>();
            //if(!vm.IsLogin)
            //{
            //    Toast.Make("로그인 하세요.").Show();
            //    args.Cancel();
            //}
        }
    }
}