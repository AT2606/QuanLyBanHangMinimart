using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace QuanLyMiniMart
{
    public partial class reportTonKho1 : DevExpress.XtraReports.UI.XtraReport
    {
        private DataTable dataSource;
        private string ngay;
        private string nhanvien;
        
        public reportTonKho1(DataTable data, string ngay, string nhanvien)
        {
            InitializeComponent();
            dataSource = data;
            this.ngay = ngay;          
            this.nhanvien = nhanvien;
            
            // Gọi hàm để thiết lập dữ liệu
           SetupData();
        }
        private void SetupData()
        {
            lbNgay.Text = ngay;
            lbNhanVien.Text = nhanvien;

            // Tạo một DataTable mới cho báo cáo
            DataTable reportDataTable = new DataTable();

            // Định nghĩa cột cho DataTable của báo cáo
            reportDataTable.Columns.Add("STT", typeof(int));
            reportDataTable.Columns.Add("MaSanPham", typeof(string));
            reportDataTable.Columns.Add("TenSanPham", typeof(string));
            reportDataTable.Columns.Add("SoLuongTon", typeof(string));
            reportDataTable.Columns.Add("NgaySanXuat", typeof(string));
            reportDataTable.Columns.Add("HanSuDung", typeof(string));

            if (dataSource.Rows.Count > 0)
            {
                for (int i = 0; i < dataSource.Rows.Count; i++)
                {
                    string masp = dataSource.Rows[i]["MaSanPham"].ToString();
                    string tensanpham = dataSource.Rows[i]["TenSanPham"].ToString();
                    string sl = Convert.ToDecimal(dataSource.Rows[i]["SoLuongTon"]).ToString("N0");
                    string nsx = Convert.ToDateTime(dataSource.Rows[i]["NgaySanXuat"]).ToString("dd/MM/yyyy");
                    string hsd = Convert.ToDateTime(dataSource.Rows[i]["HanSuDung"]).ToString("dd/MM/yyyy");

                    reportDataTable.Rows.Add(i + 1, masp, tensanpham, sl, nsx, hsd);
                }
            }

            // Gán DataTable của báo cáo làm Nguồn dữ liệu cho báo cáo
            this.DataSource = reportDataTable;

            // Liên kết các điều khiển của báo cáo với các cột dữ liệu
            STT.DataBindings.Add("Text", reportDataTable, "STT");
            MaSanPham.DataBindings.Add("Text", reportDataTable, "MaSanPham");
            TenSanPham.DataBindings.Add("Text", reportDataTable, "TenSanPham");
            SoLuongTon.DataBindings.Add("Text", reportDataTable, "SoLuongTon");
            NgaySanXuat.DataBindings.Add("Text", reportDataTable, "NgaySanXuat");
            HanSuDung.DataBindings.Add("Text", reportDataTable, "HanSuDung");

            // Gọi phương thức DataBind để cập nhật dữ liệu
            this.DataMember = "DataSource";
            this.CreateDocument();
        }


    }
}
