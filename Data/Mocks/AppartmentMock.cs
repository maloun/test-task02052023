using demo.Data.Interfaces;
using demo.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace demo.Data.Mocks
{
    public class AppartmentMock : IAppartments
    {
        AppDbContext _dbContext;

        public AppartmentMock(AppDbContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public IEnumerable<AppartmentModel> GetAppartmentsWithVerifyedMeters()
        {
            var result = _dbContext.Appartments
                .Include(c => c.Meter)
                .Where(a => a.Meter.NextVerifyDate > DateTime.Now);                 
            return result;                  
        }
    }
}
