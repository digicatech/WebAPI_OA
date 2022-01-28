using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WabAPI_Domain.Models;
using WebAPI_Repository.Repostory;

namespace WebAPI_Service.Services
{
    public class EmployeeService : IEmployeeService
    {
        private IRepository<Employee> _employeeRepository;

        public EmployeeService(IRepository<Employee> employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public void DeleteEmployee(int id)
        {
            Employee employee = GetEmployeeById(id);
            _employeeRepository.Remove(employee);
            _employeeRepository.SaveChanges();
        }

        public Employee GetEmployeeById(int id)
        {
            return _employeeRepository.Get(id);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _employeeRepository.GetAll();
        }

        public void InsetEmployee(Employee employee)
        {
            _employeeRepository.Insert(employee);
            _employeeRepository.SaveChanges();
        }

        public void UpdateEmployee(Employee employee)
        {
            _employeeRepository.Update(employee);
            _employeeRepository.SaveChanges();
        }
    }
}
