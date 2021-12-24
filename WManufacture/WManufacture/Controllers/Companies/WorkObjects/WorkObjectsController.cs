using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies.WorkObjects;
using WManufacture.Infrastructure.Services.WorkObjects;

namespace WManufacture.Controllers.Companies.WorkObjects
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkObjectsController : ControllerBase
    {
        private readonly ILogger<WorkObjectsController> _logger;

        private readonly IWorkObjectService _workObjectService;

        public WorkObjectsController(
            ILogger<WorkObjectsController> logger,
            IWorkObjectService workObjectService)
        {
            _logger = logger;

            _workObjectService = workObjectService;
        }

        [HttpGet]
        public async Task<ActionResult<List<WorkObject>>> GetAsync()
        {
            try
            {
                var list = await _workObjectService.GetAsync();

                return Ok(list);
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    "Error with GET WorkObjects",
                    ex);

                return StatusCode(500);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<WorkObject>> GetAsync(
            int id)
        {
            try
            {
                var item = await _workObjectService.GetAsync(
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
                    "Error with GET WorkObjects",
                    ex);

                return StatusCode(500);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(
            [FromBody] WorkObject data)
        {
            if (data != null)
            {
                try
                {
                    await _workObjectService.CreateAsync(
                        data);

                    return StatusCode(204);
                }
                catch (Exception ex)
                {
                    _logger.LogError(
                        "Error with POST WorkObjects",
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
            [FromBody] WorkObject data)
        {
            if (id > 0
                && data != null
                && data.Id == id)
            {
                try
                {
                    await _workObjectService.UpdateAsync(
                        id,
                        data);

                    return StatusCode(204);
                }
                catch (Exception ex)
                {
                    _logger.LogError(
                        "Error with PUT WorkObjects",
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
                    await _workObjectService.DeleteAsync(
                        id);

                    return StatusCode(204);
                }
                catch (Exception ex)
                {
                    _logger.LogError(
                        "Error with DELETE WorkObjects",
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
