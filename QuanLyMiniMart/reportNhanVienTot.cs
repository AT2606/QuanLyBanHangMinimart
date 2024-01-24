using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace QuanLyMiniMart
{
    public partial class reportNhanVienTot : DevExpress.XtraReports.UI.XtraReport
    {
        private DataTable dataSource;
        private string ngay;
        public reportNhanVienTot(DataTable data, string ngay)
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
            reportDataTable.Columns.Add("MaNhanVien", typeof(string));
            reportDataTable.Columns.Add("TenNhanVien", typeof(string));
            reportDataTable.Columns.Add("TongTien", typeof(string));
            

            if (dataSource.Rows.Count > 0)
            {
                for (int i = 0; i < dataSource.Rows.Count; i++)
                {
                    string manv = dataSource.Rows[i]["MaNhanVien"].ToString();
                    string tennv = dataSource.Rows[i]["TenNhanVien"].ToString();
                    string tt = Convert.ToDecimal(dataSource.Rows[i]["TongTien"]).ToString("N2");
                    

                    reportDataTable.Rows.Add(i + 1, manv, tennv, tt);
                }
            }

            // Gán DataTable của báo cáo làm Nguồn dữ liệu cho báo cáo
            this.DataSource = reportDataTable;

            // Liên kết các điều khiển của báo cáo với các cột dữ liệu
            STT.DataBindings.Add("Text", reportDataTable, "STT");
            MaNhanVien.DataBindings.Add("Text", reportDataTable, "MaNhanVien");
            TenNhanVien.DataBindings.Add("Text", reportDataTable, "TenNhanVien");
            TongTien.DataBindings.Add("Text", reportDataTable, "TongTien");
           

        }



    }
}
