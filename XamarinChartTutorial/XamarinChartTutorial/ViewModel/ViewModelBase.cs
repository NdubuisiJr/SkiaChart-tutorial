using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinChartTutorial.ViewModel {
    public abstract class ViewModelBase {
        protected IEnumerable<string> GetXValues() {
            for (int i = 0; i <= 7; i++) {
                yield return $"{i} value";
            }
        }

        protected IEnumerable<float> GetXValues(int upperlimit=15) {
            for (int i = 0; i <= upperlimit; i++) {
                yield return i + 1;
            }
        }

        protected IEnumerable<float> GetYValues(int lowerLimit,int upperLimit=15) {
            var rand = new Random();
            for (int i = 0; i <= upperLimit; i++) {
                yield return upperLimit - ((1 - (float)rand.NextDouble()) * 
                    (upperLimit - lowerLimit));
            }
        }
    }
}
