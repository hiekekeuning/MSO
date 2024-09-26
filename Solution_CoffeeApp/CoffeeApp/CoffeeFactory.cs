using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeApp
{
    class CoffeeFactory
    {
        public static Beverage MakeCappucino()
        {
            return new CacaoDecorator(new MilkDecorator(new Coffee(), 2));
        }
        public static Beverage MakeCaramelLatte()
        {
            return new SyrupDecorator(Syrup.Caramel, new MilkDecorator(new Coffee(), 2));
        }
    }
}
