using System;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Nanny
{
	public partial class LoginViewController : UIViewController
	{
		public LoginViewController () : base ("LoginViewController", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		
		partial void signIn(NSObject sender)
		{
			var controller = new FlipsideViewController () {
				ModalTransitionStyle = UIModalTransitionStyle.FlipHorizontal,
			};
			
			controller.Done += delegate {
				DismissModalViewControllerAnimated (true);
			};
			
			PresentModalViewController (controller, true);
			
		}
	}
}

