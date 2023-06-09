using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace randomInformation.Controllers
{
    public class GameController : Controller
    {
        private readonly ITruthService _gameService;
        private readonly IDareService _game2Service;
        public GameController(ITruthService gameService,IDareService game2Service)
        {
            _gameService = gameService;
            _game2Service = game2Service;   
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(new Truth());
        }
        public JsonResult GetTruth()
        {
            var result = _gameService.GetTruth();
            return Json(result);
        }
        public JsonResult GetDare()
        {
            var result = _game2Service.GetDare();
            return Json(result);
        }
        public IActionResult TruthOrDare()
        {
            return View(new Truth());
        }
    }
}
