using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuuDien.Class;
using BuuDien.Control;

namespace BuuDien
{
    public partial class Form1 : Form
    {

        private NhapThongTinHangHoa nhapThongTinHH;
        private NhapThongTinThu nhapThongTinThu;
        public static bool KiemTraTao;

        private int SoLuongHangHoa;
        private double TongPhiVanChuyen;

        private List<HangHoa> DanhSachHangHoa;
        private List<Thu> DanhSachThu;

        public Form1()
        {
            InitializeComponent();
            nhapThongTinHH = new NhapThongTinHangHoa();
            nhapThongTinThu = new NhapThongTinThu();

            DanhSachThu = new List<Thu>();
            DanhSachHangHoa = new List<HangHoa>();

            cbNguoiNhan.SelectedIndex = 0;
            cbLoaiBuuPham.SelectedIndex = 0;
            SoLuongHangHoa = 0;
            TongPhiVanChuyen = 0;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            string NguoiNhan = cbNguoiNhan.Text.ToString();
            string DiaChiNhan = txbDiaChi.Text.ToString();

            if (panel1.Controls.Contains(nhapThongTinHH))
            {
                if (DiaChiNhan == "")
                {
                    MessageBox.Show("Chưa nhập địa chỉ người nhận");
                }
                else NhapHangHoa(DiaChiNhan, NguoiNhan);
            }
            else {
                if (DiaChiNhan == "")
                {
                    MessageBox.Show("Chưa nhập địa chỉ người nhận");
                }          
                else NhapThu(DiaChiNhan, NguoiNhan);
            }

            txbTongPVC.Text = TongPhiVanChuyen.ToString();
            txbTongHH.Text = SoLuongHangHoa.ToString();
        }

        private void NhapHangHoa(string DiaChiNhan, string NguoiNhan) {
            double trongluong = nhapThongTinHH.TrongLuongHangHoa();
            if (NhapThongTinHangHoa.Dem > 0) {
                NhapThongTinHangHoa.Dem = 0;
                return;
            }

            if (trongluong < 0)
            {
                MessageBox.Show("Trọng lượng phải lớn hơn 0");
            }
            else {
                HangHoa hangHoa = new HangHoa(DiaChiNhan, NguoiNhan, trongluong);
                DanhSachHangHoa.Add(hangHoa);

                int rowid = dtgwHangHoa.Rows.Add();
                DataGridViewRow row = dtgwHangHoa.Rows[rowid];
                row.Cells[0].Value = NguoiNhan;
                row.Cells[1].Value = DiaChiNhan;
                row.Cells[2].Value = trongluong;
                row.Cells[3].Value = hangHoa.PhiVanChuyen();

                SoLuongHangHoa += 1;
                TongPhiVanChuyen += hangHoa.PhiVanChuyen();
            }
         
        }

        private void NhapThu(string DiaChiNhan, string NguoiNhan) {
            string loaithu = nhapThongTinThu.LoaiThu();
            
            Thu thu = new Thu(DiaChiNhan, NguoiNhan, loaithu);
            DanhSachThu.Add(thu);

            int rowid = dtgwThu.Rows.Add();
            DataGridViewRow row = dtgwThu.Rows[rowid];
            row.Cells[0].Value = NguoiNhan;
            row.Cells[1].Value = DiaChiNhan;
            row.Cells[2].Value = loaithu;
            row.Cells[3].Value = thu.PhiVanChuyen();

            SoLuongHangHoa += 1;
            TongPhiVanChuyen += thu.PhiVanChuyen();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            txbDiaChi.Text = "";
            cbNguoiNhan.SelectedIndex = 0;
            txbThemNguoiNhan.Text = "";

            if (panel1.Controls.Contains(nhapThongTinHH))
            {
                nhapThongTinHH = new NhapThongTinHangHoa();
                panel1.Controls.Clear();
                panel1.Controls.Add(nhapThongTinHH);
                nhapThongTinHH.Dock = DockStyle.Fill;
            }
            else {
                nhapThongTinThu = new NhapThongTinThu();
                panel1.Controls.Clear();
                panel1.Controls.Add(nhapThongTinThu);
                nhapThongTinThu.Dock = DockStyle.Fill;
            }
          
        }

        private void cbLoaiBuuPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLoaiBuuPham.SelectedIndex == 0)
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(nhapThongTinHH);
                nhapThongTinThu.Dock = DockStyle.Fill;
            }
            else
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(nhapThongTinThu);
                nhapThongTinThu.Dock = DockStyle.Fill;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cbNguoiNhan.Items.Add(txbThemNguoiNhan.Text.ToString());
            cbNguoiNhan.Refresh();
            txbThemNguoiNhan.Text = "";
        }
    }
}
