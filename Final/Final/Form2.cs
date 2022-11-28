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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Final
{
    public partial class Form2 : Form
    {
        String message = "";
        String Orderid = "";
        String Customerid = "";
        String Shipname = "";
        String EmployeeID = "";
        String Country = "";
     

    
        public Form2()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            /*  GroupBox TypeCountry = new GroupBox();
              TypeCountry.Text = "Select Shipping Country";
              this.Controls.Add(TypeCountry);

            CheckBox cbxNat = new CheckBox();
            cbxNat.Text = "National";
            this.Controls.Add(cbxNat);

            CheckBox cbxinter = new CheckBox();
            cbxinter.Text = "International";
            this.Controls.Add(cbxinter);

            if (cbxNat.Checked)
            {
                Text = "National";
            }
            else 
            {
                Text = "International";
            }*/

            textBox1.Text = Form1.Orderid;
            textBox2.Text = Form1.Customerid;
            textBox3.Text = Form1.Shipname;


            String[] EmployeeID = new String[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", };
            for (int i = 0; i < EmployeeID.Length; i++)
            { cboEmpid.Items.Add(Convert.ToString(EmployeeID[i])); }

            if (cboEmpid.SelectedIndex == 0)
            { MessageBox.Show("Please select an item from the list"); }


           //ListBox listBox1 = new ListBox();
            listBox1.Items.Add("France");
            listBox1.Items.Add("Germany");
            listBox1.Items.Add("Brazil");
            listBox1.Items.Add("Belgium");
            listBox1.Items.Add("Switzerland");
            listBox1.Items.Add("Venezuela");
            listBox1.Items.Add("Austria");
            listBox1.Items.Add("Mexico");
            listBox1.Items.Add("USA");
            listBox1.Items.Add("Sweden");
            listBox1.Items.Add("Finland");
            listBox1.Items.Add("Italy");
            listBox1.Items.Add("Spain");
            listBox1.Items.Add("Ireland");
            listBox1.Items.Add("UK");
            listBox1.Items.Add("Portugal");
            listBox1.Items.Add("Canada");

            this.Controls.Add(listBox1);

            for (int i = 0; i < Country.Length; i++)
            { listBox1.Items.Add(Convert.ToString(Country[i])); }

            if (listBox1.SelectedIndex == 0)
            { MessageBox.Show("Please select an item from the list"); }

           
        }

        private void cboEmpid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
