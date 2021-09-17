using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DATA;
using System.Data;

namespace BUSINESS
{
     public  class QLSach
    {
      QLSach_DB s = new QLSach_DB();
      public DataTable loadSach()
      {
         return s.loadSach();
      }
      public DataTable loadLOAISACH()
      {
          return s.loadLOAISACH();
      }
      public DataTable loadTACGIA()
      {
          return s.loadTACGIA();
      }
      public DataTable loadKHUVUC()
      {
          return s.loadKHUVUC();
      }
      public DataTable loadNXB()
      {
          return s.loadNXB();
      }
      public DataTable loadNhaCC()
      {
          return s.loadNhaCC();
      }
      public int? layMaSach()
      {
          return s.layMaSavh();
      }
      public void ThemSach(string maSach, string tenSach, string LoaiSach, int? soLuong, string MoTa, string TacGia, string trangthai, string NXB, string Khuvuc, decimal? gia, string hinnhanh, string Ncc)
      {
          s.ThemSach(maSach, tenSach, LoaiSach, soLuong, MoTa, TacGia, trangthai, NXB, Khuvuc, gia, hinnhanh, Ncc);
      }
      public void SuaSach(string maSach, string tenSach, string LoaiSach, int? soLuong, string MoTa, string TacGia, string trangthai, string NXB, string Khuvuc, decimal? gia, string hinnhanh, string Ncc)
      {
          s.SuaSach(maSach, tenSach, LoaiSach, soLuong, MoTa, TacGia, trangthai, NXB, Khuvuc, gia, hinnhanh, Ncc);
      }
      public void XoaSach(string maSach)
      {
          s.xoaSach(maSach);
      }
      public bool KTKhoaChinh(string maSach)
      {
          if (s.KTKhoaChinh(maSach))
          {
              return true;
          }
          return false;
      }

    }
}
