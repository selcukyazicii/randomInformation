using Business.Abstract.BiDijitalMedya;
using Core.Utilties.Results;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace biPlatformKBB.Controllers
{
    public class MainController : Controller
    {
        private readonly IContactService _contactService;
        public MainController(IContactService contactService)
        {
            _contactService = contactService;
        }
        public IActionResult Iletisim()
        {
            return View();
        }
        public IActionResult Anasayfa()
        {
            return View();
        }
        public IActionResult Galeri()
        {
            return View();
        }
        public IActionResult Hakkimizda()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult>AddContact(bidijital_contact contact)
        {
            if (contact != null)
            {
                await _contactService.AddContact(contact);
                return Json(new ResultModel { Success = true, Message = "İşlem Başarılı" });
            }
            return Json(new ResultModel { Success = false, Message = "İşlem Başarısız" });
        }
    }
}
