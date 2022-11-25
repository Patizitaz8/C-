using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1= new Form1();
            form1.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            String[] Title = new String[] { "Accountant", "Enginner", "Receptionist", "Salesman", "Programmer", "Electrical Technician", "Other" };
            for (int i = 0; i < Title.Length; i++)
            { comboBox1.Items.Add(Convert.ToString(Title[i])); }

            if (comboBox1.SelectedIndex == 0)
            { MessageBox.Show("Please select an item from the list"); }



           /* ListBox listBox = new ListBox();
            listBox.Items.Add(txtEmpID);
            listBox.Items.Add(txtLname);
            listBox.Items.Add(txtFname);
            listBox.Items.Add(txtCountry);

            this.Controls.Add(listBox);*/
        }
    }
}
