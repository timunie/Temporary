using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.VisualTree;
using Avalonia.Win32;
using UberShop.UI.Panels;
using WinApi.User32;

namespace UberShop.UI
{
	public partial class QFloatingWindow : Window
	{
		public QFloatingWindow()
		{
			throw new Exception ($"Do not use default constructor.");
		}

		public QFloatingWindow(QPanel Panel)
		{
			InitializeComponent();
#if DEBUG
			this.AttachDevTools();
#endif

			Content = Panel;
		}

		private void InitializeComponent()
		{
			AvaloniaXamlLoader.Load(this);
		}

		public void ClosePressed(object Sender, RoutedEventArgs Event)
		{
			Close();
		}
	}
}
