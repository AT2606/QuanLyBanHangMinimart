using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Filtering.Templates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyMiniMart
{
    public partial class frmChiTietPhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmChiTietPhieuNhap()
        {
            InitializeComponent();
        }
        private object maphieunhap;

        public frmChiTietPhieuNhap(object maphieunhap)
        {
            InitializeComponent();
            this.maphieunhap = maphieunhap;
        }

        private void frmChiTietPhieuNhap_Load(object sender, EventArgs e)
        {

            loaddata();
            loadSanPham();
            loadDVT();

        }
        void loaddata()
        {
            string query = "SELECT CTN.MaPhieuNhap, CTN.MaChiTietNhap, CTN.MaSanPham, SP.TenSanPham,CTN.MaDonViTinh, DVT.TenDonViTinh, CTN.SoLuong, CTN.DonGiaMua, CTN.ThanhTien, CTN.NgaySanXuat, CTN.HanSuDung " +
                           "FROM ChiTietNhapHang CTN " +
                           "JOIN NhapHang NH ON CTN.MaPhieuNhap = NH.MaPhieuNhap " +
                           "JOIN SanPham SP ON CTN.MaSanPham = SP.MaSanPham " +
                           "JOIN DonViTinh DVT ON CTN.MaDonViTinh = DVT.MaDonViTinh " +
                           "WHERE CTN.MaPhieuNhap = @MaPhieuNhap";

            // Thực hiện truy vấn với mã hóa đơn đã truyền vào
            DataTable dt = MyClass.getData1(query, new SqlParameter("@MaPhieuNhap", maphieunhap));

            gridCTPN.DataSource = dt;
        }
        void loadSanPham()
        {
            lkIDSanPham.DataSource = MyClass.getData("SELECT * from SanPham");
            lkIDSanPham.DisplayMember = "MaSanPham";
            lkIDSanPham.ValueMember = "MaSanPham";
        }
        void loadDVT()
        {
            lkDonViTinh.DataSource = MyClass.getData("SELECT * from DonViTinh");
            lkDonViTinh.DisplayMember = "TenDonViTinh";
            lkDonViTinh.ValueMember = "TenDonViTinh";
        }
        
        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            MyClass.STT.TaoCotSTT(e);
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool hasShownWarning = false;
            

            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRow dr = gridView1.GetDataRow(i);

                if (!string.IsNullOrEmpty(dr["MaSanPham"].ToString()) && !string.IsNullOrEmpty(dr["TenSanPham"].ToString())
                    && !string.IsNullOrEmpty(dr["TenDonViTinh"].ToString()) && !string.IsNullOrEmpty(dr["SoLuong"].ToString())
                    && !string.IsNullOrEmpty(dr["DonGiaMua"].ToString()) && !string.IsNullOrEmpty(dr["ThanhTien"].ToString())
                    && !string.IsNullOrEmpty(dr["NgaySanXuat"].ToString()) && !string.IsNullOrEmpty(dr["HanSuDung"].ToString()))
                {
                    string maCTPN = dr["MaChiTietNhap"].ToString();
                    string masanpham = dr["MaSanPham"].ToString();
                    string tensanpham = dr["TenSanPham"].ToString();
                    string tenDonViTinh = dr["TenDonViTinh"].ToString();
                    string soluong = dr["SoLuong"].ToString();
                    string dongiamua = dr["DonGiaMua"].ToString();
                    string thanhtien = dr["ThanhTien"].ToString();
                    string ngaysanxuat = dr["NgaySanXuat"].ToString();
                    string hansudung = dr["HanSuDung"].ToString();

                    // Lấy mã đơn vị tính từ tên đơn vị tính
                    string maDonViTinh = TimMaDonViTinhTheoTen(tenDonViTinh);

                    if (dr.RowState == DataRowState.Modified)
                    {
                        UpdateChiTietPhieuNhap(maCTPN, maphieunhap, masanpham, tensanpham, maDonViTinh, soluong, dongiamua, thanhtien, ngaysanxuat, hansudung);
                    }
                    else if (dr.RowState == DataRowState.Added)
                    {
                        InsertChiTietPhieuNhap(maphieunhap, masanpham, tensanpham, maDonViTinh, soluong, dongiamua, thanhtien, ngaysanxuat, hansudung);
                    }
                }

                else if (!hasShownWarning)
                {
                    MessageBox.Show("Bạn cần điền đủ các thông tin của chi tiết phiếu nhập (*)", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    hasShownWarning = true;
                }

            }

            loaddata();
        }

        // Hàm để lấy mã đơn vị tính từ tên đơn vị tính
        private string TimMaDonViTinhTheoTen(string tenDonViTinh)
        {
            string sql = ("SELECT MaDonViTinh FROM DonViTinh WHERE TenDonViTinh = @TenDonViTinh");

            using (SqlConnection conn = Databasehelper.getConnection())
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@TenDonViTinh", tenDonViTinh);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        return result.ToString();
                    }
                }
            }

            return null; // Hoặc một giá trị mặc định nếu không tìm thấy
        }

        private void UpdateChiTietPhieuNhap(string maCTPN, object maphieunhap, string masanpham, string tensanpham, string madvt, string soluong, string dongiamua, string thanhtien, string ngaysanxuat, string hansudung)
        {
            string updateQuery = "UPDATE ChiTietNhapHang SET MaPhieuNhap = '" + maphieunhap + "', MaSanPham = '" + masanpham + "', TenSanPham = N'" + tensanpham + "'" +
                ", MaDonViTinh ='" + madvt + "', SoLuong = '" + soluong + "', DonGiaMua = '" + dongiamua + "', ThanhTien ='" + thanhtien + "'" +
                ", NgaySanXuat = '" + ngaysanxuat + "', HanSuDung = '" + hansudung + "' WHERE MaChiTietNhap = '" + maCTPN + "'";
            MyClass.execquery(updateQuery);
        }

        private void InsertChiTietPhieuNhap(object maphieunhap, string masanpham, string tensanpham, string madvt, string soluong, string dongiamua, string thanhtien, string ngaysanxuat, string hansudung)
        {
            string insertQuery = "INSERT INTO ChiTietNhapHang (MaPhieuNhap, MaSanPham, TenSanPham, MaDonViTinh, SoLuong ,DonGiaMua, ThanhTien, NgaySanXuat ,HanSuDung) VALUES" +
                " ('" + maphieunhap + "', '" + masanpham + "',N'" + tensanpham + "','" + madvt + "', '" + soluong + "'" +
                ", '" + dongiamua + "', '" + thanhtien + "','" + ngaysanxuat + "', '" + hansudung + "')";
            MyClass.execquery(insertQuery);
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {

            DataRow dr = gridView1.GetFocusedDataRow();

            if (dr != null)
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa sản phẩm " + dr["TenSanPham"] + " có mã " + dr["MaSanPham"] + " ra khỏi danh sách phiếu nhập ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MyClass.execquery("DELETE FROM ChiTietNhapHang WHERE MaChiTietNhap = '" + dr["MaChiTietNhap"] + "'");

                }

            }
            loaddata();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "MaSanPham" && e.Value != null)
            {
                string maSanPham = e.Value.ToString();

                // Lấy tên sản phẩm tương ứng từ mã sản phẩm
                string tenSanPham = LayTenSanPhamTheoMa(maSanPham);

                // Cập nhật giá trị cho cột TenSanPham
                gridView1.SetRowCellValue(e.RowHandle, "TenSanPham", tenSanPham);
            }
            if (e.Column.FieldName == "SoLuong" || e.Column.FieldName == "DonGiaMua")
            {
                // Kiểm tra nếu cột "SoLuong" hoặc "DonGiaMua" thay đổi
                UpdateThanhTien(e.RowHandle);
            }
            if (e.Column.FieldName == "HanSuDung")
            {
                DateTime hanSuDung = Convert.ToDateTime(e.Value);
                string tenSanPham = gridView1.GetRowCellValue(e.RowHandle, "MaSanPham").ToString();

                // Kiểm tra nếu hạn sử dụng đã hết hạn so với ngày hiện tại
                if (hanSuDung < DateTime.Now)
                {
                    MessageBox.Show("Sản phẩm đã hết hạn sử dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (hanSuDung < DateTime.Now.AddDays(60))
                {
                    MessageBox.Show("Sản phẩm " + tenSanPham + " quá sát với hạn sử dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void UpdateThanhTien(int rowHandle)
        {
            // Lấy giá trị số lượng và đơn giá từ các cột tương ứng
            decimal soLuong = Convert.ToDecimal(gridView1.GetRowCellValue(rowHandle, "SoLuong"));
            decimal donGia = Convert.ToDecimal(gridView1.GetRowCellValue(rowHandle, "DonGiaMua").ToString() == "" ? 1 : gridView1.GetRowCellValue(rowHandle, "DonGiaMua"));

            // Tính toán giá trị Thành Tiền
            decimal thanhTien = soLuong * donGia;

            // Cập nhật giá trị cho cột "ThanhTien"
            gridView1.SetRowCellValue(rowHandle, "ThanhTien", thanhTien);
        }
        private string LayTenSanPhamTheoMa(string maSanPham)
        {
            // Thực hiện truy vấn để lấy tên sản phẩm từ mã sản phẩm
            string query = $"SELECT TenSanPham FROM SanPham WHERE MaSanPham = '{maSanPham}'";
            object result = MyClass.execqueryScalar(query);

            return result != null ? result.ToString() : string.Empty;
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}