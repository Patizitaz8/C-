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
        String orderId = "";
        String customerId = "";
        String shipName = "";
        String EmployeeID = "";
        public string OrderID
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string CustomerID
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }

        public string ShipName
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }
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
            TypeCountry.Controls.Add(cbxNat);

            CheckBox cbxinter = new CheckBox();
            cbxinter.Text = "International";
            TypeCountry.Controls.Add(cbxinter);

            if (cbxNat.Checked)
            {
                TypeCountry = "National";
            }
            else 
            {
                TypeCountry = "International";
            }*/


            String[] EmployeeId = new String[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", };
            for (int i = 0; i < EmployeeId.Length; i++)
            { cboEmpid.Items.Add(Convert.ToString(EmployeeId[i])); }

            if (cboEmpid.SelectedIndex == 0)
            { MessageBox.Show("Please select an item from the list"); }


            ListBox listBox1 = new ListBox();
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
        }
    }
}
