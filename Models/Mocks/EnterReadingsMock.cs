using demo.Models.Database;
using demo.Models.Interfaces;
using demo.Views.EnterReadings;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System.Diagnostics.Metrics;

namespace demo.Models.Mocks
{
    public class EnterReadingsMock : IEnterReadings
    {
        AppDbContext _dbContext;

        public EnterReadingsMock(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool ValidateAndUploadReadings(EnterReadingsData readings)
        {
            var meter = _dbContext.Meters.Where(m => m.Number == readings.MeterNumber);
            if (!meter.Any())
                return false;

            var greaterReadings = meter.Include(m => m.Readings).First().Readings.Where(
                r => r.Value > readings.MeterValue
            );
            if (greaterReadings.Any())
                return false;

            _dbContext.Readings.Add(
                new ReadingsTable()
                {
                    MeterId = meter.First().Id,
                    Value = readings.MeterValue,
                    Date = DateTime.Now
                }
            );
            _dbContext.SaveChanges();
            return true;
        }
    }
}