namespace DoAn.GUI.YeuCau5
{
    partial class YeuCau5
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
            this.MaPhieuMuonTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TenDocGiaCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NgaySinhSelector = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.HanTraSachTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SoSachQuaHanTxt = new System.Windows.Forms.TextBox();
            this.SachMuonTheoQDTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MaPhieuMuonTxt
            // 
            this.MaPhieuMuonTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.MaPhieuMuonTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaPhieuMuonTxt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MaPhieuMuonTxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MaPhieuMuonTxt.Location = new System.Drawing.Point(28, 45);
            this.MaPhieuMuonTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaPhieuMuonTxt.Name = "MaPhieuMuonTxt";
            this.MaPhieuMuonTxt.ReadOnly = true;
            this.MaPhieuMuonTxt.Size = new System.Drawing.Size(146, 34);
            this.MaPhieuMuonTxt.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã phiếu mượn";
            // 
            // TenDocGiaCombo
            // 
            this.TenDocGiaCombo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TenDocGiaCombo.FormattingEnabled = true;
            this.TenDocGiaCombo.Location = new System.Drawing.Point(202, 43);
            this.TenDocGiaCombo.Name = "TenDocGiaCombo";
            this.TenDocGiaCombo.Size = new System.Drawing.Size(139, 36);
            this.TenDocGiaCombo.TabIndex = 12;
            this.TenDocGiaCombo.SelectedIndexChanged += new System.EventHandler(this.TenDocGiaCombo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tên độc giả";
            // 
            // NgaySinhSelector
            // 
            this.NgaySinhSelector.CustomFormat = "dd/MM/yyyy";
            this.NgaySinhSelector.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NgaySinhSelector.Location = new System.Drawing.Point(392, 44);
            this.NgaySinhSelector.Name = "NgaySinhSelector";
            this.NgaySinhSelector.Size = new System.Drawing.Size(191, 34);
            this.NgaySinhSelector.TabIndex = 14;
            this.NgaySinhSelector.Value = new System.DateTime(2025, 5, 29, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 28);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ngày mượn";
            // 
            // HanTraSachTxt
            // 
            this.HanTraSachTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.HanTraSachTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HanTraSachTxt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.HanTraSachTxt.Location = new System.Drawing.Point(616, 45);
            this.HanTraSachTxt.Name = "HanTraSachTxt";
            this.HanTraSachTxt.ReadOnly = true;
            this.HanTraSachTxt.Size = new System.Drawing.Size(191, 34);
            this.HanTraSachTxt.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(611, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 28);
            this.label2.TabIndex = 15;
            this.label2.Text = "Hạn Trả Sách";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 28);
            this.label5.TabIndex = 17;
            this.label5.Text = "Số sách mượn quá hạn";
            // 
            // SoSachQuaHanTxt
            // 
            this.SoSachQuaHanTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.SoSachQuaHanTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SoSachQuaHanTxt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SoSachQuaHanTxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SoSachQuaHanTxt.ForeColor = System.Drawing.Color.Black;
            this.SoSachQuaHanTxt.Location = new System.Drawing.Point(241, 108);
            this.SoSachQuaHanTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SoSachQuaHanTxt.Name = "SoSachQuaHanTxt";
            this.SoSachQuaHanTxt.ReadOnly = true;
            this.SoSachQuaHanTxt.Size = new System.Drawing.Size(100, 34);
            this.SoSachQuaHanTxt.TabIndex = 18;
            // 
            // SachMuonTheoQDTxt
            // 
            this.SachMuonTheoQDTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.SachMuonTheoQDTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SachMuonTheoQDTxt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SachMuonTheoQDTxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SachMuonTheoQDTxt.ForeColor = System.Drawing.Color.Black;
            this.SachMuonTheoQDTxt.Location = new System.Drawing.Point(718, 108);
            this.SachMuonTheoQDTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SachMuonTheoQDTxt.Name = "SachMuonTheoQDTxt";
            this.SachMuonTheoQDTxt.ReadOnly = true;
            this.SachMuonTheoQDTxt.Size = new System.Drawing.Size(89, 34);
            this.SachMuonTheoQDTxt.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(387, 110);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(332, 28);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tổng sách mượn theo ngày quy định";
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.BackColor = System.Drawing.Color.Turquoise;
            this.SubmitBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBtn.ForeColor = System.Drawing.Color.White;
            this.SubmitBtn.Location = new System.Drawing.Point(28, 477);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(180, 40);
            this.SubmitBtn.TabIndex = 22;
            this.SubmitBtn.Text = "Lập phiếu mượn";
            this.SubmitBtn.UseVisualStyleBackColor = false;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.Turquoise;
            this.SearchBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.Location = new System.Drawing.Point(360, 477);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(157, 40);
            this.SearchBtn.TabIndex = 23;
            this.SearchBtn.Text = "Tìm phiếu";
            this.SearchBtn.UseVisualStyleBackColor = false;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Red;
            this.ExitBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Location = new System.Drawing.Point(693, 477);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(114, 40);
            this.ExitBtn.TabIndex = 24;
            this.ExitBtn.Text = "Thoát";
            this.ExitBtn.UseVisualStyleBackColor = false;
            // 
            // YeuCau5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(839, 522);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.SachMuonTheoQDTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SoSachQuaHanTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.HanTraSachTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NgaySinhSelector);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TenDocGiaCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MaPhieuMuonTxt);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "YeuCau5";
            this.Text = "YeuCau5";
            this.Load += new System.EventHandler(this.YeuCau5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MaPhieuMuonTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TenDocGiaCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker NgaySinhSelector;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox HanTraSachTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SoSachQuaHanTxt;
        private System.Windows.Forms.TextBox SachMuonTheoQDTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button ExitBtn;
    }
}