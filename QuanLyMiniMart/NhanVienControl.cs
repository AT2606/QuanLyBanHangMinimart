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
    public partial class NhanVienControl : UserControl
    {
        public NhanVienControl()
        {
            InitializeComponent();
        }

        private void NhanVienControl_Load(object sender, EventArgs e)
        {

            loaddata();
            loadTaiKhoan();

        }
        void loadTaiKhoan()
        {
            lkTaiKhoan.DataSource = MyClass.getData("SELECT * from TaiKhoan");
            lkTaiKhoan.DisplayMember = "MaTaiKhoan";
            lkTaiKhoan.ValueMember = "MaTaiKhoan";
        }
        void loaddata()
        {
            DataTable dt = MyClass.getData("SELECT MaNhanVien, TenNhanVien, ChucVu, CCCD, Luong, SoDienThoai, NgaySinh, DiaChi, NgayKyHopDong,MaTaiKhoan FROM NhanVien");
            gridNhanVien.DataSource = dt;
        }
        
        

        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool hasShownWarning = false;
            HashSet<string> uniqueEmployeeNames = new HashSet<string>();

            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRow dr = gridView1.GetDataRow(i);

                if (!string.IsNullOrEmpty(dr["MaNhanVien"].ToString()) && !string.IsNullOrEmpty(dr["TenNhanVien"].ToString()) && !string.IsNullOrEmpty(dr["ChucVu"].ToString()) 
                    && !string.IsNullOrEmpty(dr["CCCD"].ToString()) && !string.IsNullOrEmpty(dr["Luong"].ToString()) && !string.IsNullOrEmpty(dr["SoDienThoai"].ToString())
                    && !string.IsNullOrEmpty(dr["NgaySinh"].ToString())
                    && !string.IsNullOrEmpty(dr["DiaChi"].ToString()) && !string.IsNullOrEmpty(dr["NgayKyHopDong"].ToString()) && !string.IsNullOrEmpty(dr["MaTaiKhoan"].ToString()))
                {
                    string maNhanVien = dr["MaNhanVien"].ToString();
                    Console.WriteLine("MNV",maNhanVien);
                    string tenNhanVien = dr["TenNhanVien"].ToString();
                    string chucVu = dr["ChucVu"].ToString();
                    string cccd = dr["CCCD"].ToString();
                    decimal luong = Convert.ToDecimal(dr["Luong"]);
                    string soDienThoai = dr["SoDienThoai"].ToString();
                    DateTime ngaySinh = Convert.ToDateTime(dr["NgaySinh"]);
                    string diaChi = dr["DiaChi"].ToString();
                    DateTime ngayKyHopDong = Convert.ToDateTime(dr["NgayKyHopDong"]);
                    string mataikhoan = dr["MaTaiKhoan"].ToString();

                    if (uniqueEmployeeNames.Contains(maNhanVien))
                    {
                        MessageBox.Show($"Nhân viên '{maNhanVien}' đã có.\nVui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        // Bạn có thể chọn dừng tại đây hoặc tiếp tục xử lý các hàng khác
                    }
                    else
                    {
                        uniqueEmployeeNames.Add(tenNhanVien);

                        if (dr.RowState == DataRowState.Modified)
                        {
                            UpdateNhanVien(maNhanVien, tenNhanVien, chucVu, cccd, luong, soDienThoai, ngaySinh, diaChi, ngayKyHopDong,mataikhoan);
                            
                        }
                        else if (dr.RowState == DataRowState.Added)
                        {
                            InsertNhanVien(maNhanVien,tenNhanVien, chucVu, cccd, luong, soDienThoai, ngaySinh, diaChi, ngayKyHopDong,mataikhoan);
                            
                        }
                        
                    }
                }
                else
                {
                    if (!hasShownWarning)
                    {
                        MessageBox.Show("Bạn cần điền đủ các thông tin nhân viên (*)", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        hasShownWarning = true;
                    }
                }
            }
            loaddata();
        }

        private void UpdateNhanVien(string MaNhanVien, string TenNhanVien, string ChucVu, string CCCD, decimal Luong, string SoDienThoai, DateTime NgaySinh, string DiaChi, DateTime NgayKyHopDong,string mataikhoan)
        {
            string updateQuery = "UPDATE NhanVien SET TenNhanVien = N'" + TenNhanVien + "', ChucVu = N'" + ChucVu + "', CCCD = '" + CCCD + "', Luong = " + Luong + ", SoDienThoai = '" + SoDienThoai + "', NgaySinh = '" + NgaySinh + "', DiaChi = N'" + DiaChi + "', NgayKyHopDong = '" + NgayKyHopDong+ "', MaTaiKhoan = '" + mataikhoan + "' WHERE MaNhanVien = '" + MaNhanVien + "'";
            MyClass.execquery(updateQuery);
        }

        private void InsertNhanVien(string MaNhanVien, string TenNhanVien, string ChucVu, string CCCD, decimal Luong, string SoDienThoai, DateTime NgaySinh, string DiaChi, DateTime NgayKyHopDong, string mataikhoan)
        {
            string insertQuery = "INSERT INTO NhanVien (MaNhanVien,TenNhanVien, ChucVu, CCCD, Luong, SoDienThoai, NgaySinh, DiaChi, NgayKyHopDong,MaTaiKhoan) VALUES ('" + MaNhanVien + "',N'" + TenNhanVien + "', N'" + ChucVu + "', '" + CCCD + "', " + Luong + ", '" + SoDienThoai + "', '" + NgaySinh + "', N'" + DiaChi + "', '" + NgayKyHopDong + "', '" + mataikhoan + "')";
            MyClass.execquery(insertQuery);
        }
       
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataRow dr = gridView1.GetFocusedDataRow();

            if (dr != null)
            {
                string maNhanVien = dr["MaNhanVien"].ToString();
               

                if (MessageBox.Show("Bạn chắc chắn muốn xóa " + dr["TenNhanVien"] + " ra khỏi danh sách tài khoản ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                 
                    MyClass.execquery("DELETE FROM NhanVien WHERE MaNhanVien = '" + maNhanVien + "'");
                }
            }

            loaddata();
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gridView1_CustomDrawRowIndicator(object sender,RowIndicatorCustomDrawEventArgs e)
        {
            MyClass.STT.TaoCotSTT(e);
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                txtTimKiem.Text = "Tìm kiếm nhân viên";
                txtTimKiem.ForeColor = Color.Silver;
            }
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Tìm kiếm nhân viên")
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = Color.Black;
            }
        }


        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim().ToLower(); // Lấy từ khóa tìm kiếm và chuẩn hóa nó

            // Nếu từ khóa không rỗng
            if (!string.IsNullOrEmpty(keyword) && keyword != "tìm kiếm nhân viên")
            {
                // Lọc dữ liệu trong GridView dựa trên từ khóa
                gridView1.ActiveFilterString = $"[MaNhanVien]  LIKE '%{keyword}%' OR [CCCD] LIKE '%{keyword}%'";
            }
            else if (keyword == "tìm kiếm nhân viên")
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
