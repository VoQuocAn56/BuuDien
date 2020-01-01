namespace BuuDien
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgwHangHoa = new System.Windows.Forms.DataGridView();
            this.NguoiNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChiNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrongLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhiVanChuye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgwThu = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbLoaiBuuPham = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.txbThemNguoiNhan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbNguoiNhan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbDiaChi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txbTongPVC = new System.Windows.Forms.TextBox();
            this.txbTongHH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnTao = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChiNguoiNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhiVanChuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgwHangHoa)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgwThu)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgwHangHoa);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 668);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(881, 199);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hàng hóa";
            // 
            // dtgwHangHoa
            // 
            this.dtgwHangHoa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgwHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgwHangHoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NguoiNhan,
            this.DiaChiNhan,
            this.TrongLuong,
            this.PhiVanChuye});
            this.dtgwHangHoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgwHangHoa.Location = new System.Drawing.Point(3, 24);
            this.dtgwHangHoa.Name = "dtgwHangHoa";
            this.dtgwHangHoa.RowHeadersWidth = 51;
            this.dtgwHangHoa.RowTemplate.Height = 24;
            this.dtgwHangHoa.Size = new System.Drawing.Size(875, 172);
            this.dtgwHangHoa.TabIndex = 0;
            // 
            // NguoiNhan
            // 
            this.NguoiNhan.HeaderText = "NguoiNhan";
            this.NguoiNhan.MinimumWidth = 6;
            this.NguoiNhan.Name = "NguoiNhan";
            this.NguoiNhan.Width = 125;
            // 
            // DiaChiNhan
            // 
            this.DiaChiNhan.HeaderText = "DiaChiNhan";
            this.DiaChiNhan.MinimumWidth = 6;
            this.DiaChiNhan.Name = "DiaChiNhan";
            this.DiaChiNhan.Width = 125;
            // 
            // TrongLuong
            // 
            this.TrongLuong.HeaderText = "TrongLuong";
            this.TrongLuong.MinimumWidth = 6;
            this.TrongLuong.Name = "TrongLuong";
            this.TrongLuong.Width = 125;
            // 
            // PhiVanChuye
            // 
            this.PhiVanChuye.HeaderText = "PhiVanChuyen";
            this.PhiVanChuye.MinimumWidth = 6;
            this.PhiVanChuye.Name = "PhiVanChuye";
            this.PhiVanChuye.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgwThu);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 468);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(881, 200);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin thư";
            // 
            // dtgwThu
            // 
            this.dtgwThu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgwThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgwThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.DiaChiNguoiNhan,
            this.LoaiHang,
            this.PhiVanChuyen});
            this.dtgwThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgwThu.Location = new System.Drawing.Point(3, 24);
            this.dtgwThu.Name = "dtgwThu";
            this.dtgwThu.RowHeadersWidth = 51;
            this.dtgwThu.RowTemplate.Height = 24;
            this.dtgwThu.Size = new System.Drawing.Size(875, 173);
            this.dtgwThu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 224);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 96);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1064, 75);
            this.panel2.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbLoaiBuuPham);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Controls.Add(this.txbThemNguoiNhan);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cbNguoiNhan);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txbDiaChi);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 84);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(878, 134);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin cơ bản";
            // 
            // cbLoaiBuuPham
            // 
            this.cbLoaiBuuPham.FormattingEnabled = true;
            this.cbLoaiBuuPham.Items.AddRange(new object[] {
            "Hàng hóa",
            "Thư"});
            this.cbLoaiBuuPham.Location = new System.Drawing.Point(176, 77);
            this.cbLoaiBuuPham.Name = "cbLoaiBuuPham";
            this.cbLoaiBuuPham.Size = new System.Drawing.Size(291, 30);
            this.cbLoaiBuuPham.TabIndex = 9;
            this.cbLoaiBuuPham.SelectedIndexChanged += new System.EventHandler(this.cbLoaiBuuPham_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Loại bưu phầm";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(392, 41);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 30);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txbThemNguoiNhan
            // 
            this.txbThemNguoiNhan.Location = new System.Drawing.Point(176, 42);
            this.txbThemNguoiNhan.Name = "txbThemNguoiNhan";
            this.txbThemNguoiNhan.Size = new System.Drawing.Size(210, 28);
            this.txbThemNguoiNhan.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thêm người nhận";
            // 
            // cbNguoiNhan
            // 
            this.cbNguoiNhan.FormattingEnabled = true;
            this.cbNguoiNhan.Items.AddRange(new object[] {
            "An",
            "Bình"});
            this.cbNguoiNhan.Location = new System.Drawing.Point(598, 40);
            this.cbNguoiNhan.Name = "cbNguoiNhan";
            this.cbNguoiNhan.Size = new System.Drawing.Size(264, 30);
            this.cbNguoiNhan.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(481, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Người nhận";
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.Location = new System.Drawing.Point(598, 76);
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Size = new System.Drawing.Size(264, 28);
            this.txbDiaChi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(484, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Địa chỉ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txbTongPVC);
            this.groupBox4.Controls.Add(this.txbTongHH);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(2, 400);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(875, 69);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            // 
            // txbTongPVC
            // 
            this.txbTongPVC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTongPVC.Location = new System.Drawing.Point(686, 25);
            this.txbTongPVC.Name = "txbTongPVC";
            this.txbTongPVC.Size = new System.Drawing.Size(166, 28);
            this.txbTongPVC.TabIndex = 15;
            // 
            // txbTongHH
            // 
            this.txbTongHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTongHH.Location = new System.Drawing.Point(190, 26);
            this.txbTongHH.Name = "txbTongHH";
            this.txbTongHH.Size = new System.Drawing.Size(166, 28);
            this.txbTongHH.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(484, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tổng phí vận chuyển:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tổng số hàng hóa:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnThoat);
            this.groupBox5.Controls.Add(this.btnNhap);
            this.groupBox5.Controls.Add(this.btnTao);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(3, 323);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(874, 78);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(749, 22);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(106, 44);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(380, 22);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(106, 44);
            this.btnNhap.TabIndex = 5;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnTao
            // 
            this.btnTao.Location = new System.Drawing.Point(19, 22);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(106, 44);
            this.btnTao.TabIndex = 4;
            this.btnTao.Text = "Tạo";
            this.btnTao.UseVisualStyleBackColor = true;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(195, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(431, 38);
            this.label7.TabIndex = 12;
            this.label7.Text = "Phần mềm quản lí bưu phầm";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "NguoiNhan";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // DiaChiNguoiNhan
            // 
            this.DiaChiNguoiNhan.HeaderText = "DiaChiNhan";
            this.DiaChiNguoiNhan.MinimumWidth = 6;
            this.DiaChiNguoiNhan.Name = "DiaChiNguoiNhan";
            this.DiaChiNguoiNhan.Width = 125;
            // 
            // LoaiHang
            // 
            this.LoaiHang.HeaderText = "LoaiHang";
            this.LoaiHang.MinimumWidth = 6;
            this.LoaiHang.Name = "LoaiHang";
            this.LoaiHang.Width = 125;
            // 
            // PhiVanChuyen
            // 
            this.PhiVanChuyen.HeaderText = "PhieVanChuyen";
            this.PhiVanChuyen.MinimumWidth = 6;
            this.PhiVanChuyen.Name = "PhiVanChuyen";
            this.PhiVanChuyen.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 867);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgwHangHoa)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgwThu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgwHangHoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgwThu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbDiaChi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbThemNguoiNhan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbNguoiNhan;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbLoaiBuuPham;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NguoiNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChiNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrongLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhiVanChuye;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txbTongPVC;
        private System.Windows.Forms.TextBox txbTongHH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChiNguoiNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhiVanChuyen;
    }
}

