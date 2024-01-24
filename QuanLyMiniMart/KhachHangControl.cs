using DevExpress.XtraReports.UI;
using DevExpress.XtraRichEdit.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyMiniMart
{
    public partial class KhachHangControl : UserControl
    {
        public KhachHangControl()
        {
            InitializeComponent();
        }

        private void KhachHangControl_Load(object sender, EventArgs e)
        {
            // Ngày kết thúc là ngày hiện tại
            DateTime endDate = DateTime.Now.Date;

            // Ngày bắt đầu là 10 ngày trước ngày kết thúc
            DateTime startDate = endDate.AddDays(-30);

            // Đặt giá trị mặc định cho DateTimePicker
            startdate.Value = startDate;
            enddate.Value = endDate;
            loaddata(startDate, endDate);

        }
        void loaddata(DateTime startDateTime, DateTime endDateTime)
        {
           
            DataTable dt = MyClass.getData($@"SELECT 
                      Kh.TenKhachHang, 
                      Kh.SoDienThoai, 
                      SUM(Hd.TongTienHoaDon) AS TongTienHoaDon,
                      MAX(Hd.NgayXuatHoaDon) AS NgayXuatHoaDon
                    FROM 
                        KhachHang Kh
                    JOIN 
                        HoaDon Hd ON Kh.MaKhachHang = Hd.MaKhachHang
                    WHERE 
                        Hd.NgayXuatHoaDon BETWEEN '{startDateTime}' AND '{endDateTime}'
                  GROUP BY 
                        Kh.TenKhachHang, Kh.SoDienThoai
                  ORDER BY 
                        TongTienHoaDon DESC");

            gridKhachHang.DataSource = dt;
        }

       

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim().ToLower(); // Lấy từ khóa tìm kiếm và chuẩn hóa nó

            // Nếu từ khóa không rỗng
            if (!string.IsNullOrEmpty(keyword) && keyword != "tìm kiếm khách hàng")
            {
                // Sử dụng biểu thức AND để kết hợp nhiều điều kiện tìm kiếm
                gridView1.ActiveFilterString = $"[SoDienThoai] LIKE '%{keyword}%' OR [TenKhachHang] LIKE '%{keyword}%'";
            }
            else if (keyword == "tìm kiếm khách hàng")
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
                txtTimKiem.Text = "Tìm kiếm khách hàng";
                txtTimKiem.ForeColor = Color.Silver;
            }
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Tìm kiếm khách hàng")
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = Color.Black;
            }

        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            MyClass.STT.TaoCotSTT(e);
        }

        private void btntienhanh_Click(object sender, EventArgs e)
        {

            DateTime startDate = startdate.Value.Date;
            DateTime endDate = enddate.Value.Date.AddSeconds(86399); // Kết thúc vào 00:00:00 của ngày tiếp theo;
            loaddata(startDate, endDate);
        }

        private void btnXuatPDF_Click(object sender, EventArgs e)
        {

            XuatHD();
        }

        private void XuatHD()
        {
            DataTable dt = new DataTable();

            string ngay = DateTime.Now.ToString("dd/MM/yyyy");
            

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
            reportKhachHang report = new reportKhachHang(dt, ngay);

            // Hiển thị xem trước báo cáo
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }
    }
}
