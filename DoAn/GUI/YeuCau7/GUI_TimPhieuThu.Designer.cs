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
            this.Name_text.Location = new System.Drawing.Point(382, 34);
            this.Name_text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name_text.Name = "Name_text";
            this.Name_text.Size = new System.Drawing.Size(138, 34);
            this.Name_text.TabIndex = 40;
            // 
            // MaPM_text
            // 
            this.MaPM_text.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MaPM_text.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaPM_text.Location = new System.Drawing.Point(148, 34);
            this.MaPM_text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaPM_text.Name = "MaPM_text";
            this.MaPM_text.Size = new System.Drawing.Size(95, 34);
            this.MaPM_text.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(267, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 28);
            this.label2.TabIndex = 38;
            this.label2.Text = "Mã độc giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 28);
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
            this.Phieuthutien.Location = new System.Drawing.Point(17, 96);
            this.Phieuthutien.Name = "Phieuthutien";
            this.Phieuthutien.RowHeadersVisible = false;
            this.Phieuthutien.RowHeadersWidth = 51;
            this.Phieuthutien.RowTemplate.Height = 24;
            this.Phieuthutien.Size = new System.Drawing.Size(503, 232);
            this.Phieuthutien.TabIndex = 41;
            // 
            // TimPM
            // 
            this.TimPM.BackColor = System.Drawing.Color.Turquoise;
            this.TimPM.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.TimPM.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TimPM.Location = new System.Drawing.Point(238, 67);
            this.TimPM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TimPM.Name = "TimPM";
            this.TimPM.Size = new System.Drawing.Size(80, 28);
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
            this.maPhieuThu.Width = 125;
            // 
            // maNhanVien
            // 
            this.maNhanVien.HeaderText = "Mã Nhân Viên";
            this.maNhanVien.MinimumWidth = 6;
            this.maNhanVien.Name = "maNhanVien";
            this.maNhanVien.ReadOnly = true;
            this.maNhanVien.Width = 125;
            // 
            // maDocGia
            // 
            this.maDocGia.HeaderText = "Mã Độc Giả";
            this.maDocGia.MinimumWidth = 6;
            this.maDocGia.Name = "maDocGia";
            this.maDocGia.ReadOnly = true;
            this.maDocGia.Width = 125;
            // 
            // soTienThu
            // 
            this.soTienThu.HeaderText = "Số Tiền Thu";
            this.soTienThu.MinimumWidth = 6;
            this.soTienThu.Name = "soTienThu";
            this.soTienThu.ReadOnly = true;
            this.soTienThu.Width = 125;
            // 
            // GUI_TimPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 450);
            this.Controls.Add(this.TimPM);
            this.Controls.Add(this.Phieuthutien);
            this.Controls.Add(this.Name_text);
            this.Controls.Add(this.MaPM_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "GUI_TimPhieuMuon";
            this.Text = "GUI_TimPhieuMuon";
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