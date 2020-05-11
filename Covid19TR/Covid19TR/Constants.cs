using System;
using Xamarin.Forms;

namespace Covid19TR
{
    public static class Constants
    {
        public static string AdUnitIdTest
        {
            get
            {
                switch (Device.RuntimePlatform)
                {
                    case Device.Android:
                        return "ca-app-pub-3940256099942544/6300978111";

                    case Device.iOS:
                        return "ca-app-pub-1832493294534276/9773706912";

                    default:
                        throw new InvalidOperationException("Invalid platform");
                }
            }
        }
    }
}
