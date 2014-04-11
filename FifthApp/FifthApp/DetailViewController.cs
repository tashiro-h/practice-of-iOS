using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace FifthApp
{
	public partial class DetailViewController : UIViewController
	{
		public DetailViewController () : base ("DetailViewController", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.

		}

		public void ShowDetail (Item item)
		{
			detailNameLabel.Text = item.name;
			detailPrefLabel.Text = item.pref;
		}
	}
}

