using Microsoft.EntityFrameworkCore;
using demo.Models.Database;
using demo.Models.Interfaces;
using demo.Views.Appartments;
using demo.Views.Shared;

namespace demo.Models.Mocks
{
    public class AppartmentsReadingsMock : IAppartmentsReadings
    {
        AppDbContext _dbContext;

        public AppartmentsReadingsMock(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<ListValidMetersData> GetAppartmentsWithValidatedMetersReadings()
        {
            var result =
                from d in _dbContext.Appartments
                    .Include(a => a.Meter)
                    .Include(m => m.Meter.Readings)
                    .Where(a => a.Meter.NextVerifyDate > DateTime.Now)
                select new ListValidMetersData()
                {
                    Address = AppartmentAddress.FromXml(d.Name),
                    MeterNumber = d.Meter.Number,
                    MeterValue = d.Meter.Readings
                        .Where(w => w.Date == d.Meter.Readings.Max(w => w.Date))
                        .Select(d => d.Value)
                        .FirstOrDefault()
                };

            return result;
        }
    }
}
