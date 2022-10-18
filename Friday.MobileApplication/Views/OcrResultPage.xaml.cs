using CommunityToolkit.Maui.Views;

namespace Friday.MobileApplication.Views;

public partial class OcrResultPage : ContentPage
{
    public OcrResultPage()
	{
		InitializeComponent();
    }

    private async void OnResultClicked(object sender, EventArgs e)
	{
        var popup = new SpinnerPopup("���ε� ��...");
        this.ShowPopup(popup);
        await Task.Delay(1000);
        popup.Close();

        await Shell.Current.DisplayAlert("�ȳ�", "���ε� �Ϸ�", "OK");
        
    }

    private async void OnIndicatorCloseClicked(object sender, EventArgs e)
    {
        //await Task.Delay(1000);
        //page back (animate effect show)
        Shell.Current.SendBackButtonPressed();
        
        //or page back (animate effect not show)
        await Shell.Current.GoToAsync("..");
        
        //or page back and other page
        //await Shell.Current.GoToAsync("../monkey");
        
        //or page go and parameter binding, so vm data binded.
        //await Shell.Current.GoToAsync($"monkey?Name={"test"}");
    }
}