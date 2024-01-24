using DevExpress.Charts.Native;
using DevExpress.CodeParser;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraCharts.Native;
using DevExpress.XtraEditors;
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
using System.Web.UI;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyMiniMart
{
    public partial class frmBanHang : DevExpress.XtraEditors.XtraForm
    {
        private SanPham_TrenFlowlayoutPanel SanPhamPanel;
        public frmBanHang()
        {
            InitializeComponent();
            SanPhamPanel = new SanPham_TrenFlowlayoutPanel();
            SanPhamPanel.LoadDataOnFlowLayoutPanel(flowLayoutPanel1);
        }
       
        private void SanPham_TrenFlowlayoutPanel_Click(object sender, EventArgs e)
        {
            if (sender is SanPham_TrenFlowlayoutPanel clickedUserControl)
            {
                // Lấy thông tin từ UserControl
                string maSanPham = clickedUserControl.lbMaSanPham.Text;
                string tenSanPham = clickedUserControl.lbTenSanPham.Text;
                decimal soLuong = 1;
                //soluongkho =Convert.ToInt32( clickedUserControl.lbSoLuong.Text);
                //Console.WriteLine(" so luong kho con",soluongkho);
                string giaBan = clickedUserControl.lbGiaTien.Text;
                string ngaysx = clickedUserControl.lbNSX.Text;
                string HSD = clickedUserControl.lbHSD.Text;
                decimal thanhTien = Convert.ToDecimal(soLuong) * Convert.ToDecimal(giaBan);
                
                // Kiểm tra xem sản phẩm đã tồn tại trong DataGridView chưa
                bool productExists = false;
                foreach (DataGridViewRow row in dgvHoaDon.Rows)
                {
                    if (row.Cells[1].Value != null && row.Cells[1].Value.ToString() == maSanPham)
                    {
                        // Sản phẩm đã tồn tại, cộng thêm 1 vào số lượng
                        decimal existingQuantity = Convert.ToDecimal(row.Cells[3].Value);
                        existingQuantity += 1;
                        row.Cells[3].Value = existingQuantity;

                        // Cập nhật lại thành tiền
                        decimal existingGiaBan = Convert.ToDecimal(row.Cells[4].Value);
                        row.Cells[5].Value = existingQuantity * existingGiaBan;

                        productExists = true;
                        break;
                    }
                }

                // Nếu sản phẩm chưa tồn tại, thêm mới vào DataGridView
                if (!productExists)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvHoaDon);
                    row.Cells[1].Value = maSanPham;
                    row.Cells[2].Value = tenSanPham;
                    row.Cells[3].Value = soLuong;
                    row.Cells[4].Value = giaBan;
                    row.Cells[5].Value = thanhTien;
                    // Định dạng cột thành tiền dạng N2
                    row.Cells[5].Style.Format = "N2";
                    row.Cells[6].Value = ngaysx;
                    row.Cells[7].Value = HSD;
                    //Console.WriteLine("ngay san xuat", ngaysx);
                    dgvHoaDon.Rows.Add(row);
                }
            }
            UpdateTongTien();
        }

        ///////////// thực hiện tìm kiếm khách hàng/////////
        private void txtTenKhachHang_TextChanged(object sender, EventArgs e)
        {
            // Lấy nội dung từ textbox
            string userInput = txtTenKhachHang.Text;

            // Chuyển đổi thành chuỗi in hoa
            string uppercaseInput = userInput.ToUpper();

            // Gán lại giá trị in hoa vào textbox
            txtTenKhachHang.Text = uppercaseInput;

            // Di chuyển con trỏ đến cuối textbox để người dùng không phải nhập lại từ đầu
            txtTenKhachHang.SelectionStart = txtTenKhachHang.Text.Length;
        }


        private void txtTenKhachHang_Leave(object sender, EventArgs e)
        {

            if (txtTenKhachHang.Text == "")
            {
                txtTenKhachHang.Text = "Tên khách hàng";
                txtTenKhachHang.ForeColor = Color.Silver;
            }
        }

        private void txtTenKhachHang_Enter(object sender, EventArgs e)
        {
            if (txtTenKhachHang.Text == "Tên khách hàng" || txtTenKhachHang.Text == "TÊN KHÁCH HÀNG")
            {
                txtTenKhachHang.Text = "";
                txtTenKhachHang.ForeColor = Color.Black;
            }
        }


        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSDT.Text.Trim().ToLower();
            SqlConnection conn = Databasehelper.getConnection();
            conn.Open();

            // Truy vấn để lấy thông tin khách hàng dựa trên số điện thoại
            string query = "SELECT COUNT(*),TenKhachHang FROM KhachHang WHERE SoDienThoai = @SoDienThoai GROUP BY TenKhachHang";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@SoDienThoai", keyword);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read(); // Di chuyển con trỏ đến dòng đầu tiên
                int count = reader.GetInt32(0);
                if (count > 0)
                {
                    //MessageBox.Show("Khách hàng cũ");
                    // Số điện thoại đã tồn tại, lấy tên khách hàng và hiển thị lên TextBox khác
                    string tenKH = reader.GetString(1);
                    txtTenKhachHang.Text = tenKH;
                }
            }

            reader.Close();
            conn.Close();


        }

        private void txtSDT_Leave(object sender, EventArgs e)
        {
            if (txtSDT.Text == "")
            {
                txtSDT.Text = "Số điện thoại";
                txtSDT.ForeColor = Color.Silver;
            }

        }

        private void txtSDT_Enter(object sender, EventArgs e)
        {
            if (txtSDT.Text == "Số điện thoại")
            {
                txtSDT.Text = "";
                txtSDT.ForeColor = Color.Black;
            }
        }
        ////////////////

        ///tìm kiếm sản phẩm trên flolayoutpanel/
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtTimKiem.Text.Trim().ToLower();
            bool isDefaultText = (searchText.Length == 0 || searchText == "tìm kiếm sản phẩm");

            foreach (var item in flowLayoutPanel1.Controls)
            {
                if (item is SanPham_TrenFlowlayoutPanel sanPhamPanel)
                {
                    // Kiểm tra xem liệu lbMaSanPham có chứa chuỗi tìm kiếm hay không
                    bool isVisible = isDefaultText || sanPhamPanel.lbMaSanPham.Text.ToLower().Contains(searchText);

                    // Đặt thuộc tính Visible của SanPham_TrenFlowlayoutPanel tương ứng
                    sanPhamPanel.Visible = isVisible;
                }
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

        //
        private void frmBanHang_Load(object sender, EventArgs e)
        {
            // Đăng ký sự kiện cho các UserControl
            foreach (System.Windows.Forms.Control control in flowLayoutPanel1.Controls)

            {
                if (control is SanPham_TrenFlowlayoutPanel userControl)
                {
                    userControl.UserControlClicked += SanPham_TrenFlowlayoutPanel_Click;
                }
            }
            // lấy tên nhân viên từ đăng nhập
            lbNhanVien.Text = ((frmDangNhap)Application.OpenForms["frmDangNhap"]).tenNhanVien;
            lbmaNhanVien.Text = ((frmDangNhap)Application.OpenForms["frmDangNhap"]).maNhanVien;
            txtTienKhachDua.TextChanged += txtTienKhachDua_TextChanged;

            // Gán thời gian hiện tại vào label lbTime
            TimeLabel();

            // Thiết lập Timer
            Timer timer = new Timer();
            timer.Interval = 100; // Đặt Interval là 0,1 giây
            timer.Tick += Timer_Tick;

            // Bắt đầu Timer
            timer.Start();
            //LaysoluongSP(flowLayoutPanel1);
        }
        private void txtTienKhachDua_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTienKhachDua.Text))
            {
                // Không làm gì cả nếu là chuỗi trống
                return;
            }
            // Kiểm tra xem có thể chuyển đổi thành số không
            if (decimal.TryParse(txtTienKhachDua.Text, out decimal tienKhachDuaValue))
            {
                // Định dạng chuỗi số theo định dạng "N0" (số nguyên không có số thập phân)
                txtTienKhachDua.Text = tienKhachDuaValue.ToString("N0");
            }
            else
            {
                // Xử lý trường hợp không thể chuyển đổi thành số
                MessageBox.Show("Giá trị không hợp lệ");
            }
            txtTienKhachDua.SelectionStart = txtTienKhachDua.Text.Length;
            txtTienKhachDua.SelectionLength = 0;
        }



        private void Timer_Tick(object sender, EventArgs e)
        {
            // Mỗi lần Timer đếm đến, cập nhật lại thời gian hiện tại
            TimeLabel();
            UpdateTienThua();
            UpdateSoThuTu();
        }

        private void TimeLabel()
        {
            lbTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }


        private int soThuTu = 1; // Khởi tạo biến đếm



        private void UpdateTongTien()
        {

            decimal tongTien = 0;

            // Duyệt qua từng dòng trong dgvHoaDon và cộng dồn thành tiền
            foreach (DataGridViewRow row in dgvHoaDon.Rows)
            {
                if (row.Cells["ThanhTien"].Value != null)
                {
                    tongTien += Convert.ToDecimal(row.Cells["ThanhTien"].Value);
                }
            }

            // Hiển thị tổng tiền trong txtTongTien
            txtTongTien.Text = tongTien.ToString("N0"); // "N2" để hiển thị số có hai chữ số sau dấu thập phân
            UpdateTienThua();
        }

        private void UpdateTienThua()
        {
            // Kiểm tra xem có nhập tiền khách đưa hay không
            if (!string.IsNullOrEmpty(txtTienKhachDua.Text))
            {
                decimal tongtien = Convert.ToDecimal(txtTongTien.Text);
                // Lấy số tiền khách đưa từ TextBox
                decimal tienKhachDua = Convert.ToDecimal(txtTienKhachDua.Text);

                // Tính tiền thừa (tiền khách đưa - tổng tiền)
                decimal tienThua = tienKhachDua - tongtien;

                // Hiển thị tiền thừa trong txtTienThua
                txtTienThoi.Text = tienThua.ToString("N0");

            }
            else
            {
                // Nếu không nhập tiền khách đưa, hiển thị 0 trong txtTienThoi
                txtTienThoi.Text = "0";
            }
        }

        private void dgvHoaDon_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            // Kiểm tra xem cột đã kết thúc chỉnh sửa có phải là cột số lượng không
            if (e.ColumnIndex == dgvHoaDon.Columns["SoLuong"].Index)
            {
                // Lấy giá trị mới của ô số lượng
                decimal soLuong = Convert.ToDecimal(dgvHoaDon.Rows[e.RowIndex].Cells["SoLuong"].Value);

                // Lấy giá trị đơn giá từ ô tương ứng
                decimal donGia = Convert.ToDecimal(dgvHoaDon.Rows[e.RowIndex].Cells["GiaBan"].Value);

                // Tính thành tiền và cập nhật lại ô thành tiền
                decimal thanhTien = soLuong * donGia;
                dgvHoaDon.Rows[e.RowIndex].Cells["ThanhTien"].Value = thanhTien.ToString("N2");

                UpdateSoThuTu();
                UpdateTongTien();
            }
            UpdateTongSoLuong();
        }

        private void UpdateSoThuTu()
        {
            // Cập nhật giá trị của cột soThuTu
            for (int i = 0; i < dgvHoaDon.Rows.Count; i++)
            {
                dgvHoaDon.Rows[i].Cells["STT"].Value = (i + 1).ToString();
            }

        }

        private void dgvHoaDon_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Kiểm tra xem có phải là lựa chọn chuột trái không
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                // Lấy tên sản phẩm từ ô cột "TenSanPhamHoaDon"
                string tenSanPham = dgvHoaDon.Rows[e.RowIndex].Cells["TenSanPham"].Value.ToString();

                // Hiển thị hộp thoại xác nhận
                DialogResult result = MessageBox.Show($"Bạn muốn xóa sản phẩm '{tenSanPham}' không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Nếu người dùng chọn "Yes", thực hiện xóa
                if (result == DialogResult.Yes)
                {
                    dgvHoaDon.Rows.RemoveAt(e.RowIndex);

                    // Cập nhật lại tổng tiền
                    UpdateTongTien();
                }
            }
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            dgvHoaDon.Rows.Clear();
            soThuTu = 1;
            // Cập nhật lại tổng tiền
            UpdateTongTien();
        }

        private void btnIN_Click(object sender, EventArgs e)
        {
            XuatHD();
        }
        private void XuatHD()
        {
            UpdateTongSoLuong();

            // Tạo DataTable để chứa dữ liệu từ DataGridView
            DataTable dt = new DataTable("dgvHoaDon");

            // Thêm cột vào DataTable tương ứng với cột trong DataGridView
            foreach (DataGridViewColumn col in dgvHoaDon.Columns)
            {
                dt.Columns.Add(col.Name);
            }

            // Thêm dữ liệu từ DataGridView vào DataTable
            foreach (DataGridViewRow row in dgvHoaDon.Rows)
            {
                DataRow dr = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dr[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dr); // Thêm mỗi hàng vào DataTable trong vòng lặp
            }

            // Lấy giá trị từ Label và textbox
            string ngay = lbTime.Text;
            string tongtien = txtTongTien.Text;
            string tongsl = lbTongSL.Text;
            string nhanvien = lbNhanVien.Text;
            string tenKh = txtTenKhachHang.Text;
            string sdt = txtSDT.Text;
            string tienkhachdua = txtTienKhachDua.Text;
            string tienthua = txtTienThoi.Text;

            // Tạo đối tượng reportHD và truyền dữ liệu vào
            reportHD report = new reportHD(dt, ngay, tongtien, tongsl, nhanvien, tenKh, sdt, tienkhachdua, tienthua);

            // Hiển thị xem trước báo cáo
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }
        private void UpdateTongSoLuong()
        {
            int tongSoLuong = 0;

            foreach (DataGridViewRow row in dgvHoaDon.Rows)
            {
                if (row.Cells["SoLuong"].Value != null)
                {
                    // Kiểm tra và cộng thêm số lượng từ mỗi dòng
                    tongSoLuong += Convert.ToInt32(row.Cells["SoLuong"].Value);
                }
            }
            // Hiển thị tổng số lượng trong lbTongSL.Text
            lbTongSL.Text = tongSoLuong.ToString();
        }
       
        //private void LaysoluongSP()
        //{
        //    SqlConnection conn = Databasehelper.getConnection();
        //    conn.Open();
        //    string sql = ($@"
        //                 SELECT
        //                 SP.MaSanPham,
        //                 SP.TenSanPham, 
        //                 SP.HinhAnh,
        //                 GiaSp.GiaBan,
        //                 AD.NgaySanXuat,
        //                 AD.HanSuDung,
        //                 SUM(AD.SoLuong) AS SoLuong
        //                 FROM
        //                    (
        //                    SELECT MaSanPham, NgaySanXuat, HanSuDung, SoLuong FROM ChiTietNhapHang
        //                    UNION ALL
        //                    SELECT MaSanPham, NgaySanXuat, HanSuDung, -SoLuong FROM ChiTietXuatHang
        //                    UNION ALL
        //                    SELECT MaSanPham, NgaySanXuat, HanSuDung, -SoLuong FROM ChiTietHoaDon
        //                    ) AS AD
        //                JOIN
        //                    SanPham SP ON AD.MaSanPham = SP.MaSanPham
        //                JOIN
        //                    LoaiSanPham LSP ON LSP.MaLoaiSanPham = SP.MaLoaiSanPham
        //                JOIN (
        //                   SELECT Gs.MaSanPham, MAX(Gs.NgayApDung) AS NgayMax
        //                   FROM GiaSanPham Gs
        //                   GROUP BY Gs.MaSanPham
        //                      ) AS GiaMax ON GiaMax.MaSanPham = SP.MaSanPham
        //                JOIN GiaSanPham GiaSp ON GiaSp.MaSanPham = GiaMax.MaSanPham AND GiaSp.NgayApDung = GiaMax.NgayMax
        //               WHERE GiaSp.GiaBan IS NOT NULL 
        //                GROUP BY
        //                SP.MaSanPham, SP.TenSanPham,SP.HinhAnh, AD.NgaySanXuat, AD.HanSuDung, GiaSp.GiaBan, LSP.TenLoaiSanPham
        //                HAVING SUM(AD.SoLuong) > 0;");
        //    using (SqlCommand cmdSL = new SqlCommand(sql, conn))
        //    {
        //        // Thêm các tham số
               
        //        cmdSL.Parameters.AddWithValue("@MaSanPham", masanphamSL);
        //        cmdSL.Parameters.AddWithValue("@SoLuong", Convert.ToInt32(soluongSL));
        //        // Thực hiện câu lệnh SQL
        //        cmdSL.ExecuteNonQuery();


        //    }

        //}
       private void btnThanhToan_Click(object sender, EventArgs e)
        {
            //lưu thông tin khách hàng
            //nếu như sdt khách hàng đó đã có rồi thì chỉ cần lưu lại hóa đơn nếu không thì phải lưu thêm cả khách hàng

            SqlConnection conn = Databasehelper.getConnection();
            conn.Open();
            string sdt = txtSDT.Text;
            int makh = 0;

            // Truy vấn để kiểm tra số điện thoại có tồn tại trong KhachHang hay không
            string query = "SELECT MaKhachHang FROM KhachHang WHERE SoDienThoai = @SoDienThoai";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@SoDienThoai", sdt);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                // Nếu số điện thoại tồn tại, lấy MaKhachHang từ kết quả
                makh = Convert.ToInt32(reader["MaKhachHang"]);
            }
            
            // Đóng reader trước khi thực hiện truy vấn mới
            reader.Close();
           

            DataTable dt = MyClass.getData ($@"
                         SELECT
                         SP.MaSanPham,
                         SP.TenSanPham, 
                         SP.HinhAnh,
                         GiaSp.GiaBan,
                         AD.NgaySanXuat,
                         AD.HanSuDung,
                         SUM(AD.SoLuong) AS SoLuong
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
                        JOIN
                            LoaiSanPham LSP ON LSP.MaLoaiSanPham = SP.MaLoaiSanPham
                        JOIN (
                           SELECT Gs.MaSanPham, MAX(Gs.NgayApDung) AS NgayMax
                           FROM GiaSanPham Gs
                           GROUP BY Gs.MaSanPham
                              ) AS GiaMax ON GiaMax.MaSanPham = SP.MaSanPham
                        JOIN GiaSanPham GiaSp ON GiaSp.MaSanPham = GiaMax.MaSanPham AND GiaSp.NgayApDung = GiaMax.NgayMax
                       WHERE GiaSp.GiaBan IS NOT NULL 
                        GROUP BY
                        SP.MaSanPham, SP.TenSanPham,SP.HinhAnh, AD.NgaySanXuat, AD.HanSuDung, GiaSp.GiaBan, LSP.TenLoaiSanPham
                        HAVING SUM(AD.SoLuong) > 0;");
            
            foreach (DataGridViewRow row in dgvHoaDon.Rows)
            {
                // Trích xuất dữ liệu từ các ô cột
                string maSanPham = row.Cells["MaSanPham"].Value.ToString();
                int soLuong =Convert.ToInt32( row.Cells["SoLuong"].Value.ToString());
                DataRow[] dataRows = dt.Select("MaSanPham ='"+maSanPham+"'");
                if(dataRows.Length > 0){
                    int soluongton = Convert.ToInt32(dataRows[0]["SoLuong"]);
                    if(soLuong > soluongton)
                    {
                       
                        MessageBox.Show("Số lượng trong kho không đủ để bán","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

            }
                if (makh == 0)
            {
                // Nếu MaKhachHang vẫn bằng 0, tức là số điện thoại không tồn tại
                // Thêm mới khách hàng và lấy MaKhachHang từ kết quả
                string tenKH = txtTenKhachHang.Text;
                string insertQuery = "INSERT INTO KhachHang(TenKhachHang, SoDienThoai) OUTPUT INSERTED.MaKhachHang VALUES (@tenkhachhang, @SoDienThoai)";
                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@tenkhachhang", tenKH);
                cmd.Parameters.AddWithValue("@SoDienThoai", sdt);

                makh = (int)cmd.ExecuteScalar();
            }
            DateTime dateTime = DateTime.Now;
            // nếu sdt này mà dã có rồi thì sẽ thêm hóa đơn vào chung với khách hàng đó theo số điện thoại
            string sqlHD = "INSERT INTO HoaDon(MaNhanVien, MaKhachHang, TongTienHoaDon, NgayXuatHoaDon) " +
                 "OUTPUT INSERTED.MaHoaDon " +
                 "VALUES (@MaNhanVien, @MaKhachHang, @TongTienHoaDon, @NgayXuatHoaDon)";
            SqlCommand cmdHD = new SqlCommand(sqlHD, conn);
            cmdHD.Parameters.AddWithValue("@MaNhanVien", lbmaNhanVien.Text.ToString());
            cmdHD.Parameters.AddWithValue("@MaKhachHang", makh);
            cmdHD.Parameters.AddWithValue("@TongTienHoaDon",Convert.ToDecimal( txtTongTien.Text));
            cmdHD.Parameters.AddWithValue("@NgayXuatHoaDon", dateTime);

            // Lấy giá trị MaHoaDon sau khi thêm vào
            int maHoaDon = (int)cmdHD.ExecuteScalar();

            // Tiếp tục xử lý các dữ liệu từ DataGridView
            foreach (DataGridViewRow row in dgvHoaDon.Rows)
            {
                // Trích xuất dữ liệu từ các ô cột
                string maSanPham = row.Cells["MaSanPham"].Value.ToString();
                string soLuong = row.Cells["SoLuong"].Value.ToString();
                string donGia = row.Cells["GiaBan"].Value.ToString();
                string thanhTien = row.Cells["ThanhTien"].Value.ToString();
                string ngaySanXuat = row.Cells["NgaySanXuat"].Value.ToString();
                string hanSuDung = row.Cells["HanSuDung"].Value.ToString();

                // Sử dụng giá trị MaHoaDon ở đây
                Console.WriteLine($"MaHoaDon: {maHoaDon}");

                // Câu lệnh SQL INSERT INTO
                string sqlCTHDHD = "INSERT INTO ChiTietHoaDon(MaHoaDon, MaSanPham, SoLuong, DonGia, ThanhTien, NgaySanXuat, HanSuDung)" +
                    " VALUES (@MaHoaDon, @MaSanPham, @SoLuong, @DonGia, @ThanhTien, @NgaySanXuat, @HanSuDung)";

                using (SqlCommand cmdCTHD = new SqlCommand(sqlCTHDHD, conn))
                {
                    // Thêm các tham số
                    cmdCTHD.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
                    cmdCTHD.Parameters.AddWithValue("@MaSanPham", maSanPham);
                    cmdCTHD.Parameters.AddWithValue("@SoLuong",Convert.ToInt32( soLuong));
                    cmdCTHD.Parameters.AddWithValue("@DonGia", Convert.ToDecimal(donGia));
                    cmdCTHD.Parameters.AddWithValue("@ThanhTien", Convert.ToDecimal( thanhTien));
                    cmdCTHD.Parameters.AddWithValue("@NgaySanXuat", ngaySanXuat);
                    cmdCTHD.Parameters.AddWithValue("@HanSuDung", hanSuDung);

                    // Thực hiện câu lệnh SQL
                    cmdCTHD.ExecuteNonQuery();


                }
            }
            
            // Đóng kết nối
            conn.Close();
           // MessageBox.Show("Thành công");
            XuatHD();
            btnXoaHD_Click(sender, e);
            txtTenKhachHang.Clear();
            txtSDT.Clear();
            txtTienKhachDua.Clear();
            txtTongTien.Clear();

            frmBanHang banHangForm = new frmBanHang();
            banHangForm.Show();  
            this.Hide();
            //flowLayoutPanel1.Controls.Clear();
            //SanPhamPanel = new SanPham_TrenFlowlayoutPanel();
            //SanPhamPanel.LoadDataOnFlowLayoutPanel(flowLayoutPanel1);


        }

    }


}


