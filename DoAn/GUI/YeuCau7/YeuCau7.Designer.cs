﻿namespace DoAn.GUI.YeuCau7
{
    partial class YeuCau7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YeuCau7));
            this.TenNhanVienCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MaBoPhanTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MaPhieuThuTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TenDocGiaCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TongNoTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SoTienThuTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TienConLaiTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TenNhanVienCombo
            // 
            this.TenNhanVienCombo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TenNhanVienCombo.FormattingEnabled = true;
            this.TenNhanVienCombo.Location = new System.Drawing.Point(38, 76);
            this.TenNhanVienCombo.Margin = new System.Windows.Forms.Padding(6, 11, 6, 11);
            this.TenNhanVienCombo.Name = "TenNhanVienCombo";
            this.TenNhanVienCombo.Size = new System.Drawing.Size(423, 40);
            this.TenNhanVienCombo.TabIndex = 16;
            this.TenNhanVienCombo.SelectedIndexChanged += new System.EventHandler(this.TenNhanVienCombo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 32);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tên nhân viên";
            // 
            // MaBoPhanTxt
            // 
            this.MaBoPhanTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.MaBoPhanTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaBoPhanTxt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MaBoPhanTxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MaBoPhanTxt.Location = new System.Drawing.Point(559, 79);
            this.MaBoPhanTxt.Margin = new System.Windows.Forms.Padding(6, 11, 6, 11);
            this.MaBoPhanTxt.Name = "MaBoPhanTxt";
            this.MaBoPhanTxt.ReadOnly = true;
            this.MaBoPhanTxt.Size = new System.Drawing.Size(499, 39);
            this.MaBoPhanTxt.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(550, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 32);
            this.label2.TabIndex = 19;
            this.label2.Text = "Mã bộ phận";
            // 
            // MaPhieuThuTxt
            // 
            this.MaPhieuThuTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.MaPhieuThuTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaPhieuThuTxt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MaPhieuThuTxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MaPhieuThuTxt.Location = new System.Drawing.Point(38, 258);
            this.MaPhieuThuTxt.Margin = new System.Windows.Forms.Padding(6, 11, 6, 11);
            this.MaPhieuThuTxt.Name = "MaPhieuThuTxt";
            this.MaPhieuThuTxt.ReadOnly = true;
            this.MaPhieuThuTxt.Size = new System.Drawing.Size(224, 39);
            this.MaPhieuThuTxt.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 187);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mã phiếu thu";
            // 
            // TenDocGiaCombo
            // 
            this.TenDocGiaCombo.Enabled = false;
            this.TenDocGiaCombo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TenDocGiaCombo.FormattingEnabled = true;
            this.TenDocGiaCombo.Location = new System.Drawing.Point(376, 254);
            this.TenDocGiaCombo.Margin = new System.Windows.Forms.Padding(6, 11, 6, 11);
            this.TenDocGiaCombo.Name = "TenDocGiaCombo";
            this.TenDocGiaCombo.Size = new System.Drawing.Size(307, 40);
            this.TenDocGiaCombo.TabIndex = 24;
            this.TenDocGiaCombo.SelectedIndexChanged += new System.EventHandler(this.TenDocGiaCombo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(367, 187);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 32);
            this.label4.TabIndex = 23;
            this.label4.Text = "Tên Độc Giả";
            // 
            // TongNoTxt
            // 
            this.TongNoTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.TongNoTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TongNoTxt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TongNoTxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TongNoTxt.Location = new System.Drawing.Point(833, 254);
            this.TongNoTxt.Margin = new System.Windows.Forms.Padding(6, 11, 6, 11);
            this.TongNoTxt.Name = "TongNoTxt";
            this.TongNoTxt.ReadOnly = true;
            this.TongNoTxt.Size = new System.Drawing.Size(224, 39);
            this.TongNoTxt.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(826, 184);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 32);
            this.label5.TabIndex = 25;
            this.label5.Text = "Tổng nợ";
            // 
            // SoTienThuTxt
            // 
            this.SoTienThuTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SoTienThuTxt.Enabled = false;
            this.SoTienThuTxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SoTienThuTxt.Location = new System.Drawing.Point(38, 443);
            this.SoTienThuTxt.Margin = new System.Windows.Forms.Padding(6, 11, 6, 11);
            this.SoTienThuTxt.Name = "SoTienThuTxt";
            this.SoTienThuTxt.Size = new System.Drawing.Size(424, 39);
            this.SoTienThuTxt.TabIndex = 28;
            this.SoTienThuTxt.Validated += new System.EventHandler(this.SoTienThuTxt_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 378);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 32);
            this.label6.TabIndex = 27;
            this.label6.Text = "Số Tiền Thu";
            // 
            // TienConLaiTxt
            // 
            this.TienConLaiTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.TienConLaiTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TienConLaiTxt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TienConLaiTxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TienConLaiTxt.Location = new System.Drawing.Point(559, 443);
            this.TienConLaiTxt.Margin = new System.Windows.Forms.Padding(6, 11, 6, 11);
            this.TienConLaiTxt.Name = "TienConLaiTxt";
            this.TienConLaiTxt.ReadOnly = true;
            this.TienConLaiTxt.Size = new System.Drawing.Size(499, 39);
            this.TienConLaiTxt.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(550, 373);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 32);
            this.label7.TabIndex = 29;
            this.label7.Text = "Số tiền còn lại";
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Red;
            this.ExitBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Location = new System.Drawing.Point(968, 602);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(6, 11, 6, 11);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(147, 62);
            this.ExitBtn.TabIndex = 33;
            this.ExitBtn.Text = "Thoát";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.Turquoise;
            this.SearchBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.Location = new System.Drawing.Point(277, 602);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(6, 11, 6, 11);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(292, 62);
            this.SearchBtn.TabIndex = 32;
            this.SearchBtn.Text = "Tìm phiếu thu tiền phạt";
            this.SearchBtn.UseVisualStyleBackColor = false;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.BackColor = System.Drawing.Color.Turquoise;
            this.SubmitBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBtn.ForeColor = System.Drawing.Color.White;
            this.SubmitBtn.Location = new System.Drawing.Point(22, 602);
            this.SubmitBtn.Margin = new System.Windows.Forms.Padding(6, 11, 6, 11);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(209, 62);
            this.SubmitBtn.TabIndex = 31;
            this.SubmitBtn.Text = "Lập phiếu thu";
            this.SubmitBtn.UseVisualStyleBackColor = false;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // YeuCau7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 680);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.TienConLaiTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SoTienThuTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TongNoTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TenDocGiaCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MaPhieuThuTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MaBoPhanTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TenNhanVienCombo);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "YeuCau7";
            this.Text = "Lập phiếu thu tiền phạt";
            this.Load += new System.EventHandler(this.YeuCau7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TenNhanVienCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MaBoPhanTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MaPhieuThuTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TenDocGiaCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TongNoTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SoTienThuTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TienConLaiTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button SubmitBtn;
    }
}