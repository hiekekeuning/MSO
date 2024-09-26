using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeApp
{
    abstract class BeverageDecorator : Beverage
    {
        protected Beverage _beverage;

        public BeverageDecorator(Beverage beverage)
        {
            _beverage = beverage;
        }
    }

    class MilkDecorator : BeverageDecorator
    {
        public int Quantity { get; set; }
        public MilkDecorator(Beverage beverage, int q = 1) : base(beverage)
        {
            Quantity = q;
        }


        public override string Make()
        {
            // to do 
            return _beverage.Make() + " + milk";
        }

        public override decimal Price()
        {
            return 0.50m + _beverage.Price();
        }
    }

    class CacaoDecorator : BeverageDecorator
    {
        public CacaoDecorator(Beverage beverage) : base(beverage)
        {

        }
        public override string Make()
        {
            return _beverage.Make() + " + cacao";
        }

        public override decimal Price()
        {
            return 0.25m + _beverage.Price();
        }
    }

public enum Syrup { Caramel, Chocolate, Hazelnut }
class SyrupDecorator : BeverageDecorator
{
    private Syrup _syrupType;
    public SyrupDecorator(Syrup type, Beverage beverage) : base(beverage)
    {
        _syrupType = type;
    }
    public override string Make()
    {
        return $"{_syrupType} syrup " + _beverage.Make();
    }

    public override decimal Price()
    {
        return 0.55m + _beverage.Price();
    }
}

    class TestDecorator : BeverageDecorator
    {
        public TestDecorator(Beverage beverage) : base(beverage)
        {

        }
        public override string Make()
        {
            return "test " + _beverage.Make();
        }

        public override decimal Price()
        {
            return 0.55m + _beverage.Price();
        }
    }
}
