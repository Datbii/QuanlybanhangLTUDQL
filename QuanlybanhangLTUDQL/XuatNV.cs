using System;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using BLL;

namespace QuanlybanhangLTUDQL
{
    public partial class XuatNV : Form
    {
        BLL_NhanVien BLL_NhanVien = new BLL_NhanVien();

        public XuatNV()
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
            string reportPath = @"D:\2003\QuanlybanhangLTUDQL\QuanlybanhangLTUDQL\BaoCaoNhanVien.rpt";

            // Tạo đối tượng báo cáo
            BaoCaoNhanVien baoCaoNhanVien = new BaoCaoNhanVien();
            baoCaoNhanVien.Load(reportPath);

            // Thông tin kết nối cơ sở dữ liệu
            string serverName = "DESKTOP-CDO0SQ2";
            string databaseName = "QUAN LY CUA HANG TIEN LOI";

            // Thiết lập kết nối cơ sở dữ liệu
            ConnectionInfo connectionInfo = new ConnectionInfo();
            connectionInfo.ServerName = serverName;
            connectionInfo.DatabaseName = databaseName;
            connectionInfo.IntegratedSecurity = true;

            // Thiết lập kết nối cho từng bảng trong báo cáo
            Tables tables = baoCaoNhanVien.Database.Tables;
            foreach (Table table in tables)
            {
                TableLogOnInfo tableLogOnInfo = table.LogOnInfo;
                tableLogOnInfo.ConnectionInfo = connectionInfo;
                table.ApplyLogOnInfo(tableLogOnInfo);
            }

            // Nếu báo cáo có các subreport, thiết lập kết nối cho các subreport
            foreach (Section section in baoCaoNhanVien.ReportDefinition.Sections)
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
            crystalReportViewer1.ReportSource = baoCaoNhanVien;

            // Làm mới báo cáo
            baoCaoNhanVien.Refresh();
            crystalReportViewer1.Refresh();
        }
    }
}
