using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuuDien.Class
{
    class Thu: BuuPham
    {
        public string LoaiThu { get; set; }

        public Thu() {
            this.LoaiThu = "";
        }

        public Thu(string DiaChiNguoiNhan, string NguoiNhan, string LoaiThu): base(DiaChiNguoiNhan, NguoiNhan) {
            this.LoaiThu = LoaiThu;
        }

        public override double PhiVanChuyen()
        {
            return LoaiThu == "Nhanh" ? 5000 : 1000;
        }
    }
}
