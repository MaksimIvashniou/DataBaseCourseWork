using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies.WorkObjects;
using WManufacture.Infrastructure.Services.WorkObjects.WorkObjectResults;

namespace WManufacture.Controllers.WorkObjects
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkObjectResultsController : ControllerBase
    {
        private readonly ILogger<WorkObjectResultsController> _logger;

        private readonly IWorkObjectResultService _workObjectResultService;

        public WorkObjectResultsController(
            ILogger<WorkObjectResultsController> logger,
            IWorkObjectResultService workObjectResultService)
        {
            _logger = logger;

            _workObjectResultService = workObjectResultService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<WorkObjectResult>> GetAsync(
            int id)
        {
            try
            {
                var item = _workObjectResultService.GetAsync(
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
                    "Error with GET WorkObjectResults",
                    ex);

                return StatusCode(500);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(
            [FromBody] WorkObjectResult data)
        {
            if (data != null)
            {
                try
                {
                    await _workObjectResultService.CreateAsync(
                        data);

                    return StatusCode(204);
                }
                catch (Exception ex)
                {
                    _logger.LogError(
                        "Error with POST WorkObjectResults",
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
            [FromBody] WorkObjectResult data)
        {
            if (id > 0
                && data != null
                && data.Id == id)
            {
                try
                {
                    await _workObjectResultService.UpdateAsync(
                        id,
                        data);

                    return StatusCode(204);
                }
                catch (Exception ex)
                {
                    _logger.LogError(
                        "Error with PUT WorkObjectResults",
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
                    await _workObjectResultService.DeleteAsync(
                        id);

                    return StatusCode(204);
                }
                catch (Exception ex)
                {
                    _logger.LogError(
                        "Error with DELETE WorkObjectResults",
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
