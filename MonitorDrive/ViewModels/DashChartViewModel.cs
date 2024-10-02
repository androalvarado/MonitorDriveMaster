using CommunityToolkit.Mvvm.ComponentModel;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using Color = Microsoft.Maui.Graphics.Color;

namespace MonitorDrive.ViewModels;

    public partial class DashChartViewModel : ObservableObject
    {
    public ISeries[] Series { get; set; } =
        {
        new ColumnSeries<double> {
            IsHoverable = false, // disables the colum tooltips 
            Values = new double[] { 85, 85, 85, 85, 85, 85, 85 },
            Stroke = null,
            Fill = new SolidColorPaint(new SKColor(30, 30, 30, 30)),
            IgnoresBarPosition = true,
            MaxBarWidth = 30
        },
        new ColumnSeries<double>
        {
            DataLabelsSize = 16,
            DataLabelsPaint = new SolidColorPaint(SKColors.Blue),
            DataLabelsPosition = LiveChartsCore.Measure.DataLabelsPosition.Top,
            
            IsHoverable = false, // disables the colum tooltips 
           Values = new ObservableCollection<double>{ 75, 77, 79, 83, 81.5, 80, 83 },
            Stroke = null,
            Fill = new SolidColorPaint(new SKColor(112, 63, 243)), //Valores RGB para #703FF3
            IgnoresBarPosition = true,
            MaxBarWidth = 30
        },        
        new LineSeries<int>
                {
                    Values = new int[] { 38, 38, 40, 41, 40, 40, 41 },
                    Fill = new SolidColorPaint(SKColors.Transparent),
                    Stroke = new SolidColorPaint(SKColors.LightBlue) { StrokeThickness = 5 },
                    GeometryStroke = new SolidColorPaint(SKColors.Transparent) { StrokeThickness = 4 },
                    GeometryFill = new SolidColorPaint(SKColors.Transparent) { StrokeThickness = 4 },
                    
                },
    };

    public Axis[] YAxes { get; set; } =
    {
            new Axis { MinLimit = 0, MaxLimit = 100 }
    };

    public Axis[] XAxes { get; set; } =
    {
            new Axis {Name = "weeks",
                MinLimit = -0.5,
                MaxLimit = 7,
            Labels = ["-6", "-5", "-4", "-3","-2","-1","0"] }            
    };
}


