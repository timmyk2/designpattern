using CuaHangDienThoai.Models.View;
using System.Collections.Generic;

namespace CuaHangDienThoai.Areas.Admin.Controllers
{
    public interface IIterator
    {      
        ThongKeViewModel First();
        ThongKeViewModel Next();
        bool IsDone {  get; }
        ThongKeViewModel CurrentItem { get; }
    }
    public class ThongKeIterator : IIterator
    {
        List<ThongKeViewModel> _listThongKeVM;
        int current = 0;
        int step = 1;
       
        

        public ThongKeIterator(List<ThongKeViewModel> listThongKeVM)
        {
            _listThongKeVM = listThongKeVM;
        }

      

        public bool IsDone
        {
            get { return current >= _listThongKeVM.Count; }
        }

        public ThongKeViewModel CurrentItem => _listThongKeVM[current];

        public ThongKeViewModel First()
        {
            current = 0;
            if (_listThongKeVM.Count > 0)
                return _listThongKeVM[current];
            return null;
        }

        public ThongKeViewModel Next()
        {
            current += step;
            if (!IsDone)
                return _listThongKeVM[current]; else return null;
        }

        
    }
}
