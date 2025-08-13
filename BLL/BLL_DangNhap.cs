using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_DangNhap
    {
        DAL_DangNhap DANG_NHAP = new DAL_DangNhap();
        public DataTable DangNhap(string TenTK, string MatKhau)
        {
            return DANG_NHAP.DangNhap(TenTK, MatKhau);
        }
    }
}
