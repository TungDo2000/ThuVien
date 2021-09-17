using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUSINESS;

namespace GUI
{
    public partial class FormMuonSach : Form
    {
        MuonSach ms;
        public static string Ma = string.Empty;
        public FormMuonSach()
        {
            InitializeComponent();
            ms = new MuonSach();
        }
        private void FormMuonSach_Load(object sender, EventArgs e)
        {
            cb_Sach.DataSource = ms.loadSach();
            cb_Sach.DisplayMember = "TenSach";
            cb_Sach.ValueMember = "MaSach";

            MSSV.DataSource = ms.loadDocGia();
            MSSV.DisplayMember = "TenDG";
            MSSV.ValueMember = "MSSV";

            MaTT.DataSource = ms.loadThuThu();
            MaTT.DisplayMember = "TenTT";
            MaTT.ValueMember = "MaTT";

            MaSach.DataSource = ms.loadSach();
            MaSach.DisplayMember = "TenSach";
            MaSach.ValueMember = "MaSach";

            txt_MaTT.Text = Ma;
            bn_LuuMuon.Enabled = bn_TaoMoi.Enabled =  bn_LuuCTMuon.Enabled = false;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_MaSV.TextLength > 0)
            {
                dataGridView1.DataSource = ms.loadThongTinMuonCu(txt_MaSV.Text);
            }
            else if (txt_MaPM.TextLength > 0)
            {
                dataGridView1.DataSource = ms.loadPhieuMuon(txt_MaPM.Text);
            }
        }

        private void bn_TaoMoi_Click(object sender, EventArgs e)
        {
            int? kq = ms.layMaPhieuMuon();
            if (kq == null)
            {
                kq = 0;
            }
            kq++;
            txt_MaPM.Text = "PM" + kq.ToString();
            bn_LuuMuon.Enabled = true;
            bn_TaoMoi.Enabled = false;
        }

        private void bn_Them_Click(object sender, EventArgs e)
        {
            txt_MaPM.Clear();
            txt_MaSV.Clear();
            txt_PhiCoc.Clear();
            txt_SoLuongMuon.Clear();
            txt_NgayMuon.Text = DateTime.Today.ToString("dd/MM/yyyy");
            txt_TongSLMuon.Text = "0";
            txt_MaPM.Enabled = txt_NgayMuon.Enabled = txt_TongSLMuon.Enabled = false;
            bn_Them.Enabled = false;
            bn_TaoMoi.Enabled = true;
        }

        private void bn_Luu_Click(object sender, EventArgs e)
        {
            DateTime? ngayMuon = DateTime.Parse(DateTime.Today.ToString("MM/dd/yyyy"));
            int? TongSLMuon =Convert.ToInt16(txt_TongSLMuon.Text);
            if (ms.laySoLuongDangMuon(txt_MaSV.Text) <= 2 || ms.laySoLuongDangMuon(txt_MaSV.Text) == null)
            {
                if (!ms.kiemTraPhieuMUon(txt_MaPM.Text))
                {
                    ms.LuuPhieuMuon(txt_MaPM.Text, ngayMuon, TongSLMuon, txt_MaSV.Text, txt_MaTT.Text);
                    MessageBox.Show("Thêm thành công");
                    dataGridView1.DataSource = ms.loadPhieuMuon(txt_MaPM.Text);
                    txt_PhiCoc.Text = "0";
                    txt_PhiCoc.Enabled = false;
                    bn_LuuCTMuon.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Vui lòng kiểm tra lại");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng bạn trả lại sách cũ");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txt_MaPM.TextLength > 0 && txt_SoLuongMuon.TextLength > 0 && txt_TinhTrang.TextLength > 0)
            {
                if (ms.laySoLuongDangMuon(txt_MaSV.Text) <= 2 || ms.laySoLuongDangMuon(txt_MaSV.Text) == null)
                {
                    if (DateTime.Parse(txt_NgayTra.Text) > DateTime.Parse(DateTime.Today.ToString("MM/dd/yyyy")))
                    {

                        DateTime? ngayTra = DateTime.Parse(txt_NgayTra.Text);
                        int? soLuongMuon = Convert.ToInt16(txt_SoLuongMuon.Text);
                        decimal? phiCoc = decimal.Parse(txt_PhiCoc.Text);
                        if (ms.soLuongTonSach(cb_Sach.SelectedValue.ToString()) > soLuongMuon)
                        {
                            ms.luuCTPhieuMuon(txt_MaPM.Text, cb_Sach.SelectedValue.ToString(), ngayTra, soLuongMuon, txt_TinhTrang.Text, phiCoc);
                            MessageBox.Show("Thêm thành công");
                            dataGridView2.DataSource = ms.loadCTPhieuMuon(txt_MaPM.Text);
                            dataGridView1.DataSource = ms.loadPhieuMuon(txt_MaPM.Text);
                        }
                        else
                        {
                            MessageBox.Show("Số lượng trong kho sách không tồn tại");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng kiểm tra ngày trả");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng bạn trả sách cũ");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.DataSource = ms.loadCTPhieuMuon(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            }
            catch
            {
            }
        }

        private void txt_MaSV_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_MaSV.TextLength > 0)
            {
                dataGridView1.DataSource = ms.loadThongTinMuonCu(txt_MaSV.Text);
            }
            else if (txt_MaPM.TextLength > 0)
            {
                dataGridView1.DataSource = ms.loadPhieuMuon(txt_MaPM.Text);
            }
        }

        private void txt_MaSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
