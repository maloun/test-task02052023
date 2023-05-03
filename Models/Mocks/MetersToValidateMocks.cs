using demo.Models.Database;
using demo.Models.Interfaces;
using demo.Views.Appartments;
using demo.Views.Meters;
using demo.Views.Shared;
using Microsoft.EntityFrameworkCore;

namespace demo.Models.Mocks
{
    public class MetersMock : IMetersToValidate
    {
        AppDbContext _dbContext;

        public MetersMock(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<ListInvalidMetersData> GetMetersToValidate()
        {
            var result =
                from d in _dbContext.Meters
                    .Include(m => m.Appartment)
                    .Where(m => m.NextVerifyDate <= DateTime.Now && m.Appartment != null)                    
                select new ListInvalidMetersData()
                {
                    Address = AppartmentAddress.FromXml(d.Appartment.Name),
                    MeterNumber = d.Number
                };
            return result;
        }

    }
}
