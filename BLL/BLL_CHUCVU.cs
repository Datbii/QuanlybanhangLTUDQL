using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class BLL_ChucVu
    {
        DAL_ChucVu ChucVu = new DAL_ChucVu();

        public DataTable ChucVu_Select()
        {
            return ChucVu.ChucVu_Select();
        }

        public DataTable ChucVu_Select_Where(string MaChucVu)
        {
            return ChucVu.ChucVu_Select_Where(MaChucVu);
        }

        public int ChucVu_Insert(string MaChucVu, string TenChucVu)
        {
            return ChucVu.ChucVu_Insert(MaChucVu, TenChucVu);
        }

        public int ChucVu_Update(string MaChucVu, string TenChucVu)
        {
            return ChucVu.ChucVu_Update(MaChucVu, TenChucVu);
        }

        public int ChucVu_Delete(string MaChucVu)
        {
            return ChucVu.ChucVu_Delete(MaChucVu);
        }
    }
}
