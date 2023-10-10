using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeApp
{
    abstract class Beverage
    {
        public abstract string Make();
        public abstract decimal Price { get; }
    }

    class Coffee : Beverage
    {
        public override string Make() => "coffee";
        
        public override decimal Price
        {
            get => 2;
        }
    }

    class Decaf : Beverage
    {
        public override string Make() => "decaf";

        public override decimal Price
        {
            get => 1.75m;
        }
    }

    
}
