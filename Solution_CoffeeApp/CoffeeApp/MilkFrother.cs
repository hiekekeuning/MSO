using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeApp
{
  
    abstract class MilkFrother
    {
        public int UsesSinceCleaned { get; protected set; }
        public abstract void FrothMilk();
    }

    class EgbertsFrother : MilkFrother
    {
        public override void FrothMilk()
        {
            Console.WriteLine("schoonmaken");
            Console.WriteLine("opschuimen");
            if (UsesSinceCleaned > 10)
            {
                Console.WriteLine("opwarmen");
                UsesSinceCleaned = 0;
            }
        }
    }
    class SpressoFrother : MilkFrother
    {
        public override void FrothMilk()
        {
            Console.WriteLine("<heat>");
            Console.WriteLine("<froth>");
            if (UsesSinceCleaned > 10)
            {
                Console.WriteLine("<clean>");
                UsesSinceCleaned = 0;
            }
        }
    }

}
