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
    public partial class FormDangKi : Form
    {
        DangKi dk;
        public FormDangKi()
        {
            InitializeComponent();
            dk = new DangKi();
        }

        private void btdangky_Click(object sender, EventArgs e)
        {
            DateTime? ngSinh = DateTime.Parse(txt_ngaySinh.Text);
            if (rd_DocGia.Checked)
            {
                if (!dk.kiemTraKCDocGia(txt_TenTK.Text))
                {
                    DateTime? ngBD = DateTime.Today;
                    DateTime? ngyKT = DateTime.Parse(DateTime.Now.Month + "/" + DateTime.Now.Day + "/" + (DateTime.Now.Year + 6));
                    try
                    {
                        dk.LuuDG(txt_TenTK.Text, txt_HoTen.Text, txt_MatKhau.Text, cbgioitinh.SelectedItem.ToString(), txt_HinhAnh.Text, ngSinh, ngBD, ngyKT, txt_SDT.Text, txt_DiaChi.Text);
                        MessageBox.Show("Xin chào: " + txt_HoTen.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Vui lòng kiểm tra lại");
                    }
                }
                else
                {
                    MessageBox.Show("Đã tồn tại tài khoản vui lòng kiểm tra lại");
                }
            }
            else if (rd_TT.Checked == true)
            {
                if (!dk.kiemTraKCTT(txt_TenTK.Text))
                {
                    try
                    {
                        dk.LuuTT(txt_TenTK.Text, txt_HoTen.Text, txt_MatKhau.Text, cbgioitinh.SelectedItem.ToString(), txt_HinhAnh.Text, ngSinh, txt_SDT.Text, txt_DiaChi.Text);
                        MessageBox.Show("Xin chào: " + txt_HoTen.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Vui lòng kiểm tra lại");
                    }
                }
                else
                {
                    MessageBox.Show("Đã tồn tại tài khoản vui lòng kiểm tra lại");
                }
            }
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

        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
