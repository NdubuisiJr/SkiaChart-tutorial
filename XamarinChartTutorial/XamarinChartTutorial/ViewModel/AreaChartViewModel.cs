using SkiaChart;
using SkiaChart.Charts;
using SkiaSharp;
using System;
using System.Collections.Generic;

namespace XamarinChartTutorial.ViewModel {
    public class AreaChartViewModel : ViewModelBase {
        public AreaChartViewModel() {
            GridColor = SKColors.Blue;
            AreaChart = new Chart<AreaChart>(GenerateAreaChart());
        }

        private IEnumerable<AreaChart> GenerateAreaChart() {
            var area1 = new AreaChart(GetXValues(20), GetYValues(10, 20)) {
                ChartColor = SKColors.Red,
                ChartName = "Area 1",
                ShowPoints = false
            };
            var area2 = new AreaChart(GetXValues(20), GetYValues(10, 20)) {
                ChartColor = SKColors.Green,
                ChartName = "Area 2",
                ShowPoints = true
            };
            var area3 = new AreaChart(GetXValues(20), GetYValues(10, 20)) {
                ChartColor = SKColors.Yellow,
                ChartName = "Area 3",
                ShowPoints = false
            };

            return new List<AreaChart> { area1, area2, area3 };
        }

        public Chart<AreaChart> AreaChart { get; set; }
        public SKColor GridColor { get; set; }
    }
}
