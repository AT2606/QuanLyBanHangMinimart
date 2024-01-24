namespace QuanLyMiniMart
{
    partial class frmMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.pn_body = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.menuBanHang = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menuGroupSanPham = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menuKhoSanPham = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menuLoaiSanPham = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menuBangGia = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menuTonKho = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menuSPHetHang = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menuDonViTinh = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menuGroupQuanLy = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menuTaiKhoan = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menuNhanVien = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menuNCC = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menuHoaDon = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menuPhieuNhap = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menuPhieuXuat = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menuGroupBaoCaoThongKe = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menuBaoCaoDoanhThu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menuLoiNhuan = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menuNhanVienBanHang = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menuKhachHangMuaHang = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement9 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement10 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement11 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement12 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement13 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement14 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_body
            // 
            this.pn_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_body.Location = new System.Drawing.Point(328, 39);
            this.pn_body.Margin = new System.Windows.Forms.Padding(15);
            this.pn_body.Name = "pn_body";
            this.pn_body.Size = new System.Drawing.Size(1348, 1062);
            this.pn_body.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.menuBanHang,
            this.menuGroupSanPham,
            this.menuGroupQuanLy,
            this.menuGroupBaoCaoThongKe});
            this.accordionControl1.Location = new System.Drawing.Point(0, 39);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(15);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(328, 1062);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // menuBanHang
            // 
            this.menuBanHang.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("menuBanHang.ImageOptions.SvgImage")));
            this.menuBanHang.Name = "menuBanHang";
            this.menuBanHang.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.menuBanHang.Text = "Bán Hàng";
            this.menuBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
            // 
            // menuGroupSanPham
            // 
            this.menuGroupSanPham.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.menuKhoSanPham,
            this.menuLoaiSanPham,
            this.menuBangGia,
            this.menuTonKho,
            this.menuSPHetHang,
            this.menuDonViTinh});
            this.menuGroupSanPham.Expanded = true;
            this.menuGroupSanPham.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("menuGroupSanPham.ImageOptions.Image")));
            this.menuGroupSanPham.Name = "menuGroupSanPham";
            this.menuGroupSanPham.Text = "Sản Phẩm";
            // 
            // menuKhoSanPham
            // 
            this.menuKhoSanPham.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("menuKhoSanPham.ImageOptions.Image")));
            this.menuKhoSanPham.Name = "menuKhoSanPham";
            this.menuKhoSanPham.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.menuKhoSanPham.Text = "Kho Sản Phẩm";
            this.menuKhoSanPham.Click += new System.EventHandler(this.MenuKhoSanPham_Click);
            // 
            // menuLoaiSanPham
            // 
            this.menuLoaiSanPham.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("menuLoaiSanPham.ImageOptions.SvgImage")));
            this.menuLoaiSanPham.Name = "menuLoaiSanPham";
            this.menuLoaiSanPham.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.menuLoaiSanPham.Text = "Loại Sản Phẩm";
            this.menuLoaiSanPham.Click += new System.EventHandler(this.menuLoaiSanPham_Click);
            // 
            // menuBangGia
            // 
            this.menuBangGia.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("menuBangGia.ImageOptions.Image")));
            this.menuBangGia.Name = "menuBangGia";
            this.menuBangGia.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.menuBangGia.Text = "Bảng Giá";
            this.menuBangGia.Click += new System.EventHandler(this.menuBangGia_Click);
            // 
            // menuTonKho
            // 
            this.menuTonKho.ImageOptions.Image = global::QuanLyMiniMart.Properties.Resources.tonkho;
            this.menuTonKho.Name = "menuTonKho";
            this.menuTonKho.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.menuTonKho.Text = "Tồn Kho";
            this.menuTonKho.Click += new System.EventHandler(this.menuTonKho_Click);
            // 
            // menuSPHetHang
            // 
            this.menuSPHetHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("menuSPHetHang.ImageOptions.Image")));
            this.menuSPHetHang.Name = "menuSPHetHang";
            this.menuSPHetHang.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.menuSPHetHang.Text = "Sản Phẩm Gần Hết Hàng";
            this.menuSPHetHang.Click += new System.EventHandler(this.menuSPHetHang_Click);
            // 
            // menuDonViTinh
            // 
            this.menuDonViTinh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("menuDonViTinh.ImageOptions.Image")));
            this.menuDonViTinh.Name = "menuDonViTinh";
            this.menuDonViTinh.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.menuDonViTinh.Text = "Đơn Vị Tính";
            this.menuDonViTinh.Click += new System.EventHandler(this.menuDonViTinh_Click);
            // 
            // menuGroupQuanLy
            // 
            this.menuGroupQuanLy.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.menuTaiKhoan,
            this.menuNhanVien,
            this.menuNCC,
            this.menuHoaDon,
            this.menuPhieuNhap,
            this.menuPhieuXuat});
            this.menuGroupQuanLy.Expanded = true;
            this.menuGroupQuanLy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("menuGroupQuanLy.ImageOptions.Image")));
            this.menuGroupQuanLy.Name = "menuGroupQuanLy";
            this.menuGroupQuanLy.Text = "Quản Lý";
            // 
            // menuTaiKhoan
            // 
            this.menuTaiKhoan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("menuTaiKhoan.ImageOptions.Image")));
            this.menuTaiKhoan.Name = "menuTaiKhoan";
            this.menuTaiKhoan.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.menuTaiKhoan.Text = "Tài Khoản";
            this.menuTaiKhoan.Click += new System.EventHandler(this.menuTaiKhoan_Click);
            // 
            // menuNhanVien
            // 
            this.menuNhanVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("menuNhanVien.ImageOptions.Image")));
            this.menuNhanVien.Name = "menuNhanVien";
            this.menuNhanVien.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.menuNhanVien.Text = "Nhân Viên";
            this.menuNhanVien.Click += new System.EventHandler(this.menuNhanVien_Click);
            // 
            // menuNCC
            // 
            this.menuNCC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("menuNCC.ImageOptions.Image")));
            this.menuNCC.Name = "menuNCC";
            this.menuNCC.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.menuNCC.Text = "Nhà Cung Cấp";
            this.menuNCC.Click += new System.EventHandler(this.menuNCC_Click);
            // 
            // menuHoaDon
            // 
            this.menuHoaDon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("menuHoaDon.ImageOptions.Image")));
            this.menuHoaDon.Name = "menuHoaDon";
            this.menuHoaDon.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.menuHoaDon.Text = "Hóa Đơn";
            this.menuHoaDon.Click += new System.EventHandler(this.menuHoaDon_Click);
            // 
            // menuPhieuNhap
            // 
            this.menuPhieuNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("menuPhieuNhap.ImageOptions.Image")));
            this.menuPhieuNhap.Name = "menuPhieuNhap";
            this.menuPhieuNhap.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.menuPhieuNhap.Text = "Phiếu Nhập Hàng";
            this.menuPhieuNhap.Click += new System.EventHandler(this.menuPhieuNhap_Click);
            // 
            // menuPhieuXuat
            // 
            this.menuPhieuXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("menuPhieuXuat.ImageOptions.Image")));
            this.menuPhieuXuat.Name = "menuPhieuXuat";
            this.menuPhieuXuat.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.menuPhieuXuat.Text = "Phiếu Xuất Hàng";
            this.menuPhieuXuat.Click += new System.EventHandler(this.menuPhieuXuat_Click);
            // 
            // menuGroupBaoCaoThongKe
            // 
            this.menuGroupBaoCaoThongKe.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.menuBaoCaoDoanhThu,
            this.menuLoiNhuan,
            this.menuNhanVienBanHang,
            this.menuKhachHangMuaHang});
            this.menuGroupBaoCaoThongKe.Expanded = true;
            this.menuGroupBaoCaoThongKe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGroupBaoCaoThongKe.ImageOptions.Image")));
            this.menuGroupBaoCaoThongKe.Name = "menuGroupBaoCaoThongKe";
            this.menuGroupBaoCaoThongKe.Text = "Báo Cáo";
            // 
            // menuBaoCaoDoanhThu
            // 
            this.menuBaoCaoDoanhThu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("menuBaoCaoDoanhThu.ImageOptions.SvgImage")));
            this.menuBaoCaoDoanhThu.Name = "menuBaoCaoDoanhThu";
            this.menuBaoCaoDoanhThu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.menuBaoCaoDoanhThu.Text = "Báo Cáo Doanh Thu";
            this.menuBaoCaoDoanhThu.Click += new System.EventHandler(this.menuBaoCaoDoanhThu_Click);
            // 
            // menuLoiNhuan
            // 
            this.menuLoiNhuan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("menuLoiNhuan.ImageOptions.SvgImage")));
            this.menuLoiNhuan.Name = "menuLoiNhuan";
            this.menuLoiNhuan.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.menuLoiNhuan.Text = "Biểu Đồ DT&LN";
            this.menuLoiNhuan.Click += new System.EventHandler(this.menuLoiNhuan_Click);
            // 
            // menuNhanVienBanHang
            // 
            this.menuNhanVienBanHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("menuNhanVienBanHang.ImageOptions.Image")));
            this.menuNhanVienBanHang.Name = "menuNhanVienBanHang";
            this.menuNhanVienBanHang.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.menuNhanVienBanHang.Text = "Nhân Viên Bán Hàng Tốt";
            this.menuNhanVienBanHang.Click += new System.EventHandler(this.menuNhanVienBanHang_Click);
            // 
            // menuKhachHangMuaHang
            // 
            this.menuKhachHangMuaHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("menuKhachHangMuaHang.ImageOptions.Image")));
            this.menuKhachHangMuaHang.Name = "menuKhachHangMuaHang";
            this.menuKhachHangMuaHang.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.menuKhachHangMuaHang.Text = "Khách Hàng Mua Hàng";
            this.menuKhachHangMuaHang.Click += new System.EventHandler(this.menuKhachHangMuaHang_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1676, 39);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement2,
            this.accordionControlElement3,
            this.accordionControlElement9,
            this.accordionControlElement10,
            this.accordionControlElement11,
            this.accordionControlElement12,
            this.accordionControlElement13});
            this.accordionControlElement1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement1.ImageOptions.Image")));
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Quản Lý";
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement2.ImageOptions.Image")));
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement2.Text = "Bảng Giá";
            // 
            // accordionControlElement3
            // 
            this.accordionControlElement3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement3.ImageOptions.Image")));
            this.accordionControlElement3.Name = "accordionControlElement3";
            this.accordionControlElement3.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement3.Text = "Khách Hàng";
            // 
            // accordionControlElement9
            // 
            this.accordionControlElement9.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement9.ImageOptions.Image")));
            this.accordionControlElement9.Name = "accordionControlElement9";
            this.accordionControlElement9.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement9.Text = "Nhân Viên";
            // 
            // accordionControlElement10
            // 
            this.accordionControlElement10.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement10.ImageOptions.Image")));
            this.accordionControlElement10.Name = "accordionControlElement10";
            this.accordionControlElement10.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement10.Text = "Nhà Cung Cấp";
            // 
            // accordionControlElement11
            // 
            this.accordionControlElement11.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement11.ImageOptions.Image")));
            this.accordionControlElement11.Name = "accordionControlElement11";
            this.accordionControlElement11.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement11.Text = "Hóa Đơn";
            // 
            // accordionControlElement12
            // 
            this.accordionControlElement12.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement12.ImageOptions.Image")));
            this.accordionControlElement12.Name = "accordionControlElement12";
            this.accordionControlElement12.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement12.Text = "Phiếu Nhập Hàng";
            // 
            // accordionControlElement13
            // 
            this.accordionControlElement13.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement13.ImageOptions.Image")));
            this.accordionControlElement13.Name = "accordionControlElement13";
            this.accordionControlElement13.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement13.Text = "Phiếu Xuất Hàng";
            // 
            // accordionControlElement14
            // 
            this.accordionControlElement14.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement14.ImageOptions.Image")));
            this.accordionControlElement14.Name = "accordionControlElement14";
            this.accordionControlElement14.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement14.Text = "Kho";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1676, 1101);
            this.ControlContainer = this.pn_body;
            this.Controls.Add(this.pn_body);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "frmMenu";
            this.NavigationControl = this.accordionControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer pn_body;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuBanHang;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuGroupSanPham;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuGroupQuanLy;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuGroupBaoCaoThongKe;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuNhanVien;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuHoaDon;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuPhieuNhap;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuPhieuXuat;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuBaoCaoDoanhThu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuTonKho;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuSPHetHang;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuBangGia;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuNCC;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement9;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement10;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement11;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement12;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement13;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement14;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuKhoSanPham;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuLoaiSanPham;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuDonViTinh;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuTaiKhoan;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuLoiNhuan;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuNhanVienBanHang;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuKhachHangMuaHang;
    }
}