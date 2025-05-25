using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn.BUS;
using DoAn.DTO;

namespace DoAn.GUI.YeuCau2
{


    public partial class GUI_CapNhatTheDocGia : Form
    {


        private BUS_LoaiDocGia BUS_LoaiDocGia = new BUS_LoaiDocGia();
        private BUS_TheDocGia BUS_TheDocGia = new BUS_TheDocGia();
        private BUS_NhanVien BUS_NhanVien = new BUS_NhanVien();
        private BUS_LoaiBoPhan BUS_LoaiBoPhan = new BUS_LoaiBoPhan();

        private DateTime ngayLapThe;

        public GUI_CapNhatTheDocGia()
        {
            InitializeComponent();
        }
        private void HienThiThongTinNhanVien()
        {
            if (MaNhanVienCombo.SelectedItem == null)
                return;
            string maNhanVien = MaNhanVienCombo.SelectedItem.ToString();
            DTO_NhanVien nhanVien = BUS_NhanVien.LayThongTinNhanVien(maNhanVien);
            if (nhanVien != null)
            {
                string TenBoPhan = BUS_LoaiBoPhan.LayTenBoPhan(nhanVien.MaBoPhanNhanVien);
                bool QuyenLapThe = BUS_LoaiBoPhan.LayQuyenLapThe(nhanVien.MaBoPhanNhanVien);
                string QuyenLapTheStr = QuyenLapThe ? "Có" : "Không";
                TenNhanVienTxt.Text = nhanVien.TenNhanVien;
                TenBoPhanTxt.Text = TenBoPhan;
                QuyenLapTheTxt.Text = QuyenLapTheStr;
            }

        }
     

        private void HienThiThongTinDocGia()
        {
           string maDocGia = MaDocGiaTxt.Text.Trim();
            DTO_TheDocGia theDocGia = BUS_TheDocGia.LayThongTinTheDocGia(maDocGia);
            if (theDocGia != null)
            {
                HoTenDocGiaTxt.Text = theDocGia.HoTenDocGia;
                NgaySinhSelector.Value = theDocGia.NgaySinhDocGia;
                NgayHetHanSelector.Value = theDocGia.NgayHetHan;
                LoaiDocGiaCombo.SelectedValue = theDocGia.MaLoaiDocGia;
                EmailTxt.Text = theDocGia.EmailDocGia;
                DiaChiTxt.Text = theDocGia.DiaChiDocGia;
                MaNhanVienCombo.SelectedItem = theDocGia.MaNhanVien;

                ngayLapThe = theDocGia.NgayLapThe;

                HoTenDocGiaTxt.ReadOnly = false;
                NgaySinhSelector.Enabled = true;
                LoaiDocGiaCombo.Enabled = true;
                EmailTxt.ReadOnly = false;
                DiaChiTxt.ReadOnly = false;
                NgayHetHanSelector.Enabled = true;
                MaNhanVienCombo.Enabled = true;

           
                if (MaNhanVienCombo != null)
                
                    HienThiThongTinNhanVien();
                    
                else
                    
                        MessageBox.Show("Không tìm thấy thông tin nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
               

            }
           
        }
        void ResetForm()
        {
            MaDocGiaTxt.Text = "";
            HoTenDocGiaTxt.Text = "";
            NgaySinhSelector.Value = DateTime.Now;
            EmailTxt.Text = "";
            DiaChiTxt.Text = "";
            NgayHetHanSelector.Value = DateTime.Now;
            LoaiDocGiaCombo.SelectedIndex = -1;
            MaNhanVienCombo.SelectedIndex = -1;
            TenNhanVienTxt.Text = "";
            TenBoPhanTxt.Text = "";
            QuyenLapTheTxt.Text = "";


            HoTenDocGiaTxt.ReadOnly = true;
            NgaySinhSelector.Enabled = false;
            LoaiDocGiaCombo.Enabled = false;
            EmailTxt.ReadOnly = true;
            DiaChiTxt.ReadOnly = true;
            NgayHetHanSelector.Enabled = false;
            MaNhanVienCombo.Enabled = false;

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CapNhatTheDocGia_Load(object sender, EventArgs e)
        {
            HienThiMaNhanVien();
           HienThiLoaiDocGia();
      

        }

        private void NgaySinhSelector_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void HienThiMaNhanVien()
        {
            List<string> listMaNhanVien = BUS_NhanVien.LayTatCaMaNhanVien();
            var sortedList = listMaNhanVien
                .OrderBy(ma => int.Parse(ma.Substring(2))) 
                .ToList();
            MaNhanVienCombo.DataSource = sortedList;
        }
        private void HienThiLoaiDocGia()
        {
            List<DTO_LoaiDocGia> listLoaiDocGia = BUS_LoaiDocGia.LayDanhSachLoaiDocGia();
            LoaiDocGiaCombo.DataSource = listLoaiDocGia;
            LoaiDocGiaCombo.DisplayMember = "TenLoaiDocGia";
            LoaiDocGiaCombo.ValueMember = "MaLoaiDocGia";
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
            HienThiThongTinDocGia();



        }

        private void ngayLapTheSelector_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            string maDocGia = MaDocGiaTxt.Text.Trim();
            string hoTenDocGia = HoTenDocGiaTxt.Text.Trim();
            DateTime ngaySinhDocGia = NgaySinhSelector.Value;
            string emailDocGia = EmailTxt.Text.Trim();
            string diaChiDocGia = DiaChiTxt.Text.Trim();
            DateTime ngayHetHan = NgayHetHanSelector.Value;
            string maLoaiDocGia = LoaiDocGiaCombo.SelectedValue?.ToString();
            string maNhanVien = MaNhanVienCombo.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(hoTenDocGia) || string.IsNullOrEmpty(emailDocGia) || string.IsNullOrEmpty(diaChiDocGia) || string.IsNullOrEmpty(maLoaiDocGia) || string.IsNullOrEmpty(maNhanVien))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DateTime ngayHienHanh = DateTime.Today;
            int tuoi = ngayHienHanh.Year - NgaySinhSelector.Value.Year;
            if (tuoi<=18 && tuoi >= 55)
            {
                MessageBox.Show("Độc giả phải từ 18 đến 55 tuổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DTO_NhanVien nhanVien = BUS_NhanVien.LayThongTinNhanVien(maNhanVien);
            bool QuyenLapThe = BUS_LoaiBoPhan.LayQuyenLapThe(nhanVien.MaBoPhanNhanVien);
            if (QuyenLapThe == false)
            {
                MessageBox.Show("Nhân viên hiện tại không có quyền lập thẻ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            

            if (BUS_TheDocGia.CapNhatTheDocGia(new DTO_TheDocGia(maDocGia, hoTenDocGia, diaChiDocGia, ngaySinhDocGia.ToString("dd/MM/yyyy"), emailDocGia, ngayLapThe.ToString("dd/MM/yyyy"), ngayHetHan.ToString("dd/MM/yyyy"), maLoaiDocGia, maNhanVien))
                )
            {
                MessageBox.Show("Cập nhật thẻ độc giả thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                MaDocGiaTxt.Text = "";
                HoTenDocGiaTxt.Text = "";
                NgaySinhSelector.Value = DateTime.Now;
                EmailTxt.Text = "";
                DiaChiTxt.Text = "";
                NgayHetHanSelector.Value = DateTime.Now;
                LoaiDocGiaCombo.SelectedIndex = -1;

                ResetForm();
            }
            else
            {
                MessageBox.Show("Cập nhật thẻ độc giả thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void MaNhanVienCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiThongTinNhanVien();
        }
    }
}
