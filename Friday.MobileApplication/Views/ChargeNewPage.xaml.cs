#if ANDROID
using Android.Content.PM;
#endif

namespace Friday.MobileApplication.Views;

public partial class ChargeNewPage : ContentPage
{
	public ChargeNewPage()
	{
		InitializeComponent();
	}

	public async void OnCameraClicked(object sender, EventArgs e)
	{
#if ANDROID
		var apps = Android.App.Application.Context.PackageManager.GetInstalledApplications(PackageInfoFlags.MatchAll);		
		var officelens = apps.FirstOrDefault(m => m.PackageName.Contains("com.microsoft.office.officelens"));
		if(officelens != null)
		{
            var intent = Android.App.Application.Context.PackageManager.GetLaunchIntentForPackage(officelens.PackageName);
            Platform.CurrentActivity.StartActivity(intent);
        }
		else
		{
            var uri = new Uri("https://play.google.com/store/apps/details?id=com.microsoft.office.officelens&hl=ko&gl=KR");
            await Browser.Default.OpenAsync(uri, BrowserLaunchMode.External);
        }
#endif

#if IOS

#endif
	}


    public async void OnBillingClicked(object sender, EventArgs e)
	{
        //if(MediaPicker.Default.IsCaptureSupported)
        //{
        //	FileResult photo = await MediaPicker.Default.CapturePhotoAsync();

        //	if(photo != null)
        //	{
        //		var localFilePath = Path.Combine(FileSystem.CacheDirectory, photo.FileName);

        //		using Stream sourcestream = await photo.OpenReadAsync();
        //		using FileStream localFileStream = File.OpenWrite(localFilePath);
        //		await sourcestream.CopyToAsync(localFileStream);


        //	}
        //}
        var result = await MediaPicker.Default.PickPhotoAsync();
        if(result != null)
        {
            var page = ServiceHelper.GetService<ChargeDetailPage>();
            await Navigation.PushAsync(page);
        }
    }
}