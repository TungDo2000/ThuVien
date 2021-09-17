using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DATA;

namespace BUSINESS
{
   public class DangKi
    {
       DangKi_DB dk;
       public DangKi()
       {
           dk = new DangKi_DB();
       }
       public bool kiemTraKCDocGia(string maDG)
       {
           if (dk.kiemTraKCDocGia(maDG))
           {
               return true;
           }
           return false;
       }
       public void LuuDG(string maDG, string tenDG, string matKhau, string GTinh, string hinh, DateTime? ngSinh, DateTime? NgayBD, DateTime? NgayKT, string SDT, string diaChi)
       {
           dk.LuuDG(maDG, tenDG, matKhau, GTinh, hinh, ngSinh, NgayBD, NgayKT, SDT, diaChi);
       }
       public bool kiemTraKCTT(string maTT)
       {
           if (dk.kiemTraKCTT(maTT))
           {
               return true;
           }
           return false;
       }
       public void LuuTT(string maTT, string tenTT, string matKhau, string GTinh, string hinh, DateTime? ngSinh, string SDT, string diaChi)
       {
           dk.LuuTT(maTT, tenTT, matKhau, GTinh, hinh, ngSinh, SDT, diaChi);
       }

    }
}
