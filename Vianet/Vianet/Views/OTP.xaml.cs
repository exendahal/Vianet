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
    public partial class OTP:  Rg.Plugins.Popup.Pages.PopupPage
    {
        public OTP()
        {
            InitializeComponent();
        }

        private async void TapGestureRecognizer_Tapped_Next(object sender, System.EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new HomePage());
            await PopupNavigation.Instance.PopAllAsync();
        }
    }
}