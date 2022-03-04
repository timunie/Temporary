using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using UberShop.UI.Panels;

namespace UberShop.UI
{
	public partial class QMainWindow : Window
	{
		public QMainWindow()
		{
			InitializeComponent();
#if DEBUG
			this.AttachDevTools();
#endif
		}

		private void InitializeComponent()
		{
			AvaloniaXamlLoader.Load(this);
		}

		protected override void OnOpened(EventArgs e)
		{
			//Window Floating = new QFloatingWindow(new QSamplePanel());
			//Floating.Show();
		}

		public void MinimizePressed(object Sender, RoutedEventArgs Event)
		{
			WindowState = WindowState.Minimized;
		}

		public void MaximizePressed(object Sender, RoutedEventArgs Event)
		{
			if (WindowState == WindowState.Normal)
			{
				WindowState = WindowState.Maximized;
			}
			else
			{
				WindowState = WindowState.Normal;
			}
		}

		public void ClosePressed(object Sender, RoutedEventArgs Event)
		{
			Close();
		}
	}
}
