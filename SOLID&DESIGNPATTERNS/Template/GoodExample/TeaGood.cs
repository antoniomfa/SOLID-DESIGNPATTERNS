using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DESIGNPATTERNS.Template.GoodExample
{
    public class TeaGood : Beverage
    {
        public void Prepare()
        {
            Brew();
            AddCondimements();
        }

        private void Brew()
        {
            Console.WriteLine("Brewing tea... \n");
        }

        private void AddCondimements()
        {
            if (CustomerWantsCondiments())
            {
                Console.WriteLine("Adding condiments to tea... \n");
            }

        }

        private bool CustomerWantsCondiments()
        {
            Console.WriteLine("Would you like lemon in your tea? (y/n)\n");

            string input = Console.ReadLine();

            return input.ToLower() == "y";
        }
    }
}
