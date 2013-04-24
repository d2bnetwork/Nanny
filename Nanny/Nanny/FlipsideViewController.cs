using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Nanny.DOM;

namespace Nanny
{
	public partial class FlipsideViewController : UIViewController
	{
		public FlipsideViewController () : base ("FlipsideViewController", null)
		{
		}
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			Logic.DataLogic.Instance.SaveObject(new DOM.ChildInfo()
			                                  {
				ID = 1,
				Name="Prueba",
				Parent = new UserInfo()
			});
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
		
		partial void done (UIBarButtonItem sender)
		{
			if (Done != null)
				Done (this, EventArgs.Empty);
		}
		
		public event EventHandler Done;
	}
}

