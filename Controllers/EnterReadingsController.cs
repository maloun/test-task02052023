using demo.Models.Interfaces;
using demo.Views.EnterReadings;
using Microsoft.AspNetCore.Mvc;

namespace demo.Controllers
{
    public class EnterReadingsController : Controller
    {
        IEnterReadings _readings;

        public EnterReadingsController(IEnterReadings readings)
        {
            _readings = readings;
        }

        public ViewResult EnterReadings() => View();
  

        [HttpPost]
        public string EnterReadings(EnterReadingsData readings) 
        {
            if (_readings.ValidateAndUploadReadings(readings))
                return "показания добавлены";
            else
                return "ошибка добавления";
        }

    }
}
