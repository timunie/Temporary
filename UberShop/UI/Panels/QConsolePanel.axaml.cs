using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace UberShop.UI.Panels
{
	public partial class QConsolePanel : QPanel
	{
		public QConsolePanel()
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
			AvaloniaXamlLoader.Load(this);
		}
	}
}
