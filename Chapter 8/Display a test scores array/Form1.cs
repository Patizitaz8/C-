using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Score_Calculator
{
    public partial class Form1 : Form
    {

        int[] arr = new int[20];
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
            try
            {
                if (IsValidData())
                {
                    score = Convert.ToInt32(txtscore.Text);
                    arr[scount] = score;
                    stotal = stotal + arr[scount];
                    scount += 1;
                    average = stotal / scount;

                    txtScount.Text = scount.ToString();
                    txtStotal.Text = stotal.ToString();
                    txtaverage.Text = average.ToString();
                    txtscore.Focus();
                    txtscore.Clear();
                }
            }
        

        catch (Exception)
            {
            MessageBox.Show("Invalid Input");
            }

        }

        public bool IsValidData()
        {
            return
                IsPresent(txtscore, "Score") &&
                IsInt32(txtscore, "Score") &&
                IsWithinRange(txtscore, "Score", 01, 100);
        }

        public bool IsPresent (TextBox textBox, string name)
        {
            if (textBox == "")

            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            else
                return true;
        }

        public bool IsInt32 (TextBox textBox, string name)
        {
            int value;
            if (int.TryParse(textBox.Text, out value))
            {
                return true;
            }

            else
                MessageBox.Show(name + " must be a valid integer.", "Entry Error");
                textBox.Focus();
                return false;
        }

        public bool IsWithinRange (TextBox textBox, string name, decimal min, decimal max)
        {
            if (Convert.ToInt32(textBox.Text) > max || Convert.ToInt32(textBox.Text) < min)
            {
                MessageBox.Show(name + " must be between " + min + " and " + max + ".", "Entry Error");
                textBox.Focus();
                return false;
            }

            else
                return true;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            int[] newArr = new int[20];
            arr = newArr;
            stotal = 0;
            scount = 0;
            average = 0;
            txtStotal.Clear();
            txtScount.Clear();
            txtaverage.Clear();
            txtscore.Focus();
        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            Array.Sort (arr,0,scount);
            String score = "";

            foreach (int i in arr)
                if (i != 0)
                {
                    score += i.ToString() + "\n";
                }
            MessageBox.Show(score, "Sorted Scores");
            txtscore.Focus();
        }
    }
}
