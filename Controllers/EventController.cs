using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventRegister.Controllers
{
    public class EventController : Controller
    {
        // GET: EventController
        public ActionResult Index()
        {
            return View(Index);
        }
        public ActionResult Register()
        {
            ViewBag.EventName ="Trang đăng ký sự kiện";
            return View(Register);
        }
        public ActionResult Confirm(String name)
        {
            ViewData["Name"] = name;
            return View(Confirm);
        }
    }
}
