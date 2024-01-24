namespace QuanLyMiniMart
{
    partial class KhoSanPhamControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhoSanPhamControl));
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.gridSanPham = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CTGiaBan = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.MaLoaiSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkLoaiSp = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.MaGiaBanSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuongSanPhamToiThieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CusTomSlSp = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.HinhAnh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkDVTSP = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.CustomSoLuong = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.lkMaGiaBanSp = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.lkMaGiaBanSP1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.CusTomGiaBan = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.anhsp = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.hinhEditSP = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.hinhanhsp = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CTGiaBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkLoaiSp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CusTomSlSp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkDVTSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkMaGiaBanSp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkMaGiaBanSP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CusTomGiaBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anhsp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hinhEditSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hinhanhsp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Sản Phẩm";
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
            this.txtTimKiem.Location = new System.Drawing.Point(1059, 84);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderText = "";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(442, 45);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            this.txtTimKiem.Enter += new System.EventHandler(this.txtTimKiem_Enter);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(955, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tìm kiếm";
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
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.Location = new System.Drawing.Point(1112, 901);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(127, 54);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // gridSanPham
            // 
            this.gridSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridSanPham.Location = new System.Drawing.Point(60, 142);
            this.gridSanPham.MainView = this.gridView1;
            this.gridSanPham.Name = "gridSanPham";
            this.gridSanPham.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lkDVTSP,
            this.CustomSoLuong,
            this.lkMaGiaBanSp,
            this.lkLoaiSp,
            this.lkMaGiaBanSP1,
            this.CusTomGiaBan,
            this.CTGiaBan,
            this.CusTomSlSp,
            this.anhsp,
            this.repositoryItemImageEdit1,
            this.hinhEditSP,
            this.hinhanhsp});
            this.gridSanPham.Size = new System.Drawing.Size(1487, 753);
            this.gridSanPham.TabIndex = 9;
            this.gridSanPham.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaSanPham,
            this.TenSanPham,
            this.GiaBan,
            this.MaLoaiSanPham,
            this.MaGiaBanSanPham,
            this.SoLuongSanPhamToiThieu,
            this.HinhAnh});
            this.gridView1.GridControl = this.gridSanPham;
            this.gridView1.Name = "gridView1";
            this.gridView1.NewItemRowText = "Thêm mới sản phẩm tại đây";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged_1);
            this.gridView1.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gridView1_CustomUnboundColumnData);
            // 
            // MaSanPham
            // 
            this.MaSanPham.Caption = "MÃ SẢN PHẨM";
            this.MaSanPham.FieldName = "MaSanPham";
            this.MaSanPham.MaxWidth = 500;
            this.MaSanPham.MinWidth = 25;
            this.MaSanPham.Name = "MaSanPham";
            this.MaSanPham.Visible = true;
            this.MaSanPham.VisibleIndex = 0;
            this.MaSanPham.Width = 200;
            // 
            // TenSanPham
            // 
            this.TenSanPham.Caption = "TÊN SẢN PHẨM";
            this.TenSanPham.FieldName = "TenSanPham";
            this.TenSanPham.MaxWidth = 500;
            this.TenSanPham.MinWidth = 25;
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.Visible = true;
            this.TenSanPham.VisibleIndex = 1;
            this.TenSanPham.Width = 300;
            // 
            // GiaBan
            // 
            this.GiaBan.Caption = "GIÁ BÁN";
            this.GiaBan.ColumnEdit = this.CTGiaBan;
            this.GiaBan.DisplayFormat.FormatString = "N2";
            this.GiaBan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GiaBan.FieldName = "GiaBan";
            this.GiaBan.MaxWidth = 500;
            this.GiaBan.MinWidth = 25;
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.Visible = true;
            this.GiaBan.VisibleIndex = 2;
            this.GiaBan.Width = 200;
            // 
            // CTGiaBan
            // 
            this.CTGiaBan.AutoHeight = false;
            this.CTGiaBan.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.CTGiaBan.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.CTGiaBan.MaskSettings.Set("mask", "n");
            this.CTGiaBan.Name = "CTGiaBan";
            // 
            // MaLoaiSanPham
            // 
            this.MaLoaiSanPham.Caption = "LOẠI SẢN PHẨM";
            this.MaLoaiSanPham.ColumnEdit = this.lkLoaiSp;
            this.MaLoaiSanPham.FieldName = "MaLoaiSanPham";
            this.MaLoaiSanPham.MaxWidth = 500;
            this.MaLoaiSanPham.MinWidth = 25;
            this.MaLoaiSanPham.Name = "MaLoaiSanPham";
            this.MaLoaiSanPham.Visible = true;
            this.MaLoaiSanPham.VisibleIndex = 3;
            this.MaLoaiSanPham.Width = 230;
            // 
            // lkLoaiSp
            // 
            this.lkLoaiSp.AutoHeight = false;
            this.lkLoaiSp.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkLoaiSp.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaLoaiSanPham", "ID"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenLoaiSanPham", "Loại Sản Phẩm")});
            this.lkLoaiSp.Name = "lkLoaiSp";
            // 
            // MaGiaBanSanPham
            // 
            this.MaGiaBanSanPham.Caption = "MÃ giá sp";
            this.MaGiaBanSanPham.FieldName = "MaGiaBanSanPham";
            this.MaGiaBanSanPham.MinWidth = 25;
            this.MaGiaBanSanPham.Name = "MaGiaBanSanPham";
            this.MaGiaBanSanPham.Width = 94;
            // 
            // SoLuongSanPhamToiThieu
            // 
            this.SoLuongSanPhamToiThieu.Caption = "SL SP TỐI THIỂU";
            this.SoLuongSanPhamToiThieu.ColumnEdit = this.CusTomSlSp;
            this.SoLuongSanPhamToiThieu.DisplayFormat.FormatString = "N0";
            this.SoLuongSanPhamToiThieu.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SoLuongSanPhamToiThieu.FieldName = "SoLuongSanPhamToiThieu";
            this.SoLuongSanPhamToiThieu.MaxWidth = 500;
            this.SoLuongSanPhamToiThieu.MinWidth = 25;
            this.SoLuongSanPhamToiThieu.Name = "SoLuongSanPhamToiThieu";
            this.SoLuongSanPhamToiThieu.Visible = true;
            this.SoLuongSanPhamToiThieu.VisibleIndex = 4;
            this.SoLuongSanPhamToiThieu.Width = 220;
            // 
            // CusTomSlSp
            // 
            this.CusTomSlSp.AutoHeight = false;
            this.CusTomSlSp.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.CusTomSlSp.MaskSettings.Set("mask", "N0");
            this.CusTomSlSp.Name = "CusTomSlSp";
            // 
            // HinhAnh
            // 
            this.HinhAnh.Caption = "HÌNH ẢNH";
            this.HinhAnh.FieldName = "HinhAnh";
            this.HinhAnh.MaxWidth = 500;
            this.HinhAnh.MinWidth = 500;
            this.HinhAnh.Name = "HinhAnh";
            this.HinhAnh.Width = 500;
            // 
            // lkDVTSP
            // 
            this.lkDVTSP.AutoHeight = false;
            this.lkDVTSP.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkDVTSP.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaDonViTinh", "ID"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenDonViTinh", "Đơn Vị Tính")});
            this.lkDVTSP.Name = "lkDVTSP";
            // 
            // CustomSoLuong
            // 
            this.CustomSoLuong.AutoHeight = false;
            this.CustomSoLuong.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.CustomSoLuong.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.CustomSoLuong.MaskSettings.Set("mask", "N0");
            this.CustomSoLuong.Name = "CustomSoLuong";
            // 
            // lkMaGiaBanSp
            // 
            this.lkMaGiaBanSp.AutoHeight = false;
            this.lkMaGiaBanSp.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.lkMaGiaBanSp.MaskSettings.Set("mask", "n");
            this.lkMaGiaBanSp.Name = "lkMaGiaBanSp";
            // 
            // lkMaGiaBanSP1
            // 
            this.lkMaGiaBanSP1.AutoHeight = false;
            this.lkMaGiaBanSP1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkMaGiaBanSP1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaGiaBanSanPham", "ID"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GiaBan", "Giá Bán")});
            this.lkMaGiaBanSP1.Name = "lkMaGiaBanSP1";
            // 
            // CusTomGiaBan
            // 
            this.CusTomGiaBan.AutoHeight = false;
            this.CusTomGiaBan.Name = "CusTomGiaBan";
            // 
            // anhsp
            // 
            this.anhsp.AutoHeight = false;
            this.anhsp.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.anhsp.Name = "anhsp";
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            // 
            // hinhEditSP
            // 
            this.hinhEditSP.Name = "hinhEditSP";
            this.hinhEditSP.OptionsMask.MaskType = DevExpress.XtraEditors.Controls.PictureEditMaskType.Custom;
            this.hinhEditSP.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // hinhanhsp
            // 
            this.hinhanhsp.Name = "hinhanhsp";
            this.hinhanhsp.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.ImageOptions.Image = global::QuanLyMiniMart.Properties.Resources.XoaSP;
            this.btnXoa.Location = new System.Drawing.Point(1263, 901);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(123, 54);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(1422, 901);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(125, 54);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1056, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 15);
            this.label3.TabIndex = 38;
            this.label3.Text = "(Tìm kiếm theo mã sản phẩm hoặc theo tên sản phẩm*)";
            // 
            // KhoSanPhamControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.gridSanPham);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "KhoSanPhamControl";
            this.Size = new System.Drawing.Size(1562, 967);
            this.Load += new System.EventHandler(this.KhoSanPhamControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CTGiaBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkLoaiSp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CusTomSlSp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkDVTSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkMaGiaBanSp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkMaGiaBanSP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CusTomGiaBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anhsp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hinhEditSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hinhanhsp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraGrid.GridControl gridSanPham;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraGrid.Columns.GridColumn MaSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn TenSanPham;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lkDVTSP;
        private DevExpress.XtraGrid.Columns.GridColumn MaLoaiSanPham;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit CustomSoLuong;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit lkMaGiaBanSp;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lkLoaiSp;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lkMaGiaBanSP1;
        private DevExpress.XtraGrid.Columns.GridColumn GiaBan;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit CTGiaBan;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit CusTomGiaBan;
        private DevExpress.XtraGrid.Columns.GridColumn MaGiaBanSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuongSanPhamToiThieu;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit CusTomSlSp;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox anhsp;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit hinhEditSP;
        private DevExpress.XtraGrid.Columns.GridColumn HinhAnh;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit hinhanhsp;
    }
}
