using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DATA;

namespace BUSINESS
{
  public  class TimKiem
    {
        TimKiem_DB tk;
        public TimKiem()
        {
            tk = new TimKiem_DB();
        }
        public DataTable loadSach(string tenSach)
        {
            return tk.loadSACH(tenSach);
        }
        public DataTable loadLOAISACH()
        {
            return tk.loadLOAISACH();
        }
        public DataTable loadTACGIA()
        {
            return tk.loadTACGIA();
        }
        public DataTable loadKHUVUC()
        {
            return tk.loadKHUVUC();
        }
        public DataTable loadNXB()
        {
            return tk.loadNXB();
        }
        public DataTable loadNhaCC()
        {
            return tk.loadNhaCC();
        }
        public DataTable loadSachTacGia(string tenTacGia)
        {
            return tk.loadSACHTacGia(tenTacGia);
        }
        public DataTable loadSachLoai(string tenLoai)
        {
            return tk.loadSACHLoai(tenLoai);
        }
        public DataTable loadAllSach()
        {
            return tk.loadALLSACH();
        }
    }
}
