using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLL_LoaiHang
    {
        DAL_LoaiHang LoaiHang = new DAL_LoaiHang();

        // Method to select all records from the LOAIHANG table
        public DataTable LoaiHang_Select()
        {
            return LoaiHang.LoaiHang_Select();
        }

        // Method to select a specific record from the LOAIHANG table based on MaLH
        public DataTable LoaiHang_Select_Where(string MaLH)
        {
            return LoaiHang.LoaiHang_Select_Where(MaLH);
        }

        // Method to insert a new record into the LOAIHANG table
        public int LoaiHang_Insert(string MaLH, string TenLoaiHang, string Mota)
        {
            return LoaiHang.LoaiHang_Insert(MaLH, TenLoaiHang, Mota);
        }

        // Method to update an existing record in the LOAIHANG table
        public int LoaiHang_Update(string MaLH, string TenLoaiHang, string Mota)
        {
            return LoaiHang.LoaiHang_Update(MaLH, TenLoaiHang, Mota);
        }

        // Method to delete a record from the LOAIHANG table based on MaLH
        public int LoaiHang_Delete(string MaLH)
        {
            return LoaiHang.LoaiHang_Delete(MaLH);
        }
    }
}