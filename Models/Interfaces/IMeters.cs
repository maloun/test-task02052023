using demo.Models.Database;

namespace demo.Models.Interfaces
{
    public interface IMeters
    {
        public IEnumerable<MetersTable> GetMetersInBuilding(int buildingId);
    }
}
