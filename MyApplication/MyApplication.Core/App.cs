using Cirrious.CrossCore.IoC;
using Cirrious.MvvmCross.ViewModels;
using MyApplication.Core.Services.Error;
using MyApplication.Core.Services.First;
using MyApplication.Core.ViewModels;

namespace MyApplication.Core
{
    public class App
        : MvxApplication
    {
        public override void Initialize()
        {
            AppTrace.Trace("App initializing");
            base.Initialize();

            InitialisePlugins();
            InitaliseServices();
            InitialiseStartNavigation();

            AppTrace.Trace("App initialization complete");
        }

        private void InitialisePlugins()
        {
            AppTrace.Trace("Initialising plugins");
            // initialise any plugins where are required at app startup
            // e.g. Cirrious.MvvmCross.Plugins.Visibility.PluginLoader.Instance.EnsureLoaded();
            Cirrious.MvvmCross.Plugins.Messenger.PluginLoader.Instance.EnsureLoaded();
        }

        private void InitaliseServices()
        {
            AppTrace.Trace("Initialising services");
            InitaliseErrorReporting();
            InitialiseFirstService();
        }

        private void InitaliseErrorReporting()
        {
            var errorService = Mvx.IocConstruct<ErrorService>();
            Mvx.RegisterSingleton<IErrorService>(errorService);
        }

        private static void InitialiseFirstService()
        {
            Mvx.RegisterSingleton<IFirstService>(new FirstService());
        }

        private void InitialiseStartNavigation()
        {
            AppTrace.Trace("Initialising start navigation");
            Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<HomeViewModel>());
        }
    }
}
