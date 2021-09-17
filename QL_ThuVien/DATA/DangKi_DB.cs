using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DATA.qlThuVienTableAdapters;

namespace DATA
{
   public class DangKi_DB
    {
       DOCGIATableAdapter dg = new DOCGIATableAdapter();
       public bool kiemTraKCDocGia(string maDG)
       {
           if (dg.kTTonTaiDG(maDG) > 0)
           {
               return true;
           }
           return false;
       }
       public void LuuDG(string maDG, string tenDG, string matKhau, string GTinh, string hinh, DateTime? ngSinh, DateTime? NgayBD,DateTime? NgayKT, string SDT, string diaChi)
       {
           dg.Insert(maDG, tenDG, matKhau, GTinh, ngSinh, SDT, diaChi, NgayBD, NgayKT, 100000, hinh);
       }
       THUTHUTableAdapter tt = new THUTHUTableAdapter();
       public bool kiemTraKCTT(string maTT)
       {
           if (tt.kTraTonTaiTT(maTT) > 0)
           {
               return true;
           }
           return false;
       }
       public void LuuTT(string maTT, string tenTT, string matKhau, string GTinh, string hinh, DateTime? ngSinh, string SDT, string diaChi)
       {
           tt.Insert(maTT, tenTT, matKhau, GTinh, ngSinh, SDT, diaChi, hinh);
       }
    }
}
