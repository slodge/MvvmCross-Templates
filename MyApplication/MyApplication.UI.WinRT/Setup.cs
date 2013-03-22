using Cirrious.MvvmCross.ViewModels;
using Cirrious.MvvmCross.WindowsStore.Platform;
using Windows.UI.Xaml.Controls;

namespace MyApplication.UI.WindowsStore
{
    public class Setup
        : MvxStoreSetup
    {
        public Setup(Frame rootFrame)
            : base(rootFrame)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            var app = new MyApplication.Core.App();
            return app;
        }

        protected override void InitializeLastChance()
        {
            var errorDisplayer = new ErrorDisplay();
            base.InitializeLastChance();
        }
    }
}
