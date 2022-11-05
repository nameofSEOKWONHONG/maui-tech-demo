using Friday.MobileApplication.Views;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friday.MobileApplication.Pages
{
    public partial class Map
    {
        MapPage mapPage;
        public Map()
        {
            mapPage = ServiceHelper.GetService<MapPage>();           
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            Location location = await Geolocation.Default.GetLastKnownLocationAsync();
            if (location != null)
            {
                await JS.InvokeVoidAsync($"goLocation", location.Latitude, location.Longitude);
            }

            mapPage.OnGoLocation = async () =>
            {
                try
                {
                    location = await Geolocation.Default.GetLastKnownLocationAsync();
                    if (location != null)
                    {
                        await JS.InvokeVoidAsync($"goLocation", location.Latitude, location.Longitude);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            };
        }
    }
}
