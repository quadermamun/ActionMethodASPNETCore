using Microsoft.AspNetCore.Mvc;

namespace ControllersAndActions.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Display()
        {
            return "Welcome to Mamun";
        }

        public int DisplayId(int id)
        {
            return id;
        }
    }
}
