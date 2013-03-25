using Android.App;
using MyApplication.Core.ViewModels;

namespace MyApplication.UI.Droid.Views
{
    [Activity]
    public class HomeView
        : BaseView
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.Page_HomeView);
        }
    }
}