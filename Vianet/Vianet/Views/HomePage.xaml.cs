using Newtonsoft.Json;
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
    public partial class HomePage : ContentPage
    {
        public ICommand TapCommand { get; set; }
        
        public HomePage()
        {
            BindingContext = this;
            InitializeComponent();
            addCommand();
            createCOllection();
            var chartConfigScript = GetChartScript();
            var html = GetHtmlWithChartConfig(chartConfigScript);
            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = html;
            graph.Source = htmlSource;
        }
         void addCommand()
        {

            TapCommand = new Command<GenericModel>(async items =>
            {
                await DisplayAlert("Disconnected", items.item3+" has been disconnected", "OK");
            });

            }
        void createCOllection()
        {
            List<GenericModel> source = new List<GenericModel>();
            source.Add(new GenericModel() { item1 = "\uf11d", item2 = "Mobile", item3 = "Iphone X",item4= "9518 6253 1223 00XC" });
            source.Add(new GenericModel() { item1 = "\uf324", item2 = "Laptop", item3 = "Mac Book Pro", item4= "9518 6253 1223 00XC" });
            source.Add(new GenericModel() { item1 = "\uf502", item2 = "TV", item3 = "LG C8", item4= "9518 6253 1223 00XC" });
            source.Add(new GenericModel() { item1 = "\uf896", item2 = "Watch", item3 = "I Watch", item4= "9518 6253 1223 00XC" });
            BindableLayout.SetItemsSource(BindCollection,source);
        }

        private void TapGestureRecognizer_Tapped_datePickerFocus(object sender, EventArgs e)
        {
            datePicker.Focus();
        }

        private string GetHtmlWithChartConfig(string chartConfig)
        {
            var inlineStyle = "style=\"width:100%;height:100%;\"";
            var chartJsScript = "<script src=\"https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.7.1/Chart.bundle.min.js\"></script>";
            var chartConfigJsScript = $"<script>{chartConfig}</script>";
            var chartContent = $@"<div id=""chart-container"" {inlineStyle}>
  <canvas id=""chart"" />
</div>";
            var document = $@"<html style=""width:97%;height:100%;"">
  <head>{chartJsScript}</head>
  <body {inlineStyle}>
    {chartContent}
    {chartConfigJsScript}
  </body>
</html>";
            return document;
        }

        private string GetChartScript()
        {
            var chartConfig = GetSpendingChartConfig();
            var script = $@"var config = {chartConfig};
window.onload = function() {{
  var canvasContext = document.getElementById(""chart"").getContext(""2d"");
  new Chart(canvasContext, config);
}};";
            return script;
        }

        private string GetSpendingChartConfig()
        {
            var config = new
            {
                type = "doughnut",
                data = GetPieChartData(),
                options = new
                {
                    responsive = true,
                    maintainAspectRatio = false,
                    //legend = new
                    //{
                    //    position = "top"
                    //},
                    animation = new
                    {
                        animateScale = true
                    }
                }
            };
            var jsonConfig = JsonConvert.SerializeObject(config);
            return jsonConfig;
        }

        private object GetPieChartData()
        {
            var colors = GetDefaultColors();
            var labels = new[] { "Gone", "Remaining" };
           // var randomGen = new Random();
            var dataPoints = new[] { 325, 40 };
            var data = new
            {
                datasets = new[]
                {
                    new
                    {                        
                        data = dataPoints,
                        backgroundColor = dataPoints.Select((d, i) =>
                        {
                            var color = colors[i % colors.Count];
                            return $"rgb({color.Item1},{color.Item2},{color.Item3})";
                        })
                    }
                },
                //labels
            };
            return data;
        }

        private List<Tuple<int, int, int>> GetDefaultColors()
        {
            return new List<Tuple<int, int, int>>
            {
                new Tuple<int, int, int>(236,28,36),
                new Tuple<int, int, int>(247,246,251)
               
            };
        }
    }
}