using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleWebApi.Models;

namespace Employee_Data.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private static List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Joyal", Department = "IT", Salary = 50000 },
            new Employee { Id = 2, Name = "Noyal", Department = "HR", Salary = 45000 }
        };

        [HttpGet]

        public IActionResult GetAllEmployees(){ // what this IActionResult
            return Ok(employees);
        }

        [HttpPost]

        public IActionResult AddEmployee(Employee employee) { 
            if(!ModelState.IsValid) // what is this Modelstate and also Isvalid
                return BadRequest(employees);
            employee.Id = employees.Max(e => e.Id) + 1;
            employees.Add(employee);
            return Ok(employee); // whats this ok() function 

        }
        [HttpPut("{id}")]
        public IActionResult UpdateEmployee(int id, Employee updatedEmployee)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var employee = employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
                return NotFound();

            employee.Name = updatedEmployee.Name;
            employee.Department = updatedEmployee.Department;
            employee.Salary = updatedEmployee.Salary;

            return Ok(employee);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
                return NotFound();

            employees.Remove(employee);
            return Ok(employee);
        }
    }
}

