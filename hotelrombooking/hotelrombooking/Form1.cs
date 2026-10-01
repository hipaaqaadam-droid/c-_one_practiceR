using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotelrombooking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculatebooking_Click(object sender, EventArgs e)
        {

            {
                //creating variables
                try
                {
                    //variable
                    string jestname = txtguestname.Text;
                    string room = txtguestname.Text;
                    int nights = int.Parse(txtnights.Text);
                    decimal price = decimal.Parse(txtprice.Text);
                    //calculate
                    decimal bookingcost = nights * price;
                    //service text
                    decimal servicetext = bookingcost * 0.010m;
                    //discount.
                    decimal discount = bookingcost * 0.05m;
                    //calculate total
                    decimal totalamount = bookingcost + servicetext - discount;
                    //display
                    lblservicetax.Text = servicetext.ToString();
                    lbldiscount.Text = discount.ToString();
                    lbltotal.Text = totalamount.ToString();
                }
               
               catch {
                    MessageBox.Show("plz try again invalid error");

                }
                

            }
        }
    }
}

    
    
   