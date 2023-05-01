using demo.Data.Models;

namespace demo.Data.Interfaces
{
    public interface IMeters
    {
        public IEnumerable<MeterModel> GetMetersInBuilding(int buildingId);
    }
}
