using DTO_QLBanHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLBanHang
{
    public partial class frmMain : Form
    {
        public static NhanVien nhanVien; //dùng để lưu thông tin tài khoản đăng nhập
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            resetMenu();
        }
        private void resetMenu()
        {
            if(nhanVien == null)
            {
                //hẹ thong
                mniDangXuat.Enabled = true;
                
            }
        }
        private void OpenOrActiveFrom(From frm)
        {
            From frm1 = this.MdiChildren.FirstOrDefault(f => f.Name == frm.Name);
            if(frm1 != null)
            {
                frm1.Activete();
            }
            else
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }
        private void DangNhap()
        {
            frmDangNhap frm = new frmDangNhap();
            frm.ShowDialog();
            resetMenu();
        }
        private void DangXuat()
        {
            nhanVien = null;
            foreach(var f in this.MdiChildren)
            {

            }
        }
        

        private void mniDangNhap_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            resetMenu();
        }

        private void mniHoSo_Click(object sender, EventArgs e)
        {
            frmHoSoNhanVien frm = new frmHoSoNhanVien();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                resetMenu();
                DialogHelper.Alert("Cập nhật mật khẩu thành công. Bạn cần đăng nhập lại");
                DangNhap();
            }
        }

        private void mniThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mniSanPham_Click(object sender, EventArgs e)
        {
            frmDanhSachHang frm = new frmDanhSachHang();
            OpenOrActiveFrom(frm);
        }

        private void mniNhanVien_Click(object sender, EventArgs e)
        {
            frmDanhSachNhanVien frm = new frmDanhSachNhanVien();
            OpenOrActiveFrom(frm);
        }

        private void mniKhachhang_Click(object sender, EventArgs e)
        {
            frmDanhSachKhachHang frm = new frmDanhSachKhachHang();
            OpenOrActiveFrom(frm);
        }

        private void mniThongKeSanPham_Click(object sender, EventArgs e)
        {
            var frm = new frmThongKe();
            OpenOrActiveFrom(frm);
        }

        private void mniHuongDanSuDung_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = Application.StartupPath + @"\Docs\help.pdf";
                System.Diagnostics.Process.Start(filePath);
            }
            catch(Exception ex) 
            {
                DialogHelper.Error("Lỗi: " + ex.Message);
            }
        }

        private void mniGioiThieu_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            OpenOrActiveFrom(frm);
        }

        
    }
}
