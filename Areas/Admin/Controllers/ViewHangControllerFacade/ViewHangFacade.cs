using CuaHangDienThoai.Areas.Admin.Controllers.ViewHangControllerFacade;
using CuaHangDienThoai.Data;
using Microsoft.Extensions.Logging;

namespace CuaHangDienThoai.Areas.Admin.Controllers.ViewHangFacade
{
    public class ViewHangFaCade
    {
        ViewHangSubControllerLogger vhscLogger;
        ViewHangSubControllerMb vhscMb;
        public ViewHangFaCade(MobileContext mb, ILogger<HangsController> logger) {
            vhscLogger = new ViewHangSubControllerLogger(logger);
            vhscMb =    new ViewHangSubControllerMb(mb);
        
        
        }
        public void PrintRoutes()
        {
            vhscLogger.PrintRoutes();
        }
    }
}
