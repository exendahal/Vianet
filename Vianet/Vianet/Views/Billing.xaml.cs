using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vianet.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Vianet.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Billing : ContentPage
    {
        public Billing()
        {
            BindingContext = this;
            InitializeComponent();
            createCOllection();
        }

        void createCOllection()
        {
            List<GenericModel> source = new List<GenericModel>();
            source.Add(new GenericModel() { item1 = "\uf11d", item2 = "Mobile", item3 = "Iphone X", item4 = "9518 6253 1223 00XC" });
            source.Add(new GenericModel() { item1 = "\uf324", item2 = "Laptop", item3 = "Mac Book Pro", item4 = "9518 6253 1223 00XC" });
            source.Add(new GenericModel() { item1 = "\uf502", item2 = "TV", item3 = "LG C8", item4 = "9518 6253 1223 00XC" });
            source.Add(new GenericModel() { item1 = "\uf896", item2 = "Watch", item3 = "I Watch", item4 = "9518 6253 1223 00XC" });
            BindableLayout.SetItemsSource(BindCollection, source);
            list.ItemsSource = source;
            list2.ItemsSource = source;
        }
    }
}