using Cirrious.MvvmCross.Plugins.Messenger;
using MyApplication.Core.Messages;

namespace MyApplication.Core.Services.Error
{
    public class ErrorService
        : IErrorService
    {
        private readonly IMvxMessenger _messenger;

        public ErrorService(IMvxMessenger messenger)
        {
            _messenger = messenger;
        }

        public void ReportError(string errorMessage)
        {
            AppTrace.Trace("Error reported: {0}", errorMessage);
            _messenger.Publish(new ErrorMessage(this, errorMessage));
        }
    }
}