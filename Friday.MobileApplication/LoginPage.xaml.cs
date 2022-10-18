using CommunityToolkit.Maui.Behaviors;
using Friday.MobileApplication.Views;
using Microsoft.Maui;

namespace Friday.MobileApplication;

/// <summary>
/// ref : https://github.com/syazwan089/.NET-MAUI-SIMPLE-LOGIN-PAGE
/// </summary>
public partial class LoginPage : ContentPage
{
    private readonly AppShell _shell;
    private readonly FridayDatabase _database;
    public LoginPage(AppShell appShell, FridayDatabase database)
    {
        this._shell = appShell;
        this._database = database;

        InitializeComponent();
        //SetFocusOnEntryCompletedBehavior.SetNextElement(this.entLogin, this.entPassword);        
        Shell.SetNavBarIsVisible(this, false);

        this.Loaded += async (s, e) =>
        {
            var loginData = await _database.GetLoginDataAsync();
            if(loginData != null) 
            { 
                if(loginData.IsSave)
                {
                    this.UserId.Text = loginData.UserEmail;
                    this.IsSave.IsChecked = loginData.IsSave;
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
        if(this.IsSave.IsChecked)
        {
            await _database.SaveItem(new Data.Entity.LoginData()
            {
                UserEmail = this.UserId.Text,
                IsSave = true
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
        App.Current.MainPage = _shell;

        //navigation root를 사용함.(즉, <- 표시 나타남.)
        //await Navigation.PushAsync(new UserPage());
    }
}