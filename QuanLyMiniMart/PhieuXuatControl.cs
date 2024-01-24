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
    public partial class PhieuXuatControl : UserControl
    {
        public PhieuXuatControl()
        {
            InitializeComponent();
        }

        private void PhieuXuatControl_Load(object sender, EventArgs e)
        {

            loaddata();
            loadlkNhanVien();
            loadlkNCC();
        }
        void loaddata()
        {
            DataTable dt = MyClass.getData("SELECT PX.MaPhieuXuat, NCC.MaNhaCungCap, NCC.TenNhaCungCap, NV.MaNhanVien, NV.TenNhanVien, PX.TongTien, PX.NgayXuatHang " +
                                "FROM XuatHang PX " +
                                "JOIN NhaCungCap NCC ON PX.MaNhaCungCap = NCC.MaNhaCungCap " +
                                "JOIN NhanVien NV ON PX.MaNhanVien = NV.MaNhanVien");

            gridPhieuXuat.DataSource = dt;

        }
        void loadlkNhanVien()
        {
            lkNV.DataSource = MyClass.getData("SELECT * from NhanVien");
            lkNV.DisplayMember = "MaNhanVien";

            lkNV.ValueMember = "MaNhanVien";
        }
        void loadlkNCC()
        {
            lkNCC.DataSource = MyClass.getData("SELECT * from NhaCungCap");
            lkNCC.DisplayMember = "MaNhaCungCap";
            lkNCC.ValueMember = "MaNhaCungCap";
        }
        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            MyClass.STT.TaoCotSTT(e);
        }
        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {


            // Kiểm tra xem giá trị của ô đã thay đổi và ô đang được chọn (checked)
            if (e.Column.FieldName == "ChiTietPhieuXuat" && e.Value != null && (bool)e.Value)
            {
                // Lấy mã hóa đơn từ dòng đang chọn
                object maHoaDon = gridView1.GetRowCellValue(e.RowHandle, "MaPhieuXuat");

                // Hiển thị form ChiTietHoaDon
                ShowChiTietPhieuXuatForm(maHoaDon);


            }

        }

        private void ShowChiTietPhieuXuatForm(object maphieunhap)
        {
            // Gọi form ChiTietHoaDon và truyền mã hóa đơn
            frmChiTietXuatHang chiTietXuatHang = new frmChiTietXuatHang(maphieunhap);

            // Hiển thị form ChiTietHoaDon
            chiTietXuatHang.Show();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {

            bool hasShownWarning = false;
            HashSet<string> uniqueCategoryNames = new HashSet<string>();

            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRow dr = gridView1.GetDataRow(i);

                if (!string.IsNullOrEmpty(dr["MaPhieuXuat"].ToString()) && !string.IsNullOrEmpty(dr["MaNhaCungCap"].ToString())
                    && !string.IsNullOrEmpty(dr["MaNhanVien"].ToString()) && !string.IsNullOrEmpty(dr["TongTien"].ToString())
                    && !string.IsNullOrEmpty(dr["NgayXuatHang"].ToString()))
                {
                    string maphieuxuat = dr["MaPhieuXuat"].ToString();
                    string manhacungcap = dr["MaNhaCungCap"].ToString();
                    string manhanvien = dr["MaNhanVien"].ToString();
                    string tongtien = dr["TongTien"].ToString();
                    string ngayxuathang = dr["NgayXuatHang"].ToString();

                    //Console.WriteLine(dr["MaTaiKhoan"].ToString());

                    if (uniqueCategoryNames.Contains(maphieuxuat))
                    {
                        MessageBox.Show($"Mã phiếu nhập '{maphieuxuat}' đã có.\nVui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        // You may choose to break here or continue to process the rest of the rows
                    }
                    else
                    {
                        uniqueCategoryNames.Add(maphieuxuat);

                        if (dr.RowState == DataRowState.Modified)
                        {
                            UpdatePhieuNhap(maphieuxuat, manhacungcap, manhanvien, tongtien, ngayxuathang);
                        }
                        else if (dr.RowState == DataRowState.Added)
                        {
                            InsertPhieuNhap(maphieuxuat, manhacungcap, manhanvien, tongtien, ngayxuathang);
                        }
                    }
                }
                else
                {
                    if (!hasShownWarning)
                    {
                        MessageBox.Show("Bạn cần điền đủ các thông tin của phiếu nhập (*)", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        hasShownWarning = true;
                    }
                }
            }
            loaddata();

        }
        private void UpdatePhieuNhap(string maphieuxuat, string manhacungcap, string manhanvien, string tongtien, string ngayxuathang)
        {
            string updateQuery = "UPDATE XuatHang SET MaNhaCungCap = '" + manhacungcap + "', MaNhanVien = '" + manhanvien + "', TongTien = '" + tongtien + "', NgayXuatHang ='" + ngayxuathang + "' WHERE MaPhieuXuat = '" + maphieuxuat + "'";
            MyClass.execquery(updateQuery);
        }

        private void InsertPhieuNhap(string maphieuxuat, string manhacungcap, string manhanvien, string tongtien, string ngayxuathang)
        {
            string insertQuery = "INSERT INTO XuatHang (MaPhieuXuat,MaNhaCungCap, MaNhanVien, TongTien, NgayXuatHang) VALUES ('" + maphieuxuat + "', '" + manhacungcap + "', '" + manhanvien + "','" + tongtien + "', '" + ngayxuathang + "')";
            MyClass.execquery(insertQuery);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataRow dr = gridView1.GetFocusedDataRow();

            if (dr != null)
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa " + dr["MaPhieuXuat"] + " ra khỏi danh sách phiếu Xuat ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MyClass.execquery("DELETE FROM ChiTietXuatHang WHERE MaPhieuXuat = '" + dr["MaPhieuXuat"] + "'");
                    MyClass.execquery("DELETE FROM XuatHang WHERE MaPhieuXuat = '" + dr["MaPhieuXuat"] + "'");
                }

            }
            loaddata();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim().ToLower(); // Lấy từ khóa tìm kiếm và chuẩn hóa nó

            // Nếu từ khóa không rỗng
            if (!string.IsNullOrEmpty(keyword) && keyword != "tìm kiếm phiếu xuất")
            {
                // Lọc dữ liệu trong GridView dựa trên từ khóa
                gridView1.ActiveFilterString = $"[MaPhieuXuat] LIKE '%{keyword}%' OR [NgayXuatHang] LIKE '%{keyword}%'";
            }
            else if (keyword == "tìm kiếm phiếu xuất")
            {
                gridView1.ActiveFilterString = "";
            }
            else
            {
                // Nếu từ khóa rỗng, xóa bộ lọc để hiển thị tất cả
                gridView1.ActiveFilterString = "";
            }
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Tìm kiếm phiếu xuất")
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = Color.Black;
            }
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                txtTimKiem.Text = "Tìm kiếm phiếu xuất";
                txtTimKiem.ForeColor = Color.Silver;
            }
        }

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            //set cho ngày đặt hàng là ngày giờ hiện tại
            gridView1.SetFocusedRowCellValue("NgayXuatHang", DateTime.Now);
        }
    }
}
