using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeApp
{
    public abstract class Beverage
    {
        public abstract string Make();
        public abstract decimal Price();
    }

    class Coffee : Beverage
    {
        public override string Make()
        {
            return "coffee";
        }

        public override decimal Price()
        {
            return 2;
        }
    }

    class Decaf : Beverage
    {
        public override string Make()
        {
            return "decaf";
        }

        public override decimal Price()
        {
            return 1.75m;
        }
    }

    
}
