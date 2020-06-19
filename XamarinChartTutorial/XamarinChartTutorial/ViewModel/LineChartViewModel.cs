using SkiaChart;
using SkiaChart.Charts;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace XamarinChartTutorial.ViewModel {
    public class LineChartViewModel : ViewModelBase {
        public LineChartViewModel() {
            GridColor = SKColors.Blue;
            LineChart = new Chart<LineChart>(GenerateLineChart());
        }

        private IEnumerable<LineChart> GenerateLineChart() {
            var line1 = new LineChart(GetXValues(500), GetYValues(100, 500).OrderBy(x=>x)) {
                ChartName = "Line chart 1",
                ChartColor = SKColors.Red,
                ShowPoints = true
            };
            var line2 = new LineChart(GetXValues(500), GetYValues(10, 500).OrderByDescending(x=>x)) {
                ChartName = "Line chart 2",
                ChartColor = SKColors.Green,
                ShowPoints = true
            };
            var line3 = new LineChart(GetXValues(500), GetYValues(300, 500).OrderBy(x=>x)) {
                ChartName = "Line chart 1",
                ChartColor = SKColors.Yellow,
                ShowPoints = true
            };
            return new List<LineChart> { line1, line2, line3 };
        }

        public Chart<LineChart> LineChart { get; set; }
        public SKColor GridColor { get; set; }
    }
}
