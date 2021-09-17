using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DATA;

namespace BUSINESS
{
  public  class DocGia
    {
      DocGia_DB dg;
      public DocGia()
      {
          dg = new DocGia_DB();
      }
      public bool KiemTraKhoaChinhDG(string maDG)
      {
          if (dg.kiemTraKCDocGia(maDG))
          {
              return true;
          }
          else
          {
              return false;
          }
      }
      public DataTable loaddgvDocGia()
      {
          return dg.loaddgvDocGia();
      }
      public void LuuDG(string maDG, string tenDG, string matKhau, string GTinh, string hinh, DateTime? ngSinh, DateTime? NgayBD, DateTime? NgayKT, string SDT, string diaChi)
      {
          dg.LuuDG(maDG, tenDG, matKhau, GTinh, hinh, ngSinh, NgayBD, NgayKT, SDT, diaChi);
      }
      public void suaDG(string maDG, string tenDG, string GTinh, string hinh, string ngSinh, string NgayBD, string NgayKT, string SDT, string diaChi)
      {
          dg.SuaDocGia(maDG, tenDG, GTinh, hinh, ngSinh, NgayBD, NgayKT, SDT, diaChi);
      }
      public void xoaDG(string maDG)
      {
          dg.xoaDG(maDG);
      }
    }
}
