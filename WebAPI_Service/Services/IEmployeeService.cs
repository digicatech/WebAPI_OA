using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WabAPI_Domain.Models;

namespace WebAPI_Service.Services
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetEmployees();
        void InsetEmployee(Employee employee);

        void UpdateEmployee(Employee employee);
        void DeleteEmployee(int id);

        Employee GetEmployeeById(int id);
    }
}
