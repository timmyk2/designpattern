using CuaHangDienThoai.Data;

namespace CuaHangDienThoai.Areas.Admin.Controllers.ViewHangControllerFacade
{
    public class ViewHangSubControllerMb
    {
        private readonly MobileContext _mb;
        public ViewHangSubControllerMb(MobileContext mb)
        {
            _mb = mb;
        }
    }
}
