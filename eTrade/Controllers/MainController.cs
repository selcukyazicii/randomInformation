using Microsoft.AspNetCore.Mvc;

namespace eTrade.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
