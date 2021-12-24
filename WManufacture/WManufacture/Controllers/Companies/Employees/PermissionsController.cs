using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies.Employees;
using WManufacture.Infrastructure.Services.Employees.Permissions;

namespace WManufacture.Controllers.Companies.Employees
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionsController : ControllerBase
    {
        private readonly ILogger<PermissionsController> _logger;

        private readonly IPermissionService _permissionService;

        public PermissionsController(
            ILogger<PermissionsController> logger,
            IPermissionService permissionService)
        {
            _logger = logger;

            _permissionService = permissionService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Permission>> GetAsync(
            int id)
        {
            try
            {
                var item = await _permissionService.GetAsync(
                    id);

                if (item != null)
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
                    "Error with GET Permissions",
                    ex);

                return StatusCode(500);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(
            [FromBody] Permission data)
        {
            if (data != null)
            {
                try
                {
                    await _permissionService.CreateAsync(
                        data);

                    return StatusCode(204);
                }
                catch (Exception ex)
                {
                    _logger.LogError(
                        "Error with POST Permissions",
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
            [FromBody] Permission data)
        {
            if (id > 0
                && data != null
                && data.Id == id)
            {
                try
                {
                    await _permissionService.UpdateAsync(
                        id,
                        data);

                    return StatusCode(204);
                }
                catch (Exception ex)
                {
                    _logger.LogError(
                        "Error with PUT Permissions",
                        ex);

                    return StatusCode(500);
                }
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(
            int id)
        {
            if (id > 0)
            {
                try
                {
                    await _permissionService.DeleteAsync(
                        id);

                    return StatusCode(204);
                }
                catch (Exception ex)
                {
                    _logger.LogError(
                        "Error with DELETE Permissions",
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
