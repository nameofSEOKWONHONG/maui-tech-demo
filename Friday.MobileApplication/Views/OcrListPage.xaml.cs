using System.Collections.ObjectModel;

namespace Friday.MobileApplication.Views;

public partial class OcrListPage : ContentPage
{
    public ObservableCollection<OcrResultItem> OcrItems = new()
    {
        new OcrResultItem("test1", "����"),
        new OcrResultItem("test2", "�ݷ�"),
        new OcrResultItem("test3", "�ݷ�"),
        new OcrResultItem("test4", "�ݷ�"),
        new OcrResultItem("test5", "�ݷ�"),
        new OcrResultItem("test6", "�ݷ�"),
        new OcrResultItem("test7", "�ݷ�"),
        new OcrResultItem("test8", "�ݷ�"),
        new OcrResultItem("test9", "�ݷ�"),
        new OcrResultItem("test10", "�ݷ�"),
        new OcrResultItem("test11", "�ݷ�"),
        new OcrResultItem("test12", "�ݷ�"),
        new OcrResultItem("test13", "�ݷ�"),
        new OcrResultItem("test14", "�ݷ�"),
        new OcrResultItem("test15", "�ݷ�"),
        new OcrResultItem("test16", "�ݷ�"),
        new OcrResultItem("test17", "�ݷ�"),
        new OcrResultItem("test18", "�ݷ�"),
        new OcrResultItem("test19", "�ݷ�"),
        new OcrResultItem("test20", "�ݷ�"),
        new OcrResultItem("test21", "�ݷ�"),
        new OcrResultItem("test22", "�ݷ�"),
        new OcrResultItem("test23", "�ݷ�"),
        new OcrResultItem("test24", "�ݷ�"),
        new OcrResultItem("test25", "�ݷ�"),
        new OcrResultItem("test26", "�ݷ�"),
        new OcrResultItem("test27", "�ݷ�"),
        new OcrResultItem("test28", "�ݷ�"),
        new OcrResultItem("test29", "�ݷ�"),
        new OcrResultItem("test30", "�ݷ�"),
        new OcrResultItem("test31", "�ݷ�"),
        new OcrResultItem("test32", "�ݷ�"),
        new OcrResultItem("test33", "�ݷ�"),
        new OcrResultItem("test34", "�ݷ�"),
        new OcrResultItem("test35", "�ݷ�"),
        new OcrResultItem("test36", "�ݷ�"),
    };

    public OcrListPage()
	{
        this.BindingContext = this;
		InitializeComponent();
        this.cv.ItemsSource = OcrItems;
        this.Loaded += (s, e) =>
        {

        };
	}

    private async void OnNewClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new OcrPage());
    }

    private async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        await Navigation.PushAsync(new OcrResultPage());
    }

    private void cv_Scrolled(object sender, ItemsViewScrolledEventArgs e)
    {

    }
}

public class OcrResultItem
{
	public string Title { get; set; }
	public string Approval { get; set; }
    public OcrResultItem(string title, string approval) { this.Title = title; this.Approval = approval;}
    
}