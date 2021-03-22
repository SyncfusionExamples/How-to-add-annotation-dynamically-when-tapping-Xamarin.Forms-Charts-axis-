using Syncfusion.SfChart.XForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ChartSample
{
    public partial class MainPage : ContentPage
    {
        List<string> imageSource = new List<string>();

       
        public MainPage()
        {
            InitializeComponent();
            imageSource.Add("Rice.jpg");
            imageSource.Add("Wheat.jpg");
            imageSource.Add("Ragi.jpg");
            imageSource.Add("Millet.jpg");
        }

        
        private void CategoryAxis_LabelClicked(object sender, Syncfusion.SfChart.XForms.LabelClickedEventArgs e)
        {
            chart.ChartAnnotations.Clear();

            ViewAnnotation viewAnnotation = new ViewAnnotation()
            {
                VerticalAlignment = ChartAnnotationAlignment.Start,
              
                View = new Image()
                {
                    Source = imageSource[(int)e.Position],
                    Aspect = Aspect.AspectFit,
                    HeightRequest = 90,
                    WidthRequest=90
                },

                X1 = e.Position,
                Y1 = (BindingContext as ViewModel).Data[(int)e.Position].YValue1

            };

            chart.ChartAnnotations.Add(viewAnnotation);

        }
    }
}
