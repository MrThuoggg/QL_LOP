using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_LOP.DAO;
using QL_LOP.DTO;
using System.Windows.Forms;
namespace QL_LOP.BUS
{
    internal class SinhVienBUS
    {
        public static void ThemSinhVien(SinhVienDTO sv)
        {
            try
            {
                SinhVienDAO.ThemSinhVien(sv);
            }
            catch (Exception)
            {
                MessageBox.Show("Them sinh vien khong thanh cong!");
            }
        }
        public static void CapNhatSinhVien(SinhVienDTO sv)
        {
            try
            {
                SinhVienDAO.CapNhatSinhVien(sv);
            }
            catch (Exception)
            {
                MessageBox.Show("Cap nhat sinh vien khong thanh cong!");
            }
        }
        public static void XoaSinhVien(SinhVienDTO sv)
        {
            try
            {
                SinhVienDAO.XoaSinhVien(sv);
            }
            catch (Exception)
            {
                MessageBox.Show("Xoa sinh vien khong thanh cong!");
            }
        }
    }
}
