﻿using DoAn.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.BUS
{
    internal class BUS_ThamSo
    {

        DAL_ThamSo DAL_ThamSo = new DAL_ThamSo();
        internal int LayTuoiToiThieu()
        {
            return DAL_ThamSo.LayTuoiToiThieu();
        }
        internal int LayTuoiToiDa()
        {
            return DAL_ThamSo.LayTuoiToiDa();
        }

        internal int LayTienPhatTraTreMoiNgay()
        {
            return DAL_ThamSo.LayTienPhatTraTreMoiNgay();
        }

        internal int LayGiaTriThe()
        {
            return DAL_ThamSo.LayGiaTriThe();
        }

        internal int LayThoiGianNhapSachToiDa()
        {
            return DAL_ThamSo.LayThoiGianNhapSachToiDa();
        }

        internal int LayHanMuonSachToiDa()
        {
            return DAL_ThamSo.LayHanMuonSachToiDa();
        }

        internal int LayThoiGianMuonSachTheoQuyDinh()
        {
            return DAL_ThamSo.LayThoiGianMuonSachTheoQuyDinh();
        }

        internal int LaySachMuonToiDaTheoThoiGianQuyDinh()
        {
            return DAL_ThamSo.LaySachMuonToiDaTheoThoiGianQuyDinh();
        }

        internal bool CapNhatThamSo(int tuoiToiThieu, int tuoiToiDa, int tienPhatTraTreMoiNgay, int giaTriThe, int thoiGianNhapSachToiDa, int hanMuonSachToiDa, int thoiGianMuonSachTheoQuyDinh, int sachMuonToiDaTheoThoiGianQuyDinh)
        {
            return DAL_ThamSo.CapNhatThamSo(tuoiToiThieu, tuoiToiDa, tienPhatTraTreMoiNgay, giaTriThe, thoiGianNhapSachToiDa, hanMuonSachToiDa, thoiGianMuonSachTheoQuyDinh, sachMuonToiDaTheoThoiGianQuyDinh);
        }
    }
}
