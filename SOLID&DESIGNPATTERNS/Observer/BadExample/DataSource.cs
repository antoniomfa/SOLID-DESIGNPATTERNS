using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DESIGNPATTERNS.Observer.BadExample
{
    public class DataSource
    {
        private List<int> _values = new List<int>();
        private List<Object> _dependents = new List<Object>();

        public List<int> GetValues() { return _values; }

        public void SetValues(List<int> values)
        {
            this._values = values;

            foreach (var dependent in _dependents)
            {
                if (dependent is Sheet2 sheet2)
                {
                    (dependent as Sheet2).CalculateTotal(_values);
                }
                else if (dependent is BarChart)
                {
                    (dependent as BarChart).Render(values);
                }
            }
        }

        public void AddDependent(Object dependent)
        {
            _dependents.Add(dependent);
        }

        public void RemoveDependent(Object dependent)
        {
            _dependents.Remove(dependent);
        }
    }
}
