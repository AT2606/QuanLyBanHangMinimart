using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace QuanLyMiniMart
{
    public partial class reportKhachHang : DevExpress.XtraReports.UI.XtraReport
    {
        private DataTable dataSource;
        private string ngay;
        public reportKhachHang(DataTable data, string ngay)
        {
            InitializeComponent();
            dataSource = data;
            this.ngay = ngay;
           

            // Gọi hàm để thiết lập dữ liệu
            SetupData();
        }
        private void SetupData()
        {
            lbNgay.Text = ngay;
           

            // Tạo một DataTable mới cho báo cáo
            DataTable reportDataTable = new DataTable();

            // Định nghĩa cột cho DataTable của báo cáo
            reportDataTable.Columns.Add("STT", typeof(int));
            reportDataTable.Columns.Add("TenKhachHang", typeof(string));
            reportDataTable.Columns.Add("SoDienThoai", typeof(string));
            reportDataTable.Columns.Add("TongTienHoaDon", typeof(string));
            reportDataTable.Columns.Add("NgayXuatHoaDon", typeof(string));
            

            if (dataSource.Rows.Count > 0)
            {
                for (int i = 0; i < dataSource.Rows.Count; i++)
                {
                    string tenkh = dataSource.Rows[i]["TenKhachHang"].ToString();
                    string sdt = dataSource.Rows[i]["SoDienThoai"].ToString();
                    string tt = Convert.ToDecimal(dataSource.Rows[i]["TongTienHoaDon"]).ToString("N2");
                    string nxhd = Convert.ToDateTime(dataSource.Rows[i]["NgayXuatHoaDon"]).ToString("dd/MM/yyyy");
                    

                    reportDataTable.Rows.Add(i + 1, tenkh, sdt, tt, nxhd);
                }
            }

            // Gán DataTable của báo cáo làm Nguồn dữ liệu cho báo cáo
            this.DataSource = reportDataTable;

            // Liên kết các điều khiển của báo cáo với các cột dữ liệu
            STT.DataBindings.Add("Text", reportDataTable, "STT");
            TenKhachHang.DataBindings.Add("Text", reportDataTable, "TenKhachHang");
            SoDienThoai.DataBindings.Add("Text", reportDataTable, "SoDienThoai");
            TongTienHoaDon.DataBindings.Add("Text", reportDataTable, "TongTienHoaDon");
            NgayXuatHoaDon.DataBindings.Add("Text", reportDataTable, "NgayXuatHoaDon");
            
            // Gọi phương thức DataBind để cập nhật dữ liệu
            this.DataMember = "DataSource";
            this.CreateDocument();
        }



    }
}
