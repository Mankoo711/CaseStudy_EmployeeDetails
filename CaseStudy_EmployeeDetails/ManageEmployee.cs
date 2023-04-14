using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaseStudy_EmployeeDetails
{
    public partial class ManageEmployee : Form
    {
        public ManageEmployee()
        {
            InitializeComponent();
        }
        BusinessLogic logic = new BusinessLogic();
        private async void btnAddEmployee_Click(object sender, EventArgs e)
        {
           
            await logic.AddEmployee(txtBoxName.Text, txtBoxEmail.Text, comboBoxGender.Text,comboBoxStatus.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private async void  btnDelete_Click(object sender, EventArgs e)
        {
            await logic.DeleteEmployeeDetails(txtboxId.Text);
        }

        private async void btnEditEmployee_Click(object sender, EventArgs e)
        {
            await logic.EditEmployeeDetails(txtBoxName.Text, txtBoxEmail.Text, comboBoxGender.Text, comboBoxStatus.Text, txtboxId.Text);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
