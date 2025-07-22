using Microsoft.AspNetCore.Mvc;

namespace VoluntariosConectadosRD.Controllers
{
    public class AccountController : Controller
    {
        private readonly IConfiguration _configuration;

        public AccountController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View(new VoluntariosConectadosRD.Models.LoginViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(VoluntariosConectadosRD.Models.LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Profile", "Dashboard");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Registro()
        {
            return View(new VoluntariosConectadosRD.Models.RegistroViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Registro(VoluntariosConectadosRD.Models.RegistroViewModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("RegistroExito", "Account");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult RegistroONG()
        {
            return View(new VoluntariosConectadosRD.Models.RegistroONGViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RegistroONG(VoluntariosConectadosRD.Models.RegistroONGViewModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("RegistroExito", "Account");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult RegistroExito()
        {
            return View();
        }
    }
} 
