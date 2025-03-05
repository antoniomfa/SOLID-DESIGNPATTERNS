using SOLID_DESIGNPATTERNS.Observer.BadExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DESIGNPATTERNS.Observer.GoodExample
{
    public class BarChartGood : IObserver
    {
        private DataSourceGood _dataSource;

        public BarChartGood(DataSourceGood dataSource)
        {
            _dataSource = dataSource;
        }

        public void Update()
        {
            Console.WriteLine("Rendering bar chart with new values... \n");
        }
    }
}
