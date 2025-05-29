namespace DoAn.GUI.YeuCau5
{
    partial class GUI_TimPhieuMuon
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
            this.ResetBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TimPM = new System.Windows.Forms.Button();
            this.TenNhanVienTxt = new System.Windows.Forms.TextBox();
            this.MaNhanVienTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(991, 76);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(146, 38);
            this.ExitBtn.TabIndex = 47;
            this.ExitBtn.Text = "Thoát";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.Location = new System.Drawing.Point(1059, 31);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(113, 39);
            this.ResetBtn.TabIndex = 46;
            this.ResetBtn.Text = "Tái lập";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1134, 589);
            this.dataGridView1.TabIndex = 45;
            // 
            // TimPM
            // 
            this.TimPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimPM.Location = new System.Drawing.Point(957, 31);
            this.TimPM.Name = "TimPM";
            this.TimPM.Size = new System.Drawing.Size(89, 39);
            this.TimPM.TabIndex = 44;
            this.TimPM.Text = "Tìm";
            this.TimPM.UseVisualStyleBackColor = true;
            this.TimPM.Click += new System.EventHandler(this.TimPM_Click);
            // 
            // TenNhanVienTxt
            // 
            this.TenNhanVienTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenNhanVienTxt.Location = new System.Drawing.Point(529, 57);
            this.TenNhanVienTxt.Name = "TenNhanVienTxt";
            this.TenNhanVienTxt.Size = new System.Drawing.Size(222, 32);
            this.TenNhanVienTxt.TabIndex = 36;
            // 
            // MaNhanVienTxt
            // 
            this.MaNhanVienTxt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MaNhanVienTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaNhanVienTxt.Location = new System.Drawing.Point(214, 60);
            this.MaNhanVienTxt.Name = "MaNhanVienTxt";
            this.MaNhanVienTxt.Size = new System.Drawing.Size(104, 32);
            this.MaNhanVienTxt.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(418, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 26);
            this.label2.TabIndex = 33;
            this.label2.Text = "Họ và tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 26);
            this.label3.TabIndex = 32;
            this.label3.Text = "Mã phiếu mượn";
            // 
            // GUI_TimPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 738);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TimPM);
            this.Controls.Add(this.TenNhanVienTxt);
            this.Controls.Add(this.MaNhanVienTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "GUI_TimPhieuMuon";
            this.Text = "GUI_TimPhieuMuon";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button TimPM;
        private System.Windows.Forms.TextBox TenNhanVienTxt;
        private System.Windows.Forms.TextBox MaNhanVienTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}