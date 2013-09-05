using System;
using Cirrious.MvvmCross.ViewModels;

namespace TwitterMVVM.Core.ViewModels
{
	public class HomeViewModel : MvxViewModel
	{
		private TableViewModel _child1;
		private TableViewModel _child2;
		private TableViewModel _child3;
		private TableViewModel _child4;



		public HomeViewModel()
		{
			Child1 = new TableViewModel();
			Child2 = new TableViewModel();
			Child3 = new TableViewModel();
			Child4 = new TableViewModel();
		}



		public TableViewModel Child1
		{
			get { return _child1; }
			set { _child1 = value; RaisePropertyChanged(() => Child1); }
		}

		public TableViewModel Child2
		{
			get { return _child2; }
			set { _child2 = value; RaisePropertyChanged(() => Child2); }
		}

		public TableViewModel Child3
		{
			get { return _child3; }
			set { _child3 = value; RaisePropertyChanged(() => Child3); }
		}

		public TableViewModel Child4
		{
			get { return _child4; }
			set { _child4 = value; RaisePropertyChanged(() => Child4); }
		}
	}
}

