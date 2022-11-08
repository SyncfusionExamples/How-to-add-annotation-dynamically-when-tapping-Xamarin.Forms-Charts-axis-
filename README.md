# How to notify when clicking the axis label of Xamarin.Forms Charts

In [Xamarin.Forms Chart](https://help.syncfusion.com/xamarin/charts/getting-started), the major division has been marked by axis labels. It provides support to notify an action while clicking that. Here, using that support, we are going to add an image [annotation](https://help.syncfusion.com/xamarin/charts/chartannotation) on the segment position as shown below.

![Notify Xamarin.Forms Axis label click](https://github.com/SyncfusionExamples/How-to-notify-when-clicking-the-axis-label-of-Xamarin.Forms-Charts/blob/main/Axis_Label_Clicked.gif)

This has been achieved by using the [LabelClicked](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.ChartAxis.html#Syncfusion_SfChart_XForms_ChartAxis_LabelClicked) of the chart’s axis. It has been invoked when the axis label is clicked. It has arguments like [LabelContent](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.LabelClickedEventArgs.html#Syncfusion_SfChart_XForms_LabelClickedEventArgs_LabelContent) and [Position](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.LabelClickedEventArgs.html#Syncfusion_SfChart_XForms_LabelClickedEventArgs_Position). By adding the annotation on its corresponding position as shown in the following code sample.

```
<syncfusion:SfChart x:Name="chart" HorizontalOptions="FillAndExpand" VerticalOptions="FillAndExpand">
    <syncfusion:SfChart.Title>
        <syncfusion:ChartTitle Text="CROP YEILD FORECASTING" FontAttributes="Bold"/>
    </syncfusion:SfChart.Title>
    <syncfusion:SfChart.PrimaryAxis>
        <syncfusion:CategoryAxis  LabelClicked="CategoryAxis_LabelClicked"/>
    </syncfusion:SfChart.PrimaryAxis>
    <syncfusion:SfChart.SecondaryAxis>
        <syncfusion:NumericalAxis Minimum="0" Maximum="50"/>
    </syncfusion:SfChart.SecondaryAxis>
    <syncfusion:ColumnSeries Color="#bcdbb7" ItemsSource="{Binding Data}" XBindingPath="XValue" YBindingPath="YValue1"/>
</syncfusion:SfChart>
```

```
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
            WidthRequest = 90
        },

        X1 = e.Position,
        Y1 = (BindingContext as ViewModel).Data[(int)e.Position].YValue1

    };

    chart.ChartAnnotations.Add(viewAnnotation);
}
```

**KB article** - [How to notify when clicking the axis label of Xamarin.Forms Charts](https://www.syncfusion.com/kb/12487/how-to-notify-when-clicking-the-axis-label-of-xamarin-forms-charts)

## See also

[How to customize the axis label format based on the culture in Xamarin.Forms Charts](https://www.syncfusion.com/kb/11289/how-to-customize-the-axis-label-format-based-on-the-culture-in-xamarin-forms-chart-sfchart)

[How to view corner segments without cutting in the edge of Xamarin.Forms Charts](https://www.syncfusion.com/kb/10785/how-to-view-corner-segments-without-cutting-in-edge-of-xamarin-forms-chart)

[How to replace the axis labels with an image in Xamarin.Forms Charts](https://www.syncfusion.com/kb/10676/how-to-replace-the-axis-labels-with-image-in-xamarin-forms-chart)
