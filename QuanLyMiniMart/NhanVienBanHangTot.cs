using DevExpress.XtraReports.UI;
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
    public partial class NhanVienBanHangTot : UserControl
    {
        public NhanVienBanHangTot()
        {
            InitializeComponent();
        }

        private void NhanVienBanHangTot_Load(object sender, EventArgs e)
        {
            // Ngày kết thúc là ngày hiện tại
            DateTime endDate = DateTime.Now.Date;

            // Ngày bắt đầu là 30 ngày trước ngày kết thúc
            DateTime startDate = endDate.AddDays(-30);

            // Đặt giá trị mặc định cho DateTimePicker
            startdate.Value = startDate;
            enddate.Value = endDate;
            loaddata(startDate, endDate);
        }
        void loaddata(DateTime startDateTime, DateTime endDateTime)
        {
           

            DataTable dt = MyClass.getData($@"SELECT 
                                 NhanVien.MaNhanVien,
                                 NhanVien.TenNhanVien,
                                 SUM(HoaDon.TongTienHoaDon) AS TongTien
                                 FROM 
                                    NhanVien
                                 JOIN 
                                    HoaDon ON NhanVien.MaNhanVien = HoaDon.MaNhanVien
                                 WHERE 
                                    HoaDon.NgayXuatHoaDon BETWEEN '{startDateTime}' AND '{endDateTime}'
                                 GROUP BY 
                                     NhanVien.MaNhanVien, NhanVien.TenNhanVien
                                 ORDER BY 
                                 TongTien DESC");

            gridNhanVienBHT.DataSource = dt;
        }

        private void btntienhanh_Click(object sender, EventArgs e)
        {
            DateTime startDate = startdate.Value.Date;
            DateTime endDate = enddate.Value.Date.AddSeconds(86399); // Kết thúc vào 00:00:00 của ngày tiếp theo;
            loaddata(startDate, endDate);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            MyClass.STT.TaoCotSTT(e);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim().ToLower(); // Lấy từ khóa tìm kiếm và chuẩn hóa nó

            // Nếu từ khóa không rỗng
            if (!string.IsNullOrEmpty(keyword) && keyword != "tìm kiếm nhân viên")
            {
                // Sử dụng biểu thức AND để kết hợp nhiều điều kiện tìm kiếm
                gridView1.ActiveFilterString = $"[MaNhanVien] LIKE '%{keyword}%' ";
            }
            else if (keyword == "tìm kiếm nhân viên")
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
                txtTimKiem.Text = "Tìm kiếm nhân viên";
                txtTimKiem.ForeColor = Color.Silver;
            }
        }
        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Tìm kiếm nhân viên")
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
            reportNhanVienTot report = new reportNhanVienTot(dt, ngay);

            // Hiển thị xem trước báo cáo
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

    }
}
