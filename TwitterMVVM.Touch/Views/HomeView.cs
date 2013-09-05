using System;
using Cirrious.MvvmCross.Touch.Views;
using TwitterMVVM.Core.ViewModels;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.ViewModels;

namespace TwitterMVVM.Touch.Views
{
	public class HomeView: MvxTabBarViewController
	{
		private int _createdSoFarCount = 0;



		public HomeView()
		{
			// need this additional call to ViewDidLoad because UIkit creates the view before the C# hierarchy has been constructed
			ViewDidLoad();
		}



		protected HomeViewModel HomeViewModel
		{
			get 
			{ 
				return base.ViewModel as HomeViewModel; 
			} 
		}



		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			if (ViewModel == null)
				return;

			var viewControllers = new UIViewController[]
			{
				CreateTabFor("Dribbble", "icon_dribbble", HomeViewModel.Child1),
				CreateTabFor("Twitter", "icon_twitter", HomeViewModel.Child2),
				CreateTabFor("Apple", "icon_apple", HomeViewModel.Child3),
				CreateTabFor("GitHub", "icon_github", HomeViewModel.Child4),
			};

			ViewControllers = viewControllers;
			CustomizableViewControllers = new UIViewController[] { };
			SelectedViewController = ViewControllers[0];
		}

		private UIViewController CreateTabFor(string title, string imageName, IMvxViewModel viewModel)
		{
			var controller = new UINavigationController();
			var screen = this.CreateViewControllerFor(viewModel) as UIViewController;
			SetTitleAndTabBarItem(screen, title, imageName);
			controller.PushViewController(screen, false);
			return controller;
		}

		private void SetTitleAndTabBarItem(UIViewController screen, string title, string imageName)
		{
			screen.Title = title;
			screen.TabBarItem = new UITabBarItem(title, UIImage.FromBundle(@"TabBar/" + imageName + ".png"), _createdSoFarCount);
			_createdSoFarCount++;
		}
	}
}

