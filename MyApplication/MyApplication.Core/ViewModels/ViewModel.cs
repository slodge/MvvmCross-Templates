using Cirrious.CrossCore;
using Cirrious.MvvmCross.ViewModels;
using MyApplication.Core.Services.Error;

namespace MyApplication.Core.ViewModels
{
    public abstract class ViewModel 
        : MvxViewModel
    {
        protected ViewModel()
        {
            AppTrace.Trace("Creating ViewModel : {0}", GetType().Name);
        }

        public void ReportError(string error)
        {
            Mvx.Resolve<IErrorService>().ReportError(error);
        }
    }
}