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
    public partial class BaoCaoThongKeConTrol : UserControl
    {
        public BaoCaoThongKeConTrol()
        {
            InitializeComponent();
        }

        private void BaoCaoThongKeConTrol_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            dgvThongKeDoanhThu.CellFormatting += dgvThongKeDoanhThu_CellFormatting;

            //dateStart.Value = DateTime.Now;
            //dateEnd.Value = DateTime.Now;
        }
        private void dgvThongKeDoanhThu_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra cột NgayXuatHoaDon và định dạng lại nếu cần
            if (dgvThongKeDoanhThu.Columns[e.ColumnIndex].Name == "NgayXuatHoaDon" && e.Value != null)
            {
                DateTime ngayXuat = (DateTime)e.Value;
                e.Value = ngayXuat.ToString("dd/MM/yyyy");
                e.FormattingApplied = true;
            }
        }

        private void LoadDataGridView()
        {
            try
            {
                
                DataTable dt = MyClass.getData(@"SELECT 
    CTHD.MaSanPham, 
    SP.TenSanPham, 
    SUM(CTHD.SoLuong) AS SoLuong, 
    CTHD.DonGia, 
    SUM(CTHD.ThanhTien) AS ThanhTien, 
    HD.NgayXuatHoaDon
FROM 
    ChiTietHoaDon CTHD 
    INNER JOIN HoaDon HD ON CTHD.MaHoaDon = HD.MaHoaDon
    INNER JOIN SanPham SP ON CTHD.MaSanPham = SP.MaSanPham
GROUP BY 
    CTHD.MaSanPham, 
    SP.TenSanPham, 
    CTHD.DonGia, 
    HD.NgayXuatHoaDon;");


                dgvThongKeDoanhThu.Columns["MaSanPham"].DataPropertyName = "MaSanPham";
                dgvThongKeDoanhThu.Columns["TenSanPham"].DataPropertyName = "TenSanPham";
                dgvThongKeDoanhThu.Columns["SoLuong"].DataPropertyName = "SoLuong";
                dgvThongKeDoanhThu.Columns["DonGia"].DataPropertyName = "DonGia";
                dgvThongKeDoanhThu.Columns["ThanhTien"].DataPropertyName = "ThanhTien";
                dgvThongKeDoanhThu.Columns["NgayXuatHoaDon"].DataPropertyName = "NgayXuatHoaDon";            
                dgvThongKeDoanhThu.DataSource = dt;

               
                    int totalSoLuong = 0;
                    decimal totalThanhTien = 0;
                    // Duyệt qua các dòng trong DataTable và tính tổng số lượng và tổng thành tiền
                    foreach (DataRow row in dt.Rows)
                    {
                        totalSoLuong += Convert.ToInt32(row["SoLuong"]);
                        totalThanhTien += Convert.ToDecimal(row["ThanhTien"]);
                    }
                    // Hiển thị tổng số lượng và tổng thành tiền trên các TextBox
                    txtTongSLBan.Text = totalSoLuong.ToString("N0");
                    txtTongDoanhThu.Text = totalThanhTien.ToString("N2");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu" + ex.Message);
            }
           
        }
       
        private void btntim_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateStart.Value.Date;
            DateTime endDate = dateEnd.Value.Date.AddSeconds(86399);

           

            

            if (endDate >= startDate)
            {
                DataView dv = ((DataTable)dgvThongKeDoanhThu.DataSource).DefaultView;
                dv.RowFilter = $"NgayXuatHoaDon >= #{startDate}# AND NgayXuatHoaDon <= #{endDate}#";
                
                // Sau khi lọc dữ liệu, tính lại tổng số lượng và tổng thành tiền
                int totalSoLuong = 0;
                decimal totalThanhTien = 0;

                foreach (DataRowView rowView in dv)
                {
                    DataRow row = rowView.Row;
                    totalSoLuong += Convert.ToInt32(row["SoLuong"]);
                    totalThanhTien += Convert.ToDecimal(row["ThanhTien"]);
                }

                // Cập nhật TextBoxs hiển thị tổng số lượng và tổng thành tiền
                txtTongSLBan.Text = totalSoLuong.ToString();
                txtTongDoanhThu.Text = totalThanhTien.ToString("N2");
               
            }
            else
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvThongKeDoanhThu_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {           
                // Hiển thị số thứ tự bắt đầu từ 1
                var index = (e.RowIndex + 1).ToString();
               // Gán giá trị số thứ tự vào cột STT
               dgvThongKeDoanhThu.Rows[e.RowIndex].Cells["STT"].Value = index;
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnXuatPDF_Click(object sender, EventArgs e)
        {

            XuatHD();
        }
        private void XuatHD()
        {
           
            // Tạo DataTable để chứa dữ liệu từ DataGridView
            DataTable dt = new DataTable("dgvHoaDon");

            // Thêm cột vào DataTable tương ứng với cột trong DataGridView
            foreach (DataGridViewColumn col in dgvThongKeDoanhThu.Columns)
            {
                dt.Columns.Add(col.Name);
            }

            // Thêm dữ liệu từ DataGridView vào DataTable
            foreach (DataGridViewRow row in dgvThongKeDoanhThu.Rows)
            {
                DataRow dr = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dr[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dr); // Thêm mỗi hàng vào DataTable trong vòng lặp
            }

            // Lấy giá trị từ Label và textbox
            string startdate = dateStart.Text;
            string enddate = dateEnd.Text;
            
            // Tạo đối tượng reportHD và truyền dữ liệu vào
            reportDoanhThu report = new reportDoanhThu(dt, startdate, enddate);

            // Hiển thị xem trước báo cáo
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }
    }
}
