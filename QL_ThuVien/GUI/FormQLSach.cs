using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using BUSINESS;

namespace GUI
{
    public partial class FormQLSach : Form
    {
        QLSach ql;
        public FormQLSach()
        {
            InitializeComponent();
            ql = new QLSach();
        }
       
        RichTextBox richtex = new RichTextBox();
        private void Bn_File_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files (*.png;*.jpeg)|*.png;*.jpeg|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_HinhAnh.Text = openFileDialog1.FileName;
                StreamReader f = new StreamReader(openFileDialog1.FileName);
                richtex.Text = f.ReadToEnd();
                f.Close();
            }
            pictureBox1.Image = Image.FromFile(txt_HinhAnh.Text);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void FormQLSach_Load(object sender, EventArgs e)
        {
            MaLoai.DataSource = ql.loadLOAISACH();
            MaLoai.DisplayMember = "TenLoai";
            MaLoai.ValueMember = "MaLoai";

            cb_LoaiSach.DataSource = ql.loadLOAISACH();
            cb_LoaiSach.DisplayMember = "TenLoai";
            cb_LoaiSach.ValueMember = "MaLoai";

            MaTG.DataSource = ql.loadTACGIA();
            MaTG.DisplayMember = "TenTG";
            MaTG.ValueMember = "MaTG";

            cb_TacGia.DataSource = ql.loadTACGIA();
            cb_TacGia.DisplayMember = "TenTG";
            cb_TacGia.ValueMember = "MaTG";

            MaNCC.DataSource = ql.loadNhaCC();
            MaNCC.DisplayMember = "TenNCC";
            MaNCC.ValueMember = "MaNCC";

            cb_NhaCC.DataSource = ql.loadNhaCC();
            cb_NhaCC.DisplayMember = "TenNCC";
            cb_NhaCC.ValueMember = "MaNCC";

            MaKhuVuc.DataSource = ql.loadKHUVUC();
            MaKhuVuc.DisplayMember = "TenKhuVuc";
            MaKhuVuc.ValueMember = "MaKhuVuc";

            cb_KhuVuc.DataSource = ql.loadKHUVUC();
            cb_KhuVuc.DisplayMember = "TenKhuVuc";
            cb_KhuVuc.ValueMember = "MaKhuVuc";

            MaNXB.DataSource = ql.loadNXB();
            MaNXB.DisplayMember = "TenNXB";
            MaNXB.ValueMember = "MaNXB";

            cb_NXB.DataSource = ql.loadNXB();
            cb_NXB.DisplayMember = "TenNXB";
            cb_NXB.ValueMember = "MaNXB";
            dataGridView1.DataSource = ql.loadSach();
            bn_TaoMa.Enabled = bn_Xoa.Enabled = bn_LuuSach.Enabled = false;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                bn_Xoa.Enabled = bn_LuuSach.Enabled = true;
                Txt_MaSach.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Txt_TenSach.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                cb_LoaiSach.SelectedValue = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                Txt_SoLuong.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txt_MoTa.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                cb_TacGia.SelectedValue = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txt_TrangThai.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                cb_NXB.SelectedValue = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                cb_KhuVuc.SelectedValue = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                txt_Gia.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                txt_HinhAnh.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                cb_NhaCC.SelectedValue = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                pictureBox1.Image = Image.FromFile("D:\\DoAnNam3\\20_Quan Ly Thu Vien\\HinhAnh\\"+txt_HinhAnh.Text+".jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch
            {
                return;
            }
        }

        private void bn_ThemSach_Click(object sender, EventArgs e)
        {
            txt_Gia.Clear();
            txt_HinhAnh.Clear();
            Txt_MaSach.Clear();
            Txt_SoLuong.Clear();
            txt_MoTa.Clear();
            Txt_TenSach.Clear();
            txt_TrangThai.Clear();
            bn_TaoMa.Enabled = true;
            bn_ThemSach.Enabled = false;
            Txt_MaSach.Enabled = false;
        }

        private void bn_TaoMa_Click(object sender, EventArgs e)
        {
            int? kq = ql.layMaSach();
            if (kq == null)
            {
                kq = 0;
            }
            kq++;
            Txt_MaSach.Text = "S" + kq.ToString();
            bn_LuuSach.Enabled = true;
            bn_Xoa.Enabled = true;
            bn_TaoMa.Enabled = false;
        }

        private void bn_LuuSach_Click(object sender, EventArgs e)
        {
            int? sl = Convert.ToInt16(Txt_SoLuong.Text);
            decimal? Gia = Convert.ToDecimal(txt_Gia.Text);
            if (!ql.KTKhoaChinh(Txt_MaSach.Text))
            {
               

                ql.ThemSach(Txt_MaSach.Text, Txt_TenSach.Text, cb_LoaiSach.SelectedValue.ToString(), sl, txt_MoTa.Text, cb_TacGia.SelectedValue.ToString(), txt_TrangThai.Text, cb_NXB.SelectedValue.ToString(), cb_KhuVuc.SelectedValue.ToString(), Gia, txt_HinhAnh.Text, cb_NhaCC.SelectedValue.ToString());
                MessageBox.Show("Thêm thành công");
                FormQLSach_Load(sender, e);
            }
            else
            {
                if (MessageBox.Show("Bạn Có Muốn Sửa Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (Txt_MaSach.Text == string.Empty)
                    {
                        MessageBox.Show("Mời bạn click vào bảng");
                    }
                    else
                    {
                        ql.SuaSach(Txt_MaSach.Text, Txt_TenSach.Text, cb_LoaiSach.SelectedValue.ToString(), sl, txt_MoTa.Text, cb_TacGia.SelectedValue.ToString(), txt_TrangThai.Text, cb_NXB.SelectedValue.ToString(), cb_KhuVuc.SelectedValue.ToString(), Gia, txt_HinhAnh.Text, cb_NhaCC.SelectedValue.ToString());
                        MessageBox.Show("Sửa thành công");
                        FormQLSach_Load(sender, e);
                    }
                }
            }
            bn_ThemSach.Enabled = true;
        }

        private void bn_Xoa_Click(object sender, EventArgs e)
        {
            if (Txt_MaSach.Text == string.Empty)
            {
                MessageBox.Show("Mời bạn chọn dữ liệu trong bảng");
            }
            else
            {
                if (MessageBox.Show("Bạn Có Muốn Xóa Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        ql.XoaSach(Txt_MaSach.Text);
                        MessageBox.Show("Xóa Thành Công");
                        FormQLSach_Load(sender, e);
                    }
                    catch
                    {
                        MessageBox.Show("Không thể xóa sách này");
                    }
                }
            }
        }

        private void Txt_SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
