using DevExpress.Xpo.DB.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class frmChiTietHoaDon : DevExpress.XtraEditors.XtraForm
    {
        private object maHoaDon;
        public frmChiTietHoaDon()
        {
            InitializeComponent();
        }
        public frmChiTietHoaDon(object maHoaDon)
        {
            InitializeComponent();
            this.maHoaDon = maHoaDon;
        }
        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {

            loaddata();
        }
        void loaddata()
        {
            string query = "SELECT CTHD.MaHoaDon, CTHD.MaCTHD, CTHD.MaSanPham, SP.TenSanPham, CTHD.SoLuong, CTHD.DonGia, CTHD.ThanhTien,CTHD.NgaySanXuat,CTHD.HanSuDung " +
                           "FROM ChiTietHoaDon CTHD " +
                           "JOIN HoaDon HD ON CTHD.MaHoaDon = HD.MaHoaDon " +
                           "JOIN SanPham SP ON CTHD.MaSanPham = SP.MaSanPham " +
                          
                           "WHERE CTHD.MaHoaDon = @MaHoaDon";

            // Thực hiện truy vấn với mã hóa đơn đã truyền vào
            DataTable dt = MyClass.getData1(query, new SqlParameter("@MaHoaDon", maHoaDon));

            gridCTHD.DataSource = dt;
        }

        private void gridView1_CustomDrawRowIndicator(object sender,RowIndicatorCustomDrawEventArgs e)
        {
            MyClass.STT.TaoCotSTT(e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
