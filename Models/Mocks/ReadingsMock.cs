using demo.Models.Database;
using demo.Models.Interfaces;

namespace demo.Models.Mocks
{
    public class ReadingsMock : IReadings
    {
        AppDbContext _dbContext;

        public ReadingsMock(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void UploadAndValidateReadings(ReadingsTable readings)
        {
            _dbContext.Readings.Add(readings);
            _dbContext.SaveChanges();
        }
    }
}