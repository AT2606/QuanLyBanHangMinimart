using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
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
using DevExpress.XtraGrid.Views.Grid;


namespace QuanLyMiniMart
{
    public partial class frmChiTietXuatHang : DevExpress.XtraEditors.XtraForm
    {
        public frmChiTietXuatHang()
        {
            InitializeComponent();
        }
        private object maphieuxuat;

        public frmChiTietXuatHang(object maphieuxuat)
        {
            InitializeComponent();
            this.maphieuxuat = maphieuxuat;
        }

        private void frmChiTietXuatHang_Load(object sender, EventArgs e)
        {
            loaddata();
            loadSanPham();
            loadDVT();
        }
        void loaddata()
        {
            string query = "SELECT CTX.MaPhieuXuat, CTX.MaChiTietXuatHang, CTX.MaSanPham, SP.TenSanPham, CTX.MaDonViTinh, DVT.TenDonViTinh, CTX.SoLuong, CTX.DonGiaXuat, CTX.ThanhTien, CTX.NgaySanXuat, CTX.HanSuDung " +
                           "FROM ChiTietXuatHang CTX " +
                           "JOIN XuatHang XH ON CTX.MaPhieuXuat = XH.MaPhieuXuat " +
                           "JOIN SanPham SP ON CTX.MaSanPham = SP.MaSanPham " +
                           "JOIN DonViTinh DVT ON CTX.MaDonViTinh = DVT.MaDonViTinh " +
                           "WHERE CTX.MaPhieuXuat = @MaPhieuXuat";

            // Thực hiện truy vấn với mã hóa đơn đã truyền vào
            DataTable dt = MyClass.getData1(query, new SqlParameter("@MaPhieuXuat", maphieuxuat));

            gridCTPX.DataSource = dt;
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

            DataTable dt = MyClass.getData($@"
                         SELECT
                         SP.MaSanPham,
                         SP.TenSanPham, 
                         SP.HinhAnh,
                         GiaSp.GiaBan,
                         AD.NgaySanXuat,
                         AD.HanSuDung,
                         SUM(AD.SoLuong) AS SoLuong
                         FROM
                            (
                            SELECT MaSanPham, NgaySanXuat, HanSuDung, SoLuong FROM ChiTietNhapHang
                            UNION ALL
                            SELECT MaSanPham, NgaySanXuat, HanSuDung, -SoLuong FROM ChiTietXuatHang
                            UNION ALL
                            SELECT MaSanPham, NgaySanXuat, HanSuDung, -SoLuong FROM ChiTietHoaDon
                            ) AS AD
                        JOIN
                            SanPham SP ON AD.MaSanPham = SP.MaSanPham
                        JOIN
                            LoaiSanPham LSP ON LSP.MaLoaiSanPham = SP.MaLoaiSanPham
                        JOIN (
                           SELECT Gs.MaSanPham, MAX(Gs.NgayApDung) AS NgayMax
                           FROM GiaSanPham Gs
                           GROUP BY Gs.MaSanPham
                              ) AS GiaMax ON GiaMax.MaSanPham = SP.MaSanPham
                        JOIN GiaSanPham GiaSp ON GiaSp.MaSanPham = GiaMax.MaSanPham AND GiaSp.NgayApDung = GiaMax.NgayMax
                       WHERE GiaSp.GiaBan IS NOT NULL 
                        GROUP BY
                        SP.MaSanPham, SP.TenSanPham,SP.HinhAnh, AD.NgaySanXuat, AD.HanSuDung, GiaSp.GiaBan, LSP.TenLoaiSanPham
                        HAVING SUM(AD.SoLuong) > 0;");

            foreach (DevExpress.XtraGrid.Views.Grid.GridView view in gridCTPX.Views)
            {
                for (int i = 0; i < view.DataRowCount; i++)
                {
                    // Trích xuất dữ liệu từ các ô cột
                    string maSanPham = view.GetRowCellValue(i, "MaSanPham").ToString();
                    int soLuong = Convert.ToInt32(view.GetRowCellValue(i, "SoLuong"));

                    DataRow[] dataRows = dt.Select("MaSanPham ='" + maSanPham + "'");
                    if (dataRows.Length > 0)
                    {
                        int soluongton = Convert.ToInt32(dataRows[0]["SoLuong"]);
                        if (soLuong > soluongton)
                        {
                            DevExpress.XtraEditors.XtraMessageBox.Show("Số lượng trong kho không đủ để bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }
            bool hasShownWarning = false;


            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRow dr = gridView1.GetDataRow(i);

                if (!string.IsNullOrEmpty(dr["MaSanPham"].ToString()) && !string.IsNullOrEmpty(dr["TenSanPham"].ToString())
                    && !string.IsNullOrEmpty(dr["TenDonViTinh"].ToString()) && !string.IsNullOrEmpty(dr["SoLuong"].ToString())
                    && !string.IsNullOrEmpty(dr["DonGiaXuat"].ToString()) && !string.IsNullOrEmpty(dr["ThanhTien"].ToString())
                    && !string.IsNullOrEmpty(dr["NgaySanXuat"].ToString()) && !string.IsNullOrEmpty(dr["HanSuDung"].ToString()))
                {
                    string maCTXH = dr["MaChiTietXuatHang"].ToString();
                    string masanpham = dr["MaSanPham"].ToString();
                    string tensanpham = dr["TenSanPham"].ToString();
                    string tenDonViTinh = dr["TenDonViTinh"].ToString();
                    string soluong = dr["SoLuong"].ToString();
                    string dongiaxuat = dr["DonGiaXuat"].ToString();
                    string thanhtien = dr["ThanhTien"].ToString();
                    string ngaysanxuat = dr["NgaySanXuat"].ToString();
                    string hansudung = dr["HanSuDung"].ToString();

                    // Lấy mã đơn vị tính từ tên đơn vị tính
                    string maDonViTinh = TimMaDonViTinhTheoTen(tenDonViTinh);

                    if (dr.RowState == DataRowState.Modified)
                    {
                        UpdateChiTietPhieuXuat(maCTXH, maphieuxuat, masanpham, tensanpham, maDonViTinh, soluong, dongiaxuat, thanhtien, ngaysanxuat, hansudung);
                    }
                    else if (dr.RowState == DataRowState.Added)
                    {
                        InsertChiTietPhieuXuat(maphieuxuat, masanpham, tensanpham, maDonViTinh, soluong, dongiaxuat, thanhtien, ngaysanxuat, hansudung);
                    }
                }

                else if (!hasShownWarning)
                {
                    MessageBox.Show("Bạn cần điền đủ các thông tin của chi tiết phiếu xuất (*)", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
              
        private void UpdateChiTietPhieuXuat(string maCTXH, object maphieuxuat, string masanpham, string tensanpham, string maDonViTinh, string soluong, string dongiaxuat, string thanhtien, string ngaysanxuat, string hansudung)
        {
            string updateQuery = "UPDATE ChiTietXuatHang SET MaPhieuXuat = '" + maphieuxuat + "', MaSanPham = '" + masanpham + "', TenSanPham = N'" + tensanpham + "'" +
                ", MaDonViTinh ='" + maDonViTinh + "', SoLuong = '" + soluong + "', DonGiaXuat = '" + dongiaxuat + "', ThanhTien ='" + thanhtien + "'" +
                ", NgaySanXuat = '" + ngaysanxuat + "', HanSuDung = '" + hansudung + "' WHERE MaChiTietXuatHang = '" + maCTXH + "'";
            MyClass.execquery(updateQuery);
        }

        private void InsertChiTietPhieuXuat( object maphieuxuat, string masanpham, string tensanpham, string maDonViTinh, string soluong, string dongiaxuat, string thanhtien, string ngaysanxuat, string hansudung)
        {
            string insertQuery = "INSERT INTO ChiTietXuatHang (MaPhieuXuat, MaSanPham, TenSanPham, MaDonViTinh, SoLuong ,DonGiaXuat, ThanhTien, NgaySanXuat ,HanSuDung) VALUES" +
                " ('" + maphieuxuat + "', '" + masanpham + "',N'" + tensanpham + "','" + maDonViTinh + "', '" + soluong + "'" +
                ", '" + dongiaxuat + "', '" + thanhtien + "','" + ngaysanxuat + "', '" + hansudung + "')";
            MyClass.execquery(insertQuery);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataRow dr = gridView1.GetFocusedDataRow();

            if (dr != null)
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa sản phẩm " + dr["TenSanPham"] + " có mã " + dr["MaSanPham"] + " ra khỏi danh sách phiếu xuất ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MyClass.execquery("DELETE FROM ChiTietXuatHang WHERE MaChiTietXuatHang = '" + dr["MaChiTietXuatHang"] + "'");

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
            // lấy tên theo mã sản phẩm
            if (e.Column.FieldName == "MaSanPham" && e.Value != null)
            {
                string maSanPham = e.Value.ToString();

                // Lấy tên sản phẩm tương ứng từ mã sản phẩm
                string tenSanPham = LayTenSanPhamTheoMa(maSanPham);

                // Cập nhật giá trị cho cột TenSanPham
                gridView1.SetRowCellValue(e.RowHandle, "TenSanPham", tenSanPham);
            }
            //tính thành tiền
            if (e.Column.FieldName == "SoLuong" || e.Column.FieldName == "DonGiaXuat")
            {
                // Kiểm tra nếu cột "SoLuong" hoặc "DonGiaMua" thay đổi
                UpdateThanhTien(e.RowHandle);
            }
            
            
        }

        private void UpdateThanhTien(int rowHandle)
        {
            // Lấy giá trị số lượng và đơn giá từ các cột tương ứng
            decimal soLuong = Convert.ToDecimal(gridView1.GetRowCellValue(rowHandle, "SoLuong"));
            decimal donGia = Convert.ToDecimal(gridView1.GetRowCellValue(rowHandle, "DonGiaXuat").ToString() == "" ? 1 : gridView1.GetRowCellValue(rowHandle, "DonGiaXuat"));

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


      
    }
}