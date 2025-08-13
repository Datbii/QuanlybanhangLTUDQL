using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_ChiTietHoaDon
    {
        ThaoTac_CSDL ThaoTac = new ThaoTac_CSDL();
        string[] name;
        object[] value;

        public DataTable ChiTietHoaDon_Select()
        {
            return ThaoTac.SQL_LayDuLieu("SP_CHITIETHOADON_SelectAll");
        }

        public DataTable ChiTietHoaDon_Select_Where(string MaHD)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaHD";
            value[0] = MaHD;

          

            return ThaoTac.SQL_LayDuLieu_CoDK("SP_CHITIETHOADON_Select", name, value, 1);
        }

        public int ChiTietHoaDon_Insert(string MaHD, string MaSP, int SLMua)
        {
            name = new string[3];
            value = new object[3];
            name[0] = "@MaHD";
            value[0] = MaHD;

            name[1] = "@MaSP";
            value[1] = MaSP;

            name[2] = "@SLMua";
            value[2] = SLMua;

            

            return ThaoTac.SQL_ThucHien("SP_CHITIETHOADON_Insert", name, value, 3);
        }

        public int ChiTietHoaDon_Update(string MaHD, string MaSP, int SLMua)
        {
            name = new string[3];
            value = new object[3];
            name[0] = "@MaHD";
            value[0] = MaHD;

            name[1] = "@MaSP";
            value[1] = MaSP;

            name[2] = "@SLMua";
            value[2] = SLMua;

            

            return ThaoTac.SQL_ThucHien("SP_CHITIETHOADON_Update", name, value, 3);
        }

        public int ChiTietHoaDon_Delete(string MaHD)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaHD";
            value[0] = MaHD;

         

            return ThaoTac.SQL_ThucHien("SP_CHITIETHOADON_Delete", name, value, 1);
        }
    }
}