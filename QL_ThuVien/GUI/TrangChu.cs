using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace GUI
{
    public partial class TrangChu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static string ten = string.Empty;
        public static string Ma = string.Empty;
        public TrangChu()
        {
            InitializeComponent();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ten))
            {
                String[] s = ten.Split('-');
                if (s[0] == "Độc Giả ")
                {
                    txt_HoTen.Text = "Xin chào: " + s[1];
                    bn_xemthongtinmuon.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    bn_DangKi.Enabled = false;
                    rpb_DocGia.Visible = rpb_MuonTra.Visible = rpb_Sach.Visible = rpb_ThongKe.Visible = rpg_NhaCC.Visible = false;
                    bn_DangNhap.Enabled = false;
                    panel2.Visible = false;
                }
                else
                {
                    txt_HoTen.Text = "Xin chào: " + s[1];
                    bn_xemthongtinmuon.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    bn_DangNhap.Enabled = false;
                    panel2.Visible = false;
                }
            }
            else
            {
                txt_HoTen.Text = "Xin chào: ";
                bn_DoiMatKhau.Enabled = false;
                bn_DangKi.Enabled = false;
                bn_DangXuat.Enabled = false;
                
                rpb_DocGia.Visible = rpb_MuonTra.Visible = rpb_Sach.Visible = rpb_ThongKe.Visible = rpg_NhaCC.Visible = false;
                panel2.Visible = true;            
                bn_xemthongtinmuon.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
               
               

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn có chắc muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private Form KiemTraTon(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }

        private void bn_DangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
            FormDangNhap f = new FormDangNhap();
            f.ShowDialog();
        }

        private void bn_DangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ten = string.Empty;
            Form1_Load(sender, e);
            bn_DangNhap.Enabled = true;
        }

        private void bn_QLSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form dn = this.KiemTraTon(typeof(FormQLSach));
            if (dn != null)
            {
                dn.Activate();
            }
            else
            {
                FormQLSach f = new FormQLSach();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void bn_QlMuon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form dn = this.KiemTraTon(typeof(FormMuonSach));
            if (dn != null)
            {
                dn.Activate();
            }
            else
            {
                FormMuonSach f = new FormMuonSach();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void bn_DangKi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form dn = this.KiemTraTon(typeof(FormDangKi));
            if (dn != null)
            {
                dn.Activate();
            }
            else
            {
                FormDangKi f = new FormDangKi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void bn_xemthongtinmuon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form dn = this.KiemTraTon(typeof(FormXemThongTin));
            if (dn != null)
            {
                dn.Activate();
            }
            else
            {
                FormXemThongTin f = new FormXemThongTin();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void bn_QLDocGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form dn = this.KiemTraTon(typeof(FormDocGia));
            if (dn != null)
            {
                dn.Activate();
            }
            else
            {
                FormDocGia f = new FormDocGia();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void bn_QLGiahan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form dn = this.KiemTraTon(typeof(FormGiaHan));
            if (dn != null)
            {
                dn.Activate();
            }
            else
            {
                FormGiaHan f = new FormGiaHan();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void bn_QLTraSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form dn = this.KiemTraTon(typeof(FormTraSach));
            if (dn != null)
            {
                dn.Activate();
            }
            else
            {
                FormTraSach f = new FormTraSach();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void bn_QLmuonPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form dn = this.KiemTraTon(typeof(FormMuonPhong));
            if (dn != null)
            {
                dn.Activate();
            }
            else
            {
                FormMuonPhong f = new FormMuonPhong();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void bn_TimKiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panel2.Visible = false;
            Form dn = this.KiemTraTon(typeof(FormTimKiem));
            if (dn != null)
            {
                dn.Activate();
            }
            else
            {
                FormTimKiem f = new FormTimKiem();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void bn_TrangChu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
