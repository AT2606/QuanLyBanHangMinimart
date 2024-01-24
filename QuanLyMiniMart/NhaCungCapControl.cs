using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyMiniMart
{
    public partial class NhaCungCapControl : UserControl
    {
        public NhaCungCapControl()
        {
            InitializeComponent();
        }

        private void NhaCungCapControl_Load(object sender, EventArgs e)
        {

            loaddata();

        }
        void loaddata()
        {
            DataTable dt = MyClass.getData("SELECT * FROM NhaCungCap");
            gridNCC.DataSource = dt;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            bool hasShownWarning = false;
            HashSet<string> uniqueCategoryNames = new HashSet<string>();

            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRow dr = gridView1.GetDataRow(i);

                if (!string.IsNullOrEmpty(dr["TenNhaCungCap"].ToString()) && !string.IsNullOrEmpty(dr["SoDienThoai"].ToString()) && !string.IsNullOrEmpty(dr["DiaChi"].ToString()))
                {
                    string manhacungcap = dr["MaNhaCungCap"].ToString();
                    string tennhacungcap = dr["TenNhaCungCap"].ToString();
                    string sdt = dr["SoDienThoai"].ToString();
                    string diachi = dr["DiaChi"].ToString();

                    //Console.WriteLine(dr["MaTaiKhoan"].ToString());

                    if (uniqueCategoryNames.Contains(tennhacungcap))
                    {
                        MessageBox.Show($"Tên đăng nhập '{tennhacungcap}' đã có.\nVui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        // You may choose to break here or continue to process the rest of the rows
                    }
                    else
                    {
                        uniqueCategoryNames.Add(tennhacungcap);

                        if (dr.RowState == DataRowState.Modified)
                        {
                            UpdateNCC(manhacungcap, tennhacungcap, sdt, diachi);
                        }
                        else if (dr.RowState == DataRowState.Added)
                        {
                            InsertNCC(tennhacungcap, sdt, diachi);
                        }
                    }
                }
                else
                {
                    if (!hasShownWarning)
                    {
                        MessageBox.Show("Bạn cần điền đủ các thông tin của nhà cung cấp (*)", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        hasShownWarning = true;
                    }
                }
            }
            loaddata();

        }
        private void UpdateNCC(string MaNCC, string TenNCC, string SDT, string DiaChi)
        {
            string updateQuery = "UPDATE NhaCungCap SET TenNhaCungCap = N'" + TenNCC + "', SoDienThoai = '" + SDT + "', DiaChi = N'" + DiaChi + "' WHERE MaNhaCungCap = '" + MaNCC + "'";
            MyClass.execquery(updateQuery);
        }

        private void InsertNCC(string TenNCC, string SDT, string DiaChi)
        {
            string insertQuery = "INSERT INTO NhaCungCap (TenNhaCungCap, SoDienThoai, DiaChi) VALUES (N'" + TenNCC + "', '" + SDT + "', N'" + DiaChi + "')";
            MyClass.execquery(insertQuery);
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataRow dr = gridView1.GetFocusedDataRow();

            if (dr != null)
            {
                string manhacungcap = dr["MaNhaCungCap"].ToString();
                if (IsNCCDangDuocSuDung(manhacungcap))
                {
                    MessageBox.Show("Không thể xóa nhà cung cấp " + dr["TenNhaCungCap"] + " vì đang có sản phẩm của nhà cung cấp tại cửa hàng ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    if (MessageBox.Show("Bạn chắc chắn muốn xóa " + dr["TenNhaCungCap"] + " ra khỏi danh sách nhà cung cấp ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        MyClass.execquery("DELETE FROM NhaCungCap WHERE MaNhaCungCap = '" + dr["MaNhaCungCap"] + "'");


                    }
                }

            }
            loaddata();
        }
        private bool IsNCCDangDuocSuDung(string maNCC)
        {
            // Thực hiện truy vấn kiểm tra xem có nhân viên đang sử dụng tài khoản không
            // Sử dụng câu truy vấn phù hợp với cấu trúc dữ liệu của bạn
            string query = "SELECT COUNT(*) FROM NhapHang WHERE MaNhaCungCap = '" + maNCC + "'";
            int count = Convert.ToInt32(MyClass.execqueryScalar(query));

            // Nếu có ít nhất một nhân viên đang sử dụng tài khoản, trả về true
            return count > 0;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            MyClass.STT.TaoCotSTT(e);
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                txtTimKiem.Text = "Tìm kiếm nhà cung cấp";
                txtTimKiem.ForeColor = Color.Silver;
            }
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Tìm kiếm nhà cung cấp")
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = Color.Black;
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim().ToLower(); // Lấy từ khóa tìm kiếm và chuẩn hóa nó

            // Nếu từ khóa không rỗng
            if (!string.IsNullOrEmpty(keyword) && keyword != "tìm kiếm nhà cung cấp")
            {
                // Lọc dữ liệu trong GridView dựa trên từ khóa
                gridView1.ActiveFilterString = $"[TenNhaCungCap] LIKE '%{keyword}%' OR [SoDienThoai] LIKE '%{keyword}%'";
            }
            else if (keyword == "tìm kiếm nhà cung cấp")
            {
                gridView1.ActiveFilterString = "";
            }
            else
            {
                // Nếu từ khóa rỗng, xóa bộ lọc
                gridView1.ActiveFilterString = "";
            }

        }
    }
}
