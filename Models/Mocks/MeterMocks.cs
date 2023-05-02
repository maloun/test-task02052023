using demo.Models.Database;
using demo.Models.Interfaces;

namespace demo.Models.Mocks
{
    public class MetersMock : IMeters
    {
        AppDbContext _dbContext;

        public MetersMock(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<MetersTable> GetMetersInBuilding(int buildingId)
        {
            var result = _dbContext.Meters;
            return result;
        }
    }

}
