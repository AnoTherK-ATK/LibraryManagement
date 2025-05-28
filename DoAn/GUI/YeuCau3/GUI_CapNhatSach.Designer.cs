namespace DoAn.GUI.YeuCau3
{
    partial class GUI_CapNhatSach
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
            this.ResetBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.TiepNhanSachBtn = new System.Windows.Forms.Button();
            this.TriGiaTxt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.NhaXuatBanTxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SachQuaHanNhapTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.NgayNhapSelector = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.NamXuatBanSelector = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.TheLoaiCombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TacGiaTxt = new System.Windows.Forms.TextBox();
            this.TenSachTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MaSachTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.QuyeNhanSachTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TenBoPhanTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TenNhanVienTxt = new System.Windows.Forms.TextBox();
            this.MaNhanVienCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(194, 362);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(177, 52);
            this.ResetBtn.TabIndex = 57;
            this.ResetBtn.Text = "Tái lập";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(710, 358);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(126, 57);
            this.ExitBtn.TabIndex = 56;
            this.ExitBtn.Text = "Thoát";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // TiepNhanSachBtn
            // 
            this.TiepNhanSachBtn.Location = new System.Drawing.Point(16, 358);
            this.TiepNhanSachBtn.Name = "TiepNhanSachBtn";
            this.TiepNhanSachBtn.Size = new System.Drawing.Size(164, 57);
            this.TiepNhanSachBtn.TabIndex = 55;
            this.TiepNhanSachBtn.Text = "Cập nhật sách";
            this.TiepNhanSachBtn.UseVisualStyleBackColor = true;
            this.TiepNhanSachBtn.Click += new System.EventHandler(this.TiepNhanSachBtn_Click);
            // 
            // TriGiaTxt
            // 
            this.TriGiaTxt.Location = new System.Drawing.Point(509, 312);
            this.TriGiaTxt.Name = "TriGiaTxt";
            this.TriGiaTxt.Size = new System.Drawing.Size(294, 34);
            this.TriGiaTxt.TabIndex = 54;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(505, 288);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 21);
            this.label13.TabIndex = 53;
            this.label13.Text = "Trị giả (VNĐ)";
            // 
            // NhaXuatBanTxt
            // 
            this.NhaXuatBanTxt.Location = new System.Drawing.Point(16, 312);
            this.NhaXuatBanTxt.Name = "NhaXuatBanTxt";
            this.NhaXuatBanTxt.Size = new System.Drawing.Size(405, 34);
            this.NhaXuatBanTxt.TabIndex = 52;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(12, 288);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 21);
            this.label12.TabIndex = 51;
            this.label12.Text = "Nhà xuất bản";
            // 
            // SachQuaHanNhapTxt
            // 
            this.SachQuaHanNhapTxt.Location = new System.Drawing.Point(509, 220);
            this.SachQuaHanNhapTxt.Name = "SachQuaHanNhapTxt";
            this.SachQuaHanNhapTxt.ReadOnly = true;
            this.SachQuaHanNhapTxt.Size = new System.Drawing.Size(148, 34);
            this.SachQuaHanNhapTxt.TabIndex = 50;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(505, 193);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 21);
            this.label11.TabIndex = 49;
            this.label11.Text = "Sách quá hạn nhập";
            // 
            // NgayNhapSelector
            // 
            this.NgayNhapSelector.CustomFormat = "dd/MM/yyyy";
            this.NgayNhapSelector.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NgayNhapSelector.Location = new System.Drawing.Point(207, 217);
            this.NgayNhapSelector.Name = "NgayNhapSelector";
            this.NgayNhapSelector.Size = new System.Drawing.Size(181, 34);
            this.NgayNhapSelector.TabIndex = 48;
            this.NgayNhapSelector.ValueChanged += new System.EventHandler(this.NgayNhapSelector_ValueChanged);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(203, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 21);
            this.label10.TabIndex = 47;
            this.label10.Text = "Ngày nhập";
            // 
            // NamXuatBanSelector
            // 
            this.NamXuatBanSelector.CustomFormat = "yyyy";
            this.NamXuatBanSelector.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NamXuatBanSelector.Location = new System.Drawing.Point(16, 217);
            this.NamXuatBanSelector.Name = "NamXuatBanSelector";
            this.NamXuatBanSelector.ShowUpDown = true;
            this.NamXuatBanSelector.Size = new System.Drawing.Size(119, 34);
            this.NamXuatBanSelector.TabIndex = 46;
            this.NamXuatBanSelector.ValueChanged += new System.EventHandler(this.NamXuatBanSelector_ValueChanged);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(12, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 21);
            this.label9.TabIndex = 45;
            this.label9.Text = "Năm xuất bản";
            // 
            // TheLoaiCombo
            // 
            this.TheLoaiCombo.FormattingEnabled = true;
            this.TheLoaiCombo.Location = new System.Drawing.Point(744, 127);
            this.TheLoaiCombo.Name = "TheLoaiCombo";
            this.TheLoaiCombo.Size = new System.Drawing.Size(92, 36);
            this.TheLoaiCombo.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(740, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 21);
            this.label8.TabIndex = 43;
            this.label8.Text = "Tên thể loại";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(505, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 21);
            this.label7.TabIndex = 42;
            this.label7.Text = "Tác giả";
            // 
            // TacGiaTxt
            // 
            this.TacGiaTxt.Location = new System.Drawing.Point(509, 127);
            this.TacGiaTxt.Name = "TacGiaTxt";
            this.TacGiaTxt.Size = new System.Drawing.Size(199, 34);
            this.TacGiaTxt.TabIndex = 41;
            // 
            // TenSachTxt
            // 
            this.TenSachTxt.Location = new System.Drawing.Point(207, 127);
            this.TenSachTxt.Name = "TenSachTxt";
            this.TenSachTxt.Size = new System.Drawing.Size(236, 34);
            this.TenSachTxt.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(203, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 21);
            this.label6.TabIndex = 39;
            this.label6.Text = "Tên sách";
            // 
            // MaSachTxt
            // 
            this.MaSachTxt.Location = new System.Drawing.Point(16, 127);
            this.MaSachTxt.Name = "MaSachTxt";
            this.MaSachTxt.Size = new System.Drawing.Size(119, 34);
            this.MaSachTxt.TabIndex = 38;
            this.MaSachTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MaSachTxt_KeyDown);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 21);
            this.label5.TabIndex = 37;
            this.label5.Text = "Mã sách";
            // 
            // QuyeNhanSachTxt
            // 
            this.QuyeNhanSachTxt.Location = new System.Drawing.Point(681, 33);
            this.QuyeNhanSachTxt.Name = "QuyeNhanSachTxt";
            this.QuyeNhanSachTxt.ReadOnly = true;
            this.QuyeNhanSachTxt.Size = new System.Drawing.Size(115, 34);
            this.QuyeNhanSachTxt.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(677, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 28);
            this.label4.TabIndex = 35;
            this.label4.Text = "Quyền nhận sách";
            // 
            // TenBoPhanTxt
            // 
            this.TenBoPhanTxt.Location = new System.Drawing.Point(509, 33);
            this.TenBoPhanTxt.Name = "TenBoPhanTxt";
            this.TenBoPhanTxt.ReadOnly = true;
            this.TenBoPhanTxt.Size = new System.Drawing.Size(115, 34);
            this.TenBoPhanTxt.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(505, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 28);
            this.label3.TabIndex = 33;
            this.label3.Text = "Tên bộ phận";
            // 
            // TenNhanVienTxt
            // 
            this.TenNhanVienTxt.Location = new System.Drawing.Point(207, 33);
            this.TenNhanVienTxt.Name = "TenNhanVienTxt";
            this.TenNhanVienTxt.ReadOnly = true;
            this.TenNhanVienTxt.Size = new System.Drawing.Size(236, 34);
            this.TenNhanVienTxt.TabIndex = 32;
            // 
            // MaNhanVienCombo
            // 
            this.MaNhanVienCombo.FormattingEnabled = true;
            this.MaNhanVienCombo.Location = new System.Drawing.Point(16, 33);
            this.MaNhanVienCombo.Name = "MaNhanVienCombo";
            this.MaNhanVienCombo.Size = new System.Drawing.Size(119, 36);
            this.MaNhanVienCombo.TabIndex = 31;
            this.MaNhanVienCombo.SelectedIndexChanged += new System.EventHandler(this.MaNhanVienCombo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(203, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 21);
            this.label2.TabIndex = 30;
            this.label2.Text = "Tên nhân viên";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 21);
            this.label1.TabIndex = 29;
            this.label1.Text = "Mã nhân viên";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(141, 131);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(61, 25);
            this.SearchBtn.TabIndex = 58;
            this.SearchBtn.Text = "Tìm";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // GUI_CapNhatSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 455);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.TiepNhanSachBtn);
            this.Controls.Add(this.TriGiaTxt);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.NhaXuatBanTxt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.SachQuaHanNhapTxt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.NgayNhapSelector);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.NamXuatBanSelector);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TheLoaiCombo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TacGiaTxt);
            this.Controls.Add(this.TenSachTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MaSachTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.QuyeNhanSachTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TenBoPhanTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TenNhanVienTxt);
            this.Controls.Add(this.MaNhanVienCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GUI_CapNhatSach";
            this.Text = "GUI_CapNhatSach";
            this.Load += new System.EventHandler(this.GUI_CapNhatSach_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button TiepNhanSachBtn;
        private System.Windows.Forms.TextBox TriGiaTxt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox NhaXuatBanTxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox SachQuaHanNhapTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker NgayNhapSelector;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker NamXuatBanSelector;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox TheLoaiCombo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TacGiaTxt;
        private System.Windows.Forms.TextBox TenSachTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MaSachTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox QuyeNhanSachTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TenBoPhanTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TenNhanVienTxt;
        private System.Windows.Forms.ComboBox MaNhanVienCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchBtn;
    }
}