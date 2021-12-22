using System.Threading.Tasks;
using WManufacture.Common.Entity.Companies.WorkObjects;

namespace WManufacture.Infrastructure.Services.BookingWorkObjectTasks
{
    public interface IBookingWorkObjectTaskService
    {
        Task<BookingWorkObjectTask> GetAsync(int id);

        Task CreateAsync(BookingWorkObjectTask data);

        Task UpdateAsync(
            int id,
            BookingWorkObjectTask data);

        Task DeleteAsync(int id);
    }
}
