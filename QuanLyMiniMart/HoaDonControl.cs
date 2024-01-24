using DevExpress.XtraGrid.Views.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyMiniMart
{
    public partial class HoaDonControl : UserControl
    {
        public HoaDonControl()
        {
            InitializeComponent();
        }

        private void HoaDonControl_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        void loaddata()
        {
            DataTable dt = MyClass.getData("SELECT HD.MaHoaDon, HD.MaKhachHang, KH.TenKhachHang, HD.MaNhanVien, NV.TenNhanVien, HD.TongTienHoaDon, HD.NgayXuatHoaDon " +
                                "FROM HoaDon HD " +
                                "JOIN KhachHang KH ON HD.MaKhachHang = KH.MaKhachHang " +
                                "JOIN NhanVien NV ON HD.MaNhanVien = NV.MaNhanVien");

            gridHoaDon.DataSource = dt;
            
        }
        private void gridView1_CustomDrawRowIndicator_1(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            MyClass.STT.TaoCotSTT(e);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim().ToLower(); // Lấy từ khóa tìm kiếm và chuẩn hóa nó

            // Nếu từ khóa không rỗng
            if (!string.IsNullOrEmpty(keyword)&& keyword != "Tìm kiếm hóa đơn")
            {
                // Lọc dữ liệu trong GridView dựa trên từ khóa
                gridView1.ActiveFilterString = $"[TenKhachHang] LIKE '%{keyword}%' OR [NgayXuatHoaDon] LIKE '%{keyword}%'";
            }
            else if (keyword == "tìm kiếm hóa đơn")
            {
                gridView1.ActiveFilterString = "";
            }
            else
            {
                // Nếu từ khóa rỗng, xóa bộ lọc
                gridView1.ActiveFilterString = "";
            }

        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                txtTimKiem.Text = "Tìm kiếm hóa đơn";
                txtTimKiem.ForeColor = Color.Silver;
            }

        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Tìm kiếm hóa đơn")
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = Color.Black;
            }
        }

        private void gridView1_CellValueChanging(object sender, CellValueChangedEventArgs e)
        {
            // Kiểm tra xem giá trị của ô đã thay đổi và ô đang được chọn (checked)
            if (e.Column.FieldName == "ChiTietHoaDon" && e.Value != null && (bool)e.Value)
            {
                // Lấy mã hóa đơn từ dòng đang chọn
                object maHoaDon = gridView1.GetRowCellValue(e.RowHandle, "MaHoaDon");

                // Hiển thị form ChiTietHoaDon
                ShowChiTietHoaDonForm(maHoaDon);
            }
        }

        private void ShowChiTietHoaDonForm(object maHoaDon)
        {
            // Gọi form ChiTietHoaDon và truyền mã hóa đơn
            frmChiTietHoaDon chiTietHoaDonForm = new frmChiTietHoaDon(maHoaDon);

            // Hiển thị form ChiTietHoaDon
            chiTietHoaDonForm.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataRow dr = gridView1.GetFocusedDataRow();

            if (dr != null)
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa " + dr["MaHoaDon"] + " ra khỏi danh sách hóa đơn ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MyClass.execquery("DELETE FROM ChiTietHoaDon WHERE MaHoaDon = '" + dr["MaHoaDon"] + "'");
                    MyClass.execquery("DELETE FROM HoaDon WHERE MaHoaDon = '" + dr["MaHoaDon"] + "'");
                }

            }
            loaddata();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}

