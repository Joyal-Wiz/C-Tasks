    using SimpleWebApi.Models;
    using System.Collections.Generic;

namespace Employee_Data.services
{
    public interface IEmployeeService
    {
        List<Employee> GetAll();
        Employee Add(Employee employee);
        Employee Update(int id, Employee employee);
        Employee Delete(int id);
    }

}
