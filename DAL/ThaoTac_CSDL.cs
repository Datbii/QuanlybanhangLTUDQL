using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThaoTac_CSDL
    {
        SqlConnection cn;
        SqlDataAdapter da;
        DataTable dt;
        string constr = "Data Source=DESKTOP-CDO0SQ2;Initial Catalog=\"QUAN LY CUA HANG TIEN LOI\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        string SQL;
        private void KetNoi()
        {
            cn = new SqlConnection(constr);
            cn.Open();
        }
        private void NgatKetNoi()
        {
            cn.Close();
            cn.Dispose();
        }
        public DataTable SQL_LayDuLieu(string TenSP)//dùng cho select 
        {
            KetNoi();
            SqlCommand cmd = new SqlCommand(TenSP, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            NgatKetNoi();
            return dt;
        }
        public int SQL_ThucHien(string TenSP, string[] name, object[] value, int NPara)//dùng cho thêm sửa xóa
        //TenSP: Tên Procedure,
        //name:mảng chứa tên thuộc tính nằm trong procedure,
        //value: mảng chứa các giá trị trong procedure,
        //NPara: số tham số của store procedure
        {
            KetNoi();
            SqlCommand cmd = new SqlCommand(TenSP, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < NPara; i++)
            {
                cmd.Parameters.AddWithValue(name[i], value[i]);

            }
            return cmd.ExecuteNonQuery();
        }
        public DataTable SQL_LayDuLieu_CoDK(string TenSP, string[] name, object[] value, int NPara) //Dùng cho select where
        {
            KetNoi();
            SqlCommand cmd = new SqlCommand(TenSP, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < NPara; i++) //Thêm tham số vào sp
            {
                cmd.Parameters.AddWithValue(name[i], value[i]);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd); // Lấy dl về
            DataTable dt = new DataTable(); //Đưa dl vào bảng dt
            da.Fill(dt);
            NgatKetNoi();
            return dt;
        }

    }
}
