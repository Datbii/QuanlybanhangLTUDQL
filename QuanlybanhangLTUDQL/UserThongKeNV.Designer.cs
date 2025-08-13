namespace QuanlybanhangLTUDQL
{
    partial class UserThongKeNV
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
            this.butxuatex = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.chartthongkenv = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtgvthongkenv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.butin = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartthongkenv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvthongkenv)).BeginInit();
            this.SuspendLayout();
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
            this.butxuatex.Location = new System.Drawing.Point(132, 368);
            this.butxuatex.Name = "butxuatex";
            this.butxuatex.Size = new System.Drawing.Size(107, 45);
            this.butxuatex.TabIndex = 68;
            this.butxuatex.Text = "Xuất file exel";
            this.butxuatex.Click += new System.EventHandler(this.butxuatex_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(58, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(328, 25);
            this.label7.TabIndex = 65;
            this.label7.Text = "BẢNG THỐNG KÊ NHÂN VIÊN";
            // 
            // chartthongkenv
            // 
            chartArea1.Name = "ChartArea1";
            this.chartthongkenv.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartthongkenv.Legends.Add(legend1);
            this.chartthongkenv.Location = new System.Drawing.Point(470, 7);
            this.chartthongkenv.Name = "chartthongkenv";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartthongkenv.Series.Add(series1);
            this.chartthongkenv.Size = new System.Drawing.Size(553, 412);
            this.chartthongkenv.TabIndex = 64;
            this.chartthongkenv.Text = "chart1";
            // 
            // dtgvthongkenv
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgvthongkenv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvthongkenv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvthongkenv.ColumnHeadersHeight = 4;
            this.dtgvthongkenv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvthongkenv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvthongkenv.GridColor = System.Drawing.Color.DarkCyan;
            this.dtgvthongkenv.Location = new System.Drawing.Point(7, 44);
            this.dtgvthongkenv.Name = "dtgvthongkenv";
            this.dtgvthongkenv.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvthongkenv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvthongkenv.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkCyan;
            this.dtgvthongkenv.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvthongkenv.Size = new System.Drawing.Size(457, 318);
            this.dtgvthongkenv.TabIndex = 63;
            this.dtgvthongkenv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvthongkenv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvthongkenv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvthongkenv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvthongkenv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvthongkenv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvthongkenv.ThemeStyle.GridColor = System.Drawing.Color.DarkCyan;
            this.dtgvthongkenv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkCyan;
            this.dtgvthongkenv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvthongkenv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvthongkenv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvthongkenv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvthongkenv.ThemeStyle.HeaderStyle.Height = 4;
            this.dtgvthongkenv.ThemeStyle.ReadOnly = true;
            this.dtgvthongkenv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvthongkenv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvthongkenv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvthongkenv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvthongkenv.ThemeStyle.RowsStyle.Height = 22;
            this.dtgvthongkenv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvthongkenv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // butin
            // 
            this.butin.BorderRadius = 5;
            this.butin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butin.FillColor = System.Drawing.Color.RoyalBlue;
            this.butin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butin.ForeColor = System.Drawing.Color.White;
            this.butin.Location = new System.Drawing.Point(7, 368);
            this.butin.Name = "butin";
            this.butin.Size = new System.Drawing.Size(107, 45);
            this.butin.TabIndex = 69;
            this.butin.Text = "In báo cáo";
            this.butin.Click += new System.EventHandler(this.butin_Click);
            // 
            // UserThongKeNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.butin);
            this.Controls.Add(this.butxuatex);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chartthongkenv);
            this.Controls.Add(this.dtgvthongkenv);
            this.Name = "UserThongKeNV";
            this.Size = new System.Drawing.Size(1031, 426);
            this.Load += new System.EventHandler(this.UserThongKeNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartthongkenv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvthongkenv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button butxuatex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartthongkenv;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvthongkenv;
        private Guna.UI2.WinForms.Guna2Button butin;
    }
}
