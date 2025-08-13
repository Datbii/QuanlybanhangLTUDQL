using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class BLL_KhachHang
    {
        DAL_KhachHang KhachHang = new DAL_KhachHang();

        // Select all records from KHACHHANG table
        public DataTable KhachHang_Select()
        {
            return KhachHang.KhachHang_Select();
        }

        // Select a specific record from KHACHHANG table based on MaKH
        public DataTable KhachHang_Select_Where(string MaKH)
        {
            return KhachHang.KhachHang_Select_Where(MaKH);
        }

        // Insert a new record into KHACHHANG table
        public int KhachHang_Insert(string MaKH, string TenKH, string DiaChiKH, string SDTKH, string Email, string LichSuMuaHang)
        {
            return KhachHang.KhachHang_Insert(MaKH, TenKH, DiaChiKH, SDTKH, Email, LichSuMuaHang);
        }

        // Update an existing record in KHACHHANG table
        public int KhachHang_Update(string MaKH, string TenKH, string DiaChiKH, string SDTKH, string Email, string LichSuMuaHang)
        {
            return KhachHang.KhachHang_Update(MaKH, TenKH, DiaChiKH, SDTKH, Email, LichSuMuaHang);
        }

        // Delete a record from KHACHHANG table based on MaKH
        public int KhachHang_Delete(string MaKH)
        {
            return KhachHang.KhachHang_Delete(MaKH);
        }
        public DataTable KhachHang_Thongke_tien()
        {
            return KhachHang.KhachHang_Thongke_Tien();
        }
        public DataTable KhachHang_Thongke_SLmua()
        {
            return KhachHang.KhachHang_Thongke_SLmua();
        }
    }
}

