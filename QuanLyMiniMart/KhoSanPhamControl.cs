
using DevExpress.CodeParser;
using DevExpress.Data;
using DevExpress.Office.Utils;
using DevExpress.XtraBars.Docking2010.Views.Widget;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraRichEdit.Painters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QuanLyMiniMart
{
    public partial class KhoSanPhamControl : UserControl
    {
        Dictionary<string, Image> imageCache = new Dictionary<string, Image>(StringComparer.OrdinalIgnoreCase);
        public KhoSanPhamControl()
        {
            InitializeComponent();
            AddUnboundColumn(gridView1);
            
        }

        private void KhoSanPhamControl_Load(object sender, EventArgs e)
        {
           
            loaddata();
            loadLSP();
         
        }
        void loadLSP()
        {
            lkLoaiSp.DataSource = MyClass.getData("SELECT * from LoaiSanPham");
            lkLoaiSp.DisplayMember = "TenLoaiSanPham";
            lkLoaiSp.ValueMember = "MaLoaiSanPham";
        }
        void loaddata()
        {
            DataTable dt = MyClass.getData("SELECT SP.MaSanPham, SP.TenSanPham, SP.MaGiaBanSanPham, G.NgayApDung, G.GiaBan, SP.MaLoaiSanPham, LSP.TenLoaiSanPham, SP.SoLuongSanPhamToiThieu, SP.HinhAnh" +
                                            " FROM SanPham SP" +
                                            " JOIN GiaSanPham G ON SP.MaGiaBanSanPham = G.MaGiaBanSanPham" +
                                            " JOIN LoaiSanPham LSP ON SP.MaLoaiSanPham = LSP.MaLoaiSanPham");
            gridSanPham.DataSource = dt;

        }
        private void gridView1_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            // Kiểm tra nếu ô được click là ô trong cột HinhAnh
            
                // Mở hộp thoại chọn file
                OpenFileDialog opf = new OpenFileDialog();
                opf.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

                if (opf.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn của hình ảnh đã chọn
                    string imagePath = opf.FileName;

                    // Cập nhật giá trị của ô trong cột HinhAnh
                    gridView1.SetRowCellValue(e.RowHandle, "HinhAnh", imagePath);

                    // Hiển thị hình ảnh tại cột Image
                    // Chú ý: Đảm bảo cột Image của GridView có kiểu dữ liệu là Image
                    Image image = Image.FromFile(imagePath);
                    gridView1.SetRowCellValue(e.RowHandle, "Image", image);
                }
            
        }



        private void gridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "Image" && e.IsGetData)
            {
                GridView view = sender as GridView;
                string fileName = view.GetRowCellValue(view.GetRowHandle(e.ListSourceRowIndex), "HinhAnh") as string ?? string.Empty;
                if (!imageCache.ContainsKey(fileName))
                {
                    Image img = GetImage(fileName);
                    imageCache.Add(fileName, img);
                }
                e.Value = imageCache[fileName];
            }
        }
        Image GetImage(string path)
        {

            Image img = null;
            if (File.Exists(path))
                img = Image.FromFile(path);
            else
                img = Image.FromFile(@"C:\Users\nguye\source\repos\QuanLyMiniMart\QuanLyMiniMart\Images\Profiles\AnhTrangSP.jpg");
            return img;
        }
        void AddUnboundColumn(GridView view)
        {
            // Create an unbound column.
            GridColumn colImage = new GridColumn();
            colImage.FieldName = "Image";
            colImage.Caption = "Hình Ảnh";
            colImage.Width = 300;
            colImage.MaxWidth = 500;

            colImage.UnboundType = UnboundColumnType.Object;
            colImage.OptionsColumn.AllowEdit = false;
            colImage.Visible = true;

            // Add the Image column to the grid's Columns coll
            RepositoryItemPictureEdit riPictureEdit = new RepositoryItemPictureEdit();
            riPictureEdit.SizeMode = PictureSizeMode.Zoom;
            colImage.ColumnEdit = riPictureEdit;
            view.Columns.Add(colImage);
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim().ToLower(); // Lấy từ khóa tìm kiếm và chuẩn hóa nó

            // Nếu từ khóa không rỗng
            if (!string.IsNullOrEmpty(keyword) && keyword != "tìm kiếm sản phẩm")
            {
                // Lọc dữ liệu trong GridView dựa trên từ khóa
                gridView1.ActiveFilterString = $"[MaSanPham] LIKE '%{keyword}%' OR [TenSanPham] LIKE '%{keyword}%'";
            }
            else if (keyword == "tìm kiếm sản phẩm")
            {

                gridView1.ActiveFilterString = "";

            }
            else
            {
                // Nếu từ khóa rỗng, xóa bộ lọc
                gridView1.ActiveFilterString = "";
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

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                txtTimKiem.Text = "Tìm kiếm sản phẩm";
                txtTimKiem.ForeColor = Color.Silver;
            }
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            MyClass.STT.TaoCotSTT(e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            bool hasShownWarning = false;
            HashSet<string> uniqueCategoryNames = new HashSet<string>();

            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRow dr = gridView1.GetDataRow(i);

                if (!string.IsNullOrEmpty(dr["MaSanPham"].ToString()) && !string.IsNullOrEmpty(dr["TenSanPham"].ToString())
                    && !string.IsNullOrEmpty(dr["GiaBan"].ToString()) && !string.IsNullOrEmpty(dr["MaLoaiSanPham"].ToString()) && !string.IsNullOrEmpty(dr["SoLuongSanPhamToiThieu"].ToString()))
                {
                    string hinhanh = dr["HinhAnh"].ToString();
                    string masanpham = dr["MaSanPham"].ToString();
                    string tensanpham = dr["TenSanPham"].ToString();
                    string magiabansanpham = dr["MaGiaBanSanPham"].ToString();
                    string giaban = dr["GiaBan"].ToString();
                    string SoLuongSp = dr["SoLuongSanPhamToiThieu"].ToString();
                    string maloaisanpham = dr["MaLoaiSanPham"].ToString();
                    //string tenloaisanpham = dr["TenLoaiSanPham"].ToString();

                    //Console.WriteLine(dr["MaTaiKhoan"].ToString());

                    if (uniqueCategoryNames.Contains(masanpham))
                    {
                        MessageBox.Show($"Mã sản phẩm '{masanpham}' đã có.\nVui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        // You may choose to break here or continue to process the rest of the rows
                    }
                    else
                    {
                        uniqueCategoryNames.Add(masanpham);

                        if (dr.RowState == DataRowState.Modified)
                        {
                            UpdateSp(masanpham, magiabansanpham, tensanpham, maloaisanpham, SoLuongSp, hinhanh);
                        }
                        else if (dr.RowState == DataRowState.Added)
                        {
                            InsertSP(masanpham, magiabansanpham, tensanpham, maloaisanpham, SoLuongSp, hinhanh);
                        }
                    }
                }
                else
                {
                    if (!hasShownWarning)
                    {
                        MessageBox.Show("Bạn cần điền đủ các thông tin của phiếu nhập (*)", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        hasShownWarning = true;
                    }
                }
            }
            loaddata();

        }
        private void UpdateSp(string masanpham, string magiabansanpham, string tensanpham, string maloaisanpham, string SoLuongSp,string hinhanh)
        {
            string updateQuery = "UPDATE SanPham SET MaGiaBanSanPham = '" + magiabansanpham + "', TenSanPham = N'" + tensanpham + "', MaLoaiSanPham = '" + maloaisanpham + "', SoLuongSanPhamToiThieu = N'" + SoLuongSp + "', HinhAnh = N'" + hinhanh + "' WHERE MaSanPham = '" + masanpham + "'";
            MyClass.execquery(updateQuery);
        }

        private void InsertSP(string masanpham, string magiabansanpham, string tensanpham, string maloaisanpham, string SoLuongSp, string hinhanh)
        {
            string insertQuery = "INSERT INTO SanPham (MaSanPham, MaGiaBanSanPham, TenSanPham, MaLoaiSanPham,SoLuongSanPhamToiThieu,HinhAnh) VALUES ('" + masanpham + "', '" + magiabansanpham + "',N'" + tensanpham + "','" + maloaisanpham + "', '" + SoLuongSp + "',N'" + hinhanh + "')";
            MyClass.execquery(insertQuery);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataRow dr = gridView1.GetFocusedDataRow();

            if (dr != null)
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa " + dr["MaSanPham"] + " ra khỏi danh sách phiếu nhập ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    MyClass.execquery("DELETE FROM SanPham WHERE MaSanPham = '" + dr["MaSanPham"] + "'");
                }

            }
            loaddata();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gridView1_CellValueChanged_1(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "MaSanPham")
            {
                string masanpham = gridView1.GetRowCellValue(e.RowHandle, "MaSanPham").ToString();
                double giaban = GetGiaBanFormBangGia(masanpham);
                gridView1.SetRowCellValue(e.RowHandle, "GiaBan", giaban);

                string giabansp = gridView1.GetRowCellValue(e.RowHandle, "GiaBan").ToString();
                double magiabansanpham = GetMaGiaBanSP(masanpham, giabansp);
                gridView1.SetRowCellValue(e.RowHandle, "MaGiaBanSanPham", magiabansanpham);
               
            }

        }
        private double GetMaGiaBanSP(string masanpham, string giabansp)
        {
            string query = "SELECT MaGiaBanSanPham FROM GiaSanPham WHERE MaSanPham = @MaSanPham AND GiaBan = @GiaBan ORDER BY NgayApDung DESC";

            // Kết nối đến cơ sở dữ liệu và thực hiện truy vấn
            using (SqlConnection conn = Databasehelper.getConnection())
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    // Thay thế tham số trong câu truy vấn
                    command.Parameters.AddWithValue("@MaSanPham", masanpham);
                    command.Parameters.AddWithValue("@GiaBan", giabansp);

                    // Thực hiện truy vấn và trả về giá trị
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToDouble(result);
                    }
                }
            }

            return 0;
        }

        public double GetGiaBanFormBangGia(string masanpham)
        {
            // Lấy ngày hiện tại
            DateTime currentDate = DateTime.Now;

            // Lấy giá bán từ mã giá bán sản phẩm mới nhất với cùng mã sản phẩm
            string query = "SELECT TOP 1 GiaBan FROM GiaSanPham WHERE MaSanPham = @MaSanPham AND NgayApDung <= @NgayApDung ORDER BY NgayApDung DESC, MaGiaBanSanPham DESC";

            // Kết nối đến cơ sở dữ liệu và thực hiện truy vấn
            using (SqlConnection conn = Databasehelper.getConnection())
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    // Thay thế tham số trong câu truy vấn
                    command.Parameters.AddWithValue("@MaSanPham", masanpham);
                    command.Parameters.AddWithValue("@NgayApDung", currentDate);

                    // Thực hiện truy vấn và trả về giá trị
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToDouble(result);
                    }
                }
            }

            return 0;
        }

       
    }
}



