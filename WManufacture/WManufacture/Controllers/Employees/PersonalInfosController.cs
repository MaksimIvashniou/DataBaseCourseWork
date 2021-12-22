using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies.Employees;
using WManufacture.Infrastructure.Services.Employees.PersonalInfos;

namespace WManufacture.Controllers.Employees
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonalInfosController : ControllerBase
    {
        private readonly ILogger<PersonalInfosController> _logger;

        private readonly IPersonalInfoService _personalInfoService;

        public PersonalInfosController(
            ILogger<PersonalInfosController> logger,
            IPersonalInfoService personalInfoService)
        {
            _logger = logger;

            _personalInfoService = personalInfoService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PersonalInfo>> GetAsync(
            int id)
        {
            try
            {
                var item = _personalInfoService.GetAsync(
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
                    "Error with GET PersonalInfos",
                    ex);

                return StatusCode(500);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(
            [FromBody] PersonalInfo data)
        {
            if (data != null)
            {
                try
                {
                    await _personalInfoService.CreateAsync(
                        data);

                    return StatusCode(204);
                }
                catch (Exception ex)
                {
                    _logger.LogError(
                        "Error wirth POST PersonalInfos",
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
            [FromBody] PersonalInfo data)
        {
            if (id > 0
                && data != null
                && data.Id == id)
            {
                try
                {
                    await _personalInfoService.UpdateAsync(
                        id,
                        data);

                    return StatusCode(204);
                }
                catch (Exception ex)
                {
                    _logger.LogError(
                        "Error with PUT PersonalInfos",
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
                    await _personalInfoService.DeleteAsync(
                        id);

                    return StatusCode(204);
                }
                catch (Exception ex)
                {
                    _logger.LogError(
                        "Error with DELETE PersonalInfos",
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
