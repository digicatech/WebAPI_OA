using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WabAPI_Domain.Models;
using WebAPI_Service.Services;

namespace WebAPI_OA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeService;

        public EmployeeController(IEmployeeService employeService)
        {
            _employeService = employeService;
        }

        [HttpGet(nameof(GetEmployess))]
        public IActionResult GetEmployess()
        { 
            var result = _employeService.GetEmployees();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No Records Found");
        }


        [HttpGet(nameof(GetEmployeeById))]
        public IActionResult GetEmployeeById(int id)
        {
            var result = _employeService.GetEmployeeById(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No Records Found");

        }
        
        
        [HttpPost(nameof(InsertEmployee))]
        public IActionResult InsertEmployee(Employee employee)
        { 
            _employeService.InsetEmployee(employee);
            return Ok("Data Saved");
        }

        [HttpPost(nameof(UpdateEmployee))]
        public IActionResult UpdateEmployee(Employee employee)
        {
            _employeService.UpdateEmployee(employee);
            return Ok("Data updated");
        }

        [HttpPost(nameof(DeleteEmployee))]
        public IActionResult DeleteEmployee(int id)
        {
            _employeService.DeleteEmployee(id);
            return Ok("Data deleted");
        }
       

    }
}
