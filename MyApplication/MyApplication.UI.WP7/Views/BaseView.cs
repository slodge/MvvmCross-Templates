using Cirrious.MvvmCross.WindowsPhone.Views;
using MyApplication.Core;

namespace MyApplication.UI.WP7.Views
{
    public abstract class BaseView
        : MvxPhonePage
    {
        protected BaseView()
        {
            AppTrace.Trace("Creating {0}", GetType().Name);
        }
    }
}