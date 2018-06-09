using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using Darwin.iOS.Renderers;

[assembly: ExportRenderer(typeof(ViewCell), typeof(CustomListViewCellRenderer))]
namespace Darwin.iOS.Renderers
{
	public class CustomListViewCellRenderer : ViewCellRenderer
    {
        public override UIKit.UITableViewCell GetCell(Xamarin.Forms.Cell item, UIKit.UITableViewCell reusableCell, UIKit.UITableView tv)
        {
            //return base.GetCell(item, reusableCell, tv);
            var cell = base.GetCell(item, reusableCell, tv);
			cell.SelectionStyle = UIKit.UITableViewCellSelectionStyle.None;
            return cell;
        }
    }
}
