using Friday.MobileApplication.Controls;
using System.Diagnostics;

namespace Friday.MobileApplication.Views;

public partial class MapPage : ContentPage
{
	public MapPage()
	{
		InitializeComponent();

        //mappy.Pins.Add(new Microsoft.Maui.Controls.Maps.Pin
        //{
        //    Label = "Subscribe to my channel?",
        //    Location = new Location(50.8514, 5.6910),
        //});

        //        this.Loaded += async (s, e) =>
        //        {
        //            var filePath = "map.html";
        //#if WINDOWS

        //        var stream = await Microsoft.Maui.Essentials.FileSystem.OpenAppPackageFileAsync("Assets/" + filePath);
        //#else
        //            var stream = await FileSystem.OpenAppPackageFileAsync(filePath);
        //#endif

        //            if (stream != null)
        //            {
        //                string html = (new System.IO.StreamReader(stream)).ReadToEnd();
        //                this.MapWebView.Source = new HtmlWebViewSource { Html = html };
        //                this.MapWebView.Navigated += (ss, ee) =>
        //                {

        //                };
        //            }
        //        };

        //this.Loaded += async (s, e) =>
        //{
        //    this.MapWebView.Source = new HtmlWebViewSource() { Html = htmlSource };
        //    this.MapWebView.Navigated += async (s, e) =>
        //    {
        //        var result = await this.MapWebView.EvaluateJavaScriptAsync("init()");
        //    };
        //};
        
    }

    protected override async void OnParentSet()
    {
        base.OnParentSet();
    }

    protected async override void OnAppearing()
    {
        //await Permissions.RequestAsync<Permissions.LocationWhenInUse>();
    }

    private async void OnLocationClicked(object sender, EventArgs e)
    {
        //await this.MapWebView.EvaluateJavaScriptAsync("");
    }


    string htmlSource = @"
<html>
<head>
    <meta charset=""utf-8"" />
    <title>Kakao 지도 시작하기</title>
</head>
<body>
    <div id=""map"" style=""width:500px;height:400px;""></div>
    <script type=""text/javascript"" src=""https://dapi.kakao.com/v2/maps/sdk.js?appkey=218a4662ed5cba24f4796b29ab7a7de2""></script>
    <script type=""text/javascript"">
        function init() {
alert('test');
		var container = document.getElementById('map');
		var options = {
			center: new kakao.maps.LatLng(33.450701, 126.570667),
			level: 3
		};

        var map = new kakao.maps.Map(container, options);
        
        }
    </script>
</body>
</html>
";
}