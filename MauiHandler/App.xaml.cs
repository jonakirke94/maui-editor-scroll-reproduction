using Microsoft.Maui.Platform;

namespace MauiHandler;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        MainPage = new AppShell();

        Microsoft.Maui.Handlers.ScrollViewHandler.Mapper.AppendToMapping(nameof(ScrollView), (handler, view) =>
        {
#if ANDROID
            if (view is MyScrollView)
            {
                handler.PlatformView.SetVerticalScrollBarVisibility(ScrollBarVisibility.Never);
            }
#endif
        });
    }
}
