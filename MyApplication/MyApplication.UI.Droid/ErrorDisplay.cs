using Android.App;
using Cirrious.CrossCore.Droid.Platform;
using Cirrious.CrossCore.IoC;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Plugins.Messenger;
using MyApplication.Core.Messages;

namespace MyApplication.UI.Droid
{
    public class ErrorDisplay
    {
        private readonly MvxSubscriptionToken _subscription;

        public ErrorDisplay()
        {
            var messenger = Mvx.Resolve<IMvxMessenger>();
            _subscription = messenger.SubscribeOnMainThread<ErrorMessage>(ShowError, MvxReference.Strong );
        }

        private void ShowError(ErrorMessage message)
        {
            var activity = Mvx.Resolve<IMvxAndroidCurrentTopActivity>().Activity as IMvxBindingContextOwner;
            if (activity == null)
            {
                return;
            }
            var alertDialog = new AlertDialog.Builder((Activity)activity).Create();
            alertDialog.SetTitle("Sorry!");
            alertDialog.SetMessage(message.Message);
            alertDialog.SetButton("OK", (sender, args) => {});
            alertDialog.Show();
        }
    }
}