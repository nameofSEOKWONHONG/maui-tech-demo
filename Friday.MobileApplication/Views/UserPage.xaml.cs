namespace Friday.MobileApplication.Views;

public partial class UserPage : ContentPage
{
    private CancellationTokenSource _cancelTokenSource;

    public UserPage()
	{
		InitializeComponent();
	}

	private async void OnClicked(object sender, EventArgs e)
	{
		try
		{
			GeolocationRequest request = new GeolocationRequest(GeolocationAccuracy.Medium, TimeSpan.FromSeconds(10));
            _cancelTokenSource = new CancellationTokenSource();
            Location location = await Geolocation.Default.GetLocationAsync(request, _cancelTokenSource.Token);
            //Location loc = await Geolocation.Default.GetLocationAsync();

			if(location != null)
			{
				this.Latitude.Text = location.Latitude.ToString();
				this.Longitude.Text = location.Longitude.ToString();
				this.Altitude.Text = location.Altitude.ToString();
			}
		}
		catch(Exception ex)
		{

		}
	}

    public void CancelRequest()
    {
        if (_cancelTokenSource != null && _cancelTokenSource.IsCancellationRequested == false)
            _cancelTokenSource.Cancel();
    }
}