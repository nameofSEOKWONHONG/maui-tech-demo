using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;

namespace Friday.MobileApplication.Views;

/// <summary>
/// MVVM 规过2肺 备泅
/// </summary>
public partial class SpinnerPopup : Popup, INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;

    protected void RaisePropertyChanged(string propertyName)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    private string _message;
	public string Message
	{
		get { return _message; }
		//set { this._message = value; RaisePropertyChanged(nameof(Message)); }
	}

	//SpinnerPopupViewModel spinnerPopupViewModel;
    public SpinnerPopup(string message)
	{
		this._message = message;
		//spinnerPopupViewModel = new SpinnerPopupViewModel(message);		
		//this.BindingContext = spinnerPopupViewModel;
		this.BindingContext = this;
		InitializeComponent();	
	}
}

/// <summary>
/// MVVM 规过1
/// </summary>
public partial class SpinnerPopupViewModel : ObservableObject
{
	public SpinnerPopupViewModel(string message)
	{
		this.message = message;
	}

    [ObservableProperty]
    string message;
}