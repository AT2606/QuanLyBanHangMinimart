using DevExpress.Data.Linq.Helpers;
using DevExpress.DataProcessing.InMemoryDataProcessor;
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
    public partial class TaiKhoanControl : UserControl
    {
        public TaiKhoanControl()
        {
            InitializeComponent();
        }

        private void TaiKhoanControl_Load(object sender, EventArgs e)
        {
            loaddata();
            loadlQTC();
        }
        void loaddata()
        {
            DataTable dt = MyClass.getData("SELECT * FROM TaiKhoan");
            gridLoaiSanPham.DataSource = dt;
        }
        void loadlQTC()
        {
            lkQuyenTC.DataSource = MyClass.getData("SELECT * from QuyenTruyCap");
            lkQuyenTC.DisplayMember = "TenQuyenTruyCap";
            lkQuyenTC.ValueMember = "MaQuyenTruyCap";
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool hasShownWarning = false;
            HashSet<string> uniqueCategoryNames = new HashSet<string>();

            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRow dr = gridView1.GetDataRow(i);

                if (!string.IsNullOrEmpty(dr["TenTaiKhoan"].ToString())&& !string.IsNullOrEmpty(dr["TaiKhoan"].ToString())&& !string.IsNullOrEmpty(dr["MatKhau"].ToString())&& !string.IsNullOrEmpty(dr["MaQuyenTruyCap"].ToString()))
                {
                    string mataikhoan = dr["MaTaiKhoan"].ToString();
                    string tentaikhoan = dr["TenTaiKhoan"].ToString();
                    string taikhoan = dr["TaiKhoan"].ToString();
                    string matkhau = dr["MatKhau"].ToString();
                    string quyentruycap = dr["MaQuyenTruyCap"].ToString();
                    string ghichu = dr["GhiChu"].ToString();
                    //Console.WriteLine(dr["MaTaiKhoan"].ToString());

                    if (uniqueCategoryNames.Contains(taikhoan))
                    {
                        MessageBox.Show($"Tên đăng nhập '{taikhoan}' đã có.\nVui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        // You may choose to break here or continue to process the rest of the rows
                    }
                    else
                    {
                        uniqueCategoryNames.Add(taikhoan);

                        if (dr.RowState == DataRowState.Modified)
                        {
                            UpdateTaiKhoan(mataikhoan, tentaikhoan, taikhoan, matkhau, quyentruycap, ghichu);
                        }
                        else if (dr.RowState == DataRowState.Added)
                        {
                            InsertTaiKhoan(tentaikhoan, taikhoan, matkhau, quyentruycap, ghichu);
                        }
                    }
                }
                else
                {
                    if (!hasShownWarning)
                    {
                        MessageBox.Show("Bạn cần điền đủ các thông tin tài tài khoản (*)", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        hasShownWarning = true;
                    }
                }
            }
            loaddata();

        }
        private void UpdateTaiKhoan(string MaTaiKhoan, string TenTaiKhoan, string TaiKhoan, string MatKhau, string QuyenTruyCap, string GhiChu)
        {
            string updateQuery = "UPDATE TaiKhoan SET TenTaiKhoan = N'" + TenTaiKhoan + "', TaiKhoan = N'" + TaiKhoan + "', MatKhau = N'" + MatKhau + "', MaQuyenTruyCap = N'" + QuyenTruyCap + "', GhiChu = N'" + GhiChu + "' WHERE MaTaiKhoan = '" + MaTaiKhoan + "'";
            MyClass.execquery(updateQuery);
        }

        private void InsertTaiKhoan(string TenTaiKhoan, string TaiKhoan, string MatKhau, string QuyenTruyCap, string GhiChu)
        {
            string insertQuery = "INSERT INTO TaiKhoan (TenTaiKhoan, TaiKhoan, MatKhau, MaQuyenTruyCap, GhiChu) VALUES (N'" + TenTaiKhoan + "',N'" + TaiKhoan + "',N'" + MatKhau + "',N'" + QuyenTruyCap + "', N'" + GhiChu + "')";
            MyClass.execquery(insertQuery);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataRow dr = gridView1.GetFocusedDataRow();

            if (dr != null)
            {
                string maTaiKhoan = dr["MaTaiKhoan"].ToString();

                if (IsTaiKhoanDangDuocSuDung(maTaiKhoan))
                {
                    MessageBox.Show("Không thể xóa tài khoản đang được sử dụng bởi nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (MessageBox.Show("Bạn chắc chắn muốn xóa " + dr["TenTaiKhoan"] + " ra khỏi danh sách tài khoản ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        MyClass.execquery("DELETE FROM TaiKhoan WHERE MaTaiKhoan = '" + maTaiKhoan + "'");
                        loaddata();
                    }
                }
            }
        }

        private bool IsTaiKhoanDangDuocSuDung(string maTaiKhoan)
        {
            // Thực hiện truy vấn kiểm tra xem có nhân viên đang sử dụng tài khoản không
            // Sử dụng câu truy vấn phù hợp với cấu trúc dữ liệu của bạn
            string query = "SELECT COUNT(*) FROM NhanVien WHERE MaTaiKhoan = '" + maTaiKhoan + "'";
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
                txtTimKiem.Text = "Tìm kiếm tài khoản";
                txtTimKiem.ForeColor = Color.Silver;
            }
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Tìm kiếm tài khoản")
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = Color.Black;
            }
        }

       
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim().ToLower(); // Lấy từ khóa tìm kiếm và chuẩn hóa nó

            // Nếu từ khóa không rỗng
            if (!string.IsNullOrEmpty(keyword) && keyword != "tìm kiếm tài khoản")
            {
                // Lọc dữ liệu trong GridView dựa trên từ khóa

                gridView1.ActiveFilterString = $"[TenTaiKhoan]  LIKE  '%{keyword}%'";

            }
            else if (keyword == "tìm kiếm tài khoản")
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


