using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route(template:"api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private IEmployeeService _employeeService;
        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet(template:"getall")]
        public IActionResult GetList()
        {
            var result = _employeeService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);

        }

        [HttpGet(template: "getbyid")]
        public IActionResult GetById(int employeeId)
        {
            var result = _employeeService.GetById(employeeId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);

        }

        [HttpPost]

        public IActionResult Add(Employee employee)
        {
            var result = _employeeService.Add(employee);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);

        }

        [HttpDelete]

        [Authorize(Roles = "Employee.Delete")]
        public IActionResult Delete(Employee employee)
        {
            var result = _employeeService.Delete(employee);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPut]
        public IActionResult Update(Employee employee)
        {
            var result = _employeeService.Update(employee);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}
