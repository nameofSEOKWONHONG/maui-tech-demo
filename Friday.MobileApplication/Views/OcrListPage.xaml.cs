using System.Collections.ObjectModel;

namespace Friday.MobileApplication.Views;

public partial class OcrListPage : ContentPage
{
    public ObservableCollection<OcrResultItem> OcrItems = new()
    {
        new OcrResultItem("test1", "승인"),
        new OcrResultItem("test2", "반려"),
        new OcrResultItem("test3", "반려"),
        new OcrResultItem("test4", "반려"),
        new OcrResultItem("test5", "반려"),
        new OcrResultItem("test6", "반려"),
        new OcrResultItem("test7", "반려"),
        new OcrResultItem("test8", "반려"),
        new OcrResultItem("test9", "반려"),
        new OcrResultItem("test10", "반려"),
        new OcrResultItem("test11", "반려"),
        new OcrResultItem("test12", "반려"),
        new OcrResultItem("test13", "반려"),
        new OcrResultItem("test14", "반려"),
        new OcrResultItem("test15", "반려"),
        new OcrResultItem("test16", "반려"),
        new OcrResultItem("test17", "반려"),
        new OcrResultItem("test18", "반려"),
        new OcrResultItem("test19", "반려"),
        new OcrResultItem("test20", "반려"),
        new OcrResultItem("test21", "반려"),
        new OcrResultItem("test22", "반려"),
        new OcrResultItem("test23", "반려"),
        new OcrResultItem("test24", "반려"),
        new OcrResultItem("test25", "반려"),
        new OcrResultItem("test26", "반려"),
        new OcrResultItem("test27", "반려"),
        new OcrResultItem("test28", "반려"),
        new OcrResultItem("test29", "반려"),
        new OcrResultItem("test30", "반려"),
        new OcrResultItem("test31", "반려"),
        new OcrResultItem("test32", "반려"),
        new OcrResultItem("test33", "반려"),
        new OcrResultItem("test34", "반려"),
        new OcrResultItem("test35", "반려"),
        new OcrResultItem("test36", "반려"),
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