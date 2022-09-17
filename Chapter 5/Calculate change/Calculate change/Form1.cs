using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate_change
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
            const int quarter = 25;
            const int dime = 10;
            const int nickel = 5;
            const int peny = 1;
            int inputAmount = Convert.ToInt32(txtInput.Text);

            if (inputAmount >= quarter)
            {
                txtQuarters.Text = (inputAmount / quarter).ToString();
                inputAmount = inputAmount % quarter;
            }

            if (inputAmount >= dime)
            {
                txtDimes.Text = (inputAmount / dime).ToString();
                inputAmount = inputAmount % dime;
            }

            if (inputAmount >= nickel)
            {

                txtNickels.Text = (inputAmount / nickel).ToString();

                inputAmount = inputAmount % nickel;
            }


            if (inputAmount >= peny)
            {
                txtPennies.Text = (inputAmount / peny).ToString();

                inputAmount = inputAmount % peny;
            }
        }

    }
}
