namespace GUI_QLBanHang
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.mniDangNhap = new System.Windows.Forms.MenuStrip();
            this.mniHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mniDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mniHoSo = new System.Windows.Forms.ToolStripMenuItem();
            this.mniThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mniDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.mniNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mniKhachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.mniThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.mniThongKeSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.mniHuongDan = new System.Windows.Forms.ToolStripMenuItem();
            this.mniHuongDanSuDung = new System.Windows.Forms.ToolStripMenuItem();
            this.mniGioiThieu = new System.Windows.Forms.ToolStripMenuItem();
            this.chàoFpolygmailconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mniDangNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // mniDangNhap
            // 
            this.mniDangNhap.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mniDangNhap.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniHeThong,
            this.mniDanhMuc,
            this.mniThongKe,
            this.mniHuongDan,
            this.chàoFpolygmailconToolStripMenuItem});
            resources.ApplyResources(this.mniDangNhap, "mniDangNhap");
            this.mniDangNhap.Name = "mniDangNhap";
            this.mniDangNhap.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mniDangNhap_ItemClicked);
            // 
            // mniHeThong
            // 
            this.mniHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.mniDangXuat,
            this.mniHoSo,
            this.mniThoat});
            this.mniHeThong.Name = "mniHeThong";
            resources.ApplyResources(this.mniHeThong, "mniHeThong");
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            // 
            // mniDangXuat
            // 
            this.mniDangXuat.Name = "mniDangXuat";
            resources.ApplyResources(this.mniDangXuat, "mniDangXuat");
            // 
            // mniHoSo
            // 
            this.mniHoSo.Name = "mniHoSo";
            resources.ApplyResources(this.mniHoSo, "mniHoSo");
            this.mniHoSo.Click += new System.EventHandler(this.mniHoSo_Click);
            // 
            // mniThoat
            // 
            this.mniThoat.Name = "mniThoat";
            resources.ApplyResources(this.mniThoat, "mniThoat");
            this.mniThoat.Click += new System.EventHandler(this.mniThoat_Click);
            // 
            // mniDanhMuc
            // 
            this.mniDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniSanPham,
            this.mniNhanVien,
            this.mniKhachhang});
            this.mniDanhMuc.Name = "mniDanhMuc";
            resources.ApplyResources(this.mniDanhMuc, "mniDanhMuc");
            // 
            // mniSanPham
            // 
            this.mniSanPham.Name = "mniSanPham";
            resources.ApplyResources(this.mniSanPham, "mniSanPham");
            this.mniSanPham.Click += new System.EventHandler(this.mniSanPham_Click);
            // 
            // mniNhanVien
            // 
            this.mniNhanVien.Name = "mniNhanVien";
            resources.ApplyResources(this.mniNhanVien, "mniNhanVien");
            this.mniNhanVien.Click += new System.EventHandler(this.mniNhanVien_Click);
            // 
            // mniKhachhang
            // 
            this.mniKhachhang.Name = "mniKhachhang";
            resources.ApplyResources(this.mniKhachhang, "mniKhachhang");
            this.mniKhachhang.Click += new System.EventHandler(this.mniKhachhang_Click);
            // 
            // mniThongKe
            // 
            this.mniThongKe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniThongKeSanPham});
            this.mniThongKe.Name = "mniThongKe";
            resources.ApplyResources(this.mniThongKe, "mniThongKe");
            // 
            // mniThongKeSanPham
            // 
            this.mniThongKeSanPham.Name = "mniThongKeSanPham";
            resources.ApplyResources(this.mniThongKeSanPham, "mniThongKeSanPham");
            // 
            // mniHuongDan
            // 
            this.mniHuongDan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniHuongDanSuDung,
            this.mniGioiThieu});
            this.mniHuongDan.Name = "mniHuongDan";
            resources.ApplyResources(this.mniHuongDan, "mniHuongDan");
            // 
            // mniHuongDanSuDung
            // 
            this.mniHuongDanSuDung.Name = "mniHuongDanSuDung";
            resources.ApplyResources(this.mniHuongDanSuDung, "mniHuongDanSuDung");
            this.mniHuongDanSuDung.Click += new System.EventHandler(this.mniHuongDanSuDung_Click);
            // 
            // mniGioiThieu
            // 
            this.mniGioiThieu.Name = "mniGioiThieu";
            resources.ApplyResources(this.mniGioiThieu, "mniGioiThieu");
            this.mniGioiThieu.Click += new System.EventHandler(this.mniGioiThieu_Click);
            // 
            // chàoFpolygmailconToolStripMenuItem
            // 
            this.chàoFpolygmailconToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.chàoFpolygmailconToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem12,
            this.đăngXuấtToolStripMenuItem1});
            this.chàoFpolygmailconToolStripMenuItem.Name = "chàoFpolygmailconToolStripMenuItem";
            resources.ApplyResources(this.chàoFpolygmailconToolStripMenuItem, "chàoFpolygmailconToolStripMenuItem");
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            resources.ApplyResources(this.toolStripMenuItem12, "toolStripMenuItem12");
            // 
            // đăngXuấtToolStripMenuItem1
            // 
            this.đăngXuấtToolStripMenuItem1.Name = "đăngXuấtToolStripMenuItem1";
            resources.ApplyResources(this.đăngXuấtToolStripMenuItem1, "đăngXuấtToolStripMenuItem1");
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.mniDangNhap);
            this.Controls.Add(this.statusStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mniDangNhap.ResumeLayout(false);
            this.mniDangNhap.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip mniDangNhap;
        private System.Windows.Forms.ToolStripMenuItem mniHeThong;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mniDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mniHoSo;
        private System.Windows.Forms.ToolStripMenuItem mniThoat;
        private System.Windows.Forms.ToolStripMenuItem mniDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mniSanPham;
        private System.Windows.Forms.ToolStripMenuItem mniNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mniKhachhang;
        private System.Windows.Forms.ToolStripMenuItem mniThongKe;
        private System.Windows.Forms.ToolStripMenuItem mniThongKeSanPham;
        private System.Windows.Forms.ToolStripMenuItem mniHuongDan;
        private System.Windows.Forms.ToolStripMenuItem mniHuongDanSuDung;
        private System.Windows.Forms.ToolStripMenuItem mniGioiThieu;
        private System.Windows.Forms.ToolStripMenuItem chàoFpolygmailconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem1;
    }
}

