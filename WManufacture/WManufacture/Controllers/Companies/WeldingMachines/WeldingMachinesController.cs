using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies.WeldingMachines;
using WManufacture.Infrastructure.Services.WeldingMachines;

namespace WManufacture.Controllers.Companies.WeldingMachines
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeldingMachinesController : ControllerBase
    {
        private readonly ILogger<WeldingMachinesController> _logger;

        private readonly IWeldingMachineService _weldingMachineService;

        public WeldingMachinesController(
            ILogger<WeldingMachinesController> logger,
            IWeldingMachineService weldingMachineService)
        {
            _logger = logger;

            _weldingMachineService = weldingMachineService;
        }

        [HttpGet]
        public async Task<ActionResult<List<WeldingMachine>>> GetAsync()
        {
            try
            {
                var list = await _weldingMachineService.GetAsync();

                return Ok(list);
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    "Error with GET WeldingMachines",
                    ex);

                return StatusCode(500);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<WeldingMachine>> GetAsync(
            int id)
        {
            try
            {
                var item = await _weldingMachineService.GetAsync(
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
                    "Erro with GET WeldingMachines",
                    ex);

                return StatusCode(500);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(
            [FromBody] WeldingMachine data)
        {
            if (data != null)
            {
                try
                {
                    await _weldingMachineService.CreateAsync(
                        data);

                    return StatusCode(204);
                }
                catch (Exception ex)
                {
                    _logger.LogError(
                        "Error with POST WeldingMachines",
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
            [FromBody] WeldingMachine data)
        {
            if (id > 0
                && data != null
                && data.Id == id)
            {
                try
                {
                    await _weldingMachineService.UpdateAsync(
                        id,
                        data);

                    return StatusCode(204);
                }
                catch (Exception ex)
                {
                    _logger.LogError(
                        "Error with PUT WeldingMachines",
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
                    await _weldingMachineService.DeleteAsync(
                        id);

                    return StatusCode(204);
                }
                catch (Exception ex)
                {
                    _logger.LogError(
                        "Error with DELETE WeldingMachines",
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
