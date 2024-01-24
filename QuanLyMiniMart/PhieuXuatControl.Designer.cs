namespace QuanLyMiniMart
{
    partial class PhieuXuatControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhieuXuatControl));
            this.DinhDangNgay = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableBangGia = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.tableDonViTinh = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.KTChiTietPX = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.ChiTietPhieuXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaPhieuXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaNhaCungCap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkNCC = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.MaNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkNV = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.TongTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CustomTongTien = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.NgayXuatHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridPhieuXuat = new DevExpress.XtraGrid.GridControl();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DinhDangNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DinhDangNgay.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBangGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDonViTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KTChiTietPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkNCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomTongTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPhieuXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DinhDangNgay
            // 
            this.DinhDangNgay.AutoHeight = false;
            this.DinhDangNgay.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DinhDangNgay.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DinhDangNgay.MaskSettings.Set("mask", "dd/MM/yyyy hh:mm");
            this.DinhDangNgay.Name = "DinhDangNgay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1272, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 30;
            this.label2.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.AutoRoundedCorners = true;
            this.txtTimKiem.BorderRadius = 21;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "Tìm kiếm phiếu xuất";
            this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Location = new System.Drawing.Point(1276, 69);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderText = "";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(480, 45);
            this.txtTimKiem.TabIndex = 29;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            this.txtTimKiem.Enter += new System.EventHandler(this.txtTimKiem_Enter);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 38);
            this.label1.TabIndex = 28;
            this.label1.Text = "Danh Sách Phiếu Xuất";
            // 
            // tableBangGia
            // 
            this.tableBangGia.AutoHeight = false;
            this.tableBangGia.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tableBangGia.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaSanPham", "Mã Sản Phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenSanPham", "Tên Sản Phẩm")});
            this.tableBangGia.Name = "tableBangGia";
            // 
            // tableDonViTinh
            // 
            this.tableDonViTinh.AutoHeight = false;
            this.tableDonViTinh.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tableDonViTinh.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaDonViTinh", "Mã Đơn Vị Tính"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DonViTinh", "Đơn Vị Tính"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ChiChu", "Ghi Chú")});
            this.tableDonViTinh.Name = "tableDonViTinh";
            // 
            // KTChiTietPX
            // 
            this.KTChiTietPX.AutoHeight = false;
            this.KTChiTietPX.Name = "KTChiTietPX";
            // 
            // ChiTietPhieuXuat
            // 
            this.ChiTietPhieuXuat.Caption = "CTPX";
            this.ChiTietPhieuXuat.ColumnEdit = this.KTChiTietPX;
            this.ChiTietPhieuXuat.FieldName = "ChiTietPhieuXuat";
            this.ChiTietPhieuXuat.MinWidth = 25;
            this.ChiTietPhieuXuat.Name = "ChiTietPhieuXuat";
            this.ChiTietPhieuXuat.Visible = true;
            this.ChiTietPhieuXuat.VisibleIndex = 0;
            this.ChiTietPhieuXuat.Width = 65;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ChiTietPhieuXuat,
            this.MaPhieuXuat,
            this.MaNhaCungCap,
            this.MaNhanVien,
            this.TongTien,
            this.NgayXuatHang});
            this.gridView1.GridControl = this.gridPhieuXuat;
            this.gridView1.Name = "gridView1";
            this.gridView1.NewItemRowText = "Thêm phiếu xuất mới tại đây";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            this.gridView1.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView1_InitNewRow);
            this.gridView1.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanging);
            // 
            // MaPhieuXuat
            // 
            this.MaPhieuXuat.Caption = "MÃ PHIẾU XUẤT";
            this.MaPhieuXuat.FieldName = "MaPhieuXuat";
            this.MaPhieuXuat.MinWidth = 25;
            this.MaPhieuXuat.Name = "MaPhieuXuat";
            this.MaPhieuXuat.Visible = true;
            this.MaPhieuXuat.VisibleIndex = 1;
            this.MaPhieuXuat.Width = 165;
            // 
            // MaNhaCungCap
            // 
            this.MaNhaCungCap.Caption = "MÃ NHÀ CUNG CẤP SP";
            this.MaNhaCungCap.ColumnEdit = this.lkNCC;
            this.MaNhaCungCap.FieldName = "MaNhaCungCap";
            this.MaNhaCungCap.MinWidth = 25;
            this.MaNhaCungCap.Name = "MaNhaCungCap";
            this.MaNhaCungCap.Visible = true;
            this.MaNhaCungCap.VisibleIndex = 2;
            this.MaNhaCungCap.Width = 232;
            // 
            // lkNCC
            // 
            this.lkNCC.AutoHeight = false;
            this.lkNCC.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkNCC.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaNhaCungCap", "Id"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenNhaCungCap", "Tên Nhà Cung Cấp")});
            this.lkNCC.Name = "lkNCC";
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.Caption = "MÃ NHÂN VIÊN";
            this.MaNhanVien.ColumnEdit = this.lkNV;
            this.MaNhanVien.FieldName = "MaNhanVien";
            this.MaNhanVien.MinWidth = 25;
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.Visible = true;
            this.MaNhanVien.VisibleIndex = 3;
            this.MaNhanVien.Width = 232;
            // 
            // lkNV
            // 
            this.lkNV.AutoHeight = false;
            this.lkNV.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkNV.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaNhanVien", "Id"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenNhanVien", "Tên Nhân Viên")});
            this.lkNV.Name = "lkNV";
            // 
            // TongTien
            // 
            this.TongTien.Caption = "TỔNG TIỀN";
            this.TongTien.ColumnEdit = this.CustomTongTien;
            this.TongTien.DisplayFormat.FormatString = "N2";
            this.TongTien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TongTien.FieldName = "TongTien";
            this.TongTien.MinWidth = 25;
            this.TongTien.Name = "TongTien";
            this.TongTien.Visible = true;
            this.TongTien.VisibleIndex = 4;
            this.TongTien.Width = 232;
            // 
            // CustomTongTien
            // 
            this.CustomTongTien.AutoHeight = false;
            this.CustomTongTien.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.CustomTongTien.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.CustomTongTien.MaskSettings.Set("mask", "n");
            this.CustomTongTien.Name = "CustomTongTien";
            // 
            // NgayXuatHang
            // 
            this.NgayXuatHang.Caption = "NGÀY XUẤT HÀNG";
            this.NgayXuatHang.ColumnEdit = this.DinhDangNgay;
            this.NgayXuatHang.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.NgayXuatHang.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.NgayXuatHang.FieldName = "NgayXuatHang";
            this.NgayXuatHang.MinWidth = 25;
            this.NgayXuatHang.Name = "NgayXuatHang";
            this.NgayXuatHang.Visible = true;
            this.NgayXuatHang.VisibleIndex = 5;
            this.NgayXuatHang.Width = 249;
            // 
            // gridPhieuXuat
            // 
            this.gridPhieuXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridPhieuXuat.Location = new System.Drawing.Point(22, 130);
            this.gridPhieuXuat.MainView = this.gridView1;
            this.gridPhieuXuat.Name = "gridPhieuXuat";
            this.gridPhieuXuat.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.tableDonViTinh,
            this.tableBangGia,
            this.KTChiTietPX,
            this.DinhDangNgay,
            this.lkNCC,
            this.lkNV,
            this.CustomTongTien});
            this.gridPhieuXuat.Size = new System.Drawing.Size(1734, 765);
            this.gridPhieuXuat.TabIndex = 33;
            this.gridPhieuXuat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn2.FillWeight = 200F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::QuanLyMiniMart.Properties.Resources.XoaSP;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 200;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 200;
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(1649, 901);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(107, 54);
            this.btnThoat.TabIndex = 35;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.ImageOptions.Image = global::QuanLyMiniMart.Properties.Resources.XoaSP;
            this.btnXoa.Location = new System.Drawing.Point(1504, 901);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(107, 54);
            this.btnXoa.TabIndex = 34;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.Location = new System.Drawing.Point(1361, 901);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(107, 54);
            this.btnLuu.TabIndex = 32;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::QuanLyMiniMart.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(1762, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.FillWeight = 200F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::QuanLyMiniMart.Properties.Resources.edit;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 200;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 200;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1360, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 15);
            this.label3.TabIndex = 37;
            this.label3.Text = "(Tìm kiếm mã phiếu xuất hoặc ngày xuất hàng *)";
            // 
            // PhieuXuatControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridPhieuXuat);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PhieuXuatControl";
            this.Size = new System.Drawing.Size(1799, 967);
            this.Load += new System.EventHandler(this.PhieuXuatControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DinhDangNgay.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DinhDangNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBangGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDonViTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KTChiTietPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkNCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomTongTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPhieuXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit DinhDangNgay;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit tableBangGia;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit tableDonViTinh;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit KTChiTietPX;
        private DevExpress.XtraGrid.Columns.GridColumn ChiTietPhieuXuat;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridPhieuXuat;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn MaNhaCungCap;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lkNCC;
        private DevExpress.XtraGrid.Columns.GridColumn MaNhanVien;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lkNV;
        private DevExpress.XtraGrid.Columns.GridColumn TongTien;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit CustomTongTien;
        private DevExpress.XtraGrid.Columns.GridColumn NgayXuatHang;
        private DevExpress.XtraGrid.Columns.GridColumn MaPhieuXuat;
        private System.Windows.Forms.Label label3;
    }
}
