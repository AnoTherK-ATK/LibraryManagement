﻿namespace DoAn.GUI.YeuCau2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_XoaTheDocGia));
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
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 32);
            this.label4.TabIndex = 71;
            this.label4.Text = "Mã độc giả";
            // 
            // TimTheDocGiaBtn
            // 
            this.TimTheDocGiaBtn.BackColor = System.Drawing.Color.Turquoise;
            this.TimTheDocGiaBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimTheDocGiaBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TimTheDocGiaBtn.Location = new System.Drawing.Point(242, 102);
            this.TimTheDocGiaBtn.Name = "TimTheDocGiaBtn";
            this.TimTheDocGiaBtn.Size = new System.Drawing.Size(118, 50);
            this.TimTheDocGiaBtn.TabIndex = 76;
            this.TimTheDocGiaBtn.Text = "Tìm";
            this.TimTheDocGiaBtn.UseVisualStyleBackColor = false;
            this.TimTheDocGiaBtn.Click += new System.EventHandler(this.TimTheDocGiaBtn_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.BackColor = System.Drawing.Color.Turquoise;
            this.DelBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DelBtn.Location = new System.Drawing.Point(392, 102);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(118, 50);
            this.DelBtn.TabIndex = 77;
            this.DelBtn.Text = "Xóa";
            this.DelBtn.UseVisualStyleBackColor = false;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // MaDocGiaTxt
            // 
            this.MaDocGiaTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaDocGiaTxt.Location = new System.Drawing.Point(24, 108);
            this.MaDocGiaTxt.Name = "MaDocGiaTxt";
            this.MaDocGiaTxt.ReadOnly = true;
            this.MaDocGiaTxt.Size = new System.Drawing.Size(176, 39);
            this.MaDocGiaTxt.TabIndex = 78;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Red;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitBtn.Location = new System.Drawing.Point(539, 102);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(118, 50);
            this.exitBtn.TabIndex = 79;
            this.exitBtn.Text = "Thoát";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // GUI_XoaTheDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 194);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.MaDocGiaTxt);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.TimTheDocGiaBtn);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GUI_XoaTheDocGia";
            this.Text = "Xoá thẻ độc giả";
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