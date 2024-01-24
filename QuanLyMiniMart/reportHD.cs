using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace QuanLyMiniMart
{
    public partial class reportHD : DevExpress.XtraReports.UI.XtraReport
    {
        private DataTable dataSource;
        private string ngay;
        private string tongtien;
        private string tongsl;
        private string nhanvien;
        private string tenkh;
        private string sdt;
        private string tienkhachdua;
        private string tienthua;
        public reportHD(DataTable data, string ngay,string tongtien, string tongsl, string nhanvien, string tenkh, string sdt,string tienkhachdua,string tienthua)
        {
            InitializeComponent();
            dataSource = data;
            this.ngay = ngay;
            this.tongtien = tongtien;
            this.tongsl = tongsl;
            this.nhanvien = nhanvien; 
            this.tenkh = tenkh;
            this.sdt = sdt;
            this.tienkhachdua = tienkhachdua;
            this.tienthua = tienthua;
            
            // Gọi hàm để thiết lập dữ liệu
            SetupData();
        }
        private void SetupData()
        {
            lbNgay.Text = ngay;
            TongSL.Text = tongsl;
            TongTien.Text = tongtien;
            lbNhanVien.Text = nhanvien;
            lbTenKhachHang.Text = tenkh;
            lbSDT.Text = sdt;
            TienKhachDua.Text = tienkhachdua;
            TienThua.Text = tienthua;

            // Tạo một DataTable mới cho báo cáo
            DataTable reportDataTable = new DataTable();

            // Định nghĩa cột cho DataTable của báo cáo
            reportDataTable.Columns.Add("STT", typeof(string));
            reportDataTable.Columns.Add("TenSanPham", typeof(string));
            reportDataTable.Columns.Add("SoLuong", typeof(string));
            reportDataTable.Columns.Add("GiaBan", typeof(string));
            reportDataTable.Columns.Add("ThanhTien", typeof(string));

            if (dataSource.Rows.Count > 0)
            {
                for (int i = 0; i < dataSource.Rows.Count; i++)
                {
                    // Lấy giá trị từ dataSource
                    string stt = dataSource.Rows[i]["STT"].ToString();
                    string tenSP = dataSource.Rows[i]["TenSanPham"].ToString();
                    string soLuong = Convert.ToDecimal(dataSource.Rows[i]["SoLuong"]).ToString("N0");
                    string donGia = Convert.ToDecimal(dataSource.Rows[i]["GiaBan"]).ToString("N0");
                    string thanhTien = Convert.ToDecimal(dataSource.Rows[i]["ThanhTien"]).ToString("N0");

                    // Thêm một dòng mới vào DataTable của báo cáo
                    reportDataTable.Rows.Add(stt, tenSP, soLuong, donGia, thanhTien);
                }
            }

            // Gán DataTable của báo cáo làm Nguồn dữ liệu cho báo cáo
            this.DataSource = reportDataTable;

            // Liên kết các điều khiển của báo cáo với các cột dữ liệu
            STT.DataBindings.Add("Text", reportDataTable, "STT");
            TenSanPham.DataBindings.Add("Text", reportDataTable, "TenSanPham");
            SoLuong.DataBindings.Add("Text", reportDataTable, "SoLuong");
            DonGia.DataBindings.Add("Text", reportDataTable, "GiaBan");
            ThanhTien.DataBindings.Add("Text", reportDataTable, "ThanhTien");
        }


    }
}
