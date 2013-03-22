using Cirrious.CrossCore.IoC;
using Cirrious.MvvmCross.ViewModels;
using MyApplication.Core.Services.Error;

namespace MyApplication.Core.ViewModels
{
    public class BaseViewModel 
        : MvxViewModel
    {
        public BaseViewModel()
        {
            AppTrace.Trace("Creating ViewModel : {0}", GetType().Name);
        }

        public void ReportError(string error)
        {
            Mvx.Resolve<IErrorService>().ReportError(error);
        }
    }
}