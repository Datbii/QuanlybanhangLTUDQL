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
    public partial class FormNhanVien : Form
    {
        BLL_NhanVien NHANVIEN = new BLL_NhanVien();

        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void butnew_Click(object sender, EventArgs e)
        {
            try
            {
                int sinhmatudong = dtgvnv.Rows.Count;
                string maSP;
                bool trunglap;

                do
                {
                    maSP = "NV" + sinhmatudong.ToString().PadLeft(3, '0');
                    trunglap = false;

                    // Kiểm tra xem mã sản phẩm đã tồn tại trong DataGridView chưa
                    foreach (DataGridViewRow row in dtgvnv.Rows)
                    {
                        if (row.Cells["Mã Nhân Viên"].Value != null && row.Cells["Mã Nhân Viên"].Value.ToString() == maSP) // Thay "Mã Sản Phẩm" bằng tên cột chứa mã sản phẩm trong DataGridView
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

                txtmanv.Text = maSP;

                txttennv.Clear();
                txtdiachinv.Clear();
                cbchucvu.SelectedIndex = 0;
                txtsdtnv.Clear();
                dtpngaysinh.Value = DateTime.Now;
                txttennv.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi làm mới nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                dtgvnv.DataSource = NHANVIEN.NhanVien_Select();
                DataTable dtchucvu = NHANVIEN.NhanVien_laychucvu();
                cbchucvu.DataSource = dtchucvu;
                cbchucvu.DisplayMember = "TenChucVu";
                cbchucvu.ValueMember = "MaChucVu";
                txttennv.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butinsert_Click(object sender, EventArgs e)
        {
            try
            {
                NHANVIEN.NhanVien_Insert(txtmanv.Text, txttennv.Text, dtpngaysinh.Value, txtdiachinv.Text, txtsdtnv.Text, cbchucvu.SelectedValue.ToString());
                FormNhanVien_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgvnv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong;
                dong = dtgvnv.CurrentRow.Index;
                txtmanv.Text = dtgvnv[0, dong].Value.ToString();
                txttennv.Text = dtgvnv[1, dong].Value.ToString();
                dtpngaysinh.Value = DateTime.Parse(dtgvnv[2, dong].Value.ToString());
                txtdiachinv.Text = dtgvnv[3, dong].Value.ToString();
                txtsdtnv.Text = dtgvnv[4, dong].Value.ToString();
                // Lấy mã loại hàng từ cột tương ứng
                string maLoaiHang = dtgvnv[5, dong].Value.ToString();

                // Tìm tên loại hàng tương ứng trong DataTable
                DataRow[] rows = ((DataTable)cbchucvu.DataSource).Select($"[MaChucVu] = '{maLoaiHang}'");
                if (rows.Length > 0)
                {
                    cbchucvu.Text = rows[0]["TenChucVu"].ToString();
                }
                else
                {
                    cbchucvu.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi chọn nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butupdate_Click(object sender, EventArgs e)
        {
            try
            {
                NHANVIEN.NhanVien_Update(txtmanv.Text, txttennv.Text, dtpngaysinh.Value, txtdiachinv.Text, txtsdtnv.Text, cbchucvu.SelectedValue.ToString());
                FormNhanVien_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butdelete_Click(object sender, EventArgs e)
        {
            DialogResult key = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (key == DialogResult.Yes)
            {
                try
                {
                    NHANVIEN.NhanVien_Delete(txtmanv.Text);
                    FormNhanVien_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txttimkiemnv_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dtgvnv.DataSource = NHANVIEN.NhanVien_Select_Where(txttimkiemnv.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butupdate_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void FormNhanVien_KeyDown(object sender, KeyEventArgs e)
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
