using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Score_Calculator
{ 
    public partial class Form1 : Form
    {
        
        int score = 0;
        int stotal = 0;
        int scount = 0;
        decimal average = 0m;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            score = int.Parse(txtscore.Text);
            ++scount;
            stotal += score;
            average = stotal / scount;

            txtScount.Text = scount.ToString();
            txtStotal.Text = stotal.ToString();
            txtaverage.Text = average.ToString();
            txtscore.Focus();
            txtscore.Clear();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            score = 0;
            stotal = 0;
            scount = 0;
            average = 0;
            txtStotal.Clear();
            txtScount.Clear();
            txtaverage.Clear();
            txtscore.Focus();
        }
    }
}
