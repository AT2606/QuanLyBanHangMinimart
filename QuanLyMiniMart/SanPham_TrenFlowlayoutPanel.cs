using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyMiniMart
{
    public partial class SanPham_TrenFlowlayoutPanel : UserControl
    {
        public event EventHandler UserControlClicked;
       

        private void OnUserControlClicked()
        {
            // Gọi sự kiện và chuyển thông tin cần thiết
            UserControlClicked?.Invoke(this, EventArgs.Empty);
        }

      
        private void hinhSP_Click(object sender, EventArgs e)
        {
           
        }


        public SanPham_TrenFlowlayoutPanel()
        {
            InitializeComponent();
           
        }

        private void SanPham_TrenFlowlayoutPanel_Click(object sender, EventArgs e)
        {
           
            OnUserControlClicked();
           
        }
    public void SetMaSanPham(string value)
    {
        lbMaSanPham.Text = value;
    }

    public void SetTenSanPham(string value)
    {
        lbTenSanPham.Text = value;
    }
    public void SetNgaySanXuat(string value)
    {
        lbNSX.Text = value;
    }

    public void SetHSD(string value)
    {
        lbHSD.Text = value;
    }
    public void SetSoLuong(int value)
    {
        lbSoLuong.Text = value.ToString("N0");
    }

    public void SetGiaTien(decimal value)
    {
        lbGiaTien.Text = value.ToString("N2");
    }
    public void LoadDataOnFlowLayoutPanel(FlowLayoutPanel flowLayoutPanel)
    {
        using (SqlConnection conn = Databasehelper.getConnection())
        {
            conn.Open();
            string sql = ($@"
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

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        SanPham_TrenFlowlayoutPanel productControl = new SanPham_TrenFlowlayoutPanel();

                        
                        productControl.SetMaSanPham(reader["MaSanPham"].ToString());
                        productControl.SetTenSanPham(reader["TenSanPham"].ToString());
                        productControl.SetNgaySanXuat(reader["NgaySanXuat"].ToString());
                        productControl.SetHSD(reader["HanSuDung"].ToString());
                        productControl.SetSoLuong(Convert.ToInt32(reader["SoLuong"]));
                        productControl.SetGiaTien(Convert.ToDecimal(reader["GiaBan"]));
                        
                        string imagePath = reader["HinhAnh"].ToString();

                       
                        if (!string.IsNullOrEmpty(imagePath))
                        {
                            try
                            {
                                
                                if (File.Exists(imagePath))
                                {
                                    productControl.hinhSP.Image = Image.FromFile(imagePath);

                                }
                                else
                                {
                                    
                                    productControl.hinhSP.Image = null; 
                                }
                            }
                            catch (Exception ex)
                            {
                               
                                Console.WriteLine("Error loading image: " + ex.Message);
                            }
                        }
                        else
                        {
                            // Provide a default image path or handle the absence of an image
                            productControl.hinhSP.Image = Image.FromFile("C:\\Users\\nguye\\source\\repos\\QuanLyMiniMart\\QuanLyMiniMart\\Images\\Profiles\\AnhTrangSP.jpg");
                            // Note: Ensure that the specified default image path is correct and the image file exists.
                        }

                        flowLayoutPanel.Controls.Add(productControl);
                    }
                }
            }
        }
    }
    private void SanPham_TrenFlowlayoutPanel_Load(object sender, EventArgs e)
    {


    }

       
    }
}
