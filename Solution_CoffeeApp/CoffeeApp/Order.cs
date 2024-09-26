using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeApp
{
    public class Order
    {
        public Beverage Beverage { get; set; }


        public decimal Price { get; private set; }

        private int _discount = 0;

        public void Make(Beverage beverage, bool discount = false)
        {
            Beverage = beverage ?? throw new ArgumentNullException(nameof(beverage));
            if (discount)
            {
                _discount = 25;
            }
            Price = Beverage.Price() * (1 - _discount/100.0m);
        }

    }
}
