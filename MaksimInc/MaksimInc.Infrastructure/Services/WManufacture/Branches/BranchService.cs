using MaksimInc.Infrastructure.Databases;
using Microsoft.Extensions.Logging;

namespace MaksimInc.Infrastructure.Services.WManufacture.Branches
{
    public class BranchService : IBranchService
    {
        private readonly WManufactureContext _db;

        private readonly ILogger<BranchService> _logger;

        public BranchService(
            WManufactureContext db,
            ILogger<BranchService> logger)
        {
            _db = db;

            _logger = logger;
        }
    }
}
