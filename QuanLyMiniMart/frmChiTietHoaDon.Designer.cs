namespace QuanLyMiniMart
{
    partial class frmChiTietHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTietHoaDon));
            this.gridCTHD = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CustomSLHD = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.DonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CUstomDLHD = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.ThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgaySanXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HanSuDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnInBu = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridCTHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomSLHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CUstomDLHD)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCTHD
            // 
            this.gridCTHD.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridCTHD.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridCTHD.Location = new System.Drawing.Point(0, 0);
            this.gridCTHD.MainView = this.gridView1;
            this.gridCTHD.Margin = new System.Windows.Forms.Padding(4);
            this.gridCTHD.Name = "gridCTHD";
            this.gridCTHD.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.CustomSLHD,
            this.CUstomDLHD});
            this.gridCTHD.Size = new System.Drawing.Size(1306, 451);
            this.gridCTHD.TabIndex = 0;
            this.gridCTHD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaSanPham,
            this.TenSanPham,
            this.SoLuong,
            this.DonGia,
            this.ThanhTien,
            this.NgaySanXuat,
            this.HanSuDung});
            this.gridView1.DetailHeight = 437;
            this.gridView1.GridControl = this.gridCTHD;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            // 
            // MaSanPham
            // 
            this.MaSanPham.Caption = "ID";
            this.MaSanPham.FieldName = "MaSanPham";
            this.MaSanPham.MinWidth = 31;
            this.MaSanPham.Name = "MaSanPham";
            this.MaSanPham.Visible = true;
            this.MaSanPham.VisibleIndex = 0;
            this.MaSanPham.Width = 189;
            // 
            // TenSanPham
            // 
            this.TenSanPham.Caption = "TÊN SẢN PHẨM";
            this.TenSanPham.FieldName = "TenSanPham";
            this.TenSanPham.MinWidth = 31;
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.Visible = true;
            this.TenSanPham.VisibleIndex = 1;
            this.TenSanPham.Width = 234;
            // 
            // SoLuong
            // 
            this.SoLuong.Caption = "SỐ LƯỢNG";
            this.SoLuong.ColumnEdit = this.CustomSLHD;
            this.SoLuong.DisplayFormat.FormatString = "N0";
            this.SoLuong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SoLuong.FieldName = "SoLuong";
            this.SoLuong.MinWidth = 31;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 2;
            this.SoLuong.Width = 140;
            // 
            // CustomSLHD
            // 
            this.CustomSLHD.AutoHeight = false;
            this.CustomSLHD.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.CustomSLHD.MaskSettings.Set("mask", "N0");
            this.CustomSLHD.Name = "CustomSLHD";
            // 
            // DonGia
            // 
            this.DonGia.Caption = "ĐƠN GIÁ";
            this.DonGia.ColumnEdit = this.CUstomDLHD;
            this.DonGia.DisplayFormat.FormatString = "N2";
            this.DonGia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DonGia.FieldName = "DonGia";
            this.DonGia.MinWidth = 31;
            this.DonGia.Name = "DonGia";
            this.DonGia.Visible = true;
            this.DonGia.VisibleIndex = 3;
            this.DonGia.Width = 241;
            // 
            // CUstomDLHD
            // 
            this.CUstomDLHD.AutoHeight = false;
            this.CUstomDLHD.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.CUstomDLHD.MaskSettings.Set("mask", "n");
            this.CUstomDLHD.Name = "CUstomDLHD";
            // 
            // ThanhTien
            // 
            this.ThanhTien.Caption = "THÀNH TIỀN";
            this.ThanhTien.ColumnEdit = this.CUstomDLHD;
            this.ThanhTien.DisplayFormat.FormatString = "N2";
            this.ThanhTien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ThanhTien.FieldName = "ThanhTien";
            this.ThanhTien.MinWidth = 31;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Visible = true;
            this.ThanhTien.VisibleIndex = 4;
            this.ThanhTien.Width = 250;
            // 
            // NgaySanXuat
            // 
            this.NgaySanXuat.Caption = "NGÀY SẢN XUẤT";
            this.NgaySanXuat.FieldName = "NgaySanXuat";
            this.NgaySanXuat.MinWidth = 31;
            this.NgaySanXuat.Name = "NgaySanXuat";
            this.NgaySanXuat.Visible = true;
            this.NgaySanXuat.VisibleIndex = 5;
            this.NgaySanXuat.Width = 130;
            // 
            // HanSuDung
            // 
            this.HanSuDung.Caption = "HẠN SỬ DỤNG";
            this.HanSuDung.FieldName = "HanSuDung";
            this.HanSuDung.MinWidth = 31;
            this.HanSuDung.Name = "HanSuDung";
            this.HanSuDung.Visible = true;
            this.HanSuDung.VisibleIndex = 6;
            this.HanSuDung.Width = 130;
            // 
            // btnInBu
            // 
            this.btnInBu.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInBu.Appearance.Options.UseFont = true;
            this.btnInBu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInBu.ImageOptions.Image")));
            this.btnInBu.Location = new System.Drawing.Point(952, 471);
            this.btnInBu.Margin = new System.Windows.Forms.Padding(4);
            this.btnInBu.Name = "btnInBu";
            this.btnInBu.Size = new System.Drawing.Size(139, 60);
            this.btnInBu.TabIndex = 1;
            this.btnInBu.Text = "In Bù";
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(1114, 471);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(139, 60);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 429);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnInBu);
            this.Controls.Add(this.gridCTHD);
            this.Name = "frmChiTietHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết hóa đơn";
            this.Load += new System.EventHandler(this.frmChiTietHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCTHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomSLHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CUstomDLHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridCTHD;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn TenSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn DonGia;
        private DevExpress.XtraGrid.Columns.GridColumn ThanhTien;
        private DevExpress.XtraEditors.SimpleButton btnInBu;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit CustomSLHD;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit CUstomDLHD;
        private DevExpress.XtraGrid.Columns.GridColumn NgaySanXuat;
        private DevExpress.XtraGrid.Columns.GridColumn HanSuDung;
    }
}