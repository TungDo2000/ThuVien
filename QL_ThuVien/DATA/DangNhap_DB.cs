using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DATA.qlThuVienTableAdapters;
using System.Data;

namespace DATA
{
    public class DangNhap_DB
    {
        DOCGIATableAdapter dg = new DOCGIATableAdapter();
        public bool KTDangNhapDG(string maDG, string matKhau)
        {
            if (dg.timKiemDocGiaVaMatKhau(maDG, matKhau) > 0)
            {
                return true;
            }
            return false;
        }
        public DataTable timkiemDocGia(string mssv)
        {
            return dg.timKiemDocGia(mssv);
        }
        public DataTable LoadDocGia()
        {
            return dg.GetData();
        }
        THUTHUTableAdapter tt = new THUTHUTableAdapter();
        public bool KTDangNhapTT(string maTT, string matKhau)
        {
            if (tt.timKiemTTvaMatKhau(maTT, matKhau) > 0)
            {
                return true;
            }
            return false;
        }
        public DataTable timkiemTT(string mTT)
        {
            return tt.timKiemTheoMaTT(mTT);
        }
       
    }
}
