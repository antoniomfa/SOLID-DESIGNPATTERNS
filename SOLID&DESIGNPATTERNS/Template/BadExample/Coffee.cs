using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DESIGNPATTERNS.Template.BadExample
{
    public class Coffee
    {
        public void MakeBeverage()
        {
            BoilWater();
            PourWaterIntoCup();
            Brew();
            AddCondimements();
        }

        private void BoilWater()
        {
            Console.WriteLine("Boiling water... \n");
        }

        private void PourWaterIntoCup()
        {
            Console.WriteLine("Pouring water into cup... \n");
        }

        private void Brew()
        {
            Console.WriteLine("Brewing coffee... \n");
        }

        private void AddCondimements()
        {
            if (CustomerWantsCondiments())
            {
                Console.WriteLine("Adding condiments to coffee... \n");
            }

        }

        private bool CustomerWantsCondiments()
        {
            Console.WriteLine("Would you like sugar in your coffee? (y/n)\n");

            string input = Console.ReadLine();

            return input.ToLower() == "y";
        }
    }
}
