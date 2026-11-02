using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tiptexttotal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
                   private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtprisefood1.Text, out double mealcherge))
            {
                const double TIP_RATE = 0.15;
                const double TAX_RATE = 0.07;

                double tipAmount = mealcherge * TIP_RATE;
                double taxAmount = mealcherge * TAX_RATE;
                double totalAmount = mealcherge + tipAmount + taxAmount;

                txtnamefood1.Text = tipAmount.ToString("C");
                txtpricefood1.Text = taxAmount.ToString("C");
                txtnamefood2.Text = totalAmount.ToString("C");
            }
            else
            {
                MessageBox.Show("Fadlan qor lambar sax ah!");
            }
        }
    } 
}
