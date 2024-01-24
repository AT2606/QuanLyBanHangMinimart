namespace QuanLyMiniMart
{
    partial class TonKhoControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TonKhoControl));
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.CustomGiaTon = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.tableDonViTinh = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.TenSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SoLuongTon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CustomSl1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.NgaySanXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CustoNgay = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.HanSuDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSanPhamTonKho = new DevExpress.XtraGrid.GridControl();
            this.CusTomSL = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.btnXuat = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CustomGiaTon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDonViTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomSl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustoNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustoNgay.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSanPhamTonKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CusTomSL)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(1599, 900);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(123, 54);
            this.btnThoat.TabIndex = 19;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // CustomGiaTon
            // 
            this.CustomGiaTon.AutoHeight = false;
            this.CustomGiaTon.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.CustomGiaTon.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.CustomGiaTon.MaskSettings.Set("mask", "n");
            this.CustomGiaTon.Name = "CustomGiaTon";
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
            // TenSanPham
            // 
            this.TenSanPham.Caption = "TÊN SẢN PHẨM";
            this.TenSanPham.FieldName = "TenSanPham";
            this.TenSanPham.MinWidth = 25;
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.Visible = true;
            this.TenSanPham.VisibleIndex = 1;
            this.TenSanPham.Width = 375;
            // 
            // MaSanPham
            // 
            this.MaSanPham.Caption = "MÃ SẢN PHẨM";
            this.MaSanPham.FieldName = "MaSanPham";
            this.MaSanPham.MinWidth = 25;
            this.MaSanPham.Name = "MaSanPham";
            this.MaSanPham.Visible = true;
            this.MaSanPham.VisibleIndex = 0;
            this.MaSanPham.Width = 187;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaSanPham,
            this.TenSanPham,
            this.SoLuongTon,
            this.NgaySanXuat,
            this.HanSuDung});
            this.gridView1.GridControl = this.gridSanPhamTonKho;
            this.gridView1.Name = "gridView1";
            this.gridView1.NewItemRowText = "Thêm sản phẩm tồn kho tại đây";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            // 
            // SoLuongTon
            // 
            this.SoLuongTon.Caption = "SỐ LƯỢNG TỒN";
            this.SoLuongTon.ColumnEdit = this.CustomSl1;
            this.SoLuongTon.DisplayFormat.FormatString = "N0";
            this.SoLuongTon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SoLuongTon.FieldName = "SoLuongTon";
            this.SoLuongTon.MinWidth = 25;
            this.SoLuongTon.Name = "SoLuongTon";
            this.SoLuongTon.Visible = true;
            this.SoLuongTon.VisibleIndex = 2;
            this.SoLuongTon.Width = 143;
            // 
            // CustomSl1
            // 
            this.CustomSl1.AutoHeight = false;
            this.CustomSl1.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.CustomSl1.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.CustomSl1.MaskSettings.Set("mask", "N0");
            this.CustomSl1.Name = "CustomSl1";
            // 
            // NgaySanXuat
            // 
            this.NgaySanXuat.Caption = "NGÀY SẢN XUẤT";
            this.NgaySanXuat.ColumnEdit = this.CustoNgay;
            this.NgaySanXuat.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.NgaySanXuat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.NgaySanXuat.FieldName = "NgaySanXuat";
            this.NgaySanXuat.MinWidth = 25;
            this.NgaySanXuat.Name = "NgaySanXuat";
            this.NgaySanXuat.Visible = true;
            this.NgaySanXuat.VisibleIndex = 3;
            this.NgaySanXuat.Width = 150;
            // 
            // CustoNgay
            // 
            this.CustoNgay.AutoHeight = false;
            this.CustoNgay.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CustoNgay.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CustoNgay.MaskSettings.Set("mask", "dd/MM/yyyy");
            this.CustoNgay.Name = "CustoNgay";
            // 
            // HanSuDung
            // 
            this.HanSuDung.Caption = "HẠN SỬ DỤNG";
            this.HanSuDung.ColumnEdit = this.CustoNgay;
            this.HanSuDung.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.HanSuDung.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.HanSuDung.FieldName = "HanSuDung";
            this.HanSuDung.MinWidth = 25;
            this.HanSuDung.Name = "HanSuDung";
            this.HanSuDung.Visible = true;
            this.HanSuDung.VisibleIndex = 4;
            this.HanSuDung.Width = 150;
            // 
            // gridSanPhamTonKho
            // 
            this.gridSanPhamTonKho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridSanPhamTonKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridSanPhamTonKho.Location = new System.Drawing.Point(56, 135);
            this.gridSanPhamTonKho.MainView = this.gridView1;
            this.gridSanPhamTonKho.Name = "gridSanPhamTonKho";
            this.gridSanPhamTonKho.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.tableDonViTinh,
            this.CusTomSL,
            this.CustomGiaTon,
            this.CustomSl1,
            this.CustoNgay});
            this.gridSanPhamTonKho.Size = new System.Drawing.Size(1666, 759);
            this.gridSanPhamTonKho.TabIndex = 17;
            this.gridSanPhamTonKho.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // CusTomSL
            // 
            this.CusTomSL.AutoHeight = false;
            this.CusTomSL.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.CusTomSL.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.CusTomSL.MaskSettings.Set("mask", "n");
            this.CusTomSL.Name = "CusTomSL";
            // 
            // btnXuat
            // 
            this.btnXuat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXuat.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuat.Appearance.Options.UseFont = true;
            this.btnXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXuat.ImageOptions.Image")));
            this.btnXuat.Location = new System.Drawing.Point(1445, 900);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(128, 54);
            this.btnXuat.TabIndex = 16;
            this.btnXuat.Text = "Xuất File";
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn2.FillWeight = 200F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
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
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 200;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 200;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1051, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.AutoRoundedCorners = true;
            this.txtTimKiem.BorderRadius = 21;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "Tìm kiếm sản phẩm";
            this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Location = new System.Drawing.Point(1055, 77);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderText = "";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(667, 45);
            this.txtTimKiem.TabIndex = 13;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            this.txtTimKiem.Enter += new System.EventHandler(this.txtTimKiem_Enter);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 38);
            this.label1.TabIndex = 12;
            this.label1.Text = "Danh Sách Sản Phẩm Tồn Kho";
            // 
            // TonKhoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.gridSanPhamTonKho);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label1);
            this.Name = "TonKhoControl";
            this.Size = new System.Drawing.Size(1787, 967);
            this.Load += new System.EventHandler(this.TonKhoControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomGiaTon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDonViTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomSl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustoNgay.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustoNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSanPhamTonKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CusTomSL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit tableDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn TenSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn MaSanPham;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridSanPhamTonKho;
        private DevExpress.XtraEditors.SimpleButton btnXuat;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuongTon;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit CusTomSL;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit CustomGiaTon;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit CustomSl1;
        private DevExpress.XtraGrid.Columns.GridColumn NgaySanXuat;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit CustoNgay;
        private DevExpress.XtraGrid.Columns.GridColumn HanSuDung;
    }
}
