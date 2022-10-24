using CommunityToolkit.Mvvm.ComponentModel;
using System.Globalization;

namespace Friday.MobileApplication.Controls;

public partial class LabelInputNumberView : ContentView
{
    public static readonly BindableProperty LabelTextProperty = BindableProperty.Create(nameof(LabelText), typeof(string), typeof(LabelInputNumberView), string.Empty);
    public string LabelText
    {
        get => (string)GetValue(LabelInputNumberView.LabelTextProperty);
        set => SetValue(LabelInputNumberView.LabelTextProperty, value);
    }

    public static readonly BindableProperty NumberFormatProperty = BindableProperty.Create(nameof(NumberFormat), typeof(string), typeof(LabelInputNumberView), string.Empty);
    public string NumberFormat
    {
        get => (string)GetValue(LabelInputNumberView.NumberFormatProperty);
        set => SetValue(LabelInputNumberView.NumberFormatProperty, value);
    }

    public static readonly BindableProperty EntryTextProperty = BindableProperty.Create(nameof(EntryText), typeof(string), typeof(LabelInputNumberView), string.Empty);    
    public string EntryText
    {
        get
        {
            var value = (string)GetValue(LabelInputNumberView.EntryTextProperty);
            //var formatInfo = (NumberFormatInfo)CultureInfo.CurrentCulture.NumberFormat.Clone();
            //formatInfo.CurrencyGroupSeparator = string.Empty;
            if (string.IsNullOrEmpty(value)) return value;
            var stringValue = Convert.ToDecimal(value).ToString(NumberFormat);
            
            return stringValue;
        }
        set
        {
            SetValue(LabelInputNumberView.EntryTextProperty, value);
        }
    }

    public static readonly BindableProperty EntryPlaceholderTextProperty = BindableProperty.Create(nameof(EntryPlaceholderText), typeof(string), typeof(LabelInputNumberView), string.Empty);
    public string EntryPlaceholderText
    {
        get => (string)GetValue(LabelInputNumberView.EntryPlaceholderTextProperty);
        set => SetValue(LabelInputNumberView.EntryPlaceholderTextProperty, value);
    }

    public LabelInputNumberView()
    {        
        InitializeComponent();
    }
}