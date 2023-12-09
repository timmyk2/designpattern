using Microsoft.Extensions.Logging;

namespace CuaHangDienThoai.Areas.Admin.Controllers.ViewHangControllerFacade
{
    
    public class ViewHangSubControllerLogger
    {
        private readonly ILogger<HangsController> _logger;
        public ViewHangSubControllerLogger(ILogger<HangsController> logger)
        {

            _logger = logger;   
        }
        public void  PrintRoutes()
        {
            _logger.LogDebug($@"{GetType().Name}
                Routes:
                /Hangs
                /Hangs/Create
                /Hangs/Edit?MaHang=id?
              ");
        }
    }
}
