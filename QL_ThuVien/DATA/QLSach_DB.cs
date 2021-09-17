using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DATA.qlThuVienTableAdapters;

namespace DATA
{
  public  class QLSach_DB
    {
        SACHTableAdapter s = new SACHTableAdapter();
        public DataTable loadSach()
        {
            return s.GetData();
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
        public int? layMaSavh()
        {
            return s.LayMaSach();
        }
        public bool KTKhoaChinh(string maSach)
        {
            if(s.timKiemMaSach(maSach) > 0)
            {
                return true;
            }
            return false;
        }
        public void ThemSach(string maSach, string tenSach, string LoaiSach, int? soLuong, string MoTa, string TacGia, string trangthai, string NXB, string Khuvuc, decimal? gia, string hinnhanh, string Ncc)
        {
            s.Insert(maSach, tenSach, LoaiSach, soLuong, MoTa, TacGia, trangthai, NXB, Khuvuc, gia, hinnhanh, Ncc);
        }
        public void SuaSach(string maSach, string tenSach, string LoaiSach, int? soLuong, string MoTa, string TacGia, string trangthai, string NXB, string Khuvuc, decimal? gia, string hinnhanh, string Ncc)
        {
            s.SuaSach(tenSach, LoaiSach, soLuong, MoTa, TacGia, trangthai, NXB, Khuvuc, gia, hinnhanh, Ncc, maSach);
        }
        public void xoaSach(string MaSach)
        {
            s.XoaSach(MaSach);
        }
    }
}
