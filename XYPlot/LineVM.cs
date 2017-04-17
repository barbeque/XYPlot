using LiveCharts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace XYPlot
{
    class LineVM
    {
        public Func<double, string> DollarFormatter { get; private set; }
        public Func<double, string> SecondLookupFormatter { get; private set; } // Provide the mapping to go from the index of the x-axis to the actual human-readable value...

        public List<double> Seconds { get; private set; }

        public ChartValues<double> Sales { get; private set; }

        public LineVM()
        {
            DollarFormatter = (dollars) => dollars.ToString("C");
            SecondLookupFormatter = (index) => Seconds.ElementAt((int)index).ToString();

            Seconds = new List<double> {
                // Demonstrate the lookup values for the x-axis, one per index
                10, 25, 300, 450
            };

            // Add actual values, one per index
            Sales = new ChartValues<double>();
            Sales.Add(0);
            Sales.Add(100);
            Sales.Add(400);
            Sales.Add(1000);            
        }
    }
}
