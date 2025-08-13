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
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanlybanhangLTUDQL
{
    public partial class UserSanPham : UserControl
    {
        public UserSanPham()
        {
            InitializeComponent();
        }
        BLL_HangHoa BLL_HangHoa = new BLL_HangHoa();
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void butxuatex_Click(object sender, EventArgs e)
        {
            if (dtgvthongkesp.Rows.Count > 0)
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
                for (int i = 0; i < dtgvthongkesp.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = dtgvthongkesp.Columns[i].HeaderText;
                    for (int j = 0; j < dtgvthongkesp.Rows.Count; j++)
                    {
                        if (dtgvthongkesp.Rows[j].Cells[i].Value != null)
                        {
                            worksheet.Cells[j + 2, i + 1] = dtgvthongkesp.Rows[j].Cells[i].Value.ToString();
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

    

    private void Butin_Click(object sender, EventArgs e)
        {
        FormXUATSP formXUATSP = new FormXUATSP();
            formXUATSP.Show();
        }

        private void chartthongkekh_Click(object sender, EventArgs e)
        {

        }

        private void dtgvthongkekh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserSanPham_Load(object sender, EventArgs e)
        {
            dtgvthongkesp.DataSource = BLL_HangHoa.HangHoa_thongke();
            chartthongkesp.Series.Clear();
            Series series = new Series
            {
                Name = "Top 10 sản phẩm bán chạy",
                XValueMember = "Tên Sản Phẩm",
                YValueMembers = "Tổng Số Lượng Bán Được",
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true
            };

            chartthongkesp.Series.Add(series);
            chartthongkesp.DataSource = BLL_HangHoa.HangHoa_thongke();
            chartthongkesp.DataBind();
            // Điều chỉnh thuộc tính của biểu đồ
            chartthongkesp.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // Xoay nhãn trên trục X để dễ đọc hơn
            chartthongkesp.ChartAreas[0].AxisX.Interval = 1; // Hiển thị tất cả các nhãn trục X
            chartthongkesp.ChartAreas[0].AxisX.Title = "Tên Sản Phẩm";
            chartthongkesp.ChartAreas[0].AxisY.Title = "Tổng Số Lượng Bán Được";

            chartthongkesp.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 12, FontStyle.Bold);
            chartthongkesp.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 12, FontStyle.Bold);

            chartthongkesp.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 10);
            chartthongkesp.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Arial", 10);

            chartthongkesp.ChartAreas[0].AxisY.LabelStyle.Format = "{0:0,}";
        }   
    }
}
