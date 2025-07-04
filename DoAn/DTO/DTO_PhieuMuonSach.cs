﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.DTO
{
    class DTO_PhieuMuonSach
    {
        string maPhieuMuonSach;
        public string MaPhieuMuonSach { get => maPhieuMuonSach; set => maPhieuMuonSach = value; }

        string maDocGia;
        public string MaDocGia { get => maDocGia; set => maDocGia = value; }

        public DateTime ngayMuon { get; set; }
        public string ngayMuonStr
        {
            get => ngayMuon.ToString("dd/MM/yyyy");
            set
            {
                if (DateTime.TryParseExact(value, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
                {
                    ngayMuon = parsedDate;
                }
                //ngaySinhNhanVien = DateTime.ParseExact(value, "dd/MM/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
            }
        }
        public DateTime HanTraSach { get; set; }

        public string hanTraSachStr
        {
            get => HanTraSach.ToString("dd/MM/yyyy");
            set
            {
                if (DateTime.TryParseExact(value, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
                {
                    HanTraSach = parsedDate;
                }
                //ngaySinhNhanVien = DateTime.ParseExact(value, "dd/MM/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
            }
        }

        public DTO_PhieuMuonSach(
            string maPhieuMuonSach=null,
            string maDocGia = null,
            string ngayMuonStr = null,
            string hanTraSachStr = null

        )
        {
            this.maPhieuMuonSach = maPhieuMuonSach;
            this.maDocGia = maDocGia;
            this.ngayMuonStr = ngayMuonStr;
            this.hanTraSachStr = hanTraSachStr;
        }
    }
}
