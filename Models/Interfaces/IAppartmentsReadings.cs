using demo.Views.Appartments;

namespace demo.Models.Interfaces
{
    public interface IAppartmentsReadings
    {
        public IEnumerable<ListValidMetersData> GetAppartmentsWithValidatedMetersReadings();
    }
}