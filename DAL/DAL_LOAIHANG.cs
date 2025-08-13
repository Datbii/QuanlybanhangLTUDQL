using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_LoaiHang
    {
        ThaoTac_CSDL ThaoTac = new ThaoTac_CSDL();
        string[] name;
        object[] value;

        // Method to select all records from the LOAIHANG table
        public DataTable LoaiHang_Select()
        {
            return ThaoTac.SQL_LayDuLieu("SP_LOAIHANG_SelectAll");
        }

        // Method to select a specific record from the LOAIHANG table based on MaLH
        public DataTable LoaiHang_Select_Where(string MaLH)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@Kitu";
            value[0] = MaLH;
            return ThaoTac.SQL_LayDuLieu_CoDK("SP_LOAIHANG_Select", name, value, 1);
        }

        // Method to insert a new record into the LOAIHANG table
        public int LoaiHang_Insert(string MaLH, string TenLoaiHang, string Mota)
        {
            name = new string[3];
            value = new object[3];
            name[0] = "@MaLH";
            value[0] = MaLH;

            name[1] = "@TenLoaiHang";
            value[1] = TenLoaiHang;

            name[2] = "@Mota";
            value[2] = Mota;

            return ThaoTac.SQL_ThucHien("SP_LOAIHANG_Insert", name, value, 3);
        }

        // Method to update an existing record in the LOAIHANG table
        public int LoaiHang_Update(string MaLH, string TenLoaiHang, string Mota)
        {
            name = new string[3];
            value = new object[3];
            name[0] = "@MaLH";
            value[0] = MaLH;

            name[1] = "@TenLoaiHang";
            value[1] = TenLoaiHang;

            name[2] = "@Mota";
            value[2] = Mota;

            return ThaoTac.SQL_ThucHien("SP_LOAIHANG_Update", name, value, 3);
        }

        // Method to delete a record from the LOAIHANG table based on MaLH
        public int LoaiHang_Delete(string MaLH)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaLH";
            value[0] = MaLH;
            return ThaoTac.SQL_ThucHien("SP_LOAIHANG_Delete", name, value, 1);
        }
    }
}

