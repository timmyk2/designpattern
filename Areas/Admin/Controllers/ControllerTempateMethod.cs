using Microsoft.AspNetCore.Mvc;

namespace CuaHangDienThoai.Areas.Admin.Controllers
{
    public abstract class ControllerTempateMethod : Controller
    {
        protected abstract void PrintRoutes();
        protected abstract void PrintDIs();
        public void PrintInformation()
        {
            PrintRoutes();
            PrintDIs();
        }
    }
}
