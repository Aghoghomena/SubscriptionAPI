
using Microsoft.AspNetCore.Mvc;
using System;
using WebApplication1.Domain;
using WebApplication1.Entity;

namespace WebApplication1.Controllers
{
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private IEmployeeData _employeeData;
        public EmployeesController(IEmployeeData employeeData)
        {
            //this is dependency injection
            _employeeData = employeeData;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult getEmployees()
        {
            return Ok (_employeeData.GetEmployee());
        }

        //get single emplooyee

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetEmployee(Guid id)
        {
            var employee = _employeeData.GetSingleEmployee(id);

            if(employee != null)
            {
                return Ok(employee);
            }
            return NotFound($"The employee with string: {id} was not found");
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult CreateEmployee(Employee employee )
        {
            _employeeData.AddEmployee(employee);

            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + employee.Id, employee);

        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult DeleteEmployee(Guid Id)
        {
            //chcek if employee exist first
            var employee = _employeeData.GetSingleEmployee(Id);

            if(employee != null)
            {
                _employeeData.DeleteEmployee(employee);
                return Ok();
            }

            return NotFound($"Employee with id: {Id} not Found");
        }

        [HttpPatch]
        [Route("api/[controller]/{id}")]
        public IActionResult EditEmployee(Guid Id, Employee emp)
        {
            //chcek if employee exist first
            var existingemployee = _employeeData.GetSingleEmployee(Id);

            if (existingemployee != null)
            {
                emp.Id = Id;
                _employeeData.EditEmployee(emp);
                return Ok(emp);
            }

            return NotFound($"Employee with id: {Id} not Found");
        }
    }
}
