using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlybanhangLTUDQL
{
    public partial class FormThongKe : Form
    {
        public FormThongKe()
        {
            InitializeComponent();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserThongKeKH userThongKeKH = new UserThongKeKH();
            panel1.Controls.Add(userThongKeKH);
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {panel1.Controls.Clear();
            UserThongKeNV userThongKeNV = new UserThongKeNV();
            panel1.Controls.Add(userThongKeNV);
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserSanPham userSanPham = new UserSanPham();
            panel1.Controls.Add(userSanPham);
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserDoanhThu dt = new UserDoanhThu();
            panel1.Controls.Add(dt);
        }
    }
}
