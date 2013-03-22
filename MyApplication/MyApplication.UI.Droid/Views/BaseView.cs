using Cirrious.MvvmCross.Droid.Views;
using MyApplication.Core;

namespace MyApplication.UI.Droid.Views
{
    public abstract class BaseView
        : MvxActivity
    {
        protected BaseView()
        {
            AppTrace.Trace("View created {0}", GetType().Name);
        }
    }
}