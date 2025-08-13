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
    public class BLL_HangHoa
    {
        DAL_HangHoa HangHoa = new DAL_HangHoa();
        public DataTable HangHoa_Select()
        {
            return HangHoa.HangHoa_Select();
        }
        public DataTable loaihang()
        {
            return HangHoa.Loaihang();
        }
        public DataTable HangHoa_Select_Where(string kitu)
        {
            return HangHoa.HangHoa_Select_Where(kitu);
        }
        public int HangHoa_Insert(string MaSP, string TenSanPham, float DonGia, int SLTon, string DonViTinh, string MaLH)
        {
            return HangHoa.HangHoa_Insert(MaSP, TenSanPham, DonGia, SLTon, DonViTinh, MaLH);
        }
        public int HangHoa_Update(string MaSP, string TenSanPham, float DonGia, int SLTon, string DonViTinh, string MaLH)
        {
            return HangHoa.HangHoa_Update(MaSP, TenSanPham, DonGia, SLTon, DonViTinh, MaLH);
        }
        public int HangHoa_Delete(string MaSP)
        {
            return HangHoa.HangHoa_Delete(MaSP);
        }
        public DataTable HangHoa_thongke()
        {
            return HangHoa.HangHoa_Thongke();
        }
        public DataTable HangHoa_Select_Wherecbb(string kitu)
        {
            return HangHoa.HangHoa_Select_Wherecbb(kitu);
        }
    }
}
