using System;

namespace DuchessSalary.Model
{
    public class Salary
    {
        public int Id { get; set; }
        public double EmployeeSalary { get; set; }
        public string Role { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
