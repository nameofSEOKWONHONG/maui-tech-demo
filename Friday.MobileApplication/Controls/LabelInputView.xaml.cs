namespace Friday.MobileApplication.Controls;

public partial class LabelInputView : ContentView
{
    public static readonly BindableProperty LabelTextProperty = BindableProperty.Create(nameof(LabelText), typeof(string), typeof(LabelInputView), string.Empty);
    public string LabelText
    {
        get => (string)GetValue(LabelInputView.LabelTextProperty);
        set => SetValue(LabelInputView.LabelTextProperty, value);
    }

    public static readonly BindableProperty EntryTextProperty = BindableProperty.Create(nameof(EntryText), typeof(string), typeof(LabelInputView), string.Empty);
    public string EntryText
    {
        get => (string)GetValue(LabelInputView.EntryTextProperty);
        set => SetValue(LabelInputView.EntryTextProperty, value);
    }

    public static readonly BindableProperty EntryPlaceholderTextProperty = BindableProperty.Create(nameof(EntryPlaceholderText), typeof(string), typeof(LabelInputView), string.Empty);
    public string EntryPlaceholderText
    {
        get => (string)GetValue(LabelInputView.EntryPlaceholderTextProperty);
        set => SetValue(LabelInputView.EntryPlaceholderTextProperty, value);
    }

    public LabelInputView()
	{
		this.BindingContext = this;
		InitializeComponent();
	}

    private void OnCompleted(object sender, EventArgs e)
    {
        this.Input.Unfocus();
    }

    private void OnUnfocused(object sender, FocusEventArgs e)
    {
        
    }
}