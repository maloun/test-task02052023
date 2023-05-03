using demo.Models.Database;
using demo.Views.EnterReadings;
using System.Diagnostics.Metrics;

namespace demo.Models.Interfaces
{
    public interface IEnterReadings
    {
        public bool ValidateAndUploadReadings(EnterReadingsData readings);
    }
}