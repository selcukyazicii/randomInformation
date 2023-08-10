using Entity.Concrete;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Business.Abstract.BiDijitalMedya;
using Core.Utilties.Results;
using Business.Constants;
using System.Linq.Dynamic.Core;

namespace drone.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAboutUsService _aboutUsService;
        private readonly IAboutService _aboutService;
        public AdminController(IAboutUsService aboutUsService, IAboutService aboutService)
        {
            _aboutUsService = aboutUsService;
            _aboutService = aboutService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Hakkimizda()
        {
            return View(new bidijital_about());
        }
        public IActionResult Login()
        {
            return View();
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

                    return RedirectToAction("Panel", "Admin");
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
        //[Authorize]
        public IActionResult Panel()
        {
            return View();
        }
        public async Task<IActionResult> AddAboutUs(bidijital_about about)
        {
            if (about != null)
            {
                await _aboutService.AddAboutUs(about);
                return Json(new ResultModel { Success = true, Message = Messages.SuccessAddMessage });
            }
            return Json(new ResultModel { Success = false, Message = Messages.Error});
        }
        public async Task<JsonResult> ListAbout()
        {
            var result = await _aboutService.AboutList();
            return Json(new ResultModel { Data= result,Message=Messages.Success ,Success=true});
        }
    }
}
