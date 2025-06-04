namespace DoAn.GUI.YeuCau6
{
    partial class YeuCau6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YeuCau6));
            this.TenDocGiaCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NgayTradate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.TienPhatKiNayTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TienNoTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TongNoTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Danhsachsachmuon = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSach = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ngayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hanTraSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soNgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SubmitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Danhsachsachmuon)).BeginInit();
            this.SuspendLayout();
            // 
            // TenDocGiaCombo
            // 
            this.TenDocGiaCombo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TenDocGiaCombo.FormattingEnabled = true;
            this.TenDocGiaCombo.Location = new System.Drawing.Point(45, 82);
            this.TenDocGiaCombo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TenDocGiaCombo.Name = "TenDocGiaCombo";
            this.TenDocGiaCombo.Size = new System.Drawing.Size(174, 40);
            this.TenDocGiaCombo.TabIndex = 14;
            this.TenDocGiaCombo.SelectedIndexChanged += new System.EventHandler(this.TenDocGiaCombo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tên độc giả";
            // 
            // NgayTradate
            // 
            this.NgayTradate.CustomFormat = "dd/MM/yyyy";
            this.NgayTradate.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.NgayTradate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NgayTradate.Location = new System.Drawing.Point(272, 82);
            this.NgayTradate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NgayTradate.Name = "NgayTradate";
            this.NgayTradate.Size = new System.Drawing.Size(241, 42);
            this.NgayTradate.TabIndex = 16;
            this.NgayTradate.Value = new System.DateTime(2025, 5, 29, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(266, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 32);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ngày Trả";
            // 
            // TienPhatKiNayTxt
            // 
            this.TienPhatKiNayTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.TienPhatKiNayTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TienPhatKiNayTxt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TienPhatKiNayTxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TienPhatKiNayTxt.Location = new System.Drawing.Point(560, 82);
            this.TienPhatKiNayTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TienPhatKiNayTxt.Name = "TienPhatKiNayTxt";
            this.TienPhatKiNayTxt.ReadOnly = true;
            this.TienPhatKiNayTxt.Size = new System.Drawing.Size(219, 39);
            this.TienPhatKiNayTxt.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(553, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 32);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tiền phạt kì này";
            // 
            // TienNoTxt
            // 
            this.TienNoTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TienNoTxt.Enabled = false;
            this.TienNoTxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TienNoTxt.Location = new System.Drawing.Point(815, 81);
            this.TienNoTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TienNoTxt.Name = "TienNoTxt";
            this.TienNoTxt.Size = new System.Drawing.Size(172, 39);
            this.TienNoTxt.TabIndex = 20;
            this.TienNoTxt.Validated += new System.EventHandler(this.TienNoTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(806, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 32);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tiền nợ";
            // 
            // TongNoTxt
            // 
            this.TongNoTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.TongNoTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TongNoTxt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TongNoTxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TongNoTxt.Location = new System.Drawing.Point(1018, 81);
            this.TongNoTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TongNoTxt.Name = "TongNoTxt";
            this.TongNoTxt.ReadOnly = true;
            this.TongNoTxt.Size = new System.Drawing.Size(154, 39);
            this.TongNoTxt.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1011, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 32);
            this.label5.TabIndex = 21;
            this.label5.Text = "Tổng nợ";
            // 
            // Danhsachsachmuon
            // 
            this.Danhsachsachmuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Danhsachsachmuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.tenSach,
            this.ngayMuon,
            this.hanTraSach,
            this.tienPhat,
            this.soNgayMuon});
            this.Danhsachsachmuon.Enabled = false;
            this.Danhsachsachmuon.Location = new System.Drawing.Point(43, 180);
            this.Danhsachsachmuon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Danhsachsachmuon.Name = "Danhsachsachmuon";
            this.Danhsachsachmuon.RowHeadersVisible = false;
            this.Danhsachsachmuon.RowHeadersWidth = 51;
            this.Danhsachsachmuon.RowTemplate.Height = 24;
            this.Danhsachsachmuon.Size = new System.Drawing.Size(1130, 491);
            this.Danhsachsachmuon.TabIndex = 23;
            this.Danhsachsachmuon.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.Danhsachsachmuon_CellValidated);
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.MinimumWidth = 6;
            this.stt.Name = "stt";
            this.stt.Width = 50;
            // 
            // tenSach
            // 
            this.tenSach.HeaderText = "Tên Sách";
            this.tenSach.MinimumWidth = 6;
            this.tenSach.Name = "tenSach";
            this.tenSach.Width = 200;
            // 
            // ngayMuon
            // 
            this.ngayMuon.HeaderText = "Ngày Mượn";
            this.ngayMuon.MinimumWidth = 6;
            this.ngayMuon.Name = "ngayMuon";
            this.ngayMuon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ngayMuon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ngayMuon.Width = 140;
            // 
            // hanTraSach
            // 
            this.hanTraSach.HeaderText = "Hạn Trả Sách";
            this.hanTraSach.MinimumWidth = 6;
            this.hanTraSach.Name = "hanTraSach";
            this.hanTraSach.Width = 140;
            // 
            // tienPhat
            // 
            this.tienPhat.HeaderText = "Tiền Phạt";
            this.tienPhat.MinimumWidth = 6;
            this.tienPhat.Name = "tienPhat";
            this.tienPhat.ReadOnly = true;
            this.tienPhat.Width = 140;
            // 
            // soNgayMuon
            // 
            this.soNgayMuon.HeaderText = "Số Ngày Mượn";
            this.soNgayMuon.MinimumWidth = 6;
            this.soNgayMuon.Name = "soNgayMuon";
            this.soNgayMuon.ReadOnly = true;
            this.soNgayMuon.Width = 110;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Red;
            this.ExitBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Location = new System.Drawing.Point(1008, 702);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(165, 61);
            this.ExitBtn.TabIndex = 27;
            this.ExitBtn.Text = "Thoát";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.Turquoise;
            this.SearchBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.Location = new System.Drawing.Point(316, 702);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(272, 61);
            this.SearchBtn.TabIndex = 26;
            this.SearchBtn.Text = "Tìm sách đã trả";
            this.SearchBtn.UseVisualStyleBackColor = false;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.BackColor = System.Drawing.Color.Turquoise;
            this.SubmitBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBtn.ForeColor = System.Drawing.Color.White;
            this.SubmitBtn.Location = new System.Drawing.Point(48, 702);
            this.SubmitBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(260, 61);
            this.SubmitBtn.TabIndex = 25;
            this.SubmitBtn.Text = "Trả sách";
            this.SubmitBtn.UseVisualStyleBackColor = false;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // YeuCau6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 805);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.Danhsachsachmuon);
            this.Controls.Add(this.TongNoTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TienNoTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TienPhatKiNayTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NgayTradate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TenDocGiaCombo);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "YeuCau6";
            this.Text = "Trả sách";
            this.Load += new System.EventHandler(this.YeuCau6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Danhsachsachmuon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TenDocGiaCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker NgayTradate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TienPhatKiNayTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TienNoTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TongNoTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView Danhsachsachmuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewComboBoxColumn tenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn hanTraSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienPhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn soNgayMuon;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button SubmitBtn;
    }
}