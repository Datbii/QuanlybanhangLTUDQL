using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BLL;
using CrystalDecisions.Windows.Forms;

namespace QuanlybanhangLTUDQL
{
    public partial class XuatHoaDon : Form
    {
       
        BLL_HoaDon HOADON = new BLL_HoaDon();
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

            HoaDonBanHang rpt = new HoaDonBanHang();
            rpt.SetDataSource(HOADON.xuathoadon(FormHoaDon.MaHD.ToString()));
            crystalReportViewer1.ReportSource = rpt;

        }
       
        public XuatHoaDon()
        {
            InitializeComponent();
        }

        private void XuatHoaDon_Load(object sender, EventArgs e)
        {

        }
    }
}
