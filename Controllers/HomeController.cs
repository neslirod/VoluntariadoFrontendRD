using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using VoluntariosConectadosRD.Models;

namespace VoluntariosConectadosRD.Controllers
{

    //Prueba del docente Omar
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        // NUEVAS ACCIONES PARA NAVEGACIÓN
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Registro()
        {
            return View();
        }

        [HttpGet]
        public IActionResult RegistroONG()
        {
            return View();
        }

        [HttpGet]
        public IActionResult RegistroExito()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RegistroONG(string nombre, string email, string rnc,string telefono, string direccion, string ciudad, string provincia, string sector, string descripcion, string logoONGURL)
        {
            // TODO: Handle form data, save to DB, etc.
            // Redirect to success page after processing
            return RedirectToAction("RegistroExito");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult ProfileONG()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
