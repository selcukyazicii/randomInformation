using Microsoft.AspNetCore.Mvc;

namespace randomInformation.Controllers
{
    public class InformationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
