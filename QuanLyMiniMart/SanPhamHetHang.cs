using DevExpress.XtraReports.UI;
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
    public partial class SanPhamHetHang : UserControl
    {
        public SanPhamHetHang()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {


        }

        private void SanPhamHetHang_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        void loaddata()
        {
            DataTable dt = MyClass.getData1($@"SELECT 
        HetHang.MaSanPham, 
        HetHang.TenSanPham, 
        HetHang.TenDonViTinh, 
        HetHang.TenLoaiSanPham, 
        HetHang.SoLuongCon
    FROM (
        SELECT
            Sp.MaSanPham, 
            Sp.TenSanPham, 
			Sp.SoLuongSanPhamToiThieu,
            DVT.TenDonViTinh, 
            LSP.TenLoaiSanPham, 

            (TotalPn.SoLuongPn - COALESCE(TotalPx.SoLuongPx, 0) - COALESCE(TotalHd.SoLuongHd, 0)) AS SoLuongCon
        FROM 
            SanPham Sp 
	    JOIN LoaiSanPham LSP ON Sp.MaLoaiSanPham = LSP.MaLoaiSanPham 
		
       LEFT JOIN (
            SELECT 
                Hd.MaSanPham, 
                SUM(Hd.SoLuong) AS SoLuongHd
            FROM ChiTietHoaDon Hd
            GROUP BY Hd.MaSanPham
        ) AS TotalHd ON Sp.MaSanPham = TotalHd.MaSanPham 
       
        LEFT JOIN (
            SELECT 
                Pn.MaSanPham,Pn.MaDonViTinh,
                SUM(Pn.SoLuong) AS SoLuongPn
            FROM ChiTietNhapHang Pn
            GROUP BY Pn.MaSanPham,Pn.MaDonViTinh
        ) AS TotalPn ON Sp.MaSanPham = TotalPn.MaSanPham 
		
        LEFT JOIN (
            SELECT 
                Px.MaSanPham, 
                SUM(Px.SoLuong) AS SoLuongPx
            FROM ChiTietXuatHang Px
            GROUP BY Px.MaSanPham
        ) AS TotalPx ON Sp.MaSanPham = TotalPx.MaSanPham 

        JOIN  DonViTinh DVT ON DVT.MaDonViTinh = TotalPn.MaDonViTinh
    ) AS HetHang
	
    WHERE 
        HetHang.SoLuongCon <= HetHang.SoLuongSanPhamToiThieu
    ORDER BY 
        HetHang.MaSanPham;");
        

        gridSanPhamHetHang.DataSource = dt;

        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            MyClass.STT.TaoCotSTT(e);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim().ToLower(); // Lấy từ khóa tìm kiếm và chuẩn hóa nó

            // Nếu từ khóa không rỗng
            if (!string.IsNullOrEmpty(keyword) && keyword != "tìm kiếm sản phẩm")
            {
                // Lọc dữ liệu trong GridView dựa trên từ khóa
                gridView1.ActiveFilterString = $"[TenSanPham] LIKE '%{keyword}%'OR [MaSanPham] LIKE '%{keyword}%'";
            }
            else if(keyword== "tìm kiếm sản phẩm")
            {
                // Nếu từ khóa rỗng, xóa bộ lọc
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
                txtTimKiem.Text = "Tìm kiếm sản phẩm";
                txtTimKiem.ForeColor = Color.Silver;
            }
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Tìm kiếm sản phẩm")
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = Color.Black;
            }
        }

        private void btnXuatPDF_Click(object sender, EventArgs e)
        {


            XuatHD();
        }

        private void XuatHD()
        {
            DataTable dt = new DataTable();

            string ngay = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            string nhanvien = "anhtoi";

            // Thêm cột vào DataTable tương ứng với cột trong GridControl
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in gridView1.Columns)
            {
                dt.Columns.Add(col.FieldName, col.ColumnType); // Sử dụng kiểu dữ liệu cột trong GridView
            }

            // Thêm dữ liệu từ GridControl vào DataTable
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRow dr = dt.NewRow();
                foreach (DevExpress.XtraGrid.Columns.GridColumn col in gridView1.Columns)
                {
                    dr[col.FieldName] = gridView1.GetRowCellValue(i, col);
                }
                dt.Rows.Add(dr);
            }

            // Tạo đối tượng reportHD và truyền dữ liệu vào
            reportHetHang report = new reportHetHang(dt, ngay, nhanvien);

            // Hiển thị xem trước báo cáo
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

    }
}
