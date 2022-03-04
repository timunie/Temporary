using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;

namespace UberShop.UI.Panels
{
	public class QPanel : UserControl
	{
		public static readonly StyledProperty<string> TitleProperty = AvaloniaProperty.Register<QPanel, string>(nameof(Title), "Untitled Panel");

		public string Title
		{
			get { return GetValue(TitleProperty); }
			set { SetValue(TitleProperty, value); }
		}
	}
}
