using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_HoaDon
    {
        ThaoTac_CSDL ThaoTac = new ThaoTac_CSDL();
        string[] name;
        object[] value;

        public DataTable HoaDon_Select()
        {
            return ThaoTac.SQL_LayDuLieu("SP_HOADON_SelectAll");
        }

        public DataTable HoaDon_Select_Where(string MaHD)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaHD";
            value[0] = MaHD;
            return ThaoTac.SQL_LayDuLieu_CoDK("SP_HOADON_Select", name, value, 1);
        }

        public int HoaDon_Insert(string MaHD, DateTime NgayXuat, string MaKH, string MaNV)
        {
            name = new string[4];
            value = new object[4];
            name[0] = "@MaHD";
            value[0] = MaHD;

            name[1] = "@NgayXuat";
            value[1] = NgayXuat;



            name[2] = "@MaKH";
            value[2] = MaKH;

            name[3] = "@MaNV";
            value[3] = MaNV;


            return ThaoTac.SQL_ThucHien("SP_HOADON_Insert", name, value, 4);
        }

        public int HoaDon_Update(string MaHD, DateTime NgayXuat, string MaKH, string MaNV)
        {
            name = new string[4];
            value = new object[4];
            name[0] = "@MaHD";
            value[0] = MaHD;

            name[1] = "@NgayXuat";
            value[1] = NgayXuat;

       

            name[2] = "@MaKH";
            value[2] = MaKH;

            name[3] = "@MaNV";
            value[3] = MaNV;

            return ThaoTac.SQL_ThucHien("SP_HOADON_Update", name, value, 4);
        }

        public int HoaDon_Delete(string MaHD)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaHD";
            value[0] = MaHD;
            return ThaoTac.SQL_ThucHien("SP_HOADON_Delete", name, value, 1);
        }
        public DataTable xuathoadon(string MaHD)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaHD";
            value[0] = MaHD;
            return ThaoTac.SQL_LayDuLieu_CoDK("xuathoadon", name, value, 1);
        }
        public DataTable thongkedoanhthu()
        {
            return ThaoTac.SQL_LayDuLieu("SP_ThongKeDoanhThu");
        }

    }
}
