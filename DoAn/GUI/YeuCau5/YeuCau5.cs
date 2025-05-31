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
using DoAn.GUI.YeuCau5;

namespace DoAn.GUI.YeuCau5
{
    public partial class YeuCau5 : Form
    {
        BUS_PhieuMuonSach BUS_PhieuMuonSach = new BUS_PhieuMuonSach();
        BUS_ThongTinSachMuon BUS_ThongTinSachMuon = new BUS_ThongTinSachMuon();
        BUS_TheDocGia BUS_TheDocGia = new BUS_TheDocGia();
        BUS_ThamSo BUS_ThamSo = new BUS_ThamSo();
        Form1 form1 = new Form1();
        
        public YeuCau5()
        {
            InitializeComponent();
        }
        private void YeuCau5_Load(object sender, EventArgs e)
        {
            HienThiMaPhieuMuonMoi();
            HienThiDanhSachTenDocGia();
            HienThiHanTraSach();
            NgayMuonTxt.Value = DateTime.Today;
            form1.TopLevel = false;
            form1.FormBorderStyle = FormBorderStyle.None;
            form1.Dock = DockStyle.Fill;
            panel1.Controls.Add(form1);
            form1.Show();
            HienThiSoSachMuonQuaHan();
        }
        private void HienThiMaPhieuMuonMoi()
        {
            List<DTO_PhieuMuonSach> listPhieuMuonSach = BUS_PhieuMuonSach.LayDanhSachPhieuMuonSach();
            if (listPhieuMuonSach.Count == 0)
            {
                MaPhieuMuonTxt.Text = "PM0001";
            }
            else
            {
                string maPMCuoi = listPhieuMuonSach.Last().MaPhieuMuonSach;
                //MessageBox.Show(maPMCuoi);
                int soCuoi = int.Parse(maPMCuoi.Substring(2)) + 1;
                MaPhieuMuonTxt.Text = "PM" + soCuoi.ToString("D4");
            }
        }
        private void HienThiDanhSachTenDocGia()
        {
            TenDocGiaCombo.SelectedIndexChanged -= TenDocGiaCombo_SelectedIndexChanged;
            List<string> listTenDocGia = BUS_TheDocGia.LayTatCaTenDocGia();
            var sortedList = listTenDocGia
                .OrderBy(ten => ten)
                .ToList();
            TenDocGiaCombo.DataSource = null;
            TenDocGiaCombo.DataSource = sortedList;
            TenDocGiaCombo.SelectedIndex = -1;
            TenDocGiaCombo.SelectedIndexChanged += TenDocGiaCombo_SelectedIndexChanged;
        }

        private void HienThiHanTraSach()
        {
            int hanMuonSachToiDa = BUS_ThamSo.LayHanMuonSachToiDa();
            DateTime ngayMuonSach = DateTime.Today;
            string hanTraSach = ngayMuonSach.AddDays(hanMuonSachToiDa).ToString("dd/MM/yyyy");
            HanTraSachTxt.Text = hanTraSach;

        }

        private void HienThiSoSachMuonQuaHan()
        {
            //string maDocGia = BUS_TheDocGia.LayMaDocGiaTheoTenDocGia(TenDocGiaCombo.Text);
            ////int soSachMuonQuaHan = BUS_PhieuMuonSach.DemSoSachDangMuonQuaHan(TenDocGiaCombo.Text);
            ////DateTime ngayMuonSach = DateTime.Today;
            ////string hanTraSach = ngayMuonSach.AddDays(hanMuonSachToiDa).ToString("dd/MM/yyyy");
            //SoSachQuaHanTxt.Text = maDocGia;

        }

        private void TenDocGiaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            string TenDocGia = TenDocGiaCombo.Text;
            string maDocGia = BUS_TheDocGia.LayMaDocGiaTheoTenDocGia(TenDocGia);
            List<string> MaPMTheoDocGia = BUS_PhieuMuonSach.LayTatCaMaPMTheoDocGia(maDocGia);
            List<string> MaPMDangMuon = BUS_ThongTinSachMuon.LayMaPMDangMuon(MaPMTheoDocGia);

            SoSachQuaHanTxt.Text = MaPMDangMuon.Count.ToString();
            if (MaPMDangMuon.Count > 0)
            {
                form1.dataGridView1.Enabled = false;

                this.BeginInvoke(new Action(() =>
                {
                    MessageBox.Show($"Độc giả {TenDocGia} đang có {MaPMDangMuon.Count} cuốn sách mượn quá hạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }));
            }
            else
            {
                int thoiGianMuonSachQuyDinh = BUS_ThamSo.LayThoiGianMuonSachTheoQuyDinh();
                int sachMuonToiDaTheoThoiGianQuyDinh = BUS_ThamSo.LaySachMuonToiDaTheoThoiGianQuyDinh();
                List<string> MaPMTheoThoiGianMuonSach = BUS_PhieuMuonSach.LayTatCaMaPMTheoThoiGianMuonSach(maDocGia, thoiGianMuonSachQuyDinh);
                List<string> MaPMDangMuonTheoTG = BUS_ThongTinSachMuon.LayMaPMDangMuon(MaPMTheoThoiGianMuonSach);
                
                SachMuonTheoQDTxt.Text = MaPMDangMuonTheoTG.Count.ToString();
                if (MaPMDangMuonTheoTG.Count >= sachMuonToiDaTheoThoiGianQuyDinh)
                {
                    form1.dataGridView1.Enabled = false;
                    this.BeginInvoke(new Action(() =>
                    {
                        MessageBox.Show($"Độc giả {TenDocGia} đang mượn {MaPMDangMuonTheoTG.Count} quyển sách trong {thoiGianMuonSachQuyDinh} ngày, Tối đa chỉ {sachMuonToiDaTheoThoiGianQuyDinh} quyển theo quy định!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }));
                }
                else
                {
                    form1.dataGridView1.Enabled = true;
                }
                


            }
        }

        private void ClearContent()
        {
            HienThiMaPhieuMuonMoi();
            TenDocGiaCombo.SelectedIndex = -1;
            HienThiHanTraSach();
            SoSachQuaHanTxt.Clear();
            SachMuonTheoQDTxt.Clear();
            NgayMuonTxt.Value = DateTime.Now;
            form1.dataGridView1.Rows.Clear();
            form1.dataGridView1.Enabled = false;
        }
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            string maDocGia = BUS_TheDocGia.LayMaDocGiaTheoTenDocGia(TenDocGiaCombo.Text);
            int thoiGianMuonSachQuyDinh = BUS_ThamSo.LayThoiGianMuonSachTheoQuyDinh();
            int sachMuonToiDaTheoThoiGianQuyDinh = BUS_ThamSo.LaySachMuonToiDaTheoThoiGianQuyDinh();
            List<string> MaPMTheoThoiGianMuonSach = BUS_PhieuMuonSach.LayTatCaMaPMTheoThoiGianMuonSach(maDocGia, thoiGianMuonSachQuyDinh);
            List<string> MaPMDangMuonTheoTG = BUS_ThongTinSachMuon.LayMaPMDangMuon(MaPMTheoThoiGianMuonSach);
            DTO_PhieuMuonSach DTO_PhieuMuonSach = new DTO_PhieuMuonSach(
                MaPhieuMuonTxt.Text,
                maDocGia,
                NgayMuonTxt.Text.ToString(),
                HanTraSachTxt.Text.ToString()
            );

            
            try
            {   
                if(form1.dataGridView1.Rows.Cast<DataGridViewRow>().Count(row => !row.IsNewRow) == 0)
                {
                    MessageBox.Show("Vui lòng thêm sách vào phiếu mượn trước khi lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if((MaPMDangMuonTheoTG.Count + form1.dataGridView1.Rows.Cast<DataGridViewRow>().Count(row => !row.IsNewRow)) > sachMuonToiDaTheoThoiGianQuyDinh){
                    MessageBox.Show($"bạn chỉ có thể mượn thêm {sachMuonToiDaTheoThoiGianQuyDinh - MaPMDangMuonTheoTG.Count} Quyển, Vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    int currentCount = form1.dataGridView1.Rows.Cast<DataGridViewRow>().Count(row => !row.IsNewRow);
                    int allowedToAdd = sachMuonToiDaTheoThoiGianQuyDinh - MaPMDangMuonTheoTG.Count;
                    int rowsToRemove = currentCount - allowedToAdd;

                    // Remove rows from the end, skipping the new row
                    for (int i = form1.dataGridView1.Rows.Count - 1; i >= 0 && rowsToRemove > 0; i--)
                    {
                        if (!form1.dataGridView1.Rows[i].IsNewRow)
                        {
                            form1.dataGridView1.Rows.RemoveAt(i);
                            rowsToRemove--;
                        }
                    }
                    return;
                } else {
                        if (BUS_PhieuMuonSach.ThemPhieuMuonSach(DTO_PhieuMuonSach))
                        {   
                            bool toend = false;
                            foreach (DataGridViewRow row in form1.dataGridView1.Rows)
                                {
                                    //if (row.IsNewRow) continue; // Bỏ qua dòng trống cuối cùng

                                    var cellValue = row.Cells["MaSach"].Value;
                                    if (cellValue != null)
                                    {
                                        string maSach = cellValue.ToString();
                                        string trangThai = "Đang mượn";
                                        DTO_ThongTinSachMuon DTO_ThongTinSachMuon = new DTO_ThongTinSachMuon(MaPhieuMuonTxt.Text, maSach, trangThai);
                                        if (BUS_ThongTinSachMuon.ThemPhieuMuonSach(DTO_ThongTinSachMuon))
                                        {
                                            BUS_Sach BUS_Sach = new BUS_Sach();
                                        if (BUS_Sach.CapNhatTinhTrangSach(maSach))
                                        {
                                            continue;
                                        }
                                        ;
                                        continue;
                                        }
                                        else
                                        {
                                            break;
                                        }
                                    }
                                    toend = true;
                                }
                        if (toend)
                        {
                            MessageBox.Show("Thêm phiếu mượn sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            ClearContent();
                        }

                    } else
                        {
                            MessageBox.Show("Thêm phiếu mượn sách thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi Thêm phiếu mượn sách: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    

}
