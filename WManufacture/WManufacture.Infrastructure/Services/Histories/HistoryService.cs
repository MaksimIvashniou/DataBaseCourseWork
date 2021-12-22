using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using WManufacture.Common.Entity;
using WManufacture.Infrastructure.Databases;

namespace WManufacture.Infrastructure.Services.Histories
{
    public class HistoryService : IHistoryService
    {
        private readonly WManufactureContext _db;

        private readonly ILogger<HistoryService> _logger;

        public HistoryService(
            WManufactureContext db,
            ILogger<HistoryService> logger)
        {
            _db = db;

            _logger = logger;
        }

        public async Task CreateAsync(History data)
        {
            if (data.Id == 0)
            {
                _db.Histories.Add(data);

                await _db.SaveChangesAsync();
            }
        }
    }
}
