using System;
using Cirrious.MvvmCross.Touch.Views;
using MonoTouch.UIKit;
using System.Drawing;

namespace TwitterMVVM.Touch.Views
{
	public class InfoView : MvxViewController
	{
		private UIImageView _imgView;



		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			_imgView = new UIImageView();
			_imgView.Image = UIImage.FromBundle(@"Info/logo.png");
			_imgView.ContentMode = UIViewContentMode.Center;
			View.AddSubview(_imgView);

			SetFrames();
		}

		public override void DidRotate(UIInterfaceOrientation fromInterfaceOrientation)
		{
			base.DidRotate(fromInterfaceOrientation);

			SetFrames();
		}

		private void SetFrames()
		{
			_imgView.Frame = new RectangleF(0, 0, 179, 138);
		}
	}
}

