using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DATA.qlThuVienTableAdapters;
using System.Data;

namespace DATA
{
  public  class GiaHan_DB
    {
      THONGTINMUONCUTableAdapter tt = new THONGTINMUONCUTableAdapter();
      public DataTable loadThongTinMuonCu(string maSV)
      {
          return tt.GetData(maSV);
      }
      SACHTableAdapter s = new SACHTableAdapter();
      public DataTable loadSach()
      {
          return s.GetData();
      }
      PHIEUGIAHANTableAdapter gh = new PHIEUGIAHANTableAdapter();
      public int? LayPhieuGiaHan()
      {
          return gh.layMaPhieuGH();
      }
      public void LuuGiaHan(string maPGH, DateTime? tgGH, int? togSL)
      {
          gh.Insert(maPGH, tgGH, togSL);
      }
      CTPHIEUGIAHANTableAdapter ctgh = new CTPHIEUGIAHANTableAdapter();
      public DataTable loadCTPhieuGiaHan(string maGH)
      {
          return ctgh.loadCTPhieuGiaHan(maGH);
      }
      public DataTable loadPhieuGiaHan(string maGH)
      {
          return gh.loadPhieuGiaHan(maGH);
      }
      public void LuuCTGiaHan(string maGH, DateTime? NgayGH, int? SoLuongGH, string MaPM, string MaSach)
      {
          ctgh.Insert(maGH, NgayGH, SoLuongGH, MaPM, MaSach);
      }

    }
}
