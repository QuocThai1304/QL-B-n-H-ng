using BUS_QLBanHang;
using DTO_QLBanHang;
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
    public partial class frmDanhSachNhanVien : Form
    {
        public frmDanhSachNhanVien()
        {
            InitializeComponent();
        }
        private void NapDanhSachSinhVien()
        {
            string key = txtKey.Text.Trim();
            if (key == "Mã hoặc Tên")
                key = "";
            List<NhanVien> ListNhanVien;
            ListNhanVien = BUS_NhanVien.Search(key);
            var ListHienThi = (from n in ListNhanVien
                               select new
                               {
                                   n.Id,
                                   n.MaNV,
                                   n.TenNV,
                                   n.Email,
                                   n.DiaChi,
                                   n.VaiTro,
                                   n.TinhTrang
                               }).ToList();
            dgvDanSachNhanVien.DataSource = ListHienThi;
            dgvDanSachNhanVien.Columns[0].Visible = false;
            dgvDanSachNhanVien.Columns[1].HeaderText = "Mã NV";
            dgvDanSachNhanVien.Columns[1].Width = 70;
            dgvDanSachNhanVien.Columns[2].HeaderText = "Tên NV";
            dgvDanSachNhanVien.Columns[2].Width = 150;
            dgvDanSachNhanVien.Columns[3].HeaderText = "Email";
            dgvDanSachNhanVien.Columns[3].Width = 150;
            dgvDanSachNhanVien.Columns[4].HeaderText = "Địa Chỉ";
            dgvDanSachNhanVien.Columns[4].Width = 150;
            dgvDanSachNhanVien.Columns[5].HeaderText = "Vai trò";
            dgvDanSachNhanVien.Columns[5].Width = 50;
            dgvDanSachNhanVien.Columns[6].HeaderText = "Tình Trạng";
            dgvDanSachNhanVien.Columns[6].Width = 50;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var row = dgvDanSachNhanVien.CurrentRow;
            if (row != null)
            {
                string maNV = row.Cells["maNV"].Value.ToString();
                NhanVien nv = BUS_NhanVien.Get(maNV);
                frmThemSuaNhanVien frm = new frmThemSuaNhanVien(nv);
                if (frm.ShowDialog() == DialogResult.OK)
                    NapDanhSachSinhVien();
            }
            else
                DialogHelper.Alter("Bạn cần chọn nhân viên muốn sửa);


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemSuaNhanVien frm = new frmThemSuaNhanVien(null);
            if (frm.ShowDialog() == DialogResult.OK)
                NapDanhSachSinhVien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (DialogHelper.Comfirm("Bạn chắc chắn muốn xóa không?") == DialogResult.Yes)
            {
                var row = dgvDanSachNhanVien.CurrentRow;
                if (row != null)
                {
                    string maNV = row.Cells["maNV"].Value.ToString();
                    NhanVien nv = BUS_NhanVien.Get(maNV);
                    if (BUS_NhanVien.Delete(nv) > 0)
                    {
                        NapDanhSachSinhVien();
                        DialogHelper.Alter("Xóa Nhân viên thành công");
                    }
                    else
                        DialogHelper.Alter("Không thể xóa nhân viên vì có các dữ liệu liên quan");

                }
                else
                    DialogHelper.Alter("Bạn cần chọn nhâ viên muốn xóa");
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            NapDanhSachSinhVien();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtKey_Enter(object sender, EventArgs e)
        {
            if (txtKey.Text == "Mã hoặc Tên")
                txtKey.Text = "";
        }
        private void txtKey_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKey.Text))
                txtKey.Text = "mã hoặc tên";
        }
    }
}
