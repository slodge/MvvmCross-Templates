using MyApplication.Core;
using MyApplication.UI.WindowsStore.Common;

namespace MyApplication.UI.WindowsStore.Views
{
    public abstract class BaseView : LayoutAwarePage
    {
        protected BaseView()
        {
            AppTrace.Trace("Creating View {0}", GetType().Name);
        }
    }
}