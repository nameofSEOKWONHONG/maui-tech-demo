using Friday.MobileApplication.ViewModels;

namespace Friday.MobileApplication.Views;

public partial class ChargeListPage : ContentPage
{
    private readonly ChargeListViewModel vm;
    public List<ChargeItem> ChargeItems = new()
    {
        new ChargeItem("test1", "승인"),
        new ChargeItem("test2", "반려"),
        new ChargeItem("test3", "반려"),
        new ChargeItem("test4", "반려"),
        new ChargeItem("test5", "반려"),
        new ChargeItem("test6", "반려"),
        new ChargeItem("test7", "반려"),
        new ChargeItem("test8", "반려"),
        new ChargeItem("test9", "반려"),
        new ChargeItem("test10", "반려"),
        new ChargeItem("test11", "반려"),
        new ChargeItem("test12", "반려"),
        new ChargeItem("test13", "반려"),
        new ChargeItem("test14", "반려"),
        new ChargeItem("test15", "반려"),
        new ChargeItem("test16", "반려"),
        new ChargeItem("test17", "반려"),
        new ChargeItem("test18", "반려"),
        new ChargeItem("test19", "반려"),
        new ChargeItem("test20", "반려"),
        new ChargeItem("test21", "반려"),
        new ChargeItem("test22", "반려"),
        new ChargeItem("test23", "반려"),
        new ChargeItem("test24", "반려"),
        new ChargeItem("test25", "반려"),
        new ChargeItem("test26", "반려"),
        new ChargeItem("test27", "반려"),
        new ChargeItem("test28", "반려"),
        new ChargeItem("test29", "반려"),
        new ChargeItem("test30", "반려"),
        new ChargeItem("test31", "반려"),
        new ChargeItem("test32", "반려"),
        new ChargeItem("test33", "반려"),
        new ChargeItem("test34", "반려"),
        new ChargeItem("test35", "반려"),
        new ChargeItem("test36", "반려"),
    };

    public ChargeListPage()
	{
        vm = ServiceHelper.GetService<ChargeListViewModel>();
        vm.ChargeItems = this.ChargeItems;
        this.BindingContext = vm;
		InitializeComponent();

        //this.cv.ItemsSource = ChargeItems;
        this.Loaded += (s, e) =>
        {

        };
	}

    private async void OnNewClicked(object sender, EventArgs e)
    {
        var chargeNewPage = ServiceHelper.GetService<ChargeNewPage>();
        await Navigation.PushAsync(chargeNewPage);
    }
        
    private async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (vm.SelectedItem == null) return;
        if (e.CurrentSelection.FirstOrDefault() == null) return;
        var chargeDetailPage = ServiceHelper.GetService<ChargeDetailPage>();
        await Navigation.PushAsync(chargeDetailPage);
    }
}