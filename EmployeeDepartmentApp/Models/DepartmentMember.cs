using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDepartmentApp.Models
{
    public class DepartmentMember
    {
       int ID { get; set; }
       //Employee Employee { get; set; }
       Department Department { get; set; }
       string Role { get; set; }

    }
}
