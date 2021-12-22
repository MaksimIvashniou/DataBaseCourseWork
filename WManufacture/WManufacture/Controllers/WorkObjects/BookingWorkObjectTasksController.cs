using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies.WorkObjects;
using WManufacture.Infrastructure.Services.WorkObjects.BookingWorkObjectTasks;

namespace WManufacture.Controllers.WorkObjects
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingWorkObjectTasksController : ControllerBase
    {
        private readonly ILogger<BookingWorkObjectTasksController> _logger;

        private readonly IBookingWorkObjectTaskService _bookingWorkObjectTaskService;

        public BookingWorkObjectTasksController(
            ILogger<BookingWorkObjectTasksController> logger,
            IBookingWorkObjectTaskService bookingWorkObjectTaskService)
        {
            _logger = logger;

            _bookingWorkObjectTaskService = bookingWorkObjectTaskService;
        }

        [HttpGet]
        public async Task<ActionResult<List<BookingWorkObjectTask>>> GetAsync()
        {
            try
            {
                var list = await _bookingWorkObjectTaskService.GetAsync();

                return Ok(list);
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    "Error with GET BookingWorkObjectTasks",
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
                var item = _bookingWorkObjectTaskService.GetAsync(
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
                    "Error with GET BookingWorkObjectTasks",
                    ex);

                return StatusCode(500);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(
            [FromBody] BookingWorkObjectTask data)
        {
            if (data != null)
            {
                try
                {
                    await _bookingWorkObjectTaskService.CreateAsync(
                        data);

                    return StatusCode(204);
                }
                catch (Exception ex)
                {
                    _logger.LogError(
                        "Error with POST BookingWorkObjectTasks",
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
            [FromBody] BookingWorkObjectTask data)
        {
            if (id > 0
                && data != null
                && data.Id == id)
            {
                try
                {
                    await _bookingWorkObjectTaskService.UpdateAsync(
                        id,
                        data);

                    return StatusCode(204);
                }
                catch (Exception ex)
                {
                    _logger.LogError(
                        "Error with PUT BookingWorkObjectTasks",
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
                    await _bookingWorkObjectTaskService.DeleteAsync(
                        id);

                    return StatusCode(204);
                }
                catch (Exception ex)
                {
                    _logger.LogError(
                        "Error with DELETE BookingWorkObjectTasks",
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
