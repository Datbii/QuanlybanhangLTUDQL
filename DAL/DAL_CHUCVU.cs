using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_ChucVu
    {
        ThaoTac_CSDL ThaoTac = new ThaoTac_CSDL();
        string[] name;
        object[] value;

        public DataTable ChucVu_Select()
        {
            return ThaoTac.SQL_LayDuLieu("SP_CHUCVU_SelectAll");
        }

        public DataTable ChucVu_Select_Where(string MaChucVu)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaChucVu";
            value[0] = MaChucVu;
            return ThaoTac.SQL_LayDuLieu_CoDK("SP_CHUCVU_Select", name, value, 1);
        }

        public int ChucVu_Insert(string MaChucVu, string TenChucVu)
        {
            name = new string[2];
            value = new object[2];
            name[0] = "@MaChucVu";
            value[0] = MaChucVu;

            name[1] = "@TenChucVu";
            value[1] = TenChucVu;

            return ThaoTac.SQL_ThucHien("SP_CHUCVU_Insert", name, value, 2);
        }

        public int ChucVu_Update(string MaChucVu, string TenChucVu)
        {
            name = new string[2];
            value = new object[2];
            name[0] = "@MaChucVu";
            value[0] = MaChucVu;

            name[1] = "@TenChucVu";
            value[1] = TenChucVu;

            return ThaoTac.SQL_ThucHien("SP_CHUCVU_Update", name, value, 2);
        }

        public int ChucVu_Delete(string MaChucVu)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaChucVu";
            value[0] = MaChucVu;
            return ThaoTac.SQL_ThucHien("SP_CHUCVU_Delete", name, value, 1);
        }
    }
}

