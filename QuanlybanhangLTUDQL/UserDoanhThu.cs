using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BLL;
namespace QuanlybanhangLTUDQL
{
    public partial class UserDoanhThu : UserControl
    {
        BLL_HoaDon BLL_HoaDon = new BLL_HoaDon();
        public UserDoanhThu()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void butxuatex_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dtgvthongkedt.DataSource;
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để dự báo.");
                return;
            }

            // Chuẩn bị dữ liệu cho hồi quy tuyến tính
            int n = dt.Rows.Count;
            double[] x = new double[n];
            double[] y = new double[n];
            for (int i = 0; i < n; i++)
            {
                x[i] = i + 1; // Giả sử các tháng liên tiếp
                y[i] = Convert.ToDouble(dt.Rows[i]["Tổng Doanh Thu"]);
            }

            // Tính toán các hệ số của phương trình hồi quy tuyến tính y = a + bx
            double sumX = x.Sum();
            double sumY = y.Sum();
            double sumXY = x.Select((xi, idx) => xi * y[idx]).Sum();
            double sumX2 = x.Select(xi => xi * xi).Sum();

            double b = (n * sumXY - sumX * sumY) / (n * sumX2 - sumX * sumX);
            double a = (sumY - b * sumX) / n;

            // Dự báo doanh thu cho tháng tiếp theo
            double nextX = n + 1;
            double duBaoDoanhThu = a + b * nextX;
            MessageBox.Show($"Dự báo doanh thu cho tháng tiếp theo: {duBaoDoanhThu:0,0} VND");

            // Cập nhật biểu đồ với dự báo
            DataRow lastRow = dt.Rows[dt.Rows.Count - 1];
            int lastMonth = Convert.ToInt32(lastRow["Tháng"]);
            int lastYear = Convert.ToInt32(lastRow["Năm"]);

            int nextMonth = lastMonth == 12 ? 1 : lastMonth + 1;
            int nextYear = lastMonth == 12 ? lastYear + 1 : lastYear;

         

       
        
    }


        private void Butin_Click(object sender, EventArgs e)
        {
            FormXUATDT frm = new FormXUATDT();
            frm.Show();
        }

        private void chartthongkesp_Click(object sender, EventArgs e)
        {

        }

        private void dtgvthongkesp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserDoanhThu_Load(object sender, EventArgs e)
        {
            dtgvthongkedt.DataSource =BLL_HoaDon.thongkedoanhthu();
            chartthongkedt.Series.Clear();
            Series series = new Series
            {
                Name = "Tổng Doanh Thu",
                XValueMember = "Tháng",
                YValueMembers = "Tổng Doanh Thu",
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true
            };

            chartthongkedt.Series.Add(series);
            chartthongkedt.DataSource = BLL_HoaDon.thongkedoanhthu();
            chartthongkedt.DataBind();
            // Điều chỉnh thuộc tính của biểu đồ
            chartthongkedt.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // Xoay nhãn trên trục X để dễ đọc hơn
            chartthongkedt.ChartAreas[0].AxisX.Interval = 1; // Hiển thị tất cả các nhãn trục X
            chartthongkedt.ChartAreas[0].AxisX.Title = "Tháng";
            chartthongkedt.ChartAreas[0].AxisY.Title = "Tổng Doanh Thu";

            chartthongkedt.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 12, FontStyle.Bold);
            chartthongkedt.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 12, FontStyle.Bold);

            chartthongkedt.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 10);
            chartthongkedt.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Arial", 10);

            chartthongkedt.ChartAreas[0].AxisY.LabelStyle.Format = "{0:0,}";
        }
    }
}
