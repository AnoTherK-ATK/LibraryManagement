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

namespace DoAn.GUI.YeuCau5
{
    public partial class YeuCau5 : Form
    {
        BUS_PhieuMuonSach BUS_PhieuMuonSach = new BUS_PhieuMuonSach();
        BUS_ThongTinSachMuon BUS_ThongTinSachMuon = new BUS_ThongTinSachMuon();
        BUS_TheDocGia BUS_TheDocGia = new BUS_TheDocGia();
        BUS_ThamSo BUS_ThamSo = new BUS_ThamSo();


        public YeuCau5()
        {
            InitializeComponent();
        }
        private void YeuCau5_Load(object sender, EventArgs e)
        {
            HienThiMaPhieuMuonMoi();
            HienThiDanhSachTenDocGia();
            HienThiHanTraSach();
            HienThiSoSachMuonQuaHan();
        }
        private void HienThiMaPhieuMuonMoi()
        {
            List<DTO_PhieuMuonSach> listPhieuMuonSach = BUS_PhieuMuonSach.LayDanhSachPhieuMuonSach();
            if (listPhieuMuonSach.Count == 0)
            {
                MaPhieuMuonTxt.Text = "S0001";
            }
            else
            {
                string maPMCuoi = listPhieuMuonSach.Last().MaPhieuMuonSach;
                int soCuoi = int.Parse(maPMCuoi.Substring(2)) + 1;
                MaPhieuMuonTxt.Text = "S" + soCuoi.ToString("D4");
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
                if (MaPMDangMuonTheoTG.Count > sachMuonToiDaTheoThoiGianQuyDinh)
                {
                    this.BeginInvoke(new Action(() =>
                    {
                        MessageBox.Show($"Độc giả {TenDocGia} đang mượn {MaPMDangMuonTheoTG.Count} quyển sách trong {thoiGianMuonSachQuyDinh} ngày, vượt mức {sachMuonToiDaTheoThoiGianQuyDinh} quyển theo quy định!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }));
                }

            }
        }
    }
    

}
