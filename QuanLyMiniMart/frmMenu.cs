using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyMiniMart
{
    public partial class frmMenu : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
       
        public frmMenu()
        {
            InitializeComponent();
           //menuBanHang.Visible = false;
           
        }


        public AccordionControlElement GetMenuBanHang()
        {
            // Trả về đối tượng của nút bạn muốn điều khiển
            return menuBanHang;
        }
        public AccordionControlElement GetMenuTaiKhoan()
        {
            // Trả về đối tượng của nút bạn muốn điều khiển
            return menuTaiKhoan;
        }
        public AccordionControlElement GetMenuNhanVien()
        {
            // Trả về đối tượng của nút bạn muốn điều khiển
            return menuNhanVien;
        }
        public AccordionControlElement GetMenuBCDT()
        {
            // Trả về đối tượng của nút bạn muốn điều khiển
            return menuGroupBaoCaoThongKe;
        }
        

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            frmBanHang frmBanHang = new frmBanHang();
            frmBanHang.Show();   
            
        }

        private void MenuKhoSanPham_Click(object sender, EventArgs e)
        {
            pn_body.Controls.Clear();
            KhoSanPhamControl khoSanPhamControl = new KhoSanPhamControl();

            if (khoSanPhamControl != null)
            {
                pn_body.Controls.Add(khoSanPhamControl);
                khoSanPhamControl.Show();
            }
        }

        private void menuBangGia_Click(object sender, EventArgs e)
        {
           pn_body.Controls.Clear();
            BangGiaControl bangGiaControl = new BangGiaControl();

            if (bangGiaControl != null)
            {
                pn_body.Controls.Add(bangGiaControl);
                bangGiaControl.Show();
            }
        }

        private void menuKhachHang_Click(object sender, EventArgs e)
        {
            pn_body.Controls.Clear();
            KhachHangControl khachHangControl = new KhachHangControl();

            if (khachHangControl != null)
            {
                pn_body.Controls.Add(khachHangControl);
                khachHangControl.Show();
            }
        }

        private void menuNhanVien_Click(object sender, EventArgs e)
        {
            pn_body.Controls.Clear();
            NhanVienControl nhanVienControl = new NhanVienControl();

            if (nhanVienControl != null)
            {
                pn_body.Controls.Add(nhanVienControl);
                nhanVienControl.Show();
            }
        }

        private void menuNCC_Click(object sender, EventArgs e)
        {
            pn_body.Controls.Clear();
            NhaCungCapControl nhaCungCapControl = new NhaCungCapControl();

            if (nhaCungCapControl != null)
            {
                pn_body.Controls.Add(nhaCungCapControl);
                nhaCungCapControl.Show();
            }
        }

        private void menuHoaDon_Click(object sender, EventArgs e)
        {
            pn_body.Controls.Clear();
            HoaDonControl hoaDonControl = new HoaDonControl();

            if (hoaDonControl != null)
            {
                pn_body.Controls.Add(hoaDonControl);
                hoaDonControl.Show();
            }
        }

        private void menuPhieuNhap_Click(object sender, EventArgs e)
        {
            pn_body.Controls.Clear();
            PhieuNhapControl phieuNhapControl = new PhieuNhapControl();

            if (phieuNhapControl != null)
            {
                pn_body.Controls.Add(phieuNhapControl);
                phieuNhapControl.Show();
            }

        }

        private void menuPhieuXuat_Click(object sender, EventArgs e)
        {
            pn_body.Controls.Clear();
            PhieuXuatControl phieuXuatControl = new PhieuXuatControl();

            if (phieuXuatControl != null)
            {
                pn_body.Controls.Add(phieuXuatControl);
                phieuXuatControl.Show();
            }
        }

        private void menuLoaiSanPham_Click(object sender, EventArgs e)
        {
            pn_body.Controls.Clear();
            LoaiSanPhamControl loaiSanPhamControl = new LoaiSanPhamControl();

            if (loaiSanPhamControl != null)
            {
                pn_body.Controls.Add(loaiSanPhamControl);
                loaiSanPhamControl.Show();
            }
        }

        private void menuTonKho_Click(object sender, EventArgs e)
        {
            pn_body.Controls.Clear();
            TonKhoControl tonKhoControl = new TonKhoControl();

            if (tonKhoControl != null)
            {
                pn_body.Controls.Add(tonKhoControl);
                tonKhoControl.Show();
            }

        }

        private void menuSPHetHang_Click(object sender, EventArgs e)
        {
            pn_body.Controls.Clear();
            SanPhamHetHang sanPhamHetHang = new SanPhamHetHang();

            if (sanPhamHetHang != null)
            {
                pn_body.Controls.Add(sanPhamHetHang);
                sanPhamHetHang.Show();
            }
        }

        private void menuTaiKhoan_Click(object sender, EventArgs e)
        {
            pn_body.Controls.Clear();
            TaiKhoanControl taiKhoanControl = new TaiKhoanControl();

            if (taiKhoanControl != null)
            {
                pn_body.Controls.Add(taiKhoanControl);
                taiKhoanControl.Show();
            }
        }

        private void menuDonViTinh_Click(object sender, EventArgs e)
        {
            pn_body.Controls.Clear();
            DonViTinhControl donViTinhControl = new DonViTinhControl();

            if (donViTinhControl != null)
            {
                pn_body.Controls.Add(donViTinhControl);
                donViTinhControl.Show();
            }
        }

        
        private void menuBaoCaoDoanhThu_Click(object sender, EventArgs e)
        {
            pn_body.Controls.Clear();
            BaoCaoThongKeConTrol baoCaoThongKeConTrol = new BaoCaoThongKeConTrol();

            if (baoCaoThongKeConTrol != null)
            {
                pn_body.Controls.Add(baoCaoThongKeConTrol);
                baoCaoThongKeConTrol.Show();
            }

        }

        private void menuLoiNhuan_Click(object sender, EventArgs e)
        {
            pn_body.Controls.Clear();
            LoiNhuanConTrol loiNhuanConTrol = new LoiNhuanConTrol();

            if (loiNhuanConTrol != null)
            {
                pn_body.Controls.Add(loiNhuanConTrol);
                loiNhuanConTrol.Show();
            }

        }

        private void menuKhachHangMuaHang_Click(object sender, EventArgs e)
        {
            pn_body.Controls.Clear();
            KhachHangControl KhachHangControl = new KhachHangControl();

            if (KhachHangControl != null)
            {
                pn_body.Controls.Add(KhachHangControl);
                KhachHangControl.Show();
            }
        }

        private void menuNhanVienBanHang_Click(object sender, EventArgs e)
        {
            pn_body.Controls.Clear();
            NhanVienBanHangTot NhanVienBanHangTot = new NhanVienBanHangTot();

            if (NhanVienBanHangTot != null)
            {
                pn_body.Controls.Add(NhanVienBanHangTot);
                NhanVienBanHangTot.Show();
            }
        }
    }
}
