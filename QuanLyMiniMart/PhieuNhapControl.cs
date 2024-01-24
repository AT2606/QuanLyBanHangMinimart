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
    public partial class PhieuNhapControl : UserControl
    {
        public PhieuNhapControl()
        {
            InitializeComponent();
        }

        private void PhieuNhapControl_Load(object sender, EventArgs e)
        {

            loaddata();
            loadlkNhanVien();
            loadlkNCC();
        }
        void loaddata()
        {
            DataTable dt = MyClass.getData("SELECT PN.MaPhieuNhap, NCC.MaNhaCungCap, NCC.TenNhaCungCap, NV.MaNhanVien, NV.TenNhanVien, PN.TongTienNhap, PN.NgayNhapHang " +
                                "FROM NhapHang PN " +
                                "JOIN NhaCungCap NCC ON PN.MaNhaCungCap = NCC.MaNhaCungCap " +
                                "JOIN NhanVien NV ON PN.MaNhanVien = NV.MaNhanVien");

            gridPhieuNhap.DataSource = dt;

        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            MyClass.STT.TaoCotSTT(e);
        }

        private void gridView1_CellValueChanging(object sender,CellValueChangedEventArgs e)
        {

            // Kiểm tra xem giá trị của ô đã thay đổi và ô đang được chọn (checked)
            if (e.Column.FieldName == "ChiTietPhieuNhap" && e.Value != null && (bool)e.Value)
            {
                // Lấy mã hóa đơn từ dòng đang chọn
                object maHoaDon = gridView1.GetRowCellValue(e.RowHandle, "MaPhieuNhap");

                // Hiển thị form ChiTietHoaDon
                ShowChiTietHoaDonForm(maHoaDon);


            }

        }

        private void ShowChiTietHoaDonForm(object maphieunhap)
        {
            // Gọi form ChiTietHoaDon và truyền mã hóa đơn
            frmChiTietPhieuNhap chiTietPhieuNhap = new frmChiTietPhieuNhap(maphieunhap);

            // Hiển thị form ChiTietHoaDon
            chiTietPhieuNhap.Show();
        }
        void loadlkNhanVien()
        {
            lkMaNhanVien.DataSource = MyClass.getData("SELECT * from NhanVien");
            lkMaNhanVien.DisplayMember = "MaNhanVien";            
            lkMaNhanVien.ValueMember = "MaNhanVien";
        }
        void loadlkNCC()
        {
            lkNCC.DataSource = MyClass.getData("SELECT * from NhaCungCap");
            lkNCC.DisplayMember = "MaNhaCungCap";
            lkNCC.ValueMember = "MaNhaCungCap";
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool hasShownWarning = false;
            HashSet<string> uniqueCategoryNames = new HashSet<string>();

            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRow dr = gridView1.GetDataRow(i);

                if (!string.IsNullOrEmpty(dr["MaPhieuNhap"].ToString()) && !string.IsNullOrEmpty(dr["MaNhaCungCap"].ToString()) 
                    && !string.IsNullOrEmpty(dr["MaNhanVien"].ToString()) && !string.IsNullOrEmpty(dr["TongTienNhap"].ToString()) 
                    && !string.IsNullOrEmpty(dr["NgayNhapHang"].ToString()))
                {
                    string maphieunhap = dr["MaPhieuNhap"].ToString();
                    string manhacungcap = dr["MaNhaCungCap"].ToString();
                    string manhanvien = dr["MaNhanVien"].ToString();
                    string tongtiennhap = dr["TongTienNhap"].ToString();
                    string ngaynhaphang = dr["NgayNhapHang"].ToString();

                    //Console.WriteLine(dr["MaTaiKhoan"].ToString());

                    if (uniqueCategoryNames.Contains(maphieunhap))
                    {
                        MessageBox.Show($"Mã phiếu nhập '{maphieunhap}' đã có.\nVui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        // You may choose to break here or continue to process the rest of the rows
                    }
                    else
                    {
                        uniqueCategoryNames.Add(maphieunhap);

                        if (dr.RowState == DataRowState.Modified)
                        {
                            UpdatePhieuNhap(maphieunhap, manhacungcap, manhanvien, tongtiennhap, ngaynhaphang);
                        }
                        else if (dr.RowState == DataRowState.Added)
                        {
                            InsertPhieuNhap(maphieunhap, manhacungcap, manhanvien, tongtiennhap, ngaynhaphang);
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
        private void UpdatePhieuNhap(string maphieunhap, string manhacungcap, string manhanvien, string tongtiennhap, string ngaynhaphang)
        {
            string updateQuery = "UPDATE NhapHang SET MaNhaCungCap = '" + manhacungcap + "', MaNhanVien = '" + manhanvien + "', TongTienNhap = '" + tongtiennhap + "', NgayNhapHang ='" + ngaynhaphang + "' WHERE MaPhieuNhap = '" + maphieunhap + "'";
            MyClass.execquery(updateQuery);
        }

        private void InsertPhieuNhap(string maphieunhap, string manhacungcap, string manhanvien, string tongtiennhap, string ngaynhaphang)
        {
            string insertQuery = "INSERT INTO NhapHang (MaPhieuNhap,MaNhaCungCap, MaNhanVien, TongTienNhap, NgayNhapHang) VALUES ('" + maphieunhap + "', '" + manhacungcap + "', '" + manhanvien + "','" + tongtiennhap + "', '" + ngaynhaphang + "')";
            MyClass.execquery(insertQuery);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataRow dr = gridView1.GetFocusedDataRow();

            if (dr != null)
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa " + dr["MaPhieuNhap"] + " ra khỏi danh sách phiếu nhập ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MyClass.execquery("DELETE FROM ChiTietNhapHang WHERE MaPhieuNhap = '" + dr["MaPhieuNhap"] + "'");
                    MyClass.execquery("DELETE FROM NhapHang WHERE MaPhieuNhap = '" + dr["MaPhieuNhap"] + "'");
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
            if (!string.IsNullOrEmpty(keyword) && keyword != "tìm kiếm phiếu nhập")
            {
                // Lọc dữ liệu trong GridView dựa trên từ khóa
                gridView1.ActiveFilterString = $"[MaPhieuNhap] LIKE '%{keyword}%' OR [NgayNhapHang] LIKE '%{keyword}%'";
            }
            else if (keyword == "tìm kiếm phiếu nhập")
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
            if (txtTimKiem.Text == "Tìm kiếm phiếu nhập")
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = Color.Black;
            }

        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                txtTimKiem.Text = "Tìm kiếm phiếu nhập";
                txtTimKiem.ForeColor = Color.Silver;
            }
        }
        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            //set cho ngày đặt hàng là ngày giờ hiện tại
            gridView1.SetFocusedRowCellValue("NgayNhapHang", DateTime.Now);
        }
    }
}
