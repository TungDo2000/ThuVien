using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DATA;
using System.Data;

namespace BUSINESS
{
   public class MuonSach
    {
       MuonSach_DB ms;
       public MuonSach()
       {
           ms = new MuonSach_DB();
       }
       public DataTable loadThongTinMuonCu(string maSV)
       {
           return ms.loadThongTinMuonCu(maSV);
       }
       public int? layMaPhieuMuon()
       {
           return ms.LayMaPhieuMuon();
       }
       public void LuuPhieuMuon(string maPM, DateTime? NgayMuon, int? tongLuongMuon, string Mssv, string MaTT)
       {
           ms.LuuPhieuMuon(maPM, NgayMuon, tongLuongMuon, Mssv, MaTT);
       }
       public DataTable loadSach()
       {
           return ms.loadSach();
       }
       //public DataTable loadTimSach(string maSach)
       //{
       //    return ms.loadTimSach(maSach);
       //}
       public void luuCTPhieuMuon(string maPM, string maSach, DateTime? ngayTra, int? SoLuongMuon, string tinhTrang, decimal? phicoc)
       {
           ms.LuuCTPhieuMuon(maPM, maSach, ngayTra, SoLuongMuon, tinhTrang, phicoc);
       }
       public DataTable loadPhieuMuon(string maPM)
       {
           return ms.loadPhieuMuon(maPM);
       }
       public DataTable loadCTPhieuMuon(string maPM)
       {
           return ms.loadCTPhieuMuon(maPM);
       }
       public DataTable loadThuThu()
       {
           return ms.loadThuThu();
       }
       public DataTable loadDocGia()
       {
           return ms.loadDocGia();
       }
       public int? laySoLuongDangMuon(string mssv)
       {
           return ms.LaySoLuongDangMuon(mssv);

       }
       public bool kiemTraPhieuMUon(string MaPM)
       {
           if (ms.kiemTraPhieuMUon(MaPM))
           {
               return true;
           }
           return false;
       }
       public int? soLuongTonSach(string maSach)
       {
           return ms.soLuongTonSach(maSach);
       }
    }
}
