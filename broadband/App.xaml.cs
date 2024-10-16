using System.Globalization;
using broadband.Helper;
using broadband.Views;

namespace broadband
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            if (Preferences.ContainsKey("isEnglish"))
            {
                if (Preferences.Get("isEnglish","0").ToString() == "1")
                {
                    LocalizationResourceManager.Instance.SetCulture(CultureInfo.GetCultureInfo("ne"));
                }
                else
                {
                    LocalizationResourceManager.Instance.SetCulture(CultureInfo.GetCultureInfo("en"));

                }
            }
            MainPage = new WelcomePage();
        }
    }
}
