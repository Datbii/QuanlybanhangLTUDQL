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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace QuanlybanhangLTUDQL
{
    public partial class XuatThongKe : Form
    {
        BLL_KhachHang KHACHHANG = new BLL_KhachHang();

        public XuatThongKe()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void LoadReport()
        {
            // Đường dẫn tới file Crystal Report (.rpt)
            string reportPath = @"D:\2003\QuanlybanhangLTUDQL\QuanlybanhangLTUDQL\BaoCaoThongKeTienKH.rpt";

            // Tạo đối tượng báo cáo
            BaoCaoThongKeTienKH rpt = new BaoCaoThongKeTienKH();
            rpt.Load(reportPath);

            // Thông tin kết nối cơ sở dữ liệu
            string serverName = "DESKTOP-CDO0SQ2";
            string databaseName = "QUAN LY CUA HANG TIEN LOI";

            // Thiết lập kết nối cơ sở dữ liệu
            ConnectionInfo connectionInfo = new ConnectionInfo();
            connectionInfo.ServerName = serverName;
            connectionInfo.DatabaseName = databaseName;
            connectionInfo.IntegratedSecurity = true;

            // Thiết lập kết nối cho từng bảng trong báo cáo
            Tables tables = rpt.Database.Tables;
            foreach (Table table in tables)
            {
                TableLogOnInfo tableLogOnInfo = table.LogOnInfo;
                tableLogOnInfo.ConnectionInfo = connectionInfo;
                table.ApplyLogOnInfo(tableLogOnInfo);
            }

            // Nếu báo cáo có các subreport, thiết lập kết nối cho các subreport
            foreach (Section section in rpt.ReportDefinition.Sections)
            {
                foreach (ReportObject reportObject in section.ReportObjects)
                {
                    if (reportObject.Kind == ReportObjectKind.SubreportObject)
                    {
                        SubreportObject subreportObject = (SubreportObject)reportObject;
                        ReportDocument subReportDocument = subreportObject.OpenSubreport(subreportObject.SubreportName);
                        Tables subTables = subReportDocument.Database.Tables;
                        foreach (Table subTable in subTables)
                        {
                            TableLogOnInfo tableLogOnInfo = subTable.LogOnInfo;
                            tableLogOnInfo.ConnectionInfo = connectionInfo;
                            subTable.ApplyLogOnInfo(tableLogOnInfo);
                        }
                    }
                }
            }

            // Thiết lập nguồn dữ liệu cho CrystalReportViewer
            crystalReportViewer1.ReportSource = rpt;

            // Làm mới báo cáo
            rpt.Refresh();
            crystalReportViewer1.Refresh();
        }
    }
}
