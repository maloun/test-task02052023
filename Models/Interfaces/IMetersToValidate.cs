using demo.Models.Database;
using demo.Views.Meters;

namespace demo.Models.Interfaces
{
    public interface IMetersToValidate
    {
        public IEnumerable<ListInvalidMetersData> GetMetersToValidate();
    }
}