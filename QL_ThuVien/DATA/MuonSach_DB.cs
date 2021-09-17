using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DATA.qlThuVienTableAdapters;
using System.Data;

namespace DATA
{

    public class MuonSach_DB
    {
        SACHTableAdapter s = new SACHTableAdapter();
        public DataTable loadSach()
        {
            return s.GetData();
        }
        DOCGIATableAdapter dg = new DOCGIATableAdapter();
        public DataTable loadDocGia()
        {
            return dg.GetData();
        }
        THUTHUTableAdapter tt = new THUTHUTableAdapter();
        public DataTable loadThuThu()
        {
            return tt.GetData();
        }
        PHIEUMUONTableAdapter pm = new PHIEUMUONTableAdapter();
        public int? LayMaPhieuMuon()
        {
            return pm.taoMaoPhieuMuon();
        }
        public void LuuPhieuMuon(string maPM, DateTime? NgayMuon, int? tongLuongMuon, string Mssv, string MaTT)
        {
            pm.Insert(maPM, NgayMuon, tongLuongMuon, Mssv, MaTT, 0);
        }
        public bool kiemTraPhieuMUon(string MaPM)
        {
            if (pm.KiemTraMaPM(MaPM) > 0)
            {
                return true;
            }
            return false;
        }
        public int? LaySoLuongDangMuon(string MSSV)
        {
            return pm.SoLuongSVDangMuon(MSSV);
        }
        public DataTable loadThongTinMuonCu(string mssv)
        {
            return pm.loadThongTinMuonCu(mssv);
        }
        CTPHIEUMUONTableAdapter ctm = new CTPHIEUMUONTableAdapter();
        public void LuuCTPhieuMuon(string maPM, string maSach, DateTime? ngayTra, int? SoLuongMuon, string tinhTrang, decimal? phicoc)
        {
            try
            {
                ctm.Insert(maPM, maSach, ngayTra, SoLuongMuon, tinhTrang, phicoc);
            }
            catch
            {
               
            }
        }
        public DataTable loadPhieuMuon(string maPM)
        {
            return pm.loadPhieuMuon(maPM);
        }
        public DataTable loadCTPhieuMuon(string maPM)
        {
            return ctm.loadCTPhieuMuon(maPM);
        }
        public int? soLuongTonSach(string maSach)
        {
            return s.SoLuongTonSach(maSach);
        }
       
    }
}
