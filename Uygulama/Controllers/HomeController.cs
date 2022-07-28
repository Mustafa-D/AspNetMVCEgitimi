using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Uygulama.Models;

namespace Uygulama.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SessionOlustur()
        {
            HttpContext.Session.SetString("deger", "ahmet");
            return RedirectToAction("Privacy");
        }
        public IActionResult SessionSil()
        {
            HttpContext.Session.Remove("deger");
            return RedirectToAction(nameof(Privacy));
        }
        public IActionResult CookieOlustur()
        {
            CookieOptions cookieOp = new CookieOptions()
            {
                Expires = DateTime.Now.AddMinutes(1)
            };
            Response.Cookies.Append("user","mustafa",cookieOp);
            Response.Cookies.Append("password", "123456");
            return RedirectToAction(nameof(CookieOku));
        }
        public IActionResult CookieOku()
        {
            TempData["user"] =Request.Cookies["user"];
            TempData["password"] =Request.Cookies["password"];

            return View();
        }                   
        public IActionResult CookieSil()
        {
            Response.Cookies.Delete("user");
            Response.Cookies.Delete("password");
            return RedirectToAction(nameof(CookieOku));
        }
        public IActionResult Privacy()
        {
            TempData["deger"] = HttpContext.Session.GetString("deger");

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}