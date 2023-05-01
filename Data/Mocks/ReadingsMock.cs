using demo.Data.Interfaces;
using demo.Data.Models;

namespace demo.Data.Implementers
{
    public class ReadingsMock : IReadings
    {
        AppDbContext _dbContext;

        public ReadingsMock(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void UploadAndValidateReadings(ReadingsModel readings)
        {
            _dbContext.Readings.Add(readings);
            _dbContext.SaveChanges();
        }


    }
}