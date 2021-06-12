using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace Vianet.Model
{
    class MenuModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public int value { get; set; }
        public Color TextColor { get; set; } = Color.FromHex("#999999");

        public Color TxtColor { get { return TextColor; } set { TextColor = value; NotifyPropertyChanged(); } }


        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
