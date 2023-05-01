using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using demo.Data.Interfaces;
using demo.Models;
using System.Diagnostics;
using Microsoft.Extensions.Logging;

namespace mvc.Controllers
{
    public class AppartmentsController : Controller
    {
        private readonly IAppartments _appartments;
        private readonly ILogger<AppartmentsController> _logger;

        public AppartmentsController(IAppartments appartments, ILogger<AppartmentsController> logger)
        {
            _logger = logger;
            _appartments = appartments;
        }

        public ViewResult ListVerifyedMeters()
        {
            ViewBag.Title = "Показания счётчиков в квартирах";
            var appartments = _appartments.GetAppartmentsWithVerifyedMeters();
            return View(appartments);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}