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
    public partial class FormTraSach : Form
    {
        TraSach ts;
        public FormTraSach()
        {
            InitializeComponent();
            ts = new TraSach();
        }

        private void FormTraSach_Load(object sender, EventArgs e)
        {
            Sach.DataSource = ts.loadSach();
            Sach.DisplayMember = "TenSach";
            Sach.ValueMember = "MaSach";

            MaSach.DataSource = ts.loadSach();
            MaSach.DisplayMember = "TenSach";
            MaSach.ValueMember = "MaSach";
        }

        private void txt_MaSV_KeyUp(object sender, KeyEventArgs e)
        {
            Sach.DataSource = ts.loadSach();
            Sach.DisplayMember = "TenSach";
            Sach.ValueMember = "MaSach";
            dataGridView1.DataSource = ts.loadThongTinCu(txt_MaSV.Text);
        }

        private void btdangky_Click(object sender, EventArgs e)
        {
            int? kq = ts.LayMaPhieuTra();
            if (kq == null)
            {
                kq = 0;
            }
            kq++;
            txt_MaPT.Text = "PT" + kq.ToString();
            txt_TienBoiThuong.Text = "0";
            txt_MaPT.Enabled = false;
            txt_TongSLTra.Text = "0";
            txt_TongSLTra.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime? ngayTra = DateTime.Parse(txt_NgayTra.Text);
            int? tongSLTra = Convert.ToInt16(txt_TongSLTra.Text);
          
            decimal? tienBoiThuong = decimal.Parse(txt_TienBoiThuong.Text);
            try
            {
                  if(ngayTra <= DateTime.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString()))
                   {
                      ts.LuuPhieuTra(txt_MaPT.Text, ngayTra, tongSLTra, tienBoiThuong);
                        MessageBox.Show("Thêm thành công (^-^)");
                        dataGridView2.DataSource = ts.LoadPhieuTra(txt_MaPT.Text);
                        txt_DenBu.Text = "0";
                  }
                else
                  {
                      MessageBox.Show("Mượn quá ngày");
                      ts.LuuPhieuTra(txt_MaPT.Text, ngayTra, tongSLTra, 100000);
                      MessageBox.Show("Thêm thành công (^-^)");
                      dataGridView2.DataSource = ts.LoadPhieuTra(txt_MaPT.Text);
                      txt_DenBu.Text = "0";
                  }
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại (^-^)");
            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView3.DataSource = ts.LoadCTPhieuTra(dataGridView2.CurrentRow.Cells[0].Value.ToString());
            }
            catch
            {
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int? ctSoLuongTra = Convert.ToInt16(txt_SLTra.Text);
            decimal? tiendenBu = decimal.Parse(txt_DenBu.Text);
            try
            {
                if (Convert.ToInt16(txt_SLTra.Text) <= Convert.ToInt16(dataGridView1.CurrentRow.Cells[4].Value.ToString()))
                {

                    ts.LuuCTPhieuTra(txt_MaPT.Text, dataGridView1.CurrentRow.Cells[0].Value.ToString(), dataGridView1.CurrentRow.Cells[1].Value.ToString(), txt_TinhTrang.Text, ctSoLuongTra, tiendenBu);
                    MessageBox.Show("Trả sách thành công (^-^)");
                    dataGridView2.DataSource = ts.LoadPhieuTra(txt_MaPT.Text);
                    dataGridView1.DataSource = ts.loadThongTinCu(txt_MaSV.Text);
                }
                else
                {
                    MessageBox.Show("Vui lòng kiểm lại số lượng (^-^)");
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại (^-^)");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txt_MaPM.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_MaSach.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                //txt_SLTra.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }
            catch
            {
            }
        }

        private void txt_MaSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

    }
}
