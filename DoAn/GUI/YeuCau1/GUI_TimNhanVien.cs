using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn.BUS;
using DoAn.DTO;

namespace DoAn.GUI.YeuCau1
{
    public partial class GUI_TimNhanVien: Form
    {

        private BUS_LoaiBangCap BUS_LoaiBangCap = new BUS_LoaiBangCap();
        private BUS_LoaiBoPhan BUS_LoaiBoPhan = new BUS_LoaiBoPhan();
        private BUS_LoaiChucVu BUS_LoaiChucVu = new BUS_LoaiChucVu();
        private BUS_NhanVien BUS_NhanVien = new BUS_NhanVien();

        private List<DTO_NhanVien> filteredList = new List<DTO_NhanVien>();

        public GUI_TimNhanVien()
        {
            InitializeComponent();
        }

        private void SetupForm()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add("MaNhanVien", "Mã Nhân viên");
            dataGridView1.Columns.Add("TenNhanVien", "Họ và tên");
            dataGridView1.Columns.Add("DiaChiNhanVien", "Địa chỉ");
            dataGridView1.Columns.Add("NgaySinhNhanVien", "Ngày sinh");
            dataGridView1.Columns.Add("SoDienThoaiNhanVien", "Số điện thoại");
            dataGridView1.Columns.Add("MaBangCapNhanVien", "Bằng cấp");
            dataGridView1.Columns.Add("MaBoPhanNhanVien", "Bộ phận");
            dataGridView1.Columns.Add("MaChucVuNhanVien", "Chức vụ");

            dataGridView1.Columns["MaNhanVien"].DataPropertyName = "MaNhanVien";
            dataGridView1.Columns["TenNhanVien"].DataPropertyName = "TenNhanVien";
            dataGridView1.Columns["DiaChiNhanVien"].DataPropertyName = "DiaChiNhanVien";
            dataGridView1.Columns["NgaySinhNhanVien"].DataPropertyName = "ngaySinhNhanVienStr";
            dataGridView1.Columns["SoDienThoaiNhanVien"].DataPropertyName = "SoDienThoaiNhanVien";
            dataGridView1.Columns["MaBangCapNhanVien"].DataPropertyName = "MaBangCapNhanVien";
            dataGridView1.Columns["MaBoPhanNhanVien"].DataPropertyName = "MaBoPhanNhanVien";
            dataGridView1.Columns["MaChucVuNhanVien"].DataPropertyName = "MaChucVuNhanVien";

            dataGridView1.Columns["MaNhanVien"].Width = 100;
            dataGridView1.Columns["TenNhanVien"].Width = 220;
            dataGridView1.Columns["DiaChiNhanVien"].Width = 200;
            dataGridView1.Columns["NgaySinhNhanVien"].Width = 100;
            dataGridView1.Columns["SoDienThoaiNhanVien"].Width = 120;
            dataGridView1.Columns["MaBangCapNhanVien"].Width = 95;
            dataGridView1.Columns["MaBoPhanNhanVien"].Width = 120;
            dataGridView1.Columns["MaChucVuNhanVien"].Width = 120;

            dataGridView1.DataSource = filteredList;
        }

        private void HienThiDanhSachLoaiBangCap()
        {
            List<DTO_LoaiBangCap> listLoaiBangCap = BUS_LoaiBangCap.LayDanhSachLoaiBangCap();
            BangCapCombo.DataSource = listLoaiBangCap;
            BangCapCombo.DisplayMember = "TenLoaiBangCap";
            BangCapCombo.ValueMember = "MaLoaiBangCap";
        }

        private void HienThiDanhSachLoaiBoPhan()
        {
            List<DTO_LoaiBoPhan> listLoaiBoPhan = BUS_LoaiBoPhan.LayDanhSachLoaiBoPhan();
            BoPhanCombo.DataSource = listLoaiBoPhan;
            BoPhanCombo.DisplayMember = "TenLoaiBoPhan";
            BoPhanCombo.ValueMember = "MaLoaiBoPhan";
        }

        private void HienThiDanhSachLoaiChucVu()
        {
            List<DTO_LoaiChucVu> listLoaiChucVu = BUS_LoaiChucVu.LayDanhSachLoaiChucVu();
            ChucVuCombo.DataSource = listLoaiChucVu;
            ChucVuCombo.DisplayMember = "TenLoaiChucVu";
            ChucVuCombo.ValueMember = "MaLoaiChucVu";
        }

        private void GUI_TimNhanVien_Load(object sender, EventArgs e)
        {
            SetupForm();
            HienThiDanhSachLoaiBangCap();
            HienThiDanhSachLoaiBoPhan();
            HienThiDanhSachLoaiChucVu();
            BangCapCombo.SelectedIndex = -1;
            BoPhanCombo.SelectedIndex = -1;
            ChucVuCombo.SelectedIndex = -1;
        }

        private void TimNhanVienBtn_Click(object sender, EventArgs e)
        {
            string maNV = MaNhanVienTxt.Text.Trim();
            string tenNV = TenNhanVienTxt.Text.Trim();
            string sdtNV = SDTTxt.Text.Trim();
            string bangCapNV = BangCapCombo.SelectedValue?.ToString();
            string boPhanNV = BoPhanCombo.SelectedValue?.ToString();
            string chucVuNV = ChucVuCombo.SelectedValue?.ToString();

            filteredList = BUS_NhanVien.TimKiemNhanVien(maNV, tenNV, sdtNV, bangCapNV, boPhanNV, chucVuNV);
            foreach (var item in filteredList)
            {
                item.MaChucVuNhanVien = BUS_LoaiChucVu.LayTenChucVu(item.MaChucVuNhanVien);
                item.MaBangCapNhanVien = BUS_LoaiBangCap.LayTenBangCap(item.MaBangCapNhanVien);
                item.MaBoPhanNhanVien = BUS_LoaiBoPhan.LayTenBoPhan(item.MaBoPhanNhanVien);
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = filteredList;
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            MaNhanVienTxt.Text = "";
            TenNhanVienTxt.Text = "";
            SDTTxt.Text = "";
            BangCapCombo.SelectedIndex = -1;
            BoPhanCombo.SelectedIndex = -1;
            ChucVuCombo.SelectedIndex = -1;
        }

        public string MaNVReturn { get; set; }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                MaNVReturn = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                Clipboard.SetText(MaNVReturn);
                MessageBox.Show("Đã sao chép mã nhân viên vào bộ nhớ tạm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                if (this.Modal)
                {
                    this.Close();
                }
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
