using Employee_Data.services;
using Microsoft.AspNetCore.Mvc;
using SimpleWebApi.Models;

[ApiController]
[Route("api/[controller]")]
public class EmployeesController : ControllerBase
{
    private readonly IEmployeeService _employeeService;

    public EmployeesController(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    [HttpGet]
    public IActionResult GetAllEmployees()
    {
        return Ok(_employeeService.GetAll());
    }

    [HttpPost]
    public IActionResult AddEmployee(Employee employee)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        return Ok(_employeeService.Add(employee));
    }

    [HttpPut("{id}")]
    public IActionResult UpdateEmployee(int id, Employee employee)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var updated = _employeeService.Update(id, employee);
        if (updated == null)
            return NotFound();

        return Ok(updated);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteEmployee(int id)
    {
        var deleted = _employeeService.Delete(id);
        if (deleted == null)
            return NotFound();

        return Ok(deleted);
    }
}
