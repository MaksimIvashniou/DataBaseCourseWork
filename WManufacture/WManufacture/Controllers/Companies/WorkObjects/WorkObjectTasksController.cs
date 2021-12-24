using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies.WorkObjects;
using WManufacture.Infrastructure.Services.WorkObjects.WorkObjectTasks;

namespace WManufacture.Controllers.Companies.WorkObjects
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkObjectTasksController : ControllerBase
    {
        private readonly ILogger<WorkObjectTasksController> _logger;

        private readonly IWorkObjectTaskService _workObjectTaskService;

        public WorkObjectTasksController(
            ILogger<WorkObjectTasksController> logger,
            IWorkObjectTaskService workObjectTaskService)
        {
            _logger = logger;

            _workObjectTaskService = workObjectTaskService;
        }

        [HttpGet]
        public async Task<ActionResult<List<WorkObjectTask>>> GetAsync()
        {
            try
            {
                var list = await _workObjectTaskService.GetAsync();

                return Ok(list);
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    "Error with GET WorkObjectTasks",
                    ex);

                return StatusCode(500);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<WorkObjectTask>> GetAsync(
            int id)
        {
            try
            {
                var item = await _workObjectTaskService.GetAsync(
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
                    "Error with GET WorkObjectTasks",
                    ex);

                return StatusCode(500);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(
            [FromBody] WorkObjectTask data)
        {
            if (data != null)
            {
                try
                {
                    await _workObjectTaskService.CreateAsync(
                        data);

                    return StatusCode(204);
                }
                catch (Exception ex)
                {
                    _logger.LogError(
                        "Error with POST WorkObjectTasks",
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
            [FromBody] WorkObjectTask data)
        {
            if (id > 0
                && data != null
                && data.Id == id)
            {
                try
                {
                    await _workObjectTaskService.UpdateAsync(
                        id,
                        data);

                    return StatusCode(204);
                }
                catch (Exception ex)
                {
                    _logger.LogError(
                        "Error with PUT WorkObjectTasks",
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
                    await _workObjectTaskService.DeleteAsync(
                        id);

                    return StatusCode(204);
                }
                catch (Exception ex)
                {
                    _logger.LogError(
                        "Error with DELETE WorkObjectTasks",
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
