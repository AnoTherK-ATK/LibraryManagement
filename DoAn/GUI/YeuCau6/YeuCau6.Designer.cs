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
            ((System.ComponentModel.ISupportInitialize)(this.Danhsachsachmuon)).BeginInit();
            this.SuspendLayout();
            // 
            // TenDocGiaCombo
            // 
            this.TenDocGiaCombo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TenDocGiaCombo.FormattingEnabled = true;
            this.TenDocGiaCombo.Location = new System.Drawing.Point(31, 54);
            this.TenDocGiaCombo.Name = "TenDocGiaCombo";
            this.TenDocGiaCombo.Size = new System.Drawing.Size(122, 29);
            this.TenDocGiaCombo.TabIndex = 14;
            this.TenDocGiaCombo.SelectedIndexChanged += new System.EventHandler(this.TenDocGiaCombo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(26, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tên độc giả";
            // 
            // NgayTradate
            // 
            this.NgayTradate.CustomFormat = "dd/MM/yyyy";
            this.NgayTradate.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.NgayTradate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NgayTradate.Location = new System.Drawing.Point(188, 54);
            this.NgayTradate.Name = "NgayTradate";
            this.NgayTradate.Size = new System.Drawing.Size(168, 31);
            this.NgayTradate.TabIndex = 16;
            this.NgayTradate.Value = new System.DateTime(2025, 5, 29, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(184, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ngày Trả";
            // 
            // TienPhatKiNayTxt
            // 
            this.TienPhatKiNayTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.TienPhatKiNayTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TienPhatKiNayTxt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TienPhatKiNayTxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TienPhatKiNayTxt.Location = new System.Drawing.Point(388, 54);
            this.TienPhatKiNayTxt.Name = "TienPhatKiNayTxt";
            this.TienPhatKiNayTxt.ReadOnly = true;
            this.TienPhatKiNayTxt.Size = new System.Drawing.Size(152, 29);
            this.TienPhatKiNayTxt.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(383, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tiền phạt kì này";
            // 
            // TienNoTxt
            // 
            this.TienNoTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TienNoTxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TienNoTxt.Location = new System.Drawing.Point(564, 53);
            this.TienNoTxt.Name = "TienNoTxt";
            this.TienNoTxt.Size = new System.Drawing.Size(120, 29);
            this.TienNoTxt.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(558, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tiền nợ";
            // 
            // TongNoTxt
            // 
            this.TongNoTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.TongNoTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TongNoTxt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TongNoTxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TongNoTxt.Location = new System.Drawing.Point(705, 53);
            this.TongNoTxt.Name = "TongNoTxt";
            this.TongNoTxt.ReadOnly = true;
            this.TongNoTxt.Size = new System.Drawing.Size(107, 29);
            this.TongNoTxt.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(700, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 21);
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
            this.tienPhat});
            this.Danhsachsachmuon.Location = new System.Drawing.Point(30, 118);
            this.Danhsachsachmuon.Name = "Danhsachsachmuon";
            this.Danhsachsachmuon.RowHeadersVisible = false;
            this.Danhsachsachmuon.RowHeadersWidth = 51;
            this.Danhsachsachmuon.RowTemplate.Height = 24;
            this.Danhsachsachmuon.Size = new System.Drawing.Size(782, 331);
            this.Danhsachsachmuon.TabIndex = 23;
            this.Danhsachsachmuon.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.Danhsachsachmuon_CellValidated);
            this.Danhsachsachmuon.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.Danhsachsachmuon_CellValidating);
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
            this.ngayMuon.Width = 170;
            // 
            // hanTraSach
            // 
            this.hanTraSach.HeaderText = "Hạn Trả Sách";
            this.hanTraSach.MinimumWidth = 6;
            this.hanTraSach.Name = "hanTraSach";
            this.hanTraSach.Width = 170;
            // 
            // tienPhat
            // 
            this.tienPhat.HeaderText = "Tiền Phạt";
            this.tienPhat.MinimumWidth = 6;
            this.tienPhat.Name = "tienPhat";
            this.tienPhat.ReadOnly = true;
            this.tienPhat.Width = 190;
            // 
            // YeuCau6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 478);
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
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.Name = "YeuCau6";
            this.Text = "YeuCau6";
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
    }
}