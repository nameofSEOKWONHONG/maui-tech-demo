using CommunityToolkit.Maui.Behaviors;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Maui;

namespace Friday.MobileApplication.Views;

/// <summary>
/// ref : https://github.com/syazwan089/.NET-MAUI-SIMPLE-LOGIN-PAGE
/// </summary>
public partial class LoginPage : ContentPage
{   
    private readonly FridayDatabase _database;
    private readonly LoginViewModel _loginViewModel;
    public LoginPage(FridayDatabase database)
    {
        this._database = database;

        InitializeComponent();
        _loginViewModel = ServiceHelper.GetService<LoginViewModel>();
        this.BindingContext = _loginViewModel;
        //SetFocusOnEntryCompletedBehavior.SetNextElement(this.entLogin, this.entPassword);
        Shell.SetNavBarIsVisible(this, false);

        this.Loaded += async (s, e) =>
        {
            var loginData = await _database.GetLoginDataAsync();
            if(loginData != null) 
            { 
                if(loginData.IsSave)
                {
                    _loginViewModel.Email = loginData.UserEmail;
                    _loginViewModel.IsSave = loginData.IsSave;
                }
            }
        };

        //this.entLogin.Completed += (s, e) =>
        //{
        //    this.entPassword.Focus();
        //};
        //this.entPassword.Completed += (s, e) =>
        //{
        //    this.entPassword.Unfocus();
        //};
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        //if (count == 1)
        //    CounterBtn.Text = $"Clicked {count} time";
        //else
        //    CounterBtn.Text = $"Clicked {count} times";

        //SemanticScreenReader.Announce(CounterBtn.Text);
    }

    private async void OnSignInClicked(object sender, EventArgs e)
    {
        //TODO : http api call
        _loginViewModel.IsLogin = true;
        AppShell.Current.FlyoutBehavior = FlyoutBehavior.Flyout;
        if (this.IsSave.IsChecked)
        {
            await _database.SaveItem(new Data.Entity.LoginData()
            {
                UserEmail = _loginViewModel.Email,
                IsSave = _loginViewModel.IsSave
            });
        }
        else
        {
            var data = await _database.GetLoginDataAsync();
            if(data != null)
            {
                data.UserEmail = string.Empty;
                data.IsSave = false;
                await _database.SaveItem(data);
            }
        }
        //change mainpage to AppShell.
        //this is mean, loginPage not navigate. 
        //navigation root is AppShell.        

        //navigation root를 사용함.(즉, <- 표시 나타남.)
        //await Navigation.PushAsync(new UserPage());

        await Shell.Current.GoToAsync("//App");
    }
}

public partial class LoginViewModel : ObservableObject
{
    [ObservableProperty]
    string email;

    [ObservableProperty]
    string password;

    [ObservableProperty]
    bool isLogin;

    [ObservableProperty]
    bool isSave;
}