using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeApp
{
    public partial class CoffeeUI : Form
    {
        private Order _order = new();
        private CoffeeMachine _coffeeMachine = new();

        public CoffeeUI()
        {
            InitializeComponent();

            baseBox.SelectedIndex = 0;

            _coffeeMachine.Show();
        }

        private void makeButton_Click(object sender, EventArgs e)
        {
            Beverage beverage;
            switch (baseBox.Text)
            {
                case "coffee": beverage = new Coffee(); break;
                case "decaf": beverage = new Decaf(); break;
                default: throw new CoffeeAppException("unknown coffee type");
            }
            if (milkBox.Checked)
            {
                beverage = new MilkDecorator(beverage);
            }
            if (syrupBox1.Checked)
            {
                beverage = new SyrupDecorator(Syrup.Caramel, beverage);
            }
            if (cacaoBox.Checked)
            {
                beverage = new CacaoDecorator(beverage);
            }
            _order.Make(beverage);
            showOrder(_order);
        }

        private void cappucinoButton_Click(object sender, EventArgs e)
        { 
            _order.Make(CoffeeFactory.MakeCappucino());
            showOrder(_order);
        }

        private void latteButton_Click(object sender, EventArgs e)
        {
            _order.Make(CoffeeFactory.MakeCaramelLatte());
            showOrder(_order);
        }

        private void showOrder(Order order)
        {
            outBox.Text = $"{order.Beverage.Make()}" + Environment.NewLine + $"€ {order.Beverage.Price()}";
        }

       
    }
}
