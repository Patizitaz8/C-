using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaAndPerimeter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal l = Convert.ToDecimal(textBox1.Text);

            decimal w = Convert.ToDecimal(textBox2.Text);

            decimal area = l * w;

            decimal perimeter = 2 * l + 2 * w;

            textBox3.Text = Convert.ToString(area);

            textBox4.Text = Convert.ToString(perimeter);

            textBox1.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
