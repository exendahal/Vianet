using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Vianet.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
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
               async(page, data) =>
               {

                   DefaultLanguage.Text = data;
                   await PopupNavigation.Instance.PopAsync();
                   MessagingCenter.Unsubscribe<LanguageSelection, string>(this, "Language");

               });
        }
    }
}