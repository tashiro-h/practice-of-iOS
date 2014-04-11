// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace FifthApp
{
	[Register ("DetailViewController")]
	partial class DetailViewController
	{
		[Outlet]
		MonoTouch.UIKit.UILabel detailNameLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel detailPrefLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (detailNameLabel != null) {
				detailNameLabel.Dispose ();
				detailNameLabel = null;
			}

			if (detailPrefLabel != null) {
				detailPrefLabel.Dispose ();
				detailPrefLabel = null;
			}
		}
	}
}
