namespace DoAn.GUI.YeuCau2
{
    partial class YeuCau2
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
            this.ExitBtn = new System.Windows.Forms.Button();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.DiaChiTxt = new System.Windows.Forms.TextBox();
            this.NgaySinhSelector = new System.Windows.Forms.DateTimePicker();
            this.MaNhanVienCombo = new System.Windows.Forms.ComboBox();
            this.HoTenDocGiaTxt = new System.Windows.Forms.TextBox();
            this.MaDocGiaTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TenNhanVienTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TenBoPhanTxt = new System.Windows.Forms.TextBox();
            this.QuyenLapTheTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.LoaiDocGiaCombo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.NgayHetHanTxt = new System.Windows.Forms.TextBox();
            this.NgayLapTheTxt = new System.Windows.Forms.TextBox();
            this.TheDocGiaMoiBtn = new System.Windows.Forms.Button();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Red;
            this.ExitBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExitBtn.Location = new System.Drawing.Point(744, 679);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(183, 62);
            this.ExitBtn.TabIndex = 61;
            this.ExitBtn.Text = "Thoát";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // EmailTxt
            // 
            this.EmailTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTxt.Location = new System.Drawing.Point(14, 349);
            this.EmailTxt.MaxLength = 25;
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.ReadOnly = true;
            this.EmailTxt.Size = new System.Drawing.Size(370, 39);
            this.EmailTxt.TabIndex = 59;
            // 
            // DiaChiTxt
            // 
            this.DiaChiTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiaChiTxt.Location = new System.Drawing.Point(468, 349);
            this.DiaChiTxt.MaxLength = 30;
            this.DiaChiTxt.Name = "DiaChiTxt";
            this.DiaChiTxt.ReadOnly = true;
            this.DiaChiTxt.Size = new System.Drawing.Size(458, 39);
            this.DiaChiTxt.TabIndex = 57;
            // 
            // NgaySinhSelector
            // 
            this.NgaySinhSelector.CustomFormat = "dd/MM/yyyy";
            this.NgaySinhSelector.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgaySinhSelector.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NgaySinhSelector.Location = new System.Drawing.Point(770, 201);
            this.NgaySinhSelector.Name = "NgaySinhSelector";
            this.NgaySinhSelector.Size = new System.Drawing.Size(157, 39);
            this.NgaySinhSelector.TabIndex = 55;
            this.NgaySinhSelector.Value = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            // 
            // MaNhanVienCombo
            // 
            this.MaNhanVienCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaNhanVienCombo.FormattingEnabled = true;
            this.MaNhanVienCombo.Location = new System.Drawing.Point(10, 77);
            this.MaNhanVienCombo.Name = "MaNhanVienCombo";
            this.MaNhanVienCombo.Size = new System.Drawing.Size(163, 40);
            this.MaNhanVienCombo.TabIndex = 54;
            this.MaNhanVienCombo.SelectedIndexChanged += new System.EventHandler(this.MaNhanVienCombo_SelectedIndexChanged);
            // 
            // HoTenDocGiaTxt
            // 
            this.HoTenDocGiaTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoTenDocGiaTxt.Location = new System.Drawing.Point(231, 202);
            this.HoTenDocGiaTxt.Name = "HoTenDocGiaTxt";
            this.HoTenDocGiaTxt.ReadOnly = true;
            this.HoTenDocGiaTxt.Size = new System.Drawing.Size(262, 39);
            this.HoTenDocGiaTxt.TabIndex = 53;
            // 
            // MaDocGiaTxt
            // 
            this.MaDocGiaTxt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MaDocGiaTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaDocGiaTxt.Location = new System.Drawing.Point(14, 202);
            this.MaDocGiaTxt.Name = "MaDocGiaTxt";
            this.MaDocGiaTxt.ReadOnly = true;
            this.MaDocGiaTxt.Size = new System.Drawing.Size(160, 39);
            this.MaDocGiaTxt.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 32);
            this.label8.TabIndex = 51;
            this.label8.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(462, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 32);
            this.label6.TabIndex = 49;
            this.label6.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(546, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 32);
            this.label5.TabIndex = 48;
            this.label5.Text = "Tên bộ phận";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(777, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 32);
            this.label4.TabIndex = 47;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 32);
            this.label3.TabIndex = 46;
            this.label3.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 32);
            this.label2.TabIndex = 45;
            this.label2.Text = "Họ và tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 32);
            this.label1.TabIndex = 44;
            this.label1.Text = "Mã độc giả";
            // 
            // TenNhanVienTxt
            // 
            this.TenNhanVienTxt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TenNhanVienTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenNhanVienTxt.Location = new System.Drawing.Point(231, 77);
            this.TenNhanVienTxt.Name = "TenNhanVienTxt";
            this.TenNhanVienTxt.ReadOnly = true;
            this.TenNhanVienTxt.Size = new System.Drawing.Size(262, 39);
            this.TenNhanVienTxt.TabIndex = 63;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(226, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 32);
            this.label9.TabIndex = 64;
            this.label9.Text = "Tên nhân viên";
            // 
            // TenBoPhanTxt
            // 
            this.TenBoPhanTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenBoPhanTxt.Location = new System.Drawing.Point(550, 77);
            this.TenBoPhanTxt.Name = "TenBoPhanTxt";
            this.TenBoPhanTxt.ReadOnly = true;
            this.TenBoPhanTxt.Size = new System.Drawing.Size(147, 39);
            this.TenBoPhanTxt.TabIndex = 65;
            // 
            // QuyenLapTheTxt
            // 
            this.QuyenLapTheTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuyenLapTheTxt.Location = new System.Drawing.Point(770, 77);
            this.QuyenLapTheTxt.Name = "QuyenLapTheTxt";
            this.QuyenLapTheTxt.ReadOnly = true;
            this.QuyenLapTheTxt.Size = new System.Drawing.Size(157, 39);
            this.QuyenLapTheTxt.TabIndex = 67;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(766, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 32);
            this.label10.TabIndex = 66;
            this.label10.Text = "Quyền lập thẻ";
            // 
            // LoaiDocGiaCombo
            // 
            this.LoaiDocGiaCombo.Enabled = false;
            this.LoaiDocGiaCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoaiDocGiaCombo.FormattingEnabled = true;
            this.LoaiDocGiaCombo.Location = new System.Drawing.Point(550, 201);
            this.LoaiDocGiaCombo.Name = "LoaiDocGiaCombo";
            this.LoaiDocGiaCombo.Size = new System.Drawing.Size(156, 40);
            this.LoaiDocGiaCombo.TabIndex = 69;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(546, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(194, 32);
            this.label11.TabIndex = 68;
            this.label11.Text = "Tên loại độc giả";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 429);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 32);
            this.label7.TabIndex = 72;
            this.label7.Text = "Ngày lập thẻ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(462, 429);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(166, 32);
            this.label13.TabIndex = 74;
            this.label13.Text = "Ngày hết hạn";
            // 
            // NgayHetHanTxt
            // 
            this.NgayHetHanTxt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.NgayHetHanTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayHetHanTxt.Location = new System.Drawing.Point(468, 484);
            this.NgayHetHanTxt.Name = "NgayHetHanTxt";
            this.NgayHetHanTxt.ReadOnly = true;
            this.NgayHetHanTxt.Size = new System.Drawing.Size(373, 39);
            this.NgayHetHanTxt.TabIndex = 75;
            // 
            // NgayLapTheTxt
            // 
            this.NgayLapTheTxt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.NgayLapTheTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayLapTheTxt.Location = new System.Drawing.Point(14, 484);
            this.NgayLapTheTxt.Name = "NgayLapTheTxt";
            this.NgayLapTheTxt.ReadOnly = true;
            this.NgayLapTheTxt.Size = new System.Drawing.Size(370, 39);
            this.NgayLapTheTxt.TabIndex = 76;
            // 
            // TheDocGiaMoiBtn
            // 
            this.TheDocGiaMoiBtn.BackColor = System.Drawing.Color.Turquoise;
            this.TheDocGiaMoiBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TheDocGiaMoiBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TheDocGiaMoiBtn.Location = new System.Drawing.Point(269, 679);
            this.TheDocGiaMoiBtn.Name = "TheDocGiaMoiBtn";
            this.TheDocGiaMoiBtn.Size = new System.Drawing.Size(210, 62);
            this.TheDocGiaMoiBtn.TabIndex = 78;
            this.TheDocGiaMoiBtn.Text = "Reset";
            this.TheDocGiaMoiBtn.UseVisualStyleBackColor = false;
            this.TheDocGiaMoiBtn.Click += new System.EventHandler(this.TheDocGiaMoiBtn_Click);
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.BackColor = System.Drawing.Color.Turquoise;
            this.SubmitBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SubmitBtn.Location = new System.Drawing.Point(17, 679);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(222, 62);
            this.SubmitBtn.TabIndex = 77;
            this.SubmitBtn.Text = "Lập thẻ độc giả";
            this.SubmitBtn.UseVisualStyleBackColor = false;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // YeuCau2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 756);
            this.Controls.Add(this.TheDocGiaMoiBtn);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.NgayLapTheTxt);
            this.Controls.Add(this.NgayHetHanTxt);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LoaiDocGiaCombo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.QuyenLapTheTxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TenBoPhanTxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TenNhanVienTxt);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.EmailTxt);
            this.Controls.Add(this.DiaChiTxt);
            this.Controls.Add(this.NgaySinhSelector);
            this.Controls.Add(this.MaNhanVienCombo);
            this.Controls.Add(this.HoTenDocGiaTxt);
            this.Controls.Add(this.MaDocGiaTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "YeuCau2";
            this.Text = "Tiếp nhận thẻ độc giả";
            this.Load += new System.EventHandler(this.YeuCau2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.TextBox EmailTxt;
        private System.Windows.Forms.TextBox DiaChiTxt;
        private System.Windows.Forms.DateTimePicker NgaySinhSelector;
        private System.Windows.Forms.ComboBox MaNhanVienCombo;
        private System.Windows.Forms.TextBox HoTenDocGiaTxt;
        private System.Windows.Forms.TextBox MaDocGiaTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TenNhanVienTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TenBoPhanTxt;
        private System.Windows.Forms.TextBox QuyenLapTheTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox LoaiDocGiaCombo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox NgayHetHanTxt;
        private System.Windows.Forms.TextBox NgayLapTheTxt;
        private System.Windows.Forms.Button TheDocGiaMoiBtn;
        private System.Windows.Forms.Button SubmitBtn;
    }
}