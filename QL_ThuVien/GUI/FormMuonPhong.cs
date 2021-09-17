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
    public partial class FormMuonPhong : Form
    {
        public static string MaTT = string.Empty;
        MuonPhong mp;
        public FormMuonPhong()
        {
            InitializeComponent();
            mp = new MuonPhong();
        }

        private void MuonPhong_Load(object sender, EventArgs e)
        {

            mp.maphong = textBox1;
            txt_maTT.Text = MaTT;
            flowLayoutPanel1.Controls.Clear();
            MaP.DataSource = mp.loadPhong();
            MaP.DisplayMember = "TenPhong";
            MaP.ValueMember = "MaPhong";
            MSSV.DataSource = mp.loadDocGia();
            MSSV.DisplayMember = "TenDG";
            MSSV.ValueMember = "MSSV";
            mp.selectPhong(flowLayoutPanel1, imageList1);
            dataGridView1.DataSource = mp.LoadMuonPhong();
            comboBox1.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            comboBox1.DataSource = mp.timkiemMaKhuVuctheoP(textBox1.Text);
            comboBox1.DisplayMember = "TenPhong";
            comboBox1.ValueMember = "MaKhuVuc";

            cbox_KhuVuc.DataSource = mp.loadkhuVuc(comboBox1.SelectedValue.ToString());
            cbox_KhuVuc.DisplayMember = "TenKhuVuc";
            cbox_KhuVuc.ValueMember = "MaKhuVuc";
            if (textBox1.Text == "")
            {
                cbox_KhuVuc.Text = "";
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            //comboBox1.DataSource = mp.timkiemMaKhuVuctheoP(textBox1.Text);
            //comboBox1.DisplayMember = "TenPhong";
            //comboBox1.ValueMember = "MaKhuVuc";

            //cbox_KhuVuc.DataSource = mp.loadkhuVuc(comboBox1.SelectedValue.ToString());
            //cbox_KhuVuc.DisplayMember = "TenKhuVuc";
            //cbox_KhuVuc.ValueMember = "MaKhuVuc";
            //if (textBox1.Text == "")
            //{
            //    cbox_KhuVuc.Text = "";
            //}
        }

        private void btdangky_Click(object sender, EventArgs e)
        {
            try
            {
                int? tgsd = Convert.ToInt16(txt_TgSuDung.Text);
                DateTime ngayMuon = DateTime.Parse(txt_NgayMuon.Text);
                mp.luuMuonPhong(textBox1.Text, txt_MaSV.Text, ngayMuon, tgsd, txt_maTT.Text);
                MessageBox.Show("Mượn phòng thành công (^-^)");
                MuonPhong_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại (^-^)");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                     mp.traPhong(textBox1.Text);
                     mp.traPhong2(textBox1.Text, txt_MaSV.Text, txt_NgayMuon.Text);
                    MessageBox.Show("Trả phòng thành công (^-^)");
                    MuonPhong_Load(sender, e);
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
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_MaSV.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_NgayMuon.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txt_TgSuDung.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
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

        private void txt_TgSuDung_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
