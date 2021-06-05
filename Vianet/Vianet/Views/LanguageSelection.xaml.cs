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
    public partial class LanguageSelection : Rg.Plugins.Popup.Pages.PopupPage
    {

        public LanguageSelection()
        {
            InitializeComponent();
            if (App.Current.Properties.ContainsKey("isEnglish"))
            {
                if (Application.Current.Properties["isEnglish"].ToString() == "1")
                {
                    englishFrame.BackgroundColor = (Color)Application.Current.Resources["MainColor"];
                    englishText.TextColor = (Color)Application.Current.Resources["MainColor"];
                    langColor.TextColor = Color.White;
                    nepaliFrame.BackgroundColor = Color.FromHex("#F7F2F2");
                    nepaliText.TextColor = Color.FromHex("#999999");
                    nepLang.TextColor = (Color)Application.Current.Resources["MainColor"];
                }
                else
                {
                    nepaliFrame.BackgroundColor = (Color)Application.Current.Resources["MainColor"];
                    nepaliText.TextColor = (Color)Application.Current.Resources["MainColor"];
                    nepLang.TextColor = Color.White;
                    englishFrame.BackgroundColor = Color.FromHex("#F7F2F2");
                    englishText.TextColor = Color.FromHex("#999999");
                    langColor.TextColor = (Color)Application.Current.Resources["MainColor"];
                }
            }
            
        }

        private void TapGestureRecognizer_Tapped_english(object sender, EventArgs e)
        {
            englishFrame.BackgroundColor = (Color)Application.Current.Resources["MainColor"];
            englishText.TextColor = (Color)Application.Current.Resources["MainColor"];
            langColor.TextColor = Color.White;

            nepaliFrame.BackgroundColor = Color.FromHex("#F7F2F2");
            nepaliText.TextColor = Color.FromHex("#999999");
            nepLang.TextColor = (Color)Application.Current.Resources["MainColor"];
            Application.Current.Properties["isEnglish"] = "1";
            MessagingCenter.Send(this, "Language", "English");
        }

        private void TapGestureRecognizer_Tapped_nepali(object sender, EventArgs e)
        {
            nepaliFrame.BackgroundColor = (Color)Application.Current.Resources["MainColor"];
            nepaliText.TextColor = (Color)Application.Current.Resources["MainColor"];
            nepLang.TextColor = Color.White;

            englishFrame.BackgroundColor = Color.FromHex("#F7F2F2");
            englishText.TextColor = Color.FromHex("#999999"); 
            langColor.TextColor = (Color)Application.Current.Resources["MainColor"];
            Application.Current.Properties["isEnglish"] = "0";
            MessagingCenter.Send(this, "Language", "नेपाली");

        }
    }
}