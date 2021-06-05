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
        }
    }
}