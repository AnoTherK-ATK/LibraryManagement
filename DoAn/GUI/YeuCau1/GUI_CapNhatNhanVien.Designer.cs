﻿namespace DoAn.GUI.YeuCau1
{
    partial class GUI_CapNhatNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_CapNhatNhanVien));
            this.ExitBtn = new System.Windows.Forms.Button();
            this.CapNhatNhanVienBtn = new System.Windows.Forms.Button();
            this.SDTTxt = new System.Windows.Forms.TextBox();
            this.ChucVuCombo = new System.Windows.Forms.ComboBox();
            this.DiaChiTxt = new System.Windows.Forms.TextBox();
            this.BoPhanCombo = new System.Windows.Forms.ComboBox();
            this.NgaySinhSelector = new System.Windows.Forms.DateTimePicker();
            this.BangCapCombo = new System.Windows.Forms.ComboBox();
            this.TenNhanVienTxt = new System.Windows.Forms.TextBox();
            this.MaNhanVienTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TimNhanVienBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Red;
            this.ExitBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExitBtn.Location = new System.Drawing.Point(913, 510);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(168, 50);
            this.ExitBtn.TabIndex = 42;
            this.ExitBtn.Text = "Thoát";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // CapNhatNhanVienBtn
            // 
            this.CapNhatNhanVienBtn.BackColor = System.Drawing.Color.Turquoise;
            this.CapNhatNhanVienBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CapNhatNhanVienBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CapNhatNhanVienBtn.Location = new System.Drawing.Point(635, 510);
            this.CapNhatNhanVienBtn.Name = "CapNhatNhanVienBtn";
            this.CapNhatNhanVienBtn.Size = new System.Drawing.Size(218, 50);
            this.CapNhatNhanVienBtn.TabIndex = 41;
            this.CapNhatNhanVienBtn.Text = "Cập nhật nhân viên";
            this.CapNhatNhanVienBtn.UseVisualStyleBackColor = false;
            this.CapNhatNhanVienBtn.Click += new System.EventHandler(this.CapNhatNhanVienBtn_Click);
            // 
            // SDTTxt
            // 
            this.SDTTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SDTTxt.Location = new System.Drawing.Point(36, 380);
            this.SDTTxt.MaxLength = 10;
            this.SDTTxt.Name = "SDTTxt";
            this.SDTTxt.ReadOnly = true;
            this.SDTTxt.Size = new System.Drawing.Size(340, 39);
            this.SDTTxt.TabIndex = 37;
            // 
            // ChucVuCombo
            // 
            this.ChucVuCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChucVuCombo.FormattingEnabled = true;
            this.ChucVuCombo.Location = new System.Drawing.Point(729, 271);
            this.ChucVuCombo.Name = "ChucVuCombo";
            this.ChucVuCombo.Size = new System.Drawing.Size(248, 40);
            this.ChucVuCombo.TabIndex = 36;
            // 
            // DiaChiTxt
            // 
            this.DiaChiTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiaChiTxt.Location = new System.Drawing.Point(36, 271);
            this.DiaChiTxt.Name = "DiaChiTxt";
            this.DiaChiTxt.ReadOnly = true;
            this.DiaChiTxt.Size = new System.Drawing.Size(340, 39);
            this.DiaChiTxt.TabIndex = 35;
            // 
            // BoPhanCombo
            // 
            this.BoPhanCombo.Enabled = false;
            this.BoPhanCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoPhanCombo.FormattingEnabled = true;
            this.BoPhanCombo.Location = new System.Drawing.Point(729, 157);
            this.BoPhanCombo.Name = "BoPhanCombo";
            this.BoPhanCombo.Size = new System.Drawing.Size(248, 40);
            this.BoPhanCombo.TabIndex = 34;
            // 
            // NgaySinhSelector
            // 
            this.NgaySinhSelector.CustomFormat = "dd/MM/yyyy";
            this.NgaySinhSelector.Enabled = false;
            this.NgaySinhSelector.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgaySinhSelector.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NgaySinhSelector.Location = new System.Drawing.Point(36, 157);
            this.NgaySinhSelector.Name = "NgaySinhSelector";
            this.NgaySinhSelector.Size = new System.Drawing.Size(340, 39);
            this.NgaySinhSelector.TabIndex = 33;
            this.NgaySinhSelector.Value = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            // 
            // BangCapCombo
            // 
            this.BangCapCombo.Enabled = false;
            this.BangCapCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BangCapCombo.FormattingEnabled = true;
            this.BangCapCombo.Location = new System.Drawing.Point(729, 52);
            this.BangCapCombo.Name = "BangCapCombo";
            this.BangCapCombo.Size = new System.Drawing.Size(248, 40);
            this.BangCapCombo.TabIndex = 32;
            // 
            // TenNhanVienTxt
            // 
            this.TenNhanVienTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenNhanVienTxt.Location = new System.Drawing.Point(371, 52);
            this.TenNhanVienTxt.Name = "TenNhanVienTxt";
            this.TenNhanVienTxt.ReadOnly = true;
            this.TenNhanVienTxt.Size = new System.Drawing.Size(242, 39);
            this.TenNhanVienTxt.TabIndex = 31;
            // 
            // MaNhanVienTxt
            // 
            this.MaNhanVienTxt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MaNhanVienTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaNhanVienTxt.Location = new System.Drawing.Point(36, 52);
            this.MaNhanVienTxt.Name = "MaNhanVienTxt";
            this.MaNhanVienTxt.ReadOnly = true;
            this.MaNhanVienTxt.Size = new System.Drawing.Size(186, 39);
            this.MaNhanVienTxt.TabIndex = 30;
            this.MaNhanVienTxt.TextChanged += new System.EventHandler(this.MaNhanVienTxt_TextChanged);
            this.MaNhanVienTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MaNhanVienTxt_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 32);
            this.label8.TabIndex = 29;
            this.label8.Text = "Số điện thoại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(723, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 32);
            this.label7.TabIndex = 28;
            this.label7.Text = "Tên chức vụ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 32);
            this.label6.TabIndex = 27;
            this.label6.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(723, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 32);
            this.label5.TabIndex = 26;
            this.label5.Text = "Tên bộ phận";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 32);
            this.label4.TabIndex = 25;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(722, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 32);
            this.label3.TabIndex = 24;
            this.label3.Text = "Tên bằng cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 32);
            this.label2.TabIndex = 23;
            this.label2.Text = "Họ và tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 32);
            this.label1.TabIndex = 22;
            this.label1.Text = "Mã nhân viên";
            // 
            // TimNhanVienBtn
            // 
            this.TimNhanVienBtn.BackColor = System.Drawing.Color.Turquoise;
            this.TimNhanVienBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TimNhanVienBtn.Location = new System.Drawing.Point(244, 52);
            this.TimNhanVienBtn.Name = "TimNhanVienBtn";
            this.TimNhanVienBtn.Size = new System.Drawing.Size(96, 44);
            this.TimNhanVienBtn.TabIndex = 43;
            this.TimNhanVienBtn.Text = "Tìm";
            this.TimNhanVienBtn.UseVisualStyleBackColor = false;
            this.TimNhanVienBtn.Click += new System.EventHandler(this.TimNhanVienBtn_Click);
            // 
            // GUI_CapNhatNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 727);
            this.Controls.Add(this.TimNhanVienBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.CapNhatNhanVienBtn);
            this.Controls.Add(this.SDTTxt);
            this.Controls.Add(this.ChucVuCombo);
            this.Controls.Add(this.DiaChiTxt);
            this.Controls.Add(this.BoPhanCombo);
            this.Controls.Add(this.NgaySinhSelector);
            this.Controls.Add(this.BangCapCombo);
            this.Controls.Add(this.TenNhanVienTxt);
            this.Controls.Add(this.MaNhanVienTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GUI_CapNhatNhanVien";
            this.Text = "Cập nhật nhân viên";
            this.Load += new System.EventHandler(this.GUI_CapNhatNhanVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button CapNhatNhanVienBtn;
        private System.Windows.Forms.TextBox SDTTxt;
        private System.Windows.Forms.ComboBox ChucVuCombo;
        private System.Windows.Forms.TextBox DiaChiTxt;
        private System.Windows.Forms.ComboBox BoPhanCombo;
        private System.Windows.Forms.DateTimePicker NgaySinhSelector;
        private System.Windows.Forms.ComboBox BangCapCombo;
        private System.Windows.Forms.TextBox TenNhanVienTxt;
        private System.Windows.Forms.TextBox MaNhanVienTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TimNhanVienBtn;
    }
}