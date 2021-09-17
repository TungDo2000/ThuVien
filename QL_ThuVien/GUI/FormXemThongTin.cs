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
    public partial class FormXemThongTin : Form
    {
        XemThongTin tt;
        public static string tenSV = string.Empty;
        public static string MaSV = string.Empty;
        public FormXemThongTin()
        {
            InitializeComponent();
            tt = new XemThongTin();
        }

        private void txt_MaSV_KeyUp(object sender, KeyEventArgs e)
        {
            dataGridView1.DataSource = tt.loadXemThongTin(txt_MaSV.Text);
            dataGridView2.DataSource = tt.loadXemThongTinTra(txt_MaSV.Text);
            dataGridView3.DataSource = tt.loadXemThongTinDangMuonSach(txt_MaSV.Text);
        }

        private void btdangky_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tt.loadXemThongTin(txt_MaSV.Text);
            dataGridView2.DataSource = tt.loadXemThongTinTra(txt_MaSV.Text);
            dataGridView3.DataSource = tt.loadXemThongTinDangMuonSach(txt_MaSV.Text);
        }

        private void FormXemThongTin_Load(object sender, EventArgs e)
        {
            txt_TenSV.Text = tenSV;
            txt_MaSV.Text = MaSV;
            txt_MaSV.Enabled = txt_TenSV.Enabled = false;
        }

        private void txt_MaSV_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tt.loadXemThongTin(txt_MaSV.Text);
            dataGridView2.DataSource = tt.loadXemThongTinTra(txt_MaSV.Text);
            dataGridView3.DataSource = tt.loadXemThongTinDangMuonSach(txt_MaSV.Text);
        }
    }
}
