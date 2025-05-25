using DoAn.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.GUI.YeuCau2
{
    public partial class GUI_XoaTheDocGia : Form
    {
        BUS_TheDocGia busTheDocGia = new BUS_TheDocGia();

        public GUI_XoaTheDocGia()
        {
            InitializeComponent();
        }

        private void TimTheDocGiaBtn_Click(object sender, EventArgs e)
        {
            using (GUI_TimTheDocGia timTheDocGiaForm = new GUI_TimTheDocGia())
            {
                timTheDocGiaForm.ShowDialog();
                if (timTheDocGiaForm.DialogResult == DialogResult.OK)
                {

                    string maDocGia = timTheDocGiaForm.MaDGReturn;
                    MaDocGiaTxt.Text = maDocGia;
                }
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa thẻ độc giả này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string maDocGia = MaDocGiaTxt.Text.Trim();
                if (string.IsNullOrEmpty(maDocGia))
                {
                    MessageBox.Show("Vui lòng nhập mã độc giả cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    if (busTheDocGia.XoaTheDocGia(maDocGia))
                    {
                        MessageBox.Show("Xóa thẻ độc giả thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thẻ độc giả thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();    
        }
    }
}
