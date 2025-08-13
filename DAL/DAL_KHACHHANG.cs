using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAL_KhachHang
    {
        ThaoTac_CSDL ThaoTac = new ThaoTac_CSDL();
        string[] name;
        object[] value;

        // Select all records from KHACHHANG table
        public DataTable KhachHang_Select()
        {
            return ThaoTac.SQL_LayDuLieu("SP_KHACHHANG_SelectAll");
        }

        // Select a specific record from KHACHHANG table based on MaKH
        public DataTable KhachHang_Select_Where(string MaKH)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@Kitu";
            value[0] = MaKH;
            return ThaoTac.SQL_LayDuLieu_CoDK("SP_KHACHHANG_Select", name, value, 1);
        }

        // Insert a new record into KHACHHANG table
        public int KhachHang_Insert(string MaKH, string TenKH, string DiaChiKH, string SDTKH, string Email, string LichSuMuaHang)
        {
            name = new string[6];
            value = new object[6];
            name[0] = "@MaKH";
            value[0] = MaKH;

            name[1] = "@TenKH";
            value[1] = TenKH;

            name[2] = "@DiaChiKH";
            value[2] = DiaChiKH;

            name[3] = "@SDTKH";
            value[3] = SDTKH;

            name[4] = "@Email";
            value[4] = Email;

            name[5] = "@LichSu";
            value[5] = LichSuMuaHang;
            return ThaoTac.SQL_ThucHien("SP_KHACHHANG_Insert", name, value, 6);
        }

        // Update an existing record in KHACHHANG table
        public int KhachHang_Update(string MaKH, string TenKH, string DiaChiKH, string SDTKH, string Email, string LichSuMuaHang)
        {
            name = new string[6];
            value = new object[6];
            name[0] = "@MaKH";
            value[0] = MaKH;

            name[1] = "@TenKH";
            value[1] = TenKH;

            name[2] = "@DiaChiKH";
            value[2] = DiaChiKH;

            name[3] = "@SDTKH";
            value[3] = SDTKH;

            name[4] = "@Email";
            value[4] = Email;

            name[5] = "@LichSu";
            value[5] = LichSuMuaHang;
            return ThaoTac.SQL_ThucHien("SP_KHACHHANG_Update", name, value, 6);
        }

        // Delete a record from KHACHHANG table based on MaKH
        public int KhachHang_Delete(string MaKH)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaKH";
            value[0] = MaKH;
            return ThaoTac.SQL_ThucHien("SP_KHACHHANG_Delete", name, value, 1);
        }
        public DataTable KhachHang_Thongke_Tien()
        {
            return ThaoTac.SQL_LayDuLieu("SP_ThongkeKH_theotien");
        }
        public DataTable KhachHang_Thongke_SLmua()
        {
            return ThaoTac.SQL_LayDuLieu("SP_ThongKeKH_theoSL");
        }

    }
}
