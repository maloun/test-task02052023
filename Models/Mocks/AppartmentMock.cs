using Microsoft.EntityFrameworkCore;
using demo.Models.Database;
using demo.Models.Interfaces;
using demo.Views.ViewData;
using System.Xml;

namespace demo.Models.Mocks
{
    public class AppartmentMock : IAppartments
    {
        AppDbContext _dbContext;

        public AppartmentMock(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<AppartmentsViewData> GetAppartmentsWithVerifyedMeters()
        {
            var result = from d in _dbContext.Appartments
                    .Include(a => a.Meter)
                    .Include(m => m.Meter.Readings)
                    .Where(a => a.Meter.NextVerifyDate > DateTime.Now)
                select new AppartmentsViewData(d);
            
            return result;
        }
    }
}
