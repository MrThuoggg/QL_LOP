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
    internal class LopBUS
    {
        public static void ThemLopHoc(LopDTO lop)
        {
            try
            {
                LopDAO.ThemLopHoc(lop);
            }
            catch (Exception)
            {
                MessageBox.Show("Them lop khong thanh cong!");
            }
        }
        public static void XoaLopHoc(LopDTO lop)
        {
            try
            {
                LopDAO.XoaLopHoc(lop);
            }
            catch (Exception)
            {
                MessageBox.Show("Xoa lop khong thanh cong!");
            }
        }
        public static void CapNhatLopHoc(LopDTO lop)
        {
            try
            {
                LopDAO.CapNhatLopHoc(lop);
            }
            catch (Exception)
            {
                MessageBox.Show("Cap nhat lop khong thanh cong!");
            }
        }
    }
}
