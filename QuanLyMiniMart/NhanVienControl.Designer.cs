namespace QuanLyMiniMart
{
    partial class NhanVienControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVienControl));
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.CustomNgayKyHopDong = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridNhanVien = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChucVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CCCD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Luong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CustomLuong = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.SoDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CustomNgaySinh = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.DiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayKyHopDong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaTaiKhoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkTaiKhoan = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.tableDonViTinh = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.tableBangGia = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.CustomNgay = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CustomNgayKyHopDong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomNgayKyHopDong.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomNgaySinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomNgaySinh.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDonViTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBangGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomNgay)).BeginInit();
            this.SuspendLayout();
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
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(1637, 891);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(107, 54);
            this.btnThoat.TabIndex = 55;
            this.btnThoat.Text = "Thoát";
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.ImageOptions.Image = global::QuanLyMiniMart.Properties.Resources.XoaSP;
            this.btnXoa.Location = new System.Drawing.Point(1498, 891);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(107, 54);
            this.btnXoa.TabIndex = 54;
            this.btnXoa.Text = "Xóa";
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.Location = new System.Drawing.Point(1352, 891);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(107, 54);
            this.btnLuu.TabIndex = 52;
            this.btnLuu.Text = "Lưu";
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
            // CustomNgayKyHopDong
            // 
            this.CustomNgayKyHopDong.AutoHeight = false;
            this.CustomNgayKyHopDong.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CustomNgayKyHopDong.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CustomNgayKyHopDong.MaskSettings.Set("mask", "dd/MM/yyyy hh:mm");
            this.CustomNgayKyHopDong.Name = "CustomNgayKyHopDong";
            this.CustomNgayKyHopDong.UseMaskAsDisplayFormat = true;
            // 
            // gridNhanVien
            // 
            this.gridNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridNhanVien.Location = new System.Drawing.Point(28, 133);
            this.gridNhanVien.MainView = this.gridView1;
            this.gridNhanVien.Name = "gridNhanVien";
            this.gridNhanVien.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.tableDonViTinh,
            this.tableBangGia,
            this.CustomNgayKyHopDong,
            this.CustomLuong,
            this.CustomNgaySinh,
            this.CustomNgay,
            this.lkTaiKhoan});
            this.gridNhanVien.Size = new System.Drawing.Size(1716, 752);
            this.gridNhanVien.TabIndex = 53;
            this.gridNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaNhanVien,
            this.TenNhanVien,
            this.ChucVu,
            this.CCCD,
            this.Luong,
            this.SoDienThoai,
            this.NgaySinh,
            this.DiaChi,
            this.NgayKyHopDong,
            this.MaTaiKhoan});
            this.gridView1.GridControl = this.gridNhanVien;
            this.gridView1.Name = "gridView1";
            this.gridView1.NewItemRowText = "Thêm thông tin nhân viên mới tại đây";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.Caption = "MÃ NHÂN VIÊN";
            this.MaNhanVien.FieldName = "MaNhanVien";
            this.MaNhanVien.MinWidth = 25;
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.Visible = true;
            this.MaNhanVien.VisibleIndex = 0;
            this.MaNhanVien.Width = 155;
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.Caption = "TÊN NHÂN VIÊN";
            this.TenNhanVien.FieldName = "TenNhanVien";
            this.TenNhanVien.MinWidth = 25;
            this.TenNhanVien.Name = "TenNhanVien";
            this.TenNhanVien.Visible = true;
            this.TenNhanVien.VisibleIndex = 1;
            this.TenNhanVien.Width = 250;
            // 
            // ChucVu
            // 
            this.ChucVu.Caption = "CHỨC VỤ";
            this.ChucVu.FieldName = "ChucVu";
            this.ChucVu.MinWidth = 25;
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.Visible = true;
            this.ChucVu.VisibleIndex = 2;
            this.ChucVu.Width = 200;
            // 
            // CCCD
            // 
            this.CCCD.Caption = "CCCD";
            this.CCCD.FieldName = "CCCD";
            this.CCCD.MinWidth = 25;
            this.CCCD.Name = "CCCD";
            this.CCCD.Visible = true;
            this.CCCD.VisibleIndex = 3;
            this.CCCD.Width = 155;
            // 
            // Luong
            // 
            this.Luong.Caption = "LƯƠNG";
            this.Luong.ColumnEdit = this.CustomLuong;
            this.Luong.DisplayFormat.FormatString = "N2";
            this.Luong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Luong.FieldName = "Luong";
            this.Luong.MinWidth = 25;
            this.Luong.Name = "Luong";
            this.Luong.Visible = true;
            this.Luong.VisibleIndex = 4;
            this.Luong.Width = 146;
            // 
            // CustomLuong
            // 
            this.CustomLuong.AutoHeight = false;
            this.CustomLuong.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.CustomLuong.MaskSettings.Set("mask", "n");
            this.CustomLuong.Name = "CustomLuong";
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.Caption = "SỐ ĐIỆN THOẠI";
            this.SoDienThoai.FieldName = "SoDienThoai";
            this.SoDienThoai.MinWidth = 25;
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.Visible = true;
            this.SoDienThoai.VisibleIndex = 5;
            this.SoDienThoai.Width = 155;
            // 
            // NgaySinh
            // 
            this.NgaySinh.Caption = "NGÀY SINH";
            this.NgaySinh.ColumnEdit = this.CustomNgaySinh;
            this.NgaySinh.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.NgaySinh.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.NgaySinh.FieldName = "NgaySinh";
            this.NgaySinh.MinWidth = 25;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Visible = true;
            this.NgaySinh.VisibleIndex = 6;
            this.NgaySinh.Width = 200;
            // 
            // CustomNgaySinh
            // 
            this.CustomNgaySinh.AutoHeight = false;
            this.CustomNgaySinh.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CustomNgaySinh.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CustomNgaySinh.MaskSettings.Set("mask", "dd/MM/yyyy");
            this.CustomNgaySinh.Name = "CustomNgaySinh";
            // 
            // DiaChi
            // 
            this.DiaChi.Caption = "ĐỊA CHỈ";
            this.DiaChi.FieldName = "DiaChi";
            this.DiaChi.MinWidth = 25;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Visible = true;
            this.DiaChi.VisibleIndex = 7;
            this.DiaChi.Width = 250;
            // 
            // NgayKyHopDong
            // 
            this.NgayKyHopDong.Caption = "NGÀY KÝ HỢP ĐỒNG";
            this.NgayKyHopDong.ColumnEdit = this.CustomNgaySinh;
            this.NgayKyHopDong.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.NgayKyHopDong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.NgayKyHopDong.FieldName = "NgayKyHopDong";
            this.NgayKyHopDong.MinWidth = 25;
            this.NgayKyHopDong.Name = "NgayKyHopDong";
            this.NgayKyHopDong.Visible = true;
            this.NgayKyHopDong.VisibleIndex = 8;
            this.NgayKyHopDong.Width = 200;
            // 
            // MaTaiKhoan
            // 
            this.MaTaiKhoan.Caption = "MÃ TÀI KHOẢN ĐN";
            this.MaTaiKhoan.ColumnEdit = this.lkTaiKhoan;
            this.MaTaiKhoan.FieldName = "MaTaiKhoan";
            this.MaTaiKhoan.MinWidth = 25;
            this.MaTaiKhoan.Name = "MaTaiKhoan";
            this.MaTaiKhoan.Visible = true;
            this.MaTaiKhoan.VisibleIndex = 9;
            this.MaTaiKhoan.Width = 150;
            // 
            // lkTaiKhoan
            // 
            this.lkTaiKhoan.AutoHeight = false;
            this.lkTaiKhoan.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkTaiKhoan.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaTaiKhoan", "ID"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TaiKhoan", "TaiKhoan"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MatKhau", "MatKhau")});
            this.lkTaiKhoan.Name = "lkTaiKhoan";
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
            // CustomNgay
            // 
            this.CustomNgay.AutoHeight = false;
            this.CustomNgay.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.DateTimeMaskManager));
            this.CustomNgay.MaskSettings.Set("mask", "dd/MM/yyyy hh:mm");
            this.CustomNgay.Name = "CustomNgay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1349, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 15);
            this.label3.TabIndex = 56;
            this.label3.Text = "(Tìm kiếm theo mã nhân viên hoặc CCCD*)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1259, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 50;
            this.label2.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.AutoRoundedCorners = true;
            this.txtTimKiem.BorderRadius = 21;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "Tìm kiếm nhân viên";
            this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Location = new System.Drawing.Point(1263, 71);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderText = "";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(480, 45);
            this.txtTimKiem.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 38);
            this.label1.TabIndex = 48;
            this.label1.Text = "Danh Sách Nhân Viên";
            // 
            // NhanVienControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.gridNhanVien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label1);
            this.Name = "NhanVienControl";
            this.Size = new System.Drawing.Size(1799, 960);
            this.Load += new System.EventHandler(this.NhanVienControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomNgayKyHopDong.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomNgayKyHopDong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomNgaySinh.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomNgaySinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDonViTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBangGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomNgay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit CustomNgayKyHopDong;
        private DevExpress.XtraGrid.GridControl gridNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn TenNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn ChucVu;
        private DevExpress.XtraGrid.Columns.GridColumn CCCD;
        private DevExpress.XtraGrid.Columns.GridColumn Luong;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit CustomLuong;
        private DevExpress.XtraGrid.Columns.GridColumn SoDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn NgaySinh;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit CustomNgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn NgayKyHopDong;
        private DevExpress.XtraGrid.Columns.GridColumn MaTaiKhoan;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lkTaiKhoan;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit tableDonViTinh;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit tableBangGia;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit CustomNgay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
    }
}
