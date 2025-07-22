using Microsoft.AspNetCore.Mvc;

namespace VoluntariosConectadosRD.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult ProfileONG()
        {
            return View();
        }
    }
}
