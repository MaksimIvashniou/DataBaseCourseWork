using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies.WorkObjects;
using WManufacture.Infrastructure.Databases;

namespace WManufacture.Infrastructure.Services.WorkObjects.BookingWorkObjectTasks
{
    public class BookingWorkObjectTaskService : IBookingWorkObjectTaskService
    {
        private readonly WManufactureContext _db;

        private readonly ILogger<BookingWorkObjectTaskService> _logger;

        public BookingWorkObjectTaskService(
            WManufactureContext db,
            ILogger<BookingWorkObjectTaskService> logger)
        {
            _db = db;

            _logger = logger;
        }

        public async Task CreateAsync(BookingWorkObjectTask data)
        {
            if (data.Id == 0)
            {
                _db.BookingWorkObjectTasks.Add(data);

                await _db.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(int id)
        {
            var bookingWorkOdjectTask = await _db.BookingWorkObjectTasks.FindAsync(id);

            if (bookingWorkOdjectTask != null)
            {
                _db.BookingWorkObjectTasks.Remove(bookingWorkOdjectTask);

                await _db.SaveChangesAsync();
            }
        }

        public async Task<BookingWorkObjectTask> GetAsync(int id)
        {
            var bookingWorkOdjectTask = await _db.BookingWorkObjectTasks.FindAsync(id);

            return bookingWorkOdjectTask;
        }

        public async Task UpdateAsync(
            int id, 
            BookingWorkObjectTask data)
        {
            if (data.Id == id)
            {
                var bookingWorkOdjectTask = await _db.BookingWorkObjectTasks.FindAsync(id);

                if (bookingWorkOdjectTask != null)
                {
                    bookingWorkOdjectTask.StartBooking = data.StartBooking;

                    bookingWorkOdjectTask.EndBooking = data.EndBooking;

                    _db.Update(bookingWorkOdjectTask);

                    await _db.SaveChangesAsync();
                }
            }
        }
    }
}
