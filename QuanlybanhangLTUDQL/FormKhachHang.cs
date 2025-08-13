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
using DevExpress.Data;
namespace QuanlybanhangLTUDQL
{
    public partial class FormKhachHang : Form
    {
      BLL_KhachHang KHACHHANG = new BLL_KhachHang();
        public FormKhachHang()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            dtgvkh.DataSource = KHACHHANG.KhachHang_Select();
            txttenkh.Focus();
        }

        private void butnew_Click(object sender, EventArgs e)
        {
            int sinhmatudong = dtgvkh.Rows.Count ;
            string maSP;
            bool trunglap;

            do
            {
                maSP = "KH" + sinhmatudong.ToString().PadLeft(3, '0');
                trunglap = false;

                // Kiểm tra xem mã sản phẩm đã tồn tại trong DataGridView chưa
                foreach (DataGridViewRow row in dtgvkh.Rows)
                {
                    if (row.Cells["Mã Khách Hàng"].Value != null && row.Cells["Mã Khách Hàng"].Value.ToString() == maSP) // Thay "Mã Sản Phẩm" bằng tên cột chứa mã sản phẩm trong DataGridView
                    {
                        trunglap = true;
                        break;
                    }
                }

                if (trunglap)
                {
                    sinhmatudong++; // Nếu mã trùng lặp, tăng giá trị để tạo mã mới
                }
            } while (trunglap);

            txtmakh.Text = maSP;
            
            txtdiachikh.Clear();
            txtemailkh.Clear();
            txttenkh.Clear();
            txtsdtkh.Clear();
            txtlsmh.Clear();
        }

        private void butinsert_Click(object sender, EventArgs e)
        {
            try
            {
                KHACHHANG.KhachHang_Insert(txtmakh.Text, txttenkh.Text, txtdiachikh.Text, txtsdtkh.Text, txtemailkh.Text, txtlsmh.Text);
                FormKhachHang_Load(sender, e);
            }
            catch (Exception ex)
            {
               MessageBox.Show($"Lỗi khi thêm khách hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butupdate_Click(object sender, EventArgs e)
        {
            try
            {

                KHACHHANG.KhachHang_Update(txtmakh.Text, txttenkh.Text, txtdiachikh.Text, txtsdtkh.Text, txtemailkh.Text, txtlsmh.Text);
                FormKhachHang_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật khách hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butdelete_Click(object sender, EventArgs e)
        {
            DialogResult key = MessageBox.Show(" Bạn có chắc chắn muốn xóa ?", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (key == DialogResult.Yes)
            {
                try
                {
                    KHACHHANG.KhachHang_Delete(txtmakh.Text);
                    FormKhachHang_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa khách hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txttimkiemkh_TextChanged(object sender, EventArgs e)
        {
           dtgvkh.DataSource= KHACHHANG.KhachHang_Select_Where(txttimkiemkh.Text.ToLower());
        }

        private void dtgvkh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = dtgvkh.CurrentRow.Index;
            txtmakh.Text = dtgvkh[0, dong].Value.ToString();
            txttenkh.Text = dtgvkh[1, dong].Value.ToString();
            txtdiachikh.Text = dtgvkh[2, dong].Value.ToString();
            txtsdtkh.Text = dtgvkh[3, dong].Value.ToString();
            txtemailkh.Text = dtgvkh[4, dong].Value.ToString();
            txtlsmh.Text = dtgvkh[5, dong].Value.ToString();
           
        }

        private void dtgvkh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormKhachHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.T)
            {
                butnew_Click(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.S)
            {
                butupdate_Click(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.X)
            {
                butdelete_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Enter)
            {
                butinsert_Click(sender, e);
            }
        }
    }
}
