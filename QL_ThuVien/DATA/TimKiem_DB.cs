using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DATA.qlThuVienTableAdapters;
using System.Data;

namespace DATA
{
    public class TimKiem_DB
    {
      SACHTableAdapter s = new SACHTableAdapter();
      public DataTable loadSACH(string tenSach)
      {
          return s.TimKiemTenSach(tenSach);
      }
      public DataTable loadALLSACH()
      {
          return s.GetData();
      }
        SACHTHEOTENTACGIATableAdapter stg = new SACHTHEOTENTACGIATableAdapter();
        public DataTable loadSACHTacGia(string tenTacGia)
        {
           return stg.GetData(tenTacGia);
        }
        SACHTHEOTHELOAITableAdapter stl = new SACHTHEOTHELOAITableAdapter();
        public DataTable loadSACHLoai(string tenLoai)
        {
            return stl.GetData(tenLoai);
        }
        THELOAITableAdapter tl = new THELOAITableAdapter();
        public DataTable loadLOAISACH()
        {
            return tl.GetData();
        }
        TACGIATableAdapter tg = new TACGIATableAdapter();
        public DataTable loadTACGIA()
        {
            return tg.GetData();
        }
        KHUVUCTableAdapter kv = new KHUVUCTableAdapter();
        public DataTable loadKHUVUC()
        {
            return kv.GetData();
        }
        NXBTableAdapter nxb = new NXBTableAdapter();
        public DataTable loadNXB()
        {
            return nxb.GetData();
        }
        NHACCTableAdapter nc = new NHACCTableAdapter();
        public DataTable loadNhaCC()
        {
            return nc.GetData();
        }

    }
}
