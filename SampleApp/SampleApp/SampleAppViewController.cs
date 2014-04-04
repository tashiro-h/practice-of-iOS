using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace SampleApp
{
    public partial class SampleAppViewController : UIViewController
    {
        public SampleAppViewController() : base("SampleAppViewController", null)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
        }

        partial void goToNext(NSObject sender)
        {
            dispLabel.Text = "Pushed!!";

            PresentModalViewController(new SecondViewController(), false);
        }
    }
}

