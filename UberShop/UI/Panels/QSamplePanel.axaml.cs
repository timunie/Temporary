using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace UberShop.UI.Panels
{
	public partial class QSamplePanel : QPanel
	{
		public QSamplePanel()
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
			AvaloniaXamlLoader.Load(this);
		}
	}
}
