using System;
using Cirrious.MvvmCross.Binding.Touch.Views;
using MonoTouch.Foundation;
using System.Collections.Generic;
using Cirrious.MvvmCross.Binding.Touch;
using Cirrious.MvvmCross.Binding.BindingContext;

namespace MyApplication.UI.Touch
{
	[Register("SimpleItem")]
	public partial class SimpleItem : MvxTableViewCell
	{
		public SimpleItem (IntPtr handle)
			: base(handle)
		{
			this.DelayBind(() => 
				this.AddBindings (
							new Dictionary<object, string>() {
							{ this.TextLabel, "Text Title" },
							{ this.BodyLabel, "Text Notes" },
							{ this.DateLabel, "Text When,Converter=TimeAgo" },
						}));
		}
	}
}

