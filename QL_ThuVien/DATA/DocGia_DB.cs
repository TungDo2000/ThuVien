using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DATA.qlThuVienTableAdapters;
using System.Data;

namespace DATA
{
  public  class DocGia_DB
    {
      DOCGIATableAdapter dg = new DOCGIATableAdapter();
      public DataTable loaddgvDocGia()
      {
          return dg.GetData();
      }
      public bool kiemTraKCDocGia(string maDG)
      {
          if (dg.kTTonTaiDG(maDG) > 0)
          {
              return true;
          }
          return false;
      }
      public void LuuDG(string maDG, string tenDG, string matKhau, string GTinh, string hinh, DateTime? ngSinh, DateTime? NgayBD, DateTime? NgayKT, string SDT, string diaChi)
      {
          dg.Insert(maDG, matKhau, tenDG, GTinh, ngSinh, SDT, diaChi, NgayBD, NgayKT, 100000, hinh);
      }
      public void SuaDocGia(string maDG, string tenDG, string GTinh, string hinh, string ngSinh, string NgayBD, string NgayKT, string SDT, string diaChi)
      {
          dg.Sua(tenDG, GTinh, ngSinh, SDT, diaChi, NgayBD, NgayKT, hinh, maDG);
      }
      public void xoaDG(string maDG)
      {
          dg.XoaDG(maDG);
      }
    }
}
