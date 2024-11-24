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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void DanhSachLopHoc()
        {
            DataTable dt = new DataTable();
            dt = LopDAO.ThongTinLopHoc();
            dgdanhsachlop.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DanhSachLopHoc();
        }

        private void dgdanhsachlop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmalop.Text = dgdanhsachlop.CurrentRow.Cells[0].Value.ToString();
            txttenlop.Text = dgdanhsachlop.CurrentRow.Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LopDTO lop = new LopDTO();
            lop.malop = txtmalop.Text;
            lop.tenlop = txttenlop.Text;
            LopBUS.ThemLopHoc(lop);
            DanhSachLopHoc();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LopDTO lop = new LopDTO();
            lop.malop = txtmalop.Text;
            LopBUS.XoaLopHoc(lop);
            DanhSachLopHoc();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LopDTO lop = new LopDTO();
            lop.malop = txtmalop.Text;
            lop.tenlop = txttenlop.Text;
            LopBUS.CapNhatLopHoc(lop);
            DanhSachLopHoc();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát lớp học không ?","Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (kq == DialogResult.Yes)
                {
                    this.Close();
                }
        }
    }
}
