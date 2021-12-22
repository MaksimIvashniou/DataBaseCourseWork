using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies.WorkObjects;
using WManufacture.Infrastructure.Services.WorkObjects.WorkObjectTaskResults;

namespace WManufacture.Controllers.WorkObjects
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkObjectTaskResultsController : ControllerBase
    {
        private readonly ILogger<WorkObjectTaskResultsController> _logger;

        private readonly IWorkObjectTaskResultService _workObjectTaskResultService;

        public WorkObjectTaskResultsController(
            ILogger<WorkObjectTaskResultsController> logger,
            IWorkObjectTaskResultService workObjectTaskResultService)
        {
            _logger = logger;

            _workObjectTaskResultService = workObjectTaskResultService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<WorkObjectTaskResult>> GetAsync(
            int id)
        {
            try
            {
                var item = _workObjectTaskResultService.GetAsync(
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
                    "Error with GET WorkObjectTaskResults",
                    ex);

                return StatusCode(500);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(
            [FromBody] WorkObjectTaskResult data)
        {
            if (data != null)
            {
                try
                {
                    await _workObjectTaskResultService.CreateAsync(
                        data);

                    return StatusCode(204);
                }
                catch (Exception ex)
                {
                    _logger.LogError(
                        "Error with POST WorkObjectTaskResults",
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
            [FromBody] WorkObjectTaskResult data)
        {
            if (id > 0
                && data != null
                && data.Id == id)
            {
                try
                {
                    await _workObjectTaskResultService.UpdateAsync(
                        id,
                        data);

                    return StatusCode(204);
                }
                catch (Exception ex)
                {
                    _logger.LogError(
                        "Error with PUT WorkObjectTaskResults",
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
                    await _workObjectTaskResultService.DeleteAsync(
                        id);

                    return StatusCode(204);
                }
                catch (Exception ex)
                {
                    _logger.LogError(
                        "Error with DELETE WorkObjectTaskResults",
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
