using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwndDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.northwndDataSet.Employees);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            this.employeesBindingSource.MoveFirst();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.employeesBindingSource.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.employeesBindingSource.MoveNext();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            this.employeesBindingSource.MoveLast();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.employeesBindingSource.AddNew();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.employeesTableAdapter.Update(this.northwndDataSet);

            northwndDataSet.EmployeesDataTable newemployees = (northwndDataSet.EmployeesDataTable)
            northwndDataSet.Employees.GetChanges(DataRowState.Added);

            try
            {
                object newEmployees = null;
                if (newEmployees != null)
                {
                    employeesTableAdapter.Update((northwndDataSet)newEmployees);
                }

                northwndDataSet.AcceptChanges();
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


        }
    }
}
