using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace Vu_Victoria_HW1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _environment;
        public HomeController(IWebHostEnvironment environment)
        {
            _environment = environment;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Interests()
        {
            return View();
        }
        public IActionResult Gallery()
        {
            return View();
        }

        public IActionResult Resume()
        {

            string path = _environment.WebRootPath + "/files/Victoria Vu Resume 333K.pdf";
            var stream = new FileStream(path, FileMode.Open);
            return File(stream, "application/pdf", "Victoria Vu Resume 333K.pdf");
        }
     

    }


}