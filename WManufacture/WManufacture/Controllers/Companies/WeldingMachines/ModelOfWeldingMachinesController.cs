using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies.WeldingMachines;
using WManufacture.Infrastructure.Services.WeldingMachines.ModelOfWeldingMachines;

namespace WManufacture.Controllers.Companies.WeldingMachines
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelOfWeldingMachinesController : ControllerBase
    {
        private readonly ILogger<ModelOfWeldingMachinesController> _logger;

        private readonly IModelOfWeldingMachineService _modelOfWeldingMachineService;

        public ModelOfWeldingMachinesController(
            ILogger<ModelOfWeldingMachinesController> logger,
            IModelOfWeldingMachineService modelOfWeldingMachineService)
        {
            _logger = logger;

            _modelOfWeldingMachineService = modelOfWeldingMachineService;
        }

        [HttpGet]
        public async Task<ActionResult<List<ModelOfWeldingMachine>>> GetAsync()
        {
            try
            {
                var list = await _modelOfWeldingMachineService.GetAsync();

                return Ok(list);
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    "Error with GET ModelOfWeldingMachines",
                    ex);

                return StatusCode(500);
            }
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<ModelOfWeldingMachine>> GetAsync(
            int id)
        {
            try
            {
                var item = await _modelOfWeldingMachineService.GetAsync(
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
                    "Error with GET ModelOfWeldingMachines",
                    ex);

                return StatusCode(500);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(
            [FromBody] ModelOfWeldingMachine data)
        {
            if (data != null)
            {
                try
                {
                    await _modelOfWeldingMachineService.CreateAsync(
                        data);

                    return StatusCode(204);
                }
                catch (Exception ex)
                {
                    _logger.LogError(
                        "Error with POST ModelOfWeldingMachines",
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
            [FromBody] ModelOfWeldingMachine data)
        {
            if (id > 0
                && data != null
                && data.Id == id)
            {
                try
                {
                    await _modelOfWeldingMachineService.UpdateAsync(
                        id,
                        data);

                    return StatusCode(204);
                }
                catch (Exception ex)
                {
                    _logger.LogError(
                        "Error with PUT ModelOfWeldingMachines",
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
                    await _modelOfWeldingMachineService.DeleteAsync(
                        id);

                    return StatusCode(204);
                }
                catch (Exception ex)
                {
                    _logger.LogError(
                        "Error with DELETE ModelOfWeldingMachines",
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
