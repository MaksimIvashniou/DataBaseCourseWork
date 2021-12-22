using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies.Employees;
using WManufacture.Infrastructure.Services.Employees.Positions;

namespace WManufacture.Controllers.Employees
{
    [Route("api/[controller]")]
    [ApiController]
    public class PositionsController : ControllerBase
    {
        private readonly ILogger<PositionsController> _logger;

        private readonly IPositionService _positionService;

        public PositionsController(
            ILogger<PositionsController> logger,
            IPositionService positionService)
        {
            _logger = logger;

            _positionService = positionService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Position>>> GetAsync()
        {
            try
            {
                var list = await _positionService.GetAsync();

                return Ok(list);
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    "Error with GET Positions",
                    ex);

                return StatusCode(500);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Position>> GetAsync(
            int id)
        {
            try
            {
                var item = _positionService.GetAsync(id);

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
                    "Error with GET Positions",
                    ex);

                return StatusCode(500);
            }
        }

        [HttpPost]
        public async Task<ActionResult> CreateAsync(
            [FromBody] Position data)
        {
            if (data != null)
            {
                try
                {
                    await _positionService.CreateAsync(data);

                    return StatusCode(204);
                }
                catch (Exception ex)
                {
                    _logger.LogError(
                        "Error with POST Positions",
                        ex);

                    return StatusCode(500);
                }
            }
            else
            {
                return BadRequest(500);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(
            int id,
            [FromBody] Position data)
        {
            if (id > 0
                && data != null
                && data.Id == id)
            {
                try
                {
                    await _positionService.UpdateAsync(
                        id,
                        data);

                    return StatusCode(204);
                }
                catch (Exception ex)
                {
                    _logger.LogError(
                        "Error with PUT Positions",
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
                    await _positionService.DeleteAsync(
                        id);

                    return StatusCode(204);
                }
                catch (Exception ex)
                {
                    _logger.LogError(
                        "Error with DELETE Positions",
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
