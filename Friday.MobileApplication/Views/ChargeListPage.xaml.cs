using Friday.MobileApplication.ViewModels;

namespace Friday.MobileApplication.Views;

public partial class ChargeListPage : ContentPage
{
    private readonly ChargeListViewModel vm;
    public List<ChargeItem> ChargeItems = new()
    {
        new ChargeItem("test1", "����"),
        new ChargeItem("test2", "�ݷ�"),
        new ChargeItem("test3", "�ݷ�"),
        new ChargeItem("test4", "�ݷ�"),
        new ChargeItem("test5", "�ݷ�"),
        new ChargeItem("test6", "�ݷ�"),
        new ChargeItem("test7", "�ݷ�"),
        new ChargeItem("test8", "�ݷ�"),
        new ChargeItem("test9", "�ݷ�"),
        new ChargeItem("test10", "�ݷ�"),
        new ChargeItem("test11", "�ݷ�"),
        new ChargeItem("test12", "�ݷ�"),
        new ChargeItem("test13", "�ݷ�"),
        new ChargeItem("test14", "�ݷ�"),
        new ChargeItem("test15", "�ݷ�"),
        new ChargeItem("test16", "�ݷ�"),
        new ChargeItem("test17", "�ݷ�"),
        new ChargeItem("test18", "�ݷ�"),
        new ChargeItem("test19", "�ݷ�"),
        new ChargeItem("test20", "�ݷ�"),
        new ChargeItem("test21", "�ݷ�"),
        new ChargeItem("test22", "�ݷ�"),
        new ChargeItem("test23", "�ݷ�"),
        new ChargeItem("test24", "�ݷ�"),
        new ChargeItem("test25", "�ݷ�"),
        new ChargeItem("test26", "�ݷ�"),
        new ChargeItem("test27", "�ݷ�"),
        new ChargeItem("test28", "�ݷ�"),
        new ChargeItem("test29", "�ݷ�"),
        new ChargeItem("test30", "�ݷ�"),
        new ChargeItem("test31", "�ݷ�"),
        new ChargeItem("test32", "�ݷ�"),
        new ChargeItem("test33", "�ݷ�"),
        new ChargeItem("test34", "�ݷ�"),
        new ChargeItem("test35", "�ݷ�"),
        new ChargeItem("test36", "�ݷ�"),
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