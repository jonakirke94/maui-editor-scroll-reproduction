namespace MauiHandler;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        //Editor.TextChanged += OnTextChanged;
    }

    //private void OnTextChanged(object sender, TextChangedEventArgs e)
    //{
    //    Dispatcher.Dispatch(async () =>
    //    {
    //        await Task.Delay(100);
    //        (InnerScrollView as IView).InvalidateArrange();
    //        (InnerScrollView as IView).InvalidateMeasure();
    //    });        
    //}
}

