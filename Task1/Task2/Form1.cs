using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly Dictionary<string, decimal> prices = new Dictionary<string, decimal>
        {
            { "Пломбір", 40.00m },
            { "Шоколадне", 45.00m },
            { "Фруктове", 35.00m },
            { "Ванільне", 38.00m }
        };

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string selectedFlavor = "";
            decimal pricePerOne = 0;

            if (rbPlombir.Checked) { selectedFlavor = "Пломбір"; pricePerOne = prices["Пломбір"]; }
            else if (rbChocolate.Checked) { selectedFlavor = "Шоколадне"; pricePerOne = prices["Шоколадне"]; }
            else if (rbFruit.Checked) { selectedFlavor = "Фруктове"; pricePerOne = prices["Фруктове"]; }
            else if (rbVanilla.Checked) { selectedFlavor = "Ванільне"; pricePerOne = prices["Ванільне"]; }

            int quantity = (int)numQuantity.Value;
            decimal total = pricePerOne * quantity;

            if (quantity > 20)
            {
                decimal discount = total * 0.05m;
                total -= discount;
                lblResult.Text = $"Знижка 5% врахована!\nДо сплати: {total:F2} грн";
            }
            else
            {
                lblResult.Text = $"До сплати: {total:F2} грн";
            }

            lblResult.ForeColor = Color.DarkGreen;
        }
    }
}
