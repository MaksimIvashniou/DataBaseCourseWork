using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies.Employees;
using WManufacture.Infrastructure.Services.Employees;

namespace WManufacture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly ILogger<EmployeesController> _logger;

        private readonly IEmployeeService _employeeService;

        public EmployeesController(
            ILogger<EmployeesController> logger,
            IEmployeeService employeeService)
        {
            _logger = logger;

            _employeeService = employeeService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Employee>>> GetAsync()
        {
            try
            {
                var list = await _employeeService.GetAsync();

                return Ok(list);
            }
            catch(Exception ex)
            {
                _logger.LogError(
                    "Error with GET Employees",
                    ex);

                return StatusCode(500);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> GetAsync(int id)
        {
            try
            {
                var item = _employeeService.GetAsync(id);

                if(item != null)
                {
                    return Ok(item);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    "Error with GET Employees",
                    ex);

                return StatusCode(500);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] Employee data)
        {
            if(data != null)
            {
                try
                {
                    await _employeeService.CreateAsync(data);

                    return StatusCode(204);
                }
                catch(Exception ex)
                {
                    _logger.LogError(
                        "Error with GET Employees",
                        ex);

                    return StatusCode(500);
                }
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(
            int id,
            [FromBody] Employee data)
        {
            if (id > 0
                && data != null
                && id == data.Id)
            {
                try
                {
                    await _employeeService.UpdateAsync(
                        id,
                        data);

                    return StatusCode(204);
                }
                catch (Exception ex)
                {
                    _logger.LogError(
                        "Error with GET Employees",
                        ex);

                    return StatusCode(500);
                }
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
