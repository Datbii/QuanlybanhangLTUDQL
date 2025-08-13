namespace QuanlybanhangLTUDQL
{
    partial class UserDoanhThu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Butin = new Guna.UI2.WinForms.Guna2Button();
            this.btnDuBaoDoanhThu = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.chartthongkedt = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtgvthongkedt = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.chartthongkedt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvthongkedt)).BeginInit();
            this.SuspendLayout();
            // 
            // Butin
            // 
            this.Butin.BorderRadius = 5;
            this.Butin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Butin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Butin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Butin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Butin.FillColor = System.Drawing.Color.RoyalBlue;
            this.Butin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Butin.ForeColor = System.Drawing.Color.White;
            this.Butin.Location = new System.Drawing.Point(6, 370);
            this.Butin.Name = "Butin";
            this.Butin.Size = new System.Drawing.Size(107, 45);
            this.Butin.TabIndex = 73;
            this.Butin.Text = "In báo cáo";
            this.Butin.Click += new System.EventHandler(this.Butin_Click);
            // 
            // btnDuBaoDoanhThu
            // 
            this.btnDuBaoDoanhThu.BorderRadius = 5;
            this.btnDuBaoDoanhThu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDuBaoDoanhThu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDuBaoDoanhThu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDuBaoDoanhThu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDuBaoDoanhThu.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnDuBaoDoanhThu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuBaoDoanhThu.ForeColor = System.Drawing.Color.White;
            this.btnDuBaoDoanhThu.Location = new System.Drawing.Point(122, 370);
            this.btnDuBaoDoanhThu.Name = "btnDuBaoDoanhThu";
            this.btnDuBaoDoanhThu.Size = new System.Drawing.Size(107, 45);
            this.btnDuBaoDoanhThu.TabIndex = 72;
            this.btnDuBaoDoanhThu.Text = "Dự Báo";
            this.btnDuBaoDoanhThu.Click += new System.EventHandler(this.butxuatex_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(369, 25);
            this.label7.TabIndex = 71;
            this.label7.Text = "BẢNG DOANH THU THEO THÁNG";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // chartthongkedt
            // 
            chartArea1.Name = "ChartArea1";
            this.chartthongkedt.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartthongkedt.Legends.Add(legend1);
            this.chartthongkedt.Location = new System.Drawing.Point(472, 7);
            this.chartthongkedt.Name = "chartthongkedt";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartthongkedt.Series.Add(series1);
            this.chartthongkedt.Size = new System.Drawing.Size(553, 412);
            this.chartthongkedt.TabIndex = 70;
            this.chartthongkedt.Text = "chart1";
            this.chartthongkedt.Click += new System.EventHandler(this.chartthongkesp_Click);
            // 
            // dtgvthongkedt
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgvthongkedt.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvthongkedt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvthongkedt.ColumnHeadersHeight = 4;
            this.dtgvthongkedt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvthongkedt.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvthongkedt.GridColor = System.Drawing.Color.DarkCyan;
            this.dtgvthongkedt.Location = new System.Drawing.Point(6, 44);
            this.dtgvthongkedt.Name = "dtgvthongkedt";
            this.dtgvthongkedt.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvthongkedt.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvthongkedt.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkCyan;
            this.dtgvthongkedt.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvthongkedt.Size = new System.Drawing.Size(457, 320);
            this.dtgvthongkedt.TabIndex = 69;
            this.dtgvthongkedt.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvthongkedt.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvthongkedt.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvthongkedt.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvthongkedt.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvthongkedt.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvthongkedt.ThemeStyle.GridColor = System.Drawing.Color.DarkCyan;
            this.dtgvthongkedt.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkCyan;
            this.dtgvthongkedt.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvthongkedt.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvthongkedt.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvthongkedt.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvthongkedt.ThemeStyle.HeaderStyle.Height = 4;
            this.dtgvthongkedt.ThemeStyle.ReadOnly = true;
            this.dtgvthongkedt.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvthongkedt.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvthongkedt.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvthongkedt.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvthongkedt.ThemeStyle.RowsStyle.Height = 22;
            this.dtgvthongkedt.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvthongkedt.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvthongkedt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvthongkesp_CellContentClick);
            // 
            // UserDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Butin);
            this.Controls.Add(this.btnDuBaoDoanhThu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chartthongkedt);
            this.Controls.Add(this.dtgvthongkedt);
            this.Name = "UserDoanhThu";
            this.Size = new System.Drawing.Size(1031, 426);
            this.Load += new System.EventHandler(this.UserDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartthongkedt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvthongkedt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button Butin;
        private Guna.UI2.WinForms.Guna2Button btnDuBaoDoanhThu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartthongkedt;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvthongkedt;
    }
}
