using Guna.UI2.WinForms;
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
    public partial class FormGiaoDien : Form
    {
        public FormGiaoDien()
        {
            InitializeComponent();
            timer1.Start();
        }
    
        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
            label3.Text = DateTime.Now.ToLongDateString();
        }

        private void buthanghoa_Click(object sender, EventArgs e)
        {
          panelform.Controls.Clear();
            SanPham sanPham = new SanPham();
            AddFormToPanel(sanPham, panelform);

        }
      
        private void AddFormToPanel(Form form, Panel panel)
        {
            form.TopLevel = false; // Đặt TopLevel = false để tránh lỗi khi thêm vào Panel
            panel.Controls.Add(form); // Thêm form vào panel
            form.Dock = DockStyle.Fill; // Đặt DockStyle.Fill để form điền vào panel
            form.Show(); // Hiển thị form
        }

        private void buthoadon_Click(object sender, EventArgs e)
        {
            panelform.Controls.Clear();
            FormHoaDon formHoaDon = new FormHoaDon();
            AddFormToPanel(formHoaDon, panelform);

        }

        private void butthongke_Click(object sender, EventArgs e)
        {
            panelform.Controls.Clear();
            FormThongKe formThongKe = new FormThongKe();
            AddFormToPanel(formThongKe, panelform);
        }

        private void butkhachhang_Click(object sender, EventArgs e)
        {
            panelform.Controls.Clear();
           FormKhachHang formKhachHang = new FormKhachHang();
            AddFormToPanel(formKhachHang, panelform);
        }

        private void butnhanvien_Click(object sender, EventArgs e)
        {
            panelform.Controls.Clear();
            FormNhanVien formNhanVien = new FormNhanVien();
            AddFormToPanel(formNhanVien, panelform);
        }

        private void butloaihang_Click(object sender, EventArgs e)
        {
            panelform.Controls.Clear();
            FormLoaiHang formNhanVien = new FormLoaiHang();
            AddFormToPanel(formNhanVien, panelform);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Formdangnhap frm = new Formdangnhap();
            frm.Show();
        }
    }
}
