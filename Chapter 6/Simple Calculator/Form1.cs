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

namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal operand1 = Convert.ToDecimal(txtValue1.Text);
            decimal operand2 = Convert.ToDecimal(txtValue2.Text);
            String Operator= txtOperator.Text;


            decimal result = CalculateResult(operand1, Operator, operand2);
            result = Math.Round(result, 4);
            txtresult.Text = result.ToString();
            txtValue1.Focus();
        }

        private decimal CalculateResult(decimal operand1, String Operator, decimal operand2)
        {
            decimal result = 0;

            if (txtOperator.Text == "+")
            
                {
                result = (operand1 + operand2);
                }

            else if (txtOperator.Text == "-")

                 {
                result = (operand1 - operand2);
                 }

            else if (txtOperator.Text == "*")

                {
                result = (operand1 * operand2);
                }

            else if (txtOperator.Text == "/")

                 {
                result = (operand1 / operand2);
                 }

            return result;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtValue1_TextChanged(object sender, EventArgs e)
        {
            txtresult.Text = "";
        }

        private void txtValue2_TextChanged(object sender, EventArgs e)
        {
            txtresult.Text = "";
        }
    }
}

