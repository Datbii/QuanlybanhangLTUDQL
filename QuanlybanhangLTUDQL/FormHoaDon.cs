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
namespace QuanlybanhangLTUDQL
{
    public partial class FormHoaDon : Form
    {
        int dongCTHD;
        public static string MaHD;
        BLL_ChiTietHoaDon Chitiet = new BLL_ChiTietHoaDon();
        BLL_KhachHang KHACHHANG = new BLL_KhachHang();
        BLL_NhanVien NHANVIEN = new BLL_NhanVien();
        BLL_HangHoa HANGHOA = new BLL_HangHoa();
        BLL_HoaDon HOADON = new BLL_HoaDon();
        public DataTable CTHD;
        double thanhtien;
        public FormHoaDon()
        {
            InitializeComponent();
        }

        private void dtgvhoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {CTHD.Clear();
            int dong;
            dong = dtgvhoadon.CurrentRow.Index;
            txtMaHD.Text = dtgvhoadon[1,dong].Value.ToString();
            dtpNgayHD.Value = DateTime.Parse(dtgvhoadon[2, dong].Value.ToString());
            cbdanhsachnv.Text = dtgvhoadon[3,dong].Value.ToString();
            cbdanhsachKH.Text = dtgvhoadon[0, dong].Value.ToString();
            CTHD=Chitiet.ChiTietHoaDon_Select_Where(dtgvhoadon[1, dong].Value.ToString());
            dtgvcthd.DataSource = CTHD;
       

        }

        private void butinhoadon_Click(object sender, EventArgs e)
        {
            
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
          
            cbdanhsachKH.DataSource = KHACHHANG.KhachHang_Select();
            cbdanhsachKH.DisplayMember = "Tên Khách Hàng";
            cbdanhsachKH.ValueMember = "Mã Khách Hàng";          
            cbdanhsachnv.DataSource = NHANVIEN.NhanVien_Select();
            cbdanhsachnv.DisplayMember = "Tên Nhân Viên";
            cbdanhsachnv.ValueMember = "Mã Nhân Viên";       
            dtgvhoadon.DataSource = HOADON.HoaDon_Select() ;       
            cbdssanpham.DataSource = HANGHOA.HangHoa_Select();
            cbdssanpham.DisplayMember = "Tên Sản Phẩm";
            cbdssanpham.ValueMember = "Mã Sản Phẩm";
            cbdssanpham.SelectedIndex= 0;
            CTHD = new DataTable();
            CTHD.Columns.Add(new DataColumn("Mã sản phẩm", typeof(string)) { AllowDBNull = true });
            CTHD.Columns.Add(new DataColumn("Tên sản phẩm", typeof(string)) { AllowDBNull = true });
            CTHD.Columns.Add(new DataColumn("ĐVT", typeof(string)) { AllowDBNull = true });
            CTHD.Columns.Add(new DataColumn("Đơn giá", typeof(float)) { AllowDBNull = true });
            CTHD.Columns.Add(new DataColumn("Số lượng", typeof(int)) { AllowDBNull = true });
            CTHD.Columns.Add(new DataColumn("Thành tiền", typeof(double)) { AllowDBNull = true });

            dtgvcthd.DataSource = CTHD;
        }

        private void butthem_Click(object sender, EventArgs e)
        {
            int i = 1;
            foreach (DataRow dr in CTHD.Rows)
            {
                if (dr.RowState != DataRowState.Deleted && dr[0].ToString() == cbdssanpham.SelectedValue.ToString())
                {
                    int SL = int.Parse(txtSL.Text) + int.Parse(dr[4].ToString()); // Sửa từ dr[3] thành dr[4]
                    thanhtien = SL * float.Parse(txtdongia.Text);
                    dr.Delete();
                    CTHD.Rows.Add(cbdssanpham.SelectedValue.ToString(), cbdssanpham.Text, txtDVT.Text, float.Parse(txtdongia.Text), SL, thanhtien);
                    dtgvcthd.DataSource = CTHD;
                    break;
                }
                i++;
            }
            if (i > CTHD.Rows.Count)
            {
                thanhtien = float.Parse(txtdongia.Text) * int.Parse(txtSL.Text);
                CTHD.Rows.Add(cbdssanpham.SelectedValue.ToString(), cbdssanpham.Text, txtDVT.Text, float.Parse(txtdongia.Text), int.Parse(txtSL.Text), thanhtien);
                dtgvcthd.DataSource = CTHD;
            }
        }

        private void cbloaisanpham_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cbdssanpham_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable hh = new DataTable();
            hh = HANGHOA.HangHoa_Select_Wherecbb(cbdssanpham.SelectedValue.ToString());
            if (hh.Rows.Count > 0)
            {
                txtDVT.Text = hh.Rows[0][4].ToString();
                txtdongia.Text = hh.Rows[0][2].ToString();
            }
        }

        private void dtgvcthd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           dongCTHD = e.RowIndex;
            cbdssanpham.Text = dtgvcthd[1, dongCTHD].Value.ToString();
            txtDVT.Text = dtgvcthd[2, dongCTHD].Value.ToString();
            txtdongia.Text = dtgvcthd[3, dongCTHD].Value.ToString();
            txtSL.Text = dtgvcthd[4, dongCTHD].Value.ToString();
        }

        private void butsua_Click(object sender, EventArgs e)
        {
            DataGridViewRow newRow = dtgvcthd.Rows[dongCTHD];
            newRow.Cells[0].Value = cbdssanpham.SelectedValue.ToString();
            newRow.Cells[1].Value = cbdssanpham.Text;
            newRow.Cells[2].Value = txtDVT.Text;
            newRow.Cells[4].Value = txtSL.Text;
            newRow.Cells[3].Value = txtdongia.Text;
            newRow.Cells[5].Value = float.Parse(txtdongia.Text) * int.Parse(txtSL.Text);
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            dtgvcthd.Rows.RemoveAt(dongCTHD);
        }

        private void butluu_Click(object sender, EventArgs e)
        {
            HOADON.HoaDon_Insert(txtMaHD.Text,dtpNgayHD.Value, cbdanhsachKH.SelectedValue.ToString(), cbdanhsachnv.SelectedValue.ToString());
            foreach(DataRow dr in CTHD.Rows)
            {
                Chitiet.ChiTietHoaDon_Insert(txtMaHD.Text, dr[0].ToString(), int.Parse(dr[4].ToString()));
            }
            FormHoaDon_Load(sender,e);
        }

        private void butsuahd_Click(object sender, EventArgs e)
        {
            {
                HOADON.HoaDon_Update(txtMaHD.Text, dtpNgayHD.Value, cbdanhsachKH.SelectedValue.ToString(), cbdanhsachnv.SelectedValue.ToString());
                Chitiet.ChiTietHoaDon_Delete(txtMaHD.Text);
                foreach (DataRow dr in CTHD.Rows)
                {
                    if (dr.RowState != DataRowState.Deleted) // Kiểm tra dòng không bị xóa
                    {
                        Chitiet.ChiTietHoaDon_Insert(txtMaHD.Text, dr[0].ToString(), int.Parse(dr[4].ToString()));
                    }
                }
                FormHoaDon_Load(sender, e);
            }
        }

        private void butxoahd_Click(object sender, EventArgs e)
        {
            Chitiet.ChiTietHoaDon_Delete(txtMaHD.Text);
            HOADON.HoaDon_Delete(txtMaHD.Text) ;
            FormHoaDon_Load(sender, e);
        }

        private void butinhoadon_Click_1(object sender, EventArgs e)
        {

            MaHD = txtMaHD.Text;
            XuatHoaDon frm = new XuatHoaDon();
            frm.Show();
        }

        private void dtgvcthd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dongCTHD = e.RowIndex;
            cbdssanpham.Text = dtgvcthd[1, dongCTHD].Value.ToString();
            txtDVT.Text = dtgvcthd[2, dongCTHD].Value.ToString();
            txtdongia.Text = dtgvcthd[3, dongCTHD].Value.ToString();
            txtSL.Text = dtgvcthd[4, dongCTHD].Value.ToString();

        }

        private void buttaomoihd_Click(object sender, EventArgs e)
        {
            int sinhmatudong = dtgvhoadon.Rows.Count;
            string maSP;
            bool trunglap;

            do
            {
                maSP = "HD" + sinhmatudong.ToString().PadLeft(3, '0');
                trunglap = false;

                // Kiểm tra xem mã sản phẩm đã tồn tại trong DataGridView chưa
                foreach (DataGridViewRow row in dtgvhoadon.Rows)
                {
                    if (row.Cells["Mã Hóa Đơn"].Value != null && row.Cells["Mã Hóa Đơn"].Value.ToString() == maSP) // Thay "Mã Sản Phẩm" bằng tên cột chứa mã sản phẩm trong DataGridView
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

            txtMaHD.Text = maSP;// Xóa các dữ liệu hiện có trong DataTable CTHD
            CTHD.Clear();

            // Đặt lại các trường nhập liệu về giá trị mặc định hoặc rỗng
            // Hoặc bạn có thể tạo một mã hóa đơn mới tự động
            dtpNgayHD.Value = DateTime.Now;
            cbdanhsachnv.SelectedIndex = -1;
            cbdanhsachKH.SelectedIndex = -1;
            cbdssanpham.SelectedIndex = 0;
            txtDVT.Text = string.Empty;
            txtdongia.Text = string.Empty;
            txtSL.Text = string.Empty;

            // Đặt DataTable CTHD làm nguồn dữ liệu cho DataGridView
            dtgvcthd.DataSource = CTHD;
        }


    }
}
