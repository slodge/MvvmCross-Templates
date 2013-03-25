using System;
using System.Collections.Generic;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Binding.Touch;
using Cirrious.MvvmCross.Binding.Touch.Views;
using Cirrious.MvvmCross.Touch.Views;

using MyApplication.Core.ViewModels;

namespace MyApplication.UI.Touch
{
	public partial class HomeView : BaseView
	{
		public HomeView () : base ("HomeView", null)
		{
		}
				
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
			var tableSource = new MvxSimpleTableViewSource(ResultsTable, "SimpleItem");
			this.ResultsTable.Source = tableSource;

			this.Bind( KeyTextField, (HomeViewModel vm) => vm.Key );
			this.Bind( FetchButton, (HomeViewModel vm) => vm.FetchItemsCommand );
			this.Bind( tableSource, (HomeViewModel vm) => vm.Items );

			// alternative approach would be:
			//this.AddBindings (
			//	new Dictionary<object,string> ()
			//    {
			//		{ this.KeyTextField, "Text Key" },
			//		{ this.FetchButton, "TouchUpInside FetchItemsCommand" },
			//		{ tableSource, "ItemsSource Items" }
			//	});

			this.ResultsTable.ReloadData ();

			// UI only concerns
			this.FetchButton.TouchUpInside += (s,e) => ClearKeyboard(); 
			this.View.AddGestureRecognizer(new UITapGestureRecognizer(ClearKeyboard));
		}

		private void ClearKeyboard()
		{
			KeyTextField.ResignFirstResponder();
		}
	}
}
