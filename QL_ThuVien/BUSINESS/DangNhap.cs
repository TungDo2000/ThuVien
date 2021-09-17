using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DATA;
using System.Data;

namespace BUSINESS
{
    public class DangNhap
    {
        DangNhap_DB dn = new DangNhap_DB();
        public bool KTDangNhapDG(string MSSV, string MatKhau)
        {
            if (dn.KTDangNhapDG(MSSV, MatKhau))
            {
                return true;
            }
            return false;
        }
        public DataTable timKiemTenDG(string mssv)
        {
            return dn.timkiemDocGia(mssv);
        }
        public DataTable loadDocGia()
        {
            return dn.LoadDocGia();
        }
        public bool KTDangNhapTT(string maTT, string MatKhau)
        {
            if (dn.KTDangNhapTT(maTT, MatKhau))
            {
                return true;
            }
            return false;
        }
        public DataTable timKiemTenTT(string mTT)
        {
            return dn.timkiemTT(mTT);
        }
    }
}
