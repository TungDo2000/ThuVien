using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUSINESS;
using System.IO;

namespace GUI
{
    public partial class FormDocGia : Form
    {
        DocGia dg_BD;
        public FormDocGia()
        {
            InitializeComponent();
            txt_GioiTinh.SelectedIndex = 1;
            dg_BD = new DocGia();
        }

        private void FormDocGia_Load(object sender, EventArgs e)
        {
            btn_Luu.Enabled = false;
            btn_xoa.Enabled = false;
            dgView_DG.DataSource = dg_BD.loaddgvDocGia();
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

        private void dgView_DG_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txt_MaDG.Text = dgView_DG.CurrentRow.Cells[0].Value.ToString();
                txt_TenDG.Text = dgView_DG.CurrentRow.Cells[2].Value.ToString();
                txt_GioiTinh.Text = dgView_DG.CurrentRow.Cells[3].Value.ToString();
                txt_NgaySinh.Text = DateTime.Parse(dgView_DG.CurrentRow.Cells[4].Value.ToString()).ToString("dd/MM/yyyy");
                txt_SDT.Text = dgView_DG.CurrentRow.Cells[5].Value.ToString();
                txt_DiaChi.Text = dgView_DG.CurrentRow.Cells[6].Value.ToString();
                txt_NgaylapThe.Text = DateTime.Parse(dgView_DG.CurrentRow.Cells[7].Value.ToString()).ToString("dd/MM/yyyy");
                txt_NgayHetHan.Text = DateTime.Parse(dgView_DG.CurrentRow.Cells[8].Value.ToString()).ToString("dd/MM/yyyy");
                txt_TienCoc.Text = dgView_DG.CurrentRow.Cells[9].Value.ToString();
                txt_HinhAnh.Text = dgView_DG.CurrentRow.Cells[10].Value.ToString();
                txt_MatKhau.Text = dgView_DG.CurrentRow.Cells[1].Value.ToString();
                btn_Luu.Enabled = true;
                btn_xoa.Enabled = true;
                pictureBox1.Image = Image.FromFile(txt_HinhAnh.Text);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch
            {
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            txt_DiaChi.Clear();
            txt_HinhAnh.Clear();
            txt_MaDG.Clear();
            txt_MatKhau.Clear();
            txt_NgaySinh.Clear();
            txt_SDT.Clear();
            txt_TenDG.Clear();
            txt_MaDG.Focus();
            txt_TienCoc.Text = "100000";
            txt_TienCoc.Enabled = false;
            txt_NgaylapThe.Text = DateTime.Parse(DateTime.Now.ToString()).ToString("dd/MM/yyyy");
            txt_NgaylapThe.Enabled = false;
            txt_NgayHetHan.Text = DateTime.Parse(DateTime.Now.AddYears(6).ToString()).ToString("dd/MM/yyyy");
            txt_NgayHetHan.Enabled = false;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            DateTime? ngSinh = DateTime.Parse(txt_NgaySinh.Text);
            DateTime? ngBD = DateTime.Today;
            DateTime? ngyKT = DateTime.Parse(DateTime.Now.Month + "/" + DateTime.Now.Day + "/" + (DateTime.Now.Year + 6));
            if (!dg_BD.KiemTraKhoaChinhDG(txt_MaDG.Text))
            {
                
                try
                {
                    dg_BD.LuuDG(txt_MaDG.Text, txt_TenDG.Text, txt_MatKhau.Text, txt_GioiTinh.SelectedItem.ToString(), txt_HinhAnh.Text, ngSinh, ngBD, ngyKT, txt_SDT.Text, txt_DiaChi.Text);
                    MessageBox.Show("Xin chào: " + txt_TenDG.Text);
                    FormDocGia_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Vui lòng kiểm tra lại");
                }
            }
            else
            {
                if (MessageBox.Show("Bạn Có Muốn Sửa Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (txt_MaDG.Text == string.Empty)
                    {
                        MessageBox.Show("Mời bạn click vào bảng");
                    }
                    else
                    {
                        try
                        {
                            dg_BD.suaDG(txt_MaDG.Text, txt_TenDG.Text, txt_GioiTinh.SelectedItem.ToString(), txt_HinhAnh.Text, DateTime.Parse(txt_NgaySinh.Text).ToString("dd/MM/yyyy"), txt_NgaylapThe.Text, txt_NgayHetHan.Text, txt_SDT.Text, txt_DiaChi.Text);
                            MessageBox.Show("Sửa thành công");
                            FormDocGia_Load(sender, e);
                        }
                        catch
                        {
                            MessageBox.Show("Vui lòng kiểm tra lại");
                        }
                    }
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txt_MaDG.Text == string.Empty)
            {
                MessageBox.Show("Mời bạn chọn dữ liệu trong bảng");
            }
            else
            {
                if (MessageBox.Show("Bạn Có Muốn Xóa Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        dg_BD.xoaDG(txt_MaDG.Text);
                        MessageBox.Show("Xóa Thành Công");
                        FormDocGia_Load(sender, e);
                    }
                    catch
                    {
                        MessageBox.Show("Không thể được");
                    }
                }
            }
        }

        private void txt_MaDG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
