using DuchessEmployee.Models;
using Microsoft.EntityFrameworkCore;

namespace DuchessEmployee.Context
{
    public class EmployeeContext: DbContext
    {
        public EmployeeContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
