using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BLL;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanlybanhangLTUDQL
{
    public partial class UserThongKeKH : UserControl
    {
        BLL_KhachHang KHACHHANG = new BLL_KhachHang();
        public UserThongKeKH()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void butxuatex_Click(object sender, EventArgs e)
        {
            if (dtgvthongkekh.Rows.Count > 0)
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
                for (int i = 0; i < dtgvthongkekh.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = dtgvthongkekh.Columns[i].HeaderText;
                    for (int j = 0; j < dtgvthongkekh.Rows.Count; j++)
                    {
                        if (dtgvthongkekh.Rows[j].Cells[i].Value != null)
                        {
                            worksheet.Cells[j + 2, i + 1] = dtgvthongkekh.Rows[j].Cells[i].Value.ToString();
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
           
                XuatThongKe xuatThongKe = new XuatThongKe();
                xuatThongKe.Show();
                
        }

        private void UserThongKeKH_Load(object sender, EventArgs e)
        {
            dtgvthongkekh.DataSource = KHACHHANG.KhachHang_Thongke_tien();
            chartthongkekh.Series.Clear();
            Series series = new Series
            {
                Name = "Tổng Tiền Mua",
                XValueMember = "Tên Khách Hàng",
                YValueMembers = "Tổng Tiền Mua",
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true
            };

            chartthongkekh.Series.Add(series);
            chartthongkekh.DataSource = KHACHHANG.KhachHang_Thongke_tien();
            chartthongkekh.DataBind();
            // Điều chỉnh thuộc tính của biểu đồ
            chartthongkekh.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // Xoay nhãn trên trục X để dễ đọc hơn
            chartthongkekh.ChartAreas[0].AxisX.Interval = 1; // Hiển thị tất cả các nhãn trục X
            chartthongkekh.ChartAreas[0].AxisX.Title = "Tên Khách Hàng";
            chartthongkekh.ChartAreas[0].AxisY.Title = "Tổng Tiền Mua";

            chartthongkekh.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 12, FontStyle.Bold);
            chartthongkekh.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 12, FontStyle.Bold);

            chartthongkekh.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 10);
            chartthongkekh.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Arial", 10);

            chartthongkekh.ChartAreas[0].AxisY.LabelStyle.Format = "{0:0,}";
        }
    }
}

