using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DATA.qlThuVienTableAdapters;
using System.Data;

namespace DATA
{
   public class TraSach_DB
    {
       THONGTINMUONCUTableAdapter tt = new THONGTINMUONCUTableAdapter();
       public DataTable loadThongTinMuonCu(string maSV)
       {
           return tt.GetData(maSV);
       }
       PHIEUTRASACHTableAdapter pt = new PHIEUTRASACHTableAdapter();
       public int? LayPhieuTra()
       {
           return pt.LayPhieuTra();
       }
       public void LuuPhieuTra(string maT, DateTime? NgayTra, int? tongLuongTra, decimal? tongTien)
       {
           pt.Insert(maT, NgayTra, tongLuongTra, tongTien);
       }
       public DataTable loadPhieuTra(string maPT)
       {
           return pt.loadPhieuTra(maPT);
       }
       CTPHIEUTRATableAdapter ctpt = new CTPHIEUTRATableAdapter();
       public DataTable loadCTPhieuTra(string maPT)
       {
           return ctpt.loadCTPhieuTra(maPT);
       }
       public void LuuCTPhieuTra(string maT, string MaPM, string MaSach, string TinhTrang, int? SoLuongTra, decimal? CPDenBU)
       {
           ctpt.Insert(maT, MaPM, MaSach, TinhTrang, SoLuongTra, CPDenBU);
       }
       SACHTableAdapter s = new SACHTableAdapter();
       public DataTable loadSach()
       {
           return s.GetData();
       }
    }
}
