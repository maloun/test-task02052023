using demo.Data.Models;
using System.Diagnostics.Metrics;

namespace demo.Data.Interfaces
{
    public interface IReadings
    {
        public void UploadAndValidateReadings(ReadingsModel readings);
    }
}
