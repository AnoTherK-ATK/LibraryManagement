namespace DoAn.GUI.YeuCau1
{
    partial class GUI_XoaNhanVien
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
            this.MaNhanVienTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TimNhanVienBtn = new System.Windows.Forms.Button();
            this.DeleteBtb = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MaNhanVienTxt
            // 
            this.MaNhanVienTxt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MaNhanVienTxt.Location = new System.Drawing.Point(23, 55);
            this.MaNhanVienTxt.Name = "MaNhanVienTxt";
            this.MaNhanVienTxt.ReadOnly = true;
            this.MaNhanVienTxt.Size = new System.Drawing.Size(171, 29);
            this.MaNhanVienTxt.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã nhân viên";
            // 
            // TimNhanVienBtn
            // 
            this.TimNhanVienBtn.Location = new System.Drawing.Point(212, 54);
            this.TimNhanVienBtn.Name = "TimNhanVienBtn";
            this.TimNhanVienBtn.Size = new System.Drawing.Size(93, 29);
            this.TimNhanVienBtn.TabIndex = 44;
            this.TimNhanVienBtn.Text = "Tìm";
            this.TimNhanVienBtn.UseVisualStyleBackColor = true;
            this.TimNhanVienBtn.Click += new System.EventHandler(this.TimNhanVienBtn_Click);
            // 
            // DeleteBtb
            // 
            this.DeleteBtb.Location = new System.Drawing.Point(423, 44);
            this.DeleteBtb.Name = "DeleteBtb";
            this.DeleteBtb.Size = new System.Drawing.Size(156, 40);
            this.DeleteBtb.TabIndex = 45;
            this.DeleteBtb.Text = "Xoá nhân viên";
            this.DeleteBtb.UseVisualStyleBackColor = true;
            this.DeleteBtb.Click += new System.EventHandler(this.DeleteBtb_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(461, 119);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(118, 29);
            this.ExitBtn.TabIndex = 46;
            this.ExitBtn.Text = "Thoát";
            this.ExitBtn.UseVisualStyleBackColor = true;
            // 
            // GUI_XoaNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 164);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.DeleteBtb);
            this.Controls.Add(this.TimNhanVienBtn);
            this.Controls.Add(this.MaNhanVienTxt);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GUI_XoaNhanVien";
            this.Text = "GUI_XoaNhanVien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MaNhanVienTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TimNhanVienBtn;
        private System.Windows.Forms.Button DeleteBtb;
        private System.Windows.Forms.Button ExitBtn;
    }
}