using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
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

            try

            {

                if (IsValidData())

                {
                    decimal operand1 = Convert.ToDecimal(txtValue1.Text);
                    decimal operand2 = Convert.ToDecimal(txtValue2.Text);
                    String Operator = txtOperator.Text;


                    decimal result = CalculateResult(operand1, Operator, operand2);
                    result = Math.Round(result, 4);
                    txtresult.Text = result.ToString();
                    txtValue1.Focus();
                }
            }


            catch (FormatException ex)

            {
                MessageBox.Show("Format error ocurred. Please enter numeric values for operands" + "\n\n" + ex.StackTrace, "Entry Error");
            }

            catch (OverflowException ex)

            {
                MessageBox.Show("Overflow error occurred. Please enter a valid operator." + "\n\n" + ex.StackTrace, "Entry Error");
            }

            catch (DivideByZeroException ex)

            {
                MessageBox.Show("Division-by-zero error ocurred. Please enter a none zero value for operand 2." + "\n\n" + ex.StackTrace, "Entry Error");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Invalid input for operands." + "\n\n" + ex.StackTrace, "Entry Error");
            }

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

        private bool IsValidData()

        {

            return

            IsPresent(txtValue1.Text, "Operand 1") &&

            IsDecimal(txtValue1.Text, "Operand 1") &&

            IsWithinRange(txtValue1.Text, "Operand 1", 0, 1000000) &&


            IsPresent(txtOperator.Text, "Operator") &&

            IsOperator(txtOperator.Text, "Operator") &&


            IsPresent(txtValue2.Text, "Operand 2") &&

            IsDecimal(txtValue2.Text, "Operand 2") &&

            IsWithinRange(txtValue2.Text, "Operand 2", 0, 1000000);

        }

        public bool IsPresent(TextBox textBox, string Name)

        {

            if (textBox.Text == "")

            {

                MessageBox.Show(Name + " is a required field.", "Entry Error");

                textBox.Focus();

                return false;

            }

        }

        public bool IsDecimal(TextBox textBox, string Name)

        {
            decimal number = 0m;

            if (Decimal.TryParse(textBox.Text, out number))
            {
                return true; 
            }
            else 
            {
                MessageBox.Show(Name + " must be a decimal value.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        public bool IsWithinRange(TextBox textBox, string Name, decimal Mn, decimal Mx)

        {

            decimal number = Convert.ToDecimal(textBox.Text);

            if (number < Mn || number > Mx)

            {
                MessageBox.Show(Name + " must be between " + Mn + " and " + Mx + ".", "Entry Error");

                textBox.Focus();

                return false;

            }

            return true;

        }

        public bool IsOperator(TextBox textBox, string name)

        {
            string op = textBox.Text;

            if (new[] { "+", "-", "*", "/" }.Contains(op))
            {
                return true;
            }
            MessageBox.Show("Please enter a valid operator", "Operator Error");

            return false;
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

