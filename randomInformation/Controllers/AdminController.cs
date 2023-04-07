using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace randomInformation.Controllers
{
    public class AdminController : Controller
    {
        private readonly IGameService _gameService;
        private readonly IGame2Service _game2Service;

        public AdminController(IGameService gameService, IGame2Service game2Service)
        {
            _gameService = gameService;
            _game2Service = game2Service;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [Authorize]
        public IActionResult AddContent()
        {
            return View();
        }
        public JsonResult AddContents(Game game)
        {
            var list=_gameService.AddContent(game);
            return Json(list);
        }
        public JsonResult AddContents2(Game2 game)
        {
            var list = _game2Service.AddContent(game);
            return Json(list);
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginRequest loginRequest)
        {
            if (ModelState.IsValid)
            {
                if (loginRequest.username == "admin"
                 && loginRequest.password == "allah")
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.NameIdentifier, loginRequest.username),
                        new Claim(ClaimTypes.Name, loginRequest.username)
                    };

                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var authProperties = new AuthenticationProperties
                    {
                    };

                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                                                  new ClaimsPrincipal(claimsIdentity),
                                                  authProperties);

                    return RedirectToAction("GetPanel", "Admin");
                }
                else
                {
                    ModelState.AddModelError("Password", "Username or Password wrong !");
                }
            }


            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();

            return RedirectToAction("Login");
        }
        [Authorize]
        public IActionResult GetPanel()
        {
            return View();
        }
    }
}

