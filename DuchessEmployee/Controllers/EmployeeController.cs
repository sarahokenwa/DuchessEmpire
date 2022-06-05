using DuchessEmployee.Context;
using DuchessEmployee.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DuchessEmployee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private EmployeeContext _employeeContext;

        public EmployeeController(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }

        // GET: api/<EmployeeController>
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return _employeeContext.Employees;
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return _employeeContext.Employees.FirstOrDefault(s => s.Id == id);
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public void Post([FromBody] Employee value)
        {
            _employeeContext.Employees.Add(value);
            _employeeContext.SaveChanges();
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Employee value)
        {
            var employee = _employeeContext.Employees.FirstOrDefault(s => s.Id == id);
            if (employee != null)
            {
                _employeeContext.Entry<Employee>(employee).CurrentValues.SetValues(value);
                _employeeContext.SaveChanges();
            }
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var employee = _employeeContext.Employees.FirstOrDefault(s => s.Id == id);
            if (employee != null)
            {
                _employeeContext.Employees.Remove(employee);
                _employeeContext.SaveChanges();
            }

        }
    }
}
