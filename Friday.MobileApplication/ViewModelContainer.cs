using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Friday.MobileApplication
{
    //public class Sample
    //{
    //    public Sample() {
    //        var container = new ViewModelContainer();
    //        container.AddViewModel<LoginViewModel>()
    //            .AddViewModel<LogoutViewModel>()
    //            .AddSubscribe<LoginViewModel, LogoutViewModel>((vm1, vm2) =>
    //            {
    //                vm1.PropertyChanged += (s, e) =>
    //                {
    //                    if(e.PropertyName == "Message")
    //                    {
    //                        vm2.MessageB = vm1.Message;
    //                    }
    //                };
    //            });
    //        container.GetViewModel<LoginViewModel>().Message = "test2";
    //        container.GetViewModel<LoginViewModel>().Message = "test3";
    //    }
    //}

    //public class ViewModelContainer
    //{
    //    private readonly List<ViewModelBase> viewModels = new ();

    //    public ViewModelContainer()
    //    {

    //    }

    //    public ViewModelContainer AddViewModel<T>() where T : ViewModelBase, new()
    //    {
    //        viewModels.Add (new T());
    //        return this;
    //    }

    //    public T GetViewModel<T>() where T : ViewModelBase
    //    {
    //        return (T)viewModels.First(m => m.GetType() == typeof(T));
    //    }

    //    public ViewModelContainer AddSubscribe<T1, T2>(Action<T1, T2> action = null) 
    //        where T1 : ViewModelBase
    //        where T2 : ViewModelBase
    //    {
    //        var t1 = (T1)viewModels.First(m => m.GetType() == typeof(T1));
    //        var t2 = (T2)viewModels.First(m => m.GetType() == typeof(T2));
    //        if(action != null) action(t1, t2);
    //        return this;
    //    }
    //}

    //public class ViewModelBase : INotifyPropertyChanged
    //{
    //    public string ViewModelName { get; set; }
    //    protected ViewModelBase() { }

    //    protected bool SetProperty<T>(ref T backingStore, T value, [CallerMemberName] string propertyName = null)
    //    {
    //        if (Equals(backingStore, value)) return false;
    //        backingStore = value;

    //        OnPropertyChanged(propertyName);

    //        return true;
    //    }

    //    protected bool SetProperty([CallerMemberName] string propertyName = null)
    //    {
    //        OnPropertyChanged(propertyName);

    //        return true;
    //    }


    //    public event PropertyChangedEventHandler PropertyChanged;

    //    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    //    {
    //        var handler = PropertyChanged;
    //        if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
    //    }
    //}

    //public partial class LoginViewModel : ViewModelBase
    //{
    //    public LoginViewModel() { this.ViewModelName = nameof(LoginViewModel); }
    //    string message;
    //    public string Message { get => message; 
    //        set
    //        {
    //            message = value;
    //            SetProperty();
    //        }
    //    }
    //}

    //public partial class LogoutViewModel : ViewModelBase
    //{
    //    string message_b;
    //    public string MessageB { get => message_b;
    //        set
    //        {
    //            message_b = value;
    //            SetProperty();
    //        }
    //    }
    //}
}
