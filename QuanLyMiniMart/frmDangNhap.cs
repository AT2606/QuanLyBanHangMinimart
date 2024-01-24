using DevExpress.XtraBars.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyMiniMart
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        private frmMenu frmMenu;
        public frmDangNhap()
        {
            InitializeComponent();
            frmMenu = new frmMenu();
        }
        public string tenNhanVien;
        public string maNhanVien;
        //public void SetNhanVienValue(string value)
        //{
        //    lbNhanVien.Text = value;
        //}
        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = Databasehelper.getConnection();          
            string tk = txtTenDangNhap.Text;
            string mk = txtMatKhau.Text;
            string quyen = "";

            conn.Open();
            string sql = "select Tk.MaTaiKhoan,Nv.MaNhanVien,Nv.TenNhanVien,Tk.TaiKhoan,Tk.MatKhau,Tk.MaQuyenTruyCap from TaiKhoan Tk " +
                         "inner join nhanvien Nv ON Nv.MaTaiKhoan = Tk.MaTaiKhoan where TaiKhoan = @tk and MatKhau = @mk ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@tk", tk);
            cmd.Parameters.AddWithValue("@mk", mk);
            cmd.Parameters.AddWithValue("Quyen", quyen);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                quyen = rdr["MaQuyenTruyCap"].ToString();
                tenNhanVien = rdr["TenNhanVien"].ToString();
                maNhanVien = rdr["MaNhanVien"].ToString();
                // admin
                if (quyen == "1")
                {
                    //MessageBox.Show("Bạn Đang đăng nhập với tài khoản Admin");
                    AccordionControlElement menuBanHang = frmMenu.GetMenuBanHang();
                    if (menuBanHang != null)
                    {
                        menuBanHang.Visible = false;
                    }
                    frmMenu.Show();
                    this.Hide();
                }

                // NHÂN VIÊN BÁN HÀNG
                else if (quyen == "2")
                {
                    AccordionControlElement mngroup = frmMenu.GetMenuBCDT();
                    if (mngroup != null)
                    {
                        mngroup.Visible = false;
                    }
                    AccordionControlElement mnTK = frmMenu.GetMenuTaiKhoan();
                    if (mnTK != null)
                    {
                        mnTK.Visible = false;
                    }
                    AccordionControlElement mnNV = frmMenu.GetMenuNhanVien();
                    if (mnNV != null)
                    {
                        mnNV.Visible = false;
                    }
                    frmMenu.Show();
                    this.Hide();

                }
                // CHỦ CỬA HÀNG
                else if (quyen == "4")
                {

                    frmMenu.Show();
                    this.Hide();
                }

               

               
            }

            else if (string.IsNullOrEmpty(txtTenDangNhap.Text) || string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Tài Khoản hoặc mật khẩu không đúng\n\t Vui lòng nhập lại", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }



        }
        private bool isPasswordVisible = false;
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = '*'; // Ẩn mật khẩu
        }                               
       private void btnPictureeye_Click(object sender, EventArgs e)
        {
            // click
            isPasswordVisible = !isPasswordVisible;

            // Update the PasswordChar based on the flag
            txtMatKhau.PasswordChar = isPasswordVisible ? '\0' : '*';
        }

        private void btnPictureeye_MouseDown(object sender, MouseEventArgs e)
        {

            // Hiển thị mật khẩu khi người dùng giữ chuột trái 
            txtMatKhau.PasswordChar = '\0';
        }

        private void btnPictureeye_MouseUp(object sender, MouseEventArgs e)
        {
            // Ẩn mật khẩu khi người dùng nhả chuột trái 
            txtMatKhau.PasswordChar = '*';


        }
    }
}
