using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DESIGNPATTERNS.Template.GoodExample
{
    public class BeverageMaker
    {
        private Beverage _beverage;

        public BeverageMaker(Beverage beverage)
        {
            _beverage = beverage;
        }

        public void SetBeverage(Beverage beverage) 
        {
            _beverage = beverage;
        }

        public void MakeBeverage()
        {
            // Common steps
            BoilWater();
            PourWaterIntoCup();

            // Unique
            _beverage.Prepare();
        }

        private void BoilWater()
        {
            Console.WriteLine("Boiling water... \n");
        }

        private void PourWaterIntoCup()
        {
            Console.WriteLine("Pouring water into cup... \n");
        }
    }
}
