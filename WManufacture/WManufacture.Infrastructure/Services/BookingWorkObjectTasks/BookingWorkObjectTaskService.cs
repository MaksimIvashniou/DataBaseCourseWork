using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies.WorkObjects;
using WManufacture.Infrastructure.Databases;

namespace WManufacture.Infrastructure.Services.BookingWorkObjectTasks
{
    public class BookingWorkObjectTaskService : IBookingWorkObjectTaskService
    {
        private readonly WManufactureContext _db;

        public BookingWorkObjectTaskService(WManufactureContext db)
        {
            _db = db;
        }

        public async Task<BookingWorkObjectTask> CreateAsync(BookingWorkObjectTask data)
        {
            if (data.Id <= 0)
            {
                _db.BookingWorkObjectTasks.Add(data);

                await _db.SaveChangesAsync();

                return data;
            }

            return null;
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

        public async Task<BookingWorkObjectTask> UpdateAsync(
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

                    return data;
                }
            }

            return null;
        }
    }
}
