using Business.Abstract;
using Entity.Concrete;
using Entity.Concrete.ViewModels;
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
        private readonly ITruthService _truthService;
        private readonly IDareService _dareService;

        public AdminController(ITruthService truthService, IDareService dareService)
        {
            _truthService = truthService;
            _dareService = dareService;
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
        public JsonResult AddContents(TruthOrDareVM game)
        {

            var list= _truthService.AddContent(game);
            return Json(list);
        }
        public JsonResult AddContents2(TruthOrDareVM game)
        {

            var list = _dareService.AddContents(game);
            return Json(list);
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginRequest loginRequest)
        {
            if (ModelState.IsValid)
            {
                if (loginRequest.username == "admin"
                 && loginRequest.password == "123")
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

