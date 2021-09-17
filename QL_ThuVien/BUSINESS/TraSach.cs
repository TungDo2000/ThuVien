using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DATA;
using System.Data;

namespace BUSINESS
{
   public class TraSach
    {
        TraSach_DB ts;
        public TraSach()
        {
            ts = new TraSach_DB();
        }
        public DataTable loadThongTinCu(string s)
        {
            return ts.loadThongTinMuonCu(s);
        }
        public int? LayMaPhieuTra()
        {
            return ts.LayPhieuTra();
        }
        public void LuuPhieuTra(string maT, DateTime? NgayTra, int? tongLuongTra, decimal? tongTien)
        {
            ts.LuuPhieuTra(maT, NgayTra, tongLuongTra, tongTien);
        }
        public DataTable LoadPhieuTra(string maPT)
        {
            return ts.loadPhieuTra(maPT);
        }
        public DataTable LoadCTPhieuTra(string maPT)
        {
            return ts.loadCTPhieuTra(maPT);
        }
        public void LuuCTPhieuTra(string maT, string MaPM, string MaSach, string TinhTrang, int? SoLuongTra, decimal? CPDenBU)
        {
            ts.LuuCTPhieuTra(maT, MaPM, MaSach, TinhTrang, SoLuongTra, CPDenBU);
        }
        public DataTable loadSach()
        {
            return ts.loadSach();
        }
    }
}
