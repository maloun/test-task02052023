using demo.Models.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace demo.Controllers
{
    public class MetersToValidateController : Controller
    {
        IMetersToValidate _meters;

        public MetersToValidateController(IMetersToValidate meters)
        {
            _meters = meters;
        }

        public ViewResult ListInvalidMeters()
        {
            var meters = _meters.GetMetersToValidate();              
            return View(meters);
        }
    }
}
