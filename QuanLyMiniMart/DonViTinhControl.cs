using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace QuanLyMiniMart
{
    public partial class DonViTinhControl : UserControl
    {
        public DonViTinhControl()
        {
            InitializeComponent();

        }
        private void DonViTinhControl_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        void loaddata()
        {
            DataTable dt = MyClass.getData("SELECT * FROM DonViTinh");
            gridDVTSanPham.DataSource = dt;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool hasShownWarning = false;
            HashSet<string> uniqueCategoryNames = new HashSet<string>();

            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRow dr = gridView1.GetDataRow(i);

                if (!string.IsNullOrEmpty(dr["TenDonViTinh"].ToString()))
                {
                    string madonvitinh = dr["MaDonViTinh"].ToString();
                    string tendonvitinh = dr["TenDonViTinh"].ToString();
                    string ghichu = dr["GhiChu"].ToString();

                    // Check for duplicate names
                    if (uniqueCategoryNames.Contains(tendonvitinh))
                    {
                        MessageBox.Show($"Tên đơn vị tính '{tendonvitinh}' bị trùng lặp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        // You may choose to break here or continue to process the rest of the rows
                    }
                    else
                    {
                        uniqueCategoryNames.Add(tendonvitinh);

                        if (dr.RowState == DataRowState.Modified)
                        {
                            UpdateDVT(madonvitinh, tendonvitinh,ghichu);
                        }
                        else if (dr.RowState == DataRowState.Added)
                        {
                            InsertDVT(tendonvitinh,ghichu);
                        }
                    }
                }
                else
                {
                    if (!hasShownWarning)
                    {
                        MessageBox.Show("Bạn cần điền đơn vị tính", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        hasShownWarning = true;
                    }
                }
            }

            loaddata();
        }
       
        private void UpdateDVT(string MaDVT, string TenDVT,string ghichu)
        {
            string updateQuery = "UPDATE DonViTinh SET TenDonViTinh = N'" + TenDVT + "',GhiChu = N'" + ghichu + "' WHERE MaDonViTinh = '" + MaDVT + "'";
            MyClass.execquery(updateQuery);
        }

        private void InsertDVT(string TenDVT,string ghichu)
        {
            string insertQuery = "INSERT INTO DonViTinh (TenDonViTinh,GhiChu) VALUES (N'" + TenDVT + "',N'" + ghichu + "')";
            MyClass.execquery(insertQuery);
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataRow dr = gridView1.GetFocusedDataRow();

            if (dr != null)
            {
                string maTaiKhoan = dr["MaDonViTinh"].ToString();

                if (IsDVTDangDuocSuDung(maTaiKhoan))
                {
                    MessageBox.Show("Không thể xóa" + dr["TenDonViTinh"] + "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (MessageBox.Show("Bạn chắc chắn muốn xóa " + dr["TenDonViTinh"] + " ra khỏi danh sách đơn vị tính ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        MyClass.execquery("DELETE FROM DonViTinh WHERE MaDonViTinh = '" + dr["MaDonViTinh"] + "'");


                    }
                }

            }

            loaddata();
        }
        private bool IsDVTDangDuocSuDung(string madonvitinh)
        {
            // Thực hiện truy vấn kiểm tra xem có nhân viên đang sử dụng tài khoản không
            // Sử dụng câu truy vấn phù hợp với cấu trúc dữ liệu của bạn
            string query = "SELECT COUNT(*) FROM ChiTietNhapHang, ChiTietXuatHang, ChiTietHoaDon, SanPham, GiaSanPham " +
                "WHERE ChiTietNhapHang.MaDonViTinh = '" + madonvitinh + "' " +
                "AND ChiTietXuatHang.MaDonViTinh = '" + madonvitinh + "' " +
                "AND ChiTietHoaDon.MaDonViTinh = '" + madonvitinh + "' " +
                "AND SanPham.MaDonViTinh = '" + madonvitinh + "' " +
                "AND GiaSanPham.MaDonViTinh = '" + madonvitinh + "'";

            int count = Convert.ToInt32(MyClass.execqueryScalar(query));

            return count > 0;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                txtTimKiem.Text = "Tìm kiếm đơn vị tính";
                txtTimKiem.ForeColor = Color.Silver;
            }
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Tìm kiếm đơn vị tính")
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = Color.Black;
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim().ToLower(); // Lấy từ khóa tìm kiếm và chuẩn hóa nó

            // Nếu từ khóa không rỗng
            if (!string.IsNullOrEmpty(keyword) && keyword != "tìm kiếm đơn vị tính")
            {
                // Lọc dữ liệu trong GridView dựa trên từ khóa
                gridView1.ActiveFilterString = $"[TenDonViTinh] LIKE '%{keyword}%'";
            }
            else if (keyword == "tìm kiếm đơn vị tính")
            {
                gridView1.ActiveFilterString = "";
            }
            else
            {
                // Nếu từ khóa rỗng, xóa bộ lọc
                gridView1.ActiveFilterString = "";
            }
        }

        private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            MyClass.STT.TaoCotSTT(e);
        }
    }
}
