using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class BLL_ChiTietHoaDon
    {
        DAL_ChiTietHoaDon ChiTietHoaDon = new DAL_ChiTietHoaDon();

        public DataTable ChiTietHoaDon_Select()
        {
            return ChiTietHoaDon.ChiTietHoaDon_Select();
        }

        public DataTable ChiTietHoaDon_Select_Where(string MaHD)
        {
            return ChiTietHoaDon.ChiTietHoaDon_Select_Where(MaHD);
        }

        public int ChiTietHoaDon_Insert(string MaHD, string MaSP, int SLMua)
        {
            return ChiTietHoaDon.ChiTietHoaDon_Insert(MaHD, MaSP, SLMua);
        }

        public int ChiTietHoaDon_Update(string MaHD, string MaSP, int SLMua)
        {
            return ChiTietHoaDon.ChiTietHoaDon_Update(MaHD, MaSP, SLMua);
        }

        public int ChiTietHoaDon_Delete(string MaHD)
        {
            return ChiTietHoaDon.ChiTietHoaDon_Delete(MaHD);
        }
    }
}

