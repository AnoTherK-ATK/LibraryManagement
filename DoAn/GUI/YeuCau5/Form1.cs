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

namespace DoAn.GUI.YeuCau5
{
    public partial class Form1 : Form
    {
        BUS_Sach sach = new BUS_Sach();
        //YeuCau5 yc5 = new YeuCau5();
        public Form1()
        {
            InitializeComponent();
            loadDataGridView();
            dataGridView1.RowsAdded += addRow;
            dataGridView1.CellValidating += dataGridView1_CellValidating;
        }
        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            // Chỉ kiểm tra với cột "MaSach"
            if (dataGridView1.Columns[e.ColumnIndex].Name == "MaSach")
            {
                string newValue = e.FormattedValue?.ToString();
                if (string.IsNullOrEmpty(newValue))
                    return;

                // Kiểm tra trùng lặp ở các hàng khác
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (i == e.RowIndex) continue; // Bỏ qua hàng hiện tại
                    var cell = dataGridView1.Rows[i].Cells["MaSach"];
                    if (cell.Value != null && cell.Value.ToString() == newValue)
                    {
                        MessageBox.Show("Mã sách này đã được chọn ở hàng khác. Vui lòng chọn mã khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                        return;
                    }
                }
            }
        }

        public void loadDataGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Stt", "STT");
            dataGridView1.Rows[0].Cells["Stt"].Value = 1;
            var listSach = sach.LayDanhSachSach();
            var listMaSach = listSach
                .Where(s => s.TinhTrang == "Chưa mượn")
                .Select(s => s.MaSach)
                .ToList();
            var maSachColumn = new DataGridViewComboBoxColumn
            {
                HeaderText = "MÃ SÁCH",
                Name = "MaSach",
                DataSource = listMaSach
            };
            dataGridView1.Columns.Add(maSachColumn);
            dataGridView1.Columns.Add("TenSach", "TÊN SÁCH");
            dataGridView1.Columns.Add("TheLoai", "THỂ LOẠI");
            dataGridView1.Columns.Add("TacGia", "TÁC GIẢ");
            dataGridView1.Columns.Add("TinhTrang", "TÌNH TRẠNG");
            dataGridView1.Columns["Stt"].ReadOnly = true;

            // Chỉnh kích thước các cột
            dataGridView1.Columns["Stt"].Width = 50;
            dataGridView1.Columns["MaSach"].Width = 100;
            dataGridView1.Columns["TenSach"].Width = 250;
            dataGridView1.Columns["TheLoai"].Width = 100;
            dataGridView1.Columns["TacGia"].Width = 150;
            dataGridView1.Columns["TinhTrang"].Width = 125;

        }
        private void addRow(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int rowIndex = e.RowIndex;
            dataGridView1.Rows[rowIndex].Cells["Stt"].Value = rowIndex + 1;
        }
        
        private void updateRow(object sender, DataGridViewCellEventArgs e)
        {
            String maSach = null;
            try
            {
                maSach = dataGridView1.Rows[e.RowIndex].Cells["MaSach"].Value.ToString();
            }
            catch { }
            //MessageBox.Show(maSach);
            if (maSach != null)
            {
                //yc5.SubmitBtn.Enabled = true;
                var sachInfo = sach.LayThongTinSach(maSach);
                dataGridView1.Rows[e.RowIndex].Cells["TenSach"].Value = sachInfo.TenSach;
                dataGridView1.Rows[e.RowIndex].Cells["TheLoai"].Value = sachInfo.MaTheLoai;
                dataGridView1.Rows[e.RowIndex].Cells["TacGia"].Value = sachInfo.TacGia;
                dataGridView1.Rows[e.RowIndex].Cells["TinhTrang"].Value = sachInfo.TinhTrang;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
