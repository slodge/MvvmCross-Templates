using System.Windows;
using Cirrious.CrossCore.IoC;
using Cirrious.MvvmCross.Plugins.Messenger;
using MyApplication.Core.Messages;

namespace MyApplication.UI.WP7
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
            MessageBox.Show(message.Message, "Sorry!", MessageBoxButton.OK);
        }
    }
}