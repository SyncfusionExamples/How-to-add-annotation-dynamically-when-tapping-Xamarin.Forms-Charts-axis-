using Syncfusion.SfChart.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ChartSample
{
    public class ChartModel
    {
        public string XValue { get; set; }

        public double YValue1 { get; set; }
    
    }
    public class ViewModel
    {
        public ObservableCollection<ChartModel> Data { get; set; }

        public ViewModel()
        {
            Data = new ObservableCollection<ChartModel>();

            Data.Add(new ChartModel() { XValue = "Yeild 1", YValue1 = 12 });
            Data.Add(new ChartModel() { XValue = "Yeild 2", YValue1 = 34 });
            Data.Add(new ChartModel() { XValue = "Yeild 3", YValue1 = 23 });
            Data.Add(new ChartModel() { XValue = "Yeild 4", YValue1 = 15 });

        }
    }
}
