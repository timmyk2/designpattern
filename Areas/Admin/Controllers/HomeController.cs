using CuaHangDienThoai.Common;
using CuaHangDienThoai.Data;
using CuaHangDienThoai.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CuaHangDienThoai.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : ControllerTempateMethod
    {
        private readonly MobileContext _mb;
        private readonly ILogger<HangsController> _logger;
        public HomeController(MobileContext mb, ILogger<HangsController> logger)
        {
            _mb = mb;
            _logger = logger;
            PrintInformation();
        }
        public IActionResult Index()
        {
            PrintInformation();
            var Role = HttpContext.Session.GetString(CommonAdmin.ROLE_SESSION);
            if (Role != null)
            {
                ViewBag.khachHangAndDonHangs = News.SendName(_mb);
                return View();

            }
            else
            {
                return RedirectToAction("Index", "Login", new { area = "Identity" });
            } 
        }
        public IActionResult NoRight()
        {
            var Role = HttpContext.Session.GetString(CommonAdmin.ROLE_SESSION);
            if (Role != null && Role.Equals("Super Admin"))
            {
                return RedirectToAction("Index", "DonHangs", new { area = "Admin" });
            }
            else if(Role==null)
            {
                return RedirectToAction("Index", "Login", new { area = "Identity" });
            }
            ViewBag.khachHangAndDonHangs = News.SendName(_mb);
            return View();
        }

        protected override void PrintDIs()
        {
            _logger.LogInformation($@"{GetType().Name}==
                Routes:
                Get: Index
                Get: NoRight
               
=======");
        }

        protected override void PrintRoutes()
        {
            _logger.LogInformation($@"==
                 Denpencies:
                 MobileContext _mb
                 ILogger<HangsController> _logger
=======");
        }
    }
}