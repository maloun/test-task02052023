using demo.Data.Mocks;
using demo.Data.Models;

namespace demo.Data.Interfaces
{
    public interface IAppartments
    {       
        public IEnumerable<AppartmentModel> GetAppartmentsWithVerifyedMeters();
    }
}
