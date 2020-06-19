using SkiaChart;
using SkiaChart.Charts;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinChartTutorial.ViewModel {
    public class BarChartViewModel : ViewModelBase {

        public BarChartViewModel() {
            GridColor = SKColors.Blue;
            BarChart = new Chart<BarChart>(GenerateBarCharts());
        }

        private IEnumerable<BarChart> GenerateBarCharts() {
            var bar1 = new BarChart(GetXValues(), GetYValues(1)) {
                ChartColor = SKColors.Green,
                ChartName = "Random starting from 1"
            };
            var bar2 = new BarChart(GetXValues(), GetYValues(5)) {
                ChartColor = SKColors.Red,
                ChartName = "Random starting from 5"
            };
            var bar3 = new BarChart(GetXValues(), GetYValues(10)) {
                ChartColor = SKColors.Yellow,
                ChartName = "Random starting from 10"
            };
            return new List<BarChart> { bar1, bar2, bar3 };
        }

        public Chart<BarChart> BarChart { get; set; }
        public SKColor GridColor { get; set; }
    }
}
