using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies.WeldingMachines;
using WManufacture.Infrastructure.Services.WeldingMachines.ModelCharacteristics;

namespace WManufacture.Controllers.WeldingMachines
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelCharacteristicsController : ControllerBase
    {
        private readonly ILogger<ModelCharacteristicsController> _logger;

        private readonly IModelCharacteristicService _modelCharacteristicService;

        public ModelCharacteristicsController(
            ILogger<ModelCharacteristicsController> logger,
            IModelCharacteristicService modelCharacteristicService)
        {
            _logger = logger;

            _modelCharacteristicService = modelCharacteristicService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ModelCharacteristic>> GetAsync(
            int id)
        {
            try
            {
                var item = _modelCharacteristicService.GetAsync(
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
                    "Error with GET ModelCharacteristics",
                    ex);

                return StatusCode(500);
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(
            [FromBody] ModelCharacteristic data)
        {
            if (data != null)
            {
                try
                {
                    await _modelCharacteristicService.CreateAsync(
                        data);

                    return StatusCode(204);
                }
                catch (Exception ex)
                {
                    _logger.LogError(
                        "Error with POST ModelCharacteristics",
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
            [FromBody] ModelCharacteristic data)
        {
            if (id > 0
                && data != null
                && data.Id == id)
            {
                try
                {
                    await _modelCharacteristicService.UpdateAsync(
                        id,
                        data);

                    return StatusCode(204);
                }
                catch (Exception ex)
                {
                    _logger.LogError(
                        "Error with PUT ModelCharacteristics",
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
                    await _modelCharacteristicService.DeleteAsync(
                        id);

                    return StatusCode(204);
                }
                catch (Exception ex)
                {
                    _logger.LogError(
                        "Error with DELETE ModelCharacteristics",
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
