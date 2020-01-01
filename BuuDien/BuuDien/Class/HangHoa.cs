using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuuDien.Class
{
    class HangHoa:BuuPham
    {
        public double TrongLuong { get; set; }

        public HangHoa():base() {
            TrongLuong = 0;
        }

        public HangHoa(string NguoiNhan, string DiaChiNhan, double TrongLuong) : base(DiaChiNhan, NguoiNhan) {
            this.TrongLuong = TrongLuong;
        }

        public override double PhiVanChuyen()
        {
            return 10000 * TrongLuong;
        }
    }
}
