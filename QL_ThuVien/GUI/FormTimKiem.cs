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
    public partial class FormTimKiem : Form
    {
        TimKiem tk;
        public FormTimKiem()
        {
            InitializeComponent();
            tk = new TimKiem();
        }

        private void txt_TenTK_KeyUp(object sender, KeyEventArgs e)
        {
            dataGridView1.DataSource = tk.loadSach(txt_TenTK.Text);
            if (rd_TenSach.Checked)
            {
                dataGridView1.DataSource = tk.loadSach(txt_TenTK.Text);
            }
            else if (rd_TacGia.Checked)
            {
                dataGridView1.DataSource = tk.loadSachTacGia(txt_TenTK.Text);
            }
            else if (rd_LoaiSach.Checked)
            {
                dataGridView1.DataSource = tk.loadSachLoai(txt_TenTK.Text);
            }
        }

        private void FormTimKiem_Load(object sender, EventArgs e)
        {
            MaLoai.DataSource = tk.loadLOAISACH();
            MaLoai.DisplayMember = "TenLoai";
            MaLoai.ValueMember = "MaLoai";

            MaTG.DataSource = tk.loadTACGIA();
            MaTG.DisplayMember = "TenTG";
            MaTG.ValueMember = "MaTG";

            MaNCC.DataSource = tk.loadNhaCC();
            MaNCC.DisplayMember = "TenNCC";
            MaNCC.ValueMember = "MaNCC";

            MaKhuVuc.DataSource = tk.loadKHUVUC();
            MaKhuVuc.DisplayMember = "TenKhuVuc";
            MaKhuVuc.ValueMember = "MaKhuVuc";

            MaNXB.DataSource = tk.loadNXB();
            MaNXB.DisplayMember = "TenNXB";
            MaNXB.ValueMember = "MaNXB";
            dataGridView1.DataSource = tk.loadAllSach();
        }

        private void bn_Tim_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tk.loadSach(txt_TenTK.Text);
            if (rd_TenSach.Checked)
            {
                dataGridView1.DataSource = tk.loadSach(txt_TenTK.Text);
            }
            else if (rd_TacGia.Checked)
            {
                dataGridView1.DataSource = tk.loadSachTacGia(txt_TenTK.Text);
            }
            else if (rd_LoaiSach.Checked)
            {
                dataGridView1.DataSource = tk.loadSachLoai(txt_TenTK.Text);
            }
        }
    }
}
