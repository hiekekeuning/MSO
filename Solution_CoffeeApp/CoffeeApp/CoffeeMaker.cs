using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeApp
{
    class CoffeeMaker
    {
        private static CoffeeMaker _instance;

        private CoffeeMaker()
        {
        }

        public static CoffeeMaker GetCoffeeMaker()
        {
            if (_instance == null)
            {
                _instance = new CoffeeMaker();
            }
            return _instance;
        }
        public void Start() { }
    }


    class HomeManager
    {
        public void Arrive()
        {
            CoffeeMaker.GetCoffeeMaker().Start();
            //..
        }

    }

}
