using ERP_Solution.Model;
using ERP_Solution.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Solution.Presenter
{
    public class EmployeePresenter
    {
        IEmployee employeeView;

        public EmployeePresenter(IEmployee view)
        {
            employeeView = view;


            if (employeeView.CurrentPageText == "0")
            {
                ReloadPageInfo();
                ControlButtonNav(true, false);
            }
        }

        /// <summary>
        /// Action to list all employees
        /// </summary>
        /// <returns></returns>
        public async Task ListAllEmployees()
        {
            int page = Convert.ToInt32(employeeView.CurrentPageText);

            var response = await EmployeeHelper.ListAll(page);

            employeeView.DataSourceGridEmployee = Deserialize.DeserializeEmployeSearch(response);
        }


        /// <summary>
        /// Actions when 'New' button is clicked
        /// </summary>
        public void New()
        {
            Employee employee = new Employee();

            ReloadForm(employee);
        }

        /// <summary>
        /// Action to create a new employee
        /// </summary>
        public async void Create()
        {
            Employee employee = new Employee();
            employee.Name = employeeView.NameEmployeeText;
            employee.Email = employeeView.EmailEmployeeText;
            employee.Gender = employeeView.GenderEmployeeFemale == true ? "Female" : "Male";
            employee.Status = employeeView.StatusEmployeeActive == true ? "Active" : "Inactive";

            var response = await EmployeeHelper.Create(employee);

            Employee employeeResponse = Deserialize.DeserializeCreateUpdate(response);

            if (employeeResponse.Id > 0)
            {
                employeeView.CurrentPageText = employeeView.PagesTotalText;

                employeeView.SelectionChanged = false;
                await ListAllEmployees();
                employeeView.SelectionChanged = true;

                ReloadForm(employeeResponse);

                ReloadPageInfo();

                ControlButtonCrud();

                ControlButtonNav(true, false);
            }

        }

        /// <summary>
        /// Action to update employee data
        /// </summary>
        public async void Edit()
        {

            Employee employee = new Employee();
            employee.Id = Convert.ToInt32(employeeView.IdEmployeeText);
            employee.Name = employeeView.NameEmployeeText;
            employee.Email = employeeView.EmailEmployeeText;
            employee.Gender = employeeView.GenderEmployeeFemale == true ? "Female" : "Male";
            employee.Status = employeeView.StatusEmployeeActive == true ? "Active" : "Inactive";

            var response = await EmployeeHelper.Update(employee);

            Employee employeeResponse = Deserialize.DeserializeCreateUpdate(response);

            if (employeeResponse.Id > 0)
            {
                employeeView.SelectionChanged = false;
                await ListAllEmployees();
                employeeView.SelectionChanged = true;

                ReloadForm(employeeResponse);

                ReloadPageInfo();


                ControlButtonCrud();
            }
        }

        /// <summary>
        /// Actions when 'Delete' button is clicked
        /// </summary>
        public async void Delete()
        {
            Employee employee = new Employee();
            employee.Id = Convert.ToInt32(employeeView.IdEmployeeText);

            await EmployeeHelper.Delete(employee);

            await ListAllEmployees();
        }

        /// <summary>
        /// Search for all each Employee property
        /// </summary>
        /// <returns></returns>
        public async void Search()
        {
            Employee employee = new Employee();
            employee.Id = employeeView.SearchIdEmployeeText != "" ? Convert.ToInt32(employeeView.SearchIdEmployeeText) : 0;
            employee.Name = employeeView.SearchNameEmployeeText;
            employee.Email = employeeView.SearchEmailEmployeeText;

            if (employeeView.GenderEmployeeFemaleSearch == true || employeeView.GenderEmployeeMaleSearch == true)
            {
                employee.Gender = employeeView.GenderEmployeeFemaleSearch == true ? "Female" : "Male";
            }

            if (employeeView.StatusEmployeeActiveSearch == true || employeeView.StatusEmployeeInactiveSearch == true)
            {
                employee.Status = employeeView.StatusEmployeeActiveSearch == true ? "Active" : "Inactive";
            }

            var stringValue = ConcatenateStringForSearch(employee);

            var response = await EmployeeHelper.ListByString(stringValue);

            employeeView.DataSourceGridEmployee = Deserialize.DeserializeEmployeSearch(response);

            ControlButtonCrud();
        }

        public string ConcatenateStringForSearch(Employee employee)
        {
            string stringSearch = "?";

            if (employee.Id != 0)
            {
                stringSearch = stringSearch + "id=" + employee.Id + "&";
            }
            if (employee.Name != "")
            {
                stringSearch = stringSearch + "name=" + employee.Name + "&";
            }
            if (employee.Email != "")
            {
                stringSearch = stringSearch + "email=" + employee.Email + "&";
            }
            if (employee.Gender != "")
            {
                stringSearch = stringSearch + "gender=" + employee.Gender + "&";
            }
            if (employee.Status != "")
            {
                stringSearch = stringSearch + "status=" + employee.Status + "&";
            }

            return stringSearch;
        }

        /// <summary>
        /// Search Employee by ID when row is selected
        /// </summary>
        /// <param name="idSelected"></param>
        public async void SearchGrid(int idSelected)
        {
            var response = await EmployeeHelper.ListById(idSelected);

            Employee employeeResponse = Deserialize.DeserializeEmployeeSearchGrid(response);

            ReloadForm(employeeResponse);

            ControlButtonCrud();
        }

        /// <summary>
        /// Actions when 'Last Page' button is clicked
        /// </summary>
        public void ReloadForm(Employee employee)
        {
            employeeView.IdEmployeeText = Convert.ToString(employee.Id);
            employeeView.NameEmployeeText = employee.Name;
            employeeView.EmailEmployeeText = employee.Email;
            employeeView.GenderEmployeeFemale = employee.Gender == "Female";
            employeeView.GenderEmployeeMale = employee.Gender == "Male";
            employeeView.StatusEmployeeActive = employee.Status == "Active";
            employeeView.StatusEmployeeInactive = employee.Status == "Inactive";
        }

        /// <summary>
        /// Actions when 'First Page' button is clicked
        /// </summary>
        public void SearchFirstPage()
        {
            employeeView.CurrentPageText = "1";

            ControlButtonNav(false, true);
        }

        /// <summary>
        /// Actions when 'Next Page' button is clicked
        /// </summary>
        public void SearchNext()
        {
            int currentPage = Convert.ToInt32(employeeView.CurrentPageText);
            int totalPages = Convert.ToInt32(employeeView.PagesTotalText);
            int nextPage = currentPage + 1;

            if (totalPages > currentPage)
            {
                employeeView.CurrentPageText = nextPage.ToString();

                ControlButtonNav(true, true);
            }

            if (totalPages == nextPage)
            {
                ControlButtonNav(true, false);
            }
        }

        /// <summary>
        /// Actions when 'Previous Page' button is clicked
        /// </summary>
        public void SearchPrevious()
        {
            int currentPage = Convert.ToInt32(employeeView.CurrentPageText);
            int previousPage = currentPage - 1;

            if (currentPage > 0)
            {
                employeeView.CurrentPageText = previousPage.ToString();

                ControlButtonNav(true, true);
            }

            if (currentPage == previousPage)
            {
                ControlButtonNav(false, true);
            }
        }

        /// <summary>
        /// Actions when 'Last Page' button is clicked
        /// </summary>
        public void SearchLastPage()
        {
            employeeView.CurrentPageText = employeeView.PagesTotalText;

            ControlButtonNav(true, false);
        }

        /// <summary>
        /// Controls enable/disable naviagation buttons
        /// </summary>
        public void ControlButtonNav(bool btFirstPage, bool btLastPage)
        {
            employeeView.BtFirstPageEnable = btFirstPage;
            employeeView.BtPreviousPageEnable = btFirstPage;
            employeeView.BtNextPageEnable = btLastPage;
            employeeView.BtLastPageEnable = btLastPage;
        }

        /// <summary>
        /// Controle enable/disable New, Create, Update and Delete button
        /// </summary>
        public void ControlButtonCrud()
        {
            bool enableBtn = employeeView.IdEmployeeText == string.Empty || employeeView.IdEmployeeText != "0";

            employeeView.BtNewEmployeeEnable = enableBtn;
            employeeView.BtCreateEmployeeEnable = !enableBtn;
            employeeView.BtUpdateEmployeeEnable = enableBtn;
            employeeView.BtDeleteEmployeeEnable = enableBtn;
        }

        /// <summary>
        /// Refresh labels with updated info
        /// </summary>
        public async Task ReloadPageInfo()
        {
            var response = await EmployeeHelper.ListPage();

            PaginationEmployee pagination = Deserialize.DeserializeEmployeePagination(response);

            if (employeeView.CurrentPageText == "0")
            {
                employeeView.CurrentPageText = pagination.Pages.ToString();
            }
            employeeView.PagesTotalText = pagination.Pages.ToString();
            employeeView.EmployeeTotalText = pagination.Total.ToString();

        }
    }
}
