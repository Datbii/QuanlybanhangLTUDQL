using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAL_HangHoa
    {
        ThaoTac_CSDL ThaoTac = new ThaoTac_CSDL();
        string[] name;
        object[] value;
        public DataTable HangHoa_Select()
        {
            return ThaoTac.SQL_LayDuLieu("SP_SANPHAM_SelectAll");

        }
        public DataTable Loaihang()
        {
            return ThaoTac.SQL_LayDuLieu("SP_LOAIHANG_SelectAll");
        }
        public DataTable HangHoa_Select_Where(string kitu)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@Kitu";
            value[0] = kitu;
            return ThaoTac.SQL_LayDuLieu_CoDK("SearchProducts", name, value, 1);
        }
        public int HangHoa_Insert(string MaSP,string TenSanPham,float DonGia,int SLTon,string DonViTinh,string MaLH)
        {
            name = new string[6];
            value = new object[6];
            name[0] = "@MaSP";
            value[0] = MaSP;

            name[1] = "@TenSanPham";
            value[1] = TenSanPham;

            name[2] = "@DonGia";
            value[2] = DonGia;

            name[3] = "@SLTon";
            value[3] = SLTon;

            name[4] = "@DonViTinh";
            value[4] = DonViTinh;

        

            name[5] = "@MaLH";
            value[5] = MaLH;
            return ThaoTac.SQL_ThucHien("SP_SANPHAM_Insert",name,value,6);
        }
        public int HangHoa_Update(string MaSP, string TenSanPham, float DonGia, int SLTon, string DonViTinh, string MaLH)
        {
            name = new string[6];
            value = new object[6];
            name[0] = "@MaSP";
            value[0] = MaSP;

            name[1] = "@TenSanPham";
            value[1] = TenSanPham;

            name[2] = "@DonGia";
            value[2] = DonGia;

            name[3] = "@SLTon";
            value[3] = SLTon;

            name[4] = "@DonViTinh";
            value[4] = DonViTinh;

          
            name[5] = "@MaLH";
            value[5] = MaLH;
            return ThaoTac.SQL_ThucHien("SP_SANPHAM_Update", name, value, 6);
        }
        public int HangHoa_Delete(string MaSP)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaSP";
            value[0] = MaSP;
            return ThaoTac.SQL_ThucHien("SP_SANPHAM_Delete", name, value, 1);
        }
        public DataTable HangHoa_Thongke()
        {
            return ThaoTac.SQL_LayDuLieu("SP_SANPHAM_Banchay");

        }
        public DataTable HangHoa_Select_Wherecbb(string kitu)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaSP";
            value[0] = kitu;
            return ThaoTac.SQL_LayDuLieu_CoDK("SP_SANPHAM_Select", name, value, 1);
        }
    }

}
