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
    public abstract class BaseView : MvxViewController
    {
        protected BaseView(string nibName, NSBundle bundle)
            : base(nibName, bundle)
        {}
    }
}