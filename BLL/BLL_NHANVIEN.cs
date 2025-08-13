using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLL_NhanVien
    {
        DAL_NhanVien NhanVien = new DAL_NhanVien();

        // Method to select all records from the NHANVIEN table
        public DataTable NhanVien_Select()
        {
            return NhanVien.NhanVien_Select();
        }

        // Method to select a specific record from the NHANVIEN table based on MaNV
        public DataTable NhanVien_Select_Where(string MaNV)
        {
            return NhanVien.NhanVien_Select_Where(MaNV);
        }

        // Method to insert a new record into the NHANVIEN table
        public int NhanVien_Insert(string MaNV, string TenNV, DateTime NgaySinh, string DiaChiNV, string SDTNV, string MaChucVu)
        {
            return NhanVien.NhanVien_Insert(MaNV, TenNV, NgaySinh, DiaChiNV, SDTNV, MaChucVu);
        }

        // Method to update an existing record in the NHANVIEN table
        public int NhanVien_Update(string MaNV, string TenNV, DateTime NgaySinh, string DiaChiNV, string SDTNV, string MaChucVu)
        {
            return NhanVien.NhanVien_Update(MaNV, TenNV, NgaySinh, DiaChiNV, SDTNV, MaChucVu);
        }

        // Method to delete a record from the NHANVIEN table based on MaNV
        public int NhanVien_Delete(string MaNV)
        {
            return NhanVien.NhanVien_Delete(MaNV);
        }
        public DataTable NhanVien_TKSL()
        {
            return NhanVien.NhanVien_thongkeSLSP();
        }
        public DataTable NhanVien_TKTT()
        {
            return NhanVien.NhanVien_thongkeTONGTIEN();
        }
        public DataTable NhanVien_laychucvu()
        {
            return NhanVien.NhanVien_laychucvu();
        }
    }
}
