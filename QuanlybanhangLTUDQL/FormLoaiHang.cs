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
    public partial class FormLoaiHang : Form
    {
        BLL_LoaiHang LOAIHANG = new BLL_LoaiHang();

        public FormLoaiHang()
        {
            InitializeComponent();
        }

        private void FormLoaiHang_Load(object sender, EventArgs e)
        {
            try
            {
                dtgvLH.DataSource = LOAIHANG.LoaiHang_Select();
                txttenlh.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu loại hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butnew_Click(object sender, EventArgs e)
        {
            try
            {
                int sinhmatudong = dtgvLH.Rows.Count;
                string maSP;
                bool trunglap;

                do
                {
                    maSP = "LH" + sinhmatudong.ToString().PadLeft(3, '0');
                    trunglap = false;

                    // Kiểm tra xem mã sản phẩm đã tồn tại trong DataGridView chưa
                    foreach (DataGridViewRow row in dtgvLH.Rows)
                    {
                        if (row.Cells["Mã Loại Hàng"].Value != null && row.Cells["Mã Loại Hàng"].Value.ToString() == maSP) // Thay "Mã Loại Hàng" bằng tên cột chứa mã sản phẩm trong DataGridView
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

                txtmalh.Text = maSP;

                txttenlh.Clear();
                txtmota.Clear();

                txttenlh.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi làm mới loại hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgvLH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong;
                dong = dtgvLH.CurrentRow.Index;
                txtmalh.Text = dtgvLH[0, dong].Value.ToString();
                txttenlh.Text = dtgvLH[1, dong].Value.ToString();
                txtmota.Text = dtgvLH[2, dong].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi chọn loại hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butinsert_Click(object sender, EventArgs e)
        {
            try
            {
                LOAIHANG.LoaiHang_Insert(txtmalh.Text, txttenlh.Text, txtmota.Text);
                FormLoaiHang_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm loại hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butupdate_Click(object sender, EventArgs e)
        {
            try
            {
                LOAIHANG.LoaiHang_Update(txtmalh.Text, txttenlh.Text, txtmota.Text);
                FormLoaiHang_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi sửa loại hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butdelete_Click(object sender, EventArgs e)
        {
            DialogResult key = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (key == DialogResult.Yes)
            {
                try
                {
                    LOAIHANG.LoaiHang_Delete(txtmalh.Text);
                    FormLoaiHang_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa loại hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txttimkiemlh_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dtgvLH.DataSource = LOAIHANG.LoaiHang_Select_Where(txttimkiemlh.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm loại hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormLoaiHang_KeyDown(object sender, KeyEventArgs e)
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

