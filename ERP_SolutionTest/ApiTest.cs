using ERP_Solution.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using static ERP_Solution.Model.EmployeeDeserialize;

namespace ERP_SolutionTest
{
    [TestClass]
    public class ApiTest
    {
        const string BASE_URL = "https://gorest.co.in/public-api/users";
        const string TOKEN = "fa114107311259f5f33e70a5d85de34a2499b4401da069af0b1d835cd5ec0d56";

        [TestMethod]
        public void Employee_Api_MethodGet_ResponseOK()
        {
            var client = new RestClient(BASE_URL);
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer " + TOKEN);
            request.AddHeader("Cache-Control", "no-cache");
            IRestResponse response = client.Execute(request);
            var content = response.Content;

            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(content);

            var employeeList = myDeserializedClass
                                .data
                                .ConvertAll(x => new Employee { Id = x.id, Name = x.name, Email = x.email, Gender = x.gender, Status = x.status, Created_at = x.created_at, Updated_at = x.updated_at });

            Assert.AreEqual(200, myDeserializedClass.code = 200);
        }

        [TestMethod]
        public void Employee_Api_MethodGet_TokeyEmpty()
        {
            var token = "";

            var client = new RestClient(BASE_URL);
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer " + token);
            request.AddHeader("Cache-Control", "no-cache");
            IRestResponse response = client.Execute(request);
            var content = response.Content;

            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(content);

            List<Employee> employeeList = myDeserializedClass
                                .data
                                .ConvertAll(x => new Employee { Id = x.id, Name = x.name, Email = x.email, Gender = x.gender, Status = x.status, Created_at = x.created_at, Updated_at = x.updated_at });

            Assert.AreEqual(true, employeeList.Count > 0);
        }

        [TestMethod]
        public void Employee_Api_MethodGet_AllEmployoees()
        {
            var client = new RestClient(BASE_URL);
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer " + TOKEN);
            request.AddHeader("Cache-Control", "no-cache");
            IRestResponse response = client.Execute(request);
            var content = response.Content;

            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(content);

            List<Employee> employeeList = myDeserializedClass
                                .data
                                .ConvertAll(x => new Employee { Id = x.id, Name = x.name, Email = x.email, Gender = x.gender, Status = x.status, Created_at = x.created_at, Updated_at = x.updated_at });


            Assert.AreEqual(true, employeeList.Count > 0);
        }

        [TestMethod]
        public void Employee_Api_MethodGet_IdFound()
        {
            Employee employeeCreated = CreateRandomEmployee();

            Employee employeeInserted = Api_Employee_Insert(employeeCreated);

            IList<Employee> employeeGetList = Api_Employee_Get(employeeCreated);

            Assert.AreEqual(employeeInserted.Id, employeeGetList[0].Id);
        }

        [TestMethod]
        public void Employee_Api_MethodGet_IdNotFound()
        {
            Employee employeeCreated = new Employee();
            employeeCreated.Id = 1;

            IList<Employee> employeeGetList = Api_Employee_Get(employeeCreated);

            Assert.AreEqual(0, employeeGetList.Count);
        }

        [TestMethod]
        public void Employee_Api_MethodGet_NameFound()
        {
            Employee employeeCreated = CreateRandomEmployee();
            var name = employeeCreated.Name;

            Employee employeeInserted = Api_Employee_Insert(employeeCreated);

            IList<Employee> employeeGetList = Api_Employee_Get(employeeCreated);

            Assert.AreEqual(name, employeeGetList[0].Name);
        }

        [TestMethod]
        public void Employee_Api_MethodGet_NameNotFound()
        {
            Employee employeeCreated = new Employee();
            employeeCreated.Name = "Not a name";

            IList<Employee> employeeGetList = Api_Employee_Get(employeeCreated);

            Assert.AreEqual(0, employeeGetList.Count);
        }

        [TestMethod]
        public void Employee_Api_MethodGet_EmailFound()
        {
            Employee employeeCreated = CreateRandomEmployee();
            var email = employeeCreated.Email;

            Employee employeeInserted = Api_Employee_Insert(employeeCreated);

            IList<Employee> employeeGetList = Api_Employee_Get(employeeCreated);

            Assert.AreEqual(email, employeeGetList[0].Email);
        }

        [TestMethod]
        public void Employee_Api_MethodGet_EmailNotFound()
        {
            Employee employeeCreated = new Employee();
            employeeCreated.Email = "notfound@mail.com";

            IList<Employee> employeeGetList = Api_Employee_Get(employeeCreated);

            Assert.AreEqual(0, employeeGetList.Count);
        }

        [TestMethod]
        public void Employee_Api_MethodGet_GenderFemaleFound()
        {
            Employee employeeCreated = CreateRandomEmployee();
            employeeCreated.Gender = "Female";

            Employee employeeInserted = Api_Employee_Insert(employeeCreated);

            IList<Employee> employeeGetList = Api_Employee_Get(employeeCreated);

            Assert.AreEqual(true, employeeGetList.Count > 0);
        }

        [TestMethod]
        public void Employee_Api_MethodGet_GenderMaleFound()
        {
            Employee employeeCreated = CreateRandomEmployee();
            employeeCreated.Gender = "Male";

            Employee employeeInserted = Api_Employee_Insert(employeeCreated);

            IList<Employee> employeeGetList = Api_Employee_Get(employeeCreated);

            Assert.AreEqual(true, employeeGetList.Count > 0);
        }

        [TestMethod]
        public void Employee_Api_MethodGet_GenderNotFound()
        {
            Employee employeeCreated = CreateRandomEmployee();
            employeeCreated.Gender = "NotAGender";

            IList<Employee> employeeGetList = Api_Employee_Get(employeeCreated);

            Assert.AreEqual(0, employeeGetList.Count);
        }

        [TestMethod]
        public void Employee_Api_MethodGet_StatusInactiveFound()
        {
            Employee employeeCreated = CreateRandomEmployee();
            employeeCreated.Status = "Inactive";

            Employee employeeInserted = Api_Employee_Insert(employeeCreated);

            IList<Employee> employeeGetList = Api_Employee_Get(employeeCreated);

            Assert.AreEqual(true, employeeGetList.Count > 0);
        }

        [TestMethod]
        public void Employee_Api_MethodGet_StatusActiveFound()
        {
            Employee employeeCreated = CreateRandomEmployee();
            employeeCreated.Status = "Active";

            Employee employeeInserted = Api_Employee_Insert(employeeCreated);

            IList<Employee> employeeGetList = Api_Employee_Get(employeeCreated);

            Assert.AreEqual(true, employeeGetList.Count > 0);
        }

        [TestMethod]
        public void Employee_Api_MethodGet_StatusNotFound()
        {
            Employee employeeCreated = new Employee();
            employeeCreated.Status = "NotAStatus";

            IList<Employee> employeeGetList = Api_Employee_Get(employeeCreated);

            Assert.AreEqual(0, employeeGetList.Count);
        }

        [TestMethod]
        public void Employee_Api_MethodGet_Sucess()
        {
            Employee employeeCreated = CreateRandomEmployee();
            Employee employeeInserted = Api_Employee_Insert(employeeCreated);

            Assert.AreEqual(employeeCreated.Name, employeeInserted.Name);
            Assert.AreEqual(employeeCreated.Email, employeeInserted.Email);
            Assert.AreEqual(employeeCreated.Gender, employeeInserted.Gender);
            Assert.AreEqual(employeeCreated.Status, employeeInserted.Status);
        }

        [TestMethod]
        public void Employee_Api_MethodPost_Sucess()
        {
            Employee employeeCreated = CreateRandomEmployee();
            Employee employeeInserted = Api_Employee_Insert(employeeCreated);

            Assert.AreEqual(employeeCreated.Name, employeeInserted.Name);
            Assert.AreEqual(employeeCreated.Email, employeeInserted.Email);
            Assert.AreEqual(employeeCreated.Gender, employeeInserted.Gender);
            Assert.AreEqual(employeeCreated.Status, employeeInserted.Status);
        }

        [TestMethod]
        public void Employee_Api_MethodEdit_Sucess()
        {
            Employee employeeCreated = CreateRandomEmployee();
            Employee employeeInserted = Api_Employee_Insert(employeeCreated);

            employeeInserted.Name = "Name edited";
            employeeInserted.Gender = "Male";
            employeeInserted.Status = "Inactive";

            Employee employeeEdited = Api_Employee_Edit(employeeInserted);

            Assert.AreEqual(employeeInserted.Name, employeeEdited.Name);
            Assert.AreEqual(employeeInserted.Email, employeeEdited.Email);
            Assert.AreEqual(employeeInserted.Gender, employeeEdited.Gender);
            Assert.AreEqual(employeeInserted.Status, employeeEdited.Status);
        }

        [TestMethod]
        public void Employee_Api_MethodDelete_Sucess()
        {
            Employee employeeCreated = CreateRandomEmployee();
            Employee employeeInserted = Api_Employee_Insert(employeeCreated);

            Employee employeeDeleted = Api_Employee_Delete(employeeInserted);

            Assert.AreEqual(0, employeeDeleted.Id);
        }

        public IList<Employee> Api_Employee_Get(Employee employee)
        {
            string stringSearch = StringSearch(employee);

            var client = new RestClient(BASE_URL + "?" + stringSearch);
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer " + TOKEN);
            request.AddHeader("Cache-Control", "no-cache");
            IRestResponse response = client.Execute(request);
            var content = response.Content;

            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(content);

            List<Employee> employeeList = myDeserializedClass
                                .data
                                .ConvertAll(x => new Employee { Id = x.id, Name = x.name, Email = x.email, Gender = x.gender, Status = x.status, Created_at = x.created_at, Updated_at = x.updated_at });

            return employeeList;
        }

        public Employee Api_Employee_Insert(Employee employee)
        {
            RestClient client = new RestClient(BASE_URL);
            RestRequest request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "Bearer " + TOKEN);
            request.AddHeader("Cache-Control", "no-cache");
            request.RequestFormat = DataFormat.Json;

            request.AddJsonBody(new { name = employee.Name, email = employee.Email, gender = employee.Gender, status = employee.Status });

            IRestResponse response = client.Execute(request);
            var content = response.Content;

            RootResponse myDeserializedClass = JsonConvert.DeserializeObject<RootResponse>(response.Content);

            Employee returnEmployee = new Employee
            {
                Id = myDeserializedClass.data.id,
                Name = myDeserializedClass.data.name,
                Email = myDeserializedClass.data.email,
                Gender = myDeserializedClass.data.gender,
                Status = myDeserializedClass.data.status,
                Created_at = myDeserializedClass.data.created_at,
                Updated_at = myDeserializedClass.data.updated_at
            };

            return returnEmployee;
        }

        public Employee CreateRandomEmployee()
        {
            string randomName = GenerateString(5);
            string randomEmail = GenerateString(5) + "@mail.com";

            var employee = new Employee();
            employee.Name = randomName;
            employee.Email = randomEmail;
            employee.Gender = "Female";
            employee.Status = "Active";

            return employee;
        }

        public string StringSearch(Employee employee)
        {
            string stringSearch = "";

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

        public static string GenerateString(int length)
        {
            Random random = new Random();
            string characters = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            StringBuilder result = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                result.Append(characters[random.Next(characters.Length)]);
            }
            return result.ToString();
        }

        public Employee Api_Employee_Edit(Employee employee)
        {
            RestClient client = new RestClient(BASE_URL + "/" + employee.Id);
            RestRequest request = new RestRequest(Method.PATCH);
            request.AddHeader("Authorization", "Bearer " + TOKEN);
            request.AddHeader("Cache-Control", "no-cache");
            request.RequestFormat = DataFormat.Json;

            request.AddJsonBody(new { name = employee.Name, email = employee.Email, gender = employee.Gender, status = employee.Status });

            IRestResponse response = client.Execute(request);
            var content = response.Content;

            RootResponse myDeserializedClass = JsonConvert.DeserializeObject<RootResponse>(response.Content);

            Employee returnEmployee = new Employee
            {
                Id = myDeserializedClass.data.id,
                Name = myDeserializedClass.data.name,
                Email = myDeserializedClass.data.email,
                Gender = myDeserializedClass.data.gender,
                Status = myDeserializedClass.data.status,
                Created_at = myDeserializedClass.data.created_at,
                Updated_at = myDeserializedClass.data.updated_at
            };

            return returnEmployee;
        }

        public Employee Api_Employee_Delete(Employee employee)
        {
            var client = new RestClient(BASE_URL + "/" + employee.Id);
            var request = new RestRequest(Method.DELETE);
            request.AddHeader("Authorization", "Bearer " + TOKEN);
            request.AddHeader("Cache-Control", "no-cache");
            IRestResponse response = client.Execute(request);
            var content = response.Content;

            RootResponseDelete myDeserializedClass = JsonConvert.DeserializeObject<RootResponseDelete>(content);

            return new Employee();
        }
    }
}
