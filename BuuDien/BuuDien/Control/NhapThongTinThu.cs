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
    public partial class NhapThongTinThu : UserControl
    {
        public NhapThongTinThu()
        {
            InitializeComponent();
            cbLoaiThu.SelectedIndex = 0;
        }
        public string LoaiThu() {
            string lt = cbLoaiThu.Text;
            return lt;
        }
    }
}
