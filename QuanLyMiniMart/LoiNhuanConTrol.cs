using DevExpress.CodeParser;
using DevExpress.Data.Mask.Internal;
using DevExpress.DataProcessing.InMemoryDataProcessor;
using DevExpress.XtraCharts.Native;
using DevExpress.XtraRichEdit.Import.Html;
using DevExpress.XtraRichEdit.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static DevExpress.Xpo.DB.DataStoreLongrunnersWatch;

namespace QuanLyMiniMart
{
    public partial class LoiNhuanConTrol : UserControl
    {
        public LoiNhuanConTrol()
        {
            InitializeComponent();
        }

        private void LoiNhuanConTrol_Load(object sender, EventArgs e)
        {
            // Ngày kết thúc là ngày hiện tại
            DateTime endDate = DateTime.Now.Date;

            // Ngày bắt đầu là 10 ngày trước ngày kết thúc
            DateTime startDate = endDate.AddDays(-10);

            // Đặt giá trị mặc định cho DateTimePicker
            startdate.Value = startDate;
            enddate.Value = endDate;

            // Nếu khoảng cách hợp lệ, thực hiện cập nhật biểu đồ
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "dd/MM";
            chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Font = new Font(chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Font.FontFamily, 12);
            UpdateChartDoanhThu(startDate, endDate);
            UpdateChartChiPhi(startDate, endDate);
            UpdateChartLoiNhuan(startDate, endDate);
            UpdateChartSP(startDate, endDate);
           

            SetChartTitles();
        }
        private void SetChartTitles()
        {
            // Đặt tiêu đề cho biểu đồ 1
            chart1.Titles.Clear();
            Title title1 = new Title("Biểu đồ về doanh thu, chi phí nhập, lợi nhuận bán hàng", Docking.Top, new Font("Arial", 12, FontStyle.Italic), Color.Black);
            chart1.Titles.Add(title1);

            // Đặt tiêu đề cho biểu đồ 2
            chart2.Titles.Clear();
            Title title2 = new Title("Biểu đồ về số lượng sản phẩm bán được trong các ngày qua", Docking.Top, new Font("Arial", 12, FontStyle.Italic), Color.Black);
            chart2.Titles.Add(title2);

            
        }


        private void btntienhanh_Click(object sender, EventArgs e)
        {
            DateTime startDate = startdate.Value.Date;
            DateTime endDate = enddate.Value.Date.AddSeconds(86399); // Kết thúc vào 00:00:00 của ngày tiếp theo;

            // Kiểm tra xem khoảng cách giữa startDate và endDate có quá 10 ngày không
            TimeSpan difference = endDate - startDate;
            int daysDifference = Math.Abs(difference.Days);

            if (daysDifference > 10)
            {
                MessageBox.Show("Khoảng cách không được vượt quá 10 ngày.");
                
            }
            else
            {
                // Nếu khoảng cách hợp lệ, thực hiện cập nhật biểu đồ
                chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
                chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "dd/MM";
                chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Font = new Font(chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Font.FontFamily, 12);
                UpdateChartDoanhThu(startDate, endDate);
                UpdateChartChiPhi(startDate, endDate);
                UpdateChartLoiNhuan(startDate, endDate);
                UpdateChartSP(startDate, endDate);
               

            }
        }

        // doanh thu
        private void UpdateChartDoanhThu(DateTime startDateTime, DateTime endDateTime)
        {
          
            DataTable dt = MyClass.getData($@"SELECT Ngay, SUM(TongTien) AS TongTien
                    FROM(
                    SELECT NgayXuatHoaDon AS Ngay, TongTienHoaDon AS TongTien
                    FROM HoaDon
                    WHERE NgayXuatHoaDon BETWEEN '{startDateTime}' AND '{endDateTime}'
                    UNION ALL
                    SELECT NgayXuatHang AS Ngay, TongTien
                    FROM XuatHang
                    WHERE NgayXuatHang BETWEEN '{startDateTime}' AND '{endDateTime}'
                    ) AS T
                    GROUP BY Ngay");

                // Xóa dòng này nếu bạn muốn thêm vào dữ liệu hiện tại
                chart1.Series["Doanh Thu"].Points.Clear();
                //chart1.Series["Doanh Thu"]["DrawingStyle"] = "cylinder";
                
                foreach (DataRow row in dt.Rows)
                {
                    DateTime ngayXuatHoaDon = Convert.ToDateTime(row["Ngay"]);
                    decimal tongTienHoaDon = Convert.ToDecimal(row["TongTien"]);

                    chart1.Series["Doanh Thu"].Points.AddXY(ngayXuatHoaDon, tongTienHoaDon);              
                }            
        }
        // chi phí nhập hàng cảu từng ngày
        private void UpdateChartChiPhi(DateTime startDateTime, DateTime endDateTime)
        {
            DataTable dt = MyClass.getData($"SELECT NgayNhapHang, SUM(TongTienNhap) as TongTien FROM NhapHang WHERE NgayNhapHang BETWEEN '{startDateTime}' AND '{endDateTime}' GROUP BY NgayNhapHang");
            // Xóa dòng này nếu bạn muốn thêm vào dữ liệu hiện tại
            chart1.Series["Chi Phí Nhập"].Points.Clear();
            //chart1.Series["Chi Phí"]["DrawingStyle"] = "cylinder";
           
            foreach (DataRow row in dt.Rows)
            {
                DateTime ngayXuatHoaDon = Convert.ToDateTime(row["NgayNhapHang"]);
                decimal tongTienHoaDon = Convert.ToDecimal(row["TongTien"]);

                // Thêm điểm trên biểu đồ
                 chart1.Series["Chi Phí Nhập"].Points.AddXY(ngayXuatHoaDon, tongTienHoaDon);

               
            }
        }
        // lợi nhuận
        private void UpdateChartLoiNhuan(DateTime startDateTime, DateTime endDateTime)
        {
            DataTable dt = MyClass.getData($@"SELECT 
                 Ngay,
                 MaSanPham,
                 SUM(SoLuong * (DonGia - DonGiaMua)) AS LoiNhuan
                 FROM (
                 SELECT 
                    HD.NgayXuatHoaDon AS Ngay,
                    CTHD.MaSanPham,
                    CTHD.SoLuong,
                    CTHD.DonGia,
                    PN.DonGiaMua
                 FROM 
                    HoaDon HD  
                 INNER JOIN     
                     ChiTietHoaDon CTHD ON HD.MaHoaDon = CTHD.MaHoaDon
                 INNER JOIN 
                     ChiTietNhapHang PN ON PN.MaSanPham = CTHD.MaSanPham
                WHERE 
                     NgayXuatHoaDon BETWEEN '{startDateTime}' AND '{endDateTime}'   
                  ) AS T
                GROUP BY 
                   Ngay, MaSanPham, SoLuong, DonGia, DonGiaMua");
            // Xóa dòng này nếu bạn muốn thêm vào dữ liệu hiện tại
            chart1.Series["Lợi Nhuận"].Points.Clear();
            //chart1.Series["Lợi Nhuận"]["DrawingStyle"] = "cylinder";
            foreach (DataRow row in dt.Rows)
            {
                DateTime ngayXuatHoaDon = Convert.ToDateTime(row["Ngay"]);
                decimal tongTienHoaDon = Convert.ToDecimal(row["LoiNhuan"]);
                // Thêm điểm trên biểu đồ
               chart1.Series["Lợi Nhuận"].Points.AddXY(ngayXuatHoaDon, tongTienHoaDon);                
            }
        }

        private ToolTip tooltip = new ToolTip();

        private void chart1_MouseMove(object sender, MouseEventArgs e)
        {
            var hitTestResult = chart1.HitTest(e.X, e.Y);

            // Kiểm tra xem có phải là một điểm trên biểu đồ hay không
            if (hitTestResult.ChartElementType == ChartElementType.DataPoint)
            {
                // Lấy giá trị của điểm đó từ mỗi series
                string tooltipText = "";
                foreach (var series in chart1.Series)
                {
                    // Kiểm tra xem chỉ mục có hợp lệ hay không
                    if (hitTestResult.PointIndex >= 0 && hitTestResult.PointIndex < series.Points.Count)
                    {
                        DataPoint dataPoint = series.Points[hitTestResult.PointIndex];
                        tooltipText += $"{series.Name}: {dataPoint.YValues[0]}\n";
                    }
                }

                // Hiển thị thông tin chi tiết trong Tooltip
                tooltip.SetToolTip(chart1, tooltipText);
            }
            else
            {
                // Nếu không phải là điểm trên biểu đồ, ẩn Tooltip
                tooltip.Hide(chart1);
            }
        }
        // biểu đồ tròn về sản phẩm bán được trong các ngày chọn
        private void UpdateChartSP(DateTime startDateTime, DateTime endDateTime)
        {
            DataTable dt = MyClass.getData($@"SELECT 
    CTHD.MaSanPham,
    SUM(CTHD.SoLuong) as SoLuong
FROM 
    HoaDon HD
    INNER JOIN ChiTietHoaDon CTHD ON CTHD.MaHoaDon = HD.MaHoaDon
                                        WHERE 
                                        NgayXuatHoaDon BETWEEN '{startDateTime}' AND '{endDateTime}'
                                        GROUP BY 
                                        CTHD.MaSanPham");

            // Xóa dòng này nếu bạn muốn thêm vào dữ liệu hiện tại
            chart2.Series["Số lượng"].Points.Clear();

            foreach (DataRow row in dt.Rows)
            {
                decimal SoLuong = Convert.ToDecimal(row["SoLuong"]);
                string MaSanPham = row["MaSanPham"].ToString(); // Chuyển đổi thành kiểu dữ liệu phù hợp

                // Thêm điểm trên biểu đồ
                chart2.Series["Số lượng"].Points.AddXY(MaSanPham, SoLuong);
            }
        }

        private void chart2_MouseMove(object sender, MouseEventArgs e)
        {
            var hitTestResult = chart2.HitTest(e.X, e.Y);

            // Kiểm tra xem có phải là một điểm trên biểu đồ hay không
            if (hitTestResult.ChartElementType == ChartElementType.DataPoint)
            {
                // Lấy giá trị của điểm đó từ mỗi series
                string tooltipText = "";
                foreach (var series in chart2.Series)
                {
                    // Kiểm tra xem chỉ mục có hợp lệ hay không
                    if (hitTestResult.PointIndex >= 0 && hitTestResult.PointIndex < series.Points.Count)
                    {
                        DataPoint dataPoint = series.Points[hitTestResult.PointIndex];
                        tooltipText += $"{series.Name}: {dataPoint.YValues[0]}\n";
                    }
                }

                // Hiển thị thông tin chi tiết trong Tooltip
                tooltip.SetToolTip(chart2, tooltipText);
            }
            else
            {
                // Nếu không phải là điểm trên biểu đồ, ẩn Tooltip
                tooltip.Hide(chart2);
            }
          
        }
    }
}
