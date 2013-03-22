using Cirrious.CrossCore.IoC;
using Cirrious.MvvmCross.Plugins.Messenger;
using MyApplication.Core.Messages;
using Windows.UI.Popups;

namespace MyApplication.UI.WindowsStore
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
            var dialog = new MessageDialog(message.Message);
            dialog.ShowAsync();
        }
    }
}