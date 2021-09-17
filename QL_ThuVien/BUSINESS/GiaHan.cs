using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DATA;
using System.Data;

namespace BUSINESS
{
  public  class GiaHan
    {
        GiaHan_DB gh;
        public GiaHan()
        {
            gh = new GiaHan_DB();

        }
        public DataTable loadSach()
        {
            return gh.loadSach();
        }
        public DataTable loadThongTinCu(string s)
        {
            return gh.loadThongTinMuonCu(s);
        }
        public int? layMaPhieuGH()
        {
            return gh.LayPhieuGiaHan();
        }
        public void LuuPhieuGH(string maGH, DateTime? NgayGH, int? tongLuongGH)
        {
            gh.LuuGiaHan(maGH, NgayGH, tongLuongGH);
               
        }
        public DataTable loadPhieuGiaHan(string maGH)
        {
            return gh.loadPhieuGiaHan(maGH);
        }
        public DataTable loadCTPhieuGiaHan(string maGH)
        {
            return gh.loadCTPhieuGiaHan(maGH);
        }
        public void LuuCTPhieuGH(string maGH, DateTime? NgayGH, int? SoLuongGH, string MaPM, string MaSach)
        {
            gh.LuuCTGiaHan(maGH, NgayGH, SoLuongGH, MaPM, MaSach);
            
        }
    }
}
