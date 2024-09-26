using CoffeeApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeAppPrivate
{
   
    abstract class Decorator : Beverage
    {
        protected Beverage _beverage;

        public Decorator(Beverage beverage)
        {
            _beverage = beverage;
        }
    }

    class Milk : Decorator
    {
        public Milk(Beverage beverage) : base(beverage)
        {

        }
        public override string Make()
        {
            return _beverage.Make() + " + milk";
   
        }

        public override decimal Price()
        {
            return _beverage.Price() + 0.50m;
        }
    }

    class Cacao : Decorator
    {
        public Cacao(Beverage beverage) : base(beverage)
        {

        }
        public override string Make()
        {
            return _beverage.Make() + " + cacao";

        }

        public override decimal Price()
        {
            return _beverage.Price() + 0.25m;
        }
    }

    class Syrup : Decorator
    {
        public Syrup(Beverage beverage) : base(beverage)
        {

        }
        public override string Make()
        {
            return "syrup + " + _beverage.Make();

        }

        public override decimal Price()
        {
            return _beverage.Price() + 0.55m;
        }
    }

    


}
