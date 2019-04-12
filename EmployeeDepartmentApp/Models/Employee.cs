using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDepartmentApp.Models
{
    public class Employee
    {
        public int ID { get; set; }

        [DisplayName("Department")]
        public int DepartmentID { get; set; } // Foreign Key

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("First Name")]
        public string FirstMidName { get; set; }

        [DisplayName("Primary Phone #")]
        public string PrimaryPhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public Department Department { get; set; }

    }
}
