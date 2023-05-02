using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using demo.Models;
using System.Diagnostics;
using Microsoft.Extensions.Logging;
using demo.Models.Interfaces;

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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ViewResult ListVerifyedMeters() 
        {
            ViewBag.Title = "Показания счётчиков в квартирах";
            var appartments = _appartments.GetAppartmentsWithVerifyedMeters();

            //if (!appartments.Any())
            //   throw new Exception("Не найдено ни одного результата");

            return View(appartments);
        }
    }
}