using DevExpress.Xpo;
using DevExpress.XtraGrid;
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
    public partial class TonKhoControl : UserControl
    {
        public TonKhoControl()
        {
            InitializeComponent();
        }

        private void TonKhoControl_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void loaddata()
        {
            // Lấy ngày hiện tại
            DateTime currentDate = DateTime.Now;

            // Lấy dữ liệu sản phẩm với điều kiện hạn sử dụng gần hết và cộng gộp số lượng
            DataTable dt = MyClass.getData1($@"SELECT
    SP.MaSanPham,
    SP.TenSanPham,
    AD.NgaySanXuat,
    AD.HanSuDung,
    SUM(AD.SoLuong) AS SoLuongTon
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
WHERE
     DateAdd(""d"", 60, GETDATE()) >= AD.HanSuDung
GROUP BY
    SP.MaSanPham, SP.TenSanPham, AD.NgaySanXuat, AD.HanSuDung
HAVING
    SUM(AD.SoLuong) > 0;");  // Thêm điều kiện HAVING để chỉ hiển thị khi số lượng tồn lớn hơn 0


            gridSanPhamTonKho.DataSource = dt;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            MyClass.STT.TaoCotSTT(e);
        }

        private void btnXuat_Click(object sender, EventArgs e)
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
            reportTonKho1 report = new reportTonKho1(dt, ngay, nhanvien);

            // Hiển thị xem trước báo cáo
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }


        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim().ToLower(); // Lấy từ khóa tìm kiếm và chuẩn hóa nó

            // Nếu từ khóa không rỗng
            if (!string.IsNullOrEmpty(keyword) && keyword != "tìm kiếm sản phẩm")
            {
                // Lọc dữ liệu trong GridView dựa trên từ khóa
                gridView1.ActiveFilterString = $"[MaSanPham] LIKE '%{keyword}%' OR [TenSanPham] LIKE '%{keyword}%'";
            }
            else if (keyword == "tìm kiếm sản phẩm")
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
    }
}
