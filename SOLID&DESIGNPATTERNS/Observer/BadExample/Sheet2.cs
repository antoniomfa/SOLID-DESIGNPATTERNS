using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DESIGNPATTERNS.Observer.BadExample
{
    public class Sheet2
    {
        private int _total;

        public Sheet2()
        {
            
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
