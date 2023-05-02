using demo.Models.Database;
using demo.Views.ViewData;

namespace demo.Models.Interfaces
{
    public interface IAppartments
    {
        public IEnumerable<AppartmentsViewData> GetAppartmentsWithVerifyedMeters();
    }
}
