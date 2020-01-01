using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuuDien.Control
{
    public partial class NhapThongTinHangHoa : UserControl
    {
        private double trongluong;
        public static int Dem { get; set; }

        public NhapThongTinHangHoa()
        {
            InitializeComponent();
            trongluong = 1;
            Dem = 0;
            txbTrongLuong.Text = "";

        }

        public double TrongLuongHangHoa() {
            try
            {
                trongluong = double.Parse(txbTrongLuong.Text.ToString());
            }
            catch
            {
                MessageBox.Show("Dữ liệu trọng lượng phải là số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbTrongLuong.Text = "";
                Dem += 1;
            }
            return trongluong;
        }

        private void txbTrongLuong_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
