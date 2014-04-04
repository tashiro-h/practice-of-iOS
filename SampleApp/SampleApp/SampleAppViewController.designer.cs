// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace SampleApp
{
    [Register("SampleAppViewController")]
    partial class SampleAppViewController
    {
        [Outlet]
        MonoTouch.UIKit.UILabel dispLabel { get; set; }

        [Outlet]
        MonoTouch.UIKit.UIButton nextButton { get; set; }

        [Action("goToNext:")]
        partial void goToNext(MonoTouch.Foundation.NSObject sender);

        void ReleaseDesignerOutlets()
        {
            if (dispLabel != null)
            {
                dispLabel.Dispose();
                dispLabel = null;
            }

            if (nextButton != null)
            {
                nextButton.Dispose();
                nextButton = null;
            }
        }
    }
}
