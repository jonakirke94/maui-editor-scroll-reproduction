namespace MauiHandler;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        MyEditor.TextChanged += OnTextChanged;
    }

    private void OnTextChanged(object sender, TextChangedEventArgs e)
    {
        // There is a mismatch between these values. They should be equal.
        // It appears the autosize does not update the inner scroll view
        Console.WriteLine($"ContentSize of the ScrollView: {InnerScrollView.ContentSize}");
        Console.WriteLine($"ContentSize of the Editor: {MyEditor.DesiredSize}");

        // Trigger a new layout in the scroll view. After this the content size and desired size will be equal
        Dispatcher.Dispatch(() => InnerScrollView.ForceLayout());
    }
}

