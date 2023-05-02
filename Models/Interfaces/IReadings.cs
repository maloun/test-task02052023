using demo.Models.Database;
using System.Diagnostics.Metrics;

namespace demo.Models.Interfaces
{
    public interface IReadings
    {
        public void UploadAndValidateReadings(ReadingsTable readings);
    }
}
