using CommunityToolkit.Mvvm.ComponentModel;

namespace Friday.MobileApplication.Controls;

public partial class LabelInputNumberView : ContentView
{
    public static readonly BindableProperty LabelTextProperty = BindableProperty.Create(nameof(LabelText), typeof(string), typeof(LabelInputNumberView), string.Empty);
    public string LabelText
    {
        get => (string)GetValue(LabelInputNumberView.LabelTextProperty);
        set => SetValue(LabelInputNumberView.LabelTextProperty, value);
    }

    public static readonly BindableProperty EntryTextProperty = BindableProperty.Create(nameof(EntryText), typeof(string), typeof(LabelInputNumberView), string.Empty);
    private string _entryText;
    public string EntryText
    {
        get => (string)GetValue(LabelInputNumberView.EntryTextProperty);
        set => SetValue(LabelInputNumberView.EntryTextProperty, value);
    }

    public static readonly BindableProperty EntryPlaceholderTextProperty = BindableProperty.Create(nameof(EntryPlaceholderText), typeof(string), typeof(LabelInputNumberView), string.Empty);
    public string EntryPlaceholderText
    {
        get => (string)GetValue(LabelInputNumberView.EntryPlaceholderTextProperty);
        set => SetValue(LabelInputNumberView.EntryPlaceholderTextProperty, value);
    }

    public LabelInputNumberView()
    {
        this.BindingContext = this;
        InitializeComponent();
        this.Loaded += (s, e) =>
        {
            if (string.IsNullOrEmpty(this.Input.Text)) return;
            ToCurrencyValue(this.Input);
        };
    }

    private void OnCompleted(object sender, EventArgs e)
    {
        ToCurrencyValue(sender as Entry);
        this.Input.Unfocus();        
    }

    private void OnUnfocused(object sender, FocusEventArgs e)
    {
        ToCurrencyValue(sender as Entry);
    }

    private void ToCurrencyValue(Entry entry)
    {
        if (entry == null) return;

        if (string.IsNullOrEmpty(entry.Text)) return;

        var v = entry.Text;
        if (v.Contains(","))
        {
            v = entry.Text.Replace(",", "");
        }
        entry.Text = string.Format("{0:#,###}", Convert.ToInt64(v));
    }
}