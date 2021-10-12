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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            baseBox.SelectedIndex = 0;
        }

        private void makeButton_Click(object sender, EventArgs e)
        {
            Beverage order;
            switch (baseBox.Text)
            {
                case "coffee": order = new Coffee(); break;
                case "decaf": order = new Decaf(); break;
                default: throw new CoffeeAppException("unknown coffee type");
            }
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
        }

        private void showOrder(Beverage order)
        {
            outBox.Text = order.Make() + Environment.NewLine + $"€ {order.Price()}";
       
        }
    }
}
