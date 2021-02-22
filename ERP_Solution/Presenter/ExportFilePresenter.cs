using ERP_Solution.Model;
using ERP_Solution.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_Solution.Presenter
{
    public class ExportFilePresenter
    {
        const string BASE_URL = "https://gorest.co.in/public-api/users";
        const string TOKEN = "fa114107311259f5f33e70a5d85de34a2499b4401da069af0b1d835cd5ec0d56";

        IExportFile employeeView;

        public ExportFilePresenter(IExportFile view)
        {
            employeeView = view;

        }

        public async void ExportToExcel(ProgressBar progressBar)
        {
            // Display the ProgressBar control.
            progressBar.Visible = true;
            // Set Minimum to 1 to represent the first file being copied.
            progressBar.Minimum = 1;

            // Set the initial value of the ProgressBar.
            progressBar.Value = 1;
            // Set the Step property to a value of 1 to represent each file being copied.
            progressBar.Step = 1;


            object Nothing = System.Reflection.Missing.Value;
            var app = new Microsoft.Office.Interop.Excel.Application();
            app.Visible = false;
            Microsoft.Office.Interop.Excel.Workbook workBook = app.Workbooks.Add(Nothing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workBook.Sheets[1];
            worksheet.Name = "Employee Exported";
            worksheet.StandardWidth = 20;

            // Show save file dialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // storing header part in Excel  
                Employee employee = new Employee();

                worksheet.Cells[1, 1] = "Id";
                worksheet.Cells[1, 2] = "Name";
                worksheet.Cells[1, 3] = "Email";
                worksheet.Cells[1, 4] = "Gender";
                worksheet.Cells[1, 5] = "Status";

                var response = await EmployeeHelper.ListPage();

                PaginationEmployee paginationInfo = Deserialize.DeserializeEmployeePagination(response);

                int total = paginationInfo.Total;
                int pages = paginationInfo.Pages;
                int page = paginationInfo.Page;
                int limit = paginationInfo.Limit;

                IList<Employee> employeeList = new List<Employee>();

                int countPage = pages;

                // Set Maximum to the total number of files to copy.
                progressBar.Maximum = total;

                int cellCount = 1;

                for (int i = 1; i <= pages; i++)
                {
                    var responseList = await ListAll(i);
                    employeeList = Deserialize.DeserializeEmployeSearch(responseList);

                    for (int j = 0; j < employeeList.Count; j++)
                    {
                        cellCount++;

                        worksheet.Cells[cellCount, 1] = employeeList[j].Id;
                        worksheet.Cells[cellCount, 2] = employeeList[j].Name;
                        worksheet.Cells[cellCount, 3] = employeeList[j].Email;
                        worksheet.Cells[cellCount, 4] = employeeList[j].Gender;
                        worksheet.Cells[cellCount, 5] = employeeList[j].Status;

                        progressBar.PerformStep();
                    }
                }

                progressBar.Visible = false;

                worksheet.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing);
                workBook.Close(false, Type.Missing, Type.Missing);
                app.Quit();

            }

        }


        public static async Task<string> ListAll(int page)
        {

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(BASE_URL + "?page=" + page))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }

                    }
                }
            }
            return string.Empty;

        }
    }
}
