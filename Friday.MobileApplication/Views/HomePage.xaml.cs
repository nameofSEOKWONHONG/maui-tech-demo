#if ANDROID
using Android.Content.PM;
#endif

using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core.Views;
using Microsoft.Maui.Controls.PlatformConfiguration;

namespace Friday.MobileApplication.Views;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
        this.Loaded += async (s, e) =>
        {
            await Toast.Make("중요 공지 사항이 있습니다. 확인하세요.",
            CommunityToolkit.Maui.Core.ToastDuration.Short,
            20).Show();
        };
	}

    private async void OnTapped(object sender, EventArgs e)
    {        
		await Shell.Current.DisplayAlert("test", "test", "OK");
    }

	private void OnAccountsManagerClicked(object sender, EventArgs e)
	{
        if (PhoneDialer.Default.IsSupported)
            PhoneDialer.Default.Open("010-2153-6821");
    }

	private async void OnBankConnectClicked(object sender, EventArgs e)
	{
#if ANDROID
        var apps = Android.App.Application.Context.PackageManager.GetInstalledApplications(PackageInfoFlags.MatchAll);
        foreach(var app in apps) {
            Console.WriteLine(app.PackageName);
        }
        var band = apps.FirstOrDefault(m => m.PackageName.Contains("com.nhn.android.band"));
        if (band != null)
        {
            var intent = Android.App.Application.Context.PackageManager.GetLaunchIntentForPackage(band.PackageName);
            Platform.CurrentActivity.StartActivity(intent);
        }
        else
        {
            var uri = new Uri("https://play.google.com/store/apps/details?id=com.nhn.android.band&hl=ko&gl=KR");
            await Browser.Default.OpenAsync(uri, BrowserLaunchMode.External);
        }
#endif
    }
}