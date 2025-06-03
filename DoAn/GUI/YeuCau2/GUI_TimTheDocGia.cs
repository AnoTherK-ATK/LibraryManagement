using DoAn.BUS;
using DoAn.DTO;
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
    public partial class GUI_TimTheDocGia : Form
    {
        private BUS_LoaiDocGia BUS_LoaiDocGia = new BUS_LoaiDocGia();
        private BUS_ThamSo BUS_ThamSo = new BUS_ThamSo();
        private BUS_TheDocGia BUS_TheDocGia = new BUS_TheDocGia();
        private BUS_NhanVien BUS_NhanVien = new BUS_NhanVien();
        private bool ngaySinhSelected = false;
        private bool ngayLapTheSelected = false; 
        private bool ngayHetHanSelected = false;

        public GUI_TimTheDocGia()
        {
            InitializeComponent();
            // Chỉnh font cho ô dữ liệu
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 12);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;


        }

        private void ResetDate()
        {
            ngaySinhSelected = false;
            ngayLapTheSelected = false;
            ngayHetHanSelected = false;

            NgaySinhSelector.Format = DateTimePickerFormat.Custom;
            NgaySinhSelector.CustomFormat = " ";

            NgayLapTheSelector.Format = DateTimePickerFormat.Custom;
            NgayLapTheSelector.CustomFormat = " ";

            NgayHetHanSelector.Format = DateTimePickerFormat.Custom;
            NgayHetHanSelector.CustomFormat = " ";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                Clipboard.SetText(row.Cells["MaDocGia"].Value.ToString());
                MaDGReturn = row.Cells["MaDocGia"].Value.ToString();
                MessageBox.Show("Đã sao chép mã độc giả vào bộ nhớ tạm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }

        }
        
       
        private void HienThiLoaiDocGia()
        {
            List<DTO_LoaiDocGia> listLoaiDocGia = BUS_LoaiDocGia.LayDanhSachLoaiDocGia();
            LoaiDocGiaCombo.DataSource = listLoaiDocGia;
            LoaiDocGiaCombo.DisplayMember = "TenLoaiDocGia";
            LoaiDocGiaCombo.ValueMember = "MaLoaiDocGia";

        }


        private void HienThiDanhSachMaDocGia()
        {
            List<string> listMaDocGia = BUS_TheDocGia.LayTatCaMaDocGia();
            var sortedList = listMaDocGia
                .OrderBy(ma => int.Parse(ma.Substring(3))) 
                .ToList();
            MaDocGiaCombo.DataSource = sortedList;
        }

        private void HienThiDanhSachMaNhanVien()
        {
            List<string> listMaNhanVien = BUS_NhanVien.LayTatCaMaNhanVien();
            var sortedList = listMaNhanVien
                .OrderBy(ma => int.Parse(ma.Substring(2)))
                .ToList();
            MaNhanVienCombo.DataSource = sortedList;
        }

        private void GUI_TimTheDocGia_Load(object sender, EventArgs e)
        {
            HienThiLoaiDocGia();
            SetUpForm();
            ResetDate();
            HienThiDanhSachMaDocGia();
            HienThiDanhSachMaNhanVien();
            ResetForm();


        }




        private void SetUpForm()
        {

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add("MaDocGia", "Mã Độc Giả");
            dataGridView1.Columns.Add("HoTenDocGia", "Họ và Tên");
            dataGridView1.Columns.Add("DiaChiDocGia", "Địa Chỉ");
            dataGridView1.Columns.Add("NgaySinhDocGia", "Ngày Sinh");
            dataGridView1.Columns.Add("EmailDocGia", "Email");
            dataGridView1.Columns.Add("NgayLapThe", "Ngày Lập Thẻ");
            dataGridView1.Columns.Add("NgayHetHan", "Ngày Hết Hạn");
            dataGridView1.Columns.Add("MaLoaiDocGia", "Mã Loại Độc Giả");
            dataGridView1.Columns.Add("MaNhanVien", "Mã Nhân Viên");
            dataGridView1.Columns["MaDocGia"].DataPropertyName = "MaDocGia";
            dataGridView1.Columns["HoTenDocGia"].DataPropertyName = "HoTenDocGia";
            dataGridView1.Columns["DiaChiDocGia"].DataPropertyName = "DiaChiDocGia";
            dataGridView1.Columns["NgaySinhDocGia"].DataPropertyName = "NgaySinhDocGiaStr";
            dataGridView1.Columns["EmailDocGia"].DataPropertyName = "EmailDocGia";
            dataGridView1.Columns["NgayLapThe"].DataPropertyName = "NgayLapTheStr";
            dataGridView1.Columns["NgayHetHan"].DataPropertyName = "NgayHetHanStr";
            dataGridView1.Columns["MaLoaiDocGia"].DataPropertyName = "MaLoaiDocGia";
            dataGridView1.Columns["MaNhanVien"].DataPropertyName = "MaNhanVien";
            dataGridView1.Columns["MaDocGia"].Width = 80;
            dataGridView1.Columns["HoTenDocGia"].Width = 200;
            dataGridView1.Columns["DiaChiDocGia"].Width = 400;
            dataGridView1.Columns["NgaySinhDocGia"].Width = 100;
            dataGridView1.Columns["EmailDocGia"].Width = 200;
            dataGridView1.Columns["NgayLapThe"].Width = 100;
            dataGridView1.Columns["NgayHetHan"].Width = 100;
            dataGridView1.Columns["MaLoaiDocGia"].Width = 80;
            dataGridView1.Columns["MaNhanVien"].Width = 80;



            dataGridView1.DataSource = BUS_TheDocGia.LayDanhSachTheDocGia();
        }

        public string MaDGReturn { get;  set; }

        private void TimTheDocGiaBtn_Click(object sender, EventArgs e)
        {
                


            string maDocGia = MaDocGiaCombo.SelectedValue?.ToString() ?? "";
            string tenDocGia = HoTenDocGiaTxt.Text.Trim();
            string emailDocGia = EmailTxt.Text.Trim();
            string diaChiDocGia = DiaChiTxt.Text.Trim();
            string ngaySinhDocGia = (NgaySinhSelector.CustomFormat == " ") ? "" : NgaySinhSelector.Value.ToString("dd/MM/yyyy");
            string ngayLapThe = (NgayLapTheSelector.CustomFormat == " ")? "": NgayLapTheSelector.Value.ToString("dd/MM/yyyy");
            string ngayHetHan = (NgayHetHanSelector.CustomFormat == " ") ? "" : NgayHetHanSelector.Value.ToString("dd/MM/yyyy");

            string maLoaiDocGia = LoaiDocGiaCombo.SelectedValue?.ToString() ?? "";
            string maNhanVien = MaNhanVienCombo.SelectedValue?.ToString() ?? "";
            string tenNhanVien = TenNhanVienTxt.Text.Trim();

            List<DTO_TheDocGia> filteredList = BUS_TheDocGia.TimKiemTheDocGia(
                maDocGia,
                tenDocGia,
                diaChiDocGia,
                ngaySinhDocGia,
                emailDocGia,
                ngayLapThe,
                ngayHetHan,
                maLoaiDocGia,
                maNhanVien,
                tenNhanVien
            );

            dataGridView1.DataSource = filteredList;
        }

        private void NgaySinhSelector_ValueChanged(object sender, EventArgs e)
        {
            if (!ngaySinhSelected)
            {
                NgaySinhSelector.Format = DateTimePickerFormat.Custom;

                NgaySinhSelector.CustomFormat = "dd/MM/yyyy";
                ngaySinhSelected = true;
            }
        }

        private void NgayLapTheSelector_ValueChanged(object sender, EventArgs e)
        {
            if (!ngayLapTheSelected)
            {
                NgayLapTheSelector.Format = DateTimePickerFormat.Custom;
                NgayLapTheSelector.CustomFormat = "dd/MM/yyyy";
                ngayLapTheSelected = true;
            }
        }

        private void NgayHetHanSelector_ValueChanged(object sender, EventArgs e)
        {
            if (!ngayHetHanSelected)
            {
                NgayHetHanSelector.Format = DateTimePickerFormat.Custom;
                NgayHetHanSelector.CustomFormat = "dd/MM/yyyy";
                ngayHetHanSelected = true;
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetForm();
            ResetDate();


        }

       private void ResetForm()
        {
            MaDocGiaCombo.SelectedIndex = -1;
            HoTenDocGiaTxt.Text = "";
            DiaChiTxt.Text = "";
            EmailTxt.Text = "";
            MaNhanVienCombo.SelectedIndex = -1;
            TenNhanVienTxt.Text = "";
            LoaiDocGiaCombo.SelectedIndex = -1;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
