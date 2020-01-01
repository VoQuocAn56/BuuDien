using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuuDien.Class
{
    abstract class BuuPham
    {
        public string DiaChiNhan { get; set; }
        public string NguoiNhan { get; set; }

        public BuuPham() {
            this.DiaChiNhan = "";
            this.NguoiNhan = "";
        }

        public BuuPham(string DiaChiNhan, string NguoiNhan) {
            this.DiaChiNhan = DiaChiNhan;
            this.NguoiNhan = NguoiNhan;
        }

        public abstract double PhiVanChuyen();
    }
}
