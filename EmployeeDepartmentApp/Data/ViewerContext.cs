using EmployeeDepartmentApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeDepartmentApp.Data
{
    public class ViewerContext : DbContext
    {
        public ViewerContext(DbContextOptions<ViewerContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().ToTable("Department");
            modelBuilder.Entity<Employee>().ToTable("Employee");
        }
    }
}




