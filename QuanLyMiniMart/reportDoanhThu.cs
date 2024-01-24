using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace QuanLyMiniMart
{
    public partial class reportDoanhThu : DevExpress.XtraReports.UI.XtraReport
    {
        private DataTable dataSource;
        private string startdate;
        private string endate;
        
        public reportDoanhThu(DataTable data, string startdate, string endate)
        {
            InitializeComponent();
            dataSource = data;
            this.startdate = startdate;
            this.endate = endate;
            

            // Gọi hàm để thiết lập dữ liệu
            SetupData();
        }
        private void SetupData()
        {
           
            lbstartdate.Text = startdate;
            lbenddate.Text = endate;

            // Tạo một DataTable mới cho báo cáo
            DataTable reportDataTable = new DataTable();

            // Định nghĩa cột cho DataTable của báo cáo
            reportDataTable.Columns.Add("STT", typeof(string));
            reportDataTable.Columns.Add("MaSanPham", typeof(string));
            reportDataTable.Columns.Add("TenSanPham", typeof(string));
            reportDataTable.Columns.Add("SoLuong", typeof(string));
            reportDataTable.Columns.Add("DonGia", typeof(string));
            reportDataTable.Columns.Add("ThanhTien", typeof(string));
            reportDataTable.Columns.Add("NgayXuatHoaDon", typeof(string));

            if (dataSource.Rows.Count > 0)
            {
                for (int i = 0; i < dataSource.Rows.Count; i++)
                {
                    // Lấy giá trị từ dataSource
                    string stt = dataSource.Rows[i]["STT"].ToString();
                    string masp = dataSource.Rows[i]["MaSanPham"].ToString();
                    string tensp = dataSource.Rows[i]["TenSanPham"].ToString();
                    string soLuong = Convert.ToDecimal(dataSource.Rows[i]["SoLuong"]).ToString("N0");
                    string donGia = Convert.ToDecimal(dataSource.Rows[i]["DonGia"]).ToString("N2");
                    string thanhTien = Convert.ToDecimal(dataSource.Rows[i]["ThanhTien"]).ToString("N2");
                    string ngayxuathoadon = Convert.ToDateTime(dataSource.Rows[i]["NgayXuatHoaDon"]).ToString("dd/MM/yyyy");




                    // Thêm một dòng mới vào DataTable của báo cáo
                    reportDataTable.Rows.Add(stt, masp, tensp, soLuong, donGia, thanhTien, ngayxuathoadon);
                }
            }

            // Gán DataTable của báo cáo làm Nguồn dữ liệu cho báo cáo
            this.DataSource = reportDataTable;

            // Liên kết các điều khiển của báo cáo với các cột dữ liệu
            STT.DataBindings.Add("Text", reportDataTable, "STT");
            MaSanPham.DataBindings.Add("Text", reportDataTable, "MaSanPham");
            TenSanPham.DataBindings.Add("Text", reportDataTable, "TenSanPham");
            SoLuong.DataBindings.Add("Text", reportDataTable, "SoLuong");
            DonGia.DataBindings.Add("Text", reportDataTable, "DonGia");
            ThanhTien.DataBindings.Add("Text", reportDataTable, "ThanhTien");
            NgayXuatHoaDon.DataBindings.Add("Text", reportDataTable, "NgayXuatHoaDon");
        }



    }
}
