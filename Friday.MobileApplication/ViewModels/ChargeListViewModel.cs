using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friday.MobileApplication.ViewModels
{
    public partial class ChargeListViewModel : ObservableObject
    {
        [ObservableProperty]
        List<ChargeItem> chargeItems;

        [ObservableProperty]
        ChargeItem selectedItem;
    }

    public class ChargeItem
    {
        public string Title { get; set; }
        public string Approval { get; set; }
        public ChargeItem(string title, string approval) { this.Title = title; this.Approval = approval; }
    }
}