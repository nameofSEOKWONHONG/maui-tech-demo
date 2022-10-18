using Android.App;
using Android.Content.PM;
using Android.OS;

namespace Friday.MobileApplication;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true,
    ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode |
                           ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
[IntentFilter(new[] {Android.Content.Intent.ActionSend},
    Categories = new[]
    {
        Android.Content.Intent.ActionCameraButton,
    },
    DataMimeType = "*/*")]
public class MainActivity : MauiAppCompatActivity
{
}