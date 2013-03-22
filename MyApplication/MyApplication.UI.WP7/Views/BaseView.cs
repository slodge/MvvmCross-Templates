using Cirrious.MvvmCross.WindowsPhone.Views;
using MyApplication.Core;

namespace MyApplication.UI.WP7.Views
{
    public class BaseView
        : MvxPhonePage
    {
        public BaseView()
        {
            AppTrace.Trace("Creating {0}", GetType().Name);
        }
    }
}