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
    public partial class FormDangNhap : Form
    {
        DangNhap dn;
        public FormDangNhap()
        {
            InitializeComponent();
            dn = new DangNhap();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rd_ThuThu.Checked == true)
            {
                if (dn.KTDangNhapTT(txtTaikhoan.Text, txtMatKhau.Text))
                {
                    comboBox1.DataSource = dn.timKiemTenTT(txtTaikhoan.Text);
                    comboBox1.DisplayMember = "TenTT";
                    comboBox1.ValueMember = "MaTT";
                    TrangChu.ten = "Thủ Thư " + "- " + comboBox1.Text;
                    FormMuonSach.Ma = comboBox1.SelectedValue.ToString();
                    FormMuonPhong.MaTT = comboBox1.SelectedValue.ToString();
                    this.Hide();
                    TrangChu tc = new TrangChu();
                    tc.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Vui lòng kiểm tra lại mật khẩu hoặc tên tài khoản không đúng (^-^)");
                }
            }
            else if (rd_DocGia.Checked == true)
            {
                if (dn.KTDangNhapDG(txtTaikhoan.Text, txtMatKhau.Text))
                {
                    comboBox1.DataSource = dn.timKiemTenDG(txtTaikhoan.Text);
                    comboBox1.DisplayMember = "TenDG";
                    comboBox1.ValueMember = "MSSV";
                    TrangChu.ten = "Độc Giả " + "- " + comboBox1.Text;
                    FormMuonSach.Ma = comboBox1.SelectedValue.ToString();
                    FormXemThongTin.tenSV = comboBox1.Text;
                    FormXemThongTin.MaSV = comboBox1.SelectedValue.ToString();
                    this.Hide();
                 
                    TrangChu tc = new TrangChu();
                    tc.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Vui lòng kiểm tra lại mật khẩu hoặc tên tài khoản không đúng (^-^)");
                    txtTaikhoan.Clear();
                    txtMatKhau.Clear();
                    txtTaikhoan.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại tài khoản(^-^)");
            }
        }
    }
}
