using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace FifthApp
{
	public partial class FifthAppViewController : UIViewController
	{
		public FifthAppViewController () : base ("FifthAppViewController", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
		}
		// テーブルビューページへ遷移
		partial void GoToTableView (NSObject sender)
		{
			UINavigationController navigationController = new UINavigationController (new TableViewController ());
			PresentViewController (navigationController, false, null);

		}
	}
}

