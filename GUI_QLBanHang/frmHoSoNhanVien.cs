using BUS_QLBanHang;
using GUI_QLBanHang.DialogHelper;
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
    public partial class frmHoSoNhanVien : Form
    {
        public frmHoSoNhanVien()
        {
            InitializeComponent();
        }
        private bool KiemTraDuLieuNhap()
        {
            if(txtOldPass.Text.Trim().Lenght == 0)
            {
                DialogHelper.Alter("Bạn phải nhập mật khẩu cũ");
                txtOldPass.Focus();
                return false;
            }
            if(txtNewPass.Text.Trim().Lenght == 0)
            {
                DialogHelper.Alter("Bạn phải nhạp mật khẩu mới");
                txtNewpass.Focus();
                return false;
            }
            if(txtReNewPass.Text.Trim().Lenght == 0)
            {
                DialogHelper.Alter("Bạn phải nhập lại mật khẩu mới");
                txtReNewPass.Focus();
                return false;
            }
            if (txtReNewPass.Text.Trim().Length == 0)
            {
                DialogHelper.Alert("Mật Khẩu mới và Nhập lại mật khẩu mới không giống nhau");
                txtReNewPass.Focus();
                return false;
            }
            if (txtNewPass.Text.Trim() == txtOlPass.Text.Trim())
            {
                DialogHelper.Alert(" Mật Khẩu mới trùng với mật khẩu cũ");
                txtReNewPass.Focus();
                return false;
            }
        }
        //private void btnOK_Click(object sender, EventArgs e)
        //{
        //    if (KiemTraDuLieuNhap() == false)
        //        return;
        //    string email = txtEmail.Text;
        //    string oldPass = StringHelper.MD5Hash(txtOldPass.Text.Trim());
        //    string NewPass = StringHelper.MD5Hash(txtNewPass.Text.Trim());
        //    if(BUS_NhanVien.UpdatePassword(email,oldPass,NewPass) > 0)
        //    {
        //        frmMain.nhanVien = null;
        //        //Send mail
        //        String subject = "Cập nhật mật khẩu thành công";
        //        String message = "Bạn vừa cập nhật mật khẩu thành công. Mật khẩu mới của bạn là : " + txtNewPass.Text;
        //        EmailHelper.SendMail(email,subject,message);
        //        this.DialogResult = DialogResult.OK;
        //    }
        //    else
        //    {
        //        DialogHelper.Error("Cập nhật mật khẩu thất bại. Sai mật khẩu cũ");
        //    }

        //}
        //private void btnClose_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}
        
        private void frmHoSoNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            if (KiemTraDuLieuNhap() == false)
                return;
            string email = txtEmail.Text;
            string oldPass = StringHelper.MD5Hash(txtOldPass.Text.Trim());
            string NewPass = StringHelper.MD5Hash(txtNewPass.Text.Trim());
            if (BUS_NhanVien.UpdatePassword(email, oldPass, NewPass) > 0)
            {
                frmMain.nhanVien = null;
                //Send mail
                String subject = "Cập nhật mật khẩu thành công";
                String message = "Bạn vừa cập nhật mật khẩu thành công. Mật khẩu mới của bạn là : " + txtNewPass.Text;
                EmailHelper.SendMail(email, subject, message);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                DialogHelper.Error("Cập nhật mật khẩu thất bại. Sai mật khẩu cũ");
            }

        }
    }
}
