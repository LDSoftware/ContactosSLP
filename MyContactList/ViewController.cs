using System;
using UIKit;

namespace MyContactList
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			txtIngresos.Delegate = new UITextNumberValidate();
			txtEgresos.Delegate = new UITextNumberValidate();

			btnCalcular.TouchUpInside += ((sender, e) =>
			{

			// Create a new Alert Controller
			UIAlertController actionSheetAlert = UIAlertController.Create("Action Sheet", "Select an item from below", UIAlertControllerStyle.ActionSheet);

			// Add Actions
			actionSheetAlert.AddAction(UIAlertAction.Create("Item One", UIAlertActionStyle.Default, (action) => Console.WriteLine("Item One pressed.")));

				actionSheetAlert.AddAction(UIAlertAction.Create("Item Two", UIAlertActionStyle.Default, (action) => Console.WriteLine("Item Two pressed.")));

				actionSheetAlert.AddAction(UIAlertAction.Create("Item Three", UIAlertActionStyle.Default, (action) => Console.WriteLine("Item Three pressed.")));

				actionSheetAlert.AddAction(UIAlertAction.Create("Cancel", UIAlertActionStyle.Cancel, (action) => Console.WriteLine("Cancel button pressed.")));

			// Required for iPad - You must specify a source for the Action Sheet since it is
			// displayed as a popover
			UIPopoverPresentationController presentationPopover = actionSheetAlert.PopoverPresentationController;
				if (presentationPopover != null)
				{
					presentationPopover.SourceView = this.View;
					presentationPopover.PermittedArrowDirections = UIPopoverArrowDirection.Up;
				}

			// Display the alert
			this.PresentViewController(actionSheetAlert, true, null);
			});


			//var bounds = UIScreen.MainScreen.Bounds;

			//// show the loading overlay on the UI thread using the correct orientation sizing
			//var loadPop = new LoadingOverlay(bounds);
			//View.Add(loadPop);

		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
