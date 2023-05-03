using Microsoft.AspNetCore.Mvc;
using demo.Models;
using System.Diagnostics;
using demo.Models.Interfaces;

namespace mvc.Controllers
{
    public class AppartmentsReadingsController : Controller
    {
        private readonly IAppartmentsReadings _appartments;

        public AppartmentsReadingsController(IAppartmentsReadings appartments)
        {
            _appartments = appartments;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ViewResult ListValidMeters() 
        {
            var appartments = _appartments.GetAppartmentsWithValidatedMetersReadings();
            return View(appartments);
        }
    }
}