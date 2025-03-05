using SOLID_DESIGNPATTERNS.Observer.BadExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DESIGNPATTERNS.Observer.GoodExample
{
    public class DataSourceGood : Subject
    {
        private List<int> _values = new List<int>();

        public List<int> GetValues() { return _values; }

        public void SetValues(List<int> values)
        {
            this._values = values;

            NotifyObservers();
        }
    }
}
