namespace QuanLyMiniMart
{
    partial class NhanVienBanHangTot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVienBanHangTot));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btntienhanh = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.enddate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.startdate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.gridNhanVienBHT = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TongTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CusTomTTKH = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.tableDonViTinh = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.tableBangGia = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.NgayMuaHangKH = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.CustomNgayMuaHang = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnXuatPDF = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridNhanVienBHT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CusTomTTKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDonViTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBangGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NgayMuaHangKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NgayMuaHangKH.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomNgayMuaHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomNgayMuaHang.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1360, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 15);
            this.label3.TabIndex = 47;
            this.label3.Text = "(Tìm kiếm theo mã nhân viên *)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1259, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 41;
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
            this.txtTimKiem.Location = new System.Drawing.Point(1244, 77);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderText = "";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(480, 45);
            this.txtTimKiem.TabIndex = 40;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            this.txtTimKiem.Enter += new System.EventHandler(this.txtTimKiem_Enter);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 38);
            this.label1.TabIndex = 39;
            this.label1.Text = "Danh Sách Nhân Viên";
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
            // btntienhanh
            // 
            this.btntienhanh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btntienhanh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btntienhanh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btntienhanh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btntienhanh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btntienhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btntienhanh.ForeColor = System.Drawing.Color.White;
            this.btntienhanh.Location = new System.Drawing.Point(534, 77);
            this.btntienhanh.Name = "btntienhanh";
            this.btntienhanh.Size = new System.Drawing.Size(148, 36);
            this.btntienhanh.TabIndex = 51;
            this.btntienhanh.Text = "Tiến hành";
            this.btntienhanh.Click += new System.EventHandler(this.btntienhanh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(239, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 50;
            this.label4.Tag = "";
            this.label4.Text = "ĐẾN";
            // 
            // enddate
            // 
            this.enddate.AutoRoundedCorners = true;
            this.enddate.BackColor = System.Drawing.Color.Transparent;
            this.enddate.BorderRadius = 17;
            this.enddate.Checked = true;
            this.enddate.CustomFormat = "dd/MM/yyyy";
            this.enddate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.enddate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.enddate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.enddate.Location = new System.Drawing.Point(315, 77);
            this.enddate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.enddate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.enddate.Name = "enddate";
            this.enddate.Size = new System.Drawing.Size(172, 36);
            this.enddate.TabIndex = 49;
            this.enddate.Value = new System.DateTime(2023, 12, 30, 22, 26, 27, 283);
            // 
            // startdate
            // 
            this.startdate.AutoRoundedCorners = true;
            this.startdate.BackColor = System.Drawing.Color.Transparent;
            this.startdate.BorderRadius = 17;
            this.startdate.Checked = true;
            this.startdate.CustomFormat = "dd/MM/yyyy";
            this.startdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.startdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.startdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startdate.Location = new System.Drawing.Point(39, 77);
            this.startdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.startdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.startdate.Name = "startdate";
            this.startdate.Size = new System.Drawing.Size(172, 36);
            this.startdate.TabIndex = 48;
            this.startdate.Value = new System.DateTime(2023, 12, 30, 22, 26, 27, 283);
            // 
            // gridNhanVienBHT
            // 
            this.gridNhanVienBHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridNhanVienBHT.Location = new System.Drawing.Point(38, 129);
            this.gridNhanVienBHT.MainView = this.gridView1;
            this.gridNhanVienBHT.Name = "gridNhanVienBHT";
            this.gridNhanVienBHT.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.tableDonViTinh,
            this.tableBangGia,
            this.NgayMuaHangKH,
            this.CusTomTTKH,
            this.CustomNgayMuaHang});
            this.gridNhanVienBHT.Size = new System.Drawing.Size(1728, 764);
            this.gridNhanVienBHT.TabIndex = 52;
            this.gridNhanVienBHT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaNhanVien,
            this.TenNhanVien,
            this.TongTien});
            this.gridView1.GridControl = this.gridNhanVienBHT;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.Caption = "MÃ NHÂN VIÊN";
            this.MaNhanVien.FieldName = "MaNhanVien";
            this.MaNhanVien.MinWidth = 25;
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.Visible = true;
            this.MaNhanVien.VisibleIndex = 0;
            this.MaNhanVien.Width = 200;
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.Caption = "TÊN NHÂN VIÊN";
            this.TenNhanVien.FieldName = "TenNhanVien";
            this.TenNhanVien.MinWidth = 25;
            this.TenNhanVien.Name = "TenNhanVien";
            this.TenNhanVien.Visible = true;
            this.TenNhanVien.VisibleIndex = 1;
            this.TenNhanVien.Width = 500;
            // 
            // TongTien
            // 
            this.TongTien.Caption = "DOANH THU BÁN HÀNG";
            this.TongTien.ColumnEdit = this.CusTomTTKH;
            this.TongTien.DisplayFormat.FormatString = "N2";
            this.TongTien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TongTien.FieldName = "TongTien";
            this.TongTien.MinWidth = 25;
            this.TongTien.Name = "TongTien";
            this.TongTien.Visible = true;
            this.TongTien.VisibleIndex = 2;
            this.TongTien.Width = 956;
            // 
            // CusTomTTKH
            // 
            this.CusTomTTKH.AutoHeight = false;
            this.CusTomTTKH.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.CusTomTTKH.MaskSettings.Set("mask", "n");
            this.CusTomTTKH.Name = "CusTomTTKH";
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
            // NgayMuaHangKH
            // 
            this.NgayMuaHangKH.AutoHeight = false;
            this.NgayMuaHangKH.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NgayMuaHangKH.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NgayMuaHangKH.MaskSettings.Set("mask", "dd/MM/yyyy hh:mm");
            this.NgayMuaHangKH.Name = "NgayMuaHangKH";
            this.NgayMuaHangKH.UseMaskAsDisplayFormat = true;
            // 
            // CustomNgayMuaHang
            // 
            this.CustomNgayMuaHang.AutoHeight = false;
            this.CustomNgayMuaHang.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CustomNgayMuaHang.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CustomNgayMuaHang.MaskSettings.Set("mask", "dd/MM/yyyy hh:mm");
            this.CustomNgayMuaHang.Name = "CustomNgayMuaHang";
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(1659, 899);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(107, 54);
            this.btnThoat.TabIndex = 54;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXuatPDF
            // 
            this.btnXuatPDF.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatPDF.Appearance.Options.UseFont = true;
            this.btnXuatPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatPDF.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatPDF.ImageOptions.Image")));
            this.btnXuatPDF.Location = new System.Drawing.Point(1497, 899);
            this.btnXuatPDF.Name = "btnXuatPDF";
            this.btnXuatPDF.Size = new System.Drawing.Size(146, 54);
            this.btnXuatPDF.TabIndex = 53;
            this.btnXuatPDF.Text = "Xuất FILE";
            this.btnXuatPDF.Click += new System.EventHandler(this.btnXuatPDF_Click);
            // 
            // NhanVienBanHangTot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXuatPDF);
            this.Controls.Add(this.gridNhanVienBHT);
            this.Controls.Add(this.btntienhanh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.enddate);
            this.Controls.Add(this.startdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label1);
            this.Name = "NhanVienBanHangTot";
            this.Size = new System.Drawing.Size(1796, 973);
            this.Load += new System.EventHandler(this.NhanVienBanHangTot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridNhanVienBHT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CusTomTTKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDonViTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBangGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NgayMuaHangKH.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NgayMuaHangKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomNgayMuaHang.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomNgayMuaHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private Guna.UI2.WinForms.Guna2Button btntienhanh;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker enddate;
        private Guna.UI2.WinForms.Guna2DateTimePicker startdate;
        private DevExpress.XtraGrid.GridControl gridNhanVienBHT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn TenNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn TongTien;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit CusTomTTKH;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit CustomNgayMuaHang;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit tableDonViTinh;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit tableBangGia;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit NgayMuaHangKH;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnXuatPDF;
    }
}
