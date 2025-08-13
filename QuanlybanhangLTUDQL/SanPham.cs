using BLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanlybanhangLTUDQL
{
    public partial class SanPham : Form
    {
        BLL_HangHoa HANGHOA = new BLL_HangHoa();
        BLL_LoaiHang loaiHang = new BLL_LoaiHang();
        public SanPham()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = HANGHOA.HangHoa_Select();
            DataTable dtLoaiHang = loaiHang.LoaiHang_Select();
            cbloaisp.DataSource = dtLoaiHang;
            cbloaisp.DisplayMember = "Tên Loại Hàng";
            cbloaisp.ValueMember = "Mã Loại Hàng";
            txttensp.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
                int dong;
                dong = dataGridView1.CurrentRow.Index;

                txtmasp.Text = dataGridView1[0, dong].Value.ToString();
                txttensp.Text = dataGridView1[1, dong].Value.ToString();
                txtdongia.Text = dataGridView1[2, dong].Value.ToString();
                cbdonvitinh.Text = dataGridView1[4, dong].Value.ToString();
                nrsoluongton.Value = Convert.ToInt32(dataGridView1[3, dong].Value);

                // Lấy mã loại hàng từ cột tương ứng
                string maLoaiHang = dataGridView1[5, dong].Value.ToString();

                // Tìm tên loại hàng tương ứng trong DataTable
                DataRow[] rows = ((DataTable)cbloaisp.DataSource).Select($"[Mã Loại Hàng] = '{maLoaiHang}'");
                if (rows.Length > 0)
                {
                    cbloaisp.Text = rows[0]["Tên Loại Hàng"].ToString();
                }
                else
                {
                    cbloaisp.Text = string.Empty;
                }
            
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                HANGHOA.HangHoa_Insert(txtmasp.Text, txttensp.Text, float.Parse(txtdongia.Text), Convert.ToInt32(nrsoluongton.Value), cbdonvitinh.Text, cbloaisp.SelectedValue.ToString());
                Form1_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm sản phẩm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butnew_Click(object sender, EventArgs e)
        {
            try
            {
                int sinhmatudong = dataGridView1.Rows.Count + 1;
                string maSP;
                bool trunglap;

                do
                {
                    maSP = "SP" + sinhmatudong.ToString().PadLeft(3, '0');
                    trunglap = false;

                    // Kiểm tra xem mã sản phẩm đã tồn tại trong DataGridView chưa
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells["Mã Sản Phẩm"].Value != null && row.Cells["Mã Sản Phẩm"].Value.ToString() == maSP) // Thay "Mã Sản Phẩm" bằng tên cột chứa mã sản phẩm trong DataGridView
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

                txtmasp.Text = maSP;
               
                txttensp.Clear();
                txtdongia.Clear();
                cbdonvitinh.SelectedIndex = 0;
                nrsoluongton.Value = 0;
                cbloaisp.SelectedIndex = 0;
                txtmasp.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi làm mới sản phẩm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butupdate_Click(object sender, EventArgs e)
        {
            try
            {
                HANGHOA.HangHoa_Update(txtmasp.Text, txttensp.Text, float.Parse(txtdongia.Text), Convert.ToInt32(nrsoluongton.Value), cbdonvitinh.Text, cbloaisp.SelectedValue.ToString());
                Form1_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật sản phẩm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butdelete_Click(object sender, EventArgs e)
        {
            DialogResult key = MessageBox.Show("Nếu xóa sản phẩm thì các hóa đơn liên quan đến sản phẩm này cũng bị xóa. Bạn có chắc chắn muốn xóa ?", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (key == DialogResult.Yes)
            {
                try
                {
                    HANGHOA.HangHoa_Delete(txtmasp.Text);
                    Form1_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa sản phẩm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

       

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = HANGHOA.HangHoa_Select_Where(txttimkiem.Text.ToLower());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm sản phẩm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SanPham_KeyDown(object sender, KeyEventArgs e)
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
                button1_Click(sender, e);
            }
        }
    }
}
