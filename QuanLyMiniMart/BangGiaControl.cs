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
    public partial class BangGiaControl : UserControl
    {
        public BangGiaControl()
        {
            InitializeComponent();
        }

        private void BangGiaControl_Load(object sender, EventArgs e)
        {

            loaddata();
            loadDVT(); 
        }

        void loaddata()
        {
            DataTable dt = MyClass.getData("SELECT G.MaGiaBanSanPham, G.MaSanPham, G.MaDonViTinh, DVT.TenDonViTinh, G.GiaBan, G.NgayApDung FROM GiaSanPham G" +
                                           " JOIN DonViTinh DVT ON G.MaDonViTinh = DVT.MaDonViTinh");
            gridBangGia.DataSource = dt;
        }

        void loadDVT()
        {
            lkDonViTinh.DataSource = MyClass.getData("SELECT * from DonViTinh");
            lkDonViTinh.DisplayMember = "TenDonViTinh";
            lkDonViTinh.ValueMember = "TenDonViTinh";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            bool hasShownWarning = false;


            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRow dr = gridView1.GetDataRow(i);

                if (!string.IsNullOrEmpty(dr["MaSanPham"].ToString()) && !string.IsNullOrEmpty(dr["TenDonViTinh"].ToString())
                    && !string.IsNullOrEmpty(dr["GiaBan"].ToString()) && !string.IsNullOrEmpty(dr["NgayApDung"].ToString()))
                {
                    string magiabansanpham = dr["MaGiaBanSanPham"].ToString();
                    string masanpham = dr["MaSanPham"].ToString();
                    string tendonvitinh = dr["TenDonViTinh"].ToString();
                    string giaban = dr["GiaBan"].ToString();
                    string ngayapdung = dr["NgayApDung"].ToString();

                    string maDonViTinh = TimMaDonViTinhTheoTen(tendonvitinh);


                    if (dr.RowState == DataRowState.Modified)
                    {
                        UpdateBangGia(magiabansanpham, masanpham, maDonViTinh, giaban, ngayapdung);
                    }
                    else if (dr.RowState == DataRowState.Added)
                    {
                        InsertBangGia(masanpham, maDonViTinh, giaban, ngayapdung);
                    }

                }
                else
                {
                    if (!hasShownWarning)
                    {
                        MessageBox.Show("Bạn cần điền đầy đủ thông tin cho giá bán sản phẩm", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        hasShownWarning = true;
                    }
                }
            }

            loaddata();
        }
        private string TimMaDonViTinhTheoTen(string tenDonViTinh)
        {
            string sql = ("SELECT MaDonViTinh FROM DonViTinh WHERE TenDonViTinh = @TenDonViTinh");

            using (SqlConnection conn = Databasehelper.getConnection())
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@TenDonViTinh", tenDonViTinh);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        return result.ToString();
                    }
                }
            }

            return null; // Hoặc một giá trị mặc định nếu không tìm thấy
        }
        private void UpdateBangGia(string magiabansanpham, string masanpham, string madonvitinh, string giaban, string ngayapdung)
        {
            string updateQuery = "UPDATE GiaSanPham SET MaSanPham = '" + masanpham + "',MaDonViTinh = '" + madonvitinh + "',GiaBan = '" + giaban + "',NgayApDung = '" + ngayapdung + "' WHERE MaGiaBanSanPham = '" + magiabansanpham + "'";
            MyClass.execquery(updateQuery);
        }

        private void InsertBangGia(string masanpham, string madonvitinh, string giaban, string ngayapdung)
        {
            string insertQuery = "INSERT INTO GiaSanPham (MaSanPham,MaDonViTinh,GiaBan,NgayApDung) VALUES ('" + masanpham + "','" + madonvitinh + "','" + giaban + "','" + ngayapdung + "')";
            MyClass.execquery(insertQuery);
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataRow dr = gridView1.GetFocusedDataRow();

            if (dr != null)
            {
                string magiabansanpham = dr["MaGiaBanSanPham"].ToString();

                if (IsDVTDangDuocSuDung(magiabansanpham))
                {
                    MessageBox.Show("Không thể xóa giá sản phẩm" + dr["MaSanPham"] + " ngày " + dr["NgayApDung"] + "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (MessageBox.Show("Bạn chắc chắn muốn xóa giá " + dr["MaSanPham"] + " ngày " + dr["NgayApDung"] + " ra khỏi danh sách bảng giá ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        MyClass.execquery("DELETE FROM GiaSanPham WHERE MaGiaBanSanPham = '" + dr["MaGiaBanSanPham"] + "'");


                    }
                }

            }

            loaddata();
        }
        private bool IsDVTDangDuocSuDung(string magiasanpham)
        {
            // Thực hiện truy vấn kiểm tra xem có nhân viên đang sử dụng tài khoản không
            // Sử dụng câu truy vấn phù hợp với cấu trúc dữ liệu của bạn
            string query = "SELECT COUNT(*) FROM SanPham WHERE MaGiaBanSanPham = '" + magiasanpham + "'";
                
            int count = Convert.ToInt32(MyClass.execqueryScalar(query));

            return count > 0;
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
            if (!string.IsNullOrEmpty(keyword) && keyword != "tìm kiếm giá sản phẩm")
            {
                // Lọc dữ liệu trong GridView dựa trên từ khóa
                gridView1.ActiveFilterString = $"[NgayApDung] LIKE '%{keyword}%'OR [MaSanPham] LIKE '%{keyword}%'";
            }
            else if (keyword == "tìm kiếm giá sản phẩm")
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
                txtTimKiem.Text = "Tìm kiếm giá sản phẩm";
                txtTimKiem.ForeColor = Color.Silver;
            }
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Tìm kiếm giá sản phẩm")
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = Color.Black;
            }

        }
    }
}
