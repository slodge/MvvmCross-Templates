using Android.App;
using MyApplication.Core.ViewModels;

namespace MyApplication.UI.Droid.Views
{
    [Activity]
    public class HomeView
        : BaseView
    {
        public new HomeViewModel ViewModel
        {
            get { return (HomeViewModel)base.ViewModel;  }
            set { base.ViewModel = value; }
        }

        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.Page_HomeView);
        }
    }
}