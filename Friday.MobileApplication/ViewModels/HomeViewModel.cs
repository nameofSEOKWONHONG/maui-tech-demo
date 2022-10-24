using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friday.MobileApplication.ViewModels
{
    public partial class HomeViewModel : ObservableObject
    {
        [ObservableProperty]
        string systemNotice;

        [ObservableProperty]
        string todayNotice;

        [ObservableProperty]
        double totalPayed;

        [ObservableProperty]
        string projectTitle;

        [ObservableProperty]
        bool isClose;

        [ObservableProperty]
        string projectTimes;
    }
}