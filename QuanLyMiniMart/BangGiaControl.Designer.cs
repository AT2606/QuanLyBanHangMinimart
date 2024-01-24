namespace QuanLyMiniMart
{
    partial class BangGiaControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BangGiaControl));
            this.lkDonViTinh = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CustomGia = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.NgayApDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CustomNgayApDung = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridBangGia = new DevExpress.XtraGrid.GridControl();
            this.tableBangGia = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lkDonViTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomNgayApDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomNgayApDung.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBangGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBangGia)).BeginInit();
            this.SuspendLayout();
            // 
            // lkDonViTinh
            // 
            this.lkDonViTinh.AutoHeight = false;
            this.lkDonViTinh.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkDonViTinh.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaDonViTinh", "ID"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenDonViTinh", "Đơn Vị Tính")});
            this.lkDonViTinh.Name = "lkDonViTinh";
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaSanPham,
            this.TenDonViTinh,
            this.GiaBan,
            this.NgayApDung});
            this.gridView1.GridControl = this.gridBangGia;
            this.gridView1.Name = "gridView1";
            this.gridView1.NewItemRowText = "Thêm mới bảng giá sản phẩm tại đây";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            // 
            // MaSanPham
            // 
            this.MaSanPham.Caption = "MÃ SẢN PHẨM";
            this.MaSanPham.FieldName = "MaSanPham";
            this.MaSanPham.MinWidth = 25;
            this.MaSanPham.Name = "MaSanPham";
            this.MaSanPham.Visible = true;
            this.MaSanPham.VisibleIndex = 0;
            this.MaSanPham.Width = 200;
            // 
            // TenDonViTinh
            // 
            this.TenDonViTinh.Caption = "ĐƠN VỊ TÍNH";
            this.TenDonViTinh.ColumnEdit = this.lkDonViTinh;
            this.TenDonViTinh.FieldName = "TenDonViTinh";
            this.TenDonViTinh.MinWidth = 25;
            this.TenDonViTinh.Name = "TenDonViTinh";
            this.TenDonViTinh.Visible = true;
            this.TenDonViTinh.VisibleIndex = 1;
            this.TenDonViTinh.Width = 227;
            // 
            // GiaBan
            // 
            this.GiaBan.Caption = "GIÁ";
            this.GiaBan.ColumnEdit = this.CustomGia;
            this.GiaBan.DisplayFormat.FormatString = "N2";
            this.GiaBan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaBan.FieldName = "GiaBan";
            this.GiaBan.MinWidth = 25;
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.Visible = true;
            this.GiaBan.VisibleIndex = 2;
            this.GiaBan.Width = 220;
            // 
            // CustomGia
            // 
            this.CustomGia.AutoHeight = false;
            this.CustomGia.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.CustomGia.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.CustomGia.MaskSettings.Set("mask", "n");
            this.CustomGia.Name = "CustomGia";
            // 
            // NgayApDung
            // 
            this.NgayApDung.Caption = "NGÀY ÁP DỤNG";
            this.NgayApDung.ColumnEdit = this.CustomNgayApDung;
            this.NgayApDung.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.NgayApDung.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.NgayApDung.FieldName = "NgayApDung";
            this.NgayApDung.MinWidth = 25;
            this.NgayApDung.Name = "NgayApDung";
            this.NgayApDung.Visible = true;
            this.NgayApDung.VisibleIndex = 3;
            this.NgayApDung.Width = 288;
            // 
            // CustomNgayApDung
            // 
            this.CustomNgayApDung.AutoHeight = false;
            this.CustomNgayApDung.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CustomNgayApDung.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CustomNgayApDung.MaskSettings.Set("mask", "dd/MM/yyyy");
            this.CustomNgayApDung.Name = "CustomNgayApDung";
            // 
            // gridBangGia
            // 
            this.gridBangGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridBangGia.Location = new System.Drawing.Point(62, 132);
            this.gridBangGia.MainView = this.gridView1;
            this.gridBangGia.Name = "gridBangGia";
            this.gridBangGia.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lkDonViTinh,
            this.tableBangGia,
            this.CustomNgayApDung,
            this.CustomGia});
            this.gridBangGia.Size = new System.Drawing.Size(1700, 765);
            this.gridBangGia.TabIndex = 17;
            this.gridBangGia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1297, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.AutoRoundedCorners = true;
            this.txtTimKiem.BorderRadius = 21;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "Tìm kiếm giá sản phẩm";
            this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Location = new System.Drawing.Point(1288, 65);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderText = "";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(480, 45);
            this.txtTimKiem.TabIndex = 13;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            this.txtTimKiem.Enter += new System.EventHandler(this.txtTimKiem_Enter);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 38);
            this.label1.TabIndex = 12;
            this.label1.Text = "Bảng Giá Sản Phẩm";
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(1655, 903);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(107, 54);
            this.btnThoat.TabIndex = 19;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.ImageOptions.Image = global::QuanLyMiniMart.Properties.Resources.XoaSP;
            this.btnXoa.Location = new System.Drawing.Point(1510, 903);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(107, 54);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.Location = new System.Drawing.Point(1362, 903);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(107, 54);
            this.btnLuu.TabIndex = 16;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1394, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(309, 15);
            this.label3.TabIndex = 38;
            this.label3.Text = "(Tìm kiếm theo mã sản phẩm hoặc theo ngày áp dụng*)";
            // 
            // BangGiaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.gridBangGia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label1);
            this.Name = "BangGiaControl";
            this.Size = new System.Drawing.Size(1799, 967);
            this.Load += new System.EventHandler(this.BangGiaControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lkDonViTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomNgayApDung.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomNgayApDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBangGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBangGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraGrid.Columns.GridColumn NgayApDung;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lkDonViTinh;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridBangGia;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit tableBangGia;
        private DevExpress.XtraGrid.Columns.GridColumn GiaBan;
        private DevExpress.XtraGrid.Columns.GridColumn TenDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn MaSanPham;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit CustomNgayApDung;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit CustomGia;
        private System.Windows.Forms.Label label3;
    }
}
