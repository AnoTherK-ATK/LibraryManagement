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
    public partial class YeuCau5: Form
    {
        BUS_PhieuMuonSach BUS_PhieuMuonSach = new BUS_PhieuMuonSach();
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
            List<string> listTenDocGia = BUS_TheDocGia.LayTatCaTenDocGia();
            var sortedList = listTenDocGia
                .OrderBy(ten => ten)
                .ToList();
            TenDocGiaCombo.DataSource = sortedList;
        }

        private void HienThiHanTraSach()
        {
            int hanMuonSachToiDa = BUS_ThamSo.LayHanMuonSachToiDa();
            DateTime ngayMuonSach = DateTime.Today;
            string hanTraSach = ngayMuonSach.AddDays(hanMuonSachToiDa).ToString("dd/MM/yyyy");
            HanTraSachTxt.Text = hanTraSach;

        }


    }

}
