using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwndDataSet1.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.northwndDataSet1.Orders);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            this.ordersBindingSource.MoveFirst();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.ordersBindingSource.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.ordersBindingSource.MoveNext();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            this.ordersBindingSource.MoveLast();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.ordersBindingSource.AddNew();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.ordersTableAdapter.Update(this.northwndDataSet1);

            northwndDataSet.OrdersDataTable neworders = (northwndDataSet.OrdersDataTable)
            northwndDataSet1.Orders.GetChanges(DataRowState.Added);

            try
            {
                object newOrders = null;
                if (newOrders != null)
                {
                    ordersTableAdapter.Update((northwndDataSet1)newOrders);
                }

                northwndDataSet1.AcceptChanges();
            }

            catch (System.Exception)
            {
                MessageBox.Show("Update failed");
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();

            this.Visible = false;
        }
    }
}
