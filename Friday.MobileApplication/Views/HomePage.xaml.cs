#if ANDROID
using Android.Content.PM;
#endif

using CommunityToolkit.Mvvm.ComponentModel;
using Friday.MobileApplication.ViewModels;
using Microsoft.Maui.Controls.PlatformConfiguration;

namespace Friday.MobileApplication.Views;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
        var vm = ServiceHelper.GetService<HomeViewModel>();
        vm.SystemNotice = "�ý��� ���� ���� 12�� 30�� ���� ������ �ֽ��ϴ�.\n��뿡 �����Ͻñ� �ٶ��ϴ�.";
        vm.TodayNotice = "ȸ�� ������ �Դϴ�. ����(24��)���� ��� ������ û�� �ٶ��ϴ�.\n��û���� ������ ���� ȸ���� û���� �����Դϴ�.";
        vm.TotalPayed = 1500000;
        vm.ProjectTitle = "�׽�Ʈ ������Ʈ";
        var r1 = new Random();
        vm.IsClose = Convert.ToBoolean(r1.Next(0, 1));
        var r2 = new Random();
        vm.ProjectTimes = $"{r2.Next(20)}ȸ�� {DateTime.Now.ToString("yyyy-MM-dd")}";
        BindingContext = vm;
	}

    private async void OnTapped(object sender, EventArgs e)
    {
		await Shell.Current.DisplayAlert("test", "test", "OK");
    }

	private void OnAccountsManagerClicked(object sender, EventArgs e)
	{
        if (PhoneDialer.Default.IsSupported)
            PhoneDialer.Default.Open("010-7102-0130");
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

