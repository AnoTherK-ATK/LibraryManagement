namespace DoAn.GUI.YeuCau2
{
    partial class GUI_XoaTheDocGia
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
            this.label4 = new System.Windows.Forms.Label();
            this.TimTheDocGiaBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.MaDocGiaTxt = new System.Windows.Forms.TextBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 71;
            this.label4.Text = "Mã độc giả";
            // 
            // TimTheDocGiaBtn
            // 
            this.TimTheDocGiaBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimTheDocGiaBtn.Location = new System.Drawing.Point(161, 63);
            this.TimTheDocGiaBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TimTheDocGiaBtn.Name = "TimTheDocGiaBtn";
            this.TimTheDocGiaBtn.Size = new System.Drawing.Size(79, 31);
            this.TimTheDocGiaBtn.TabIndex = 76;
            this.TimTheDocGiaBtn.Text = "Tìm";
            this.TimTheDocGiaBtn.UseVisualStyleBackColor = true;
            this.TimTheDocGiaBtn.Click += new System.EventHandler(this.TimTheDocGiaBtn_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< Updated upstream
            this.DelBtn.Location = new System.Drawing.Point(348, 80);
=======
            this.DelBtn.Location = new System.Drawing.Point(261, 63);
            this.DelBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> Stashed changes
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(79, 31);
            this.DelBtn.TabIndex = 77;
            this.DelBtn.Text = "Xóa";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // MaDocGiaTxt
            // 
            this.MaDocGiaTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaDocGiaTxt.Location = new System.Drawing.Point(16, 67);
            this.MaDocGiaTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaDocGiaTxt.Name = "MaDocGiaTxt";
            this.MaDocGiaTxt.ReadOnly = true;
            this.MaDocGiaTxt.Size = new System.Drawing.Size(119, 29);
            this.MaDocGiaTxt.TabIndex = 78;
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< Updated upstream
            this.exitBtn.Location = new System.Drawing.Point(479, 80);
=======
            this.exitBtn.Location = new System.Drawing.Point(359, 63);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> Stashed changes
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(79, 31);
            this.exitBtn.TabIndex = 79;
            this.exitBtn.Text = "Thoát";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // GUI_XoaTheDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 120);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.MaDocGiaTxt);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.TimTheDocGiaBtn);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GUI_XoaTheDocGia";
            this.Text = "GUI_XoaTheDocGia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button TimTheDocGiaBtn;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.TextBox MaDocGiaTxt;
        private System.Windows.Forms.Button exitBtn;
    }
}