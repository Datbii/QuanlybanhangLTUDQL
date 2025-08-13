using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace QuanlybanhangLTUDQL
{
    public partial class Formdangnhap : Form
    {
        public Formdangnhap()
        {
            InitializeComponent();
        }
        BLL_DangNhap DANGNHAP = new BLL_DangNhap();
        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txttendangnhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
          
                if (txttendangnhap.Text == "" || txtmatkhau.Text == "")

                    MessageBox.Show("Cần nhập đầy đủ tên đăng nhập và mật khẩu!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    DataTable dt = DANGNHAP.DangNhap(txttendangnhap.Text, txtmatkhau.Text);
                    if (dt.Rows.Count == 0)
                        MessageBox.Show("Sai tên đăng nhập và mật khẩu!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {

                        Program.Quyen = dt.Rows[0][3].ToString();
                        Program.TenTK = dt.Rows[0][0].ToString();
                        MessageBox.Show("Tài khoản " + Program.TenTK.ToString().Trim() + "' đã đăng nhập thành công vào hệ thống với quyền là '" + Program.Quyen.ToString() + "'!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        FormGiaoDien frm = new FormGiaoDien();
                        frm.Show();
                        this.Visible = false;
                    }
                }
            }

        private void Formdangnhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guna2Button1.PerformClick();
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }

