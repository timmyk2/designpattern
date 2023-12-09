using System.Linq;
using System.Threading.Tasks;
using CuaHangDienThoai.Common;
using CuaHangDienThoai.Data;
using CuaHangDienThoai.Extensions;
using CuaHangDienThoai.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CuaHangDienThoai.Areas.Admin.Controllers.ViewHangFacade;


namespace CuaHangDienThoai.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HangsController : ControllerTempateMethod
    {
        private readonly MobileContext _mb;
        private readonly ILogger<HangsController> _logger;

        ViewHangFaCade facade;
        public HangsController(MobileContext mb, ILogger<HangsController> logger)
        {
            _mb = mb;
            _logger = logger;
            CategorySingleton.Instance.Init(mb);
            PrintInformation();

            facade = new ViewHangFaCade(mb, logger);
            facade.PrintRoutes();
        }
        public IActionResult Index()
        {
            var Role = HttpContext.Session.GetString(CommonAdmin.ROLE_SESSION);
            if (Role != null)
            {
                // ViewBag.khachHangAndDonHangs = News.SendName(_mb);
               
                
                var items = CategorySingleton.Instance.listCatgegory;
                //return View(items);
                return View(_mb.Hang.ToList());
                //return View(items);
            }
            else
            {
                return RedirectToAction("Index", "Login", new { area = "Identity" });
            }
        }
        public IActionResult Create()
        {
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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Hang hang)
        {
            if (ModelState.IsValid)
            {
                 ViewBag.khachHangAndDonHangs = News.SendName(_mb);
                _mb.Add(hang);
                await _mb.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hang);
        }
        public async Task<IActionResult> Edit(int? maHang)
        {
            var Role = HttpContext.Session.GetString(CommonAdmin.ROLE_SESSION);
            if (Role != null)
            {
                 ViewBag.khachHangAndDonHangs = News.SendName(_mb);
                if (maHang == null)
                    return NotFound();
                var hang = await _mb.Hang.FindAsync(maHang);
                if (hang == null)
                    return null;
                return View(hang);
            }
            else
            {
                return RedirectToAction("Index", "Login", new { area = "Identity" });
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int maHang, Hang hang)
        {
            if (maHang != hang.MaHang)
                return NotFound();
            if (ModelState.IsValid)
            {
                _mb.Update(hang);
                await _mb.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hang);
        }
        public async Task<IActionResult> Details(int? maHang)
        {
            var Role = HttpContext.Session.GetString(CommonAdmin.ROLE_SESSION);
            if (Role == null)
            {
                return RedirectToAction("Index", "Login", new { area = "Identity" });
            }
             ViewBag.khachHangAndDonHangs = News.SendName(_mb);
            if (maHang == null)
                return NotFound();
            var hang = await _mb.Hang.FindAsync(maHang);
            if (hang == null)
                return null;
            return View(hang);
        }

        protected override void PrintRoutes()
        {
            _logger.LogDebug($@"{GetType().Name}==
                Routes:
                Get: Admin/Hangs
                Get: Admin/Hangs/Create
                Post: Admin/Hangs/Edit?MaHang=1
=======");
        }

        protected override void PrintDIs()
        {
            _logger.LogDebug($@"=====
               Denpencies:
                 MobileContext _mb
                 ILogger<HangsController> _logger
                
====");
        }
    }
}