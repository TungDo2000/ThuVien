using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DATA;
using System.Data;

namespace BUSINESS
{
  public  class XemThongTin
    {
        XemThongTin_DB tt;
        public XemThongTin()
        {
            tt = new XemThongTin_DB();
        }

        public DataTable loadXemThongTin(string maSV)
        {
            return tt.loadXemThongTinMuon(maSV);
        }
        public DataTable loadXemThongTinTra(string maSV)
        {
            return tt.loadXemThongTinTra(maSV);
        }
        public DataTable loadXemThongTinDangMuonSach(string maSV)
        {
            return tt.loadXemThongTinDangMuon(maSV);
        }
    }
}
