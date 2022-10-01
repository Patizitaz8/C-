using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculate_income_tax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal income = Convert.ToDecimal(txtIncome.Text);
            decimal taxOwed = CalculateTax(income);
            txttaxOwed.Text = taxOwed.ToString();

        }
        private decimal CalculateTax(decimal income)
        {
             decimal taxOwed = 0m;

            if (income <= 9875)
            {
                taxOwed = (int)(income * .10m);
            }

            else if (income > 9875 && income <= 40125)
            {
                taxOwed = 987.50m + (int)((income - 9875) * .12m);
            }

            else if (income > 40125 && income <= 85525)
            {
                taxOwed = 4617.50m + (int)((income - 40125) * .22m);
            }

            else if (income > 85526 && income <= 163300)
            {
                taxOwed = 14605.50m + (int)((income - 85526) * .24m);
            }

            else if (income > 163301 && income <= 207350)
            {
                taxOwed = 33271.50m + (int)((income - 163301) * .32m);
            }

            else if (income > 207351 && income <= 518400)
            {
                taxOwed = 47367.50m + (int)((income - 207351) * .35m);
            }

            else
            {
                taxOwed = 156235m + (int)((income - 518401) * .37m);
            }
                return taxOwed;

            }

        private void txtIncome_TextChanged(object sender, EventArgs e)
        {
            txttaxOwed.Text = "";
        }
    }
}
