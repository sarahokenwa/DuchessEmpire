using DuchessDepartment.Models;
using Microsoft.EntityFrameworkCore;

namespace DuchessDepartment.Context
{
    public class DepartmentContext: DbContext
    {
        public DepartmentContext(DbContextOptions options) : base(options)
        {

        }
       public DbSet<Department> Departments { get; set; }
    }
}
