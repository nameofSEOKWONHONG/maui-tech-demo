using Friday.MobileApplication.Controls;
using System.Diagnostics;

namespace Friday.MobileApplication.Views;

public partial class MapPage : ContentPage
{
    public Action OnGoLocation;
    public MapPage()
	{
		InitializeComponent();
    }

    private async void OnLocationClicked(object sender, EventArgs e)
    {
        if (OnGoLocation != null) OnGoLocation();
    }
}