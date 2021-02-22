using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ERP_Solution.Model.EmployeeDeserialize;

namespace ERP_Solution.Model
{
    public class Deserialize
    {
        public static IList<Employee> DeserializeEmployeSearch(string content)
        {

            IList<Employee> employeeList = new List<Employee>();

            try
            {
                Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(content);

                employeeList = myDeserializedClass
                                   .data
                                   .ConvertAll(x =>
                                   new Employee
                                   {
                                       Id = x.id,
                                       Name = x.name,
                                       Email = x.email,
                                       Gender = x.gender,
                                       Status = x.status,
                                       Created_at = x.created_at,
                                       Updated_at = x.updated_at
                                   });
            }
            catch
            {
                try
                {
                    RootResponseError myDeserializedClassError = JsonConvert.DeserializeObject<RootResponseError>(content);
                    new CustomException("It was not possible to proceed with the search. \n\n Reason: " + myDeserializedClassError.data[0].field + " " + myDeserializedClassError.data[0].message);
                }
                catch (Exception ex)
                {
                    new CustomException(ex.Message);
                }
            }

            return employeeList;
        }

        public static Employee DeserializeEmployeeSearchGrid(string content)
        {
            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(content);

            IList<Employee> employeeList = new List<Employee>();

            try
            {
                employeeList = myDeserializedClass
                                    .data
                                    .ConvertAll(x =>
                                    new Employee
                                    {
                                        Id = x.id,
                                        Name = x.name,
                                        Email = x.email,
                                        Gender = x.gender,
                                        Status = x.status,
                                        Created_at = x.created_at,
                                        Updated_at = x.updated_at
                                    });
            }
            catch
            {
                try
                {
                    RootResponseError myDeserializedClassError = JsonConvert.DeserializeObject<RootResponseError>(content);
                    new CustomException("It was not possible proceed with this selection. \n\n Reason: " + myDeserializedClassError.data[0].field + " " + myDeserializedClassError.data[0].message);
                }
                catch (Exception ex)
                {
                    new CustomException(ex.Message);
                }
            }
            return employeeList[0];
        }

        public static Employee DeserializeCreateUpdate(string content)
        {
            Employee employee = new Employee();

            try
            {
                RootResponse myDeserializedClass = JsonConvert.DeserializeObject<RootResponse>(content);

                employee = new Employee
                {
                    Id = myDeserializedClass.data.id,
                    Name = myDeserializedClass.data.name,
                    Email = myDeserializedClass.data.email,
                    Gender = myDeserializedClass.data.gender,
                    Status = myDeserializedClass.data.status,
                    Created_at = myDeserializedClass.data.created_at,
                    Updated_at = myDeserializedClass.data.updated_at
                };
            }
            catch
            {
                try
                {
                    RootResponseError myDeserializedClassError = JsonConvert.DeserializeObject<RootResponseError>(content);
                    new CustomException("It was not possible to proceed with this operation. \n\n Reason: " + myDeserializedClassError.data[0].field + " " + myDeserializedClassError.data[0].message);
                }
                catch (Exception ex)
                {
                    new CustomException(ex.Message);
                }
            }

            return employee;
        }

        public static PaginationEmployee DeserializeEmployeePagination(string content)
        {
            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(content);

            PaginationEmployee paginationEmployee = new PaginationEmployee()
            {
                Total = myDeserializedClass.meta.pagination.total,
                Page = myDeserializedClass.meta.pagination.page,
                Pages = myDeserializedClass.meta.pagination.pages,
                Limit = myDeserializedClass.meta.pagination.limit
            };

            return paginationEmployee;
        }
    }
}
