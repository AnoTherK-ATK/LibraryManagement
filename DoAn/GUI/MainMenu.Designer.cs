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
            this.SuspendLayout();
            // 
            // YC1btn
            // 
            this.YC1btn.Location = new System.Drawing.Point(20, 30);
            this.YC1btn.Name = "YC1btn";
            this.YC1btn.Size = new System.Drawing.Size(288, 104);
            this.YC1btn.TabIndex = 0;
            this.YC1btn.Text = "Tiếp nhận nhân viên";
            this.YC1btn.UseVisualStyleBackColor = true;
            this.YC1btn.Click += new System.EventHandler(this.YC1btn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 821);
            this.Controls.Add(this.YC1btn);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "MainMenu";
            this.Text = "Quản lý thư viện";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button YC1btn;
    }
}

