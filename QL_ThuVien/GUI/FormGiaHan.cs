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
    public partial class FormGiaHan : Form
    {
        GiaHan gh;
        public FormGiaHan()
        {
            InitializeComponent();
            gh = new GiaHan();
        }

        private void FormGiaHan_Load(object sender, EventArgs e)
        {
            Sach.DataSource = gh.loadSach();
            Sach.DisplayMember = "TenSach";
            Sach.ValueMember = "MaSach";

            TenSach.DataSource = gh.loadSach();
            TenSach.DisplayMember = "TenSach";
            TenSach.ValueMember = "MaSach";
        }

        private void txt_MaSV_KeyUp(object sender, KeyEventArgs e)
        {
            Sach.DataSource = gh.loadSach();
            Sach.DisplayMember = "TenSach";
            Sach.ValueMember = "MaSach";
            dataGridView1.DataSource = gh.loadThongTinCu(txt_MaSV.Text);
        }

        private void btdangky_Click(object sender, EventArgs e)
        {
            int? kq = gh.layMaPhieuGH();
            if (kq == null)
            {
                kq = 0;
            }
            kq++;
            txt_MaGH.Text = "GH" + kq.ToString();
            txt_TongSLGH.Text = "0";
            txt_TongSLGH.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime? ngayGH = DateTime.Parse(txt_NgayGH.Text);
            int? togSLGH = Convert.ToInt16(txt_TongSLGH.Text);
            try
            {
                gh.LuuPhieuGH(txt_MaGH.Text, ngayGH, togSLGH);
                MessageBox.Show("Thêm gia hạn thành công ");
                dataGridView2.DataSource = gh.loadPhieuGiaHan(txt_MaGH.Text);
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại");
            }
        }

        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    txt_MaPM.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //    txt_MaSach.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //}
            //catch
            //{
            //}
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView3.DataSource = gh.loadCTPhieuGiaHan(dataGridView2.CurrentRow.Cells[0].Value.ToString());
            }
            catch
            {
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime? ctngayGH = DateTime.Parse(txt_CTNgayGH.Text);
            int? slGH = Convert.ToInt16(txt_SLGH.Text);
            try
            { 
                gh.LuuCTPhieuGH(txt_MaGH.Text, ctngayGH, slGH, txt_MaPM.Text, txt_MaSach.Text);
                MessageBox.Show("Gia hạn thành công");
                dataGridView2.DataSource = gh.loadPhieuGiaHan(txt_MaGH.Text);
                dataGridView1.DataSource = gh.loadThongTinCu(txt_MaSV.Text);
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txt_MaPM.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_MaSach.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_SLGH.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }
            catch
            {
            }
        }

        private void txt_SLGH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
