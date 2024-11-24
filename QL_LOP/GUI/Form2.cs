using QL_LOP.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_LOP.DAO;
using QL_LOP.DTO;
using QL_LOP.BUS;
namespace QL_LOP.GUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //Ghi chú GitHub thay đổi
        public void DanhSachSinhVien()
        {
            DataTable dt = new DataTable();
            dt = SinhVienDAO.ThongTinSinhVien();
            dgdanhsachsinhvien.DataSource = dt;
        }
        public void DanhSachLop()
        {
            DataTable dt = new DataTable();
            dt = LopDAO.ThongTinLopHoc();
            cblophoc.DataSource = dt;
            cblophoc.ValueMember = "MaLop";
            cblophoc.DisplayMember = "TenLop";

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            DanhSachSinhVien();
            DanhSachLop();
        }

        private void dgdanhsachsinhvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbmasv.Text = dgdanhsachsinhvien.CurrentRow.Cells[0].Value.ToString();
            tbhoten.Text = dgdanhsachsinhvien.CurrentRow.Cells[1].Value.ToString();
            if (dgdanhsachsinhvien.CurrentRow.Cells[2].Value.ToString() == "True")
            {
                rdnam.Checked = true;
            }
            else
            {
                rdnu.Checked = true;
            }
            dtngaysinh.Text = dgdanhsachsinhvien.CurrentRow.Cells[3].Value.ToString();
            tbnoisinh.Text = dgdanhsachsinhvien.CurrentRow.Cells[4].Value.ToString();
            cblophoc.SelectedValue = dgdanhsachsinhvien.CurrentRow.Cells[5].Value.ToString();
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = SinhVienDAO.MaSVLonNhat();
            string masv = dt.Rows[0][0].ToString();
            tbmasv.Text = "022101" + (int.Parse(masv.Substring(6, masv.Length - 6)) + 1).ToString("000");
        }

        private void btghi_Click(object sender, EventArgs e)
        {
            SinhVienDTO sv = new SinhVienDTO();
            sv.masv = tbmasv.Text;
            sv.hoten = tbhoten.Text;
            sv.ngaysinh = dtngaysinh.Value.ToString("yyyy/MM/dd");
            if (rdnam.Checked == true)
            {
                sv.phai = "1";
            }
            else
            {
                sv.phai = "0";
            }
            sv.noisinh = tbnoisinh.Text;
            sv.malop = cblophoc.SelectedValue.ToString();
            SinhVienBUS.ThemSinhVien(sv);
            DanhSachSinhVien();
        }

        private void btcapnhat_Click(object sender, EventArgs e)
        {
            SinhVienDTO sv = new SinhVienDTO();
            sv.masv = tbmasv.Text;
            sv.hoten = tbhoten.Text;
            sv.ngaysinh = dtngaysinh.Value.ToString("yyyy/MM/dd");
            if (rdnam.Checked == true)
            {
                sv.phai = "1";
            }
            else
            {
                sv.phai = "0";
            }
            sv.noisinh = tbnoisinh.Text;
            sv.malop = cblophoc.SelectedValue.ToString();
            SinhVienBUS.CapNhatSinhVien(sv);
            DanhSachSinhVien();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            SinhVienDTO sv = new SinhVienDTO();
            sv.masv = tbmasv.Text;
            SinhVienBUS.XoaSinhVien(sv);
            DanhSachSinhVien();
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát chương trình", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void rdnu_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
