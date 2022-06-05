using DuchessSalary.Model;
using Microsoft.EntityFrameworkCore;

namespace DuchessSalary.Context
{
    public class SalaryContext: DbContext
    {
        public SalaryContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Salary> Salaries { get; set; }
    }
}
