using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Covid19TR
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjU0NDI2QDMxMzgyZTMxMmUzMFJlL2l0bVZjeFJUczEwc0xabjZNbzFQSzFHYUQzaTNyRUdTNytxRitwdGc9");
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
