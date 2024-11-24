using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using QL_LOP.DTO;

namespace QL_LOP.DAO
{
    internal class SinhVienDAO
    {
        public static DataTable ThongTinSinhVien()
        {
            string sql = "select * from SinhVien";
            DataTable dt = new DataTable();
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable ThongTinLopHoc()
        {
            string sql = "select * from LOP";
            DataTable dt = new DataTable();
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable MaSVLonNhat()
        {
            string sql = "select MaSV from SINHVIEN order by MaSV desc limit 1";
            DataTable dt = new DataTable();
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static void ThemSinhVien(SinhVienDTO sv)
        {
            string sql = "INSERT INTO SINHVIEN(MaSV, HoTen, Phai, NgaySinh, NoiSinh, MaLop) VALUES ('"+sv.masv+"', '"+sv.hoten+"', '"+sv.phai+"', '"+sv.ngaysinh+"', '"+sv.noisinh+"', '"+sv.malop+"')";
            KetNoiCSDL.ThucThiTruyVan(sql);
        }
        public static void CapNhatSinhVien(SinhVienDTO sv)
        {
            string sql = "UPDATE SinhVien set Hoten='"+sv.hoten+"', Phai = '"+sv.phai+"', NgaySinh = '"+sv.ngaysinh+"', NoiSinh= '"+sv.noisinh+"', MaLop = '"+sv.malop+"' where MaSV = '"+sv.masv+"'";
            KetNoiCSDL.ThucThiTruyVan(sql);
        }
        public static void XoaSinhVien(SinhVienDTO sv)
        {
            string sql = "Delete from SinhVien where MaSV = '" + sv.masv + "'";
            KetNoiCSDL.ThucThiTruyVan(sql);
        }
    }
}
