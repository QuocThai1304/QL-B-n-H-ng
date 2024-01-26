using BUS_QLBanHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLBanHang
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text.Trim().Length == 0 || txtMatKhau.Text.Trim().Length == 0)
            {
                DialogHelper.Alert("Bạn cần nhập đầy đủ thông tin để đăng nhập");
                return;
            }
            string matKhau = StringHelper.MD5Hash(txtMatKhau.Text);
           frmMain.nhanVien = BUS_NhanVien.DangNhap(txtEmail.Text, matKhau);
           if(frmMain.nhanVien != null)
            {
                DialogHelper.Alert("Đăng nhập thành công");
                this.Close();
            }
           else
            {
                DialogHelper.Alert("Sai thông tin đăng nhập");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuenMatKhau_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text.Trim() == "")
            {
                DialogHelper.Alert("Bạn cần nhập email nhận thông tin phục hồi mật khẩu");
                txtEmail.Focus();
                return;
            }
            if (!EmailHelper.IsValidEmail(txtEmail.Text))
            {
                DialogHelper.Alert("Địa chỉ email ko hợp lệ");
                txtEmail.Focus();
                return;
            }
            string email = txtEmail.Text.Trim();
            if(BUS_NhanVien.DaTonTaiEmail(email)== false)
            {
                DialogHelper.Alert("Địa chỉ email không tồn tại");
                txtEmail.Focus();
                return;
            }
            string matKhauMoi = StringHelper.GetRandomString(8);
            string subject = "Bạn đã sử dụng tính năng quên mật khẩu";
            string msg = "Chào anh/chị. mật khẩu mới truy cập phần mềm là: "+ matKhauMoi;
            string result = EmailHelper.SendMail(txtEmail.Text.Trim(), subject, msg);
            if (result ==)
            {
                DialogHelper.Alert("Một  email phục hồi mật khẩu đã được gửi đến bạn");
                if (BUS_NhanVien.CreatePassword(txtEmail.Text.Trim(), StringHelper.MD5Hash(matKhauMoi)) > 0)
                {
                    DialogHelper.Alert("Mật khẩu mới của bạn đã  được tạo");
                }
            }
            else
                DialogHelper.Alert("Lỗi gửi mail: " + result);
        }
    }
}
