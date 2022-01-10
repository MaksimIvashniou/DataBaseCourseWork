using MaksimInc.Infrastructure.Databases;
using Microsoft.Extensions.Logging;

namespace MaksimInc.Infrastructure.Services.PManufacture.Branches
{
    public class BranchService : IBranchService
    {
        private readonly PManufactureContext _db;

        private readonly ILogger<BranchService> _logger;

        public BranchService(
            PManufactureContext db,
            ILogger<BranchService> logger)
        {
            _db = db;

            _logger = logger;
        }
    }
}
