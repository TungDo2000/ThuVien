using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DATA;
using System.Data;

namespace BUSINESS
{
  public  class MuonPhong
    {
        MuonPhong_DB mp;
        public TextBox maphong;
        public MuonPhong()
        {
            mp = new MuonPhong_DB();
        }
        public void selectPhong(FlowLayoutPanel f, ImageList l)
        {
            mp.maPhong = maphong;
            mp.selectPhong(f, l);
        }
        public DataTable loadkhuVuc(string maP)
        {
            return mp.loadKhuVuc(maP);
        }
        public DataTable loadPhong()
        {
            return mp.loadPhong();
        }
        public void luuMuonPhong(string MaP, string mssv, DateTime ngaymuon, int? tgSD, string maTT)
        {
            mp.LuuMuonPhong(MaP, mssv, ngaymuon, tgSD, maTT);
        }
        public DataTable loadKhuVuc(string maKhuVuc)
        {
            return mp.loadKhuVuc(maKhuVuc);
        }
        public DataTable timkiemMaKhuVuctheoP(string maP)
        {
            return mp.timkiemMaKhuVuctheoP(maP);
        }
        public DataTable LoadMuonPhong()
        {
            return mp.loadMuonPhong();
        }
        public void traPhong2(string maP, string mSSV, string ngayMuon)
        {
            mp.traPhong2(maP, mSSV, ngayMuon);
        }
        public DataTable loadDocGia()
        {
           return mp.loadDocGia();
        }
        public void traPhong(string maPhong)
        {
            mp.traPhong(maPhong);
        }

    }
}
