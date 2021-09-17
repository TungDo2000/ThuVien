using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DATA.qlThuVienTableAdapters;
using System.Data;

namespace DATA
{
   public class XemThongTin_DB
    {
       XemThongTinMuonTableAdapter ttm = new XemThongTinMuonTableAdapter();
       public DataTable loadXemThongTinMuon(string maSV)
       {
           return ttm.GetData(maSV);
       }
       XemThongTinTraTableAdapter ttt = new XemThongTinTraTableAdapter();
       public DataTable loadXemThongTinTra(string maSV)
       {
           return ttt.GetData(maSV);
       }
       XemThongTinDangMuonTableAdapter ttdm = new XemThongTinDangMuonTableAdapter();
       public DataTable loadXemThongTinDangMuon(string maSV)
       {
           return ttdm.GetData(maSV);
       }
    }
}
