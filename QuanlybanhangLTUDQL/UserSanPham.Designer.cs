namespace QuanlybanhangLTUDQL
{
    partial class UserSanPham
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Butin = new Guna.UI2.WinForms.Guna2Button();
            this.butxuatex = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.chartthongkesp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtgvthongkesp = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.chartthongkesp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvthongkesp)).BeginInit();
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
            this.Butin.Location = new System.Drawing.Point(6, 353);
            this.Butin.Name = "Butin";
            this.Butin.Size = new System.Drawing.Size(107, 45);
            this.Butin.TabIndex = 68;
            this.Butin.Text = "In báo cáo";
            this.Butin.Click += new System.EventHandler(this.Butin_Click);
            // 
            // butxuatex
            // 
            this.butxuatex.BorderRadius = 5;
            this.butxuatex.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butxuatex.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butxuatex.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butxuatex.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butxuatex.FillColor = System.Drawing.Color.RoyalBlue;
            this.butxuatex.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butxuatex.ForeColor = System.Drawing.Color.White;
            this.butxuatex.Location = new System.Drawing.Point(122, 353);
            this.butxuatex.Name = "butxuatex";
            this.butxuatex.Size = new System.Drawing.Size(107, 45);
            this.butxuatex.TabIndex = 67;
            this.butxuatex.Text = "Xuất file exel";
            this.butxuatex.Click += new System.EventHandler(this.butxuatex_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(59, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(324, 25);
            this.label7.TabIndex = 66;
            this.label7.Text = "BẢNG THỐNG KÊ SẢN PHẨM";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // chartthongkesp
            // 
            chartArea4.Name = "ChartArea1";
            this.chartthongkesp.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartthongkesp.Legends.Add(legend4);
            this.chartthongkesp.Location = new System.Drawing.Point(472, 7);
            this.chartthongkesp.Name = "chartthongkesp";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartthongkesp.Series.Add(series4);
            this.chartthongkesp.Size = new System.Drawing.Size(553, 412);
            this.chartthongkesp.TabIndex = 65;
            this.chartthongkesp.Text = "chart1";
            this.chartthongkesp.Click += new System.EventHandler(this.chartthongkekh_Click);
            // 
            // dtgvthongkesp
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.dtgvthongkesp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvthongkesp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dtgvthongkesp.ColumnHeadersHeight = 4;
            this.dtgvthongkesp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvthongkesp.DefaultCellStyle = dataGridViewCellStyle18;
            this.dtgvthongkesp.GridColor = System.Drawing.Color.DarkCyan;
            this.dtgvthongkesp.Location = new System.Drawing.Point(6, 44);
            this.dtgvthongkesp.Name = "dtgvthongkesp";
            this.dtgvthongkesp.ReadOnly = true;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvthongkesp.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dtgvthongkesp.RowHeadersVisible = false;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.DarkCyan;
            this.dtgvthongkesp.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dtgvthongkesp.Size = new System.Drawing.Size(457, 303);
            this.dtgvthongkesp.TabIndex = 64;
            this.dtgvthongkesp.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvthongkesp.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvthongkesp.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvthongkesp.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvthongkesp.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvthongkesp.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvthongkesp.ThemeStyle.GridColor = System.Drawing.Color.DarkCyan;
            this.dtgvthongkesp.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkCyan;
            this.dtgvthongkesp.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvthongkesp.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvthongkesp.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvthongkesp.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvthongkesp.ThemeStyle.HeaderStyle.Height = 4;
            this.dtgvthongkesp.ThemeStyle.ReadOnly = true;
            this.dtgvthongkesp.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvthongkesp.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvthongkesp.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvthongkesp.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvthongkesp.ThemeStyle.RowsStyle.Height = 22;
            this.dtgvthongkesp.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvthongkesp.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvthongkesp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvthongkekh_CellContentClick);
            // 
            // UserSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Butin);
            this.Controls.Add(this.butxuatex);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chartthongkesp);
            this.Controls.Add(this.dtgvthongkesp);
            this.Name = "UserSanPham";
            this.Size = new System.Drawing.Size(1031, 426);
            this.Load += new System.EventHandler(this.UserSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartthongkesp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvthongkesp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button Butin;
        private Guna.UI2.WinForms.Guna2Button butxuatex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartthongkesp;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvthongkesp;
    }
}
