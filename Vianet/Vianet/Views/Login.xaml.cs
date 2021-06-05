
using Rg.Plugins.Popup.Extensions;
using Xamarin.Forms.Xaml;

namespace Vianet.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : Rg.Plugins.Popup.Pages.PopupPage
    {
        public Login()
        {
            InitializeComponent();
            
        }
       
        private async void TapGestureRecognizer_Tapped_Next(object sender, System.EventArgs e)
        {
            await Navigation.PushPopupAsync(new OTP());
        }
    }
}