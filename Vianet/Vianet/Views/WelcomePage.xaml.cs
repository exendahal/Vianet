using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Vianet.Helper;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Vianet.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
            if (App.Current.Properties.ContainsKey("isEnglish"))
            {
                if (Application.Current.Properties["isEnglish"].ToString() == "1")
                {
                    DefaultLanguage.Text = "English";
                }
                else
                {
                    DefaultLanguage.Text = "नेपाली";

                }
            }
        }

        private async void TapGestureRecognizer_Tapped_language(object sender, EventArgs e)
        {
            await Navigation.PushPopupAsync(new LanguageSelection());
            MessagingCenter.Subscribe<LanguageSelection, string>(this, "Language",
               async (page, data) =>
               {

                   DefaultLanguage.Text = data;
                   if (Application.Current.Properties["isEnglish"].ToString() == "1")
                   {
                       LocalizationResourceManager.Instance.SetCulture(CultureInfo.GetCultureInfo("en"));
                   }
                   else
                   {
                       LocalizationResourceManager.Instance.SetCulture(CultureInfo.GetCultureInfo("ne"));
                   }
                   
                   await PopupNavigation.Instance.PopAsync();
                   MessagingCenter.Unsubscribe<LanguageSelection, string>(this, "Language");


               });
        }

        private async void TapGestureRecognizer_Tapped_Login(object sender, EventArgs e)
        {
            await Navigation.PushPopupAsync(new Login());
        }
    }
}