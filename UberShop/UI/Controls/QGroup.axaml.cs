using System.Collections.ObjectModel;
using Avalonia;
using Avalonia.Collections;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Metadata;
using UberShop.UI.Panels;

namespace UberShop.UI.Controls
{
	public class QGroup : TemplatedControl
	{
		
		public static readonly StyledProperty<IAvaloniaList<QPanel>> ItemsProperty = AvaloniaProperty.Register<QGroup, IAvaloniaList<QPanel>>(nameof(Items), new AvaloniaList<QPanel>());
		public static readonly StyledProperty<QPanel> SelectedItemProperty = AvaloniaProperty.Register<QGroup, QPanel>(nameof(SelectedItem));
		public static readonly StyledProperty<int> SelectedIndexProperty = AvaloniaProperty.Register<QGroup, int>(nameof(SelectedIndex), 0);

		[Content]
		public IAvaloniaList<QPanel> Items
		{
			get { return GetValue(ItemsProperty); }
			internal set { SetValue(ItemsProperty, value); }
		}

		public QPanel SelectedItem
		{
			get { return GetValue(SelectedItemProperty); }
			internal set { SetValue(SelectedItemProperty, value); }
		}

		public int SelectedIndex
		{
			get { return GetValue(SelectedIndexProperty); }
			internal set { SetValue(SelectedIndexProperty, value); }
		}

		public QGroup()
		{
			SelectedIndex = 0;
		}

		protected override void OnApplyTemplate(TemplateAppliedEventArgs Event)
		{
			UpdateSelectedContent();
		}

		private void UpdateSelectedContent()
		{
			if (SelectedIndex == -1)
			{
				SelectedItem = null;
			}
			else if (Items.Count > SelectedIndex)
			{
				SelectedItem = Items[SelectedIndex];
			}
		}
	}
}
