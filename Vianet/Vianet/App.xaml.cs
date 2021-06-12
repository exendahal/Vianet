using System;
using System.Globalization;
using System.Threading;
using Vianet.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Vianet
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            if (App.Current.Properties.ContainsKey("isEnglish"))
            {
                if (Application.Current.Properties["isEnglish"].ToString() == "1")
                {
                    CultureInfo cultureInfo = new CultureInfo("en-US");
                    Thread.CurrentThread.CurrentUICulture = cultureInfo;
                }
                else
                {
                    CultureInfo cultureInfo = new CultureInfo("ne-NP");
                    Thread.CurrentThread.CurrentUICulture = cultureInfo;
                }
            }
                
            
            MainPage = new WelcomePage();
           // MainPage = new MainPage();
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
