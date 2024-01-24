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
    public partial class LoaiSanPhamControl : UserControl
    {
        public LoaiSanPhamControl()
        {
            InitializeComponent();
            
        }

        private void LoaiSanPhamControl_Load(object sender, EventArgs e)
        {
           
            loaddata();
        }

        void loaddata()
        {
            DataTable dt = MyClass.getData("SELECT * FROM LoaiSanPham");
            gridLoaiSanPham.DataSource = dt;           
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool hasShownWarning = false;
            HashSet<string> uniqueCategoryNames = new HashSet<string>();

            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRow dr = gridView1.GetDataRow(i);

                if (!string.IsNullOrEmpty(dr["TenLoaiSanPham"].ToString()))
                {
                    string maLoaiSanPham = dr["MaLoaiSanPham"].ToString();
                    string tenLoaiSanPham = dr["TenLoaiSanPham"].ToString();

                    // Check for duplicate names
                    if (uniqueCategoryNames.Contains(tenLoaiSanPham))
                    {
                        MessageBox.Show($"Tên loại sản phẩm '{tenLoaiSanPham}' bị trùng lặp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        // You may choose to break here or continue to process the rest of the rows
                    }
                    else
                    {
                        uniqueCategoryNames.Add(tenLoaiSanPham);

                        if (dr.RowState == DataRowState.Modified)
                        {
                            UpdateLoaiSanPham(maLoaiSanPham, tenLoaiSanPham);
                        }
                        else if (dr.RowState == DataRowState.Added)
                        {
                            InsertLoaiSanPham(tenLoaiSanPham);
                        }
                    }
                }
                else
                {
                    if (!hasShownWarning)
                    {
                        MessageBox.Show("Bạn cần điền tên loại sản phẩm", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        hasShownWarning = true;
                    }
                }
            }

            loaddata();

        }

        private void UpdateLoaiSanPham(string maLoaiSanPham, string tenLoaiSanPham)
        {
            string updateQuery = "UPDATE LoaiSanPham SET TenLoaiSanPham = N'" + tenLoaiSanPham + "' WHERE MaLoaiSanPham = '" + maLoaiSanPham + "'";
            MyClass.execquery(updateQuery);
        }

        private void InsertLoaiSanPham(string tenLoaiSanPham)
        {
            string insertQuery = "INSERT INTO LoaiSanPham (TenLoaiSanPham) VALUES (N'" + tenLoaiSanPham + "')";
            MyClass.execquery(insertQuery);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            DataRow dr = gridView1.GetFocusedDataRow();

            if (dr != null)
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa " + dr["TenLoaiSanPham"] + " ra khỏi danh sách loại sản phẩm ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MyClass.execquery("DELETE FROM LoaiSanPham WHERE MaLoaiSanPham = '" + dr["MaLoaiSanPham"] + "'");


                }

            }

            loaddata();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                txtTimKiem.Text = "Tìm kiếm loại sản phẩm";
                txtTimKiem.ForeColor = Color.Silver;
            }
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Tìm kiếm loại sản phẩm")
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = Color.Black;
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim().ToLower(); // Lấy từ khóa tìm kiếm và chuẩn hóa nó

            // Nếu từ khóa không rỗng
            if (!string.IsNullOrEmpty(keyword)&& keyword != "tìm kiếm loại sản phẩm")
            {
                // Lọc dữ liệu trong GridView dựa trên từ khóa
                gridView1.ActiveFilterString = $"[TenLoaiSanPham] LIKE '%{keyword}%'";
            }
            else if (keyword == "tìm kiếm loại sản phẩm")
            {
                // Nếu từ khóa rỗng, xóa bộ lọc
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
