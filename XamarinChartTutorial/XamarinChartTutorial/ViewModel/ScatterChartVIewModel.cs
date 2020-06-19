using SkiaChart;
using SkiaChart.Charts;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinChartTutorial.ViewModel {
    public class ScatterChartVIewModel : ViewModelBase {
        public ScatterChartVIewModel() {
            GridColor = SKColors.Blue;
            ScatterChart = new Chart<ScatterChart>(GenerateSCatterChart());
        }

        private IEnumerable<ScatterChart> GenerateSCatterChart() {
            var scatterChart1 = new ScatterChart(GetXValues(10), GetYValues(2, 10)) {
                ChartColor = SKColors.Red,
                ChartName = "Scatter Chart 1",
                IsStroked = true
            };
            var scatterChart2 = new ScatterChart(GetXValues(10), GetYValues(8, 10)) {
                ChartColor = SKColors.Green,
                ChartName = "Scatter Chart 2",
                IsStroked = false
            };
            var scatterChart3 = new ScatterChart(GetXValues(10), GetYValues(2, 10)) {
                ChartColor = SKColors.Yellow,
                ChartName = "Scatter Chart 3",
                IsStroked = true
            };

            return new List<ScatterChart> { scatterChart1, scatterChart2, scatterChart3 };
        }

        public Chart<ScatterChart> ScatterChart { get; set; }
        public SKColor GridColor { get; set; }
    }
}
