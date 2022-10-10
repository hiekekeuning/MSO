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
        public CoffeeUI()
        {
            InitializeComponent();

            baseBox.SelectedIndex = 0;
        }

        private void makeButton_Click(object sender, EventArgs e)
        {
            Beverage order = baseBox.Text switch
            {
                "coffee" => new Coffee(),
                "decaf"  => new Decaf(),
                _        => throw new CoffeeAppException("unknown coffee type"),
            };
            if (milkBox.Checked)
            {
                
            }
            if (syrupBox1.Checked)
            {
                
            }
            if (cacaoBox.Checked)
            {
                
            }
            showOrder(order);
        }

        private void cappucinoButton_Click(object sender, EventArgs e)
        {
            throw new CoffeeAppException("don't know how to make cappucino yet");
        }

        private void showOrder(Beverage order)
        {
            outBox.Text = order.Make() + Environment.NewLine + $"€ {order.Price}";
        }
    }
}
