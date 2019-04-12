using EmployeeDepartmentApp.Models;
using System;
using System.Linq;

namespace EmployeeDepartmentApp.Data
{
    public static class DbInitializer
    {

        public static void Initialize(ViewerContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
                       
                //Look for any Employees.
                if (context.Employees.Any())
                {
                       return;   // DB has been seededj
                }

                var Departments = new Department[]
                {
                new Department{DepartmentID=1050,Name="Finance" },
                new Department{DepartmentID=4022,Name="Sales" },
                new Department{DepartmentID=4041,Name="Customer Service" },
                new Department{DepartmentID=1045,Name="IT" },
                };
                foreach (Department c in Departments)
                {
                    context.Departments.Add(c);
                }
                context.SaveChanges();

                var Employees = new Employee[]
                {
                        new Employee{DepartmentID=1050,FirstMidName="Carson",LastName="Alexander",PrimaryPhoneNumber="978-923-3456",Address="2234 A Street",City="Dedham",State="MA",Zip="02026" },
                        new Employee{DepartmentID=4022,FirstMidName="Meredith",LastName="Alonso",PrimaryPhoneNumber="916-523-4455",Address="2234 A Street",City="Woburn",State="MA",Zip="02022" },
                        new Employee{DepartmentID=4041,FirstMidName="Arturo",LastName="Anand",PrimaryPhoneNumber="916-334-3456",Address="2234 A Street",City="Attleboro",State="MA",Zip="02026" },
                        new Employee{DepartmentID=1045,FirstMidName="Gytis",LastName="Barzdukas",PrimaryPhoneNumber="978-919-3456",Address="2234 A Street",City="Dracut",State="MA",Zip="01826" },
                        new Employee{DepartmentID=4022,FirstMidName="Yan",LastName="Li",PrimaryPhoneNumber="978-222-3366",Address="2234 A Street",City="Lowell",State="MA",Zip="01827" },
                        new Employee{DepartmentID=1045,FirstMidName="Peggy",LastName="Justice",PrimaryPhoneNumber="978-674-9878",Address="2234 A Street",City="Mansfield",State="MA",Zip="01825" },
                        new Employee{DepartmentID=4041,FirstMidName="Laura",LastName="Norman",PrimaryPhoneNumber="978-922-1122",Address="2234 A Street",City="Lowell",State="MA",Zip="01823" },
                        new Employee{DepartmentID=4022,FirstMidName="Nino",LastName="Olivetto",PrimaryPhoneNumber="978-921-3456",Address="2234 A Street",City="Andover",State="MA",Zip="02022" }
                };
                foreach (Employee s in Employees)
                {
                    context.Employees.Add(s);
                }
                context.SaveChanges();


        }
    }
}