namespace QuanLyMiniMart
{
    partial class PhieuNhapControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhieuNhapControl));
            this.DinhDangNgay = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableBangGia = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.tableDonViTinh = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.TongTienNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CustomTongTienPhieuNhap = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.MaNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkMaNhanVien = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.MaPhieuNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KTChiTietPN = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.ChiTietPhieuNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaNhaCungCap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkNCC = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.NgayNhapHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridPhieuNhap = new DevExpress.XtraGrid.GridControl();
            this.TableNCC = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.lkNhaCungCap = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DinhDangNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DinhDangNgay.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBangGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDonViTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomTongTienPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkMaNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KTChiTietPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkNCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableNCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkNhaCungCap)).BeginInit();
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
            this.txtTimKiem.DefaultText = "Tìm kiếm phiếu nhập";
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
            this.label1.Size = new System.Drawing.Size(378, 38);
            this.label1.TabIndex = 28;
            this.label1.Text = "Danh Sách Phiếu Nhập";
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
            // TongTienNhap
            // 
            this.TongTienNhap.Caption = "TỔNG TIỀN NHẬP";
            this.TongTienNhap.ColumnEdit = this.CustomTongTienPhieuNhap;
            this.TongTienNhap.DisplayFormat.FormatString = "N2";
            this.TongTienNhap.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TongTienNhap.FieldName = "TongTienNhap";
            this.TongTienNhap.MinWidth = 25;
            this.TongTienNhap.Name = "TongTienNhap";
            this.TongTienNhap.Visible = true;
            this.TongTienNhap.VisibleIndex = 4;
            this.TongTienNhap.Width = 300;
            // 
            // CustomTongTienPhieuNhap
            // 
            this.CustomTongTienPhieuNhap.AutoHeight = false;
            this.CustomTongTienPhieuNhap.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.CustomTongTienPhieuNhap.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.CustomTongTienPhieuNhap.MaskSettings.Set("mask", "n");
            this.CustomTongTienPhieuNhap.Name = "CustomTongTienPhieuNhap";
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.Caption = "ID NHÂN VIÊN";
            this.MaNhanVien.ColumnEdit = this.lkMaNhanVien;
            this.MaNhanVien.FieldName = "MaNhanVien";
            this.MaNhanVien.MinWidth = 25;
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.Visible = true;
            this.MaNhanVien.VisibleIndex = 3;
            this.MaNhanVien.Width = 368;
            // 
            // lkMaNhanVien
            // 
            this.lkMaNhanVien.AutoHeight = false;
            this.lkMaNhanVien.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkMaNhanVien.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaNhanVien", "ID"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenNhanVien", "Tên Nhân Viên")});
            this.lkMaNhanVien.Name = "lkMaNhanVien";
            // 
            // MaPhieuNhap
            // 
            this.MaPhieuNhap.Caption = "MÃ PHIẾU NHẬP";
            this.MaPhieuNhap.FieldName = "MaPhieuNhap";
            this.MaPhieuNhap.MinWidth = 25;
            this.MaPhieuNhap.Name = "MaPhieuNhap";
            this.MaPhieuNhap.Visible = true;
            this.MaPhieuNhap.VisibleIndex = 1;
            this.MaPhieuNhap.Width = 210;
            // 
            // KTChiTietPN
            // 
            this.KTChiTietPN.AutoHeight = false;
            this.KTChiTietPN.Name = "KTChiTietPN";
            // 
            // ChiTietPhieuNhap
            // 
            this.ChiTietPhieuNhap.Caption = "CTPN";
            this.ChiTietPhieuNhap.ColumnEdit = this.KTChiTietPN;
            this.ChiTietPhieuNhap.FieldName = "ChiTietPhieuNhap";
            this.ChiTietPhieuNhap.MinWidth = 25;
            this.ChiTietPhieuNhap.Name = "ChiTietPhieuNhap";
            this.ChiTietPhieuNhap.Visible = true;
            this.ChiTietPhieuNhap.VisibleIndex = 0;
            this.ChiTietPhieuNhap.Width = 65;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ChiTietPhieuNhap,
            this.MaPhieuNhap,
            this.MaNhaCungCap,
            this.MaNhanVien,
            this.TongTienNhap,
            this.NgayNhapHang});
            this.gridView1.GridControl = this.gridPhieuNhap;
            this.gridView1.Name = "gridView1";
            this.gridView1.NewItemRowText = "Thêm phiếu nhập mới tại đây";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            this.gridView1.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView1_InitNewRow);
            this.gridView1.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanging);
            // 
            // MaNhaCungCap
            // 
            this.MaNhaCungCap.Caption = "ID NCC";
            this.MaNhaCungCap.ColumnEdit = this.lkNCC;
            this.MaNhaCungCap.FieldName = "MaNhaCungCap";
            this.MaNhaCungCap.MinWidth = 25;
            this.MaNhaCungCap.Name = "MaNhaCungCap";
            this.MaNhaCungCap.Visible = true;
            this.MaNhaCungCap.VisibleIndex = 2;
            this.MaNhaCungCap.Width = 220;
            // 
            // lkNCC
            // 
            this.lkNCC.AutoHeight = false;
            this.lkNCC.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkNCC.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaNhaCungCap", "ID NCC"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenNhaCungCap", "Tên NCC")});
            this.lkNCC.Name = "lkNCC";
            // 
            // NgayNhapHang
            // 
            this.NgayNhapHang.Caption = "NGÀY NHẬP HÀNG";
            this.NgayNhapHang.ColumnEdit = this.DinhDangNgay;
            this.NgayNhapHang.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.NgayNhapHang.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.NgayNhapHang.FieldName = "NgayNhapHang";
            this.NgayNhapHang.MinWidth = 25;
            this.NgayNhapHang.Name = "NgayNhapHang";
            this.NgayNhapHang.Visible = true;
            this.NgayNhapHang.VisibleIndex = 5;
            this.NgayNhapHang.Width = 395;
            // 
            // gridPhieuNhap
            // 
            this.gridPhieuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridPhieuNhap.Location = new System.Drawing.Point(22, 130);
            this.gridPhieuNhap.MainView = this.gridView1;
            this.gridPhieuNhap.Name = "gridPhieuNhap";
            this.gridPhieuNhap.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.tableDonViTinh,
            this.tableBangGia,
            this.KTChiTietPN,
            this.DinhDangNgay,
            this.CustomTongTienPhieuNhap,
            this.TableNCC,
            this.lkNhaCungCap,
            this.lkMaNhanVien,
            this.lkNCC});
            this.gridPhieuNhap.Size = new System.Drawing.Size(1734, 765);
            this.gridPhieuNhap.TabIndex = 33;
            this.gridPhieuNhap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // TableNCC
            // 
            this.TableNCC.AutoHeight = false;
            this.TableNCC.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TableNCC.Name = "TableNCC";
            // 
            // lkNhaCungCap
            // 
            this.lkNhaCungCap.AutoHeight = false;
            this.lkNhaCungCap.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkNhaCungCap.Name = "lkNhaCungCap";
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
            this.label3.Location = new System.Drawing.Point(1366, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 15);
            this.label3.TabIndex = 36;
            this.label3.Text = "(Tìm kiếm mã phiếu nhâp hoặc ngày nhập hàng *)";
            // 
            // PhieuNhapControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridPhieuNhap);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Name = "PhieuNhapControl";
            this.Size = new System.Drawing.Size(1799, 967);
            this.Load += new System.EventHandler(this.PhieuNhapControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DinhDangNgay.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DinhDangNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBangGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDonViTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomTongTienPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkMaNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KTChiTietPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkNCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableNCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkNhaCungCap)).EndInit();
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
        private DevExpress.XtraGrid.Columns.GridColumn TongTienNhap;
        private DevExpress.XtraGrid.Columns.GridColumn MaNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn MaPhieuNhap;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit KTChiTietPN;
        private DevExpress.XtraGrid.Columns.GridColumn ChiTietPhieuNhap;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn NgayNhapHang;
        private DevExpress.XtraGrid.GridControl gridPhieuNhap;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit CustomTongTienPhieuNhap;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit TableNCC;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lkNhaCungCap;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lkMaNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn MaNhaCungCap;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lkNCC;
        private System.Windows.Forms.Label label3;
    }
}
