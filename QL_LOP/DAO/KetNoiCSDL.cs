using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace QL_LOP.DAO
{
    internal class KetNoiCSDL
    {
        private static MySqlConnection cnn = new MySqlConnection();
        public static void MoKetNoi()
        {
            try
            {
                string sqlcon = @"Server=localhost;Database=QLSVLOP1;Uid=root;Pwd=123456789;";
                cnn.ConnectionString = sqlcon;
                if(cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
            }catch (Exception)
            {
                MessageBox.Show("Ket noi khong thanh cong");
            }
        }
        public static void DongKetNoi()
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
        }
        public static DataTable DocDuLieu(string sql)
        {
            MoKetNoi();
            MySqlCommand cd = new MySqlCommand(sql, cnn);
            MySqlDataReader dr = cd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            DongKetNoi();
            return dt;
        }
        public static void ThucThiTruyVan(string sql)
        {
            MoKetNoi();
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            DongKetNoi();
        }
    }
}
