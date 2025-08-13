using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;

namespace BLL
{
    public class BLL_HoaDon
    {
        DAL_HoaDon HoaDon = new DAL_HoaDon();

        public DataTable HoaDon_Select()
        {
            return HoaDon.HoaDon_Select();
        }

        public DataTable HoaDon_Select_Where(string MaHD)
        {
            return HoaDon.HoaDon_Select_Where(MaHD);
        }

        public int HoaDon_Insert(string MaHD, DateTime NgayXuat,string MaKH, string MaNV)
        {
            return HoaDon.HoaDon_Insert(MaHD, NgayXuat, MaKH, MaNV);
        }

        public int HoaDon_Update(string MaHD, DateTime NgayXuat, string MaKH, string MaNV)
        {
            return HoaDon.HoaDon_Update(MaHD, NgayXuat, MaKH, MaNV);
        }

        public int HoaDon_Delete(string MaHD)
        {
            return HoaDon.HoaDon_Delete(MaHD);
        }
        public DataTable xuathoadon(string MaHD)
        {
            return HoaDon.xuathoadon(MaHD);
        }
        public DataTable thongkedoanhthu()
        {
            return HoaDon.thongkedoanhthu();
        }

    }
}
