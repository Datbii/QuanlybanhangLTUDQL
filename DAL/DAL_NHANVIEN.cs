using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAL_NhanVien
    {
        ThaoTac_CSDL ThaoTac = new ThaoTac_CSDL();
        string[] name;
        object[] value;

        // Method to select all records from the NHANVIEN table
        public DataTable NhanVien_Select()
        {
            return ThaoTac.SQL_LayDuLieu("SP_NHANVIEN_SelectAll");
        }

        public DataTable NhanVien_laychucvu()
        {
            return ThaoTac.SQL_LayDuLieu("SP_CHUCVU_SelectAll");
        }
        // Method to select a specific record from the NHANVIEN table based on MaNV
        public DataTable NhanVien_Select_Where(string MaNV)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@Kitu";
            value[0] = MaNV;
            return ThaoTac.SQL_LayDuLieu_CoDK("SP_NHANVIEN_Select", name, value, 1);
        }

        // Method to insert a new record into the NHANVIEN table
        public int NhanVien_Insert(string MaNV, string TenNV, DateTime NgaySinh, string DiaChiNV, string SDTNV, string MaChucVu)
        {
            name = new string[6];
            value = new object[6];
            name[0] = "@MaNV";
            value[0] = MaNV;

            name[1] = "@TenNV";
            value[1] = TenNV;

            name[2] = "@NgaySinh";
            value[2] = NgaySinh;

            name[3] = "@DiaChiNV";
            value[3] = DiaChiNV;

            name[4] = "@SDTNV";
            value[4] = SDTNV;

            name[5] = "@MaChucVu";
            value[5] = MaChucVu;

            return ThaoTac.SQL_ThucHien("SP_NHANVIEN_Insert", name, value, 6);
        }

        // Method to update an existing record in the NHANVIEN table
        public int NhanVien_Update(string MaNV, string TenNV, DateTime NgaySinh, string DiaChiNV, string SDTNV, string MaChucVu)
        {
            name = new string[6];
            value = new object[6];
            name[0] = "@MaNV";
            value[0] = MaNV;

            name[1] = "@TenNV";
            value[1] = TenNV;

            name[2] = "@NgaySinh";
            value[2] = NgaySinh;

            name[3] = "@DiaChiNV";
            value[3] = DiaChiNV;

            name[4] = "@SDTNV";
            value[4] = SDTNV;

            name[5] = "@MaChucVu";
            value[5] = MaChucVu;

            return ThaoTac.SQL_ThucHien("SP_NHANVIEN_Update", name, value, 6);
        }

        // Method to delete a record from the NHANVIEN table based on MaNV
        public int NhanVien_Delete(string MaNV)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaNV";
            value[0] = MaNV;
            return ThaoTac.SQL_ThucHien("SP_NHANVIEN_Delete", name, value, 1);
        }
        public DataTable NhanVien_thongkeSLSP()
        {
            return ThaoTac.SQL_LayDuLieu("SP_NHANVIEN_TKSL");
        }
        public DataTable NhanVien_thongkeTONGTIEN()
        {
            return ThaoTac.SQL_LayDuLieu("SP_NHANVIEN_tongtien");
        }
    }
}
