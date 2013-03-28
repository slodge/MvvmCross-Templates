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
			ResultsTable.RowHeight = 69;
			this.ResultsTable.Source = tableSource;

			this.CreateBinding( KeyTextField).To((HomeViewModel vm) => vm.Key ).Apply();
			this.CreateBinding( FetchButton).To( (HomeViewModel vm) => vm.FetchItemsCommand ).Apply();
			this.CreateBinding( tableSource).To( (HomeViewModel vm) => vm.Items ).Apply();

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
