using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DATA.qlThuVienTableAdapters;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace DATA
{
  public  class MuonPhong_DB
    {
      PHONGTableAdapter p = new PHONGTableAdapter();
      DataColumn[] key = new DataColumn[1];
      Button btnBan;
      public TextBox maPhong;
      public void selectPhong(FlowLayoutPanel f, ImageList l)
      {
          try
          {
              DataTable phong = p.GetData();
              foreach (DataRow rd in phong.Rows)
              {
                  Button btn = new Button { Text = rd["TenPhong"].ToString(), ForeColor = Color.Black, BackColor = Color.White, ImageList = l, ImageIndex = 0, TextImageRelation = TextImageRelation.ImageAboveText };
                  btn.Width = 100; btn.Height = 60;
                  if (rd["TinhTrang"].ToString() == "Đã Có Người")
                  {
                      btn.BackColor = Color.Red;
                  }
                  btn.Click += btn_clickPhong;
                  f.Controls.Add(btn);
              }
          }
          catch
          {
          }
      }
      public void btn_clickPhong(object sender, EventArgs e)
      {
          try
          {
              //string MaP = "";  
              DataTable phong = p.GetData();
              foreach (DataRow rd in phong.Rows)
              {
                  btnBan = sender as Button;
                  if (btnBan.BackColor == Color.White && btnBan.Text == rd["TenPhong"].ToString())
                  {
                      btnBan.BackColor = Color.Yellow;
                      //Form.MaPhong = rd["MaPhong"].ToString();
                       maPhong.Text =  rd["MaPhong"].ToString();
                  }
                  else if (btnBan.BackColor == Color.Yellow && btnBan.Text == rd["TenPhong"].ToString())
                  {
                      btnBan.BackColor = Color.White;
                      //frm_MuonPhong.MaPhong = "";
                      maPhong.Text = "";
                  }
                  else if (btnBan.Text == rd["TenPhong"].ToString() && rd["TrangThai"].ToString() == "Đã Có Người")
                  {
                  }
              }
          }
          catch
          {
          }
      }
      MUONPHONGTableAdapter mp = new MUONPHONGTableAdapter();
      public void LuuMuonPhong(string MaP, string mssv, DateTime ngaymuon, int? tgSD, string maTT)
      {
          mp.Insert(MaP, mssv, ngaymuon, tgSD, "Đang mượn", maTT);
      }
      public DataTable loadPhong()
      {
          return p.GetData();
      }
      KHUVUCTableAdapter kv = new KHUVUCTableAdapter();
      public DataTable loadKhuVuc(string maKhuVuc)
      {
          return kv.loadMaKhuVuc(maKhuVuc);
      }
      public DataTable timkiemMaKhuVuctheoP(string maP)
      {
          return p.maKhuVucTheoP(maP);
      }
      MUONPHONGTableAdapter pm = new MUONPHONGTableAdapter();
       public DataTable loadMuonPhong()
        {
          return  pm.loadMuonPhong("Đang mượn");
        }
       public void traPhong2(string maP, string mSSV, string ngayMuon)
       {
           pm.traPhong2("Đã trả", maP, mSSV, ngayMuon); 
       }
       DOCGIATableAdapter dg = new DOCGIATableAdapter();
       public DataTable loadDocGia()
       {
         return  dg.GetData();
       }
       public void traPhong(string maP)
       {
           p.TraPhong("Còn trống", maP);
       }
    }
}
