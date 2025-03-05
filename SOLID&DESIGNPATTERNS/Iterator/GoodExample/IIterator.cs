using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DESIGNPATTERNS.Iterator.GoodExample
{
    public interface IIterator<T>
    {
        void Next();
        bool HasNext();
        T Current();
    }
}
