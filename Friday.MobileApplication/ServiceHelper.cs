using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friday.MobileApplication
{
    public static class ServiceHelper
    {
        public static TService GetService<TService>()
            => Current.GetService<TService>();

        public static IServiceProvider Current =>
#if WINDOWS
            MauiWinUIApplication.Current.Services.GetService<IServiceProvider>();
#elif ANDROID
            MauiApplication.Current.Services.GetService<IServiceProvider>();
#elif IOS || MACCATALYST
            MauiUIApplicationDelegate.Current.Services.GetService<IServiceProvider>();
#else 
            null;
#endif
    }
}
