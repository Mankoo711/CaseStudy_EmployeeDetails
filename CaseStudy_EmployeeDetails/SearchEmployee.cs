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
    public partial class SearchEmployee : Form
    {
        public SearchEmployee()
        {
            InitializeComponent();
        }
        BusinessLogic logic = new BusinessLogic();
        private async void btnEmpSearch_Click(object sender, EventArgs e)
        {
            await logic.SearchEmployee(txtEmpSearch.Text, dataGridViewEmpDetails);
        }

        private void btnViewAllEmp_Click(object sender, EventArgs e)
        {
            logic.GetAllEmployeeDetails(dataGridViewEmpDetails);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
