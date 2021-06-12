using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Vianet.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Vianet.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Billing : ContentPage
    {
        List<MenuModel> source_menu = new List<MenuModel>();
        public ICommand TapCommandMenu { get; set; }

        List<GenericModel> source_Popular = new List<GenericModel>();
        List<GenericModel> source_Plans = new List<GenericModel>();
        public Billing()
        {
            BindingContext = this;
            InitializeComponent();
            createCOllection();
            addCommand();
        }

        void addCommand()
        {
            TapCommandMenu = new Command<MenuModel>(items =>
            {
                int value = items.value;
                BindableLayout.SetItemsSource(BindCollection, source_Plans.Where(x => x.item5.Equals(items.value)));
                foreach (var item in source_menu)
                {
                    if (item.value == items.value)
                    {
                        item.TxtColor = Color.FromHex("#D6001B");
                    }
                    else
                    {
                        item.TxtColor = Color.FromHex("#999999");
                    }
                }

                
            });

        
        }
        void createCOllection()
        {
            
           

            source_Plans.Add(new GenericModel() { item1 = "20", item2 = "Unlimited", item3 = "30",item4="1450",item5=1 });
            source_Plans.Add(new GenericModel() { item1 = "30", item2 = "Unlimited", item3 = "30", item4 = "1640", item5 = 1 });
            source_Plans.Add(new GenericModel() { item1 = "40", item2 = "Unlimited", item3 = "30", item4 = "1850", item5 = 1 });
            source_Plans.Add(new GenericModel() { item1 = "60", item2 = "Unlimited", item3 = "30", item4 = "2400", item5 = 1 });


            source_Plans.Add(new GenericModel() { item1 = "20", item2 = "Unlimited", item3 = "90", item4 = "4200", item5 = 3 });
            source_Plans.Add(new GenericModel() { item1 = "30", item2 = "Unlimited", item3 = "90", item4 = "4850", item5 = 3 });
            source_Plans.Add(new GenericModel() { item1 = "40", item2 = "Unlimited", item3 = "90", item4 = "5400", item5 = 3 });
            source_Plans.Add(new GenericModel() { item1 = "60", item2 = "Unlimited", item3 = "90", item4 = "7100", item5 = 3 });

            source_Plans.Add(new GenericModel() { item1 = "20", item2 = "Unlimited", item3 = "180", item4 = "8300", item5 = 6 });
            source_Plans.Add(new GenericModel() { item1 = "30", item2 = "Unlimited", item3 = "180", item4 = "9600", item5 = 6 });
            source_Plans.Add(new GenericModel() { item1 = "40", item2 = "Unlimited", item3 = "180", item4 = "10600", item5 = 6 });
            source_Plans.Add(new GenericModel() { item1 = "60", item2 = "Unlimited", item3 = "180", item4 = "14000", item5 = 6 });

            source_Plans.Add(new GenericModel() { item1 = "20", item2 = "Unlimited", item3 = "365", item4 = "16500", item5 = 12 });
            source_Plans.Add(new GenericModel() { item1 = "30", item2 = "Unlimited", item3 = "365", item4 = "19000", item5 = 12});
            source_Plans.Add(new GenericModel() { item1 = "40", item2 = "Unlimited", item3 = "365", item4 = "21000", item5 = 12 });
            source_Plans.Add(new GenericModel() { item1 = "60", item2 = "Unlimited", item3 = "365", item4 = "27000", item5 = 12 });


            source_Popular.Add(new GenericModel() { item1 = "20", item2 = "Unlimited", item3 = "30" });
            source_Popular.Add(new GenericModel() { item1 = "30", item2 = "Unlimited", item3 = "90" });
            source_Popular.Add(new GenericModel() { item1 = "40", item2 = "Unlimited", item3 = "30" });
            source_Popular.Add(new GenericModel() { item1 = "60", item2 = "Unlimited", item3 = "60" });

            source_menu.Add(new MenuModel() { value = 1,TextColor=Color.FromHex("#D6001B") });
            source_menu.Add(new MenuModel() { value = 3, TextColor = Color.FromHex("#999999") });
            source_menu.Add(new MenuModel() { value = 6, TextColor = Color.FromHex("#999999") });
            source_menu.Add(new MenuModel() { value = 12, TextColor = Color.FromHex("#999999") });
            
            BindableLayout.SetItemsSource(BindCollection, source_Plans.Where(x => x.item5.Equals(1)));
            list.ItemsSource = source_Popular;
            list2.ItemsSource = source_menu;
        }
    }
}