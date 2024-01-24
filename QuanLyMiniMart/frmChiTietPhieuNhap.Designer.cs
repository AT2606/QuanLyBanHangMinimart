namespace QuanLyMiniMart
{
    partial class frmChiTietPhieuNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTietPhieuNhap));
            this.gridCTPN = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkIDSanPham = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.TenSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkDonViTinh = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CUstomSLPN = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.DonGiaMua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CustomTien = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.ThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgaySanXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DDNgaySX = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.HanSuDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CusTomNgay = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.CusTomNgaySX = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkIDSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkDonViTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CUstomSLPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DDNgaySX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DDNgaySX.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CusTomNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CusTomNgaySX)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCTPN
            // 
            this.gridCTPN.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridCTPN.Location = new System.Drawing.Point(0, 0);
            this.gridCTPN.MainView = this.gridView1;
            this.gridCTPN.Name = "gridCTPN";
            this.gridCTPN.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lkDonViTinh,
            this.CustomTien,
            this.CusTomNgay,
            this.lkIDSanPham,
            this.CusTomNgaySX,
            this.DDNgaySX,
            this.CUstomSLPN});
            this.gridCTPN.Size = new System.Drawing.Size(1306, 361);
            this.gridCTPN.TabIndex = 3;
            this.gridCTPN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaSanPham,
            this.TenSanPham,
            this.TenDonViTinh,
            this.SoLuong,
            this.DonGiaMua,
            this.ThanhTien,
            this.NgaySanXuat,
            this.HanSuDung});
            this.gridView1.GridControl = this.gridCTPN;
            this.gridView1.Name = "gridView1";
            this.gridView1.NewItemRowText = "Thêm sản phẩm cho phiếu nhập tại đây";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // MaSanPham
            // 
            this.MaSanPham.Caption = "ID";
            this.MaSanPham.ColumnEdit = this.lkIDSanPham;
            this.MaSanPham.FieldName = "MaSanPham";
            this.MaSanPham.MinWidth = 25;
            this.MaSanPham.Name = "MaSanPham";
            this.MaSanPham.Visible = true;
            this.MaSanPham.VisibleIndex = 0;
            this.MaSanPham.Width = 150;
            // 
            // lkIDSanPham
            // 
            this.lkIDSanPham.AutoHeight = false;
            this.lkIDSanPham.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkIDSanPham.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaSanPham", "ID"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenSanPham", "Tên Sản Phẩm")});
            this.lkIDSanPham.Name = "lkIDSanPham";
            // 
            // TenSanPham
            // 
            this.TenSanPham.Caption = "TÊN SẢN PHẨM";
            this.TenSanPham.FieldName = "TenSanPham";
            this.TenSanPham.MinWidth = 25;
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.Visible = true;
            this.TenSanPham.VisibleIndex = 1;
            this.TenSanPham.Width = 220;
            // 
            // TenDonViTinh
            // 
            this.TenDonViTinh.Caption = "DVT";
            this.TenDonViTinh.ColumnEdit = this.lkDonViTinh;
            this.TenDonViTinh.FieldName = "TenDonViTinh";
            this.TenDonViTinh.MinWidth = 25;
            this.TenDonViTinh.Name = "TenDonViTinh";
            this.TenDonViTinh.Visible = true;
            this.TenDonViTinh.VisibleIndex = 2;
            this.TenDonViTinh.Width = 90;
            // 
            // lkDonViTinh
            // 
            this.lkDonViTinh.AutoHeight = false;
            this.lkDonViTinh.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkDonViTinh.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaDonViTinh", "ID"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenDonViTinh", "ĐƠN VỊ TÍNH")});
            this.lkDonViTinh.Name = "lkDonViTinh";
            // 
            // SoLuong
            // 
            this.SoLuong.Caption = "SỐ LƯỢNG";
            this.SoLuong.ColumnEdit = this.CUstomSLPN;
            this.SoLuong.DisplayFormat.FormatString = "N0";
            this.SoLuong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SoLuong.FieldName = "SoLuong";
            this.SoLuong.MinWidth = 25;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 3;
            this.SoLuong.Width = 121;
            // 
            // CUstomSLPN
            // 
            this.CUstomSLPN.AutoHeight = false;
            this.CUstomSLPN.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.CUstomSLPN.MaskSettings.Set("mask", "N0");
            this.CUstomSLPN.Name = "CUstomSLPN";
            // 
            // DonGiaMua
            // 
            this.DonGiaMua.Caption = "GIÁ NHẬP";
            this.DonGiaMua.ColumnEdit = this.CustomTien;
            this.DonGiaMua.DisplayFormat.FormatString = "N2";
            this.DonGiaMua.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DonGiaMua.FieldName = "DonGiaMua";
            this.DonGiaMua.MinWidth = 25;
            this.DonGiaMua.Name = "DonGiaMua";
            this.DonGiaMua.Visible = true;
            this.DonGiaMua.VisibleIndex = 4;
            this.DonGiaMua.Width = 158;
            // 
            // CustomTien
            // 
            this.CustomTien.AutoHeight = false;
            this.CustomTien.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.CustomTien.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.CustomTien.MaskSettings.Set("mask", "n");
            this.CustomTien.Name = "CustomTien";
            // 
            // ThanhTien
            // 
            this.ThanhTien.Caption = "THÀNH TIỀN";
            this.ThanhTien.ColumnEdit = this.CustomTien;
            this.ThanhTien.DisplayFormat.FormatString = "N2";
            this.ThanhTien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ThanhTien.FieldName = "ThanhTien";
            this.ThanhTien.MinWidth = 25;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Visible = true;
            this.ThanhTien.VisibleIndex = 5;
            this.ThanhTien.Width = 158;
            // 
            // NgaySanXuat
            // 
            this.NgaySanXuat.Caption = "NGÀY SẢN XUẤT";
            this.NgaySanXuat.ColumnEdit = this.DDNgaySX;
            this.NgaySanXuat.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.NgaySanXuat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.NgaySanXuat.FieldName = "NgaySanXuat";
            this.NgaySanXuat.MinWidth = 25;
            this.NgaySanXuat.Name = "NgaySanXuat";
            this.NgaySanXuat.Visible = true;
            this.NgaySanXuat.VisibleIndex = 6;
            this.NgaySanXuat.Width = 94;
            // 
            // DDNgaySX
            // 
            this.DDNgaySX.AutoHeight = false;
            this.DDNgaySX.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DDNgaySX.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DDNgaySX.MaskSettings.Set("mask", "dd/MM/yyyy");
            this.DDNgaySX.Name = "DDNgaySX";
            // 
            // HanSuDung
            // 
            this.HanSuDung.Caption = "HẠN SỬ DỤNG";
            this.HanSuDung.ColumnEdit = this.DDNgaySX;
            this.HanSuDung.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.HanSuDung.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.HanSuDung.FieldName = "HanSuDung";
            this.HanSuDung.MinWidth = 25;
            this.HanSuDung.Name = "HanSuDung";
            this.HanSuDung.Visible = true;
            this.HanSuDung.VisibleIndex = 7;
            this.HanSuDung.Width = 94;
            // 
            // CusTomNgay
            // 
            this.CusTomNgay.AutoHeight = false;
            this.CusTomNgay.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CusTomNgay.MaskSettings.Set("mask", "dd/MM/yyyy");
            this.CusTomNgay.Name = "CusTomNgay";
            // 
            // CusTomNgaySX
            // 
            this.CusTomNgaySX.AutoHeight = false;
            this.CusTomNgaySX.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.DateTimeMaskManager));
            this.CusTomNgaySX.MaskSettings.Set("mask", "dd/MM/yyyy");
            this.CusTomNgaySX.Name = "CusTomNgaySX";
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(1048, 367);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(107, 54);
            this.btnXoa.TabIndex = 37;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.Location = new System.Drawing.Point(916, 367);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(107, 54);
            this.btnLuu.TabIndex = 36;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(1180, 367);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(114, 54);
            this.btnThoat.TabIndex = 38;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click_1);
            // 
            // frmChiTietPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 429);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.gridCTPN);
            this.Name = "frmChiTietPhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Tiết Phiếu nhập";
            this.Load += new System.EventHandler(this.frmChiTietPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkIDSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkDonViTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CUstomSLPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DDNgaySX.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DDNgaySX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CusTomNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CusTomNgaySX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridCTPN;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn TenSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn TenDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn DonGiaMua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraGrid.Columns.GridColumn ThanhTien;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lkDonViTinh;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit CustomTien;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit CusTomNgay;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lkIDSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn NgaySanXuat;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit CusTomNgaySX;
        private DevExpress.XtraGrid.Columns.GridColumn HanSuDung;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit DDNgaySX;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit CUstomSLPN;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
    }
}