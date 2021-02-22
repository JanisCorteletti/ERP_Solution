using ERP_Solution.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP_SolutionTest
{
    [TestClass]
    public class EmployeeTest
    {

        [TestMethod]
        public void Employee_Class_MethodCreate_Sucess()
        {
            string randomName = GenerateString(5);
            string randomEmail = GenerateString(5) + "@mail.com";

            //Create
            Employee employee = MockEmployee(randomName, randomEmail, "Female", "Active");

            Assert.AreEqual(randomName, employee.Name);
            Assert.AreEqual(randomEmail, employee.Email);
            Assert.AreEqual("Female", employee.Gender);
            Assert.AreEqual("Active", employee.Status);
        }

        public Employee MockEmployee(string name, string email, string gender, string status)
        {
            var employee = new Employee();
            employee.Name = name;
            employee.Email = email;
            employee.Gender = gender;
            employee.Status = status;

            return employee;
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

    }
}
