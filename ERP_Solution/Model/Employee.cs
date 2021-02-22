using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Solution.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Status { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }

        public Employee() { }

        public Employee(int id, string name, string email, string gender, string status)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Gender = gender;
            this.Status = status;
        }
    }
}
