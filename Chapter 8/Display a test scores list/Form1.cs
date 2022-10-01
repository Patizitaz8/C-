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

        List<int> listscore = new List<int>(); 
        public int index = 0;
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
            int scount;
            try
            {
                if (IsValidData() && index < 20)
                {
                    score = Convert.ToInt32(txtscore.Text);
                    listscore.Add(score);
                    stotal = listscore.ConvertAll(Convert.ToInt32).Sum();
                    scount = index +1;
                    index = index + 1;
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

        public void sortArray()
        {
            listscore.Sort(); 
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {

            txtscore = "";
            txtStotal = "";
            txtScount = "";
            txtaverage = "";
            txtscore.Focus();
            listscore.Clear();
            this.stotal = 0;
            index = 0;
        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            sortArray();
            var message = string.Join(Environment.NewLine, listscore.ToArray()); 
            MessageBox.Show(message, "Sorted Scores");
        }
    }
}
