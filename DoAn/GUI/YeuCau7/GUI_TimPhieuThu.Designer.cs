namespace DoAn.GUI.YeuCau7
{
    partial class GUI_TimPhieuThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_TimPhieuThu));
            this.Name_text = new System.Windows.Forms.TextBox();
            this.MaPM_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Phieuthutien = new System.Windows.Forms.DataGridView();
            this.TimPM = new System.Windows.Forms.Button();
            this.maPhieuThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTienThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Phieuthutien)).BeginInit();
            this.SuspendLayout();
            // 
            // Name_text
            // 
            this.Name_text.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_text.Location = new System.Drawing.Point(621, 69);
            this.Name_text.Margin = new System.Windows.Forms.Padding(6, 11, 6, 11);
            this.Name_text.Name = "Name_text";
            this.Name_text.Size = new System.Drawing.Size(222, 39);
            this.Name_text.TabIndex = 40;
            // 
            // MaPM_text
            // 
            this.MaPM_text.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MaPM_text.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaPM_text.Location = new System.Drawing.Point(240, 69);
            this.MaPM_text.Margin = new System.Windows.Forms.Padding(6, 11, 6, 11);
            this.MaPM_text.Name = "MaPM_text";
            this.MaPM_text.Size = new System.Drawing.Size(151, 39);
            this.MaPM_text.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(433, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 32);
            this.label2.TabIndex = 38;
            this.label2.Text = "Mã độc giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 32);
            this.label3.TabIndex = 37;
            this.label3.Text = "Mã phiếu thu ";
            // 
            // Phieuthutien
            // 
            this.Phieuthutien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Phieuthutien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhieuThu,
            this.maNhanVien,
            this.maDocGia,
            this.soTienThu});
            this.Phieuthutien.Location = new System.Drawing.Point(27, 192);
            this.Phieuthutien.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Phieuthutien.Name = "Phieuthutien";
            this.Phieuthutien.RowHeadersVisible = false;
            this.Phieuthutien.RowHeadersWidth = 51;
            this.Phieuthutien.RowTemplate.Height = 24;
            this.Phieuthutien.Size = new System.Drawing.Size(818, 463);
            this.Phieuthutien.TabIndex = 41;
            // 
            // TimPM
            // 
            this.TimPM.BackColor = System.Drawing.Color.Turquoise;
            this.TimPM.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimPM.ForeColor = System.Drawing.SystemColors.Control;
            this.TimPM.Location = new System.Drawing.Point(713, 130);
            this.TimPM.Margin = new System.Windows.Forms.Padding(6, 11, 6, 11);
            this.TimPM.Name = "TimPM";
            this.TimPM.Size = new System.Drawing.Size(130, 56);
            this.TimPM.TabIndex = 45;
            this.TimPM.Text = "Tìm";
            this.TimPM.UseVisualStyleBackColor = false;
            this.TimPM.Click += new System.EventHandler(this.TimPM_Click);
            // 
            // maPhieuThu
            // 
            this.maPhieuThu.HeaderText = "Mã Phiếu Thu";
            this.maPhieuThu.MinimumWidth = 6;
            this.maPhieuThu.Name = "maPhieuThu";
            this.maPhieuThu.ReadOnly = true;
            this.maPhieuThu.Width = 200;
            // 
            // maNhanVien
            // 
            this.maNhanVien.HeaderText = "Mã Nhân Viên";
            this.maNhanVien.MinimumWidth = 6;
            this.maNhanVien.Name = "maNhanVien";
            this.maNhanVien.ReadOnly = true;
            this.maNhanVien.Width = 200;
            // 
            // maDocGia
            // 
            this.maDocGia.HeaderText = "Mã Độc Giả";
            this.maDocGia.MinimumWidth = 6;
            this.maDocGia.Name = "maDocGia";
            this.maDocGia.ReadOnly = true;
            this.maDocGia.Width = 200;
            // 
            // soTienThu
            // 
            this.soTienThu.HeaderText = "Số Tiền Thu";
            this.soTienThu.MinimumWidth = 6;
            this.soTienThu.Name = "soTienThu";
            this.soTienThu.ReadOnly = true;
            this.soTienThu.Width = 200;
            // 
            // GUI_TimPhieuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 901);
            this.Controls.Add(this.TimPM);
            this.Controls.Add(this.Phieuthutien);
            this.Controls.Add(this.Name_text);
            this.Controls.Add(this.MaPM_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "GUI_TimPhieuThu";
            this.Text = "Tìm phiếu thu";
            this.Load += new System.EventHandler(this.GUI_TimPhieuMuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Phieuthutien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name_text;
        private System.Windows.Forms.TextBox MaPM_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Phieuthutien;
        private System.Windows.Forms.Button TimPM;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhieuThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTienThu;
    }
}