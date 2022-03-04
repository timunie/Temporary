using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using UberShop.UI;
using UberShop.UI.Panels;

namespace UberShop
{
	public class App : Application
	{
		[STAThread]
		public static void Main(string[] args)
		{
			BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);
		}

		public static AppBuilder BuildAvaloniaApp()
		{
			return AppBuilder.Configure<App>().UsePlatformDetect().LogToTrace();
		}

		public override void Initialize()
		{
			AvaloniaXamlLoader.Load(this);
		}

		public override void OnFrameworkInitializationCompleted()
		{
			if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime Lifetime)
			{
				Lifetime.ShutdownMode = ShutdownMode.OnMainWindowClose;
				Lifetime.MainWindow = new QMainWindow();
			}
		}
	}
}
