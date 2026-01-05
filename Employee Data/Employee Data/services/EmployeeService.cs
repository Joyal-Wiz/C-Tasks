    using SimpleWebApi.Models;
    using System.Collections.Generic;
    using System.Linq;

namespace Employee_Data.services
{
    public class EmployeeService : IEmployeeService
    {
        private static List<Employee> employees = new List<Employee>
    {
        new Employee { Id = 1, Name = "Joyal", Department = "IT", Salary = 50000 },
        new Employee { Id = 2, Name = "Noyal", Department = "HR", Salary = 45000 }
    };

        public List<Employee> GetAll()
        {
            return employees;
        }

        public Employee Add(Employee employee)
        {
            employee.Id = employees.Max(e => e.Id) + 1;
            employees.Add(employee);
            return employee;
        }

        public Employee Update(int id, Employee updatedEmployee)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
                return null;

            employee.Name = updatedEmployee.Name;
            employee.Department = updatedEmployee.Department;
            employee.Salary = updatedEmployee.Salary;

            return employee;
        }

        public Employee Delete(int id)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
                return null;

            employees.Remove(employee);
            return employee;
        }
    }

}
