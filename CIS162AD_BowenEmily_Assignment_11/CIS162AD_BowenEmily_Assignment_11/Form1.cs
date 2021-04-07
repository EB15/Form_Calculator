using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS162AD_BowenEmily_Assignment_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelTB_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            

            string laborText = laborTB.Text;
            double laborInt = double.Parse(laborText);

            string materialText = materialTB.Text;
            double matInt = double.Parse(materialText);

            double subtotal1 = laborInt + matInt;

                    
            double tax = subtotal1 * 0.06;
           

            double total = subtotal1 + tax;


            string subtotal2 = "$" + subtotal1.ToString();

            string taxSt = "$" + tax.ToString();

            string totalSt = "$" + total.ToString();

            
            subtotalTB.Text = subtotal2;

            taxTB.Text = taxSt;

            costTB.Text = totalSt;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            laborTB.Text = String.Empty;
            materialTB.Text = String.Empty;
            subtotalTB.Text = String.Empty;
            taxTB.Text = String.Empty;
            costTB.Text = String.Empty;

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
