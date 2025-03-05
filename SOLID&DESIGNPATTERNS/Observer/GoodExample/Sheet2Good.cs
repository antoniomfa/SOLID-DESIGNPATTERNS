using SOLID_DESIGNPATTERNS.Observer.BadExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DESIGNPATTERNS.Observer.GoodExample
{
    public class Sheet2Good : IObserver
    {
        private int _total;
        private DataSourceGood _dataSource;

        public Sheet2Good(DataSourceGood dataSource)
        {
            _dataSource = dataSource;
        }

        public void Update()
        {
            _total = CalculateTotal(_dataSource.GetValues());
        }

        public int GetTotal()
        {
            return _total;
        }

        public int CalculateTotal(List<int> values)
        {
            var sum = 0;

            foreach (var value in values)
            {
                sum += value;
            }

            Console.WriteLine("Total: " + sum + "\n");

            return sum;
        }
    }
}
