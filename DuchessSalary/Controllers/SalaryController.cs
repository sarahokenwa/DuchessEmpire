using DuchessSalary.Context;
using DuchessSalary.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DuchessSalary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalaryController : ControllerBase
    {
        private SalaryContext _salaryContext;

        public SalaryController(SalaryContext salaryContext)
        {
            _salaryContext = salaryContext;
        }

        // GET: api/<EmployeeController>
        [HttpGet]
        public IEnumerable<Salary> Get()
        {
            return _salaryContext.Salaries;
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public Salary Get(int id)
        {
            return _salaryContext.Salaries.FirstOrDefault(s => s.Id == id);
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public void Post([FromBody] Salary value)
        {
            _salaryContext.Salaries.Add(value);
            _salaryContext.SaveChanges();
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Salary value)
        {
            var salary = _salaryContext.Salaries.FirstOrDefault(s => s.Id == id);
            if (salary != null)
            {
                _salaryContext.Entry<Salary>(salary).CurrentValues.SetValues(value);
                _salaryContext.SaveChanges();
            }
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var salary = _salaryContext.Salaries.FirstOrDefault(s => s.Id == id);
            if (salary != null)
            {
                _salaryContext.Salaries.Remove(salary);
                _salaryContext.SaveChanges();
            }
        }
    }
}
