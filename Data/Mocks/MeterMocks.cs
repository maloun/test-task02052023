using demo.Data.Interfaces;
using demo.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace demo.Data.Mocks
{
    public class MetersMock : IMeters
    {
        AppDbContext _dbContext;

        public MetersMock(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<MeterModel> GetMetersInBuilding(int buildingId)
        {
            var result = _dbContext.Meters;
            return result;
        }
    }

}
