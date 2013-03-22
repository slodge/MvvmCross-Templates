using MyApplication.Core;
using MyApplication.UI.WindowsStore.Common;

namespace MyApplication.UI.WindowsStore.Views
{
    public class BaseView : LayoutAwarePage
    {
        public BaseView()
        {
            AppTrace.Trace("Creating View {0}", GetType().Name);
        }
    }
}