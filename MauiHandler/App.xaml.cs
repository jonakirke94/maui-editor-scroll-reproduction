using Microsoft.Maui.Platform;

namespace MauiHandler;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        MainPage = new AppShell();
    }
}
