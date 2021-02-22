using ERP_Solution.Presenter;
using ERP_Solution.View;
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
    public partial class EmployeeForm : Form, IEmployee, IExportFile
    {

        public EmployeeForm()
        {
            InitializeComponent();
        }

        public string IdEmployeeText { get => txtId.Text; set => txtId.Text = value; }
        public string NameEmployeeText { get => txtName.Text; set => txtName.Text = value; }
        public string EmailEmployeeText { get => TxtEmail.Text; set => TxtEmail.Text = value; }

        public bool GenderEmployeeFemale { get => rbFemale.Checked; set => rbFemale.Checked = value; }
        public bool GenderEmployeeMale { get => rbMale.Checked; set => rbMale.Checked = value; }

        public bool StatusEmployeeActive { get => rbActive.Checked; set => rbActive.Checked = value; }
        public bool StatusEmployeeInactive { get => rbInactive.Checked; set => rbInactive.Checked = value; }

        public string Created_atEmployeeText { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Updated_atEmployeeText { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string SearchIdEmployeeText { get => txtSearchId.Text; set => txtSearchId.Text = value; }
        public string SearchNameEmployeeText { get => txtSearchName.Text; set => txtSearchName.Text = value; }
        public string SearchEmailEmployeeText { get => txtSearchEmail.Text; set => txtSearchEmail.Text = value; }

        public bool GenderEmployeeFemaleSearch { get => rbFemaleSearch.Checked; set => rbFemaleSearch.Checked = value; }
        public bool GenderEmployeeMaleSearch { get => rbMaleSearch.Checked; set => rbMaleSearch.Checked = value; }

        public bool StatusEmployeeActiveSearch { get => rbActiveSearch.Checked; set => rbActiveSearch.Checked = value; }
        public bool StatusEmployeeInactiveSearch { get => rbInactiveSearch.Checked; set => rbInactiveSearch.Checked = value; }

        public bool BtNewEmployeeEnable { get => btNew.Enabled; set => btNew.Enabled = value; }
        public bool BtCreateEmployeeEnable { get => btCreate.Enabled; set => btCreate.Enabled = value; }
        public bool BtUpdateEmployeeEnable { get => btUpdate.Enabled; set => btUpdate.Enabled = value; }
        public bool BtDeleteEmployeeEnable { get => btDelete.Enabled; set => btDelete.Enabled = value; }

        public string EmployeeTotalText { get => lblEmployeeTotal.Text; set => lblEmployeeTotal.Text = value; }
        public string CurrentPageText { get => lblCurrentPage.Text; set => lblCurrentPage.Text = value; }
        public string PagesTotalText { get => lblPagesTotal.Text; set => lblPagesTotal.Text = value; }

        public bool BtFirstPageEnable { get => btFirstPage.Enabled; set => btFirstPage.Enabled = value; }
        public bool BtPreviousPageEnable { get => btPrevious.Enabled; set => btPrevious.Enabled = value; }
        public bool BtNextPageEnable { get => btNext.Enabled; set => btNext.Enabled = value; }
        public bool BtLastPageEnable { get => btLastPage.Enabled; set => btLastPage.Enabled = value; }

        public bool SelectionChanged { get; set; }

        public object DataSourceGridEmployee { get => GridEmployee.DataSource; set => GridEmployee.DataSource = value; }

        private async void btListAll_Click(object sender, EventArgs e)
        {
            EmployeePresenter presenter = new EmployeePresenter(this);
            presenter.SearchLastPage();
            await presenter.ListAllEmployees();

            presenter.ControlButtonCrud();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            EmployeePresenter presenter = new EmployeePresenter(this);
            presenter.New();

            rbFemale.Checked = true;
            rbActive.Checked = true;

            presenter.ControlButtonCrud();
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            bool formValidated = ValidateForm();

            if (formValidated)
            {
                EmployeePresenter presenter = new EmployeePresenter(this);
                presenter.Create();
            }

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            bool formValidated = ValidateForm();

            if (formValidated)
            {
                EmployeePresenter presenter = new EmployeePresenter(this);

                presenter.Edit();

            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            EmployeePresenter presenter = new EmployeePresenter(this);
            presenter.Delete();

        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            EmployeePresenter presenter = new EmployeePresenter(this);
            presenter.Search();
        }

        private void GridEmployee_SelectionChanged(object sender, EventArgs e)
        {
            if (SelectionChanged)
            {
                DataGridView dataGrid = sender as DataGridView;

                if (dataGrid != null && dataGrid.SelectedRows.Count > 0)
                {
                    if (SelectionChanged)
                    {
                        var IdSelected = Convert.ToInt32(dataGrid.SelectedRows[0].Cells[0].Value.ToString());

                        if (IdSelected != 0)
                        {
                            EmployeePresenter presenter = new EmployeePresenter(this);
                            presenter.SearchGrid(IdSelected);
                        }
                    }
                }
            }
        }

        private async void btNext_Click(object sender, EventArgs e)
        {
            EmployeePresenter presenter = new EmployeePresenter(this);
            presenter.SearchNext();
            await presenter.ListAllEmployees();

            presenter.ControlButtonCrud();
        }

        private async void btPrevious_Click(object sender, EventArgs e)
        {
            EmployeePresenter presenter = new EmployeePresenter(this);
            presenter.SearchPrevious();
            await presenter.ListAllEmployees();

            presenter.ControlButtonCrud();
        }

        private async void btFirstPage_Click(object sender, EventArgs e)
        {
            EmployeePresenter presenter = new EmployeePresenter(this);
            presenter.SearchFirstPage();
            await presenter.ListAllEmployees();

            presenter.ControlButtonCrud();
        }

        private async void btLastPage_Click(object sender, EventArgs e)
        {
            EmployeePresenter presenter = new EmployeePresenter(this);
            presenter.SearchLastPage();
            await presenter.ListAllEmployees();

            presenter.ControlButtonCrud();
        }

        private void txtName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateName();
        }

        private bool ValidateName()
        {
            bool bStatus = true;
            if (txtName.Text == "")
            {
                errorProvider1.SetError(txtName, "Please enter the employee Name");
                bStatus = false;
            }
            else
                errorProvider1.SetError(txtName, "");
            return bStatus;
        }

        private bool ValidateForm()
        {
            bool formValidated = true;

            bool bValidName = ValidateName();
            bool bValidateEmail = ValidateEmail();

            if (!bValidName || !bValidateEmail)
            {
                formValidated = false;
                MessageBox.Show("Please enter valid data", "Application Message");
            }

            return formValidated;
        }

        private void TxtEmail_Validating(object sender, CancelEventArgs e)
        {
            ValidateEmail();
        }

        private bool ValidateEmail()
        {
            bool bStatus = true;
            if (TxtEmail.Text == "")
            {
                errorProvider1.SetError(TxtEmail, "Please enter the employee Email");
                bStatus = false;
            }
            else if (!IsValidEmail(TxtEmail.Text))
            {
                errorProvider1.SetError(TxtEmail, "Please enter a valid Email");
                bStatus = false;
            }
            else
            {
                errorProvider1.SetError(TxtEmail, "");
            }

            return bStatus;
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ExportFilePresenter presenterFile = new ExportFilePresenter(this);
            presenterFile.ExportToExcel(pBar1);
        }

        private async void EmployeeForm_Load(object sender, EventArgs e)
        {
            EmployeePresenter presenter = new EmployeePresenter(this);

            await presenter.ReloadPageInfo();
            SelectionChanged = true;

            await presenter.ListAllEmployees();
            presenter.ControlButtonCrud();
            presenter.ControlButtonNav(true, false);
        }
    }
}