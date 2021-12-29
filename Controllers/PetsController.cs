using Microsoft.AspNetCore.Mvc;

namespace SalvandoHuellas.Controllers
{
    public class PetsController: Controller
    {
        public IActionResult Index(){
            return View();
        }
        public IActionResult Contactanos(){
            return View();
        }
    }
}