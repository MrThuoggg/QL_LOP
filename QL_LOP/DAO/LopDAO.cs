using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QL_LOP.DTO;
namespace QL_LOP.DAO
{
    internal class LopDAO
    {
        public static DataTable ThongTinLopHoc()
        {
            string sql = "select * from LOP";
            DataTable dt = new DataTable();
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static void ThemLopHoc(LopDTO lop)
        {
            string sql = "INSERT INTO LOP(MaLop, TenLop) VALUES ('"+lop.malop+"', '"+lop.tenlop+"')";
            KetNoiCSDL.ThucThiTruyVan(sql);
        }
        public static void XoaLopHoc(LopDTO lop)
        {
            string sql = "DELETE FROM LOP WHERE MaLop='" + lop.malop + "'";
            KetNoiCSDL.ThucThiTruyVan(sql);
        }
        public static void CapNhatLopHoc(LopDTO lop)
        {
            string sql = "UPDATE LOP SET TenLop =N'" + lop.tenlop + "' WHERE MaLop ='" + lop.malop + "'";
            KetNoiCSDL.ThucThiTruyVan(sql);
        }
    }
}
