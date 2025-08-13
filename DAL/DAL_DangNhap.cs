using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_DangNhap
    { 
    ThaoTac_CSDL ThaoTac = new ThaoTac_CSDL();
    string[] name;
    object[] value;
    public DataTable DangNhap(string TenTK, string MatKhau)
    {
        name = new string[2];
        value = new object[2];
        name[0] = "@TenTK";
        value[0] = TenTK;
        name[1] = "@MatKhau";
        value[1] = MatKhau;
        return ThaoTac.SQL_LayDuLieu_CoDK("SP_DangNhap", name, value, 2);
    }
    public DataTable DangNhap_SelectAll()
    {
        return ThaoTac.SQL_LayDuLieu("SP_DangNhap_SelectAll");
    }

    public DataTable DangNhap_SelectWhere(string TenTK)
    {
        name = new string[1];
        value = new object[1];
        name[0] = "@TenTK";
        value[0] = TenTK;
        return ThaoTac.SQL_LayDuLieu_CoDK("SP_DangNhap_SelectWhere", name, value, 1);
    }

    public int DangNhap_Insert(string TenTK, string MatKhau, int Quyen, string GhiChu)
    {
        name = new string[4];
        value = new object[4];
        name[0] = "@TenTK";
        value[0] = TenTK;
        name[1] = "@MatKhau";
        value[1] = MatKhau;
        name[2] = "@Quyen";
        value[2] = Quyen;
        name[3] = "@GhiChu";
        value[3] = GhiChu;
        return ThaoTac.SQL_ThucHien("SP_DangNhap_Insert", name, value, 4);
    }

    public int DangNhap_Update(string TenTK, string MatKhau, int Quyen, string GhiChu)
    {
        name = new string[4];
        value = new object[4];
        name[0] = "@TenTK";
        value[0] = TenTK;
        name[1] = "@MatKhau";
        value[1] = MatKhau;
        name[2] = "@Quyen";
        value[2] = Quyen;
        name[3] = "@GhiChu";
        value[3] = GhiChu;
        return ThaoTac.SQL_ThucHien("SP_DangNhap_Update", name, value, 4);
    }

    public int DangNhap_Delete(string TenTK)
    {
        name = new string[1];
        value = new object[1];
        name[0] = "@TenTK";
        value[0] = TenTK;
        return ThaoTac.SQL_ThucHien("SP_DangNhap_Delete", name, value, 1);
    }
}
}
