namespace DoAn
{
    partial class MainMenu
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
            this.YC1btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TimNhanVienBtn = new System.Windows.Forms.Button();
            this.UpdateNhanVienBtn = new System.Windows.Forms.Button();
            this.DelNhanVienBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // YC1btn
            // 
            this.YC1btn.Location = new System.Drawing.Point(12, 56);
            this.YC1btn.Name = "YC1btn";
            this.YC1btn.Size = new System.Drawing.Size(187, 30);
            this.YC1btn.TabIndex = 0;
            this.YC1btn.Text = "Tiếp nhận nhân viên";
            this.YC1btn.UseVisualStyleBackColor = true;
            this.YC1btn.Click += new System.EventHandler(this.YC1btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý nhân viên";
            // 
            // TimNhanVienBtn
            // 
            this.TimNhanVienBtn.Location = new System.Drawing.Point(12, 92);
            this.TimNhanVienBtn.Name = "TimNhanVienBtn";
            this.TimNhanVienBtn.Size = new System.Drawing.Size(187, 30);
            this.TimNhanVienBtn.TabIndex = 19;
            this.TimNhanVienBtn.Text = "Tìm nhân viên";
            this.TimNhanVienBtn.UseVisualStyleBackColor = true;
            this.TimNhanVienBtn.Click += new System.EventHandler(this.TimNhanVienBtn_Click);
            // 
            // UpdateNhanVienBtn
            // 
            this.UpdateNhanVienBtn.Location = new System.Drawing.Point(12, 128);
            this.UpdateNhanVienBtn.Name = "UpdateNhanVienBtn";
            this.UpdateNhanVienBtn.Size = new System.Drawing.Size(187, 30);
            this.UpdateNhanVienBtn.TabIndex = 20;
            this.UpdateNhanVienBtn.Text = "Cập nhật nhân viên";
            this.UpdateNhanVienBtn.UseVisualStyleBackColor = true;
            this.UpdateNhanVienBtn.Click += new System.EventHandler(this.UpdateNhanVienBtn_Click);
            // 
            // DelNhanVienBtn
            // 
            this.DelNhanVienBtn.Location = new System.Drawing.Point(12, 164);
            this.DelNhanVienBtn.Name = "DelNhanVienBtn";
            this.DelNhanVienBtn.Size = new System.Drawing.Size(187, 30);
            this.DelNhanVienBtn.TabIndex = 21;
            this.DelNhanVienBtn.Text = "Xoá nhân viên";
            this.DelNhanVienBtn.UseVisualStyleBackColor = true;
            this.DelNhanVienBtn.Click += new System.EventHandler(this.DelNhanVienBtn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 821);
            this.Controls.Add(this.DelNhanVienBtn);
            this.Controls.Add(this.UpdateNhanVienBtn);
            this.Controls.Add(this.TimNhanVienBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YC1btn);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "MainMenu";
            this.Text = "Quản lý thư viện";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button YC1btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TimNhanVienBtn;
        private System.Windows.Forms.Button UpdateNhanVienBtn;
        private System.Windows.Forms.Button DelNhanVienBtn;
    }
}

