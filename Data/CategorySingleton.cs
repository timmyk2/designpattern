using CuaHangDienThoai.Models;
using System.Collections.Generic;
using System.Linq;

namespace CuaHangDienThoai.Data
{
    public sealed class CategorySingleton
    {
        public static CategorySingleton Instance { get; } = new CategorySingleton();
        public List<Hang> listCatgegory { get; } = new List<Hang>();
        private CategorySingleton()
        {

        }
        public void Init(MobileContext mb)
        {
            if (listCatgegory.Count == 0)
            {

                var items = mb.Hang
                    .AsEnumerable()
                    .Where(c => c.MaHang == null)
                    .ToList();
                foreach (var item in items)
                {
                    listCatgegory.Add(item);
                }
            }
        }
    }
}
