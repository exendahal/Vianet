using System;
using System.Globalization;
using System.Threading;
using Vianet.Helper;
using Vianet.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Vianet
{
    public partial class App : Application
    {
        public App()
        {
            if (App.Current.Properties.ContainsKey("isEnglish"))
            {
                if (Application.Current.Properties["isEnglish"].ToString() == "1")
                {
                    LocalizationResourceManager.Instance.SetCulture(CultureInfo.GetCultureInfo("en"));
                }
                else
                {
                    LocalizationResourceManager.Instance.SetCulture(CultureInfo.GetCultureInfo("ne"));

                }
            }
            InitializeComponent();           
            MainPage = new WelcomePage();
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
