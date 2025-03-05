using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DESIGNPATTERNS.Iterator
{
    // PROBLEM
    public class ShoppingList
    {
        private List<string> _list = new();

        // IF WE CHANGE TO 
        //private string[] _list = new string[50];
        // USING IN PROGRAM BREAKS BECAUSE FIXED LENGHT ARRAY DOESN'T HAVE COUNT FIELD

        public void Push(string itemName)
        {
            _list.Add(itemName);
        }

        public string Pop()
        {
            var last = _list.Last();

            _list.Remove(last);

            return last;
        }

        public List<string> GetList()
        {
            return _list;
        }
    }
}
