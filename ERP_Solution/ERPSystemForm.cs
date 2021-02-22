using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_Solution
{
    public partial class ERPSystemForm : Form
    {
        public ERPSystemForm()
        {
            InitializeComponent();
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var employeeForm = new EmployeeForm();
            employeeForm.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutForm = new AboutForm();
            aboutForm.Show();
        }
    }
}
