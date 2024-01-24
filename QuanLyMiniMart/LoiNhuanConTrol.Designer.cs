namespace QuanLyMiniMart
{
    partial class LoiNhuanConTrol
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.startdate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.enddate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btntienhanh = new Guna.UI2.WinForms.Guna2Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Hand;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(23, 113);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Chi Phí Nhập";
            series1.YValuesPerPoint = 2;
            series2.ChartArea = "ChartArea1";
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Legend1";
            series2.Name = "Doanh Thu";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Lợi Nhuận";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(1009, 503);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseMove);
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
            this.startdate.Location = new System.Drawing.Point(23, 38);
            this.startdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.startdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.startdate.Name = "startdate";
            this.startdate.Size = new System.Drawing.Size(172, 36);
            this.startdate.TabIndex = 3;
            this.startdate.Value = new System.DateTime(2023, 12, 30, 22, 26, 27, 283);
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
            this.enddate.Location = new System.Drawing.Point(299, 38);
            this.enddate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.enddate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.enddate.Name = "enddate";
            this.enddate.Size = new System.Drawing.Size(172, 36);
            this.enddate.TabIndex = 4;
            this.enddate.Value = new System.DateTime(2023, 12, 30, 22, 26, 27, 283);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 5;
            this.label2.Tag = "";
            this.label2.Text = "ĐẾN";
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
            this.btntienhanh.Location = new System.Drawing.Point(518, 38);
            this.btntienhanh.Name = "btntienhanh";
            this.btntienhanh.Size = new System.Drawing.Size(148, 36);
            this.btntienhanh.TabIndex = 6;
            this.btntienhanh.Text = "Tiến hành";
            this.btntienhanh.Click += new System.EventHandler(this.btntienhanh_Click);
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(1058, 113);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Số lượng";
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(665, 503);
            this.chart2.TabIndex = 7;
            this.chart2.Text = "chart2";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Biểu đồ về sản phẩm bán được";
            this.chart2.Titles.Add(title1);
            this.chart2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart2_MouseMove);
            // 
            // LoiNhuanConTrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.btntienhanh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.enddate);
            this.Controls.Add(this.startdate);
            this.Controls.Add(this.chart1);
            this.Name = "LoiNhuanConTrol";
            this.Size = new System.Drawing.Size(1738, 675);
            this.Load += new System.EventHandler(this.LoiNhuanConTrol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Guna.UI2.WinForms.Guna2DateTimePicker startdate;
        private Guna.UI2.WinForms.Guna2DateTimePicker enddate;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btntienhanh;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}
