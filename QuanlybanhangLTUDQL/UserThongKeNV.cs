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
using Excel = Microsoft.Office.Interop.Excel;
using BLL;

namespace QuanlybanhangLTUDQL
{
    public partial class UserThongKeNV : UserControl
    {
        BLL_NhanVien BLL_NhanVien = new BLL_NhanVien();
        public UserThongKeNV()
        {
            InitializeComponent();
        }

        private void Rbuttheotien_CheckedChanged(object sender, EventArgs e)
        {
            //dtgvthongkenv.DataSource = BLL_NhanVien.NhanVien_TKSL();
            //chartthongkenv.Series.Clear();
            //Series series = new Series
            //{
            //    Name = "Tổng Số Lượng Bán Được",
            //    XValueMember = "Tên Nhân Viên",
            //    YValueMembers = "Số Lượng Sản Phẩm Bán Được",
            //    ChartType = SeriesChartType.Column,
            //    IsValueShownAsLabel = true
            //};

            //chartthongkenv.Series.Add(series);
            //chartthongkenv.DataSource = BLL_NhanVien.NhanVien_TKSL();
            //chartthongkenv.DataBind();
            //// Điều chỉnh thuộc tính của biểu đồ
            //chartthongkenv.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // Xoay nhãn trên trục X để dễ đọc hơn
            //chartthongkenv.ChartAreas[0].AxisX.Interval = 1; // Hiển thị tất cả các nhãn trục X
            //chartthongkenv.ChartAreas[0].AxisX.Title = "Tên Nhân Viên";
            //chartthongkenv.ChartAreas[0].AxisY.Title = "Số Lượng Sản Phẩm Bán Được";

            //chartthongkenv.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 12, FontStyle.Bold);
            //chartthongkenv.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 12, FontStyle.Bold);

            //chartthongkenv.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 10);
            //chartthongkenv.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Arial", 10);

            //chartthongkenv.ChartAreas[0].AxisY.LabelStyle.Format = "{0:0,}";
        }

        private void RbuttheoSL_CheckedChanged(object sender, EventArgs e)
        {
        //    DataTable dataTable = BLL_NhanVien.NhanVien_TKTT();
        //    dtgvthongkenv.DataSource = dataTable;
        //    chartthongkenv.Series.Clear();

        //    Series series = new Series
        //    {
        //        Name = "Tổng Số Tiền Bán Được",
        //        XValueMember = "Tên Nhân Viên",
        //        YValueMembers = "Tổng Số Tiền Bán Được",
        //        ChartType = SeriesChartType.Column,
        //        IsValueShownAsLabel = true
        //    };

        //    chartthongkenv.Series.Add(series);
        //    chartthongkenv.DataSource = dataTable;
        //    chartthongkenv.DataBind();

        //    // Điều chỉnh thuộc tính của biểu đồ
        //    chartthongkenv.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // Xoay nhãn trên trục X để dễ đọc hơn
        //    chartthongkenv.ChartAreas[0].AxisX.Interval = 1; // Hiển thị tất cả các nhãn trục X
        //    chartthongkenv.ChartAreas[0].AxisX.Title = "Tên Nhân Viên";
        //    chartthongkenv.ChartAreas[0].AxisY.Title = "Tổng Số Tiền Bán Được";

        //    chartthongkenv.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 12, FontStyle.Bold);
        //    chartthongkenv.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 12, FontStyle.Bold);

        //    chartthongkenv.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 10);
        //    chartthongkenv.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Arial", 10);

        //    chartthongkenv.ChartAreas[0].AxisY.LabelStyle.Format = "{0:0,}"; // Định dạng số có dấu phẩy
        }

        private void UserThongKeNV_Load(object sender, EventArgs e)
        {
            DataTable dataTable = BLL_NhanVien.NhanVien_TKTT();
            dtgvthongkenv.DataSource = dataTable;
            chartthongkenv.Series.Clear();

            Series series = new Series
            {
                Name = "Tổng Số Tiền Bán Được",
                XValueMember = "Tên Nhân Viên",
                YValueMembers = "Tổng Số Tiền Bán Được",
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true
            };

            chartthongkenv.Series.Add(series);
            chartthongkenv.DataSource = dataTable;
            chartthongkenv.DataBind();

            // Điều chỉnh thuộc tính của biểu đồ
            chartthongkenv.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // Xoay nhãn trên trục X để dễ đọc hơn
            chartthongkenv.ChartAreas[0].AxisX.Interval = 1; // Hiển thị tất cả các nhãn trục X
            chartthongkenv.ChartAreas[0].AxisX.Title = "Tên Nhân Viên";
            chartthongkenv.ChartAreas[0].AxisY.Title = "Tổng Số Tiền Bán Được";

            chartthongkenv.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 12, FontStyle.Bold);
            chartthongkenv.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 12, FontStyle.Bold);

            chartthongkenv.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 10);
            chartthongkenv.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Arial", 10);

            chartthongkenv.ChartAreas[0].AxisY.LabelStyle.Format = "{0:0,}"; // Định dạng số có dấu phẩy
        }

        private void butxuatex_Click(object sender, EventArgs e)
        {
            if (dtgvthongkenv.Rows.Count > 0)
            {
                // Tạo đối tượng Excel
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = true; // Hiển thị ứng dụng Excel

                // Thêm Workbook vào Excel
                Excel.Workbook workbook = excelApp.Workbooks.Add();

                // Thêm Worksheet vào Workbook
                Excel.Worksheet worksheet = workbook.Sheets[1];
                worksheet.Name = "Dữ liệu từ DataGridView";

                // Đổ dữ liệu từ DataGridView vào Excel
                for (int i = 0; i < dtgvthongkenv.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = dtgvthongkenv.Columns[i].HeaderText;
                    for (int j = 0; j < dtgvthongkenv.Rows.Count; j++)
                    {
                        if (dtgvthongkenv.Rows[j].Cells[i].Value != null)
                        {
                            worksheet.Cells[j + 2, i + 1] = dtgvthongkenv.Rows[j].Cells[i].Value.ToString();
                        }
                        else
                        {
                            worksheet.Cells[j + 2, i + 1] = "";
                        }
                    }
                }

                // Lưu file Excel và mở thông báo thành công
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("Xuất dữ liệu thành công!");
                }

                // Đóng Workbook và Excel Application
                workbook.Close();
                excelApp.Quit();

                // Giải phóng tài nguyên COM
                System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất!");
            }
        }

        private void butin_Click(object sender, EventArgs e)
        {
           XuatNV xuatNV = new XuatNV();
            xuatNV.Show();
        }
    }
}
    

